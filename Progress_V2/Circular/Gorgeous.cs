// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Gorgeous.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {
        /// <summary>
        /// The graphics
        /// </summary>
        //private Graphics graphics;

        //private float Value = 70f;
        //private float Maximum = 100f;

        //private bool EnableInnerCover = false;

        //private int ShiftOuter = 16;
        //private int ShiftInner = 26;
        //private int ShiftInnerCover = 32;
        //private int ShiftSmallRect = 180;

        //private Color[] GradientColor = new Color[]
        //{
        //    Color.FromArgb(254, 84, 84),
        //    Color.DarkSlateGray
        //};

        //private Color[] SolidColors = new Color[]
        //{
        //    Color.FromArgb(255,255,255),
        //    Color.FromArgb(37, 37, 38),
        //    Color.FromArgb(254, 84, 84),
        //    Color.FromArgb(37, 37, 38),
        //    Color.Gray
        //};

        //private int Border = 10;

        //private float StartingAngle = 270f;


        //public bool Gorgeous_showText = true;

        /// <summary>
        /// Enum Gorgeous_rotatingAngle
        /// </summary>
        public enum Gorgeous_rotatingAngle
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
        /// Enum Gorgeous_drawMode
        /// </summary>
        public enum Gorgeous_drawMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient,
            /// <summary>
            /// The hatch
            /// </summary>
            Hatch
        }



        //private Gorgeous_rotatingAngle RotatingAngle = Gorgeous_rotatingAngle.Clockwise;


        #region Public Properties
        /// <summary>
        /// Gets or sets the gorgeous draw mode.
        /// </summary>
        /// <value>The gorgeous draw mode.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public Gorgeous_drawMode GorgeousDrawMode
        {
            get { return progressInput.GorgeousDrawMode; }
            set
            {
                progressInput.GorgeousDrawMode = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the rotating angle.
        /// </summary>
        /// <value>The rotating angle.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public Gorgeous_rotatingAngle RotatingAngle
        {
            get { return progressInput.RotatingAngle; }
            set
            {
                progressInput.RotatingAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the solid colors.
        /// </summary>
        /// <value>The solid colors.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public Color[] SolidColors
        {
            get { return progressInput.SolidColors; }
            set
            {
                progressInput.SolidColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the gradient.
        /// </summary>
        /// <value>The color of the gradient.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public Color[] GradientColor
        {
            get { return progressInput.GradientColor; }
            set
            {
                progressInput.GradientColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>The border.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public int Border
        {
            get { return progressInput.Border; }
            set
            {
                progressInput.Border = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable inner cover].
        /// </summary>
        /// <value><c>true</c> if [enable inner cover]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public bool EnableInnerCover
        {
            get { return progressInput.EnableInnerCover; }
            set
            {
                progressInput.EnableInnerCover = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shift outer.
        /// </summary>
        /// <value>The shift outer.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public int ShiftOuter
        {
            get { return progressInput.ShiftOuter; }
            set
            {
                progressInput.ShiftOuter = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shift inner.
        /// </summary>
        /// <value>The shift inner.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public int ShiftInner
        {
            get { return progressInput.ShiftInner; }
            set
            {
                progressInput.ShiftInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shift inner cover.
        /// </summary>
        /// <value>The shift inner cover.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public int ShiftInnerCover
        {
            get { return progressInput.ShiftInnerCover; }
            set
            {
                progressInput.ShiftInnerCover = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shift small rect.
        /// </summary>
        /// <value>The shift small rect.</value>
        [Category("CircularProgress Gorgeous")]
        [Browsable(false)]
        public int ShiftSmallRect
        {
            get { return progressInput.ShiftSmallRect; }
            set
            {
                progressInput.ShiftSmallRect = value;
                Invalidate();
            }
        }


        //public float Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        this.Value = value;
        //        Invalidate();
        //    }
        //}

        //public float Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}


        #endregion


        #region Animation Code


        #region Event

        /// <summary>
        /// Handles the Tick event of the Gorgeous_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Gorgeous_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //} 
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
        /// Handles the Tick event of the Gorgeous_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Gorgeous_Timer_Reduced_Tick(object sender, EventArgs e)
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


        //#region Include in Private Field


        //private bool autoAnimateStatingAngle = false;
        //private System.Windows.Forms.Timer timerStartingAngle = new System.Windows.Forms.Timer();

        //#endregion

        //#region Include in Public Properties

        //public bool AnimateStartAngle
        //{
        //    get { return autoAnimateStatingAngle; }
        //    set
        //    {
        //        autoAnimateStatingAngle = value;

        //        if (value == true)
        //        {
        //            timerStartingAngle.Enabled = true;
        //        }

        //        else
        //        {
        //            timerStartingAngle.Enabled = false;
        //        }

        //        Invalidate();
        //    }
        //}

        //#endregion

        #region Event

        /// <summary>
        /// Handles the StartAngle event of the Gorgeous_Timer_Tick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Gorgeous_Timer_Tick_StartAngle(object sender, EventArgs e)
        {
            if (this.StartingAngle + 1 > 360)
            {
                this.StartingAngle = 0;
            }

            else
            {
                this.StartingAngle++;
                Invalidate();
            }
        }

        #endregion



        #endregion

        /// <summary>
        /// Gorgeouses this instance.
        /// </summary>
        public void Gorgeous()
        {
            
            #region Glow Animation

            transparencyAnimator.Control = this;
            transparencyAnimator.DurationValue = (ulong)AnimationSpeed[2];
            transparencyAnimator.Repeat = true;
            transparencyAnimator.Reverse = true;
            transparencyAnimator.OneDProperty = AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Custom;
            transparencyAnimator.StartValue = 0;
            transparencyAnimator.EndValue = 255;
            transparencyAnimator.PropertyName = "FillTransparency";
            transparencyAnimator.DurationValue = 1000;
            
            #endregion
            
            
        }


        /// <summary>
        /// Gorgeouses the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Gorgeous_Paint(PaintEventArgs e)
        {
            
            //timerStartingAngle.Interval = speed[1];
            //timer.Interval = speed[0];
            
            switch (TransparentEasing)
            {
                case transparencyEasingType.BounceEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseIn;

                    break;
                case transparencyEasingType.BounceEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseInOut;

                    break;
                case transparencyEasingType.BounceEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOut;

                    break;
                case transparencyEasingType.BounceEaseOutIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOutIn;

                    break;
                case transparencyEasingType.CircularEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

                    break;
                case transparencyEasingType.CircularEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;

                    break;
                case transparencyEasingType.CircularEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;

                    break;
                case transparencyEasingType.CubicEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;

                    break;
                case transparencyEasingType.CubicEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut;

                    break;
                case transparencyEasingType.CubicEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseOut;

                    break;
                case transparencyEasingType.ExponentialEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;

                    break;
                case transparencyEasingType.ExponentialEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;

                    break;
                case transparencyEasingType.ExponentialEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseOut;

                    break;
                case transparencyEasingType.Liner:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.Liner;

                    break;
                case transparencyEasingType.None:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.None;

                    break;
                case transparencyEasingType.QuadraticEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseIn;

                    break;
                case transparencyEasingType.QuadraticEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseInOut;

                    break;
                case transparencyEasingType.QuadraticEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseOut;

                    break;
                case transparencyEasingType.QuarticEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseIn;

                    break;
                case transparencyEasingType.QuarticEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseInOut;

                    break;
                case transparencyEasingType.QuarticEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;

                    break;
                case transparencyEasingType.QuinticEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseIn;

                    break;
                case transparencyEasingType.QuinticEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseInOut;

                    break;
                case transparencyEasingType.QuinticEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;

                    break;
                case transparencyEasingType.SinusoidalEaseIn:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseIn;

                    break;
                case transparencyEasingType.SinusoidalEaseInOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;

                    break;
                case transparencyEasingType.SinusoidalEaseOut:
                    transparencyAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseOut;

                    break;
                default:
                    break;
            }

            Graphics graphics = e.Graphics;
            //graphics.SmoothingMode = Smoothing;
            //graphics.TextRenderingHint = TextRendering;

            //graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, graphics);
            }
            //graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            //ForeColor = Color.White;
            //Font = new Font("Century Gothic", 12); 

            Rectangle region = new Rectangle(ShiftOuter/2, ShiftOuter/2, Width - ShiftOuter, Height - ShiftOuter);
            Rectangle region1 = new Rectangle(ShiftInner/2, ShiftInner/2, Width - ShiftInner, Height - ShiftInner);
            Rectangle region2 = new Rectangle(ShiftSmallRect/2, ShiftSmallRect/2, Width - ShiftSmallRect, Height - ShiftSmallRect);
            Rectangle region3 = new Rectangle(ShiftInnerCover / 2, ShiftInnerCover / 2, Width - ShiftInnerCover, Height - ShiftInnerCover);

            graphics.FillEllipse(new SolidBrush(SolidColors[0]), region);
            graphics.DrawEllipse(new Pen(SolidColors[1], Border), region);

            switch (GorgeousDrawMode)
            {
                case Gorgeous_drawMode.Solid:
                    switch (RotatingAngle)
                    {
                        case Gorgeous_rotatingAngle.Clockwise:
                            graphics.FillPie(new SolidBrush(Color.FromArgb(FillTransparency,SolidColors[2])), region1, StartingAngle, (Value / Maximum) * 360f);
                            break;
                        case Gorgeous_rotatingAngle.AntiClockwise:
                            graphics.FillPie(new SolidBrush(Color.FromArgb(FillTransparency, SolidColors[2])), region1, StartingAngle, (Value / Maximum) * -360f);
                            break;
                        default:
                            break;
                    }
                    
                    break;
                case Gorgeous_drawMode.Gradient:
                    LinearGradientBrush linbrush = new LinearGradientBrush(region1, Color.FromArgb(FillTransparency,GradientColor[0]), Color.FromArgb(FillTransparency, GradientColor[1]), 90f);

                    switch (RotatingAngle)
                    {
                        case Gorgeous_rotatingAngle.Clockwise:
                            graphics.FillPie(linbrush, region1, StartingAngle, (Value / Maximum) * 360f);

                            break;
                        case Gorgeous_rotatingAngle.AntiClockwise:
                            graphics.FillPie(linbrush, region1, StartingAngle, (Value / Maximum) * -360f);

                            break;
                        default:
                            break;
                    }
                    
                    break;
                case Gorgeous_drawMode.Hatch:

                    switch (RotatingAngle)
                    {
                        case Gorgeous_rotatingAngle.Clockwise:
                            #region HatchBrush Paint
                            switch (HatchBrush)
                            {
                                case HatchBrushType.BackwardDiagonal:
                                    HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Cross:
                                    HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB1, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DarkDownwardDiagonal:
                                    HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB2, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DarkHorizontal:
                                    HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB3, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DarkUpwardDiagonal:
                                    HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB4, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DarkVertical:
                                    HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB5, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DashedDownwardDiagonal:
                                    HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB6, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DashedHorizontal:
                                    HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB7, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DashedUpwardDiagonal:
                                    HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB8, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DashedVertical:
                                    HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB9, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DiagonalBrick:
                                    HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBA, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DiagonalCross:
                                    HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBB, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Divot:
                                    HatchBrush HBC = new HatchBrush(HatchStyle.Divot, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBC, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DottedDiamond:
                                    HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBD, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.DottedGrid:
                                    HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBE, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.ForwardDiagonal:
                                    HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBF, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Horizontal:
                                    HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBG, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.HorizontalBrick:
                                    HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBH, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LargeCheckerBoard:
                                    HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBI, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LargeConfetti:
                                    HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBJ, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LargeGrid:
                                    HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBK, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LightDownwardDiagonal:
                                    HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBL, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LightHorizontal:
                                    HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBM, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LightUpwardDiagonal:
                                    HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBN, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.LightVertical:
                                    HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBO, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Max:
                                    HatchBrush HBP = new HatchBrush(HatchStyle.Max, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBP, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Min:
                                    HatchBrush HBQ = new HatchBrush(HatchStyle.Min, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBQ, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.NarrowHorizontal:
                                    HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBR, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.NarrowVertical:
                                    HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBS, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.OutlinedDiamond:
                                    HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBT, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent05:
                                    HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBU, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent10:
                                    HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBV, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent20:
                                    HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBW, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent25:
                                    HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBX, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent30:
                                    HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBY, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent40:
                                    HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBZ, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent50:
                                    HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB10, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent60:
                                    HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB11, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent70:
                                    HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB12, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent75:
                                    HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB13, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent80:
                                    HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB14, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Percent90:
                                    HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB15, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Plaid:
                                    HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB16, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Shingle:
                                    HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB17, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.SmallCheckerBoard:
                                    HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB18, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.SmallConfetti:
                                    HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB19, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.SmallGrid:
                                    HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB20, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.SolidDiamond:
                                    HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB21, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Sphere:
                                    HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB22, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Trellis:
                                    HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB23, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Vertical:
                                    HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB24, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Wave:
                                    HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB25, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.Weave:
                                    HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB26, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.WideDownwardDiagonal:
                                    HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB27, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.WideUpwardDiagonal:
                                    HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB28, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                case HatchBrushType.ZigZag:
                                    HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB29, region1, StartingAngle, (Value / Maximum) * 360f);
                                    break;
                                default:
                                    break;
                            }
                            #endregion
                            break;
                        case Gorgeous_rotatingAngle.AntiClockwise:
                            #region HatchBrush Paint
                            switch (HatchBrush)
                            {
                                case HatchBrushType.BackwardDiagonal:
                                    HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Cross:
                                    HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB1, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DarkDownwardDiagonal:
                                    HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB2, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DarkHorizontal:
                                    HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB3, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DarkUpwardDiagonal:
                                    HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB4, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DarkVertical:
                                    HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB5, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DashedDownwardDiagonal:
                                    HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB6, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DashedHorizontal:
                                    HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB7, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DashedUpwardDiagonal:
                                    HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB8, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DashedVertical:
                                    HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB9, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DiagonalBrick:
                                    HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBA, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DiagonalCross:
                                    HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBB, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Divot:
                                    HatchBrush HBC = new HatchBrush(HatchStyle.Divot, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBC, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DottedDiamond:
                                    HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBD, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.DottedGrid:
                                    HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBE, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.ForwardDiagonal:
                                    HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBF, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Horizontal:
                                    HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBG, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.HorizontalBrick:
                                    HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBH, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LargeCheckerBoard:
                                    HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBI, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LargeConfetti:
                                    HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBJ, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LargeGrid:
                                    HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBK, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LightDownwardDiagonal:
                                    HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBL, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LightHorizontal:
                                    HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBM, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LightUpwardDiagonal:
                                    HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBN, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.LightVertical:
                                    HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBO, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Max:
                                    HatchBrush HBP = new HatchBrush(HatchStyle.Max, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBP, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Min:
                                    HatchBrush HBQ = new HatchBrush(HatchStyle.Min, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBQ, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.NarrowHorizontal:
                                    HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBR, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.NarrowVertical:
                                    HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBS, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.OutlinedDiamond:
                                    HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBT, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent05:
                                    HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBU, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent10:
                                    HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBV, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent20:
                                    HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBW, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent25:
                                    HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBX, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent30:
                                    HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBY, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent40:
                                    HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HBZ, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent50:
                                    HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB10, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent60:
                                    HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB11, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent70:
                                    HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB12, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent75:
                                    HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB13, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent80:
                                    HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB14, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Percent90:
                                    HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB15, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Plaid:
                                    HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB16, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Shingle:
                                    HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB17, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.SmallCheckerBoard:
                                    HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB18, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.SmallConfetti:
                                    HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB19, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.SmallGrid:
                                    HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB20, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.SolidDiamond:
                                    HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB21, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Sphere:
                                    HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB22, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Trellis:
                                    HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB23, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Vertical:
                                    HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB24, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Wave:
                                    HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB25, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.Weave:
                                    HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB26, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.WideDownwardDiagonal:
                                    HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB27, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.WideUpwardDiagonal:
                                    HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB28, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                case HatchBrushType.ZigZag:
                                    HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, Color.FromArgb(FillTransparency, ColorHatchBrushgradient1), Color.FromArgb(FillTransparency, ColorHatchBrushgradient2));
                                    graphics.FillPie(HB29, region1, StartingAngle, (Value / Maximum) * -360f);
                                    break;
                                default:
                                    break;
                            }
                            #endregion
                            break;
                        default:
                            break;
                    }
                    
                    break;
                default:
                    break;
            }

            if(EnableInnerCover)
            {
                graphics.FillEllipse(new SolidBrush(SolidColors[4]), region3);

            }

            graphics.FillEllipse(new SolidBrush(SolidColors[3]), region2);

            if(ShowText)
            {
                graphics.DrawString(((int)Value).ToString() + " " + PostFix, Font, new SolidBrush(ForeColor), (Width / 2) - Font.Size, (Height / 2) - Font.Size);
            }

        }
        
    }
}