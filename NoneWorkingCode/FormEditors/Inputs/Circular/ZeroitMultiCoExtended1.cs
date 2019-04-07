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


        #region Private Properties

        private LineCap MCExV2_outerBorderStart = LineCap.Round;
        private LineCap MCExV2_outerBorderEnd = LineCap.ArrowAnchor;
        private DashStyle MCExV2_outerBorderStyle = DashStyle.Dash;
        private float MCExV2_gradientAngle = 90f;
        bool MCExV2_outerborder = false;
        bool MCExV2_rotatingborder = true;
        bool MCExV2_divisions = true;
        int MCExV2_divisionsWidth = 5;
        private drawMode MCExV2_drawMode = drawMode.Solid;
        private bool MCExV2_showInnerBorder = true;
        private int MCExV2_innerBorder = 2;
        private int MCExV2_shift = 15;
        private int MCExV2_correctShift = 6;
        private int MCExV2_rectShift = 3;
        private Rings MCExV2_noOfRings = Rings.One;
        private Color MCExV2_innerHoleColor = Color.Transparent;
        private Color[] MCExV2_innerHoleGradColor = new Color[]
        {
            Color.Azure,
            Color.Bisque
        };
        private Color MCExV2_innerBorderColor = Color.Gray;
        Color[] MCExV2_linColors0 = new Color[] {

            Color.Red,
            Color.Blue,
            Color.LightPink,
            Color.Yellow,
            Color.BlanchedAlmond,
            Color.DarkTurquoise,
            Color.Beige,
            Color.BurlyWood,
            Color.DarkOrange,
            Color.GreenYellow,
            Color.HotPink,
            Color.Magenta,
            Color.OldLace,
            Color.PowderBlue,
            Color.SlateBlue,
            Color.Sienna,
            Color.Peru,
            Color.MistyRose,
            Color.LemonChiffon,
            Color.Khaki,
            Color.ForestGreen,
            Color.DarkSlateGray,
            Color.Cornsilk,
            Color.Beige

        };
        Color[] MCExV2_linColors1 = new Color[] {

            Color.Yellow ,
            Color.LightGreen,
            Color.LightSkyBlue ,
            Color.Green ,
            Color.DarkGoldenrod ,
            Color.DimGray ,
            Color.BlanchedAlmond ,
            Color.Chartreuse ,
            Color.DarkOrchid ,
            Color.Honeydew ,
            Color.Indigo ,
            Color.Maroon ,
            Color.Plum ,
            Color.Purple ,
            Color.Thistle ,
            Color.SeaShell ,
            Color.Navy,
            Color.MidnightBlue ,
            Color.LawnGreen ,
            Color.HotPink ,
            Color.Yellow ,
            Color.Crimson ,
            Color.CornflowerBlue ,
            Color.Cyan

        };
        Color[] MCExV2_colors = new Color[]
            {
                Color.Red,
                Color.Yellow,
                Color.Green,
                Color.AliceBlue,
                Color.Brown,
                Color.Chocolate,
                Color.DarkOrange,
                Color.DarkRed,
                Color.DeepPink,
                Color.Indigo,
                Color.Ivory,
                Color.Lavender,
                Color.LightSeaGreen,
                Color.Maroon,
                Color.OrangeRed,
                Color.Orchid,
                Color.PaleGoldenrod,
                Color.PapayaWhip,
                Color.Teal,
                Color.Tomato,
                Color.YellowGreen,
                Color.Thistle,
                Color.Tan,
                Color.SlateGray,
            };
        
        #endregion

        #region Public Properties
        
        public bool MCExV2_RotatingBorder
        {
            get { return MCExV2_rotatingborder; }
            set
            {
                MCExV2_rotatingborder = value;
                
            }
        }
        
        public LineCap MCExV2_OuterBorderStart
        {
            get { return MCExV2_outerBorderStart; }
            set
            {
                MCExV2_outerBorderStart = value;
                
            }
        }
        
        public LineCap MCExV2_OuterBorderEnd
        {
            get { return MCExV2_outerBorderEnd; }
            set
            {
                MCExV2_outerBorderEnd = value;
                
            }
        }
        
        public DashStyle MCExV2_OuterBorderStyle
        {
            get { return MCExV2_outerBorderStyle; }
            set
            {
                MCExV2_outerBorderStyle = value;
                
            }
        }
        
        public bool MCExV2_OuterBorder
        {
            get { return MCExV2_outerborder; }
            set
            {
                MCExV2_outerborder = value;
                
            }
        }
        
        public Color[] MCExV2_InnerHoleGradCol
        {
            get { return MCExV2_innerHoleGradColor; }
            set
            {
                MCExV2_innerHoleGradColor = value;
                
            }
        }
        
        public Color MCExV2_InnerHole
        {
            get
            {
                return MCExV2_innerHoleColor;
            }

            set
            {
                MCExV2_innerHoleColor = value;
                
            }
        }
        
        public float MCExV2_GradientAngle
        {
            get { return MCExV2_gradientAngle; }
            set
            {
                MCExV2_gradientAngle = value;
                
            }
        }
        
        public bool MCExV2_Divisions
        {
            get { return MCExV2_divisions; }
            set
            {
                MCExV2_divisions = value;
                
            }
        }
        
        public int MCExV2_DivisionsWidth
        {
            get { return MCExV2_divisionsWidth; }
            set
            {
                MCExV2_divisionsWidth = value;
                
            }
        }
        
        public Color[] MCExV2_GradientLine1
        {
            get { return MCExV2_linColors0; }
            set
            {
                MCExV2_linColors0 = value;
                
            }
        }
        
        public Color[] MCExV2_GradientLine2
        {
            get { return MCExV2_linColors1; }
            set
            {
                MCExV2_linColors1 = value;
                
            }
        }

        public drawMode MCExV2_DrawMode
        {
            get { return MCExV2_drawMode; }
            set
            {
                MCExV2_drawMode = value;
                
            }
        }

        public Color MCExV2_InnerBorderColor
        {
            get { return MCExV2_innerBorderColor; }
            set
            {
                MCExV2_innerBorderColor = value;
                
            }
        }

        
        public Color[] MCExV2_Colors
        {
            get { return MCExV2_colors; }
            set
            {
                MCExV2_colors = value;
                
            }
        }
        
        public Rings MCExV2_NoOfRings
        {
            get { return MCExV2_noOfRings; }
            set
            {
                MCExV2_noOfRings = value;
                
            }
        }
        
        public bool ShowInnerBorder
        {
            get { return MCExV2_showInnerBorder; }
            set
            {
                MCExV2_showInnerBorder = value;
                
            }
        }
        
        public int MCExV2_InnerBorder
        {
            get { return MCExV2_innerBorder; }
            set
            {
                MCExV2_innerBorder = value;
                
            }
        }
        
        public int MCExV2_InnerShift
        {
            get { return MCExV2_rectShift; }
            set
            {
                MCExV2_rectShift = value;
                
            }
        }
        
        public int MCExV2_CorrectShift
        {
            get { return MCExV2_correctShift; }
            set
            {
                MCExV2_correctShift = value;
                
            }
        }
        
        public int MCExV2_Shift
        {
            get { return MCExV2_shift; }
            set
            {
                MCExV2_shift = value;
                
            }
        }
        
        public int MCExV2_RectShift
        {
            get { return MCExV2_rectShift; }
            set
            {
                MCExV2_rectShift = value;
                
            }
        }


        #endregion


    }
}
