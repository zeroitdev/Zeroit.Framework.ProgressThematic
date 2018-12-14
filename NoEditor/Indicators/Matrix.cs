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
    #region MacOSX Matrix

    #region Control
    public partial class ThematicProgress
    {

        #region Include in Private Field


        
        #endregion
        
        #region Event

        private void MacOSX_Matrix_Timer_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_Matrix_StartAngle + 1 > 360)
                this.MacOSX_Matrix_StartAngle = 0;
            else
                this.MacOSX_Matrix_StartAngle++;
            Invalidate();
        }

        #endregion

        #region Constants

        private const int MacOSX_Matrix_DEFAULT_INTERVAL = 60;
        private readonly Color MacOSX_Matrix_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        private const int MacOSX_Matrix_DEFAULT_TICK_WIDTH = 2;
        private const int MacOSX_Matrix_MINIMUM_INNER_RADIUS = 4;
        private const int MacOSX_Matrix_MINIMUM_OUTER_RADIUS = 8;
        private Size MacOSX_Matrix_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        private const int MacOSX_Matrix_MINIMUM_PEN_WIDTH = 2;
        private const float MacOSX_Matrix_INNER_RADIUS_FACTOR = 0.175F;
        private const float MacOSX_Matrix_OUTER_RADIUS_FACTOR = 0.3125F;

        #endregion

        #region Enums

        

        #endregion

        #region Structs

        struct MacOSX_Matrix_Spoke
        {
            public PointF StartPoint;
            public PointF EndPoint;

            public MacOSX_Matrix_Spoke(PointF pt1, PointF pt2)
            {
                StartPoint = pt1;
                EndPoint = pt2;
            }
        }

        #endregion

        #region Members

        //private int MacOSX_Matrix_Interval;
        Pen MacOSX_Matrix_m_Pen = null;
        PointF MacOSX_Matrix_m_CentrePt = new PointF();
        int MacOSX_Matrix_m_InnerRadius = 0;
        int MacOSX_Matrix_m_OuterRadius = 0;
        //int MacOSX_Matrix_SpokesCount = 0;
        int MacOSX_Matrix_m_AlphaChange = 0;
        int MacOSX_Matrix_m_AlphaLowerLimit = 0;
        //float MacOSX_Matrix_StartAngle = 0;
        float MacOSX_Matrix_m_AngleIncrement = 0;
        //MacOSX_Direction MacOSX_Matrix_Rotation;
        System.Timers.Timer MacOSX_Matrix_m_Timer = null;
        List<MacOSX_Matrix_Spoke> MacOSX_Matrix_m_Spokes = null;
        
        private int MacOSX_Matrix_m_Interval = 60;
        float MacOSX_Matrix_m_StartAngle = 270;
        MacOSX_Direction MacOSX_Matrix_m_Rotation = MacOSX_Direction.CLOCKWISE;
        Color matrix_tick_Color = Color.FromArgb(58, 58, 58);

        int MacOSX_Matrix_m_SpokesCount = 12;
        private LineCap MacOSX_Matrix_startCap = LineCap.Round;
        private LineCap MacOSX_Matrix_endCap = LineCap.Round;


        #endregion

        #region Properties

        [Category("Indicator Progress - MacOSX_Matrix")]
        public LineCap MacOSX_Matrix_StartCap
        {
            get { return MacOSX_Matrix_startCap; }
            set
            {
                MacOSX_Matrix_startCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - MacOSX_Matrix")]
        public LineCap MacOSX_Matrix_EndCap
        {
            get { return MacOSX_Matrix_endCap; }
            set
            {
                MacOSX_Matrix_endCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - MacOSX_Matrix")]
        public int MacOSX_Matrix_SpokesCount
        {
            get { return MacOSX_Matrix_m_SpokesCount; }
            set
            {
                MacOSX_Matrix_m_SpokesCount = value;
                Invalidate();
            }
        }

        
        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        [Category("Indicator Progress - MacOSX_Matrix")]
        public int MacOSX_Matrix_Interval
        {
            get
            {
                return MacOSX_Matrix_m_Interval;
            }
            set
            {
                if (value > 0)
                {
                    MacOSX_Matrix_m_Interval = value;
                }
                else
                {
                    MacOSX_Matrix_m_Interval = MacOSX_Matrix_DEFAULT_INTERVAL;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        [Category("Indicator Progress - MacOSX_Matrix")]
        public Color MacOSX_Matrix_TickColor
        {
            get { return matrix_tick_Color; }
            set
            {
                matrix_tick_Color = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        [Category("Indicator Progress - MacOSX_Matrix")]
        public MacOSX_Direction MacOSX_Matrix_Rotation
        {
            get
            {
                return MacOSX_Matrix_m_Rotation;
            }
            set
            {
                MacOSX_Matrix_m_Rotation = value;
                MacOSX_Matrix_CalculateSpokesPoints();

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        [Category("Indicator Progress - MacOSX_Matrix")]
        public float MacOSX_Matrix_StartAngle
        {
            get
            {
                return MacOSX_Matrix_m_StartAngle;
            }
            set
            {
                MacOSX_Matrix_m_StartAngle = value;
                Invalidate();
            }
        }

        #endregion

        #region Construction/Initialization

        /// <summary>
        /// Ctor
        /// </summary>
        public void ZeroitMacOSXMatrix()
        {
            //this.DoubleBuffered = true;

            
            // Set Default Values
            //this.BackColor = Color.Transparent;
            this.MacOSX_Matrix_TickColor = MacOSX_Matrix_DEFAULT_TICK_COLOR;
            this.MinimumSize = MacOSX_Matrix_MINIMUM_CONTROL_SIZE;
            this.MacOSX_Matrix_Interval = MacOSX_Matrix_DEFAULT_INTERVAL;
            // Default starting angle is 12 o'clock
            this.MacOSX_Matrix_StartAngle = 270;
            // Default number of Spokes in this control is 12
            MacOSX_Matrix_SpokesCount = (int)Maximum;
            // Set the Lower limit of the Alpha value (The spokes will be shown in 
            // alpha values ranging from 255 to MacOSX_Matrix_m_AlphaLowerLimit)
            MacOSX_Matrix_m_AlphaLowerLimit = 15;

            // Create the Pen
            MacOSX_Matrix_m_Pen = new Pen(MacOSX_Matrix_TickColor, MacOSX_Matrix_DEFAULT_TICK_WIDTH);
            MacOSX_Matrix_m_Pen.EndCap = MacOSX_Matrix_EndCap;
            MacOSX_Matrix_m_Pen.StartCap = MacOSX_Matrix_StartCap;

            // Default rotation direction is clockwise
            this.MacOSX_Matrix_Rotation = MacOSX_Direction.CLOCKWISE;

            // Calculate the MacOSX_Matrix_Spoke Points
            MacOSX_Matrix_CalculateSpokesPoints();

            MacOSX_Matrix_m_Timer = new System.Timers.Timer(this.MacOSX_Matrix_Interval);
            MacOSX_Matrix_m_Timer.Elapsed += new System.Timers.ElapsedEventHandler(MacOSX_Matrix_OnTimerElapsed);
        }

        /// <summary>
        /// Calculate the MacOSX_Matrix_Spoke Points and store them
        /// </summary>
        private void MacOSX_Matrix_CalculateSpokesPoints()
        {
            MacOSX_Matrix_m_Spokes = new List<MacOSX_Matrix_Spoke>();

            // Calculate the angle between adjacent spokes
            MacOSX_Matrix_m_AngleIncrement = (360 / (float)MacOSX_Matrix_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_Matrix_m_AlphaChange = (int)((255 - MacOSX_Matrix_m_AlphaLowerLimit) / MacOSX_Matrix_SpokesCount);

            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_Matrix_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_Matrix_m_Pen.Width = (int)(width / 15);
            if (MacOSX_Matrix_m_Pen.Width < MacOSX_Matrix_MINIMUM_PEN_WIDTH)
                MacOSX_Matrix_m_Pen.Width = MacOSX_Matrix_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_Matrix_m_InnerRadius = (int)(width * MacOSX_Matrix_INNER_RADIUS_FACTOR);
            if (MacOSX_Matrix_m_InnerRadius < MacOSX_Matrix_MINIMUM_INNER_RADIUS)
                MacOSX_Matrix_m_InnerRadius = MacOSX_Matrix_MINIMUM_INNER_RADIUS;
            MacOSX_Matrix_m_OuterRadius = (int)(width * MacOSX_Matrix_OUTER_RADIUS_FACTOR);
            if (MacOSX_Matrix_m_OuterRadius < MacOSX_Matrix_MINIMUM_OUTER_RADIUS)
                MacOSX_Matrix_m_OuterRadius = MacOSX_Matrix_MINIMUM_OUTER_RADIUS;

            float angle = 0;

            for (int i = 0; i < MacOSX_Matrix_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_Matrix_m_InnerRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_InnerRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Matrix_m_OuterRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_OuterRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));

                // Create a spoke based on the points generated
                MacOSX_Matrix_Spoke spoke = new MacOSX_Matrix_Spoke(pt1, pt2);
                // Add the spoke to the List
                MacOSX_Matrix_m_Spokes.Add(spoke);

                if (MacOSX_Matrix_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_Matrix_m_AngleIncrement;
                }
                else if (MacOSX_Matrix_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_Matrix_m_AngleIncrement;
                }
            }
        }

        private void MacOSX_Matrix_CalculateSpokesPoints(float value)
        {
            MacOSX_Matrix_m_Spokes = new List<MacOSX_Matrix_Spoke>();

            MacOSX_Matrix_SpokesCount = (int)value;

            // Calculate the angle between adjacent spokes
            MacOSX_Matrix_m_AngleIncrement = (360 / (float)MacOSX_Matrix_SpokesCount);
            // Calculate the change in alpha between adjacent spokes
            MacOSX_Matrix_m_AlphaChange = (int)((255 - MacOSX_Matrix_m_AlphaLowerLimit) / MacOSX_Matrix_SpokesCount);

            // Calculate the location around which the spokes will be drawn
            int width = (this.Width < this.Height) ? this.Width : this.Height;
            MacOSX_Matrix_m_CentrePt = new PointF(this.Width / 2, this.Height / 2);
            // Calculate the width of the pen which will be used to draw the spokes
            MacOSX_Matrix_m_Pen.Width = (int)(width / 15);
            if (MacOSX_Matrix_m_Pen.Width < MacOSX_Matrix_MINIMUM_PEN_WIDTH)
                MacOSX_Matrix_m_Pen.Width = MacOSX_Matrix_MINIMUM_PEN_WIDTH;
            // Calculate the inner and outer radii of the control. The radii should not be less than the
            // Minimum values
            MacOSX_Matrix_m_InnerRadius = (int)(width * MacOSX_Matrix_INNER_RADIUS_FACTOR);
            if (MacOSX_Matrix_m_InnerRadius < MacOSX_Matrix_MINIMUM_INNER_RADIUS)
                MacOSX_Matrix_m_InnerRadius = MacOSX_Matrix_MINIMUM_INNER_RADIUS;
            MacOSX_Matrix_m_OuterRadius = (int)(width * MacOSX_Matrix_OUTER_RADIUS_FACTOR);
            if (MacOSX_Matrix_m_OuterRadius < MacOSX_Matrix_MINIMUM_OUTER_RADIUS)
                MacOSX_Matrix_m_OuterRadius = MacOSX_Matrix_MINIMUM_OUTER_RADIUS;

            float angle = 0;

            for (int i = 0; i < MacOSX_Matrix_SpokesCount; i++)
            {
                PointF pt1 = new PointF(MacOSX_Matrix_m_InnerRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_InnerRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Matrix_m_OuterRadius * (float)Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_OuterRadius * (float)Math.Sin(ConvertDegreesToRadians(angle)));

                // Create a spoke based on the points generated
                MacOSX_Matrix_Spoke spoke = new MacOSX_Matrix_Spoke(pt1, pt2);
                // Add the spoke to the List
                MacOSX_Matrix_m_Spokes.Add(spoke);

                if (MacOSX_Matrix_Rotation == MacOSX_Direction.CLOCKWISE)
                {
                    angle -= MacOSX_Matrix_m_AngleIncrement;
                }
                else if (MacOSX_Matrix_Rotation == MacOSX_Direction.ANTICLOCKWISE)
                {
                    angle += MacOSX_Matrix_m_AngleIncrement;
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
        void MacOSX_Matrix_OnTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (MacOSX_Matrix_Rotation == MacOSX_Direction.CLOCKWISE)
            {
                MacOSX_Matrix_StartAngle += MacOSX_Matrix_m_AngleIncrement;

                if (MacOSX_Matrix_StartAngle >= 360)
                    MacOSX_Matrix_StartAngle = 0;
            }
            else if (MacOSX_Matrix_Rotation == MacOSX_Direction.ANTICLOCKWISE)
            {
                MacOSX_Matrix_StartAngle -= MacOSX_Matrix_m_AngleIncrement;

                if (MacOSX_Matrix_StartAngle <= -360)
                    MacOSX_Matrix_StartAngle = 0;
            }

            Invalidate();
        }


        /// <summary>
        /// Handles the MacOSX_Matrix_Paint Event of the control
        /// </summary>
        /// <param name="e">PaintEventArgs</param>
        private void MacOSX_Matrix_Paint(PaintEventArgs e)
        {

            switch (MacOSX_Automatic)
            {
                case MacOSX_automatic.Start:
                    this.MacOSX_Matrix_Start();
                    break;
                case MacOSX_automatic.FastRotate:
                    #region MyRegion
                    if (DesignMode)
                    {
                        timer.Tick += MacOSX_Matrix_Timer_Tick;
                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Matrix_Interval;
                            timer.Start();
                        }
                    }

                    if (!DesignMode)
                    {
                        timer.Tick += MacOSX_Matrix_Timer_Tick;

                        if (AutoAnimate)
                        {
                            timer.Interval = MacOSX_Matrix_Interval;
                            timer.Start();
                        }
                    }

                    #endregion
                    break;
                case MacOSX_automatic.SlowRotate:
                    this.MacOSX_Matrix_Stop();

                    break;

                case MacOSX_automatic.Stop:
                    this.MacOSX_Matrix_Stop();
                    timer.Stop();
                    break;
                default:
                    break;
            }
            
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            MacOSX_Matrix_m_Pen.EndCap = MacOSX_Matrix_EndCap;
            MacOSX_Matrix_m_Pen.StartCap = MacOSX_Matrix_StartCap;

            // Perform a Translation so that the centre of the control is the centre of MacOSX_Matrix_Rotation
            e.Graphics.TranslateTransform(MacOSX_Matrix_m_CentrePt.X, MacOSX_Matrix_m_CentrePt.Y, System.Drawing.Drawing2D.MatrixOrder.Prepend);
            // Perform a MacOSX_Matrix_Rotation about the control's centre
            e.Graphics.RotateTransform(MacOSX_Matrix_StartAngle, System.Drawing.Drawing2D.MatrixOrder.Prepend);

            int alpha = 255;

            // Render the spokes
            for (int i = 0; i < MacOSX_Matrix_SpokesCount; i++)
            {
                MacOSX_Matrix_m_Pen.Color = Color.FromArgb(alpha, this.MacOSX_Matrix_TickColor);
                e.Graphics.DrawLine(MacOSX_Matrix_m_Pen, MacOSX_Matrix_m_Spokes[i].StartPoint, MacOSX_Matrix_m_Spokes[i].EndPoint);

                alpha -= MacOSX_Matrix_m_AlphaChange;
                if (alpha < MacOSX_Matrix_m_AlphaLowerLimit)
                    alpha = 255 - MacOSX_Matrix_m_AlphaChange;
            }

            // Perform a reverse MacOSX_Matrix_Rotation and Translation to obtain the original Transformation
            e.Graphics.RotateTransform(-MacOSX_Matrix_StartAngle, System.Drawing.Drawing2D.MatrixOrder.Append);
            e.Graphics.TranslateTransform(-MacOSX_Matrix_m_CentrePt.X, -MacOSX_Matrix_m_CentrePt.Y, System.Drawing.Drawing2D.MatrixOrder.Append);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Converts Degrees to Radians
        /// </summary>
        /// <param name="degrees">Degrees</param>
        /// <returns></returns>
        private double ConvertDegreesToRadians(float degrees)
        {
            return ((Math.PI / (double)180) * degrees);
        }

        #endregion

        #region APIs

        /// <summary>
        /// MacOSX_Matrix_Start the Tick Control rotation
        /// </summary>
        public void MacOSX_Matrix_Start()
        {
            if (MacOSX_Matrix_m_Timer != null)
            {
                MacOSX_Matrix_m_Timer.Interval = this.MacOSX_Matrix_Interval;
                MacOSX_Matrix_m_Timer.Enabled = true;
            }
        }

        /// <summary>
        /// MacOSX_Matrix_Stop the Tick Control rotation
        /// </summary>
        public void MacOSX_Matrix_Stop()
        {
            if (MacOSX_Matrix_m_Timer != null)
            {
                MacOSX_Matrix_m_Timer.Enabled = false;
            }
        }

        #endregion
    }
    #endregion
    
    #endregion
}
