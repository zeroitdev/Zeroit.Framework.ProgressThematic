// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ThematicProgress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Zeroit.Framework.ProgressThematic.FormEditors;
using Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation;
//using Zeroit.Framework.ProgressThematic;

namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    [Designer(typeof(ZeroitThematicProgressDesigner))]
    public partial class ZeroitThematicProgress : Control
    {

        #region Construtor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitThematicProgress"/> class.
        /// </summary>
        public ZeroitThematicProgress()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor,
                true);


            ProgressAwesome_animator = DesignMode ? null : new Animator();

            Font = new Font("Century Gothic", 12);

            #region AutoIncrement Animation

            if (!DesignMode)
            {
                peaceAnimator.Control = this;
                peaceAnimator.DurationValue = (ulong)AnimationSpeed[2];
                peaceAnimator.Repeat = true;
                peaceAnimator.Reverse = true;
                peaceAnimator.OneDProperty = AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value;
                peaceAnimator.StartValue = 0;
                peaceAnimator.EndValue = Maximum;
                peaceAnimator.PropertyName = "Value";

            }

            if (DesignMode)
            {
                peaceAnimator.Control = this;
                peaceAnimator.DurationValue = (ulong)AnimationSpeed[2];
                peaceAnimator.Repeat = true;
                peaceAnimator.Reverse = true;
                peaceAnimator.OneDProperty = AnimationHelpers.WinFormAnimation.Animator.KnownProperties.Value;
                peaceAnimator.StartValue = 0;
                peaceAnimator.EndValue = Maximum;
                peaceAnimator.PropertyName = "Value";
            }


            #endregion

            #region AutoAnimate

            IncludeInConstructor();

            #endregion

            #region StartingAngle Animation
            if (DesignMode)
            {
                timerStartingAngle.Tick += Timer_Tick_StartAngle;
                if (AnimateStartAngle)
                {
                    //timerStartingAngle.Interval = 100;
                    timerStartingAngle.Start();
                }
            }

            if (!DesignMode)
            {
                timerStartingAngle.Tick += Timer_Tick_StartAngle;

                if (AnimateStartAngle)
                {
                    //timerStartingAngle.Interval = 100;
                    timerStartingAngle.Start();
                }
            }



            #endregion

            #region CircularProgress Indeterminate

            Init();



            #endregion

            CircularProgressBarv5();

            ZeroitExtendedProgressBar();

            ZeroitGoogleProgressIndicator();

            Gorgeous();

            ZeroitIndicator();

            ZeroitProgressITunesBar();

            ZeroitMacOSX();

            ZeroitMacOSXMatrix();

            ZeroitMacOSXOptimized();

            ZeroitAmazingProgressBar();

            ZeroitProgressBarNormal();

            ZeroitProgressBarBoxed();

            ZeroitProgressBarNormalGradient();

            ZeroitProgressBarAwesome();

            ZeroitProgressIndicatorV1();

            //ZeroitProgressSplitter();

            RotatingArc();

            ZeroitProgressIndicatorSpinner();

            SpinningProgress();

            //SupremeCircularProgress();

            ZeroitWin8MarqueeHorizontal();

            ZeroitWin8ProgressRing();

            ZeroitDaggerCircular();

            ZeroitDaggerCircularV2();

            ZeroitDaggerCircularSmooth();

        }

        #endregion

        #region Private Fields


        /// <summary>
        /// The peace animator
        /// </summary>
        PeaceAnimator peaceAnimator = new PeaceAnimator();


        /// <summary>
        /// The transparency animator
        /// </summary>
        PeaceAnimator transparencyAnimator = new PeaceAnimator();



        /// <summary>
        /// The progress input
        /// </summary>
        private ProgressInput progressInput = new ProgressInput(
            Supreme_colorMode.Solid, SystemColors.HotTrack,
            Color.LightGray, SystemColors.Control, new Color[] { Color.Orange,
                Color.DarkSlateGray}, LinearGradientMode.BackwardDiagonal,
            -90f, 10, 20);

        #region HatchBrush


        /// <summary>
        /// Enum HatchBrushType
        /// </summary>
        public enum HatchBrushType
        {
            /// <summary>
            /// The backward diagonal
            /// </summary>
            BackwardDiagonal,
            /// <summary>
            /// The cross
            /// </summary>
            Cross,
            /// <summary>
            /// The dark downward diagonal
            /// </summary>
            DarkDownwardDiagonal,
            /// <summary>
            /// The dark horizontal
            /// </summary>
            DarkHorizontal,
            /// <summary>
            /// The dark upward diagonal
            /// </summary>
            DarkUpwardDiagonal,
            /// <summary>
            /// The dark vertical
            /// </summary>
            DarkVertical,
            /// <summary>
            /// The dashed downward diagonal
            /// </summary>
            DashedDownwardDiagonal,
            /// <summary>
            /// The dashed horizontal
            /// </summary>
            DashedHorizontal,
            /// <summary>
            /// The dashed upward diagonal
            /// </summary>
            DashedUpwardDiagonal,
            /// <summary>
            /// The dashed vertical
            /// </summary>
            DashedVertical,
            /// <summary>
            /// The diagonal brick
            /// </summary>
            DiagonalBrick,
            /// <summary>
            /// The diagonal cross
            /// </summary>
            DiagonalCross,
            /// <summary>
            /// The divot
            /// </summary>
            Divot,
            /// <summary>
            /// The dotted diamond
            /// </summary>
            DottedDiamond,
            /// <summary>
            /// The dotted grid
            /// </summary>
            DottedGrid,
            /// <summary>
            /// The forward diagonal
            /// </summary>
            ForwardDiagonal,
            /// <summary>
            /// The horizontal
            /// </summary>
            Horizontal,
            /// <summary>
            /// The horizontal brick
            /// </summary>
            HorizontalBrick,
            /// <summary>
            /// The large checker board
            /// </summary>
            LargeCheckerBoard,
            /// <summary>
            /// The large confetti
            /// </summary>
            LargeConfetti,
            /// <summary>
            /// The large grid
            /// </summary>
            LargeGrid,
            /// <summary>
            /// The light downward diagonal
            /// </summary>
            LightDownwardDiagonal,
            /// <summary>
            /// The light horizontal
            /// </summary>
            LightHorizontal,
            /// <summary>
            /// The light upward diagonal
            /// </summary>
            LightUpwardDiagonal,
            /// <summary>
            /// The light vertical
            /// </summary>
            LightVertical,
            /// <summary>
            /// The maximum
            /// </summary>
            Max,
            /// <summary>
            /// The minimum
            /// </summary>
            Min,
            /// <summary>
            /// The narrow horizontal
            /// </summary>
            NarrowHorizontal,
            /// <summary>
            /// The narrow vertical
            /// </summary>
            NarrowVertical,
            /// <summary>
            /// The outlined diamond
            /// </summary>
            OutlinedDiamond,
            /// <summary>
            /// The percent05
            /// </summary>
            Percent05,
            /// <summary>
            /// The percent10
            /// </summary>
            Percent10,
            /// <summary>
            /// The percent20
            /// </summary>
            Percent20,
            /// <summary>
            /// The percent25
            /// </summary>
            Percent25,
            /// <summary>
            /// The percent30
            /// </summary>
            Percent30,
            /// <summary>
            /// The percent40
            /// </summary>
            Percent40,
            /// <summary>
            /// The percent50
            /// </summary>
            Percent50,
            /// <summary>
            /// The percent60
            /// </summary>
            Percent60,
            /// <summary>
            /// The percent70
            /// </summary>
            Percent70,
            /// <summary>
            /// The percent75
            /// </summary>
            Percent75,
            /// <summary>
            /// The percent80
            /// </summary>
            Percent80,
            /// <summary>
            /// The percent90
            /// </summary>
            Percent90,
            /// <summary>
            /// The plaid
            /// </summary>
            Plaid,
            /// <summary>
            /// The shingle
            /// </summary>
            Shingle,
            /// <summary>
            /// The small checker board
            /// </summary>
            SmallCheckerBoard,
            /// <summary>
            /// The small confetti
            /// </summary>
            SmallConfetti,
            /// <summary>
            /// The small grid
            /// </summary>
            SmallGrid,
            /// <summary>
            /// The solid diamond
            /// </summary>
            SolidDiamond,
            /// <summary>
            /// The sphere
            /// </summary>
            Sphere,
            /// <summary>
            /// The trellis
            /// </summary>
            Trellis,
            /// <summary>
            /// The vertical
            /// </summary>
            Vertical,
            /// <summary>
            /// The wave
            /// </summary>
            Wave,
            /// <summary>
            /// The weave
            /// </summary>
            Weave,
            /// <summary>
            /// The wide downward diagonal
            /// </summary>
            WideDownwardDiagonal,
            /// <summary>
            /// The wide upward diagonal
            /// </summary>
            WideUpwardDiagonal,
            /// <summary>
            /// The zig zag
            /// </summary>
            ZigZag
        }

        #endregion


        #endregion

        #region Public Properties

        
        /// <summary>
        /// Gets or sets the progress input.
        /// </summary>
        /// <value>The progress input.</value>
        [Category("General Progress Information")]
        public ProgressInput ProgressInput
        {
            get { return progressInput; }
            set
            {
                progressInput = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        [Category("General Progress Information")]
        public bool ShowText
        {
            get { return progressInput.ShowText; }
            set
            {
                if (value == true)
                {
                    DisplayProgress = true;
                    ShowValue = true;
                }
                else
                {
                    DisplayProgress = false;
                    ShowValue = false;
                }


                progressInput.ShowText = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [allow transparency].
        /// </summary>
        /// <value><c>true</c> if [allow transparency]; otherwise, <c>false</c>.</value>
        [Category("General Progress Information")]
        public bool AllowTransparency
        {
            get { return progressInput.AllowTransparency; }
            set
            {
                progressInput.AllowTransparency = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [Category("General Progress Information")]

        public float Value
        {
            get { return progressInput.Value; }
            set
            {
                if (value > Maximum)
                {
                    value = Maximum;
                }


                if (this.BarType == BarType.Animated)
                {
                    MakeAnimation(value);
                    return;
                }

                switch (SolidProgressBar)
                {
                    case ProgressBar.RPExtendedProgress:
                        break;
                    case ProgressBar.RPIndicator:
                        break;
                    case ProgressBar.RPiTunes:
                        break;
                    case ProgressBar.RPMaze:
                        break;
                    case ProgressBar.RPProgNormal:
                        //float Temp = _iPercent;
                        //if (value < Minimum || value > Maximum)
                        //    throw new ArgumentOutOfRangeException("Value", "Must be between Minimum and Maximum");
                        //Value = value;
                        //float Range = Maximum - Minimum;
                        //_fPercent = 100 * (((float)Value) / Range);
                        //_iPercent = _fPercent /*(float)Math.Ceiling(_fPercent)*/;
                        //if (_iPercent == Temp)
                        //    _TurnOffInvalidation = true;
                        //ProgressBarNormal_Invalidate();
                        _iPercent = ((value) / Maximum) * (100f);
                        break;
                    //case ProgressBar.RPProgBoxed:
                    //    int Temps = ProgressBarBoxed_MaxBlockToDraw;
                    //    _TurnOffInvalidation = true;
                    //    Value = value;
                    //    ProgressBarBoxed_ComputeMaxBlockToDraw();
                    //    if (ProgressBarBoxed_MaxBlockToDraw == Temps)
                    //        _TurnOffInvalidation = true;
                    //    ProgressBarNormal_Invalidate();
                    //    break;
                    //case ProgressBar.RPProgGradient:
                    //    break;
                    case ProgressBar.RPAlter:
                        break;
                    case ProgressBar.RPClear:
                        break;
                    case ProgressBar.RPPerplex:
                        break;
                    case ProgressBar.RPRect:
                        break;

                    case ProgressBar.RPTransparent:
                        break;

                    case ProgressBar.RPSplitter:
                        break;

                    case ProgressBar.CPDagger:
                        //if (value < 0)
                        //{
                        //    this.Value = 0;
                        //}
                        //if (value > 100)
                        //{
                        //    this.Value = 100;
                        //}

                        this.OnPercentageChanged();
                        Invalidate();
                        break;

                    case ProgressBar.CPDaggerSmooth:
                        //if (value < 0)
                        //{
                        //    this.Value = 0;
                        //}
                        //if (value > 100)
                        //{
                        //    this.Value = 100;
                        //}

                        this.OnPercentageChanged();
                        Invalidate();
                        break;

                    case ProgressBar.CPDaggerV1:
                        //if (value < 0)
                        //{
                        //    this.Value = 0;
                        //}
                        //if (value > 100)
                        //{
                        //    this.Value = 100;
                        //}

                        this.OnPercentageChanged();
                        Invalidate();
                        break;

                        //default:
                        //    throw new ArgumentOutOfRangeException();

                }

                progressInput.Value = value;
                this.OnValueChanged(EventArgs.Empty);
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        [Category("General Progress Information")]

        public float Maximum
        {
            get { return progressInput.Maximum; }
            set
            {
                if (value < 1)
                    value = 1;

                switch (ProgressType)
                {
                    case ProgressType.Bar:
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.RPExtendedProgress:
                                break;
                            case ProgressBar.RPIndicator:
                                break;
                            case ProgressBar.RPiTunes:
                                break;
                            case ProgressBar.RPMaze:
                                break;
                            case ProgressBar.RPProgNormal:
                                break;
                            //case ProgressBar.RPProgBoxed:
                            //    break;
                            //case ProgressBar.RPProgGradient:
                            //    break;
                            case ProgressBar.RPAlter:
                                break;
                            case ProgressBar.RPClear:
                                break;
                            case ProgressBar.RPRect:
                                break;
                            case ProgressBar.RPPerplex:
                                break;
                            case ProgressBar.RPTransparent:
                                break;
                            case ProgressBar.RPSplitter:
                                break;

                            case ProgressBar.CPBarCircular:
                                break;
                            case ProgressBar.CPv2:
                                break;
                            case ProgressBar.CPv3:
                                break;
                            case ProgressBar.CPv4:
                                break;
                            case ProgressBar.CPv5:
                                break;
                            //case CircularProgress.CircularProgressv5aClock:
                            //    break;
                            case ProgressBar.CPGorgeous:
                                break;
                            case ProgressBar.CPIgnito:
                                break;
                            case ProgressBar.CPMulitCo:
                                break;
                            case ProgressBar.CPMultiCoExtended:
                                break;
                            case ProgressBar.CPMultiCoV1:
                                break;
                            case ProgressBar.CPAwesome:
                                break;
                            case ProgressBar.CPPerfect:
                                break;
                            case ProgressBar.CPProgressPie:
                                break;
                            case ProgressBar.CPRotatingArc:
                                break;
                            case ProgressBar.CPRotatingCompass:
                                break;
                            case ProgressBar.CPSupreme:
                                break;
                            case ProgressBar.CPBarCircularDefault:
                                break;

                            case ProgressBar.CPDagger:
                                break;

                            case ProgressBar.CPDaggerSmooth:
                                break;

                            case ProgressBar.CPDaggerV1:
                                break;

                            case ProgressBar.IPIndeterminate:
                                break;
                            case ProgressBar.IPGoogle:
                                break;
                            case ProgressBar.IPMacOSX:
                                //MaximumSpokeCount(value);
                                //MacOSX_CalculateSpokes();
                                Invalidate();
                                break;
                            case ProgressBar.IPMacOSXOptimized:
                                //MacOSX_Optimized_CalculateSpokesPoints(value);
                                //Invalidate();
                                break;
                            case ProgressBar.IPMatrix:
                                MacOSX_Matrix_CalculateSpokesPoints(value);
                                Invalidate();
                                break;
                            case ProgressBar.IPV1:
                                break;
                            case ProgressBar.IPUnique:
                                break;
                            case ProgressBar.IPVuvuzela:
                                break;
                            case ProgressBar.IPSpinnerCircle:
                                break;
                            case ProgressBar.IPSpinnerDivided:
                                break;
                            case ProgressBar.IPWin8Horizontal:
                                break;
                            case ProgressBar.IPWin8Ring:
                                break;
                                //default:
                                //    throw new ArgumentOutOfRangeException();
                        }
                        break;
                        //default:
                        //    throw new ArgumentOutOfRangeException();
                }

                progressInput.Maximum = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        [Category("General Progress Information")]

        public float Minimum
        {
            get
            {
                return progressInput.Minimum;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                progressInput.Minimum = value;
                Invalidate();
            }
        }


        #region HatchBrush Property

        /// <summary>
        /// Gets or sets the color hatch brushgradient1.
        /// </summary>
        /// <value>The color hatch brushgradient1.</value>
        [Category("General Progress Information")]

        public Color ColorHatchBrushgradient1
        {
            get { return progressInput.ColorHatchBrushgradient1; }
            set
            {
                progressInput.ColorHatchBrushgradient1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color hatch brushgradient2.
        /// </summary>
        /// <value>The color hatch brushgradient2.</value>
        [Category("General Progress Information")]

        public Color ColorHatchBrushgradient2
        {
            get { return progressInput.ColorHatchBrushgradient2; }
            set
            {
                progressInput.ColorHatchBrushgradient2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the hatch brush.
        /// </summary>
        /// <value>The hatch brush.</value>
        [Category("General Progress Information")]

        public HatchBrushType HatchBrush
        {
            get
            {
                return progressInput.HatchBrush;
            }

            set
            {
                progressInput.HatchBrush = value;
                Invalidate();
            }
        }
        #endregion


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitThematicProgress"/> is glow.
        /// </summary>
        /// <value><c>true</c> if glow; otherwise, <c>false</c>.</value>
        [Category("General Progress Information")]

        public bool Glow
        {
            get { return progressInput.Glow; }
            set
            {

                if (value == true)
                {

                    transparencyAnimator.Start();
                }

                else
                {
                    transparencyAnimator.Stop();

                }

                progressInput.Glow = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the size of the fixed.
        /// </summary>
        /// <value>The size of the fixed.</value>
        [Category("General Progress Information")]

        public Boolean FixedSize
        {
            get { return progressInput.FixedSize; }
            set
            {
                progressInput.FixedSize = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the fill transparency.
        /// </summary>
        /// <value>The fill transparency.</value>
        [Category("General Progress Information")]

        public int FillTransparency
        {
            get { return progressInput.FillTransparency; }
            set
            {
                progressInput.FillTransparency = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        [Category("General Progress Information")]

        public drawMode DrawMode
        {
            get { return progressInput.DrawMode; }
            set
            {
                progressInput.DrawMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the type of the easing.
        /// </summary>
        /// <value>The type of the easing.</value>
        [Category("General Progress Information")]

        public PeaceAnimatorEasing EasingType
        {
            get { return progressInput.EasingType; }
            set
            {

                progressInput.EasingType = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the transparent easing.
        /// </summary>
        /// <value>The transparent easing.</value>
        [Category("General Progress Information")]

        public transparencyEasingType TransparentEasing
        {
            get { return progressInput.TransparentEasing; }
            set
            {
                progressInput.TransparentEasing = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic increment].
        /// </summary>
        /// <value><c>true</c> if [automatic increment]; otherwise, <c>false</c>.</value>
        [Category("General Progress Information")]

        public bool AutoIncrement
        {
            get { return progressInput.AutoIncrement; }
            set
            {

                if (value == true)
                {

                    peaceAnimator.Start();

                    _stopped = false;
                }

                else
                {
                    peaceAnimator.Stop();

                    _stopped = true;
                }

                progressInput.AutoIncrement = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
        [Category("General Progress Information")]
        public int[] AnimationSpeed
        {
            get { return progressInput.AnimationSpeed; }
            set
            {
                for (int i = 0; i <= 1; i++)
                    if (value[0] < 1)
                    {
                        value[0] = 1;
                    }

                if (value[1] < 1)
                {
                    value[1] = 1;
                }

                if (value[2] < 1)
                {
                    value[2] = 1;
                }

                if (value[2] > 0)
                {
                    if (AutoIncrement == true)
                    {
                        peaceAnimator.Stop();
                        peaceAnimator.DurationValue = (ulong)value[2];
                        peaceAnimator.Start();
                    }

                }

                DagAnimSpeed = value[0];
                DagAnimUpSpeed = value[0];
                progressInput.AnimationSpeed = value;

                timerStartingAngle.Interval = value[1];
                timer.Interval = value[0];
                timerDecrement.Interval = value[0];

                Invalidate();
            }
        }


        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = TextRendering;
        #endregion

        //TextRenderingHint TextRendering = TextRenderingHint.AntiAlias;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        [Category("General Progress Information")]

        public TextRenderingHint TextRendering
        {
            get { return progressInput.TextRendering; }
            set
            {
                progressInput.TextRendering = value;
                Invalidate();
            }
        }
        #endregion


        /// <summary>
        /// Gets or sets the type of the progress.
        /// </summary>
        /// <value>The type of the progress.</value>
        [Category("General Progress Information")]

        public ProgressType ProgressType
        {
            get { return progressInput.ProgressType; }
            set
            {
                progressInput.ProgressType = value;
                //ProgType = value;
                this.Refresh();
            }
        }


        //[Category("General Progress Information")]
        //
        //public CircularProgress CircularProgressType
        //{
        //    get { return progressInput.CircularProgressType; }
        //    set
        //    {
        //        progressInput.CircularProgressType = value;
        //        //CircType = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the solid progress bar.
        /// </summary>
        /// <value>The solid progress bar.</value>
        [Category("General Progress Information")]

        public ProgressBar SolidProgressBar
        {
            get { return progressInput.SolidProgressBar; }
            set
            {
                progressInput.SolidProgressBar = value;
                //ProgBar = value;
                Invalidate();
            }
        }

        //[Category("General Progress Information")]
        //
        //public ProgressIndicator ProgressIndicatorType
        //{
        //    get { return progressInput.ProgressIndicatorType; }
        //    set
        //    {
        //        progressInput.ProgressIndicatorType = value;
        //        //ProgIndicate = value;
        //        //Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the post fix.
        /// </summary>
        /// <value>The post fix.</value>
        [Category("General Progress Information")]

        public string PostFix
        {
            get { return progressInput.PostFix; }
            set
            {
                progressInput.PostFix = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the background color for the control.
        /// </summary>
        /// <value>The color of the back.</value>
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                xBrushes[BrushBackGround] = new SolidBrush(value);

                base.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the size that is the lower limit that <see cref="M:System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)" /> can specify.
        /// </summary>
        /// <value>The minimum size.</value>
        public override Size MinimumSize
        {
            get { return _minimumSize; }
            set
            {
                if (value.Height < minimumSizeAllowed.Height)
                    value.Height = minimumSizeAllowed.Height;
                if (value.Width < minimumSizeAllowed.Width)
                    value.Height = minimumSizeAllowed.Height;
                _minimumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            //get { return progressInput.Info; }
            //set
            //{
            //    progressInput.Info = value;
            //    RefreshControl();
            //}
            get { return base.Text; }
            set
            {
                progressInput.Info = value;
                base.Text = value;

            }
        }
        /// <summary>
        ///     Gets or sets the font of text in the <see cref="CircularProgressBar" />.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Drawing.Font" /> of the text. The default is the font set by the container.
        /// </returns>
        /// <summary>
        /// Gets or sets the font of the text displayed by the control.
        /// </summary>
        /// <value>The font.</value>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }
        /// <summary>
        /// Gets or sets the starting angle.
        /// </summary>
        /// <value>The starting angle.</value>
        [Category("General Progress Information")]

        public float StartingAngle
        {
            get { return progressInput.StartingAngle; }
            set
            {
                progressInput.StartingAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the foreground color of the control.
        /// </summary>
        /// <value>The color of the fore.</value>
        [Description("Text Color"), Category("ProgressApearance")]

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {

                //switch (SolidProgressBar)
                //{
                //    case ProgressBar.RPExtendedProgress:
                //        break;
                //    case ProgressBar.RPIndicator:
                //        break;
                //    case ProgressBar.RPiTunes:
                //        break;
                //    case ProgressBar.RPMaze:
                //        break;
                //    case ProgressBar.RPProgNormal:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    case ProgressBar.RPProgBoxed:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    case ProgressBar.RPProgGradient:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    default:
                //        throw new ArgumentOutOfRangeException();
                //}

                xBrushes[BrushText] = new SolidBrush(value);

                base.ForeColor = value;
            }
        }


        //private ProgressType progType = ProgressThematic.ProgressType.Circular;
        //[RefreshProperties(RefreshProperties.Repaint)]
        //public ProgressType ProgType
        //{
        //    get { return progType; }
        //    set
        //    {
        //        progType = value;
        //        this.Invalidate();
        //    }
        //}

        //private CircularProgress cirCType = CircularProgress.CPSupreme;
        //public CircularProgress CircType
        //{
        //    get { return cirCType; }
        //    set
        //    {
        //        cirCType = value;
        //        Invalidate();
        //    }
        //}

        //private ProgressBar progbar = ProgressBar.RPExtendedProgress;
        //public ProgressBar ProgBar
        //{
        //    get { return progbar; }
        //    set
        //    {
        //        progbar = value;
        //        Invalidate();
        //    }
        //}

        //private ProgressIndicator progIndicate = ProgressIndicator.IPIndeterminate;
        //public ProgressIndicator ProgIndicate
        //{
        //    get { return progIndicate; }
        //    set
        //    {
        //        progIndicate = value;
        //        Invalidate();
        //    }
        //}


        #endregion

        #region Private Methods

        /// <summary>
        /// Circulars the size of the progress bar set standard.
        /// </summary>
        private void CircularProgressBar_SetStandardSize()
        {
            if (FixedSize)
            {
                int _Size = System.Math.Max(Width, Height);
                Size = new Size(_Size, _Size);
            }

        }

        /// <summary>
        /// Sets the size of the standard.
        /// </summary>
        private void SetStandardSize()
        {
            if (FixedSize)
            {
                int _Size = System.Math.Max(Width, Height);
                Size = new Size(_Size, _Size);
            }

        }

        #endregion

        #region Image Designer

        #region Include in paint method

        ///////////////////////////////////////////////////////////////////////////////////////////////// 
        //                                                                                             //                                                                     
        //         ------------------------Add this to the Paint Method ------------------------       //
        //                                                                                             //
        // Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          //
        //                                                                                             //
        // PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);                   //
        //                                                                                             //
        // if ((Image == null))                                                                        //
        //     {                                                                                       //
        //         G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat           //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        // else                                                                                        //
        //      {                                                                                      //
        //         G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);              //
        //          G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat          //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        //                                                                                             //
        /////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Include in Private Fields
        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// The image align
        /// </summary>
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// The text alignment
        /// </summary>
        private StringAlignment _TextAlignment = StringAlignment.Center;
        //private bool showText = true;
        #endregion

        #region Include in Public Properties
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                if ((value == null))
                {
                    ShowText = true;
                }
                else
                {
                    ShowText = false;
                }


                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        public Size ImageSize
        {
            get { return _ImageSize; }
            set
            {
                _ImageSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the image align.
        /// </summary>
        /// <value>The image align.</value>
        public ContentAlignment ImageAlign
        {
            get { return _ImageAlign; }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        //public bool ShowText
        //{
        //    get { return showText; }
        //    set
        //    {
        //        showText = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        public StringAlignment TextAlign
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }


        #endregion

        #region Include in Private Methods
        /// <summary>
        /// Images the location.
        /// </summary>
        /// <param name="SF">The sf.</param>
        /// <param name="Area">The area.</param>
        /// <param name="ImageArea">The image area.</param>
        /// <returns>PointF.</returns>
        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint = default(PointF);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    MyPoint.X = Convert.ToSingle((Area.Width - ImageArea.Width) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.X = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.X = Area.Width - ImageArea.Width - 2;
                    break;
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    MyPoint.Y = Convert.ToSingle((Area.Height - ImageArea.Height) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.Y = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.Y = Area.Height - ImageArea.Height - 2;
                    break;
            }
            return MyPoint;
        }

        /// <summary>
        /// Gets the string format.
        /// </summary>
        /// <param name="_ContentAlignment">The content alignment.</param>
        /// <returns>StringFormat.</returns>
        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            StringFormat SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.TopCenter:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopLeft:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomRight:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Far;
                    break;
            }
            return SF;
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="R1">The r1.</param>
        private void DrawImage(Graphics G, Rectangle R1)
        {
            //Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          
            G.SmoothingMode = SmoothingMode.HighQuality;

            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

            if ((Image == null))
            {
                //if (ShowText)
                //    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                //    {
                //        Alignment = _TextAlignment,
                //        LineAlignment = StringAlignment.Center

                //    });
            }
            else
            {
                G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);
                //ShowText = false;

                //if (ShowText)
                //    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                //    {
                //        Alignment = _TextAlignment,
                //        LineAlignment = StringAlignment.Center
                //    });
            }

        }


        #endregion
        #endregion

        #region Timer

        //AutoAnimate
        #region Include in Private Field


        //private bool AutoAnimate = false;
        /// <summary>
        /// The timer
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        /// <summary>
        /// The timer decrement
        /// </summary>
        private System.Windows.Forms.Timer timerDecrement = new System.Windows.Forms.Timer();
        /// <summary>
        /// The speed multiplier
        /// </summary>
        private float speedMultiplier = 1;
        /// <summary>
        /// The change
        /// </summary>
        private float change = 0.1f;
        /// <summary>
        /// The reverse
        /// </summary>
        private bool reverse = true;

        #endregion

        #region Include in Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether [automatic animate].
        /// </summary>
        /// <value><c>true</c> if [automatic animate]; otherwise, <c>false</c>.</value>
        [Category("Timer")]
        public bool AutoAnimate
        {
            get { return progressInput.AutoAnimate; }
            set
            {
                progressInput.AutoAnimate = value;

                //heartAutoAnimate = true;

                if (value == true)
                {
                    timer.Enabled = true;

                    timer_running = timer.Enabled;

                    //heartTimer.Enabled = true;

                    rotateColor.Enabled = true;


                    //Unique_Start();

                    switch (SolidProgressBar)
                    {
                        case ProgressBar.CPv5:
                            CPv5_timer1.Enabled = true;
                            CPv5_timer2.Enabled = true;
                            CPv5_timer3.Enabled = true;
                            CPv5_timer4.Enabled = true;
                            break;
                        case ProgressBar.CPPerfect:
                            ProgressPerfect_Start();

                            break;


                        case ProgressBar.IPGoogle:
                            timerInnerCircle.Enabled = true;
                            break;

                        case ProgressBar.IPSpinnerCircle:
                            timer.Enabled = false;
                            timer.Stop();
                            Spinner_Active = true;
                            break;

                        case ProgressBar.IPSpinnerDivided:
                            timer.Enabled = false;
                            Automate = true;
                            break;

                        case ProgressBar.IPUnique:
                            _stopped = false;
                            break;

                        case ProgressBar.IPWin8Horizontal:
                            //WinHR_Animate = true;
                            WinHR_timer.Enabled = true;
                            WinHR_timer.Start();
                            break;
                        case ProgressBar.IPWin8Ring:
                            WinRing_Animate = true;
                            break;

                        case ProgressBar.CPDagger:
                            DagIsAnimated = true;
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            DagSmoothIsAnimated = true;
                            break;

                        case ProgressBar.CPDaggerV1:
                            DagUpIsAnimated = true;
                            break;
                    }
                }

                else
                {
                    timer.Enabled = false;
                    timerDecrement.Enabled = false;
                    //heartTimer.Enabled = false;


                    switch (SolidProgressBar)
                    {
                        case ProgressBar.CPv5:
                            CPv5_timer1.Enabled = false;
                            CPv5_timer2.Enabled = false;
                            CPv5_timer3.Enabled = false;
                            CPv5_timer4.Enabled = false;
                            break;

                        case ProgressBar.CPPerfect:
                            ProgressPerfect_Stop();
                            break;

                        case ProgressBar.CPDagger:
                            DagIsAnimated = false;
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            DagSmoothIsAnimated = false;
                            break;

                        case ProgressBar.CPDaggerV1:
                            DagUpIsAnimated = false;
                            break;


                        case ProgressBar.IPGoogle:
                            timerInnerCircle.Enabled = false;
                            break;

                        case ProgressBar.IPSpinnerCircle:
                            Spinner_Active = false;
                            break;

                        case ProgressBar.IPSpinnerDivided:
                            timer.Enabled = false;
                            Automate = false;
                            break;

                        case ProgressBar.IPUnique:
                            _stopped = true;
                            break;

                        case ProgressBar.IPWin8Horizontal:
                            //WinHR_Animate = false;
                            WinHR_timer.Enabled = false;
                            WinHR_timer.Stop();
                            break;

                        case ProgressBar.IPWin8Ring:
                            WinRing_Animate = false;
                            break;
                    }

                    rotateColor.Enabled = false;
                }


                UpdateStyles();
                Invalidate();


            }
        }

        /// <summary>
        /// Gets or sets the speed multiplier.
        /// </summary>
        /// <value>The speed multiplier.</value>
        [Category("Timer")]
        public float SpeedMultiplier
        {
            get { return speedMultiplier; }
            set
            {
                speedMultiplier = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the change.
        /// </summary>
        /// <value>The change.</value>
        [Category("Timer")]
        public float Change
        {
            get { return change; }
            set
            {
                change = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitThematicProgress"/> is reverse.
        /// </summary>
        /// <value><c>true</c> if reverse; otherwise, <c>false</c>.</value>
        public bool Reverse
        {
            get { return reverse; }
            set
            {

                reverse = value;
                Invalidate();
            }
        }

        
        #endregion

        #region Timer Event

        /// <summary>
        /// Handles the Tick event of the Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPExtendedProgress:

                            Extended_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPIndicator:
                            ZeroitIndicator_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPiTunes:
                            iTunes_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPMaze:
                            Maze_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPProgNormal:
                            ProgressNormal_Timer_Tick(sender, e);
                            break;

                        //case ProgressBar.RPProgBoxed:
                        //    ProgressNormal_Timer_Tick(sender, e);
                        //    break;

                        //case ProgressBar.RPProgGradient:
                        //    ProgressNormal_Timer_Tick(sender, e);
                        //    break;

                        case ProgressBar.RPAlter:
                            ProgressAlter_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPClear:
                            ProgressBarClear_Timer_Tick(sender, e); //Consider
                            break;

                        case ProgressBar.RPPerplex:
                            ProgressBarPerplex_Timer_Tick(sender, e); //Consider
                            break;

                        case ProgressBar.RPRect:
                            ProgressRect_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPTransparent:
                            Transparent_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.RPSplitter:
                            ProgressBarSplitter_Timer_Tick(sender, e);
                            break;


                        case ProgressBar.IPIndeterminate:
                            Pulse(sender, e);
                            break;
                        case ProgressBar.IPGoogle:

                            GoogleProgress_Timer_Tick(sender, e);

                            break;
                        case ProgressBar.IPMacOSX:
                            MacOSX_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.IPMacOSXOptimized:
                            MacOSX_Optimized_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.IPMatrix:
                            MacOSX_Matrix_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.IPV1:
                            ProgIndicatorV1_AnimationSpeed_Tick(sender, e);
                            break;

                        case ProgressBar.IPUnique:
                            Unique_timerAnimation_Tick(sender, e);
                            break;

                        case ProgressBar.IPVuvuzela:
                            Vuvuzela_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.IPSpinnerCircle:
                            aTimer_Tick(sender, e);
                            break;

                        case ProgressBar.IPWin8Horizontal:
                            break;
                        case ProgressBar.IPWin8Ring:
                            break;

                        case ProgressBar.CPBarCircular:

                            #region Value Increment for ZeroitProgressCircular
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

                            CircularDef_Timer_Tick(sender, e);

                            break;
                        case ProgressBar.CPBarCircularDefault:
                            CircularDef_Timer_Tick(sender, e);
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    CircularProgressv5aClock_Timer_Tick(sender, e);
                        //    break;
                        case ProgressBar.CPv2:
                            CPv2_Timer_Tick(sender, e);
                            break;
                        case ProgressBar.CPv3:
                            CPv3_Timer_Tick(sender, e);
                            break;
                        case ProgressBar.CPv4:
                            CPv4_Timer_Tick(sender, e);
                            break;
                        case ProgressBar.CPv5:
                            CPv5_Timer_Tick(sender, e);
                            CPv5_Timer_Tick1(sender, e);
                            CPv5_Timer_Tick2(sender, e);
                            CPv5_Timer_Tick3(sender, e);
                            CPv5_Timer_Tick4(sender, e);
                            CPv5_MarqueeTimer_Tick(sender, e);
                            break;

                        case ProgressBar.CPGorgeous:
                            Gorgeous_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPIgnito:
                            Ignito_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPMulitCo:
                            MultiCo_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPMultiCoExtended:
                            MultiCoExtended_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPMultiCoV1:
                            MCExV2_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPAwesome:
                            timerAnimation_Tick(sender, e);
                            break;

                        case ProgressBar.CPPerfect:
                            //timer.Enabled = false;
                            ProgressPerfect_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPProgressPie:
                            ProgressBarPie_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPRotatingArc:
                            RotatingArc_Timer_Tick(sender, e);
                            //RotatingArc_HeartBeatTimer_Tick(sender, e);
                            break;

                        case ProgressBar.CPRotatingCompass:
                            RotatingCompass_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPSupreme:
                            SP_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPDaggerSmooth:

                            if (DagSmoothRotate)
                            {
                                if (DagSmoothAnimEndAngle)
                                {
                                    DagSmoothAnimateEndAngle(sender, e);
                                }
                            }
                            else
                            {
                                DagSmoothAnimateWithoutRotate(sender, e);
                            }

                            break;

                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        /// <summary>
        /// Handles the Tick event of the TimerDecrement control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void TimerDecrement_Tick(object sender, EventArgs e)
        {
            
            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPExtendedProgress:

                            Extended_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPIndicator:
                            ZeroitIndicator_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPiTunes:
                            iTunes_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPMaze:
                            Maze_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPProgNormal:
                            ProgressNormal_Timer_Reduced_Tick(sender, e);
                            break;

                        //case ProgressBar.RPProgBoxed:
                        //    ProgressNormal_Timer_Reduced_Tick(sender, e);
                        //    break;

                        //case ProgressBar.RPProgGradient:
                        //    ProgressNormal_Timer_Reduced_Tick(sender, e);
                        //    break;

                        case ProgressBar.RPAlter:
                            ProgressAlter_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPClear:
                            ProgressBarClear_Timer_Reduced_Tick(sender, e); //Consider
                            break;

                        case ProgressBar.RPPerplex:
                            ProgressBarPerplex_Timer_Reduced_Tick(sender, e); //Consider
                            break;

                        case ProgressBar.RPRect:
                            ProgressRect_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPTransparent:
                            Transparent_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.RPSplitter:
                            ProgressBarSplitter_Timer_Reduced_Tick(sender, e);
                            break;


                        case ProgressBar.IPIndeterminate:
                            Pulse(sender, e);
                            break;
                        case ProgressBar.IPGoogle:

                            GoogleProgress_Timer_Reduced_Tick(sender, e);

                            break;
                        case ProgressBar.IPMacOSX:
                            MacOSX_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.IPMacOSXOptimized:
                            MacOSX_Optimized_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.IPMatrix:
                            MacOSX_Matrix_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.IPV1:
                            ProgIndicatorV1_AnimationSpeed_Tick(sender, e);
                            break;

                        case ProgressBar.IPUnique:
                            Unique_timerAnimation_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.IPVuvuzela:
                            Vuvuzela_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.IPSpinnerCircle:
                            aTimer_Tick(sender, e);
                            break;

                        case ProgressBar.IPWin8Horizontal:
                            WinHR_timer_tick(sender, e);
                            break;
                        case ProgressBar.IPWin8Ring:
                            WinRing_tick(sender, e);
                            break;

                        case ProgressBar.CPBarCircular:

                            #region Value Increment for ZeroitProgressCircular
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

                            CircularDef_Timer_Reduced_Tick(sender, e);

                            break;
                        case ProgressBar.CPBarCircularDefault:
                            CircularDef_Timer_Reduced_Tick(sender, e);
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    CircularProgressv5aClock_Timer_Tick(sender, e);
                        //    break;
                        case ProgressBar.CPv2:
                            CPv2_Timer_Reduced_Tick(sender, e);
                            break;
                        case ProgressBar.CPv3:
                            CPv3_Timer_Reduced_Tick(sender, e);
                            break;
                        case ProgressBar.CPv4:
                            CPv4_Timer_Reduced_Tick(sender, e);
                            break;
                        case ProgressBar.CPv5:
                            CPv5_Timer_Reduced_Tick(sender, e);
                            CPv5_Timer_Reduced_Tick1(sender, e);
                            CPv5_Timer_Reduced_Tick2(sender, e);
                            CPv5_Timer_Reduced_Tick3(sender, e);
                            CPv5_Timer_Reduced_Tick4(sender, e);
                            CPv5_MarqueeTimer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPGorgeous:
                            Gorgeous_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPIgnito:
                            Ignito_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPMulitCo:
                            MultiCo_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPMultiCoExtended:
                            MultiCoExtended_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPMultiCoV1:
                            MCExV2_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPAwesome:
                            timerAnimation_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPPerfect:
                            //timer.Enabled = false;

                            ProgressPerfect_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPProgressPie:
                            ProgressBarPie_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPRotatingArc:
                            RotatingArc_Timer_Reduced_Tick(sender, e);
                            //RotatingArc_HeartBeatTimer_Tick(sender, e);
                            break;

                        case ProgressBar.CPRotatingCompass:
                            RotatingCompass_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPSupreme:
                            SP_Timer_Reduced_Tick(sender, e);
                            break;

                        case ProgressBar.CPDaggerSmooth:

                            if (DagSmoothRotate)
                            {
                                if (DagSmoothAnimEndAngle)
                                {
                                    DagSmoothAnimateEndAngleReduced(sender, e);
                                }
                            }
                            else
                            {
                                DagSmoothAnimateWithoutRotateReduced(sender, e);
                            }

                            break;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }


        /// <summary>
        /// Includes the in constructor.
        /// </summary>
        private void IncludeInConstructor()
        {

            if (DesignMode)
            {
                timer.Tick += Timer_Tick;
                timerDecrement.Tick += TimerDecrement_Tick;
                if (AutoAnimate)
                {
                    //timerDecrement.Interval = 100;
                    //timer.Interval = 100;
                    timer.Start();
                }
            }

            if (!DesignMode)
            {
                timer.Tick += Timer_Tick;
                timerDecrement.Tick += TimerDecrement_Tick;
                if (AutoAnimate)
                {
                    //timerDecrement.Interval = 100;
                    //timer.Interval = 100;
                    timer.Start();
                }
            }

        }



        #endregion

        //Animate_Indeterminate Start Angle
        #region Include in Private Field


        //private bool AnimateStartAngle = false;
        /// <summary>
        /// The timer starting angle
        /// </summary>
        private System.Windows.Forms.Timer timerStartingAngle = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [animate start angle].
        /// </summary>
        /// <value><c>true</c> if [animate start angle]; otherwise, <c>false</c>.</value>
        public bool AnimateStartAngle
        {
            get { return progressInput.AnimateStartAngle; }
            set
            {
                progressInput.AnimateStartAngle = value;

                if (value == true)
                {
                    timerStartingAngle.Enabled = true;
                }

                else
                {
                    timerStartingAngle.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// Handles the StartAngle event of the Timer_Tick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void Timer_Tick_StartAngle(object sender, EventArgs e)
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

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPExtendedProgress:
                            break;
                        case ProgressBar.RPIndicator:
                            break;
                        case ProgressBar.RPiTunes:
                            break;
                        case ProgressBar.RPMaze:
                            break;
                        case ProgressBar.RPProgNormal:
                            break;
                        //case ProgressBar.RPProgBoxed:
                        //    break;
                        //case ProgressBar.RPProgGradient:
                        //    break;
                        case ProgressBar.RPAlter:
                            break;
                        case ProgressBar.RPClear:
                            break;
                        case ProgressBar.RPPerplex:
                            break;
                        case ProgressBar.RPRect:
                            break;
                        case ProgressBar.RPSplitter:
                            break;
                        case ProgressBar.RPTransparent:
                            break;

                        case ProgressBar.CPAwesome:
                            break;

                        case ProgressBar.CPBarCircular:
                            break;
                        case ProgressBar.CPv2:

                            if (this.CPv2_AngleReduced + 1 > 360)
                            {
                                this.CPv2_AngleReduced = 0;
                            }

                            else
                            {
                                this.CPv2_AngleReduced++;
                                Invalidate();
                            }

                            break;
                        case ProgressBar.CPv3:
                            break;
                        case ProgressBar.CPv4:
                            break;
                        case ProgressBar.CPv5:
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    break;

                        case ProgressBar.CPGorgeous:
                            Gorgeous_Timer_Tick_StartAngle(sender, e);
                            break;

                        case ProgressBar.CPBarCircularDefault:
                            break;
                        case ProgressBar.CPIgnito:
                            break;
                        case ProgressBar.CPMulitCo:
                            break;
                        case ProgressBar.CPMultiCoExtended:
                            break;
                        case ProgressBar.CPMultiCoV1:
                            break;

                        case ProgressBar.CPPerfect:
                            break;

                        case ProgressBar.CPRotatingArc:
                            RotatingArcAngle_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPRotatingCompass:
                            RotatingCompassAngle_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPSupreme:
                            SP_Angle_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.CPDagger:
                            Animate(sender, e);
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            if (DagSmoothRotate)
                            {
                                DagSmoothAnimate(sender, e);
                            }
                            break;

                        case ProgressBar.CPDaggerV1:
                            DagUpAnimate(sender, e);
                            break;

                        case ProgressBar.IPIndeterminate:
                            break;
                        case ProgressBar.IPGoogle:
                            break;
                        case ProgressBar.IPV1:
                            break;
                        case ProgressBar.IPMacOSX:
                            break;
                        case ProgressBar.IPMacOSXOptimized:
                            break;
                        case ProgressBar.IPMatrix:
                            break;
                        case ProgressBar.IPSpinnerCircle:
                            break;
                        case ProgressBar.IPSpinnerDivided:
                            break;
                        case ProgressBar.IPUnique:
                            break;
                        case ProgressBar.IPVuvuzela:
                            break;
                        case ProgressBar.IPWin8Horizontal:
                            break;
                        case ProgressBar.IPWin8Ring:
                            break;

                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }

        #endregion


        #endregion

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                if (value == SmoothingMode.Invalid)
                {
                    value = SmoothingMode.HighQuality;
                }
                smoothing = value;
                Invalidate();
            }
        }



        #endregion

        #region Protected Overridden Events

        /// <summary>
        /// Handler for the event when the size of the control changes
        /// </summary>
        /// <param name="e">EventArgs</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        protected override void OnClientSizeChanged(EventArgs e)
        {

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPExtendedProgress:
                            break;
                        case ProgressBar.RPIndicator:
                            break;
                        case ProgressBar.RPiTunes:
                            break;
                        case ProgressBar.RPMaze:
                            break;
                        case ProgressBar.RPProgNormal:
                            break;
                        //case ProgressBar.RPProgBoxed:
                        //    break;
                        //case ProgressBar.RPProgGradient:
                        //    break;
                        case ProgressBar.RPAlter:
                            break;
                        case ProgressBar.RPClear:
                            break;
                        case ProgressBar.RPPerplex:
                            break;

                        case ProgressBar.RPRect:
                            break;

                        case ProgressBar.RPTransparent:
                            break;

                        case ProgressBar.RPSplitter:
                            break;

                        case ProgressBar.CPBarCircular:
                            break;
                        case ProgressBar.CPv2:
                            break;
                        case ProgressBar.CPv3:
                            break;
                        case ProgressBar.CPv4:
                            break;
                        case ProgressBar.CPv5:
                            CPv5_OnResize(e);
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    break;

                        case ProgressBar.CPGorgeous:
                            break;

                        case ProgressBar.CPMulitCo:
                            break;

                        case ProgressBar.CPMultiCoExtended:
                            break;

                        case ProgressBar.CPMultiCoV1:
                            break;

                        case ProgressBar.CPPerfect:
                            break;
                        case ProgressBar.CPProgressPie:
                            break;

                        case ProgressBar.CPRotatingArc:
                            break;
                        case ProgressBar.CPRotatingCompass:
                            break;
                        case ProgressBar.CPSupreme:
                            break;

                        case ProgressBar.CPBarCircularDefault:
                            break;

                        case ProgressBar.CPAwesome:
                            break;

                        case ProgressBar.CPIgnito:
                            break;

                        case ProgressBar.CPDagger:
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            break;

                        case ProgressBar.CPDaggerV1:
                            break;

                        case ProgressBar.IPIndeterminate:
                            break;
                        case ProgressBar.IPGoogle:
                            break;
                        case ProgressBar.IPMacOSX:
                            MaximumSpokeCount(MacOSX_MaxSpokes);
                            MacOSX_CalculateSpokes();

                            break;
                        case ProgressBar.IPMacOSXOptimized:
                            MacOSX_Optimized_CalculateSpokesPoints(MacOSX_MaxSpokes);
                            break;
                        case ProgressBar.IPMatrix:
                            MacOSX_Matrix_CalculateSpokesPoints(MacOSX_MaxSpokes);
                            break;
                        case ProgressBar.IPV1:
                            break;
                        case ProgressBar.IPUnique:
                            break;

                        case ProgressBar.IPVuvuzela:
                            break;

                        case ProgressBar.IPSpinnerCircle:
                            //LoadingCircle_Resize(e);
                            GenerateColorsPallet();
                            break;

                        case ProgressBar.IPSpinnerDivided:
                            ProgressDisk_SizeChanged(e);
                            break;

                        case ProgressBar.IPWin8Horizontal:
                            WinHR_OnResize(e);
                            break;

                        case ProgressBar.IPWin8Ring:
                            WinRing_OnResize(e);
                            break;


                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }




        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);


            switch (ProgressType)
            {
                case ProgressType.Bar:
                    {
                        //switch (SolidProgressBar)
                        //{
                        //    case ProgressBar.RPExtendedProgress:
                        //        Extended_Resize(e);
                        //        break;
                        //    default:
                        //        throw new ArgumentOutOfRangeException();
                        //}

                        switch (SolidProgressBar)
                        {
                            case ProgressBar.RPExtendedProgress:
                                Extended_Resize(e);
                                break;
                            case ProgressBar.RPIndicator:
                                break;
                            case ProgressBar.RPiTunes:
                                break;
                            case ProgressBar.RPMaze:
                                break;
                            case ProgressBar.RPProgNormal:
                                break;
                            //case ProgressBar.RPProgBoxed:
                            //    break;
                            //case ProgressBar.RPProgGradient:
                            //    break;
                            case ProgressBar.RPAlter:
                                break;
                            case ProgressBar.RPClear:
                                break;
                            case ProgressBar.RPRect:
                                break;
                            case ProgressBar.RPPerplex:
                                break;
                            case ProgressBar.RPTransparent:
                                break;
                            case ProgressBar.RPSplitter:
                                break;

                            case ProgressBar.CPBarCircular:
                                CircularProgressBar_SetStandardSize();

                                break;
                            case ProgressBar.CPv2:
                                break;
                            case ProgressBar.CPv3:
                                break;
                            case ProgressBar.CPv4:
                                break;
                            case ProgressBar.CPv5:
                                CPv5_OnResize(e);
                                break;
                            //case CircularProgress.CircularProgressv5aClock:
                            //    break;
                            case ProgressBar.CPBarCircularDefault:
                                CircularProgressBar_SetStandardSize();
                                break;
                            case ProgressBar.CPGorgeous:
                                break;

                            case ProgressBar.CPMulitCo:
                                break;

                            case ProgressBar.CPMultiCoExtended:
                                break;

                            case ProgressBar.CPMultiCoV1:
                                break;

                            case ProgressBar.CPPerfect:
                                ProgressBarPerfect_OnResize(e);
                                break;

                            case ProgressBar.CPProgressPie:
                                //ProgressPie_OnResize(e);
                                break;

                            case ProgressBar.CPRotatingArc:
                                RotatingArc_OnSizeChanged(e);
                                break;

                            case ProgressBar.CPRotatingCompass:
                                break;

                            case ProgressBar.CPSupreme:
                                break;

                            case ProgressBar.CPAwesome:
                                break;

                            case ProgressBar.CPIgnito:
                                break;

                            case ProgressBar.CPDagger:
                                break;

                            case ProgressBar.CPDaggerSmooth:
                                break;

                            case ProgressBar.CPDaggerV1:
                                break;

                            case ProgressBar.IPIndeterminate:
                                Indeterminate_Resize(e);
                                break;
                            case ProgressBar.IPGoogle:
                                Google_OnResize(e);
                                break;
                            case ProgressBar.IPMacOSX:
                                MacOSX_CalculateSpokes();
                                break;
                            case ProgressBar.IPMacOSXOptimized:
                                break;
                            case ProgressBar.IPMatrix:
                                break;
                            case ProgressBar.IPV1:
                                //ProgIndicatorV1_OnSizeChanged(e);
                                break;

                            case ProgressBar.IPUnique:
                                Unique_OnResize(e);
                                break;

                            case ProgressBar.IPVuvuzela:
                                break;

                            case ProgressBar.IPSpinnerCircle:
                                LoadingCircle_Resize(e);
                                GenerateColorsPallet();
                                break;

                            case ProgressBar.IPSpinnerDivided:
                                ProgressDisk_Resize(e);
                                break;

                            case ProgressBar.IPWin8Horizontal:
                                WinHR_OnResize(e);
                                break;

                            case ProgressBar.IPWin8Ring:
                                WinRing_OnResize(e);
                                break;

                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.SizeChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            //CircularProgressBar_SetStandardSize();

            switch (SolidProgressBar)
            {

                case ProgressBar.CPBarCircular:
                    CircularProgressBar_SetStandardSize();
                    break;
                case ProgressBar.CPv2:
                    SetStandardSize();
                    break;
                case ProgressBar.CPv3:
                    SetStandardSize();
                    break;
                case ProgressBar.CPv4:
                    SetStandardSize();
                    break;
                case ProgressBar.CPv5:
                    CPv5_OnResize(e);
                    SetStandardSize();
                    break;
                //case CircularProgress.CircularProgressv5aClock:
                //    break;

                case ProgressBar.CPGorgeous:
                    SetStandardSize();
                    break;

                case ProgressBar.CPMulitCo:
                    SetStandardSize();
                    break;

                case ProgressBar.CPMultiCoExtended:
                    SetStandardSize();
                    break;

                case ProgressBar.CPMultiCoV1:
                    SetStandardSize();
                    break;

                case ProgressBar.CPPerfect:
                    ProgressBarPerfect_OnSizeChanged(e);
                    break;

                case ProgressBar.CPProgressPie:
                    //ProgressPie_OnSizeChanged(e);
                    //SetStandardSize();
                    break;

                case ProgressBar.CPRotatingArc:
                    RotatingArc_OnSizeChanged(e);
                    break;

                case ProgressBar.CPRotatingCompass:
                    SetStandardSize();
                    break;

                case ProgressBar.CPSupreme:
                    SetStandardSize();
                    break;

                case ProgressBar.CPAwesome:
                    SetStandardSize();
                    break;

                case ProgressBar.CPIgnito:
                    SetStandardSize();
                    break;

                case ProgressBar.CPDagger:
                    SetStandardSize();
                    break;

                case ProgressBar.CPDaggerSmooth:
                    SetStandardSize();
                    break;

                case ProgressBar.CPDaggerV1:
                    SetStandardSize();
                    break;

                case ProgressBar.CPBarCircularDefault:
                    SetStandardSize();
                    break;

                case ProgressBar.IPIndeterminate:
                    SetStandardSize();
                    break;
                case ProgressBar.IPGoogle:
                    SetStandardSize();
                    break;
                case ProgressBar.IPMacOSX:
                    SetStandardSize();
                    break;
                case ProgressBar.IPMacOSXOptimized:
                    SetStandardSize();
                    break;
                case ProgressBar.IPMatrix:
                    SetStandardSize();
                    break;
                case ProgressBar.IPV1:
                    ProgIndicatorV1_OnSizeChanged(e); //Subject to change
                    break;
                case ProgressBar.IPUnique:
                    Unique_OnSizeChanged(e); //Subject to change
                    break;

                case ProgressBar.IPVuvuzela:
                    SetStandardSize();
                    break;

                case ProgressBar.IPSpinnerCircle:
                    LoadingCircle_Resize(e);
                    GenerateColorsPallet();

                    SetStandardSize(); // Subject to change
                    break;

                case ProgressBar.IPSpinnerDivided:
                    ProgressDisk_SizeChanged(e);

                    SetStandardSize(); // Subject to change

                    break;

                case ProgressBar.IPWin8Horizontal:
                    WinHR_OnResize(e);
                    break;

                case ProgressBar.IPWin8Ring:
                    WinRing_OnResize(e);
                    break;


                case ProgressBar.RPExtendedProgress:
                    break;
                case ProgressBar.RPIndicator:
                    break;
                case ProgressBar.RPiTunes:
                    break;
                case ProgressBar.RPMaze:
                    break;
                case ProgressBar.RPProgNormal:
                    ProgressBarNormal_OnSizeChanged(e);
                    break;
                //case ProgressBar.RPProgBoxed:
                //    ProgressBarNormal_OnSizeChanged(e);
                //    break;
                //case ProgressBar.RPProgGradient:
                //    ProgressBarNormal_OnSizeChanged(e);
                //    break;
                case ProgressBar.RPAlter:
                    break;
                case ProgressBar.RPClear:
                    break;
                case ProgressBar.RPPerplex:
                    break;
                case ProgressBar.RPRect:
                    break;
                case ProgressBar.RPTransparent:
                    break;
                case ProgressBar.RPSplitter:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }

        /// <summary>
        /// Handles the <see cref="E:PaintBackground" /> event.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            
            //Bitmap b = new Bitmap(1, 1);
            Graphics g = e.Graphics;

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;


            #region Peace Animator Easing For Value

            switch (EasingType)
            {
                case PeaceAnimatorEasing.BounceEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseIn;

                    break;
                case PeaceAnimatorEasing.BounceEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseInOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOutIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOutIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;

                    break;
                case PeaceAnimatorEasing.CircularEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;

                    break;
                case PeaceAnimatorEasing.CubicEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseOut;

                    break;
                case PeaceAnimatorEasing.Liner:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.Liner;

                    break;
                case PeaceAnimatorEasing.None:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.None;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuarticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuinticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseIn;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseOut;

                    break;
                default:
                    break;
            }

            #endregion

            
            #region Paint Codes

            #region New Concept Code
            switch (ProgressType)
            {
                case ProgressType.Bar:
                    {
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.RPExtendedProgress:
                                Extended_Paint(e);
                                break;

                            case ProgressBar.RPIndicator:
                                ZeroitIndicator_Paint(e);
                                break;

                            case ProgressBar.RPiTunes:
                                iTunes_Paint(e);
                                break;

                            case ProgressBar.RPMaze:
                                Maze_Paint(e);
                                break;

                            case ProgressBar.RPProgNormal:
                                ProgressBarNormal_Paint(e);
                                break;

                            //case ProgressBar.RPProgBoxed:
                            //    ProgressBarBoxed_Paint(e);
                            //    break;

                            //case ProgressBar.RPProgGradient:
                            //    ProgressBarGradient_Paint(e);
                            //    break;

                            case ProgressBar.RPAlter:
                                ProgressAlter_Paint(e);
                                break;

                            case ProgressBar.RPClear:
                                ProgressBarClear_Paint(e);
                                break;

                            case ProgressBar.RPPerplex:
                                ProgressBarPerplex_Paint(e);
                                break;

                            case ProgressBar.RPRect:
                                ProgressRect_Paint(e);
                                break;
                            case ProgressBar.RPTransparent:
                                Transparent_Paint(e);
                                break;

                            case ProgressBar.RPSplitter:
                                ProgressBarSplitter_OnPaint(e);
                                break;

                            case ProgressBar.CPAwesome:
                                ProgressAwesome_OnPaint(e);
                                break;

                            case ProgressBar.CPBarCircular:
                                ZeroitProgressCircular_Paint(e);
                                break;

                            //case CircularProgress.CircularProgressv5aClock:
                            //    CircularProgressv5aClock_Paint(e);
                            //    break;

                            case ProgressBar.CPBarCircularDefault:
                                ZeroitProgressBarCircularDefault_Paint(e);
                                break;

                            case ProgressBar.CPv2:
                                CPv2_Paint(e);
                                break;

                            case ProgressBar.CPv3:
                                CPv3_Paint(e);
                                break;

                            case ProgressBar.CPv4:
                                CPv4_Paint(e);
                                break;

                            case ProgressBar.CPv5:
                                CPv5_Paint(e);
                                break;

                            case ProgressBar.CPGorgeous:
                                Gorgeous_Paint(e);
                                break;

                            case ProgressBar.CPIgnito:
                                Ignito_Paint(e);
                                break;

                            case ProgressBar.CPMulitCo:
                                MultiCo_Paint(e);
                                break;

                            case ProgressBar.CPMultiCoExtended:
                                MultiCoExtended_Paint(e);
                                break;

                            case ProgressBar.CPMultiCoV1:
                                MCExV2_Paint(e);
                                break;


                            case ProgressBar.CPPerfect:
                                ProgressBarPerfect_Paint(e);
                                break;

                            case ProgressBar.CPProgressPie:
                                ProgressPie_Paint(e);
                                break;

                            case ProgressBar.CPRotatingArc:
                                RotatingArc_OnPaint(e);
                                break;

                            case ProgressBar.CPRotatingCompass:
                                RotatingCompass_OnPaint(e);
                                break;

                            case ProgressBar.CPSupreme:
                                SP_OnPaint(e);
                                break;

                            case ProgressBar.CPDagger:
                                Dagger_OnPaint(e);
                                break;

                            case ProgressBar.CPDaggerSmooth:
                                DagSmoothOnPaint(e);
                                break;

                            case ProgressBar.CPDaggerV1:
                                DagUpPaint(e);
                                break;

                            case ProgressBar.IPIndeterminate:
                                CircularIndeterminatePaint(e);
                                break;
                            case ProgressBar.IPGoogle:
                                Google_Paint(e);
                                break;
                            case ProgressBar.IPMacOSX:
                                MacOSX_Paint(e);
                                break;
                            case ProgressBar.IPMacOSXOptimized:
                                MacOSX_Optimized_Paint(e);
                                break;
                            case ProgressBar.IPMatrix:
                                MacOSX_Matrix_Paint(e);
                                break;

                            case ProgressBar.IPV1:
                                ProgIndicatorV1_OnPaint(e);
                                break;

                            case ProgressBar.IPUnique:
                                Unique_OnPaint(e);
                                break;

                            case ProgressBar.IPVuvuzela:
                                Vuvuzela_OnPaint(e);
                                break;

                            case ProgressBar.IPSpinnerCircle:
                                Spinner_OnPaint(e);
                                break;

                            case ProgressBar.IPSpinnerDivided:
                                ProgressDisk_Paint(e);
                                break;

                            case ProgressBar.IPWin8Horizontal:
                                WinHR_OnPaint(e);
                                break;

                            case ProgressBar.IPWin8Ring:
                                WinRing_OnPaint(e);
                                break;

                        }

                    }
                    break;

            }
            #endregion

            #endregion

            
            DrawImage(g, new Rectangle(0, 0, Width, Height));

            //e.Graphics.DrawImage(b, 0, 0);

            //g.Dispose();
            //b.Dispose();

            base.OnPaintBackground(e);

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            //ProgIndicator_animationSpeed.Enabled = this.Enabled;

            SpinningProgress_EnabledChanged(e);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //ProgIndicator_animationSpeed.Tick += ProgIndicator_AnimationSpeed_Tick;
            //ProgIndicator_animationSpeed.Start();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        protected override void OnPaint(PaintEventArgs e)
        {

            

            //Bitmap b = new Bitmap(1, 1);
            Graphics g = e.Graphics;

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;


            #region Peace Animator Easing For Value

            switch (EasingType)
            {
                case PeaceAnimatorEasing.BounceEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseIn;

                    break;
                case PeaceAnimatorEasing.BounceEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseInOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOutIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.BounceEaseOutIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;

                    break;
                case PeaceAnimatorEasing.CircularEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;

                    break;
                case PeaceAnimatorEasing.CubicEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.CubicEaseOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseOut;

                    break;
                case PeaceAnimatorEasing.Liner:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.Liner;

                    break;
                case PeaceAnimatorEasing.None:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.None;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuarticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuinticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseIn:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseIn;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseInOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseOut:
                    peaceAnimator.OneD_Path_Easing = AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseOut;

                    break;
                default:
                    break;
            }

            #endregion


            #region Paint Codes

            #region New Concept Code
            switch (ProgressType)
            {
                case ProgressType.Bar:
                    {
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.RPExtendedProgress:
                                Extended_Paint(e);
                                break;

                            case ProgressBar.RPIndicator:
                                ZeroitIndicator_Paint(e);
                                break;

                            case ProgressBar.RPiTunes:
                                iTunes_Paint(e);
                                break;

                            case ProgressBar.RPMaze:
                                Maze_Paint(e);
                                break;

                            case ProgressBar.RPProgNormal:
                                ProgressBarNormal_Paint(e);
                                break;

                            //case ProgressBar.RPProgBoxed:
                            //    ProgressBarBoxed_Paint(e);
                            //    break;

                            //case ProgressBar.RPProgGradient:
                            //    ProgressBarGradient_Paint(e);
                            //    break;

                            case ProgressBar.RPAlter:
                                ProgressAlter_Paint(e);
                                break;

                            case ProgressBar.RPClear:
                                ProgressBarClear_Paint(e);
                                break;

                            case ProgressBar.RPPerplex:
                                ProgressBarPerplex_Paint(e);
                                break;

                            case ProgressBar.RPRect:
                                ProgressRect_Paint(e);
                                break;
                            case ProgressBar.RPTransparent:
                                Transparent_Paint(e);
                                break;

                            case ProgressBar.RPSplitter:
                                ProgressBarSplitter_OnPaint(e);
                                break;

                            case ProgressBar.CPAwesome:
                                ProgressAwesome_OnPaint(e);
                                break;

                            case ProgressBar.CPBarCircular:
                                ZeroitProgressCircular_Paint(e);
                                break;

                            //case CircularProgress.CircularProgressv5aClock:
                            //    CircularProgressv5aClock_Paint(e);
                            //    break;

                            case ProgressBar.CPBarCircularDefault:
                                ZeroitProgressBarCircularDefault_Paint(e);
                                break;

                            case ProgressBar.CPv2:
                                CPv2_Paint(e);
                                break;

                            case ProgressBar.CPv3:
                                CPv3_Paint(e);
                                break;

                            case ProgressBar.CPv4:
                                CPv4_Paint(e);
                                break;

                            case ProgressBar.CPv5:
                                CPv5_Paint(e);
                                break;

                            case ProgressBar.CPGorgeous:
                                Gorgeous_Paint(e);
                                break;

                            case ProgressBar.CPIgnito:
                                Ignito_Paint(e);
                                break;

                            case ProgressBar.CPMulitCo:
                                MultiCo_Paint(e);
                                break;

                            case ProgressBar.CPMultiCoExtended:
                                MultiCoExtended_Paint(e);
                                break;

                            case ProgressBar.CPMultiCoV1:
                                MCExV2_Paint(e);
                                break;


                            case ProgressBar.CPPerfect:
                                ProgressBarPerfect_Paint(e);
                                break;

                            case ProgressBar.CPProgressPie:
                                ProgressPie_Paint(e);
                                break;

                            case ProgressBar.CPRotatingArc:
                                RotatingArc_OnPaint(e);
                                break;

                            case ProgressBar.CPRotatingCompass:
                                RotatingCompass_OnPaint(e);
                                break;

                            case ProgressBar.CPSupreme:
                                SP_OnPaint(e);
                                break;

                            case ProgressBar.CPDagger:
                                Dagger_OnPaint(e);
                                break;

                            case ProgressBar.CPDaggerSmooth:
                                DagSmoothOnPaint(e);
                                break;

                            case ProgressBar.CPDaggerV1:
                                DagUpPaint(e);
                                break;

                            case ProgressBar.IPIndeterminate:
                                CircularIndeterminatePaint(e);
                                break;
                            case ProgressBar.IPGoogle:
                                Google_Paint(e);
                                break;
                            case ProgressBar.IPMacOSX:
                                MacOSX_Paint(e);
                                break;
                            case ProgressBar.IPMacOSXOptimized:
                                MacOSX_Optimized_Paint(e);
                                break;
                            case ProgressBar.IPMatrix:
                                MacOSX_Matrix_Paint(e);
                                break;

                            case ProgressBar.IPV1:
                                ProgIndicatorV1_OnPaint(e);
                                break;

                            case ProgressBar.IPUnique:
                                Unique_OnPaint(e);
                                break;

                            case ProgressBar.IPVuvuzela:
                                Vuvuzela_OnPaint(e);
                                break;

                            case ProgressBar.IPSpinnerCircle:
                                Spinner_OnPaint(e);
                                break;

                            case ProgressBar.IPSpinnerDivided:
                                ProgressDisk_Paint(e);
                                break;

                            case ProgressBar.IPWin8Horizontal:
                                WinHR_OnPaint(e);
                                break;

                            case ProgressBar.IPWin8Ring:
                                WinRing_OnPaint(e);
                                break;

                        }

                    }
                    break;

            }
            #endregion


            #endregion

            DrawImage(g, new Rectangle(0, 0, Width, Height));

            //e.Graphics.DrawImage(b, 0, 0);

            //g.Dispose();
            //b.Dispose();

            base.OnPaint(e);

        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.Control" /> and its child controls and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            peaceAnimator.Dispose();

            Helper.MultiDispose(peaceAnimator, timer);

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPExtendedProgress:
                            break;
                        case ProgressBar.RPIndicator:
                            break;
                        case ProgressBar.RPiTunes:
                            break;
                        case ProgressBar.RPMaze:
                            break;
                        case ProgressBar.RPProgNormal:
                            ProgressBarNormal_Dispose(disposing);
                            break;
                        //case ProgressBar.RPProgBoxed:
                        //    ProgressBarNormal_Dispose(disposing);
                        //    break;
                        //case ProgressBar.RPProgGradient:
                        //    ProgressBarNormal_Dispose(disposing);
                        //    break;
                        case ProgressBar.RPAlter:
                            break;
                        case ProgressBar.RPClear:
                            break;
                        case ProgressBar.RPPerplex:
                            break;
                        case ProgressBar.RPRect:
                            break;
                        case ProgressBar.RPTransparent:
                            break;
                        case ProgressBar.RPSplitter:
                            //ProgressBarSplitter_Dispose(disposing);
                            break;

                        case ProgressBar.CPBarCircular:
                            break;
                        case ProgressBar.CPv2:
                            break;
                        case ProgressBar.CPv3:
                            break;
                        case ProgressBar.CPv4:
                            break;
                        case ProgressBar.CPv5:
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    break;
                        case ProgressBar.CPGorgeous:
                            break;
                        case ProgressBar.CPIgnito:
                            break;
                        case ProgressBar.CPMulitCo:
                            break;
                        case ProgressBar.CPMultiCoExtended:
                            break;
                        case ProgressBar.CPMultiCoV1:
                            break;
                        case ProgressBar.CPAwesome:
                            break;
                        case ProgressBar.CPPerfect:
                            break;
                        case ProgressBar.CPProgressPie:
                            break;
                        case ProgressBar.CPRotatingArc:
                            break;
                        case ProgressBar.CPRotatingCompass:
                            break;
                        case ProgressBar.CPSupreme:
                            break;

                        case ProgressBar.CPBarCircularDefault:
                            break;

                        case ProgressBar.CPDagger:
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            break;

                        case ProgressBar.CPDaggerV1:
                            break;

                        case ProgressBar.IPIndeterminate:
                            break;
                        case ProgressBar.IPGoogle:
                            break;
                        case ProgressBar.IPMacOSX:
                            break;
                        case ProgressBar.IPMacOSXOptimized:
                            break;
                        case ProgressBar.IPMatrix:
                            break;
                        case ProgressBar.IPV1:
                            break;
                        case ProgressBar.IPUnique:
                            break;
                        case ProgressBar.IPVuvuzela:
                            break;
                        case ProgressBar.IPSpinnerCircle:
                            break;
                        case ProgressBar.IPSpinnerDivided:
                            break;
                        case ProgressBar.IPWin8Horizontal:
                            break;
                        case ProgressBar.IPWin8Ring:
                            break;

                    }
                    break;

            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ControlRemoved" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.ControlEventArgs" /> that contains the event data.</param>
        protected override void OnControlRemoved(ControlEventArgs e)
        {

            base.OnControlRemoved(e);

            WinHR_memory_cleanup();

            WinRing_memory_cleanup();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.RPAlter:
                            break;
                        case ProgressBar.RPClear:
                            break;
                        case ProgressBar.RPExtendedProgress:
                            break;
                        case ProgressBar.RPiTunes:
                            break;
                        case ProgressBar.RPMaze:
                            break;
                        case ProgressBar.RPPerplex:
                            break;
                        //case ProgressBar.RPProgBoxed:
                        //    break;
                        //case ProgressBar.RPProgGradient:
                        //    break;
                        case ProgressBar.RPProgNormal:
                            break;
                        case ProgressBar.RPRect:
                            break;
                        case ProgressBar.RPSplitter:
                            break;
                        case ProgressBar.RPTransparent:
                            break;
                        case ProgressBar.RPIndicator:
                            break;

                        case ProgressBar.CPAwesome:
                            break;
                        case ProgressBar.CPv2:
                            break;
                        case ProgressBar.CPv3:
                            break;
                        case ProgressBar.CPv4:
                            break;
                        case ProgressBar.CPv5:
                            break;
                        //case CircularProgress.CircularProgressv5aClock:
                        //    break;
                        case ProgressBar.CPGorgeous:
                            break;
                        case ProgressBar.CPIgnito:
                            break;
                        case ProgressBar.CPMulitCo:
                            break;
                        case ProgressBar.CPMultiCoExtended:
                            break;
                        case ProgressBar.CPMultiCoV1:
                            break;
                        case ProgressBar.CPPerfect:
                            break;
                        case ProgressBar.CPProgressPie:
                            break;
                        case ProgressBar.CPRotatingArc:
                            break;
                        case ProgressBar.CPRotatingCompass:
                            break;
                        case ProgressBar.CPSupreme:
                            break;
                        case ProgressBar.CPBarCircular:
                            break;
                        case ProgressBar.CPBarCircularDefault:
                            break;

                        case ProgressBar.CPDagger:
                            break;

                        case ProgressBar.CPDaggerSmooth:
                            break;

                        case ProgressBar.CPDaggerV1:
                            break;


                        case ProgressBar.IPIndeterminate:
                            break;
                        case ProgressBar.IPGoogle:
                            break;
                        case ProgressBar.IPV1:
                            ProgIndicatorV1_OnSizeChanged(e);
                            break;
                        case ProgressBar.IPMacOSX:
                            break;
                        case ProgressBar.IPMacOSXOptimized:
                            break;
                        case ProgressBar.IPMatrix:
                            break;
                        case ProgressBar.IPSpinnerCircle:
                            break;
                        case ProgressBar.IPSpinnerDivided:
                            break;
                        case ProgressBar.IPUnique:
                            break;
                        case ProgressBar.IPVuvuzela:
                            break;
                        case ProgressBar.IPWin8Horizontal:
                            break;
                        case ProgressBar.IPWin8Ring:
                            break;
                            //default:
                            //    throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }

        #endregion

        #region EventHandler
        /////Implement this in the Property you want to trigger the event///////////////////////////
        // 
        //  For Example this will be triggered by the Value Property
        //
        //  public int Value
        //   { 
        //      get { return _value;}
        //      set
        //         {
        //          
        //              _value = value;
        //
        //              this.OnValueChanged(EventArgs.Empty);
        //              Invalidate();
        //          }
        //    }
        //
        ////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// The on value changed
        /// </summary>
        private EventHandler onValueChanged;

        /// <summary>
        /// Triggered when the Value changes
        /// </summary>

        public event EventHandler ValueChanged
        {
            add
            {
                this.onValueChanged = this.onValueChanged + value;
            }
            remove
            {
                this.onValueChanged = this.onValueChanged - value;
            }
        }

        /// <summary>
        /// Handles the <see cref="E:ValueChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (this.onValueChanged == null)
                return;
            this.onValueChanged((object)this, e);
        }

        #endregion

        #region Include in Private Field

        /// <summary>
        /// The allow transparency
        /// </summary>
        private bool allowTransparency = true;

        #endregion

        #region Include in Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [enable transparency].
        /// </summary>
        /// <value><c>true</c> if [enable transparency]; otherwise, <c>false</c>.</value>
        public bool EnableTransparency
        {
            get { return allowTransparency; }
            set
            {
                allowTransparency = value;

                Invalidate();
            }
        }

        #endregion






       
        #region Include in Paint

        //-----------------------------Include in Paint--------------------------//
        //
        // if(AllowTransparency)
        //  {
        //    MakeTransparent(this,g);
        //  }
        //
        //-----------------------------Include in Paint--------------------------//

        private static void MakeTransparent(Control control, Graphics g)
        {
            var parent = control.Parent;
            if (parent == null) return;
            var bounds = control.Bounds;
            var siblings = parent.Controls;
            int index = siblings.IndexOf(control);
            Bitmap behind = null;
            for (int i = siblings.Count - 1; i > index; i--)
            {
                var c = siblings[i];
                if (!c.Bounds.IntersectsWith(bounds)) continue;
                if (behind == null)
                    behind = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                c.DrawToBitmap(behind, c.Bounds);
            }
            if (behind == null) return;
            g.DrawImage(behind, control.ClientRectangle, bounds, GraphicsUnit.Pixel);
            behind.Dispose();
        }

        #endregion




    }

}
