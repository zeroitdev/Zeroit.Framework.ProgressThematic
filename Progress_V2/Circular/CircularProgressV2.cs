// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV2.cs" company="Zeroit Dev Technologies">
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
    #region CircularProgressv2

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        //private int CPv2_ProgressWidth = 2;
        //private int CPv2_Shift = 0;
        //private int _Value = 40;
        //private int Maximum = 100;
        /// <summary>
        /// The c PV2 remainder angle
        /// </summary>
        int CPv2_remainderAngle = 0;
        //int CPv2_StartAngle = 80;

        //private bool CPv2_ShowText = true;



        #region Include in Private Field



        #endregion

        #region Include in Public Properties
        /// <summary>
        /// Gets or sets the color of the c PV2.
        /// </summary>
        /// <value>The color of the c PV2.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]
        public Color CPv2_Color
        {
            get { return progressInput.CPv2_Color; }
            set
            {
                progressInput.CPv2_Color = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the c PV2 color empty.
        /// </summary>
        /// <value>The c PV2 color empty.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public Color CPv2_ColorEmpty
        {
            get { return progressInput.CPv2_ColorEmpty; }
            set
            {
                progressInput.CPv2_ColorEmpty = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [c PV2 show text].
        /// </summary>
        /// <value><c>true</c> if [c PV2 show text]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public bool CPv2_ShowText
        {
            get { return progressInput.CPv2_ShowText; }
            set
            {
                progressInput.CPv2_ShowText = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV2")]
        //[Browsable(false)]

        //public int Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the c PV2 start angle.
        /// </summary>
        /// <value>The c PV2 start angle.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public int CPv2_StartAngle
        {
            get { return progressInput.CPv2_StartAngle; }
            set
            {
                progressInput.CPv2_StartAngle = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV2")]
        //[Browsable(false)]

        //public int Value
        //{
        //    get { return _Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //        {
        //            value = Maximum;
        //        }

        //        _Value = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the c PV2 shift.
        /// </summary>
        /// <value>The c PV2 shift.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public int CPv2_Shift
        {
            get { return progressInput.CPv2_Shift; }
            set
            {
                progressInput.CPv2_Shift = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the c PV2 progress.
        /// </summary>
        /// <value>The width of the c PV2 progress.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public int CPv2_ProgressWidth
        {
            get { return progressInput.CPv2_ProgressWidth; }
            set
            {
                progressInput.CPv2_ProgressWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV2 angle reduced.
        /// </summary>
        /// <value>The c PV2 angle reduced.</value>
        [Category("CircularProgress CircularProgressV2")]
        [Browsable(false)]

        public int CPv2_AngleReduced
        {
            get { return progressInput.CPv2_AngleReduced; }
            set
            {
                progressInput.CPv2_AngleReduced = value;
                Invalidate();
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the CPv2_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv2_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value++;

            //    //Invalidate();
            //}

            //if (CPv2_StartAngle + 1 > 300)
            //{
            //    CPv2_StartAngle = -60;
            //}

            //else
            //{
            //    CPv2_remainderAngle++;
            //    Invalidate();
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

                if (this.CPv2_StartAngle + (Change * SpeedMultiplier) > 300)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    CPv2_StartAngle = -60;
                    Invalidate();
                }

                else
                {
                    this.CPv2_StartAngle += (int)(Change * SpeedMultiplier);
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

                if (this.CPv2_StartAngle + (Change * SpeedMultiplier) > 300)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    CPv2_StartAngle = -60;
                    Invalidate();
                }

                else
                {
                    this.CPv2_StartAngle += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            
        }

        /// <summary>
        /// Handles the Tick event of the CPv2_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv2_Timer_Reduced_Tick(object sender, EventArgs e)
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


            if (this.CPv2_StartAngle < -60)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                CPv2_StartAngle = 60;
                Invalidate();
            }

            else
            {
                this.CPv2_StartAngle -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }


        }

        #endregion

        #region Paint Events

        /// <summary>
        /// cs the PV2 paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CPv2_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;

            g.Clear(BackColor);
            
            Rectangle rect = new Rectangle(CPv2_Shift, CPv2_Shift, Width - CPv2_ProgressWidth, Height - CPv2_ProgressWidth);

            float percentage = Value;

            //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

            float progressAngle = Convert.ToSingle(360 * (percentage / Maximum));

            CPv2_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(CPv2_Color, CPv2_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(CPv2_ColorEmpty, CPv2_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, CPv2_StartAngle, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - CPv2_AngleReduced, CPv2_remainderAngle);
                }
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 14))
            {

                string text = Convert.ToInt32(percentage).ToString() + PostFix;
                dynamic textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text

                if (ShowText)
                {
                    g.DrawString(text, Font, new SolidBrush(ForeColor), textPoint);
                }

                else
                {
                    g.DrawString(text, Font, new SolidBrush(Color.Transparent), textPoint);
                }

            }

            //Form2_Paint(e);
        }

        /// <summary>
        /// Draws the progress.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="rect">The rect.</param>
        /// <param name="percentage">The percentage.</param>
        private void DrawProgress(Graphics g, Rectangle rect, float percentage)
        {
            //work out the angles for each arc
            float progressAngle = Convert.ToSingle(360 / 100 * percentage);
            int CPv2_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(CPv2_Color, CPv2_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(CPv2_ColorEmpty, CPv2_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, -60, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - 90, CPv2_remainderAngle);
                }
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 14))
            {
                string text = percentage.ToString() + "%";
                dynamic textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text
                g.DrawString(text, fnt, new SolidBrush(ForeColor), textPoint);
            }
        }

        #endregion

    }

    #endregion
}
