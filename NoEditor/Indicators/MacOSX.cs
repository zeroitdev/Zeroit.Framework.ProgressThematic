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
    #region MacOSX


    #region MacOSX NonOptimized
    
    #region Control
    public partial class ThematicProgress
    {

        
        #region Event

        private void MacOSX_Timer_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_StartAngle + 1 > 360)
                this.MacOSX_StartAngle = 0;
            else
                this.MacOSX_StartAngle++;
            Invalidate();
        }

        private void MacOSX_OnResize(EventArgs e)
        {
            MacOSX_SpokesCount = (int)Maximum;
        }

        #endregion

        #region Constants

        private const int MacOSX_DEFAULT_INTERVAL = 60;
        private readonly Color MacOSX_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        private const int MacOSX_DEFAULT_TICK_WIDTH = 2;
        private const int MacOSX_MINIMUM_INNER_RADIUS = 4;
        private const int MacOSX_MINIMUM_OUTER_RADIUS = 8;
        private Size MacOSX_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        private const int MacOSX_MINIMUM_PEN_WIDTH = 2;

        #endregion

        #region Enums

        public enum MacOSX_Direction
        {
            CLOCKWISE,
            ANTICLOCKWISE
        }

        #endregion

        #region Members

        //private int MacOSX_Interval;
        Pen MacOSX_m_Pen = null;
        PointF MacOSX_m_CentrePt = new PointF();
        int MacOSX_m_InnerRadius = 0;
        int MacOSX_m_OuterRadius = 0;
        //int MacOSX_StartAngle = 0;
        int MacOSX_m_AlphaStartValue = 255;
        //int MacOSX_SpokesCount = 0;
        int MacOSX_m_AngleIncrement = 0;
        int MacOSX_m_AlphaDecrement = 0;
        System.Windows.Forms.Timer MacOSX_m_Timer = null;
        private int MacOSX_m_Interval = 60;
        int MacOSX_m_StartAngle = 270;
        int MacOSX_m_SpokesCount = 12;
        private MacOSX_automatic _automatic = MacOSX_automatic.Start;
        private Color tick_Color = Color.FromArgb(58, 58, 58);
        MacOSX_Direction macOSX_Rotation = MacOSX_Direction.CLOCKWISE;
        private LineCap MacOSX_startCap = LineCap.Round;
        private LineCap MacOSX_endCap = LineCap.Round;

        #endregion

        #region Properties
        [Category("Indicator Progress - MacOSX")]
        public LineCap MacOSX_StartCap
        {
            get { return MacOSX_startCap; }
            set
            {
                MacOSX_startCap = value;
                Invalidate();

            }
        }

        [Category("Indicator Progress - MacOSX")]
        public LineCap MacOSX_EndCap
        {
            get { return MacOSX_endCap; }
            set
            {
                MacOSX_endCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - MacOSX")]
        public int MacOSX_SpokesCount
        {
            get { return MacOSX_m_SpokesCount; }
            set
            {
                MacOSX_m_SpokesCount = value;
                Invalidate();

            }
        }


        [Category("Indicator Progress - MacOSX")]
        public MacOSX_automatic MacOSX_Automatic
        {
            get { return _automatic; }
            set
            {
                _automatic = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        [Category("Indicator Progress - MacOSX")]
        public int MacOSX_Interval
        {
            get
            {
                return MacOSX_m_Interval;
            }
            set
            {
                if (value > 0)
                {
                    MacOSX_m_Interval = value;
                }
                else
                {
                    MacOSX_m_Interval = MacOSX_DEFAULT_INTERVAL;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        [Category("Indicator Progress - MacOSX")]
        public Color MacOSX_TickColor
        {
            get { return tick_Color; }
            set
            {
                tick_Color = value;
                Invalidate();
            }
        }

        /// <summary>
        /// MacOSX_Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        [Category("Indicator Progress - MacOSX")]
        public MacOSX_Direction MacOSX_Rotation
        {
            get { return macOSX_Rotation; }
            set
            {
                macOSX_Rotation = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        [Category("Indicator Progress - MacOSX")]
        public int MacOSX_StartAngle
        {
            get
            {
                return MacOSX_m_StartAngle;
            }
            set
            {
                MacOSX_m_StartAngle = value;
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
            MacOSX_SpokesCount = /*12*/(int)Maximum;
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
            
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
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
                PointF pt1 = new PointF(MacOSX_m_InnerRadius * (float)Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_InnerRadius * (float)Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_m_OuterRadius * (float)Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_OuterRadius * (float)Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));

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

        private void MacOSX_CalculateSpokes()
        {
            MacOSX_m_Pen = new Pen(MacOSX_TickColor, MacOSX_DEFAULT_TICK_WIDTH);
            MacOSX_m_Pen.EndCap = MacOSX_EndCap;
            MacOSX_m_Pen.StartCap = MacOSX_StartCap;

            MacOSX_SpokesCount = (int)Maximum;
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
                PointF pt1 = new PointF(MacOSX_m_InnerRadius * (float)Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_InnerRadius * (float)Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_m_OuterRadius * (float)Math.Cos(MacOSX_ConvertDegreesToRadians(angle)), MacOSX_m_OuterRadius * (float)Math.Sin(MacOSX_ConvertDegreesToRadians(angle)));

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
        /// <returns></returns>
        private double MacOSX_ConvertDegreesToRadians(int degrees)
        {
            return ((Math.PI / (double)180) * degrees);
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
