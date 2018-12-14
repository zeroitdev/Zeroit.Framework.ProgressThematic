// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingArc.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

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
        /// The angle
        /// </summary>
        private float angle = 90f;
        /// <summary>
        /// The interval
        /// </summary>
        private int interval = 10;
        /// <summary>
        /// The rotating border
        /// </summary>
        private bool rotatingBorder = false;
        /// <summary>
        /// The pie arc
        /// </summary>
        private PieArc pieArc = PieArc.Arc;
        /// <summary>
        /// The rotating arc drawmode
        /// </summary>
        private RotatingArc_drawMode RotatingArc_drawmode = RotatingArc_drawMode.Default;
        /// <summary>
        /// The shape
        /// </summary>
        private shape _shape = shape.Arc;
        /// <summary>
        /// The size
        /// </summary>
        private int size = 1;
        /// <summary>
        /// The custom heart fade
        /// </summary>
        private Color customHeartFade = SystemColors.Control;
        /// <summary>
        /// The pie color1
        /// </summary>
        private Color pieColor1 = Color.Beige;
        /// <summary>
        /// The pie color2
        /// </summary>
        private Color pieColor2 = Color.Blue;
        /// <summary>
        /// The line color1
        /// </summary>
        private Color lineColor1 = Color.Yellow;
        /// <summary>
        /// The line color2
        /// </summary>
        private Color lineColor2 = Color.Blue;
        /// <summary>
        /// The line width color
        /// </summary>
        private Color lineWidthColor = Color.Transparent;
        /// <summary>
        /// The fill pie
        /// </summary>
        private bool fillPie = false;
        /// <summary>
        /// The draw line
        /// </summary>
        private bool drawLine = true;
        /// <summary>
        /// The color outer border
        /// </summary>
        private Color colorOuterBorder = Color.Blue;
        /// <summary>
        /// The inner circle1 grad1
        /// </summary>
        private Color innerCircle1Grad1 = Color.Red;
        /// <summary>
        /// The inner circle1 grad2
        /// </summary>
        private Color innerCircle1Grad2 = Color.Green;
        /// <summary>
        /// The inner circle2 grad1
        /// </summary>
        private Color innerCircle2Grad1 = Color.Yellow;
        /// <summary>
        /// The inner circle2 grad2
        /// </summary>
        private Color innerCircle2Grad2 = Color.Blue;
        /// <summary>
        /// The inner circle3 grad1
        /// </summary>
        private Color innerCircle3Grad1 = Color.Brown;
        /// <summary>
        /// The inner circle3 grad2
        /// </summary>
        private Color innerCircle3Grad2 = Color.Gray;
        /// <summary>
        /// The inner circle4 grad1
        /// </summary>
        private Color innerCircle4Grad1 = Color.RosyBrown;
        /// <summary>
        /// The inner circle4 grad2
        /// </summary>
        private Color innerCircle4Grad2 = Color.LightBlue;
        /// <summary>
        /// The inner circle5 grad1
        /// </summary>
        private Color innerCircle5Grad1 = Color.Violet;
        /// <summary>
        /// The inner circle5 grad2
        /// </summary>
        private Color innerCircle5Grad2 = Color.LightPink;
        /// <summary>
        /// The inner circle6 grad1
        /// </summary>
        private Color innerCircle6Grad1 = SystemColors.Control;
        /// <summary>
        /// The inner circle6 grad2
        /// </summary>
        private Color innerCircle6Grad2 = SystemColors.Control;
        /// <summary>
        /// The show inner circle1
        /// </summary>
        private bool showInnerCircle1 = true;
        /// <summary>
        /// The show inner circle2
        /// </summary>
        private bool showInnerCircle2 = true;
        /// <summary>
        /// The show inner circle3
        /// </summary>
        private bool showInnerCircle3 = true;
        /// <summary>
        /// The show inner circle4
        /// </summary>
        private bool showInnerCircle4 = true;
        /// <summary>
        /// The show inner circle5
        /// </summary>
        private bool showInnerCircle5 = true;
        /// <summary>
        /// The show inner circle6
        /// </summary>
        private bool showInnerCircle6 = true;
        /// <summary>
        /// The outer border width
        /// </summary>
        private int outerBorderWidth = 1;
        /// <summary>
        /// The innercircle border
        /// </summary>
        private int innercircleBorder = 10;
        /// <summary>
        /// The width reduction
        /// </summary>
        private int widthReduction = 10;
        /// <summary>
        /// The height reduction
        /// </summary>
        private int heightReduction = 10;
        /// <summary>
        /// The innercircle2 width
        /// </summary>
        private int innercircle2Width = 20;
        /// <summary>
        /// The innercircle2 height
        /// </summary>
        private int innercircle2Height = 20;
        /// <summary>
        /// The innercircle3 width
        /// </summary>
        private int innercircle3Width = 40;
        /// <summary>
        /// The innercircle3 height
        /// </summary>
        private int innercircle3Height = 40;
        /// <summary>
        /// The innercircle4 width
        /// </summary>
        private int innercircle4Width = 60;
        /// <summary>
        /// The innercircle4 height
        /// </summary>
        private int innercircle4Height = 60;
        /// <summary>
        /// The innercircle5 width
        /// </summary>
        private int innercircle5Width = 80;
        /// <summary>
        /// The innercircle5 height
        /// </summary>
        private int innercircle5Height = 80;
        /// <summary>
        /// The innercircle6 width
        /// </summary>
        private int innercircle6Width = 100;
        /// <summary>
        /// The innercircle6 height
        /// </summary>
        private int innercircle6Height = 100;

        /// <summary>
        /// The heartinterval
        /// </summary>
        int heartinterval = 100;

        /// <summary>
        /// The heart automatic animate
        /// </summary>
        private bool heartAutoAnimate = false;

        /// <summary>
        /// The rotating arc start angle
        /// </summary>
        private float rotatingArc_startAngle = 180;
        /// <summary>
        /// The rotating arc sweep angle
        /// </summary>
        private float rotatingArc_sweepAngle = 360;

        #endregion



        #region Include in Public Properties


        /// <summary>
        /// Gets or sets the heart timer interval.
        /// </summary>
        /// <value>The heart timer interval.</value>
        public int HeartTimerInterval
        {
            get { return heartinterval; }
            set
            {
                heartinterval = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [heart beat].
        /// </summary>
        /// <value><c>true</c> if [heart beat]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets the rotating arc start angle.
        /// </summary>
        /// <value>The rotating arc start angle.</value>
        public float RotatingArc_StartAngle
        {
            get { return rotatingArc_startAngle; }
            set
            {
                rotatingArc_startAngle = value;
            }
        }

        /// <summary>
        /// Gets or sets the rotating arc sweep angle.
        /// </summary>
        /// <value>The rotating arc sweep angle.</value>
        public float RotatingArc_SweepAngle
        {
            get { return rotatingArc_sweepAngle; }
            set
            {
                rotatingArc_sweepAngle = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the rotating.
        /// </summary>
        /// <value>The type of the rotating.</value>
        public PieArc RotatingType
        {
            get { return pieArc; }
            set
            {
                pieArc = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the rotating arc draw mode.
        /// </summary>
        /// <value>The rotating arc draw mode.</value>
        public RotatingArc_drawMode RotatingArc_DrawMode
        {
            get { return RotatingArc_drawmode; }
            set
            {
                RotatingArc_drawmode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle1 width reduction.
        /// </summary>
        /// <value>The innercircle1 width reduction.</value>
        public int Innercircle1WidthReduction
        {
            get { return widthReduction; }
            set
            {
                widthReduction = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle1 height reduction.
        /// </summary>
        /// <value>The innercircle1 height reduction.</value>
        public int Innercircle1HeightReduction
        {
            get { return heightReduction; }
            set
            {
                heightReduction = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the line.
        /// </summary>
        /// <value>The size of the line.</value>
        public int LineSize
        {
            get { return size; }
            set
            {
                size = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the outer border.
        /// </summary>
        /// <value>The width of the outer border.</value>
        public int OuterBorderWidth
        {
            get { return outerBorderWidth; }
            set
            {
                outerBorderWidth = value;

            }
        }

        /// <summary>
        /// Gets or sets the angle.
        /// </summary>
        /// <value>The angle.</value>
        public float Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                //
            }
        }

        /// <summary>
        /// Gets or sets the inner circle border.
        /// </summary>
        /// <value>The inner circle border.</value>
        public int InnerCircleBorder
        {
            get { return innercircleBorder; }
            set
            {
                innercircleBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle2 width reduction.
        /// </summary>
        /// <value>The innercircle2 width reduction.</value>
        public int Innercircle2WidthReduction
        {
            get { return innercircle2Width; }
            set
            {
                innercircle2Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle2 height reduction.
        /// </summary>
        /// <value>The innercircle2 height reduction.</value>
        public int Innercircle2HeightReduction
        {
            get { return innercircle2Height; }
            set
            {
                innercircle2Height = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle3 width reduction.
        /// </summary>
        /// <value>The innercircle3 width reduction.</value>
        public int Innercircle3WidthReduction
        {
            get { return innercircle3Width; }
            set
            {
                innercircle3Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle3 height reduction.
        /// </summary>
        /// <value>The innercircle3 height reduction.</value>
        public int Innercircle3HeightReduction
        {
            get { return innercircle3Height; }
            set
            {
                innercircle3Height = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle4 width reduction.
        /// </summary>
        /// <value>The innercircle4 width reduction.</value>
        public int Innercircle4WidthReduction
        {
            get { return innercircle4Width; }
            set
            {
                innercircle4Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle4 height reduction.
        /// </summary>
        /// <value>The innercircle4 height reduction.</value>
        public int Innercircle4HeightReduction
        {
            get { return innercircle4Height; }
            set
            {
                innercircle4Height = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle5 width reduction.
        /// </summary>
        /// <value>The innercircle5 width reduction.</value>
        public int Innercircle5WidthReduction
        {
            get { return innercircle5Width; }
            set
            {
                innercircle5Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle5 height reduction.
        /// </summary>
        /// <value>The innercircle5 height reduction.</value>
        public int Innercircle5HeightReduction
        {
            get { return innercircle5Height; }
            set
            {
                innercircle5Height = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle6 width reduction.
        /// </summary>
        /// <value>The innercircle6 width reduction.</value>
        public int Innercircle6WidthReduction
        {
            get { return innercircle6Width; }
            set
            {
                innercircle6Width = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the innercircle6 height reduction.
        /// </summary>
        /// <value>The innercircle6 height reduction.</value>
        public int Innercircle6HeightReduction
        {
            get { return innercircle6Height; }
            set
            {
                innercircle6Height = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show line].
        /// </summary>
        /// <value><c>true</c> if [show line]; otherwise, <c>false</c>.</value>
        public bool ShowLine
        {
            get { return drawLine; }
            set
            {
                drawLine = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [fill pie].
        /// </summary>
        /// <value><c>true</c> if [fill pie]; otherwise, <c>false</c>.</value>
        public bool FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating border].
        /// </summary>
        /// <value><c>true</c> if [rotating border]; otherwise, <c>false</c>.</value>
        public bool RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle1].
        /// </summary>
        /// <value><c>true</c> if [show inner circle1]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle2].
        /// </summary>
        /// <value><c>true</c> if [show inner circle2]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle3].
        /// </summary>
        /// <value><c>true</c> if [show inner circle3]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle4].
        /// </summary>
        /// <value><c>true</c> if [show inner circle4]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle5].
        /// </summary>
        /// <value><c>true</c> if [show inner circle5]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether [show inner circle6].
        /// </summary>
        /// <value><c>true</c> if [show inner circle6]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets the color of the custom fade.
        /// </summary>
        /// <value>The color of the custom fade.</value>
        public Color CustomFadeColor
        {
            get { return customHeartFade; }
            set
            {
                customHeartFade = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the line width.
        /// </summary>
        /// <value>The color of the line width.</value>
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

        /// <summary>
        /// Gets or sets the pie color1.
        /// </summary>
        /// <value>The pie color1.</value>
        public Color PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;

            }
        }

        /// <summary>
        /// Gets or sets the pie color2.
        /// </summary>
        /// <value>The pie color2.</value>
        public Color PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;

            }
        }

        /// <summary>
        /// Gets or sets the line color1.
        /// </summary>
        /// <value>The line color1.</value>
        public Color LineColor1
        {
            get { return lineColor1; }
            set
            {
                lineColor1 = value;

            }
        }

        /// <summary>
        /// Gets or sets the line color2.
        /// </summary>
        /// <value>The line color2.</value>
        public Color LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;

            }
        }

        /// <summary>
        /// Gets or sets the color inner circle1 grad1.
        /// </summary>
        /// <value>The color inner circle1 grad1.</value>
        public Color ColorInnerCircle1Grad1
        {
            get { return innerCircle1Grad1; }
            set
            {
                innerCircle1Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle1 grad2.
        /// </summary>
        /// <value>The color inner circle1 grad2.</value>
        public Color ColorInnerCircle1Grad2
        {
            get { return innerCircle1Grad2; }
            set
            {
                innerCircle1Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle2 grad1.
        /// </summary>
        /// <value>The color inner circle2 grad1.</value>
        public Color ColorInnerCircle2Grad1
        {
            get { return innerCircle2Grad1; }
            set
            {
                innerCircle2Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle2 grad2.
        /// </summary>
        /// <value>The color inner circle2 grad2.</value>
        public Color ColorInnerCircle2Grad2
        {
            get { return innerCircle2Grad2; }
            set
            {
                innerCircle2Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle3 grad1.
        /// </summary>
        /// <value>The color inner circle3 grad1.</value>
        public Color ColorInnerCircle3Grad1
        {
            get { return innerCircle3Grad1; }
            set
            {
                innerCircle3Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle3 grad2.
        /// </summary>
        /// <value>The color inner circle3 grad2.</value>
        public Color ColorInnerCircle3Grad2
        {
            get { return innerCircle3Grad2; }
            set
            {
                innerCircle3Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle4 grad1.
        /// </summary>
        /// <value>The color inner circle4 grad1.</value>
        public Color ColorInnerCircle4Grad1
        {
            get { return innerCircle4Grad1; }
            set
            {
                innerCircle4Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle4 grad2.
        /// </summary>
        /// <value>The color inner circle4 grad2.</value>
        public Color ColorInnerCircle4Grad2
        {
            get { return innerCircle4Grad2; }
            set
            {
                innerCircle4Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle5 grad1.
        /// </summary>
        /// <value>The color inner circle5 grad1.</value>
        public Color ColorInnerCircle5Grad1
        {
            get { return innerCircle5Grad1; }
            set
            {
                innerCircle5Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle5 grad2.
        /// </summary>
        /// <value>The color inner circle5 grad2.</value>
        public Color ColorInnerCircle5Grad2
        {
            get { return innerCircle5Grad2; }
            set
            {
                innerCircle5Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle6 grad1.
        /// </summary>
        /// <value>The color inner circle6 grad1.</value>
        public Color ColorInnerCircle6Grad1
        {
            get { return innerCircle6Grad1; }
            set
            {
                innerCircle6Grad1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color inner circle6 grad2.
        /// </summary>
        /// <value>The color inner circle6 grad2.</value>
        public Color ColorInnerCircle6Grad2
        {
            get { return innerCircle6Grad2; }
            set
            {
                innerCircle6Grad2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color outer border.
        /// </summary>
        /// <value>The color outer border.</value>
        public Color ColorOuterBorder
        {
            get { return colorOuterBorder; }
            set
            {
                colorOuterBorder = value;
                
            }
        }
        
        #endregion

    }
}
