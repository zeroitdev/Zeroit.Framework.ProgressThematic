// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarRect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.ProgressThematic
{


    #region  ZeroitProgressBarRect

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region  RoundRect

        /// <summary>
        /// The progress rect create round path
        /// </summary>
        private GraphicsPath ProgressRect_CreateRoundPath;

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            ProgressRect_CreateRoundPath = new GraphicsPath(FillMode.Winding);
            ProgressRect_CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F);
            ProgressRect_CreateRoundPath.CloseFigure();
            return ProgressRect_CreateRoundPath;
        }

        #endregion

        #region Private Fields
        /// <summary>
        /// The progress rect percent
        /// </summary>
        private float ProgressRect_percent;
        //private Color ProgressRect_ValueColour = Color.FromArgb(42, 119, 220);
        //private Color ProgressRect_ColorBackground = Color.FromArgb(51, 52, 55);
        //private Color ProgressRect_ColorBorder = Color.FromArgb(51, 52, 55);
        //private int ProgressRect_Corner = 8;
        #endregion

        #region  Custom Properties

        /// <summary>
        /// Gets or sets the progress rect corner.
        /// </summary>
        /// <value>The progress rect corner.</value>
        [Category("RectangularProgress ProgressRect")]
        [Browsable(false)]
        public int ProgressRect_Corner
        {
            get { return progressInput.ProgressRect_Corner; }
            set
            {
                progressInput.ProgressRect_Corner = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress rect value colour.
        /// </summary>
        /// <value>The progress rect value colour.</value>
        [Category("RectangularProgress ProgressRect")]
        [Browsable(false)]
        public Color ProgressRect_ValueColour
        {
            get
            {
                return progressInput.ProgressRect_ValueColour;
            }
            set
            {
                progressInput.ProgressRect_ValueColour = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress rect color background.
        /// </summary>
        /// <value>The progress rect color background.</value>
        [Category("RectangularProgress ProgressRect")]
        [Browsable(false)]
        public Color ProgressRect_ColorBackground
        {
            get { return progressInput.ProgressRect_ColorBackground; }
            set
            {
                progressInput.ProgressRect_ColorBackground = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress rect color border.
        /// </summary>
        /// <value>The progress rect color border.</value>
        [Category("RectangularProgress ProgressRect")]
        [Browsable(false)]
        public Color ProgressRect_ColorBorder
        {
            get { return progressInput.ProgressRect_ColorBorder; }
            set
            {
                progressInput.ProgressRect_ColorBorder = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the interpolate colors.
        /// </summary>
        /// <value>The interpolate colors.</value>
        [Category("RectangularProgress ProgressRect")]
        [Browsable(false)]
        public Color[] InterpolateColors
        {
            get { return progressInput.InterpolateColors; }
            set
            {
                progressInput.InterpolateColors = value;
                Invalidate();
            }
        }

        #endregion


        #region Event

        /// <summary>
        /// Handles the Tick event of the ProgressRect_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressRect_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the ProgressRect_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressRect_Timer_Reduced_Tick(object sender, EventArgs e)
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


        /// <summary>
        /// Zeroits the progress bar rect.
        /// </summary>
        public void ZeroitProgressBarRect()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Transparent;
            //DoubleBuffered = true;
            //Size = new Size(100, 10);

            
        }


        /// <summary>
        /// Progresses the rect paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressRect_Paint(System.Windows.Forms.PaintEventArgs e)
        {
            
            Graphics G = e.Graphics;
            //G.SmoothingMode = Smoothing;
            //G.TextRenderingHint = TextRendering;

            //G.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, G);
            }

            this.ProgressRect_percent = this.Value / this.Maximum * 100;

            int Slope = ProgressRect_Corner;
            Rectangle MyRect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath BorderPath = CreateRound(MyRect, Slope);
            G.FillPath(new SolidBrush(ProgressRect_ColorBackground), BorderPath);

            ColorBlend ProgressBlend = new ColorBlend(3);
            ProgressBlend.Colors[0] = ProgressRect_ValueColour;
            ProgressBlend.Colors[1] = ProgressRect_ValueColour;
            ProgressBlend.Colors[2] = ProgressRect_ValueColour;
            ProgressBlend.Positions = new Single[] { 0, 0.5F, 1 };
            LinearGradientBrush LGB = new LinearGradientBrush(MyRect, InterpolateColors[0], InterpolateColors[1], 90.0F);
            LGB.InterpolationColors = ProgressBlend;

            Rectangle ProgressRect = new Rectangle(1, 1, (int)System.Math.Round(((double)this.Width / (double)this.Maximum * (double)this.Value - 3.0)), this.Height - 3);
            GraphicsPath ProgressPath = CreateRound(ProgressRect, Slope);

            if (ProgressRect_percent >= 1)
            {
                G.FillPath(LGB, ProgressPath);
            }

            try
            {
                G.DrawPath(new Pen(ProgressRect_ColorBorder), BorderPath);
            }
            catch (Exception)
            {
            }

            if(ShowText)
            Helper.CenterString(e.Graphics, Convert.ToInt32(ProgressRect_percent).ToString() + PostFix, Font, new SolidBrush(ForeColor),
                this.ClientRectangle);
        }
        
    }


    


    #endregion


}
