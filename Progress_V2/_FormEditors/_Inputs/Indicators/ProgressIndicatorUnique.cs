// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicatorUnique.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        /// The unique interval
        /// </summary>
        private int Unique_interval = 100;
        /// <summary>
        /// The unique circle color
        /// </summary>
        private Color Unique_circleColor = Color.FromArgb(20, 20, 20);
        /// <summary>
        /// The unique circle size
        /// </summary>
        private float Unique_circleSize = 1.0F;
        /// <summary>
        /// The unique number of circles
        /// </summary>
        private float Unique_numberOfCircles = 100 /*8*/;
        /// <summary>
        /// The unique number of visible circles
        /// </summary>
        private int Unique_numberOfVisibleCircles = 8;
        /// <summary>
        /// The unique rotation
        /// </summary>
        private Unique_RotationType Unique_rotation = Unique_RotationType.Clockwise;
        /// <summary>
        /// The unique percentage
        /// </summary>
        private float Unique_percentage = 0;
        /// <summary>
        /// The unique show percentage
        /// </summary>
        private bool Unique_showPercentage = false;
        /// <summary>
        /// The unique show text
        /// </summary>
        private bool Unique_showText = false;
        /// <summary>
        /// The unique text display
        /// </summary>
        private Unique_TextDisplayModes Unique_textDisplay = Unique_TextDisplayModes.None;

        /// <summary>
        /// The unique custom text
        /// </summary>
        private string Unique_customText = "Unique";
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the unique custom text.
        /// </summary>
        /// <value>The unique custom text.</value>
        public string Unique_CustomText
        {
            get { return Unique_customText;}
            set { Unique_customText = value; }
        }
        /// <summary>
        /// Gets or sets the color of the unique circle.
        /// </summary>
        /// <value>The color of the unique circle.</value>
        public Color Unique_CircleColor
        {
            get { return Unique_circleColor; }
            set
            {
                Unique_circleColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the unique circle.
        /// </summary>
        /// <value>The size of the unique circle.</value>
        public float Unique_CircleSize
        {
            get { return Unique_circleSize; }
            set { Unique_circleSize = value; }
        }

        /// <summary>
        /// Gets or sets the unique animation speed.
        /// </summary>
        /// <value>The unique animation speed.</value>
        public int Unique_AnimationSpeed
        {
            get { return Unique_interval; }
            set { Unique_interval = value; }
        }

        /// <summary>
        /// Gets or sets the unique number of circles.
        /// </summary>
        /// <value>The unique number of circles.</value>
        public float Unique_NumberOfCircles
        {
            get { return Unique_numberOfCircles; }
            set
            {

                Unique_numberOfCircles = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the unique number of visible circles.
        /// </summary>
        /// <value>The unique number of visible circles.</value>
        public int Unique_NumberOfVisibleCircles
        {
            get { return Unique_numberOfVisibleCircles; }
            set
            {
                
                Unique_numberOfVisibleCircles = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the unique rotation.
        /// </summary>
        /// <value>The unique rotation.</value>
        public Unique_RotationType Unique_Rotation
        {
            get { return Unique_rotation; }
            set
            {
                Unique_rotation = value;
            }
        }

        /// <summary>
        /// Gets or sets the unique percentage.
        /// </summary>
        /// <value>The unique percentage.</value>
        public float Unique_Percentage
        {
            get { return Unique_percentage; }
            set
            {
                
                Unique_percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [unique show percentage].
        /// </summary>
        /// <value><c>true</c> if [unique show percentage]; otherwise, <c>false</c>.</value>
        public bool Unique_ShowPercentage
        {
            get { return Unique_showPercentage; }
            set
            {
                Unique_showPercentage = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [unique show text].
        /// </summary>
        /// <value><c>true</c> if [unique show text]; otherwise, <c>false</c>.</value>
        public bool Unique_ShowText
        {
            get { return Unique_showText; }
            set
            {
                Unique_showText = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the unique text display.
        /// </summary>
        /// <value>The unique text display.</value>
        public Unique_TextDisplayModes Unique_TextDisplay
        {
            get { return Unique_textDisplay; }
            set
            {
                Unique_textDisplay = value;
                
            }
        }

        #endregion

    }
}
