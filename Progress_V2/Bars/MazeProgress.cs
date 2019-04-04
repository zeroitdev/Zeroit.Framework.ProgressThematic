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
#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region Maze ProgressBar

    #region Amazing ProgressBar
    /// <summary>
    /// AmazingProgressBar control.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //private ProgressBarStyle Style = System.Windows.Forms.ProgressBarStyle.Continuous;

        //private float MarqueeAnimationSpeed = 100f;
        /// <summary>
        /// The maze
        /// </summary>
        private Maze maze = null;

        /// <summary>
        /// The maze marquee timer
        /// </summary>
        private System.Windows.Forms.Timer Maze_marqueeTimer = null;
        /// <summary>
        /// The maze marquee position
        /// </summary>
        private int Maze_marqueePosition = 0;
        /// <summary>
        /// The maze marquee length
        /// </summary>
        private int Maze_marqueeLength = 0;

        /// <summary>
        /// The maze gradient colors
        /// </summary>
        private Color[] Maze_gradientColors = null;
        /// <summary>
        /// The maze border colors
        /// </summary>
        private Color[] Maze_borderColors = null;

        /// <summary>
        /// The maze row pixels
        /// </summary>
        private int Maze_rowPixels;
        /// <summary>
        /// The maze unused row pixels
        /// </summary>
        private int Maze_unusedRowPixels;
        /// <summary>
        /// The maze unused top pixels
        /// </summary>
        private int Maze_unusedTopPixels;
        /// <summary>
        /// The maze unused bottom pixels
        /// </summary>
        private int Maze_unusedBottomPixels;

        /// <summary>
        /// The maze col pixels
        /// </summary>
        private int Maze_colPixels;
        /// <summary>
        /// The maze unused col pixels
        /// </summary>
        private int Maze_unusedColPixels;
        /// <summary>
        /// The maze unused left pixels
        /// </summary>
        private int Maze_unusedLeftPixels;
        /// <summary>
        /// The maze unused right pixels
        /// </summary>
        private int Maze_unusedRightPixels;

        /// <summary>
        /// The maze inner width
        /// </summary>
        private int Maze_innerWidth;
        /// <summary>
        /// The maze inner height
        /// </summary>
        private int Maze_innerHeight;

        /// <summary>
        /// The g
        /// </summary>
        private Graphics g;

        //private int RowCount = 3;
        /// <summary>
        /// The maze cell size
        /// </summary>
        private int Maze_cellSize = 0;
        /// <summary>
        /// The maze col count
        /// </summary>
        private int Maze_colCount = 0;
        //private MazeStyleType MazeStyle = MazeStyleType.SingleRight;
        //private Maze_GradientType Gradient;
        //private Color GradientStartColor = Color.PaleGreen;
        //private Color GradientEndColor = Color.Lime;
        //private int WallSize = 1;
        //private int BorderSize = 0;
        //private Color Maze_BorderColor = Color.Black;
        //private bool BorderGradient = false;
        //private bool BorderRoundCorners = false;
        //private Color Maze_BackgroundColor = SystemColors.Control;

        //private Color Maze_SolidColor = SystemColors.Highlight;
        #endregion

        #region Timer Event

        /// <summary>
        /// Handles the Tick event of the Maze_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Maze_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //    this.Value = 0;
            //else
            //    this.Value++; 
            #endregion

            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Handles the Tick event of the Maze_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Maze_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.Value < this.Minimum)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Value -= (Change * SpeedMultiplier);
                Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public void ZeroitAmazingProgressBar()
        {
            
            maze = null;
            Maze_marqueeTimer = new System.Windows.Forms.Timer();
            Maze_marqueeTimer.Tick += new System.EventHandler(this.MarqueeTimer_Tick);

            
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the maze solid.
        /// </summary>
        /// <value>The color of the maze solid.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color Maze_SolidColor
        {
            get { return progressInput.Maze_SolidColor; }
            set
            {
                progressInput.Maze_SolidColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the minimum value of the range of the control.
        /// </summary>
        /// <value>The minimum value of the range of the control. The default is 0.</value>
        /// <exception cref="System.ArgumentException">The value specified is less than 0.</exception>
        /// <exception cref="System.ArgumentException">The value specified is less than 0.</exception>
        /// <exception cref="System.ArgumentException">The value specified is greater than the value of the <c>Maximum</c> property, or
        /// the value specified is less than the value of the <c>Minimum</c> property.</exception>
        /// <remarks>Refer to the .NET 2.0 documenation for <c>ProgressBar.Minimum</c> for more information.</remarks>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public new ProgressBarStyle Style
        {
            get { return progressInput.Style; }
            set
            {


                progressInput.Style = value;
                MarqueeUpdate();
                Redraw();
            }
        }

        /// <summary>
        /// Gets or the time period, in milliseconds, that it takes the progress block to scroll across the progress bar.
        /// </summary>
        /// <value>The time period, in milliseconds, that it takes the progress block to scroll across the progress bar.</value>
        /// <exception cref="System.ArgumentOutOfRangeException">The value specified is less than one.</exception>


        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public float MarqueeAnimationSpeed
        {
            get { return progressInput.MarqueeAnimationSpeed; }
            set
            {
                progressInput.MarqueeAnimationSpeed = value;
                MarqueeUpdate();
                Redraw();
            }
        }


        /// <summary>
        /// Gets or sets the number of rows in the maze.
        /// </summary>
        /// <value>The number of rows in the maze.</value>
        /// <exception cref="ArgumentOutOfRangeException">RowCount</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The value specified is less than one.</exception>
        /// <remarks>The size and complexity of the maze generally depends on the this parameter.
        /// A value of 1 results in a maze which looks just like a standard progress bar.
        /// A value of 2 results in a distinctly uninteresting maze.
        /// A value of 3 or more is strongly recommended.</remarks>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int RowCount
        {
            get { return progressInput.RowCount; }
            set
            {
                if (value != progressInput.RowCount)
                {
                    if (value < 1)
                    {
                        throw new ArgumentOutOfRangeException("RowCount");
                    }
                    progressInput.RowCount = value;
                    Regenerate();
                }
            }
        }


        /// <summary>
        /// Gets the number of columns in the maze.
        /// </summary>
        /// <value>The number of columns in the maze.
        /// <para>
        /// This value is determined internally by the class
        /// as the largest possible value given the size of the control,
        /// and the current values of <c>RowCount</c>, <c>WallSize</c> and <c>BorderSize</c>.
        /// </para></value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int ColCount
        {
            get { return Maze_colCount; }
        }

        /// <summary>
        /// Gets the number of cells in the maze.
        /// </summary>
        /// <value>The number of cells in the maze.
        /// Equivalent to <c>RowCount</c> times <c>ColCount</c>.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int CellCount
        {
            get { return RowCount * Maze_colCount; }
        }


        /// <summary>
        /// Gets the pixel size of a cell in the maze.
        /// </summary>
        /// <value>The height and width of each maze cell.
        /// <para>
        /// This value is determined internally by the class given the size of the control,
        /// and the current values of <c>RowCount</c>, <c>ColCount</c>, <c>WallSize</c> and <c>BorderSize</c>.
        /// </para></value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int CellSize
        {
            get { return Maze_cellSize; }
        }

        /// <summary>
        /// Gets the length of the longest path in the maze.
        /// </summary>
        /// <value>The length of the longest path in the maze.
        /// This value will be less than or equal to <c>CellCount</c>.
        /// If the maze has but a single path with no branching, this value will be equal to <c>CellCount</c>.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int PathLength
        {
            get
            {
                if (maze == null)
                {
                    return 0;
                }
                return maze.Paths.GetLength(0);
            }
        }

        /// <summary>
        /// The style and general direction of the maze.
        /// </summary>
        /// <value>The <c>AmazingProgressBar.MazeStyleType</c> value indicating the style and general direction of the maze.</value>
        /// <remarks>The generated mazes do not have loops, and branching is avoided
        /// (though a small amount may occur if <c>RowCount</c> is greater than 3).
        /// The maze directions are the general directions, though
        /// there will be always be twists and turns and some doubling back.</remarks>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public MazeStyleType MazeStyle
        {
            get { return progressInput.MazeStyle; }
            set
            {
                if (value != progressInput.MazeStyle)
                {
                    progressInput.MazeStyle = value;
                    Regenerate();
                }
            }
        }

        /// <summary>
        /// Coloring of filled cells.
        /// </summary>
        /// <value>The <c>AmazingProgressBar.Maze_GradientType</c> value indicating the type of Gradient used for coloring filled cells.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Maze_GradientType Gradient
        {
            get { return progressInput.Gradient; }
            set
            {
                if (value != progressInput.Gradient)
                {
                    progressInput.Gradient = value;
                    Maze_gradientColors = null;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or set the start Gradient color.
        /// </summary>
        /// <value>The start color of the Gradient.
        /// Only used if <c>Gradient</c> is not <c>AmazingProgressBar.Maze_GradientType.None</c>.</value>
        [DefaultValue("PaleGreen")]
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color GradientStartColor
        {
            get { return progressInput.GradientStartColor; }
            set
            {
                if (progressInput.GradientStartColor.ToArgb() != value.ToArgb())
                {
                    progressInput.GradientStartColor = value;
                    Maze_gradientColors = null;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or set the end Gradient color.
        /// </summary>
        /// <value>The end color of the Gradient.
        /// Only used if <c>Gradient</c> is not <c>AmazingProgressBar.Maze_GradientType.None</c>.</value>
        [DefaultValue("PaleGreen")]
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color GradientEndColor
        {
            get { return progressInput.GradientEndColor; }
            set
            {
                if (progressInput.GradientEndColor.ToArgb() != value.ToArgb())
                {
                    progressInput.GradientEndColor = value;
                    Maze_gradientColors = null;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or sets the size of the maze walls.
        /// </summary>
        /// <value>The size of the maze walls in pixels.</value>
        /// <remarks>Combine a wall size of zero and a <c>Style</c> of <c>ProgressBarStyle.Blocks</c> for an
        /// interesting visual effect.</remarks>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int WallSize
        {
            get { return progressInput.WallSize; }
            set
            {
                int v = System.Math.Max(0, value);
                if (progressInput.WallSize != v)
                {
                    progressInput.WallSize = v;
                    Regenerate();
                }
            }
        }

        //private Color WallColor = Color.Black;
        /// <summary>
        /// Gets or set the color of the maze walls.
        /// </summary>
        /// <value>The color of the maze walls.</value>
        /// <remarks>Set the maze wall color to <c>BackColor</c> for an interesting visual effect.</remarks>
        [DefaultValue("Black")]
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color WallColor
        {
            get { return progressInput.WallColor; }
            set
            {
                if (progressInput.WallColor.ToArgb() != value.ToArgb())
                {
                    progressInput.WallColor = value;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or sets the size of the maze border.
        /// </summary>
        /// <value>The size of the maze border in pixels.
        /// The border is drawn around the outside of the maze.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public int BorderSize
        {
            get { return progressInput.BorderSize; }
            set
            {
                int v = System.Math.Max(0, value);
                if (progressInput.BorderSize != v)
                {
                    progressInput.BorderSize = v;
                    Maze_borderColors = null;
                    Regenerate();
                }
            }
        }


        /// <summary>
        /// Gets or sets the color of the maze border.
        /// </summary>
        /// <value>The color of the border.  The border is drawn around the outside of the maze.</value>
        [DefaultValue("Black")]
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color Maze_BorderColor
        {
            get { return progressInput.Maze_BorderColor; }
            set
            {
                if (progressInput.Maze_BorderColor.ToArgb() != value.ToArgb())
                {
                    progressInput.Maze_BorderColor = value;
                    Maze_borderColors = null;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or sets whether the border is drawn as a Gradient.
        /// </summary>
        /// <value><c>True</c> if the border is drawn as a Gradient, <c>false</c> otherwise.
        /// <para>
        /// If <c>true</c>, the border color is a Gradient from <c>Maze_BorderColor</c>
        /// to <c>UnusedColor</c>.
        /// If <c>false</c>, the entire border is <c>Maze_BorderColor</c>.
        /// </para></value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public bool BorderGradient
        {
            get { return progressInput.BorderGradient; }
            set
            {
                if (progressInput.BorderGradient != value)
                {
                    progressInput.BorderGradient = value;
                    Maze_borderColors = null;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or sets whether the border is drawn with round corners.
        /// </summary>
        /// <value><c>True</c> if the border is drawn with round borders, <c>false</c> otherwise.</value>
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public bool BorderRoundCorners
        {
            get { return progressInput.BorderRoundCorners; }
            set
            {
                if (progressInput.BorderRoundCorners != value)
                {
                    progressInput.BorderRoundCorners = value;
                    Redraw();
                }
            }
        }


        /// <summary>
        /// Gets or sets the color of the unused area of the control.
        /// </summary>
        /// <value>The color of the unused area of the control.
        /// Should be left as <c>SystemColors.Control</c>.</value>
        [DefaultValue("Control")]
        [Category("RectangularProgress Maze")]
        [Browsable(false)]
        public Color Maze_BackgroundColor
        {
            get { return progressInput.Maze_BackgroundColor; }
            set
            {
                if (progressInput.Maze_BackgroundColor.ToArgb() != value.ToArgb())
                {
                    progressInput.Maze_BackgroundColor = value;
                    Redraw();
                }
            }
        }

        

        /// <summary>
        /// Represents the method that is called when the maze layout changes.
        /// </summary>
        /// <remarks>The maze layout may change whenever any of the following changes:
        /// the size of the control, <c>RowCount</c>, <c>WallSize</c>, <c>BorderSize</c>, or <c>MazeStyle</c>.
        /// It will also change if <c>Regenerate</c> is called.
        /// But a new maze is not actually generated until painting occurs.
        /// This method is called immediately after a new maze is generated, but
        /// before it is displayed.</remarks>
        public event EventHandler MazeChanged = null;

        /// <summary>
        /// Generate a new maze.
        /// </summary>
		public void Regenerate()
        {
            maze = null;
            Redraw();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Redraws this instance.
        /// </summary>
        private void Redraw()
        {
            Invalidate(true);
        }

        /// <summary>
        /// Mazes the cannot fit.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void MazeCannotFit(PaintEventArgs e)
        {
            Size cs = ClientSize;

            Brush br = new SolidBrush(Color.LightGray);
            e.Graphics.FillRectangle(br, 0, 0, cs.Width, cs.Height);
            br.Dispose();

            br = new HatchBrush(HatchStyle.Wave, Color.Pink);
            e.Graphics.FillRectangle(br, 0, 0, cs.Width, cs.Height);
            br.Dispose();
        }


        /// <summary>
        /// Marquees the update.
        /// </summary>
        private void MarqueeUpdate()
        {
            
            if (Style == System.Windows.Forms.ProgressBarStyle.Marquee && maze != null)
            {
                Maze_marqueeLength = System.Math.Max(PathLength / 6, 1);
                Maze_marqueePosition = -Maze_marqueeLength;
                Maze_marqueeTimer.Interval = System.Math.Max(Convert.ToInt32(MarqueeAnimationSpeed) / PathLength, 5);
                Maze_marqueeTimer.Enabled = true;
            }
            else
            {
                Maze_marqueeTimer.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Tick event of the MarqueeTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            Maze_marqueePosition++;
            if (Maze_marqueePosition - Maze_marqueeLength >= PathLength)
            {
                Maze_marqueePosition = -Maze_marqueeLength;
            }
            Redraw();
        }
        #endregion

        #region Paint


        /// <summary>
        /// Called when paint event is raised.
        /// </summary>
        /// <param name="e">Painting parameters.</param>
        private void Maze_Paint(PaintEventArgs e)
        {
            g = e.Graphics;

            if (allowTransparency)
            {
                MakeTransparent(this, g);
            }

            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

            //g.SmoothingMode = SmoothingMode.HighQuality;
            //g.Clear(BackColor);

            // Is there enough space for maze rows?
            Maze_rowPixels = this.ClientSize.Height;
            Maze_colPixels = this.ClientSize.Width;
            int borderPixels = 2 * BorderSize;

            int rowCellPixels = Maze_rowPixels - (RowCount + 1) * WallSize - borderPixels;
            Maze_cellSize = rowCellPixels / RowCount;
            if (Maze_cellSize < 1)
            {
                MazeCannotFit(e);
                return;
            }

            // How many column cells?
            int colCellPixels = Maze_colPixels - WallSize - borderPixels;
            int newColCount = colCellPixels / (Maze_cellSize + WallSize);
            if (newColCount < 1)
            {
                MazeCannotFit(e);
                return;
            }

            // Need to regen maze?
            if (Maze_colCount != newColCount)
            {
                maze = null;
            }
            Maze_colCount = newColCount;
            if (maze == null)
            {
                switch (MazeStyle)
                {
                    case MazeStyleType.SingleRight: maze = MazeSinglePath.Generate(RowCount, Maze_colCount, Maze.Dir.E); break;
                    case MazeStyleType.SingleLeft: maze = MazeSinglePath.Generate(RowCount, Maze_colCount, Maze.Dir.W); break;
                    case MazeStyleType.SingleUp: maze = MazeSinglePath.Generate(RowCount, Maze_colCount, Maze.Dir.N); break;
                    case MazeStyleType.SingleDown: maze = MazeSinglePath.Generate(RowCount, Maze_colCount, Maze.Dir.S); break;

                    case MazeStyleType.SplitConvergeHorizontal: maze = MazeSplitPath.Generate(RowCount, Maze_colCount, MazeSplitPath.PathType.ConvergeEW); break;
                    case MazeStyleType.SplitConvergeVertical: maze = MazeSplitPath.Generate(RowCount, Maze_colCount, MazeSplitPath.PathType.ConvergeNS); break;
                    case MazeStyleType.SplitDivergeHorizontal: maze = MazeSplitPath.Generate(RowCount, Maze_colCount, MazeSplitPath.PathType.DivergeEW); break;
                    case MazeStyleType.SplitDivergeVertical: maze = MazeSplitPath.Generate(RowCount, Maze_colCount, MazeSplitPath.PathType.DivergeNS); break;
                }
                if (MazeChanged != null)
                {
                    MazeChanged(this, null);
                }
                Maze_gradientColors = null;
                MarqueeUpdate();
            }

            // All cells are square - so might have "unused" pixels left over
            Maze_unusedRowPixels = Maze_rowPixels - (RowCount * Maze_cellSize) - ((RowCount + 1) * WallSize) - borderPixels;
            Maze_unusedTopPixels = Maze_unusedRowPixels / 2;
            Maze_unusedBottomPixels = Maze_unusedRowPixels - Maze_unusedTopPixels;

            Maze_unusedColPixels = Maze_colPixels - (Maze_colCount * Maze_cellSize) - ((Maze_colCount + 1) * WallSize) - borderPixels;
            Maze_unusedLeftPixels = Maze_unusedColPixels / 2;
            Maze_unusedRightPixels = Maze_unusedColPixels - Maze_unusedLeftPixels;

            Maze_innerWidth = Maze_colPixels - Maze_unusedColPixels - borderPixels;
            Maze_innerHeight = Maze_rowPixels - Maze_unusedRowPixels - borderPixels;

            // 1. Fill with unused color
            Brush br = new SolidBrush(Maze_BackgroundColor);
            g.FillRectangle(br, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            //br.Dispose();

            // 2. Fill inside with background color
            br = new SolidBrush(base.BackColor);
            g.FillRectangle(br, Maze_unusedLeftPixels + BorderSize,
                                Maze_unusedTopPixels + BorderSize,
                                Maze_colPixels - Maze_unusedColPixels - borderPixels,
                                Maze_rowPixels - Maze_unusedRowPixels - borderPixels);
            //br.Dispose();

            // 3. Fill cells
            FillCells();

            // 4. Draw walls
            DrawWalls();

            // 5. Draw borders
            DrawBorder();

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), ClientRectangle);
            }
        }

        /// <summary>
        /// Draws the border.
        /// </summary>
        private void DrawBorder()
        {
            if (BorderSize <= 0)
            {
                return;
            }

            GenerateBorderColors();

            // Draw borders inside to out
            int x = Maze_unusedLeftPixels + BorderSize - 1;
            int width = Maze_colPixels - Maze_unusedColPixels - 2 * BorderSize + 1;
            int y = Maze_unusedTopPixels + BorderSize - 1;
            int height = Maze_rowPixels - Maze_unusedRowPixels - 2 * BorderSize + 1;

            int bf = (BorderSize > 1 && BorderRoundCorners) ? (BorderSize - 1) : 0;

            for (int i = 0; i < BorderSize; i++)
            {
                Pen pen = new Pen(Maze_borderColors[i]);
                if (BorderRoundCorners)
                {
                    g.DrawLine(pen, x, y + i + bf + 1, x, y + height - i - bf - 1);
                    g.DrawLine(pen, x + width, y + i + bf + 1, x + width, y + height - i - bf - 1);
                    g.DrawLine(pen, x + i + bf + 1, y, x + width - i - bf - 1, y);
                    g.DrawLine(pen, x + i + bf + 1, y + height, x + width - i - bf - 1, y + height);

                    Pen arcPen = new Pen(Maze_borderColors[i], (i == 0 || i == (BorderSize - 1)) ? 1.0f : 2.0f);

                    int size = 2 * (i + bf + 1);
                    g.DrawArc(arcPen, x, y, size, size, 180, 90);
                    g.DrawArc(arcPen, x, y + height - size, size, size, 90, 90);
                    g.DrawArc(arcPen, x + width - size, y, size, size, 270, 90);
                    g.DrawArc(arcPen, x + width - size, y + height - size, size, size, 0, 90);
                    arcPen.Dispose();
                }
                else
                {
                    g.DrawRectangle(pen, x, y, width, height);
                }
                //pen.Dispose();
                x--; width += 2;
                y--; height += 2;
            }
        }

        /// <summary>
        /// Generates the border colors.
        /// </summary>
        private void GenerateBorderColors()
        {
            if (Maze_borderColors != null || BorderSize == 0)
            {
                return;
            }

            Maze_borderColors = new Color[BorderSize];
            Maze_borderColors[0] = Maze_BorderColor;

            if (BorderSize > 1)
            {
                float dA = BorderGradient ? (float)(Maze_BackgroundColor.A - Maze_BorderColor.A) / (float)BorderSize : 0.0f;
                float dR = BorderGradient ? (float)(Maze_BackgroundColor.R - Maze_BorderColor.R) / (float)BorderSize : 0.0f;
                float dG = BorderGradient ? (float)(Maze_BackgroundColor.G - Maze_BorderColor.G) / (float)BorderSize : 0.0f;
                float dB = BorderGradient ? (float)(Maze_BackgroundColor.B - Maze_BorderColor.B) / (float)BorderSize : 0.0f;

                for (int i = 1; i < BorderSize; i++)
                {
                    Maze_borderColors[i] = Color.FromArgb((int)((float)Maze_BorderColor.A + dA * (float)i),
                                                     (int)((float)Maze_BorderColor.R + dR * (float)i),
                                                     (int)((float)Maze_BorderColor.G + dG * (float)i),
                                                     (int)((float)Maze_BorderColor.B + dB * (float)i));

                }
            }
        }

        /// <summary>
        /// Generates the gradient colors.
        /// </summary>
        private void GenerateGradientColors()
        {
            if (Maze_gradientColors != null || Gradient == Maze_GradientType.None)
            {
                return;
            }

            int gradCount = 0;
            switch (Gradient)
            {
                case Maze_GradientType.Rows: gradCount = RowCount; break;
                case Maze_GradientType.Columns: gradCount = ColCount; break;
                case Maze_GradientType.Flow: gradCount = PathLength; break;
            }

            Maze_gradientColors = new Color[gradCount];

            Maze_gradientColors[0] = GradientStartColor;
            Maze_gradientColors[gradCount - 1] = GradientEndColor;

            if (gradCount > 2)
            {
                float dA = (float)(GradientEndColor.A - GradientStartColor.A) / (float)(gradCount - 1);
                float dR = (float)(GradientEndColor.R - GradientStartColor.R) / (float)(gradCount - 1);
                float dG = (float)(GradientEndColor.G - GradientStartColor.G) / (float)(gradCount - 1);
                float dB = (float)(GradientEndColor.B - GradientStartColor.B) / (float)(gradCount - 1);

                for (int i = 1; i < (gradCount - 1); i++)
                {
                    Maze_gradientColors[i] = Color.FromArgb((int)((float)GradientStartColor.A + dA * (float)i),
                                                       (int)((float)GradientStartColor.R + dR * (float)i),
                                                       (int)((float)GradientStartColor.G + dG * (float)i),
                                                       (int)((float)GradientStartColor.B + dB * (float)i));
                }
            }
        }

        /// <summary>
        /// Fills the cells.
        /// </summary>
        private void FillCells()
        {
            if (Maximum <= Minimum || Value < Minimum) // sanity checks
            {
                return;
            }

            int startIndex = 0;
            int endIndex = 0;

            if (Style == System.Windows.Forms.ProgressBarStyle.Marquee)
            {
                startIndex = System.Math.Max(0, Maze_marqueePosition - Maze_marqueeLength);
                endIndex = System.Math.Min(PathLength - 1, Maze_marqueePosition + Maze_marqueeLength);
            }
            else
            {
                // How many cells to fill?
                float cellsPerStep = (float)PathLength / (float)(Maximum - Minimum);
                int filledCells = (int)Math.Floor(cellsPerStep * (Value - Minimum));
                if (filledCells == 0)
                {
                    return;
                }
                if (Value >= Maximum) // another sanity check
                {
                    filledCells = PathLength;
                }
                endIndex = filledCells - 1;
            }
            FillCells(startIndex, endIndex);
        }

        /// <summary>
        /// Fills the cells.
        /// </summary>
        /// <param name="startIndex">The start index.</param>
        /// <param name="endIndex">The end index.</param>
        private void FillCells(int startIndex, int endIndex)
        {
            GenerateGradientColors();

            int cellWidening = 0;
            int cellOffset = 0;
            if (Style == System.Windows.Forms.ProgressBarStyle.Continuous
                || Style == System.Windows.Forms.ProgressBarStyle.Marquee)
            {
                cellWidening = (WallSize + 1) / 2;
            }
            else if (Maze_cellSize > 2)
            {
                cellOffset = 0;
                cellWidening = -1;
            }
            int cellFullSize = Maze_cellSize + 2 * cellWidening;

            Brush br = new SolidBrush(Maze_SolidColor);

            int skip = Maze_cellSize + WallSize;

            int colConst = Maze_unusedLeftPixels + BorderSize + WallSize - cellWidening + cellOffset;
            int rowConst = Maze_unusedTopPixels + BorderSize + WallSize - cellWidening + cellOffset;

            for (int ci = startIndex; ci <= endIndex; ci++)
            {
                Maze.Cell[] cells = maze.Paths[ci];

                foreach (Maze.Cell cell in cells)
                {
                    if (Gradient != Maze_GradientType.None)
                    {
                        Color color = Color.Empty;
                        switch (Gradient)
                        {
                            case Maze_GradientType.Rows: color = Maze_gradientColors[cell.Row]; break;
                            case Maze_GradientType.Columns: color = Maze_gradientColors[cell.Col]; break;
                            case Maze_GradientType.Flow: color = Maze_gradientColors[ci]; break;
                        }
                        br.Dispose();
                        br = new SolidBrush(color);
                    }

                    int x = colConst + cell.Col * skip;
                    int y = rowConst + cell.Row * skip;
                    g.FillRectangle(br, x, y, cellFullSize, cellFullSize);
                }
            }

            br.Dispose();
        }


        /// <summary>
        /// Draws the walls.
        /// </summary>
        private void DrawWalls()
        {
            if (WallSize < 1)
            {
                return;
            }

            Brush br = new SolidBrush(WallColor);

            int edgeWidth = Maze_colCount * (Maze_cellSize + WallSize) + WallSize;
            int edgeHeight = RowCount * (Maze_cellSize + WallSize) + WallSize;

            // Draw north-most wall
            g.FillRectangle(br, Maze_unusedLeftPixels + BorderSize,
                                Maze_unusedTopPixels + BorderSize,
                                edgeWidth,
                                WallSize);

            // Draw south-most wall
            g.FillRectangle(br, Maze_unusedLeftPixels + BorderSize,
                                Maze_rowPixels - Maze_unusedBottomPixels - BorderSize - WallSize,
                                edgeWidth,
                                WallSize);

            // Draw west-most wall
            g.FillRectangle(br, Maze_unusedLeftPixels + BorderSize,
                                Maze_unusedTopPixels + BorderSize,
                                WallSize,
                                edgeHeight);

            // Draw east-most wall
            g.FillRectangle(br, Maze_colPixels - Maze_unusedRightPixels - BorderSize - WallSize,
                                Maze_unusedTopPixels + BorderSize,
                                WallSize,
                                edgeHeight);

            // Draw south walls (except for last row)
            int y = Maze_unusedTopPixels + BorderSize + WallSize + Maze_cellSize;
            int dx = WallSize + Maze_cellSize + WallSize;
            int dy = WallSize;
            int skip = Maze_cellSize + WallSize;
            for (int r = 0; r < RowCount - 1; r++)
            {
                int x = Maze_unusedLeftPixels + BorderSize;
                for (int c = 0; c < Maze_colCount; c++)
                {
                    if ((maze.Map[r, c] & Maze.Dir.S) != Maze.Dir.S)
                    {
                        g.FillRectangle(br, x, y, dx, dy);
                    }
                    x += skip;
                }
                y += skip;
            }

            // Draw east walls (except for last col)
            y = Maze_unusedTopPixels + BorderSize;
            dx = WallSize;
            dy = WallSize + Maze_cellSize + WallSize;
            for (int r = 0; r < RowCount; r++)
            {
                int x = Maze_unusedLeftPixels + BorderSize + WallSize + Maze_cellSize;
                for (int c = 0; c < Maze_colCount - 1; c++)
                {
                    if ((maze.Map[r, c] & Maze.Dir.E) != Maze.Dir.E)
                    {
                        g.FillRectangle(br, x, y, dx, dy);
                    }
                    x += skip;
                }
                y += skip;
            }

            br.Dispose();
        }
        #endregion

    }
    #endregion

    #region Maze

    partial class ZeroitThematicProgress
    {
        /// <summary>
        /// Represesents a maze enclosed by a rectanglar area.
        /// </summary>
        /// <remarks>A maze is composed of a <c>map</c> and a <c>path</c>.
        /// The map defines the structure of the maze, that is, the location of all the walls.
        /// The path defines the order in which the maze is filled while used in a progress bar.
        /// For any given map, there are numerous possible paths.
        /// <para>
        /// Maze and map sizes are given as rows and columns.
        /// Row indexes are zero based starting at the top.
        /// Column indexes are zero based starting at the left.
        /// </para></remarks>
		public class Maze
        {
            /// <summary>
            /// Movement direction flags.
            /// </summary>
            [Flags]
            public enum Dir
            {
                /// <summary>
                /// No movement.  Used to indicate an empty, or unassigned cell.
                /// </summary>
                None = 0x00,

                /// <summary>
                /// Can go north (up).
                /// </summary>
                N = 0x01,

                /// <summary>
                /// Can go east (right).
                /// </summary>
                E = 0x02,

                /// <summary>
                /// Can go south (down).
                /// </summary>
                S = 0x04,

                /// <summary>
                /// Can go west (left).
                /// </summary>
                W = 0x08,

                /// <summary>
                /// Mask representing all four direction (N, E, S, W).
                /// </summary>
                All = 0x0F,

                /// <summary>
                /// Mapped flag - used internally for generating paths.
                /// </summary>
                MAP = 0x80
            };

            /// <summary>
            /// Helper method to determine the opposite of a given direction.
            /// </summary>
            /// <param name="dir">Direction</param>
            /// <returns>Opposite direction</returns>
			public static Dir Opposite(Dir dir)
            {
                switch (dir)
                {
                    case Dir.N: return Dir.S;
                    case Dir.E: return Dir.W;
                    case Dir.S: return Dir.N;
                    case Dir.W: return Dir.E;
                }
                return Dir.None;
            }

            /// <summary>
            /// Represents the coordinates of a single cell in a maze.
            /// </summary>
			public class Cell
            {
                /// <summary>
                /// Copy constructor.
                /// </summary>
                /// <param name="cell">Cell to copy.</param>
                /// <exception cref="ArgumentNullException">cell</exception>
                /// <exception cref="System.ArgumentNullException">Thrown if <c>cell</c> is null.</exception>
                public Cell(Cell cell)
                {
                    if (cell == null)
                    {
                        throw new ArgumentNullException("cell");
                    }
                    Row = cell.Row;
                    Col = cell.Col;
                }

                /// <summary>
                /// Constructor using given coordinates.
                /// </summary>
                /// <param name="row">Row coordinate</param>
                /// <param name="col">Column coordinate</param>
                public Cell(int row, int col)
                {
                    Row = row;
                    Col = col;
                }

                /// <summary>
                /// Constructor using coordinates of given cell after direction applied.
                /// Constucted object has coordinates of <c>cell</c> after movement of one step in direction <c>dir</c>.
                /// </summary>
                /// <param name="cell">Cell coordinate to copy.</param>
                /// <param name="dir">Direction to move.</param>
                public Cell(Cell cell, Dir dir) : this(cell.Row, cell.Col, dir)
                { }

                /// <summary>
                /// Constructor using given coordinates after direction applied.
                /// Constucted object has coordinates of <c>row</c>, <c>col</c> after movement of one step in direction <c>dir</c>.
                /// </summary>
                /// <param name="row">Start row coordinate.</param>
                /// <param name="col">Start column coordinate.</param>
                /// <param name="dir">Direction to move.</param>
                /// <exception cref="ArgumentException">dir not one of N,E,S,W</exception>
				public Cell(int row, int col, Dir dir)
                {
                    switch (dir)
                    {
                        case Dir.N: Row = row - 1; Col = col; break;
                        case Dir.E: Row = row; Col = col + 1; break;
                        case Dir.S: Row = row + 1; Col = col; break;
                        case Dir.W: Row = row; Col = col - 1; break;
                        default:
                            {
                                throw new ArgumentException("dir not one of N,E,S,W");
                            }
                    }
                }

                /// <summary>
                /// Row in maze. The range is [0, number of rows - 1].
                /// Row zero is the top row.
                /// </summary>
                public readonly int Row;

                /// <summary>
                /// Column in maze. The range is [0, number of rows - 1].
                /// Column zero is the left column.
                /// </summary>
                public readonly int Col;

                /// <summary>
                /// String representation of cell.
                /// </summary>
                /// <returns>String.</returns>
                public override string ToString()
                {
                    return string.Format("Cell R={0} C={1}");
                }

                /// <summary>
                /// Compares this Cell with another object.
                /// </summary>
                /// <param name="o">Other object.</param>
                /// <returns><c>True</c> if <c>o</c> is not null, is a <c>Cell</c>, and has the same coordinate as <c>this</c>. <c>False</c> otherwise.</returns>
                public override bool Equals(object o)
                {
                    if (o == null)
                    {
                        return false;
                    }
                    Cell co = o as Cell;
                    if ((object)co == null)
                    {
                        return false;
                    }
                    return (co.Row == Row) && (co.Col == Col);
                }

                /// <summary>
                /// Calculates hashcode for this object.
                /// </summary>
                /// <returns>Hashcode.</returns>
                public override int GetHashCode()
                {
                    return Row ^ Col;
                }
            }

            /// <summary>
            /// Constructor using two-dimensional array of <c>Dir</c> values, and starting coordinates.
            /// </summary>
            /// <param name="map">Valid movement directions for each cell; first dimension is row index; second dimension is column index.</param>
            /// <param name="startRow">Row coordinate of starting cell.</param>
            /// <param name="startCol">Column coordinate of starting cell.</param>
            public Maze(Dir[,] map, int startRow, int startCol) : this(map, new Cell(startRow, startCol))
            { }

            /// <summary>
            /// Constructor using 2D array of <c>Dir</c> values, and starting cell.
            /// </summary>
            /// <param name="map">Valid movement directions for each cell; first dimension is row index; second dimension is column index.</param>
            /// <param name="startCell">Starting cell.</param>
            public Maze(Dir[,] map, Cell startCell) : this(map, new Cell[1] { startCell })
            { }

            /// <summary>
            /// Constructor using 2D array of <c>Dir</c> values, and list of starting cells.
            /// </summary>
            /// <param name="map">Valid movement directions for each cell; first dimension is row index; second dimension is column index.</param>
            /// <param name="startCells">List of starting cells.</param>
            /// <exception cref="ArgumentNullException">
            /// map
            /// or
            /// startCells
            /// </exception>
            /// <exception cref="ArgumentException">
            /// map has a zero length dimension
            /// or
            /// startCells.Length is zero; must be 1+
            /// </exception>
            /// <exception cref="System.ArgumentNullException">Thrown if <c>map</c> or <c>startCells</c> is null.</exception>
            /// <exception cref="System.ArgumentNullException">Thrown if either dimension of <c>map</c> is less than one, length of <c>startCells</c> is less than one,
            /// or <c>startCells</c> contains any invalid or repeating cells.</exception>
            public Maze(Dir[,] map, Cell[] startCells)
            {
                if (map == null)
                {
                    throw new ArgumentNullException("map");
                }
                if (map.GetLength(0) == 0 || map.GetLength(1) == 0)
                {
                    throw new ArgumentException("map has a zero length dimension");
                }
                if (startCells == null)
                {
                    throw new ArgumentNullException("startCells");
                }
                if (startCells.Length == 0)
                {
                    throw new ArgumentException("startCells.Length is zero; must be 1+");
                }

                Map = map;

                // Turn off all non-NSEW flags
                for (int r = 0; r < Rows; r++)
                {
                    for (int c = 0; c < Cols; c++)
                    {
                        Map[r, c] &= Dir.All;
                    }
                }

                Paths = GeneratePaths(startCells);
            }

            /// <summary>
            /// Map of the maze.
            /// <para>
            /// Each entry represents one cell in the maze, with the values
            /// indicating the direction(s) one can move from that cell.
            /// The first dimension is the rows.  The second dimenion is columns.
            /// </para><para>
            /// For example, from cell with the value <c>Dir.N | Dir.E</c>, one
            /// could move north or east, but not south or west.
            /// </para>
            /// </summary>
            public readonly Dir[,] Map;

            /// <summary>
            /// Paths through the maze.
            /// <para>
            /// The first dimension is the number of steps from the nearest starting cell.
            /// The second dimension are all the cells at that distance.
            /// Each reachable cell occurs once and only once in this array.
            /// </para><para>
            /// For example, <c>Paths[0]</c> is the list of start cells specified in the constructor,
            /// and <c>Paths[1}</c> is the list of a cells one step from a start cell.
            /// </para>
            /// </summary>
            public readonly Cell[][] Paths;

            /// <summary>
            /// Number of rows in the maze (1+).
            /// </summary>
            /// <value>The rows.</value>
            public int Rows
            {
                get { return Map.GetLength(0); }
            }

            /// <summary>
            /// Number of columns in the maze (1+).
            /// </summary>
            /// <value>The cols.</value>
            public int Cols
            {
                get { return Map.GetLength(1); }
            }

            /// <summary>
            /// Test if a cell is valid.
            /// </summary>
            /// <param name="cell">Cell to test.</param>
            /// <returns><c>True</c> if <c>cell</c> is not <c>null</c> and whose coordinates are within this maze, <c>false</c> otherwise.</returns>
            public bool Valid(Cell cell)
            {
                if (cell == null)
                {
                    return false;
                }
                return Valid(cell.Row, cell.Col);
            }

            /// <summary>
            /// Test if coordinates are within this maze.
            /// </summary>
            /// <param name="row">Row coordinate.</param>
            /// <param name="col">Column coordinate.</param>
            /// <returns><c>True</c> if the coordinates are within this maze, <c>false</c> otherwise.</returns>
            public bool Valid(int row, int col)
            {
                return (row >= 0) && (row < Rows) && (col >= 0) && (col < Cols);
            }

            /// <summary>
            /// Generates the paths.
            /// </summary>
            /// <param name="startCells">The start cells.</param>
            /// <returns>Cell[][].</returns>
            /// <exception cref="ArgumentException">
            /// </exception>
            private Cell[][] GeneratePaths(Cell[] startCells)
            {
                // Make sure all startCells entries are unique
                for (int c = 0; c < startCells.Length; c++)
                {
                    if (!Valid(startCells[c]))
                    {
                        throw new ArgumentException(string.Format("startCells entry [{0}] invalid cell", c));
                    }
                    for (int cc = c + 1; cc < startCells.Length; cc++)
                    {
                        if (startCells[c].Equals(startCells[cc]))
                        {
                            throw new ArgumentException(string.Format("startCells entries [{0}] and [{1}] are equivalent", c, cc));
                        }
                    }
                }

                // Build path array
                // The 1st rank is the progress bar step count, or distance from the nearest starting cell.
                // The 2nd rank is the number of cells at that step.
                //
                // As each cells is assigned to the path, set the MAP bit to prevent returning to a cell twice.

                List<Maze.Cell[]> paths = new List<Maze.Cell[]>();
                List<Cell> curCells = new List<Cell>();

                // Add first cells
                for (int i = 0; i < startCells.Length; i++)
                {
                    curCells.Add(new Cell(startCells[i]));
                    Map[startCells[i].Row, startCells[i].Col] |= Dir.MAP;
                }
                paths.Add(curCells.ToArray());

                Dir[] map = new Dir[] { Dir.N, Dir.E, Dir.S, Dir.W };

                // Keep looping until curCells list is empty
                while (curCells.Count > 0)
                {
                    List<Cell> newCurCells = new List<Cell>();

                    // For each curCell, check all possible directions, and if can go that
                    // direction, and the cell is not MAPped, then add that cell to the next cur list.
                    foreach (Cell curCell in curCells)
                    {
                        foreach (Dir dir in map)
                        {
                            if ((Map[curCell.Row, curCell.Col] & dir) == dir)
                            {
                                Maze.Cell newCell = new Maze.Cell(curCell, dir);
                                if ((Map[newCell.Row, newCell.Col] & Dir.MAP) != Dir.MAP)
                                {
                                    Map[newCell.Row, newCell.Col] |= Dir.MAP;
                                    newCurCells.Add(newCell);
                                }
                            }
                        }
                    }
                    paths.Add(newCurCells.ToArray());

                    curCells = newCurCells;
                }

                return paths.ToArray();
            }
        }
    }
    #endregion

    #region Maze Single Path

    partial class ZeroitThematicProgress
    {
        /// <summary>
        /// Static class to generate a simple maze with a (mostly) single path.
        /// </summary>
        public static class MazeSinglePath
        {
            /// <summary>
            /// Generate a single path maze using the system default random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of maze flow.</param>
            /// <returns>Generated maze.</returns>
			public static Maze Generate(int rows, int cols, Maze.Dir direction)
            {
                return Generate(rows, cols, direction, new Random());
            }

            /// <summary>
            /// Generate a single path maze using the given seed for the random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of maze flow.</param>
            /// <param name="randomSeed">Seed for random number generator.</param>
            /// <returns>Generated maze.</returns>
            public static Maze Generate(int rows, int cols, Maze.Dir direction, int randomSeed)
            {
                return Generate(rows, cols, direction, new Random(randomSeed));
            }

            /// <summary>
            /// Generate a single path maze.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of maze flow.</param>
            /// <param name="random">Random number generator.</param>
            /// <returns>Generated maze.</returns>
            public static Maze Generate(int rows, int cols, Maze.Dir direction, Random random)
            {
                Maze.Cell firstCell;
                Maze.Cell lastCell;

                Maze.Dir[,] map = SimpleMap.Generate(rows, cols, direction, random, out firstCell, out lastCell);
                Maze maze = new Maze(map, firstCell);
                return maze;
            }
        }
    }

    #endregion

    #region Maze Split Path

    partial class ZeroitThematicProgress
    {
        /// <summary>
        /// Static class to generate a simple map maze but using converging or diverging paths.
        /// </summary>
        public static class MazeSplitPath
        {
            /// <summary>
            /// Type of maze path.
            /// </summary>
            public enum PathType
            {
                /// <summary>
                /// Start at East and West ends, converging in the middle.
                /// </summary>
                ConvergeEW,

                /// <summary>
                /// Start at North and South ends, converging in the middle.
                /// </summary>
                ConvergeNS,

                /// <summary>
                /// Start in the middle, ending in the East and West ends.
                /// </summary>
                DivergeEW,

                /// <summary>
                /// Start in the middle, ending in the North and South ends.
                /// </summary>
                DivergeNS
            };

            /// <summary>
            /// Generate a split path maze using the system default random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="pathType">Type of maze path.</param>
            /// <returns>Generated maze.</returns>
			public static Maze Generate(int rows, int cols, PathType pathType)
            {
                return Generate(rows, cols, pathType, new Random());
            }

            /// <summary>
            /// Generate a split path maze using the given seed for the random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="pathType">Type of maze path.</param>
            /// <param name="randomSeed">Seed for random number generator.</param>
            /// <returns>Generated maze.</returns>
            public static Maze Generate(int rows, int cols, PathType pathType, int randomSeed)
            {
                return Generate(rows, cols, pathType, new Random(randomSeed));
            }

            /// <summary>
            /// Generate a split path maze.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="pathType">Type of maze path.</param>
            /// <param name="random">Random number generator.</param>
            /// <returns>Generated maze.</returns>
            public static Maze Generate(int rows, int cols, PathType pathType, Random random)
            {
                // If pathType is EW, randomly pick an E/W direction
                // Correspondingly, if pathType is NS, randomly pick a N/S direction.
                Maze.Dir direction;
                int rnd = random.Next(2);
                if (pathType == PathType.ConvergeEW || pathType == PathType.DivergeEW)
                {
                    direction = (rnd == 0) ? Maze.Dir.E : Maze.Dir.W;
                }
                else
                {
                    direction = (rnd == 0) ? Maze.Dir.N : Maze.Dir.S;
                }

                Maze.Cell firstCell;
                Maze.Cell lastCell;
                Maze.Dir[,] map = SimpleMap.Generate(rows, cols, direction, random, out firstCell, out lastCell);

                Maze.Cell[] startCells;
                if (pathType == PathType.DivergeEW || pathType == PathType.DivergeNS)
                {
                    startCells = new Maze.Cell[1];
                    startCells[0] = new Maze.Cell(rows / 2, cols / 2);
                }
                else
                {
                    startCells = new Maze.Cell[2];
                    startCells[0] = firstCell;
                    startCells[1] = lastCell;
                }

                Maze maze = new Maze(map, startCells);
                return maze;
            }
        }
    }

    #endregion

    #region Simple Map


    partial class ZeroitThematicProgress
    {
        /// <summary>
        /// Static class to generate a simple map.
        /// </summary>
        /// <remarks>Refer to the <c>Maze</c> class for a discussion of maps, paths, and mazes.</remarks>
        public static class SimpleMap
        {
            /// <summary>
            /// Generate a single map using the system default random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of map flow.</param>
            /// <param name="firstCell">Cell where map generation began.</param>
            /// <param name="lastCell">Cell where map generation ended.</param>
            /// <returns>Generated map.</returns>
            public static Maze.Dir[,] Generate(int rows, int cols, Maze.Dir direction,
                                                 out Maze.Cell firstCell, out Maze.Cell lastCell)
            {
                return Generate(rows, cols, direction, new Random(), out firstCell, out lastCell);
            }

            /// <summary>
            /// Generate a simple map using the given seed for the random number generator.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of map flow.</param>
            /// <param name="randomSeed">Seed for random number generator.</param>
            /// <param name="firstCell">Cell where map generation began.</param>
            /// <param name="lastCell">Cell where map generation ended.</param>
            /// <returns>Generated map.</returns>
            public static Maze.Dir[,] Generate(int rows, int cols, Maze.Dir direction, int randomSeed,
                                                 out Maze.Cell firstCell, out Maze.Cell lastCell)
            {
                return Generate(rows, cols, direction, new Random(randomSeed), out firstCell, out lastCell);
            }

            /// <summary>
            /// Generate a simple map.
            /// </summary>
            /// <param name="rows">Number of rows.</param>
            /// <param name="cols">Number of columns.</param>
            /// <param name="direction">Primary direction of map flow.</param>
            /// <param name="random">Random number generator.</param>
            /// <param name="firstCell">Cell where map generation began.</param>
            /// <param name="lastCell">Cell where map generation ended.</param>
            /// <returns>Generated map.</returns>
            /// <exception cref="ArgumentException">
            /// rows
            /// or
            /// cols
            /// </exception>
            /// <exception cref="ArgumentNullException">random</exception>
            public static Maze.Dir[,] Generate(int rows, int cols, Maze.Dir direction, Random random,
                                                 out Maze.Cell firstCell, out Maze.Cell lastCell)
            {
                firstCell = null;
                lastCell = null;

                if (rows < 1)
                {
                    throw new ArgumentException("rows");
                }
                if (cols < 1)
                {
                    throw new ArgumentException("cols");
                }
                if (random == null)
                {
                    throw new ArgumentNullException("random");
                }

                int maxRow = rows - 1;
                int maxCol = cols - 1;
                Maze.Dir[,] map = new Maze.Dir[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        map[r, c] = Maze.Dir.None;
                    }
                }

                // Following are the rules for generating a simple map.
                //
                // The directions are F(orward), B(ackward) and S(ideways).
                // What they actually are depends on the direction parameter.
                // For example, if direction == Right, then forward is East, backward is West,
                // and sideways is north or south.
                //
                // Start at one of the most backward corner cells.  Until stuck, use the following rules (in order) to determine
                // the next cell:
                // 1. If can only go in one direction, go in that direction.
                // 2. If we can go backward, go backward.
                // 3. If there is only one empty cell in a sideways direction, go in that direction,
                // 4. If more than one empty cell in both of the sideways directions, randomly pick one of those directions
                // 5. Pick a random direction from the ones available; but only allowed to go forward if
                //      (a) at a sideways edge, and
                //      (b) more than two steps from the forward most end, and
                //      (c) back most filled column is not more than three steps backward

                Maze.Dir dirFor = direction;
                Maze.Dir dirBack = Maze.Opposite(direction);
                Maze.Dir dirSide1 = Maze.Dir.None;
                Maze.Dir dirSide2 = Maze.Dir.None;

                int startRow = -1;
                int startCol = -1;
                int rnd = random.Next(2);

                int backSize = 0;
                int backVal = 0;

                switch (direction)
                {
                    case Maze.Dir.E:
                        dirSide1 = Maze.Dir.N; dirSide2 = Maze.Dir.S;
                        startRow = (rnd == 0) ? 0 : maxRow;
                        startCol = 0;
                        backSize = rows;
                        backVal = -1;
                        break;

                    case Maze.Dir.W:
                        dirSide1 = Maze.Dir.N; dirSide2 = Maze.Dir.S;
                        startRow = (rnd == 0) ? 0 : maxRow;
                        startCol = maxCol;
                        backSize = rows;
                        backVal = cols;
                        break;

                    case Maze.Dir.N:
                        dirSide1 = Maze.Dir.E; dirSide2 = Maze.Dir.W;
                        startRow = maxRow;
                        startCol = (rnd == 0) ? 0 : maxCol;
                        backSize = cols;
                        backVal = -1;
                        break;

                    case Maze.Dir.S:
                        dirSide1 = Maze.Dir.E; dirSide2 = Maze.Dir.W;
                        startRow = 0;
                        startCol = (rnd == 0) ? 0 : maxCol;
                        backSize = cols;
                        backVal = rows;
                        break;
                }

                // Use this array to track rows/cols which are falling behind
                int[] backMost = new int[backSize];
                for (int b = 0; b < backSize; b++)
                {
                    backMost[b] = backVal;
                }

                // Starting cell
                firstCell = new Maze.Cell(startRow, startCol);
                Maze.Cell cur = new Maze.Cell(startRow, startCol);
                int emptyCells = rows * cols - 1;

                // Keep going until we get stuck
                while (true)
                {
                    // Update backMost array
                    switch (direction)
                    {
                        case Maze.Dir.E: backMost[cur.Row] = System.Math.Max(backMost[cur.Row], cur.Col); break;
                        case Maze.Dir.W: backMost[cur.Row] = System.Math.Min(backMost[cur.Row], cur.Col); break;
                        case Maze.Dir.N: backMost[cur.Col] = System.Math.Max(backMost[cur.Col], cur.Row); break;
                        case Maze.Dir.S: backMost[cur.Col] = System.Math.Min(backMost[cur.Col], cur.Row); break;
                    }

                    Maze.Dir dir = Maze.Dir.None;

                    // Count # of steps that can be travelled in each the directions
                    // If 2 or more steps, just list as 2
                    int numFor = CountCanGo(map, cur, dirFor);
                    int numBack = CountCanGo(map, cur, dirBack);
                    int numSide1 = CountCanGo(map, cur, dirSide1);
                    int numSide2 = CountCanGo(map, cur, dirSide2);

                    // 1. If can only go one direction, then dude, that is the direction we go
                    if (numFor > 0 && (numBack + numSide1 + numSide2 == 0))
                    {
                        dir = dirFor;
                        goto DirDecided;
                    }
                    if (numBack > 0 && (numFor + numSide1 + numSide2 == 0))
                    {
                        dir = dirBack;
                        goto DirDecided;
                    }
                    if (numSide1 > 0 && (numFor + numBack + numSide2 == 0))
                    {
                        dir = dirSide1;
                        goto DirDecided;
                    }
                    if (numSide2 > 0 && (numFor + numBack + numSide1 == 0))
                    {
                        dir = dirSide2;
                        goto DirDecided;
                    }

                    // 2. If we can go back - that is the ONLY direction to go
                    if (numBack > 0)
                    {
                        dir = dirBack;
                        goto DirDecided;
                    }

                    // 3. If can only go one step sideways, then go sideways
                    if (numSide1 == 1)
                    {
                        dir = dirSide1;
                        goto DirDecided;
                    }
                    if (numSide2 == 1)
                    {
                        dir = dirSide2;
                        goto DirDecided;
                    }

                    // 4. If can go more than one step in both sideways directions, randomly pick one of the two
                    if (numSide1 > 1 && numSide2 > 1)
                    {
                        rnd = random.Next(2);
                        dir = (rnd == 0) ? dirSide1 : dirSide2;
                        goto DirDecided;
                    }

                    // 5. Pick a random direction from the ones available; but only allowed to go east if
                    //      (a) at sideways edge
                    //      (b) more than two steps from the forwards end, and
                    //      (c) back most filled cells not more than three steps behind
                    List<Maze.Dir> dirList = new List<Maze.Dir>();
                    if (numSide1 > 0)
                    {
                        dirList.Add(dirSide1);
                    }
                    if (numSide2 > 0)
                    {
                        dirList.Add(dirSide2);
                    }
                    if (numFor > 0)
                    {
                        bool backMostOk = false;
                        bool farFromForEdge = false;
                        bool onSideEdge = false;

                        switch (direction)
                        {
                            case Maze.Dir.E:
                                {
                                    int backMostCol = cols;
                                    for (int r = 0; r < rows; r++)
                                    {
                                        backMostCol = System.Math.Min(backMostCol, backMost[r]);
                                    }
                                    backMostOk = (backMostCol >= cur.Col - 3);
                                    farFromForEdge = (cur.Col < maxCol - 2);
                                    onSideEdge = (cur.Row == 0 || cur.Row == maxRow);
                                    break;
                                }
                            case Maze.Dir.W:
                                {
                                    int backMostCol = -1;
                                    for (int r = 0; r < rows; r++)
                                    {
                                        backMostCol = System.Math.Max(backMostCol, backMost[r]);
                                    }
                                    backMostOk = (backMostCol <= cur.Col + 3);
                                    farFromForEdge = (cur.Col > 2);
                                    onSideEdge = (cur.Row == 0 || cur.Row == maxRow);
                                    break;
                                }
                            case Maze.Dir.N:
                                {
                                    int backMostRow = rows;
                                    for (int c = 0; c < cols; c++)
                                    {
                                        backMostRow = System.Math.Min(backMostRow, backMost[c]);
                                    }
                                    backMostOk = (backMostRow >= cur.Row - 3);
                                    farFromForEdge = (cur.Row < maxRow - 2);
                                    onSideEdge = (cur.Col == 0 || cur.Col == maxCol);
                                    break;
                                }
                            case Maze.Dir.S:
                                {
                                    int backMostRow = -1;
                                    for (int c = 0; c < cols; c++)
                                    {
                                        backMostRow = System.Math.Max(backMostRow, backMost[c]);
                                    }
                                    backMostOk = (backMostRow <= cur.Row + 3);
                                    farFromForEdge = (cur.Row > 2);
                                    onSideEdge = (cur.Col == 0 || cur.Col == maxCol);
                                    break;
                                }
                        }

                        if (backMostOk && farFromForEdge && onSideEdge)
                        {
                            dirList.Add(dirFor);
                        }
                    }

                    // If dirList is empty, then we've reached a deadend, and must quit...
                    if (dirList.Count == 0)
                    {
                        break;
                    }

                    // Otherwise, pick a dir
                    rnd = random.Next(dirList.Count);
                    dir = dirList[rnd];

                    DirDecided:
                    // Update map
                    Maze.Cell nxt = new Maze.Cell(cur, dir);
                    lastCell = nxt;

                    map[cur.Row, cur.Col] |= dir;
                    map[nxt.Row, nxt.Col] |= Maze.Opposite(dir);
                    emptyCells--;
                    cur = nxt;
                }

                // If still have empty cells, then cycle through and join the empty cell to one
                // of it's non-empty neighbours (randomly) chosen.
                //
                // Cycle throught the cells east-to-west.  For each, randomly join to a finished cell
                // in an north, south or west direction.  Only pick east if that is the only option.
                // This is to maintain a general sense of east-to-west motion.
                //
                // Keep track of empty cells with NO non-empty neighbours, and iterate through that
                // list next.  Keep looping till all empty cells are filled.

                if (emptyCells > 0)
                {
                    List<Maze.Cell> empty = new List<Maze.Cell>();

                    for (int col = 0; col < cols; col++)
                    {
                        for (int row = 0; row < rows; row++)
                        {
                            if (map[row, col] == Maze.Dir.None)
                            {
                                if (!RandomJoin(random, map, row, col))
                                {
                                    empty.Add(new Maze.Cell(row, col));
                                }
                            }
                        }
                    }

                    while (empty.Count > 0)
                    {
                        List<Maze.Cell> stillEmpty = new List<Maze.Cell>();
                        foreach (Maze.Cell cell in empty)
                        {
                            if (!RandomJoin(random, map, cell.Row, cell.Col))
                            {
                                stillEmpty.Add(cell);
                            }
                        }
                        empty = stillEmpty;
                    }
                }

                return map;
            }

            /// <summary>
            /// Randoms the join.
            /// </summary>
            /// <param name="random">The random.</param>
            /// <param name="map">The map.</param>
            /// <param name="row">The row.</param>
            /// <param name="col">The col.</param>
            /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
            private static bool RandomJoin(Random random, Maze.Dir[,] map, int row, int col)
            {
                int maxRow = map.GetLength(0) - 1;
                int maxCol = map.GetLength(1) - 1;

                List<Maze.Dir> dirList = new List<Maze.Dir>();

                if (col > 0 && map[row, col - 1] != Maze.Dir.None)
                {
                    dirList.Add(Maze.Dir.W);
                }
                if (row > 0 && map[row - 1, col] != Maze.Dir.None)
                {
                    dirList.Add(Maze.Dir.N);
                }
                if (row < maxRow && map[row + 1, col] != Maze.Dir.None)
                {
                    dirList.Add(Maze.Dir.S);
                }

                if (dirList.Count == 0)
                {
                    if (col < maxCol && map[row, col + 1] != Maze.Dir.None)
                    {
                        dirList.Add(Maze.Dir.E);
                    }
                }

                if (dirList.Count == 0)
                {
                    return false;
                }

                Maze.Dir dir = dirList[random.Next(dirList.Count)];
                Maze.Cell nn = new Maze.Cell(row, col, dir);

                map[row, col] |= dir;
                map[nn.Row, nn.Col] |= Maze.Opposite(dir);

                return true;
            }

            /// <summary>
            /// Counts the can go.
            /// </summary>
            /// <param name="map">The map.</param>
            /// <param name="cur">The current.</param>
            /// <param name="dir">The dir.</param>
            /// <returns>System.Int32.</returns>
            private static int CountCanGo(Maze.Dir[,] map, Maze.Cell cur, Maze.Dir dir)
            {
                int maxRow = map.GetLength(0) - 1;
                int maxCol = map.GetLength(1) - 1;

                switch (dir)
                {
                    case Maze.Dir.N:
                        {
                            if (cur.Row > 0 && map[cur.Row - 1, cur.Col] == Maze.Dir.None)
                            {
                                if (cur.Row > 1 && map[cur.Row - 2, cur.Col] == Maze.Dir.None) return 2;
                                return 1;
                            }
                            break;
                        }

                    case Maze.Dir.E:
                        {
                            if (cur.Col < maxCol && map[cur.Row, cur.Col + 1] == Maze.Dir.None)
                            {
                                if (cur.Col < (maxCol - 1) && map[cur.Row, cur.Col + 2] == Maze.Dir.None) return 2;
                                return 1;
                            }
                            break;
                        }

                    case Maze.Dir.S:
                        {
                            if (cur.Row < maxRow && map[cur.Row + 1, cur.Col] == Maze.Dir.None)
                            {
                                if (cur.Row < (maxRow - 1) && map[cur.Row + 2, cur.Col] == Maze.Dir.None) return 2;
                                return 1;
                            }
                            break;
                        }

                    case Maze.Dir.W:
                        {
                            if (cur.Col > 0 && map[cur.Row, cur.Col - 1] == Maze.Dir.None)
                            {
                                if (cur.Col > 1 && map[cur.Row, cur.Col - 2] == Maze.Dir.None) return 2;
                                return 1;
                            }
                            break;
                        }
                }
                return 0;
            }
        }
    }

    #endregion


    


    #endregion
}
