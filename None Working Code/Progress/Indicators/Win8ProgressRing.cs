#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
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

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region ProgressRing

    #region Control
    // *************************************** class Win8_ProgressRing
    public partial class ThematicProgress
    {

        #region Constants
        // *********************************** constants and variables

        const int WinRing_CONTROL_HEIGHT = 100;           // pixels
        const int WinRing_CONTROL_WIDTH = WinRing_CONTROL_HEIGHT; // pixels
        static Color WinRing_INDICATOR_COLOR = Color.White;  // Color
        const double INDICATOR_OFFSET = 11.25;       // deg
        const int WinRing_MAXIMUM_INDICATORS = 6;         // units
        const int WinRing_SIZE_FACTOR = 20;               // pixels
        const double START_AT = 120.0;                // deg
        const double WinRing_TIMER_INTERVAL = 100.0;         // ms 
        #endregion

        #region Variables
        // ***********************************************************

        ZeroitWin8ProgressRingGraphicsBuffer WinRing_background = null;
        //int Control_Height = WinRing_CONTROL_HEIGHT;
        int WinRing_control_width = WinRing_CONTROL_WIDTH;
        ZeroitWin8ProgressRingGraphicsBuffer WinRing_indicator = null;
        int indicator_center_radius = 0;
        //Color WinRing_Indicator_Color = WinRing_INDICATOR_COLOR;
        int WinRing_indicator_diameter = 0;
        int indicator_radius = 0;
        WinRing_Indicator[] indicators = new WinRing_Indicator[
                                                WinRing_MAXIMUM_INDICATORS];
        int WinRing_inner_radius = 0;
        int WinRing_outer_radius = 0;
        Point P0 = Point.Empty;
        //int WinRing_Refresh_Rate = (int)WinRing_TIMER_INTERVAL;
        bool WinRing_revise_background_graphic = true;
        double start_at = START_AT;
        System.Timers.Timer WinRing_timer = new System.Timers.Timer();
        double WinRing_timer_interval = WinRing_TIMER_INTERVAL;
        // trigonometry tables
        double[] cosine = new double[1440];
        double[] sine = new double[1440];
        #endregion

        #region Private Methods
        // ************************************************* deg_2_rad

        double deg_2_rad(double degrees)
        {

            return (Math.PI * (degrees / 180.0));
        }



        // **************************** initialize_trigonometry_tables

        void initialize_trigonometry_tables()
        {

            for (int i = 0; (i < sine.Length); i++)
            {
                double degrees = 0.25 * (double)i;
                double radians = deg_2_rad(degrees);

                sine[i] = Math.Sin(radians);
                cosine[i] = Math.Cos(radians);
            }
        }

        // ******************************************************* cos

        double cos(double degrees)
        {
            int index = WinRing_round(degrees / 0.25);

            return (cosine[index]);
        }

        // ******************************************************* sin

        double sin(double degrees)
        {
            int index = WinRing_round(degrees / 0.25);

            return (sine[index]);
        }

        // ************************************* initialize_indicators

        void initialize_indicators()
        {
            double degrees = start_at;

            for (int i = 0; (i < WinRing_MAXIMUM_INDICATORS); i++)
            {
                if (degrees < 0.0)
                {
                    degrees += 360.0;
                }

                indicators[i] = new WinRing_Indicator(degrees);

                degrees -= INDICATOR_OFFSET;
            }
        }
        #endregion


        #region Memory Cleanup
        // ******************************************** WinRing_memory_cleanup

        void WinRing_memory_cleanup()
        {
            // DeleteGraphicsBuffer 
            // returns null
            if (WinRing_background != null)
            {
                WinRing_background = WinRing_background.DeleteGraphicsBuffer();
            }

            if (WinRing_indicator != null)
            {
                WinRing_indicator = WinRing_indicator.DeleteGraphicsBuffer();
            }
        }
        #endregion

        #region Round Method
        // ***************************************************** WinRing_round

        // http://en.wikipedia.org/wiki/Rounding

        int WinRing_round(double control_value)
        {

            return ((int)(control_value + 0.5));
        }
        #endregion

        #region Create Background Graphic
        // ********************************* WinRing_create_background_graphic

        void WinRing_create_background_graphic()
        {

            if (WinRing_background != null)
            {
                WinRing_background = WinRing_background.DeleteGraphicsBuffer();
            }
            WinRing_background = new ZeroitWin8ProgressRingGraphicsBuffer();
            WinRing_background.CreateGraphicsBuffer(WinRing_control_width,
                                              Control_Height);
            WinRing_background.Graphic.SmoothingMode = SmoothingMode.
                                               HighQuality;
        }
        #endregion

        #region Create WinRing_Indicator Graphic
        // ********************************** WinRing_create_indicator_graphic

        void WinRing_create_indicator_graphic()
        {

            if (WinRing_indicator != null)
            {
                WinRing_indicator = WinRing_indicator.DeleteGraphicsBuffer();
            }
            WinRing_indicator = new ZeroitWin8ProgressRingGraphicsBuffer();
            WinRing_indicator.CreateGraphicsBuffer(WinRing_control_width,
                                             Control_Height);
            WinRing_indicator.Graphic.SmoothingMode = SmoothingMode.
                                              HighQuality;
        }
        #endregion

        #region Adjust Control Dimensions from height
        // ********************* adjust_control_dimensions_from_height

        void adjust_control_dimensions_from_height(int new_height)
        {

            indicator_radius = WinRing_round((double)new_height /
                                       (double)WinRing_SIZE_FACTOR);
            WinRing_indicator_diameter = 2 * indicator_radius;

            Control_Height = WinRing_SIZE_FACTOR * indicator_radius;
            WinRing_control_width = Control_Height;

            WinRing_outer_radius = Control_Height / 2;
            WinRing_inner_radius = WinRing_outer_radius - WinRing_indicator_diameter;

            indicator_center_radius = WinRing_inner_radius +
                                      indicator_radius;

            this.Height = Control_Height;
            this.Width = WinRing_control_width;
        }
        #endregion

        #region Constructor
        // ***************************************** Win8_ProgressRing

        public void ZeroitWin8ProgressRing()
        {

            initialize_trigonometry_tables();
            adjust_control_dimensions_from_height(WinRing_CONTROL_HEIGHT);
            initialize_indicators();

            //this.SetStyle(
            //    (ControlStyles.DoubleBuffer |
            //      ControlStyles.UserPaint |
            //      ControlStyles.AllPaintingInWmPaint |
            //      ControlStyles.SupportsTransparentBackColor),
            //    true);
            this.UpdateStyles();

            //WinRing_timer = new System.Timers.Timer();
            WinRing_timer.Elapsed += new ElapsedEventHandler(WinRing_tick);
            //WinRing_timer.Interval = WinRing_Refresh_Rate;
            //WinRing_timer.Enabled = true;
        }
        #endregion

        #region Public Properties
        // *************************************************** WinRing_Animate

        [Category("Indicator Progress - Win8Ring"),
         Description("Start/stops WinRing_indicator animation"),
         DefaultValue(true),
         Bindable(true)]
        public bool WinRing_Animate
        {

            get
            {
                return (progressInput.WinRing_Animate);
            }

            set
            {
                if (value == true)
                {
                    WinRing_timer.Enabled = true;
                }
                else
                {
                    WinRing_timer.Enabled = false;
                }

                progressInput.WinRing_Animate = value;
                Invalidate();

            }
        }

        // ******************************************** Control_Height

        [Category("Indicator Progress - Win8Ring"),
         Description("Gets/Sets control height"),
         DefaultValue(100),
         Bindable(true)]
        public int Control_Height
        {

            get
            {
                return (progressInput.Control_Height);
            }
            set
            {
                int old_control_height = progressInput.Control_Height;

                progressInput.Control_Height = value;
                if (old_control_height != progressInput.Control_Height)
                {
                    adjust_control_dimensions_from_height(value);
                    WinRing_revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        // ******************************************* WinRing_Indicator_Color

        [Category("Indicator Progress - Win8Ring"),
         Description("Gets/Sets color of the rotating indicators"),
         DefaultValue(typeof(Color), "White"),
         Bindable(true)]
        public Color WinRing_Indicator_Color
        {

            get
            {
                return (progressInput.WinRing_Indicator_Color);
            }
            set
            {
                Color old_indicator_color = progressInput.WinRing_Indicator_Color;

                progressInput.WinRing_Indicator_Color = value;
                if (old_indicator_color != progressInput.WinRing_Indicator_Color)
                {
                    WinRing_revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        // ***************************************************** WinRing_Pulse

        public void WinRing_Pulse()
        {

            this.Invalidate();
        }

        // ********************************************** WinRing_Refresh_Rate

        [Category("Indicator Progress - Win8Ring"),
         Description("Specifies WinRing_indicator rotational refresh"),
         DefaultValue(200),
         Bindable(true)]
        public int WinRing_Refresh_Rate
        {

            get
            {
                return (progressInput.WinRing_Refresh_Rate);
            }

            set
            {
                int old_refresh_rate = progressInput.WinRing_Refresh_Rate;
                bool timer_running = WinRing_timer.Enabled;

                WinRing_timer.Interval = value;

                progressInput.WinRing_Refresh_Rate = value;
                if (progressInput.WinRing_Refresh_Rate < 10)
                {
                    progressInput.WinRing_Refresh_Rate = 10;
                }
                if (progressInput.WinRing_Refresh_Rate > 200)
                {
                    progressInput.WinRing_Refresh_Rate = 200;
                }

                if (timer_running)
                {
                    WinRing_timer.Stop();
                }

                WinRing_timer_interval = (double)progressInput.WinRing_Refresh_Rate;
                WinRing_timer.Interval = WinRing_timer_interval;

                if (timer_running)
                {
                    WinRing_timer.Start();
                }

                if (old_refresh_rate != progressInput.WinRing_Refresh_Rate)
                {
                    WinRing_revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }
        #endregion

        #region Draw Background Graphics
        // *********************************** WinRing_draw_background_graphic

        void WinRing_draw_background_graphic(Graphics graphics)
        {
            // currently nothing to do
        }
        #endregion

        #region Draw WinRing_Indicator Graphic
        // ************************************ WinRing_draw_indicator_graphic

        void WinRing_draw_indicator_graphic(Graphics graphics)
        {
            Brush brush = new SolidBrush(WinRing_Indicator_Color);
            Rectangle rectangle = new Rectangle();

            for (int i = (WinRing_MAXIMUM_INDICATORS - 1);
                      (i >= 0);
                      i--)
            {
                double degrees = indicators[i].Degrees;
                int dx;
                int dy;

                if (degrees < 0.0)
                {
                    degrees += 360.0;
                }

                dx = WinRing_round((double)indicator_center_radius *
                             cos(degrees)) +
                     indicator_center_radius;
                dy = indicator_center_radius -
                     WinRing_round((double)indicator_center_radius *
                             sin(degrees));

                rectangle.Location = new Point(dx, dy);
                rectangle.Size = new Size(WinRing_indicator_diameter,
                                            WinRing_indicator_diameter);
                graphics.FillEllipse(brush, rectangle);

                degrees -= (double)indicators[i].Fast *
                           INDICATOR_OFFSET;

                if (indicators[i].Fast > 1.0)
                {
                    indicators[i].Fast += 0.25;
                }

                if (degrees < 0.0)
                {
                    indicators[i].Fast = 1.25;
                }
                else if (degrees < START_AT)
                {
                    indicators[i].Fast = 1.0;
                }

                indicators[i].Degrees = degrees;
            }

            brush.Dispose();
        }
        #endregion

        #region Events and Overrides
        // ****************************************************** WinRing_tick

        void WinRing_tick(object source,
                    ElapsedEventArgs e)
        {

            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(
                        new EventHandler(
                            delegate
                            {
                                this.Refresh();
                            }
                            )
                        );
                }
                else
                {
                    this.Refresh();
                }
            }

            catch (Exception ex)
            {

            }
        }


        // ****************************************** OnControlRemoved

        //protected override void OnControlRemoved(
        //                                        ControlEventArgs e)
        //{

        //    base.OnControlRemoved(e);

        //    WinRing_memory_cleanup();
        //}

        // ************************************************** WinRing_OnResize

        private void WinRing_OnResize(EventArgs e)
        {

            
            adjust_control_dimensions_from_height(this.Height);

            WinRing_revise_background_graphic = true;

            this.Refresh();
        }

        // *************************************************** WinRing_OnPaint

        // see community additions in
        // http://msdn.microsoft.com/en-us/library/wk5b13s4(v=vs.90).aspx
        // regarding transparent WinRing_background

        private void WinRing_OnPaint(PaintEventArgs e)
        {

            {                       // begin transparent WinRing_background
                Rectangle clip;
                PaintEventArgs pea;
                GraphicsContainer state;

                state = e.Graphics.BeginContainer();
                e.Graphics.TranslateTransform(-this.Left,
                                                -this.Top);
                clip = e.ClipRectangle;
                clip.Offset(this.Left, this.Top);
                pea = new PaintEventArgs(e.Graphics, clip);
                // paint the container's 
                // WinRing_background
                InvokePaintBackground(this.Parent, pea);
                // paint the container's 
                // foreground
                InvokePaint(this.Parent, pea);
                // restores graphics to 
                // original state
                e.Graphics.EndContainer(state);
            }                       // end transparent WinRing_background

            if ((WinRing_background == null) || WinRing_revise_background_graphic)
            {
                if (WinRing_revise_background_graphic)
                {
                    WinRing_revise_background_graphic = false;
                }
                WinRing_create_background_graphic();
                WinRing_draw_background_graphic(WinRing_background.Graphic);
            }
            WinRing_background.RenderGraphicsBuffer(e.Graphics);

            WinRing_create_indicator_graphic();
            WinRing_draw_indicator_graphic(WinRing_indicator.Graphic);

            WinRing_indicator.RenderGraphicsBuffer(e.Graphics);
        }

        #endregion

    } // class Win8_ProgressRing

    #endregion

    #region Class WinRing_Indicator

    // *********************************************** class WinRing_Indicator

    public class WinRing_Indicator
    {
        double degrees = 0.0;
        double fast = 1.0;

        // ************************************************* WinRing_Indicator

        public WinRing_Indicator()
        {

            Degrees = 0.0;
            Fast = 1.0;
        }

        // ************************************************* WinRing_Indicator

        public WinRing_Indicator(double degrees)
        {

            Degrees = degrees;
            Fast = 1.0;
        }

        // *************************************************** Degrees

        public double Degrees
        {

            get
            {
                return (degrees);
            }
            set
            {
                degrees = value;
            }
        }

        // ****************************************************** Fast

        public double Fast
        {

            get
            {
                return (fast);
            }
            set
            {
                fast = value;
            }
        }

    } // class WinRing_Indicator 
    #endregion

    #region Graphics Buffer
    // ****************************************** class GraphicsBuffer

    public class ZeroitWin8ProgressRingGraphicsBuffer
    {
        Bitmap bitmap;
        Graphics graphics;
        int height;
        int width;

        // ******************************************** GraphicsBuffer

        /// <summary>
        /// constructor for the GraphicsBuffer
        /// </summary>
        public ZeroitWin8ProgressRingGraphicsBuffer()
        {

            width = 0;
            height = 0;
        }

        // ************************************** CreateGraphicsBuffer

        /// <summary>
        /// completes the creation of the GraphicsBuffer object
        /// </summary>
        /// <param name="width">
        /// width of the bitmap
        /// </param>
        /// <param name="height">
        /// height of the bitmap
        /// </param>
        /// <returns>
        /// true, if GraphicsBuffer created; otherwise, false
        /// </returns>
        public bool CreateGraphicsBuffer(int width,
                                           int height)
        {
            bool success = true;

            DeleteGraphicsBuffer();

            this.width = 0;
            this.height = 0;

            if ((width == 0) || (height == 0))
            {
                success = false;
            }
            else
            {
                this.width = width;
                this.height = height;

                bitmap = new Bitmap(this.width, this.height);
                graphics = Graphics.FromImage(bitmap);

                success = true;
            }

            return (success);
        }

        // ************************************** DeleteGraphicsBuffer

        /// <summary>
        /// deletes the current GraphicsBuffer
        /// </summary>
        /// <returns>
        /// null, always
        /// </returns>
        public ZeroitWin8ProgressRingGraphicsBuffer DeleteGraphicsBuffer()
        {

            if (graphics != null)
            {
                graphics.Dispose();
                graphics = null;
            }

            if (bitmap != null)
            {
                bitmap.Dispose();
                bitmap = null;
            }

            width = 0;
            height = 0;

            return (null);
        }

        // *************************************************** Graphic

        /// <summary>
        /// returns the current Graphic Graphics object
        /// </summary>
        public Graphics Graphic
        {

            get
            {
                return (graphics);
            }
        }

        // ************************************** RenderGraphicsBuffer

        /// <summary>
        /// Renders the buffer to the graphics object identified by 
        /// graphic
        /// </summary>
        /// <param name="graphic">
        /// target graphics object (e.g., PaintEventArgs e.Graphics)
        /// </param>
        public void RenderGraphicsBuffer(Graphics graphic)
        {

            if (bitmap != null)
            {
                graphic.DrawImage(
                            bitmap,
                            new Rectangle(0, 0, width, height),
                            new Rectangle(0, 0, width, height),
                            GraphicsUnit.Pixel);
            }
        }

    } // class GraphicsBuffer 
    #endregion

    

    #endregion

}
