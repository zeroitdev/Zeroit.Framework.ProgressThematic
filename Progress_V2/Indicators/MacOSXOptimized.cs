// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MacOSXOptimized.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region MacOSX Optimized

    #region Control
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Event

        /// <summary>
        /// Handles the Tick event of the MacOSX_Optimized_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Optimized_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.MacOSX_Optimized_StartAngle + 1 > 360)
            //    this.MacOSX_Optimized_StartAngle = 0;
            //else
            //    this.MacOSX_Optimized_StartAngle++;
            //Invalidate(); 
            #endregion

            

            if (Reverse)
            {
                if (this.MacOSX_Optimized_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
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
                    this.MacOSX_Optimized_StartAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.MacOSX_Optimized_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    MacOSX_Optimized_StartAngle = 0;
                    Invalidate();
                }

                else
                {
                    this.MacOSX_Optimized_StartAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick event of the MacOSX_Optimized_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Optimized_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_Optimized_StartAngle < this.Minimum)
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
                this.MacOSX_Optimized_StartAngle -= (Change * SpeedMultiplier);
                Invalidate();
            }
        }

        #endregion

        #region Constants

        /// <summary>
        /// The mac osx optimized default interval
        /// </summary>
        private const int MacOSX_Optimized_DEFAULT_INTERVAL = 60;
        /// <summary>
        /// The mac osx optimized default tick color
        /// </summary>
        private readonly Color MacOSX_Optimized_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        /// <summary>
        /// The mac osx optimized default tick width
        /// </summary>
        private const int MacOSX_Optimized_DEFAULT_TICK_WIDTH = 2;
        /// <summary>
        /// The mac osx optimized minimum inner radius
        /// </summary>
        private const int MacOSX_Optimized_MINIMUM_INNER_RADIUS = 4;
        /// <summary>
        /// The mac osx optimized minimum outer radius
        /// </summary>
        private const int MacOSX_Optimized_MINIMUM_OUTER_RADIUS = 8;
        /// <summary>
        /// The mac osx optimized minimum control size
        /// </summary>
        private Size MacOSX_Optimized_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        /// <summary>
        /// The mac osx optimized minimum pen width
        /// </summary>
        private const int MacOSX_Optimized_MINIMUM_PEN_WIDTH = 2;
        /// <summary>
        /// The mac osx optimized inner radius factor
        /// </summary>
        private const float MacOSX_Optimized_INNER_RADIUS_FACTOR = 0.175F;
        /// <summary>
        /// The mac osx optimized outer radius factor
        /// </summary>
        private const float MacOSX_Optimized_OUTER_RADIUS_FACTOR = 0.3125F;

        #endregion

        #region Enums



        #endregion

        #region Structs

        /// <summary>
        /// Struct MacOSX_Optimized_Spoke
        /// </summary>
        struct MacOSX_Optimized_Spoke
        {
            /// <summary>
            /// The start point
            /// </summary>
            public PointF StartPoint;
            /// <summary>
            /// The end point
            /// </summary>
            public PointF EndPoint;

            /// <summary>
            /// Initializes a new instance of the <see cref="MacOSX_Optimized_Spoke"/> struct.
            /// </summary>
            /// <param name="pt1">The PT1.</param>
            /// <param name="pt2">The PT2.</param>
            public MacOSX_Optimized_Spoke(PointF pt1, PointF pt2)
            {
                StartPoint = pt1;
                EndPoint = pt2;
            }
        }

        #endregion

        #region Members

        //private int MacOSX_Optimized_Interval;
        /// <summary>
        /// The mac osx optimized m pen
        /// </summary>
        Pen MacOSX_Optimized_m_Pen = null;
        /// <summary>
        /// The mac osx optimized m centre pt
        /// </summary>
        PointF MacOSX_Optimized_m_CentrePt = new PointF();
        /// <summary>
        /// The mac osx optimized m inner radius
        /// </summary>
        int MacOSX_Optimized_m_InnerRadius = 0;
        /// <summary>
        /// The mac osx optimized m outer radius
        /// </summary>
        int MacOSX_Optimized_m_OuterRadius = 0;
        /// <summary>
        /// The mac osx optimized m alpha start value
        /// </summary>
        int MacOSX_Optimized_m_AlphaStartValue = 0;
        //int MacOSX_Optimized_SpokesCount = 0;
        /// <summary>
        /// The mac osx optimized m alpha change
        /// </summary>
        int MacOSX_Optimized_m_AlphaChange = 0;
        /// <summary>
        /// The mac osx optimized m alpha lower limit
        /// </summary>
        int MacOSX_Optimized_m_AlphaLowerLimit = 0;
        //float MacOSX_Optimized_StartAngle = 0;
        /// <summary>
        /// The mac osx optimized m angle increment
        /// </summary>
        float MacOSX_Optimized_m_AngleIncrement = 0;
        //MacOSX_Direction MacOSX_Optimized_Rotation;
        /// <summary>
        /// The mac osx optimized m timer
        /// </summary>
        System.Timers.Timer MacOSX_Optimized_m_Timer = null;
        /// <summary>
        /// The mac osx optimized m spokes
        /// </summary>
        List<MacOSX_Optimized_Spoke> MacOSX_Optimized_m_Spokes = null;
        //private LineCap MacOSX_Optimized_StartCap = LineCap.Round;
        //private LineCap MacOSX_Optimized_EndCap = LineCap.Round;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx optimized start cap.
        /// </summary>
        /// <value>The mac osx optimized start cap.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public LineCap MacOSX_Optimized_StartCap
        {
            get { return progressInput.MacOSX_Optimized_StartCap; }
            set
            {
                progressInput.MacOSX_Optimized_StartCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized end cap.
        /// </summary>
        /// <value>The mac osx optimized end cap.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public LineCap MacOSX_Optimized_EndCap
        {
            get { return progressInput.MacOSX_Optimized_EndCap; }
            set
            {
                progressInput.MacOSX_Optimized_EndCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized spokes count.
        /// </summary>
        /// <value>The mac osx optimized spokes count.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public int MacOSX_Optimized_SpokesCount
        {
            get { return progressInput.MacOSX_Optimized_SpokesCount; }
            set
            {
                progressInput.MacOSX_Optimized_SpokesCount = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        /// <value>The mac osx optimized interval.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public int MacOSX_Optimized_Interval
        {
            get
            {
                return progressInput.MacOSX_Optimized_Interval;
            }
            set
            {
                if (value > 0)
                {
                    progressInput.MacOSX_Optimized_Interval = value;
                }
                else
                {
                    progressInput.MacOSX_Optimized_Interval = MacOSX_Optimized_DEFAULT_INTERVAL;

                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        /// <value>The color of the mac osx optimized tick.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public Color MacOSX_Optimized_TickColor
        {
            get { return progressInput.MacOSX_Optimized_TickColor; }
            set
            {
                progressInput.MacOSX_Optimized_TickColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        /// <value>The mac osx optimized rotation.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public MacOSX_Direction MacOSX_Optimized_Rotation
        {
            get
            {
                return progressInput.MacOSX_Optimized_Rotation;
            }
            set
            {
                progressInput.MacOSX_Optimized_Rotation = value;
                MacOSX_Optimized_CalculateSpokesPoints();

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        /// <value>The mac osx optimized start angle.</value>
        [Category("Indicator Progress MacOSXOptimized")]
        [Browsable(false)]
        public float MacOSX_Optimized_StartAngle
        {
            get
            {
                return progressInput.MacOSX_Optimized_StartAngle;
            }
            set
            {
                progressInput.MacOSX_Optimized_StartAngle = value;
                MacOSX_Optimized_CalculateAlpha();

                Invalidate();
            }
        }

        /// <summary>
        /// Calculate the Alpha Value of the MacOSX_Optimized_Spoke drawn at 0 degrees angle
        /// </summary>
        private void MacOSX_Optimized_CalculateAlpha()
        {
            if (this.MacOSX_Optimized_Rotation == MacOSX_Direction.CLOCKWISE)
            {
                if (MacOSX_Optimized_StartAngle >= 0)
                {

                    MacOSX_Optimized_m_AlphaStartValue = 255 - (((int)((MacOSX_Optimized_StartAngle % 360) / MacOSX_Optimized_m_AngleIncrement) + 1) * MacOSX_Optimized_m_AlphaChange);
                }
                else
                {
                    MacOSX_Optimized_m_AlphaStartValue = 255 - (((int)((360 + (MacOSX_Optimized_StartAngle % 360)) / MacOSX_Optimized_m_AngleIncrement) + 1) * MacOSX_Optimized_m_AlphaChange);
                }
            }
            else
            {
                if (MacOSX_Optimized_StartAngle >= 0)
                {
                    MacOSX_Optimized_m_AlphaStartValue = 255 - (((int)((360 - (MacOSX_Optimized_StartAngle % 360)) / MacOSX_Optimized_m_AngleIncrement) + 1) * MacOSX_Optimized_m_AlphaChange);
                }
                else
                {
                    MacOSX_Optimized_m_AlphaStartValue = 255 - (((int)(((360 - MacOSX_Optimized_StartAngle) % 360) / MacOSX_Optimized_m_AngleIncrement) + 1) * MacOSX_Optimized_m_AlphaChange);
                }
            }
        }

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Ctor
        /// </summary>
        public void ZeroitMacOSXOptimized()
        {
            //this.DoubleBuffered = true;


            // Set Default Values
            //this.BackColor = Color.Transparent;
            this.MacOSX_Optimized_TickColor = MacOSX_Optimized_DEFAULT_TICK_COLOR;
            this.MinimumSize = MacOSX_Optimized_MINIMUM_CONTROL_SIZE;
            this.MacOSX_Optimized_Interval = MacOSX_Optimized_DEFAULT_INTERVAL;
            // Default starting angle is 12 o'clock
            this.MacOSX_Optimized_StartAngle = 30;
            // Default number of Spokes in this control is 12
            
            // Default alpha value of the first spoke is 255
            MacOSX_Optimized_m_AlphaStartValue = 255;
            // Set the Lower limit of the Alpha value (The spokes will be shown in 
            // alpha values ranging from 255 to MacOSX_Optimized_m_AlphaLowerLimit)
            MacOSX_Optimized_m_AlphaLowerLimit = 15;
            // Create the Pen
            MacOSX_Optimized_m_Pen = new Pen(MacOSX_Optimized_TickColor, MacOSX_Optimized_DEFAULT_TICK_WIDTH);
            MacOSX_Optimized_m_Pen.EndCap = MacOSX_Optimized_EndCap;
            MacOSX_Optimized_m_Pen.StartCap = MacOSX_Optimized_StartCap;

            // Default rotation direction is clockwise
            this.MacOSX_Optimized_Rotation = MacOSX_Direction.CLOCKWISE;

            
            // Calculate the MacOSX_Optimized_Spoke Points
            MacOSX_Optimized_CalculateSpokesPoints(MacOSX_MaxSpokes);

            MacOSX_Optimized_m_Timer = new System.Timers.Timer(this.MacOSX_Optimized_Interval);
            MacOSX_Optimized_m_Timer.Elapsed += new System.Timers.ElapsedEventHandler(MacOSX_Optimized_OnTimerElapsed);
        }

        /// <summary>
        /// Calculate the MacOSX_Optimized_Spoke Points and store them
        /// </summary>
        private void MacOSX_Optimized_CalculateSpokesPoints()
        {

            MacOSX_Optimized_m_Spokes = new List<MacOSX_Optimized_Spoke>();

            //MacOSX_Optimized_SpokesCount = (int)Maximum;
            // Calculate the angle between adjacent spokes
            MacOSX_Optimized_m_AngleIncrement = (360 / (float)MacOSX_Optimized_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_Optimized_m_AlphaChange = (int)((255 - MacOSX_Optimized_m_AlphaLowerLimit) / MacOSX_Optimized_SpokesCount);

            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_Optimized_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_Optimized_m_Pen.Width = (int)(width / 15);
            if (MacOSX_Optimized_m_Pen.Width < MacOSX_Optimized_MINIMUM_PEN_WIDTH)
                MacOSX_Optimized_m_Pen.Width = MacOSX_Optimized_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_Optimized_m_InnerRadius = (int)(width * MacOSX_Optimized_INNER_RADIUS_FACTOR);
            if (MacOSX_Optimized_m_InnerRadius < MacOSX_Optimized_MINIMUM_INNER_RADIUS)
                MacOSX_Optimized_m_InnerRadius = MacOSX_Optimized_MINIMUM_INNER_RADIUS;
            MacOSX_Optimized_m_OuterRadius = (int)(width * MacOSX_Optimized_OUTER_RADIUS_FACTOR);
            if (MacOSX_Optimized_m_OuterRadius < MacOSX_Optimized_MINIMUM_OUTER_RADIUS)
                MacOSX_Optimized_m_OuterRadius = MacOSX_Optimized_MINIMUM_OUTER_RADIUS;

            float angle = 0;

            for (int i = 0; i < MacOSX_Optimized_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_Optimized_m_InnerRadius * (float)System.Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_InnerRadius * (float)System.Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Optimized_m_OuterRadius * (float)System.Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_OuterRadius * (float)System.Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));

                pt1.X += MacOSX_Optimized_m_CentrePt.X;
                pt1.Y += MacOSX_Optimized_m_CentrePt.Y;
                pt2.X += MacOSX_Optimized_m_CentrePt.X;
                pt2.Y += MacOSX_Optimized_m_CentrePt.Y;

                // Create a spoke based on the points generated
                MacOSX_Optimized_Spoke spoke = new MacOSX_Optimized_Spoke(pt1, pt2);
                // Add the spoke to the List
                MacOSX_Optimized_m_Spokes.Add(spoke);

                if (MacOSX_Optimized_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_Optimized_m_AngleIncrement;
                }
                else if (MacOSX_Optimized_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_Optimized_m_AngleIncrement;
                }
            }
        }

        /// <summary>
        /// Calculate the MacOSX_Optimized_Spoke Points and store them
        /// </summary>
        /// <param name="value">The value.</param>
        private void MacOSX_Optimized_CalculateSpokesPoints(float value)
        {

            MacOSX_Optimized_m_Spokes = new List<MacOSX_Optimized_Spoke>();

            MacOSX_Optimized_SpokesCount = (int)value;
            // Calculate the angle between adjacent spokes
            MacOSX_Optimized_m_AngleIncrement = (360 / (float)MacOSX_Optimized_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_Optimized_m_AlphaChange = (int)((255 - MacOSX_Optimized_m_AlphaLowerLimit) / MacOSX_Optimized_SpokesCount);

            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_Optimized_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_Optimized_m_Pen.Width = (int)(width / 15);
            if (MacOSX_Optimized_m_Pen.Width < MacOSX_Optimized_MINIMUM_PEN_WIDTH)
                MacOSX_Optimized_m_Pen.Width = MacOSX_Optimized_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_Optimized_m_InnerRadius = (int)(width * MacOSX_Optimized_INNER_RADIUS_FACTOR);
            if (MacOSX_Optimized_m_InnerRadius < MacOSX_Optimized_MINIMUM_INNER_RADIUS)
                MacOSX_Optimized_m_InnerRadius = MacOSX_Optimized_MINIMUM_INNER_RADIUS;
            MacOSX_Optimized_m_OuterRadius = (int)(width * MacOSX_Optimized_OUTER_RADIUS_FACTOR);
            if (MacOSX_Optimized_m_OuterRadius < MacOSX_Optimized_MINIMUM_OUTER_RADIUS)
                MacOSX_Optimized_m_OuterRadius = MacOSX_Optimized_MINIMUM_OUTER_RADIUS;

            float angle = 0;

            for (int i = 0; i < MacOSX_Optimized_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_Optimized_m_InnerRadius * (float)System.Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_InnerRadius * (float)System.Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Optimized_m_OuterRadius * (float)System.Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_OuterRadius * (float)System.Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));

                pt1.X += MacOSX_Optimized_m_CentrePt.X;
                pt1.Y += MacOSX_Optimized_m_CentrePt.Y;
                pt2.X += MacOSX_Optimized_m_CentrePt.X;
                pt2.Y += MacOSX_Optimized_m_CentrePt.Y;

                // Create a spoke based on the points generated
                MacOSX_Optimized_Spoke spoke = new MacOSX_Optimized_Spoke(pt1, pt2);
                // Add the spoke to the List
                MacOSX_Optimized_m_Spokes.Add(spoke);

                if (MacOSX_Optimized_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_Optimized_m_AngleIncrement;
                }
                else if (MacOSX_Optimized_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_Optimized_m_AngleIncrement;
                }
            }
        }

        #endregion

        #region EventHandlers



        /// <summary>
        /// Handle the Tick event
        /// </summary>
        /// <param name="sender">Timer</param>
        /// <param name="e">ElapsedEventArgs</param>
        void MacOSX_Optimized_OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (MacOSX_Optimized_Rotation == MacOSX_Direction.CLOCKWISE)
            {
                MacOSX_Optimized_StartAngle += MacOSX_Optimized_m_AngleIncrement;

                if (MacOSX_Optimized_StartAngle >= 360)
                    MacOSX_Optimized_StartAngle = 0;
            }
            else if (MacOSX_Optimized_Rotation == MacOSX_Direction.ANTICLOCKWISE)
            {
                MacOSX_Optimized_StartAngle -= MacOSX_Optimized_m_AngleIncrement;

                if (MacOSX_Optimized_StartAngle <= -360)
                    MacOSX_Optimized_StartAngle = 0;
            }

            // Change Alpha value accordingly
            MacOSX_Optimized_m_AlphaStartValue -= MacOSX_Optimized_m_AlphaChange;
            if (MacOSX_Optimized_m_AlphaStartValue < MacOSX_Optimized_m_AlphaLowerLimit)
                MacOSX_Optimized_m_AlphaStartValue = 255 - MacOSX_Optimized_m_AlphaChange;

            Invalidate();
        }


        /// <summary>
        /// Handles the MacOSX_Optimized_Paint Event of the control
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        void MacOSX_Optimized_Paint(PaintEventArgs e)
        {
            switch (MacOSX_Automatic)
            {
                case MacOSX_automatic.Start:
                    this.MacOSX_Optimized_Start();
                    break;
                case MacOSX_automatic.FastRotate:
                    #region MyRegion
                    if (DesignMode)
                    {
                        timer.Tick += Timer_Tick;
                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Optimized_Interval;
                            timer.Start();
                        }
                    }

                    if (!DesignMode)
                    {
                        timer.Tick += Timer_Tick;

                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Optimized_Interval;
                            timer.Start();
                        }
                    }

                    #endregion
                    break;
                case MacOSX_automatic.SlowRotate:
                    this.MacOSX_Optimized_Stop();

                    break;

                case MacOSX_automatic.Stop:
                    this.MacOSX_Optimized_Stop();
                    timer.Stop();
                    break;
                default:
                    break;
            }

            //MacOSX_Optimized_SpokesCount = (int)Maximum;

            //MacOSX_Optimized_CalculateSpokesPoints();

            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            //e.Graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            MacOSX_Optimized_m_Pen.EndCap = MacOSX_Optimized_EndCap;
            MacOSX_Optimized_m_Pen.StartCap = MacOSX_Optimized_StartCap;

            int alpha = MacOSX_Optimized_m_AlphaStartValue;

            // Render the spokes
            for (int i = 0; i < MacOSX_Optimized_SpokesCount; i++)
            {

                MacOSX_Optimized_m_Pen.Color = Color.FromArgb(alpha, this.MacOSX_Optimized_TickColor);
                e.Graphics.DrawLine(MacOSX_Optimized_m_Pen, MacOSX_Optimized_m_Spokes[i].StartPoint, MacOSX_Optimized_m_Spokes[i].EndPoint);

                alpha -= MacOSX_Optimized_m_AlphaChange;
                if (alpha < MacOSX_Optimized_m_AlphaLowerLimit)
                    alpha = 255 - MacOSX_Optimized_m_AlphaChange;
            }
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Converts Degrees to Radians
        /// </summary>
        /// <param name="degrees">Degrees</param>
        /// <returns>System.Double.</returns>
        private double MacOSX_Optimized_ConvertDegreesToRadians(float degrees)
        {
            return ((System.Math.PI / (double)180) * degrees);
        }

        #endregion

        #region APIs

        /// <summary>
        /// MacOSX_Optimized_Start the Tick Control rotation
        /// </summary>
        public void MacOSX_Optimized_Start()
        {
            if (MacOSX_Optimized_m_Timer != null)
            {
                MacOSX_Optimized_m_Timer.Interval = this.MacOSX_Optimized_Interval;
                MacOSX_Optimized_m_Timer.Enabled = true;
            }
        }

        /// <summary>
        /// MacOSX_Optimized_Stop the Tick Control rotation
        /// </summary>
        public void MacOSX_Optimized_Stop()
        {
            if (MacOSX_Optimized_m_Timer != null)
            {
                MacOSX_Optimized_m_Timer.Enabled = false;
            }
        }

        #endregion

    }

    #endregion
    
    #endregion
}
