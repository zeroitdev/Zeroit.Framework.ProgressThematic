using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zeroit.Framework.ProgressThematic.ThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        #region Private Fields

        private ProgressBarStyle Maze_progressStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
        private float Maze_marqueeAnimationSpeed = 100f;
        private int Maze_rowCount = 3;
        private MazeStyleType Maze_mazeStyle = MazeStyleType.SingleRight;
        private Maze_GradientType Maze_gradient = Maze_GradientType.None;
        private Color Maze_gradientStartColor = Color.PaleGreen;
        private Color Maze_gradientEndColor = Color.Lime;
        private int Maze_wallSize = 1;
        private int Maze_borderSize = 0;
        private Color Maze_borderColor = Color.Black;
        private bool Maze_borderGradient = false;
        private bool Maze_borderRoundCorners = false;
        private Color Maze_unusedColor = SystemColors.Control;
        private Color maze_solidColor = SystemColors.Highlight;
        private Color wallColor = Color.Black;

        #endregion


        #region Public Properties
        
        public Color Maze_SolidColor
        {
            get { return maze_solidColor; }
            set
            {
                maze_solidColor = value;
                
            }
        }
        
        public new ProgressBarStyle Style
        {
            get { return Maze_progressStyle; }
            set
            {


                Maze_progressStyle = value;
                
                
            }
        }

        public float MarqueeAnimationSpeed
        {
            get { return Maze_marqueeAnimationSpeed; }
            set
            {
                Maze_marqueeAnimationSpeed = value;
                
                
            }
        }
        
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
        
        public MazeStyleType MazeStyle
        {
            get { return Maze_mazeStyle; }
            set
            {
                Maze_mazeStyle = value;
                
            }
        }

        public Maze_GradientType Gradient
        {
            get { return Maze_gradient; }
            set
            {
                Maze_gradient = value;
                
            }
        }
        
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
        
        public int WallSize
        {
            get { return Maze_wallSize; }
            set
            {

                Maze_wallSize = value;
                
            }
        }
        
        
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
        
        public int BorderSize
        {
            get { return Maze_borderSize; }
            set
            {
                Maze_borderSize = value;
                //int v = Math.Max(0, value);
                //if (Maze_borderSize != v)
                //{
                //    Maze_borderSize = v;
                //    Maze_borderColors = null;
                    
                //}
            }
        }
        
        
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
