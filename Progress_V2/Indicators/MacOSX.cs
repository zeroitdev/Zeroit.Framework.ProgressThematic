// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MacOSX.cs" company="Zeroit Dev Technologies">
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
    #region MacOSX


    #region MacOSX NonOptimized

    #region Control
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {


        #region Event

        /// <summary>
        /// Handles the Tick event of the MacOSX_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.MacOSX_StartAngle + 1 > 360)
            //    this.MacOSX_StartAngle = 0;
            //else
            //    this.MacOSX_StartAngle++;
            //Invalidate(); 
            #endregion

            
            if (Reverse)
            {
                if (this.MacOSX_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
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
                    this.MacOSX_StartAngle += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.MacOSX_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    MacOSX_StartAngle = 0;
                    Invalidate();
                }

                else
                {
                    this.MacOSX_StartAngle += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick event of the MacOSX_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_StartAngle < this.Minimum)
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
                this.MacOSX_StartAngle -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }
        }

        /// <summary>
        /// Macs the osx on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_OnResize(EventArgs e)
        {
            MacOSX_SpokesCount = (int)Maximum;
        }

        #endregion

        #region Constants

        /// <summary>
        /// The mac osx default interval
        /// </summary>
        private const int MacOSX_DEFAULT_INTERVAL = 60;
        /// <summary>
        /// The mac osx default tick color
        /// </summary>
        private readonly Color MacOSX_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        /// <summary>
        /// The mac osx default tick width
        /// </summary>
        private const int MacOSX_DEFAULT_TICK_WIDTH = 2;
        /// <summary>
        /// The mac osx minimum inner radius
        /// </summary>
        private const int MacOSX_MINIMUM_INNER_RADIUS = 4;
        /// <summary>
        /// The mac osx minimum outer radius
        /// </summary>
        private const int MacOSX_MINIMUM_OUTER_RADIUS = 8;
        /// <summary>
        /// The mac osx minimum control size
        /// </summary>
        private Size MacOSX_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        /// <summary>
        /// The mac osx minimum pen width
        /// </summary>
        private const int MacOSX_MINIMUM_PEN_WIDTH = 2;

        #endregion

        #region Enums

        /// <summary>
        /// Enum MacOSX_Direction
        /// </summary>
        public enum MacOSX_Direction
        {
            /// <summary>
            /// The clockwise
            /// </summary>
            CLOCKWISE,
            /// <summary>
            /// The anticlockwise
            /// </summary>
            ANTICLOCKWISE
        }

        #endregion

        #region Members

        //private int MacOSX_Interval;
        /// <summary>
        /// The mac osx m pen
        /// </summary>
        Pen MacOSX_m_Pen = null;
        /// <summary>
        /// The mac osx m centre pt
        /// </summary>
        PointF MacOSX_m_CentrePt = new PointF();
        /// <summary>
        /// The mac osx m inner radius
        /// </summary>
        int MacOSX_m_InnerRadius = 0;
        /// <summary>
        /// The mac osx m outer radius
        /// </summary>
        int MacOSX_m_OuterRadius = 0;
        //int MacOSX_StartAngle = 0;
        /// <summary>
        /// The mac osx m alpha start value
        /// </summary>
        int MacOSX_m_AlphaStartValue = 255;
        //int MacOSX_SpokesCount = 0;
        /// <summary>
        /// The mac osx m angle increment
        /// </summary>
        int MacOSX_m_AngleIncrement = 0;
        /// <summary>
        /// The mac osx m alpha decrement
        /// </summary>
        int MacOSX_m_AlphaDecrement = 0;
        /// <summary>
        /// The mac osx m timer
        /// </summary>
        System.Windows.Forms.Timer MacOSX_m_Timer = null;

        //private MacOSX_automatic MacOSX_Automatic = MacOSX_automatic.Start;
        //private LineCap MacOSX_StartCap = LineCap.Round;
        //private LineCap MacOSX_EndCap = LineCap.Round;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx maximum spokes.
        /// </summary>
        /// <value>The mac osx maximum spokes.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public int MacOSX_MaxSpokes
        {
            get { return progressInput.MacOSX_MaxSpokes; }
            set
            {
                progressInput.MacOSX_MaxSpokes = value;

                MaximumSpokeCount(value);
                MacOSX_CalculateSpokes();
                MacOSX_Optimized_CalculateSpokesPoints(value);
                MacOSX_Matrix_CalculateSpokesPoints(value);
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the mac osx start cap.
        /// </summary>
        /// <value>The mac osx start cap.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public LineCap MacOSX_StartCap
        {
            get { return progressInput.MacOSX_StartCap; }
            set
            {
                progressInput.MacOSX_StartCap = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the mac osx end cap.
        /// </summary>
        /// <value>The mac osx end cap.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public LineCap MacOSX_EndCap
        {
            get { return progressInput.MacOSX_EndCap; }
            set
            {
                progressInput.MacOSX_EndCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mac osx spokes count.
        /// </summary>
        /// <value>The mac osx spokes count.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public int MacOSX_SpokesCount
        {
            get { return progressInput.MacOSX_SpokesCount; }
            set
            {
                progressInput.MacOSX_SpokesCount = value;
                Invalidate();

            }
        }


        /// <summary>
        /// Gets or sets the mac osx automatic.
        /// </summary>
        /// <value>The mac osx automatic.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public MacOSX_automatic MacOSX_Automatic
        {
            get { return progressInput.MacOSX_Automatic; }
            set
            {
                progressInput.MacOSX_Automatic = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        /// <value>The mac osx interval.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public int MacOSX_Interval
        {
            get
            {
                return progressInput.MacOSX_Interval;
            }
            set
            {
                if (value > 0)
                {
                    progressInput.MacOSX_Interval = value;
                }
                else
                {
                    progressInput.MacOSX_Interval = MacOSX_DEFAULT_INTERVAL;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        /// <value>The color of the mac osx tick.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public Color MacOSX_TickColor
        {
            get { return progressInput.MacOSX_TickColor; }
            set
            {
                progressInput.MacOSX_TickColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// MacOSX_Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        /// <value>The mac osx rotation.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public MacOSX_Direction MacOSX_Rotation
        {
            get { return progressInput.MacOSX_Rotation; }
            set
            {
                progressInput.MacOSX_Rotation = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        /// <value>The mac osx start angle.</value>
        [Category("Indicator Progress MacOSX")]
        [Browsable(false)]
        public int MacOSX_StartAngle
        {
            get
            {
                return progressInput.MacOSX_StartAngle;
            }
            set
            {
                progressInput.MacOSX_StartAngle = value;
                Invalidate();
            }
        }

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Ctor
        /// </summary>
        public void ZeroitMacOSX()
        {
            //this.DoubleBuffered = true;
            
            //this.BackColor = Color.Transparent;
            this.MacOSX_TickColor = MacOSX_DEFAULT_TICK_COLOR;
            this.MinimumSize = MacOSX_MINIMUM_CONTROL_SIZE;
            this.MacOSX_Interval = MacOSX_DEFAULT_INTERVAL;
            // Default rotation direction is clockwise
            this.MacOSX_Rotation = MacOSX_Direction.CLOCKWISE;
            // Default starting angle is 12 o'clock
            this.MacOSX_StartAngle = 270;
            // Default number of Spokes in this control is 12
            //MacOSX_SpokesCount = /*12*/(int)Maximum;
            // Default alpha value of the first spoke is 255
            MacOSX_m_AlphaStartValue = 255;
            // Calculate the angle between adjacent spokes
            MacOSX_m_AngleIncrement = (int)(360 / MacOSX_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_m_AlphaDecrement = (int)((MacOSX_m_AlphaStartValue - 15) / MacOSX_SpokesCount);
            
            MacOSX_m_Pen = new Pen(MacOSX_TickColor, MacOSX_DEFAULT_TICK_WIDTH);
            MacOSX_m_Pen.EndCap = MacOSX_EndCap;
            MacOSX_m_Pen.StartCap = MacOSX_StartCap;
            MacOSX_m_Timer = new System.Windows.Forms.Timer();
            MacOSX_m_Timer.Interval = this.MacOSX_Interval;
            MacOSX_m_Timer.Tick += new EventHandler(OnTimerTick);
            
            MacOSX_CalculateSpokes();
        }

        #endregion

        #region EventHandlers

        /// <summary>
        /// Handle the Tick event
        /// </summary>
        /// <param name="sender">Timer</param>
        /// <param name="e">EventArgs</param>
        void OnTimerTick(object sender, EventArgs e)
        {
            if (MacOSX_Rotation == MacOSX_Direction.CLOCKWISE)
            {
                MacOSX_StartAngle += MacOSX_m_AngleIncrement;

                if (MacOSX_StartAngle >= 360)
                    MacOSX_StartAngle = 0;
            }
            else if (MacOSX_Rotation == MacOSX_Direction.ANTICLOCKWISE)
            {
                MacOSX_StartAngle -= MacOSX_m_AngleIncrement;

                if (MacOSX_StartAngle <= -360)
                    MacOSX_StartAngle = 0;
            }

            Invalidate();
        }

        /// <summary>
        /// Handles the Paint Event of the control
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void MacOSX_Paint(PaintEventArgs e)
        {
            // All the painting will be handled by us.
            //base.OnPaint(e);

            
            switch (MacOSX_Automatic)
            {
                case MacOSX_automatic.Start:
                    this.Start();
                    break;
                case MacOSX_automatic.FastRotate:
                    #region MyRegion
                    if (DesignMode)
                    {
                        timer.Tick += Timer_Tick;
                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Interval;
                            timer.Start();
                        }
                    }

                    if (!DesignMode)
                    {
                        timer.Tick += Timer_Tick;

                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Interval;
                            timer.Start();
                        }
                    }

                    #endregion
                    break;
                case MacOSX_automatic.SlowRotate:
                    this.Stop();

                    break;

                case MacOSX_automatic.Stop:
                    this.Stop();
                    timer.Stop();
                    break;
                default:
                    break;
            }
            
            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);
            
            MacOSX_m_Pen.EndCap = MacOSX_EndCap;
            MacOSX_m_Pen.StartCap = MacOSX_StartCap;

            // Since the Rendering of the spokes is dependent upon the current size of the 
            // control, the following calculation needs to be done within the Paint eventhandler.
            int alpha = MacOSX_m_AlphaStartValue;
            int angle = MacOSX_StartAngle;
            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_m_Pen.Width = (int)(width / 15);
            if (MacOSX_m_Pen.Width < MacOSX_MINIMUM_PEN_WIDTH)
                MacOSX_m_Pen.Width = MacOSX_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_m_InnerRadius = (int)(width * (140 / (float)800));
            if (MacOSX_m_InnerRadius < MacOSX_MINIMUM_INNER_RADIUS)
                MacOSX_m_InnerRadius = MacOSX_MINIMUM_INNER_RADIUS;
            MacOSX_m_OuterRadius = (int)(width * (250 / (float)800));
            if (MacOSX_m_OuterRadius < MacOSX_MINIMUM_OUTER_RADIUS)
                MacOSX_m_OuterRadius = MacOSX_MINIMUM_OUTER_RADIUS;

            // Render the spokes
            for (int i = 0; i < MacOSX_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_m_InnerRadius * (float)System.Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_InnerRadius * (float)System.Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_m_OuterRadius * (float)System.Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_OuterRadius * (float)System.Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));

                pt1.X += MacOSX_m_CentrePt.X;
                pt1.Y += MacOSX_m_CentrePt.Y;
                pt2.X += MacOSX_m_CentrePt.X;
                pt2.Y += MacOSX_m_CentrePt.Y;
                MacOSX_m_Pen.Color = Color.FromArgb(alpha, this.MacOSX_TickColor);
                e.Graphics.DrawLine(MacOSX_m_Pen, pt1, pt2);

                if (MacOSX_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_m_AngleIncrement;
                }
                else if (MacOSX_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_m_AngleIncrement;
                }

                //if (i < 5)
                //    alpha -= 45;
                alpha -= MacOSX_m_AlphaDecrement;
            }
            
        }

        /// <summary>
        /// Macs the osx calculate spokes.
        /// </summary>
        private void MacOSX_CalculateSpokes()
        {
            MacOSX_m_Pen = new Pen(MacOSX_TickColor, MacOSX_DEFAULT_TICK_WIDTH);
            MacOSX_m_Pen.EndCap = MacOSX_EndCap;
            MacOSX_m_Pen.StartCap = MacOSX_StartCap;

            //MacOSX_SpokesCount = (int)Maximum;
            // Default alpha value of the first spoke is 255
            MacOSX_m_AlphaStartValue = 255;
            // Calculate the angle between adjacent spokes
            MacOSX_m_AngleIncrement = (int)(360 / MacOSX_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_m_AlphaDecrement = (int)((MacOSX_m_AlphaStartValue - 15) / MacOSX_SpokesCount);
            
            // Since the Rendering of the spokes is dependent upon the current size of the 
            // control, the following calculation needs to be done within the Paint eventhandler.
            int alpha = MacOSX_m_AlphaStartValue;
            int angle = MacOSX_StartAngle;
            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_m_Pen.Width = (int)(width / 15);
            if (MacOSX_m_Pen.Width < MacOSX_MINIMUM_PEN_WIDTH)
                MacOSX_m_Pen.Width = MacOSX_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_m_InnerRadius = (int)(width * (140 / (float)800));
            if (MacOSX_m_InnerRadius < MacOSX_MINIMUM_INNER_RADIUS)
                MacOSX_m_InnerRadius = MacOSX_MINIMUM_INNER_RADIUS;
            MacOSX_m_OuterRadius = (int)(width * (250 / (float)800));
            if (MacOSX_m_OuterRadius < MacOSX_MINIMUM_OUTER_RADIUS)
                MacOSX_m_OuterRadius = MacOSX_MINIMUM_OUTER_RADIUS;

            // Render the spokes
            for (int i = 0; i < MacOSX_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_m_InnerRadius * (float)System.Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_InnerRadius * (float)System.Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_m_OuterRadius * (float)System.Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_OuterRadius * (float)System.Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));

                pt1.X += MacOSX_m_CentrePt.X;
                pt1.Y += MacOSX_m_CentrePt.Y;
                pt2.X += MacOSX_m_CentrePt.X;
                pt2.Y += MacOSX_m_CentrePt.Y;
                MacOSX_m_Pen.Color = Color.FromArgb(alpha, this.MacOSX_TickColor);
                
                if (MacOSX_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_m_AngleIncrement;
                }
                else if (MacOSX_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_m_AngleIncrement;
                }

                //if (i < 5)
                //    alpha -= 45;
                alpha -= MacOSX_m_AlphaDecrement;
            }
        }

        /// <summary>
        /// Maximums the spoke count.
        /// </summary>
        /// <param name="value">The value.</param>
        private void MaximumSpokeCount(float value)
        {
            MacOSX_SpokesCount = (int)value;
            // Default alpha value of the first spoke is 255
            MacOSX_m_AlphaStartValue = 255;
            // Calculate the angle between adjacent spokes
            MacOSX_m_AngleIncrement = (int) (360 / value);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_m_AlphaDecrement = (int) ((MacOSX_m_AlphaStartValue - 15) / value);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Converts Degrees to Radians
        /// </summary>
        /// <param name="degrees">Degrees</param>
        /// <returns>System.Double.</returns>
        private double MacOSX_ConvertDegreesToRadians(int degrees)
        {
            return ((System.Math.PI / (double)180) * degrees);
        }

        #endregion

        #region APIs

        /// <summary>
        /// Start the Tick Control rotation
        /// </summary>
        public void Start()
        {
            if (MacOSX_m_Timer != null)
            {
                MacOSX_m_Timer.Interval = this.MacOSX_Interval;
                MacOSX_m_Timer.Enabled = true;
            }
        }

        /// <summary>
        /// Stop the Tick Control rotation
        /// </summary>
        public void Stop()
        {
            if (MacOSX_m_Timer != null)
            {
                MacOSX_m_Timer.Enabled = false;
            }
        }

        #endregion
    }
    #endregion
    
    #endregion
    

    #endregion
}
