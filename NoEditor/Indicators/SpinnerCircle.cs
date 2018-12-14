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

        private int ZeroitInnerCircleRadius = 45;
        private int ZeroitOuterCircleRadius = 50;
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
        private System.Windows.Forms.Timer m_Timer;
        private PointF m_CenterPoint;
        private Color[] m_Colors;
        private double[] m_Angles;
        
        private bool Spinner_m_IsTimerActive = false;
        private int m_NumberOfSpoke = 255;
        private int m_SpokeThickness = 4;
        private int m_OuterCircleRadius = 10;
        private int m_InnerCircleRadius = 8;
        private Color m_Color = Color.DarkGray;
        private StylePresets m_StylePreset = StylePresets.Custom;
        private int _Timer_Interval = 100;

        private LineCap Spinner_startCap = LineCap.Round;
        private LineCap Spinner_endCap = LineCap.Round;

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
                return m_Color;
            }
            set
            {
                m_Color = value;

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
                if (m_OuterCircleRadius == 0)
                    m_OuterCircleRadius = DefaultOuterCircleRadius;

                return m_OuterCircleRadius;
            }
            set
            {
                m_OuterCircleRadius = value;
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
                if (m_InnerCircleRadius == 0)
                    m_InnerCircleRadius = DefaultInnerCircleRadius;

                return m_InnerCircleRadius;
            }
            set
            {
                m_InnerCircleRadius = value;
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
                if (m_NumberOfSpoke == 0)
                    m_NumberOfSpoke = DefaultNumberOfSpoke;

                return m_NumberOfSpoke;
            }
            set
            {
                if (m_NumberOfSpoke != value && m_NumberOfSpoke > 0)
                {
                    if (value > 255)
                    {
                        value = 255;
                    }
                    m_NumberOfSpoke = value;
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
                return Spinner_m_IsTimerActive;
            }
            set
            {
                Spinner_m_IsTimerActive = value;
                ActiveTimer();

                Invalidate();
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
                if (m_SpokeThickness <= 0)
                    m_SpokeThickness = DefaultSpokeThickness;

                return m_SpokeThickness;
            }
            set
            {
                m_SpokeThickness = value;
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

                return _Timer_Interval;
            }
            set
            {
                
                if (value > 0)
                {
                    AnimationSpeed[0] = value;
                    m_Timer.Interval = value;
                }


                _Timer_Interval = value;
                Invalidate();
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
                return _Timer_Interval;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Value should be more than 0");

                else
                    _Timer_Interval = value;

                Invalidate();
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
            get { return m_StylePreset; }
            set
            {
                m_StylePreset = value;

                switch (value)
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
                        //SetCircleAppearance(DefaultNumberOfSpoke,
                        //    DefaultSpokeThickness,
                        //    DefaultInnerCircleRadius,
                        //    DefaultOuterCircleRadius);

                        SetCircleAppearance(
                            NumberSpoke,
                            SpokeThickness,
                            InnerCircleRadius,
                            OuterCircleRadius);

                        break;
                }

                Invalidate();
            }
        }

        [Category("Indicator Progress - Spinner")]
        public LineCap Spinner_StartCap
        {
            get { return Spinner_startCap; }
            set
            {
                Spinner_startCap = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Spinner")]
        public LineCap Spinner_EndCap
        {
            get { return Spinner_endCap; }
            set
            {
                Spinner_endCap = value;
                Invalidate();
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
            
            //SpokeColor = DefaultColor;

            GenerateColorsPallet();
            GetSpokesAngles();
            GetControlCenterPoint();

            m_Timer = new System.Windows.Forms.Timer();
            m_Timer.Interval = AnimationSpeed[0];
            m_Timer.Tick += new EventHandler(aTimer_Tick);
            ActiveTimer();

            switch (StylePreset)
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
                    //SetCircleAppearance(DefaultNumberOfSpoke,
                    //    DefaultSpokeThickness,
                    //    DefaultInnerCircleRadius,
                    //    DefaultOuterCircleRadius);

                    SetCircleAppearance(
                        NumberSpoke,
                        SpokeThickness,
                        InnerCircleRadius,
                        OuterCircleRadius);

                    break;
            }


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
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);
            
            m_Timer.Interval = AnimationSpeed[0];

            GenerateColorsPallet();
            GetSpokesAngles();
            GetControlCenterPoint();

            int intPosition = (int)(Value);

            for (int intCounter = 0; intCounter < NumberSpoke; intCounter++)
            {
                intPosition = intPosition % NumberSpoke;
                DrawLine(e.Graphics,
                    GetCoordinate(m_CenterPoint, InnerCircleRadius, m_Angles[intPosition]),
                    GetCoordinate(m_CenterPoint, OuterCircleRadius, m_Angles[intPosition]),
                    m_Colors[intCounter], SpokeThickness);
                intPosition++;
            }

            


            //if (NumberSpoke > 0)
            //{

            //    int intPosition = (int)Value;
            //    for (int intCounter = 0; intCounter < NumberSpoke; intCounter++)
            //    {
            //        intPosition = intPosition % NumberSpoke;
            //        DrawLine(e.Graphics,
            //                 GetCoordinate(m_CenterPoint, InnerCircleRadius, m_Angles[intPosition]),
            //                 GetCoordinate(m_CenterPoint, OuterCircleRadius, m_Angles[intPosition]),
            //                 m_Colors[intCounter], SpokeThickness);
            //        intPosition++;
            //    }
            //}


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
                objPen.StartCap = Spinner_StartCap;
                objPen.EndCap = Spinner_EndCap;
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
            switch (StylePreset)
            {
                case StylePresets.MacOSX:
                    NumberSpoke = MacOSXNumberOfSpoke;
                    SpokeThickness = MacOSXSpokeThickness;
                    InnerCircleRadius = MacOSXInnerCircleRadius;
                    OuterCircleRadius = MacOSXOuterCircleRadius;
                    break;
                case StylePresets.Firefox:
                    FireFoxNumberOfSpoke = numberSpoke;
                    FireFoxSpokeThickness = spokeThickness;
                    FireFoxInnerCircleRadius = innerCircleRadius;
                    FireFoxOuterCircleRadius = outerCircleRadius;
                    break;
                case StylePresets.IE7:
                    IE7NumberOfSpoke = numberSpoke;
                    IE7SpokeThickness = spokeThickness;
                    IE7InnerCircleRadius = innerCircleRadius;
                    IE7OuterCircleRadius = outerCircleRadius;
                    break;
                case StylePresets.Zeroit:
                    ZeroitNumberOfSpoke = numberSpoke;
                    ZeroitSpokeThickness = spokeThickness;
                    ZeroitInnerCircleRadius = innerCircleRadius;
                    ZeroitOuterCircleRadius = outerCircleRadius;
                    break;
                case StylePresets.Custom:
                    NumberSpoke = numberSpoke;
                    SpokeThickness = spokeThickness;
                    InnerCircleRadius = innerCircleRadius;
                    OuterCircleRadius = outerCircleRadius;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            //NumberSpoke = numberSpoke;
            //SpokeThickness = spokeThickness;
            //InnerCircleRadius = innerCircleRadius;
            //OuterCircleRadius = outerCircleRadius;

            Invalidate();
        }
    }

}
