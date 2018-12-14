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

using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region Marquee Progress Ring
    // **************************** class Win8MarqueeProgressIndicator
    public partial class ThematicProgress
    {

        #region Constant

        const int CONTROL_WIDTH = 462;            // pixels
        static Color INDICATOR_COLOR = Color.White;  // Color

        const int INITIAL_FIXED_INDEX = 4;        // count
        const int MAXIMUM_INDICATORS = 6;         // count
        const int MAXIMUM_POSITIONS = 33;         // count
        const double MAXIMUM_TIMER_INTERVAL = 200.0; // ms
        const int MAXIMUM_WIDTH = 462;            // count
        const double MINIMUM_TIMER_INTERVAL = 10.0;  // ms
        const int MINIMUM_WIDTH = 99;             // count
        const int POSITIONS = 14;                 // count
        const double TIMER_INTERVAL = 100.0;         // ms

        #endregion

        #region Private Field
        
        // ***********************************************************

        ZeroitWin8MarqueeHorizontalGraphicsBuffer background = null;
        int control_height;
        //int Control_Width = CONTROL_WIDTH;
        ZeroitWin8MarqueeHorizontalGraphicsBuffer indicator = null;
        //Color Indicator_Color = INDICATOR_COLOR;
        int WinHR_indicator_diameter = 0;
        int[] position_indices = new int[
                                               MAXIMUM_INDICATORS];
        double[] positions = new double[POSITIONS]
                                {
                                 0.0,
                                 5.0,
                                 9.0,
                                11.0,
                                13.0,   // initial index points here
                                14.0,
                                15.0,
                                16.0,
                                17.0,
                                18.0,
                                20.0,
                                23.0,
                                27.0,
                                32.0,
                                };
        //int Refresh_Rate = (int)TIMER_INTERVAL;
        bool revise_background_graphic = true;
        System.Timers.Timer WinHR_timer = null;
        

        int control_width = 462;
        Color WinHR_indicator_color = Color.White;
        int WinHR_refresh_rate = 100;
        double timer_interval = 100;
        bool winHR_Animate = false;


        #endregion

        #region Constructor

        public void ZeroitWin8MarqueeHorizontal()
        {

            initialize_indicators_indices();
            adjust_control_dimensions_from_width(CONTROL_WIDTH);

            //this.SetStyle(
            //    (ControlStyles.DoubleBuffer |
            //      ControlStyles.UserPaint |
            //      ControlStyles.AllPaintingInWmPaint |
            //      ControlStyles.SupportsTransparentBackColor),
            //    true);
            //this.UpdateStyles();

            WinHR_timer = new System.Timers.Timer();
            WinHR_timer.Elapsed += new ElapsedEventHandler(WinHR_timer_tick);
            WinHR_timer.Interval = /*TIMER_INTERVAL*/ AnimationSpeed[0];
            //WinHR_timer.Enabled = true;


        }


        #endregion

        #region Public Properties
        // *************************************************** WinHR_Animate

        [Category("Indicator Progress - Win8HR"),
         Description("Start/stops indicator animation"),
         DefaultValue(true),
         Bindable(true)]
        public bool WinHR_Animate
        {

            get
            {
                return (winHR_Animate);
            }

            set
            {
                if (value == true)
                {
                    WinHR_timer.Enabled = true;
                }
                else
                {
                    WinHR_timer.Enabled = false;
                }

                winHR_Animate = value;

                Invalidate();
            }
        }

        // ********************************************* Control_Width

        [Category("Indicator Progress - Win8HR"),
         Description("Gets/Sets control width"),
         DefaultValue(100),
         Bindable(true)]
        public int Control_Width
        {

            get
            {
                return (control_width);
            }
            set
            {
                int old_control_width = control_width;

                control_width = value;

                if (control_width < MINIMUM_WIDTH)
                {
                    control_width = MINIMUM_WIDTH;
                }
                if (control_width > MAXIMUM_WIDTH)
                {
                    control_width = MAXIMUM_WIDTH;
                }

                if (old_control_width != control_width)
                {
                    adjust_control_dimensions_from_width(
                        control_width);
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        // ******************************************* Indicator_Color

        [Category("Indicator Progress - Win8HR"),
         Description("Gets/Sets color of the moving indicators"),
         DefaultValue(typeof(Color), "White"),
         Bindable(true)]
        public Color Indicator_Color
        {

            get
            {
                return (WinHR_indicator_color);
            }
            set
            {
                Color old_indicator_color = WinHR_indicator_color;

                WinHR_indicator_color = value;
                if (old_indicator_color != WinHR_indicator_color)
                {
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }



        // ********************************************** Refresh_Rate

        [Category("Indicator Progress - Win8HR"),
         Description("Specifies how often the indicators move"),
         DefaultValue(200),
         Bindable(true)]
        public int Refresh_Rate
        {

            get
            {
                return (WinHR_refresh_rate);
            }

            set
            {
                int old_refresh_rate = WinHR_refresh_rate;
                bool timer_running = WinHR_timer.Enabled;

                WinHR_refresh_rate = value;
                if (WinHR_refresh_rate < (int)MINIMUM_TIMER_INTERVAL)
                {
                    WinHR_refresh_rate = (int)MINIMUM_TIMER_INTERVAL;
                }
                if (WinHR_refresh_rate > (int)MAXIMUM_TIMER_INTERVAL)
                {
                    WinHR_refresh_rate = (int)MAXIMUM_TIMER_INTERVAL;
                }

                if (timer_running)
                {
                    WinHR_timer.Stop();
                }

                timer_interval = (double)WinHR_refresh_rate;
                WinHR_timer.Interval = timer_interval;

                if (timer_running)
                {
                    WinHR_timer.Start();
                }

                if (old_refresh_rate != WinHR_refresh_rate)
                {
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #region Private Methods

        // ******************************************** WinHR_memory_cleanup

        void WinHR_memory_cleanup()
        {
            // DeleteGraphicsBuffer 
            // returns null
            if (background != null)
            {
                background = background.DeleteGraphicsBuffer();
            }

            if (indicator != null)
            {
                indicator = indicator.DeleteGraphicsBuffer();
            }

            if (WinHR_timer != null)
            {
                if (WinHR_timer.Enabled)
                {
                    WinHR_timer.Enabled = false;
                }
                WinHR_timer.Dispose();
                WinHR_timer = null;
            }
        }

        // ***************************** initialize_indicators_indices

        void initialize_indicators_indices()
        {
            int index = INITIAL_FIXED_INDEX;

            for (int i = 0; (i < MAXIMUM_INDICATORS); i++)
            {
                position_indices[i] = new int();

                position_indices[i] = index;
                index += 1;
            }
        }

        // ********************************* create_background_graphic

        void create_background_graphic()
        {

            if (background != null)
            {
                background = background.DeleteGraphicsBuffer();
            }
            background = new ZeroitWin8MarqueeHorizontalGraphicsBuffer();
            background.CreateGraphicsBuffer(Control_Width,
                                              control_height);
            background.Graphic.SmoothingMode = Smoothing;
            background.Graphic.TextRenderingHint = TextRendering;
        }

        // ********************************** WinHR_create_indicator_graphic

        void WinHR_create_indicator_graphic()
        {

            if (indicator != null)
            {
                indicator = indicator.DeleteGraphicsBuffer();
            }
            indicator = new ZeroitWin8MarqueeHorizontalGraphicsBuffer();
            indicator.CreateGraphicsBuffer(Control_Width,
                                             control_height);
            indicator.Graphic.SmoothingMode = Smoothing;
            indicator.Graphic.TextRenderingHint = TextRendering;
        }

        // ***************************************************** round

        // http://en.wikipedia.org/wiki/Rounding

        int round(double parameter)
        {

            return ((int)(parameter + 0.5));
        }

        // ********************** adjust_control_dimensions_from_width

        void adjust_control_dimensions_from_width(int new_width)
        {

            WinHR_indicator_diameter = round(
                                     (double)new_width /
                                     (double)MAXIMUM_POSITIONS);

            Control_Width = WinHR_indicator_diameter * MAXIMUM_POSITIONS;
            control_height = WinHR_indicator_diameter;

            this.Width = Control_Width;
            this.Height = control_height;
        }

        // ****************************** Win8MarqueeProgressIndicator

        // ***************************************************** WinHR_Pulse

        public void WinHR_Pulse()
        {

            this.Invalidate();
        }



        // *********************************** draw_background_graphic

        void draw_background_graphic(Graphics graphics)
        {
            // currently nothing to do
        }

        // ************************************ WinHR_draw_indicator_graphic

        void WinHR_draw_indicator_graphic(Graphics graphics)
        {
            graphics.SmoothingMode = Smoothing;
            graphics.TextRenderingHint = TextRendering;

            Brush brush = new SolidBrush(Indicator_Color);
            Rectangle rectangle = new Rectangle();

            for (int i = (MAXIMUM_INDICATORS - 1);
                      (i >= 0);
                      i--)
            {
                int index;
                double position;
                int x;
                int y;

                index = position_indices[i];

                if (index >= POSITIONS)
                {
                    index = 0;
                }
                position = positions[index];

                x = round(position *
                            (double)WinHR_indicator_diameter);
                y = 0;

                rectangle.Location = new Point(x, y);
                rectangle.Size = new Size(WinHR_indicator_diameter,
                                            WinHR_indicator_diameter);
                graphics.FillEllipse(brush, rectangle);

                index++;
                position_indices[i] = index;
            }

            brush.Dispose();
        }

        #endregion

        #region Events

        // ****************************************************** WinHR_timer_tick

        void WinHR_timer_tick(object source,
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


        // ************************************************** WinHR_OnResize

        private void WinHR_OnResize(EventArgs e)
        {


            adjust_control_dimensions_from_width(this.Width + 1);

            revise_background_graphic = true;

            this.Refresh();
        }

        // *************************************************** WinHR_OnPaint

        // see community additions in
        // http://msdn.microsoft.com/en-us/library/wk5b13s4(v=vs.90).aspx
        // regarding transparent background

        private void WinHR_OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            WinHR_timer.Interval = AnimationSpeed[0];
            {                       // begin transparent background
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
                // background
                InvokePaintBackground(this.Parent, pea);
                // paint the container's 
                // foreground
                InvokePaint(this.Parent, pea);
                // restores graphics to 
                // original state
                e.Graphics.EndContainer(state);
            }                       // end transparent background

            if ((background == null) || revise_background_graphic)
            {
                if (revise_background_graphic)
                {
                    revise_background_graphic = false;
                }
                create_background_graphic();
                draw_background_graphic(background.Graphic);
            }
            background.RenderGraphicsBuffer(e.Graphics);

            WinHR_create_indicator_graphic();
            WinHR_draw_indicator_graphic(indicator.Graphic);

            indicator.RenderGraphicsBuffer(e.Graphics);
        }


        #endregion

    } // class Win8MarqueeProgressIndicator


    #region Graphic BufferClass

    // ****************************************** class GraphicsBuffer

    public class ZeroitWin8MarqueeHorizontalGraphicsBuffer
    {
        Bitmap bitmap;
        Graphics graphics;
        int height;
        int width;

        // ******************************************** GraphicsBuffer

        /// <summary>
        /// constructor for the GraphicsBuffer
        /// </summary>
        public ZeroitWin8MarqueeHorizontalGraphicsBuffer()
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
        public ZeroitWin8MarqueeHorizontalGraphicsBuffer DeleteGraphicsBuffer()
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
