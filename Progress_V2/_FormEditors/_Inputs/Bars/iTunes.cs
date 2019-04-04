// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="iTunes.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {


        #region Static Members
        /// <summary>
        /// The pre bar base dark
        /// </summary>
        private static readonly Color PreBarBaseDark = Color.FromArgb(199, 200, 201);
        /// <summary>
        /// The pre bar base light
        /// </summary>
        private static readonly Color PreBarBaseLight = Color.WhiteSmoke;
        /// <summary>
        /// The pre bar light
        /// </summary>
        private static readonly Color PreBarLight = Color.FromArgb(102, 144, 252);
        /// <summary>
        /// The pre bar dark
        /// </summary>
        private static readonly Color PreBarDark = Color.FromArgb(40, 68, 202);
        /// <summary>
        /// The pre border color
        /// </summary>
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


        /// <summary>
        /// The i tunes interval
        /// </summary>
        private int iTunesInterval = 100;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the size of the step.
        /// </summary>
        /// <value>The size of the step.</value>
        public float StepSize
        {
            get { return iStepSize; }
            set
            {
                iStepSize = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the step interval.
        /// </summary>
        /// <value>The step interval.</value>
        public int StepInterval
        {
            get { return iTunesInterval; }
            set
            {
                iTunesInterval = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the bar dividers count.
        /// </summary>
        /// <value>The bar dividers count.</value>
        public int BarDividersCount
        {
            get { return iNumDividers; }
            set { iNumDividers = value;  }
        }

        /// <summary>
        /// Gets or sets the bar mirror opacity.
        /// </summary>
        /// <value>The bar mirror opacity.</value>
        public float BarMirrorOpacity
        {
            get { return fMirrorOpacity; }
            set { fMirrorOpacity = value;  }
        }

        /// <summary>
        /// Gets or sets the width of the bar border.
        /// </summary>
        /// <value>The width of the bar border.</value>
        public float BarBorderWidth
        {
            get { return fBorderWidth; }
            set { fBorderWidth = value;  }
        }

        /// <summary>
        /// Gets or sets the bar background light.
        /// </summary>
        /// <value>The bar background light.</value>
        public Color BarBackgroundLight
        {
            get { return clrBarBgLight; }
            set { clrBarBgLight = value;  }
        }

        /// <summary>
        /// Gets or sets the bar background dark.
        /// </summary>
        /// <value>The bar background dark.</value>
        public Color BarBackgroundDark
        {
            get { return clrBarBgDark; }
            set { clrBarBgDark = value;  }
        }

        /// <summary>
        /// Gets or sets the bar light.
        /// </summary>
        /// <value>The bar light.</value>
        public Color BarLight
        {
            get { return clrBarLight; }
            set { clrBarLight = value;  }
        }

        /// <summary>
        /// Gets or sets the bar dark.
        /// </summary>
        /// <value>The bar dark.</value>
        public Color BarDark
        {
            get { return clrBarDark; }
            set { clrBarDark = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the bar border.
        /// </summary>
        /// <value>The color of the bar border.</value>
        public Color BarBorderColor
        {
            get { return clrBorderColor; }
            set { clrBorderColor = value;  }
        }

        /// <summary>
        /// Gets or sets the type of the bar.
        /// </summary>
        /// <value>The type of the bar.</value>
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
