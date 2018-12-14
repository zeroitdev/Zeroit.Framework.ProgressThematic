// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="IgnitoProgress.cs" company="Zeroit Dev Technologies">
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


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Enumerations

        /// <summary>
        /// Enum Ignito_drawMode
        /// </summary>
        public enum Ignito_drawMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient
        }

        /// <summary>
        /// Enum Ignito_innerRotatingAngle
        /// </summary>
        public enum Ignito_innerRotatingAngle
        {
            /// <summary>
            /// The clockwise
            /// </summary>
            Clockwise,
            /// <summary>
            /// The anti clockwise
            /// </summary>
            AntiClockwise
        }

        /// <summary>
        /// Enum Ignito_outterRotatingAngle
        /// </summary>
        public enum Ignito_outterRotatingAngle
        {
            /// <summary>
            /// The clockwise
            /// </summary>
            Clockwise,
            /// <summary>
            /// The anti clockwise
            /// </summary>
            AntiClockwise
        }

        //public enum easingType
        //{
        //    BounceEaseIn,
        //    BounceEaseInOut,
        //    BounceEaseOut,
        //    BounceEaseOutIn,
        //    CircularEaseIn,
        //    CircularEaseInOut,
        //    CircularEaseOut,
        //    CubicEaseIn,
        //    CubicEaseInOut,
        //    CubicEaseOut,
        //    ExponentialEaseIn,
        //    ExponentialEaseInOut,
        //    ExponentialEaseOut,
        //    Liner,
        //    None,
        //    QuadraticEaseIn,
        //    QuadraticEaseInOut,
        //    QuadraticEaseOut,
        //    QuarticEaseIn,
        //    QuarticEaseInOut,
        //    QuarticEaseOut,
        //    QuinticEaseIn,
        //    QuinticEaseInOut,
        //    QuinticEaseOut,
        //    SinusoidalEaseIn,
        //    SinusoidalEaseInOut,
        //    SinusoidalEaseOut
        //} 

        #endregion

        #region Private Fields


        //private bool autoIncrement = false;

        //private int[] speed = new int[]
        //{
        //    100,
        //    100,
        //    5000
        //};

        //private float value = 0;

        //private float Maximum = 100;

        //private float IG_OuterBorder = 1;

        //private float IG_InnerBorder = 1;

        //Color[] IG_Colors = new Color[]
        //{
        //    Color.Orange,
        //    Color.FromArgb(152, 212, 204),
        //    Color.Gray,
        //    Color.Black,
        //    Color.DarkSlateGray,
        //    Color.LightGray,
        //    Color.DimGray,
        //    Color.Black,
        //    Color.Green,
        //    Color.LightGray,
        //    Color.Gray,
        //    Color.LightGray,
        //};

        //private bool IG_EnableHatch = false;

        //private LineCap IG_Caps = LineCap.Round;

        //private Ignito_innerRotatingAngle IG_InnerRotatingAnlge = Ignito_innerRotatingAngle.AntiClockwise;

        //private Ignito_outterRotatingAngle IG_OutterRotatingAngle = Ignito_outterRotatingAngle.Clockwise;

        //private Ignito_drawMode IG_DrawMode = Ignito_drawMode.Solid;


        //private DashStyle IG_BorderStyleOuter = DashStyle.DashDot;

        //private DashStyle IG_BorderStyleInner = DashStyle.DashDot;




        #endregion

        #region Public Properties



        //public int[] AnimationSpeed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        for(int i = 0; i <=1; i++)
        //        if( value[0] < 1)
        //        {
        //                value[0] = 1;
        //        }

        //        if (value[1] < 1)
        //        {
        //            value[1] = 1;
        //        }

        //        speed = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the ig inner rotating anlge.
        /// </summary>
        /// <value>The ig inner rotating anlge.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public Ignito_innerRotatingAngle IG_InnerRotatingAnlge
        {
            get { return progressInput.IG_InnerRotatingAnlge; }
            set
            {
                progressInput.IG_InnerRotatingAnlge = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig outter rotating angle.
        /// </summary>
        /// <value>The ig outter rotating angle.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public Ignito_outterRotatingAngle IG_OutterRotatingAngle
        {
            get { return progressInput.IG_OutterRotatingAngle; }
            set
            {
                progressInput.IG_OutterRotatingAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig outer border.
        /// </summary>
        /// <value>The ig outer border.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public float IG_OuterBorder
        {
            get { return progressInput.IG_OuterBorder; }
            set
            {
                progressInput.IG_OuterBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig inner border.
        /// </summary>
        /// <value>The ig inner border.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public float IG_InnerBorder
        {
            get { return progressInput.IG_InnerBorder;}
            set
            {
                progressInput.IG_InnerBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig caps.
        /// </summary>
        /// <value>The ig caps.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public LineCap IG_Caps
        {
            get { return progressInput.IG_Caps; }
            set
            {
                progressInput.IG_Caps = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig border style outer.
        /// </summary>
        /// <value>The ig border style outer.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public DashStyle IG_BorderStyleOuter
        {
            get { return progressInput.IG_BorderStyleOuter; }
            set
            {
                progressInput.IG_BorderStyleOuter = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig border style inner.
        /// </summary>
        /// <value>The ig border style inner.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public DashStyle IG_BorderStyleInner
        {
            get { return progressInput.IG_BorderStyleInner; }
            set
            {
                progressInput.IG_BorderStyleInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the ig colors.
        /// </summary>
        /// <value>The ig colors.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public Color [] IG_Colors
        {
            get { return progressInput.IG_Colors; }
            set
            {
                progressInput.IG_Colors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [ig enable hatch].
        /// </summary>
        /// <value><c>true</c> if [ig enable hatch]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public bool IG_EnableHatch
        {
            get { return progressInput.IG_EnableHatch; }
            set
            {
                progressInput.IG_EnableHatch = value;
                Invalidate();
            }
        }

        //public bool AutoIncrement
        //{
        //    get { return autoIncrement; }
        //    set
        //    {

        //        if (value == true)
        //        {

        //            peaceAnimator.Start();
        //        }

        //        else
        //        {
        //            peaceAnimator.Stop();
        //        }

        //        autoIncrement = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the ig draw mode.
        /// </summary>
        /// <value>The ig draw mode.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public Ignito_drawMode IG_DrawMode
        {
            get { return progressInput.IG_DrawMode; }
            set
            {
                progressInput.IG_DrawMode = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the ig gradient colors.
        /// </summary>
        /// <value>The ig gradient colors.</value>
        [Category("CircularProgress Ignito")]
        [Browsable(false)]
        public Color[] IG_GradientColors
        {
            get { return progressInput.IG_GradientColors; }
            set
            {
                progressInput.IG_GradientColors = value;
                Invalidate();
            }
        }

        //public float Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        //public float Value
        //{
        //    get { return this.value; }
        //    set
        //    {

        //        this.value = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        #region Animation Code


        #region Event

        /// <summary>
        /// Handles the Tick event of the Ignito_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Ignito_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //    this.Value = 0;
            //else
            //    this.Value++; 
            #endregion

            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
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
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
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
        /// Handles the Tick event of the Ignito_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Ignito_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.Value < this.Minimum)
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

        #endregion


        #endregion

        #region Constructor

        /// <summary>
        /// Ignitoes the progress.
        /// </summary>
        public void IgnitoProgress()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //#region AutoAnimate
            //if (DesignMode)
            //{
            //    timer.Tick += Timer_Tick;
            //    if (AutoAnimate)
            //    {
            //        //timer.Interval = 100;
            //        timer.Start();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    timer.Tick += Timer_Tick;

            //    if (AutoAnimate)
            //    {
            //        //timer.Interval = 100;
            //        timer.Start();
            //    }
            //}



            //#endregion

            //#region AutoIncrement Animation

            //peaceAnimator.Control = this;
            //peaceAnimator.DurationValue = (ulong)speed[2];
            //peaceAnimator.Repeat = true;
            //peaceAnimator.Reverse = true;
            //peaceAnimator.OneDProperty = Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            //peaceAnimator.StartValue = 0;
            //peaceAnimator.EndValue = 100;


            //#endregion


            //#region StartingAngle Animation
            //if (DesignMode)
            //{
            //    timerStartingAngle.Tick += Timer_Tick_StartAngle;
            //    if (AnimateStartAngle)
            //    {
            //        //timerStartingAngle.Interval = 100;
            //        timerStartingAngle.Start();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    timerStartingAngle.Tick += Timer_Tick_StartAngle;

            //    if (AnimateStartAngle)
            //    {
            //        //timerStartingAngle.Interval = 100;
            //        timerStartingAngle.Start();
            //    }
            //}



            //#endregion

            
        }


        #endregion

        #region Paint Event Arguments

        /// <summary>
        /// Ignitoes the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Ignito_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;
            g.Clear(BackColor);
            
            Rectangle circRect = new Rectangle(2, 2, Width - 5, Height - 5);
            Pen outera = new Pen(IG_Colors[0], 10);
            outera.EndCap = IG_Caps;
            outera.DashStyle = IG_BorderStyleOuter;

            Pen outerb = new Pen(IG_Colors[1], 10);
            outerb.EndCap = IG_Caps;
            outerb.DashStyle = IG_BorderStyleInner;

            Pen outergradienta = new Pen(new LinearGradientBrush(new Rectangle(10, 10, Width - 20, Height - 20), IG_GradientColors[0], IG_GradientColors[1], 90f), 10);
            Pen outergradientb = new Pen(new LinearGradientBrush(new Rectangle(45, 45, Width - 90, Height - 90), IG_GradientColors[2], IG_GradientColors[3], 90f), 15);

            g.FillEllipse(new SolidBrush(IG_Colors[2]), circRect);
            g.DrawEllipse(new Pen(IG_Colors[3], IG_OuterBorder), circRect);

            
            switch (IG_DrawMode)
            {
                case Ignito_drawMode.Solid:
                    switch (IG_OutterRotatingAngle)
                    {
                        case Ignito_outterRotatingAngle.Clockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            g.DrawPie(outera, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_outterRotatingAngle.AntiClockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            g.DrawPie(outera, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    break;
                case Ignito_drawMode.Gradient:
                    switch (IG_OutterRotatingAngle)
                    {
                        case Ignito_outterRotatingAngle.Clockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            g.DrawPie(outergradienta, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_outterRotatingAngle.AntiClockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            g.DrawPie(outergradienta, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            if(IG_EnableHatch)
            {
                #region HatchBrush Paint
                switch (HatchBrush)
                {
                    case HatchBrushType.BackwardDiagonal:
                        HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Cross:
                        HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB1, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DarkDownwardDiagonal:
                        HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB2, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DarkHorizontal:
                        HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB3, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DarkUpwardDiagonal:
                        HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB4, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DarkVertical:
                        HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB5, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DashedDownwardDiagonal:
                        HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB6, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DashedHorizontal:
                        HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB7, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DashedUpwardDiagonal:
                        HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB8, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DashedVertical:
                        HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB9, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DiagonalBrick:
                        HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBA, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DiagonalCross:
                        HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBB, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Divot:
                        HatchBrush HBC = new HatchBrush(HatchStyle.Divot, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBC, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DottedDiamond:
                        HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBD, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.DottedGrid:
                        HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBE, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.ForwardDiagonal:
                        HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBF, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Horizontal:
                        HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBG, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.HorizontalBrick:
                        HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBH, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LargeCheckerBoard:
                        HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBI, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LargeConfetti:
                        HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBJ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LargeGrid:
                        HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBK, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LightDownwardDiagonal:
                        HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBL, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LightHorizontal:
                        HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBM, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LightUpwardDiagonal:
                        HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBN, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.LightVertical:
                        HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBO, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Max:
                        HatchBrush HBP = new HatchBrush(HatchStyle.Max, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBP, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Min:
                        HatchBrush HBQ = new HatchBrush(HatchStyle.Min, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBQ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.NarrowHorizontal:
                        HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBR, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.NarrowVertical:
                        HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBS, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.OutlinedDiamond:
                        HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBT, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent05:
                        HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBU, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent10:
                        HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBV, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent20:
                        HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBW, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent25:
                        HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBX, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent30:
                        HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBY, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent40:
                        HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBZ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent50:
                        HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB10, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent60:
                        HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB11, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent70:
                        HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB12, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent75:
                        HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB13, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent80:
                        HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB14, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Percent90:
                        HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB15, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Plaid:
                        HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB16, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Shingle:
                        HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB17, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.SmallCheckerBoard:
                        HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB18, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.SmallConfetti:
                        HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB19, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.SmallGrid:
                        HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB20, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.SolidDiamond:
                        HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB21, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Sphere:
                        HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB22, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Trellis:
                        HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB23, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Vertical:
                        HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB24, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Wave:
                        HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB25, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.Weave:
                        HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB26, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.WideDownwardDiagonal:
                        HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB27, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.WideUpwardDiagonal:
                        HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB28, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case HatchBrushType.ZigZag:
                        HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB29, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    default:
                        break;
                }
                #endregion
            }

            else
            {
                g.FillEllipse(new SolidBrush(IG_Colors[4]), new Rectangle(15, 15, Width - 30, Height - 30));
            }
            g.DrawEllipse(new Pen(IG_Colors[5], 3), new Rectangle(15, 15, Width - 30, Height - 30));

            g.FillEllipse(new SolidBrush(IG_Colors[6]), new Rectangle(30, 30, Width - 60, Height - 60));
            g.DrawEllipse(new Pen(IG_Colors[7], IG_InnerBorder), new Rectangle(30, 30, Width - 60, Height - 60));

            g.FillPie(new SolidBrush(IG_Colors[8]), new Rectangle(50, 50, Width - 100, Height - 100), 270f, /*(this.Value / 100)*/ -360f);

            switch (IG_DrawMode)
            {
                case Ignito_drawMode.Solid:

                    switch (IG_InnerRotatingAnlge)
                    {
                        case Ignito_innerRotatingAngle.Clockwise:
                            g.DrawPie(outerb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_innerRotatingAngle.AntiClockwise:
                            g.DrawPie(outerb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    
                    break;
                case Ignito_drawMode.Gradient:
                    switch (IG_InnerRotatingAnlge)
                    {
                        case Ignito_innerRotatingAngle.Clockwise:
                            g.DrawPie(outergradientb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_innerRotatingAngle.AntiClockwise:
                            g.DrawPie(outergradientb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    
                    break;
                default:
                    break;
            }

            g.FillPie(new SolidBrush(IG_Colors[9]), new Rectangle(50, 50, Width - 100, Height - 100), 270f, /*(this.value / 100) **/ -360f);
            g.DrawPie(new Pen(IG_Colors[10], 5), new Rectangle(55, 55, Width - 110, Height - 110), 270f, -360f);

            g.FillEllipse(new SolidBrush(IG_Colors[11]), new Rectangle(55, 55, Width - 110, Height - 110));

            //if(ShowText)
            //    g.DrawString(((int)Value).ToString() + PostFix, Font, new SolidBrush(ForeColor), (Width / 2) - Font.Size, (Height / 2) - Font.Size);


            if (ShowText)
            {
                Helper.CenterString(g, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

        }

        #endregion


    }






}
