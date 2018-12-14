// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressBarV2.cs" company="Zeroit Dev Technologies">
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

        #region Private Field


        /// <summary>
        /// The dag up un filled color
        /// </summary>
        private Color DagUp_unFilledColor = Color.FromArgb(114, 114, 114);

        /// <summary>
        /// The dag up filled color
        /// </summary>
        private Color DagUp_filledColor = Color.FromArgb(60, 220, 210);

        /// <summary>
        /// The dag up inner color
        /// </summary>
        private Color DagUp_innerColor = Color.Orange;

        /// <summary>
        /// The dag innercircle color
        /// </summary>
        private Color Dag_innercircleColor = Color.FromArgb(20, 20, 20);

        /// <summary>
        /// The dag innercircle border
        /// </summary>
        private Color Dag_innercircleBorder = Color.LightGray;

        /// <summary>
        /// The dag up innerfilled alpha
        /// </summary>
        private int DagUp_innerfilledAlpha = 200;

        /// <summary>
        /// The dag up innerfilled thickness
        /// </summary>
        private int DagUp_innerfilledThickness = 30;

        /// <summary>
        /// The dag up filled color alpha
        /// </summary>
        private int DagUp_filledColorAlpha = 130;

        /// <summary>
        /// The dag up unfilled thickness
        /// </summary>
        private int DagUp_unfilledThickness = 24;

        /// <summary>
        /// The dag up filled thickness
        /// </summary>
        private int DagUp_filledThickness = 40;

        /// <summary>
        /// The dag up animation speed
        /// </summary>
        public int DagUp_animationSpeed = 5;

        /// <summary>
        /// The dag pen width
        /// </summary>
        int Dag_penWidth = 20;

        /// <summary>
        /// The dag styled
        /// </summary>
        private bool dagStyled = false;

        /// <summary>
        /// The draw inner circle
        /// </summary>
        private bool drawInnerCircle = true;

        /// <summary>
        /// The dag up is animated
        /// </summary>
        public bool DagUp_isAnimated = false;

        /// <summary>
        /// The penpara
        /// </summary>
        private PenParameters penpara = new PenParameters();

        /// <summary>
        /// The dag upinner border
        /// </summary>
        private bool DagUpinnerBorder = true;



        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the progress effects.
        /// </summary>
        /// <value>The progress effects.</value>
        public PenParameters ProgressEffects
        {
            get { return penpara; }
            set
            {
                penpara = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag inner.
        /// </summary>
        /// <value>The color of the dag inner.</value>
        public Color DagInnerColor
        {
            get { return Dag_innercircleColor; }
            set
            {
                Dag_innercircleColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag inner border.
        /// </summary>
        /// <value>The dag inner border.</value>
        public Color DagInnerBorder
        {
            get { return Dag_innercircleBorder; }
            set
            {
                Dag_innercircleBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag up inner filled.
        /// </summary>
        /// <value>The color of the dag up inner filled.</value>
        public Color DagUpInnerFilledColor
        {
            get { return DagUp_innerColor; }
            set
            {
                DagUp_innerColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the dag up filled.
        /// </summary>
        /// <value>The color of the dag up filled.</value>
        public Color DagUpFilledColor
        {
            get
            {
                return this.DagUp_filledColor;
            }
            set
            {
                this.DagUp_filledColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the dag up un filled.
        /// </summary>
        /// <value>The color of the dag up un filled.</value>
        public Color DagUpUnFilledColor
        {
            get
            {
                return this.DagUp_unFilledColor;
            }
            set
            {
                this.DagUp_unFilledColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the width of the dag inner border.
        /// </summary>
        /// <value>The width of the dag inner border.</value>
        public int DagInnerBorderWidth
        {
            get { return Dag_penWidth; }
            set
            {
                Dag_penWidth = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled thickness inner.
        /// </summary>
        /// <value>The dag up filled thickness inner.</value>
        public int DagUpFilledThicknessInner
        {
            get { return DagUp_innerfilledThickness; }
            set
            {
                DagUp_innerfilledThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled color alpha inner.
        /// </summary>
        /// <value>The dag up filled color alpha inner.</value>
        public int DagUpFilledColorAlphaInner
        {
            get { return DagUp_innerfilledAlpha; }
            set
            {
                
                DagUp_innerfilledAlpha = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag anim up speed.
        /// </summary>
        /// <value>The dag anim up speed.</value>
        public int DagAnimUpSpeed
        {
            get
            {
                return this.DagUp_animationSpeed;
            }
            set
            {
                this.DagUp_animationSpeed = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled color alpha.
        /// </summary>
        /// <value>The dag up filled color alpha.</value>
        public int DagUpFilledColorAlpha
        {
            get
            {
                return this.DagUp_filledColorAlpha;
            }
            set
            {
                this.DagUp_filledColorAlpha = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled thickness.
        /// </summary>
        /// <value>The dag up filled thickness.</value>
        public int DagUpFilledThickness
        {
            get
            {
                return this.DagUp_filledThickness;
            }
            set
            {
                this.DagUp_filledThickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dag up unfilled thickness.
        /// </summary>
        /// <value>The dag up unfilled thickness.</value>
        public int DagUpUnfilledThickness
        {
            get
            {
                return this.DagUp_unfilledThickness;
            }
            set
            {
                this.DagUp_unfilledThickness = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag up is animated].
        /// </summary>
        /// <value><c>true</c> if [dag up is animated]; otherwise, <c>false</c>.</value>
        public bool DagUpIsAnimated
        {
            get
            {
                return this.DagUp_isAnimated;
            }
            set
            {
                this.DagUp_isAnimated = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag up inner border].
        /// </summary>
        /// <value><c>true</c> if [dag up inner border]; otherwise, <c>false</c>.</value>
        public bool DagUpInnerBorder
        {
            get { return DagUpinnerBorder; }
            set
            {
                DagUpinnerBorder = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag styled].
        /// </summary>
        /// <value><c>true</c> if [dag styled]; otherwise, <c>false</c>.</value>
        public bool DagStyled
        {
            get { return dagStyled; }
            set
            {
                dagStyled = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag draw inner circle].
        /// </summary>
        /// <value><c>true</c> if [dag draw inner circle]; otherwise, <c>false</c>.</value>
        public bool DagDrawInnerCircle
        {
            get { return drawInnerCircle; }
            set
            {
                drawInnerCircle = value;

            }
        }


        #endregion

    }
}
