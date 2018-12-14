// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingCompass.cs" company="Zeroit Dev Technologies">
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


    #region Rotating Compass


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //private float Angle = 90f;
        //private float pieSweepAngle = 0f;
        //private int interval = 10;
        //private bool RotatingBorder = false;
        //public enum shape { Pie, Arc }
        //private shape _shape = shape.Arc;
        //private int LineSize = 1;

        //private Color PieColor1 = Color.Beige;
        //private Color PieColor2 = Color.Blue;

        //private Color LineColor1 = Color.Yellow;
        //private Color LineColor2 = Color.Blue;

        //private Color RotatingCompass_LineWidthColor = Color.Transparent;

        //private bool FillPie = false;

        //Graphics g;
        #endregion


        #region Event

        /// <summary>
        /// Handles the Tick event of the RotatingCompass_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RotatingCompass_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Angle + 1 > 360)
            //{

            //    this.Angle = 0;
            //}
            //else
            //{
            //    this.Angle++;
            //    Invalidate();
            //}

            //if (Value + 1 > 360)
            //{

            //    this.Value = 0;
            //}
            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //} 
            #endregion


            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > 360)
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

                if (this.Angle + (Change * SpeedMultiplier) > 360)
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
                    this.Angle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.Value + (Change * SpeedMultiplier) > 360)
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

                if (this.Angle + (Change * SpeedMultiplier) > 360)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Angle = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Angle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            

        }

        /// <summary>
        /// Handles the Tick event of the RotatingCompass_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RotatingCompass_Timer_Reduced_Tick(object sender, EventArgs e)
        {


            if (this.Value < 0)
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

            if (this.Angle < 0)
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
                this.Angle -= (Change * SpeedMultiplier);
                Invalidate();
            }

        }


        /// <summary>
        /// Handles the Tick event of the RotatingCompassAngle_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RotatingCompassAngle_Timer_Tick(object sender, EventArgs e)
        {

            //if (Value + 1 > 360)
            //{

            //    this.Value = 0;
            //}
            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //}

        }

        #endregion

        #region Constructor

        /// <summary>
        /// Rotatings the compass.
        /// </summary>
        public void RotatingCompass()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            if (SolidProgressBar == ProgressBar.CPRotatingArc ||
                SolidProgressBar == ProgressBar.CPRotatingCompass
                )
            {
                Maximum = 360;
            }

        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the rotating compass line width.
        /// </summary>
        /// <value>The color of the rotating compass line width.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public Color RotatingCompass_LineWidthColor
        {
            get { return progressInput.RotatingCompass_LineWidthColor; }
            set
            {
                progressInput.RotatingCompass_LineWidthColor = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the rotating compass pie color1.
        /// </summary>
        /// <value>The rotating compass pie color1.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public Color RotatingCompass_PieColor1
        {
            get { return progressInput.PieColor1; }
            set
            {
                progressInput.PieColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass pie color2.
        /// </summary>
        /// <value>The rotating compass pie color2.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public Color RotatingCompass_PieColor2
        {
            get { return progressInput.PieColor2; }
            set
            {
                progressInput.PieColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass line color1.
        /// </summary>
        /// <value>The rotating compass line color1.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public Color RotatingCompass_LineColor1
        {
            get { return progressInput.LineColor1; }
            set
            {
                progressInput.LineColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass line color2.
        /// </summary>
        /// <value>The rotating compass line color2.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public Color RotatingCompass_LineColor2
        {
            get { return progressInput.LineColor2; }
            set
            {
                progressInput.LineColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating compass fill pie].
        /// </summary>
        /// <value><c>true</c> if [rotating compass fill pie]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public bool RotatingCompass_FillPie
        {
            get { return progressInput.FillPie; }
            set
            {
                progressInput.FillPie = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the rotating compass line.
        /// </summary>
        /// <value>The size of the rotating compass line.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public int RotatingCompass_LineSize
        {
            get { return progressInput.LineSize; }
            set
            {
                progressInput.LineSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [rotating compass rotating border].
        /// </summary>
        /// <value><c>true</c> if [rotating compass rotating border]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public bool RotatingCompass_RotatingBorder
        {
            get { return progressInput.RotatingBorder; }
            set
            {
                progressInput.RotatingBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotating compass angle.
        /// </summary>
        /// <value>The rotating compass angle.</value>
        [Category("CircularProgress Compass")]
        [Browsable(false)]
        public float RotatingCompass_Angle
        {
            get { return progressInput.Angle; }
            set
            {
                progressInput.Angle = value;
                //Invalidate();
            }
        }



        #endregion

        #region Overrides

        /// <summary>
        /// Rotatings the compass on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void RotatingCompass_OnPaint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            //timer.Interval = interval;

            //Text = "";
            
            if (RotatingBorder)
            {
                e.Graphics.DrawPie(new Pen(Color.Blue), new Rectangle(0, 0, Width - 2, Height - 2), 180, Value/Maximum * 360);

                if (FillPie)
                {
                    LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, Value / Maximum * 360);
                    e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), 180, Value / Maximum * 360);
                }

            }

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            // Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(Angle);

            #region Line
            // Draw rotated, translated ellipse to screen.
            e.Graphics.DrawRectangle(new Pen(RotatingCompass_LineWidthColor, 1), 0, 0, 1, (Width / 2));

            LinearGradientBrush brushfillrect = new LinearGradientBrush(new Rectangle(0, 0, 1, (Width / 2)), LineColor1, LineColor2, Value / Maximum * 360);

            e.Graphics.FillRectangle(brushfillrect, 0, 0, LineSize, (Width / 2));
            #endregion
            
            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value / Maximum * 100).ToString() + PostFix, Font, ForeColor, new Rectangle(0, 0, Width, Height));

            }
            
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Rotatings the compass draw text.
        /// </summary>
        /// <param name="g">The g.</param>
        private void RotatingCompass_DrawText(Graphics g)
        {
            g.DrawString("Text", new Font("Verdana", 30, FontStyle.Bold),
                Brushes.Black, 0, 10);
        }
        #endregion


    }


    #endregion


}
