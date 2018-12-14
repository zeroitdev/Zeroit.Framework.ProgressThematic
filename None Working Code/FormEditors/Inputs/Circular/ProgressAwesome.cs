using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static Zeroit.Framework.ProgressThematic.ThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {


        #region Zeroit Additions

        float ProgressAwesome_marqueeAnimationSpeed = 2000;
        string ProgressAwesome_superscriptText = "°C";
        Font ProgressAwesome_secondaryFont = new Font("Segoe UI", (float)12, FontStyle.Regular);
        string ProgressAwesome_subscriptText = ".23";
        Color ProgressAwesome_superscriptColor = Color.FromArgb(166, 166, 166);
        Color ProgressAwesome_subscriptColor = Color.FromArgb(166, 166, 166);
        int ProgressAwesome_startAngle = 270;
        Padding ProgressAwesome_subscriptMargin = new Padding(10, -35, 0, 0);
        Padding ProgressAwesome_superscriptMargin = new Padding(10, 35, 0, 0);
        Padding ProgressAwesome_textMargin = new Padding(8, 8, 0, 0);
        private int ProgressAwesome_animationSpeed = 500;
        private int ProgressAwesome_outerMargin = -25;
        private int ProgressAwesome_outerWidth = 26;
        private Color ProgressAwesome_outerColor = Color.Gray;
        private int ProgressAwesome_progressWidth = 5;
        private Color ProgressAwesome_progressColor = Color.Teal;
        private int ProgressAwesome_innerMargin = 2;
        private int ProgressAwesome_innerWidth = -1;
        private Color ProgressAwesome_innerColor = Color.FromArgb(224, 224, 224);
        private ProgressBarStyle ProgressAwesome_style = System.Windows.Forms.ProgressBarStyle.Blocks;
        //private AnimationFunctions.Function ProgressAwesome_animationFunction;
        //private KnownAnimationFunctions ProgressAwesome_knownAnimationFunction = KnownAnimationFunctions.Liner;

        #endregion

        #region Constructor

        public void ProgressAwesome()
        {
            
        }

        #endregion
        
        #region Public Properties

        public float ProgressAwesome_MarqueeAnimationSpeed
        {
            get { return ProgressAwesome_marqueeAnimationSpeed; }
            set
            {
                ProgressAwesome_marqueeAnimationSpeed = value;
            }
        }

        /// <summary>
        /// </summary>

        public string SubscriptText
        {
            get { return ProgressAwesome_subscriptText; }
            set
            {
                ProgressAwesome_subscriptText = value;
            }
        }

        /// <summary>
        /// </summary>

        public Font SecondaryFont
        {
            get { return ProgressAwesome_secondaryFont; }
            set
            {
                ProgressAwesome_secondaryFont = value;

            }
        }

        /// <summary>
        /// </summary>

        public string SuperscriptText
        {
            get { return ProgressAwesome_superscriptText; }
            set
            {
                ProgressAwesome_superscriptText = value;
            }
        }

        /// <summary>
        ///     Gets or sets the animation speed in milliseconds.
        /// </summary>

        public int ProgressAwesome_AnimationSpeed
        {
            get { return ProgressAwesome_animationSpeed; }
            set
            {
                ProgressAwesome_animationSpeed = value;
            }
        }

        /// <summary>
        /// </summary>

        public Padding TextMargin
        {
            get { return ProgressAwesome_textMargin; }
            set
            {
                ProgressAwesome_textMargin = value;
            }
        }

        /// <summary>
        /// </summary>

        public Padding SuperscriptMargin
        {
            get { return ProgressAwesome_superscriptMargin; }
            set
            {
                ProgressAwesome_superscriptMargin = value;
            }
        }


        /// <summary>
        /// </summary>

        public Padding SubscriptMargin
        {
            get { return ProgressAwesome_subscriptMargin; }
            set
            {
                ProgressAwesome_subscriptMargin = value;
            }
        }

        /// <summary>
        /// </summary>
        /// 

        /// <summary>
        /// </summary>
        /// 

        public Color ProgressColor
        {
            get { return ProgressAwesome_progressColor; }
            set
            {
                ProgressAwesome_progressColor = value;
            }
        }

        /// <summary>
        /// </summary>

        public int StartAngle
        {
            get { return ProgressAwesome_startAngle; }
            set
            {
                ProgressAwesome_startAngle = value;
            }
        }

        /// <summary>
        /// </summary>
        /// 

        public int ProgressAwesome_ProgressWidth
        {
            get { return ProgressAwesome_progressWidth; }
            set
            {
                ProgressAwesome_progressWidth = value;
            }
        }

        

        /// <summary>
        /// </summary>

        public Color SubscriptColor
        {
            get { return ProgressAwesome_subscriptColor; }
            set { ProgressAwesome_subscriptColor = value; }
        }

        

        /// <summary>
        /// </summary>

        public Color SuperscriptColor
        {
            get { return ProgressAwesome_superscriptColor; }
            set
            {
                ProgressAwesome_superscriptColor = value;
            }
        }


        public ProgressBarStyle ProgressBarAwesomeStyle
        {
            get { return ProgressAwesome_style; }
            set
            {
                ProgressAwesome_style = value;
                
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

        
        public Color InnerColor
        {
            get { return ProgressAwesome_innerColor; }
            set
            {
                ProgressAwesome_innerColor = value;
                
            }
        }

        /// <summary>
        /// </summary>
        
        public int InnerMargin
        {
            get { return ProgressAwesome_innerMargin; }
            set
            {
                ProgressAwesome_innerMargin = value;
                
            }
        }

        /// <summary>
        /// </summary>
        
        public int InnerWidth
        {
            get { return ProgressAwesome_innerWidth; }
            set
            {
                ProgressAwesome_innerWidth = value;
                
            }
        }

        /// <summary>
        /// </summary>
        
        public Color OuterColor
        {
            get { return ProgressAwesome_outerColor; }
            set
            {
                ProgressAwesome_outerColor = value;
                
            }
        }

        /// <summary>
        /// </summary>
        
        public int OuterMargin
        {
            get { return ProgressAwesome_outerMargin; }
            set
            {
                ProgressAwesome_outerMargin = value;
                
            }
        }

        /// <summary>
        /// </summary>
        
        public int OuterWidth
        {
            get { return ProgressAwesome_outerWidth; }
            set
            {
                ProgressAwesome_outerWidth = value;
                
            }
        }

        


        #endregion

    }
}
