// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Matrix.cs" company="Zeroit Dev Technologies">
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region MacOSX Matrix

    #region Control
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Include in Private Field



        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the MacOSX_Matrix_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Matrix_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.MacOSX_Matrix_StartAngle + 1 > 360)
            //    this.MacOSX_Matrix_StartAngle = 0;
            //else
            //    this.MacOSX_Matrix_StartAngle++;
            //Invalidate(); 
            #endregion

            
            if (Reverse)
            {
                if (this.MacOSX_Matrix_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
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
                    this.MacOSX_Matrix_StartAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.MacOSX_Matrix_StartAngle + (Change * SpeedMultiplier) > this.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    MacOSX_Matrix_StartAngle = 0;
                    Invalidate();
                }

                else
                {
                    this.MacOSX_Matrix_StartAngle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick event of the MacOSX_Matrix_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MacOSX_Matrix_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.MacOSX_Matrix_StartAngle < this.Minimum)
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
                this.MacOSX_Matrix_StartAngle -= (Change * SpeedMultiplier);
                Invalidate();
            }
        }

        #endregion

        #region Constants

        /// <summary>
        /// The mac osx matrix default interval
        /// </summary>
        private const int MacOSX_Matrix_DEFAULT_INTERVAL = 60;
        /// <summary>
        /// The mac osx matrix default tick color
        /// </summary>
        private readonly Color MacOSX_Matrix_DEFAULT_TICK_COLOR = Color.FromArgb(58, 58, 58);
        /// <summary>
        /// The mac osx matrix default tick width
        /// </summary>
        private const int MacOSX_Matrix_DEFAULT_TICK_WIDTH = 2;
        /// <summary>
        /// The mac osx matrix minimum inner radius
        /// </summary>
        private const int MacOSX_Matrix_MINIMUM_INNER_RADIUS = 4;
        /// <summary>
        /// The mac osx matrix minimum outer radius
        /// </summary>
        private const int MacOSX_Matrix_MINIMUM_OUTER_RADIUS = 8;
        /// <summary>
        /// The mac osx matrix minimum control size
        /// </summary>
        private Size MacOSX_Matrix_MINIMUM_CONTROL_SIZE = new Size(28, 28);
        /// <summary>
        /// The mac osx matrix minimum pen width
        /// </summary>
        private const int MacOSX_Matrix_MINIMUM_PEN_WIDTH = 2;
        /// <summary>
        /// The mac osx matrix inner radius factor
        /// </summary>
        private const float MacOSX_Matrix_INNER_RADIUS_FACTOR = 0.175F;
        /// <summary>
        /// The mac osx matrix outer radius factor
        /// </summary>
        private const float MacOSX_Matrix_OUTER_RADIUS_FACTOR = 0.3125F;

        #endregion

        #region Enums



        #endregion

        #region Structs

        /// <summary>
        /// Struct MacOSX_Matrix_Spoke
        /// </summary>
        struct MacOSX_Matrix_Spoke
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
            /// Initializes a new instance of the <see cref="MacOSX_Matrix_Spoke"/> struct.
            /// </summary>
            /// <param name="pt1">The PT1.</param>
            /// <param name="pt2">The PT2.</param>
            public MacOSX_Matrix_Spoke(PointF pt1, PointF pt2)
            {
                StartPoint = pt1;
                EndPoint = pt2;
            }
        }

        #endregion

        #region Members

        //private int MacOSX_Matrix_Interval;
        /// <summary>
        /// The mac osx matrix m pen
        /// </summary>
        Pen MacOSX_Matrix_m_Pen = null;
        /// <summary>
        /// The mac osx matrix m centre pt
        /// </summary>
        PointF MacOSX_Matrix_m_CentrePt = new PointF();
        /// <summary>
        /// The mac osx matrix m inner radius
        /// </summary>
        int MacOSX_Matrix_m_InnerRadius = 0;
        /// <summary>
        /// The mac osx matrix m outer radius
        /// </summary>
        int MacOSX_Matrix_m_OuterRadius = 0;
        //int MacOSX_Matrix_SpokesCount = 0;
        /// <summary>
        /// The mac osx matrix m alpha change
        /// </summary>
        int MacOSX_Matrix_m_AlphaChange = 0;
        /// <summary>
        /// The mac osx matrix m alpha lower limit
        /// </summary>
        int MacOSX_Matrix_m_AlphaLowerLimit = 0;
        //float MacOSX_Matrix_StartAngle = 0;
        /// <summary>
        /// The mac osx matrix m angle increment
        /// </summary>
        float MacOSX_Matrix_m_AngleIncrement = 0;
        //MacOSX_Direction MacOSX_Matrix_Rotation;
        /// <summary>
        /// The mac osx matrix m timer
        /// </summary>
        System.Timers.Timer MacOSX_Matrix_m_Timer = null;
        /// <summary>
        /// The mac osx matrix m spokes
        /// </summary>
        List<MacOSX_Matrix_Spoke> MacOSX_Matrix_m_Spokes = null;

        //private LineCap MacOSX_Matrix_StartCap = LineCap.Round;
        //private LineCap MacOSX_Matrix_EndCap = LineCap.Round;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx matrix start cap.
        /// </summary>
        /// <value>The mac osx matrix start cap.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public LineCap MacOSX_Matrix_StartCap
        {
            get { return progressInput.MacOSX_Matrix_StartCap; }
            set
            {
                progressInput.MacOSX_Matrix_StartCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mac osx matrix end cap.
        /// </summary>
        /// <value>The mac osx matrix end cap.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public LineCap MacOSX_Matrix_EndCap
        {
            get { return progressInput.MacOSX_Matrix_EndCap; }
            set
            {
                progressInput.MacOSX_Matrix_EndCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mac osx matrix spokes count.
        /// </summary>
        /// <value>The mac osx matrix spokes count.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public int MacOSX_Matrix_SpokesCount
        {
            get { return progressInput.MacOSX_Matrix_SpokesCount; }
            set
            {
                progressInput.MacOSX_Matrix_SpokesCount = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        /// <value>The mac osx matrix interval.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public int MacOSX_Matrix_Interval
        {
            get
            {
                return progressInput.MacOSX_Matrix_Interval;
            }
            set
            {
                if (value > 0)
                {
                    progressInput.MacOSX_Matrix_Interval = value;
                }
                else
                {
                    progressInput.MacOSX_Matrix_Interval = MacOSX_Matrix_DEFAULT_INTERVAL;
                }

                Invalidate();
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        /// <value>The color of the mac osx matrix tick.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public Color MacOSX_Matrix_TickColor
        {
            get { return progressInput.MacOSX_Matrix_TickColor; }
            set
            {
                progressInput.MacOSX_Matrix_TickColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        /// <value>The mac osx matrix rotation.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public MacOSX_Direction MacOSX_Matrix_Rotation
        {
            get
            {
                return progressInput.MacOSX_Matrix_Rotation;
            }
            set
            {
                progressInput.MacOSX_Matrix_Rotation = value;
                MacOSX_Matrix_CalculateSpokesPoints(MacOSX_MaxSpokes);

                Invalidate();
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        /// <value>The mac osx matrix start angle.</value>
        [Category("Indicator Progress MacOSXMatrix")]
        [Browsable(false)]
        public float MacOSX_Matrix_StartAngle
        {
            get
            {
                return progressInput.MacOSX_Matrix_StartAngle;
            }
            set
            {
                progressInput.MacOSX_Matrix_StartAngle = value;
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
            //MacOSX_Matrix_SpokesCount = (int)Maximum;
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
            MacOSX_Matrix_CalculateSpokesPoints(MacOSX_MaxSpokes);

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
                PointF pt1 = new PointF(MacOSX_Matrix_m_InnerRadius * (float)System.Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_InnerRadius * (float)System.Math.Sin(ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Matrix_m_OuterRadius * (float)System.Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_OuterRadius * (float)System.Math.Sin(ConvertDegreesToRadians(angle)));

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

        /// <summary>
        /// Macs the osx matrix calculate spokes points.
        /// </summary>
        /// <param name="value">The value.</param>
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
                PointF pt1 = new PointF(MacOSX_Matrix_m_InnerRadius * (float)System.Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_InnerRadius * (float)System.Math.Sin(ConvertDegreesToRadians(angle)));
                PointF pt2 = new PointF(MacOSX_Matrix_m_OuterRadius * (float)System.Math.Cos(ConvertDegreesToRadians(angle)), MacOSX_Matrix_m_OuterRadius * (float)System.Math.Sin(ConvertDegreesToRadians(angle)));

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

            //e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            //e.Graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

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
        /// <returns>System.Double.</returns>
        private double ConvertDegreesToRadians(float degrees)
        {
            return ((System.Math.PI / (double)180) * degrees);
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
