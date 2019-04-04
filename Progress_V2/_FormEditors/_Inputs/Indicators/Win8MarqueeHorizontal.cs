// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8MarqueeHorizontal.cs" company="Zeroit Dev Technologies">
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
        /// The control width
        /// </summary>
        int control_width = 462;
        /// <summary>
        /// The win hr indicator color
        /// </summary>
        Color WinHR_indicator_color = Color.White;
        /// <summary>
        /// The win hr refresh rate
        /// </summary>
        int WinHR_refresh_rate = 100;
        /// <summary>
        /// The timer interval
        /// </summary>
        double timer_interval = 100;
        /// <summary>
        /// The win hr animate
        /// </summary>
        bool winHR_Animate = false;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [win hr animate].
        /// </summary>
        /// <value><c>true</c> if [win hr animate]; otherwise, <c>false</c>.</value>
        public bool WinHR_Animate
        {

            get
            {
                return (winHR_Animate);
            }

            set
            {
                winHR_Animate = value;
            }
        }


        /// <summary>
        /// Gets or sets the width of the control.
        /// </summary>
        /// <value>The width of the control.</value>
        public int Control_Width
        {

            get
            {
                return (control_width);
            }
            set
            {

                control_width = value;


            }
        }


        /// <summary>
        /// Gets or sets the color of the indicator.
        /// </summary>
        /// <value>The color of the indicator.</value>
        public Color Indicator_Color
        {

            get
            {
                return (WinHR_indicator_color);
            }
            set
            {

                WinHR_indicator_color = value;

            }
        }


        /// <summary>
        /// Gets or sets the refresh rate.
        /// </summary>
        /// <value>The refresh rate.</value>
        public int Refresh_Rate
        {

            get
            {
                return (WinHR_refresh_rate);
            }

            set
            {
                WinHR_refresh_rate = value;

            }
        } 

        #endregion

    }
}
