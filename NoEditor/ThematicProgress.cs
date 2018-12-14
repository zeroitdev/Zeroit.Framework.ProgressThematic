using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Zeroit.Framework.Transitions.WinformAnimation;
using System.ComponentModel.Design;
using Zeroit.Framework.ProgressThematic.FormEditors;
//using Zeroit.Framework.ProgressThematic;

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    [Designer(typeof(ThematicProgressDesigner))]
    public partial class ThematicProgress : Control
    {
        
        #region Construtor

        public ThematicProgress()
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
                peaceAnimator.OneDProperty = Transitions.WinFormAnimation.Animator.KnownProperties.Value;
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
                peaceAnimator.OneDProperty = Transitions.WinFormAnimation.Animator.KnownProperties.Value;
                peaceAnimator.StartValue = 0;
                peaceAnimator.EndValue = Maximum;
                peaceAnimator.PropertyName = "Value";
            }


            #endregion

            #region AutoAnimate
            if (DesignMode)
            {
                timer.Tick += Timer_Tick;
                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }

            if (!DesignMode)
            {
                timer.Tick += Timer_Tick;

                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }



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

        }

        #endregion

        #region Private Fields
        PeaceAnimator peaceAnimator = new PeaceAnimator();
        PeaceAnimator transparencyAnimator = new PeaceAnimator();


        private ProgressType progressType = ProgressType.Circular;
        private CircularProgress circularProgressType = CircularProgress.Awesome;
        private ProgressIndicator indicatorType = ProgressIndicator.CircularIndeterminate;
        private ProgressBar solidBars = ProgressBar.ExtendedProgress;

        private bool fixedSize = false;

        private bool _allowTransparency = false;

        private bool autoIncrement = false;

        private float startingAngle = 270f;

        private int[] speed = new int[]
        {
            100,
            100,
            5000
        };

        private ProgressThematic.WithoutEditor.drawMode _drawMode = ProgressThematic.WithoutEditor.drawMode.Solid;

        private ProgressThematic.WithoutEditor.PeaceAnimatorEasing _easingType = ProgressThematic.WithoutEditor.PeaceAnimatorEasing.BounceEaseIn;

        private ProgressThematic.WithoutEditor.transparencyEasingType _transparencyEasingType = ProgressThematic.WithoutEditor.transparencyEasingType.BounceEaseIn;

        private int transparency = 255;

        private bool transparencyAnimatorGlow = false;

        private float _Value = 0;

        private float _Maximum = 100;

        float _Minimum = 0;

        private string postFix = "%";

        //private int interval = 100;

        private bool showText = false;

        #region HatchBrush

        private Color hatchBrushgradient1 = Color.FromArgb(254, 84, 84);
        private Color hatchBrushgradient2 = Color.DeepPink;

        private ProgressThematic.ThematicProgress.HatchBrushType hatchBrushType = ProgressThematic.ThematicProgress.HatchBrushType.ForwardDiagonal;

        private bool autoAnimate = false;
        private bool autoAnimateStatingAngle = false;

        private bool dummyBool = false;
        #endregion



        #endregion

        #region Public Properties
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowText
        {
            get { return showText; }
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
                showText = value;
                Invalidate();
            }
        }


        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AllowTransparency
        {
            get { return _allowTransparency; }
            set
            {
                _allowTransparency = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float Value
        {
            get { return _Value; }
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
                    case ProgressBar.ExtendedProgress:
                        break;
                    case ProgressBar.ZeroitIndicator:
                        break;
                    case ProgressBar.iTunes:
                        break;
                    case ProgressBar.Maze:
                        break;
                    case ProgressBar.ProgressNormal:
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
                        _iPercent = ((value)/Maximum)*(100f);
                        break;
                    case ProgressBar.ProgressBoxed:
                        int Temps = ProgressBarBoxed_MaxBlockToDraw;
                        _TurnOffInvalidation = true;
                        Value = value;
                        ProgressBarBoxed_ComputeMaxBlockToDraw();
                        if (ProgressBarBoxed_MaxBlockToDraw == Temps)
                            _TurnOffInvalidation = true;
                        ProgressBarNormal_Invalidate();
                        break;
                    case ProgressBar.ProgressGradient:
                        break;
                    case ProgressBar.Alter:
                        break;
                    case ProgressBar.Clear:
                        break;
                    case ProgressBar.Perplex:
                        break;
                    case ProgressBar.ProgressRect:
                        break;

                    case ProgressBar.Transparent:
                        break;

                    case ProgressBar.Splitter:
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }

                _Value = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value < 1)
                    value = 1;

                switch (ProgressType)
                {
                    case ProgressType.Bar:
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.ExtendedProgress:
                                break;
                            case ProgressBar.ZeroitIndicator:
                                break;
                            case ProgressBar.iTunes:
                                break;
                            case ProgressBar.Maze:
                                break;
                            case ProgressBar.ProgressNormal:
                                break;
                            case ProgressBar.ProgressBoxed:
                                break;
                            case ProgressBar.ProgressGradient:
                                break;
                            case ProgressBar.Alter:
                                break;
                            case ProgressBar.Clear:
                                break;
                            case ProgressBar.ProgressRect:
                                break;
                            case ProgressBar.Perplex:
                                break;
                            case ProgressBar.Transparent:
                                break;
                            case ProgressBar.Splitter:
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case ProgressType.Circular:
                        switch (CircularProgressType)
                        {
                            case CircularProgress.ZeroitProgressBarCircular:
                                break;
                            case CircularProgress.CircularProgressv2:
                                break;
                            case CircularProgress.CircularProgressv3:
                                break;
                            case CircularProgress.CircularProgressv4:
                                break;
                            case CircularProgress.CircularProgressv5:
                                break;
                            case CircularProgress.CircularProgressv5aClock:
                                break;
                            case CircularProgress.GorgeousProgress:
                                break;
                            case CircularProgress.Ignito:
                                break;
                            case CircularProgress.MulitCo:
                                break;
                            case CircularProgress.MultiCoExtended:
                                break;
                            case CircularProgress.MultiCoV1:
                                break;
                            case CircularProgress.Awesome:
                                break;
                            case CircularProgress.Perfect:
                                break;
                            case CircularProgress.ProgressPie:
                                break;
                            case CircularProgress.RotatingArc:
                                break;
                            case CircularProgress.RotatingCompass:
                                break;
                            case CircularProgress.SupremeCircle:
                                break;
                            case CircularProgress.ZeroitProgressBarCircularDefault:
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case ProgressType.Indicator:
                        switch (ProgressIndicator)
                        {
                            case ProgressIndicator.CircularIndeterminate:
                                break;
                            case ProgressIndicator.GoogleProgressIndicator:
                                break;
                            case ProgressIndicator.MacOSX:
                                MaximumSpokeCount(value);
                                break;
                            case ProgressIndicator.MacOSXOptimized:
                                MacOSX_Optimized_CalculateSpokesPoints(value);
                                break;
                            case ProgressIndicator.Matrix:
                                MacOSX_Matrix_CalculateSpokesPoints(value);
                                break;
                            case ProgressIndicator.IndicatorV1:
                                break;
                            case ProgressIndicator.Unique:
                                break;
                            case ProgressIndicator.Vuvuzela:
                                break;
                            case ProgressIndicator.SpinnerCircle:
                                break;
                            case ProgressIndicator.SpinnerDivided:
                                break;
                            case ProgressIndicator.Win8Horizontal:
                                break;
                            case ProgressIndicator.Win8Ring:
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                _Maximum = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _Minimum = value;
                Invalidate();
            }
        }


        #region HatchBrush Property

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ProgressThematic.ThematicProgress.HatchBrushType HatchBrush
        {
            get
            {
                return hatchBrushType;
            }

            set
            {
                hatchBrushType = value;
                Invalidate();
            }
        }
        #endregion


        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Glow
        {
            get { return transparencyAnimatorGlow; }
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

                transparencyAnimatorGlow = value;
                Invalidate();
            }
        }
        

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Boolean FixedSize
        {
            get { return fixedSize; }
            set
            {
                fixedSize = value;
                this.Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int FillTransparency
        {
            get { return transparency; }
            set
            {
                transparency = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ProgressThematic.WithoutEditor.drawMode DrawMode
        {
            get { return _drawMode; }
            set
            {
                _drawMode = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public PeaceAnimatorEasing EasingType
        {
            get { return _easingType; }
            set
            {

                _easingType = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public transparencyEasingType TransparentEasing
        {
            get { return _transparencyEasingType; }
            set
            {
                _transparencyEasingType = value;
                Invalidate();
            }
        }
        
        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool AutoIncrement
        {
            get { return autoIncrement; }
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

                autoIncrement = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int[] AnimationSpeed
        {
            get { return speed; }
            set
            {
                if (DesignMode)
                {
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

                    speed = value;
                    Invalidate();
                }

                if (!DesignMode)
                {
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

                    speed = value;
                    Invalidate();
                }

                
            }
        }


        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = TextRendering;
        #endregion

        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }
        #endregion
        

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ProgressType ProgressType
        {
            get { return progressType; }
            set
            {
                progressType = value;
                this.Invalidate();
            }
        }


        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public CircularProgress CircularProgressType
        {
            get { return circularProgressType; }
            set
            {
                circularProgressType = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ProgressBar SolidProgressBar
        {
            get { return solidBars; }
            set
            {
                solidBars = value;
                Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ProgressIndicator ProgressIndicator
        {
            get { return indicatorType; }
            set
            {
                indicatorType = value;
                //Invalidate();
            }
        }

        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string PostFix
        {
            get { return postFix; }
            set
            {
                postFix = value;
                Invalidate();
            }
        }
        
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
                Info = value;
                base.Text = value; 
                
            }
        }
        /// <summary>
        ///     Gets or sets the font of text in the <see cref="CircularProgressBar" />.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Drawing.Font" /> of the text. The default is the font set by the container.
        /// </returns>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }
        [Category("General Progress Information")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float StartingAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
                Invalidate();
            }
        }

        [Description("Text Color"), Category("ProgressApearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
                //    case ProgressBar.ExtendedProgress:
                //        break;
                //    case ProgressBar.ZeroitIndicator:
                //        break;
                //    case ProgressBar.iTunes:
                //        break;
                //    case ProgressBar.Maze:
                //        break;
                //    case ProgressBar.ProgressNormal:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    case ProgressBar.ProgressBoxed:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    case ProgressBar.ProgressGradient:
                //        xBrushes[BrushText] = new SolidBrush(value);
                //        break;
                //    default:
                //        throw new ArgumentOutOfRangeException();
                //}

                xBrushes[BrushText] = new SolidBrush(value);

                base.ForeColor = value;
            }
        }


        private ProgressType progType = ProgressType.Circular;
        [RefreshProperties(RefreshProperties.Repaint)]
        public ProgressType ProgType
        {
            get { return progType; }
            set
            {
                progType = value;
                this.Invalidate();
            }
        }

        private CircularProgress cirCType = CircularProgress.SupremeCircle;
        public CircularProgress CircType
        {
            get { return cirCType; }
            set
            {
                cirCType = value;
                Invalidate();
            }
        }

        private ProgressBar progbar = ProgressBar.ExtendedProgress;
        public ProgressBar ProgBar
        {
            get { return progbar; }
            set
            {
                progbar = value;
                Invalidate();
            }
        }

        private ProgressIndicator progIndicate = ProgressIndicator.CircularIndeterminate;
        public ProgressIndicator ProgIndicate
        {
            get { return progIndicate; }
            set
            {
                progIndicate = value;
                Invalidate();
            }
        }

        
        #endregion

        #region Private Methods

        private void CircularProgressBar_SetStandardSize()
        {
            if (FixedSize)
            {
                int _Size = Math.Max(Width, Height);
                Size = new Size(_Size, _Size);
            }

        }


        #endregion

        #region Timer

        //AutoAnimate
        #region Include in Private Field


        //private bool AutoAnimate = false;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties
        [Category("General Progress Information")]
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                //heartAutoAnimate = true;

                if (value == true)
                {
                    timer.Enabled = true;
                    timer_running = timer.Enabled;
                    
                    //heartTimer.Enabled = true;

                    rotateColor.Enabled = true;

                    
                    //Unique_Start();

                    switch (CircularProgressType)
                    {
                        case CircularProgress.CircularProgressv5:
                            CPv5_timer1.Enabled = true;
                            CPv5_timer2.Enabled = true;
                            CPv5_timer3.Enabled = true;
                            CPv5_timer4.Enabled = true;
                            break;
                        case CircularProgress.Perfect:
                            ProgressPerfect_Start();

                            break;
                        
                    }

                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.GoogleProgressIndicator:
                            timerInnerCircle.Enabled = true;
                            break;

                        case ProgressIndicator.SpinnerCircle:
                            timer.Enabled= false;
                            timer.Stop();
                            Spinner_Active = true;
                            break;

                        case ProgressIndicator.SpinnerDivided:
                            timer.Enabled = false;
                            Automate = true;
                            break;

                        case ProgressIndicator.Unique:
                            _stopped = false;
                            break;

                        case ProgressIndicator.Win8Horizontal:
                            //WinHR_Animate = true;
                            WinHR_timer.Enabled = true;
                            WinHR_timer.Start();
                            break;
                        case ProgressIndicator.Win8Ring:
                            WinRing_Animate = true;
                            break;
                    }
                }

                else
                {
                    timer.Enabled = false;

                    //heartTimer.Enabled = false;

                    
                    switch (CircularProgressType)
                    {
                        case CircularProgress.CircularProgressv5:
                            CPv5_timer1.Enabled = false;
                            CPv5_timer2.Enabled = false;
                            CPv5_timer3.Enabled = false;
                            CPv5_timer4.Enabled = false;
                            break;

                        case CircularProgress.Perfect:
                            ProgressPerfect_Stop();
                            break;
                        
                    }

                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.GoogleProgressIndicator:
                            timerInnerCircle.Enabled = false;
                            break;

                        case ProgressIndicator.SpinnerCircle:
                            Spinner_Active = false;
                            break;

                        case ProgressIndicator.SpinnerDivided:
                            timer.Enabled = false;
                            Automate = false;
                            break;

                        case ProgressIndicator.Unique:
                            _stopped = true;
                            break;

                        case ProgressIndicator.Win8Horizontal:
                            //WinHR_Animate = false;
                            WinHR_timer.Enabled = false;
                            WinHR_timer.Stop();
                            break;

                        case ProgressIndicator.Win8Ring:
                            WinRing_Animate = false;
                            break;
                    }

                    rotateColor.Enabled = false;
                }


                UpdateStyles();
                Invalidate();

                
            }
        }


        //public int Interval
        //{
        //    get { return timer.Interval; }
        //    set
        //    {
        //        timer.Interval = value;
        //        Invalidate();
        //    }
        //}
        #endregion

        #region Timer Event

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.ExtendedProgress:

                            Extended_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.ZeroitIndicator:
                            ZeroitIndicator_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.iTunes:
                            iTunes_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Maze:
                            Maze_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.ProgressNormal:
                            ProgressNormal_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.ProgressBoxed:
                            ProgressNormal_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.ProgressGradient:
                            ProgressNormal_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Alter:
                            ProgressAlter_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Clear:
                            ProgressBarClear_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Perplex:
                            ProgressBarPerplex_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.ProgressRect:
                            ProgressRect_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Transparent:
                            Transparent_Timer_Tick(sender, e);
                            break;

                        case ProgressBar.Splitter:
                            ProgressBarSplitter_Timer_Tick(sender, e);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();

                    }

                    break;

                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            Pulse(sender, e);
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                        
                            GoogleProgress_Timer_Tick(sender, e);
                            
                            break;
                        case ProgressIndicator.MacOSX:
                            MacOSX_Timer_Tick(sender, e);
                            break;

                        case ProgressIndicator.MacOSXOptimized:
                            MacOSX_Optimized_Timer_Tick(sender, e);
                            break;

                        case ProgressIndicator.Matrix:
                            MacOSX_Matrix_Timer_Tick(sender, e);
                            break;

                        case ProgressIndicator.IndicatorV1:
                            ProgIndicatorV1_AnimationSpeed_Tick(sender, e);
                            break;

                        case ProgressIndicator.Unique:
                            Unique_timerAnimation_Tick(sender, e);
                            break;

                        case ProgressIndicator.Vuvuzela:
                            Vuvuzela_Timer_Tick(sender, e);
                            break;

                        case ProgressIndicator.SpinnerCircle:
                            aTimer_Tick(sender, e);
                            break;

                        case ProgressIndicator.Win8Horizontal:
                            break;
                        case ProgressIndicator.Win8Ring:
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();

                    }
                    break;

                case ProgressType.Circular:
                    switch (CircularProgressType)
                    {
                        
                        case CircularProgress.ZeroitProgressBarCircular:

                            #region Value Increment for ZeroitProgressCircular
                            if (this.Value + 1 > this.Maximum)
                            {
                                this.Value = 0;
                            }

                            else
                            {
                                this.Value++;
                                Invalidate();
                            }
                            #endregion

                            break;
                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            CircularDef_Timer_Tick(sender, e);
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            CircularProgressv5aClock_Timer_Tick(sender, e);
                            break;
                        case CircularProgress.CircularProgressv2:
                            CPv2_Timer_Tick(sender, e);
                            break;
                        case CircularProgress.CircularProgressv3:
                            CPv3_Timer_Tick(sender, e);
                            break;
                        case CircularProgress.CircularProgressv4:
                            CPv4_Timer_Tick(sender, e);
                            break;
                        case CircularProgress.CircularProgressv5:
                            CPv5_Timer_Tick(sender, e);
                            CPv5_Timer_Tick1(sender, e);
                            CPv5_Timer_Tick2(sender, e);
                            CPv5_Timer_Tick3(sender, e);
                            CPv5_Timer_Tick4(sender, e);
                            CPv5_MarqueeTimer_Tick(sender, e);
                            break;
                            
                        case CircularProgress.GorgeousProgress:
                            Gorgeous_Timer_Tick(sender, e);
                            break;
                            
                        case CircularProgress.Ignito:
                            Ignito_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.MulitCo:
                            MultiCo_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.MultiCoExtended:
                            MultiCoExtended_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.MultiCoV1:
                            MCExV2_Timer_Tick(sender,e);
                            break;

                        case CircularProgress.Awesome:
                            timerAnimation_Tick(sender, e);
                            break;

                        case CircularProgress.Perfect:
                            //timer.Enabled = false;
                            ProgressPerfect_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.ProgressPie:
                            ProgressBarPie_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.RotatingArc:
                            RotatingArc_Timer_Tick(sender, e);
                            //RotatingArc_HeartBeatTimer_Tick(sender, e);
                            break;

                        case CircularProgress.RotatingCompass:
                            RotatingCompass_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.SupremeCircle:
                            SP_Timer_Tick(sender, e);
                            break;


                        default:
                            throw new ArgumentOutOfRangeException();

                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }



        }

        #endregion

        //Animate_Indeterminate Start Angle
        #region Include in Private Field


        //private bool AnimateStartAngle = false;
        private System.Windows.Forms.Timer timerStartingAngle = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        public bool AnimateStartAngle
        {
            get { return autoAnimateStatingAngle; }
            set
            {
                autoAnimateStatingAngle = value;

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
                        case ProgressBar.ExtendedProgress:
                            break;
                        case ProgressBar.ZeroitIndicator:
                            break;
                        case ProgressBar.iTunes:
                            break;
                        case ProgressBar.Maze:
                            break;
                        case ProgressBar.ProgressNormal:
                            break;
                        case ProgressBar.ProgressBoxed:
                            break;
                        case ProgressBar.ProgressGradient:
                            break;
                        case ProgressBar.Alter:
                            break;
                        case ProgressBar.Clear:
                            break;
                        case ProgressBar.Perplex:
                            break;
                        case ProgressBar.ProgressRect:
                            break;
                        case ProgressBar.Splitter:
                            break;
                        case ProgressBar.Transparent:
                            break;
                        
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case ProgressType.Circular:
                    switch (CircularProgressType)
                    {
                        case CircularProgress.Awesome:
                            break;
                        
                        case CircularProgress.ZeroitProgressBarCircular:
                            break;
                        case CircularProgress.CircularProgressv2:

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
                        case CircularProgress.CircularProgressv3:
                            break;
                        case CircularProgress.CircularProgressv4:
                            break;
                        case CircularProgress.CircularProgressv5:
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            break;
                        
                        case CircularProgress.GorgeousProgress:
                            Gorgeous_Timer_Tick_StartAngle(sender, e);
                            break;
                        
                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            break;
                        case CircularProgress.Ignito:
                            break;
                        case CircularProgress.MulitCo:
                            break;
                        case CircularProgress.MultiCoExtended:
                            break;
                        case CircularProgress.MultiCoV1:
                            break;

                        case CircularProgress.Perfect:
                            break;

                        case CircularProgress.RotatingArc:
                            RotatingArcAngle_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.RotatingCompass:
                            RotatingCompassAngle_Timer_Tick(sender, e);
                            break;

                        case CircularProgress.SupremeCircle:
                            SP_Angle_Timer_Tick(sender, e);
                            break;
                            
                    }
                    break;
                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                            break;
                        case ProgressIndicator.IndicatorV1:
                            break;
                        case ProgressIndicator.MacOSX:
                            break;
                        case ProgressIndicator.MacOSXOptimized:
                            break;
                        case ProgressIndicator.Matrix:
                            break;
                        case ProgressIndicator.SpinnerCircle:
                            break;
                        case ProgressIndicator.SpinnerDivided:
                            break;
                        case ProgressIndicator.Unique:
                            break;
                        case ProgressIndicator.Vuvuzela:
                            break;
                        case ProgressIndicator.Win8Horizontal:
                            break;
                        case ProgressIndicator.Win8Ring:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }

        #endregion


        #endregion

        #region Smoothing Mode

        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

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
        protected override void OnClientSizeChanged(EventArgs e)
        {

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.ExtendedProgress:
                            break;
                        case ProgressBar.ZeroitIndicator:
                            break;
                        case ProgressBar.iTunes:
                            break;
                        case ProgressBar.Maze:
                            break;
                        case ProgressBar.ProgressNormal:
                            break;
                        case ProgressBar.ProgressBoxed:
                            break;
                        case ProgressBar.ProgressGradient:
                            break;
                        case ProgressBar.Alter:
                            break;
                        case ProgressBar.Clear:
                            break;
                        case ProgressBar.Perplex:
                            break;

                        case ProgressBar.ProgressRect:
                            break;

                        case ProgressBar.Transparent:
                            break;

                        case ProgressBar.Splitter:
                            break;

                        default:
                            //throw new ArgumentOutOfRangeException();
                            break;
                    }
                    break;

                case ProgressType.Circular:
                    switch (CircularProgressType)
                    {
                        
                        case CircularProgress.ZeroitProgressBarCircular:
                            break;
                        case CircularProgress.CircularProgressv2:
                            break;
                        case CircularProgress.CircularProgressv3:
                            break;
                        case CircularProgress.CircularProgressv4:
                            break;
                        case CircularProgress.CircularProgressv5:
                            CPv5_OnResize(e);
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            break;
                        
                        case CircularProgress.GorgeousProgress:
                            break;
                        
                        case CircularProgress.MulitCo:
                            break;

                        case CircularProgress.MultiCoExtended:
                            break;

                        case CircularProgress.MultiCoV1:
                            break;

                        case CircularProgress.Perfect:
                            break;
                        case CircularProgress.ProgressPie:
                            break;

                        case CircularProgress.RotatingArc:
                            break;
                        case CircularProgress.RotatingCompass:
                            break;
                        case CircularProgress.SupremeCircle:
                            break;

                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            break;

                        case CircularProgress.Awesome:
                            break;

                        case CircularProgress.Ignito:
                            break;
                            
                        default:
                            //throw new ArgumentOutOfRangeException();
                            break;
                    }
                    break;

                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                            break;
                        case ProgressIndicator.MacOSX:
                            MacOSX_CalculateSpokes();
                            break;
                        case ProgressIndicator.MacOSXOptimized:
                            MacOSX_Optimized_CalculateSpokesPoints();
                            break;
                        case ProgressIndicator.Matrix:
                            MacOSX_Matrix_CalculateSpokesPoints();
                            break;
                        case ProgressIndicator.IndicatorV1:
                            break;
                        case ProgressIndicator.Unique:
                            break;

                        case ProgressIndicator.Vuvuzela:
                            break;

                        case ProgressIndicator.SpinnerCircle:
                            //LoadingCircle_Resize(e);
                            GenerateColorsPallet();
                            break;

                        case ProgressIndicator.SpinnerDivided:
                            ProgressDisk_SizeChanged(e);
                            break;

                        case ProgressIndicator.Win8Horizontal:
                            WinHR_OnResize(e);
                            break;

                        case ProgressIndicator.Win8Ring:
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            
            switch (ProgressType)
            {
                case ProgressType.Bar:
                {
                    //switch (SolidProgressBar)
                    //{
                    //    case ProgressBar.ExtendedProgress:
                    //        Extended_Resize(e);
                    //        break;
                    //    default:
                    //        throw new ArgumentOutOfRangeException();
                    //}

                    switch (SolidProgressBar)
                    {
                        case ProgressBar.ExtendedProgress:
                            Extended_Resize(e);
                            break;
                        case ProgressBar.ZeroitIndicator:
                            break;
                        case ProgressBar.iTunes:
                            break;
                        case ProgressBar.Maze:
                            break;
                        case ProgressBar.ProgressNormal:
                            break;
                        case ProgressBar.ProgressBoxed:
                            break;
                        case ProgressBar.ProgressGradient:
                            break;
                        case ProgressBar.Alter:
                            break;
                        case ProgressBar.Clear:
                            break;
                        case ProgressBar.ProgressRect:
                            break;
                        case ProgressBar.Perplex:
                            break;
                        case ProgressBar.Transparent:
                            break;
                        case ProgressBar.Splitter:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                }

                case ProgressType.Circular:
                {
                    switch (CircularProgressType)
                    {
                        
                        case CircularProgress.ZeroitProgressBarCircular:
                            CircularProgressBar_SetStandardSize();

                                break;
                        case CircularProgress.CircularProgressv2:
                            break;
                        case CircularProgress.CircularProgressv3:
                            break;
                        case CircularProgress.CircularProgressv4:
                            break;
                        case CircularProgress.CircularProgressv5:
                            CPv5_OnResize(e);
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            break;
                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            CircularProgressBar_SetStandardSize();
                                break;
                        case CircularProgress.GorgeousProgress:
                            break;

                        case CircularProgress.MulitCo:
                            break;

                        case CircularProgress.MultiCoExtended:
                            break;

                        case CircularProgress.MultiCoV1:
                            break;
                                
                        case CircularProgress.Perfect:
                            ProgressBarPerfect_OnResize(e);
                            break;

                        case CircularProgress.ProgressPie:
                            //ProgressPie_OnResize(e);
                            break;

                        case CircularProgress.RotatingArc:
                            RotatingArc_OnSizeChanged(e);
                                break;

                        case CircularProgress.RotatingCompass:
                            break;

                        case CircularProgress.SupremeCircle:
                            break;

                        case CircularProgress.Awesome:
                            break;

                        case CircularProgress.Ignito:
                            break;

                            default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                }
                case ProgressType.Indicator:
                {
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            Indeterminate_Resize(e);
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                            Google_OnResize(e);
                            break;
                        case ProgressIndicator.MacOSX:
                            MacOSX_CalculateSpokes();
                            break;
                        case ProgressIndicator.MacOSXOptimized:
                            break;
                        case ProgressIndicator.Matrix:
                            break;
                        case ProgressIndicator.IndicatorV1:
                            //ProgIndicatorV1_OnSizeChanged(e);
                            break;

                            case ProgressIndicator.Unique:
                                Unique_OnResize(e);
                                break;

                            case ProgressIndicator.Vuvuzela:
                                break;

                            case ProgressIndicator.SpinnerCircle:
                                LoadingCircle_Resize(e);
                                GenerateColorsPallet();
                                break;

                            case ProgressIndicator.SpinnerDivided:
                                ProgressDisk_Resize(e);
                                break;

                            case ProgressIndicator.Win8Horizontal:
                                WinHR_OnResize(e);
                                break;

                            case ProgressIndicator.Win8Ring:
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

        protected override void OnSizeChanged(EventArgs e)
        {
           base.OnSizeChanged(e);

            //CircularProgressBar_SetStandardSize();
            
            switch (CircularProgressType)
            {
                
                case CircularProgress.ZeroitProgressBarCircular:
                    CircularProgressBar_SetStandardSize();
                    break;
                case CircularProgress.CircularProgressv2:
                    break;
                case CircularProgress.CircularProgressv3:
                    break;
                case CircularProgress.CircularProgressv4:
                    break;
                case CircularProgress.CircularProgressv5:
                    CPv5_OnResize(e);
                    break;
                case CircularProgress.CircularProgressv5aClock:
                    break;

                case CircularProgress.GorgeousProgress:
                    break;

                case CircularProgress.MulitCo:
                    break;

                case CircularProgress.MultiCoExtended:
                    break;

                case CircularProgress.MultiCoV1:
                    break;

                case CircularProgress.Perfect:
                    ProgressBarPerfect_OnSizeChanged(e);
                    break;

                case CircularProgress.ProgressPie:
                    //ProgressPie_OnSizeChanged(e);
                    break;

                case CircularProgress.RotatingArc:
                    RotatingArc_OnSizeChanged(e);
                    break;

                case CircularProgress.RotatingCompass:
                    break;

                case CircularProgress.SupremeCircle:
                    break;

                case CircularProgress.Awesome:
                    break;

                case CircularProgress.Ignito:
                    break;

                case CircularProgress.ZeroitProgressBarCircularDefault:
                    break;
                default:
                    //throw new ArgumentOutOfRangeException()
                    break;
            }

            switch (ProgressIndicator)
            {
                case ProgressIndicator.CircularIndeterminate:
                    break;
                case ProgressIndicator.GoogleProgressIndicator:
                    break;
                case ProgressIndicator.MacOSX:
                    break;
                case ProgressIndicator.MacOSXOptimized:
                    break;
                case ProgressIndicator.Matrix:
                    break;
                case ProgressIndicator.IndicatorV1:
                    ProgIndicatorV1_OnSizeChanged(e);
                    break;
                case ProgressIndicator.Unique:
                    Unique_OnSizeChanged(e);
                    break;

                case ProgressIndicator.Vuvuzela:
                    break;

                case ProgressIndicator.SpinnerCircle:
                    LoadingCircle_Resize(e);
                    GenerateColorsPallet();
                    break;

                case ProgressIndicator.SpinnerDivided:
                    ProgressDisk_SizeChanged(e);
                    break;

                case ProgressIndicator.Win8Horizontal:
                    WinHR_OnResize(e);
                    break;

                case ProgressIndicator.Win8Ring:
                    WinRing_OnResize(e);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (SolidProgressBar)
            {
                case ProgressBar.ExtendedProgress:
                    break;
                case ProgressBar.ZeroitIndicator:
                    break;
                case ProgressBar.iTunes:
                    break;
                case ProgressBar.Maze:
                    break;
                case ProgressBar.ProgressNormal:
                    ProgressBarNormal_OnSizeChanged(e);
                    break;
                case ProgressBar.ProgressBoxed:
                    ProgressBarNormal_OnSizeChanged(e);
                    break;
                case ProgressBar.ProgressGradient:
                    ProgressBarNormal_OnSizeChanged(e);
                    break;
                case ProgressBar.Alter:
                    break;
                case ProgressBar.Clear:
                    break;
                case ProgressBar.Perplex:
                    break;
                case ProgressBar.ProgressRect:
                    break;
                case ProgressBar.Transparent:
                    break;
                case ProgressBar.Splitter:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    {
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.ExtendedProgress:
                                Extended_Paint(e);
                                break;

                            case ProgressBar.ZeroitIndicator:
                                ZeroitIndicator_Paint(e);
                                break;

                            case ProgressBar.iTunes:
                                iTunes_Paint(e);
                                break;

                            case ProgressBar.Maze:
                                Maze_Paint(e);
                                break;

                            case ProgressBar.ProgressNormal:
                                ProgressBarNormal_Paint(e);
                                break;

                            case ProgressBar.ProgressBoxed:
                                ProgressBarBoxed_Paint(e);
                                break;

                            case ProgressBar.ProgressGradient:
                                ProgressBarGradient_Paint(e);
                                break;

                            case ProgressBar.Alter:
                                ProgressAlter_Paint(e);
                                break;

                            case ProgressBar.Clear:
                                ProgressBarClear_Paint(e);
                                break;

                            case ProgressBar.Perplex:
                                ProgressBarPerplex_Paint(e);
                                break;

                            case ProgressBar.ProgressRect:
                                ProgressRect_Paint(e);
                                break;
                            case ProgressBar.Transparent:
                                Transparent_Paint(e);
                                break;

                            case ProgressBar.Splitter:
                                ProgressBarSplitter_OnPaint(e);
                                break;

                        }

                    }
                    break;
                case ProgressType.Circular:
                    {
                        switch (CircularProgressType)
                        {

                            case CircularProgress.ZeroitProgressBarCircular:
                                ZeroitProgressCircular_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv5aClock:
                                CircularProgressv5aClock_Paint(e);
                                break;

                            case CircularProgress.ZeroitProgressBarCircularDefault:
                                ZeroitProgressBarCircularDefault_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv2:
                                CPv2_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv3:
                                CPv3_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv4:
                                CPv4_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv5:
                                CPv5_Paint(e);
                                break;

                            case CircularProgress.GorgeousProgress:
                                Gorgeous_Paint(e);
                                break;

                            case CircularProgress.Ignito:
                                Ignito_Paint(e);
                                break;

                            case CircularProgress.MulitCo:
                                MultiCo_Paint(e);
                                break;

                            case CircularProgress.MultiCoExtended:
                                MultiCoExtended_Paint(e);
                                break;

                            case CircularProgress.MultiCoV1:
                                MCExV2_Paint(e);
                                break;

                            case CircularProgress.Awesome:
                                ProgressAwesome_OnPaint(e);
                                break;

                            case CircularProgress.Perfect:
                                ProgressBarPerfect_Paint(e);
                                break;

                            case CircularProgress.ProgressPie:
                                ProgressPie_Paint(e);
                                break;

                            case CircularProgress.RotatingArc:
                                RotatingArc_OnPaint(e);
                                break;

                            case CircularProgress.RotatingCompass:
                                RotatingCompass_OnPaint(e);
                                break;

                            case CircularProgress.SupremeCircle:
                                SP_OnPaint(e);
                                break;

                        }

                    }
                    break;
                case ProgressType.Indicator:
                    {
                        switch (ProgressIndicator)
                        {
                            case ProgressIndicator.CircularIndeterminate:
                                CircularIndeterminatePaint(e);
                                break;
                            case ProgressIndicator.GoogleProgressIndicator:
                                Google_Paint(e);
                                break;
                            case ProgressIndicator.MacOSX:
                                MacOSX_Paint(e);
                                break;
                            case ProgressIndicator.MacOSXOptimized:
                                MacOSX_Optimized_Paint(e);
                                break;
                            case ProgressIndicator.Matrix:
                                MacOSX_Matrix_Paint(e);
                                break;

                            case ProgressIndicator.IndicatorV1:
                                ProgIndicatorV1_OnPaint(e);
                                break;

                            case ProgressIndicator.Unique:
                                Unique_OnPaint(e);
                                break;

                            case ProgressIndicator.Vuvuzela:
                                Vuvuzela_OnPaint(e);
                                break;

                            case ProgressIndicator.SpinnerCircle:
                                Spinner_OnPaint(e);
                                break;

                            case ProgressIndicator.SpinnerDivided:
                                ProgressDisk_Paint(e);
                                break;

                            case ProgressIndicator.Win8Horizontal:
                                WinHR_OnPaint(e);
                                break;

                            case ProgressIndicator.Win8Ring:
                                WinRing_OnPaint(e);
                                break;

                        }

                    }
                    break;
            }

        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            //ProgIndicator_animationSpeed.Enabled = this.Enabled;

            SpinningProgress_EnabledChanged(e);
        }

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //    //ProgIndicator_animationSpeed.Tick += ProgIndicator_AnimationSpeed_Tick;
        //    //ProgIndicator_animationSpeed.Start();
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            timerStartingAngle.Interval = AnimationSpeed[1];
            timer.Interval = AnimationSpeed[0];

            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;
            
            #region Peace Animator Easing For Value

            switch (EasingType)
            {
                case PeaceAnimatorEasing.BounceEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.BounceEaseIn;

                    break;
                case PeaceAnimatorEasing.BounceEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.BounceEaseInOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.BounceEaseOut;

                    break;
                case PeaceAnimatorEasing.BounceEaseOutIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.BounceEaseOutIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseIn;

                    break;
                case PeaceAnimatorEasing.CircularEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;

                    break;
                case PeaceAnimatorEasing.CircularEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CircularEaseOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;

                    break;
                case PeaceAnimatorEasing.CubicEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut;

                    break;
                case PeaceAnimatorEasing.CubicEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.CubicEaseOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseIn;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseInOut;

                    break;
                case PeaceAnimatorEasing.ExponentialEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.ExponentialEaseOut;

                    break;
                case PeaceAnimatorEasing.Liner:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.Liner;

                    break;
                case PeaceAnimatorEasing.None:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.None;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuadraticEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuadraticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuarticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuarticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuarticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuarticEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuarticEaseOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuinticEaseIn;

                    break;
                case PeaceAnimatorEasing.QuinticEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuinticEaseInOut;

                    break;
                case PeaceAnimatorEasing.QuinticEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseIn:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseIn;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseInOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;

                    break;
                case PeaceAnimatorEasing.SinusoidalEaseOut:
                    peaceAnimator.OneD_Path_Easing = Transitions.WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseOut;

                    break;
                default:
                    break;
            }

            #endregion

            #region Old Code
            //if (CircularProgressType == CircularProgress.ZeroitProgressBarCircular)
            //{
            //    ZeroitProgressCircular_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.ZeroitProgressBarCircularDefault)
            //{
            //    ZeroitProgressBarCircularDefault_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.CircularProgressv2)
            //{
            //    CPv2_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.CircularProgressv3)
            //{
            //    CPv3_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.CircularProgressv4)
            //{
            //    CPv4_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.CircularProgressv5)
            //{
            //    CPv5_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.GorgeousProgress)
            //{
            //    Gorgeous_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.Ignito)
            //{
            //    Ignito_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.MulitCo)
            //{
            //    MultiCo_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.MultiCoExtended)
            //{
            //    MultiCoExtended_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.MultiCoV1)
            //{
            //    MCExV2_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.Awesome)
            //{
            //    ProgressAwesome_OnPaint(e);
            //}
            //else if (CircularProgressType == CircularProgress.Perfect)
            //{
            //    ProgressBarPerfect_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.ProgressPie)
            //{
            //    ProgressPie_Paint(e);
            //}
            //else if (CircularProgressType == CircularProgress.RotatingArc)
            //{
            //    RotatingArc_OnPaint(e);
            //}
            //else if (CircularProgressType == CircularProgress.RotatingCompass)
            //{
            //    RotatingCompass_OnPaint(e);
            //}
            //else if (CircularProgressType == CircularProgress.SupremeCircle)
            //{
            //    SP_OnPaint(e);
            //}

            #endregion

            #region ProgressType

            //switch (ProgType)
            //{
            //    case ProgressType.Bar:
            //        {

            //            switch (ProgBar)
            //            {
            //                case ProgressBar.ExtendedProgress:
            //                    Extended_Paint(e);
            //                    break;

            //                case ProgressBar.ZeroitIndicator:
            //                    ZeroitIndicator_Paint(e);
            //                    break;

            //                case ProgressBar.iTunes:
            //                    iTunes_Paint(e);
            //                    break;

            //                case ProgressBar.Maze:
            //                    Maze_Paint(e);
            //                    break;

            //                case ProgressBar.ProgressNormal:
            //                    ProgressBarNormal_Paint(e);
            //                    break;

            //                case ProgressBar.ProgressBoxed:
            //                    ProgressBarBoxed_Paint(e);
            //                    break;

            //                case ProgressBar.ProgressGradient:
            //                    ProgressBarGradient_Paint(e);
            //                    break;

            //                case ProgressBar.Alter:
            //                    ProgressAlter_Paint(e);
            //                    break;

            //                case ProgressBar.Clear:
            //                    ProgressBarClear_Paint(e);
            //                    break;

            //                case ProgressBar.Perplex:
            //                    ProgressBarPerplex_Paint(e);
            //                    break;

            //                case ProgressBar.ProgressRect:
            //                    ProgressRect_Paint(e);
            //                    break;
            //                case ProgressBar.Transparent:
            //                    Transparent_Paint(e);
            //                    break;

            //                case ProgressBar.Splitter:
            //                    ProgressBarSplitter_OnPaint(e);
            //                    break;

            //            }

            //        }
            //        break;

            //    case ProgressType.Circular:
            //        {
            //            switch (CircType)
            //            {

            //                case CircularProgress.ZeroitProgressBarCircular:
            //                    ZeroitProgressCircular_Paint(e);
            //                    break;

            //                case CircularProgress.CircularProgressv5aClock:
            //                    CircularProgressv5aClock_Paint(e);
            //                    break;

            //                case CircularProgress.ZeroitProgressBarCircularDefault:
            //                    ZeroitProgressBarCircularDefault_Paint(e);
            //                    break;

            //                case CircularProgress.CircularProgressv2:
            //                    CPv2_Paint(e);
            //                    break;

            //                case CircularProgress.CircularProgressv3:
            //                    CPv3_Paint(e);
            //                    break;

            //                case CircularProgress.CircularProgressv4:
            //                    CPv4_Paint(e);
            //                    break;

            //                case CircularProgress.CircularProgressv5:
            //                    CPv5_Paint(e);
            //                    break;

            //                case CircularProgress.GorgeousProgress:
            //                    Gorgeous_Paint(e);
            //                    break;

            //                case CircularProgress.Ignito:
            //                    Ignito_Paint(e);
            //                    break;

            //                case CircularProgress.MulitCo:
            //                    MultiCo_Paint(e);
            //                    break;

            //                case CircularProgress.MultiCoExtended:
            //                    MultiCoExtended_Paint(e);
            //                    break;

            //                case CircularProgress.MultiCoV1:
            //                    MCExV2_Paint(e);
            //                    break;

            //                case CircularProgress.Awesome:
            //                    ProgressAwesome_OnPaint(e);
            //                    break;

            //                case CircularProgress.Perfect:
            //                    ProgressBarPerfect_Paint(e);
            //                    break;

            //                case CircularProgress.ProgressPie:
            //                    ProgressPie_Paint(e);
            //                    break;

            //                case CircularProgress.RotatingArc:
            //                    RotatingArc_OnPaint(e);
            //                    break;

            //                case CircularProgress.RotatingCompass:
            //                    RotatingCompass_OnPaint(e);
            //                    break;

            //                case CircularProgress.SupremeCircle:
            //                    SP_OnPaint(e);
            //                    break;

            //            }

            //        }
            //        break;

            //    case ProgressType.Indicator:
            //        {
            //            switch (ProgIndicate)
            //            {
            //                case ProgressIndicator.CircularIndeterminate:
            //                    CircularIndeterminatePaint(e);
            //                    break;
            //                case ProgressIndicator.GoogleProgressIndicator:
            //                    Google_Paint(e);
            //                    break;
            //                case ProgressIndicator.MacOSX:
            //                    MacOSX_Paint(e);
            //                    break;
            //                case ProgressIndicator.MacOSXOptimized:
            //                    MacOSX_Optimized_Paint(e);
            //                    break;
            //                case ProgressIndicator.Matrix:
            //                    MacOSX_Matrix_Paint(e);
            //                    break;

            //                case ProgressIndicator.IndicatorV1:
            //                    ProgIndicatorV1_OnPaint(e);
            //                    break;

            //                case ProgressIndicator.Unique:
            //                    Unique_OnPaint(e);
            //                    break;

            //                case ProgressIndicator.Vuvuzela:
            //                    Vuvuzela_OnPaint(e);
            //                    break;

            //                case ProgressIndicator.SpinnerCircle:
            //                    Spinner_OnPaint(e);
            //                    break;

            //                case ProgressIndicator.SpinnerDivided:
            //                    ProgressDisk_Paint(e);
            //                    break;

            //                case ProgressIndicator.Win8Horizontal:
            //                    WinHR_OnPaint(e);
            //                    break;

            //                case ProgressIndicator.Win8Ring:
            //                    WinRing_OnPaint(e);
            //                    break;

            //            }

            //        }
            //        break;

            //}

            #endregion

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    {
                        switch (SolidProgressBar)
                        {
                            case ProgressBar.ExtendedProgress:
                                Extended_Paint(e);
                                break;

                            case ProgressBar.ZeroitIndicator:
                                ZeroitIndicator_Paint(e);
                                break;

                            case ProgressBar.iTunes:
                                iTunes_Paint(e);
                                break;

                            case ProgressBar.Maze:
                                Maze_Paint(e);
                                break;

                            case ProgressBar.ProgressNormal:
                                ProgressBarNormal_Paint(e);
                                break;

                            case ProgressBar.ProgressBoxed:
                                ProgressBarBoxed_Paint(e);
                                break;

                            case ProgressBar.ProgressGradient:
                                ProgressBarGradient_Paint(e);
                                break;

                            case ProgressBar.Alter:
                                ProgressAlter_Paint(e);
                                break;

                            case ProgressBar.Clear:
                                ProgressBarClear_Paint(e);
                                break;

                            case ProgressBar.Perplex:
                                ProgressBarPerplex_Paint(e);
                                break;

                            case ProgressBar.ProgressRect:
                                ProgressRect_Paint(e);
                                break;
                            case ProgressBar.Transparent:
                                Transparent_Paint(e);
                                break;

                            case ProgressBar.Splitter:
                                ProgressBarSplitter_OnPaint(e);
                                break;

                        }

                    }
                    break;
                case ProgressType.Circular:
                    {
                        switch (CircularProgressType)
                        {

                            case CircularProgress.ZeroitProgressBarCircular:
                                ZeroitProgressCircular_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv5aClock:
                                CircularProgressv5aClock_Paint(e);
                                break;

                            case CircularProgress.ZeroitProgressBarCircularDefault:
                                ZeroitProgressBarCircularDefault_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv2:
                                CPv2_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv3:
                                CPv3_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv4:
                                CPv4_Paint(e);
                                break;

                            case CircularProgress.CircularProgressv5:
                                CPv5_Paint(e);
                                break;

                            case CircularProgress.GorgeousProgress:
                                Gorgeous_Paint(e);
                                break;

                            case CircularProgress.Ignito:
                                Ignito_Paint(e);
                                break;

                            case CircularProgress.MulitCo:
                                MultiCo_Paint(e);
                                break;

                            case CircularProgress.MultiCoExtended:
                                MultiCoExtended_Paint(e);
                                break;

                            case CircularProgress.MultiCoV1:
                                MCExV2_Paint(e);
                                break;

                            case CircularProgress.Awesome:
                                ProgressAwesome_OnPaint(e);
                                break;

                            case CircularProgress.Perfect:
                                ProgressBarPerfect_Paint(e);
                                break;

                            case CircularProgress.ProgressPie:
                                ProgressPie_Paint(e);
                                break;

                            case CircularProgress.RotatingArc:
                                RotatingArc_OnPaint(e);
                                break;

                            case CircularProgress.RotatingCompass:
                                RotatingCompass_OnPaint(e);
                                break;

                            case CircularProgress.SupremeCircle:
                                SP_OnPaint(e);
                                break;

                        }

                    }
                    break;
                case ProgressType.Indicator:
                    {
                        switch (ProgressIndicator)
                        {
                            case ProgressIndicator.CircularIndeterminate:
                                CircularIndeterminatePaint(e);
                                break;
                            case ProgressIndicator.GoogleProgressIndicator:
                                Google_Paint(e);
                                break;
                            case ProgressIndicator.MacOSX:
                                MacOSX_Paint(e);
                                break;
                            case ProgressIndicator.MacOSXOptimized:
                                MacOSX_Optimized_Paint(e);
                                break;
                            case ProgressIndicator.Matrix:
                                MacOSX_Matrix_Paint(e);
                                break;

                            case ProgressIndicator.IndicatorV1:
                                ProgIndicatorV1_OnPaint(e);
                                break;

                            case ProgressIndicator.Unique:
                                Unique_OnPaint(e);
                                break;

                            case ProgressIndicator.Vuvuzela:
                                Vuvuzela_OnPaint(e);
                                break;

                            case ProgressIndicator.SpinnerCircle:
                                Spinner_OnPaint(e);
                                break;

                            case ProgressIndicator.SpinnerDivided:
                                ProgressDisk_Paint(e);
                                break;

                            case ProgressIndicator.Win8Horizontal:
                                WinHR_OnPaint(e);
                                break;

                            case ProgressIndicator.Win8Ring:
                                WinRing_OnPaint(e);
                                break;

                        }

                    }
                    break;
            }

        }

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
                        case ProgressBar.ExtendedProgress:
                            break;
                        case ProgressBar.ZeroitIndicator:
                            break;
                        case ProgressBar.iTunes:
                            break;
                        case ProgressBar.Maze:
                            break;
                        case ProgressBar.ProgressNormal:
                            ProgressBarNormal_Dispose(disposing);
                            break;
                        case ProgressBar.ProgressBoxed:
                            ProgressBarNormal_Dispose(disposing);
                            break;
                        case ProgressBar.ProgressGradient:
                            ProgressBarNormal_Dispose(disposing);
                            break;
                        case ProgressBar.Alter:
                            break;
                        case ProgressBar.Clear:
                            break;
                        case ProgressBar.Perplex:
                            break;
                        case ProgressBar.ProgressRect:
                            break;
                        case ProgressBar.Transparent:
                            break;
                        case ProgressBar.Splitter:
                            //ProgressBarSplitter_Dispose(disposing);
                            break;
                            
                    }
                    break;
                case ProgressType.Circular:
                    switch (CircularProgressType)
                    {
                        case CircularProgress.ZeroitProgressBarCircular:
                            break;
                        case CircularProgress.CircularProgressv2:
                            break;
                        case CircularProgress.CircularProgressv3:
                            break;
                        case CircularProgress.CircularProgressv4:
                            break;
                        case CircularProgress.CircularProgressv5:
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            break;
                        case CircularProgress.GorgeousProgress:
                            break;
                        case CircularProgress.Ignito:
                            break;
                        case CircularProgress.MulitCo:
                            break;
                        case CircularProgress.MultiCoExtended:
                            break;
                        case CircularProgress.MultiCoV1:
                            break;
                        case CircularProgress.Awesome:
                            break;
                        case CircularProgress.Perfect:
                            break;
                        case CircularProgress.ProgressPie:
                            break;
                        case CircularProgress.RotatingArc:
                            break;
                        case CircularProgress.RotatingCompass:
                            break;
                        case CircularProgress.SupremeCircle:
                            break;

                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            break;
                        
                    }
                    break;
                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                            break;
                        case ProgressIndicator.MacOSX:
                            break;
                        case ProgressIndicator.MacOSXOptimized:
                            break;
                        case ProgressIndicator.Matrix:
                            break;
                        case ProgressIndicator.IndicatorV1:
                            break;
                        case ProgressIndicator.Unique:
                            break;
                        case ProgressIndicator.Vuvuzela:
                            break;
                        case ProgressIndicator.SpinnerCircle:
                            break;
                        case ProgressIndicator.SpinnerDivided:
                            break;
                        case ProgressIndicator.Win8Horizontal:
                            break;
                        case ProgressIndicator.Win8Ring:
                            break;
                        
                    }
                    break;

            }

            base.Dispose(disposing);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {

            base.OnControlRemoved(e);

            WinHR_memory_cleanup();

            WinRing_memory_cleanup();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.Alter:
                            break;
                        case ProgressBar.Clear:
                            break;
                        case ProgressBar.ExtendedProgress:
                            break;
                        case ProgressBar.iTunes:
                            break;
                        case ProgressBar.Maze:
                            break;
                        case ProgressBar.Perplex:
                            break;
                        case ProgressBar.ProgressBoxed:
                            break;
                        case ProgressBar.ProgressGradient:
                            break;
                        case ProgressBar.ProgressNormal:
                            break;
                        case ProgressBar.ProgressRect:
                            break;
                        case ProgressBar.Splitter:
                            break;
                        case ProgressBar.Transparent:
                            break;
                        case ProgressBar.ZeroitIndicator:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case ProgressType.Circular:
                    switch (CircularProgressType)
                    {
                        case CircularProgress.Awesome:
                            break;
                        case CircularProgress.CircularProgressv2:
                            break;
                        case CircularProgress.CircularProgressv3:
                            break;
                        case CircularProgress.CircularProgressv4:
                            break;
                        case CircularProgress.CircularProgressv5:
                            break;
                        case CircularProgress.CircularProgressv5aClock:
                            break;
                        case CircularProgress.GorgeousProgress:
                            break;
                        case CircularProgress.Ignito:
                            break;
                        case CircularProgress.MulitCo:
                            break;
                        case CircularProgress.MultiCoExtended:
                            break;
                        case CircularProgress.MultiCoV1:
                            break;
                        case CircularProgress.Perfect:
                            break;
                        case CircularProgress.ProgressPie:
                            break;
                        case CircularProgress.RotatingArc:
                            break;
                        case CircularProgress.RotatingCompass:
                            break;
                        case CircularProgress.SupremeCircle:
                            break;
                        case CircularProgress.ZeroitProgressBarCircular:
                            break;
                        case CircularProgress.ZeroitProgressBarCircularDefault:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.CircularIndeterminate:
                            break;
                        case ProgressIndicator.GoogleProgressIndicator:
                            break;
                        case ProgressIndicator.IndicatorV1:
                            ProgIndicatorV1_OnSizeChanged(e);
                            break;
                        case ProgressIndicator.MacOSX:
                            break;
                        case ProgressIndicator.MacOSXOptimized:
                            break;
                        case ProgressIndicator.Matrix:
                            break;
                        case ProgressIndicator.SpinnerCircle:
                            break;
                        case ProgressIndicator.SpinnerDivided:
                            break;
                        case ProgressIndicator.Unique:
                            break;
                        case ProgressIndicator.Vuvuzela:
                            break;
                        case ProgressIndicator.Win8Horizontal:
                            break;
                        case ProgressIndicator.Win8Ring:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        #endregion


    }





}
