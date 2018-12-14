// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerCircleProgressBarV2.cs" company="Zeroit Dev Technologies">
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
        /// The dag up buffered graphics
        /// </summary>
        private BufferedGraphics DagUp_bufferedGraphics;

        /// <summary>
        /// The dag up update UI
        /// </summary>
        private System.Windows.Forms.Timer DagUp_updateUI = new System.Windows.Forms.Timer();


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the dag up inner filled.
        /// </summary>
        /// <value>The color of the dag up inner filled.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Set to fill the Inner Color")]
        public Color DagUpInnerFilledColor
        {
            get { return progressInput.DagUpInnerFilledColor; }
            set
            {
                progressInput.DagUpInnerFilledColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled thickness inner.
        /// </summary>
        /// <value>The dag up filled thickness inner.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Set the thickness of the Inner circle")]
        public int DagUpFilledThicknessInner
        {
            get { return progressInput.DagUpFilledThicknessInner; }
            set
            {
                progressInput.DagUpFilledThicknessInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled color alpha inner.
        /// </summary>
        /// <value>The dag up filled color alpha inner.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Set the Alpha of the Inner color")]
        public int DagUpFilledColorAlphaInner
        {
            get { return progressInput.DagUpFilledColorAlphaInner; }
            set
            {
                if (value > 255)
                {
                    value = 255;
                    Invalidate();
                }

                progressInput.DagUpFilledColorAlphaInner = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag anim up speed.
        /// </summary>
        /// <value>The dag anim up speed.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("The animation speed")]
        public int DagAnimUpSpeed
        {
            get
            {
                return progressInput.DagAnimUpSpeed;
            }
            set
            {
                progressInput.DagAnimUpSpeed = value;
                if (value < 1)
                {
                    value = 1;
                }
                if (value > 10)
                {
                    value = 10;
                }
                this.DagUp_updateUI.Interval = 200 / value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the dag up filled.
        /// </summary>
        /// <value>The color of the dag up filled.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Filled circle color")]
        public Color DagUpFilledColor
        {
            get
            {
                return progressInput.DagUpFilledColor;
            }
            set
            {
                progressInput.DagUpFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag up filled color alpha.
        /// </summary>
        /// <value>The dag up filled color alpha.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Filled colors alpha value")]
        public int DagUpFilledColorAlpha
        {
            get
            {
                return progressInput.DagUpFilledColorAlpha;
            }
            set
            {
                progressInput.DagUpFilledColorAlpha = value;
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
        /// Gets or sets the dag up filled thickness.
        /// </summary>
        /// <value>The dag up filled thickness.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagUpFilledThickness
        {
            get
            {
                return progressInput.DagUpFilledThickness;
            }
            set
            {
                progressInput.DagUpFilledThickness = value;
                base.Invalidate();
            }
        }

        //		[Browsable(false)]
        //		[EditorBrowsable(EditorBrowsableState.Never)]
        //		public new Color ForeColor
        //		{
        //			get;
        //			set;
        //		}


        /// <summary>
        /// Gets or sets a value indicating whether [dag up is animated].
        /// </summary>
        /// <value><c>true</c> if [dag up is animated]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Is the control animated")]
        public bool DagUpIsAnimated
        {
            get
            {
                return progressInput.DagUpIsAnimated;
            }
            set
            {
                progressInput.DagUpIsAnimated = value;
                if (!value)
                {
                    this.DagUp_updateUI.Enabled = false;
                }
                else
                {
                    this.DagUp_updateUI.Enabled = true;
                }
                base.Invalidate();
            }
        }

        //[Browsable(true)]
        //[Category("CircularProgress DaggerV1")]
        //[Browsable(false)]
        //[Description("The progress circle DagUp_percentage")]
        //public int Percentage
        //{
        //	get
        //	{
        //		return this.DagUp_percentage;
        //	}
        //	set
        //	{
        //		this.DagUp_percentage = value;
        //		if (value < 0)
        //		{
        //			this.DagUp_percentage = 0;
        //		}
        //		if (value > 100)
        //		{
        //			this.DagUp_percentage = 100;
        //		}
        //		OnPercentageChanged();
        //		base.Invalidate();
        //	}
        //}



        /// <summary>
        /// Gets or sets the color of the dag up un filled.
        /// </summary>
        /// <value>The color of the dag up un filled.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Unfilled circle color")]
        public Color DagUpUnFilledColor
        {
            get
            {
                return progressInput.DagUpUnFilledColor;
            }
            set
            {
                progressInput.DagUpUnFilledColor = value;
                base.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the dag up unfilled thickness.
        /// </summary>
        /// <value>The dag up unfilled thickness.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Unfilled circle thickness")]
        public int DagUpUnfilledThickness
        {
            get
            {
                return progressInput.DagUpUnfilledThickness;
            }
            set
            {
                progressInput.DagUpUnfilledThickness = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets the progress effects.
        /// </summary>
        /// <value>The progress effects.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
        [Description("Sets the effects of the outerprogress")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public PenParameters ProgressEffects
	    {
	        get { return progressInput.ProgressEffects; }
	        set
	        {
	            progressInput.ProgressEffects = value;
	            Invalidate();
	        }
	    }


        /// <summary>
        /// Gets or sets a value indicating whether [dag styled].
        /// </summary>
        /// <value><c>true</c> if [dag styled]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
	    [Description("Sets the progress to have appealing feel")]
	    public bool DagStyled
	    {
	        get { return progressInput.DagStyled; }
	        set
	        {
	            progressInput.DagStyled = value;
	            Invalidate();
	        }
	    }


        /// <summary>
        /// Gets or sets a value indicating whether [dag draw inner circle].
        /// </summary>
        /// <value><c>true</c> if [dag draw inner circle]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerV1")]
        [Browsable(false)]
	    [Description("Set to Draw Inner Circle")]
	    public bool DagDrawInnerCircle
	    {
	        get { return progressInput.DagDrawInnerCircle; }
	        set
	        {
	            progressInput.DagDrawInnerCircle = value;
	            Invalidate();
	        }
	    }
        /// <summary>
        /// Gets or sets the color of the dag inner.
        /// </summary>
        /// <value>The color of the dag inner.</value>
        [Category("CircularProgress DaggerV1")]
	    [Browsable(false)]
	    public Color DagInnerColor
	    {
            get { return progressInput.DagInnerColor; }
	        set
	        {
	            progressInput.DagInnerColor = value;
	            Invalidate();
	        }
	    }
        /// <summary>
        /// Gets or sets the dag inner border.
        /// </summary>
        /// <value>The dag inner border.</value>
        [Category("CircularProgress DaggerV1")]
	    [Browsable(false)]
	    public Color DagInnerBorder
	    {
	        get { return progressInput.DagInnerBorder; }
	        set
	        {
	            progressInput.DagInnerBorder = value;
	            Invalidate();
	        }
	    }
        /// <summary>
        /// Gets or sets the width of the dag inner border.
        /// </summary>
        /// <value>The width of the dag inner border.</value>
        [Category("CircularProgress DaggerV1")]
	    [Browsable(false)]
	    public int DagInnerBorderWidth
	    {
	        get { return progressInput.DagInnerBorderWidth; }
	        set
	        {
	            progressInput.DagInnerBorderWidth = value;
	            Invalidate();
	        }
	    }
        /// <summary>
        /// Gets or sets a value indicating whether [dag up inner border].
        /// </summary>
        /// <value><c>true</c> if [dag up inner border]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress DaggerV1")]
	    [Browsable(false)]
	    public bool DagUpInnerBorder
	    {
	        get { return progressInput.DagUpInnerBorder; }
	        set
	        {
	            progressInput.DagUpInnerBorder = value;
	            Invalidate();
	        }
	    }

        #endregion

        #region Constructor

        /// <summary>
        /// Zeroits the dagger circular v2.
        /// </summary>
        private void ZeroitDaggerCircularV2()
        {

            this.DagUp_updateUI.Tick += new EventHandler(this.DagUpAnimate);
            this.DagUp_updateUI.Interval = 200 / this.DagAnimUpSpeed;


        }

        #endregion

        #region Timer Event

        /// <summary>
        /// Dags up animate.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DagUpAnimate(object sender, EventArgs e)
        {
            if (this.StartingAngle == 360)
            {
                this.StartingAngle = 0;
            }
            this.StartingAngle = this.StartingAngle + this.DagAnimUpSpeed;
            this.Refresh();
        }

        #endregion

        #region Paint Event

        /// <summary>
        /// Dags up paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void DagUpPaint(PaintEventArgs e)
        {

            

            #region New Code

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            Rectangle rectangle = new Rectangle(this.DagUpFilledThickness / 2 + 1, this.DagUpFilledThickness / 2 + 1, base.Width - this.DagUpFilledThickness - 2, base.Height - this.DagUpFilledThickness - 2);

            
            Rectangle innerRectangle = new Rectangle(0 + DagUpUnfilledThickness + DagInnerBorderWidth, 0 + DagUpUnfilledThickness + DagInnerBorderWidth, Width - (2*DagUpUnfilledThickness) - (2 * DagInnerBorderWidth), Height - (2*DagUpUnfilledThickness) - (2 * DagInnerBorderWidth));

            g.Clear(this.BackColor);

            g.DrawArc(new Pen(this.DagUpUnFilledColor, (float)this.DagUpUnfilledThickness)
            {
                
            }, rectangle, (float)this.StartingAngle, 360f);

            if (DagDrawInnerCircle)
            {
                g.FillEllipse(new SolidBrush(DagInnerColor), innerRectangle);

                if (DagUpInnerBorder)
                {
                    g.DrawEllipse(new Pen(DagInnerBorder) { Width = DagInnerBorderWidth }, innerRectangle);

                }
            }


            #region Styled
            
            if (DagStyled)
            {
                g.DrawArc(new Pen(Color.FromArgb(DagUpFilledColorAlphaInner, DagUpInnerFilledColor.R, DagUpInnerFilledColor.G, DagUpInnerFilledColor.B),
                (float)this.DagUpFilledThickness - DagUpFilledThicknessInner)
                {
                    Alignment = ProgressEffects.Alignment,
                    DashCap = ProgressEffects.DashCap,
                    DashOffset = ProgressEffects.DashOffset,
                    DashPattern = ProgressEffects.DashPattern,
                    DashStyle = ProgressEffects.DashStyle,
                    EndCap = ProgressEffects.EndCap,
                    LineJoin = ProgressEffects.LineJoin,
                    StartCap = ProgressEffects.StartCap,
                    MiterLimit = ProgressEffects.MiterLimit,
                },
                new Rectangle(this.DagUpFilledThickness / 2 + 1,
                this.DagUpFilledThickness / 2 + 1, base.Width - this.DagUpFilledThickness - 2, base.Height - this.DagUpFilledThickness - 2),
                (float)this.StartingAngle, (float)((int)((((double)this.Value / Maximum) * 100) * 3.6)));


                g.DrawArc(new Pen(Color.FromArgb(this.DagUpFilledColorAlpha, (int)this.DagUpFilledColor.R, (int)this.DagUpFilledColor.G,
                    (int)this.DagUpFilledColor.B), (float)this.DagUpFilledThickness)
                {

                    Alignment = ProgressEffects.Alignment,
                    DashCap = ProgressEffects.DashCap,
                    DashOffset = ProgressEffects.DashOffset,
                    DashPattern = ProgressEffects.DashPattern,
                    DashStyle = ProgressEffects.DashStyle,
                    EndCap = ProgressEffects.EndCap,
                    LineJoin = ProgressEffects.LineJoin,
                    StartCap = ProgressEffects.StartCap,
                    MiterLimit = ProgressEffects.MiterLimit,
                    //Width = ProgressEffects.Alignment

                },
                    rectangle, (float)this.StartingAngle,
                    (float)((int)(((double)(this.Value / Maximum) * 100) * 3.6)));

            }
            else
            {

                g.DrawArc(new Pen(Color.FromArgb(DagUpFilledColorAlphaInner, DagUpInnerFilledColor.R, DagUpInnerFilledColor.G, DagUpInnerFilledColor.B),
                        (float)this.DagUpFilledThickness - DagUpFilledThicknessInner)
                    {

                    },
                    new Rectangle(this.DagUpFilledThickness / 2 + 1,
                        this.DagUpFilledThickness / 2 + 1, base.Width - this.DagUpFilledThickness - 2, base.Height - this.DagUpFilledThickness - 2),
                    (float)this.StartingAngle, (float)((int)((((double)this.Value / Maximum) * 100) * 3.6)));


                g.DrawArc(new Pen(Color.FromArgb(this.DagUpFilledColorAlpha, (int)this.DagUpFilledColor.R, (int)this.DagUpFilledColor.G,
                        (int)this.DagUpFilledColor.B), (float)this.DagUpFilledThickness)
                    {


                    },
                    rectangle, (float)this.StartingAngle,
                    (float)((int)(((double)(this.Value / Maximum) * 100) * 3.6)));

            }

            #endregion


            if (this.ShowText)
            {
                Rectangle rectangle1 = new Rectangle(0, 0, base.Width, base.Height);
                StringFormat stringFormat = new StringFormat()
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };
                //int DagUp_percentage = (int)(Value / Maximum) * 100;
                g.DrawString(string.Concat(Convert.ToInt32((Value / Maximum) * 100).ToString(), PostFix),
                    Font, new SolidBrush(this.ForeColor),
                    rectangle1, stringFormat);
            }

            #endregion

            //base.OnPaint(e);
        }

        #endregion

    }
}