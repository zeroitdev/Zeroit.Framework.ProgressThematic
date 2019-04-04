// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarTransparent.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
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
        /// The show text
        /// </summary>
        private Boolean _ShowText = true;
        /// <summary>
        /// The progress background
        /// </summary>
        private Color _ProgressBackground = Color.Blue;
        /// <summary>
        /// The TRNS progress color1
        /// </summary>
        private Color Trns_progressColor1 = Color.Red;
        /// <summary>
        /// The TRNS progress color2
        /// </summary>
        private Color Trns_progressColor2 = Color.Gray;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the trans show text.
        /// </summary>
        /// <value>The trans show text.</value>
        [Category("RectangularProgress Transparent")]
        public Boolean Trans_ShowText
        {
            get { return _ShowText; }
            set
            {
                _ShowText = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the trans background.
        /// </summary>
        /// <value>The trans background.</value>
        [Category("RectangularProgress Transparent")]
        public Color Trans_Background
        {
            get
            {
                return this._ProgressBackground;
            }

            set
            {
                this._ProgressBackground = value;
                
            }

        }

        /// <summary>
        /// Gets or sets the trans progress color1.
        /// </summary>
        /// <value>The trans progress color1.</value>
        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor1
        {
            get
            {
                return this.Trns_progressColor1;
            }

            set
            {
                this.Trns_progressColor1 = value;
                
            }

        }

        /// <summary>
        /// Gets or sets the trans progress color2.
        /// </summary>
        /// <value>The trans progress color2.</value>
        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor2
        {
            get
            {
                return this.Trns_progressColor2;
            }

            set
            {
                this.Trns_progressColor2 = value;
                
            }

        }



        #endregion

    }
}
