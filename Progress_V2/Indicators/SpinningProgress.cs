// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SpinningProgress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region SpinnerBuzz


    #region Control

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //private Color InactiveSegmentColour = Color.FromArgb(218, 218, 218);
        //private Color ActiveSegmentColour = Color.FromArgb(35, 146, 33);
        //private Color TransistionSegmentColour = Color.FromArgb(129, 242, 121);

        /// <summary>
        /// The inner background region
        /// </summary>
        private Region innerBackgroundRegion;
        /// <summary>
        /// The segment paths
        /// </summary>
        private System.Drawing.Drawing2D.GraphicsPath[] segmentPaths = new System.Drawing.Drawing2D.GraphicsPath[12];

        //private bool Automate = false;
        //private double AutoIncrementFrequency = 100;
        //private bool BehindTransistionSegmentIsActive = true;
        //private int TransistionSegment = 0;

        /// <summary>
        /// The m automatic rotate timer
        /// </summary>
        private System.Timers.Timer m_AutoRotateTimer;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the inactive segment colour.
        /// </summary>
        /// <value>The inactive segment colour.</value>
        [System.ComponentModel.DefaultValue(typeof(Color), "218, 218, 218")]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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


        /// <summary>
        /// Gets or sets the active segment colour.
        /// </summary>
        /// <value>The active segment colour.</value>
        [System.ComponentModel.DefaultValue(typeof(Color), "35, 146, 33")]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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


        /// <summary>
        /// Gets or sets the transistion segment colour.
        /// </summary>
        /// <value>The transistion segment colour.</value>
        [System.ComponentModel.DefaultValue(typeof(Color), "129, 242, 121")]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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


        /// <summary>
        /// Gets or sets a value indicating whether [behind transistion segment is active].
        /// </summary>
        /// <value><c>true</c> if [behind transistion segment is active]; otherwise, <c>false</c>.</value>
        [System.ComponentModel.DefaultValue(true)]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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


        /// <summary>
        /// Gets or sets the transistion segment.
        /// </summary>
        /// <value>The transistion segment.</value>
        /// <exception cref="ArgumentException">TransistionSegment must be between -1 and 11</exception>
        [System.ComponentModel.DefaultValue(-1)]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitThematicProgress"/> is automate.
        /// </summary>
        /// <value><c>true</c> if automate; otherwise, <c>false</c>.</value>
        [System.ComponentModel.DefaultValue(true)]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
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
                    m_AutoRotateTimer = new System.Timers.Timer(/*AutoIncrementFrequency*/ AnimationSpeed[0]);
                    m_AutoRotateTimer.Elapsed += new System.Timers.ElapsedEventHandler(IncrementTransisionSegment);
                    m_AutoRotateTimer.Start();
                }
            }
        }

        /// <summary>
        /// Gets or sets the automatic increment frequency.
        /// </summary>
        /// <value>The automatic increment frequency.</value>
        [System.ComponentModel.DefaultValue(100)]
        [Category("Indicator Progress SpinnerDivided")]
        [Browsable(false)]
        public double AutoIncrementFrequency
        {
            get
            {
                return progressInput.AutoIncrementFrequency;
            }
            set
            {
                progressInput.AutoIncrementFrequency = value;

                if (m_AutoRotateTimer != null)
                {
                    Automate = false;
                    Automate = true;
                }
            }
        }


        #endregion


        /// <summary>
        /// Spinnings the progress.
        /// </summary>
        private void SpinningProgress()
        {
            //  This call is required by the Windows Form Designer.
            //InitializeComponent();

            //  Add any initialization after the InitializeComponent() call.
            CalculateSegments();

            m_AutoRotateTimer = new System.Timers.Timer(AutoIncrementFrequency);
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

        /// <summary>
        /// Increments the transision segment.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Timers.ElapsedEventArgs"/> instance containing the event data.</param>
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


        /// <summary>
        /// Calculates the segments.
        /// </summary>
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


        /// <summary>
        /// Spinnings the progress enabled changed.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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


        /// <summary>
        /// Progresses the disk paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressDisk_Paint(System.Windows.Forms.PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

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


        /// <summary>
        /// Progresses the disk resize.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ProgressDisk_Resize(System.EventArgs e)
        {
            CalculateSegments();
        }


        /// <summary>
        /// Progresses the disk size changed.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ProgressDisk_SizeChanged(System.EventArgs e)
        {
            CalculateSegments();
        }

    }


    #endregion

    

    #endregion
}
