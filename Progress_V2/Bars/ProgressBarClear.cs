// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarClear.cs" company="Zeroit Dev Technologies">
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
    #region ZeroitProgressBarClear

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress 
    {
        #region Private Fields


        //private Color ProgressBarClear_ColorGlow = Color.FromArgb(230, 230, 230);
        //private Color ProgressBarClear_ColorBorder = Color.FromArgb(170, 170, 170);
        //private Color ProgressBarClear_ColorGradient1 = Color.FromArgb(230, 230, 230);
        //private Color ProgressBarClear_ColorGradient2 = Color.FromArgb(210, 210, 210);


        /// <summary>
        /// Enum coloringMode
        /// </summary>
        public enum coloringMode
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


        /// <summary>
        /// The glow position
        /// </summary>
        int GlowPosition;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the progress bar clear color glow.
        /// </summary>
        /// <value>The progress bar clear color glow.</value>
        [Category("RectangularProgress Clear")]
        [Browsable(false)]
        public Color ProgressBarClear_ColorGlow
        {
            get { return progressInput.ProgressBarClear_ColorGlow; }
            set
            {
                progressInput.ProgressBarClear_ColorGlow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color border.
        /// </summary>
        /// <value>The progress bar clear color border.</value>
        [Category("RectangularProgress Clear")]
        [Browsable(false)]
        public Color ProgressBarClear_ColorBorder
        {
            get { return progressInput.ProgressBarClear_ColorBorder; }
            set
            {
                progressInput.ProgressBarClear_ColorBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color gradient1.
        /// </summary>
        /// <value>The progress bar clear color gradient1.</value>
        [Category("RectangularProgress Clear")]
        [Browsable(false)]
        public Color ProgressBarClear_ColorGradient1
        {
            get { return progressInput.ProgressBarClear_ColorGradient1; }
            set
            {
                progressInput.ProgressBarClear_ColorGradient1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color gradient2.
        /// </summary>
        /// <value>The progress bar clear color gradient2.</value>
        [Category("RectangularProgress Clear")]
        [Browsable(false)]
        public Color ProgressBarClear_ColorGradient2
        {
            get { return progressInput.ProgressBarClear_ColorGradient2; }
            set
            {
                progressInput.ProgressBarClear_ColorGradient2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        [Category("RectangularProgress Clear")]
        [Browsable(false)]
        public coloringMode Mode
        {
            get { return progressInput.Mode; }
            set
            {
                progressInput.Mode = value;
                Invalidate();
            }
        }

        //public int Minimum
        //{
        //    get { return _Minimum; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Minimum = value;
        //        if (value > _Value)
        //            _Value = value;
        //        if (value > _Maximum)
        //            _Maximum = value;
        //        Invalidate();
        //    }
        //}
        //public int Maximum
        //{
        //    get { return _Maximum; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Maximum = value;
        //        if (value < _Value)
        //            _Value = value;
        //        if (value < _Minimum)
        //            _Minimum = value;
        //        Invalidate();
        //    }
        //}
        //public bool Animated
        //{
        //    get { return IsAnimated; }
        //    set
        //    {
        //        IsAnimated = value;
        //        Invalidate();
        //    }
        //}
        //public int Value
        //{
        //    get { return _Value; }
        //    set
        //    {
        //        if (value > _Maximum || value < _Minimum)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Value = value;
        //        Invalidate();
        //    }
        //}
        //public HatchBrushType HatchBrush
        //{
        //    get
        //    {
        //        return hatchBrushType;
        //    }

        //    set
        //    {
        //        hatchBrushType = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        /// <summary>
        /// Zeroits the progress bar clear.
        /// </summary>
        public void ZeroitProgressBarClear()
        {
            
        }


        //protected override void OnAnimation()
        //{
        //    if (GlowPosition == 0)
        //    {
        //        GlowPosition = 7;
        //    }
        //    else
        //    {
        //        GlowPosition -= 1;
        //    }
        //}

        /// <summary>
        /// Progresses the bar clear paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressBarClear_Paint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            //G.SmoothingMode = Smoothing;
            //G.TextRenderingHint = TextRendering;

            //G.Clear(ProgressBarClear_ColorGradient1);



            dynamic progressWidth = Convert.ToInt32(Value * (1 / Maximum) * Width);

            


            if (allowTransparency)
            {
                MakeTransparent(this, G);
            }

            Rectangle rectangle = new Rectangle(0, 0,
                (int) (Helper.ValueToPercentage((int) Value, (int) Maximum, (int) Minimum) * Width), Height);

            //g.FillRectangle(l, new Rectangle(0, 0, (int)(Helper.ValueToPercentage((int)Value, (int)Maximum, (int)Minimum) * Width), Height));

            switch (Mode)
            {
                case coloringMode.Solid:
                    G.FillRectangle(new SolidBrush(ProgressBarClear_ColorGlow), new Rectangle(new Point(1, 1), new Size(progressWidth - 1, (Height / 2) - 3)));

                    break;
                case coloringMode.Gradient:
                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)), ProgressBarClear_ColorGradient1, ProgressBarClear_ColorGradient2, 90f);
                    G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(progressWidth - 1, Height - 2)));

                    break;
                case coloringMode.Hatch:

                    HatchBrush HB = new HatchBrush(HatchStyle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                    G.FillRectangle(HB, new Rectangle(new Point(1, 2), new Size(progressWidth - 1, Height - 3)));
                    
                    break;
            }
            
            
            G.RenderingOrigin = new Point(GlowPosition, 0);
            
            G.DrawLine(new Pen(ProgressBarClear_ColorBorder), new Point(progressWidth - 1, 1), new Point(progressWidth - 1, Height - 1));
            G.DrawRectangle(new Pen(ProgressBarClear_ColorBorder), new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32((Value/Maximum) * 100).ToString() + PostFix, Font, new SolidBrush(ForeColor),
                    this.ClientRectangle);
            }
            
        }



        #region Event

        /// <summary>
        /// Handles the Tick event of the ProgressBarClear_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarClear_Timer_Tick(object sender, EventArgs e)
        {
            
            if (Reverse)
            {
                if (GlowPosition == 0)
                {
                    GlowPosition = 7;
                }
                else
                {
                    GlowPosition -= 1;
                }

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
                if (GlowPosition == 0)
                {
                    GlowPosition = 7;
                }
                else
                {
                    GlowPosition -= 1;
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
        /// Handles the Tick event of the ProgressBarClear_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarClear_Timer_Reduced_Tick(object sender, EventArgs e)
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

            if (GlowPosition == 7)
            {
                GlowPosition = 0;
            }
            else
            {
                GlowPosition += 1;
            }
        }

        #endregion


    }


    

    #endregion
}
