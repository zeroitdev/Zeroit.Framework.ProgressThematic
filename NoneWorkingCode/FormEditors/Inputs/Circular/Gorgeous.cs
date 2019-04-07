using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private bool Gorgeous_enableInnerCover = false;
        private int Gorgeous_outerShift = 16;
        private int Gorgeous_innerShift = 26;
        private int Gorgeous_innerCoverShift = 32;
        private int Gorgeous_smallRectShift = 180;
        private Color[] Gorgeous_gradientColors = new Color[]
        {
            Color.FromArgb(254, 84, 84),
            Color.DarkSlateGray
        };
        private Color[] Gorgeous_solidcolors = new Color[]
        {
            Color.FromArgb(255,255,255),
            Color.FromArgb(37, 37, 38),
            Color.FromArgb(254, 84, 84),
            Color.FromArgb(37, 37, 38),
            Color.Gray
        };
        private int Gorgeous_border = 10;
        private bool Gorgeous_showText = true;
        private Gorgeous_rotatingAngle _rotatingAngle = Gorgeous_rotatingAngle.Clockwise;

        #endregion

        #region Public Properties

        
        public Gorgeous_rotatingAngle RotatingAngle
        {
            get { return _rotatingAngle; }
            set
            {
                _rotatingAngle = value;
                
            }
        }

        
        public Color[] SolidColors
        {
            get { return Gorgeous_solidcolors; }
            set
            {
                Gorgeous_solidcolors = value;
                
            }
        }

        
        public Color[] GradientColor
        {
            get { return Gorgeous_gradientColors; }
            set
            {
                Gorgeous_gradientColors = value;
                
            }
        }

        
        public int Border
        {
            get { return Gorgeous_border; }
            set
            {
                Gorgeous_border = value;
                
            }
        }

        
        public bool EnableInnerCover
        {
            get { return Gorgeous_enableInnerCover; }
            set
            {
                Gorgeous_enableInnerCover = value;
                
            }
        }

        
        public int ShiftOuter
        {
            get { return Gorgeous_outerShift; }
            set
            {
                Gorgeous_outerShift = value;
                
            }
        }

        
        public int ShiftInner
        {
            get { return Gorgeous_innerShift; }
            set
            {
                Gorgeous_innerShift = value;
                
            }
        }

        
        public int ShiftInnerCover
        {
            get { return Gorgeous_innerCoverShift; }
            set
            {
                Gorgeous_innerCoverShift = value;
                
            }
        }

        
        public int ShiftSmallRect
        {
            get { return Gorgeous_smallRectShift; }
            set
            {
                Gorgeous_smallRectShift = value;
                
            }
        }


        
        #endregion
    }
}
