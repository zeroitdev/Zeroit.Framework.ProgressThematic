// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended.cs" company="Zeroit Dev Technologies">
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
        /// The mc ex show inner border
        /// </summary>
        private bool MCEx_showInnerBorder = true;
        /// <summary>
        /// The mc ex inner border
        /// </summary>
        private int MCEx_innerBorder = 2;
        /// <summary>
        /// The mc ex shift
        /// </summary>
        private int MCEx_shift = 15;
        /// <summary>
        /// The mc ex correct shift
        /// </summary>
        private int MCEx_correctShift = 6;
        /// <summary>
        /// The mc ex rect shift
        /// </summary>
        private int MCEx_rectShift = 3;
        /// <summary>
        /// The mc ex no of rings
        /// </summary>
        private Rings MCEx_noOfRings = Rings.One;
        /// <summary>
        /// The mc ex inner border color
        /// </summary>
        private Color MCEx_innerBorderColor = Color.Gray;
        /// <summary>
        /// The mc ex colors
        /// </summary>
        Color[] MCEx_colors = new Color[]
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
        /// The mc exshift height
        /// </summary>
        private int MCExshift_Height = 15;
        /// <summary>
        /// The mc excorrect shift height
        /// </summary>
        private int MCExcorrectShift_Height = 6;
        /// <summary>
        /// The mc exrect shift height
        /// </summary>
        private int MCExrectShift_Height = 3;
        /// <summary>
        /// The mc exposition horizontal
        /// </summary>
        private int MCExposition_horizontal = 0;
        /// <summary>
        /// The mc exposition vertical
        /// </summary>
        private int MCExposition_vertical = 0;
        /// <summary>
        /// The mc exinnerborder color
        /// </summary>
        private Color MCExinnerborderColor = Color.Black;
        /// <summary>
        /// The mc exinner color
        /// </summary>
        private Color MCExinnerColor = Color.Blue;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the mc ex inner.
        /// </summary>
        /// <value>The color of the mc ex inner.</value>
        public Color MCEx_InnerColor
        {
            get { return MCExinnerColor; }
            set
            {
                MCExinnerColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc ex position horizontal.
        /// </summary>
        /// <value>The mc ex position horizontal.</value>
        public int MCEx_Position_Horizontal
        {
            get { return MCExposition_horizontal; }
            set
            {
                MCExposition_horizontal = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc ex position vertical.
        /// </summary>
        /// <value>The mc ex position vertical.</value>
        public int MCEx_Position_Vertical
        {
            get { return MCExposition_vertical; }
            set
            {
                MCExposition_vertical = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex correct shift.
        /// </summary>
        /// <value>The height of the mc ex correct shift.</value>
        public int MCEx_CorrectShift_Height
        {
            get { return MCExcorrectShift_Height; }
            set
            {
                MCExcorrectShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex shift.
        /// </summary>
        /// <value>The height of the mc ex shift.</value>
        public int MCEx_Shift_Height
        {
            get { return MCExshift_Height; }
            set
            {
                MCExshift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex rect shift.
        /// </summary>
        /// <value>The height of the mc ex rect shift.</value>
        public int MCEx_RectShift_Height
        {
            get { return MCExrectShift_Height; }
            set
            {
                MCExrectShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the mc ex inner border.
        /// </summary>
        /// <value>The color of the mc ex inner border.</value>
        public Color MCEx_InnerBorderColor
        {
            get { return MCEx_innerBorderColor; }
            set
            {
                MCEx_innerBorderColor = value;
                
            }
        }

        //public float valConverted
        //{
        //    get
        //    {
        //        return value;
        //    }

        //    set
        //    {
        //        this.value = value;
        //        
        //    }
        //}

        //public int Speed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        speed = value;
        //        
        //    }
        //}

        /// <summary>
        /// Gets or sets the mc ex colors.
        /// </summary>
        /// <value>The mc ex colors.</value>
        public Color[] MCEx_Colors
        {
            get { return MCEx_colors; }
            set
            {
                MCEx_colors = value;
                
            }
        }

        //public enum Rings
        //{
        //    Default,
        //    One,
        //    Two,
        //    Four,
        //    Eight,
        //    Twelve,
        //    TwentyFour
        //}

        /// <summary>
        /// Gets or sets the mc ex no of rings.
        /// </summary>
        /// <value>The mc ex no of rings.</value>
        public Rings MCEx_NoOfRings
        {
            get { return MCEx_noOfRings; }
            set
            {
                MCEx_noOfRings = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc ex show inner border].
        /// </summary>
        /// <value><c>true</c> if [mc ex show inner border]; otherwise, <c>false</c>.</value>
        public bool MCEx_ShowInnerBorder
        {
            get { return MCEx_showInnerBorder; }
            set
            {
                MCEx_showInnerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex inner border.
        /// </summary>
        /// <value>The mc ex inner border.</value>
        public int MCEx_InnerBorder
        {
            get { return MCEx_innerBorder; }
            set
            {
                MCEx_innerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex inner shift.
        /// </summary>
        /// <value>The mc ex inner shift.</value>
        public int MCEx_InnerShift
        {
            get { return MCEx_rectShift; }
            set
            {
                MCEx_rectShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex correct shift.
        /// </summary>
        /// <value>The mc ex correct shift.</value>
        public int MCEx_CorrectShift
        {
            get { return MCEx_correctShift; }
            set
            {
                MCEx_correctShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex shift.
        /// </summary>
        /// <value>The mc ex shift.</value>
        public int MCEx_Shift
        {
            get { return MCEx_shift; }
            set
            {
                MCEx_shift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex rect shift.
        /// </summary>
        /// <value>The mc ex rect shift.</value>
        public int MCEx_RectShift
        {
            get { return MCEx_rectShift; }
            set
            {
                MCEx_rectShift = value;
                
            }
        }

        
        #endregion


    }
}
