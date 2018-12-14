// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPie.cs" company="Zeroit Dev Technologies">
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
    #region ZeroitProgressBarPie


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Enums

        /// <summary>
        /// Enum ProgressPie_ProgressShape
        /// </summary>
        public enum ProgressPie_ProgressShape
        {
            /// <summary>
            /// The anchor mask
            /// </summary>
            AnchorMask,
            /// <summary>
            /// The arrow anchor
            /// </summary>
            ArrowAnchor,
            /// <summary>
            /// The custom
            /// </summary>
            Custom,
            /// <summary>
            /// The diamond anchor
            /// </summary>
            DiamondAnchor,
            /// <summary>
            /// The flat
            /// </summary>
            Flat,
            /// <summary>
            /// The no anchor
            /// </summary>
            NoAnchor,
            /// <summary>
            /// The round
            /// </summary>
            Round,
            /// <summary>
            /// The round anchor
            /// </summary>
            RoundAnchor,
            /// <summary>
            /// The square
            /// </summary>
            Square,
            /// <summary>
            /// The square anchor
            /// </summary>
            SquareAnchor,
            /// <summary>
            /// The triangle
            /// </summary>
            Triangle
        }

        #endregion

        #region Variables

        ;
        //private Color ProgressPie_ProgressColor1 = Color.DarkSlateGray;
        //private Color ProgressPie_ProgressColor2 = Color.DarkOrange;
        //private Color ProgressPie_FillEllipse1 = Color.Transparent;
        //private Color ProgressPie_FillEllipse2 = Color.Transparent;
        //private Color ProgressPie_TextColor = Color.Transparent;
        //private Color ProgressPie_InnerBorderColor = Color.Transparent;
        //private ProgressPie_ProgressShape ProgressPie__ProgressShape = ProgressPie_ProgressShape.DiamondAnchor;
        //private LineCap ProgressPie_WidthStartCap = LineCap.Flat;
        //private LineCap ProgressPie_WidthEndCap = LineCap.Flat;
        //private Double ProgressPie_ProgressWidth = 1f;
        //private float ProgressPie_InnerBorderWidth = 1f;
        /// <summary>
        /// The progress pie progress width to float
        /// </summary>
        private float ProgressPie_progressWidthToFloat;
        //private bool ProgressPie_ShowText = true;

        //private float ProgressPie_Position = 180.0f;
        //private float ProgressPie_SweepAngle = 180.0f;

        #endregion

        #region Custom Properties


        /// <summary>
        /// Gets or sets the progress pie progress shape.
        /// </summary>
        /// <value>The progress pie progress shape.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public ProgressPie_ProgressShape ProgressPie__ProgressShape
        {
            get { return progressInput.ProgressPie__ProgressShape; }
            set
            {
                progressInput.ProgressPie__ProgressShape = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie position.
        /// </summary>
        /// <value>The progress pie position.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public float ProgressPie_Position
        {
            get { return progressInput.ProgressPie_Position; }
            set
            {
                progressInput.ProgressPie_Position = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie sweep angle.
        /// </summary>
        /// <value>The progress pie sweep angle.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public float ProgressPie_SweepAngle
        {
            get { return progressInput.ProgressPie_SweepAngle; }
            set
            {
                progressInput.ProgressPie_SweepAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie show text.
        /// </summary>
        /// <value>The progress pie show text.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Boolean ProgressPie_ShowText
        {
            get { return progressInput.ProgressPie_ShowText; }
            set
            {
                if (value == false)
                {
                    this.ProgressPie_TextColor = Color.Transparent;
                }

                else
                {
                    this.ProgressPie_TextColor = Color.White;
                }
                progressInput.ProgressPie_ShowText = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the progress pie inner border.
        /// </summary>
        /// <value>The width of the progress pie inner border.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public float ProgressPie_InnerBorderWidth
        {
            get { return progressInput.ProgressPie_InnerBorderWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                progressInput.ProgressPie_InnerBorderWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress pie inner border.
        /// </summary>
        /// <value>The color of the progress pie inner border.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_InnerBorderColor
        {
            get { return progressInput.ProgressPie_InnerBorderColor; }
            set
            {
                progressInput.ProgressPie_InnerBorderColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress pie text.
        /// </summary>
        /// <value>The color of the progress pie text.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_TextColor
        {
            get { return progressInput.ProgressPie_TextColor; }
            set
            {
                progressInput.ProgressPie_TextColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie width start cap.
        /// </summary>
        /// <value>The progress pie width start cap.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public LineCap ProgressPie_WidthStartCap
        {
            get { return progressInput.ProgressPie_WidthStartCap; }
            set
            {
                if (progressInput.ProgressPie_WidthStartCap == null)
                {
                    progressInput.ProgressPie_WidthStartCap = LineCap.Flat;
                }
                progressInput.ProgressPie_WidthStartCap = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie width end cap.
        /// </summary>
        /// <value>The progress pie width end cap.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public LineCap ProgressPie_WidthEndCap
        {
            get { return progressInput.ProgressPie_WidthEndCap; }
            set
            {
                if (progressInput.ProgressPie_WidthEndCap == null)
                {
                    progressInput.ProgressPie_WidthEndCap = LineCap.Flat;
                }
                progressInput.ProgressPie_WidthEndCap = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// This changes the angle of gradient button
        /// </summary>
        /// <value>The width of the progress pie progress.</value>
        [Description("This changes the angle of gradient button")]
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Double ProgressPie_ProgressWidth
        {
            get { return progressInput.ProgressPie_ProgressWidth; }
            set
            {
                if (progressInput.ProgressPie_ProgressWidth == null)
                {
                    progressInput.ProgressPie_ProgressWidth = 5f;
                }

                progressInput.ProgressPie_ProgressWidth = value;
                ProgressPie_progressWidthToFloat = ProgressPie_DoubleToFloat(progressInput.ProgressPie_ProgressWidth);

                this.Invalidate();
            }
        }
        //public long Value
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

        //public long Maximum
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
        /// Gets or sets the progress pie progress color1.
        /// </summary>
        /// <value>The progress pie progress color1.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_ProgressColor1
        {
            get { return progressInput.ProgressPie_ProgressColor1; }
            set
            {
                progressInput.ProgressPie_ProgressColor1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie progress color2.
        /// </summary>
        /// <value>The progress pie progress color2.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_ProgressColor2
        {
            get { return progressInput.ProgressPie_ProgressColor2; }
            set
            {
                progressInput.ProgressPie_ProgressColor2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie fill ellipse1.
        /// </summary>
        /// <value>The progress pie fill ellipse1.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_FillEllipse1
        {
            get { return progressInput.ProgressPie_FillEllipse1; }
            set
            {
                progressInput.ProgressPie_FillEllipse1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress pie fill ellipse2.
        /// </summary>
        /// <value>The progress pie fill ellipse2.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public Color ProgressPie_FillEllipse2
        {
            get { return progressInput.ProgressPie_FillEllipse2; }
            set
            {
                progressInput.ProgressPie_FillEllipse2 = value;
                Invalidate();
            }
        }

        //public ProgressPie_ProgressShape ProgressShape
        //{
        //    get { return ProgressPie__ProgressShape; }
        //    set
        //    {
        //        ProgressPie__ProgressShape = value;
        //        Invalidate();
        //    }
        //}


        /// <summary>
        /// Progresses the pie double to float.
        /// </summary>
        /// <param name="dValue">The d value.</param>
        /// <returns>System.Single.</returns>
        public static float ProgressPie_DoubleToFloat(double dValue)
        {
            if (float.IsPositiveInfinity(Convert.ToSingle(dValue)))
            {
                return float.MaxValue;
            }
            if (float.IsNegativeInfinity(Convert.ToSingle(dValue)))
            {
                return float.MinValue;
            }
            return Convert.ToSingle(dValue);
        }

        #endregion

        #region EventArgs

        /// <summary>
        /// Progresses the pie on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressPie_OnResize(EventArgs e)
        {

            ProgressPie_SetStandardSize();
        }

        /// <summary>
        /// Progresses the pie on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressPie_OnSizeChanged(EventArgs e)
        {
            ProgressPie_SetStandardSize();
        }


        #endregion

        /// <summary>
        /// Zeroits the progress bar pie.
        /// </summary>
        public void ZeroitProgressBarPie()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

            //SetStyle(ControlStyles.SupportsTransparentBackColor, transparency);
            //BackColor = Color.Transparent;
            //Size = new Size(130, 130);
            //Font = new Font("Segoe UI", 15);
            ////MinimumSize = new Size(10, 100);
            //DoubleBuffered = true;


            #region Zeroit AutoStartSpinner Code (Work in Progress)
            timerAnimationAutoSpin.Tick += new System.EventHandler(timerAnimationAutoSpin_Tick);
            if (AutoStartSpinner)
                timerAnimationAutoSpin.Start();
            #endregion


        }

        #region Timer



        /// <summary>
        /// The timer animation automatic spin
        /// </summary>
        private System.Windows.Forms.Timer timerAnimationAutoSpin = new System.Windows.Forms.Timer();
        /// <summary>
        /// The enable automatic spin
        /// </summary>
        private bool enableAutoSpin;
        /// <summary>
        /// The automatic start interval
        /// </summary>
        private int _autoStartInterval = 100;

        /// <summary>
        /// Gets or sets the automatic spin start interval.
        /// </summary>
        /// <value>The automatic spin start interval.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public int AutoSpinStartInterval
        {
            get { return _autoStartInterval; }
            set
            {
                _autoStartInterval = value;
                timerAnimationAutoSpin.Interval = _autoStartInterval;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic start spinner].
        /// </summary>
        /// <value><c>true</c> if [automatic start spinner]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress ProgressPie")]
        [Browsable(false)]
        public bool AutoStartSpinner
        {
            get { return enableAutoSpin; }
            set
            {
                if (value == true)
                {
                    timerAnimationAutoSpin.Enabled = true;
                }

                else
                {
                    timerAnimationAutoSpin.Enabled = false;
                    this.ProgressPie_Position = 180f;
                    //this.Text = Value.ToString();
                }

                enableAutoSpin = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Handles the Tick event of the ProgressBarPie_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPie_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the ProgressBarPie_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPie_Timer_Reduced_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the timerAnimationAutoSpin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timerAnimationAutoSpin_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    Value += 1;
                    //Value = 100;
                    ProgressPie_Position += 10;
                    //Text = Value.ToString();

                    if (Value == Maximum)
                    {

                        Value = 0;
                        ProgressPie_Position = 0;
                    }
                }
                catch (Exception ex)
                {


                }
            }

            if (DesignMode)
            {
                try
                {
                    Value += 1;
                    ProgressPie_Position += 10;
                    //Text = Value.ToString();

                    if (Value == Maximum)
                    {
                        Value = 0;
                        ProgressPie_Position = 0;
                    }
                }
                catch (Exception ex)
                {


                }
            }

            //if (DesignMode)
            //{

            //}
        }

        #endregion

        /// <summary>
        /// Progresses the size of the pie set standard.
        /// </summary>
        private void ProgressPie_SetStandardSize()
        {
            int _Size = System.Math.Max(Width, Height);
            Size = new Size(_Size, _Size);
        }

        //public void Increment(int Val)
        //{
        //    this.Value += Val;
        //    Invalidate();
        //}

        /// <summary>
        /// Decrements the specified value.
        /// </summary>
        /// <param name="Val">The value.</param>
        private void Decrement(int Val)
        {
            this.Value -= Val;
            Invalidate();
        }

        /// <summary>
        /// Progresses the pie paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressPie_Paint(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(this.Width, this.Height);
            //Graphics graphics = Graphics.FromImage(bitmap);

            Graphics graphics = e.Graphics;
            //graphics.SmoothingMode = Smoothing;
            //graphics.TextRenderingHint = TextRendering;

            graphics.Clear(BackColor);

            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ProgressPie_ProgressColor1,
                this.ProgressPie_ProgressColor2, LinearGradientMode.ForwardDiagonal);

            Pen pen = new Pen(brush, ProgressPie_progressWidthToFloat);


            switch (this.ProgressPie__ProgressShape)
            {
                case ProgressPie_ProgressShape.AnchorMask:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.ArrowAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Custom:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.DiamondAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Flat:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.NoAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Round:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.RoundAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Square:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.SquareAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Triangle:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                default:
                    break;
            }
            try
            {
                graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, ProgressPie_Position, (int)System.Math.Round((double)((ProgressPie_SweepAngle / ((double)this.Maximum)) * this.Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add this code to the form constructor:  SetStyle(ControlStyles.SupportsTransparentBackColor, true);");
                throw;
            }

            LinearGradientBrush brush2 = new LinearGradientBrush(this.ClientRectangle, ProgressPie_FillEllipse1,
                ProgressPie_FillEllipse2, LinearGradientMode.Vertical);

            graphics.FillPie(brush2, 0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1, ProgressPie_Position, ProgressPie_SweepAngle);
            Pen BorderColor = new Pen(ProgressPie_InnerBorderColor, ProgressPie_InnerBorderWidth);
            graphics.DrawArc(BorderColor, new Rectangle(0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1), ProgressPie_Position /*90f*//*ProgressPie_SweepAngle / 2*/, ProgressPie_SweepAngle);

            SolidBrush TexTColor = new SolidBrush(ForeColor);
            SizeF MS = graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if (ShowText)
                graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, TexTColor, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));

            //e.Graphics.DrawImage(bitmap, 0, 0);
            //graphics.Dispose();
            //bitmap.Dispose();


        }

    }




    #endregion
}
