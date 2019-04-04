// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressSmooth.cs" company="Zeroit Dev Technologies">
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
        /// The dag smooth un filled color
        /// </summary>
        private Color DagSmooth_unFilledColor = Color.FromArgb(114, 114, 114);

        /// <summary>
        /// The dag smooth filled color
        /// </summary>
        private Color DagSmooth_filledColor = Color.FromArgb(60, 220, 210);

        /// <summary>
        /// The dag smooth inner color
        /// </summary>
        private Color DagSmooth_innerColor = Color.Orange;

        /// <summary>
        /// The dag smooth innerfilled alpha
        /// </summary>
        private int DagSmooth_innerfilledAlpha = 200;

        /// <summary>
        /// The dag smooth innerfilled thickness
        /// </summary>
        private int DagSmooth_innerfilledThickness = 30;

        /// <summary>
        /// The dag smooth filled color alpha
        /// </summary>
        private int DagSmooth_filledColorAlpha = 130;

        /// <summary>
        /// The dag smooth unfilled thickness
        /// </summary>
        private int DagSmooth_unfilledThickness = 24;

        /// <summary>
        /// The dag smooth filled thickness
        /// </summary>
        private int DagSmooth_filledThickness = 40;

        /// <summary>
        /// The dag smooth animation speed
        /// </summary>
        public int DagSmooth_animationSpeed = 5;

        /// <summary>
        /// The dag smooth end point
        /// </summary>
        private int DagSmooth_endPoint = 360;

        /// <summary>
        /// The dag animend angle
        /// </summary>
        private bool DagAnimendAngle = false;

        /// <summary>
        /// The dag smooth is animated
        /// </summary>
        private bool DagSmooth_isAnimated = false;

        /// <summary>
        /// The dag rotate
        /// </summary>
        private bool Dag_Rotate = false;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth rotate].
        /// </summary>
        /// <value><c>true</c> if [dag smooth rotate]; otherwise, <c>false</c>.</value>
        public bool DagSmoothRotate
        {
            get { return Dag_Rotate; }
            set
            {
                Dag_Rotate = value;
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth end angle.
        /// </summary>
        /// <value>The dag smooth end angle.</value>
        public int DagSmoothEndAngle
        {
            get { return DagSmooth_endPoint; }
            set
            {
                DagSmooth_endPoint = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag smooth inner filled.
        /// </summary>
        /// <value>The color of the dag smooth inner filled.</value>
        public Color DagSmoothInnerFilledColor
        {
            get { return DagSmooth_innerColor; }
            set
            {
                DagSmooth_innerColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled thickness inner.
        /// </summary>
        /// <value>The dag smooth filled thickness inner.</value>
        public int DagSmoothFilledThicknessInner
        {
            get { return DagSmooth_innerfilledThickness; }
            set
            {
                DagSmooth_innerfilledThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled color alpha inner.
        /// </summary>
        /// <value>The dag smooth filled color alpha inner.</value>
        public int DagSmoothFilledColorAlphaInner
        {
            get { return DagSmooth_innerfilledAlpha; }
            set
            {
                
                DagSmooth_innerfilledAlpha = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth anim speed.
        /// </summary>
        /// <value>The dag smooth anim speed.</value>
        public int DagSmoothAnimSpeed
        {
            get
            {
                return this.DagSmooth_animationSpeed;
            }
            set
            {
                this.DagSmooth_animationSpeed = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag smooth filled.
        /// </summary>
        /// <value>The color of the dag smooth filled.</value>
        public Color DagSmoothFilledColor
        {
            get
            {
                return this.DagSmooth_filledColor;
            }
            set
            {
                this.DagSmooth_filledColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled color alpha.
        /// </summary>
        /// <value>The dag smooth filled color alpha.</value>
        public int DagSmoothFilledColorAlpha
        {
            get
            {
                return this.DagSmooth_filledColorAlpha;
            }
            set
            {
                this.DagSmooth_filledColorAlpha = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled thickness.
        /// </summary>
        /// <value>The dag smooth filled thickness.</value>
        public int DagSmoothFilledThickness
        {
            get
            {
                return this.DagSmooth_filledThickness;
            }
            set
            {
                this.DagSmooth_filledThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth is animated].
        /// </summary>
        /// <value><c>true</c> if [dag smooth is animated]; otherwise, <c>false</c>.</value>
        public bool DagSmoothIsAnimated
        {
            get
            {
                return this.DagSmooth_isAnimated;
            }
            set
            {
                this.DagSmooth_isAnimated = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth anim end angle].
        /// </summary>
        /// <value><c>true</c> if [dag smooth anim end angle]; otherwise, <c>false</c>.</value>
        public bool DagSmoothAnimEndAngle
        {
            get { return DagAnimendAngle; }
            set
            {
                DagAnimendAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag smooth un filled.
        /// </summary>
        /// <value>The color of the dag smooth un filled.</value>
        public Color DagSmoothUnFilledColor
        {
            get
            {
                return this.DagSmooth_unFilledColor;
            }
            set
            {
                this.DagSmooth_unFilledColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth unfilled thickness.
        /// </summary>
        /// <value>The dag smooth unfilled thickness.</value>
        public int DagSmoothUnfilledThickness
        {
            get
            {
                return this.DagSmooth_unfilledThickness;
            }
            set
            {
                this.DagSmooth_unfilledThickness = value;
                
            }
        }

        #endregion
        
    }
}
