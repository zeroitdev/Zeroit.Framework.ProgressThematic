// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarTransparent.cs" company="Zeroit Dev Technologies">
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
    #region ZeroitProgressBarTransparent


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Event

        /// <summary>
        /// Handles the Tick event of the Transparent_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Transparent_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the Transparent_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Transparent_Timer_Reduced_Tick(object sender, EventArgs e)
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

        #region Private Fields

        //private Boolean Trans_ShowText = true;
        //private Color Trans_Background = Color.Blue;
        //private Color Trans_ProgressColor1 = Color.Red;
        //private Color Trans_ProgressColor2 = Color.Gray;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the trans show text.
        /// </summary>
        /// <value>The trans show text.</value>
        [Category("RectangularProgress Transparent")]
        [Browsable(false)]
        public Boolean Trans_ShowText
        {
            get { return progressInput.Trans_ShowText; }
            set
            {
                progressInput.Trans_ShowText = value;
                Invalidate(); 
            }
        }

        /// <summary>
        /// Gets or sets the trans background.
        /// </summary>
        /// <value>The trans background.</value>
        [Category("RectangularProgress Transparent")]
        [Browsable(false)]
        public Color Trans_Background
        {
            get
            {
                return progressInput.Trans_Background;
            }

            set
            {
                progressInput.Trans_Background = value;
                Invalidate();
            }

        }

        /// <summary>
        /// Gets or sets the trans progress color1.
        /// </summary>
        /// <value>The trans progress color1.</value>
        [Category("RectangularProgress Transparent")]
        [Browsable(false)]
        public Color Trans_ProgressColor1
        {
            get
            {
                return progressInput.Trans_ProgressColor1;
            }

            set
            {
                progressInput.Trans_ProgressColor1 = value;
                Invalidate();
            }

        }

        /// <summary>
        /// Gets or sets the trans progress color2.
        /// </summary>
        /// <value>The trans progress color2.</value>
        [Category("RectangularProgress Transparent")]
        [Browsable(false)]
        public Color Trans_ProgressColor2
        {
            get
            {
                return progressInput.Trans_ProgressColor2;
            }

            set
            {
                progressInput.Trans_ProgressColor2 = value;
                Invalidate();
            }

        }



        #endregion

        /// <summary>
        /// Zeroits the progress bar transparent.
        /// </summary>
        public void ZeroitProgressBarTransparent()
        {
            
        }

        /// <summary>
        /// Transparents the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Transparent_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;
            g.Clear(BackColor);


            LinearGradientBrush l = new LinearGradientBrush(new Point(0, 0), new Point(Width + (int)Value + 50, Height), Trans_ProgressColor1, Trans_ProgressColor2);

           //g.Clear(BackColor);

            g.FillRectangle(l, new Rectangle(0, 0, (int)(Helper.ValueToPercentage((int)Value, (int)Maximum, (int)Minimum) * Width), Height));

            Helper.RoundRect(g, 0, 0, Width - 1, Height - 1, 1, BackColor);

            if (Trans_ShowText)
                Helper.CenterString(g, Convert.ToInt32(Value).ToString() + PostFix, Font, ForeColor, new Rectangle(0, 0, Width, Height));

            Helper.MultiDispose(l);

        }

    }


    

    #endregion
}
