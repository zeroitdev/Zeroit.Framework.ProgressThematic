// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicatorUnique.cs" company="Zeroit Dev Technologies">
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
    #region ZeroitProgressIndicatorUnique

    #region ProgressIndicator
    /// <summary>
    /// Firefox like circular progress indicator.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {
        #region Constructor

        /// <summary>
        /// Default constructor for the ProgressIndicator.
        /// </summary>
        public void ZeroitProgressBarUnique()
        {

            //Unique_NumberOfCircles = (int)Maximum;

        }

        #endregion

        #region Private Fields

        //private int Unique_AnimationSpeed = 100;

        //private Color Unique_CircleColor = Color.FromArgb(20, 20, 20);

        //private bool _stopped = true;

        //private float Unique_CircleSize = 1.0F;

        //private int Unique_NumberOfCircles = 8;

        //private int Unique_NumberOfVisibleCircles = 8;

        //private Unique_RotationType Unique_Rotation = Unique_RotationType.Clockwise;

        //private float Unique_Percentage;

        //private bool Unique_ShowPercentage;

        //private bool Unique_ShowText;

        //private Unique_TextDisplayModes Unique_TextDisplay = Unique_TextDisplayModes.None;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the base color for the circles.
        /// </summary>
        /// <value>The color of the unique circle.</value>
        [DefaultValue(typeof(Color), "20, 20, 20")]
        [Description("Gets or sets the base color for the circles.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public Color Unique_CircleColor
        {
            get { return progressInput.Unique_CircleColor; }
            set
            {
                progressInput.Unique_CircleColor = value;
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
        /// <value>The size of the unique circle.</value>
        [DefaultValue(1.0F)]
        [Description("Gets or sets the scale for the circles raging from 0.1 to 1.0.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public float Unique_CircleSize
        {
            get { return progressInput.Unique_CircleSize; }
            set
            {
                if (value <= 0.0F)
                    progressInput.Unique_CircleSize = 0.1F;
                else
                    progressInput.Unique_CircleSize = value > 1.0F ? 1.0F : value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the animation speed.
        /// </summary>
        /// <value>The unique animation speed.</value>
        [DefaultValue(75)]
        [Description("Gets or sets the animation speed.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public int Unique_AnimationSpeed
        {
            get { return (-progressInput.Unique_AnimationSpeed + 400) / 4; }
            set
            {
                checked
                {
                    int interval = 400 - (value * 4);

                    if (interval < 10)
                        progressInput.Unique_AnimationSpeed = 10;
                    else
                        progressInput.Unique_AnimationSpeed = interval > 400 ? 400 : interval;

                    ProgressPerfect_timerAnimation.Interval = progressInput.Unique_AnimationSpeed;
                }
            }
        }



        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <value>The unique number of circles.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public float Unique_NumberOfCircles
        {
            get { return progressInput.Unique_NumberOfCircles; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer.");

                progressInput.Unique_NumberOfCircles = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the number of circles used in the animation.
        /// </summary>
        /// <value>The unique number of visible circles.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_NumberOfCircles</c> is out of range.</exception>
        [DefaultValue(8)]
        [Description("Gets or sets the number of circles used in the animation.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public int Unique_NumberOfVisibleCircles
        {
            get { return progressInput.Unique_NumberOfVisibleCircles; }
            set
            {
                if (value <= 0 || value > Unique_NumberOfCircles)
                    throw new ArgumentOutOfRangeException("value", "Number of circles must be a positive integer and less than or equal to the number of circles.");

                progressInput.Unique_NumberOfVisibleCircles = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.
        /// </summary>
        /// <value>The unique rotation.</value>
        [DefaultValue(Unique_RotationType.Clockwise)]
        [Description("Gets or sets a value indicating if the rotation should be clockwise or counter-clockwise.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public Unique_RotationType Unique_Rotation
        {
            get { return progressInput.Unique_Rotation; }
            set { progressInput.Unique_Rotation = value; }
        }

        /// <summary>
        /// Gets or sets the percentage to show on the control.
        /// </summary>
        /// <value>The unique percentage.</value>
        /// <exception cref="ArgumentOutOfRangeException"><c>Unique_Percentage</c> is out of range.</exception>
        [DefaultValue(0)]
        [Description("Gets or sets the percentage to show on the control.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public float Unique_Percentage
        {
            get { return progressInput.Unique_Percentage; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("value", "Unique_Percentage must be a positive integer between 0 and 100.");

                progressInput.Unique_Percentage = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating if the percentage value should be shown.
        /// </summary>
        /// <value><c>true</c> if [unique show percentage]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the percentage value should be shown.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public bool Unique_ShowPercentage
        {
            get { return progressInput.Unique_ShowPercentage; }
            set
            {
                progressInput.Unique_ShowPercentage = value;

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
        /// <value><c>true</c> if [unique show text]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [Description("Gets or sets a value indicating if the control text should be shown.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public bool Unique_ShowText
        {
            get { return progressInput.Unique_ShowText; }
            set
            {
                progressInput.Unique_ShowText = value;

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
        /// <value>The unique text display.</value>
        [DefaultValue(Unique_TextDisplayModes.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public Unique_TextDisplayModes Unique_TextDisplay
        {
            get { return progressInput.Unique_TextDisplay; }
            set
            {
                progressInput.Unique_TextDisplay = value;

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

        /// <summary>
        /// Gets or sets the unique custom text.
        /// </summary>
        /// <value>The unique custom text.</value>
        [Category("Indicator Progress Unique")]
        [Browsable(false)]
        public string Unique_CustomText
        {
            get { return progressInput.Unique_CustomText; }
            set
            {
                progressInput.Unique_CustomText = value;
                Invalidate();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts the animation.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
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
            //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
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

        /// <summary>
        /// Uniques the on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Unique_OnResize(EventArgs e)
        {
            if (FixedSize)
            {
                Unique_SetNewSize();
            }


        }

        /// <summary>
        /// Uniques the on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Unique_OnSizeChanged(EventArgs e)
        {
            if (FixedSize)
            {
                Unique_SetNewSize();
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Uniques the get draw text.
        /// </summary>
        /// <returns>System.String.</returns>
        private string Unique_GetDrawText()
        {
            string percent = string.Format(CultureInfo.CurrentCulture, "{0:0} %", /*Unique_Percentage*/ ((Value/ Unique_NumberOfCircles) * 100));

            if (Unique_ShowText && Unique_ShowPercentage)
                return string.Format("{0}{1}{2}", percent, Environment.NewLine, /*Text*/Unique_CustomText);

            if (Unique_ShowText)
                return Unique_CustomText;

            if (Unique_ShowPercentage)
                return percent;

            return string.Empty;
        }

        /// <summary>
        /// Uniques the new size of the set.
        /// </summary>
        private void Unique_SetNewSize()
        {
            if (FixedSize)
            {
                int size = System.Math.Max(Width, Height);
                Size = new Size(size, size);
            }
            
        }


        #endregion

        #region Timer

        /// <summary>
        /// Handles the Tick event of the Unique_timerAnimation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Unique_timerAnimation_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //_stopped = false;

            //if (DesignMode)
            //{
            //    if (this.Value + 1 > this.Unique_NumberOfCircles)
            //    {
            //        this.Value = 1;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    if (this.Value + 1 > this.Unique_NumberOfCircles)
            //    {
            //        this.Value = 1;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //} 
            #endregion

            _stopped = false;

            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Unique_NumberOfCircles)
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
                if (this.Value + (Change * SpeedMultiplier) > this.Unique_NumberOfCircles)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 1;
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
        /// Handles the Tick event of the Unique_timerAnimation_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Unique_timerAnimation_Reduced_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //_stopped = false;

            //if (DesignMode)
            //{
            //    if (this.Value + 1 > this.Unique_NumberOfCircles)
            //    {
            //        this.Value = 1;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    if (this.Value + 1 > this.Unique_NumberOfCircles)
            //    {
            //        this.Value = 1;
            //    }

            //    else
            //    {
            //        this.Value++;
            //        Invalidate();
            //    }
            //} 
            #endregion

            _stopped = false;

            if (this.Value < 10)
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
        

        /// <summary>
        /// The m is timer active
        /// </summary>
        private bool m_IsTimerActive = false;
        
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
