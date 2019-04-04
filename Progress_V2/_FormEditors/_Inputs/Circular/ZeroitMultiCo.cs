// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCo.cs" company="Zeroit Dev Technologies">
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

        /// <summary>
        /// The mc show inner border
        /// </summary>
        private bool MC_showInnerBorder = true;
        /// <summary>
        /// The mc inner border
        /// </summary>
        private int MC_innerBorder = 2;
        /// <summary>
        /// The mc shift width
        /// </summary>
        private int MC_shift_Width = 15;
        /// <summary>
        /// The mc correct shift width
        /// </summary>
        private int MC_correctShift_Width = 6;
        /// <summary>
        /// The mc rect shift width
        /// </summary>
        private int MC_rectShift_Width = 3;
        /// <summary>
        /// The mc no of rings
        /// </summary>
        private Rings MC_noOfRings = Rings.One;
        /// <summary>
        /// The mc colors
        /// </summary>
        Color[] MC_colors = new Color[]
        {
            Color.Red,
            Color.Yellow,
            Color.Green,
            Color.AliceBlue,
            Color.Brown,
            Color.Chocolate,
            Color.DarkOrange,
            Color.DarkRed,
            Color.DeepPink,
            Color.Indigo,
            Color.Ivory,
            Color.Lavender,
            Color.LightSeaGreen,
            Color.Maroon,
            Color.OrangeRed,
            Color.Orchid,
            Color.PaleGoldenrod,
            Color.PapayaWhip,
            Color.Teal,
            Color.Tomato,
            Color.YellowGreen,
            Color.Thistle,
            Color.Tan,
            Color.SlateGray,
        };


        /// <summary>
        /// The mc shift height
        /// </summary>
        private int MC_shift_Height = 15;
        /// <summary>
        /// The mc correct shift height
        /// </summary>
        private int MC_correctShift_Height = 6;
        /// <summary>
        /// The mc rect shift height
        /// </summary>
        private int MC_rectShift_Height = 3;
        /// <summary>
        /// The mc position horizontal
        /// </summary>
        private int MC_position_horizontal = 0;
        /// <summary>
        /// The mc position vertical
        /// </summary>
        private int MC_position_vertical = 0;
        /// <summary>
        /// The mc innerborder color
        /// </summary>
        private Color MC_innerborderColor = Color.Black;
        /// <summary>
        /// The mc inner color
        /// </summary>
        private Color MC_innerColor = Color.Blue;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the mc inner.
        /// </summary>
        /// <value>The color of the mc inner.</value>
        public Color MC_InnerColor
        {
            get { return MC_innerColor; }
            set
            {
                MC_innerColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the mc inner border.
        /// </summary>
        /// <value>The color of the mc inner border.</value>
        public Color MC_InnerBorderColor
        {
            get { return MC_innerborderColor; }
            set
            {
                MC_innerborderColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc position horizontal.
        /// </summary>
        /// <value>The mc position horizontal.</value>
        public int MC_Position_Horizontal
        {
            get { return MC_position_horizontal; }
            set
            {
                MC_position_horizontal = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc position vertical.
        /// </summary>
        /// <value>The mc position vertical.</value>
        public int MC_Position_Vertical
        {
            get { return MC_position_vertical; }
            set
            {
                MC_position_vertical = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the mc correct shift.
        /// </summary>
        /// <value>The height of the mc correct shift.</value>
        public int MC_CorrectShift_Height
        {
            get { return MC_correctShift_Height; }
            set
            {
                MC_correctShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc shift.
        /// </summary>
        /// <value>The height of the mc shift.</value>
        public int MC_Shift_Height
        {
            get { return MC_shift_Height; }
            set
            {
                MC_shift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc rect shift.
        /// </summary>
        /// <value>The height of the mc rect shift.</value>
        public int MC_RectShift_Height
        {
            get { return MC_rectShift_Height; }
            set
            {
                MC_rectShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the mc colors.
        /// </summary>
        /// <value>The mc colors.</value>
        public Color[] MC_Colors
        {
            get { return MC_colors; }
            set
            {
                MC_colors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc no of rings.
        /// </summary>
        /// <value>The mc no of rings.</value>
        public Rings MC_NoOfRings
        {
            get { return MC_noOfRings; }
            set
            {
                MC_noOfRings = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc show inner border].
        /// </summary>
        /// <value><c>true</c> if [mc show inner border]; otherwise, <c>false</c>.</value>
        public bool MC_ShowInnerBorder
        {
            get { return MC_showInnerBorder; }
            set
            {
                MC_showInnerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc inner border.
        /// </summary>
        /// <value>The mc inner border.</value>
        public int MC_InnerBorder
        {
            get { return MC_innerBorder; }
            set
            {
                MC_innerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc correct shift.
        /// </summary>
        /// <value>The mc correct shift.</value>
        public int MC_CorrectShift
        {
            get { return MC_correctShift_Width; }
            set
            {
                MC_correctShift_Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc shift.
        /// </summary>
        /// <value>The mc shift.</value>
        public int MC_Shift
        {
            get { return MC_shift_Width; }
            set
            {
                MC_shift_Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc rect shift.
        /// </summary>
        /// <value>The mc rect shift.</value>
        public int MC_RectShift
        {
            get { return MC_rectShift_Width; }
            set
            {
                MC_rectShift_Width = value;
                
            }
        }

        
        #endregion


    }
}
