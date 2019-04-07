using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {


        #region Static Members
        private static readonly Color PreBarBaseDark = Color.FromArgb(199, 200, 201);
        private static readonly Color PreBarBaseLight = Color.WhiteSmoke;
        private static readonly Color PreBarLight = Color.FromArgb(102, 144, 252);
        private static readonly Color PreBarDark = Color.FromArgb(40, 68, 202);
        private static readonly Color PreBorderColor = Color.DarkGray;
        #endregion

        #region Private Members
        /// <summary>
        /// The Light background color
        /// </summary>
        private Color clrBarBgLight = PreBarBaseLight;

        /// <summary>
        /// The Dark background color
        /// </summary>
        private Color clrBarBgDark = PreBarBaseDark;

        /// <summary>
        /// The Light bar color
        /// </summary>
        private Color clrBarLight = PreBarLight;

        /// <summary>
        /// The Dark bar color
        /// </summary>
        private Color clrBarDark = PreBarDark;

        /// <summary>
        /// The Border color for the control
        /// </summary>
        private Color clrBorderColor = PreBorderColor;

        /// <summary>
        /// The border width
        /// </summary>
        private float fBorderWidth = 1.25F;

        /// <summary>
        /// This is the % value that describs the amount of transparency 
        /// through the background that we will show.
        /// </summary>
        private float fMirrorOpacity = 40.0F;

        
        /// <summary>
        /// The number of dividers to draw in the bar
        /// </summary>
        private int iNumDividers = 10;

        /// <summary>
        /// The stepsize to use when the control is a progressbar
        /// </summary>
        private float iStepSize = 0;

        /// <summary>
        /// A member to control the way the bar behaves
        /// </summary>
        private BarType eBarType = BarType.Static;

        /// <summary>
        /// A value to save the new target procent when we are in Animation mode
        /// </summary>
        private float fNewProcent = 0.0F;

        /// <summary>
        /// A simple flag to indicate what way the control should animate it's progress when it's in Animation mode
        /// </summary>
        private bool bAnimUp = false;

        
        private int iTunesInterval = 100;
        #endregion

        #region Public Properties

        public float StepSize
        {
            get { return iStepSize; }
            set
            {
                iStepSize = value;
                
            }
        }
        
        public int StepInterval
        {
            get { return iTunesInterval; }
            set
            {
                iTunesInterval = value;
                
            }
        }
        
        public int BarDividersCount
        {
            get { return iNumDividers; }
            set { iNumDividers = value;  }
        }
        
        public float BarMirrorOpacity
        {
            get { return fMirrorOpacity; }
            set { fMirrorOpacity = value;  }
        }
        
        public float BarBorderWidth
        {
            get { return fBorderWidth; }
            set { fBorderWidth = value;  }
        }

        public Color BarBackgroundLight
        {
            get { return clrBarBgLight; }
            set { clrBarBgLight = value;  }
        }
        
        public Color BarBackgroundDark
        {
            get { return clrBarBgDark; }
            set { clrBarBgDark = value;  }
        }
        
        public Color BarLight
        {
            get { return clrBarLight; }
            set { clrBarLight = value;  }
        }
        
        public Color BarDark
        {
            get { return clrBarDark; }
            set { clrBarDark = value;  }
        }
        
        public Color BarBorderColor
        {
            get { return clrBorderColor; }
            set { clrBorderColor = value;  }
        }
        
        public BarType BarType
        {
            get { return eBarType; }
            set
            {
                eBarType = value;
                
            }
        }


        #endregion


    }
}
