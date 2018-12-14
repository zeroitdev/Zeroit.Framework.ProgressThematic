#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Data;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using Microsoft.Win32;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
//using System.Windows.Forms.VisualStyles;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region SpinnerBuzz

    #region Control

    public partial class ThematicProgress
    {

        #region Private Fields
        //private Color InactiveSegmentColour = Color.FromArgb(218, 218, 218);
        //private Color ActiveSegmentColour = Color.FromArgb(35, 146, 33);
        //private Color TransistionSegmentColour = Color.FromArgb(129, 242, 121);

        private Region innerBackgroundRegion;
        private System.Drawing.Drawing2D.GraphicsPath[] segmentPaths = new System.Drawing.Drawing2D.GraphicsPath[12];

        //private bool Automate = false;
        //private double AutoIncrementFrequency = 100;
        //private bool BehindTransistionSegmentIsActive = true;
        //private int TransistionSegment = 0;

        private System.Timers.Timer m_AutoRotateTimer = new System.Timers.Timer();

        #endregion

        #region Public Properties

        [System.ComponentModel.DefaultValue(typeof(Color), "218, 218, 218")]
        [Category("Indicator Progress - SpinnerDivided")]
        public Color InactiveSegmentColour
        {
            get
            {
                return progressInput.InactiveSegmentColour;
            }
            set
            {
                progressInput.InactiveSegmentColour = value;
                Invalidate();
            }
        }


        [System.ComponentModel.DefaultValue(typeof(Color), "35, 146, 33")]
        [Category("Indicator Progress - SpinnerDivided")]
        public Color ActiveSegmentColour
        {
            get
            {
                return progressInput.ActiveSegmentColour;
            }
            set
            {
                progressInput.ActiveSegmentColour = value;
                Invalidate();
            }
        }


        [System.ComponentModel.DefaultValue(typeof(Color), "129, 242, 121")]
        [Category("Indicator Progress - SpinnerDivided")]
        public Color TransistionSegmentColour
        {
            get
            {
                return progressInput.TransistionSegmentColour;
            }
            set
            {
                progressInput.TransistionSegmentColour = value;
                Invalidate();
            }
        }


        [System.ComponentModel.DefaultValue(true)]
        [Category("Indicator Progress - SpinnerDivided")]
        public bool BehindTransistionSegmentIsActive
        {
            get
            {
                return progressInput.BehindTransistionSegmentIsActive;
            }
            set
            {
                progressInput.BehindTransistionSegmentIsActive = value;
                Invalidate();
            }
        }


        [System.ComponentModel.DefaultValue(-1)]
        [Category("Indicator Progress - SpinnerDivided")]
        public int TransistionSegment
        {
            get
            {
                return progressInput.TransistionSegment;
            }
            set
            {
                if (value > 11 || value < -1)
                {
                    throw new ArgumentException("TransistionSegment must be between -1 and 11");
                }
                progressInput.TransistionSegment = value;
                Invalidate();
            }
        }

        [System.ComponentModel.DefaultValue(true)]
        [Category("Indicator Progress - SpinnerDivided")]
        public bool Automate
        {
            get
            {
                return progressInput.Automate;
            }
            set
            {
                progressInput.Automate = value;

                if (value == false && m_AutoRotateTimer != null)
                {
                    m_AutoRotateTimer.Dispose();
                    m_AutoRotateTimer = null;
                }

                if (value == true && m_AutoRotateTimer == null)
                {
                    m_AutoRotateTimer = new System.Timers.Timer(AutoIncrementFrequency);
                    m_AutoRotateTimer.Elapsed += new System.Timers.ElapsedEventHandler(IncrementTransisionSegment);
                    m_AutoRotateTimer.Start();
                }
            }
        }

        [System.ComponentModel.DefaultValue(100)]
        [Category("Indicator Progress - SpinnerDivided")]
        public double AutoIncrementFrequency
        {
            get
            {
                return progressInput.AutoIncrementFrequency;
            }
            set
            {
                progressInput.AutoIncrementFrequency = value;

                m_AutoRotateTimer.Interval = value;

                if (m_AutoRotateTimer != null)
                {
                    Automate = false;
                    Automate = true;
                }
            }
        }


        #endregion
        
        
        public void SpinningProgress()
        {
            //  This call is required by the Windows Form Designer.
            //InitializeComponent();

            //  Add any initialization after the InitializeComponent() call.
            CalculateSegments();

            //m_AutoRotateTimer = new System.Timers.Timer();
            m_AutoRotateTimer.Elapsed += new System.Timers.ElapsedEventHandler(IncrementTransisionSegment);
            //this.DoubleBuffered = true;
            //m_AutoRotateTimer.Start();

            //this.EnabledChanged += new EventHandler(SpinningProgress_EnabledChanged);
            // events handled by ProgressDisk_Paint
            //this.Paint += new PaintEventHandler(ProgressDisk_Paint);
            // events handled by ProgressDisk_Resize
            //this.Resize += new EventHandler(ProgressDisk_Resize);
            // events handled by ProgressDisk_SizeChanged
            //this.SizeChanged += new EventHandler(ProgressDisk_SizeChanged);
        }

        private void IncrementTransisionSegment(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (TransistionSegment == 11)
            {
                TransistionSegment = 0;
                BehindTransistionSegmentIsActive = !(BehindTransistionSegmentIsActive);
            }
            else  if (TransistionSegment == -1)
            {
                TransistionSegment = 0;
            }
            else
            {
                TransistionSegment += 1;
            }

            Invalidate();
        }


        private void CalculateSegments()
        {
            Rectangle rctFull = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rctInner = new Rectangle(((this.Width * 7) / 30),
                                                ((this.Height * 7) / 30),
                                                (this.Width - ((this.Width * 14) / 30)),
                                                (this.Height - ((this.Height * 14) / 30)));

            
            System.Drawing.Drawing2D.GraphicsPath pthInnerBackground = null;

            
            // Create 12 segment pieces
            for (int intCount = 0; intCount < 12; intCount++)
            {
                segmentPaths[intCount] = new System.Drawing.Drawing2D.GraphicsPath();

                // We subtract 90 so that the starting segment is at 12 o'clock
                segmentPaths[intCount].AddPie(rctFull, (intCount * 30) - 90, 25);
            }

            // Create the center circle cut-out
            pthInnerBackground = new System.Drawing.Drawing2D.GraphicsPath();
            pthInnerBackground.AddPie(rctInner, 0, 360);
            
            innerBackgroundRegion = new Region(pthInnerBackground);

            //graph.FillRegion(new SolidBrush(BackColor), innerBackgroundRegion);

        }


        private void SpinningProgress_EnabledChanged( System.EventArgs e)
        {
            if (Enabled == true)
            {
                if (m_AutoRotateTimer != null)
                {
                    m_AutoRotateTimer.Start();
                }
            }
            else
            {
                if (m_AutoRotateTimer != null)
                {
                    m_AutoRotateTimer.Stop();
                }
            }
        }

        
        private void ProgressDisk_Paint(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.Clear(BackColor);
            e.Graphics.ExcludeClip(innerBackgroundRegion);
            

            for (int intCount = 0; intCount < 12; intCount++)
            {
                if (this.Enabled)
                {
                    if (intCount == TransistionSegment)
                    {
                        // If this segment is the transistion segment, colour it differently
                        e.Graphics.FillPath(new SolidBrush(TransistionSegmentColour), segmentPaths[intCount]);
                    }
                    else if (intCount < TransistionSegment)
                    {
                        // This segment is behind the transistion segment
                        if (BehindTransistionSegmentIsActive)
                        {
                            // If behind the transistion should be active, 
                            // colour it with the active colour
                            e.Graphics.FillPath(new SolidBrush(ActiveSegmentColour), segmentPaths[intCount]);
                        }
                        else
                        {
                            // If behind the transistion should be in-active, 
                            // colour it with the in-active colour
                            e.Graphics.FillPath(new SolidBrush(InactiveSegmentColour), segmentPaths[intCount]);
                        }
                    }
                    else
                    {
                        // This segment is ahead of the transistion segment
                        if (BehindTransistionSegmentIsActive)
                        {
                            // If behind the the transistion should be active, 
                            // colour it with the in-active colour
                            e.Graphics.FillPath(new SolidBrush(InactiveSegmentColour), segmentPaths[intCount]);
                        }
                        else
                        {
                            // If behind the the transistion should be in-active, 
                            // colour it with the active colour
                            e.Graphics.FillPath(new SolidBrush(ActiveSegmentColour), segmentPaths[intCount]);
                        }
                    }
                }
                else
                {
                    // Draw all segments in in-active colour if not enabled
                    e.Graphics.FillPath(new SolidBrush(InactiveSegmentColour), segmentPaths[intCount]);
                }
            }
        }


        private void ProgressDisk_Resize(System.EventArgs e)
        {
            CalculateSegments();
        }


        private void ProgressDisk_SizeChanged(System.EventArgs e)
        {
            CalculateSegments();
        }

    }


    #endregion

    

    #endregion
}
