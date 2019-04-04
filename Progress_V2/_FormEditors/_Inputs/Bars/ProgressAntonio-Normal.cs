// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio-Normal.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
