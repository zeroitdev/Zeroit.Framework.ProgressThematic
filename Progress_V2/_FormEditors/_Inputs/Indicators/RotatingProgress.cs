// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingProgress.cs" company="Zeroit Dev Technologies">
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
        /// The vuvuzela angle
        /// </summary>
        private float Vuvuzela_angle = 90f;
        /// <summary>
        /// The vuvuzela interval
        /// </summary>
        private int Vuvuzela_interval = 10;
        /// <summary>
        /// The vuvuzela rotating border
        /// </summary>
        private bool Vuvuzela_rotatingBorder = false;
        /// <summary>
        /// The vuvuzela shape
        /// </summary>
        private Vuvuzela_Shape Vuvuzela_shape = Vuvuzela_Shape.Arc;
        /// <summary>
        /// The vuvuzela size
        /// </summary>
        private int Vuvuzela_size = 20;
        /// <summary>
        /// The vuvuzela fill pie
        /// </summary>
        private bool Vuvuzela_fillPie = false;
        /// <summary>
        /// The vuvuzela rotating circle
        /// </summary>
        private Color Vuvuzela_rotatingCircle = Color.Red;
        /// <summary>
        /// The vuvuzela circle1
        /// </summary>
        private Color Vuvuzela_circle1 = Color.Black;
        /// <summary>
        /// The vuvuzela circle2
        /// </summary>
        private Color Vuvuzela_circle2 = Color.Green;
        /// <summary>
        /// The vuvuzela circle3
        /// </summary>
        private Color Vuvuzela_circle3 = Color.Brown;
        /// <summary>
        /// The vuvuzela circle4
        /// </summary>
        private Color Vuvuzela_circle4 = Color.Green;
        /// <summary>
        /// The vuvuzela circle5
        /// </summary>
        private Color Vuvuzela_circle5 = Color.Blue;
        /// <summary>
        /// The vuvuzela circle size
        /// </summary>
        private int Vuvuzela_circleSize = 1;

        /// <summary>
        /// The vuvuzela vertical spacing
        /// </summary>
        private int Vuvuzela_verticalSpacing = 0;
        /// <summary>
        /// The vuvuzela horizontal spacing
        /// </summary>
        private int Vuvuzela_horizontalSpacing = 0;

        //Graphics g;
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the vuvuzela vertical spacing.
        /// </summary>
        /// <value>The vuvuzela vertical spacing.</value>
        public int Vuvuzela_VerticalSpacing
        {
            get { return Vuvuzela_verticalSpacing; }
            set { Vuvuzela_verticalSpacing = value; }
        }

        /// <summary>
        /// Gets or sets the vuvuzela horizontal spacing.
        /// </summary>
        /// <value>The vuvuzela horizontal spacing.</value>
        public int Vuvuzela_HorizontalSpacing
        {
            get { return Vuvuzela_horizontalSpacing; }
            set { Vuvuzela_horizontalSpacing = value; }
        }

        /// <summary>
        /// Gets or sets the size of the vuvuzela circle.
        /// </summary>
        /// <value>The size of the vuvuzela circle.</value>
        public int Vuvuzela_CircleSize
        {
            get { return Vuvuzela_circleSize; }
            set
            {
                Vuvuzela_circleSize = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle1.
        /// </summary>
        /// <value>The vuvuzela circle1.</value>
        public Color Vuvuzela_Circle1
        {
            get { return Vuvuzela_circle1; }
            set
            {
                Vuvuzela_circle1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle2.
        /// </summary>
        /// <value>The vuvuzela circle2.</value>
        public Color Vuvuzela_Circle2
        {
            get { return Vuvuzela_circle2; }
            set
            {
                Vuvuzela_circle2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle3.
        /// </summary>
        /// <value>The vuvuzela circle3.</value>
        public Color Vuvuzela_Circle3
        {
            get { return Vuvuzela_circle3; }
            set
            {
                Vuvuzela_circle3 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle4.
        /// </summary>
        /// <value>The vuvuzela circle4.</value>
        public Color Vuvuzela_Circle4
        {
            get { return Vuvuzela_circle4; }
            set
            {
                Vuvuzela_circle4 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle5.
        /// </summary>
        /// <value>The vuvuzela circle5.</value>
        public Color Vuvuzela_Circle5
        {
            get { return Vuvuzela_circle5; }
            set
            {
                Vuvuzela_circle5 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela rotating circle.
        /// </summary>
        /// <value>The vuvuzela rotating circle.</value>
        public Color Vuvuzela_RotatingCircle
        {
            get { return Vuvuzela_rotatingCircle; }
            set
            {
                Vuvuzela_rotatingCircle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [vuvuzela fill pie].
        /// </summary>
        /// <value><c>true</c> if [vuvuzela fill pie]; otherwise, <c>false</c>.</value>
        public bool Vuvuzela_FillPie
        {
            get { return Vuvuzela_fillPie; }
            set
            {
                Vuvuzela_fillPie = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the control.
        /// </summary>
        /// <value>The size of the control.</value>
        public int ControlSize
        {
            get { return Vuvuzela_size; }
            set
            {
                Vuvuzela_size = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the shape.
        /// </summary>
        /// <value>The shape.</value>
        public Vuvuzela_Shape Shape
        {
            get { return Vuvuzela_shape; }
            set
            {
                Vuvuzela_shape = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [vuvuzela rotating border].
        /// </summary>
        /// <value><c>true</c> if [vuvuzela rotating border]; otherwise, <c>false</c>.</value>
        public bool Vuvuzela_RotatingBorder
        {
            get { return Vuvuzela_rotatingBorder; }
            set
            {
                Vuvuzela_rotatingBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela angle.
        /// </summary>
        /// <value>The vuvuzela angle.</value>
        public float Vuvuzela_Angle
        {
            get { return Vuvuzela_angle; }
            set
            {
                Vuvuzela_angle = value;
                //
            }
        }


        #endregion
    }
}
