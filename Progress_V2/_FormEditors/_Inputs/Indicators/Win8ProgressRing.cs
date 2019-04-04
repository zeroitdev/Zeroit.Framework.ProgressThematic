// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8ProgressRing.cs" company="Zeroit Dev Technologies">
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

        #region Private Field

        /// <summary>
        /// The win ring control height
        /// </summary>
        int WinRing_control_height = 100;
        /// <summary>
        /// The win ring indicator color
        /// </summary>
        Color WinRing_indicator_color = Color.White;
        /// <summary>
        /// The win ring refresh rate
        /// </summary>
        int WinRing_refresh_rate = (int)100.0;
        /// <summary>
        /// The win ring animate
        /// </summary>
        bool winRing_Animate = false;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [win ring animate].
        /// </summary>
        /// <value><c>true</c> if [win ring animate]; otherwise, <c>false</c>.</value>
        public bool WinRing_Animate
        {

            get
            {
                return winRing_Animate;
            }

            set
            {
                winRing_Animate = value;
            }
        }


        /// <summary>
        /// Gets or sets the height of the control.
        /// </summary>
        /// <value>The height of the control.</value>
        public int Control_Height
        {

            get
            {
                return (WinRing_control_height);
            }
            set
            {
                
                WinRing_control_height = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the win ring indicator.
        /// </summary>
        /// <value>The color of the win ring indicator.</value>
        public Color WinRing_Indicator_Color
        {

            get
            {
                return (WinRing_indicator_color);
            }
            set
            {
                
                WinRing_indicator_color = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the win ring refresh rate.
        /// </summary>
        /// <value>The win ring refresh rate.</value>
        public int WinRing_Refresh_Rate
        {

            get
            {
                return (WinRing_refresh_rate);
            }

            set
            {
                
                WinRing_refresh_rate = value;
                
            }
        }
        #endregion


    }
}
