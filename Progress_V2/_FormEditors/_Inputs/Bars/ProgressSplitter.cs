// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressSplitter.cs" company="Zeroit Dev Technologies">
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
        /// The m progress bar block width
        /// </summary>
        private int m_ProgressBarBlockWidth = 6;
        /// <summary>
        /// The m progress bar block space
        /// </summary>
        private int m_ProgressBarBlockSpace = 1;
        /// <summary>
        /// The m progress bar percent
        /// </summary>
        private bool m_ProgressBarPercent = true;
        /// <summary>
        /// The m progress bar margin offset
        /// </summary>
        private bool m_ProgressBarMarginOffset = true;
        /// <summary>
        /// The m progress bar border style
        /// </summary>
        private TProgressBarBorderStyle m_ProgressBarBorderStyle = TProgressBarBorderStyle.Flat;
        /// <summary>
        /// The m progress bar fill brush color
        /// </summary>
        private Color m_ProgressBarFillBrush_Color = Color.Coral;

        /// <summary>
        /// The splitter border color
        /// </summary>
        private Color splitter_borderColor = Color.Black;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the splitter border.
        /// </summary>
        /// <value>The color of the splitter border.</value>
        public Color Splitter_BorderColor
        {
            get { return splitter_borderColor; }
            set { splitter_borderColor = value; }
        }
        /// <summary>
        /// Gets or sets the color of the splitter fill.
        /// </summary>
        /// <value>The color of the splitter fill.</value>
        public Color Splitter_FillColor
        {
            get
            {
                return m_ProgressBarFillBrush_Color;
            }

            set
            {
                m_ProgressBarFillBrush_Color = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the splitter block.
        /// </summary>
        /// <value>The width of the splitter block.</value>
        public int Splitter_BlockWidth
        {
            get { return m_ProgressBarBlockWidth; }
            set
            {
                m_ProgressBarBlockWidth = value;
            }
        }

        /// <summary>
        /// Gets or sets the splitter block space.
        /// </summary>
        /// <value>The splitter block space.</value>
        public int Splitter_BlockSpace
        {
            get { return m_ProgressBarBlockSpace; }
            set
            {
                m_ProgressBarBlockSpace = value;
            }
        }

        /// <summary>
        /// Gets or sets the splitter boder style.
        /// </summary>
        /// <value>The splitter boder style.</value>
        public TProgressBarBorderStyle Splitter_BoderStyle
        {
            get { return m_ProgressBarBorderStyle; }
            set
            {
                if (m_ProgressBarBorderStyle != value)
                {
                    m_ProgressBarBorderStyle = value;
                    
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [splitter percent].
        /// </summary>
        /// <value><c>true</c> if [splitter percent]; otherwise, <c>false</c>.</value>
        public bool Splitter_Percent
        {
            get { return m_ProgressBarPercent; }
            set
            {
                if (m_ProgressBarPercent != value)
                {
                    m_ProgressBarPercent = value;
                    
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [splitter margin offset].
        /// </summary>
        /// <value><c>true</c> if [splitter margin offset]; otherwise, <c>false</c>.</value>
        public bool Splitter_MarginOffset
        {
            get { return m_ProgressBarMarginOffset; }
            set
            {
                if (m_ProgressBarMarginOffset != value)
                {
                    m_ProgressBarMarginOffset = value;
                    
                }
            }
        }
        
        #endregion

    }
}
