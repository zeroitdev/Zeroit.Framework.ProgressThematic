// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SupremeCircularProgress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        /// The sp color mode
        /// </summary>
        private Supreme_colorMode SP_colorMode = Supreme_colorMode.Solid;
        /// <summary>
        /// The progress color
        /// </summary>
        private Color progressColor = SystemColors.HotTrack;
        /// <summary>
        /// The outer color
        /// </summary>
        private Color outerColor = Color.LightGray;
        /// <summary>
        /// The solid color
        /// </summary>
        private Color solidColor = SystemColors.Control;
        /// <summary>
        /// The gradient color
        /// </summary>
        private Color[] gradientColor = new Color[]
        {
            Color.Orange,
            Color.DarkSlateGray
        };
        /// <summary>
        /// The lin mode
        /// </summary>
        private LinearGradientMode linMode = LinearGradientMode.BackwardDiagonal;
        /// <summary>
        /// The sp angle
        /// </summary>
        private float SP_angle = -90f;
        /// <summary>
        /// The outerborder
        /// </summary>
        private int outerborder = 5;
        /// <summary>
        /// The innerborder
        /// </summary>
        private int innerborder = 15;

        /// <summary>
        /// The supreme start angle
        /// </summary>
        private float supreme_StartAngle = 180f;
        /// <summary>
        /// The supreme sweep angle
        /// </summary>
        private float supreme_SweepAngle = 360f;
        /// <summary>
        /// The supreme start cap
        /// </summary>
        private LineCap supreme_StartCap = LineCap.Round;
        /// <summary>
        /// The supreme end cap
        /// </summary>
        private LineCap supreme_EndCap = LineCap.Round;
        /// <summary>
        /// The supreme type
        /// </summary>
        private Supreme_type supreme_Type = Supreme_type.Circle;

        /// <summary>
        /// The supreme width tweak
        /// </summary>
        private int supreme_width_Tweak = 20;
        /// <summary>
        /// The supreme height tweak
        /// </summary>
        private int supreme_height_Tweak = 20;

        /// <summary>
        /// The supreme position horizontal
        /// </summary>
        private int supreme_position_horizontal = 10;
        /// <summary>
        /// The supreme position vertical
        /// </summary>
        private int supreme_position_vertical = 10;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the sp width tweak.
        /// </summary>
        /// <value>The sp width tweak.</value>
        public int SP_Width_Tweak
        {
            get { return supreme_width_Tweak; }
            set
            {
                supreme_width_Tweak = value;
            }
        }

        /// <summary>
        /// Gets or sets the sp height tweak.
        /// </summary>
        /// <value>The sp height tweak.</value>
        public int SP_Height_Tweak
        {
            get { return supreme_height_Tweak; }
            set
            {
                supreme_height_Tweak = value;
            }
        }

        /// <summary>
        /// Gets or sets the sp position horizontal.
        /// </summary>
        /// <value>The sp position horizontal.</value>
        public int SP_Position_Horizontal
        {
            get { return supreme_position_horizontal; }
            set
            {
                supreme_position_horizontal = value;
            }
        }

        /// <summary>
        /// Gets or sets the sp position vertical.
        /// </summary>
        /// <value>The sp position vertical.</value>
        public int SP_Position_Vertical
        {
            get { return supreme_position_vertical; }
            set
            {
                supreme_position_vertical = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the supreme.
        /// </summary>
        /// <value>The type of the supreme.</value>
        public Supreme_type Supreme_Type
        {
            get { return supreme_Type; }
            set
            {
                supreme_Type = value;
            }
        }

        /// <summary>
        /// Gets or sets the supreme start angle.
        /// </summary>
        /// <value>The supreme start angle.</value>
        public float Supreme_StartAngle
        {
            get { return supreme_StartAngle; }
            set { supreme_StartAngle = value; }
        }

        /// <summary>
        /// Gets or sets the supreme sweep angle.
        /// </summary>
        /// <value>The supreme sweep angle.</value>
        public float Supreme_SweepAngle
        {
            get { return supreme_SweepAngle; }
            set { supreme_SweepAngle = value; }
        }

        /// <summary>
        /// Gets or sets the supreme start cap.
        /// </summary>
        /// <value>The supreme start cap.</value>
        public LineCap Supreme_StartCap
        {
            get { return supreme_StartCap; }
            set
            {
                supreme_StartCap = value;
            }
        }

        /// <summary>
        /// Gets or sets the supreme end cap.
        /// </summary>
        /// <value>The supreme end cap.</value>
        public LineCap Supreme_EndCap
        {
            get { return supreme_EndCap; }
            set
            {
                supreme_EndCap = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp progress.
        /// </summary>
        /// <value>The color of the sp progress.</value>
        public Color SP_ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp outer.
        /// </summary>
        /// <value>The color of the sp outer.</value>
        public Color SP_OuterColor
        {
            get { return outerColor; }
            set
            {
                outerColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp solid.
        /// </summary>
        /// <value>The color of the sp solid.</value>
        public Color SP_SolidColor
        {
            get { return solidColor; }
            set
            {
                solidColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp gradient.
        /// </summary>
        /// <value>The color of the sp gradient.</value>
        public Color[] SP_GradientColor
        {
            get { return gradientColor; }
            set
            {
                gradientColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp color mode.
        /// </summary>
        /// <value>The sp color mode.</value>
        public Supreme_colorMode SP_ColorMode
        {
            get { return SP_colorMode; }
            set
            {
                SP_colorMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp angle.
        /// </summary>
        /// <value>The sp angle.</value>
        public float SP_Angle
        {
            get
            {
                return SP_angle;

            }
            set
            {
                SP_angle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp outer border.
        /// </summary>
        /// <value>The sp outer border.</value>
        public int SP_OuterBorder
        {
            get { return outerborder; }
            set
            {
                outerborder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp inner border.
        /// </summary>
        /// <value>The sp inner border.</value>
        public int SP_InnerBorder
        {
            get { return innerborder; }
            set
            {
                innerborder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp gradient mode.
        /// </summary>
        /// <value>The sp gradient mode.</value>
        public LinearGradientMode SP_GradientMode
        {
            get { return linMode; }
            set
            {
                linMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the sp draw mode.
        /// </summary>
        /// <value>The sp draw mode.</value>
        public Supreme_colorMode SP_DrawMode
        {
            get { return SP_colorMode; }
            set
            {
                SP_colorMode = value;
                
            }
        }

        #endregion

    }
}
