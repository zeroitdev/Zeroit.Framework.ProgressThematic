// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularIndeterminate.cs" company="Zeroit Dev Technologies">
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
        /// The background color
        /// </summary>
        private Color background_color = SystemColors.Control;
        /// <summary>
        /// The circles count
        /// </summary>
        private int circles_count = 5;
        /// <summary>
        /// The control color
        /// </summary>
        private Color control_color = SystemColors.Control;
        /// <summary>
        /// The control width height
        /// </summary>
        private int control_width_height = 150;
        /// <summary>
        /// The indicator angle
        /// </summary>
        private float indicator_angle = 0.0F;
        /// <summary>
        /// The indicator angular advance
        /// </summary>
        private float indicator_angular_advance = 0.7F;
        /// <summary>
        /// The indicator color
        /// </summary>
        private Color indicator_color = Color.Black;
        /// <summary>
        /// The indicator diameter
        /// </summary>
        private int indicator_diameter = 8;
        /// <summary>
        /// The indicator type
        /// </summary>
        private INDICATORTYPES indicator_type = INDICATORTYPES.ANIMATED;
        /// <summary>
        /// The refresh rate
        /// </summary>
        private int refresh_rate = 100;
        /// <summary>
        /// The indeterminate animate
        /// </summary>
        private bool indeterminate_Animate = false;

        #endregion


        #region Public Properties
        // *************************************************** Animate

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressInput"/> is animate.
        /// </summary>
        /// <value><c>true</c> if animate; otherwise, <c>false</c>.</value>
        public bool Animate
        {

            get { return indeterminate_Animate; }
            set
            {
                indeterminate_Animate = value;
            }
        }

        // ******************************************* BackgroundColor

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>The color of the background.</value>
        public Color BackgroundColor
        {

            get
            {
                return (background_color);
            }

            set
            {
                background_color = value;

                
            }
        }

        // ********************************************** CirclesCount

        /// <summary>
        /// Gets or sets the circles count.
        /// </summary>
        /// <value>The circles count.</value>
        public int CirclesCount
        {
            get
            {
                return (circles_count);
            }
            set
            {
                circles_count = value;
                
            }
        }

        // **************************************** ControlWidthHeight

        /// <summary>
        /// Gets or sets the height of the control width.
        /// </summary>
        /// <value>The height of the control width.</value>
        public int ControlWidthHeight
        {

            get
            {
                return (control_width_height);
            }

            set
            {
                control_width_height = value;
                
            }
        }

        // ******************************************** IndicatorColor

        /// <summary>
        /// Gets or sets the color of the indicator.
        /// </summary>
        /// <value>The color of the indicator.</value>
        public Color IndicatorColor
        {

            get
            {
                return (indicator_color);
            }

            set
            {
                indicator_color = value;

                
            }
        }


        /// <summary>
        /// Gets or sets the indicator diameter.
        /// </summary>
        /// <value>The indicator diameter.</value>
        public int IndicatorDiameter
        {

            get
            {
                return (indicator_diameter);
            }

            set
            {
                indicator_diameter = value;
                
            }
        }

        // ********************************************* IndicatorType

        /// <summary>
        /// Gets or sets the type of the indicator.
        /// </summary>
        /// <value>The type of the indicator.</value>
        public INDICATORTYPES IndicatorType
        {

            get
            {
                return (indicator_type);
            }

            set
            {
                indicator_type = value;

                
            }
        }

        // *********************************************** RefreshRate
        /// <summary>
        /// Gets or sets the refresh rate.
        /// </summary>
        /// <value>The refresh rate.</value>
        public int RefreshRate
        {

            get
            {
                return (refresh_rate);
            }

            set
            {
                refresh_rate = value;
                
            }
        }
        
        #endregion

    }
}
