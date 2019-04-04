// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarRect.cs" company="Zeroit Dev Technologies">
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

        #region Private Fields
        //private float ProgressRect_percent;
        /// <summary>
        /// The progress rect value colour
        /// </summary>
        private Color ProgressRect_valueColour = Color.FromArgb(42, 119, 220);
        /// <summary>
        /// The progress rect color background
        /// </summary>
        private Color ProgressRect_colorBackground = Color.FromArgb(51, 52, 55);
        /// <summary>
        /// The progress rect color border
        /// </summary>
        private Color ProgressRect_colorBorder = Color.FromArgb(51, 52, 55);
        /// <summary>
        /// The progress rect corner
        /// </summary>
        private int ProgressRect_corner = 8;

        /// <summary>
        /// The interpolate colors
        /// </summary>
        private Color[] interpolateColors = new Color[]
        {
            Color.Black,
            Color.Black
        };
        #endregion

        #region  Custom Properties


        /// <summary>
        /// Gets or sets the progress rect corner.
        /// </summary>
        /// <value>The progress rect corner.</value>
        public int ProgressRect_Corner
        {
            get { return ProgressRect_corner; }
            set
            {
                ProgressRect_corner = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress rect value colour.
        /// </summary>
        /// <value>The progress rect value colour.</value>
        public Color ProgressRect_ValueColour
        {
            get
            {
                return ProgressRect_valueColour;
            }
            set
            {
                ProgressRect_valueColour = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress rect color background.
        /// </summary>
        /// <value>The progress rect color background.</value>
        public Color ProgressRect_ColorBackground
        {
            get { return ProgressRect_colorBackground; }
            set
            {
                ProgressRect_colorBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress rect color border.
        /// </summary>
        /// <value>The progress rect color border.</value>
        public Color ProgressRect_ColorBorder
        {
            get { return ProgressRect_colorBorder; }
            set
            {
                ProgressRect_colorBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the interpolate colors.
        /// </summary>
        /// <value>The interpolate colors.</value>
        public Color[] InterpolateColors
        {
            get { return interpolateColors; }
            set { interpolateColors = value;  }
        }

        #endregion


    }
}
