// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressBar.cs" company="Zeroit Dev Technologies">
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
        /// The dag un filled color
        /// </summary>
        private Color Dag_unFilledColor = Color.FromArgb(114, 114, 114);

        /// <summary>
        /// The dag filled color
        /// </summary>
        private Color Dag_filledColor = Color.FromArgb(60, 220, 210);

        /// <summary>
        /// The dag filled color alpha
        /// </summary>
        private int Dag_filledColorAlpha = 130;

        /// <summary>
        /// The dag unfilled thickness
        /// </summary>
        private int Dag_unfilledThickness = 24;

        /// <summary>
        /// The dag filled thickness
        /// </summary>
        private int Dag_filledThickness = 40;

        /// <summary>
        /// The dag animation speed
        /// </summary>
        public int Dag_animationSpeed = 5;

        /// <summary>
        /// The dag is animated
        /// </summary>
        public bool Dag_isAnimated = false;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the dag start angle.
        /// </summary>
        /// <value>The dag start angle.</value>
        public int DagStartAngle
        {
            get { return (int)StartingAngle; }
            set
            {
                StartingAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag anim speed.
        /// </summary>
        /// <value>The dag anim speed.</value>
        public int DagAnimSpeed
        {
            get
            {
                return this.Dag_animationSpeed;
            }
            set
            {
                this.Dag_animationSpeed = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the dag filled color alpha.
        /// </summary>
        /// <value>The dag filled color alpha.</value>
        public int DagFilledColorAlpha
        {
            get
            {
                return this.Dag_filledColorAlpha;
            }
            set
            {
                this.Dag_filledColorAlpha = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag filled thickness.
        /// </summary>
        /// <value>The dag filled thickness.</value>
        public int DagFilledThickness
        {
            get
            {
                return this.Dag_filledThickness;
            }
            set
            {
                this.Dag_filledThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag unfilled thickness.
        /// </summary>
        /// <value>The dag unfilled thickness.</value>
        public int DagUnfilledThickness
        {
            get
            {
                return this.Dag_unfilledThickness;
            }
            set
            {
                this.Dag_unfilledThickness = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag is animated].
        /// </summary>
        /// <value><c>true</c> if [dag is animated]; otherwise, <c>false</c>.</value>
        public bool DagIsAnimated
        {
            get
            {
                return this.Dag_isAnimated;
            }
            set
            {
                this.Dag_isAnimated = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag filled.
        /// </summary>
        /// <value>The color of the dag filled.</value>
        public Color DagFilledColor
        {
            get
            {
                return this.Dag_filledColor;
            }
            set
            {
                this.Dag_filledColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the dag un filled.
        /// </summary>
        /// <value>The color of the dag un filled.</value>
        public Color DagUnFilledColor
        {
            get
            {
                return this.Dag_unFilledColor;
            }
            set
            {
                this.Dag_unFilledColor = value;
                
            }
        }
        
        
        #endregion

    }
}
