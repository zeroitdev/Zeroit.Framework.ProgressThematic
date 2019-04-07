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


    #region Rotating Arc with HeartBeat


    public partial class ThematicProgress
    {

        #region Private Fields
        //private float Angle = 90f;
        //private float pieSweepAngle = 0f;
        //private int interval = 10;
        //private bool RotatingBorder = false;

        public enum RotatingArc_drawMode
        {
            Default, Custom
        }

        public enum PieArc
        {
            Pie,
            Arc
        }

        //private PieArc RotatingType = PieArc.Arc;

        //private RotatingArc_drawMode RotatingArc_DrawMode = RotatingArc_drawMode.Default;
        public enum shape { Pie, Arc }
        private shape _shape = shape.Arc;
        //private int LineSize = 1;
        //private Color CustomFadeColor = SystemColors.Control;
        //private Color PieColor1 = Color.Beige;
        //private Color PieColor2 = Color.Blue;
        //private Color LineColor1 = Color.Yellow;
        //private Color LineColor2 = Color.Blue;
        //private Color lineWidthColor = Color.Transparent;
        //private bool FillPie = false;
        //private bool ShowLine = true;

        Graphics smallg;

        //private Color ColorOuterBorder = Color.Blue;
        //private Color ColorInnerCircle1Grad1 = Color.Red;
        //private Color ColorInnerCircle1Grad2 = Color.Green;
        //private Color ColorInnerCircle2Grad1 = Color.Yellow;
        //private Color ColorInnerCircle2Grad2 = Color.Blue;
        //private Color ColorInnerCircle3Grad1 = Color.Brown;
        //private Color ColorInnerCircle3Grad2 = Color.Gray;
        //private Color ColorInnerCircle4Grad1 = Color.RosyBrown;
        //private Color ColorInnerCircle4Grad2 = Color.LightBlue;
        //private Color ColorInnerCircle5Grad1 = Color.Violet;
        //private Color ColorInnerCircle5Grad2 = Color.LightPink;
        //private Color ColorInnerCircle6Grad1 = SystemColors.Control;
        //private Color ColorInnerCircle6Grad2 = SystemColors.Control;
        //private bool ShowInnerCircle1 = true;
        //private bool ShowInnerCircle2 = true;
        //private bool ShowInnerCircle3 = true;
        //private bool ShowInnerCircle4 = true;
        //private bool ShowInnerCircle5 = true;
        //private bool ShowInnerCircle6 = true;
        //private int OuterBorderWidth = 1;
        //private int InnerCircleBorder = 10;
        //private int Innercircle1WidthReduction = 10;
        //private int Innercircle1HeightReduction = 10;
        //private int Innercircle2WidthReduction = 20;
        //private int Innercircle2HeightReduction = 20;
        //private int Innercircle3WidthReduction = 40;
        //private int Innercircle3HeightReduction = 40;
        //private int Innercircle4WidthReduction = 60;
        //private int Innercircle4HeightReduction = 60;
        //private int Innercircle5WidthReduction = 80;
        //private int Innercircle5HeightReduction = 80;
        //private int Innercircle6WidthReduction = 100;
        //private int Innercircle6HeightReduction = 100;


        #endregion

        #region Public Properties
        public Color LineWidthColor
        {
            get
            {
                return progressInput.LineWidthColor;
            }
            set
            {
                progressInput.LineWidthColor = value;
            }
        }

        [Category("CircularProgress RotatingArc")]
        public PieArc RotatingType
        {
            get { return progressInput.RotatingType; }
            set
            {
                progressInput.RotatingType = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color CustomFadeColor
        {
            get { return progressInput.CustomFadeColor; }
            set
            {
                progressInput.CustomFadeColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public RotatingArc_drawMode RotatingArc_DrawMode
        {
            get { return progressInput.RotatingArc_DrawMode; }
            set
            {
                progressInput.RotatingArc_DrawMode = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle1WidthReduction
        {
            get { return progressInput.Innercircle1WidthReduction; }
            set
            {
                progressInput.Innercircle1WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle1HeightReduction
        {
            get { return progressInput.Innercircle1HeightReduction; }
            set
            {
                progressInput.Innercircle1HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowLine
        {
            get { return progressInput.ShowLine; }
            set
            {
                progressInput.ShowLine = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color PieColor1
        {
            get { return progressInput.PieColor1; }
            set
            {
                progressInput.PieColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color PieColor2
        {
            get { return progressInput.PieColor2; }
            set
            {
                progressInput.PieColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color LineColor1
        {
            get { return progressInput.LineColor1; }
            set
            {
                progressInput.LineColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color LineColor2
        {
            get { return progressInput.LineColor2; }
            set
            {
                progressInput.LineColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool FillPie
        {
            get { return progressInput.FillPie; }
            set
            {
                progressInput.FillPie = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int LineSize
        {
            get { return progressInput.LineSize; }
            set
            {
                progressInput.LineSize = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool RotatingBorder
        {
            get { return progressInput.RotatingBorder; }
            set
            {
                progressInput.RotatingBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [Category("CircularProgress RotatingArc")]
        public float Angle
        {
            get { return progressInput.Angle; }
            set
            {
                progressInput.Angle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int InnerCircleBorder
        {
            get { return progressInput.InnerCircleBorder; }
            set
            {
                progressInput.InnerCircleBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle2WidthReduction
        {
            get { return progressInput.Innercircle2WidthReduction; }
            set
            {
                progressInput.Innercircle2WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle2HeightReduction
        {
            get { return progressInput.Innercircle2HeightReduction; }
            set
            {
                progressInput.Innercircle2HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle3WidthReduction
        {
            get { return progressInput.Innercircle3WidthReduction; }
            set
            {
                progressInput.Innercircle3WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle3HeightReduction
        {
            get { return progressInput.Innercircle3HeightReduction; }
            set
            {
                progressInput.Innercircle3HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle4WidthReduction
        {
            get { return progressInput.Innercircle4WidthReduction; }
            set
            {
                progressInput.Innercircle4WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle4HeightReduction
        {
            get { return progressInput.Innercircle4HeightReduction; }
            set
            {
                progressInput.Innercircle4HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle5WidthReduction
        {
            get { return progressInput.Innercircle5WidthReduction; }
            set
            {
                progressInput.Innercircle5WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle5HeightReduction
        {
            get { return progressInput.Innercircle5HeightReduction; }
            set
            {
                progressInput.Innercircle5HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle6WidthReduction
        {
            get { return progressInput.Innercircle6WidthReduction; }
            set
            {
                progressInput.Innercircle6WidthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle6HeightReduction
        {
            get { return progressInput.Innercircle6HeightReduction; }
            set
            {
                progressInput.Innercircle6HeightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle1
        {
            get
            {
                return progressInput.ShowInnerCircle1;
            }

            set
            {
                progressInput.ShowInnerCircle1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle1Grad1
        {
            get { return progressInput.ColorInnerCircle1Grad1; }
            set
            {
                progressInput.ColorInnerCircle1Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle1Grad2
        {
            get { return progressInput.ColorInnerCircle1Grad2; }
            set
            {
                progressInput.ColorInnerCircle1Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle2
        {
            get
            {
                return progressInput.ShowInnerCircle2;
            }

            set
            {
                progressInput.ShowInnerCircle2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle2Grad1
        {
            get { return progressInput.ColorInnerCircle2Grad1; }
            set
            {
                progressInput.ColorInnerCircle2Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle2Grad2
        {
            get { return progressInput.ColorInnerCircle2Grad2; }
            set
            {
                progressInput.ColorInnerCircle2Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle3
        {
            get
            {
                return progressInput.ShowInnerCircle3;
            }

            set
            {
                progressInput.ShowInnerCircle3 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle3Grad1
        {
            get { return progressInput.ColorInnerCircle3Grad1; }
            set
            {
                progressInput.ColorInnerCircle3Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle3Grad2
        {
            get { return progressInput.ColorInnerCircle3Grad2; }
            set
            {
                progressInput.ColorInnerCircle3Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle4
        {
            get
            {
                return progressInput.ShowInnerCircle4;
            }

            set
            {
                progressInput.ShowInnerCircle4 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle4Grad1
        {
            get { return progressInput.ColorInnerCircle4Grad1; }
            set
            {
                progressInput.ColorInnerCircle4Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle4Grad2
        {
            get { return progressInput.ColorInnerCircle4Grad2; }
            set
            {
                progressInput.ColorInnerCircle4Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle5
        {
            get
            {
                return progressInput.ShowInnerCircle5;
            }

            set
            {
                progressInput.ShowInnerCircle5 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle5Grad1
        {
            get { return progressInput.ColorInnerCircle5Grad1; }
            set
            {
                progressInput.ColorInnerCircle5Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle5Grad2
        {
            get { return progressInput.ColorInnerCircle5Grad2; }
            set
            {
                progressInput.ColorInnerCircle5Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle6
        {
            get
            {
                return progressInput.ShowInnerCircle6;
            }

            set
            {
                progressInput.ShowInnerCircle6 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle6Grad1
        {
            get { return progressInput.ColorInnerCircle6Grad1; }
            set
            {
                progressInput.ColorInnerCircle6Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle6Grad2
        {
            get { return progressInput.ColorInnerCircle6Grad2; }
            set
            {
                progressInput.ColorInnerCircle6Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorOuterBorder
        {
            get { return progressInput.ColorOuterBorder; }
            set
            {
                progressInput.ColorOuterBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int OuterBorderWidth
        {
            get { return progressInput.OuterBorderWidth; }
            set
            {
                progressInput.OuterBorderWidth = value;
                Invalidate();
            }
        }

        #endregion

        #region Timer Utility

        #region Include in Private Field


        //int HeartTimerInterval = 100;
        private System.Windows.Forms.Timer heartTimer = new System.Windows.Forms.Timer();
        //private bool HeartBeat = false;

        #endregion

        #region Include in Public Properties


        [Category("CircularProgress RotatingArc")]
        public int HeartTimerInterval
        {
            get { return progressInput.HeartTimerInterval; }
            set
            {
                progressInput.HeartTimerInterval = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool HeartBeat
        {
            get { return progressInput.HeartBeat; }
            set
            {
                progressInput.HeartBeat = value;


                #region Old Code
                if (value == true)
                {
                    heartTimer.Enabled = true;
                    //heartTimer.Start();
                }

                else
                {
                    heartTimer.Enabled = false;
                    //heartTimer.Stop();
                }
                #endregion


                //Invalidate();
            }
        }

        #endregion

        #region Event

        private void RotatingArc_Timer_Tick(object sender, EventArgs e)
        {
            //if (this.Angle + 1 > 360)
            //{

            //    this.Angle = 0;
            //}
            //else
            //{
            //    this.Angle++;
            //    Invalidate();
            //}

            if (Value + 1 > 360)
            {

                this.Value = 0;
            }
            else
            {
                this.Value++;
                Invalidate();
            }

            
        }

        private void RotatingArcAngle_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Angle + 1 > 360)
            {

                this.Angle = 0;
            }
            else
            {
                this.Angle++;
                Invalidate();
            }

            

        }
        
        private void RotatingArc_HeartBeatTimer_Tick(object sender, EventArgs e)
        {

            if (InnerCircleBorder + 1 > 10)
            {

                this.InnerCircleBorder = 1;
            }
            else
            {
                this.InnerCircleBorder++;
                Invalidate();
            }
            

        }

        #endregion

        #endregion

        #region Constructor

        public void RotatingArc()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);


            #region AutoAnimate
            if (DesignMode)
            {
                heartTimer.Tick += RotatingArc_HeartBeatTimer_Tick;
                if (HeartBeat)
                {
                    //timer.Interval = 100;
                    heartTimer.Start();
                }
            }

            if (!DesignMode)
            {
                heartTimer.Tick += RotatingArc_HeartBeatTimer_Tick;

                if (HeartBeat)
                {
                    //timer.Interval = 100;
                    heartTimer.Start();
                }
            }



            #endregion

            //if (AutoAnimate)
            //{

            //    timer.Start();

            //}

            //if (HeartBeat)
            //{

            //    heartTimer.Start();

            //}


            //timer.Tick += RotatingArc_Timer_Tick;

            //heartTimer.Tick += RotatingArc_HeartBeatTimer_Tick;

        }

        #endregion

        

        #region Overrides

        private void RotatingArc_OnSizeChanged(EventArgs e)
        {
            if (Size.Width > 100 && Size.Width < 200 || Size.Height > 100 && Size.Height < 200)
            {

                Innercircle1WidthReduction = 10 / 2;
                Innercircle1HeightReduction = 10 / 2;

                Innercircle2WidthReduction = 20 / 2;
                Innercircle2HeightReduction = 20 / 2;

                Innercircle3WidthReduction = 40 / 2;
                Innercircle3HeightReduction = 40 / 2;

                Innercircle4WidthReduction = 60 / 2;
                Innercircle4HeightReduction = 60 / 2;

                Innercircle5WidthReduction = 80 / 2;
                Innercircle5HeightReduction = 80 / 2;

                Innercircle6WidthReduction = 100 / 2;
                Innercircle6HeightReduction = 100 / 2;

            }

            RotatingArc_SetNewSize();

        }

        private void RotatingArc_SetNewSize()
        {
            if (FixedSize)
            {
                int LineSize = Math.Max(Width, Height);
                Size = new Size(LineSize, LineSize);
            }
            
        }

        private void RotatingArc_OnPaint(PaintEventArgs e)
        {
            //timer.Interval = interval;

            //Maximum = 360;

            heartTimer.Interval = HeartTimerInterval;

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.Clear(BackColor);

            

            //Text = "";

            //e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            
            

            switch (RotatingType)
            {
                case PieArc.Pie:

                    if (RotatingBorder)
                    {
                        e.Graphics.DrawPie(new Pen(ColorOuterBorder, OuterBorderWidth), new Rectangle(0, 0, Width - 2, Height - 2), 180, (Value / Maximum) * 360);

                        if (FillPie)
                        {
                            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, (Value / Maximum) * 360);

                            e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), 180, (Value / Maximum) * 360);
                        }

                    }


                    #region DrawInnerCircles 

                    if (ShowInnerCircle1)
                    {
                        LinearGradientBrush innercircle1brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle1brush, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), 180, (Value / Maximum) * 360);

                    }

                    if (ShowInnerCircle2)
                    {
                        LinearGradientBrush innercircle2brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle2brush, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), 180, (Value / Maximum) * 360);

                    }

                    if (ShowInnerCircle3)
                    {
                        LinearGradientBrush innercircle3brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle3brush, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), 180, (Value / Maximum) * 360);
                    }


                    if (ShowInnerCircle4)
                    {
                        LinearGradientBrush innercircle4brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle4brush, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), 180, (Value / Maximum) * 360);
                    }

                    if (ShowInnerCircle5)
                    {

                        LinearGradientBrush innercircle5brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle5brush, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), 180, (Value / Maximum) * 360);
                    }

                    if (ShowInnerCircle6)
                    {
                        LinearGradientBrush innercircle6brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum) * 360);

                        e.Graphics.FillPie(innercircle6brush, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), 180, (Value / Maximum) * 360);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), 180, (Value / Maximum) * 360);
                    }
                    #endregion
                    break;
                case PieArc.Arc:

                    if (RotatingBorder)
                    {
                        e.Graphics.DrawPie(new Pen(ColorOuterBorder, OuterBorderWidth), new Rectangle(0, 0, Width - 2, Height - 2), 180, Value);

                        if (FillPie)
                        {
                            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, Value);

                            e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), 180, Value);
                        }

                    }


                    #region DrawInnerCircles 

                    if (ShowInnerCircle1)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle1brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle1brush, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle1brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle1brush1, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));

                                break;
                            default:
                                break;
                        }

                    }

                    if (ShowInnerCircle2)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle2brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle2brush, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle2brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle2brush1, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));

                                break;
                            default:
                                break;
                        }

                    }

                    if (ShowInnerCircle3)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle3brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle3brush, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle3brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle3brush1, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));

                                break;
                            default:
                                break;
                        }


                    }


                    if (ShowInnerCircle4)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle4brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle4brush, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle4brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle4brush1, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));

                                break;
                            default:
                                break;
                        }



                    }

                    if (ShowInnerCircle5)
                    {

                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle5brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle5brush, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle5brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle5brush1, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));

                                break;
                            default:
                                break;
                        }




                    }

                    if (ShowInnerCircle6)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle6brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle6brush, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle6brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum * 360));

                                e.Graphics.FillEllipse(innercircle6brush1, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));

                                break;
                            default:
                                break;
                        }


                    }
                    #endregion

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value / Maximum * 100).ToString() + PostFix, Font, ForeColor, this.ClientRectangle);

            }

        }

        #endregion

        #region Private Methods
        private void DrawText(Graphics g)
        {
            g.DrawString(Convert.ToInt32(Angle / 360 * 100).ToString(), new Font("Verdana", 30, FontStyle.Bold),
                new SolidBrush(ForeColor), 0, 10);
        }
        #endregion


    }

    #endregion


}
