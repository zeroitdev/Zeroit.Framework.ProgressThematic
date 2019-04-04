// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingCompass.cs" company="Zeroit Dev Technologies">
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

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the rotating compass line width.
        /// </summary>
        /// <value>The color of the rotating compass line width.</value>
        public Color RotatingCompass_LineWidthColor
        {
            get { return lineWidthColor; }
            set
            {
                lineWidthColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the rotating compass pie color1.
        /// </summary>
        /// <value>The rotating compass pie color1.</value>
        public Color RotatingCompass_PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass pie color2.
        /// </summary>
        /// <value>The rotating compass pie color2.</value>
        public Color RotatingCompass_PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass line color1.
        /// </summary>
        /// <value>The rotating compass line color1.</value>
        public Color RotatingCompass_LineColor1
        {
            get { return lineColor1; }
            set
            {
                pieColor1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass line color2.
        /// </summary>
        /// <value>The rotating compass line color2.</value>
        public Color RotatingCompass_LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the rotating compass line.
        /// </summary>
        /// <value>The size of the rotating compass line.</value>
        public int RotatingCompass_LineSize
        {
            get { return size; }
            set
            {
                size = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass angle.
        /// </summary>
        /// <value>The rotating compass angle.</value>
        public float RotatingCompass_Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                //
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating compass rotating border].
        /// </summary>
        /// <value><c>true</c> if [rotating compass rotating border]; otherwise, <c>false</c>.</value>
        public bool RotatingCompass_RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating compass fill pie].
        /// </summary>
        /// <value><c>true</c> if [rotating compass fill pie]; otherwise, <c>false</c>.</value>
        public bool RotatingCompass_FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;

            }
        }

        #endregion

    }
}
