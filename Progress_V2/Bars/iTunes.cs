// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="iTunes.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{


    #region Control
    /// <summary>
    /// This enum represents the diffrent states the control can take.
    /// Animation for ex. makes the percent bar "Rubber band" to the new procent value
    /// </summary>
    public enum BarType
    {
        /// <summary>
        /// The static
        /// </summary>
        Static,         // Plain and simple bar with procent display
        /// <summary>
        /// The progressbar
        /// </summary>
        Progressbar,    // This makes the control act as a progressbar
        /// <summary>
        /// The animated
        /// </summary>
        Animated        // This makes the control "Rubber band" to new procent values (Animated).
    };

    /// <summary>
    /// A delegate to be able to trigger value changed event
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    public delegate void BarValueChanged(object sender, EventArgs e);

    /// <summary>
    /// A iTunes look-a-like bar for displaying various data.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Static Members
        /// <summary>
        /// The pre bar base dark
        /// </summary>
        public static readonly Color PreBarBaseDark = Color.FromArgb(199, 200, 201);
        /// <summary>
        /// The pre bar base light
        /// </summary>
        public static readonly Color PreBarBaseLight = Color.WhiteSmoke;
        /// <summary>
        /// The pre bar light
        /// </summary>
        public static readonly Color PreBarLight = Color.FromArgb(102, 144, 252);
        /// <summary>
        /// The pre bar dark
        /// </summary>
        public static readonly Color PreBarDark = Color.FromArgb(40, 68, 202);
        /// <summary>
        /// The pre border color
        /// </summary>
        public static readonly Color PreBorderColor = Color.DarkGray;
        #endregion

        #region Private Members
        /// <summary>
        /// The Light background color
        /// </summary>
        private System.Windows.Forms.Timer tTickTimer = new System.Windows.Forms.Timer();

        /// <summary>
        /// The stepsize to use when the control is a progressbar
        /// </summary>
        private System.Windows.Forms.Timer tAnimTicker = new System.Windows.Forms.Timer();

        /// <summary>
        /// A value to save the new target procent when we are in Animation mode
        /// </summary>
        private float fNewProcent = 0.0F;

        /// <summary>
        /// A simple flag to indicate what way the control should animate it's progress when it's in Animation mode
        /// </summary>
        private bool bAnimUp = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the size of the step.
        /// When this value is &gt; 0 the progressbar is enabled
        /// </summary>
        /// <value>The size of the step.</value>
        [System.ComponentModel.Description("Gets or sets the stepsize. This controls how many steps it will progress when making a move")]
        [System.ComponentModel.DefaultValue(2)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public float StepSize
        {
            get { return progressInput.StepSize; }
            set
            {
                progressInput.StepSize = value;
                this.tTickTimer.Enabled = (this.progressInput.StepSize != 0 && this.tTickTimer.Interval > 0 && BarType == BarType.Progressbar);
            }
        }

        /// <summary>
        /// Gets or sets the step interval.
        /// This is the interval that determins how often the control
        /// is updated with it's step size
        /// </summary>
        /// <value>The step interval.</value>
        [System.ComponentModel.Description("Gets or sets the StepInterval. This value determins how ofthen the control is updated using the StepSize")]
        [System.ComponentModel.DefaultValue(5)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public int StepInterval
        {
            get { return progressInput.StepInterval; }
            set
            {
                progressInput.StepInterval = value;

                tTickTimer.Interval = progressInput.StepInterval;
                this.tTickTimer.Enabled = (this.StepSize != 0 && this.tTickTimer.Interval > 0 && BarType == BarType.Progressbar);
            }
        }

        /// <summary>
        /// Gets or sets the number of bar dividers to display.
        /// </summary>
        /// <value>The num bar dividers.</value>
        [System.ComponentModel.Description("Gets or sets how many dividers to display on the bar")]
        [System.ComponentModel.DefaultValue(10)]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public int BarDividersCount
        {
            get { return progressInput.BarDividersCount; }
            set { progressInput.BarDividersCount = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the mirror opacity.
        /// </summary>
        /// <value>The mirror opacity.</value>
        [System.ComponentModel.Description("Gets or sets the opacity level for the reflecting part of the control")]
        [System.ComponentModel.DefaultValue(35.0f)]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public float BarMirrorOpacity
        {
            get { return progressInput.BarMirrorOpacity; }
            set { progressInput.BarMirrorOpacity = value; Refresh(); }
        }

        ///// <summary>
        ///// Gets or sets the fill procent.
        ///// </summary>
        ///// <value>The fill procent.</value>
        //[System.ComponentModel.Description("Gets or sets the fill procent")]
        //[System.ComponentModel.DefaultValue(50.0f)]
        //[System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        //public float Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        if (this.BarType == BarType.Animated)
        //        {
        //            MakeAnimation(value);
        //            return;
        //        }

        //        Value = value;
        //        Refresh();
        //    }
        //}

        /// <summary>
        /// Gets or sets the width of the border.
        /// </summary>
        /// <value>The width of the border.</value>
        [System.ComponentModel.Description("Gets or sets the with of the borders")]
        [System.ComponentModel.DefaultValue(1.0f)]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public float BarBorderWidth
        {
            get { return progressInput.BarBorderWidth; }
            set { progressInput.BarBorderWidth = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the bar background light.
        /// </summary>
        /// <value>The bar background light.</value>
        [System.ComponentModel.Description("Gets or sets the lighter background color")]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public Color BarBackgroundLight
        {
            get { return progressInput.BarBackgroundLight; }
            set { progressInput.BarBackgroundLight = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the bar background dark.
        /// </summary>
        /// <value>The bar background dark.</value>
        [System.ComponentModel.Description("Gets or sets the darker background color")]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public Color BarBackgroundDark
        {
            get { return progressInput.BarBackgroundDark; }
            set { progressInput.BarBackgroundDark = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the bar light.
        /// </summary>
        /// <value>The bar light.</value>
        [System.ComponentModel.Description("Gets or sets the light bar color")]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public Color BarLight
        {
            get { return progressInput.BarLight; }
            set { progressInput.BarLight = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the bar dark.
        /// </summary>
        /// <value>The bar dark.</value>
        [System.ComponentModel.Description("Gets or sets the dark bar color")]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public Color BarDark
        {
            get { return progressInput.BarDark; }
            set { progressInput.BarDark = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        [System.ComponentModel.Description("Gets or sets the border color")]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public Color BarBorderColor
        {
            get { return progressInput.BarBorderColor; }
            set { progressInput.BarBorderColor = value; Refresh(); }
        }

        /// <summary>
        /// Gets or sets the type of the bar.
        /// </summary>
        /// <value>The type of the bar.</value>
        [System.ComponentModel.Description("Gets or sets the type. This changes the bahaviour of the control. See the BarType enum for specification")]
        [System.ComponentModel.DefaultValue(BarType.Animated)]
        [System.ComponentModel.RefreshProperties(System.ComponentModel.RefreshProperties.Repaint)]
        [Category("RectangularProgress iTunesProgress")]
        [Browsable(false)]
        public BarType BarType
        {
            get { return progressInput.BarType; }
            set
            {
                progressInput.BarType = value;
                if (value != BarType.Progressbar)
                {
                    this.StepSize = 0;
                    this.tTickTimer.Enabled = false;
                }
            }
        }


        #endregion

        #region Events
        /// <summary>
        /// This event is to notify the user that the progress of the control has changed
        /// </summary>
        //public event BarValueChanged OnBarValueChanged = null;
        public event EventHandler<EventArgs> OnBarValueChanged = null;
        #endregion


        #region Event

        /// <summary>
        /// Handles the Tick event of the iTunes_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iTunes_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //    this.Value = 0;
            //else
            //    this.Value++; 
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
        /// Handles the Tick event of the iTunes_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iTunes_Timer_Reduced_Tick(object sender, EventArgs e)
        {
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


        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ZeroitProgressITunesBar" /> class.
        /// </summary>
        public void ZeroitProgressITunesBar()
        {


            // Progressbar timer
            this.tTickTimer.Tick += new EventHandler(TickTimer_Tick);
            this.tTickTimer.Enabled = false;
            this.tTickTimer.Interval = AnimationSpeed[0];

            // Animation timer
            tAnimTicker.Enabled = false;
            tAnimTicker.Interval = 75;
            tAnimTicker.Tick += new EventHandler(AnimationTimer_Tick);



            

        } // END CONSTRUCTOR: iBar( ... ) 

        #endregion

        #region Public Methods



        /// <summary>
        /// Returns the control rendered to a Bitmap.
        /// This method can be used in Web environment.
        /// </summary>
        /// <returns>Bitmap.</returns>
        public Bitmap ToImage()
        {
            Bitmap retVal = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(retVal);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(this.BackColor);

            Bitmap bmp = GenerateProcentBar(this.Width, this.Height, this.Value, this.BarMirrorOpacity, this.BackColor);
            g.DrawImage(bmp, 0, 0);

            g.Dispose();
            return retVal;

        } // END METHOD: ToImage( ... )
        #endregion

        /// <summary>
        /// Handles the Tick event of the TickTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void TickTimer_Tick(object sender, EventArgs e)
        {
            this.Value += this.StepSize;
            if (this.Value >= 100.0F)
                this.Value = 0.0F;
            else if (this.Value < 0.0F)
                this.Value = 100.0F;

            Refresh();

            // Trigger event if any defined
            if (OnBarValueChanged != null)
                OnBarValueChanged(this, EventArgs.Empty);

        } // END METHOD: TickTimer_Tick( ... )

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"></see> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"></see> that contains the event data.</param>
        private void iTunes_Paint(PaintEventArgs e)
        {
            //timer.Interval = interval;

            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;
            g.Clear(this.BackColor);

            Bitmap bmp = GenerateProcentBar(this.Width, this.Height, this.Value, this.BarMirrorOpacity, this.BackColor);
            g.DrawImage(bmp, 0, 0);


            SizeF MS = e.Graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if (ShowText)
                e.Graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, new SolidBrush(ForeColor), Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2) - (0.15f * Height));



        } // END METHOD: OnPaint( ... )

        /// <summary>
        /// Generates the bar.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fillProcent">The fill procent.</param>
        private void GenerateBar(ref Graphics g, float x, float y,
                                  float width, float height, float fillProcent)
        {
            float procentMarkerWidth = (width / BarDividersCount);
            float totalWidth = width;
            RectangleF rect = new RectangleF(x, y, width, height);

            using (LinearGradientBrush white = new LinearGradientBrush(rect, BarBackgroundLight, BarBackgroundDark, 90.0F, false))
            {
                g.FillRectangle(white, rect);

            } // END using( LinearGradientBrush white = new LinearGradientBrush( rect, BarBackgroundLight, BarBackgroundDark, 90.0F, false ) )

            using (Pen p = new Pen(this.BarBorderColor, this.BarBorderWidth * 2))
            {
                p.Alignment = PenAlignment.Outset;
                p.LineJoin = LineJoin.Round;
                g.DrawRectangle(p, x, y, width, height);

            } // END using( Pen p = new Pen( this.BarBorderColor, this.BarBorderWidth * 2 ) )

            width = (fillProcent > 0 ? ((fillProcent / 100) * width) : 0);
            if (width > 0.10F)
            {
                rect = new RectangleF(x, y, width, height);
                using (LinearGradientBrush bg = new LinearGradientBrush(rect, this.BarLight, this.BarDark, 90.0F, false))
                {
                    g.FillRectangle(bg, rect);

                } // END using( LinearGradientBrush bg = new LinearGradientBrush( rect, this.BarLight, this.BarDark, 90.0F, false ) )

                using (Pen p = new Pen(this.BarBorderColor, this.BarBorderWidth))
                {
                    p.Alignment = PenAlignment.Inset;
                    p.LineJoin = LineJoin.Round;
                    g.DrawLine(p, width, y, width, height);

                } // END using( Pen p = new Pen( this.BarBorderColor, this.BarBorderWidth ) )

            } // END if( width > 0 )

            using (Pen p = new Pen(this.BarDark, this.BarBorderWidth))
            {
                p.Alignment = PenAlignment.Inset;
                p.LineJoin = LineJoin.Round;
                using (Pen p2 = new Pen(this.BarLight, this.BarBorderWidth))
                {
                    p2.Alignment = PenAlignment.Inset;
                    p2.LineJoin = LineJoin.Round;
                    for (float i = procentMarkerWidth; i < totalWidth; i += procentMarkerWidth)
                    {
                        if (i >= width)
                        {
                            p.Color = BarBackgroundLight;
                            p2.Color = BarBackgroundDark;

                        } // END if( i >= width )

                        g.DrawLine(p, i, 0, i, height);
                        g.DrawLine(p2, i + this.BarBorderWidth, 0, i + this.BarBorderWidth, height);

                    } // END for( float i = procentMarkerWidth; i < totalWidth; i += procentMarkerWidth )

                } // END using( Pen p2 = new Pen( this.BarLight, this.BarBorderWidth ) )

            } // END using( Pen p = new Pen( this.BarDark, this.BarBorderWidth ) )

        } // END METHOD: GenerateBar( ... )

        /// <summary>
        /// Generates the bar image.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="procent">The procent.</param>
        /// <returns>Bitmap.</returns>
        private Bitmap GenerateBarImage(int width, int height, float procent)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            GenerateBar(ref g, 0.0F, 0.0F, width, height, procent);
            g.Dispose();

            return bmp;

        } // END METHOD: GenerateBarImage( ... )

        /// <summary>
        /// Makes the colors fade to the background.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="bgColor">Color of the bg.</param>
        /// <param name="angle">The angle.</param>
        /// <returns>Bitmap.</returns>
        private Bitmap FadeToBg(Bitmap image, Color bgColor, float angle)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(image, 0, 0);
            Rectangle source = new Rectangle(0, -1, bmp.Width, bmp.Height);
            using (LinearGradientBrush bg = new LinearGradientBrush(source, Color.Transparent, bgColor, angle, false))
            {
                g.FillRectangle(bg, source);

            } // END using( LinearGradientBrush bg = new LinearGradientBrush( source, Color.Transparent, bgColor, angle, false ) )

            g.Dispose();

            return bmp;

        } // END METHOD: FadeToBg( ... )

        /// <summary>
        /// Generates the procent bar.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="procent">The procent.</param>
        /// <param name="mirrorOpacity">The mirror opacity.</param>
        /// <param name="bgColor">Color of the bg.</param>
        /// <returns>Bitmap.</returns>
        private Bitmap GenerateProcentBar(int width, int height, float procent, float mirrorOpacity, Color bgColor)
        {
            Bitmap theImage = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(theImage);

            g.SmoothingMode = smoothing;
            g.Clear(bgColor);

            Bitmap bmp = GenerateBarImage(width, height - (height / 3), procent);
            Bitmap mirror = FadeToBg(bmp, bgColor, -90.0F);
            GraphicsState state = g.Save();
            g.ScaleTransform(1, -1.0F, MatrixOrder.Prepend);

            ColorMatrix clr = new ColorMatrix();
            ImageAttributes attributes = new ImageAttributes();

            clr.Matrix33 = (mirrorOpacity / 100);
            attributes.SetColorMatrix(clr);

            Rectangle source = new Rectangle(0, -(height), mirror.Width, mirror.Height);
            g.DrawImage(mirror, source, 0, 0, mirror.Width, mirror.Height, GraphicsUnit.Pixel, attributes);

            g.Restore(state);
            g.DrawImage(bmp, 0, -5);

            g.Dispose();
            bmp.Dispose();
            mirror.Dispose();

            return theImage;

        } // END METHOD: GenerateProcentBar( ... )

        /// <summary>
        /// Makes the animation.
        /// </summary>
        /// <param name="newProcent">The new procent.</param>
        private void MakeAnimation(float newProcent)
        {
            fNewProcent = newProcent;
            bAnimUp = ((Value - newProcent) > 0);
            tAnimTicker.Interval = 1;
            tAnimTicker.Enabled = true;

        } // END METHOD: MakeAnimation( ... )

        /// <summary>
        /// Handles the Tick event of the AnimationTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Value -= ((Value - fNewProcent) / 5.0F);
            tAnimTicker.Enabled = (!bAnimUp ? (Value <= fNewProcent) : (Value >= fNewProcent));

            Refresh();

        } // END METHOD: AnimationTimer_Tick( ... )




    } // END CLASS: iBar

    #endregion



}
