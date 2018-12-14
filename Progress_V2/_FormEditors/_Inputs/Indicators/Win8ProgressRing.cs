// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8ProgressRing.cs" company="Zeroit Dev Technologies">
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
