// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressSmooth.cs" company="Zeroit Dev Technologies">
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

        #region Private Fields

        /// <summary>
        /// The dag smooth update UI
        /// </summary>
        private System.Windows.Forms.Timer DagSmooth_updateUI = new System.Windows.Forms.Timer();

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the color of the dag smooth inner filled.
        /// </summary>
        /// <value>The color of the dag smooth inner filled.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Set to fill the Inner Color")]
        public Color DagSmoothInnerFilledColor
        {
            get { return progressInput.DagSmoothInnerFilledColor; }
            set
            {
                progressInput.DagSmoothInnerFilledColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag smooth filled.
        /// </summary>
        /// <value>The color of the dag smooth filled.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Filled circle color")]
        public Color DagSmoothFilledColor
        {
            get
            {
                return progressInput.DagSmoothFilledColor;
            }
            set
            {
                progressInput.DagSmoothFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag smooth un filled.
        /// </summary>
        /// <value>The color of the dag smooth un filled.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Unfilled circle color")]
        public Color DagSmoothUnFilledColor
        {
            get
            {
                return progressInput.DagSmoothUnFilledColor;
            }
            set
            {
                progressInput.DagSmoothUnFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth end angle.
        /// </summary>
        /// <value>The dag smooth end angle.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Sets End Angle")]
        public int DagSmoothEndAngle
        {
            get { return progressInput.DagSmoothEndAngle; }
            set
            {
                progressInput.DagSmoothEndAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled thickness inner.
        /// </summary>
        /// <value>The dag smooth filled thickness inner.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Set the thickness of the Inner circle")]
        public int DagSmoothFilledThicknessInner
        {
            get { return progressInput.DagSmoothFilledThicknessInner; }
            set
            {
                progressInput.DagSmoothFilledThicknessInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled color alpha inner.
        /// </summary>
        /// <value>The dag smooth filled color alpha inner.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Set the Alpha of the Inner color")]
        public int DagSmoothFilledColorAlphaInner
        {
            get { return progressInput.DagSmoothFilledColorAlphaInner; }
            set
            {
                if (value > 255)
                {
                    value = 255;
                    Invalidate();
                }

                progressInput.DagSmoothFilledColorAlphaInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth anim speed.
        /// </summary>
        /// <value>The dag smooth anim speed.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("The animation speed")]
        public int DagSmoothAnimSpeed
        {
            get
            {
                return progressInput.DagSmoothAnimSpeed;
            }
            set
            {
                progressInput.DagSmoothAnimSpeed = value;
                if (value < 1)
                {
                    value = 1;
                }
                if (value > 10)
                {
                    value = 10;
                }
                this.DagSmooth_updateUI.Interval = 200 / value;
                base.Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the dag smooth filled color alpha.
        /// </summary>
        /// <value>The dag smooth filled color alpha.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Filled colors alpha value")]
        public int DagSmoothFilledColorAlpha
        {
            get
            {
                return progressInput.DagSmoothFilledColorAlpha;
            }
            set
            {
                progressInput.DagSmoothFilledColorAlpha = value;
                if (value > 255)
                {
                    value = 255;
                }
                if (value < 1)
                {
                    value = 1;
                }
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag smooth filled thickness.
        /// </summary>
        /// <value>The dag smooth filled thickness.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagSmoothFilledThickness
        {
            get
            {
                return progressInput.DagSmoothFilledThickness;
            }
            set
            {
                progressInput.DagSmoothFilledThickness = value;
                base.Invalidate();
            }
        }

        //[Browsable(true)]
        //[Category("CircularProgress DaggerSmooth")]
        //[Browsable(false)]
        //[Description("The progress circle DagSmooth_percentage")]
        //public int DagSmoothPercentage
        //{
        //    get
        //    {
        //        return this.DagSmooth_percentage;
        //    }
        //    set
        //    {
        //        this.DagSmooth_percentage = value;
        //        if (value < 0)
        //        {
        //            this.DagSmooth_percentage = 0;
        //        }
        //        if (value > 100)
        //        {
        //            this.DagSmooth_percentage = 100;
        //        }
        //        this.OnPercentageChanged();
        //        base.Invalidate();
        //    }
        //}


        /// <summary>
        /// Gets or sets the dag smooth unfilled thickness.
        /// </summary>
        /// <value>The dag smooth unfilled thickness.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagSmoothUnfilledThickness
        {
            get
            {
                return progressInput.DagSmoothUnfilledThickness;
            }
            set
            {
                progressInput.DagSmoothUnfilledThickness = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth rotate].
        /// </summary>
        /// <value><c>true</c> if [dag smooth rotate]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("This sets the progress to rotate")]
        public bool DagSmoothRotate
        {
            get { return progressInput.DagSmoothRotate; }
            set
            {
                progressInput.DagSmoothRotate = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth anim end angle].
        /// </summary>
        /// <value><c>true</c> if [dag smooth anim end angle]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("This animates the end angle")]
        public bool DagSmoothAnimEndAngle
        {
            get { return progressInput.DagSmoothAnimEndAngle; }
            set
            {
                progressInput.DagSmoothAnimEndAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [dag smooth is animated].
        /// </summary>
        /// <value><c>true</c> if [dag smooth is animated]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerSmooth")]
        [Browsable(false)]
        [Description("Is the control animated")]
        public bool DagSmoothIsAnimated
        {
            get
            {
                return progressInput.DagSmoothIsAnimated;
            }
            set
            {
                progressInput.DagSmoothIsAnimated = value;
                if (!value)
                {
                    this.DagSmooth_updateUI.Enabled = false;
                }
                else
                {
                    this.DagSmooth_updateUI.Enabled = true;
                }
                base.Invalidate();
            }
        }


        #endregion

        #region Constructor
        /// <summary>
        /// Zeroits the dagger circular smooth.
        /// </summary>
        private void ZeroitDaggerCircularSmooth()
        {
            this.DagSmooth_updateUI.Tick += new EventHandler(this.DagSmoothAnimate);
            this.DagSmooth_updateUI.Interval = 200 / this.DagSmoothAnimSpeed;

            //base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        }
        #endregion

        #region Timer Events
        /// <summary>
        /// Dags the smooth animate.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagSmoothAnimate(object sender, EventArgs e)
        {
            if (this.StartingAngle == 360)
            {
                this.StartingAngle = 0;
            }
            this.StartingAngle = this.StartingAngle + this.DagSmoothAnimSpeed;
            this.Refresh();
        }

        /// <summary>
        /// Dags the smooth animate without rotate.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagSmoothAnimateWithoutRotate(object sender, EventArgs e)
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
        /// Dags the smooth animate without rotate reduced.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagSmoothAnimateWithoutRotateReduced(object sender, EventArgs e)
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
        /// Dags the smooth animate end angle.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagSmoothAnimateEndAngle(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.DagSmoothEndAngle == 360)
            //{
            //    this.DagSmoothEndAngle = 0;
            //}
            //this.DagSmoothEndAngle = this.DagSmoothEndAngle + this.DagSmoothAnimSpeed;

            //if (this.Value + 1 > Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value += 2;
            //    Invalidate();
            //} 
            #endregion

            if (Reverse)
            {
                if (this.DagSmoothEndAngle + (DagSmoothAnimSpeed * SpeedMultiplier) > 360)
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
                    this.DagSmoothEndAngle += (int)(this.DagSmoothAnimSpeed * SpeedMultiplier);
                    Invalidate();
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
                if (this.DagSmoothEndAngle + (DagSmoothAnimSpeed * SpeedMultiplier) > 360)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    DagSmoothEndAngle = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.DagSmoothEndAngle += (int)(this.DagSmoothAnimSpeed * SpeedMultiplier);
                    Invalidate();
                }


                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            

            this.Refresh();
        }

        /// <summary>
        /// Dags the smooth animate end angle reduced.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagSmoothAnimateEndAngleReduced(object sender, EventArgs e)
        {

            if (this.DagSmoothEndAngle < 0)
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
                this.DagSmoothEndAngle -= (int)(DagSmoothAnimSpeed * SpeedMultiplier);
                Invalidate();
            }

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

            this.Refresh();
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{

        //	BufferedGraphicsContext current = BufferedGraphicsManager.Current;
        //	current.MaximumBuffer = new System.Drawing.Size(base.Width + 1, base.Height + 1);
        //	this.bufferedGraphics = current.Allocate(base.CreateGraphics(), new Rectangle(0, 0, 1, 1));
        //	this.bufferedGraphics = current.Allocate(base.CreateGraphics(), base.ClientRectangle);
        //	this.bufferedGraphics.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //	this.bufferedGraphics.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
        //	this.bufferedGraphics.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        //	this.bufferedGraphics.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //	this.bufferedGraphics.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        //	if (this.BackgroundImage != null)
        //	{
        //		this.bufferedGraphics.Graphics.DrawImage(this.BackgroundImage, 0, 0);
        //	}
        //	else
        //	{
        //		this.bufferedGraphics.Graphics.Clear(this.BackColor);
        //	}
        //	Rectangle rectangle = new Rectangle(this.DagSmoothFilledThickness / 2 + 1, this.DagSmoothFilledThickness / 2 + 1, base.Width - this.DagSmoothFilledThickness - 2, base.Height - this.DagSmoothFilledThickness - 2);
        //	this.bufferedGraphics.Graphics.DrawArc(new Pen(this.DagSmoothUnFilledColor, (float)this.DagSmoothUnfilledThickness), rectangle, (float)this.DagSmooth_startPoint, 360f);

        //          this.bufferedGraphics.Graphics.DrawArc(new Pen(Color.FromArgb(DagSmoothFilledColorAlphaInner, DagSmoothInnerFilledColor.R, DagSmoothInnerFilledColor.G, DagSmoothInnerFilledColor.B), (float)this.DagSmoothFilledThickness - DagSmoothFilledThicknessInner), new Rectangle(this.DagSmoothFilledThickness / 2 + 1, this.DagSmoothFilledThickness / 2 + 1, base.Width - this.DagSmoothFilledThickness - 2 , base.Height - this.DagSmoothFilledThickness - 2), (float)this.DagSmooth_startPoint, (float)((int)((double)this.Percentage * 3.6)));


        //          this.bufferedGraphics.Graphics.DrawArc(new Pen(Color.FromArgb(this.DagSmoothFilledColorAlpha, (int)this.DagSmoothFilledColor.R, (int)this.DagSmoothFilledColor.G, (int)this.DagSmoothFilledColor.B), (float)this.DagSmoothFilledThickness), rectangle, (float)this.DagSmooth_startPoint, (float)((int)((double)this.Percentage * 3.6)));
        //	if (this.ShowText)
        //	{
        //		Rectangle rectangle1 = new Rectangle(0, 0, base.Width, base.Height);
        //		StringFormat stringFormat = new StringFormat()
        //		{
        //			LineAlignment = StringAlignment.Center,
        //			Alignment = StringAlignment.Center
        //		};
        //		this.bufferedGraphics.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        //		Graphics graphics = this.bufferedGraphics.Graphics;
        //		int DagSmooth_percentage = this.Percentage;
        //		graphics.DrawString(string.Concat(DagSmooth_percentage.ToString(), "%"), new System.Drawing.Font("Ariel", (float)this.DagSmooth_textSize), new SolidBrush(this.DagSmooth_textColor), rectangle1, stringFormat);
        //	}
        //	this.bufferedGraphics.Render(e.Graphics);
        //	base.OnPaint(e);
        //}

        #endregion


        #region Paint Event

        /// <summary>
        /// Dags the smooth on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void DagSmoothOnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;


            //g.SmoothingMode = SmoothingMode.HighQuality;
            //g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            //g.CompositingQuality = CompositingQuality.HighQuality;
            //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //g.TextRenderingHint = TextRendering;
            //g.Clear(this.BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            Rectangle rectangle = new Rectangle(this.DagSmoothFilledThickness / 2 + 1, this.DagSmoothFilledThickness / 2 + 1, base.Width - this.DagSmoothFilledThickness - 2, base.Height - this.DagSmoothFilledThickness - 2);

            g.DrawArc(new Pen(this.DagSmoothUnFilledColor, (float)this.DagSmoothUnfilledThickness), rectangle, (float)this.StartingAngle, /*360f*/ DagSmoothEndAngle);

            g.DrawArc(new Pen(Color.FromArgb(DagSmoothFilledColorAlphaInner, DagSmoothInnerFilledColor.R, DagSmoothInnerFilledColor.G, DagSmoothInnerFilledColor.B), (float)this.DagSmoothFilledThickness - DagSmoothFilledThicknessInner), new Rectangle(this.DagSmoothFilledThickness / 2 + 1, this.DagSmoothFilledThickness / 2 + 1, base.Width - this.DagSmoothFilledThickness - 2, base.Height - this.DagSmoothFilledThickness - 2), (float)this.StartingAngle, (float)((int)((double)((Value / Maximum) * 100) * /*3.6*/ ((double)DagSmoothEndAngle / (double)100))));


            g.DrawArc(new Pen(Color.FromArgb(this.DagSmoothFilledColorAlpha, (int)this.DagSmoothFilledColor.R, (int)this.DagSmoothFilledColor.G, (int)this.DagSmoothFilledColor.B), (float)this.DagSmoothFilledThickness), rectangle, (float)this.StartingAngle, (float)((int)((double)((Value / Maximum) * 100) * /*3.6*/ ((double)DagSmoothEndAngle / (double)100))));
            if (this.ShowText)
            {
                Rectangle rectangle1 = new Rectangle(0, 0, base.Width, base.Height);
                StringFormat stringFormat = new StringFormat()
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };

                g.DrawString(string.Concat(Convert.ToInt32((Value / Maximum) * 100).ToString(), PostFix), Font, new SolidBrush(this.ForeColor), rectangle1, stringFormat);
            }



        }

        #endregion


    }
}