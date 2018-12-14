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
    #region ZeroitProgressBarPerfect

    #region ProgressIndicator
    /// <summary>
    /// Firefox like circular progress indicator.
    /// </summary>
    /// 

    public partial class ThematicProgress
    {
        private System.Windows.Forms.Timer ProgressPerfect_timerAnimation = new System.Windows.Forms.Timer();

        #region Constructor

        /// <summary>
        /// Default constructor for the ProgressIndicator.
        /// </summary>
        public void ZeroitProgressBarPerfect()
        {

            if (DesignMode)
            {
                ProgressPerfect_timerAnimation.Tick += ProgressPerfect_Timer_Tick;
                if (AutoAnimate)
                {
                    //ProgressPerfect_timerAnimation.Interval = 100;
                    ProgressPerfect_timerAnimation.Start();
                }
            }

            if (!DesignMode)
            {
                ProgressPerfect_timerAnimation.Tick += ProgressPerfect_Timer_Tick;

                if (AutoAnimate)
                {
                    //ProgressPerfect_timerAnimation.Interval = 100;
                    ProgressPerfect_timerAnimation.Start();
                }
            }

            //if (DesignMode)
            //{
            //    ProgressPerfect_timerAnimation.Tick += ProgressPerfect_Timer_Tick;
            //    if (AutoAnimate)
            //        ProgressPerfect_timerAnimation.Start();

            //}

            //if (!DesignMode)
            //{
            //    ProgressPerfect_timerAnimation.Tick += ProgressPerfect_Timer_Tick;
            //    if (AutoAnimate)
            //        ProgressPerfect_timerAnimation.Start();

            //}
        }

        #endregion

        #region Private Fields

        //private int _value = 1;

        //private int ProgressBarPerfect_AnimationSpeed = 100;

        //private Color ProgressPerfect_CircleColor = Color.FromArgb(20, 20, 20);

        //private bool _autoStart;

        private bool _stopped = true;

        //private float ProgressPerfect_CircleSize = 0.2F;

        //private float ProgressPerfect_NumberOfCircles = 180;

        //private int ProgressPerfect_NumberOfVisibleCircles = 30;

        //private RotationType1 ProgressPerfect_Rotation = RotationType1.Clockwise;

        //private float ProgressPerfect_Percentage;

        //private bool ProgressPerfect_ShowPercentage;

        //private bool ProgressBarPerfect_ShowText;

        //private TextDisplayModes1 ProgressPerfect_TextDisplay = TextDisplayModes1.None;

        #endregion

        #region Public Properties
        


        /// <summary>
        /// Gets or sets the base color for the circles.
        /// </summary>
        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("CircularProgress Perfect")]
        public Color ProgressPerfect_CircleColor
        {
            get { return progressInput.ProgressPerfect_CircleColor; }
            set
            {
                progressInput.ProgressPerfect_CircleColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the animation should start automatically.
        /// </summary>
        //[DefaultValue(false)]
        //[Description("Gets or sets a value indicating if the animation should start automatically.")]
        //[Category("Behavior")]
        //public bool AutoAnimate
        //{
        //    get { return _autoStart; }
        //    set
        //    {
        //        _autoStart = value;

        //        if (_autoStart && !DesignMode)
        //            Start();
        //        else
        //            Stop();
        //    }
        //}

        /// <summary>
        /// Gets or sets the scale for the circles raging from 0.1 to 1.0.
        /// </summary>
        [DefaultValue(1.0F)]
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("CircularProgress Perfect")]
        public float ProgressPerfect_CircleSize
        {
            get { return progressInput.ProgressPerfect_CircleSize; }
            set
            {
                if (value <= 0.0F)
                    progressInput.ProgressPerfect_CircleSize = 0.1F;
                else
                    progressInput.ProgressPerfect_CircleSize = value > 1.0F ? 1.0F : value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("CircularProgress Perfect")]
        public int ProgressBarPerfect_AnimationSpeed
        {
            get { return (-progressInput.ProgressBarPerfect_AnimationSpeed + 400) / 4; }
            set
            {
                checked
                {
                    int interval = 400 - (value * 4);

                    if (interval < 10)
                        progressInput.ProgressBarPerfect_AnimationSpeed = 10;
                    else
                        progressInput.ProgressBarPerfect_AnimationSpeed = interval > 400 ? 400 : interval;

                    ProgressPerfect_timerAnimation.Interval = progressInput.ProgressBarPerfect_AnimationSpeed;
                }
            }
        }

        //---------------------------------------------------Number Of Circles-------------------------------------//
        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_NumberOfCircles</c> is out of range.</exception>


        //[DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("CircularProgress Perfect")]
        public float ProgressPerfect_NumberOfCircles
        {
            get { return Maximum; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");
                else
                    Maximum = value > 500 ? 500 : value;

                Maximum = value;
                Invalidate();
            }
        }


        //---------------------------------------------------Number Of Circles-------------------------------------//

        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("CircularProgress Perfect")]
        public int ProgressPerfect_NumberOfVisibleCircles
        {
            get { return progressInput.ProgressPerfect_NumberOfVisibleCircles; }
            set
            {
                if (value <= 0 || value > ProgressPerfect_NumberOfCircles)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                progressInput.ProgressPerfect_NumberOfVisibleCircles = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.
        /// </summary>
        [DefaultValue(RotationType1.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("CircularProgress Perfect")]
        public RotationType1 ProgressPerfect_Rotation
        {
            get { return progressInput.ProgressPerfect_Rotation; }
            set { progressInput.ProgressPerfect_Rotation = value; }
        }

        /// <summary>
        /// Gets or sets the percentage to show on the control.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_Percentage</c> is out of range.</exception>
        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("CircularProgress Perfect")]
        public float ProgressPerfect_Percentage
        {
            get { return progressInput.ProgressPerfect_Percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("value", "ProgressPerfect_Percentage must be a positive integer between 0 and 100.");

                progressInput.ProgressPerfect_Percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the percentage value should be shown.
        /// </summary>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("CircularProgress Perfect")]
        public bool ProgressPerfect_ShowPercentage
        {
            get { return progressInput.ProgressPerfect_ShowPercentage; }
            set
            {
                progressInput.ProgressPerfect_ShowPercentage = value;

                ProgressPerfect_TextDisplay = progressInput.ProgressPerfect_ShowPercentage
                                   ? ProgressPerfect_TextDisplay | TextDisplayModes1.ProgressPerfect_Percentage
                                   : ProgressPerfect_TextDisplay & ~TextDisplayModes1.ProgressPerfect_Percentage;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the control text should be shown.
        /// </summary>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("CircularProgress Perfect")]
        public bool ProgressBarPerfect_ShowText
        {
            get { return progressInput.ProgressBarPerfect_ShowText; }
            set
            {
                progressInput.ProgressBarPerfect_ShowText = value;

                ProgressPerfect_TextDisplay = progressInput.ProgressBarPerfect_ShowText
                                   ? ProgressPerfect_TextDisplay | TextDisplayModes1.Text
                                   : ProgressPerfect_TextDisplay & ~TextDisplayModes1.Text;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the property that will be shown in the control.
        /// </summary>
        [DefaultValue(TextDisplayModes1.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("CircularProgress Perfect")]
        public TextDisplayModes1 ProgressPerfect_TextDisplay
        {
            get { return progressInput.ProgressPerfect_TextDisplay; }
            set
            {
                progressInput.ProgressPerfect_TextDisplay = value;

                ProgressBarPerfect_ShowText = (progressInput.ProgressPerfect_TextDisplay & TextDisplayModes1.Text) == TextDisplayModes1.Text;
                ProgressPerfect_ShowPercentage = (progressInput.ProgressPerfect_TextDisplay & TextDisplayModes1.ProgressPerfect_Percentage) == TextDisplayModes1.ProgressPerfect_Percentage;
                Invalidate();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the animation.
        /// </summary>
        //public void Start()
        //{
        //    ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;
        //    _stopped = false;
        //    ProgressPerfect_timerAnimation.Start();
        //}

        /// <summary>
        /// Stops the animation.
        /// </summary>
        //public void Stop()
        //{
        //    ProgressPerfect_timerAnimation.Stop();
        //    _value = 1;
        //    _stopped = true;
        //    Invalidate();
        //}

        #endregion

        #region Overrides

        private void ProgressBarPerfect_Paint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.Clear(BackColor);
            ProgressPerfect_NumberOfCircles = Maximum;

            ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;

            //Maximum = (float)ProgressPerfect_NumberOfCircles;

            float angle = 360.0F / ProgressPerfect_NumberOfCircles;

            GraphicsState oldState = e.Graphics.Save();

            e.Graphics.TranslateTransform(Width / 2.0F, Height / 2.0F);
            e.Graphics.RotateTransform(angle * Value * (int)ProgressPerfect_Rotation);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            
            for (int i = 1; i <= ProgressPerfect_NumberOfCircles; i++)
            {
                int alphaValue = (255.0F * (i / (float)ProgressPerfect_NumberOfVisibleCircles)) > 255.0 ? 0 : (int)(255.0F * (i / (float)ProgressPerfect_NumberOfVisibleCircles));
                int alpha = _stopped ? (int)(255.0F * (1.0F / 8.0F)) : alphaValue;

                Color drawColor = Color.FromArgb(alpha, ProgressPerfect_CircleColor);



                using (SolidBrush brush = new SolidBrush(drawColor))
                {
                    float sizeRate = 4.5F / ProgressPerfect_CircleSize;
                    float size = Width / sizeRate;

                    float diff = (Width / 4.5F) - size;

                    float x = (Width / 9.0F) + diff;
                    float y = (Height / 9.0F) + diff;
                    e.Graphics.FillEllipse(brush, x, y, size, size);
                    e.Graphics.RotateTransform(angle * (int)ProgressPerfect_Rotation);
                }
            }

            e.Graphics.Restore(oldState);

            string percent = ProgressPerfect_GetDrawText();

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

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

            //base.OnPaint(e);
        }

        private void ProgressBarPerfect_OnResize(EventArgs e)
        {
            if (FixedSize)
            {
                ProgressPerfect_SetNewSize();
            }
            
        }

        private void ProgressBarPerfect_OnSizeChanged(EventArgs e)
        {
            if (FixedSize)
            {
                ProgressPerfect_SetNewSize();
            }
        }

        #endregion

        #region Private Methods

        private string ProgressPerfect_GetDrawText()
        {
            string percent = string.Format(CultureInfo.CurrentCulture, "{0:0.##} %", ProgressPerfect_Percentage);

            if (ProgressBarPerfect_ShowText && ProgressPerfect_ShowPercentage)
                return string.Format("{0}{1}{2}", percent, Environment.NewLine, Text);

            if (ProgressBarPerfect_ShowText)
                return Text;

            if (ProgressPerfect_ShowPercentage)
                return percent;

            return string.Empty;
        }

        private void ProgressPerfect_SetNewSize()
        {
            int size = Math.Max(Width, Height);
            Size = new Size(size, size);
        }

        private void ProgressPerfect_IncreaseValue()
        {
            if (Value + 1 <= ProgressPerfect_NumberOfCircles)
                Value++;
            else
                Value = 1;
        }

        /// <summary>
        /// Starts the animation.
        /// </summary>
        public void ProgressPerfect_Start()
        {
            if (DesignMode)
            {
                ProgressPerfect_timerAnimation.Enabled = true;
                ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;
                _stopped = false;
                ProgressPerfect_timerAnimation.Start();
            }
            if(!DesignMode)
            {
                ProgressPerfect_timerAnimation.Enabled = true;
                ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;
                _stopped = false;
                ProgressPerfect_timerAnimation.Start();
            }
            
        }

        /// <summary>
        /// Stops the animation.
        /// </summary>
        public void ProgressPerfect_Stop()
        {
            if (DesignMode)
            {
                ProgressPerfect_timerAnimation.Enabled = false;
                ProgressPerfect_timerAnimation.Stop();
                //Value = 1;
                _stopped = true;
                Invalidate();
            }
            if(!DesignMode)
            {
                ProgressPerfect_timerAnimation.Enabled = false;
                ProgressPerfect_timerAnimation.Stop();
                //Value = 1;
                _stopped = true;
                Invalidate();
            }
            
        }

        #endregion

        #region Timer

        private void ProgressPerfect_Timer_Tick(object sender, EventArgs e)
        {
            if (Value + 1 > Maximum)
            {
                Value = 0;
            }

            else
            {
                Value++;
                Invalidate();
            }

            //if (!DesignMode)
            //{
            //    if (this.Value + 1 > this.Maximum)
            //    {
            //        this.Value = 0;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //}

            //if(DesignMode)
            //{
            //    if (this.Value + 1 > this.Maximum)
            //    {
            //        this.Value = 0;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //}
            
        }

        #endregion
    }

    #endregion

    #region RotationType1
    /// <summary>
    /// An enum used to indicate the rotational direction of the control.
    /// </summary>
    public enum RotationType1
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

    #region TextDisplayModes1
    /// <summary>
    /// This enum is used to choose what text should be shown in the control.
    /// </summary>
    [Flags]
    public enum TextDisplayModes1
    {
        /// <summary>
        /// No text will be shown by the control.
        /// </summary>
        None = 0,

        /// <summary>
        /// The control will show the value of the ProgressPerfect_Percentage property.
        /// </summary>
        ProgressPerfect_Percentage = 1,

        /// <summary>
        /// The control will show the value of the Text property.
        /// </summary>
        Text = 2,

        /// <summary>
        /// The control will show the values of the Text and ProgressPerfect_Percentage properties.
        /// </summary>
        Both = ProgressPerfect_Percentage | Text
    }
    #endregion

    


    #endregion
}
