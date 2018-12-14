// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressBar.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
	{

        #region Private Field

        /// <summary>
        /// The dag buffered graphics
        /// </summary>
        private BufferedGraphics Dag_bufferedGraphics;

        /// <summary>
        /// The dag update UI
        /// </summary>
        private System.Windows.Forms.Timer Dag_updateUI = new System.Windows.Forms.Timer();

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the dag start angle.
        /// </summary>
        /// <value>The dag start angle.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
	    [Description("The starting angle")]
        public int DagStartAngle
	    {
            get { return progressInput.DagStartAngle; }
	        set
	        {
	            progressInput.DagStartAngle = value;
	            Invalidate();
	        }
	    }

        /// <summary>
        /// Gets or sets the dag anim speed.
        /// </summary>
        /// <value>The dag anim speed.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("The animation speed")]
        public int DagAnimSpeed
        {
            get
            {
                return progressInput.DagAnimSpeed;
            }
            set
            {
                progressInput.DagAnimSpeed = value;
                if (value < 1)
                {
                    value = 1;
                }
                if (value > 10)
                {
                    value = 10;
                }
                this.Dag_updateUI.Interval = 200 / value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag filled.
        /// </summary>
        /// <value>The color of the dag filled.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Filled circle color")]
        public Color DagFilledColor
        {
            get
            {
                return progressInput.DagFilledColor;
            }
            set
            {
                progressInput.DagFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag filled color alpha.
        /// </summary>
        /// <value>The dag filled color alpha.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Filled colors alpha value")]
        public int DagFilledColorAlpha
        {
            get
            {
                return progressInput.DagFilledColorAlpha;
            }
            set
            {
                progressInput.DagFilledColorAlpha = value;
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
        /// Gets or sets the dag filled thickness.
        /// </summary>
        /// <value>The dag filled thickness.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagFilledThickness
        {
            get
            {
                return progressInput.DagFilledThickness;
            }
            set
            {
                progressInput.DagFilledThickness = value;
                base.Invalidate();
            }
        }

        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //public new Color ForeColor
        //{
        //	get;
        //	set;
        //}

        /// <summary>
        /// Gets or sets a value indicating whether [dag is animated].
        /// </summary>
        /// <value><c>true</c> if [dag is animated]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Is the control animated")]
        public bool DagIsAnimated
        {
            get
            {
                return progressInput.DagIsAnimated;
            }
            set
            {
                progressInput.DagIsAnimated = value;
                if (!value)
                {
                    this.Dag_updateUI.Enabled = false;
                }
                else
                {
                    this.Dag_updateUI.Enabled = true;
                }
                base.Invalidate();
            }
        }

        //[Browsable(true)]
        //[Category("CircularProgress Dagger")]
        //[Browsable(false)]
        //[Description("The progress circle Dag_percentage")]
        //public float DagPercentage
        //{
        //    get
        //    {
        //        return this.Value;
        //    }
        //    set
        //    {
        //        this.Value = value;
        //        if (value < 0)
        //        {
        //            this.Value = 0;
        //        }
        //        if (value > 100)
        //        {
        //            this.Value = 100;
        //        }
        //        this.OnPercentageChanged();
        //        base.Invalidate();
        //    }
        //}

        //[Browsable(true)]
        //[Category("CircularProgress Dagger")]
        //[Browsable(false)]
        //[Description("Show text")]
        //public bool ShowText
        //{
        //	get
        //	{
        //		return this.Dag_showText;
        //	}
        //	set
        //	{
        //		this.Dag_showText = value;
        //		base.Invalidate();
        //	}
        //}

        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //public new string Text
        //{
        //	get;
        //	set;
        //}

        //[Browsable(true)]
        //[Category("CircularProgress Dagger")]
        //[Browsable(false)]
        //[Description("Text color")]
        //public Color DagTextColor
        //{
        //    get
        //    {
        //        return this.Dag_textColor;
        //    }
        //    set
        //    {
        //        this.Dag_textColor = value;
        //        base.Invalidate();
        //    }
        //}

        //[Browsable(true)]
        //[Category("CircularProgress Dagger")]
        //[Browsable(false)]
        //[Description("The text size")]
        //public int DagTextSize
        //{
        //    get
        //    {
        //        return this.Dag_textSize;
        //    }
        //    set
        //    {
        //        this.Dag_textSize = value;
        //        base.Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the color of the dag un filled.
        /// </summary>
        /// <value>The color of the dag un filled.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Unfilled circle color")]
        public Color DagUnFilledColor
        {
            get
            {
                return progressInput.DagUnFilledColor;
            }
            set
            {
                progressInput.DagUnFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag unfilled thickness.
        /// </summary>
        /// <value>The dag unfilled thickness.</value>
        [Category("CircularProgress Dagger")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagUnfilledThickness
        {
            get
            {
                return progressInput.DagUnfilledThickness;
            }
            set
            {
                progressInput.DagUnfilledThickness = value;
                base.Invalidate();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Zeroits the dagger circular.
        /// </summary>
        private void ZeroitDaggerCircular()
        {
            this.Dag_updateUI.Tick += new EventHandler(this.Animate);
            this.Dag_updateUI.Interval = 200 / this.DagAnimSpeed;

            
        }

        #endregion

        #region Private Methods and Events

        /// <summary>
        /// Animates the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Animate(object sender, EventArgs e)
        {
            if (this.DagStartAngle == 360)
            {
                this.DagStartAngle = 0;
            }
            this.DagStartAngle = this.DagStartAngle + this.DagAnimSpeed;
            this.Refresh();
        }

        /// <summary>
        /// Called when [percentage changed].
        /// </summary>
        protected virtual void OnPercentageChanged()
        {
            if (this.PercentageChanged != null)
            {
                this.PercentageChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Occurs when [percentage changed].
        /// </summary>
        public event EventHandler PercentageChanged;

        #endregion

        #region Paint Event


        /// <summary>
        /// Daggers the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Dagger_OnPaint(PaintEventArgs e)
        {
            

            #region New  Code

            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            //g.CompositingQuality = CompositingQuality.HighQuality;
            //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            //g.Clear(BackColor);

            //if (this.BackgroundImage != null)
            //{
            //    g.DrawImage(this.BackgroundImage, 0, 0);
            //}

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

            Rectangle rectangle = new Rectangle(this.DagFilledThickness / 2 + 1, this.DagFilledThickness / 2 + 1, base.Width - this.DagFilledThickness - 2, base.Height - this.DagFilledThickness - 2);
            g.DrawArc(new Pen(this.DagUnFilledColor, (float)this.DagUnfilledThickness), rectangle, (float)this.DagStartAngle, 360f);
            g.DrawArc(new Pen(Color.FromArgb(this.DagFilledColorAlpha, (int)this.DagFilledColor.R, (int)this.DagFilledColor.G, (int)this.DagFilledColor.B), (float)this.DagFilledThickness), rectangle, (float)this.DagStartAngle, (float)((int)((((double)this.Value / Maximum) * 100) * 3.6)));
            if (this.ShowText)
            {
                Rectangle rectangle1 = new Rectangle(0, 0, base.Width, base.Height);
                StringFormat stringFormat = new StringFormat()
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };
                int Dag_percentage = ((int)Value / (int)Maximum) * 100;
                g.DrawString(string.Concat(Convert.ToInt32((Value / Maximum) * 100).ToString(), PostFix), Font, new SolidBrush(this.ForeColor), rectangle1, stringFormat);
            }
            //this.Dag_bufferedGraphics.Render(e.Graphics);
            //base.OnPaint(e); 

            #endregion
        }


        #endregion


    }
}