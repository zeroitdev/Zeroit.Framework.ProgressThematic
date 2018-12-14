// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingArc.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{


    #region Rotating Arc with HeartBeat


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //private float Angle = 90f;
        //private float pieSweepAngle = 0f;
        /// <summary>
        /// The interval
        /// </summary>
        private int interval = 10;
        //private bool RotatingBorder = false;

        /// <summary>
        /// Enum RotatingArc_drawMode
        /// </summary>
        public enum RotatingArc_drawMode
        {
            /// <summary>
            /// The default
            /// </summary>
            /// <summary>
            /// The custom
            /// </summary>
            Default, Custom
        }

        /// <summary>
        /// Enum PieArc
        /// </summary>
        public enum PieArc
        {
            /// <summary>
            /// The pie
            /// </summary>
            Pie,
            /// <summary>
            /// The arc
            /// </summary>
            Arc
        }

        //private PieArc RotatingType = PieArc.Arc;

        //private RotatingArc_drawMode RotatingArc_DrawMode = RotatingArc_drawMode.Default;
        /// <summary>
        /// Enum shape
        /// </summary>
        public enum shape { Pie, Arc }
        //private shape _shape = shape.Arc;
        //private int LineSize = 1;

        //private Color CustomFadeColor = SystemColors.Control;

        //private Color PieColor1 = Color.Beige;
        //private Color PieColor2 = Color.Blue;

        //private Color LineColor1 = Color.Yellow;
        //private Color LineColor2 = Color.Blue;

        //private Color lineWidthColor = Color.Transparent;

        //private bool FillPie = false;
        //private bool ShowLine = true;



        /// <summary>
        /// The smallg
        /// </summary>
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

        #region Timer Utility

        #region Include in Private Field


        //int HeartTimerInterval = 100;
        /// <summary>
        /// The heart timer
        /// </summary>
        private System.Windows.Forms.Timer heartTimer = new System.Windows.Forms.Timer();
        //private bool HeartBeat = false;

        #endregion

        #region Include in Public Properties


        /// <summary>
        /// Gets or sets the heart timer interval.
        /// </summary>
        /// <value>The heart timer interval.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int HeartTimerInterval
        {
            get { return progressInput.HeartTimerInterval; }
            set
            {
                progressInput.HeartTimerInterval = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [heart beat].
        /// </summary>
        /// <value><c>true</c> if [heart beat]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Handles the Tick event of the RotatingArc_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RotatingArc_Timer_Tick(object sender, EventArgs e)
        {
            
            #region Old Code
            //if (Value + 1 > RotatingArc_SweepAngle)
            //{

            //    this.Value = 0;
            //}
            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //} /**/
            #endregion

            
            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.RotatingArc_SweepAngle)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Value + (Change * SpeedMultiplier) > this.RotatingArc_SweepAngle)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }


        }


        /// <summary>
        /// Handles the Tick event of the RotatingArc_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RotatingArc_Timer_Reduced_Tick(object sender, EventArgs e)
        {

            if (this.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Value -= (Change * SpeedMultiplier);
                Invalidate();
            }

        }


        /// <summary>
        /// Handles the Tick event of the RotatingArcAngle_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Tick event of the RotatingArc_HeartBeatTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Rotatings the arc.
        /// </summary>
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
        /// <summary>
        /// Gets or sets the rotating arc start angle.
        /// </summary>
        /// <value>The rotating arc start angle.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public float RotatingArc_StartAngle
        {
            get { return progressInput.RotatingArc_StartAngle; }
            set
            {
                progressInput.RotatingArc_StartAngle = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the rotating arc sweep angle.
        /// </summary>
        /// <value>The rotating arc sweep angle.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public float RotatingArc_SweepAngle
        {
            get { return progressInput.RotatingArc_SweepAngle; }
            set
            {
                progressInput.RotatingArc_SweepAngle = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the type of the rotating.
        /// </summary>
        /// <value>The type of the rotating.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public PieArc RotatingType
        {
            get { return progressInput.RotatingType; }
            set
            {
                progressInput.RotatingType = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom fade.
        /// </summary>
        /// <value>The color of the custom fade.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color CustomFadeColor
        {
            get { return progressInput.CustomFadeColor; }
            set
            {
                progressInput.CustomFadeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotating arc draw mode.
        /// </summary>
        /// <value>The rotating arc draw mode.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public RotatingArc_drawMode RotatingArc_DrawMode
        {
            get { return progressInput.RotatingArc_DrawMode; }
            set
            {
                progressInput.RotatingArc_DrawMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle1 width reduction.
        /// </summary>
        /// <value>The innercircle1 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle1WidthReduction
        {
            get { return progressInput.Innercircle1WidthReduction; }
            set
            {
                progressInput.Innercircle1WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle1 height reduction.
        /// </summary>
        /// <value>The innercircle1 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle1HeightReduction
        {
            get { return progressInput.Innercircle1HeightReduction; }
            set
            {
                progressInput.Innercircle1HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show line].
        /// </summary>
        /// <value><c>true</c> if [show line]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public bool ShowLine
        {
            get { return progressInput.ShowLine; }
            set
            {
                progressInput.ShowLine = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the pie color1.
        /// </summary>
        /// <value>The pie color1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color PieColor1
        {
            get { return progressInput.PieColor1; }
            set
            {
                progressInput.PieColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the pie color2.
        /// </summary>
        /// <value>The pie color2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color PieColor2
        {
            get { return progressInput.PieColor2; }
            set
            {
                progressInput.PieColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the line color1.
        /// </summary>
        /// <value>The line color1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color LineColor1
        {
            get { return progressInput.LineColor1; }
            set
            {
                progressInput.LineColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the line color2.
        /// </summary>
        /// <value>The line color2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color LineColor2
        {
            get { return progressInput.LineColor2; }
            set
            {
                progressInput.LineColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [fill pie].
        /// </summary>
        /// <value><c>true</c> if [fill pie]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public bool FillPie
        {
            get { return progressInput.FillPie; }
            set
            {
                progressInput.FillPie = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the line.
        /// </summary>
        /// <value>The size of the line.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int LineSize
        {
            get { return progressInput.LineSize; }
            set
            {
                progressInput.LineSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating border].
        /// </summary>
        /// <value><c>true</c> if [rotating border]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public bool RotatingBorder
        {
            get { return progressInput.RotatingBorder; }
            set
            {
                progressInput.RotatingBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the angle.
        /// </summary>
        /// <value>The angle.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public float Angle
        {
            get { return progressInput.Angle; }
            set
            {
                progressInput.Angle = value;
                //Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the inner circle border.
        /// </summary>
        /// <value>The inner circle border.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int InnerCircleBorder
        {
            get { return progressInput.InnerCircleBorder; }
            set
            {
                progressInput.InnerCircleBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle2 width reduction.
        /// </summary>
        /// <value>The innercircle2 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle2WidthReduction
        {
            get { return progressInput.Innercircle2WidthReduction; }
            set
            {
                progressInput.Innercircle2WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle2 height reduction.
        /// </summary>
        /// <value>The innercircle2 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle2HeightReduction
        {
            get { return progressInput.Innercircle2HeightReduction; }
            set
            {
                progressInput.Innercircle2HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle3 width reduction.
        /// </summary>
        /// <value>The innercircle3 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle3WidthReduction
        {
            get { return progressInput.Innercircle3WidthReduction; }
            set
            {
                progressInput.Innercircle3WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle3 height reduction.
        /// </summary>
        /// <value>The innercircle3 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle3HeightReduction
        {
            get { return progressInput.Innercircle3HeightReduction; }
            set
            {
                progressInput.Innercircle3HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle4 width reduction.
        /// </summary>
        /// <value>The innercircle4 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle4WidthReduction
        {
            get { return progressInput.Innercircle4WidthReduction; }
            set
            {
                progressInput.Innercircle4WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle4 height reduction.
        /// </summary>
        /// <value>The innercircle4 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle4HeightReduction
        {
            get { return progressInput.Innercircle4HeightReduction; }
            set
            {
                progressInput.Innercircle4HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle5 width reduction.
        /// </summary>
        /// <value>The innercircle5 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle5WidthReduction
        {
            get { return progressInput.Innercircle5WidthReduction; }
            set
            {
                progressInput.Innercircle5WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle5 height reduction.
        /// </summary>
        /// <value>The innercircle5 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle5HeightReduction
        {
            get { return progressInput.Innercircle5HeightReduction; }
            set
            {
                progressInput.Innercircle5HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle6 width reduction.
        /// </summary>
        /// <value>The innercircle6 width reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle6WidthReduction
        {
            get { return progressInput.Innercircle6WidthReduction; }
            set
            {
                progressInput.Innercircle6WidthReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the innercircle6 height reduction.
        /// </summary>
        /// <value>The innercircle6 height reduction.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public int Innercircle6HeightReduction
        {
            get { return progressInput.Innercircle6HeightReduction; }
            set
            {
                progressInput.Innercircle6HeightReduction = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle1].
        /// </summary>
        /// <value><c>true</c> if [show inner circle1]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle1 grad1.
        /// </summary>
        /// <value>The color inner circle1 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle1Grad1
        {
            get { return progressInput.ColorInnerCircle1Grad1; }
            set
            {
                progressInput.ColorInnerCircle1Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle1 grad2.
        /// </summary>
        /// <value>The color inner circle1 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle1Grad2
        {
            get { return progressInput.ColorInnerCircle1Grad2; }
            set
            {
                progressInput.ColorInnerCircle1Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle2].
        /// </summary>
        /// <value><c>true</c> if [show inner circle2]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle2 grad1.
        /// </summary>
        /// <value>The color inner circle2 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle2Grad1
        {
            get { return progressInput.ColorInnerCircle2Grad1; }
            set
            {
                progressInput.ColorInnerCircle2Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle2 grad2.
        /// </summary>
        /// <value>The color inner circle2 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle2Grad2
        {
            get { return progressInput.ColorInnerCircle2Grad2; }
            set
            {
                progressInput.ColorInnerCircle2Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle3].
        /// </summary>
        /// <value><c>true</c> if [show inner circle3]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle3 grad1.
        /// </summary>
        /// <value>The color inner circle3 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle3Grad1
        {
            get { return progressInput.ColorInnerCircle3Grad1; }
            set
            {
                progressInput.ColorInnerCircle3Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle3 grad2.
        /// </summary>
        /// <value>The color inner circle3 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle3Grad2
        {
            get { return progressInput.ColorInnerCircle3Grad2; }
            set
            {
                progressInput.ColorInnerCircle3Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle4].
        /// </summary>
        /// <value><c>true</c> if [show inner circle4]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle4 grad1.
        /// </summary>
        /// <value>The color inner circle4 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle4Grad1
        {
            get { return progressInput.ColorInnerCircle4Grad1; }
            set
            {
                progressInput.ColorInnerCircle4Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle4 grad2.
        /// </summary>
        /// <value>The color inner circle4 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle4Grad2
        {
            get { return progressInput.ColorInnerCircle4Grad2; }
            set
            {
                progressInput.ColorInnerCircle4Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle5].
        /// </summary>
        /// <value><c>true</c> if [show inner circle5]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle5 grad1.
        /// </summary>
        /// <value>The color inner circle5 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle5Grad1
        {
            get { return progressInput.ColorInnerCircle5Grad1; }
            set
            {
                progressInput.ColorInnerCircle5Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle5 grad2.
        /// </summary>
        /// <value>The color inner circle5 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle5Grad2
        {
            get { return progressInput.ColorInnerCircle5Grad2; }
            set
            {
                progressInput.ColorInnerCircle5Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle6].
        /// </summary>
        /// <value><c>true</c> if [show inner circle6]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the color inner circle6 grad1.
        /// </summary>
        /// <value>The color inner circle6 grad1.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle6Grad1
        {
            get { return progressInput.ColorInnerCircle6Grad1; }
            set
            {
                progressInput.ColorInnerCircle6Grad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle6 grad2.
        /// </summary>
        /// <value>The color inner circle6 grad2.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorInnerCircle6Grad2
        {
            get { return progressInput.ColorInnerCircle6Grad2; }
            set
            {
                progressInput.ColorInnerCircle6Grad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color outer border.
        /// </summary>
        /// <value>The color outer border.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
        public Color ColorOuterBorder
        {
            get { return progressInput.ColorOuterBorder; }
            set
            {
                progressInput.ColorOuterBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the outer border.
        /// </summary>
        /// <value>The width of the outer border.</value>
        [Category("CircularProgress RotatingArc")]
        [Browsable(false)]
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

        #region Overrides

        /// <summary>
        /// Rotatings the arc on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Rotatings the new size of the arc set.
        /// </summary>
        private void RotatingArc_SetNewSize()
        {
            if (FixedSize)
            {
                int LineSize = System.Math.Max(Width, Height);
                Size = new Size(LineSize, LineSize);
            }
            
        }

        /// <summary>
        /// Rotatings the arc on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void RotatingArc_OnPaint(PaintEventArgs e)
        {
            //timer.Interval = interval;

            //Maximum = RotatingArc_SweepAngle;

            heartTimer.Interval = HeartTimerInterval;

            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

            //e.Graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

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
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="g">The g.</param>
        private void DrawText(Graphics g)
        {
            g.DrawString(Convert.ToInt32(Angle / RotatingArc_SweepAngle * 100).ToString(), new Font("Verdana", 30, FontStyle.Bold),
                new SolidBrush(ForeColor), 0, 10);
        }
        #endregion


    }

    #endregion


}
