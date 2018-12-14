// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressInput.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    [TypeConverter(typeof(ProgressInput.ProgressInputConverter))]
    [Editor(typeof(ProgressEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [Serializable]
    public partial class ProgressInput : ISerializable
    {

        #region Private ReadOnly

        #region Bars

        /// <summary>
        /// The bar type
        /// </summary>
        private ProgressType barType = ProgressType.Bar;

        /// <summary>
        /// The extended bar
        /// </summary>
        private ProgressBar extendedBar = ProgressBar.RPExtendedProgress;
        /// <summary>
        /// The indicator bar
        /// </summary>
        private ProgressBar indicatorBar = ProgressBar.RPIndicator;
        /// <summary>
        /// The i tunes bar
        /// </summary>
        private ProgressBar iTunesBar = ProgressBar.RPiTunes;
        /// <summary>
        /// The maze bar
        /// </summary>
        private ProgressBar mazeBar = ProgressBar.RPMaze;
        /// <summary>
        /// The antonio normal bar
        /// </summary>
        private ProgressBar antonioNormalBar = ProgressBar.RPProgNormal;
        /// <summary>
        /// The alter bar
        /// </summary>
        private ProgressBar alterBar = ProgressBar.RPExtendedProgress;
        /// <summary>
        /// The clear bar
        /// </summary>
        private ProgressBar clearBar = ProgressBar.RPClear;
        /// <summary>
        /// The perplex bar
        /// </summary>
        private ProgressBar perplexBar = ProgressBar.RPPerplex;
        /// <summary>
        /// The rect bar
        /// </summary>
        private ProgressBar rectBar = ProgressBar.RPRect;
        /// <summary>
        /// The transparent bar
        /// </summary>
        private ProgressBar transparentBar = ProgressBar.RPTransparent;
        /// <summary>
        /// The splitter bar
        /// </summary>
        private ProgressBar splitterBar = ProgressBar.RPSplitter;

        #endregion

        #region Circular

        /// <summary>
        /// The circular type
        /// </summary>
        private ProgressType circularType = ProgressType.Bar;

        /// <summary>
        /// The circular progress bar
        /// </summary>
        private CircularProgress circularProgressBar = CircularProgress.ZeroitProgressBarCircular;
        /// <summary>
        /// The circular progress bar default
        /// </summary>
        private CircularProgress circularProgressBarDefault = CircularProgress.ZeroitProgressBarCircularDefault;
        /// <summary>
        /// The circular progress v2
        /// </summary>
        private CircularProgress circularProgressV2 = CircularProgress.CircularProgressv2;
        /// <summary>
        /// The circular progress v3
        /// </summary>
        private CircularProgress circularProgressV3 = CircularProgress.CircularProgressv3;
        /// <summary>
        /// The circular progress v4
        /// </summary>
        private CircularProgress circularProgressV4 = CircularProgress.CircularProgressv4;
        /// <summary>
        /// The circular progress v5
        /// </summary>
        private CircularProgress circularProgressV5 = CircularProgress.CircularProgressv5;
        /// <summary>
        /// The circular gorgeous
        /// </summary>
        private CircularProgress circularGorgeous = CircularProgress.GorgeousProgress;
        /// <summary>
        /// The circular ignito
        /// </summary>
        private CircularProgress circularIgnito = CircularProgress.Ignito;
        /// <summary>
        /// The circular awesome
        /// </summary>
        private CircularProgress circularAwesome = CircularProgress.Awesome;
        /// <summary>
        /// The circular perfect
        /// </summary>
        private CircularProgress circularPerfect = CircularProgress.Perfect;
        /// <summary>
        /// The circular progress pie
        /// </summary>
        private CircularProgress circularProgressPie = CircularProgress.ProgressPie;
        /// <summary>
        /// The circular arc
        /// </summary>
        private CircularProgress circularArc = CircularProgress.RotatingArc;
        /// <summary>
        /// The circular compass
        /// </summary>
        private CircularProgress circularCompass = CircularProgress.RotatingCompass;
        /// <summary>
        /// The circular supreme
        /// </summary>
        private CircularProgress circularSupreme = CircularProgress.SupremeCircle;
        /// <summary>
        /// The circular multi co
        /// </summary>
        private CircularProgress circularMultiCo = CircularProgress.MulitCo;
        /// <summary>
        /// The circular multi co ext
        /// </summary>
        private CircularProgress circularMultiCoExt = CircularProgress.MultiCoExtended;
        /// <summary>
        /// The circular multi co ext v1
        /// </summary>
        private CircularProgress circularMultiCoExtV1 = CircularProgress.MultiCoV1;


        #endregion

        #region Indicator

        /// <summary>
        /// The indic prog type
        /// </summary>
        private ProgressType indicProgType = ProgressType.Bar;

        /// <summary>
        /// The indeterminate ind
        /// </summary>
        private ProgressIndicator indeterminate_Ind = ProgressIndicator.CircularIndeterminate;
        /// <summary>
        /// The google ind
        /// </summary>
        private ProgressIndicator google_Ind = ProgressIndicator.GoogleProgressIndicator;
        /// <summary>
        /// The mac os x ind
        /// </summary>
        private ProgressIndicator macOsX_Ind = ProgressIndicator.MacOSX;
        /// <summary>
        /// The mac os x opt ind
        /// </summary>
        private ProgressIndicator macOsXOpt_Ind = ProgressIndicator.MacOSXOptimized;
        /// <summary>
        /// The matrix ind
        /// </summary>
        private ProgressIndicator matrix_Ind = ProgressIndicator.Matrix;
        /// <summary>
        /// The indicator v1 ind
        /// </summary>
        private ProgressIndicator indicatorV1_Ind = ProgressIndicator.IndicatorV1;
        /// <summary>
        /// The unique ind
        /// </summary>
        private ProgressIndicator unique_Ind = ProgressIndicator.Unique;
        /// <summary>
        /// The vuvuzela ind
        /// </summary>
        private ProgressIndicator vuvuzela_Ind = ProgressIndicator.Vuvuzela;
        /// <summary>
        /// The spinner circ ind
        /// </summary>
        private ProgressIndicator spinnerCirc_Ind = ProgressIndicator.SpinnerCircle;
        /// <summary>
        /// The spinner divided ind
        /// </summary>
        private ProgressIndicator spinnerDivided_Ind = ProgressIndicator.SpinnerDivided;
        /// <summary>
        /// The win8 horiz ind
        /// </summary>
        private ProgressIndicator win8Horiz_Ind = ProgressIndicator.Win8Horizontal;
        /// <summary>
        /// The win8 ring ind
        /// </summary>
        private ProgressIndicator win8Ring_Ind = ProgressIndicator.Win8Ring;


        #endregion

        #endregion

        #region Private Fields

        /// <summary>
        /// The progress type
        /// </summary>
        private ProgressType progressType = ProgressType.Bar;
        //private CircularProgress circularProgressType = CircularProgress.Ignito;
        //private ProgressIndicator indicatorType = ProgressIndicator.CircularIndeterminate;
        /// <summary>
        /// The solid bars
        /// </summary>
        private ProgressBar solidBars = ProgressBar.RPExtendedProgress;

        /// <summary>
        /// The fixed size
        /// </summary>
        private bool fixedSize = false;

        /// <summary>
        /// The allow transparency
        /// </summary>
        private bool allowTransparency = true;

        /// <summary>
        /// The automatic increment
        /// </summary>
        private bool autoIncrement = false;

        /// <summary>
        /// The transparency animator glow
        /// </summary>
        private bool transparencyAnimatorGlow = false;

        /// <summary>
        /// The show text
        /// </summary>
        private bool showText = false;

        /// <summary>
        /// The starting angle
        /// </summary>
        private float startingAngle = 270f;

        /// <summary>
        /// The value
        /// </summary>
        private float value = 0;

        /// <summary>
        /// The maximum
        /// </summary>
        private float maximum = 100;

        /// <summary>
        /// The minimum
        /// </summary>
        private float minimum = 0;

        /// <summary>
        /// The speed
        /// </summary>
        private int[] speed = new int[]
        {
            10,
            10,
            5000
        };

        /// <summary>
        /// The transparency
        /// </summary>
        private int transparency = 255;

        /// <summary>
        /// The drawing mode
        /// </summary>
        private drawMode drawingMode = drawMode.Solid;

        /// <summary>
        /// The easing type
        /// </summary>
        private PeaceAnimatorEasing easingType = PeaceAnimatorEasing.BounceEaseIn;

        /// <summary>
        /// The transparency easing type
        /// </summary>
        private transparencyEasingType transparencyEasingType = transparencyEasingType.BounceEaseIn;

        /// <summary>
        /// The post fix
        /// </summary>
        private string postFix = "%";

        //private int interval = 100;


        #region HatchBrush

        /// <summary>
        /// The hatch brushgradient1
        /// </summary>
        private Color hatchBrushgradient1 = Color.FromArgb(254, 84, 84);
        /// <summary>
        /// The hatch brushgradient2
        /// </summary>
        private Color hatchBrushgradient2 = Color.DeepPink;

        /// <summary>
        /// The hatch brush type
        /// </summary>
        private ZeroitThematicProgress.HatchBrushType hatchBrushType = ZeroitThematicProgress.HatchBrushType.ForwardDiagonal;

        /// <summary>
        /// The automatic animate
        /// </summary>
        private bool autoAnimate = false;
        /// <summary>
        /// The automatic animate stating angle
        /// </summary>
        private bool autoAnimateStatingAngle = false;

        /// <summary>
        /// The dummy bool
        /// </summary>
        private bool dummyBool = false;
        #endregion


        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                
            }

        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow transparency].
        /// </summary>
        /// <value><c>true</c> if [allow transparency]; otherwise, <c>false</c>.</value>
        public bool AllowTransparency
        {
            get { return allowTransparency; }
            set
            {
                allowTransparency = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public float Value
        {
            get { return value; }
            set
            {
                
                this.value = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public float Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        public float Minimum
        {
            get
            {
                return minimum;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                minimum = value;
                
            }
        }


        #region HatchBrush Property


        /// <summary>
        /// Gets or sets the color hatch brushgradient1.
        /// </summary>
        /// <value>The color hatch brushgradient1.</value>
        public Color ColorHatchBrushgradient1
        {
            get { return hatchBrushgradient1; }
            set
            {
                hatchBrushgradient1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color hatch brushgradient2.
        /// </summary>
        /// <value>The color hatch brushgradient2.</value>
        public Color ColorHatchBrushgradient2
        {
            get { return hatchBrushgradient2; }
            set
            {
                hatchBrushgradient2 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the hatch brush.
        /// </summary>
        /// <value>The hatch brush.</value>
        public ZeroitThematicProgress.HatchBrushType HatchBrush
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

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressInput"/> is glow.
        /// </summary>
        /// <value><c>true</c> if glow; otherwise, <c>false</c>.</value>
        public bool Glow
        {
            get { return transparencyAnimatorGlow; }
            set
            {

                
                transparencyAnimatorGlow = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the fixed.
        /// </summary>
        /// <value>The size of the fixed.</value>
        public Boolean FixedSize
        {
            get { return fixedSize; }
            set
            {
                fixedSize = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the fill transparency.
        /// </summary>
        /// <value>The fill transparency.</value>
        public int FillTransparency
        {
            get { return transparency; }
            set
            {
                transparency = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        public drawMode DrawMode
        {
            get { return drawingMode; }
            set
            {
                drawingMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the type of the easing.
        /// </summary>
        /// <value>The type of the easing.</value>
        public PeaceAnimatorEasing EasingType
        {
            get { return easingType; }
            set
            {
                easingType = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the transparent easing.
        /// </summary>
        /// <value>The transparent easing.</value>
        public transparencyEasingType TransparentEasing
        {
            get { return transparencyEasingType; }
            set
            {
                transparencyEasingType = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic increment].
        /// </summary>
        /// <value><c>true</c> if [automatic increment]; otherwise, <c>false</c>.</value>
        public bool AutoIncrement
        {
            get { return autoIncrement; }
            set
            {
                autoIncrement = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The animation speed.</value>
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

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.AntiAlias;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
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


        /// <summary>
        /// Gets or sets the type of the progress.
        /// </summary>
        /// <value>The type of the progress.</value>
        public ProgressType ProgressType
        {
            get { return progressType; }
            set
            {
                progressType = value;
                
            }
        }

        //public CircularProgress CircularProgressType
        //{
        //    get { return circularProgressType; }
        //    set
        //    {
        //        circularProgressType = value;

        //    }
        //}


        /// <summary>
        /// Gets or sets the solid progress bar.
        /// </summary>
        /// <value>The solid progress bar.</value>
        public ProgressBar SolidProgressBar
        {
            get { return solidBars; }
            set
            {
                solidBars = value;
                
            }
        }


        //public ProgressIndicator ProgressIndicatorType
        //{
        //    get { return indicatorType; }
        //    set
        //    {
        //        indicatorType = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the post fix.
        /// </summary>
        /// <value>The post fix.</value>
        public string PostFix
        {
            get { return postFix; }
            set
            {
                postFix = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the starting angle.
        /// </summary>
        /// <value>The starting angle.</value>
        public float StartingAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
                
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [automatic animate].
        /// </summary>
        /// <value><c>true</c> if [automatic animate]; otherwise, <c>false</c>.</value>
        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;
                
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [animate start angle].
        /// </summary>
        /// <value><c>true</c> if [animate start angle]; otherwise, <c>false</c>.</value>
        public bool AnimateStartAngle
        {
            get { return autoAnimateStatingAngle; }
            set
            {
                autoAnimateStatingAngle = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the anim start angle.
        /// </summary>
        /// <value>The anim start angle.</value>
        public float AnimStartAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
                
            }
        }

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
                
            }
        }



        #endregion

        #region Bars
        /// <summary>
        /// Gets the bartype.
        /// </summary>
        /// <value>The bartype.</value>
        public ProgressType Bartype
        {
            get { return barType; }
        }

        /// <summary>
        /// Gets the extended bar.
        /// </summary>
        /// <value>The extended bar.</value>
        public ProgressBar ExtendedBar
        {
            get { return extendedBar; }
        }

        /// <summary>
        /// Gets the indicator bar.
        /// </summary>
        /// <value>The indicator bar.</value>
        public ProgressBar IndicatorBar
        {
            get { return indicatorBar; }
        }

        /// <summary>
        /// Gets the i tunes bar.
        /// </summary>
        /// <value>The i tunes bar.</value>
        public ProgressBar ITunesBar
        {
            get { return iTunesBar; }
        }

        /// <summary>
        /// Gets the maze bar.
        /// </summary>
        /// <value>The maze bar.</value>
        public ProgressBar MazeBar
        {
            get { return mazeBar; }
        }

        /// <summary>
        /// Gets the antonio normal bar.
        /// </summary>
        /// <value>The antonio normal bar.</value>
        public ProgressBar AntonioNormalBar
        {
            get { return antonioNormalBar; }
        }

        /// <summary>
        /// Gets the alter bar.
        /// </summary>
        /// <value>The alter bar.</value>
        public ProgressBar AlterBar
        {
            get { return alterBar; }
        }

        /// <summary>
        /// Gets the clear bar.
        /// </summary>
        /// <value>The clear bar.</value>
        public ProgressBar ClearBar
        {
            get { return clearBar; }
        }

        /// <summary>
        /// Gets the perplex bar.
        /// </summary>
        /// <value>The perplex bar.</value>
        public ProgressBar PerplexBar
        {
            get { return perplexBar; }
        }

        /// <summary>
        /// Gets the rect bar.
        /// </summary>
        /// <value>The rect bar.</value>
        public ProgressBar RectBar
        {
            get { return rectBar; }
        }

        /// <summary>
        /// Gets the transparent bar.
        /// </summary>
        /// <value>The transparent bar.</value>
        public ProgressBar TransparentBar
        {
            get { return transparentBar; }
        }

        /// <summary>
        /// Gets the splitter bar.
        /// </summary>
        /// <value>The splitter bar.</value>
        public ProgressBar SplitterBar
        {
            get { return splitterBar; }
        }




        #endregion

        #region Circular

        /// <summary>
        /// Gets the type of the circular.
        /// </summary>
        /// <value>The type of the circular.</value>
        public ProgressType CircularType
        {
            get { return circularType; }
        }

        /// <summary>
        /// Gets the circular progress bar.
        /// </summary>
        /// <value>The circular progress bar.</value>
        public CircularProgress CircularProgressBar
        {
            get { return circularProgressBar; }
        }

        /// <summary>
        /// Gets the circular progress bar default.
        /// </summary>
        /// <value>The circular progress bar default.</value>
        public CircularProgress CircularProgressBarDefault
        {
            get { return circularProgressBarDefault; }
        }

        /// <summary>
        /// Gets the circular progress v2.
        /// </summary>
        /// <value>The circular progress v2.</value>
        public CircularProgress CircularProgressV2
        {
            get { return circularProgressV2; }
        }

        /// <summary>
        /// Gets the circular progress v3.
        /// </summary>
        /// <value>The circular progress v3.</value>
        public CircularProgress CircularProgressV3
        {
            get { return circularProgressV3; }
        }

        /// <summary>
        /// Gets the circular progress v4.
        /// </summary>
        /// <value>The circular progress v4.</value>
        public CircularProgress CircularProgressV4
        {
            get { return circularProgressV4; }
        }

        /// <summary>
        /// Gets the circular progress v5.
        /// </summary>
        /// <value>The circular progress v5.</value>
        public CircularProgress CircularProgress_V5
        {
            get { return circularProgressV5; }
        }

        /// <summary>
        /// Gets the circular gorgeous.
        /// </summary>
        /// <value>The circular gorgeous.</value>
        public CircularProgress CircularGorgeous
        {
            get { return circularGorgeous; }
        }

        /// <summary>
        /// Gets the circular ignito.
        /// </summary>
        /// <value>The circular ignito.</value>
        public CircularProgress CircularIgnito
        {
            get { return circularIgnito; }
        }

        /// <summary>
        /// Gets the circular awesome.
        /// </summary>
        /// <value>The circular awesome.</value>
        public CircularProgress CircularAwesome
        {
            get { return circularAwesome; }
        }

        /// <summary>
        /// Gets the circular perfect.
        /// </summary>
        /// <value>The circular perfect.</value>
        public CircularProgress CircularPerfect
        {
            get { return circularPerfect; }
        }

        /// <summary>
        /// Gets the circular progress pie.
        /// </summary>
        /// <value>The circular progress pie.</value>
        public CircularProgress CircularProgressPie
        {
            get { return circularProgressPie; }
        }

        /// <summary>
        /// Gets the circular arc.
        /// </summary>
        /// <value>The circular arc.</value>
        public CircularProgress CircularArc
        {
            get { return circularArc; }
        }

        /// <summary>
        /// Gets the circular compass.
        /// </summary>
        /// <value>The circular compass.</value>
        public CircularProgress CircularCompass
        {
            get { return circularCompass; }
        }

        /// <summary>
        /// Gets the circular supreme.
        /// </summary>
        /// <value>The circular supreme.</value>
        public CircularProgress CircularSupreme
        {
            get { return circularSupreme; }
        }

        /// <summary>
        /// Gets the circular multi co.
        /// </summary>
        /// <value>The circular multi co.</value>
        public CircularProgress CircularMultiCo
        {
            get { return circularMultiCo; }
        }

        /// <summary>
        /// Gets the circular multi co ext.
        /// </summary>
        /// <value>The circular multi co ext.</value>
        public CircularProgress CircularMultiCoExt
        {
            get { return circularMultiCoExt; }
        }

        /// <summary>
        /// Gets the circular multi co ext v1.
        /// </summary>
        /// <value>The circular multi co ext v1.</value>
        public CircularProgress CircularMultiCoExtV1
        {
            get { return circularMultiCoExtV1; }
        }



        #endregion

        #region Indicator

        /// <summary>
        /// Gets the type of the indic prog.
        /// </summary>
        /// <value>The type of the indic prog.</value>
        public ProgressType IndicProgType
        {
            get { return indicProgType; }
        }

        /// <summary>
        /// Gets the indeterminate ind.
        /// </summary>
        /// <value>The indeterminate ind.</value>
        public ProgressIndicator IndeterminateInd
        {
            get { return indeterminate_Ind; }
        }

        /// <summary>
        /// Gets the google ind.
        /// </summary>
        /// <value>The google ind.</value>
        public ProgressIndicator GoogleInd
        {
            get { return google_Ind; }
        }

        /// <summary>
        /// Gets the mac os x ind.
        /// </summary>
        /// <value>The mac os x ind.</value>
        public ProgressIndicator MacOsXInd
        {
            get { return macOsX_Ind; }
        }

        /// <summary>
        /// Gets the mac os x opt ind.
        /// </summary>
        /// <value>The mac os x opt ind.</value>
        public ProgressIndicator MacOsXOptInd
        {
            get { return macOsXOpt_Ind; }
        }

        /// <summary>
        /// Gets the matrix ind.
        /// </summary>
        /// <value>The matrix ind.</value>
        public ProgressIndicator MatrixInd
        {
            get { return matrix_Ind; }
        }

        /// <summary>
        /// Gets the indicator v1 ind.
        /// </summary>
        /// <value>The indicator v1 ind.</value>
        public ProgressIndicator IndicatorV1Ind
        {
            get { return indicatorV1_Ind; }
        }

        /// <summary>
        /// Gets the unique ind.
        /// </summary>
        /// <value>The unique ind.</value>
        public ProgressIndicator UniqueInd
        {
            get { return unique_Ind; }
        }

        /// <summary>
        /// Gets the vuvuzela ind.
        /// </summary>
        /// <value>The vuvuzela ind.</value>
        public ProgressIndicator VuvuzelaInd
        {
            get { return vuvuzela_Ind; }
        }

        /// <summary>
        /// Gets the spinner circ ind.
        /// </summary>
        /// <value>The spinner circ ind.</value>
        public ProgressIndicator SpinnerCircInd
        {
            get { return spinnerCirc_Ind; }
        }

        /// <summary>
        /// Gets the spinner divided ind.
        /// </summary>
        /// <value>The spinner divided ind.</value>
        public ProgressIndicator SpinnerDividedInd
        {
            get { return spinnerDivided_Ind; }
        }

        /// <summary>
        /// Gets the win8 horiz ind.
        /// </summary>
        /// <value>The win8 horiz ind.</value>
        public ProgressIndicator Win8HorizInd
        {
            get { return win8Horiz_Ind; }
        }

        /// <summary>
        /// Gets the win8 ring ind.
        /// </summary>
        /// <value>The win8 ring ind.</value>
        public ProgressIndicator Win8RingInd
        {
            get { return win8Ring_Ind; }
        }

        #endregion

        #endregion

        #region Additions

        //public ProgressType progType = ProgressThematic.ProgressType.Bar;
        //[RefreshProperties(RefreshProperties.Repaint)]
        //public ProgressType ProgType
        //{
        //    get { return progType; }
        //    set
        //    {
        //        progType = value;


        //    }
        //}

        //public CircularProgress cirCType = CircularProgress.CircularProgressv2;

        //[RefreshProperties(RefreshProperties.Repaint)]
        //public CircularProgress CircType
        //{
        //    get { return cirCType; }
        //    set
        //    {
        //        cirCType = value;

        //    }
        //}

        //public ProgressBar progbar = ProgressBar.RPExtendedProgress;

        //[RefreshProperties(RefreshProperties.Repaint)]
        //public ProgressBar ProgBar
        //{
        //    get { return progbar; }
        //    set
        //    {
        //        progbar = value;

        //    }
        //}

        //public ProgressIndicator progIndicate = ProgressIndicator.CircularIndeterminate;

        //[RefreshProperties(RefreshProperties.Repaint)]
        //public ProgressIndicator ProgIndicate
        //{
        //    get { return progIndicate; }
        //    set
        //    {
        //        progIndicate = value;

        //    }
        //}


        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ProgressInput.</returns>
        public ProgressInput Clone()
        {
            return new ProgressInput(
                //progressType,
                //circularProgressType,
                solidBars,
                //indicatorType,
                smoothing,
                textrendering,
                easingType,
                transparencyEasingType,
                hatchBrushType,
                autoAnimate,
                autoIncrement,
                autoAnimateStatingAngle,
                showText,
                fixedSize,
                postFix,
                hatchBrushgradient1,
                hatchBrushgradient2,
                minimum,
                maximum,
                speed[2],
                speed[0],
                speed[1],
                startingAngle
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>ProgressInput.</returns>
        public static ProgressInput Empty()
        {
            return new ProgressInput();
        }


        #endregion

        
        #region Serialization

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressInput"/> class.
        /// </summary>
        /// <param name="info">The information.</param>
        /// <param name="context">The context.</param>
        public ProgressInput(SerializationInfo info, StreamingContext context)
        {
            solidBars = (ProgressBar)info.GetValue("solidBars", typeof(ProgressBar));
            fixedSize = info.GetBoolean("fixedSize");
            allowTransparency = info.GetBoolean("allowTransparency");
            autoIncrement = info.GetBoolean("autoIncrement");
            transparencyAnimatorGlow = info.GetBoolean("transparencyAnimatorGlow");
            showText = info.GetBoolean("showText");
            startingAngle = (float)info.GetValue("startingAngle", typeof(float));
            value = (float)info.GetValue("value", typeof(float));
            maximum = (float)info.GetValue("maximum", typeof(float));
            minimum = (float)info.GetValue("minimum", typeof(float));
            speed = (int[])info.GetValue("speed", typeof(int[]));
            transparency = info.GetInt32("transparency");
            drawingMode = (drawMode)info.GetValue("drawingMode", typeof(drawMode));
            easingType = (PeaceAnimatorEasing)info.GetValue("easingType", typeof(PeaceAnimatorEasing));
            transparencyEasingType = (transparencyEasingType)info.GetValue("transparencyEasingType", typeof(transparencyEasingType));
            postFix = info.GetString("postFix");
            hatchBrushgradient1 = (Color)info.GetValue("hatchBrushgradient1", typeof(Color));
            hatchBrushgradient2 = (Color)info.GetValue("hatchBrushgradient2", typeof(Color));
            hatchBrushType = (ZeroitThematicProgress.HatchBrushType)info.GetValue("hatchBrushType", typeof(ZeroitThematicProgress.HatchBrushType));
            autoAnimate = info.GetBoolean("autoAnimate");
            autoAnimateStatingAngle = info.GetBoolean("autoAnimateStatingAngle");

            //#region ProgressPerfect


            //ProgressPerfect_interval = info.GetInt32("ProgressPerfect_interval");
            //ProgressPerfect_circleColor = (Color)info.GetValue("ProgressPerfect_circleColor", typeof(Color));
            //ProgressPerfect_circleSize = (float)info.GetValue("ProgressPerfect_circleSize", typeof(float));
            //_numberOfCircles = (float)info.GetValue("_numberOfCircles", typeof(float));
            //_numberOfVisibleCircles = info.GetInt32("_numberOfVisibleCircles");
            //ProgressPerfect_rotation = (RotationType1)info.GetValue("ProgressPerfect_rotation", typeof(RotationType1));
            //ProgressPerfect_percentage = (float)info.GetValue("ProgressPerfect_percentage", typeof(float));
            //ProgressPerfect_showPercentage = info.GetBoolean("ProgressPerfect_showPercentage");
            //ProgressBarPerfect_showText = info.GetBoolean("ProgressBarPerfect_showText");
            //ProgressPerfect_textDisplay = (TextDisplayModes1)info.GetValue("ProgressPerfect_textDisplay", typeof(TextDisplayModes1));
            //ProgressBarPerfect_customText = (string)info.GetValue("ProgressBarPerfect_customText", typeof(string));

            //#endregion

        }

        /// <summary>
        /// Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
        /// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("solidBars", solidBars);
            info.AddValue("fixedSize", fixedSize);
            info.AddValue("allowTransparency", allowTransparency);
            info.AddValue("autoIncrement", autoIncrement);
            info.AddValue("transparencyAnimatorGlow", transparencyAnimatorGlow);
            info.AddValue("showText", showText);
            info.AddValue("startingAngle", startingAngle);
            info.AddValue("value", value);
            info.AddValue("maximum", maximum);
            info.AddValue("minimum", minimum);
            info.AddValue("speed", speed);
            info.AddValue("transparency", transparency);
            info.AddValue("drawingMode", drawingMode);
            info.AddValue("easingType", easingType);
            info.AddValue("transparencyEasingType", transparencyEasingType);
            info.AddValue("postFix", postFix);

            info.AddValue("hatchBrushgradient1", hatchBrushgradient1);
            info.AddValue("hatchBrushgradient2", hatchBrushgradient2);
            info.AddValue("hatchBrushType", hatchBrushType);
            info.AddValue("autoAnimate", autoAnimate);
            info.AddValue("autoAnimateStatingAngle", autoAnimateStatingAngle);



            #region ProgressPerfect


            info.AddValue("ProgressPerfect_interval", ProgressPerfect_interval);
            info.AddValue("ProgressPerfect_circleColor", ProgressPerfect_circleColor);
            info.AddValue("ProgressPerfect_circleSize", ProgressPerfect_circleSize);
            info.AddValue("_numberOfCircles", _numberOfCircles);
            info.AddValue("_numberOfVisibleCircles", _numberOfVisibleCircles);
            info.AddValue("ProgressPerfect_rotation", ProgressPerfect_rotation);
            info.AddValue("ProgressPerfect_percentage", ProgressPerfect_percentage);
            info.AddValue("ProgressPerfect_showPercentage", ProgressPerfect_showPercentage);
            info.AddValue("ProgressBarPerfect_showText", ProgressBarPerfect_showText);
            info.AddValue("ProgressPerfect_textDisplay", ProgressPerfect_textDisplay);
            info.AddValue("ProgressBarPerfect_customText", ProgressBarPerfect_customText);

            #endregion

        }

        #endregion


    }
}
