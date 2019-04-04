// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8ProgressRing.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
    #region ProgressRing

    #region Control
    // *************************************** class Win8_ProgressRing
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Constants
        // *********************************** constants and variables

        /// <summary>
        /// The win ring control height
        /// </summary>
        const int WinRing_CONTROL_HEIGHT = 100;           // pixels
        /// <summary>
        /// The win ring control width
        /// </summary>
        const int WinRing_CONTROL_WIDTH = WinRing_CONTROL_HEIGHT; // pixels
        /// <summary>
        /// The win ring indicator color
        /// </summary>
        static Color WinRing_INDICATOR_COLOR = Color.White;  // Color
        /// <summary>
        /// The indicator offset
        /// </summary>
        const double INDICATOR_OFFSET = 11.25;       // deg
        /// <summary>
        /// The win ring maximum indicators
        /// </summary>
        const int WinRing_MAXIMUM_INDICATORS = 6;         // units
        /// <summary>
        /// The win ring size factor
        /// </summary>
        const int WinRing_SIZE_FACTOR = 20;               // pixels
        /// <summary>
        /// The start at
        /// </summary>
        const double START_AT = 120.0;                // deg
        /// <summary>
        /// The win ring timer interval
        /// </summary>
        const double WinRing_TIMER_INTERVAL = 100.0;         // ms 
        #endregion

        #region Variables
        // ***********************************************************

        /// <summary>
        /// The win ring background
        /// </summary>
        ZeroitWin8ProgressRingGraphicsBuffer WinRing_background = null;
        //int Control_Height = WinRing_CONTROL_HEIGHT;
        /// <summary>
        /// The win ring control width
        /// </summary>
        int WinRing_control_width = WinRing_CONTROL_WIDTH;
        /// <summary>
        /// The win ring indicator
        /// </summary>
        ZeroitWin8ProgressRingGraphicsBuffer WinRing_indicator = null;
        /// <summary>
        /// The indicator center radius
        /// </summary>
        int indicator_center_radius = 0;
        //Color WinRing_Indicator_Color = WinRing_INDICATOR_COLOR;
        /// <summary>
        /// The win ring indicator diameter
        /// </summary>
        int WinRing_indicator_diameter = 0;
        /// <summary>
        /// The indicator radius
        /// </summary>
        int indicator_radius = 0;
        /// <summary>
        /// The indicators
        /// </summary>
        WinRing_Indicator[] indicators = new WinRing_Indicator[
                                                WinRing_MAXIMUM_INDICATORS];
        /// <summary>
        /// The win ring inner radius
        /// </summary>
        int WinRing_inner_radius = 0;
        /// <summary>
        /// The win ring outer radius
        /// </summary>
        int WinRing_outer_radius = 0;
        /// <summary>
        /// The p0
        /// </summary>
        Point P0 = Point.Empty;
        //int WinRing_Refresh_Rate = (int)WinRing_TIMER_INTERVAL;
        /// <summary>
        /// The win ring revise background graphic
        /// </summary>
        bool WinRing_revise_background_graphic = true;
        /// <summary>
        /// The start at
        /// </summary>
        double start_at = START_AT;
        /// <summary>
        /// The win ring timer
        /// </summary>
        System.Windows.Forms.Timer WinRing_timer = null;
        /// <summary>
        /// The win ring timer interval
        /// </summary>
        double WinRing_timer_interval = WinRing_TIMER_INTERVAL;
        // trigonometry tables
        /// <summary>
        /// The cosine
        /// </summary>
        double[] cosine = new double[1440];
        /// <summary>
        /// The sine
        /// </summary>
        double[] sine = new double[1440];
        #endregion

        #region Private Methods
        // ************************************************* deg_2_rad

        /// <summary>
        /// Degs the 2 RAD.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <returns>System.Double.</returns>
        double deg_2_rad(double degrees)
        {

            return (System.Math.PI * (degrees / 180.0));
        }



        // **************************** initialize_trigonometry_tables

        /// <summary>
        /// Initializes the trigonometry tables.
        /// </summary>
        void initialize_trigonometry_tables()
        {

            for (int i = 0; (i < sine.Length); i++)
            {
                double degrees = 0.25 * (double)i;
                double radians = deg_2_rad(degrees);

                sine[i] = System.Math.Sin(radians);
                cosine[i] = System.Math.Cos(radians);
            }
        }

        // ******************************************************* cos

        /// <summary>
        /// Coses the specified degrees.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <returns>System.Double.</returns>
        double cos(double degrees)
        {
            int index = WinRing_round(degrees / 0.25);

            return (cosine[index]);
        }

        // ******************************************************* sin

        /// <summary>
        /// Sins the specified degrees.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        /// <returns>System.Double.</returns>
        double sin(double degrees)
        {
            int index = WinRing_round(degrees / 0.25);

            return (sine[index]);
        }

        // ************************************* initialize_indicators

        /// <summary>
        /// Initializes the indicators.
        /// </summary>
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

        /// <summary>
        /// Wins the ring memory cleanup.
        /// </summary>
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

        /// <summary>
        /// Wins the ring round.
        /// </summary>
        /// <param name="control_value">The control value.</param>
        /// <returns>System.Int32.</returns>
        int WinRing_round(double control_value)
        {

            return ((int)(control_value + 0.5));
        }
        #endregion

        #region Create Background Graphic
        // ********************************* WinRing_create_background_graphic

        /// <summary>
        /// Wins the ring create background graphic.
        /// </summary>
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

        /// <summary>
        /// Wins the ring create indicator graphic.
        /// </summary>
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

        /// <summary>
        /// Adjusts the height of the control dimensions from.
        /// </summary>
        /// <param name="new_height">The new height.</param>
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

        /// <summary>
        /// Zeroits the win8 progress ring.
        /// </summary>
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
            //this.UpdateStyles();

            WinRing_timer = new System.Windows.Forms.Timer();
            //WinRing_timer.Elapsed += new ElapsedEventHandler(WinRing_tick);
            WinRing_timer.Tick += WinRing_tick;

            WinRing_timer.Interval = AnimationSpeed[0];
            //WinRing_timer.Enabled = true;
        }
        #endregion

        #region Public Properties
        // *************************************************** WinRing_Animate
        /// <summary>
        /// Gets or sets a value indicating whether [win ring animate].
        /// </summary>
        /// <value><c>true</c> if [win ring animate]; otherwise, <c>false</c>.</value>
        [Browsable(false)]
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
        /// <summary>
        /// Gets or sets the height of the control.
        /// </summary>
        /// <value>The height of the control.</value>
        [Browsable(false)]
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
        /// <summary>
        /// Gets or sets the color of the win ring indicator.
        /// </summary>
        /// <value>The color of the win ring indicator.</value>
        [Browsable(false)]
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

        /// <summary>
        /// Wins the ring pulse.
        /// </summary>
        public void WinRing_Pulse()
        {

            this.Invalidate();
        }

        // ********************************************** WinRing_Refresh_Rate
        /// <summary>
        /// Gets or sets the win ring refresh rate.
        /// </summary>
        /// <value>The win ring refresh rate.</value>
        [Browsable(false)]
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
                WinRing_timer.Interval = (int)WinRing_timer_interval;

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

        /// <summary>
        /// Wins the ring draw background graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        void WinRing_draw_background_graphic(Graphics graphics)
        {
            // currently nothing to do
        }
        #endregion

        #region Draw WinRing_Indicator Graphic
        // ************************************ WinRing_draw_indicator_graphic

        /// <summary>
        /// Wins the ring draw indicator graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        void WinRing_draw_indicator_graphic(Graphics graphics)
        {
            graphics.SmoothingMode = Smoothing;
            graphics.TextRenderingHint = TextRendering;
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

        /// <summary>
        /// Handles the tick event of the WinRing control.
        /// </summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void WinRing_tick(object source,
                    EventArgs e)
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

        /// <summary>
        /// Wins the ring on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Wins the ring on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void WinRing_OnPaint(PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            WinRing_timer.Interval = AnimationSpeed[0];

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

    /// <summary>
    /// Class WinRing_Indicator.
    /// </summary>
    public class WinRing_Indicator
    {
        /// <summary>
        /// The degrees
        /// </summary>
        double degrees = 0.0;
        /// <summary>
        /// The fast
        /// </summary>
        double fast = 1.0;

        // ************************************************* WinRing_Indicator

        /// <summary>
        /// Initializes a new instance of the <see cref="WinRing_Indicator"/> class.
        /// </summary>
        public WinRing_Indicator()
        {

            Degrees = 0.0;
            Fast = 1.0;
        }

        // ************************************************* WinRing_Indicator

        /// <summary>
        /// Initializes a new instance of the <see cref="WinRing_Indicator"/> class.
        /// </summary>
        /// <param name="degrees">The degrees.</param>
        public WinRing_Indicator(double degrees)
        {

            Degrees = degrees;
            Fast = 1.0;
        }

        // *************************************************** Degrees

        /// <summary>
        /// Gets or sets the degrees.
        /// </summary>
        /// <value>The degrees.</value>
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

        /// <summary>
        /// Gets or sets the fast.
        /// </summary>
        /// <value>The fast.</value>
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

    /// <summary>
    /// Class ZeroitWin8ProgressRingGraphicsBuffer.
    /// </summary>
    public class ZeroitWin8ProgressRingGraphicsBuffer
    {
        /// <summary>
        /// The bitmap
        /// </summary>
        Bitmap bitmap;
        /// <summary>
        /// The graphics
        /// </summary>
        Graphics graphics;
        /// <summary>
        /// The height
        /// </summary>
        int height;
        /// <summary>
        /// The width
        /// </summary>
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
        /// <param name="width">width of the bitmap</param>
        /// <param name="height">height of the bitmap</param>
        /// <returns>true, if GraphicsBuffer created; otherwise, false</returns>
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
        /// <returns>null, always</returns>
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
        /// <value>The graphic.</value>
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
        /// <param name="graphic">target graphics object (e.g., PaintEventArgs e.Graphics)</param>
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
