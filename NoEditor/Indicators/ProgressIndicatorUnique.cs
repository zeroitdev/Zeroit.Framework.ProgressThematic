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
    #region ZeroitProgressIndicatorUnique
    
    #region ProgressIndicator
    /// <summary>
    /// Firefox like circular progress indicator.
    /// </summary>
    public partial class ThematicProgress
    {
        #region Constructor

        /// <summary>
        /// Default constructor for the ProgressIndicator.
        /// </summary>
        public void ZeroitProgressBarUnique()
        {

            Unique_NumberOfCircles = (int)Maximum;

        }

        #endregion

        #region Private Fields

        private int Unique_interval = 100;
        private Color Unique_circleColor = Color.FromArgb(20, 20, 20);
        private float Unique_circleSize = 1.0F;
        private int Unique_numberOfCircles = 8;
        private int Unique_numberOfVisibleCircles = 8;
        private Unique_RotationType Unique_rotation = Unique_RotationType.Clockwise;
        private float Unique_percentage = 0;
        private bool Unique_showPercentage = false;
        private bool Unique_showText = false;
        private Unique_TextDisplayModes Unique_textDisplay = Unique_TextDisplayModes.None;

        private string Unique_customText = "Unique";

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the base color for the circles.
        /// </summary>
        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("Indicator Progress - Unique")]
        public Color Unique_CircleColor
        {
            get { return Unique_circleColor; }
            set
            {
                Unique_circleColor = value;
                Invalidate();
            }
        }

        ///// <summary>
        ///// Gets or sets a value indicating if the animation should start automatically.
        ///// </summary>
        //[DefaultValue(false)]
        //[Description("Gets or sets a value indicating if the animation should start automatically.")]
        //[Category("Behavior")]
        //public bool AutoStart
        //{
        //    get { return _autoStart; }
        //    set
        //    {
        //        _autoStart = value;


        //        if (_autoStart && !DesignMode)
        //        {
        //            Unique_Start();
        //            this.Invalidate();
        //        }

        //        else if (_autoStart && DesignMode)
        //        {
        //            Unique_Start();
        //            this.Invalidate();
        //        }
        //        else
        //            Stop();
        //    }
        //}
        

        /// <summary>
        /// Gets or sets the scale for the circles raging from 0.1 to 1.0.
        /// </summary>
        [DefaultValue(1.0F)]
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("Indicator Progress - Unique")]
        public float Unique_CircleSize
        {
            get { return Unique_circleSize; }
            set
            {
                if (value <= 0.0F)
                    Unique_circleSize = 0.1F;
                else
                    Unique_circleSize = value > 1.0F ? 1.0F : value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("Indicator Progress - Unique")]
        public int Unique_AnimationSpeed
        {
            get { return (-Unique_interval + 400) / 4; }
            set
            {
                checked
                {
                    int interval = 400 - (value * 4);

                    if (interval < 10)
                        Unique_interval = 10;
                    else
                        Unique_interval = interval > 400 ? 400 : interval;

                    ProgressPerfect_timerAnimation.Interval = Unique_interval;
                }
            }
        }

        

        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Indicator Progress - Unique")]
        public float Unique_NumberOfCircles
        {
            get { return Maximum; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");

                Maximum = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Indicator Progress - Unique")]
        public int Unique_NumberOfVisibleCircles
        {
            get { return Unique_numberOfVisibleCircles; }
            set
            {
                if (value <= 0 || value > Unique_NumberOfCircles)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                Unique_numberOfVisibleCircles = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.
        /// </summary>
        [DefaultValue(Unique_RotationType.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("Indicator Progress - Unique")]
        public Unique_RotationType Unique_Rotation
        {
            get { return Unique_rotation; }
            set { Unique_rotation = value; }
        }

        /// <summary>
        /// Gets or sets the percentage to show on the control.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_Percentage</c> is out of range.</exception>
        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("Indicator Progress - Unique")]
        public float Unique_Percentage
        {
            get { return Unique_percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("value", "Unique_Percentage must be a positive integer between 0 and 100.");

                Unique_percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the percentage value should be shown.
        /// </summary>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("Indicator Progress - Unique")]
        public bool Unique_ShowPercentage
        {
            get { return Unique_showPercentage; }
            set
            {
                Unique_showPercentage = value;

                //if (value == true)
                //{
                //    Unique_TextDisplay = Unique_TextDisplayModes.Unique_Percentage;
                //}
                
                //Unique_TextDisplay = progressInput.Unique_ShowPercentage
                //                   ? Unique_TextDisplay | Unique_TextDisplayModes.Unique_Percentage
                //                   : Unique_TextDisplay & ~Unique_TextDisplayModes.Unique_Percentage;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the control text should be shown.
        /// </summary>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("Indicator Progress - Unique")]
        public bool Unique_ShowText
        {
            get { return Unique_showText; }
            set
            {
                Unique_showText = value;

                //if (value == true)
                //{
                //    Unique_TextDisplay = Unique_TextDisplayModes.Text;
                //}

                //Unique_TextDisplay = progressInput.Unique_ShowText
                //                   ? Unique_TextDisplay | Unique_TextDisplayModes.Text
                //                   : Unique_TextDisplay & ~Unique_TextDisplayModes.Text;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the property that will be shown in the control.
        /// </summary>
        [DefaultValue(Unique_TextDisplayModes.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("Indicator Progress - Unique")]
        public Unique_TextDisplayModes Unique_TextDisplay
        {
            get { return Unique_textDisplay; }
            set
            {
                Unique_textDisplay = value;

                if (value == Unique_TextDisplayModes.Text)
                {
                    Unique_ShowText = true;
                    Unique_ShowPercentage = false;
                }
                else if (value == Unique_TextDisplayModes.Unique_Percentage)
                {
                    Unique_ShowPercentage = true;
                    Unique_ShowText = false;
                }
                else if (value == Unique_TextDisplayModes.Both)
                {
                    Unique_ShowText = true;
                    Unique_ShowPercentage = true;
                }
                else
                {
                    Unique_ShowText = false;
                    Unique_ShowPercentage = false;
                }

                //Unique_ShowText = (progressInput.Unique_TextDisplay & Unique_TextDisplayModes.Text) == Unique_TextDisplayModes.Text;
                //Unique_ShowPercentage = (progressInput.Unique_TextDisplay & Unique_TextDisplayModes.Unique_Percentage) == Unique_TextDisplayModes.Unique_Percentage;

                Invalidate();
            }
        }

        [Category("Indicator Progress - Unique")]
        public string Unique_CustomText
        {
            get { return Unique_customText; }
            set
            {
                Unique_customText = value;
                Invalidate();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the animation.
        /// </summary>
        //public void Unique_Start()
        //{
        //    if (DesignMode)
        //    {
        //        ProgressPerfect_timerAnimation.Enabled = true;
        //        ProgressPerfect_timerAnimation.Interval = ProgressPerfect_interval;
        //        _stopped = false;
        //        ProgressPerfect_timerAnimation.Start();
        //    }
        //    if (!DesignMode)
        //    {
        //        ProgressPerfect_timerAnimation.Enabled = true;
        //        ProgressPerfect_timerAnimation.Interval = ProgressPerfect_interval;
        //        _stopped = false;
        //        ProgressPerfect_timerAnimation.Start();
        //    }
        //}

        /// <summary>
        /// Stops the animation.
        /// </summary>
        //public void Unique_Stop()
        //{
        //    if (DesignMode)
        //    {
        //        ProgressPerfect_timerAnimation.Enabled = false;
        //        ProgressPerfect_timerAnimation.Stop();
        //        Value = 1;
        //        _stopped = true;
        //        Invalidate();
        //    }
        //    if (!DesignMode)
        //    {
        //        ProgressPerfect_timerAnimation.Enabled = false;
        //        ProgressPerfect_timerAnimation.Stop();
        //        Value = 1;
        //        _stopped = true;
        //        Invalidate();
        //    }
        //}



        #endregion

        #region Overrides

        private void Unique_OnPaint(PaintEventArgs e)
        {
            ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;
            
            float angle = 360.0F / Unique_NumberOfCircles;

            GraphicsState oldState = e.Graphics.Save();

            e.Graphics.TranslateTransform(Width / 2.0F, Height / 2.0F);
            e.Graphics.RotateTransform(angle * Value * (int)Unique_Rotation);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            for (int i = 1; i <= Unique_NumberOfCircles; i++)
            {
                int alphaValue = (255.0F * (i / (float)Unique_NumberOfVisibleCircles)) > 255.0 ? 0 : (int)(255.0F * (i / (float)Unique_NumberOfVisibleCircles));
                int alpha = _stopped ? (int)(255.0F * (1.0F / 8.0F)) : alphaValue;

                Color drawColor = Color.FromArgb(alpha, Unique_CircleColor);

                using (SolidBrush brush = new SolidBrush(drawColor))
                {
                    float sizeRate = 4.5F / Unique_CircleSize;
                    float size = Width / sizeRate;

                    float diff = (Width / 4.5F) - size;

                    float x = (Width / 9.0F) + diff;
                    float y = (Height / 9.0F) + diff;
                    e.Graphics.FillEllipse(brush, x, y, size, size);
                    e.Graphics.RotateTransform(angle * (int)Unique_Rotation);
                }
            }

            e.Graphics.Restore(oldState);

            string percent = Unique_GetDrawText();

            if (!string.IsNullOrEmpty(percent))
            {
                SizeF textSize = e.Graphics.MeasureString(percent, Font);
                float textX = (Width / 2.0F) - (textSize.Width / 2.0F);
                float textY = (Height / 2.0F) - (textSize.Height / 2.0F);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                RectangleF rectangle = new RectangleF(textX, textY, textSize.Width, textSize.Height);


                using (SolidBrush textBrush = new SolidBrush(ForeColor))
                {
                    e.Graphics.DrawString(percent, Font, textBrush, rectangle, format);
                }
            }

            
        }

        private void Unique_OnResize(EventArgs e)
        {
            if (FixedSize)
            {
                Unique_SetNewSize();
            }


        }

        private void Unique_OnSizeChanged(EventArgs e)
        {
            if (FixedSize)
            {
                Unique_SetNewSize();
            }
        }

        #endregion

        #region Private Methods

        private string Unique_GetDrawText()
        {
            string percent = string.Format(CultureInfo.CurrentCulture, "{0:0} %", /*Unique_Percentage*/ ((Value/Maximum) * 100));

            if (Unique_ShowText && Unique_ShowPercentage)
                return string.Format("{0}{1}{2}", percent, Environment.NewLine, /*Text*/Unique_CustomText);

            if (Unique_ShowText)
                return Unique_CustomText;

            if (Unique_ShowPercentage)
                return percent;

            return string.Empty;
        }

        private void Unique_SetNewSize()
        {
            int size = Math.Max(Width, Height);
            Size = new Size(size, size);
        }

        
        #endregion

        #region Timer

        private void Unique_timerAnimation_Tick(object sender, EventArgs e)
        {
            _stopped = false;

            if (DesignMode)
            {
                if (this.Value + 1 > this.Maximum)
                {
                    this.Value = 1;
                }

                else
                {
                    this.Value++;
                    Invalidate();
                }
            }

            if (!DesignMode)
            {
                if (this.Value + 1 > this.Maximum)
                {
                    this.Value = 1;
                }

                else
                {
                    this.Value++;
                    Invalidate();
                }
            }

        }




        private bool m_IsTimerActive = false;
        /// <summary>
        /// Actives the timer.
        /// </summary>
        
        //private void ActiveTimer()
        //{
        //    if (m_IsTimerActive)
        //        m_Timer.Unique_Start();
        //    else
        //    {
        //        m_Timer.Stop();
        //        m_ProgressValue = 0;
        //    }

        //    GenerateColorsPallet();
        //    Invalidate();
        //}



        #endregion


    }


    


    #endregion


    #region Unique_RotationType
    /// <summary>
    /// An enum used to indicate the rotational direction of the control.
    /// </summary>
    public enum Unique_RotationType
    {
        /// <summary>
        /// Indicates that the rotation should move clockwise.
        /// </summary>
        Clockwise = 1,
        /// <summary>
        /// Indicates that the rotation should move counter-clockwise.
        /// </summary>
        CounterClockwise = -1,
    }
    #endregion

    #region Unique_TextDisplayModes
    /// <summary>
    /// This enum is used to choose what text should be shown in the control.
    /// </summary>
    [Flags]
    public enum Unique_TextDisplayModes
    {
        /// <summary>
        /// No text will be shown by the control.
        /// </summary>
        None = 0,

        /// <summary>
        /// The control will show the value of the Unique_Percentage property.
        /// </summary>
        Unique_Percentage = 1,

        /// <summary>
        /// The control will show the value of the Text property.
        /// </summary>
        Text = 2,

        /// <summary>
        /// The control will show the values of the Text and Unique_Percentage properties.
        /// </summary>
        Both = Unique_Percentage | Text
    }
    #endregion
    
    
    

    #endregion
}
