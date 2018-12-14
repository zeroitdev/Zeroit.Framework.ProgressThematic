// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio-Normal.cs" company="Zeroit Dev Technologies">
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
        /// The progress normal type
        /// </summary>
        private ZeroitThematicProgress.progressNormalType _progressNormalType = ZeroitThematicProgress.progressNormalType.Normal;
        /// <summary>
        /// The progress bar normal step
        /// </summary>
        private int ProgressBarNormal_step = 5;
        /// <summary>
        /// The text color type
        /// </summary>
        private ZeroitThematicProgress.TextColorTypes _TextColorType = ZeroitThematicProgress.TextColorTypes.Automatic;
        /// <summary>
        /// The text align
        /// </summary>
        private ZeroitThematicProgress.TextAlignmentTypes _TextAlign = ZeroitThematicProgress.TextAlignmentTypes.Center;
        /// <summary>
        /// The display progress
        /// </summary>
        private bool _DisplayProgress = false;
        /// <summary>
        /// The color progress
        /// </summary>
        private Color _ColorProgress = Color.Blue;
        /// <summary>
        /// The border type
        /// </summary>
        private ZeroitThematicProgress.BorderTypes _BorderType = ZeroitThematicProgress.BorderTypes.None;
        /// <summary>
        /// The progress bar normal border color
        /// </summary>
        private Color ProgressBarNormal_borderColor = Color.Black;
        /// <summary>
        /// The roll block percent
        /// </summary>
        private int _RollBlockPercent = 20;
        /// <summary>
        /// The rolling type
        /// </summary>
        private ZeroitThematicProgress.RollingTypes _RollingType = ZeroitThematicProgress.RollingTypes.Bouncing;
        /// <summary>
        /// The antonio interval
        /// </summary>
        private int antonioInterval = 100;


        /// <summary>
        /// The gradient percent
        /// </summary>
        private int _GradientPercent = 20;
        /// <summary>
        /// The gradient type
        /// </summary>
        private ZeroitThematicProgress.GradientTypes _GradientType = ZeroitThematicProgress.GradientTypes.FullWidthGradient;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the gradient percent.
        /// </summary>
        /// <value>The gradient percent.</value>
        public int GradientPercent
        {
            get { return _GradientPercent; }
            set
            {
                _GradientPercent = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the gradient.
        /// </summary>
        /// <value>The type of the gradient.</value>
        public ZeroitThematicProgress.GradientTypes GradientType
        {
            get { return _GradientType; }
            set
            {
                _GradientType = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the progress normal.
        /// </summary>
        /// <value>The type of the progress normal.</value>
        public ZeroitThematicProgress.progressNormalType ProgressNormalType
        {
            get { return _progressNormalType; }
            set
            {
                _progressNormalType = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar normal step.
        /// </summary>
        /// <value>The progress bar normal step.</value>
        public int ProgressBarNormal_Step
        {
            get
            {
                return ProgressBarNormal_step;
            }
            set
            {
                ProgressBarNormal_step = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color progress.
        /// </summary>
        /// <value>The color progress.</value>
        public Color ColorProgress
        {
            get
            {
                return _ColorProgress;
            }
            set
            {
                _ColorProgress = value;
                
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display progress].
        /// </summary>
        /// <value><c>true</c> if [display progress]; otherwise, <c>false</c>.</value>
        public bool DisplayProgress
        {
            get
            {
                return _DisplayProgress;
            }
            set
            {
                _DisplayProgress = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the type of the text color.
        /// </summary>
        /// <value>The type of the text color.</value>
        public ZeroitThematicProgress.TextColorTypes TextColorType
        {
            get
            {
                return _TextColorType;
            }
            set
            {
                _TextColorType = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        public ZeroitThematicProgress.TextAlignmentTypes TextAlign
        {
            get
            {
                return _TextAlign;
            }
            set
            {
                _TextAlign = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the type of the border.
        /// </summary>
        /// <value>The type of the border.</value>
        public ZeroitThematicProgress.BorderTypes BorderType
        {
            get
            {
                return _BorderType;
            }
            set
            {
                _BorderType = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the progress bar normal border.
        /// </summary>
        /// <value>The color of the progress bar normal border.</value>
        public Color ProgressBarNormal_BorderColor
        {
            get
            {
                return ProgressBarNormal_borderColor;
            }
            set
            {
                
                ProgressBarNormal_borderColor = value;
                
            }
        }


        #endregion

        #region Rolling

        /// <summary>
        /// Gets or sets the roll block percent.
        /// </summary>
        /// <value>The roll block percent.</value>
        public int RollBlockPercent
        {
            get
            {
                return _RollBlockPercent;
            }
            set
            {
                _RollBlockPercent = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the type of the rolling.
        /// </summary>
        /// <value>The type of the rolling.</value>
        public ZeroitThematicProgress.RollingTypes RollingType
        {
            get
            {
                return _RollingType;
            }
            set
            {
                _RollingType = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the roll timer.
        /// </summary>
        /// <value>The roll timer.</value>
        public int RollTimer
        {
            get
            {
                return antonioInterval;
            }
            set
            {
                antonioInterval = value;
            }
        }

        


        #endregion

    }
}
