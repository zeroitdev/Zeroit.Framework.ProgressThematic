// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarAlter.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region  Private Fields
        /// <summary>
        /// The color back
        /// </summary>
        private Color colorBack = Color.FromArgb(210, 210, 210);
        /// <summary>
        /// The color border
        /// </summary>
        private Color colorBorder = Color.FromArgb(150, 150, 150);
        /// <summary>
        /// The color text
        /// </summary>
        private Color colorText = Color.FromArgb(100, 100, 100);
        /// <summary>
        /// The color inside
        /// </summary>
        private Color colorInside = Color.FromArgb(200, 200, 200);
        /// <summary>
        /// The color ic
        /// </summary>
        private Color colorIC = Color.FromArgb(215, 215, 215);
        /// <summary>
        /// The color1
        /// </summary>
        private Color color1 = Color.FromArgb(220, 220, 220);
        /// <summary>
        /// The color2
        /// </summary>
        private Color color2 = Color.FromArgb(200, 200, 200);

        /// <summary>
        /// The color angle
        /// </summary>
        private float colorAngle = 90F;

        /// <summary>
        /// The show value
        /// </summary>
        private bool _ShowValue = false;

        /// <summary>
        /// The orientation
        /// </summary>
        private Orientation _Orientation = System.Windows.Forms.Orientation.Horizontal;

        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the progress alter color back.
        /// </summary>
        /// <value>The progress alter color back.</value>
        public Color ProgressAlter_ColorBack
        {
            get { return colorBack; }
            set
            {
                colorBack = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color border.
        /// </summary>
        /// <value>The progress alter color border.</value>
        public Color ProgressAlter_ColorBorder
        {
            get { return colorBorder; }
            set
            {
                colorBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color text.
        /// </summary>
        /// <value>The progress alter color text.</value>
        public Color ProgressAlter_ColorText
        {
            get { return colorText; }
            set
            {
                colorText = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color inside.
        /// </summary>
        /// <value>The progress alter color inside.</value>
        public Color ProgressAlter_ColorInside
        {
            get { return colorInside; }
            set
            {
                colorInside = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color ic.
        /// </summary>
        /// <value>The progress alter color ic.</value>
        public Color ProgressAlter_ColorIC
        {
            get { return colorIC; }
            set
            {
                colorIC = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color1.
        /// </summary>
        /// <value>The progress alter color1.</value>
        public Color ProgressAlter_Color1
        {
            get { return color1; }
            set
            {
                color1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color2.
        /// </summary>
        /// <value>The color2.</value>
        public Color Color2
        {
            get { return color2; }
            set
            {
                color2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color angle.
        /// </summary>
        /// <value>The progress alter color angle.</value>
        public float ProgressAlter_ColorAngle
        {
            get { return colorAngle; }
            set
            {
                colorAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress alter orientation.
        /// </summary>
        /// <value>The progress alter orientation.</value>
        public Orientation ProgressAlter_Orientation
        {
            get { return _Orientation; }
            set
            {
                _Orientation = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show value].
        /// </summary>
        /// <value><c>true</c> if [show value]; otherwise, <c>false</c>.</value>
        public bool ShowValue
        {
            get { return _ShowValue; }
            set
            {
                _ShowValue = value;
                
            }
        }

        #endregion

    }
}
