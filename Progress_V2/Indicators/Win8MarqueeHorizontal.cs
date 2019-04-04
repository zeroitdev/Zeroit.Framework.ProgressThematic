// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8MarqueeHorizontal.cs" company="Zeroit Dev Technologies">
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

    #region Marquee Progress Ring
    // **************************** class Win8MarqueeProgressIndicator
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Constant

        /// <summary>
        /// The control width
        /// </summary>
        const int CONTROL_WIDTH = 462;            // pixels
        /// <summary>
        /// The indicator color
        /// </summary>
        static Color INDICATOR_COLOR = Color.White;  // Color

        /// <summary>
        /// The initial fixed index
        /// </summary>
        const int INITIAL_FIXED_INDEX = 4;        // count
        /// <summary>
        /// The maximum indicators
        /// </summary>
        const int MAXIMUM_INDICATORS = 6;         // count
        /// <summary>
        /// The maximum positions
        /// </summary>
        const int MAXIMUM_POSITIONS = 33;         // count
        /// <summary>
        /// The maximum timer interval
        /// </summary>
        const double MAXIMUM_TIMER_INTERVAL = 200.0; // ms
        /// <summary>
        /// The maximum width
        /// </summary>
        const int MAXIMUM_WIDTH = 462;            // count
        /// <summary>
        /// The minimum timer interval
        /// </summary>
        const double MINIMUM_TIMER_INTERVAL = 10.0;  // ms
        /// <summary>
        /// The minimum width
        /// </summary>
        const int MINIMUM_WIDTH = 99;             // count
        /// <summary>
        /// The positions
        /// </summary>
        const int POSITIONS = 14;                 // count
        /// <summary>
        /// The timer interval
        /// </summary>
        const double TIMER_INTERVAL = 100.0;         // ms

        #endregion

        #region Private Field

        // ***********************************************************

        /// <summary>
        /// The background
        /// </summary>
        ZeroitWin8MarqueeHorizontalGraphicsBuffer background = null;
        /// <summary>
        /// The control height
        /// </summary>
        int control_height;
        //int Control_Width = CONTROL_WIDTH;
        /// <summary>
        /// The indicator
        /// </summary>
        ZeroitWin8MarqueeHorizontalGraphicsBuffer indicator = null;
        //Color Indicator_Color = INDICATOR_COLOR;
        /// <summary>
        /// The win hr indicator diameter
        /// </summary>
        int WinHR_indicator_diameter = 0;
        /// <summary>
        /// The position indices
        /// </summary>
        int[] position_indices = new int[
                                               MAXIMUM_INDICATORS];
        /// <summary>
        /// The positions
        /// </summary>
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
        /// <summary>
        /// The revise background graphic
        /// </summary>
        bool revise_background_graphic = true;
        /// <summary>
        /// The win hr timer
        /// </summary>
        System.Windows.Forms.Timer WinHR_timer = null;
        /// <summary>
        /// The timer interval
        /// </summary>
        double timer_interval = TIMER_INTERVAL;
        #endregion

        #region Constructor

        /// <summary>
        /// Zeroits the win8 marquee horizontal.
        /// </summary>
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

            WinHR_timer = new System.Windows.Forms.Timer();
            //WinHR_timer.Tick += new ElapsedEventHandler(WinHR_timer_tick);
            WinHR_timer.Tick += WinHR_timer_tick;
            WinHR_timer.Interval = /*TIMER_INTERVAL*/ AnimationSpeed[0];
            //WinHR_timer.Enabled = true;


        }


        #endregion

        #region Public Properties
        // *************************************************** WinHR_Animate
        /// <summary>
        /// Gets or sets a value indicating whether [win hr animate].
        /// </summary>
        /// <value><c>true</c> if [win hr animate]; otherwise, <c>false</c>.</value>
        [Browsable(false)]
        [Category("Indicator Progress - Win8HR"),
         Description("Start/stops indicator animation"),
         DefaultValue(true),
         Bindable(true)]
        
        public bool WinHR_Animate
        {

            get
            {
                return (progressInput.WinHR_Animate);
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

                progressInput.WinHR_Animate = value;

                Invalidate();
            }
        }

        // ********************************************* Control_Width
        /// <summary>
        /// Gets or sets the width of the control.
        /// </summary>
        /// <value>The width of the control.</value>
        [Browsable(false)]
        [Category("Indicator Progress - Win8HR"),
         Description("Gets/Sets control width"),
         DefaultValue(100),
         Bindable(true)]
        public int Control_Width
        {

            get
            {
                return (progressInput.Control_Width);
            }
            set
            {
                int old_control_width = progressInput.Control_Width;

                progressInput.Control_Width = value;

                if (progressInput.Control_Width < MINIMUM_WIDTH)
                {
                    progressInput.Control_Width = MINIMUM_WIDTH;
                }
                if (progressInput.Control_Width > MAXIMUM_WIDTH)
                {
                    progressInput.Control_Width = MAXIMUM_WIDTH;
                }

                if (old_control_width != progressInput.Control_Width)
                {
                    adjust_control_dimensions_from_width(
                        progressInput.Control_Width);
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        // ******************************************* Indicator_Color
        /// <summary>
        /// Gets or sets the color of the indicator.
        /// </summary>
        /// <value>The color of the indicator.</value>
        [Browsable(false)]
        [Category("Indicator Progress - Win8HR"),
         Description("Gets/Sets color of the moving indicators"),
         DefaultValue(typeof(Color), "White"),
         Bindable(true)]
        public Color Indicator_Color
        {

            get
            {
                return (progressInput.Indicator_Color);
            }
            set
            {
                Color old_indicator_color = progressInput.Indicator_Color;

                progressInput.Indicator_Color = value;
                if (old_indicator_color != progressInput.Indicator_Color)
                {
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }



        // ********************************************** Refresh_Rate
        /// <summary>
        /// Gets or sets the refresh rate.
        /// </summary>
        /// <value>The refresh rate.</value>
        [Browsable(false)]
        [Category("Indicator Progress - Win8HR"),
         Description("Specifies how often the indicators move"),
         DefaultValue(200),
         Bindable(true)]
        public int Refresh_Rate
        {

            get
            {
                return (progressInput.Refresh_Rate);
            }

            set
            {
                int old_refresh_rate = progressInput.Refresh_Rate;
                bool timer_running = WinHR_timer.Enabled;

                progressInput.Refresh_Rate = value;
                if (progressInput.Refresh_Rate < (int)MINIMUM_TIMER_INTERVAL)
                {
                    progressInput.Refresh_Rate = (int)MINIMUM_TIMER_INTERVAL;
                }
                if (progressInput.Refresh_Rate > (int)MAXIMUM_TIMER_INTERVAL)
                {
                    progressInput.Refresh_Rate = (int)MAXIMUM_TIMER_INTERVAL;
                }

                if (timer_running)
                {
                    WinHR_timer.Stop();
                }

                timer_interval = (double)progressInput.Refresh_Rate;
                WinHR_timer.Interval = (int)timer_interval;

                if (timer_running)
                {
                    WinHR_timer.Start();
                }

                if (old_refresh_rate != progressInput.Refresh_Rate)
                {
                    revise_background_graphic = true;
                    this.Invalidate();
                }
            }
        }

        #endregion

        #region Private Methods

        // ******************************************** WinHR_memory_cleanup

        /// <summary>
        /// Wins the hr memory cleanup.
        /// </summary>
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

        /// <summary>
        /// Initializes the indicators indices.
        /// </summary>
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

        /// <summary>
        /// Creates the background graphic.
        /// </summary>
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

        /// <summary>
        /// Wins the hr create indicator graphic.
        /// </summary>
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

        /// <summary>
        /// Rounds the specified parameter.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns>System.Int32.</returns>
        int round(double parameter)
        {

            return ((int)(parameter + 0.5));
        }

        // ********************** adjust_control_dimensions_from_width

        /// <summary>
        /// Adjusts the width of the control dimensions from.
        /// </summary>
        /// <param name="new_width">The new width.</param>
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

        /// <summary>
        /// Wins the hr pulse.
        /// </summary>
        public void WinHR_Pulse()
        {

            this.Invalidate();
        }



        // *********************************** draw_background_graphic

        /// <summary>
        /// Draws the background graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        void draw_background_graphic(Graphics graphics)
        {
            // currently nothing to do
        }

        // ************************************ WinHR_draw_indicator_graphic

        /// <summary>
        /// Wins the hr draw indicator graphic.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
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

        /// <summary>
        /// Handles the tick event of the WinHR_timer control.
        /// </summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void WinHR_timer_tick(object source,
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


        // ************************************************** WinHR_OnResize

        /// <summary>
        /// Wins the hr on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Wins the hr on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void WinHR_OnPaint(PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

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

    /// <summary>
    /// Class ZeroitWin8MarqueeHorizontalGraphicsBuffer.
    /// </summary>
    public class ZeroitWin8MarqueeHorizontalGraphicsBuffer
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
        public ZeroitWin8MarqueeHorizontalGraphicsBuffer()
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
