// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio - Gradient.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic
{
    #region ProgressBarGradient

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Constructor
        /// <summary>
        /// Zeroits the progress bar normal gradient.
        /// </summary>
        public void ZeroitProgressBarNormalGradient()
        {
            GradientPercent = 100;
            GradientType = GradientTypes.FullWidthGradient;
        }
        #endregion

        #region Private Methods and Paint Events

        /// <summary>
        /// Prepare3s the parts.
        /// </summary>
        /// <returns>Rectangle[].</returns>
        private new Rectangle[] Prepare3Parts()
        {
            Rectangle xRec = ClientRectangle;
            int MiddleWidth = MathHelpers.MyMaths.Percent(xRec.Width, GradientPercent);
            xRec.Inflate(MiddleWidth, 0);
            int Left = MathHelpers.MyMaths.Percent(ClientRectangle.Width + MiddleWidth, (int)_iPercent);
            int Right = xRec.Width - MiddleWidth - Left;
            return ProgressThematic.Drawing.MyRectangle.SplitByPixels(xRec, new int[] { Left, MiddleWidth, Right }, Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitType.Horizontal);
        }
        /// <summary>
        /// Prepare4s the parts.
        /// </summary>
        /// <returns>Rectangle[].</returns>
        private Rectangle[] Prepare4Parts()
        {
            Rectangle[] xRecs = Prepare3Parts();
            Rectangle[] xMiddleparts = ProgressThematic.Drawing.MyRectangle.SplitByPercent(xRecs[1], new int[] { 50, 50 }, Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitType.Horizontal);
            return new Rectangle[] { xRecs[0], xMiddleparts[0], xMiddleparts[1], xRecs[2] };
        }

        /// <summary>
        /// Progresses the bar gradient draw background rolling.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarGradient_DrawBackgroundRolling(Graphics g)
        {
            if (_iPercent == 0)
            {
               ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                //return;
            }
            Rectangle[] xRecs = Prepare4Parts();
            xRecs[1].Width++;
            BrushAndFill(g, xRecs[2], ColorProgress, BackColor);
            BrushAndFill(g, xRecs[1], BackColor, ColorProgress);

        }

        /// <summary>
        /// Progresses the bar gradient draw background.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarGradient_DrawBackground(Graphics g)
        {
            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                //return;
            }
            Rectangle[] xRecs = null;
            xRecs = Prepare3Parts();
            Rectangle xRectLeft = xRecs[0];
            Rectangle xRectMiddle = xRecs[1];
            Rectangle xRectRight = xRecs[2];
            xRectLeft.Width++;
            BrushAndFill(g, xRectMiddle, ColorProgress, BackColor);
            ProgressBarNormal_FillRectangle(g, xRectLeft, xBrushes[BrushProgress]);
            ProgressBarNormal_FillRectangle(g, xRectRight, xBrushes[BrushBackGround]);

        }

        /// <summary>
        /// Brushes the and fill.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="xRec">The x record.</param>
        /// <param name="xColor1">The x color1.</param>
        /// <param name="xColor2">The x color2.</param>
        private void BrushAndFill(Graphics g, Rectangle xRec, Color xColor1, Color xColor2)
        {
            if (xRec.Width == 0)
                return;
            Brush xBrush = new LinearGradientBrush(xRec, xColor1, xColor2, 0f);
            g.FillRectangle(xBrush, xRec);
            xBrush.Dispose();
        }

        /// <summary>
        /// Progresses the bar gradient paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressBarGradient_Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;

            if (allowTransparency)
            {
                MakeTransparent(this, g);
            }

            //g.Clear(BackColor);

            if (RollingType == RollingTypes.None)
                ProgressBarGradient_DrawBackground(g);
            else
                ProgressBarGradient_DrawBackgroundRolling(g);
            if (RollingType == RollingTypes.None)
                ProgressBarNormal_DrawText(g);

            ProgressBarNormal_DrawBorder(g);
        }



        #endregion

        #region Enums
        /// <summary>
        /// Enum GradientTypes
        /// </summary>
        public enum GradientTypes
        {
            /// <summary>
            /// The specific width gradient
            /// </summary>
            SpecificWidthGradient,
            /// <summary>
            /// The full width gradient
            /// </summary>
            FullWidthGradient
        }
        #endregion

        #region Private Fields

        //private int GradientPercent = 20;
        //private GradientTypes GradientType = GradientTypes.FullWidthGradient; 

        #endregion

        #region Public  Properties
        //        protected const string BrushGradient = "BrushGradient";
        //        protected const string BrushGradientReversed = "BrushGradientReversed";


        /// <summary>
        /// Gets or sets the gradient percent.
        /// </summary>
        /// <value>The gradient percent.</value>
        /// <exception cref="ArgumentOutOfRangeException">GradientPercent - Must be between 1 and 100</exception>
        [Description("Gradient Percentage of Control"), 
            Category("RectangularProgress Antonio-Gradient")]
        [Browsable(false)]
        public int GradientPercent
        {
            get
            {
                return progressInput.GradientPercent;
            }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentOutOfRangeException("GradientPercent", "Must be between 1 and 100");
                if (GradientType == GradientTypes.FullWidthGradient)
                    return;
                progressInput.GradientPercent = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the type of the gradient.
        /// </summary>
        /// <value>The type of the gradient.</value>
        [Description("Gradient Type"), 
            Category("RectangularProgress Antonio-Gradient")]
        [Browsable(false)]
        public GradientTypes GradientType
        {
            get
            {
                return progressInput.GradientType;
            }
            set
            {
                if (value == GradientTypes.SpecificWidthGradient)
                    GradientPercent = 50;
                if (value == GradientTypes.FullWidthGradient)
                    GradientPercent = 100;
                progressInput.GradientType = value;
                Invalidate();
            }
        }


        #endregion
        
        
    }

    #endregion
}
