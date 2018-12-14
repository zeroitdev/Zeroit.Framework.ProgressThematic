// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarAwesome.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation;
//using Zeroit.Framework.ProgressThematic;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region Progress Awesome

    /// <summary>
    /// The circular progress bar windows form control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Field

        #region Zeroit Additions
        //private int OuterMargin = -25;
        //private int OuterWidth = 26;
        //private Color OuterColor = Color.Gray;

        /// <summary>
        /// The progress awesome progress width
        /// </summary>
        private int ProgressAwesome_progressWidth = 25;
        /// <summary>
        /// The progress awesome progress color
        /// </summary>
        private Color ProgressAwesome_progressColor = Color.FromArgb(156, 39, 176);

        //private int InnerMargin = 2;
        //private int InnerWidth = -1;
        //private Color InnerColor = Color.FromArgb(224, 224, 224);

        //private ProgressBarStyle ProgressBarAwesomeStyle = System.Windows.Forms.ProgressBarStyle.Blocks;

        #region Zeroit Code


        //private System.Windows.Forms.Timer timerAnimation = new System.Windows.Forms.Timer();

        #endregion



        #endregion
        /// <summary>
        /// The progress awesome animator
        /// </summary>
        private readonly Animator ProgressAwesome_animator;
        /// <summary>
        /// The progress awesome animated start angle
        /// </summary>
        private int? ProgressAwesome_animatedStartAngle;

        /// <summary>
        /// The progress awesome animated value
        /// </summary>
        private float? ProgressAwesome_animatedValue;

        /// <summary>
        /// The progress awesome animation function
        /// </summary>
        private AnimationFunctions.Function ProgressAwesome_animationFunction;

        /// <summary>
        /// The progress awesome back brush
        /// </summary>
        private Brush ProgressAwesome_backBrush;

        /// <summary>
        /// The progress awesome known animation function
        /// </summary>
        private KnownAnimationFunctions ProgressAwesome_knownAnimationFunction;

        /// <summary>
        /// The progress awesome last style
        /// </summary>
        private ProgressBarStyle? ProgressAwesome_lastStyle;

        /// <summary>
        /// The progress awesome last value
        /// </summary>
        private float ProgressAwesome_lastValue;
        #endregion

        #region Constructor
        /// <summary>
        ///     Initializes a new instance of the <see cref="CircularProgressBar" /> class.
        /// </summary>
        /// <summary>
        /// Zeroits the progress bar awesome.
        /// </summary>
        public void ZeroitProgressBarAwesome()
        {
            //SetStyle(
            //    ControlStyles.SupportsTransparentBackColor |
            //    ControlStyles.AllPaintingInWmPaint |
            //    ControlStyles.UserPaint |
            //    ControlStyles.OptimizedDoubleBuffer |
            //    ControlStyles.ResizeRedraw, true);

            AnimationFunction = KnownAnimationFunctions.Liner;
            ProgressAwesome_AnimationSpeed = 500;
            MarqueeAnimationSpeed = 2000;
            StartAngle = 270;

            ProgressAwesome_lastValue = Value;

            // Child class should be responsible for handling this values at the constructor
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            //BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(64, 64, 64);
            //DoubleBuffered = true;
            Font = new Font(Font.FontFamily, 20, FontStyle.Bold);
            SecondaryFont = new Font(Font.FontFamily, (float)(Font.Size * .7), FontStyle.Regular);
            // ReSharper restore DoNotCallOverridableMethodsInConstructor

            //OuterMargin = -25;
            //OuterWidth = 26;
            //OuterColor = Color.Gray;

            //ProgressAwesome_ProgressWidth = 25;
            //ProgressColor = Color.FromArgb(156, 39, 176);

            //InnerMargin = 2;
            //InnerWidth = -1;
            //InnerColor = Color.FromArgb(224, 224, 224);

            TextMargin = new Padding(8, 8, 0, 0);
            Value = 0;

            SuperscriptMargin = new Padding(10, 35, 0, 0);
            SuperscriptColor = Color.FromArgb(166, 166, 166);
            SuperscriptText = "°C";

            SubscriptMargin = new Padding(10, -35, 0, 0);
            SubscriptColor = Color.FromArgb(166, 166, 166);
            SubscriptText = ".23";

            Size = new Size(200, 200);
            ProgressAwesome_ProgressWidth = 5;
            ProgressColor = Color.Teal;

            #region Zeroit AutoStart Code (Work in Progress)
            //timerAnimation.Tick += new System.EventHandler(timerAnimation_Tick);
            //if (AutoStart)
            //    timerAnimation.Start();
            #endregion
        }

        #endregion

        #region Timer

        #region Zeroit Timer Old Code
        //private void timerAnimation_Tick(object sender, EventArgs e)
        //{
        //    if (!DesignMode)
        //    {
        //        IncreaseValue();
        //        Invalidate();
        //    }

        //    if (DesignMode)
        //    {
        //        IncreaseValue();
        //        Invalidate();
        //    }
        //}

        //private void IncreaseValue()
        //{
        //    //if (_value + 1 <= _numberOfCircles)
        //    //    _value++;

        //    //else
        //    //    _value = 1;

        //    //Value++;

        //    int i;

        //    this.Minimum = 0;
        //    this.Maximum = 200;

        //    for (i = 0; i <= 200; i++)
        //    {
        //        this.Value = i;
        //    }
        //}



        ///// <summary>
        ///// Starts the animation.
        ///// </summary>
        //public void Start()
        //{
        //    timerAnimation.Interval = _interval;
        //    _stopped = false;
        //    timerAnimation.Start();
        //}

        ///// <summary>
        ///// Stops the animation.
        ///// </summary>
        //public void Stop()
        //{
        //    timerAnimation.Stop();
        //    _value = 1;
        //    _stopped = true;
        //    Invalidate();
        //}
        #endregion

        ////private bool enabletime;
        ////private int _autoStartInterval = 100;

        //public int AutoStartInterval
        //{
        //    get { return _autoStartInterval; }
        //    set
        //    {
        //        _autoStartInterval = value;
        //        timerAnimation.Interval = _autoStartInterval;
        //        Invalidate();
        //    }
        //}
        //public bool AutoStart
        //{
        //    get { return enabletime; }
        //    set
        //    {
        //        if (value == true)
        //        {
        //            timerAnimation.Enabled = true;
        //        }

        //        else
        //        {
        //            timerAnimation.Enabled = false;
        //            this.Value = 0;
        //            this.Text = Value.ToString();
        //        }

        //        enabletime = value;
        //        Invalidate();

        //    }
        //}

        /// <summary>
        /// Handles the Tick event of the timerAnimation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (!DesignMode)
            //{
            //    try
            //    {
            //        Value += 1;
            //        Text = Value.ToString();

            //        if (Value == Maximum)
            //        {
            //            Value = 0;
            //        }
            //    }
            //    catch (Exception ex)
            //    {


            //    }
            //}

            //if (DesignMode)
            //{
            //    try
            //    {
            //        Value += 1;
            //        Text = Value.ToString();

            //        if (Value == Maximum)
            //        {
            //            Value = 0;
            //        }
            //    }
            //    catch (Exception ex)
            //    {


            //    }
            //}

            ////if (DesignMode)
            ////{

            ////} 
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
        /// Handles the Tick event of the timerAnimation_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timerAnimation_Reduced_Tick(object sender, EventArgs e)
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

        #region Public Properties


        /// <summary>
        ///     Sets a known animation function.
        /// </summary>
        /// <summary>
        /// Gets or sets the animation function.
        /// </summary>
        /// <value>The animation function.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public KnownAnimationFunctions AnimationFunction
        {
            get { return ProgressAwesome_knownAnimationFunction; }
            set
            {
                ProgressAwesome_animationFunction = AnimationFunctions.FromKnown(value);
                ProgressAwesome_knownAnimationFunction = value;
            }
        }

        /// <summary>
        ///     Sets a custom animation function.
        /// </summary>
        /// <summary>
        /// Gets or sets the custom animation function.
        /// </summary>
        /// <value>The custom animation function.</value>
        /// <exception cref="ArgumentNullException">value</exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public AnimationFunctions.Function CustomAnimationFunction
        {
            private get { return ProgressAwesome_animationFunction; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                ProgressAwesome_knownAnimationFunction = KnownAnimationFunctions.None;
                ProgressAwesome_animationFunction = value;
            }
        }


        /// <summary>
        /// Gets or sets the progress bar awesome style.
        /// </summary>
        /// <value>The progress bar awesome style.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public ProgressBarStyle ProgressBarAwesomeStyle
        {
            get { return progressInput.ProgressBarAwesomeStyle; }
            set
            {
                progressInput.ProgressBarAwesomeStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Gets or sets the text in the <see cref="CircularProgressBar" />.
        /// </summary>
        //[EditorBrowsable(EditorBrowsableState.Always)]
        //[Browsable(true)]
        //public override string Text
        //{
        //    get { return base.Text; }
        //    set { base.Text = value; }
        //}

        /// <summary>
        ///     Gets or sets the animation speed in milliseconds.
        /// </summary>

        /// <summary>
        /// Gets or sets the progress awesome animation speed.
        /// </summary>
        /// <value>The progress awesome animation speed.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int ProgressAwesome_AnimationSpeed
        {
            get { return progressInput.ProgressAwesome_AnimationSpeed; }

            set
            {
                progressInput.ProgressAwesome_AnimationSpeed = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the text margin.
        /// </summary>
        /// <value>The text margin.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Padding TextMargin
        {
            get { return progressInput.TextMargin; }
            set
            {
                progressInput.TextMargin = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the superscript margin.
        /// </summary>
        /// <value>The superscript margin.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Padding SuperscriptMargin {
            get { return progressInput.SuperscriptMargin; }
            set
            {
                progressInput.SuperscriptMargin = value;
                Invalidate();
            }
        }


        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the subscript margin.
        /// </summary>
        /// <value>The subscript margin.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Padding SubscriptMargin {
            get { return progressInput.SubscriptMargin; }
            set
            {
                progressInput.SubscriptMargin = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the color of the inner.
        /// </summary>
        /// <value>The color of the inner.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Color InnerColor
        {
            get { return progressInput.InnerColor; }
            set
            {
                progressInput.InnerColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the inner margin.
        /// </summary>
        /// <value>The inner margin.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int InnerMargin
        {
            get { return progressInput.InnerMargin; }
            set
            {
                progressInput.InnerMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the width of the inner.
        /// </summary>
        /// <value>The width of the inner.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int InnerWidth
        {
            get { return progressInput.InnerWidth; }
            set
            {
                progressInput.InnerWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the color of the outer.
        /// </summary>
        /// <value>The color of the outer.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Color OuterColor
        {
            get { return progressInput.OuterColor; }
            set
            {
                progressInput.OuterColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the outer margin.
        /// </summary>
        /// <value>The outer margin.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int OuterMargin
        {
            get { return progressInput.OuterMargin; }
            set
            {
                progressInput.OuterMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the width of the outer.
        /// </summary>
        /// <value>The width of the outer.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int OuterWidth
        {
            get { return progressInput.OuterWidth; }
            set
            {
                progressInput.OuterWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <summary>
        /// Gets or sets the color of the progress.
        /// </summary>
        /// <value>The color of the progress.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Color ProgressColor {
            get { return progressInput.ProgressColor; }
            set
            {
                progressInput.ProgressColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the start angle.
        /// </summary>
        /// <value>The start angle.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int StartAngle {
            get { return progressInput.StartAngle; }
            set
            {
                progressInput.StartAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// 
        /// <summary>
        /// Gets or sets the width of the progress awesome progress.
        /// </summary>
        /// <value>The width of the progress awesome progress.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public int ProgressAwesome_ProgressWidth
        {
            get { return progressInput.ProgressAwesome_ProgressWidth; }
            set
            {
                progressInput.ProgressAwesome_ProgressWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// <summary>
        /// Gets or sets the subscript text.
        /// </summary>
        /// <value>The subscript text.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public string SubscriptText {
            get { return progressInput.SubscriptText; }
            set
            {
                progressInput.SubscriptText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the subscript.
        /// </summary>
        /// <value>The color of the subscript.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Color SubscriptColor {
            get { return progressInput.SubscriptColor; }
            set
            {
                progressInput.SubscriptColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the secondary font.
        /// </summary>
        /// <value>The secondary font.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Font SecondaryFont {
            get { return progressInput.SecondaryFont; }
            set
            {
                progressInput.SecondaryFont = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the superscript text.
        /// </summary>
        /// <value>The superscript text.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public string SuperscriptText {
            get { return progressInput.SuperscriptText; }
            set
            {
                progressInput.SuperscriptText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the superscript.
        /// </summary>
        /// <value>The color of the superscript.</value>
        [Category("CircularProgress Awesome")]
        [Browsable(false)]
        public Color SuperscriptColor {
            get { return progressInput.SuperscriptColor; }
            set
            {
                progressInput.SuperscriptColor = value;
                Invalidate();
            }
        }


        #endregion

        #region Overrides
        /// <summary>
        /// Initialize the animation for the continues styling
        /// </summary>
        /// <param name="firstTime">True if it is the first execution of this function, otherwise false</param>
        protected virtual void InitializeContinues(bool firstTime)
        {
            if ((ProgressAwesome_lastValue == Value) && !firstTime)
                return;

            ProgressAwesome_lastValue = Value;

            ProgressAwesome_animator.Stop();
            ProgressAwesome_animator.Paths =
                new Path(ProgressAwesome_animatedValue ?? Value, Value, (ulong)ProgressAwesome_AnimationSpeed, CustomAnimationFunction).ToArray();
            ProgressAwesome_animator.Repeat = false;
            ProgressAwesome_animatedStartAngle = null;
            ProgressAwesome_animator.Play(
                new SafeInvoker<float>(
                    v =>
                    {
                        try
                        {
                            ProgressAwesome_animatedValue = v;
                            Invalidate();
                        }
                        catch
                        {
                            ProgressAwesome_animator.Stop();
                        }
                    },
                    this));
        }

        /// <summary>
        /// Initialize the animation for the marquee styling
        /// </summary>
        /// <param name="firstTime">True if it is the first execution of this function, otherwise false</param>
        protected virtual void InitializeMarquee(bool firstTime)
        {
            if (!firstTime &&
                ((ProgressAwesome_animator.ActivePath == null) ||
                 ((ProgressAwesome_animator.ActivePath.Duration == (ulong)MarqueeAnimationSpeed) &&
                  (ProgressAwesome_animator.ActivePath.Function == CustomAnimationFunction))))
                return;

            ProgressAwesome_animator.Stop();
            ProgressAwesome_animator.Paths = new Path(0, 359, (ulong)MarqueeAnimationSpeed, CustomAnimationFunction).ToArray();
            ProgressAwesome_animator.Repeat = true;
            ProgressAwesome_animatedValue = null;
            ProgressAwesome_animator.Play(
                new SafeInvoker<float>(
                    v =>
                    {
                        try
                        {
                            ProgressAwesome_animatedStartAngle = (int)(v % 360);
                            Invalidate();
                        }
                        catch
                        {
                            ProgressAwesome_animator.Stop();
                        }
                    },
                    this));
        }


        /// <summary>
        /// The function responsible for painting the control
        /// </summary>
        /// <param name="g">The <see cref="Graphics" /> object to draw into</param>
        protected virtual void StartPaint(Graphics g)
        {
            try
            {
                lock (this)
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAlias;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    var point = AddPoint(Point.Empty, 2);
                    var size = AddSize(Size, -2 * 2);
                    if (OuterWidth + OuterMargin < 0)
                    {
                        var offset = Math.Abs(OuterWidth + OuterMargin);
                        point = AddPoint(Point.Empty, offset);
                        size = AddSize(Size, -2 * offset);
                    }

                    if ((OuterColor != Color.Empty) && (OuterColor != Color.Transparent) && (OuterWidth != 0))
                    {
                        g.FillEllipse(new SolidBrush(OuterColor), new RectangleF(point, size));
                        if (OuterWidth >= 0)
                        {
                            point = AddPoint(point, OuterWidth);
                            size = AddSize(size, -2 * OuterWidth);
                            g.FillEllipse(ProgressAwesome_backBrush, new RectangleF(point, size));
                        }
                    }

                    point = AddPoint(point, OuterMargin);
                    size = AddSize(size, -2 * OuterMargin);

                    g.FillPie(
                        new SolidBrush(ProgressColor),
                        ToRectangle(new RectangleF(point, size)),
                        ProgressAwesome_animatedStartAngle ?? StartAngle,
                        (ProgressAwesome_animatedValue ?? Value) / (Maximum - Minimum) * 360);
                    if (ProgressAwesome_ProgressWidth >= 0)
                    {
                        point = AddPoint(point, ProgressAwesome_ProgressWidth);
                        size = AddSize(size, -2 * ProgressAwesome_ProgressWidth);
                        g.FillEllipse(ProgressAwesome_backBrush, new RectangleF(point, size));
                    }

                    point = AddPoint(point, InnerMargin);
                    size = AddSize(size, -2 * InnerMargin);

                    if ((InnerColor != Color.Empty) && (InnerColor != Color.Transparent) && (InnerWidth != 0))
                    {
                        g.FillEllipse(new SolidBrush(InnerColor), new RectangleF(point, size));
                        if (InnerWidth >= 0)
                        {
                            point = AddPoint(point, InnerWidth);
                            size = AddSize(size, -2 * InnerWidth);
                            g.FillEllipse(ProgressAwesome_backBrush, new RectangleF(point, size));
                        }
                    }

                    if (Text == string.Empty)
                        return;

                    point.X += TextMargin.Left;
                    point.Y += TextMargin.Top;
                    size.Width -= TextMargin.Right;
                    size.Height -= TextMargin.Bottom;
                    var stringFormat =
                        new StringFormat(RightToLeft == RightToLeft.Yes ? StringFormatFlags.DirectionRightToLeft : 0)
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Near
                        };
                    var textSize = g.MeasureString(Text, Font);
                    var textPoint = new PointF(
                        point.X + (size.Width - textSize.Width) / 2,
                        point.Y + (size.Height - textSize.Height) / 2);
                    if ((SubscriptText != string.Empty) || (SuperscriptText != string.Empty))
                    {
                        float maxSWidth = 0;
                        var supSize = SizeF.Empty;
                        var subSize = SizeF.Empty;
                        if (SuperscriptText != string.Empty)
                        {
                            supSize = g.MeasureString(SuperscriptText, SecondaryFont);
                            maxSWidth = System.Math.Max(supSize.Width, maxSWidth);
                            supSize.Width -= SuperscriptMargin.Right;
                            supSize.Height -= SuperscriptMargin.Bottom;
                        }

                        if (SubscriptText != string.Empty)
                        {
                            subSize = g.MeasureString(SubscriptText, SecondaryFont);
                            maxSWidth = System.Math.Max(subSize.Width, maxSWidth);
                            subSize.Width -= SubscriptMargin.Right;
                            subSize.Height -= SubscriptMargin.Bottom;
                        }

                        textPoint.X -= maxSWidth / 4;
                        if (SuperscriptText != string.Empty)
                        {
                            var supPoint = new PointF(
                                textPoint.X + textSize.Width - supSize.Width / 2,
                                textPoint.Y - supSize.Height * 0.85f);
                            supPoint.X += SuperscriptMargin.Left;
                            supPoint.Y += SuperscriptMargin.Top;

                            if(ShowText)
                            g.DrawString(
                                SuperscriptText,
                                SecondaryFont,
                                new SolidBrush(SuperscriptColor),
                                new RectangleF(supPoint, supSize),
                                stringFormat);
                        }

                        if (SubscriptText != string.Empty)
                        {
                            var subPoint = new PointF(
                                textPoint.X + textSize.Width - subSize.Width / 2,
                                textPoint.Y + textSize.Height * 0.85f);
                            subPoint.X += SubscriptMargin.Left;
                            subPoint.Y += SubscriptMargin.Top;

                            if (ShowText)
                                g.DrawString(
                                SubscriptText,
                                SecondaryFont,
                                new SolidBrush(SubscriptColor),
                                new RectangleF(subPoint, subSize),
                                stringFormat);
                        }
                    }

                    if(ShowText)
                    g.DrawString(
                        Text + PostFix,
                        Font,
                        new SolidBrush(ForeColor),
                        new RectangleF(textPoint, textSize),
                        stringFormat);
                }
            }
            catch
            {
                // ignored
            }
        }


        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.LocationChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <inheritdoc />
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.StyleChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <inheritdoc />
        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.ParentChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <inheritdoc />
        protected override void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                Parent.Invalidated -= ParentOnInvalidated;
                Parent.Resize -= ParentOnResize;
            }
            base.OnParentChanged(e);
            if (Parent != null)
            {
                Parent.Invalidated += ParentOnInvalidated;
                Parent.Resize += ParentOnResize;
            }
        }

        /// <summary>
        /// Occurs when parent's display requires redrawing.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="invalidateEventArgs">The <see cref="InvalidateEventArgs"/> instance containing the event data.</param>
        protected virtual void ParentOnInvalidated(object sender, InvalidateEventArgs invalidateEventArgs)
        {
            RecreateBackgroundBrush();
        }

        /// <summary>
        /// Occurs when the parent resized.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="eventArgs">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected virtual void ParentOnResize(object sender, EventArgs eventArgs)
        {
            RecreateBackgroundBrush();
        }

        /// <summary>
        /// Update or create the brush used for drawing the background
        /// </summary>
        protected virtual void RecreateBackgroundBrush()
        {
            lock (this)
            {
                ProgressAwesome_backBrush?.Dispose();
                ProgressAwesome_backBrush = new SolidBrush(BackColor);
                if (BackColor.A == 255)
                    return;
                if (Parent != null)
                    using (var parentImage = new Bitmap(Parent.Width, Parent.Height))
                    {
                        using (var parentGraphic = Graphics.FromImage(parentImage))
                        {
                            var pe = new PaintEventArgs(parentGraphic, new Rectangle(new Point(0, 0), parentImage.Size));
                            InvokePaintBackground(Parent, pe);
                            InvokePaint(Parent, pe);

                            if (BackColor.A > 0) // Translucent
                                parentGraphic.FillRectangle(ProgressAwesome_backBrush, Bounds);
                        }
                        ProgressAwesome_backBrush = new TextureBrush(parentImage);
                        ((TextureBrush)ProgressAwesome_backBrush).TranslateTransform(-Bounds.X, -Bounds.Y);
                    }
                else
                    ProgressAwesome_backBrush = new SolidBrush(Color.FromArgb(255, BackColor));
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged" /> event when the <see cref="P:System.Windows.Forms.Control.BackColor" /> property value of the control's container changes.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <inheritdoc />
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            RecreateBackgroundBrush();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.BackgroundImageChanged" /> event when the <see cref="P:System.Windows.Forms.Control.BackgroundImage" /> property value of the control's container changes.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        /// <inheritdoc />
        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            RecreateBackgroundBrush();
        }

        #endregion

        #region Paint Event

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void ProgressAwesome_OnPaint(PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            if (ShowText)
            {
                Text = Convert.ToInt32((Value / Maximum) * 100).ToString() + PostFix;
            }

            #region Testing Code (Use the Try Catch Code for any error)

            if (ProgressBarAwesomeStyle == System.Windows.Forms.ProgressBarStyle.Marquee)
                InitializeMarquee(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            else
                InitializeContinues(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            ProgressAwesome_lastStyle = ProgressBarAwesomeStyle;


            if (ProgressAwesome_backBrush == null)
                RecreateBackgroundBrush();

            StartPaint(e.Graphics);

            #endregion
            
            //try
            //{
            //    if (!DesignMode)
            //    {
            //        //if (Style == System.Windows.Forms.ProgressBarStyle.Marquee)
            //        //    InitializeMarquee(ProgressAwesome_lastStyle != Style);
            //        //else
            //        //    InitializeContinues(ProgressAwesome_lastStyle != Style);
            //        //ProgressAwesome_lastStyle = Style;

            //        if (ProgressBarAwesomeStyle == System.Windows.Forms.ProgressBarStyle.Marquee)
            //            InitializeMarquee(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            //        else
            //            InitializeContinues(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            //        ProgressAwesome_lastStyle = ProgressBarAwesomeStyle;
            //    }
            //    if (ProgressAwesome_backBrush == null)
            //        RecreateBackgroundBrush();
            //    StartPaint(e.Graphics);
            //}
            //catch
            //{
            //    // ignored
            //}
        }


        /// <summary>
        /// Progresses the awesome on paint.
        /// </summary>
        /// <param name="e">The e.</param>
        private void ProgressAwesome_OnPaint(Graphics e)
        {
            e.SmoothingMode = Smoothing;
            e.TextRenderingHint = TextRendering;
            e.Clear(BackColor);

            if (ShowText)
            {
                Text = Convert.ToInt32((Value / Maximum) * 100).ToString() + PostFix;
            }

            #region Testing Code (Use the Try Catch Code for any error)

            if (ProgressBarAwesomeStyle == System.Windows.Forms.ProgressBarStyle.Marquee)
                InitializeMarquee(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            else
                InitializeContinues(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            ProgressAwesome_lastStyle = ProgressBarAwesomeStyle;


            if (ProgressAwesome_backBrush == null)
                RecreateBackgroundBrush();

            StartPaint(e);

            #endregion

            //try
            //{
            //    if (!DesignMode)
            //    {
            //        //if (Style == System.Windows.Forms.ProgressBarStyle.Marquee)
            //        //    InitializeMarquee(ProgressAwesome_lastStyle != Style);
            //        //else
            //        //    InitializeContinues(ProgressAwesome_lastStyle != Style);
            //        //ProgressAwesome_lastStyle = Style;

            //        if (ProgressBarAwesomeStyle == System.Windows.Forms.ProgressBarStyle.Marquee)
            //            InitializeMarquee(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            //        else
            //            InitializeContinues(ProgressAwesome_lastStyle != ProgressBarAwesomeStyle);
            //        ProgressAwesome_lastStyle = ProgressBarAwesomeStyle;
            //    }
            //    if (ProgressAwesome_backBrush == null)
            //        RecreateBackgroundBrush();
            //    StartPaint(e.Graphics);
            //}
            //catch
            //{
            //    // ignored
            //}
        }


        #endregion

        #region Private Methods

        /// <summary>
        /// Adds the point.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="v">The v.</param>
        /// <returns>PointF.</returns>
        private static PointF AddPoint(PointF p, int v)
        {
            p.X += v;
            p.Y += v;
            return p;
        }

        /// <summary>
        /// Adds the size.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="v">The v.</param>
        /// <returns>SizeF.</returns>
        private static SizeF AddSize(SizeF s, int v)
        {
            s.Height += v;
            s.Width += v;
            return s;
        }

        /// <summary>
        /// To the rectangle.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>Rectangle.</returns>
        private static Rectangle ToRectangle(RectangleF rect)
        {
            return new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }


        #endregion
    }


    

    #endregion

}
