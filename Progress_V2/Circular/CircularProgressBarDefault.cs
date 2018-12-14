// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBarDefault.cs" company="Zeroit Dev Technologies">
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

    #region Circular ProgressBar Default

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Enums

        //public enum _ProgressShape
        //{
        //    Round,
        //    Flat
        //}

        #endregion

        #region Variables



        //private Color ProgressColor1_Default = Color.FromArgb(92, 92, 92);
        //private Color ProgressColor2_Default = Color.FromArgb(92, 92, 92);
        //private _ProgressShape ProgressShape_Default;

        #endregion

        #region Custom Properties

        //[Category("CircularProgress ZeroitProgressCircularDefault")]
        //[Browsable(false)]
        //public long CircularDefault_Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //            value = Maximum;
        //        Value = value;
        //        Invalidate();
        //    }
        //}

        //[Category("CircularProgress ZeroitProgressCircularDefault")]
        //[Browsable(false)]
        //public long CircularDefault_Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        if (value < 1)
        //            value = 1;
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the progress color1 default.
        /// </summary>
        /// <value>The progress color1 default.</value>
        [Category("CircularProgress ZeroitProgressCircularDefault")]
        [Browsable(false)]
        public Color ProgressColor1_Default
        {
            get { return progressInput.ProgressColor1_Default; }
            set
            {
                progressInput.ProgressColor1_Default = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress color2 default.
        /// </summary>
        /// <value>The progress color2 default.</value>
        [Category("CircularProgress ZeroitProgressCircularDefault")]
        [Browsable(false)]
        public Color ProgressColor2_Default
        {
            get { return progressInput.ProgressColor2_Default; }
            set
            {
                progressInput.ProgressColor2_Default = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress shape default.
        /// </summary>
        /// <value>The progress shape default.</value>
        [Category("CircularProgress ZeroitProgressCircularDefault")]
        [Browsable(false)]
        public _ProgressShape ProgressShape_Default
        {
            get { return progressInput.ProgressShape_Default; }
            set
            {
                progressInput.ProgressShape_Default = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the progress inner color1 default.
        /// </summary>
        /// <value>The progress inner color1 default.</value>
        [Category("CircularProgress ZeroitProgressCircularDefault")]
        [Browsable(false)]
        public Color ProgressInnerColor1_Default
        {
            get { return progressInput.ProgressInnerColor1_Default; }
            set
            {
                progressInput.ProgressInnerColor1_Default = value;
                Invalidate();

            }
        }
        /// <summary>
        /// Gets or sets the progress inner color2 default.
        /// </summary>
        /// <value>The progress inner color2 default.</value>
        [Category("CircularProgress ZeroitProgressCircularDefault")]
        [Browsable(false)]
        public Color ProgressInnerColor2_Default
        {
            get { return progressInput.ProgressInnerColor2_Default; }
            set
            {
                progressInput.ProgressInnerColor2_Default = value;
                Invalidate();

            }
        }


        #endregion

        #region EventArgs





        #endregion

        //public void ZeroitProgressBarCircularDefault()
        //{
        //    Size = new Size(130, 130);
        //    Font = new Font("Segoe UI", 15);
        //    MinimumSize = new Size(100, 100);
        //    DoubleBuffered = true;
        //}


        //public void Increment(int Val)
        //{
        //    this.Value += Val;
        //    Invalidate();
        //}

        //public void Decrement(int Val)
        //{
        //    this.Value -= Val;
        //    Invalidate();
        //}

        /// <summary>
        /// Handles the Tick event of the CircularDef_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CircularDef_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the CircularDef_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CircularDef_Timer_Reduced_Tick(object sender, EventArgs e)
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


        /// <summary>
        /// Zeroits the progress bar circular default paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ZeroitProgressBarCircularDefault_Paint(PaintEventArgs e)
        {
            
            Graphics graphics = e.Graphics;
            //graphics.SmoothingMode = Smoothing;
            //graphics.TextRenderingHint = TextRendering;

            graphics.Clear(this.BackColor);
            
            LinearGradientBrush brush =
                new LinearGradientBrush(this.ClientRectangle,
                    this.ProgressColor1_Default, this.ProgressColor2_Default,
                    LinearGradientMode.ForwardDiagonal);

            Pen pen = new Pen(brush, 10f);

            LinearGradientBrush brush2 = new LinearGradientBrush(this.ClientRectangle, ProgressInnerColor1_Default,
                ProgressInnerColor2_Default, LinearGradientMode.Vertical);

            switch (this.ProgressShape_Default)
            {
                case _ProgressShape.Round:
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    break;

                case _ProgressShape.Flat:
                    pen.StartCap = LineCap.Flat;
                    pen.EndCap = LineCap.Flat;
                    break;
            }

            graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, -90, (int)System.Math.Round((float)((360.0 / ((float)this.Maximum)) * this.Value)));

            
            graphics.FillEllipse(brush2, 0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1);
                    
            SizeF MS = graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, Brushes.White, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));

            //e.Graphics.DrawImage(bitmap, 0, 0);
            
            //graphics.Dispose();
            //bitmap.Dispose();
            
        }
        

    }


    


    #endregion
    
}
