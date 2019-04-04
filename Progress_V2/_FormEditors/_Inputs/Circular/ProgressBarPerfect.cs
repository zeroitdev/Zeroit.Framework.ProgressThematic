// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerfect.cs" company="Zeroit Dev Technologies">
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
        /// The progress perfect interval
        /// </summary>
        private int ProgressPerfect_interval = 100;
        /// <summary>
        /// The progress perfect circle color
        /// </summary>
        private Color ProgressPerfect_circleColor = Color.FromArgb(20, 20, 20);
        //private bool _stopped = true;
        /// <summary>
        /// The progress perfect circle size
        /// </summary>
        private float ProgressPerfect_circleSize = 0.2F;
        /// <summary>
        /// The number of circles
        /// </summary>
        private float _numberOfCircles = 180;
        /// <summary>
        /// The number of visible circles
        /// </summary>
        private int _numberOfVisibleCircles = 30;
        /// <summary>
        /// The progress perfect rotation
        /// </summary>
        private RotationType1 ProgressPerfect_rotation = RotationType1.Clockwise;
        /// <summary>
        /// The progress perfect percentage
        /// </summary>
        private float ProgressPerfect_percentage = 0;
        /// <summary>
        /// The progress perfect show percentage
        /// </summary>
        private bool ProgressPerfect_showPercentage = false;
        /// <summary>
        /// The progress bar perfect show text
        /// </summary>
        private bool ProgressBarPerfect_showText = false;
        /// <summary>
        /// The progress perfect text display
        /// </summary>
        private TextDisplayModes1 ProgressPerfect_textDisplay = TextDisplayModes1.None;


        /// <summary>
        /// The progress bar perfect custom text
        /// </summary>
        private string ProgressBarPerfect_customText = "Perfect";
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the progress bar perfect custom text.
        /// </summary>
        /// <value>The progress bar perfect custom text.</value>
        public string ProgressBarPerfect_CustomText
        {
            get { return ProgressBarPerfect_customText; }
            set
            {
                ProgressBarPerfect_customText = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress perfect circle.
        /// </summary>
        /// <value>The color of the progress perfect circle.</value>
        public Color ProgressPerfect_CircleColor
        {
            get { return ProgressPerfect_circleColor; }
            set
            {
                ProgressPerfect_circleColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the progress perfect circle.
        /// </summary>
        /// <value>The size of the progress perfect circle.</value>
        public float ProgressPerfect_CircleSize
        {
            get { return ProgressPerfect_circleSize; }
            set
            {
                ProgressPerfect_circleSize = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar perfect animation speed.
        /// </summary>
        /// <value>The progress bar perfect animation speed.</value>
        public int ProgressBarPerfect_AnimationSpeed
        {
            get { return ProgressPerfect_interval; }
            set
            {
                ProgressPerfect_interval = value;
            }
        }

        /// <summary>
        /// Gets or sets the progress perfect number of circles.
        /// </summary>
        /// <value>The progress perfect number of circles.</value>
        public float ProgressPerfect_NumberOfCircles
        {
            get { return _numberOfCircles; }
            set
            {

                _numberOfCircles = value;
                
            }
        }


        //---------------------------------------------------Number Of Circles-------------------------------------//

        /// <summary>
        /// Gets or sets the progress perfect number of visible circles.
        /// </summary>
        /// <value>The progress perfect number of visible circles.</value>
        public int ProgressPerfect_NumberOfVisibleCircles
        {
            get { return _numberOfVisibleCircles; }
            set
            {
                _numberOfVisibleCircles = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress perfect percentage.
        /// </summary>
        /// <value>The progress perfect percentage.</value>
        public float ProgressPerfect_Percentage
        {
            get { return ProgressPerfect_percentage; }
            set
            {
                
                ProgressPerfect_percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [progress perfect show percentage].
        /// </summary>
        /// <value><c>true</c> if [progress perfect show percentage]; otherwise, <c>false</c>.</value>
        public bool ProgressPerfect_ShowPercentage
        {
            get { return ProgressPerfect_showPercentage; }
            set
            {
                ProgressPerfect_showPercentage = value;

                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [progress bar perfect show text].
        /// </summary>
        /// <value><c>true</c> if [progress bar perfect show text]; otherwise, <c>false</c>.</value>
        public bool ProgressBarPerfect_ShowText
        {
            get { return ProgressBarPerfect_showText; }
            set
            {
                ProgressBarPerfect_showText = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the progress perfect rotation.
        /// </summary>
        /// <value>The progress perfect rotation.</value>
        public RotationType1 ProgressPerfect_Rotation
        {
            get { return ProgressPerfect_rotation; }
            set { ProgressPerfect_rotation = value; }
        }

        /// <summary>
        /// Gets or sets the progress perfect text display.
        /// </summary>
        /// <value>The progress perfect text display.</value>
        public TextDisplayModes1 ProgressPerfect_TextDisplay
        {
            get { return ProgressPerfect_textDisplay; }
            set
            {
                ProgressPerfect_textDisplay = value;

                
            }
        }



        #endregion

    }
}
