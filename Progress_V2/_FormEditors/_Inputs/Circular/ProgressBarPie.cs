// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPie.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
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


        #region Variables


        /// <summary>
        /// The progress pie progress color1
        /// </summary>
        private Color ProgressPie_progressColor1 = Color.DarkSlateGray;
        /// <summary>
        /// The progress pie progress color2
        /// </summary>
        private Color ProgressPie_progressColor2 = Color.DarkOrange;
        /// <summary>
        /// The progress pie fill ellipse1
        /// </summary>
        private Color ProgressPie_fillEllipse1 = Color.Transparent;
        /// <summary>
        /// The progress pie fill ellipse2
        /// </summary>
        private Color ProgressPie_fillEllipse2 = Color.Transparent;
        /// <summary>
        /// The progress pie text color
        /// </summary>
        private Color ProgressPie_textColor = Color.Transparent;
        /// <summary>
        /// The progress pie progress color inner border
        /// </summary>
        private Color ProgressPie_progressColorInnerBorder = Color.Transparent;
        /// <summary>
        /// The progress pie progress shape value
        /// </summary>
        private ProgressPie_ProgressShape ProgressPie_progressShapeVal = ProgressPie_ProgressShape.Round;
        /// <summary>
        /// The progress pie start
        /// </summary>
        private LineCap ProgressPie_start = LineCap.Flat;
        /// <summary>
        /// The progress pie end
        /// </summary>
        private LineCap ProgressPie_end = LineCap.Flat;
        /// <summary>
        /// The progress pie progress width
        /// </summary>
        private Double ProgressPie_progressWidth = 1f;
        /// <summary>
        /// The progress pie pen width
        /// </summary>
        private float ProgressPie_penWidth = 1f;
        //private float ProgressPie_progressWidthToFloat;
        /// <summary>
        /// The progress pie show text
        /// </summary>
        private bool ProgressPie_showText = true;
        /// <summary>
        /// The progress pie position
        /// </summary>
        private float ProgressPie_position = 180.0f;
        /// <summary>
        /// The progress pie sweep angle
        /// </summary>
        private float ProgressPie_sweepAngle = 180.0f;

        #endregion

        #region Custom Properties

        /// <summary>
        /// Gets or sets the progress pie position.
        /// </summary>
        /// <value>The progress pie position.</value>
        public float ProgressPie_Position
        {
            get { return ProgressPie_position; }
            set
            {
                ProgressPie_position = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie sweep angle.
        /// </summary>
        /// <value>The progress pie sweep angle.</value>
        public float ProgressPie_SweepAngle
        {
            get { return ProgressPie_sweepAngle; }
            set
            {
                ProgressPie_sweepAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie show text.
        /// </summary>
        /// <value>The progress pie show text.</value>
        public Boolean ProgressPie_ShowText
        {
            get { return ProgressPie_showText; }
            set
            {
                if (value == false)
                {
                    ProgressPie_textColor = Color.Transparent;
                }

                else
                {
                    ProgressPie_textColor = Color.White;
                }
                ProgressPie_showText = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the progress pie inner border.
        /// </summary>
        /// <value>The width of the progress pie inner border.</value>
        public float ProgressPie_InnerBorderWidth
        {
            get { return ProgressPie_penWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                ProgressPie_penWidth = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress pie inner border.
        /// </summary>
        /// <value>The color of the progress pie inner border.</value>
        public Color ProgressPie_InnerBorderColor
        {
            get { return ProgressPie_progressColorInnerBorder; }
            set
            {
                ProgressPie_progressColorInnerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress pie text.
        /// </summary>
        /// <value>The color of the progress pie text.</value>
        public Color ProgressPie_TextColor
        {
            get { return ProgressPie_textColor; }
            set
            {
                ProgressPie_textColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie width start cap.
        /// </summary>
        /// <value>The progress pie width start cap.</value>
        public LineCap ProgressPie_WidthStartCap
        {
            get { return ProgressPie_start; }
            set
            {
                if (ProgressPie_start == null)
                {
                    ProgressPie_start = LineCap.Flat;
                }
                ProgressPie_start = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie width end cap.
        /// </summary>
        /// <value>The progress pie width end cap.</value>
        public LineCap ProgressPie_WidthEndCap
        {
            get { return ProgressPie_end; }
            set
            {
                if (ProgressPie_end == null)
                {
                    ProgressPie_end = LineCap.Flat;
                }
                ProgressPie_end = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the progress pie progress.
        /// </summary>
        /// <value>The width of the progress pie progress.</value>
        public Double ProgressPie_ProgressWidth
        {
            get { return ProgressPie_progressWidth; }
            set
            {
                if (ProgressPie_progressWidth == null)
                {
                    ProgressPie_progressWidth = 5f;
                }

                ProgressPie_progressWidth = value;
                //ProgressPie_progressWidthToFloat = ProgressPie_DoubleToFloat(ProgressPie_progressWidth);

                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie progress color1.
        /// </summary>
        /// <value>The progress pie progress color1.</value>
        public Color ProgressPie_ProgressColor1
        {
            get { return ProgressPie_progressColor1; }
            set
            {
                ProgressPie_progressColor1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie progress color2.
        /// </summary>
        /// <value>The progress pie progress color2.</value>
        public Color ProgressPie_ProgressColor2
        {
            get { return ProgressPie_progressColor2; }
            set
            {
                ProgressPie_progressColor2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie fill ellipse1.
        /// </summary>
        /// <value>The progress pie fill ellipse1.</value>
        public Color ProgressPie_FillEllipse1
        {
            get { return ProgressPie_fillEllipse1; }
            set
            {
                ProgressPie_fillEllipse1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie fill ellipse2.
        /// </summary>
        /// <value>The progress pie fill ellipse2.</value>
        public Color ProgressPie_FillEllipse2
        {
            get { return ProgressPie_fillEllipse2; }
            set
            {
                ProgressPie_fillEllipse2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress pie progress shape.
        /// </summary>
        /// <value>The progress pie progress shape.</value>
        public ProgressPie_ProgressShape ProgressPie__ProgressShape
        {
            get { return ProgressPie_progressShapeVal; }
            set
            {
                ProgressPie_progressShapeVal = value;
                
            }
        }

        #endregion


    }
}
