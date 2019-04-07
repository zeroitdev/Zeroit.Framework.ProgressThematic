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
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    public partial class ThematicProgress
    {

        #region Private Fields
        // Constants =========================================================
        private static double NumberOfDegreesInCircle = 360;
        private double NumberOfDegreesInHalfCircle = NumberOfDegreesInCircle / 2;
        private int DefaultInnerCircleRadius = 8;
        private int DefaultOuterCircleRadius = 10;
        private int DefaultNumberOfSpoke = 10;
        private int DefaultSpokeThickness = 4;
        private Color DefaultColor = Color.DarkGray;

        private int MacOSXInnerCircleRadius = 5;
        private int MacOSXOuterCircleRadius = 11;
        private int MacOSXNumberOfSpoke = 12;
        private int MacOSXSpokeThickness = 2;

        private int FireFoxInnerCircleRadius = 6;
        private int FireFoxOuterCircleRadius = 7;
        private int FireFoxNumberOfSpoke = 9;
        private int FireFoxSpokeThickness = 4;

        private int IE7InnerCircleRadius = 8;
        private int IE7OuterCircleRadius = 9;
        private int IE7NumberOfSpoke = 24;
        private int IE7SpokeThickness = 4;

        private int ZeroitInnerCircleRadius = 98;
        private int ZeroitOuterCircleRadius = 100;
        private int ZeroitNumberOfSpoke = 255;
        private int ZeroitSpokeThickness = 10;

        // Enumeration =======================================================
        public enum StylePresets
        {
            MacOSX,
            Firefox,
            IE7,
            Zeroit,
            Custom
        }

        // Attributes ========================================================
        private System.Windows.Forms.Timer m_Timer = new System.Windows.Forms.Timer();
        //private bool Spinner_Active;
        //private int NumberSpoke;
        //private int SpokeThickness;
        //private int m_ProgressValue;
        //private int OuterCircleRadius;
        //private int InnerCircleRadius;
        private PointF m_CenterPoint;
        //private Color SpokeColor;
        private Color[] m_Colors;
        private double[] m_Angles;
        //private StylePresets StylePreset;
        //private int Timer_Interval = 1000; 
        #endregion

        #region Public Properties
        // Properties ========================================================
        /// <summary>
        /// Gets or sets the lightest color of the circle.
        /// </summary>
        /// <value>The lightest color of the circle.</value>
        [TypeConverter("System.Drawing.ColorConverter"),
         Category("Indicator Progress - Spinner"),
         Description("Sets the color of spoke.")]
        public Color SpokeColor
        {
            get
            {
                return progressInput.SpokeColor;
            }
            set
            {
                progressInput.SpokeColor = value;

                GenerateColorsPallet();
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the outer circle radius.
        /// </summary>
        /// <value>The outer circle radius.</value>
        [System.ComponentModel.Description("Gets or sets the radius of outer circle."),
         System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int OuterCircleRadius
        {
            get
            {
                if (progressInput.OuterCircleRadius == 0)
                    progressInput.OuterCircleRadius = DefaultOuterCircleRadius;

                return progressInput.OuterCircleRadius;
            }
            set
            {
                progressInput.OuterCircleRadius = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the inner circle radius.
        /// </summary>
        /// <value>The inner circle radius.</value>
        [System.ComponentModel.Description("Gets or sets the radius of inner circle."),
         System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int InnerCircleRadius
        {
            get
            {
                if (progressInput.InnerCircleRadius == 0)
                    progressInput.InnerCircleRadius = DefaultInnerCircleRadius;

                return progressInput.InnerCircleRadius;
            }
            set
            {
                progressInput.InnerCircleRadius = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the number of spoke.
        /// </summary>
        /// <value>The number of spoke.</value>
        [System.ComponentModel.Description("Gets or sets the number of spoke."),
        System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int NumberSpoke
        {
            get
            {
                if (progressInput.NumberSpoke == 0)
                    progressInput.NumberSpoke = DefaultNumberOfSpoke;

                return progressInput.NumberSpoke;
            }
            set
            {
                if (progressInput.NumberSpoke != value && progressInput.NumberSpoke > 0)
                {
                    if (value > 255)
                    {
                        value = 255;
                    }
                    progressInput.NumberSpoke = value;
                    GenerateColorsPallet();
                    GetSpokesAngles();

                    Invalidate();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:LoadingCircle"/> is active.
        /// </summary>
        /// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
        [System.ComponentModel.Description("Gets or sets the number of spoke."),
        System.ComponentModel.Category("Indicator Progress - Spinner")]
        [Browsable(false)]
        public bool Spinner_Active
        {
            get
            {
                return progressInput.Spinner_Active;
            }
            set
            {
                progressInput.Spinner_Active = value;
                ActiveTimer();
            }
        }

        /// <summary>
        /// Gets or sets the spoke thickness.
        /// </summary>
        /// <value>The spoke thickness.</value>
        [System.ComponentModel.Description("Gets or sets the thickness of a spoke."),
        System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int SpokeThickness
        {
            get
            {
                if (progressInput.SpokeThickness <= 0)
                    progressInput.SpokeThickness = DefaultSpokeThickness;

                return progressInput.SpokeThickness;
            }
            set
            {
                progressInput.SpokeThickness = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the rotation speed.
        /// </summary>
        /// <value>The rotation speed.</value>
        [System.ComponentModel.Description("Gets or sets the rotation speed. Higher the slower."),
        System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int RotationSpeed
        {
            get
            {
                return progressInput.RotationSpeed;
                //return m_Timer.Interval;
            }
            set
            {
                m_Timer.Interval = progressInput.RotationSpeed;

                if (value > 0)
                {
                    progressInput.RotationSpeed = value;
                }
                    
            }
        }

        /// <summary>
        /// Gets or sets the Timer Interval.
        /// </summary>
        /// <value>The rotation speed.</value>
        [System.ComponentModel.Description("Gets or sets the Time Interval. Higher the slower."),
        System.ComponentModel.Category("Indicator Progress - Spinner")]
        public int Timer_Interval
        {
            get
            {
                return progressInput.Timer_Interval;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Value should be more than 0");

                else
                {
                    progressInput.Timer_Interval = value;
                    m_Timer.Interval = value;
                }
                    
            }
        }

        /// <summary>
        /// Quickly sets the style to one of these presets, or a custom style if desired
        /// </summary>
        /// <value>The style preset.</value>
        [Category("Indicator Progress - Spinner"),
         Description("Quickly sets the style to one of these presets, or a custom style if desired")
         /*DefaultValue(typeof(StylePresets), ""*/]
        public StylePresets StylePreset
        {
            get { return progressInput.StylePreset; }
            set
            {
                progressInput.StylePreset = value;

                switch (progressInput.StylePreset)
                {
                    case StylePresets.MacOSX:
                        SetCircleAppearance(MacOSXNumberOfSpoke,
                            MacOSXSpokeThickness, MacOSXInnerCircleRadius,
                            MacOSXOuterCircleRadius);
                        break;
                    case StylePresets.Firefox:
                        SetCircleAppearance(FireFoxNumberOfSpoke,
                            FireFoxSpokeThickness, FireFoxInnerCircleRadius,
                            FireFoxOuterCircleRadius);
                        break;
                    case StylePresets.IE7:
                        SetCircleAppearance(IE7NumberOfSpoke,
                            IE7SpokeThickness, IE7InnerCircleRadius,
                            IE7OuterCircleRadius);
                        break;
                    case StylePresets.Zeroit:
                        SetCircleAppearance(ZeroitNumberOfSpoke,
                            ZeroitSpokeThickness, ZeroitInnerCircleRadius,
                            ZeroitOuterCircleRadius);
                        RotationSpeed = 10;

                        break;
                    case StylePresets.Custom:
                        SetCircleAppearance(DefaultNumberOfSpoke,
                            DefaultSpokeThickness,
                            DefaultInnerCircleRadius,
                            DefaultOuterCircleRadius);
                        break;
                }
            }
        }

        #endregion

        #region Constructor
        // Construtor ========================================================
        /// <summary>
        /// Initializes a new instance of the <see cref="T:LoadingCircle"/> class.
        /// </summary>
        public void ZeroitProgressIndicatorSpinner()
        {
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //SetStyle(ControlStyles.ResizeRedraw, true);
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            //SpokeColor = DefaultColor;

            GenerateColorsPallet();
            GetSpokesAngles();
            GetControlCenterPoint();

            //m_Timer = new System.Windows.Forms.Timer();
            //m_Timer.Interval = Timer_Interval;
            m_Timer.Tick += new EventHandler(aTimer_Tick);
            ActiveTimer();

            //this.Resize += new EventHandler(LoadingCircle_Resize);
        } 
        #endregion

        // Events ============================================================
        /// <summary>
        /// Handles the Resize event of the LoadingCircle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        void LoadingCircle_Resize(EventArgs e)
        {
            GetControlCenterPoint();
        }

        /// <summary>
        /// Handles the Tick event of the aTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        void aTimer_Tick(object sender, EventArgs e)
        {
            Value = ++Value % NumberSpoke;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"></see> that contains the event data.</param>
        private void Spinner_OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            if (NumberSpoke > 0)
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                int intPosition = (int)Value;
                for (int intCounter = 0; intCounter < NumberSpoke; intCounter++)
                {
                    intPosition = intPosition % NumberSpoke;
                    DrawLine(e.Graphics,
                             GetCoordinate(m_CenterPoint, InnerCircleRadius, m_Angles[intPosition]),
                             GetCoordinate(m_CenterPoint, OuterCircleRadius, m_Angles[intPosition]),
                             m_Colors[intCounter], SpokeThickness);
                    intPosition++;
                }
            }

            
        }

        // Overridden Methods ================================================
        /// <summary>
        /// Retrieves the size of a rectangular area into which a control can be fitted.
        /// </summary>
        /// <param name="proposedSize">The custom-sized area for a control.</param>
        /// <returns>
        /// An ordered pair of type <see cref="T:System.Drawing.Size"></see> representing the width and height of a rectangle.
        /// </returns>
        public override Size GetPreferredSize(Size proposedSize)
        {
            proposedSize.Width =
                (OuterCircleRadius + SpokeThickness) * 2;

            return proposedSize;
        }

        // Methods ===========================================================
        /// <summary>
        /// Darkens a specified color.
        /// </summary>
        /// <param name="_objColor">Color to darken.</param>
        /// <param name="_intPercent">The percent of darken.</param>
        /// <returns>The new color generated.</returns>
        private Color Darken(Color _objColor, int _intPercent)
        {
            int intRed = _objColor.R;
            int intGreen = _objColor.G;
            int intBlue = _objColor.B;
            return Color.FromArgb(_intPercent, Math.Min(intRed, byte.MaxValue), Math.Min(intGreen, byte.MaxValue), Math.Min(intBlue, byte.MaxValue));
        }

        /// <summary>
        /// Generates the colors pallet.
        /// </summary>
        private void GenerateColorsPallet()
        {
            m_Colors = GenerateColorsPallet(SpokeColor, Spinner_Active, NumberSpoke);
        }

        /// <summary>
        /// Generates the colors pallet.
        /// </summary>
        /// <param name="_objColor">Color of the lightest spoke.</param>
        /// <param name="_blnShadeColor">if set to <c>true</c> the color will be shaded on X spoke.</param>
        /// <returns>An array of color used to draw the circle.</returns>
        private Color[] GenerateColorsPallet(Color _objColor, bool _blnShadeColor, int _intNbSpoke)
        {
            Color[] objColors = new Color[NumberSpoke];

            // Value is used to simulate a gradient feel... For each spoke, the 
            // color will be darken by value in intIncrement.
            byte bytIncrement = (byte)(byte.MaxValue / NumberSpoke);

            //Reset variable in case of multiple passes
            byte PERCENTAGE_OF_DARKEN = 0;

            for (int intCursor = 0; intCursor < NumberSpoke; intCursor++)
            {
                if (_blnShadeColor)
                {
                    if (intCursor == 0 || intCursor < NumberSpoke - _intNbSpoke)
                        objColors[intCursor] = _objColor;
                    else
                    {
                        // Increment alpha channel color
                        PERCENTAGE_OF_DARKEN += bytIncrement;

                        // Ensure that we don't exceed the maximum alpha
                        // channel value (255)
                        if (PERCENTAGE_OF_DARKEN > byte.MaxValue)
                            PERCENTAGE_OF_DARKEN = byte.MaxValue;

                        // Determine the spoke forecolor
                        objColors[intCursor] = Darken(_objColor, PERCENTAGE_OF_DARKEN);
                    }
                }
                else
                    objColors[intCursor] = _objColor;
            }

            return objColors;
        }

        /// <summary>
        /// Gets the control center point.
        /// </summary>
        private void GetControlCenterPoint()
        {
            m_CenterPoint = GetControlCenterPoint(this);
        }

        /// <summary>
        /// Gets the control center point.
        /// </summary>
        /// <returns>PointF object</returns>
        private PointF GetControlCenterPoint(Control _objControl)
        {
            return new PointF(_objControl.Width / 2, _objControl.Height / 2 - 1);
        }

        /// <summary>
        /// Draws the line with GDI+.
        /// </summary>
        /// <param name="_objGraphics">The Graphics object.</param>
        /// <param name="_objPointOne">The point one.</param>
        /// <param name="_objPointTwo">The point two.</param>
        /// <param name="_objColor">Color of the spoke.</param>
        /// <param name="_intLineThickness">The thickness of spoke.</param>
        private void DrawLine(Graphics _objGraphics, PointF _objPointOne, PointF _objPointTwo,
                              Color _objColor, int _intLineThickness)
        {
            using (Pen objPen = new Pen(new SolidBrush(_objColor), _intLineThickness))
            {
                objPen.StartCap = LineCap.Round;
                objPen.EndCap = LineCap.Round;
                _objGraphics.DrawLine(objPen, _objPointOne, _objPointTwo);
            }
        }

        /// <summary>
        /// Gets the coordinate.
        /// </summary>
        /// <param name="_objCircleCenter">The Circle center.</param>
        /// <param name="_intRadius">The radius.</param>
        /// <param name="_dblAngle">The angle.</param>
        /// <returns></returns>
        private PointF GetCoordinate(PointF _objCircleCenter, int _intRadius, double _dblAngle)
        {
            double dblAngle = Math.PI * _dblAngle / NumberOfDegreesInHalfCircle;

            return new PointF(_objCircleCenter.X + _intRadius * (float)Math.Cos(dblAngle),
                              _objCircleCenter.Y + _intRadius * (float)Math.Sin(dblAngle));
        }

        /// <summary>
        /// Gets the spokes angles.
        /// </summary>
        private void GetSpokesAngles()
        {
            m_Angles = GetSpokesAngles(NumberSpoke);
        }

        /// <summary>
        /// Gets the spoke angles.
        /// </summary>
        /// <param name="_shtNumberSpoke">The number spoke.</param>
        /// <returns>An array of angle.</returns>
        private double[] GetSpokesAngles(int _intNumberSpoke)
        {
            double[] Angles = new double[_intNumberSpoke];
            double dblAngle = (double)NumberOfDegreesInCircle / _intNumberSpoke;

            for (int shtCounter = 0; shtCounter < _intNumberSpoke; shtCounter++)
                Angles[shtCounter] = (shtCounter == 0 ? dblAngle : Angles[shtCounter - 1] + dblAngle);

            return Angles;
        }

        /// <summary>
        /// Actives the timer.
        /// </summary>
        private void ActiveTimer()
        {
            if (Spinner_Active)
                m_Timer.Start();
            else
            {
                m_Timer.Stop();
                Value = 0;
            }

            GenerateColorsPallet();
            Invalidate();
        }

        /// <summary>
        /// Sets the circle appearance.
        /// </summary>
        /// <param name="numberSpoke">The number spoke.</param>
        /// <param name="spokeThickness">The spoke thickness.</param>
        /// <param name="innerCircleRadius">The inner circle radius.</param>
        /// <param name="outerCircleRadius">The outer circle radius.</param>
        public void SetCircleAppearance(int numberSpoke, int spokeThickness,
            int innerCircleRadius, int outerCircleRadius)
        {
            NumberSpoke = numberSpoke;
            SpokeThickness = spokeThickness;
            InnerCircleRadius = innerCircleRadius;
            OuterCircleRadius = outerCircleRadius;

            Invalidate();
        }
    }

}
