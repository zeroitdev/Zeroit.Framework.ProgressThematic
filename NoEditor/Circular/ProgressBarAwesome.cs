#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
//using Zeroit.Framework.ProgressThematic;

#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region Falahati Circular ProgressBar

    /// <summary>
    ///     The circular progress bar windows form control
    /// </summary>
    public partial class ThematicProgress
    {

        #region Private Field

        #region Zeroit Additions
        //private int OuterMargin = -25;
        //private int OuterWidth = 26;
        //private Color OuterColor = Color.Gray;

        
        float ProgressAwesome_marqueeAnimationSpeed = 2000;
        string ProgressAwesome_superscriptText = "°C";
        Font ProgressAwesome_secondaryFont = new Font("Segoe UI", (float)12, FontStyle.Regular);
        string ProgressAwesome_subscriptText = ".23";
        Color ProgressAwesome_superscriptColor = Color.FromArgb(166, 166, 166);
        Color ProgressAwesome_subscriptColor = Color.FromArgb(166, 166, 166);
        int ProgressAwesome_startAngle = 270;
        Padding ProgressAwesome_subscriptMargin = new Padding(10, -35, 0, 0);
        Padding ProgressAwesome_superscriptMargin = new Padding(10, 35, 0, 0);
        Padding ProgressAwesome_textMargin = new Padding(8, 8, 0, 0);
        private int ProgressAwesome_animationSpeed = 500;
        private int ProgressAwesome_outerMargin = -25;
        private int ProgressAwesome_outerWidth = 26;
        private Color ProgressAwesome_outerColor = Color.Gray;
        private int ProgressAwesome_progressWidth = 5;
        private Color ProgressAwesome_progressColor = Color.Teal;
        private int ProgressAwesome_innerMargin = 2;
        private int ProgressAwesome_innerWidth = -1;
        private Color ProgressAwesome_innerColor = Color.FromArgb(224, 224, 224);
        private ProgressBarStyle ProgressAwesome_style = System.Windows.Forms.ProgressBarStyle.Blocks;




        #endregion

        private readonly Animator ProgressAwesome_animator;
        private int? ProgressAwesome_animatedStartAngle;

        private float? ProgressAwesome_animatedValue;

        private AnimationFunctions.Function ProgressAwesome_animationFunction;

        private Brush ProgressAwesome_backBrush;

        private KnownAnimationFunctions ProgressAwesome_knownAnimationFunction;

        private ProgressBarStyle? ProgressAwesome_lastStyle;

        private float ProgressAwesome_lastValue;
        #endregion

        #region Constructor
        /// <summary>
        ///     Initializes a new instance of the <see cref="CircularProgressBar" /> class.
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

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    Value += 1;
                    Text = Value.ToString();

                    if (Value == Maximum)
                    {
                        Value = 0;
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
                    Text = Value.ToString();

                    if (Value == Maximum)
                    {
                        Value = 0;
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

        #region Public Properties


        /// <summary>
        ///     Sets a known animation function.
        /// </summary>
        [Category("CircularProgress Awesome")]
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
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        [Category("CircularProgress Awesome")]
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


        [Category("CircularProgress Awesome")]
        public ProgressBarStyle ProgressBarAwesomeStyle
        {
            get { return ProgressAwesome_style; }
            set
            {
                ProgressAwesome_style = value;
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

        [Category("CircularProgress Awesome")]
        public int ProgressAwesome_AnimationSpeed
        {
            get { return ProgressAwesome_animationSpeed; }

            set
            {
                ProgressAwesome_animationSpeed = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Padding TextMargin
        {
            get { return ProgressAwesome_textMargin; }
            set
            {
                ProgressAwesome_textMargin = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Padding SuperscriptMargin {
            get { return ProgressAwesome_superscriptMargin; }
            set
            {
                ProgressAwesome_superscriptMargin = value;
                Invalidate();
            }
        }


        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Padding SubscriptMargin {
            get { return ProgressAwesome_subscriptMargin; }
            set
            {
                ProgressAwesome_subscriptMargin = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Color InnerColor
        {
            get { return ProgressAwesome_innerColor; }
            set
            {
                ProgressAwesome_innerColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public int InnerMargin
        {
            get { return ProgressAwesome_innerMargin; }
            set
            {
                ProgressAwesome_innerMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public int InnerWidth
        {
            get { return ProgressAwesome_innerWidth; }
            set
            {
                ProgressAwesome_innerWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Color OuterColor
        {
            get { return ProgressAwesome_outerColor; }
            set
            {
                ProgressAwesome_outerColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public int OuterMargin
        {
            get { return ProgressAwesome_outerMargin; }
            set
            {
                ProgressAwesome_outerMargin = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public int OuterWidth
        {
            get { return ProgressAwesome_outerWidth; }
            set
            {
                ProgressAwesome_outerWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// 
        [Category("CircularProgress Awesome")]
        public Color ProgressColor {
            get { return ProgressAwesome_progressColor; }
            set
            {
                ProgressAwesome_progressColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public int StartAngle {
            get { return ProgressAwesome_startAngle; }
            set
            {
                ProgressAwesome_startAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        /// 
        [Category("CircularProgress Awesome")]
        public int ProgressAwesome_ProgressWidth
        {
            get { return ProgressAwesome_progressWidth; }
            set
            {
                ProgressAwesome_progressWidth = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public string SubscriptText {
            get { return ProgressAwesome_subscriptText; }
            set
            {
                ProgressAwesome_subscriptText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Color SubscriptColor {
            get { return ProgressAwesome_subscriptColor; }
            set
            {
                ProgressAwesome_subscriptColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Font SecondaryFont {
            get { return ProgressAwesome_secondaryFont; }
            set
            {
                ProgressAwesome_secondaryFont = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public string SuperscriptText {
            get { return ProgressAwesome_superscriptText; }
            set
            {
                ProgressAwesome_superscriptText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// </summary>
        [Category("CircularProgress Awesome")]
        public Color SuperscriptColor {
            get { return ProgressAwesome_superscriptColor; }
            set
            {
                ProgressAwesome_superscriptColor = value;
                Invalidate();
            }
        }


        #endregion

        #region Overrides
        /// <summary>
        ///     Initialize the animation for the continues styling
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
        ///     Initialize the animation for the marquee styling
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
        ///     The function responsible for painting the control
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
                            maxSWidth = Math.Max(supSize.Width, maxSWidth);
                            supSize.Width -= SuperscriptMargin.Right;
                            supSize.Height -= SuperscriptMargin.Bottom;
                        }

                        if (SubscriptText != string.Empty)
                        {
                            subSize = g.MeasureString(SubscriptText, SecondaryFont);
                            maxSWidth = Math.Max(subSize.Width, maxSWidth);
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


        /// <inheritdoc />
        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            Invalidate();
        }

        /// <inheritdoc />
        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
            Invalidate();
        }

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
        ///     Occurs when parent's display requires redrawing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="invalidateEventArgs"></param>
        protected virtual void ParentOnInvalidated(object sender, InvalidateEventArgs invalidateEventArgs)
        {
            RecreateBackgroundBrush();
        }

        /// <summary>
        ///     Occurs when the parent resized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected virtual void ParentOnResize(object sender, EventArgs eventArgs)
        {
            RecreateBackgroundBrush();
        }

        /// <summary>
        ///     Update or create the brush used for drawing the background
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

        /// <inheritdoc />
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            RecreateBackgroundBrush();
        }

        /// <inheritdoc />
        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            RecreateBackgroundBrush();
        }

        #endregion

        #region Paint Event

        /// <summary>
        ///     Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data. </param>
        private void ProgressAwesome_OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            if (ShowText)
            {
                Text = Convert.ToInt32(Value).ToString() + PostFix;
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


        #endregion

        #region Private Methods

        private static PointF AddPoint(PointF p, int v)
        {
            p.X += v;
            p.Y += v;
            return p;
        }

        private static SizeF AddSize(SizeF s, int v)
        {
            s.Height += v;
            s.Width += v;
            return s;
        }

        private static Rectangle ToRectangle(RectangleF rect)
        {
            return new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }


        #endregion
    }


    

    #endregion

}
