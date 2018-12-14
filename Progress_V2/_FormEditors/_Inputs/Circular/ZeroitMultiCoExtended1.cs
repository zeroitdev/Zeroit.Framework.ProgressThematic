// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended1.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {


        #region Private Properties

        /// <summary>
        /// The mc ex v2 outer border start
        /// </summary>
        private LineCap MCExV2_outerBorderStart = LineCap.Round;
        /// <summary>
        /// The mc ex v2 outer border end
        /// </summary>
        private LineCap MCExV2_outerBorderEnd = LineCap.ArrowAnchor;
        /// <summary>
        /// The mc ex v2 outer border style
        /// </summary>
        private DashStyle MCExV2_outerBorderStyle = DashStyle.Dash;
        /// <summary>
        /// The mc ex v2 gradient angle
        /// </summary>
        private float MCExV2_gradientAngle = 90f;
        /// <summary>
        /// The mc ex v2 outerborder
        /// </summary>
        bool MCExV2_outerborder = false;
        /// <summary>
        /// The mc ex v2 rotatingborder
        /// </summary>
        bool MCExV2_rotatingborder = true;
        /// <summary>
        /// The mc ex v2 divisions
        /// </summary>
        bool MCExV2_divisions = true;
        /// <summary>
        /// The mc ex v2 divisions width
        /// </summary>
        int MCExV2_divisionsWidth = 5;
        /// <summary>
        /// The mc ex v2 draw mode
        /// </summary>
        private drawMode MCExV2_drawMode = drawMode.Solid;
        /// <summary>
        /// The mc ex v2 show inner border
        /// </summary>
        private bool MCExV2_showInnerBorder = true;
        /// <summary>
        /// The mc ex v2 inner border
        /// </summary>
        private int MCExV2_innerBorder = 2;
        /// <summary>
        /// The mc ex v2 shift
        /// </summary>
        private int MCExV2_shift = 15;
        /// <summary>
        /// The mc ex v2 correct shift
        /// </summary>
        private int MCExV2_correctShift = 6;
        /// <summary>
        /// The mc ex v2 rect shift
        /// </summary>
        private int MCExV2_rectShift = 3;
        /// <summary>
        /// The mc ex v2 no of rings
        /// </summary>
        private Rings MCExV2_noOfRings = Rings.One;
        /// <summary>
        /// The mc ex v2 inner hole color
        /// </summary>
        private Color MCExV2_innerHoleColor = Color.Transparent;
        /// <summary>
        /// The mc ex v2 inner hole grad color
        /// </summary>
        private Color[] MCExV2_innerHoleGradColor = new Color[]
        {
            Color.Azure,
            Color.Bisque
        };
        /// <summary>
        /// The mc ex v2 inner border color
        /// </summary>
        private Color MCExV2_innerBorderColor = Color.Gray;
        /// <summary>
        /// The mc ex v2 lin colors0
        /// </summary>
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
        /// <summary>
        /// The mc ex v2 lin colors1
        /// </summary>
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
        /// <summary>
        /// The mc ex v2 colors
        /// </summary>
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


        /// <summary>
        /// The mc ex v2 shift height
        /// </summary>
        private int MCExV2_shift_Height = 15;
        /// <summary>
        /// The mc ex v2 correct shift height
        /// </summary>
        private int MCExV2_correctShift_Height = 6;
        /// <summary>
        /// The mc ex v2 rect shift height
        /// </summary>
        private int MCExV2_rectShift_Height = 3;
        /// <summary>
        /// The mc ex v2 position horizontal
        /// </summary>
        private int MCExV2_position_horizontal = 0;
        /// <summary>
        /// The mc ex v2 position vertical
        /// </summary>
        private int MCExV2_position_vertical = 0;
        /// <summary>
        /// The mc ex v2 innerborder color
        /// </summary>
        private Color MCExV2_innerborderColor = Color.Black;
        /// <summary>
        /// The mc ex v2 inner color
        /// </summary>
        private Color MCExV2_innerColor = Color.Blue;

        /// <summary>
        /// The mc ex v2 outer border
        /// </summary>
        private int MCExV2_outerBorder = 2;
        /// <summary>
        /// The mc ex v2 outer color
        /// </summary>
        private Color[] MCExV2_outerColor = new Color[] {Color.Gray, Color.Black};

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the width of the mc ex v2 outer border.
        /// </summary>
        /// <value>The width of the mc ex v2 outer border.</value>
        public int MCExV2_OuterBorderWidth
        {
            get { return MCExV2_outerBorder; }
            set
            {
                MCExV2_outerBorder = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the mc ex v2 outer.
        /// </summary>
        /// <value>The color of the mc ex v2 outer.</value>
        public Color[] MCExV2_OuterColor
        {
            get { return MCExV2_outerColor; }
            set
            {
                MCExV2_outerColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the mc ex v2 inner.
        /// </summary>
        /// <value>The color of the mc ex v2 inner.</value>
        public Color MCExV2_InnerColor
        {
            get { return MCExV2_innerColor; }
            set
            {
                MCExV2_innerColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 position horizontal.
        /// </summary>
        /// <value>The mc ex v2 position horizontal.</value>
        public int MCExV2_Position_Horizontal
        {
            get { return MCExV2_position_horizontal; }
            set
            {
                MCExV2_position_horizontal = value;
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 position vertical.
        /// </summary>
        /// <value>The mc ex v2 position vertical.</value>
        public int MCExV2_Position_Vertical
        {
            get { return MCExV2_position_vertical; }
            set
            {
                MCExV2_position_vertical = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex v2 correct shift.
        /// </summary>
        /// <value>The height of the mc ex v2 correct shift.</value>
        public int MCExV2_CorrectShift_Height
        {
            get { return MCExV2_correctShift_Height; }
            set
            {
                MCExV2_correctShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex v2 shift.
        /// </summary>
        /// <value>The height of the mc ex v2 shift.</value>
        public int MCExV2_Shift_Height
        {
            get { return MCExV2_shift_Height; }
            set
            {
                MCExV2_shift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex v2 rect shift.
        /// </summary>
        /// <value>The height of the mc ex v2 rect shift.</value>
        public int MCExV2_RectShift_Height
        {
            get { return MCExV2_rectShift_Height; }
            set
            {
                MCExV2_rectShift_Height = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc ex v2 rotating border].
        /// </summary>
        /// <value><c>true</c> if [mc ex v2 rotating border]; otherwise, <c>false</c>.</value>
        public bool MCExV2_RotatingBorder
        {
            get { return MCExV2_rotatingborder; }
            set
            {
                MCExV2_rotatingborder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 outer border start.
        /// </summary>
        /// <value>The mc ex v2 outer border start.</value>
        public LineCap MCExV2_OuterBorderStart
        {
            get { return MCExV2_outerBorderStart; }
            set
            {
                MCExV2_outerBorderStart = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 outer border end.
        /// </summary>
        /// <value>The mc ex v2 outer border end.</value>
        public LineCap MCExV2_OuterBorderEnd
        {
            get { return MCExV2_outerBorderEnd; }
            set
            {
                MCExV2_outerBorderEnd = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 outer border style.
        /// </summary>
        /// <value>The mc ex v2 outer border style.</value>
        public DashStyle MCExV2_OuterBorderStyle
        {
            get { return MCExV2_outerBorderStyle; }
            set
            {
                MCExV2_outerBorderStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc ex v2 outer border].
        /// </summary>
        /// <value><c>true</c> if [mc ex v2 outer border]; otherwise, <c>false</c>.</value>
        public bool MCExV2_OuterBorder
        {
            get { return MCExV2_outerborder; }
            set
            {
                MCExV2_outerborder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 inner hole grad col.
        /// </summary>
        /// <value>The mc ex v2 inner hole grad col.</value>
        public Color[] MCExV2_InnerHoleGradCol
        {
            get { return MCExV2_innerHoleGradColor; }
            set
            {
                MCExV2_innerHoleGradColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 inner hole.
        /// </summary>
        /// <value>The mc ex v2 inner hole.</value>
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

        /// <summary>
        /// Gets or sets the mc ex v2 gradient angle.
        /// </summary>
        /// <value>The mc ex v2 gradient angle.</value>
        public float MCExV2_GradientAngle
        {
            get { return MCExV2_gradientAngle; }
            set
            {
                MCExV2_gradientAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc ex v2 divisions].
        /// </summary>
        /// <value><c>true</c> if [mc ex v2 divisions]; otherwise, <c>false</c>.</value>
        public bool MCExV2_Divisions
        {
            get { return MCExV2_divisions; }
            set
            {
                MCExV2_divisions = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the mc ex v2 divisions.
        /// </summary>
        /// <value>The width of the mc ex v2 divisions.</value>
        public int MCExV2_DivisionsWidth
        {
            get { return MCExV2_divisionsWidth; }
            set
            {
                MCExV2_divisionsWidth = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 gradient line1.
        /// </summary>
        /// <value>The mc ex v2 gradient line1.</value>
        public Color[] MCExV2_GradientLine1
        {
            get { return MCExV2_linColors0; }
            set
            {
                MCExV2_linColors0 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 gradient line2.
        /// </summary>
        /// <value>The mc ex v2 gradient line2.</value>
        public Color[] MCExV2_GradientLine2
        {
            get { return MCExV2_linColors1; }
            set
            {
                MCExV2_linColors1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 draw mode.
        /// </summary>
        /// <value>The mc ex v2 draw mode.</value>
        public drawMode MCExV2_DrawMode
        {
            get { return MCExV2_drawMode; }
            set
            {
                MCExV2_drawMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the mc ex v2 inner border.
        /// </summary>
        /// <value>The color of the mc ex v2 inner border.</value>
        public Color MCExV2_InnerBorderColor
        {
            get { return MCExV2_innerBorderColor; }
            set
            {
                MCExV2_innerBorderColor = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the mc ex v2 colors.
        /// </summary>
        /// <value>The mc ex v2 colors.</value>
        public Color[] MCExV2_Colors
        {
            get { return MCExV2_colors; }
            set
            {
                MCExV2_colors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 no of rings.
        /// </summary>
        /// <value>The mc ex v2 no of rings.</value>
        public Rings MCExV2_NoOfRings
        {
            get { return MCExV2_noOfRings; }
            set
            {
                MCExV2_noOfRings = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner border].
        /// </summary>
        /// <value><c>true</c> if [show inner border]; otherwise, <c>false</c>.</value>
        public bool ShowInnerBorder
        {
            get { return MCExV2_showInnerBorder; }
            set
            {
                MCExV2_showInnerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 inner border.
        /// </summary>
        /// <value>The mc ex v2 inner border.</value>
        public int MCExV2_InnerBorder
        {
            get { return MCExV2_innerBorder; }
            set
            {
                MCExV2_innerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 inner shift.
        /// </summary>
        /// <value>The mc ex v2 inner shift.</value>
        public int MCExV2_InnerShift
        {
            get { return MCExV2_rectShift; }
            set
            {
                MCExV2_rectShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 correct shift.
        /// </summary>
        /// <value>The mc ex v2 correct shift.</value>
        public int MCExV2_CorrectShift
        {
            get { return MCExV2_correctShift; }
            set
            {
                MCExV2_correctShift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 shift.
        /// </summary>
        /// <value>The mc ex v2 shift.</value>
        public int MCExV2_Shift
        {
            get { return MCExV2_shift; }
            set
            {
                MCExV2_shift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mc ex v2 rect shift.
        /// </summary>
        /// <value>The mc ex v2 rect shift.</value>
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
