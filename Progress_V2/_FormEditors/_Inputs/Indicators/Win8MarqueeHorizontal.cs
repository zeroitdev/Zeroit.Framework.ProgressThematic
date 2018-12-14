// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8MarqueeHorizontal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
