// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="GoogleProgress.cs" company="Zeroit Dev Technologies">
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

        #region Fields
        /// <summary>
        /// The google progress annulus color
        /// </summary>
        private Color GoogleProgress_annulus_color = Color.PaleTurquoise;
        //private int GoogleProgress_annulus_thickness;
        /// <summary>
        /// The google progress background color
        /// </summary>
        private Color GoogleProgress_background_color = SystemColors.Control;
        /// <summary>
        /// The google progress indicator angle
        /// </summary>
        private int GoogleProgress_indicator_angle = 0;
        /// <summary>
        /// The google progress indicator angular advance
        /// </summary>
        private int GoogleProgress_indicator_angular_advance = 10;
        /// <summary>
        /// The google progress indicator color
        /// </summary>
        private Color GoogleProgress_indicator_color = Color.White;
        /// <summary>
        /// The google progress indicator type
        /// </summary>
        private GoogleProgress_INDICATORTYPES GoogleProgress_indicator_type =
            GoogleProgress_INDICATORTYPES.ANIMATED;
        /// <summary>
        /// The inner radius
        /// </summary>
        private int inner_radius = 20;
        /// <summary>
        /// The outer radius
        /// </summary>
        private int outer_radius/* = 84*/ = 24;
        /// <summary>
        /// The google progress refresh rate
        /// </summary>
        private int GoogleProgress_refresh_rate = 100;
        /// <summary>
        /// The google progress angle
        /// </summary>
        private float GoogleProgress_angle = 90;
        /// <summary>
        /// The transition color
        /// </summary>
        private Color transition_color = Color.Gray;
        /// <summary>
        /// The color1bigcircle
        /// </summary>
        private Color color1bigcircle = Color.Red;
        /// <summary>
        /// The color2bigcircle
        /// </summary>
        private Color color2bigcircle = Color.Yellow;
        /// <summary>
        /// The color1indicator
        /// </summary>
        private Color color1indicator = Color.Gray;
        /// <summary>
        /// The color2indicator
        /// </summary>
        private Color color2indicator = Color.DarkBlue;
        /// <summary>
        /// The inner color
        /// </summary>
        private Color inner_color = Color.DarkBlue;
        /// <summary>
        /// The inner border
        /// </summary>
        private int inner_border = 1;

        #endregion


        #region Public Properties

        // ********************************************* GoogleProgress_Pulse method


        /// <summary>
        /// Gets or sets the inner border.
        /// </summary>
        /// <value>The inner border.</value>
        public int InnerBorder
        {
            get { return inner_border; }
            set
            {
                inner_border = value;

                
            }
        }


        /// <summary>
        /// Gets or sets the color angle.
        /// </summary>
        /// <value>The color angle.</value>
        public float ColorAngle
        {
            get { return GoogleProgress_angle; }
            set
            {
                GoogleProgress_angle = value;


            }
        }


        /// <summary>
        /// Gets or sets the color inner border.
        /// </summary>
        /// <value>The color inner border.</value>
        public Color ColorInnerBorder
        {
            get { return inner_color; }
            set
            {
                inner_color = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the color1 bigcircle.
        /// </summary>
        /// <value>The color1 bigcircle.</value>
        public Color Color1Bigcircle
        {
            get { return color1bigcircle; }
            set
            {
                color1bigcircle = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the color2 bigcircle.
        /// </summary>
        /// <value>The color2 bigcircle.</value>
        public Color Color2Bigcircle
        {
            get { return color2bigcircle; }
            set
            {
                color2bigcircle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color1 indicator.
        /// </summary>
        /// <value>The color1 indicator.</value>
        public Color Color1Indicator
        {
            get { return color1indicator; }
            set
            {
                color1indicator = value;


                
            }
        }

        /// <summary>
        /// Gets or sets the color2 indicator.
        /// </summary>
        /// <value>The color2 indicator.</value>
        public Color Color2Indicator
        {
            get { return color2indicator; }
            set
            {
                color2indicator = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the color of the annulus.
        /// </summary>
        /// <value>The color of the annulus.</value>
        public Color AnnulusColor
        {
            get
            {
                return (GoogleProgress_annulus_color);
            }

            set
            {
                GoogleProgress_annulus_color = value;

                
            }
        }

        // ********************************* GoogleProgress_BackgroundColor property

        /// <summary>
        /// Gets or sets the color of the google progress background.
        /// </summary>
        /// <value>The color of the google progress background.</value>
        public Color GoogleProgress_BackgroundColor
        {

            get
            {
                return (GoogleProgress_background_color);
            }

            set
            {
                GoogleProgress_background_color = value;

                
                
            }
        }


        // ********************************** IndicatorAngularAdvance

        /// <summary>
        /// Gets or sets the indicator angular advance.
        /// </summary>
        /// <value>The indicator angular advance.</value>
        public int IndicatorAngularAdvance
        {

            get
            {
                return (GoogleProgress_indicator_angular_advance);
            }

            set
            {
                GoogleProgress_indicator_angular_advance = value;

                
            }
        }

        // ********************************** GoogleProgress_IndicatorColor property

        /// <summary>
        /// Gets or sets the color of the google progress indicator.
        /// </summary>
        /// <value>The color of the google progress indicator.</value>
        public Color GoogleProgress_IndicatorColor
        {

            get
            {
                return (GoogleProgress_indicator_color);
            }

            set
            {
                GoogleProgress_indicator_color = value;

                
            }
        }

        // ******************************************** GoogleProgress_IndicatorType

        /// <summary>
        /// Gets or sets the type of the google progress indicator.
        /// </summary>
        /// <value>The type of the google progress indicator.</value>
        public GoogleProgress_INDICATORTYPES GoogleProgress_IndicatorType
        {

            get
            {
                return (GoogleProgress_indicator_type);
            }

            set
            {
                GoogleProgress_indicator_type = value;

                
                
            }
        }

        // ************************************* InnerRadius property

        /// <summary>
        /// Gets or sets the inner radius.
        /// </summary>
        /// <value>The inner radius.</value>
        public int InnerRadius
        {

            get
            {
                return (inner_radius);
            }

            set
            {
                inner_radius = value;
                
            }
        }

        // ************************************* OuterRadius property

        /// <summary>
        /// Gets or sets the outer radius.
        /// </summary>
        /// <value>The outer radius.</value>
        public int OuterRadius
        {

            get
            {
                return (outer_radius);
            }

            set
            {
                outer_radius = value;
                
            }
        }

        // ************************************* GoogleProgress_RefreshRate property



        /// <summary>
        /// Gets or sets the google progress refresh rate.
        /// </summary>
        /// <value>The google progress refresh rate.</value>
        public int GoogleProgress_RefreshRate
        {

            get
            {
                return (GoogleProgress_refresh_rate);
            }

            set
            {


                GoogleProgress_refresh_rate = value;

                
            }
        }

        // ********************************* TransitionColor property

        /// <summary>
        /// Gets or sets the color of the transition.
        /// </summary>
        /// <value>The color of the transition.</value>
        public Color TransitionColor
        {

            get
            {
                return (transition_color);
            }

            set
            {
                transition_color = value;
                
            }
        }

        // *********************************** create_annulus_graphic 
        #endregion


    }
}
