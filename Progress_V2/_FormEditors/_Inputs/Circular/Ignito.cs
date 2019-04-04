// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Ignito.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

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
        /// The ignito outerborder
        /// </summary>
        private float Ignito_outerborder = 1;

        /// <summary>
        /// The ignito innerborder
        /// </summary>
        private float Ignito_innerborder = 1;

        /// <summary>
        /// The ignito colors
        /// </summary>
        Color[] Ignito_colors = new Color[]
        {
            Color.Orange,
            Color.FromArgb(152, 212, 204),
            Color.Gray,
            Color.Black,
            Color.DarkSlateGray,
            Color.LightGray,
            Color.DimGray,
            Color.Black,
            Color.Green,
            Color.LightGray,
            Color.Gray,
            Color.LightGray,
        };

        /// <summary>
        /// The grad
        /// </summary>
        private Color[] grad = new Color[]
        {
            Color.AliceBlue, Color.Azure, Color.GreenYellow, Color.Orange
        };

        /// <summary>
        /// The ignito enable hatch
        /// </summary>
        private bool Ignito_enableHatch = false;

        /// <summary>
        /// The ignito cap
        /// </summary>
        private LineCap Ignito_cap = LineCap.Round;

        /// <summary>
        /// The ignito inner rota angle
        /// </summary>
        private Ignito_innerRotatingAngle Ignito_innerRotaAngle = Ignito_innerRotatingAngle.AntiClockwise;

        /// <summary>
        /// The ignito outter rota angle
        /// </summary>
        private Ignito_outterRotatingAngle Ignito_outterRotaAngle = Ignito_outterRotatingAngle.Clockwise;

        /// <summary>
        /// The ignito draw mode
        /// </summary>
        private Ignito_drawMode ignito_drawMode = Ignito_drawMode.Solid;

        /// <summary>
        /// The ignito border styleouter
        /// </summary>
        private DashStyle Ignito_borderStyleouter = DashStyle.DashDot;

        /// <summary>
        /// The ignito border style inner
        /// </summary>
        private DashStyle Ignito_borderStyleInner = DashStyle.DashDot;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the ig inner rotating anlge.
        /// </summary>
        /// <value>The ig inner rotating anlge.</value>
        public Ignito_innerRotatingAngle IG_InnerRotatingAnlge
        {
            get { return Ignito_innerRotaAngle; }
            set
            {
                Ignito_innerRotaAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the ig outter rotating angle.
        /// </summary>
        /// <value>The ig outter rotating angle.</value>
        public Ignito_outterRotatingAngle IG_OutterRotatingAngle
        {
            get { return Ignito_outterRotaAngle; }
            set
            {
                Ignito_outterRotaAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the ig caps.
        /// </summary>
        /// <value>The ig caps.</value>
        public LineCap IG_Caps
        {
            get { return Ignito_cap; }
            set
            {
                Ignito_cap = value;

            }
        }

        /// <summary>
        /// Gets or sets the ig border style outer.
        /// </summary>
        /// <value>The ig border style outer.</value>
        public DashStyle IG_BorderStyleOuter
        {
            get { return Ignito_borderStyleouter; }
            set
            {
                Ignito_borderStyleouter = value;

            }
        }

        /// <summary>
        /// Gets or sets the ig border style inner.
        /// </summary>
        /// <value>The ig border style inner.</value>
        public DashStyle IG_BorderStyleInner
        {
            get { return Ignito_borderStyleInner; }
            set
            {
                Ignito_borderStyleInner = value;

            }
        }

        /// <summary>
        /// Gets or sets the ig draw mode.
        /// </summary>
        /// <value>The ig draw mode.</value>
        public Ignito_drawMode IG_DrawMode
        {
            get { return ignito_drawMode; }
            set
            {
                ignito_drawMode = value;

            }
        }

        /// <summary>
        /// Gets or sets the ig outer border.
        /// </summary>
        /// <value>The ig outer border.</value>
        public float IG_OuterBorder
        {
            get { return Ignito_outerborder; }
            set
            {
                Ignito_outerborder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the ig inner border.
        /// </summary>
        /// <value>The ig inner border.</value>
        public float IG_InnerBorder
        {
            get { return Ignito_innerborder; }
            set
            {
                Ignito_innerborder = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the ig gradient colors.
        /// </summary>
        /// <value>The ig gradient colors.</value>
        public Color[] IG_GradientColors
        {
            get { return grad; }
            set
            {
                grad = value;
            }
        }

        /// <summary>
        /// Gets or sets the ig colors.
        /// </summary>
        /// <value>The ig colors.</value>
        public Color[] IG_Colors
        {
            get { return Ignito_colors; }
            set
            {
                Ignito_colors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [ig enable hatch].
        /// </summary>
        /// <value><c>true</c> if [ig enable hatch]; otherwise, <c>false</c>.</value>
        public bool IG_EnableHatch
        {
            get { return Ignito_enableHatch; }
            set
            {
                Ignito_enableHatch = value;
                
            }
        }

        
        
        
        #endregion

    }
}
