// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerplex.cs" company="Zeroit Dev Technologies">
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
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Private Fields

        /// <summary>
        /// The perplex color gradient1
        /// </summary>
        private Color Perplex_colorGradient1 = Color.FromArgb(26, 26, 26);
        /// <summary>
        /// The perplex color gradient2
        /// </summary>
        private Color Perplex_colorGradient2 = Color.FromArgb(30, 30, 30);
        /// <summary>
        /// The perplex color gradient3
        /// </summary>
        private Color Perplex_colorGradient3 = Color.FromArgb(174, 195, 30);
        /// <summary>
        /// The perplex color gradient4
        /// </summary>
        private Color Perplex_colorGradient4 = Color.FromArgb(141, 153, 16);
        /// <summary>
        /// The color pen
        /// </summary>
        private Color colorPen = Color.FromArgb(97, 94, 90);
        /// <summary>
        /// The color gradient angle
        /// </summary>
        private float colorGradientAngle = 90f;
        /// <summary>
        /// The show percentage
        /// </summary>
        private bool _ShowPercentage = false;
        /// <summary>
        /// The perplex draw mode
        /// </summary>
        private perplex_DrawMode _perplex_DrawMode = perplex_DrawMode.Gradient;


        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the perplex draw mode.
        /// </summary>
        /// <value>The perplex draw mode.</value>
        public perplex_DrawMode Perplex_DrawMode
        {
            get { return _perplex_DrawMode; }
            set
            {
                _perplex_DrawMode = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the perplex color gradient1.
        /// </summary>
        /// <value>The perplex color gradient1.</value>
        public Color Perplex_ColorGradient1
        {
            get { return Perplex_colorGradient1; }
            set
            {
                Perplex_colorGradient1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the perplex color gradient2.
        /// </summary>
        /// <value>The perplex color gradient2.</value>
        public Color Perplex_ColorGradient2
        {
            get { return Perplex_colorGradient2; }
            set
            {
                Perplex_colorGradient2 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the perplex color gradient3.
        /// </summary>
        /// <value>The perplex color gradient3.</value>
        public Color Perplex_ColorGradient3
        {
            get { return Perplex_colorGradient3; }
            set
            {
                Perplex_colorGradient3 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the perplex color gradient4.
        /// </summary>
        /// <value>The perplex color gradient4.</value>
        public Color Perplex_ColorGradient4
        {
            get { return Perplex_colorGradient4; }
            set
            {
                Perplex_colorGradient4 = value;
                
            }
        }

        //public Color ColorHatchBrush1
        //{
        //    get { return hatchBrushgradient1; }
        //    set
        //    {
        //        hatchBrushgradient1 = value;
        //        
        //    }
        //}

        //public Color ColorHatchBrush2
        //{
        //    get { return hatchBrushgradient2; }
        //    set
        //    {
        //        hatchBrushgradient2 = value;
        //        
        //    }
        //}


        /// <summary>
        /// Gets or sets the color of the perplex border.
        /// </summary>
        /// <value>The color of the perplex border.</value>
        public Color Perplex_BorderColor
        {
            get { return colorPen; }
            set
            {
                colorPen = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color gradient angle.
        /// </summary>
        /// <value>The color gradient angle.</value>
        public float ColorGradientAngle
        {
            get { return colorGradientAngle; }
            set
            {
                colorGradientAngle = value;
                
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [perplex show percentage].
        /// </summary>
        /// <value><c>true</c> if [perplex show percentage]; otherwise, <c>false</c>.</value>
        public bool Perplex_ShowPercentage
        {
            get { return _ShowPercentage; }
            set
            {
                _ShowPercentage = value;
                
            }
        }

        #endregion

    }
}
