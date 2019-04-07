﻿#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Data;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using Microsoft.Win32;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
//using System.Windows.Forms.VisualStyles;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region Google ProgressIndicator

    #region Control
    // Notes
    //
    //  This project was created using the Microsoft Visual C# 2008 
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

    public partial class ThematicProgress
    {




        #region Include in Private Field


        //private bool autoAnimate = true;
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

        private void GoogleProgress_Timer_Tick(object sender, EventArgs e)
        {
            if (this.ColorAngle + 1 > 360)
                this.ColorAngle = 0;
            else
            {
                this.ColorAngle++;
                this.UpdateStyles();
                this.Invalidate();

            }

        }

        #endregion


        #region Fields
        public enum GoogleProgress_INDICATORTYPES { ANIMATED, PULSED };

        //private Color AnnulusColor = Color.PaleTurquoise;
        private ZeroitGoogleProgressGraphicsBuffer GoogleProgress_annulus_graphic = null;
        private int GoogleProgress_annulus_thickness;
        //private Color GoogleProgress_BackgroundColor;
        private int GoogleProgress_indicator_angle = 0;
        //private int IndicatorAngularAdvance = 10;
        //private Color GoogleProgress_IndicatorColor = Color.White;
        private ZeroitGoogleProgressGraphicsBuffer GoogleProgress_indicator_graphic = null;
        
        //private GoogleProgress_INDICATORTYPES GoogleProgress_IndicatorType = GoogleProgress_INDICATORTYPES.ANIMATED;
        //private int InnerRadius = 20;
        //private int OuterRadius/* = 84*/;
        //private int GoogleProgress_RefreshRate = 100;

        //private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.Timer rotateColor = new System.Windows.Forms.Timer();

        //private float ColorAngle = 90;

        //private Color TransitionColor = Color.Gray;

        //private Color Color1Bigcircle = Color.Red;
        //private Color Color2Bigcircle = Color.Yellow;
        //private Color Color1Indicator = Color.Gray;
        //private Color Color2Indicator = Color.DarkBlue;
        //private Color ColorInnerBorder = Color.DarkBlue;
        //private int InnerBorder = 1;

        #endregion

        #region Public Properties

        // ********************************************* GoogleProgress_Pulse method

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator")]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Base color of the annulus"),
         DefaultValue(typeof(Color), "PaleTurquoise"),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Background color of the control"),
         //DefaultValue(typeof(SystemColors), "Control"),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Degrees indicator moves on each tick/pulse"),
         DefaultValue(10),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Color of rotating indicator"),
         DefaultValue(typeof(Color), "White"),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Specifies if control is animated or pulsed"),
         DefaultValue(GoogleProgress_INDICATORTYPES.ANIMATED),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Radius of annulus inner circle"),
         //DefaultValue(8),
         Bindable(true)]
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

                    GoogleProgress_annulus_thickness = OuterRadius - InnerRadius;

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

                    GoogleProgress_annulus_thickness = OuterRadius - InnerRadius;

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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Radius of annulus outer circle"),
         //DefaultValue(30),
         Bindable(true)]
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


        bool timer_running = false;
        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Specified timer tick interval"),
         //DefaultValue(150),
         Bindable(true)]
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

        [Category("Indicator Progress - GoogleProgressIndicator"),
         Description("Transition color at annulus mid-position"),
         DefaultValue(typeof(Color), "Gray"),
         Bindable(true)]
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

        #region Constructor
        // ********************** GoogleProgressIndicator constructor

        public void ZeroitGoogleProgressIndicator()
        {

            

            Application.ApplicationExit += new EventHandler(
                                                   GoogleProgress_memory_cleanup);



            OuterRadius = Size.Width -Size.Width/2;
            //InnerRadius = Size.Width - Size.Width / 2 - 4;
            
            GoogleProgress_annulus_thickness = OuterRadius - InnerRadius;

            
            //this.UpdateStyles();

            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = GoogleProgress_RefreshRate;
            timer.Tick += new EventHandler(GoogleProgress_Pulse);
            //timer.Start();
            //timer.Enabled = true;

            //rotateColor = new System.Windows.Forms.Timer();
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

            if (DesignMode)
            {
                MessageBox.Show("Please make sure you resize the control on implementation. " +
                "Use the smart tag to set the Inner and Outer Radius to aid in resizing. Thank you. Happy Coding.");
            }



        }

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
                case ProgressType.Circular:
                    
                    break;
                case ProgressType.Indicator:
                    switch (ProgressIndicator)
                    {
                        case ProgressIndicator.GoogleProgressIndicator:
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
        public void GoogleProgress_Pulse(object sender, EventArgs e)
        {

            this.UpdateStyles();
            this.Invalidate();
        }
        #endregion

        

        #region Paint Arguments and Methods

        public void GoogleProgress_Pulse()
        {

            this.UpdateStyles();
            this.Invalidate();
        }

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
                GoogleProgress_annulus_graphic.g.SmoothingMode = SmoothingMode.HighQuality;

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
                GoogleProgress_indicator_graphic.g.SmoothingMode = SmoothingMode.HighQuality;
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

        private void Google_Paint(PaintEventArgs e)
        {
            
            // create annulus graphic 
            // only if it does not exist
            // (it will not exist if some
            // graphics oriented property
            // is changed)

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

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
    public class ZeroitGoogleProgressGraphicsBuffer
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private int height;
        private int width;

        // ******************************* GraphicsBuffer constructor

        public ZeroitGoogleProgressGraphicsBuffer()
        {

            width = 0;
            height = 0;
        }

        // ************************************* CreateGraphicsBuffer

        /// <summary>
        /// Creates buffer object
        /// </summary>
        /// <param name="g">
        /// Window forms Graphics Object
        /// </param>
        /// <param name="width">
        /// Width of paint area
        /// </param>
        /// <param name="height">
        /// Height of paint area
        /// </param>
        /// <returns>
        /// true, if buffer created; otherwise, false
        /// </returns>
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

        public Graphics g
        {

            get
            {
                return (graphics);
            }
        }

        // ************************************* GraphicsBufferExists

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
        /// <param name="g">
        /// Window forms graphics object
        /// </param>
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