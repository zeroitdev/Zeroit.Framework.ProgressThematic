// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV4.cs" company="Zeroit Dev Technologies">
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
    #region CircularProgressv4


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        //private int CPv4_StartAngle = -90;
        //private int Value;
        //private int Maximum = 100;
        //private int CPv4_Thickness = 20;
        //private float CPv4_GradientAngle = 90f;

        //private LineCap CPv4_StartCap = LineCap.Round;
        //private LineCap CPv4_EndCap = LineCap.Round;
        //private Color CPv4_InnerBorder = Color.Black;
        //private Color CPv4_OuterBorder = Color.Black;

        //private Color CPv4_ProgressGrad1 = Color.DarkSlateGray;
        //private Color CPv4_ProgressGrad2 = Color.Orange;

        //private Color CPv4_ProgressBackGrad1 = Color.White;
        //private Color CPv4_ProgressBackGrad2 = Color.White;

        //private int CPv4_Speed = 100;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the c PV4 speed.
        /// </summary>
        /// <value>The c PV4 speed.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public int CPv4_Speed
        {
            get { return progressInput.CPv4_Speed; }
            set
            {
                progressInput.CPv4_Speed = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 gradient angle.
        /// </summary>
        /// <value>The c PV4 gradient angle.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public float CPv4_GradientAngle
        {
            get { return progressInput.CPv4_GradientAngle; }
            set
            {
                progressInput.CPv4_GradientAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 progress back grad1.
        /// </summary>
        /// <value>The c PV4 progress back grad1.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_ProgressBackGrad1
        {
            get { return progressInput.CPv4_ProgressBackGrad1; }
            set
            {
                progressInput.CPv4_ProgressBackGrad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 progress back grad2.
        /// </summary>
        /// <value>The c PV4 progress back grad2.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_ProgressBackGrad2
        {
            get { return progressInput.CPv4_ProgressBackGrad2; }
            set
            {
                progressInput.CPv4_ProgressBackGrad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 progress grad1.
        /// </summary>
        /// <value>The c PV4 progress grad1.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_ProgressGrad1
        {
            get { return progressInput.CPv4_ProgressGrad1; }
            set
            {
                progressInput.CPv4_ProgressGrad1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 progress grad2.
        /// </summary>
        /// <value>The c PV4 progress grad2.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_ProgressGrad2
        {
            get { return progressInput.CPv4_ProgressGrad2; }
            set
            {
                progressInput.CPv4_ProgressGrad2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 inner border.
        /// </summary>
        /// <value>The c PV4 inner border.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_InnerBorder
        {
            get { return progressInput.CPv4_InnerBorder; }
            set
            {
                progressInput.CPv4_InnerBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 outer border.
        /// </summary>
        /// <value>The c PV4 outer border.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color CPv4_OuterBorder
        {
            get { return progressInput.CPv4_OuterBorder; }
            set
            {
                progressInput.CPv4_OuterBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 fill ellipse.
        /// </summary>
        /// <value>The c PV4 fill ellipse.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public Color[] CPv4_FillEllipse
        {
            get { return progressInput.CPv4_FillEllipse; }
            set
            {
                progressInput.CPv4_FillEllipse = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV4")]
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

        //[Category("CircularProgress CircularProgressV4")]
        //[Browsable(false)]
        //public int Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //        {
        //            value = Maximum;
        //        }

        //        Value = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the c PV4 thickness.
        /// </summary>
        /// <value>The c PV4 thickness.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public int CPv4_Thickness
        {
            get { return progressInput.CPv4_Thickness; }
            set
            {
                progressInput.CPv4_Thickness = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the c PV4 inner border thickness.
        /// </summary>
        /// <value>The c PV4 inner border thickness.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public int CPv4_InnerBorderThickness
        {
            get { return progressInput.CPv4_InnerBorderThickness; }
            set
            {
                progressInput.CPv4_InnerBorderThickness = value;
                Invalidate();

            }
        }
        /// <summary>
        /// Gets or sets the c PV4 outer border thickness.
        /// </summary>
        /// <value>The c PV4 outer border thickness.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public int CPv4_OuterBorderThickness
        {
            get { return progressInput.CPv4_OuterBorderThickness; }
            set
            {
                progressInput.CPv4_OuterBorderThickness = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the c PV4 start angle.
        /// </summary>
        /// <value>The c PV4 start angle.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public int CPv4_StartAngle
        {
            get { return progressInput.CPv4_StartAngle; }
            set
            {
                progressInput.CPv4_StartAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 start cap.
        /// </summary>
        /// <value>The c PV4 start cap.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public LineCap CPv4_StartCap
        {
            get { return progressInput.CPv4_StartCap; }
            set
            {
                progressInput.CPv4_StartCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 end cap.
        /// </summary>
        /// <value>The c PV4 end cap.</value>
        [Category("CircularProgress CircularProgressV4")]
        [Browsable(false)]
        public LineCap CPv4_EndCap
        {
            get { return progressInput.CPv4_EndCap; }
            set
            {
                progressInput.CPv4_EndCap = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint Events
        //Handle PaintBackground to prevent flicker



        /// <summary>
        /// cs the PV4 paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CPv4_Paint(PaintEventArgs e)
        {

            //Create image buffer
            //Bitmap B = new Bitmap(Width, Height);
            //timer.Interval = CPv4_Speed;
            Graphics G = e.Graphics;
            //G.SmoothingMode = Smoothing;
            //G.TextRenderingHint = TextRendering;
            G.Clear(BackColor);
            
            
            float percentage = Value;

            //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

            float progressAngle = Convert.ToSingle(360 * (percentage / Maximum));

            int remainderAngle = 360 - Convert.ToInt32(progressAngle);


            //Draw progress background
            using (LinearGradientBrush T = new LinearGradientBrush(ClientRectangle, CPv4_ProgressGrad1, CPv4_ProgressGrad2, LinearGradientMode.Vertical))
            {
                using (Pen P = new Pen(T, CPv4_Thickness))
                {
                    G.DrawArc(P, Convert.ToInt32(CPv4_Thickness / 2), Convert.ToInt32(CPv4_Thickness / 2), Width - CPv4_Thickness - 1, Height - CPv4_Thickness - 1, 0, /*360 * (Value / Maximum)*/ 360);
                }
            }

            //Draw progress
            using (LinearGradientBrush T = new LinearGradientBrush(ClientRectangle, CPv4_ProgressBackGrad1, CPv4_ProgressBackGrad2, LinearGradientMode.Vertical))
            {
                using (Pen P = new Pen(T, CPv4_Thickness))
                {
                    P.StartCap = CPv4_StartCap;
                    P.EndCap = CPv4_EndCap;
                    G.DrawArc(P, Convert.ToInt32(CPv4_Thickness / 2), Convert.ToInt32(CPv4_Thickness / 2), Width - CPv4_Thickness - 1, Height - CPv4_Thickness - 1, /*CPv4_StartAngle*/progressAngle - 90, /*360 * (Value/Maximum)*/ remainderAngle);
                }
            }

            //Draw center
            LinearGradientBrush fillEllipse = new LinearGradientBrush(ClientRectangle, CPv4_FillEllipse[0], CPv4_FillEllipse[1],
                CPv4_GradientAngle);

            G.FillEllipse(fillEllipse, CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);

            //using ()
            //{
                
            //}

            //Draw progress string
            SizeF S = G.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                G.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, new SolidBrush(ForeColor), Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            //Draw outter border
            G.DrawEllipse(new Pen(CPv4_OuterBorder, CPv4_OuterBorderThickness), 0, 0, Width - 1, Height - 1);

            //Draw inner border
            G.DrawEllipse(new Pen(CPv4_InnerBorder, CPv4_InnerBorderThickness), CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);

            //Output the buffered image
            //e.Graphics.DrawImage(B, 0, 0);

            //base.OnPaint(e);


        }
        #endregion


        #region Timer Event

        /// <summary>
        /// Handles the Tick event of the CPv4_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv4_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //}

            //if (this.CPv4_GradientAngle + 1 > 360)
            //{
            //    this.CPv4_GradientAngle = 0;
            //}

            //else
            //{
            //    this.CPv4_GradientAngle++;
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

                if (this.CPv4_GradientAngle + (Change * SpeedMultiplier) > 360)
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
                    this.CPv4_GradientAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.CPv4_GradientAngle + (Change * SpeedMultiplier) > 360)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    CPv4_GradientAngle = 0;
                    Invalidate();
                }

                else
                {
                    this.CPv4_GradientAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }

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
        /// Handles the Tick event of the CPv4_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv4_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.Value < Minimum)
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

            if (this.CPv4_GradientAngle < 0)
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
                this.CPv4_GradientAngle -= (Change * SpeedMultiplier);
                Invalidate();
            }
        }

        #endregion

    }

    #endregion
}
