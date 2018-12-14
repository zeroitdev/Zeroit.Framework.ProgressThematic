// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Gorgeous.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
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
        /// The gorgeous enable inner cover
        /// </summary>
        private bool Gorgeous_enableInnerCover = false;
        /// <summary>
        /// The gorgeous outer shift
        /// </summary>
        private int Gorgeous_outerShift = 16;
        /// <summary>
        /// The gorgeous inner shift
        /// </summary>
        private int Gorgeous_innerShift = 26;
        /// <summary>
        /// The gorgeous inner cover shift
        /// </summary>
        private int Gorgeous_innerCoverShift = 32;
        /// <summary>
        /// The gorgeous small rect shift
        /// </summary>
        private int Gorgeous_smallRectShift = 180;
        /// <summary>
        /// The gorgeous gradient colors
        /// </summary>
        private Color[] Gorgeous_gradientColors = new Color[]
        {
            Color.FromArgb(254, 84, 84),
            Color.DarkSlateGray
        };
        /// <summary>
        /// The gorgeous solidcolors
        /// </summary>
        private Color[] Gorgeous_solidcolors = new Color[]
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(37, 37, 38),
            Color.FromArgb(254, 84, 84),
            Color.FromArgb(37, 37, 38),
            Color.Gray
        };
        /// <summary>
        /// The gorgeous border
        /// </summary>
        private int Gorgeous_border = 10;
        /// <summary>
        /// The gorgeous show text
        /// </summary>
        private bool Gorgeous_showText = true;
        /// <summary>
        /// The rotating angle
        /// </summary>
        private Gorgeous_rotatingAngle _rotatingAngle = Gorgeous_rotatingAngle.Clockwise;
        /// <summary>
        /// The gorgeous draw mode
        /// </summary>
        private Gorgeous_drawMode gorgeous_DrawMode = Gorgeous_drawMode.Solid;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the gorgeous draw mode.
        /// </summary>
        /// <value>The gorgeous draw mode.</value>
        public Gorgeous_drawMode GorgeousDrawMode
        {
            get { return gorgeous_DrawMode; }
            set
            {
                gorgeous_DrawMode = value;

            }
        }

        /// <summary>
        /// Gets or sets the rotating angle.
        /// </summary>
        /// <value>The rotating angle.</value>
        public Gorgeous_rotatingAngle RotatingAngle
        {
            get { return _rotatingAngle; }
            set
            {
                _rotatingAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the solid colors.
        /// </summary>
        /// <value>The solid colors.</value>
        public Color[] SolidColors
        {
            get { return Gorgeous_solidcolors; }
            set
            {
                Gorgeous_solidcolors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the gradient.
        /// </summary>
        /// <value>The color of the gradient.</value>
        public Color[] GradientColor
        {
            get { return Gorgeous_gradientColors; }
            set
            {
                Gorgeous_gradientColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>The border.</value>
        public int Border
        {
            get { return Gorgeous_border; }
            set
            {
                Gorgeous_border = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the shift outer.
        /// </summary>
        /// <value>The shift outer.</value>
        public int ShiftOuter
        {
            get { return Gorgeous_outerShift; }
            set
            {
                Gorgeous_outerShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the shift inner.
        /// </summary>
        /// <value>The shift inner.</value>
        public int ShiftInner
        {
            get { return Gorgeous_innerShift; }
            set
            {
                Gorgeous_innerShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the shift inner cover.
        /// </summary>
        /// <value>The shift inner cover.</value>
        public int ShiftInnerCover
        {
            get { return Gorgeous_innerCoverShift; }
            set
            {
                Gorgeous_innerCoverShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the shift small rect.
        /// </summary>
        /// <value>The shift small rect.</value>
        public int ShiftSmallRect
        {
            get { return Gorgeous_smallRectShift; }
            set
            {
                Gorgeous_smallRectShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable inner cover].
        /// </summary>
        /// <value><c>true</c> if [enable inner cover]; otherwise, <c>false</c>.</value>
        public bool EnableInnerCover
        {
            get { return Gorgeous_enableInnerCover; }
            set
            {
                Gorgeous_enableInnerCover = value;

            }
        }


        #endregion
    }
}
