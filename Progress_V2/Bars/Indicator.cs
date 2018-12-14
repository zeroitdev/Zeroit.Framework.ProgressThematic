// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Indicator.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region Indicator Control

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //Int32 _Maximum;

        //Int32 _Value;
        /// <summary>
        /// The graph width
        /// </summary>
        float _GraphWidth;


        //private Color Color = Color.Black;

        //private Color BorderColor = Color.Black;
        #endregion

        #region Constructor

        /// <summary>
        /// Zeroits the indicator.
        /// </summary>
        public void ZeroitIndicator()
        {
            //SetStyle(
            //    ControlStyles.UserPaint |
            //    //ControlStyles.DoubleBuffer |
            //    ControlStyles.ResizeRedraw,
            //    true
            //    );
            //_Maximum = Int32.MaxValue;
            //_Minimum = 0;
            //_Value = 0;
            //_GraphWidth = 33;

            _GraphWidth = Size.Width - 3;
            

        }

        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the width of the graph.
        /// </summary>
        /// <value>The width of the graph.</value>
        [Category("RectangularProgress Indicator")]
        [Browsable(false)]
        public float GraphWidth
        {
            get
            {
                return _GraphWidth;
            }
            set
            {
                _GraphWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        [Category("RectangularProgress Indicator")]
        [Browsable(false)]
        public Color Color
        {
            get { return progressInput.Color; }
            set
            {
                progressInput.Color = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        [Category("RectangularProgress Indicator")]
        [Browsable(false)]
        public Color BorderColor
        {
            get { return progressInput.BorderColor; }
            set
            {
                progressInput.BorderColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Overrides

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x00000200; // WS_EX_CLIENTEDGE
        //        return cp;
        //    }
        //}


        /// <summary>
        /// Zeroits the indicator paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ZeroitIndicator_Paint(PaintEventArgs e)
        {
            //Graphics graph = CreateGraphics();

            //Graphics graph = e.Graphics;

            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

            //e.Graphics.Clear(BackColor);

            

            SolidBrush b = new SolidBrush(Color);
            float w = this.ClientSize.Width;
            float h = this.ClientSize.Height;
            float y = h;
            // draw text
            y -= this.Font.Height + 4;
            RectangleF r = new RectangleF(0, y, w, h);
            StringFormat f = new StringFormat(StringFormatFlags.NoWrap);
            f.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(Convert.ToInt32(Value).ToString() + postFix, this.Font, b, r, f);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

            // draw graph
            float graphheight = h - 6 - 4 - this.Font.Height - 4;
            graphheight += 1;
            float lines = graphheight / 3;
            Byte red = (Byte)(this.Color.R / 2);
            Byte green = (Byte)(this.Color.G / 2);
            Byte blue = (Byte)(this.Color.B / 2);
            Color dimmed = Color.FromArgb(red, green, blue);
            Pen dpen = new Pen(dimmed);
            Pen hpen = new Pen(this.BorderColor);
            dpen.DashStyle = DashStyle.Dot;
            float lx = (w - this.GraphWidth) / 2;
            float ly = h - 4 - this.Font.Height - 7;
            float lw = this.GraphWidth / 2;
            float x0 = lx;
            float y0 = 0;
            float x1 = 0;
            float y1 = 0;
            float linestohighlite = (this.Value - this.Minimum) * 1.0f /((this.Maximum - this.Minimum * 1.0f) / lines); 
                //(float)Math.Ceiling(
            //    (this.Value - this.Minimum) * 1.0 /
            //    ((this.Maximum - this.Minimum * 1.0) / lines)
            //    );
            for (float i = 0; i < lines; i++)
            {
                x0 = lx;
                y0 = ly - (i * 3) - 1;
                x1 = x0 + lw;
                y1 = y0;
                if (i < linestohighlite)
                {
                    e.Graphics.FillRectangle(b, x0, y0, lw, 2);
                    e.Graphics.FillRectangle(b, x1 + 1, y0, lw, 2);
                }
                else
                {
                    // left two lines
                    e.Graphics.DrawLine(dpen, x0, y0, x1, y1);
                    e.Graphics.DrawLine(dpen, x0 + 1, y0 + 1, x1, y1 + 1);
                    // right two lines
                    x0 = x1 + 1;
                    x1 = x0 + lw;
                    e.Graphics.DrawLine(dpen, x0, y0, x1, y1);
                    e.Graphics.DrawLine(dpen, x0 + 1, y0 + 1, x1, y1 + 1);
                }
            }
            //hpen.Dispose();
            //dpen.Dispose();
            //b.Dispose();
        }


        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the ZeroitIndicator_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ZeroitIndicator_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the ZeroitIndicator_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ZeroitIndicator_Timer_Reduced_Tick(object sender, EventArgs e)
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





    }

    #endregion
}
