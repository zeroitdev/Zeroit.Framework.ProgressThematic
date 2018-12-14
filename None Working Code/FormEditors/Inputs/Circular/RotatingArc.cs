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
        private float angle = 90f;
        private int interval = 10;
        private bool rotatingBorder = false;
        private PieArc pieArc = PieArc.Arc;
        private RotatingArc_drawMode RotatingArc_drawmode = RotatingArc_drawMode.Default;
        private shape _shape = shape.Arc;
        private int size = 1;
        private Color customHeartFade = SystemColors.Control;
        private Color pieColor1 = Color.Beige;
        private Color pieColor2 = Color.Blue;
        private Color lineColor1 = Color.Yellow;
        private Color lineColor2 = Color.Blue;
        private Color lineWidthColor = Color.Transparent;
        private bool fillPie = false;
        private bool drawLine = true;
        private Color colorOuterBorder = Color.Blue;
        private Color innerCircle1Grad1 = Color.Red;
        private Color innerCircle1Grad2 = Color.Green;
        private Color innerCircle2Grad1 = Color.Yellow;
        private Color innerCircle2Grad2 = Color.Blue;
        private Color innerCircle3Grad1 = Color.Brown;
        private Color innerCircle3Grad2 = Color.Gray;
        private Color innerCircle4Grad1 = Color.RosyBrown;
        private Color innerCircle4Grad2 = Color.LightBlue;
        private Color innerCircle5Grad1 = Color.Violet;
        private Color innerCircle5Grad2 = Color.LightPink;
        private Color innerCircle6Grad1 = SystemColors.Control;
        private Color innerCircle6Grad2 = SystemColors.Control;
        private bool showInnerCircle1 = true;
        private bool showInnerCircle2 = true;
        private bool showInnerCircle3 = true;
        private bool showInnerCircle4 = true;
        private bool showInnerCircle5 = true;
        private bool showInnerCircle6 = true;
        private int outerBorderWidth = 1;
        private int innercircleBorder = 10;
        private int widthReduction = 10;
        private int heightReduction = 10;
        private int innercircle2Width = 20;
        private int innercircle2Height = 20;
        private int innercircle3Width = 40;
        private int innercircle3Height = 40;
        private int innercircle4Width = 60;
        private int innercircle4Height = 60;
        private int innercircle5Width = 80;
        private int innercircle5Height = 80;
        private int innercircle6Width = 100;
        private int innercircle6Height = 100;
        int heartinterval = 100;
        private bool heartAutoAnimate = false;

        #endregion

        #region Include in Private Field



        #endregion

        #region Include in Public Properties


        public int HeartTimerInterval
        {
            get { return heartinterval; }
            set
            {
                heartinterval = value;
                
            }
        }

        public bool HeartBeat
        {
            get { return heartAutoAnimate; }
            set
            {
                heartAutoAnimate = value;
                
            }
        }

        #endregion

        #region Public Properties

        public Color LineWidthColor
        {
            get
            {
                return lineWidthColor;
            }
            set
            {
                lineWidthColor = value;
            }
        }
        
        public PieArc RotatingType
        {
            get { return pieArc; }
            set
            {
                pieArc = value;
                
            }
        }

        
        public Color CustomFadeColor
        {
            get { return customHeartFade; }
            set
            {
                customHeartFade = value;
                
            }
        }

        
        public RotatingArc_drawMode RotatingArc_DrawMode
        {
            get { return RotatingArc_drawmode; }
            set
            {
                RotatingArc_drawmode = value;
                
            }
        }

        
        public int Innercircle1WidthReduction
        {
            get { return widthReduction; }
            set
            {
                widthReduction = value;
                
            }
        }

        
        public int Innercircle1HeightReduction
        {
            get { return heightReduction; }
            set
            {
                heightReduction = value;
                
            }
        }

        
        public bool ShowLine
        {
            get { return drawLine; }
            set
            {
                drawLine = value;
                
            }
        }

        
        public Color PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;
                
            }
        }

        
        public Color PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;
                
            }
        }

        
        public Color LineColor1
        {
            get { return lineColor1; }
            set
            {
                pieColor1 = value;
                
            }
        }

        
        public Color LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;
                
            }
        }

        
        public bool FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;
                
            }
        }
        
        public int LineSize
        {
            get { return size; }
            set
            {
                size = value;
                
            }
        }

        
        public bool RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;
                
            }
        }

        
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                //
            }
        }

        
        public int InnerCircleBorder
        {
            get { return innercircleBorder; }
            set
            {
                innercircleBorder = value;
                
            }
        }

        
        public int Innercircle2WidthReduction
        {
            get { return innercircle2Width; }
            set
            {
                innercircle2Width = value;
                
            }
        }

        
        public int Innercircle2HeightReduction
        {
            get { return innercircle2Height; }
            set
            {
                innercircle2Height = value;
                
            }
        }

        
        public int Innercircle3WidthReduction
        {
            get { return innercircle3Width; }
            set
            {
                innercircle3Width = value;
                
            }
        }

        
        public int Innercircle3HeightReduction
        {
            get { return innercircle3Height; }
            set
            {
                innercircle3Height = value;
                
            }
        }

        
        public int Innercircle4WidthReduction
        {
            get { return innercircle4Width; }
            set
            {
                innercircle4Width = value;
                
            }
        }

        
        public int Innercircle4HeightReduction
        {
            get { return innercircle4Height; }
            set
            {
                innercircle4Height = value;
                
            }
        }

        
        public int Innercircle5WidthReduction
        {
            get { return innercircle5Width; }
            set
            {
                innercircle5Width = value;
                
            }
        }

        
        public int Innercircle5HeightReduction
        {
            get { return innercircle5Height; }
            set
            {
                innercircle5Height = value;
                
            }
        }

        
        public int Innercircle6WidthReduction
        {
            get { return innercircle6Width; }
            set
            {
                innercircle6Width = value;
                
            }
        }

        
        public int Innercircle6HeightReduction
        {
            get { return innercircle6Height; }
            set
            {
                innercircle6Height = value;
                
            }
        }

        
        public bool ShowInnerCircle1
        {
            get
            {
                return showInnerCircle1;
            }

            set
            {
                showInnerCircle1 = value;
                
            }
        }

        
        public Color ColorInnerCircle1Grad1
        {
            get { return innerCircle1Grad1; }
            set
            {
                innerCircle1Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle1Grad2
        {
            get { return innerCircle1Grad2; }
            set
            {
                innerCircle1Grad2 = value;
                
            }
        }

        
        public bool ShowInnerCircle2
        {
            get
            {
                return showInnerCircle2;
            }

            set
            {
                showInnerCircle2 = value;
                
            }
        }

        
        public Color ColorInnerCircle2Grad1
        {
            get { return innerCircle2Grad1; }
            set
            {
                innerCircle2Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle2Grad2
        {
            get { return innerCircle2Grad2; }
            set
            {
                innerCircle2Grad2 = value;
                
            }
        }

        
        public bool ShowInnerCircle3
        {
            get
            {
                return showInnerCircle3;
            }

            set
            {
                showInnerCircle3 = value;
                
            }
        }

        
        public Color ColorInnerCircle3Grad1
        {
            get { return innerCircle3Grad1; }
            set
            {
                innerCircle3Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle3Grad2
        {
            get { return innerCircle3Grad2; }
            set
            {
                innerCircle3Grad2 = value;
                
            }
        }

        
        public bool ShowInnerCircle4
        {
            get
            {
                return showInnerCircle4;
            }

            set
            {
                showInnerCircle4 = value;
                
            }
        }

        
        public Color ColorInnerCircle4Grad1
        {
            get { return innerCircle4Grad1; }
            set
            {
                innerCircle4Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle4Grad2
        {
            get { return innerCircle4Grad2; }
            set
            {
                innerCircle4Grad2 = value;
                
            }
        }

        
        public bool ShowInnerCircle5
        {
            get
            {
                return showInnerCircle5;
            }

            set
            {
                showInnerCircle5 = value;
                
            }
        }

        
        public Color ColorInnerCircle5Grad1
        {
            get { return innerCircle5Grad1; }
            set
            {
                innerCircle5Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle5Grad2
        {
            get { return innerCircle5Grad2; }
            set
            {
                innerCircle5Grad2 = value;
                
            }
        }

        
        public bool ShowInnerCircle6
        {
            get
            {
                return showInnerCircle6;
            }

            set
            {
                showInnerCircle6 = value;
                
            }
        }

        
        public Color ColorInnerCircle6Grad1
        {
            get { return innerCircle6Grad1; }
            set
            {
                innerCircle6Grad1 = value;
                
            }
        }

        
        public Color ColorInnerCircle6Grad2
        {
            get { return innerCircle6Grad2; }
            set
            {
                innerCircle6Grad2 = value;
                
            }
        }

        
        public Color ColorOuterBorder
        {
            get { return colorOuterBorder; }
            set
            {
                colorOuterBorder = value;
                
            }
        }

        
        public int OuterBorderWidth
        {
            get { return outerBorderWidth; }
            set
            {
                outerBorderWidth = value;
                
            }
        }

        #endregion

    }
}
