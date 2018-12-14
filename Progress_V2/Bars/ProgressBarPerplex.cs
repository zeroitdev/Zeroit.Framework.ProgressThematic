// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerplex.cs" company="Zeroit Dev Technologies">
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
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {



        #region Timer Event

        /// <summary>
        /// The perplex sluggish
        /// </summary>
        private bool perplexSluggish = false;

        /// <summary>
        /// Gets or sets a value indicating whether [perplex sluggish].
        /// </summary>
        /// <value><c>true</c> if [perplex sluggish]; otherwise, <c>false</c>.</value>
        public bool PerplexSluggish
        {
            get { return perplexSluggish; }
            set
            {
                perplexSluggish = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Handles the Tick event of the ProgressBarPerplex_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerplex_Timer_Tick(object sender, EventArgs e)
        {

            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value++;
            //}


            //if (this.ColorGradientAngle + 1 > this.Maximum)
            //{
            //    this.ColorGradientAngle = 0;
            //}

            //else
            //{
            //    this.ColorGradientAngle++;
            //} 
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

                if (PerplexSluggish)
                {
                    if (this.ColorGradientAngle + (0.1f * SpeedMultiplier) > Maximum)
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
                        this.ColorGradientAngle += (Change * SpeedMultiplier);
                        Invalidate();
                    }
                }
                else
                {
                    if (this.ColorGradientAngle + (0.1f * SpeedMultiplier) > 360)
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
                        this.ColorGradientAngle += (Change * SpeedMultiplier);
                        Invalidate();
                    }
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

                if (PerplexSluggish)
                {
                    if (this.ColorGradientAngle + (0.1f * SpeedMultiplier) > Maximum)
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
                        this.ColorGradientAngle += (Change * SpeedMultiplier);
                        Invalidate();
                    }
                }
                else
                {
                    if (this.ColorGradientAngle + (0.1f * SpeedMultiplier) > 360)
                    {
                        timerDecrement.Enabled = false;
                        timerDecrement.Stop();
                        //timerDecrement.Tick += TimerDecrement_Tick;
                        ColorGradientAngle = 0;
                        Invalidate();
                    }

                    else
                    {
                        this.ColorGradientAngle += (Change * SpeedMultiplier);
                        Invalidate();
                    }
                }


            }




        }


        /// <summary>
        /// Handles the Tick event of the ProgressBarPerplex_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerplex_Timer_Reduced_Tick(object sender, EventArgs e)
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
                this.Value -= (0.1f * SpeedMultiplier);
                Invalidate();
            }

            if (PerplexSluggish)
            {
                if (this.ColorGradientAngle < this.Minimum)
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
                    this.ColorGradientAngle -= (0.1f * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.ColorGradientAngle < 0)
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
                    this.ColorGradientAngle -= (0.1f * SpeedMultiplier);
                    Invalidate();
                }
            }




        }


        #endregion

        #region Private Fields
        //private Color Perplex_ColorGradient1 = Color.FromArgb(26, 26, 26);
        //private Color Perplex_ColorGradient2 = Color.FromArgb(30, 30, 30);
        //private Color Perplex_ColorGradient3 = Color.FromArgb(174, 195, 30);
        //private Color Perplex_ColorGradient4 = Color.FromArgb(141, 153, 16);
        //private Color ColorHatchBrushgradient1 = Color.FromArgb(174, 195, 30);
        //private Color ColorHatchBrushgradient2 = Color.FromArgb(141, 153, 16);
        //private Color Perplex_BorderColor = Color.FromArgb(97, 94, 90);
        //private float ColorGradientAngle = 90f;


        //private bool Perplex_ShowPercentage = false;

        /// <summary>
        /// Enum perplex_DrawMode
        /// </summary>
        public enum perplex_DrawMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient,
            /// <summary>
            /// The hatch
            /// </summary>
            Hatch
        }


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the perplex color gradient1.
        /// </summary>
        /// <value>The perplex color gradient1.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public Color Perplex_ColorGradient1
        {
            get { return progressInput.Perplex_ColorGradient1; }
            set
            {
                progressInput.Perplex_ColorGradient1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the perplex color gradient2.
        /// </summary>
        /// <value>The perplex color gradient2.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public Color Perplex_ColorGradient2
        {
            get { return progressInput.Perplex_ColorGradient2; }
            set
            {
                progressInput.Perplex_ColorGradient2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the perplex color gradient3.
        /// </summary>
        /// <value>The perplex color gradient3.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public Color Perplex_ColorGradient3
        {
            get { return progressInput.Perplex_ColorGradient3; }
            set
            {
                progressInput.Perplex_ColorGradient3 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the perplex color gradient4.
        /// </summary>
        /// <value>The perplex color gradient4.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public Color Perplex_ColorGradient4
        {
            get { return progressInput.Perplex_ColorGradient4; }
            set
            {
                progressInput.Perplex_ColorGradient4 = value;
                Invalidate();
            }
        }

        //public Color ColorHatchBrush1
        //{
        //    get { return ColorHatchBrushgradient1; }
        //    set
        //    {
        //        ColorHatchBrushgradient1 = value;
        //        Invalidate();
        //    }
        //}

        //public Color ColorHatchBrush2
        //{
        //    get { return ColorHatchBrushgradient2; }
        //    set
        //    {
        //        ColorHatchBrushgradient2 = value;
        //        Invalidate();
        //    }
        //}
        /// <summary>
        /// Gets or sets the color of the perplex border.
        /// </summary>
        /// <value>The color of the perplex border.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public Color Perplex_BorderColor
        {
            get { return progressInput.Perplex_BorderColor; }
            set
            {
                progressInput.Perplex_BorderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color gradient angle.
        /// </summary>
        /// <value>The color gradient angle.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public float ColorGradientAngle
        {
            get { return progressInput.ColorGradientAngle; }
            set
            {
                progressInput.ColorGradientAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [perplex show percentage].
        /// </summary>
        /// <value><c>true</c> if [perplex show percentage]; otherwise, <c>false</c>.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public bool Perplex_ShowPercentage
        {
            get { return progressInput.Perplex_ShowPercentage; }
            set
            {
                progressInput.Perplex_ShowPercentage = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the perplex draw mode.
        /// </summary>
        /// <value>The perplex draw mode.</value>
        [Category("RectangularProgress Perplex")]
        [Browsable(false)]
        public perplex_DrawMode Perplex_DrawMode
        {
            get { return progressInput.Perplex_DrawMode; }
            set
            {
                progressInput.Perplex_DrawMode = value;
                Invalidate();

            }
        }

        #endregion

        /// <summary>
        /// Zeroits the progress bar perplex.
        /// </summary>
        public void ZeroitProgressBarPerplex()
        {



        }

        /// <summary>
        /// Progresses the bar perplex paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerplex_Paint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            //G.SmoothingMode = Smoothing;
            //G.TextRenderingHint = TextRendering;
            //Graphics Gtrans = Graphics.FromImage(B);

            //G.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, G);
            }

            float val = Value / Maximum;
            int intValue = Convert.ToInt32(val * Width);

            if (intValue < 2)
            {
                intValue = 2;
            }


            Color C1 = Color.FromArgb(174, 195, 30);
            Color C2 = Color.FromArgb(141, 153, 16);
            Rectangle R1 = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle R2 = new Rectangle(0, 0, intValue - 1, Height - 1);
            Rectangle R3 = new Rectangle(0, 0, intValue - 1, Height - 2);
            GraphicsPath GP1 = Zeroit.Framework.ProgressThematic.RoundRectangle.RoundRect(R1, 1);
            GraphicsPath GP2 = Zeroit.Framework.ProgressThematic.RoundRectangle.RoundRect(R2, 2);
            GraphicsPath GP3 = Zeroit.Framework.ProgressThematic.RoundRectangle.RoundRect(R3, 1);

            //LinearGradientBrush gB = new LinearGradientBrush(R1, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90);
            LinearGradientBrush gB = new LinearGradientBrush(R1, Perplex_ColorGradient1, Perplex_ColorGradient2, ColorGradientAngle);
            LinearGradientBrush g1 = new LinearGradientBrush(new Rectangle(2, 2, intValue - 1, Height - 2), Perplex_ColorGradient3, Perplex_ColorGradient4, ColorGradientAngle);
            //HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(50, C1), Color.FromArgb(25, C2));
            HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
            Pen P1 = new Pen(Perplex_BorderColor);


            switch (Perplex_DrawMode)
            {
                case perplex_DrawMode.Solid:
                    G.FillRectangle(new SolidBrush(Perplex_ColorGradient1), R3);
                    break;
                case perplex_DrawMode.Gradient:
                    G.FillPath(gB, GP1);
                    G.FillPath(g1, GP3);
                    break;
                case perplex_DrawMode.Hatch:
                    #region HatchBrush Paint
                    switch (HatchBrush)
                    {
                        case HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB, GP3);
                            break;
                        case HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB1, GP3);
                            break;
                        case HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB2, GP3);
                            break;
                        case HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB3, GP3);
                            break;
                        case HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB4, GP3);
                            break;
                        case HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB5, GP3);
                            break;
                        case HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB6, GP3);
                            break;
                        case HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB7, GP3);
                            break;
                        case HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB8, GP3);
                            break;
                        case HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB9, GP3);
                            break;
                        case HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBA, GP3);
                            break;
                        case HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBB, GP3);
                            break;
                        case HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBC, GP3);
                            break;
                        case HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBD, GP3);
                            break;
                        case HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBE, GP3);
                            break;
                        case HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBF, GP3);
                            break;
                        case HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBG, GP3);
                            break;
                        case HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBH, GP3);
                            break;
                        case HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBI, GP3);
                            break;
                        case HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBJ, GP3);
                            break;
                        case HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBK, GP3);
                            break;
                        case HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBL, GP3);
                            break;
                        case HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBM, GP3);
                            break;
                        case HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBN, GP3);
                            break;
                        case HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBO, GP3);
                            break;
                        case HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBP, GP3);
                            break;
                        case HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBQ, GP3);
                            break;
                        case HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBR, GP3);
                            break;
                        case HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBS, GP3);
                            break;
                        case HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBT, GP3);
                            break;
                        case HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBU, GP3);
                            break;
                        case HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBV, GP3);
                            break;
                        case HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBW, GP3);
                            break;
                        case HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBX, GP3);
                            break;
                        case HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBY, GP3);
                            break;
                        case HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBZ, GP3);
                            break;
                        case HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB10, GP3);
                            break;
                        case HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB11, GP3);
                            break;
                        case HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB12, GP3);
                            break;
                        case HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB13, GP3);
                            break;
                        case HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB14, GP3);
                            break;
                        case HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB15, GP3);
                            break;
                        case HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB16, GP3);
                            break;
                        case HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB17, GP3);
                            break;
                        case HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB18, GP3);
                            break;
                        case HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB19, GP3);
                            break;
                        case HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB20, GP3);
                            break;
                        case HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB21, GP3);
                            break;
                        case HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB22, GP3);
                            break;
                        case HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB23, GP3);
                            break;
                        case HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB24, GP3);
                            break;
                        case HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB25, GP3);
                            break;
                        case HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB26, GP3);
                            break;
                        case HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB27, GP3);
                            break;
                        case HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB28, GP3);
                            break;
                        case HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB29, GP3);
                            break;
                        default:
                            break;
                    }
                    #endregion
                    break;

            }



            //G.FillPath(h1, GP3);
            G.DrawPath(P1, GP1);
            //G.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), GP2);
            G.DrawPath(new Pen(Perplex_BorderColor), GP2);
            G.DrawPath(P1, GP2);

            if (ShowText)
                G.DrawString(Convert.ToString(string.Concat((int)Value, PostFix)), Font, new SolidBrush(ForeColor), R1, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            //e.Graphics.DrawImage((Image)B.Clone(), 0, 0);


        }


    }

}
