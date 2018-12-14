using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [TypeConverter(typeof(ProgressInput.ProgressInputConverter))]
    [Editor(typeof(ProgressEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public partial class ProgressInput
    {
        #region Private ReadOnly

        #region Bars

        private readonly ProgressType barType = ProgressType.Bar;

        private readonly ProgressBar extendedBar = ProgressBar.ExtendedProgress;
        private readonly ProgressBar indicatorBar = ProgressBar.ZeroitIndicator;
        private readonly ProgressBar iTunesBar = ProgressBar.iTunes;
        private readonly ProgressBar mazeBar = ProgressBar.Maze;
        private readonly ProgressBar antonioNormalBar = ProgressBar.ProgressNormal;
        private readonly ProgressBar alterBar = ProgressBar.ExtendedProgress;
        private readonly ProgressBar clearBar = ProgressBar.Clear;
        private readonly ProgressBar perplexBar = ProgressBar.Perplex;
        private readonly ProgressBar rectBar = ProgressBar.ProgressRect;
        private readonly ProgressBar transparentBar = ProgressBar.Transparent;
        private readonly ProgressBar splitterBar = ProgressBar.Splitter;

        #endregion

        #region Circular

        private readonly ProgressType circularType = ProgressType.Circular;


        private readonly CircularProgress circularProgressBar = CircularProgress.ZeroitProgressBarCircular;
        private readonly CircularProgress circularProgressBarDefault = CircularProgress.ZeroitProgressBarCircularDefault;
        private readonly CircularProgress circularProgressV2 = CircularProgress.CircularProgressv2;
        private readonly CircularProgress circularProgressV3 = CircularProgress.CircularProgressv3;
        private readonly CircularProgress circularProgressV4 = CircularProgress.CircularProgressv4;
        private readonly CircularProgress circularProgressV5 = CircularProgress.CircularProgressv5;
        private readonly CircularProgress circularGorgeous = CircularProgress.GorgeousProgress;
        private readonly CircularProgress circularIgnito = CircularProgress.Ignito;
        private readonly CircularProgress circularAwesome = CircularProgress.Awesome;
        private readonly CircularProgress circularPerfect = CircularProgress.Perfect;
        private readonly CircularProgress circularProgressPie = CircularProgress.ProgressPie;
        private readonly CircularProgress circularArc = CircularProgress.RotatingArc;
        private readonly CircularProgress circularCompass = CircularProgress.RotatingCompass;
        private readonly CircularProgress circularSupreme = CircularProgress.SupremeCircle;
        private readonly CircularProgress circularMultiCo = CircularProgress.MulitCo;
        private readonly CircularProgress circularMultiCoExt = CircularProgress.MultiCoExtended;
        private readonly CircularProgress circularMultiCoExtV1 = CircularProgress.MultiCoV1;

        #endregion

        #region Indicator

        private readonly ProgressType indicProgType = ProgressType.Indicator;
        
        private readonly ProgressIndicator indeterminate_Ind = ProgressIndicator.CircularIndeterminate;
        private readonly ProgressIndicator google_Ind = ProgressIndicator.GoogleProgressIndicator;
        private readonly ProgressIndicator macOsX_Ind = ProgressIndicator.MacOSX;
        private readonly ProgressIndicator macOsXOpt_Ind = ProgressIndicator.MacOSXOptimized;
        private readonly ProgressIndicator matrix_Ind = ProgressIndicator.Matrix;
        private readonly ProgressIndicator indicatorV1_Ind = ProgressIndicator.IndicatorV1;
        private readonly ProgressIndicator unique_Ind = ProgressIndicator.Unique;
        private readonly ProgressIndicator vuvuzela_Ind = ProgressIndicator.Vuvuzela;
        private readonly ProgressIndicator spinnerCirc_Ind = ProgressIndicator.SpinnerCircle;
        private readonly ProgressIndicator spinnerDivided_Ind = ProgressIndicator.SpinnerDivided;
        private readonly ProgressIndicator win8Horiz_Ind = ProgressIndicator.Win8Horizontal;
        private readonly ProgressIndicator win8Ring_Ind = ProgressIndicator.Win8Ring;

        
        #endregion

        #endregion

        #region Private Fields

        private ProgressType progressType = ProgressType.Circular;
        private CircularProgress circularProgressType = CircularProgress.SupremeCircle;
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

        private drawMode _drawMode = drawMode.Solid;

        private PeaceAnimatorEasing _easingType = PeaceAnimatorEasing.BounceEaseIn;

        private transparencyEasingType _transparencyEasingType = transparencyEasingType.BounceEaseIn;
        
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

        private ThematicProgress.HatchBrushType hatchBrushType = ThematicProgress.HatchBrushType.ForwardDiagonal;

        private bool autoAnimate = false;
        private bool autoAnimateStatingAngle = false;

        private bool dummyBool = false;
        #endregion


        #endregion

        #region Public Properties
        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                
            }

        }
        
        public bool AllowTransparency
        {
            get { return _allowTransparency; }
            set
            {
                _allowTransparency = value;
                
            }
        }

        
        public float Value
        {
            get { return _Value; }
            set
            {
                
                _Value = value;
                
            }
        }

        
        public float Maximum
        {
            get { return _Maximum; }
            set
            {
                _Maximum = value;
                
            }
        }

        
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
                
            }
        }


        #region HatchBrush Property

        
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                
            }
        }

        
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                
            }
        }

        
        public ThematicProgress.HatchBrushType HatchBrush
        {
            get
            {
                return hatchBrushType;
            }

            set
            {
                hatchBrushType = value;
                
            }
        }
        
        #endregion
        
        public bool Glow
        {
            get { return transparencyAnimatorGlow; }
            set
            {

                
                transparencyAnimatorGlow = value;
                
            }
        }
        
        public Boolean FixedSize
        {
            get { return fixedSize; }
            set
            {
                fixedSize = value;
                
            }
        }
        
        public int FillTransparency
        {
            get { return transparency; }
            set
            {
                transparency = value;
                
            }
        }
        
        public drawMode DrawMode
        {
            get { return _drawMode; }
            set
            {
                _drawMode = value;
                
            }
        }
        
        public PeaceAnimatorEasing EasingType
        {
            get { return _easingType; }
            set
            {
                _easingType = value;
                
            }
        }
        
        public transparencyEasingType TransparentEasing
        {
            get { return _transparencyEasingType; }
            set
            {
                _transparencyEasingType = value;
                
            }
        }
        
        public bool AutoIncrement
        {
            get { return autoIncrement; }
            set
            {
                autoIncrement = value;
                
            }
        }
        
        public int[] AnimationSpeed
        {
            get { return speed; }
            set
            {
                
                speed = value;
                
            }
        }


        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

        [Category("General Progress Information")]
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                
            }
        }
        #endregion


        public ProgressType ProgressType
        {
            get { return progressType; }
            set
            {
                progressType = value;
                
            }
        }

        public CircularProgress CircularProgressType
        {
            get { return circularProgressType; }
            set
            {
                circularProgressType = value;
                
            }
        }

        
        public ProgressBar SolidProgressBar
        {
            get { return solidBars; }
            set
            {
                solidBars = value;
                
            }
        }

        
        public ProgressIndicator ProgressIndicator
        {
            get { return indicatorType; }
            set
            {
                indicatorType = value;
                
            }
        }

        public string PostFix
        {
            get { return postFix; }
            set
            {
                postFix = value;
                
            }
        }

        public float StartingAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
                
            }
        }

        
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;
                
            }
        }

        
        public bool AnimateStartAngle
        {
            get { return autoAnimateStatingAngle; }
            set
            {
                autoAnimateStatingAngle = value;

                
            }
        }

        public float AnimStartAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
                
            }
        }

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
                
            }
        }



        #endregion

        #region Bars
        public ProgressType Bartype
        {
            get { return barType; }
        }

        public ProgressBar ExtendedBar
        {
            get { return extendedBar; }
        }

        public ProgressBar IndicatorBar
        {
            get { return indicatorBar; }
        }

        public ProgressBar ITunesBar
        {
            get { return iTunesBar; }
        }

        public ProgressBar MazeBar
        {
            get { return mazeBar; }
        }

        public ProgressBar AntonioNormalBar
        {
            get { return antonioNormalBar; }
        }

        public ProgressBar AlterBar
        {
            get { return alterBar; }
        }

        public ProgressBar ClearBar
        {
            get { return clearBar; }
        }

        public ProgressBar PerplexBar
        {
            get { return perplexBar; }
        }

        public ProgressBar RectBar
        {
            get { return rectBar; }
        }

        public ProgressBar TransparentBar
        {
            get { return transparentBar; }
        }

        public ProgressBar SplitterBar
        {
            get { return splitterBar; }
        }




        #endregion

        #region Circular

        public ProgressType CircularType
        {
            get { return circularType; }
        }

        public CircularProgress CircularProgressBar
        {
            get { return circularProgressBar; }
        }

        public CircularProgress CircularProgressBarDefault
        {
            get { return circularProgressBarDefault; }
        }

        public CircularProgress CircularProgressV2
        {
            get { return circularProgressV2; }
        }

        public CircularProgress CircularProgressV3
        {
            get { return circularProgressV3; }
        }

        public CircularProgress CircularProgressV4
        {
            get { return circularProgressV4; }
        }

        public CircularProgress CircularProgress_V5
        {
            get { return circularProgressV5; }
        }

        public CircularProgress CircularGorgeous
        {
            get { return circularGorgeous; }
        }

        public CircularProgress CircularIgnito
        {
            get { return circularIgnito; }
        }

        public CircularProgress CircularAwesome
        {
            get { return circularAwesome; }
        }

        public CircularProgress CircularPerfect
        {
            get { return circularPerfect; }
        }

        public CircularProgress CircularProgressPie
        {
            get { return circularProgressPie; }
        }

        public CircularProgress CircularArc
        {
            get { return circularArc; }
        }

        public CircularProgress CircularCompass
        {
            get { return circularCompass; }
        }

        public CircularProgress CircularSupreme
        {
            get { return circularSupreme; }
        }

        public CircularProgress CircularMultiCo
        {
            get { return circularMultiCo; }
        }

        public CircularProgress CircularMultiCoExt
        {
            get { return circularMultiCoExt; }
        }

        public CircularProgress CircularMultiCoExtV1
        {
            get { return circularMultiCoExtV1; }
        }



        #endregion

        #region Indicator

        public ProgressType IndicProgType
        {
            get { return indicProgType; }
        }

        public ProgressIndicator IndeterminateInd
        {
            get { return indeterminate_Ind; }
        }

        public ProgressIndicator GoogleInd
        {
            get { return google_Ind; }
        }

        public ProgressIndicator MacOsXInd
        {
            get { return macOsX_Ind; }
        }

        public ProgressIndicator MacOsXOptInd
        {
            get { return macOsXOpt_Ind; }
        }

        public ProgressIndicator MatrixInd
        {
            get { return matrix_Ind; }
        }

        public ProgressIndicator IndicatorV1Ind
        {
            get { return indicatorV1_Ind; }
        }

        public ProgressIndicator UniqueInd
        {
            get { return unique_Ind; }
        }

        public ProgressIndicator VuvuzelaInd
        {
            get { return vuvuzela_Ind; }
        }

        public ProgressIndicator SpinnerCircInd
        {
            get { return spinnerCirc_Ind; }
        }

        public ProgressIndicator SpinnerDividedInd
        {
            get { return spinnerDivided_Ind; }
        }

        public ProgressIndicator Win8HorizInd
        {
            get { return win8Horiz_Ind; }
        }

        public ProgressIndicator Win8RingInd
        {
            get { return win8Ring_Ind; }
        }

        #endregion

        #endregion

        #region Public Methods

        public ProgressInput Clone()
        {
            return new ProgressInput(
                progressType
            );
        }

        public static ProgressInput Empty()
        {
            return new ProgressInput();
        }


        #endregion
        

        #region Constructor

        /// <summary>
        /// Main Constructor
        /// </summary>
        /// <param name="progressType"></param>
        /// 
        public ProgressInput(ProgressType progressType)
        {
            //CircularProgressV5();
            //ProgressAwesome();
            
        }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public ProgressInput() : this(ProgressType.Circular)
        {
            
        }

        #region Bars Constructor

        /// <summary>
        /// Constructor for Extended Bar
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="extendedBar"></param>
        /// <param name="m_FloodStyle"></param>
        /// <param name="m_float_BarFlood"></param>
        /// <param name="m_int_BarOffset"></param>
        /// <param name="m_int_DashWidth"></param>
        /// <param name="m_int_DashSpace"></param>
        /// <param name="m_Style"></param>
        /// <param name="m_Color1"></param>
        /// <param name="m_Color2"></param>
        /// <param name="m_color_Back"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar extendedBar,
            ProgressFloodStyle m_FloodStyle,
            float m_float_BarFlood,
            int m_int_BarOffset,
            int m_int_DashWidth,
            int m_int_DashSpace,
            ProgressStyle m_Style,
            Color m_Color1,
            Color m_Color2,
            Color m_color_Back) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.extendedBar = extendedBar;
            this.m_FloodStyle = m_FloodStyle;
            this.m_float_BarFlood = m_float_BarFlood;
            this.m_int_BarOffset = m_int_BarOffset;
            this.m_int_DashWidth = m_int_DashWidth;
            this.m_int_DashSpace = m_int_DashSpace;
            this.m_Style = m_Style;
            this.m_Color1 = m_Color1;
            this.m_Color2 = m_Color2;
            this.m_color_Back = m_color_Back;
        }

        /// <summary>
        /// Constructor for ZeroitIndicator
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="indicatorBar"></param>
        /// <param name="_GraphWidth"></param>
        /// <param name="paintColor"></param>
        /// <param name="penColor"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar indicatorBar,
            float _GraphWidth,
            Color paintColor,
            Color penColor) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.indicatorBar = indicatorBar;
            this._GraphWidth = _GraphWidth;
            this.paintColor = paintColor;
            this.penColor = penColor;
        }

        /// <summary>
        /// Constructor for iTunes
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="iTunesBar"></param>
        /// <param name="clrBarBgLight"></param>
        /// <param name="clrBarBgDark"></param>
        /// <param name="clrBarLight"></param>
        /// <param name="clrBarDark"></param>
        /// <param name="clrBorderColor"></param>
        /// <param name="fBorderWidth"></param>
        /// <param name="fMirrorOpacity"></param>
        /// <param name="iNumDividers"></param>
        /// <param name="iStepSize"></param>
        /// <param name="eBarType"></param>
        /// <param name="fNewProcent"></param>
        /// <param name="bAnimUp"></param>
        /// <param name="iTunesInterval"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar iTunesBar,
            Color clrBarBgLight,
            Color clrBarBgDark,
            Color clrBarLight,
            Color clrBarDark,
            Color clrBorderColor,
            float fBorderWidth,
            float fMirrorOpacity,
            int iNumDividers,
            float iStepSize,
            BarType eBarType,
            float fNewProcent,
            bool bAnimUp,
            int iTunesInterval

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.iTunesBar = iTunesBar;
            this.clrBarBgLight = clrBarBgLight;
            this.clrBarBgDark = clrBarBgDark;
            this.clrBarLight = clrBarLight;
            this.clrBarDark = clrBarDark;
            this.clrBorderColor = clrBorderColor;
            this.fBorderWidth = fBorderWidth;
            this.fMirrorOpacity = fMirrorOpacity;
            this.iNumDividers = iNumDividers;
            this.iStepSize = iStepSize;
            this.eBarType = eBarType;
            this.fNewProcent = fNewProcent;
            this.bAnimUp = bAnimUp;
            this.iTunesInterval = iTunesInterval;
        }

        /// <summary>
        /// Constructor for MazeProgress
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="mazeBar"></param>
        /// <param name="Maze_progressStyle"></param>
        /// <param name="Maze_marqueeAnimationSpeed"></param>
        /// <param name="maze"></param>
        /// <param name="Maze_marqueePosition"></param>
        /// <param name="Maze_marqueeLength"></param>
        /// <param name="Maze_gradientColors"></param>
        /// <param name="Maze_borderColors"></param>
        /// <param name="Maze_rowPixels"></param>
        /// <param name="Maze_unusedRowPixels"></param>
        /// <param name="Maze_unusedTopPixels"></param>
        /// <param name="Maze_unusedBottomPixels"></param>
        /// <param name="Maze_colPixels"></param>
        /// <param name="Maze_unusedColPixels"></param>
        /// <param name="Maze_unusedLeftPixels"></param>
        /// <param name="Maze_unusedRightPixels"></param>
        /// <param name="Maze_innerWidth"></param>
        /// <param name="Maze_innerHeight"></param>
        /// <param name="Maze_rowCount"></param>
        /// <param name="Maze_cellSize"></param>
        /// <param name="Maze_colCount"></param>
        /// <param name="Maze_mazeStyle"></param>
        /// <param name="Maze_gradient"></param>
        /// <param name="Maze_gradientStartColor"></param>
        /// <param name="Maze_gradientEndColor"></param>
        /// <param name="Maze_wallSize"></param>
        /// <param name="Maze_borderSize"></param>
        /// <param name="Maze_borderColor"></param>
        /// <param name="Maze_borderGradient"></param>
        /// <param name="Maze_borderRoundCorners"></param>
        /// <param name="Maze_unusedColor"></param>
        /// <param name="maze_solidColor"></param>
        /// <param name="wallColor"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar mazeBar,
            ProgressBarStyle Maze_progressStyle,
            float Maze_marqueeAnimationSpeed,
            int Maze_rowCount,
            MazeStyleType Maze_mazeStyle,
            Maze_GradientType Maze_gradient,
            Color Maze_gradientStartColor,
            Color Maze_gradientEndColor,
            int Maze_wallSize,
            int Maze_borderSize,
            Color Maze_borderColor,
            bool Maze_borderGradient,
            bool Maze_borderRoundCorners,
            Color Maze_unusedColor,
            Color maze_solidColor,
            Color wallColor
            //ThematicProgress.Maze maze,
            //int Maze_marqueePosition,
            //int Maze_marqueeLength,
            //Color[] Maze_gradientColors,
            //Color[] Maze_borderColors,
            //int Maze_rowPixels,
            //int Maze_unusedRowPixels,
            //int Maze_unusedTopPixels,
            //int Maze_unusedBottomPixels,
            //int Maze_colPixels,
            //int Maze_unusedColPixels,
            //int Maze_unusedLeftPixels,
            //int Maze_unusedRightPixels,
            //int Maze_innerWidth,
            //int Maze_innerHeight,

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.mazeBar = mazeBar;
            this.Maze_progressStyle = Maze_progressStyle;
            this.Maze_marqueeAnimationSpeed = Maze_marqueeAnimationSpeed;
            this.Maze_rowCount = Maze_rowCount;
            this.Maze_mazeStyle = Maze_mazeStyle;
            this.Maze_gradient = Maze_gradient;
            this.Maze_gradientStartColor = Maze_gradientStartColor;
            this.Maze_gradientEndColor = Maze_gradientEndColor;
            this.Maze_wallSize = Maze_wallSize;
            this.Maze_borderSize = Maze_borderSize;
            this.Maze_borderColor = Maze_borderColor;
            this.Maze_borderGradient = Maze_borderGradient;
            this.Maze_borderRoundCorners = Maze_borderRoundCorners;
            this.Maze_unusedColor = Maze_unusedColor;
            this.maze_solidColor = maze_solidColor;
            this.wallColor = wallColor;
            //this.maze = maze;
            //this.Maze_marqueePosition = Maze_marqueePosition;
            //this.Maze_marqueeLength = Maze_marqueeLength;
            //this.Maze_gradientColors = Maze_gradientColors;
            //this.Maze_borderColors = Maze_borderColors;
            //this.Maze_rowPixels = Maze_rowPixels;
            //this.Maze_unusedRowPixels = Maze_unusedRowPixels;
            //this.Maze_unusedTopPixels = Maze_unusedTopPixels;
            //this.Maze_unusedBottomPixels = Maze_unusedBottomPixels;
            //this.Maze_colPixels = Maze_colPixels;
            //this.Maze_unusedColPixels = Maze_unusedColPixels;
            //this.Maze_unusedLeftPixels = Maze_unusedLeftPixels;
            //this.Maze_unusedRightPixels = Maze_unusedRightPixels;
            //this.Maze_innerWidth = Maze_innerWidth;
            //this.Maze_innerHeight = Maze_innerHeight;


        }

        /// <summary>
        /// Constructor for Antonio - Normal
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="antonioNormalBar"></param>
        /// <param name="_progressNormalType"></param>
        /// <param name="ProgressBarNormal_step"></param>
        /// <param name="_TurnOffInvalidation"></param>
        /// <param name="_iPercent"></param>
        /// <param name="_fPercent"></param>
        /// <param name="_TextColorType"></param>
        /// <param name="_TextAlign"></param>
        /// <param name="_DisplayProgress"></param>
        /// <param name="_ColorProgress"></param>
        /// <param name="_BorderType"></param>
        /// <param name="ProgressBarNormal_borderColor"></param>
        /// <param name="_RollBlockPercent"></param>
        /// <param name="_RollingType"></param>
        /// <param name="antonioInterval"></param>
        public ProgressInput(

            ProgressType barType,
            ProgressBar antonioNormalBar,
            ThematicProgress.progressNormalType _progressNormalType,
            int ProgressBarNormal_step,
            ThematicProgress.TextColorTypes _TextColorType,
            ThematicProgress.TextAlignmentTypes _TextAlign,
            bool _DisplayProgress,
            Color _ColorProgress,
            ThematicProgress.BorderTypes _BorderType,
            Color ProgressBarNormal_borderColor,
            int _RollBlockPercent,
            ThematicProgress.RollingTypes _RollingType,
            int antonioInterval
            //bool _TurnOffInvalidation,
            //int _iPercent,
            //float _fPercent,

            ) : this(ProgressType.Bar)
        {

            this.barType = barType;
            this.antonioNormalBar = antonioNormalBar;
            this._progressNormalType = _progressNormalType;
            this.ProgressBarNormal_step = ProgressBarNormal_step;
            //this._TurnOffInvalidation = _TurnOffInvalidation;
            //this._iPercent = _iPercent;
            //this._fPercent = _fPercent;
            this._TextColorType = _TextColorType;
            this._TextAlign = _TextAlign;
            this._DisplayProgress = _DisplayProgress;
            this._ColorProgress = _ColorProgress;
            this._BorderType = _BorderType;
            this.ProgressBarNormal_borderColor = ProgressBarNormal_borderColor;
            this._RollBlockPercent = _RollBlockPercent;
            this._RollingType = _RollingType;
            this.antonioInterval = antonioInterval;
        }

        /// <summary>
        /// Constructor for Alter Progress
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="alterBar"></param>
        /// <param name="colorBack"></param>
        /// <param name="colorBorder"></param>
        /// <param name="colorText"></param>
        /// <param name="colorInside"></param>
        /// <param name="colorIC"></param>
        /// <param name="color1"></param>
        /// <param name="color2"></param>
        /// <param name="colorAngle"></param>
        /// <param name="_ShowValue"></param>
        /// <param name="_Orientation"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar alterBar,
            Color colorBack,
            Color colorBorder,
            Color colorText,
            Color colorInside,
            Color colorIC,
            Color color1,
            Color color2,
            float colorAngle,
            bool _ShowValue,
            Orientation _Orientation

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.alterBar = alterBar;
            this.colorBack = colorBack;
            this.colorBorder = colorBorder;
            this.colorText = colorText;
            this.colorInside = colorInside;
            this.colorIC = colorIC;
            this.color1 = color1;
            this.color2 = color2;
            this.colorAngle = colorAngle;
            this._ShowValue = _ShowValue;
            this._Orientation = _Orientation;
        }

        /// <summary>
        /// Constructor for Clear Progress
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="clearBar"></param>
        /// <param name="ProgressBarClear_glow"></param>
        /// <param name="ProgressBarClear_edge"></param>
        /// <param name="ProgressBarClear_gradient1"></param>
        /// <param name="ProgressBarClear_gradient2"></param>
        /// <param name="_coloringMode"></param>
        /// <param name="GlowPosition"></param>
        public ProgressInput(

            ProgressType barType,
            ProgressBar clearBar,
            Color ProgressBarClear_glow,
            Color ProgressBarClear_edge,
            Color ProgressBarClear_gradient1,
            Color ProgressBarClear_gradient2,
            ThematicProgress.coloringMode _coloringMode
            //int GlowPosition

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.clearBar = clearBar;
            this.ProgressBarClear_glow = ProgressBarClear_glow;
            this.ProgressBarClear_edge = ProgressBarClear_edge;
            this.ProgressBarClear_gradient1 = ProgressBarClear_gradient1;
            this.ProgressBarClear_gradient2 = ProgressBarClear_gradient2;
            this._coloringMode = _coloringMode;
            //this.GlowPosition = GlowPosition;
        }

        /// <summary>
        /// Constructor for Perplex Progressbar
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="perplexBar"></param>
        /// <param name="Perplex_colorGradient1"></param>
        /// <param name="Perplex_colorGradient2"></param>
        /// <param name="Perplex_colorGradient3"></param>
        /// <param name="Perplex_colorGradient4"></param>
        /// <param name="colorPen"></param>
        /// <param name="colorGradientAngle"></param>
        /// <param name="_ShowPercentage"></param>
        /// <param name="_perplex_DrawMode"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar perplexBar,
            Color Perplex_colorGradient1,
            Color Perplex_colorGradient2,
            Color Perplex_colorGradient3,
            Color Perplex_colorGradient4,
            Color colorPen,
            float colorGradientAngle,
            bool _ShowPercentage,
            ThematicProgress.perplex_DrawMode _perplex_DrawMode

            ) : this(ProgressType.Bar)
        {

            this.barType = barType;
            this.perplexBar = perplexBar;
            this.Perplex_colorGradient1 = Perplex_colorGradient1;
            this.Perplex_colorGradient2 = Perplex_colorGradient2;
            this.Perplex_colorGradient3 = Perplex_colorGradient3;
            this.Perplex_colorGradient4 = Perplex_colorGradient4;
            this.colorPen = colorPen;
            this.colorGradientAngle = colorGradientAngle;
            this._ShowPercentage = _ShowPercentage;
            this._perplex_DrawMode = _perplex_DrawMode;

        }

        /// <summary>
        /// Constructor for RectBar
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="rectBar"></param>
        /// <param name="ProgressRect_percent"></param>
        /// <param name="ProgressRect_valueColour"></param>
        /// <param name="ProgressRect_colorBackground"></param>
        /// <param name="ProgressRect_colorBorder"></param>
        /// <param name="ProgressRect_corner"></param>
        public ProgressInput(

            ProgressType barType,
            ProgressBar rectBar,
            //float ProgressRect_percent,
            Color ProgressRect_valueColour,
            Color ProgressRect_colorBackground,
            Color ProgressRect_colorBorder,
            int ProgressRect_corner

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.rectBar = rectBar;
            //this.ProgressRect_percent = ProgressRect_percent;
            this.ProgressRect_valueColour = ProgressRect_valueColour;
            this.ProgressRect_colorBackground = ProgressRect_colorBackground;
            this.ProgressRect_colorBorder = ProgressRect_colorBorder;
            this.ProgressRect_corner = ProgressRect_corner;
        }

        /// <summary>
        /// Constructor for Transparent ProgressBar
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="transparentBar"></param>
        /// <param name="_ShowText"></param>
        /// <param name="_ProgressBackground"></param>
        /// <param name="Trns_progressColor1"></param>
        /// <param name="Trns_progressColor2"></param>
        public ProgressInput(
            ProgressType barType,
            ProgressBar transparentBar,
            Boolean _ShowText,
            Color _ProgressBackground,
            Color Trns_progressColor1,
            Color Trns_progressColor2

            ) : this(ProgressType.Bar)
        {
            this.barType = barType;
            this.transparentBar = transparentBar;
            this._ShowText = _ShowText;
            this._ProgressBackground = _ProgressBackground;
            this.Trns_progressColor1 = Trns_progressColor1;
            this.Trns_progressColor2 = Trns_progressColor2;
        }

        /// <summary>
        /// Constructor for Splitter Progressbar
        /// </summary>
        /// <param name="barType"></param>
        /// <param name="splitterBar"></param>
        /// <param name="m_ProgressBarBlockWidth"></param>
        /// <param name="m_ProgressBarBlockSpace"></param>
        /// <param name="m_ProgressBarPercent"></param>
        /// <param name="m_ProgressBarMarginOffset"></param>
        /// <param name="m_ProgressBarBorderStyle"></param>
        /// <param name="m_ProgressBarFillBrush_Color"></param>
        public ProgressInput(

            ProgressType barType,
            ProgressBar splitterBar,
            int m_ProgressBarBlockWidth,
            int m_ProgressBarBlockSpace,
            bool m_ProgressBarPercent,
            bool m_ProgressBarMarginOffset,
            TProgressBarBorderStyle m_ProgressBarBorderStyle,
            Color m_ProgressBarFillBrush_Color
            ) : this(ProgressType.Bar)
        {

            this.barType = barType;
            this.splitterBar = splitterBar;
            this.m_ProgressBarBlockWidth = m_ProgressBarBlockWidth;
            this.m_ProgressBarBlockSpace = m_ProgressBarBlockSpace;
            this.m_ProgressBarPercent = m_ProgressBarPercent;
            this.m_ProgressBarMarginOffset = m_ProgressBarMarginOffset;
            this.m_ProgressBarBorderStyle = m_ProgressBarBorderStyle;
            this.m_ProgressBarFillBrush_Color = m_ProgressBarFillBrush_Color;

        }

        #endregion

        #region Circular Constructor

        /// <summary>
        /// Constructor for CircularProgressBar 
        /// </summary>
        /// <param name="circularType"></param>
        /// <param name="circularProgressBar"></param>
        /// <param name="_ProgressColor1"></param>
        /// <param name="_ProgressColor2"></param>
        /// <param name="_FillEllipse1"></param>
        /// <param name="_FillEllipse2"></param>
        /// <param name="_TextColor"></param>
        /// <param name="_ProgressColorInnerBorder"></param>
        /// <param name="ProgressShapeVal"></param>
        /// <param name="_Start"></param>
        /// <param name="_End"></param>
        /// <param name="_ProgressWidth"></param>
        /// <param name="_PenWidth"></param>
        /// <param name="_ProgressWidthToFloat"></param>
        /// <param name="_showText"></param>
        /// <param name="zeroitProgressBarCircular_transparency"></param>
        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressBar,
            Color _ProgressColor1,
            Color _ProgressColor2,
            Color _FillEllipse1,
            Color _FillEllipse2,
            Color _TextColor,
            Color _ProgressColorInnerBorder,
            ThematicProgress._ProgressShape ProgressShapeVal,
            LineCap _Start,
            LineCap _End,
            Double _ProgressWidth,
            float _PenWidth,
            bool _showText,
            bool zeroitProgressBarCircular_transparency
            //float _ProgressWidthToFloat,

            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularProgressBar = circularProgressBar;
            this._ProgressColor1 = _ProgressColor1;
            this._ProgressColor2 = _ProgressColor2;
            this._FillEllipse1 = _FillEllipse1;
            this._FillEllipse2 = _FillEllipse2;
            this._TextColor = _TextColor;
            this._ProgressColorInnerBorder = _ProgressColorInnerBorder;
            this.ProgressShapeVal = ProgressShapeVal;
            this._Start = _Start;
            this._End = _End;
            this._ProgressWidth = _ProgressWidth;
            this._PenWidth = _PenWidth;
            //this._ProgressWidthToFloat = _ProgressWidthToFloat;
            this._showText = _showText;
            this.zeroitProgressBarCircular_transparency = zeroitProgressBarCircular_transparency;

        }

        /// <summary>
        /// Constructor for CircularProgress Default
        /// </summary>
        /// <param name="circularType"></param>
        /// <param name="circularProgressBarDefault"></param>
        /// <param name="CircularDef_ProgressColor1"></param>
        /// <param name="CircularDef_ProgressColor2"></param>
        /// <param name="CircularDef_InnerColor1"></param>
        /// <param name="CircularDef_InnerColor2"></param>
        /// <param name="CircularDef_ProgressShapeVal"></param>
        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressBarDefault,
            Color CircularDef_ProgressColor1,
            Color CircularDef_ProgressColor2,
            Color CircularDef_InnerColor1,
            Color CircularDef_InnerColor2,
            ThematicProgress._ProgressShape CircularDef_ProgressShapeVal
            
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularProgressBarDefault = circularProgressBarDefault;
            this.CircularDef_ProgressColor1 = CircularDef_ProgressColor1;
            this.CircularDef_ProgressColor2 = CircularDef_ProgressColor2;
            this.CircularDef_InnerColor1 = CircularDef_InnerColor1;
            this.CircularDef_InnerColor2 = CircularDef_InnerColor2;
            this.CircularDef_ProgressShapeVal = CircularDef_ProgressShapeVal;

        }

        public ProgressInput(

            ProgressType circularType,
            CircularProgress circularProgressV2,
            int CPv2_progressWidth,
            int CPv2_shift,
            int CPv2_remainderAngle,
            int CPv2_startAngle,
            bool CPv2_showText,
            Color CPv2_progressColor,
            Color CPv2_progressEmptyColor

            
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularProgressV2 = circularProgressV2;
            this.CPv2_progressWidth = CPv2_progressWidth;
            this.CPv2_shift = CPv2_shift;
            this.CPv2_remainderAngle = CPv2_remainderAngle;
            this.CPv2_startAngle = CPv2_startAngle;
            this.CPv2_showText = CPv2_showText;
            this.CPv2_progressColor = CPv2_progressColor;
            this.CPv2_progressEmptyColor = CPv2_progressEmptyColor;

        }

        
        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressV3,
            int CPv3_progressWidth,
            int CPv3_shift,
            int CPv3_remainderAngle,
            int CPv3_startangle,
            bool CPv3_showText,
            Color CPv3_progressColor,
            Color CPv3_progressEmptyColor,
            bool dummy
            
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularProgressV3 = circularProgressV3;
            this.CPv3_progressWidth = CPv3_progressWidth;
            this.CPv3_shift = CPv3_shift;
            this.CPv3_remainderAngle = CPv3_remainderAngle;
            this.CPv3_startangle = CPv3_startangle;
            this.CPv3_showText = CPv3_showText;
            this.CPv3_progressColor = CPv3_progressColor;
            this.CPv3_progressEmptyColor = CPv3_progressEmptyColor;

        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressV4,
            int CPv4_startAngle,
            int CPv4_thickness,
            float CPv4_gradAngle,
            LineCap CPv4_startCap,
            LineCap CPv4_endCap,
            Color CPv4_innerBorder,
            Color CPv4_outerBorder,
            Color CPv4_progGrad1,
            Color CPv4_progGrad2,
            Color CPv4_progBackGrad1,
            Color CPv4_progBackGrad2,
            int CPv4_speed
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularProgressV4 = circularProgressV4;
            this.CPv4_startAngle = CPv4_startAngle;
            this.CPv4_thickness = CPv4_thickness;
            this.CPv4_gradAngle = CPv4_gradAngle;
            this.CPv4_startCap = CPv4_startCap;
            this.CPv4_endCap = CPv4_endCap;
            this.CPv4_innerBorder = CPv4_innerBorder;
            this.CPv4_outerBorder = CPv4_outerBorder;
            this.CPv4_progGrad1 = CPv4_progGrad1;
            this.CPv4_progGrad2 = CPv4_progGrad2;
            this.CPv4_progBackGrad1 = CPv4_progBackGrad1;
            this.CPv4_progBackGrad2 = CPv4_progBackGrad2;
            this.CPv4_speed = CPv4_speed;
        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressV5,
            //Size minimumSizeAllowed,
            Size _minimumSize,
            //int _barCount,
            BarData[] _bars,
            bool _borderEnabled,
            //Image _image,
            int _barSeperation,
            int _barWidth,
            bool _displayPercentage,
            bool _displayTotalPercentage,
            bool _smoothBars,
            string _info,
            bool _textShadow,
            Color _textShadowColor,
            bool _inactiveColorEnabled,
            int CPv5_marqueeAngle,
            bool CPv5_marquee,
            int CPv5_marqueeinterval,
            int CPv5_interval,
            int otherinterval,
            bool CPv5_reset,
            bool _imageEnabled

            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularProgressV5 = circularProgressV5;
            //this.minimumSizeAllowed = minimumSizeAllowed;
            this._minimumSize = _minimumSize;
            //this._barCount = _barCount;
            this._bars = _bars;
            this._borderEnabled = _borderEnabled;
            //this._image = _image;
            this._barSeperation = _barSeperation;
            this._barWidth = _barWidth;
            this._displayPercentage = _displayPercentage;
            this._displayTotalPercentage = _displayTotalPercentage;
            this._smoothBars = _smoothBars;
            this._info = _info;
            this._textShadow = _textShadow;
            this._textShadowColor = _textShadowColor;
            this._inactiveColorEnabled = _inactiveColorEnabled;
            this.CPv5_marqueeAngle = CPv5_marqueeAngle;
            this.CPv5_marquee = CPv5_marquee;
            this.CPv5_marqueeinterval = CPv5_marqueeinterval;
            this.CPv5_interval = CPv5_interval;
            this.otherinterval = otherinterval;
            this.CPv5_reset = CPv5_reset;
            this._imageEnabled = _imageEnabled;

        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularGorgeous,
            bool Gorgeous_enableInnerCover,
            int Gorgeous_outerShift,
            int Gorgeous_innerShift,
            int Gorgeous_innerCoverShift,
            int Gorgeous_smallRectShift,
            Color[] Gorgeous_gradientColors,
            Color[] Gorgeous_solidcolors,
            int Gorgeous_border,
            bool Gorgeous_showText,
            ThematicProgress.Gorgeous_rotatingAngle _rotatingAngle

            
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularGorgeous = circularGorgeous;
            this.Gorgeous_enableInnerCover = Gorgeous_enableInnerCover;
            this.Gorgeous_outerShift = Gorgeous_outerShift;
            this.Gorgeous_innerShift = Gorgeous_innerShift;
            this.Gorgeous_innerCoverShift = Gorgeous_innerCoverShift;
            this.Gorgeous_smallRectShift = Gorgeous_smallRectShift;
            this.Gorgeous_gradientColors = Gorgeous_gradientColors;
            this.Gorgeous_solidcolors = Gorgeous_solidcolors;
            this.Gorgeous_border = Gorgeous_border;
            this.Gorgeous_showText = Gorgeous_showText;
            this._rotatingAngle = _rotatingAngle;

        }


        public ProgressInput(

            ProgressType circularType,
            CircularProgress circularIgnito,
            float Ignito_outerborder,
            float Ignito_innerborder,
            Color[] Ignito_colors,
            bool Ignito_enableHatch,
            LineCap Ignito_cap,
            ThematicProgress.Ignito_innerRotatingAngle Ignito_innerRotaAngle,
            ThematicProgress.Ignito_outterRotatingAngle Ignito_outterRotaAngle,
            ThematicProgress.Ignito_drawMode ignito_drawMode,
            DashStyle Ignito_borderStyleouter,
            DashStyle Ignito_borderStyleInner
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularIgnito = circularIgnito;
            this.Ignito_outerborder = Ignito_outerborder;
            this.Ignito_innerborder = Ignito_innerborder;
            this.Ignito_colors = Ignito_colors;
            this.Ignito_enableHatch = Ignito_enableHatch;
            this.Ignito_cap = Ignito_cap;
            this.Ignito_innerRotaAngle = Ignito_innerRotaAngle;
            this.Ignito_outterRotaAngle = Ignito_outterRotaAngle;
            this.ignito_drawMode = ignito_drawMode;
            this.Ignito_borderStyleouter = Ignito_borderStyleouter;
            this.Ignito_borderStyleInner = Ignito_borderStyleInner;
        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularAwesome,
            float ProgressAwesome_marqueeAnimationSpeed,
            string ProgressAwesome_superscriptText,
            Font ProgressAwesome_secondaryFont,
            string ProgressAwesome_subscriptText,
            Color ProgressAwesome_superscriptColor,
            Color ProgressAwesome_subscriptColor,
            int ProgressAwesome_startAngle,
            Padding ProgressAwesome_subscriptMargin,
            Padding ProgressAwesome_superscriptMargin,
            Padding ProgressAwesome_textMargin,
            int ProgressAwesome_animationSpeed,
            int ProgressAwesome_outerMargin,
            int ProgressAwesome_outerWidth,
            Color ProgressAwesome_outerColor,
            int ProgressAwesome_progressWidth,
            Color ProgressAwesome_progressColor,
            int ProgressAwesome_innerMargin,
            int ProgressAwesome_innerWidth,
            Color ProgressAwesome_innerColor,
            ProgressBarStyle ProgressAwesome_style
            //AnimationFunctions.Function ProgressAwesome_animationFunction,
            //KnownAnimationFunctions ProgressAwesome_knownAnimationFunction
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularAwesome = circularAwesome;
            this.ProgressAwesome_marqueeAnimationSpeed = ProgressAwesome_marqueeAnimationSpeed;
            this.ProgressAwesome_superscriptText = ProgressAwesome_superscriptText;
            this.ProgressAwesome_secondaryFont = ProgressAwesome_secondaryFont;
            this.ProgressAwesome_subscriptText = ProgressAwesome_subscriptText;
            this.ProgressAwesome_superscriptColor = ProgressAwesome_superscriptColor;
            this.ProgressAwesome_subscriptColor = ProgressAwesome_subscriptColor;
            this.ProgressAwesome_startAngle = ProgressAwesome_startAngle;
            this.ProgressAwesome_subscriptMargin = ProgressAwesome_subscriptMargin;
            this.ProgressAwesome_superscriptMargin = ProgressAwesome_superscriptMargin;
            this.ProgressAwesome_textMargin = ProgressAwesome_textMargin;
            this.ProgressAwesome_animationSpeed = ProgressAwesome_animationSpeed;
            this.ProgressAwesome_outerMargin = ProgressAwesome_outerMargin;
            this.ProgressAwesome_outerWidth = ProgressAwesome_outerWidth;
            this.ProgressAwesome_outerColor = ProgressAwesome_outerColor;
            this.ProgressAwesome_progressWidth = ProgressAwesome_progressWidth;
            this.ProgressAwesome_progressColor = ProgressAwesome_progressColor;
            this.ProgressAwesome_innerMargin = ProgressAwesome_innerMargin;
            this.ProgressAwesome_innerWidth = ProgressAwesome_innerWidth;
            this.ProgressAwesome_innerColor = ProgressAwesome_innerColor;
            this.ProgressAwesome_style = ProgressAwesome_style;
            //this.ProgressAwesome_animationFunction = ProgressAwesome_animationFunction;
            //this.ProgressAwesome_knownAnimationFunction = ProgressAwesome_knownAnimationFunction;
        }


        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularPerfect,
            int ProgressPerfect_interval,
            Color ProgressPerfect_circleColor,
            //bool _stopped,
            float ProgressPerfect_circleSize,
            float _numberOfCircles,
            int _numberOfVisibleCircles,
            RotationType1 ProgressPerfect_rotation,
            float ProgressPerfect_percentage,
            bool ProgressPerfect_showPercentage,
            bool ProgressBarPerfect_showText,
            TextDisplayModes1 ProgressPerfect_textDisplay

            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularPerfect = circularPerfect;
            this.ProgressPerfect_interval = ProgressPerfect_interval;
            this.ProgressPerfect_circleColor = ProgressPerfect_circleColor;
            //this._stopped = _stopped;
            this.ProgressPerfect_circleSize = ProgressPerfect_circleSize;
            this._numberOfCircles = _numberOfCircles;
            this._numberOfVisibleCircles = _numberOfVisibleCircles;
            this.ProgressPerfect_rotation = ProgressPerfect_rotation;
            this.ProgressPerfect_percentage = ProgressPerfect_percentage;
            this.ProgressPerfect_showPercentage = ProgressPerfect_showPercentage;
            this.ProgressBarPerfect_showText = ProgressBarPerfect_showText;
            this.ProgressPerfect_textDisplay = ProgressPerfect_textDisplay;
        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularProgressPie,
            Color ProgressPie_progressColor1,
            Color ProgressPie_progressColor2,
            Color ProgressPie_fillEllipse1,
            Color ProgressPie_fillEllipse2,
            Color ProgressPie_textColor,
            Color ProgressPie_progressColorInnerBorder,
            ThematicProgress.ProgressPie_ProgressShape ProgressPie_progressShapeVal,
            LineCap ProgressPie_start,
            LineCap ProgressPie_end,
            Double ProgressPie_progressWidth,
            float ProgressPie_penWidth,
            //float ProgressPie_progressWidthToFloat,
            bool ProgressPie_showText,
            float ProgressPie_position,
            float ProgressPie_sweepAngle
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularProgressPie = circularProgressPie;
            this.ProgressPie_progressColor1 = ProgressPie_progressColor1;
            this.ProgressPie_progressColor2 = ProgressPie_progressColor2;
            this.ProgressPie_fillEllipse1 = ProgressPie_fillEllipse1;
            this.ProgressPie_fillEllipse2 = ProgressPie_fillEllipse2;
            this.ProgressPie_textColor = ProgressPie_textColor;
            this.ProgressPie_progressColorInnerBorder = ProgressPie_progressColorInnerBorder;
            this.ProgressPie_progressShapeVal = ProgressPie_progressShapeVal;
            this.ProgressPie_start = ProgressPie_start;
            this.ProgressPie_end = ProgressPie_end;
            this.ProgressPie_progressWidth = ProgressPie_progressWidth;
            this.ProgressPie_penWidth = ProgressPie_penWidth;
            //this.ProgressPie_progressWidthToFloat = ProgressPie_progressWidthToFloat;
            this.ProgressPie_showText = ProgressPie_showText;
            this.ProgressPie_position = ProgressPie_position;
            this.ProgressPie_sweepAngle = ProgressPie_sweepAngle;
        }


        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularArc,
            float angle,
            int interval,
            bool rotatingBorder,
            ThematicProgress.PieArc pieArc,
            ThematicProgress.RotatingArc_drawMode RotatingArc_drawmode,
            ThematicProgress.shape _shape,
            int size,
            Color customHeartFade,
            Color pieColor1,
            Color pieColor2,
            Color lineColor1,
            Color lineColor2,
            Color lineWidthColor,
            bool fillPie,
            bool drawLine,
            Color colorOuterBorder,
            Color innerCircle1Grad1,
            Color innerCircle1Grad2,
            Color innerCircle2Grad1,
            Color innerCircle2Grad2,
            Color innerCircle3Grad1,
            Color innerCircle3Grad2,
            Color innerCircle4Grad1,
            Color innerCircle4Grad2,
            Color innerCircle5Grad1,
            Color innerCircle5Grad2,
            Color innerCircle6Grad1,
            Color innerCircle6Grad2,
            bool showInnerCircle1,
            bool showInnerCircle2,
            bool showInnerCircle3,
            bool showInnerCircle4,
            bool showInnerCircle5,
            bool showInnerCircle6,
            int outerBorderWidth,
            int innercircleBorder,
            int widthReduction,
            int heightReduction,
            int innercircle2Width,
            int innercircle2Height,
            int innercircle3Width,
            int innercircle3Height,
            int innercircle4Width,
            int innercircle4Height,
            int innercircle5Width,
            int innercircle5Height,
            int innercircle6Width,
            int innercircle6Height,
            int heartinterval,
            bool heartAutoAnimate

            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularArc = circularArc;
            this.angle = angle;
            this.interval = interval;
            this.rotatingBorder = rotatingBorder;
            this.pieArc = pieArc;
            this.RotatingArc_drawmode = RotatingArc_drawmode;
            this._shape = _shape;
            this.size = size;
            this.customHeartFade = customHeartFade;
            this.pieColor1 = pieColor1;
            this.pieColor2 = pieColor2;
            this.lineColor1 = lineColor1;
            this.lineColor2 = lineColor2;
            this.lineWidthColor = lineWidthColor;
            this.fillPie = fillPie;
            this.drawLine = drawLine;
            this.colorOuterBorder = colorOuterBorder;
            this.innerCircle1Grad1 = innerCircle1Grad1;
            this.innerCircle1Grad2 = innerCircle1Grad2;
            this.innerCircle2Grad1 = innerCircle2Grad1;
            this.innerCircle2Grad2 = innerCircle2Grad2;
            this.innerCircle3Grad1 = innerCircle3Grad1;
            this.innerCircle3Grad2 = innerCircle3Grad2;
            this.innerCircle4Grad1 = innerCircle4Grad1;
            this.innerCircle4Grad2 = innerCircle4Grad2;
            this.innerCircle5Grad1 = innerCircle5Grad1;
            this.innerCircle5Grad2 = innerCircle5Grad2;
            this.innerCircle6Grad1 = innerCircle6Grad1;
            this.innerCircle6Grad2 = innerCircle6Grad2;
            this.showInnerCircle1 = showInnerCircle1;
            this.showInnerCircle2 = showInnerCircle2;
            this.showInnerCircle3 = showInnerCircle3;
            this.showInnerCircle4 = showInnerCircle4;
            this.showInnerCircle5 = showInnerCircle5;
            this.showInnerCircle6 = showInnerCircle6;
            this.outerBorderWidth = outerBorderWidth;
            this.innercircleBorder = innercircleBorder;
            this.widthReduction = widthReduction;
            this.heightReduction = heightReduction;
            this.innercircle2Width = innercircle2Width;
            this.innercircle2Height = innercircle2Height;
            this.innercircle3Width = innercircle3Width;
            this.innercircle3Height = innercircle3Height;
            this.innercircle4Width = innercircle4Width;
            this.innercircle4Height = innercircle4Height;
            this.innercircle5Width = innercircle5Width;
            this.innercircle5Height = innercircle5Height;
            this.innercircle6Width = innercircle6Width;
            this.innercircle6Height = innercircle6Height;
            this.heartinterval = heartinterval;
            this.heartAutoAnimate = heartAutoAnimate;

        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularCompass,
            Color pieColor1,
            Color pieColor2,
            Color lineColor1,
            Color lineColor2,
            int size,
            bool rotatingBorder,
            float angle


            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularCompass = circularCompass;
            this.pieColor1 = pieColor1;
            this.pieColor2 = pieColor2;
            this.lineColor1 = lineColor1;
            this.lineColor2 = lineColor2;
            this.size = size;
            this.rotatingBorder = rotatingBorder;
            this.angle = angle;
        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularSupreme,
            ThematicProgress.Supreme_colorMode SP_colorMode,
            Color progressColor,
            Color outerColor,
            Color solidColor,
            Color[] gradientColor,
            LinearGradientMode linMode,
            float SP_angle,
            int outerborder,
            int innerborder
            
            ) : this(ProgressType.Circular)
        {
            this.circularType = circularType;
            this.circularSupreme = circularSupreme;
            this.SP_colorMode = SP_colorMode;
            this.progressColor = progressColor;
            this.outerColor = outerColor;
            this.solidColor = solidColor;
            this.gradientColor = gradientColor;
            this.linMode = linMode;
            this.SP_angle = SP_angle;
            this.outerborder = outerborder;
            this.innerborder = innerborder;

        }


        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularMultiCo,
            bool MC_showInnerBorder,
            int MC_innerBorder,
            int MC_shift,
            int MC_correctShift,
            int MC_rectShift,
            Rings MC_noOfRings,
            Color[] MC_colors
            
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularMultiCo = circularMultiCo;
            this.MC_showInnerBorder = MC_showInnerBorder;
            this.MC_innerBorder = MC_innerBorder;
            this.MC_shift = MC_shift;
            this.MC_correctShift = MC_correctShift;
            this.MC_rectShift = MC_rectShift;
            this.MC_noOfRings = MC_noOfRings;
            this.MC_colors = MC_colors;

        }


        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularMultiCoExt,
            bool MCEx_showInnerBorder,
            int MCEx_innerBorder,
            int MCEx_shift,
            int MCEx_correctShift,
            int MCEx_rectShift,
            Rings MCEx_noOfRings,
            Color[] MCEx_colors,
            Color MCEx_innerBorderColor
            
        
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularMultiCoExt = circularMultiCoExt;
            this.MCEx_showInnerBorder = MCEx_showInnerBorder;
            this.MCEx_innerBorder = MCEx_innerBorder;
            this.MCEx_shift = MCEx_shift;
            this.MCEx_correctShift = MCEx_correctShift;
            this.MCEx_rectShift = MCEx_rectShift;
            this.MCEx_noOfRings = MCEx_noOfRings;
            this.MCEx_innerBorderColor = MCEx_innerBorderColor;
            this.MCEx_colors = MCEx_colors;

        }

        public ProgressInput(
            ProgressType circularType,
            CircularProgress circularMultiCoExtV1,
            LineCap MCExV2_outerBorderStart,
            LineCap MCExV2_outerBorderEnd,
            DashStyle MCExV2_outerBorderStyle,
            float MCExV2_gradientAngle,
            bool MCExV2_outerborder,
            bool MCExV2_rotatingborder,
            bool MCExV2_divisions,
            int MCExV2_divisionsWidth,
            drawMode MCExV2_drawMode,
            bool MCExV2_showInnerBorder,
            int MCExV2_innerBorder,
            int MCExV2_shift,
            int MCExV2_correctShift,
            int MCExV2_rectShift,
            Rings MCExV2_noOfRings,
            Color MCExV2_innerHoleColor,
            Color[] MCExV2_innerHoleGradColor,
            Color[] MCExV2_linColors0,
            Color[] MCExV2_linColors1,
            Color[] MCExV2_colors,
            Color MCExV2_innerBorderColor
            ) : this(ProgressType.Circular)
        {

            this.circularType = circularType;
            this.circularMultiCoExtV1 = circularMultiCoExtV1;
            this.MCExV2_outerBorderStart = MCExV2_outerBorderStart;
            this.MCExV2_outerBorderEnd = MCExV2_outerBorderEnd;
            this.MCExV2_outerBorderStyle = MCExV2_outerBorderStyle;
            this.MCExV2_gradientAngle = MCExV2_gradientAngle;
            this.MCExV2_outerborder = MCExV2_outerborder;
            this.MCExV2_rotatingborder = MCExV2_rotatingborder;
            this.MCExV2_divisions = MCExV2_divisions;
            this.MCExV2_divisionsWidth = MCExV2_divisionsWidth;
            this.MCExV2_drawMode = MCExV2_drawMode;
            this.MCExV2_showInnerBorder = MCExV2_showInnerBorder;
            this.MCExV2_innerBorder = MCExV2_innerBorder;
            this.MCExV2_shift = MCExV2_shift;
            this.MCExV2_correctShift = MCExV2_correctShift;
            this.MCExV2_rectShift = MCExV2_rectShift;
            this.MCExV2_noOfRings = MCExV2_noOfRings;
            this.MCExV2_innerHoleColor = MCExV2_innerHoleColor;
            this.MCExV2_innerHoleGradColor = MCExV2_innerHoleGradColor;
            this.MCExV2_innerBorderColor = MCExV2_innerBorderColor;
            this.MCExV2_linColors0 = MCExV2_linColors0;
            this.MCExV2_linColors1 = MCExV2_linColors1;
            this.MCExV2_colors = MCExV2_colors;


        }

        #endregion

        #region Indicator Constructor
        
        /// <summary>
        /// Constructor for Indeterminate Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="indeterminate_Ind"></param>
        /// <param name="background_color"></param>
        /// <param name="circles_count"></param>
        /// <param name="control_color"></param>
        /// <param name="control_width_height"></param>
        /// <param name="indicator_angle"></param>
        /// <param name="indicator_angular_advance"></param>
        /// <param name="indicator_color"></param>
        /// <param name="indicator_diameter"></param>
        /// <param name="indicator_type"></param>
        /// <param name="refresh_rate"></param>
        /// <param name="indeterminate_Animate"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator indeterminate_Ind,
            Color background_color,
            int circles_count,
            Color control_color,
            int control_width_height,
            float indicator_angle,
            float indicator_angular_advance,
            Color indicator_color,
            int indicator_diameter,
            ThematicProgress.INDICATORTYPES indicator_type,
            int refresh_rate,
            bool indeterminate_Animate
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.indeterminate_Ind = indeterminate_Ind;
            this.background_color = background_color;
            this.circles_count = circles_count;
            this.control_color = control_color;
            this.control_width_height = control_width_height;
            this.indicator_angle = indicator_angle;
            this.indicator_angular_advance = indicator_angular_advance;
            this.indicator_color = indicator_color;
            this.indicator_diameter = indicator_diameter;
            this.indicator_type = indicator_type;
            this.refresh_rate = refresh_rate;
            this.indeterminate_Animate = indeterminate_Animate;

        }

        /// <summary>
        /// Constructor for Google Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="google_Ind"></param>
        /// <param name="GoogleProgress_annulus_color"></param>
        /// <param name="GoogleProgress_annulus_thickness"></param>
        /// <param name="GoogleProgress_background_color"></param>
        /// <param name="GoogleProgress_indicator_angle"></param>
        /// <param name="GoogleProgress_indicator_angular_advance"></param>
        /// <param name="GoogleProgress_indicator_color"></param>
        /// <param name="GoogleProgress_indicator_type"></param>
        /// <param name="inner_radius"></param>
        /// <param name="outer_radius"></param>
        /// <param name="GoogleProgress_refresh_rate"></param>
        /// <param name="GoogleProgress_angle"></param>
        /// <param name="transition_color"></param>
        /// <param name="color1bigcircle"></param>
        /// <param name="color2bigcircle"></param>
        /// <param name="color1indicator"></param>
        /// <param name="color2indicator"></param>
        /// <param name="inner_color"></param>
        /// <param name="inner_border"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator google_Ind,
            Color GoogleProgress_annulus_color,
            //int GoogleProgress_annulus_thickness,
            Color GoogleProgress_background_color,
            int GoogleProgress_indicator_angle,
            int GoogleProgress_indicator_angular_advance,
            Color GoogleProgress_indicator_color,
            ThematicProgress.GoogleProgress_INDICATORTYPES GoogleProgress_indicator_type,
            int inner_radius,
            int outer_radius,
            int GoogleProgress_refresh_rate,
            float GoogleProgress_angle,
            Color transition_color,
            Color color1bigcircle,
            Color color2bigcircle,
            Color color1indicator,
            Color color2indicator,
            Color inner_color,
            int inner_border
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.google_Ind = google_Ind;
            this.GoogleProgress_annulus_color = GoogleProgress_annulus_color;
            //this.GoogleProgress_annulus_thickness = GoogleProgress_annulus_thickness;
            this.GoogleProgress_background_color = GoogleProgress_background_color;
            this.GoogleProgress_indicator_angle = GoogleProgress_indicator_angle;
            this.GoogleProgress_indicator_angular_advance = GoogleProgress_indicator_angular_advance;
            this.GoogleProgress_indicator_color = GoogleProgress_indicator_color;
            this.GoogleProgress_indicator_type = GoogleProgress_indicator_type;
            this.inner_radius = inner_radius;
            this.outer_radius = outer_radius;
            this.GoogleProgress_refresh_rate = GoogleProgress_refresh_rate;
            this.GoogleProgress_angle = GoogleProgress_angle;
            this.transition_color = transition_color;
            this.color1bigcircle = color1bigcircle;
            this.color2bigcircle = color2bigcircle;
            this.color1indicator = color1indicator;
            this.color2indicator = color2indicator;
            this.inner_color = inner_color;
            this.inner_border = inner_border;


        }


        /// <summary>
        /// Constructor for MacOSX
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="macOsX_Ind"></param>
        /// <param name="MacOSX_m_Interval"></param>
        /// <param name="MacOSX_m_InnerRadius"></param>
        /// <param name="MacOSX_m_OuterRadius"></param>
        /// <param name="MacOSX_m_StartAngle"></param>
        /// <param name="MacOSX_m_AlphaStartValue"></param>
        /// <param name="MacOSX_m_SpokesCount"></param>
        /// <param name="MacOSX_m_AngleIncrement"></param>
        /// <param name="MacOSX_m_AlphaDecrement"></param>
        /// <param name="_automatic"></param>
        /// <param name="tick_Color"></param>
        /// <param name="macOSX_Rotation"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator macOsX_Ind,
            int MacOSX_m_Interval,
            int MacOSX_m_InnerRadius,
            int MacOSX_m_OuterRadius,
            int MacOSX_m_StartAngle,
            int MacOSX_m_AlphaStartValue,
            int MacOSX_m_SpokesCount,
            int MacOSX_m_AngleIncrement,
            int MacOSX_m_AlphaDecrement,
            LineCap MacOSX_startCap,
            LineCap MacOSX_endCap,
            MacOSX_automatic _automatic,
            Color tick_Color,
            ThematicProgress.MacOSX_Direction macOSX_Rotation
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.macOsX_Ind = macOsX_Ind;
            this.MacOSX_m_Interval = MacOSX_m_Interval;
            this.MacOSX_m_InnerRadius = MacOSX_m_InnerRadius;
            this.MacOSX_m_OuterRadius = MacOSX_m_OuterRadius;
            this.MacOSX_m_StartAngle = MacOSX_m_StartAngle;
            this.MacOSX_m_AlphaStartValue = MacOSX_m_AlphaStartValue;
            this.MacOSX_m_SpokesCount = MacOSX_m_SpokesCount;
            this.MacOSX_m_AngleIncrement = MacOSX_m_AngleIncrement;
            this.MacOSX_m_AlphaDecrement = MacOSX_m_AlphaDecrement;
            this.MacOSX_startCap = MacOSX_startCap;
            this.MacOSX_endCap = MacOSX_endCap;
            this._automatic = _automatic;
            this.tick_Color = tick_Color;
            this.macOSX_Rotation = macOSX_Rotation;

        }

        /// <summary>
        /// Constructor for MacOSX Optimized Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="macOsXOpt_Ind"></param>
        /// <param name="MacOSX_Optimized_m_Interval"></param>
        /// <param name="MacOSX_Optimized_m_StartAngle"></param>
        /// <param name="MacOSX_Optimized_m_AngleIncrement"></param>
        /// <param name="MacOSX_Optimized_m_Rotation"></param>
        /// <param name="macOSX_Optimized_tick_Color"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator macOsXOpt_Ind,
            int MacOSX_Optimized_m_Interval,
            float MacOSX_Optimized_m_StartAngle,
            float MacOSX_Optimized_m_AngleIncrement,
            int MacOSX_Optimized_m_SpokesCount,
            LineCap MacOSX_Optimized_startCap,
            LineCap MacOSX_Optimized_endCap,
            MacOSX_automatic _automatic,
            ThematicProgress.MacOSX_Direction MacOSX_Optimized_m_Rotation,
            Color macOSX_Optimized_tick_Color
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.macOsXOpt_Ind = macOsXOpt_Ind;
            this.MacOSX_Optimized_m_Interval = MacOSX_Optimized_m_Interval;
            this.MacOSX_Optimized_m_StartAngle = MacOSX_Optimized_m_StartAngle;
            this.MacOSX_Optimized_m_AngleIncrement = MacOSX_Optimized_m_AngleIncrement;
            this.MacOSX_Optimized_m_SpokesCount = MacOSX_Optimized_m_SpokesCount;
            this.MacOSX_Optimized_startCap = MacOSX_Optimized_startCap;
            this.MacOSX_Optimized_endCap = MacOSX_Optimized_endCap;
            this._automatic = _automatic;
            this.MacOSX_Optimized_m_Rotation = MacOSX_Optimized_m_Rotation;
            this.macOSX_Optimized_tick_Color = macOSX_Optimized_tick_Color;

        }


        /// <summary>
        /// Constructor for Matrix Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="matrix_Ind"></param>
        /// <param name="MacOSX_Matrix_m_Interval"></param>
        /// <param name="MacOSX_Matrix_m_StartAngle"></param>
        /// <param name="MacOSX_Matrix_m_Rotation"></param>
        /// <param name="matrix_tick_Color"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator matrix_Ind,
            int MacOSX_Matrix_m_Interval,
            float MacOSX_Matrix_m_StartAngle,
            int MacOSX_Matrix_m_SpokesCount,
            LineCap MacOSX_Matrix_startCap,
            LineCap MacOSX_Matrix_endCap,
            MacOSX_automatic _automatic,
            ThematicProgress.MacOSX_Direction MacOSX_Matrix_m_Rotation,
            Color matrix_tick_Color
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.matrix_Ind = matrix_Ind;
            this.MacOSX_Matrix_m_Interval = MacOSX_Matrix_m_Interval;
            this.MacOSX_Matrix_m_StartAngle = MacOSX_Matrix_m_StartAngle;
            this.MacOSX_Matrix_m_SpokesCount = MacOSX_Matrix_m_SpokesCount;
            this.MacOSX_Matrix_startCap = MacOSX_Matrix_startCap;
            this.MacOSX_Matrix_endCap = MacOSX_Matrix_endCap;
            this._automatic = _automatic;
            this.MacOSX_Matrix_m_Rotation = MacOSX_Matrix_m_Rotation;
            this.matrix_tick_Color = matrix_tick_Color;

        }

        /// <summary>
        /// Constructor for IndicatorV1 Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="indicatorV1_Ind"></param>
        /// <param name="baseColor"></param>
        /// <param name="animationColor"></param>
        /// <param name="_visibleCircles"></param>
        /// <param name="_radian"></param>
        /// <param name="_circleWidth"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator indicatorV1_Ind,
            Color baseColor,
            Color animationColor,
            float _visibleCircles,
            double _radian,
            float _circleWidth
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.indicatorV1_Ind = indicatorV1_Ind;
            this.baseColor = baseColor;
            this.animationColor = animationColor;
            this._visibleCircles = _visibleCircles;
            this._radian = _radian;
            this._circleWidth = _circleWidth;

        }

        /// <summary>
        /// Constructor for Unique Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="unique_Ind"></param>
        /// <param name="Unique_interval"></param>
        /// <param name="Unique_circleColor"></param>
        /// <param name="Unique_circleSize"></param>
        /// <param name="Unique_numberOfCircles"></param>
        /// <param name="Unique_numberOfVisibleCircles"></param>
        /// <param name="Unique_rotation"></param>
        /// <param name="Unique_percentage"></param>
        /// <param name="Unique_showPercentage"></param>
        /// <param name="Unique_showText"></param>
        /// <param name="Unique_textDisplay"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator unique_Ind,
            int Unique_interval,
            Color Unique_circleColor,
            float Unique_circleSize,
            int Unique_numberOfCircles,
            int Unique_numberOfVisibleCircles,
            Unique_RotationType Unique_rotation,
            float Unique_percentage,
            bool Unique_showPercentage,
            bool Unique_showText,
            Unique_TextDisplayModes Unique_textDisplay

            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.unique_Ind = unique_Ind;
            this.Unique_interval = Unique_interval;
            this.Unique_circleColor = Unique_circleColor;
            this.Unique_circleSize = Unique_circleSize;
            this.Unique_numberOfCircles = Unique_numberOfCircles;
            this.Unique_numberOfVisibleCircles = Unique_numberOfVisibleCircles;
            this.Unique_rotation = Unique_rotation;
            this.Unique_percentage = Unique_percentage;
            this.Unique_showPercentage = Unique_showPercentage;
            this.Unique_showText = Unique_showText;
            this.Unique_textDisplay = Unique_textDisplay;

        }

        /// <summary>
        /// Constructor for Vuvuzela Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="vuvuzela_Ind"></param>
        /// <param name="Vuvuzela_angle"></param>
        /// <param name="Vuvuzela_interval"></param>
        /// <param name="Vuvuzela_rotatingBorder"></param>
        /// <param name="Vuvuzela_shape"></param>
        /// <param name="Vuvuzela_size"></param>
        /// <param name="Vuvuzela_fillPie"></param>
        /// <param name="Vuvuzela_rotatingCircle"></param>
        /// <param name="Vuvuzela_circle1"></param>
        /// <param name="Vuvuzela_circle2"></param>
        /// <param name="Vuvuzela_circle3"></param>
        /// <param name="Vuvuzela_circle4"></param>
        /// <param name="Vuvuzela_circle5"></param>
        /// <param name="Vuvuzela_circleSize"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator vuvuzela_Ind,
            float Vuvuzela_angle,
            int Vuvuzela_interval,
            bool Vuvuzela_rotatingBorder,
            ThematicProgress.Vuvuzela_Shape Vuvuzela_shape,
            int Vuvuzela_size,
            bool Vuvuzela_fillPie,
            Color Vuvuzela_rotatingCircle,
            Color Vuvuzela_circle1,
            Color Vuvuzela_circle2,
            Color Vuvuzela_circle3,
            Color Vuvuzela_circle4,
            Color Vuvuzela_circle5,
            int Vuvuzela_circleSize
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.vuvuzela_Ind = vuvuzela_Ind;
            this.Vuvuzela_angle = Vuvuzela_angle;
            this.Vuvuzela_interval = Vuvuzela_interval;
            this.Vuvuzela_rotatingBorder = Vuvuzela_rotatingBorder;
            this.Vuvuzela_shape = Vuvuzela_shape;
            this.Vuvuzela_size = Vuvuzela_size;
            this.Vuvuzela_fillPie = Vuvuzela_fillPie;
            this.Vuvuzela_rotatingCircle = Vuvuzela_rotatingCircle;
            this.Vuvuzela_circle1 = Vuvuzela_circle1;
            this.Vuvuzela_circle2 = Vuvuzela_circle2;
            this.Vuvuzela_circle3 = Vuvuzela_circle3;
            this.Vuvuzela_circle4 = Vuvuzela_circle4;
            this.Vuvuzela_circle5 = Vuvuzela_circle5;
            this.Vuvuzela_circleSize = Vuvuzela_circleSize;

        }

        /// <summary>
        /// Constructor for SpinnerCir Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="spinnerCirc_Ind"></param>
        /// <param name="Spinner_m_IsTimerActive"></param>
        /// <param name="m_NumberOfSpoke"></param>
        /// <param name="m_SpokeThickness"></param>
        /// <param name="m_OuterCircleRadius"></param>
        /// <param name="m_InnerCircleRadius"></param>
        /// <param name="m_Color"></param>
        /// <param name="m_StylePreset"></param>
        /// <param name="_Timer_Interval"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator spinnerCirc_Ind,
            bool Spinner_m_IsTimerActive,
            int m_NumberOfSpoke,
            int m_SpokeThickness,
            int m_OuterCircleRadius,
            int m_InnerCircleRadius,
            Color m_Color,
            ThematicProgress.StylePresets m_StylePreset,
            int _Timer_Interval
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.spinnerCirc_Ind = spinnerCirc_Ind;
            this.Spinner_m_IsTimerActive = Spinner_m_IsTimerActive;
            this.m_NumberOfSpoke = m_NumberOfSpoke;
            this.m_SpokeThickness = m_SpokeThickness;
            this.m_OuterCircleRadius = m_OuterCircleRadius;
            this.m_InnerCircleRadius = m_InnerCircleRadius;
            this.m_Color = m_Color;
            this.m_StylePreset = m_StylePreset;
            this._Timer_Interval = _Timer_Interval;

        }

        /// <summary>
        /// Constructor for Spinner Divided Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="spinnerDivided_Ind"></param>
        /// <param name="m_InactiveColour"></param>
        /// <param name="m_ActiveColour"></param>
        /// <param name="m_TransistionColour"></param>
        /// <param name="m_AutoIncrement"></param>
        /// <param name="m_IncrementFrequency"></param>
        /// <param name="m_BehindIsActive"></param>
        /// <param name="m_TransitionSegment"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator spinnerDivided_Ind,
            Color m_InactiveColour,
            Color m_ActiveColour,
            Color m_TransistionColour,
            bool m_AutoIncrement,
            double m_IncrementFrequency,
            bool m_BehindIsActive,
            int m_TransitionSegment
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.spinnerDivided_Ind = spinnerDivided_Ind;
            this.m_InactiveColour = m_InactiveColour;
            this.m_ActiveColour = m_ActiveColour;
            this.m_TransistionColour = m_TransistionColour;
            this.m_AutoIncrement = m_AutoIncrement;
            this.m_IncrementFrequency = m_IncrementFrequency;
            this.m_BehindIsActive = m_BehindIsActive;
            this.m_TransitionSegment = m_TransitionSegment;

        }

        /// <summary>
        /// Constructor for Win8Horizontal Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="win8Horiz_Ind"></param>
        /// <param name="control_width"></param>
        /// <param name="WinHR_indicator_color"></param>
        /// <param name="WinHR_refresh_rate"></param>
        /// <param name="timer_interval"></param>
        /// <param name="winHR_Animate"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator win8Horiz_Ind,
            int control_width,
            Color WinHR_indicator_color,
            int WinHR_refresh_rate,
            double timer_interval,
            bool winHR_Animate
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.win8Horiz_Ind = win8Horiz_Ind;
            this.control_width = control_width;
            this.WinHR_indicator_color = WinHR_indicator_color;
            this.WinHR_refresh_rate = WinHR_refresh_rate;
            this.timer_interval = timer_interval;
            this.winHR_Animate = winHR_Animate;

        }

        /// <summary>
        /// Constructor for Win8Ring Progress
        /// </summary>
        /// <param name="indicProgType"></param>
        /// <param name="win8Ring_Ind"></param>
        /// <param name="WinRing_control_height"></param>
        /// <param name="WinRing_indicator_color"></param>
        /// <param name="WinRing_refresh_rate"></param>
        /// <param name="winRing_Animate"></param>
        public ProgressInput(
            ProgressType indicProgType,
            ProgressIndicator win8Ring_Ind,
            int WinRing_control_height,
            Color WinRing_indicator_color,
            int WinRing_refresh_rate,
            bool winRing_Animate
            
            ) : this(ProgressType.Indicator)
        {

            this.indicProgType = indicProgType;
            this.win8Ring_Ind = win8Ring_Ind;
            this.WinRing_control_height = WinRing_control_height;
            this.WinRing_indicator_color = WinRing_indicator_color;
            this.WinRing_refresh_rate = WinRing_refresh_rate;
            this.winRing_Animate = winRing_Animate;

        }

        #endregion

        #endregion
        

    }
}
