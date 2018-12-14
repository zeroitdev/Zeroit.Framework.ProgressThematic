// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="GoogleProgress.cs" company="Zeroit Dev Technologies">
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
    #region Google ProgressIndicator

    #region Control
    // Notes
    //
    //  This project was created using the Microsoft Visual C# 2017 
    //  Express Edition.
    //
    //  This compilation unit contains two classes, in the following 
    //  order:
    //
    //      GoogleProgressIndicator
    //      GraphicsBuffer
    //
    //  The GoogleProgressIndicator class MUST precede the 
    //  GraphicsBuffer class (a requirement of the Visual Studio 
    //  Designer) if both classes are to appear in the same 
    //  compilation unit.  The two classes appear in the same 
    //  compilation unit so that a reference to an external class
    //  (i.e., GraphicsBuffer) is not required.
    // 

    // **************************************************************
    // ******************************** GoogleProgressIndicator class
    // **************************************************************

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {




        #region Include in Private Field


        //private bool autoAnimate = true;
        /// <summary>
        /// The timer inner circle
        /// </summary>
        private System.Windows.Forms.Timer timerInnerCircle = new System.Windows.Forms.Timer();

        #endregion

        #region Include in Public Properties

        //public bool AutoAnimate
        //{
        //    get { return autoAnimate; }
        //    set
        //    {
        //        autoAnimate = value;

        //        if (value == true)
        //        {
        //            timerInnerCircle.Enabled = true;
        //        }

        //        else
        //        {
        //            timerInnerCircle.Enabled = false;
        //        }
        //        UpdateStyles();
        //        Invalidate();
        //    }
        //}

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the GoogleProgress_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GoogleProgress_Timer_Tick(object sender, EventArgs e)
        {

            #region Old Code
            //if (this.ColorAngle + 1 > 360)
            //    this.ColorAngle = 0;
            //else
            //{
            //    this.ColorAngle++;
            //    this.UpdateStyles();
            //    this.Invalidate();

            //} 
            #endregion


            
            if (Reverse)
            {
                if (this.ColorAngle + (Change * SpeedMultiplier) > 360)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    this.UpdateStyles();
                    Invalidate();
                }

                else
                {
                    this.ColorAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.ColorAngle + (Change * SpeedMultiplier) > 360)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    ColorAngle = 0;
                    this.UpdateStyles();
                    Invalidate();
                }

                else
                {
                    this.ColorAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick event of the GoogleProgress_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GoogleProgress_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            
            if (this.ColorAngle < this.Minimum)
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
                this.ColorAngle -= (Change * SpeedMultiplier);
                this.UpdateStyles();
                Invalidate();
            }

        }

        /// <summary>
        /// Googles the progress pulse.
        /// </summary>
        public void GoogleProgress_Pulse()
        {

            this.UpdateStyles();
            this.Invalidate();
        }

        #endregion


        #region Fields
        /// <summary>
        /// Enum GoogleProgress_INDICATORTYPES
        /// </summary>
        public enum GoogleProgress_INDICATORTYPES { ANIMATED, PULSED };

        //private Color AnnulusColor = Color.PaleTurquoise;
        /// <summary>
        /// The google progress annulus graphic
        /// </summary>
        private ZeroitGoogleProgressGraphicsBuffer GoogleProgress_annulus_graphic = null;
        /// <summary>
        /// The google progress annulus thickness
        /// </summary>
        private int GoogleProgress_annulus_thickness;
        //private Color GoogleProgress_BackgroundColor;
        /// <summary>
        /// The google progress indicator angle
        /// </summary>
        private int GoogleProgress_indicator_angle = 0;
        //private int IndicatorAngularAdvance = 10;
        //private Color GoogleProgress_IndicatorColor = Color.White;
        /// <summary>
        /// The google progress indicator graphic
        /// </summary>
        private ZeroitGoogleProgressGraphicsBuffer GoogleProgress_indicator_graphic = null;
        //private GoogleProgress_INDICATORTYPES GoogleProgress_IndicatorType = GoogleProgress_INDICATORTYPES.ANIMATED;
        //private int InnerRadius = 20;
        //private int OuterRadius/* = 84*/;
        //private int GoogleProgress_RefreshRate = 100;

        //private System.Windows.Forms.Timer timer;
        /// <summary>
        /// The rotate color
        /// </summary>
        private System.Windows.Forms.Timer rotateColor;

        //private float ColorAngle = 90;

        //private Color TransitionColor = Color.Gray;

        //private Color Color1Bigcircle = Color.Red;
        //private Color Color2Bigcircle = Color.Yellow;
        //private Color Color1Indicator = Color.Gray;
        //private Color Color2Indicator = Color.DarkBlue;
        //private Color ColorInnerBorder = Color.DarkBlue;
        //private int InnerBorder = 1;

        #endregion

        #region Constructor
        // ********************** GoogleProgressIndicator constructor

        /// <summary>
        /// Zeroits the google progress indicator.
        /// </summary>
        public void ZeroitGoogleProgressIndicator()
        {



            //Application.ApplicationExit += new EventHandler(
            //                                       GoogleProgress_memory_cleanup);

            OuterRadius = Size.Width -Size.Width/2;
            //InnerRadius = Size.Width - Size.Width / 2 - 4;
            
            GoogleProgress_annulus_thickness = OuterRadius - InnerRadius;

            
            //this.UpdateStyles();

            //timer = new System.Windows.Forms.Timer();
            timer.Interval = GoogleProgress_RefreshRate;
            timer.Tick += new EventHandler(GoogleProgress_Pulse);
            //timer.Start();
            //timer.Enabled = true;

            rotateColor = new System.Windows.Forms.Timer();
            rotateColor.Interval = GoogleProgress_RefreshRate;
            rotateColor.Tick += RotateColor_Tick;
            rotateColor.Start();
            rotateColor.Enabled = true;


            #region MyRegion
            if (DesignMode)
            {
                timerInnerCircle.Tick += Timer_Tick;
                if (AutoAnimate)
                {
                    timerInnerCircle.Interval = 100;
                    timerInnerCircle.Start();
                }
            }

            if (!DesignMode)
            {
                timerInnerCircle.Tick += Timer_Tick;

                if (AutoAnimate)
                {
                    timerInnerCircle.Interval = 100;
                    timerInnerCircle.Start();
                }
            }



            #endregion

            //if (DesignMode)
            //{
            //    MessageBox.Show("Please make sure you resize the control on implementation. " +
            //    "Use the smart tag to set the Inner and Outer Radius to aid in resizing. Thank you. Happy Coding.");
            //}



        }

        /// <summary>
        /// Handles the Tick event of the RotateColor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void RotateColor_Tick(object sender, EventArgs e)
        {
            #region Unused Code
            //throw new NotImplementedException();

            //for(float x = 0; x <=360; x++)
            //{
            //    ColorAngle = x;

            //    if(ColorAngle == 360)
            //    {
            //        ColorAngle = 0;

            //    }
            //} 
            #endregion

            switch (ProgressType)
            {
                case ProgressType.Bar:
                    break;
                
                    switch (SolidProgressBar)
                    {
                        case ProgressBar.IPGoogle:
                            if (DesignMode)
                            {

                                ColorAngle += 1;

                                if (ColorAngle > 360)
                                {
                                    rotateColor.Stop();
                                    ColorAngle = 0;
                                    rotateColor.Start();

                                    this.UpdateStyles();
                                    this.Invalidate();
                                }
                                this.UpdateStyles();
                                this.Invalidate();
                            }

                            if (!DesignMode)
                            {

                                ColorAngle += 1;

                                if (ColorAngle > 360)
                                {
                                    rotateColor.Stop();
                                    ColorAngle = 0;
                                    rotateColor.Start();

                                    this.UpdateStyles();
                                    this.Invalidate();
                                }

                                this.UpdateStyles();
                                this.Invalidate();

                            }
                            break;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            

        }

        #endregion

        #region Memory Cleanup Event Handler
        // ***************************** GoogleProgress_memory_cleanup event handler

        /// <summary>
        /// Handles the cleanup event of the GoogleProgress_memory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GoogleProgress_memory_cleanup(object sender, EventArgs e)
        {

            if (GoogleProgress_annulus_graphic != null)
            {
                GoogleProgress_annulus_graphic =
                    GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
            }

            if (GoogleProgress_indicator_graphic != null)
            {
                GoogleProgress_indicator_graphic =
                    GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
            }
        }

        // GoogleProgress_Pulse is overloaded to allow it to be used as both an 
        // event handler (with parameters) and as a method (without
        // parameters).


        // ************************************** GoogleProgress_Pulse event handler 
        /// <summary>
        /// Handles the Pulse event of the GoogleProgress control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void GoogleProgress_Pulse(object sender, EventArgs e)
        {

            this.UpdateStyles();
            this.Invalidate();
        }
        #endregion

        #region Public Properties

        // ********************************************* GoogleProgress_Pulse method

        /// <summary>
        /// Gets or sets the inner border.
        /// </summary>
        /// <value>The inner border.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public int InnerBorder
        {
            get { return progressInput.InnerBorder; }
            set
            {
                progressInput.InnerBorder = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color inner border.
        /// </summary>
        /// <value>The color inner border.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public Color ColorInnerBorder
        {
            get { return progressInput.ColorInnerBorder; }
            set
            {
                progressInput.ColorInnerBorder = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color1 bigcircle.
        /// </summary>
        /// <value>The color1 bigcircle.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public Color Color1Bigcircle
        {
            get { return progressInput.Color1Bigcircle; }
            set
            {
                progressInput.Color1Bigcircle = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color2 bigcircle.
        /// </summary>
        /// <value>The color2 bigcircle.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public Color Color2Bigcircle
        {
            get { return progressInput.Color2Bigcircle; }
            set
            {
                progressInput.Color2Bigcircle = value;


                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color1 indicator.
        /// </summary>
        /// <value>The color1 indicator.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public Color Color1Indicator
        {
            get { return progressInput.Color1Indicator; }
            set
            {
                progressInput.Color1Indicator = value;


                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color2 indicator.
        /// </summary>
        /// <value>The color2 indicator.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public Color Color2Indicator
        {
            get { return progressInput.Color2Indicator; }
            set
            {
                progressInput.Color2Indicator = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color angle.
        /// </summary>
        /// <value>The color angle.</value>
        [Category("Indicator Progress Google")]
        [Browsable(false)]
        public float ColorAngle
        {
            get { return progressInput.ColorAngle; }
            set
            {
                progressInput.ColorAngle = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();


            }
        }



        // ***************************************** Animate property

        //[Category("GoogleProgressIndicator"),
        // Description("Start/stops indicator animation"),
        // DefaultValue(true),
        // Bindable(true)]
        //public bool Animate
        //{

        //    get
        //    {
        //        return (timer.Enabled);
        //    }

        //    set
        //    {
        //        timer.Enabled = value;
        //    }
        //}

        // ************************************ AnnulusColor property

        /// <summary>
        /// Gets or sets the color of the annulus.
        /// </summary>
        /// <value>The color of the annulus.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Base color of the annulus"),
         DefaultValue(typeof(Color), "PaleTurquoise"),
         Bindable(true)]
        [Browsable(false)]
        public Color AnnulusColor
        {
            get
            {
                return (progressInput.AnnulusColor);
            }

            set
            {
                progressInput.AnnulusColor = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // ********************************* GoogleProgress_BackgroundColor property

        /// <summary>
        /// Gets or sets the color of the google progress background.
        /// </summary>
        /// <value>The color of the google progress background.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Background color of the control"),
         //DefaultValue(typeof(SystemColors), "Control"),
         Bindable(true)]
        [Browsable(false)]
        public Color GoogleProgress_BackgroundColor
        {

            get
            {
                return (progressInput.GoogleProgress_BackgroundColor);
            }

            set
            {
                progressInput.GoogleProgress_BackgroundColor = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                if (GoogleProgress_indicator_graphic != null)
                {
                    GoogleProgress_indicator_graphic =
                        GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }


        // ********************************** IndicatorAngularAdvance

        /// <summary>
        /// Gets or sets the indicator angular advance.
        /// </summary>
        /// <value>The indicator angular advance.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Degrees indicator moves on each tick/pulse"),
         DefaultValue(10),
         Bindable(true)]
        [Browsable(false)]
        public int IndicatorAngularAdvance
        {

            get
            {
                return (progressInput.IndicatorAngularAdvance);
            }

            set
            {
                progressInput.IndicatorAngularAdvance = value;

                if (progressInput.IndicatorAngularAdvance >= 360)
                {
                    progressInput.IndicatorAngularAdvance = 359;
                }

                if (progressInput.IndicatorAngularAdvance <= 0)
                {
                    progressInput.IndicatorAngularAdvance = 1;
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // ********************************** GoogleProgress_IndicatorColor property

        /// <summary>
        /// Gets or sets the color of the google progress indicator.
        /// </summary>
        /// <value>The color of the google progress indicator.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Color of rotating indicator"),
         DefaultValue(typeof(Color), "White"),
         Bindable(true)]
        [Browsable(false)]
        public Color GoogleProgress_IndicatorColor
        {

            get
            {
                return (progressInput.GoogleProgress_IndicatorColor);
            }

            set
            {
                progressInput.GoogleProgress_IndicatorColor = value;

                if (GoogleProgress_indicator_graphic != null)
                {
                    GoogleProgress_indicator_graphic =
                        GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // ******************************************** GoogleProgress_IndicatorType

        /// <summary>
        /// Gets or sets the type of the google progress indicator.
        /// </summary>
        /// <value>The type of the google progress indicator.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Specifies if control is animated or pulsed"),
         DefaultValue(GoogleProgress_INDICATORTYPES.ANIMATED),
         Bindable(true)]
        [Browsable(false)]
        public GoogleProgress_INDICATORTYPES GoogleProgress_IndicatorType
        {

            get
            {
                return (progressInput.GoogleProgress_IndicatorType);
            }

            set
            {
                progressInput.GoogleProgress_IndicatorType = value;

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // ************************************* InnerRadius property

        /// <summary>
        /// Gets or sets the inner radius.
        /// </summary>
        /// <value>The inner radius.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Radius of annulus inner circle"),
         //DefaultValue(8),
         Bindable(true)]
        [Browsable(false)]
        public int InnerRadius
        {

            get
            {
                return (progressInput.InnerRadius);
            }

            set
            {
                if (!DesignMode)
                {
                    progressInput.InnerRadius = value;


                    //if (InnerRadius >= OuterRadius)
                    //{
                    //    InnerRadius = OuterRadius - 2;
                    //}

                    //if ((InnerRadius % 2) != 0)
                    //{
                    //    InnerRadius--;
                    //}

                    GoogleProgress_annulus_thickness = OuterRadius - progressInput.InnerRadius;

                    if (GoogleProgress_annulus_graphic != null)
                    {
                        GoogleProgress_annulus_graphic =
                            GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                    }

                    if (GoogleProgress_indicator_graphic != null)
                    {
                        GoogleProgress_indicator_graphic =
                            GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
                    }

                    this.UpdateStyles();
                    this.Invalidate();
                }

                if (DesignMode)
                {

                    progressInput.InnerRadius = value;

                    //if (InnerRadius >= OuterRadius)
                    //{
                    //    InnerRadius = OuterRadius - 2;
                    //}

                    //if ((InnerRadius % 2) != 0)
                    //{
                    //    InnerRadius--;
                    //}

                    GoogleProgress_annulus_thickness = OuterRadius - progressInput.InnerRadius;

                    if (GoogleProgress_annulus_graphic != null)
                    {
                        GoogleProgress_annulus_graphic =
                            GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                    }

                    if (GoogleProgress_indicator_graphic != null)
                    {
                        GoogleProgress_indicator_graphic =
                            GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
                    }



                    this.UpdateStyles();
                    this.Invalidate();
                }

            }
        }

        // ************************************* OuterRadius property

        /// <summary>
        /// Gets or sets the outer radius.
        /// </summary>
        /// <value>The outer radius.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Radius of annulus outer circle"),
         //DefaultValue(30),
         Bindable(true)]
        [Browsable(false)]
        public int OuterRadius
        {

            get
            {
                return (progressInput.OuterRadius);
            }

            set
            {
                progressInput.OuterRadius = value;
                if ((progressInput.OuterRadius % 2) != 0)
                {
                    progressInput.OuterRadius--;
                }

                this.Width = 2 * progressInput.OuterRadius;
                this.Height = this.Width;

                GoogleProgress_annulus_thickness = progressInput.OuterRadius - InnerRadius;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                if (GoogleProgress_indicator_graphic != null)
                {
                    GoogleProgress_indicator_graphic =
                        GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // ************************************* GoogleProgress_RefreshRate property


        /// <summary>
        /// The timer running
        /// </summary>
        bool timer_running = false;
        /// <summary>
        /// Gets or sets the google progress refresh rate.
        /// </summary>
        /// <value>The google progress refresh rate.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Specified timer tick interval"),
         //DefaultValue(150),
         Bindable(true)]
        [Browsable(false)]
        public int GoogleProgress_RefreshRate
        {

            get
            {
                return (progressInput.GoogleProgress_RefreshRate);
            }

            set
            {


                progressInput.GoogleProgress_RefreshRate = value;

                if (progressInput.GoogleProgress_RefreshRate < 10)
                {
                    progressInput.GoogleProgress_RefreshRate = 10;
                }

                if (timer_running)
                {
                    timer.Stop();
                }
                timer.Interval = progressInput.GoogleProgress_RefreshRate;
                if (timer_running)
                {
                    timer.Start();
                }
            }
        }

        // ********************************* TransitionColor property

        /// <summary>
        /// Gets or sets the color of the transition.
        /// </summary>
        /// <value>The color of the transition.</value>
        [Category("Indicator Progress - GoogleProgress"),
         Description("Transition color at annulus mid-position"),
         DefaultValue(typeof(Color), "Gray"),
         Bindable(true)]
        [Browsable(false)]
        public Color TransitionColor
        {

            get
            {
                return (progressInput.TransitionColor);
            }

            set
            {
                progressInput.TransitionColor = value;

                if (GoogleProgress_annulus_graphic != null)
                {
                    GoogleProgress_annulus_graphic =
                        GoogleProgress_annulus_graphic.DeleteGraphicsBuffer();
                }

                this.UpdateStyles();
                this.Invalidate();
            }
        }

        // *********************************** create_annulus_graphic 
        #endregion

        #region Paint Arguments and Methods

        /// <summary>
        /// Creates the annulus graphic.
        /// </summary>
        private void create_annulus_graphic()
        {
            #region Fields
            LinearGradientBrush brush;
            Rectangle control_bounding_rectangle = new Rectangle();
            GraphicsPath inner_path;
            Rectangle inner_rectangle;
            int inner_rectangle_side;
            Region inner_region;
            Region outer_region;
            GraphicsPath outer_path;

            int outer_rectangle_side = 2 * OuterRadius;

            #region Unused Code


            Bitmap bit = new Bitmap(5, 5);
            PaintEventArgs e = new PaintEventArgs(Graphics.FromImage(bit), control_bounding_rectangle);

            control_bounding_rectangle = new Rectangle(0, 0, Width - 3, Height - 3);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillEllipse(new SolidBrush(Color.Green), control_bounding_rectangle);
            e.Graphics.DrawEllipse(new Pen(Color.Yellow, 2), control_bounding_rectangle);

            //// compute outer geometry
            outer_path = new GraphicsPath();

            //outer_path.AddEllipse(control_bounding_rectangle);

            outer_region = new Region(outer_path);
            // compute inner geometry
            inner_rectangle_side = 2 * InnerRadius;
            inner_rectangle = new Rectangle(
                                      GoogleProgress_annulus_thickness,
                                      GoogleProgress_annulus_thickness,
                                      (2 * InnerRadius) - 2,
                                      (2 * InnerRadius) - 2);

            inner_path = new GraphicsPath();
            //inner_path.AddEllipse(inner_rectangle);


            e.Graphics.FillEllipse(
                new SolidBrush(BackColor),
                inner_rectangle);

            e.Graphics.DrawEllipse(
                new Pen(Color.Black, 1),
                inner_rectangle);

            inner_region = new Region(inner_path);

            //// exclude inner from outer
            //outer_region.Exclude(inner_region);

            //// paint the outer
            //brush = create_linear_gradient_brush(
            //            new Point(OuterRadius, 0),
            //            new Point(OuterRadius,
            //                        outer_rectangle_side),
            //            AnnulusColor,
            //            TransitionColor);
            //e.Graphics.FillRegion(brush, outer_region);

            //// clean up
            //brush.Dispose();
            //outer_region.Dispose();
            //outer_path.Dispose();
            //inner_region.Dispose();
            //inner_path.Dispose();
            #endregion

            #endregion

            GoogleProgress_annulus_graphic = new ZeroitGoogleProgressGraphicsBuffer();
            if (GoogleProgress_annulus_graphic.CreateGraphicsBuffer(
                            this.CreateGraphics(),
                            this.Width,
                            this.Height))
            {
                GoogleProgress_annulus_graphic.g.SmoothingMode = Smoothing;
                GoogleProgress_annulus_graphic.g.TextRenderingHint = TextRendering;

                //control_bounding_rectangle = this.ClientRectangle;
                control_bounding_rectangle = new Rectangle(0, 0, Width - 2, Height - 2);

                //control_bounding_rectangle.Inflate(1, 1);
                GoogleProgress_annulus_graphic.g.FillRectangle(
                    new SolidBrush(BackColor),
                    control_bounding_rectangle);

                LinearGradientBrush linbrush = new LinearGradientBrush(control_bounding_rectangle, Color1Bigcircle, Color2Bigcircle, ColorAngle);
                GoogleProgress_annulus_graphic.g.FillEllipse(
                    /*new SolidBrush(Color.Red)*/ linbrush,
                    control_bounding_rectangle);

                GoogleProgress_annulus_graphic.g.DrawEllipse(
                    new Pen(Color.Transparent, 1),
                    control_bounding_rectangle);

                //control_bounding_rectangle.Inflate(-10, -10);


                //// compute outer geometry
                outer_path = new GraphicsPath();

                //outer_path.AddEllipse(control_bounding_rectangle);

                outer_region = new Region(outer_path);
                // compute inner geometry
                inner_rectangle_side = 2 * InnerRadius;
                inner_rectangle = new Rectangle(
                                          GoogleProgress_annulus_thickness,
                                          GoogleProgress_annulus_thickness,
                                          (2 * InnerRadius) - 2,
                                          (2 * InnerRadius) - 2);

                inner_path = new GraphicsPath();
                //inner_path.AddEllipse(inner_rectangle);


                GoogleProgress_annulus_graphic.g.FillEllipse(
                    new SolidBrush(BackColor),
                    inner_rectangle);

                GoogleProgress_annulus_graphic.g.DrawEllipse(
                    new Pen(ColorInnerBorder, InnerBorder),
                    inner_rectangle);

                inner_region = new Region(inner_path);

                // exclude inner from outer
                outer_region.Exclude(inner_region);

                // paint the outer
                brush = create_linear_gradient_brush(
                            new Point(OuterRadius, 0),
                            new Point(OuterRadius,
                                        outer_rectangle_side),
                            AnnulusColor,
                            TransitionColor);
                GoogleProgress_annulus_graphic.g.FillRegion(brush, outer_region);

                // clean up
                brush.Dispose();
                outer_region.Dispose();
                outer_path.Dispose();
                inner_region.Dispose();
                inner_path.Dispose();
            }
        }

        // ********************************* GoogleProgress_create_indicator_graphic

        // GoogleProgress_annulus_graphic MUST HAVE BEEN created before this method
        // is invoked

        /// <summary>
        /// Googles the progress create indicator graphic.
        /// </summary>
        private void GoogleProgress_create_indicator_graphic()
        {
            SolidBrush brush;
            Rectangle control_bounding_rectangle;
            GraphicsPath indicator_path = new GraphicsPath();
            Rectangle indicator_rectangle = new Rectangle();

            Region indicator_region;

            //Rectangle indicator_rectangle1 = new Rectangle((Width/2) , (Height / 2), 5,5);

            //Rectangle indicator_rectangle1 = new Rectangle(OuterRadius - GoogleProgress_annulus_thickness, -(GoogleProgress_annulus_thickness / 2), 10, 10);




            if (GoogleProgress_indicator_graphic != null)
            {
                GoogleProgress_indicator_graphic = GoogleProgress_indicator_graphic.DeleteGraphicsBuffer();
            }

            GoogleProgress_indicator_graphic = new ZeroitGoogleProgressGraphicsBuffer();

            if (GoogleProgress_indicator_graphic.CreateGraphicsBuffer(this.CreateGraphics(), 2 * OuterRadius, 2 * OuterRadius))
            {
                GoogleProgress_indicator_graphic.g.SmoothingMode = Smoothing;
                GoogleProgress_indicator_graphic.g.TextRenderingHint = TextRendering;
                control_bounding_rectangle = this.ClientRectangle;

                GoogleProgress_indicator_graphic.g.FillRectangle(new SolidBrush(Color.Transparent), control_bounding_rectangle);


                // compute region geometry
                indicator_rectangle = new Rectangle(
                    new Point(OuterRadius - GoogleProgress_annulus_thickness,
                                -(GoogleProgress_annulus_thickness / 2)),
                    new Size(GoogleProgress_annulus_thickness - 1, GoogleProgress_annulus_thickness - 1));

                //indicator_rectangle = new Rectangle(new Point(this.ClientRectangle.Width - OuterRadius, this.ClientRectangle.Height - OuterRadius), new Size(GoogleProgress_annulus_thickness, GoogleProgress_annulus_thickness));

                #region Unused Code
                //indicator_path.AddEllipse(indicator_rectangle);
                //GoogleProgress_indicator_graphic.g.DrawPath(new Pen(Color.White), indicator_path);
                //GoogleProgress_indicator_graphic.g.FillPath(new SolidBrush(Color.White),indicator_path);

                #endregion

                indicator_path.AddEllipse(indicator_rectangle);

                #region Unique Rectangle
                //GoogleProgress_indicator_graphic.g.FillEllipse(new SolidBrush(Color.Yellow),
                //    indicator_rectangle1);

                //GoogleProgress_indicator_graphic.g.DrawEllipse(new Pen(Color.Yellow),
                //    indicator_rectangle1);

                #endregion

                indicator_region = new Region(indicator_path);
                //indicator_region = new Region(indicator_rectangle1);

                // rotate the indicator
                GoogleProgress_indicator_graphic.g.ResetTransform();
                GoogleProgress_indicator_graphic.g.RotateTransform(
                                        (float)GoogleProgress_indicator_angle,
                                        MatrixOrder.Append);

                GoogleProgress_indicator_graphic.g.TranslateTransform(
                                    (float)OuterRadius,
                                    (float)OuterRadius,
                                    MatrixOrder.Append);

                LinearGradientBrush linbrushregion = new LinearGradientBrush(indicator_rectangle, Color1Indicator, Color2Indicator, ColorAngle);
                brush = new SolidBrush(GoogleProgress_IndicatorColor);
                //GoogleProgress_indicator_graphic.g.FillRegion(brush, indicator_region);
                GoogleProgress_indicator_graphic.g.FillRegion(linbrushregion, indicator_region);

                brush.Dispose();
                indicator_region.Dispose();
                indicator_path.Dispose();
            }
        }

        // ***************************** create_linear_gradient_brush

        /// <summary>
        /// Creates the linear gradient brush.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <param name="AnnulusColor">Color of the annulus.</param>
        /// <param name="TransitionColor">Color of the transition.</param>
        /// <returns>LinearGradientBrush.</returns>
        private LinearGradientBrush create_linear_gradient_brush(Point start, Point end, Color AnnulusColor, Color TransitionColor)
        {
            Blend blend = new Blend();
            LinearGradientBrush brush;
            float[] factors = { 0.0F, 0.25F, 0.75F, 0.25F, 0.0F };

            float[] positions = { 0.0F, 0.25F, 0.5F, 0.75F, 1.0F };

            blend.Factors = factors;
            blend.Positions = positions;
            brush = new LinearGradientBrush(start, end, AnnulusColor, TransitionColor);

            brush.Blend = blend;

            return (brush);
        }

        // ****************************************** OnMove override

        #endregion

        #region Overrides



        // ***************************************** OnPaint override

        /// <summary>
        /// Googles the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Google_Paint(PaintEventArgs e)
        {

            // create annulus graphic 
            // only if it does not exist
            // (it will not exist if some
            // graphics oriented property
            // is changed)

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            e.Graphics.Clear(BackColor);

            if (GoogleProgress_annulus_graphic == null)
            {
                create_annulus_graphic();
            }
            // always create indicator 
            // graphic
            GoogleProgress_create_indicator_graphic();

            // render to screen
            GoogleProgress_annulus_graphic.RenderGraphicsBuffer(e.Graphics);
            GoogleProgress_indicator_graphic.RenderGraphicsBuffer(e.Graphics);


            // revise rotation ColorAngle
            GoogleProgress_indicator_angle = (GoogleProgress_indicator_angle +
                                IndicatorAngularAdvance) % 360;

            //e.Dispose();
        }

        // ******************************* OnPaintBackground override



        // **************************************** OnResize override

        /// <summary>
        /// Googles the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Google_OnResize(EventArgs e)
        {
            OuterRadius = Size.Width - Size.Width / 2;

            //InnerRadius = Size.Width - Size.Width / 2 - 4;

            GoogleProgress_annulus_thickness = OuterRadius - InnerRadius;

        }

        #endregion

    } // class GoogleProgressIndicator

    // **************************************************************
    // ***************************************** GraphicsBuffer class
    // **************************************************************

    // Notes
    //
    //  The GraphicsBuffer class was derived from 
    //  http://www.codeproject.com/KB/GDI-plus/flickerFreeDrawing.aspx
    //
    //  Because the placement of GoogleProgressIndicator in the final 
    //  file structure is unknown, the GraphicsBuffer class has been 
    //  included in this compilation unit.  Thus, the control can 
    //  stand alone without requiring a reference to GraphicsBuffer.
    //
    //  GraphicsBuffer Ordering:
    //      
    //  1.  GraphicsBuffer private types
    //  2.  GraphicsBuffer constructor
    //  3.  Public methods
    //

    // **************************************************************
    // ******************************** GoogleProgressIndicator class
    // **************************************************************

    #region Custom Graphics Class
    /// <summary>
    /// Class ZeroitGoogleProgressGraphicsBuffer.
    /// </summary>
    public class ZeroitGoogleProgressGraphicsBuffer
    {
        /// <summary>
        /// The bitmap
        /// </summary>
        private Bitmap bitmap;
        /// <summary>
        /// The graphics
        /// </summary>
        private Graphics graphics;
        /// <summary>
        /// The height
        /// </summary>
        private int height;
        /// <summary>
        /// The width
        /// </summary>
        private int width;

        // ******************************* GraphicsBuffer constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitGoogleProgressGraphicsBuffer"/> class.
        /// </summary>
        public ZeroitGoogleProgressGraphicsBuffer()
        {

            width = 0;
            height = 0;
        }

        // ************************************* CreateGraphicsBuffer

        /// <summary>
        /// Creates buffer object
        /// </summary>
        /// <param name="g">Window forms Graphics Object</param>
        /// <param name="width">Width of paint area</param>
        /// <param name="height">Height of paint area</param>
        /// <returns>true, if buffer created; otherwise, false</returns>
        public bool CreateGraphicsBuffer(Graphics g, int width, int height)
        {
            bool success = true;

            if (bitmap != null)
            {
                bitmap.Dispose();
                bitmap = null;
            }

            if (graphics != null)
            {
                graphics.Dispose();
                graphics = null;

            }

            if ((width == 0) || (height == 0))
            {
                success = false;
            }
            else if ((width != this.width) ||
                      (height != this.height))
            {
                this.width = width;
                this.height = height;

                bitmap = new Bitmap(width, height);
                graphics = Graphics.FromImage(bitmap);

                success = true;
            }
            else
            {
                success = true;
            }


            return (success);
        }

        // ************************************* DeleteGraphicsBuffer

        /// <summary>
        /// Deletes the graphics buffer.
        /// </summary>
        /// <returns>ZeroitGoogleProgressGraphicsBuffer.</returns>
        public ZeroitGoogleProgressGraphicsBuffer DeleteGraphicsBuffer()
        {

            if (bitmap != null)
            {
                bitmap.Dispose();
                bitmap = null;
            }

            if (graphics != null)
            {
                graphics.Dispose();
                graphics = null;
            }

            width = 0;
            height = 0;

            return (null);
        }

        // ************************************************* g getter

        /// <summary>
        /// Gets the g.
        /// </summary>
        /// <value>The g.</value>
        public Graphics g
        {

            get
            {
                return (graphics);
            }
        }

        // ************************************* GraphicsBufferExists

        /// <summary>
        /// Gets a value indicating whether [graphics buffer exists].
        /// </summary>
        /// <value><c>true</c> if [graphics buffer exists]; otherwise, <c>false</c>.</value>
        public bool GraphicsBufferExists
        {

            get
            {
                return (graphics != null);
            }
        }

        // ************************************* RenderGraphicsBuffer

        /// <summary>
        /// Renders the buffer to the graphics object identified by g
        /// </summary>
        /// <param name="g">Window forms graphics object</param>
        public void RenderGraphicsBuffer(Graphics g)
        {

            if (bitmap != null)
            {
                g.DrawImage(bitmap,
                              new Rectangle(0, 0, width, height),
                              0, 0,
                              width, height,
                              GraphicsUnit.Pixel);
            }
        }

    }
    #endregion// class GraphicsBuffer 
    #endregion

    #region Designer Generated Code

    
    #endregion

    

    #endregion
}
