// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerfect.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;


#endregion

namespace Zeroit.Framework.ProgressThematic
{


    #region ZeroitProgressBarPerfect


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
    //[Flags]
    public enum TextDisplayModes1
    {
        /// <summary>
        /// No text will be shown by the control.
        /// </summary>
        None,

        /// <summary>
        /// The control will show the value of the ProgressPerfect_Percentage property.
        /// </summary>
        Percentage,

        /// <summary>
        /// The control will show the value of the Text property.
        /// </summary>
        Text,

        /// <summary>
        /// The control will show the values of the Text and ProgressPerfect_Percentage properties.
        /// </summary>
        Both

        //Both = Percentage | Text
    }

    #endregion

    #region ProgressIndicator
    /// <summary>
    /// Firefox like circular progress indicator.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />

    public partial class ZeroitThematicProgress
    {
        /// <summary>
        /// The progress perfect timer animation
        /// </summary>
        private System.Windows.Forms.Timer ProgressPerfect_timerAnimation = new System.Windows.Forms.Timer();

        #region Constructor

        /// <summary>
        /// Default constructor for the ProgressIndicator.
        /// </summary>
        public void ZeroitProgressBarPerfect()
        {
            _numberOfCircles = ProgressPerfect_NumberOfCircles;

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


        }

        #endregion

        #region Private Fields

        //private int _value = 1;

        //private int ProgressBarPerfect_AnimationSpeed = 100;

        //private Color ProgressPerfect_CircleColor = Color.FromArgb(20, 20, 20);

        //private bool _autoStart;

        /// <summary>
        /// The stopped
        /// </summary>
        private bool _stopped = true;

        //private float ProgressPerfect_CircleSize = 0.2F;

