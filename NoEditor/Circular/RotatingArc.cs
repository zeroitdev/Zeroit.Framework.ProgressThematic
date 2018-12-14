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

using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{


    #region Rotating Arc with HeartBeat


    public partial class ThematicProgress
    {

        #region Private Fields

        Graphics smallg;

        public enum RotatingArc_drawMode
        {
            Default, Custom
        }

        public enum PieArc
        {
            Pie,
            Arc
        }

        public enum shape { Pie, Arc }
        
        private float angle = 90f;
        private int interval = 10;
        private bool rotatingBorder = false;
        private PieArc pieArc = PieArc.Arc;
        private RotatingArc_drawMode RotatingArc_drawmode = RotatingArc_drawMode.Default;
        private shape _shape = shape.Arc;
        private int size = 1;
        private Color customHeartFade = SystemColors.Control;
        private Color pieColor1 = Color.Beige;
        private Color pieColor2 = Color.Blue;
        private Color lineColor1 = Color.Yellow;
        private Color lineColor2 = Color.Blue;
        private Color lineWidthColor = Color.Transparent;
        private bool fillPie = false;
        private bool drawLine = true;
        private Color colorOuterBorder = Color.Blue;
        private Color innerCircle1Grad1 = Color.Red;
        private Color innerCircle1Grad2 = Color.Green;
        private Color innerCircle2Grad1 = Color.Yellow;
        private Color innerCircle2Grad2 = Color.Blue;
        private Color innerCircle3Grad1 = Color.Brown;
        private Color innerCircle3Grad2 = Color.Gray;
        private Color innerCircle4Grad1 = Color.RosyBrown;
        private Color innerCircle4Grad2 = Color.LightBlue;
        private Color innerCircle5Grad1 = Color.Violet;
        private Color innerCircle5Grad2 = Color.LightPink;
        private Color innerCircle6Grad1 = SystemColors.Control;
        private Color innerCircle6Grad2 = SystemColors.Control;
        private bool showInnerCircle1 = true;
        private bool showInnerCircle2 = true;
        private bool showInnerCircle3 = true;
        private bool showInnerCircle4 = true;
        private bool showInnerCircle5 = true;
        private bool showInnerCircle6 = true;
        private int outerBorderWidth = 1;
        private int innercircleBorder = 10;
        private int widthReduction = 10;
        private int heightReduction = 10;
        private int innercircle2Width = 20;
        private int innercircle2Height = 20;
        private int innercircle3Width = 40;
        private int innercircle3Height = 40;
        private int innercircle4Width = 60;
        private int innercircle4Height = 60;
        private int innercircle5Width = 80;
        private int innercircle5Height = 80;
        private int innercircle6Width = 100;
        private int innercircle6Height = 100;

        int heartinterval = 100;

        private bool heartAutoAnimate = false;

        private float rotatingArc_startAngle = 180;
        private float rotatingArc_sweepAngle = 360;


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
            get { return heartinterval; }
            set
            {
                heartinterval = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool HeartBeat
        {
            get { return heartAutoAnimate; }
            set
            {
                heartAutoAnimate = value;


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
            //if (this.Angle + 1 > RotatingArc_SweepAngle)
            //{

            //    this.Angle = 0;
            //}
            //else
            //{
            //    this.Angle++;
            //    Invalidate();
            //}

            if (Value + 1 > RotatingArc_SweepAngle)
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
            if (this.Angle + 1 > RotatingArc_SweepAngle)
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






            //switch (progressType)
            //{
            //    case ProgressType.Bar:
            //        switch (solidBars)
            //        {
            //            case ProgressBar.ExtendedProgress:
            //                break;
            //            case ProgressBar.ZeroitIndicator:
            //                break;
            //            case ProgressBar.iTunes:
            //                break;
            //            case ProgressBar.Maze:
            //                break;
            //            case ProgressBar.ProgressNormal:
            //                break;
            //            case ProgressBar.ProgressBoxed:
            //                break;
            //            case ProgressBar.ProgressGradient:
            //                break;
            //            case ProgressBar.Alter:
            //                break;
            //            case ProgressBar.Clear:
            //                break;
            //            case ProgressBar.ProgressRect:
            //                break;
            //            case ProgressBar.Perplex:
            //                break;
            //            case ProgressBar.Transparent:
            //                break;
            //            case ProgressBar.Splitter:
            //                break;
            //            default:
            //                throw new ArgumentOutOfRangeException();
            //        }
            //        break;
            //    case ProgressType.Circular:
            //        switch (circularProgressType)
            //        {
            //            case CircularProgress.ZeroitProgressBarCircular:
            //                break;
            //            case CircularProgress.CircularProgressv2:
            //                break;
            //            case CircularProgress.CircularProgressv3:
            //                break;
            //            case CircularProgress.CircularProgressv4:
            //                break;
            //            case CircularProgress.CircularProgressv5:
            //                break;
            //            case CircularProgress.CircularProgressv5aClock:
            //                break;
            //            case CircularProgress.GorgeousProgress:
            //                break;
            //            case CircularProgress.Ignito:
            //                break;
            //            case CircularProgress.MulitCo:
            //                break;
            //            case CircularProgress.MultiCoExtended:
            //                break;
            //            case CircularProgress.MultiCoV1:
            //                break;
            //            case CircularProgress.Awesome:
            //                break;
            //            case CircularProgress.Perfect:
            //                break;
            //            case CircularProgress.ProgressPie:
            //                break;
            //            case CircularProgress.RotatingArc:

                            
            //                break;
            //            case CircularProgress.RotatingCompass:
            //                break;
            //            case CircularProgress.RotatingPie:
            //                break;
            //            case CircularProgress.ZeroitProgressBarCircularDefault:
            //                break;
            //            default:
            //                throw new ArgumentOutOfRangeException();
            //        }
            //        break;
            //    case ProgressType.Indicator:
            //        switch (indicatorType)
            //        {
            //            case ProgressIndicator.CircularIndeterminate:
            //                break;
            //            case ProgressIndicator.GoogleProgressIndicator:
            //                break;
            //            case ProgressIndicator.MacOSX:
            //                break;
            //            case ProgressIndicator.MacOSXOptimized:
            //                break;
            //            case ProgressIndicator.Matrix:
            //                break;
            //            case ProgressIndicator.IndicatorV1:
            //                break;
            //            case ProgressIndicator.Unique:
            //                break;
            //            default:
            //                throw new ArgumentOutOfRangeException();
            //        }
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}

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

        #region Public Properties
        [Category("CircularProgress RotatingArc")]
        public float RotatingArc_StartAngle
        {
            get { return rotatingArc_startAngle; }
            set
            {
                rotatingArc_startAngle = value;
                Invalidate();
            }
        }
        [Category("CircularProgress RotatingArc")]
        public float RotatingArc_SweepAngle
        {
            get { return rotatingArc_sweepAngle; }
            set
            {
                rotatingArc_sweepAngle = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public PieArc RotatingType
        {
            get { return pieArc; }
            set
            {
                pieArc = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color CustomFadeColor
        {
            get { return customHeartFade; }
            set
            {
                customHeartFade = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public RotatingArc_drawMode RotatingArc_DrawMode
        {
            get { return RotatingArc_drawmode; }
            set
            {
                RotatingArc_drawmode = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle1WidthReduction
        {
            get { return widthReduction; }
            set
            {
                widthReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle1HeightReduction
        {
            get { return heightReduction; }
            set
            {
                heightReduction = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowLine
        {
            get { return drawLine; }
            set
            {
                drawLine = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color LineColor1
        {
            get { return lineColor1; }
            set
            {
                lineColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int LineSize
        {
            get { return size; }
            set
            {
                size = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [Category("CircularProgress RotatingArc")]
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }
        
        [Category("CircularProgress RotatingArc")]
        public int InnerCircleBorder
        {
            get { return innercircleBorder; }
            set
            {
                innercircleBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle2WidthReduction
        {
            get { return innercircle2Width; }
            set
            {
                innercircle2Width = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle2HeightReduction
        {
            get { return innercircle2Height; }
            set
            {
                innercircle2Height = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle3WidthReduction
        {
            get { return innercircle3Width; }
            set
            {
                innercircle3Width = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle3HeightReduction
        {
            get { return innercircle3Height; }
            set
            {
                innercircle3Height = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle4WidthReduction
        {
            get { return innercircle4Width; }
            set
            {
                innercircle4Width = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle4HeightReduction
        {
            get { return innercircle4Height; }
            set
            {
                innercircle4Height = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle5WidthReduction
        {
            get { return innercircle5Width; }
            set
            {
                innercircle5Width = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle5HeightReduction
        {
            get { return innercircle5Height; }
            set
            {
                innercircle5Height = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle6WidthReduction
        {
            get { return innercircle6Width; }
            set
            {
                innercircle6Width = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int Innercircle6HeightReduction
        {
            get { return innercircle6Height; }
            set
            {
                innercircle6Height = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle1
        {
            get
            {
                return showInnerCircle1;
            }

            set
            {
                showInnerCircle1 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle2
        {
            get
            {
                return showInnerCircle2;
            }

            set
            {
                showInnerCircle2 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle3
        {
            get
            {
                return showInnerCircle3;
            }

            set
            {
                showInnerCircle3 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle4
        {
            get
            {
                return showInnerCircle4;
            }

            set
            {
                showInnerCircle4 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle5
        {
            get
            {
                return showInnerCircle5;
            }

            set
            {
                showInnerCircle5 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public bool ShowInnerCircle6
        {
            get
            {
                return showInnerCircle6;
            }

            set
            {
                showInnerCircle6 = value;
                Invalidate();
            }
        }



        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle1Grad1
        {
            get { return innerCircle1Grad1; }
            set
            {
                innerCircle1Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle1Grad2
        {
            get { return innerCircle1Grad2; }
            set
            {
                innerCircle1Grad2 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle2Grad1
        {
            get { return innerCircle2Grad1; }
            set
            {
                innerCircle2Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle2Grad2
        {
            get { return innerCircle2Grad2; }
            set
            {
                innerCircle2Grad2 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle3Grad1
        {
            get { return innerCircle3Grad1; }
            set
            {
                innerCircle3Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle3Grad2
        {
            get { return innerCircle3Grad2; }
            set
            {
                innerCircle3Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle4Grad1
        {
            get { return innerCircle4Grad1; }
            set
            {
                innerCircle4Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle4Grad2
        {
            get { return innerCircle4Grad2; }
            set
            {
                innerCircle4Grad2 = value;
                Invalidate();
            }
        }


        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle5Grad1
        {
            get { return innerCircle5Grad1; }
            set
            {
                innerCircle5Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle5Grad2
        {
            get { return innerCircle5Grad2; }
            set
            {
                innerCircle5Grad2 = value;
                Invalidate();
            }
        }

        
        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle6Grad1
        {
            get { return innerCircle6Grad1; }
            set
            {
                innerCircle6Grad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorInnerCircle6Grad2
        {
            get { return innerCircle6Grad2; }
            set
            {
                innerCircle6Grad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public Color ColorOuterBorder
        {
            get { return colorOuterBorder; }
            set
            {
                colorOuterBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress RotatingArc")]
        public int OuterBorderWidth
        {
            get { return outerBorderWidth; }
            set
            {
                outerBorderWidth = value;
                Invalidate();
            }
        }

        #endregion

        #region Overrides

        private void RotatingArc_OnSizeChanged(EventArgs e)
        {
            //if (Size.Width > 100 && Size.Width < 200 || Size.Height > 100 && Size.Height < 200)
            //{

            //    Innercircle1WidthReduction = 10 / 2;
            //    Innercircle1HeightReduction = 10 / 2;

            //    Innercircle2WidthReduction = 20 / 2;
            //    Innercircle2HeightReduction = 20 / 2;

            //    Innercircle3WidthReduction = 40 / 2;
            //    Innercircle3HeightReduction = 40 / 2;

            //    Innercircle4WidthReduction = 60 / 2;
            //    Innercircle4HeightReduction = 60 / 2;

            //    Innercircle5WidthReduction = 80 / 2;
            //    Innercircle5HeightReduction = 80 / 2;

            //    Innercircle6WidthReduction = 100 / 2;
            //    Innercircle6HeightReduction = 100 / 2;

            //}

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

            //Maximum = RotatingArc_SweepAngle;

            heartTimer.Interval = HeartTimerInterval;

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            e.Graphics.Clear(BackColor);
            
            //Text = "";

            //e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            
            switch (RotatingType)
            {
                case PieArc.Pie:

                    if (RotatingBorder)
                    {
                        e.Graphics.DrawPie(new Pen(ColorOuterBorder, OuterBorderWidth), new Rectangle(0, 0, Width - 2, Height - 2), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);

                        if (FillPie)
                        {
                            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, (Value / Maximum) * RotatingArc_SweepAngle);

                            e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        }

                    }
                    
                    #region DrawInnerCircles 

                    if (ShowInnerCircle1)
                    {
                        LinearGradientBrush innercircle1brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle1brush, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);

                    }

                    if (ShowInnerCircle2)
                    {
                        LinearGradientBrush innercircle2brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle2brush, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);

                    }

                    if (ShowInnerCircle3)
                    {
                        LinearGradientBrush innercircle3brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle3brush, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                    }


                    if (ShowInnerCircle4)
                    {
                        LinearGradientBrush innercircle4brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle4brush, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                    }

                    if (ShowInnerCircle5)
                    {

                        LinearGradientBrush innercircle5brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle5brush, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                    }

                    if (ShowInnerCircle6)
                    {
                        LinearGradientBrush innercircle6brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum) * RotatingArc_SweepAngle);

                        e.Graphics.FillPie(innercircle6brush, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                        e.Graphics.DrawPie(new Pen(Parent.BackColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), RotatingArc_StartAngle, (Value / Maximum) * RotatingArc_SweepAngle);
                    }
                    #endregion

                    break;
                case PieArc.Arc:

                    if (RotatingBorder)
                    {
                        e.Graphics.DrawPie(new Pen(ColorOuterBorder, OuterBorderWidth), new Rectangle(0, 0, Width - 2, Height - 2), RotatingArc_StartAngle, Value);

                        if (FillPie)
                        {
                            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, Value);

                            e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), RotatingArc_StartAngle, (Value/Maximum) * RotatingArc_SweepAngle);
                        }

                    }
                    
                    #region DrawInnerCircles 

                    if (ShowInnerCircle1)
                    {
                        switch (RotatingArc_DrawMode)
                        {
                            case RotatingArc_drawMode.Default:
                                LinearGradientBrush innercircle1brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle1brush, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle1brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value / Maximum * RotatingArc_SweepAngle));

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
                                LinearGradientBrush innercircle2brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle2brush, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle2brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value / Maximum * RotatingArc_SweepAngle));

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
                                LinearGradientBrush innercircle3brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle3brush, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle3brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value / Maximum * RotatingArc_SweepAngle));

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
                                LinearGradientBrush innercircle4brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle4brush, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle4brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value / Maximum * RotatingArc_SweepAngle));

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
                                LinearGradientBrush innercircle5brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle5brush, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle5brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value / Maximum * RotatingArc_SweepAngle));

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
                                LinearGradientBrush innercircle6brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle6brush, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(Parent.BackColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));

                                break;
                            case RotatingArc_drawMode.Custom:
                                LinearGradientBrush innercircle6brush1 = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value / Maximum * RotatingArc_SweepAngle));

                                e.Graphics.FillEllipse(innercircle6brush1, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));
                                e.Graphics.DrawEllipse(new Pen(CustomFadeColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))));

                                break;
                            default:
                                break;
                        }


                    }
                    #endregion

                    break;
                
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
            g.DrawString(Convert.ToInt32(Angle / RotatingArc_SweepAngle * 100).ToString(), new Font("Verdana", 30, FontStyle.Bold),
                new SolidBrush(ForeColor), 0, 10);
        }
        #endregion


    }

    #endregion


}
