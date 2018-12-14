// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAwesome.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;
//using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {


        #region Zeroit Additions

        /// <summary>
        /// The progress awesome marquee animation speed
        /// </summary>
        float ProgressAwesome_marqueeAnimationSpeed = 2000;
        /// <summary>
        /// The progress awesome superscript text
        /// </summary>
        string ProgressAwesome_superscriptText = "°C";
        /// <summary>
        /// The progress awesome secondary font
        /// </summary>
        Font ProgressAwesome_secondaryFont = new Font("Segoe UI", (float)12, FontStyle.Regular);
        /// <summary>
        /// The progress awesome subscript text
        /// </summary>
        string ProgressAwesome_subscriptText = ".23";
        /// <summary>
        /// The progress awesome superscript color
        /// </summary>
        Color ProgressAwesome_superscriptColor = Color.FromArgb(166, 166, 166);
        /// <summary>
        /// The progress awesome subscript color
        /// </summary>
        Color ProgressAwesome_subscriptColor = Color.FromArgb(166, 166, 166);
        /// <summary>
        /// The progress awesome start angle
        /// </summary>
        int ProgressAwesome_startAngle = 270;
        /// <summary>
        /// The progress awesome subscript margin
        /// </summary>
        Padding ProgressAwesome_subscriptMargin = new Padding(10, -35, 0, 0);
        /// <summary>
        /// The progress awesome superscript margin
        /// </summary>
        Padding ProgressAwesome_superscriptMargin = new Padding(10, 35, 0, 0);
        /// <summary>
        /// The progress awesome text margin
        /// </summary>
        Padding ProgressAwesome_textMargin = new Padding(8, 8, 0, 0);
        /// <summary>
        /// The progress awesome animation speed
        /// </summary>
        private int ProgressAwesome_animationSpeed = 500;
        /// <summary>
        /// The progress awesome outer margin
        /// </summary>
        private int ProgressAwesome_outerMargin = -25;
        /// <summary>
        /// The progress awesome outer width
        /// </summary>
        private int ProgressAwesome_outerWidth = 26;
        /// <summary>
        /// The progress awesome outer color
        /// </summary>
        private Color ProgressAwesome_outerColor = Color.Gray;
        /// <summary>
        /// The progress awesome progress width
        /// </summary>
        private int ProgressAwesome_progressWidth = 5;
        /// <summary>
        /// The progress awesome progress color
        /// </summary>
        private Color ProgressAwesome_progressColor = Color.Teal;
        /// <summary>
        /// The progress awesome inner margin
        /// </summary>
        private int ProgressAwesome_innerMargin = 2;
        /// <summary>
        /// The progress awesome inner width
        /// </summary>
        private int ProgressAwesome_innerWidth = -1;
        /// <summary>
        /// The progress awesome inner color
        /// </summary>
        private Color ProgressAwesome_innerColor = Color.FromArgb(224, 224, 224);
        /// <summary>
        /// The progress awesome style
        /// </summary>
        private ProgressBarStyle ProgressAwesome_style = System.Windows.Forms.ProgressBarStyle.Blocks;
        //private AnimationFunctions.Function ProgressAwesome_animationFunction;
        //private KnownAnimationFunctions ProgressAwesome_knownAnimationFunction = KnownAnimationFunctions.Liner;

        #endregion

        #region Constructor

        /// <summary>
        /// Progresses the awesome.
        /// </summary>
        public void ProgressAwesome()
        {
            
        }

        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the progress bar awesome style.
        /// </summary>
        /// <value>The progress bar awesome style.</value>

        public ProgressBarStyle ProgressBarAwesomeStyle
        {
            get { return ProgressAwesome_style; }
            set
            {
                ProgressAwesome_style = value;

            }
        }


        /// <summary>
        /// Gets or sets the subscript text.
        /// </summary>
        /// <value>The subscript text.</value>

        public string SubscriptText
        {
            get { return ProgressAwesome_subscriptText; }
            set
            {
                ProgressAwesome_subscriptText = value;
            }
        }

        /// <summary>
        /// Gets or sets the secondary font.
        /// </summary>
        /// <value>The secondary font.</value>

        public Font SecondaryFont
        {
            get { return ProgressAwesome_secondaryFont; }
            set
            {
                ProgressAwesome_secondaryFont = value;

            }
        }

        /// <summary>
        /// Gets or sets the superscript text.
        /// </summary>
        /// <value>The superscript text.</value>

        public string SuperscriptText
        {
            get { return ProgressAwesome_superscriptText; }
            set
            {
                ProgressAwesome_superscriptText = value;
            }
        }


        /// <summary>
        /// Gets or sets the text margin.
        /// </summary>
        /// <value>The text margin.</value>

        public Padding TextMargin
        {
            get { return ProgressAwesome_textMargin; }
            set
            {
                ProgressAwesome_textMargin = value;
            }
        }

        /// <summary>
        /// Gets or sets the superscript margin.
        /// </summary>
        /// <value>The superscript margin.</value>

        public Padding SuperscriptMargin
        {
            get { return ProgressAwesome_superscriptMargin; }
            set
            {
                ProgressAwesome_superscriptMargin = value;
            }
        }


        /// <summary>
        /// Gets or sets the subscript margin.
        /// </summary>
        /// <value>The subscript margin.</value>

        public Padding SubscriptMargin
        {
            get { return ProgressAwesome_subscriptMargin; }
            set
            {
                ProgressAwesome_subscriptMargin = value;
            }
        }


        /// <summary>
        /// Gets or sets the progress awesome marquee animation speed.
        /// </summary>
        /// <value>The progress awesome marquee animation speed.</value>



        public float ProgressAwesome_MarqueeAnimationSpeed
        {
            get { return ProgressAwesome_marqueeAnimationSpeed; }
            set
            {
                ProgressAwesome_marqueeAnimationSpeed = value;
            }
        }


        /// <summary>
        /// Gets or sets the animation speed in milliseconds.
        /// </summary>
        /// <value>The progress awesome animation speed.</value>

        public int ProgressAwesome_AnimationSpeed
        {
            get { return ProgressAwesome_animationSpeed; }
            set
            {
                ProgressAwesome_animationSpeed = value;
            }
        }


        /// <summary>
        /// Gets or sets the start angle.
        /// </summary>
        /// <value>The start angle.</value>

        public int StartAngle
        {
            get { return ProgressAwesome_startAngle; }
            set
            {
                ProgressAwesome_startAngle = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the progress awesome progress.
        /// </summary>
        /// <value>The width of the progress awesome progress.</value>

        public int ProgressAwesome_ProgressWidth
        {
            get { return ProgressAwesome_progressWidth; }
            set
            {
                ProgressAwesome_progressWidth = value;
            }
        }

        //public KnownAnimationFunctions AnimationFunction
        //{
        //    //get { return ProgressAwesome_knownAnimationFunction; }
        //    //set
        //    //{
        //    //    ProgressAwesome_knownAnimationFunction = value;
        //    //}

        //    get { return ProgressAwesome_knownAnimationFunction; }
        //    set
        //    {
        //        ProgressAwesome_animationFunction = AnimationFunctions.FromKnown(value);
        //        ProgressAwesome_knownAnimationFunction = value;
        //    }
        //}

        //public AnimationFunctions.Function CustomAnimationFunction
        //{
        //    //get { return ProgressAwesome_animationFunction; }
        //    //set
        //    //{
        //    //    AnimationFunction = KnownAnimationFunctions.None;
        //    //    ProgressAwesome_animationFunction = value;
        //    //}

        //    get { return ProgressAwesome_animationFunction; }
        //    set
        //    {
        //        if (value == null)
        //            throw new ArgumentNullException(nameof(value));
        //        ProgressAwesome_knownAnimationFunction = KnownAnimationFunctions.None;
        //        ProgressAwesome_animationFunction = value;
        //    }

        //}

        /// <summary>
        /// Gets or sets the inner margin.
        /// </summary>
        /// <value>The inner margin.</value>

        public int InnerMargin
        {
            get { return ProgressAwesome_innerMargin; }
            set
            {
                ProgressAwesome_innerMargin = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the inner.
        /// </summary>
        /// <value>The width of the inner.</value>

        public int InnerWidth
        {
            get { return ProgressAwesome_innerWidth; }
            set
            {
                ProgressAwesome_innerWidth = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the outer margin.
        /// </summary>
        /// <value>The outer margin.</value>

        public int OuterMargin
        {
            get { return ProgressAwesome_outerMargin; }
            set
            {
                ProgressAwesome_outerMargin = value;

            }
        }

        /// <summary>
        /// Gets or sets the width of the outer.
        /// </summary>
        /// <value>The width of the outer.</value>

        public int OuterWidth
        {
            get { return ProgressAwesome_outerWidth; }
            set
            {
                ProgressAwesome_outerWidth = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the outer.
        /// </summary>
        /// <value>The color of the outer.</value>

        public Color OuterColor
        {
            get { return ProgressAwesome_outerColor; }
            set
            {
                ProgressAwesome_outerColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the inner.
        /// </summary>
        /// <value>The color of the inner.</value>
        public Color InnerColor
        {
            get { return ProgressAwesome_innerColor; }
            set
            {
                ProgressAwesome_innerColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the superscript.
        /// </summary>
        /// <value>The color of the superscript.</value>
        public Color SuperscriptColor
        {
            get { return ProgressAwesome_superscriptColor; }
            set
            {
                ProgressAwesome_superscriptColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the subscript.
        /// </summary>
        /// <value>The color of the subscript.</value>

        public Color SubscriptColor
        {
            get { return ProgressAwesome_subscriptColor; }
            set { ProgressAwesome_subscriptColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the progress.
        /// </summary>
        /// <value>The color of the progress.</value>

        public Color ProgressColor
        {
            get { return ProgressAwesome_progressColor; }
            set
            {
                ProgressAwesome_progressColor = value;
            }
        }




        #endregion

    }
}