        /// <summary>
        /// The number of circles
        /// </summary>
        private float _numberOfCircles = 180;

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
        /// <value>The color of the progress perfect circle.</value>
        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
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
        /// <value>The size of the progress perfect circle.</value>
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public float ProgressPerfect_CircleSize
        {
            get { return progressInput.ProgressPerfect_CircleSize; }
            set
            {
                if (value < 0.0F)
                {
                    value = 0.1F;
                }

                if (value > 1.0F)
                {
                    value = 1.0F;
                }

                progressInput.ProgressPerfect_CircleSize = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The progress bar perfect animation speed.</value>
        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public int ProgressBarPerfect_AnimationSpeed
        {
            get { return (-progressInput.ProgressBarPerfect_AnimationSpeed + 400) / 4; }
            set
            {
                checked
                {
                    int interval = 400 - (value * 4);

                    if (interval < 10)
                    {
                        progressInput.ProgressBarPerfect_AnimationSpeed = 10;
                    }

                    else
                    {
                        progressInput.ProgressBarPerfect_AnimationSpeed = interval > 400 ? 400 : interval;

                    }

                    ProgressPerfect_timerAnimation.Interval = progressInput.ProgressBarPerfect_AnimationSpeed;
                    AnimationSpeed[0] = progressInput.ProgressBarPerfect_AnimationSpeed;
                }
            }
        }

        //---------------------------------------------------Number Of Circles-------------------------------------//
        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <value>The progress perfect number of circles.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_NumberOfCircles</c> is out of range.</exception>


        //[DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public float ProgressPerfect_NumberOfCircles
        {
            get { return progressInput.ProgressPerfect_NumberOfCircles; }
            set
            {
                #region Old Code
                //if (value <= 0)
                //    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");
                //else
                //    Maximum = value > 500 ? 500 : value;

                //Maximum = value;
                #endregion

                if (value <= 0)
                        value = 1;

                if (value > 1000)
                        value = 1000;

                progressInput.ProgressPerfect_NumberOfCircles = value;

                Invalidate();
            }
        }


        //---------------------------------------------------Number Of Circles-------------------------------------//

        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <value>The progress perfect number of visible circles.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public int ProgressPerfect_NumberOfVisibleCircles
        {
            get { return progressInput.ProgressPerfect_NumberOfVisibleCircles; }
            set
            {
                if (value <= 0 || value > _numberOfCircles)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                progressInput.ProgressPerfect_NumberOfVisibleCircles = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.
        /// </summary>
        /// <value>The progress perfect rotation.</value>
        [DefaultValue(RotationType1.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public RotationType1 ProgressPerfect_Rotation
        {
            get { return progressInput.ProgressPerfect_Rotation; }
            set
            {
                progressInput.ProgressPerfect_Rotation = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the percentage to show on the control.
        /// </summary>
        /// <value>The progress perfect percentage.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>ProgressPerfect_Percentage</c> is out of range.</exception>
        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public float ProgressPerfect_Percentage
        {
            get { return progressInput.ProgressPerfect_Percentage; }
            set
            {
                //if (value < 0 || (value/ ProgressPerfect_NumberOfCircles * 100) > 100)
                //    throw new ArgumentOutOfRangeException("value", "ProgressPerfect_Percentage must be a positive integer between 0 and 100.");

                progressInput.ProgressPerfect_Percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the percentage value should be shown.
        /// </summary>
        /// <value><c>true</c> if [progress perfect show percentage]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public bool ProgressPerfect_ShowPercentage
        {
            get { return progressInput.ProgressPerfect_ShowPercentage; }
            set
            {
                progressInput.ProgressPerfect_ShowPercentage = value;

                
                //ProgressPerfect_TextDisplay = progressInput.ProgressPerfect_ShowPercentage
                //                   ? ProgressPerfect_TextDisplay | TextDisplayModes1.Percentage
                //                   : ProgressPerfect_TextDisplay & ~TextDisplayModes1.Percentage;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the control text should be shown.
        /// </summary>
        /// <value><c>true</c> if [progress bar perfect show text]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public bool ProgressBarPerfect_ShowText
        {
            get { return progressInput.ProgressBarPerfect_ShowText; }
            set
            {
                progressInput.ProgressBarPerfect_ShowText = value;

                
                //ProgressPerfect_TextDisplay = progressInput.ProgressBarPerfect_ShowText
                //                   ? ProgressPerfect_TextDisplay | TextDisplayModes1.Text
                //                   : ProgressPerfect_TextDisplay & ~TextDisplayModes1.Text;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the property that will be shown in the control.
        /// </summary>
        /// <value>The progress perfect text display.</value>

        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public TextDisplayModes1 ProgressPerfect_TextDisplay
        {
            get { return progressInput.ProgressPerfect_TextDisplay; }
            set
            {
                progressInput.ProgressPerfect_TextDisplay = value;

                if (value == TextDisplayModes1.Percentage)
                {
                    ProgressPerfect_ShowPercentage = true;

                    ProgressBarPerfect_ShowText = false;
                }

                if (value == TextDisplayModes1.Text)
                {
                    ProgressBarPerfect_ShowText = true;

                    ProgressPerfect_ShowPercentage = false;


                }

                if (value == TextDisplayModes1.Both)
                {
                    ProgressBarPerfect_ShowText = true;
                    ProgressPerfect_ShowPercentage = true;
                }

                if (value == TextDisplayModes1.None)
                {
                    ProgressBarPerfect_ShowText = false;
                    ProgressPerfect_ShowPercentage = false;
                }

                //ProgressBarPerfect_ShowText = (progressInput.ProgressPerfect_TextDisplay & TextDisplayModes1.Text) == TextDisplayModes1.Text;
                //ProgressPerfect_ShowPercentage = (progressInput.ProgressPerfect_TextDisplay & TextDisplayModes1.Percentage) == TextDisplayModes1.Percentage;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress bar perfect custom text.
        /// </summary>
        /// <value>The progress bar perfect custom text.</value>
        [Category("CircularProgress Perfect")]
        [Browsable(false)]
        public string ProgressBarPerfect_CustomText
        {
            get { return progressInput.ProgressBarPerfect_CustomText; }
            set
            {
                progressInput.ProgressBarPerfect_CustomText = value;
                Invalidate();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the animation.
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
        private string percent = "";
        /// <summary>
        /// Progresses the bar perfect paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerfect_Paint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            e.Graphics.Clear(BackColor);
            _numberOfCircles = ProgressPerfect_NumberOfCircles;

            ProgressPerfect_timerAnimation.Interval = ProgressBarPerfect_AnimationSpeed;

            //Maximum = (float)_numberOfCircles;

            float angle = 360.0F / _numberOfCircles;

            GraphicsState oldState = e.Graphics.Save();

            e.Graphics.TranslateTransform(Width / 2.0F, Height / 2.0F);
            e.Graphics.RotateTransform(angle * ((Value/Maximum) * _numberOfCircles) * (int)ProgressPerfect_Rotation);
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            
            for (int i = 1; i <= _numberOfCircles; i++)
            {
                int alphaValue = (255.0F * (i / (float)ProgressPerfect_NumberOfVisibleCircles)) > 255.0 ? 0 : (int)(255.0F * (i / (float)ProgressPerfect_NumberOfVisibleCircles));
                int alpha = _stopped ? (int)(255.0F * (1.0F / 8.0F)) : alphaValue;

                Color drawColor = Color.FromArgb(alpha, ProgressPerfect_CircleColor);

                SolidBrush brush = new SolidBrush(drawColor);

                float sizeRate = 4.5F / ProgressPerfect_CircleSize;
                float size = Width / sizeRate;

                float diff = (Width / 4.5F) - size;

                float x = (Width / 9.0F) + diff;
                float y = (Height / 9.0F) + diff;
                e.Graphics.FillEllipse(brush, x, y, size, size);
                e.Graphics.RotateTransform(angle * (int)ProgressPerfect_Rotation);

                //using ()
                //{
                    
                //}
            }

            e.Graphics.Restore(oldState);

            percent = ProgressPerfect_GetDrawText();

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
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value/ Maximum * 100).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

            //base.OnPaint(e);
        }

        /// <summary>
        /// Progresses the bar perfect on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerfect_OnResize(EventArgs e)
        {
            if (FixedSize)
            {
                ProgressPerfect_SetNewSize();
            }
            
        }

        /// <summary>
        /// Progresses the bar perfect on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressBarPerfect_OnSizeChanged(EventArgs e)
        {
            if (FixedSize)
            {
                ProgressPerfect_SetNewSize();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Progresses the perfect get draw text.
        /// </summary>
        /// <returns>System.String.</returns>
        private string ProgressPerfect_GetDrawText()
        {
            string percent = string.Format(CultureInfo.CurrentCulture, "{0:0.##} %", Convert.ToInt32(ProgressPerfect_Percentage/ ProgressPerfect_NumberOfCircles * 100));

            if (ProgressBarPerfect_ShowText && ProgressPerfect_ShowPercentage)
                return string.Format("{0}{1}{2}", percent, Environment.NewLine, /*Text*/ ProgressBarPerfect_CustomText);

            if (ProgressBarPerfect_ShowText)
                return /*Text*/ ProgressBarPerfect_CustomText;

            if (ProgressPerfect_ShowPercentage)
            {

                return percent;
            }
                

            return string.Empty;
        }

        /// <summary>
        /// Progresses the new size of the perfect set.
        /// </summary>
        private void ProgressPerfect_SetNewSize()
        {
            int size = System.Math.Max(Width, Height);
            Size = new Size(size, size);
        }

        /// <summary>
        /// Progresses the perfect increase value.
        /// </summary>
        private void ProgressPerfect_IncreaseValue()
        {
            if (Value + 1 <= _numberOfCircles)
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

        /// <summary>
        /// Handles the Tick event of the ProgressPerfect_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressPerfect_Timer_Tick(object sender, EventArgs e)
        {
            _stopped = false;
            #region Old Code

            //timerDecrement.Stop();
            //timerDecrement.Enabled = false;

            //if ((Value) + 1 > Maximum)
            //{
            //    Value = 0;
            //}

            //else
            //{
            //    Value++;
            //    Invalidate();
            //}

            ////if ((ProgressPerfect_Percentage / ProgressPerfect_NumberOfCircles * 100) + 1 > 100)
            ////{
            ////    ProgressPerfect_Percentage = 0;
            ////}
            ////else
            ////{
            ////    ProgressPerfect_Percentage++;
            ////    Invalidate();
            ////}
            #endregion

            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
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
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
        }


        /// <summary>
        /// Handles the Tick event of the ProgressPerfect_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressPerfect_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            _stopped = false;

            if (this.Value < this.Minimum)
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
                this.Value -= (Change * SpeedMultiplier);
                Invalidate();
            }

        }


        #endregion

    }

    #endregion



    #endregion


}
