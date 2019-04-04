// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MazeProgress.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
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

        #region Private Fields

        /// <summary>
        /// The maze progress style
        /// </summary>
        private ProgressBarStyle Maze_progressStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
        /// <summary>
        /// The maze marquee animation speed
        /// </summary>
        private float Maze_marqueeAnimationSpeed = 100f;
        /// <summary>
        /// The maze row count
        /// </summary>
        private int Maze_rowCount = 3;
        /// <summary>
        /// The maze maze style
        /// </summary>
        private MazeStyleType Maze_mazeStyle = MazeStyleType.SingleRight;
        /// <summary>
        /// The maze gradient
        /// </summary>
        private Maze_GradientType Maze_gradient = Maze_GradientType.None;
        /// <summary>
        /// The maze gradient start color
        /// </summary>
        private Color Maze_gradientStartColor = Color.PaleGreen;
        /// <summary>
        /// The maze gradient end color
        /// </summary>
        private Color Maze_gradientEndColor = Color.Lime;
        /// <summary>
        /// The maze wall size
        /// </summary>
        private int Maze_wallSize = 1;
        /// <summary>
        /// The maze border size
        /// </summary>
        private int Maze_borderSize = 0;
        /// <summary>
        /// The maze border color
        /// </summary>
        private Color Maze_borderColor = Color.Black;
        /// <summary>
        /// The maze border gradient
        /// </summary>
        private bool Maze_borderGradient = false;
        /// <summary>
        /// The maze border round corners
        /// </summary>
        private bool Maze_borderRoundCorners = false;
        /// <summary>
        /// The maze unused color
        /// </summary>
        private Color Maze_unusedColor = SystemColors.Control;
        /// <summary>
        /// The maze solid color
        /// </summary>
        private Color maze_solidColor = SystemColors.Highlight;
        /// <summary>
        /// The wall color
        /// </summary>
        private Color wallColor = Color.Black;

        #endregion


        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the maze solid.
        /// </summary>
        /// <value>The color of the maze solid.</value>
        public Color Maze_SolidColor
        {
            get { return maze_solidColor; }
            set
            {
                maze_solidColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>The style.</value>
        public new ProgressBarStyle Style
        {
            get { return Maze_progressStyle; }
            set
            {


                Maze_progressStyle = value;
                
                
            }
        }

        /// <summary>
        /// Gets or sets the marquee animation speed.
        /// </summary>
        /// <value>The marquee animation speed.</value>
        public float MarqueeAnimationSpeed
        {
            get { return Maze_marqueeAnimationSpeed; }
            set
            {
                Maze_marqueeAnimationSpeed = value;
                
                
            }
        }

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>The row count.</value>
        public int RowCount
        {
            get { return Maze_rowCount; }
            set
            {
                Maze_rowCount = value;

                //if (value != Maze_rowCount)
                //{
                //    if (value < 1)
                //    {
                //        throw new ArgumentOutOfRangeException("RowCount");
                //    }
                //    Maze_rowCount = value;
                    
                //}
            }
        }

        //public int PathLength
        //{
        //    get
        //    {
        //        if (maze == null)
        //        {
        //            return 0;
        //        }
        //        return maze.Paths.GetLength(0);
        //    }
        //}

        /// <summary>
        /// Gets or sets the maze style.
        /// </summary>
        /// <value>The maze style.</value>
        public MazeStyleType MazeStyle
        {
            get { return Maze_mazeStyle; }
            set
            {
                Maze_mazeStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the gradient.
        /// </summary>
        /// <value>The gradient.</value>
        public Maze_GradientType Gradient
        {
            get { return Maze_gradient; }
            set
            {
                Maze_gradient = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the start color of the gradient.
        /// </summary>
        /// <value>The start color of the gradient.</value>
        public Color GradientStartColor
        {
            get { return Maze_gradientStartColor; }
            set
            {
                Maze_gradientStartColor = value;
                //if (Maze_gradientStartColor.ToArgb() != value.ToArgb())
                //{
                //    Maze_gradientStartColor = value;
                //    Maze_gradientColors = null;
                    
                //}
            }
        }


        /// <summary>
        /// Gets or sets the end color of the gradient.
        /// </summary>
        /// <value>The end color of the gradient.</value>
        public Color GradientEndColor
        {
            get { return Maze_gradientEndColor; }
            set
            {
                Maze_gradientEndColor = value;
                //if (Maze_gradientEndColor.ToArgb() != value.ToArgb())
                //{
                //    Maze_gradientEndColor = value;
                //    Maze_gradientColors = null;
                    
                //}
            }
        }

        /// <summary>
        /// Gets or sets the size of the wall.
        /// </summary>
        /// <value>The size of the wall.</value>
        public int WallSize
        {
            get { return Maze_wallSize; }
            set
            {

                Maze_wallSize = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the wall.
        /// </summary>
        /// <value>The color of the wall.</value>
        public Color WallColor
        {
            get { return wallColor; }
            set
            {
                wallColor = value;
                //if (wallColor.ToArgb() != value.ToArgb())
                //{
                //    wallColor = value;
                    
                //}
            }
        }

        /// <summary>
        /// Gets or sets the size of the border.
        /// </summary>
        /// <value>The size of the border.</value>
        public int BorderSize
        {
            get { return Maze_borderSize; }
            set
            {
                Maze_borderSize = value;
                //int v = System.Math.Max(0, value);
                //if (Maze_borderSize != v)
                //{
                //    Maze_borderSize = v;
                //    Maze_borderColors = null;
                    
                //}
            }
        }


        /// <summary>
        /// Gets or sets the color of the maze border.
        /// </summary>
        /// <value>The color of the maze border.</value>
        [DefaultValue("Black")]
        
        public Color Maze_BorderColor
        {
            get { return Maze_borderColor; }
            set
            {
                Maze_borderColor = value;

                //if (Maze_borderColor.ToArgb() != value.ToArgb())
                //{
                //    Maze_borderColor = value;
                //    Maze_borderColors = null;
                    
                //}
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [border gradient].
        /// </summary>
        /// <value><c>true</c> if [border gradient]; otherwise, <c>false</c>.</value>
        public bool BorderGradient
        {
            get { return Maze_borderGradient; }
            set
            {
                Maze_borderGradient = value;

                //if (Maze_borderGradient != value)
                //{
                //    Maze_borderGradient = value;
                //    Maze_borderColors = null;
                    
                //}
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [border round corners].
        /// </summary>
        /// <value><c>true</c> if [border round corners]; otherwise, <c>false</c>.</value>
        public bool BorderRoundCorners
        {
            get { return Maze_borderRoundCorners; }
            set
            {
                Maze_borderRoundCorners = value;

                //if (Maze_borderRoundCorners != value)
                //{
                //    Maze_borderRoundCorners = value;
                    
                //}
            }
        }

        /// <summary>
        /// Gets or sets the color of the maze background.
        /// </summary>
        /// <value>The color of the maze background.</value>
        [DefaultValue("Control")]
        public Color Maze_BackgroundColor
        {
            get { return Maze_unusedColor; }
            set
            {
                Maze_unusedColor = value;
                //if (Maze_unusedColor.ToArgb() != value.ToArgb())
                //{
                //    Maze_unusedColor = value;
                    
                //}
            }
        }

        

        #endregion

    }
}
