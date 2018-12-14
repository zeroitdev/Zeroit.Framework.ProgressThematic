#region Imports

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

using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    #region MacOSX Optimized

    #region Control
    public partial class ThematicProgress
    {
        
        #region Event

        private void MacOSX_Optimized_Timer_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_Optimized_StartAngle + 1 > 360)
                this.MacOSX_Optimized_StartAngle = 0;
            else
                this.MacOSX_Optimized_StartAngle++;
            Invalidate();
        }

        #endregion

        #region Constants

        private const int MacOSX_Optimized_DEFAULT_INTERVAL = 60;
        private readonly Color MacOSX_Optimized_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        private const int MacOSX_Optimized_DEFAULT_TICK_WIDTH = 2;
        private const int MacOSX_Optimized_MINIMUM_INNER_RADIUS = 4;
        private const int MacOSX_Optimized_MINIMUM_OUTER_RADIUS = 8;
        private Size MacOSX_Optimized_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        private const int MacOSX_Optimized_MINIMUM_PEN_WIDTH = 2;
        private const float MacOSX_Optimized_INNER_RADIUS_FACTOR = 0.175F;
        private const float MacOSX_Optimized_OUTER_RADIUS_FACTOR = 0.3125F;

        #endregion

        #region Enums

        

        #endregion

        #region Structs

        struct MacOSX_Optimized_Spoke
        {
            public PointF StartPoint;
            public PointF EndPoint;

            public MacOSX_Optimized_Spoke(PointF pt1, PointF pt2)
            {
                StartPoint = pt1;
                EndPoint = pt2;
            }
        }

        #endregion

        #region Members

        //private int MacOSX_Optimized_Interval;
        Pen MacOSX_Optimized_m_Pen = null;
        PointF MacOSX_Optimized_m_CentrePt = new PointF();
        int MacOSX_Optimized_m_InnerRadius = 0;
        int MacOSX_Optimized_m_OuterRadius = 0;
        int MacOSX_Optimized_m_AlphaStartValue = 0;
        //int MacOSX_Optimized_SpokesCount = 0;
        int MacOSX_Optimized_m_AlphaChange = 0;
        int MacOSX_Optimized_m_AlphaLowerLimit = 0;
        //float MacOSX_Optimized_StartAngle = 0;
        float MacOSX_Optimized_m_AngleIncrement = 0;
        //MacOSX_Direction MacOSX_Optimized_Rotation;
        System.Timers.Timer MacOSX_Optimized_m_Timer = null;
        List<MacOSX_Optimized_Spoke> MacOSX_Optimized_m_Spokes = null;
        //private LineCap MacOSX_Optimized_StartCap = LineCap.Round;
        //private LineCap MacOSX_Optimized_EndCap = LineCap.Round;

        private int MacOSX_Optimized_m_Interval = 60;
        float MacOSX_Optimized_m_StartAngle = 30;
        MacOSX_Direction MacOSX_Optimized_m_Rotation = MacOSX_Direction.CLOCKWISE;
        Color macOSX_Optimized_tick_Color = Color.FromArgb(58, 58, 58);

        int MacOSX_Optimized_m_SpokesCount = 12;
        private LineCap MacOSX_Optimized_startCap = LineCap.Round;
        private LineCap MacOSX_Optimized_endCap = LineCap.Round;



        #endregion

        #region Properties

        [Category("Indicator Progress - MacOSX_Optimized")]
        public LineCap MacOSX_Optimized_StartCap
        {
            get { return MacOSX_Optimized_startCap; }
            set
            {
                MacOSX_Optimized_startCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - MacOSX_Optimized")]
        public LineCap MacOSX_Optimized_EndCap
        {
            get { return MacOSX_Optimized_endCap; }
            set
            {
                MacOSX_Optimized_endCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - MacOSX_Optimized")]
        public int MacOSX_Optimized_SpokesCount
        {
            get { return MacOSX_Optimized_m_SpokesCount; }
            set
            {
                MacOSX_Optimized_m_SpokesCount = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        [Category("Indicator Progress - MacOSX_Optimized")]
        public int MacOSX_Optimized_Interval
        {
            get
            {
                return MacOSX_Optimized_m_Interval;
            }
            set
            {
                if (value > 0)
                {
                    MacOSX_Optimized_m_Interval = value;
                }
                else
                {
                    MacOSX_Optimized_m_Interval = MacOSX_Optimized_DEFAULT_INTERVAL;

                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        [Category("Indicator Progress - MacOSX_Optimized")]
        public Color MacOSX_Optimized_TickColor
        {
            get { return macOSX_Optimized_tick_Color; }
            set
            {
                macOSX_Optimized_tick_Color = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        [Category("Indicator Progress - MacOSX_Optimized")]
        public MacOSX_Direction MacOSX_Optimized_Rotation
        {
            get
            {
                return MacOSX_Optimized_m_Rotation;
            }
            set
            {
                MacOSX_Optimized_m_Rotation = value;
                MacOSX_Optimized_CalculateSpokesPoints();

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        [Category("Indicator Progress - MacOSX_Optimized")]
        public float MacOSX_Optimized_StartAngle
        {
            get
            {
                return MacOSX_Optimized_m_StartAngle;
            }
            set
            {
                MacOSX_Optimized_m_StartAngle = value;
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
            MacOSX_Optimized_CalculateSpokesPoints();

            MacOSX_Optimized_m_Timer = new System.Timers.Timer(this.MacOSX_Optimized_Interval);
            MacOSX_Optimized_m_Timer.Elapsed += new System.Timers.ElapsedEventHandler(MacOSX_Optimized_OnTimerElapsed);
        }

        /// <summary>
        /// Calculate the MacOSX_Optimized_Spoke Points and store them
        /// </summary>
        private void MacOSX_Optimized_CalculateSpokesPoints()
        {

            MacOSX_Optimized_m_Spokes = new List<MacOSX_Optimized_Spoke>();

            MacOSX_Optimized_SpokesCount = (int)Maximum;
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
                PointF pt1 = new PointF(MacOSX_Optimized_m_InnerRadius * (float)Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_InnerRadius * (float)Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Optimized_m_OuterRadius * (float)Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_OuterRadius * (float)Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));

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
                PointF pt1 = new PointF(MacOSX_Optimized_m_InnerRadius * (float)Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_InnerRadius * (float)Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Optimized_m_OuterRadius * (float)Math.Cos(MacOSX_Optimized_ConvertDegreesToRadians(angle)), MacOSX_Optimized_m_OuterRadius * (float)Math.Sin(MacOSX_Optimized_ConvertDegreesToRadians(angle)));

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

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

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
        /// <returns></returns>
        private double MacOSX_Optimized_ConvertDegreesToRadians(float degrees)
        {
            return ((Math.PI / (double)180) * degrees);
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
