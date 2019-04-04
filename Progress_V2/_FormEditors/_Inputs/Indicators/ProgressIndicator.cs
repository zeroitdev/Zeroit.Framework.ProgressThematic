// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicator.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Variables

        /// <summary>
        /// The base color
        /// </summary>
        Color baseColor = Color.DarkGray;
        /// <summary>
        /// The animation color
        /// </summary>
        Color animationColor = Color.DimGray;
        /// <summary>
        /// The visible circles
        /// </summary>
        private float _visibleCircles = 45f;
        /// <summary>
        /// The radian
        /// </summary>
        private double _radian = 180f;
        /// <summary>
        /// The circle width
        /// </summary>
        private float _circleWidth = 15f;

        #endregion

        #region Custom Properties


        /// <summary>
        /// Gets or sets the prog indicator number of circles.
        /// </summary>
        /// <value>The prog indicator number of circles.</value>
        public float ProgIndicator_NumberOfCircles
        {
            get { return _visibleCircles; }
            set
            {
                _visibleCircles = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the width of the prog indicator circle.
        /// </summary>
        /// <value>The width of the prog indicator circle.</value>
        public float ProgIndicator_CircleWidth
        {
            get { return _circleWidth; }
            set
            {
                _circleWidth = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the prog indicator radian.
        /// </summary>
        /// <value>The prog indicator radian.</value>
        public Double ProgIndicator_Radian
        {
            get { return _radian; }
            set
            {
                _radian = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the p base.
        /// </summary>
        /// <value>The color of the p base.</value>
        public Color P_BaseColor
        {
            get
            {
                return baseColor;
            }
            set
            {
                baseColor = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the p animation.
        /// </summary>
        /// <value>The color of the p animation.</value>
        public Color P_AnimationColor
        {
            get
            {
                return animationColor;
            }
            set
            {
                animationColor = value;
                
            }
        }

        

        #endregion

    }
}
