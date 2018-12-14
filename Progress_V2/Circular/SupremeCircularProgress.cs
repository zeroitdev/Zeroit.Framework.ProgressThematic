// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SupremeCircularProgress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Fields
        /// <summary>
        /// Enum Supreme_colorMode
        /// </summary>
        public enum Supreme_colorMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient
        }

        /// <summary>
        /// Enum Supreme_type
        /// </summary>
        public enum Supreme_type
        {
            /// <summary>
            /// The pie
            /// </summary>
            Pie,
            /// <summary>
            /// The circle
            /// </summary>
            Circle
        }



        //private Supreme_colorMode SP_DrawMode = Supreme_colorMode.Solid;

        //private Color[] borderColors = new Color[]
        //{
        //    SystemColors.HotTrack,
        //    Color.LightGray
        //};

        //private Color SP_ProgressColor = SystemColors.HotTrack;

        //private Color SP_OuterColor = Color.LightGray;

        //private Color SP_SolidColor = SystemColors.Control;

        //private Color[] SP_GradientColor = new Color[]
        //{
        //    Color.Orange,
        //    Color.DarkSlateGray
        //};

        //private LinearGradientMode SP_GradientMode = LinearGradientMode.BackwardDiagonal;


        //private float SP_Angle = -90f;

        //private int SP_OuterBorder = 5;

        //private int SP_InnerBorder = 15; 

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the sp width tweak.
        /// </summary>
        /// <value>The sp width tweak.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_Width_Tweak
        {
            get { return progressInput.SP_Width_Tweak; }
            set
            {
                progressInput.SP_Width_Tweak = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp height tweak.
        /// </summary>
        /// <value>The sp height tweak.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_Height_Tweak
        {
            get { return progressInput.SP_Height_Tweak; }
            set
            {
                progressInput.SP_Height_Tweak = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp position horizontal.
        /// </summary>
        /// <value>The sp position horizontal.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_Position_Horizontal
        {
            get { return progressInput.SP_Position_Horizontal; }
            set
            {
                progressInput.SP_Position_Horizontal = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp position vertical.
        /// </summary>
        /// <value>The sp position vertical.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_Position_Vertical
        {
            get { return progressInput.SP_Position_Vertical; }
            set
            {
                progressInput.SP_Position_Vertical = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the type of the supreme.
        /// </summary>
        /// <value>The type of the supreme.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Supreme_type Supreme_Type
        {
            get { return progressInput.Supreme_Type; }
            set
            {
                progressInput.Supreme_Type = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the supreme start angle.
        /// </summary>
        /// <value>The supreme start angle.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public float Supreme_StartAngle
        {
            get { return progressInput.Supreme_StartAngle; }
            set
            {
                progressInput.Supreme_StartAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the supreme sweep angle.
        /// </summary>
        /// <value>The supreme sweep angle.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public float Supreme_SweepAngle
        {
            get { return progressInput.Supreme_SweepAngle; }
            set { progressInput.Supreme_SweepAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the supreme start cap.
        /// </summary>
        /// <value>The supreme start cap.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public LineCap Supreme_StartCap
        {
            get { return progressInput.Supreme_StartCap; }
            set
            {
                progressInput.Supreme_StartCap = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the supreme end cap.
        /// </summary>
        /// <value>The supreme end cap.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public LineCap Supreme_EndCap
        {
            get { return progressInput.Supreme_EndCap; }
            set
            {
                progressInput.Supreme_EndCap = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the color of the sp progress.
        /// </summary>
        /// <value>The color of the sp progress.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Color SP_ProgressColor
        {
            get { return progressInput.SP_ProgressColor; }
            set
            {
                progressInput.SP_ProgressColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp outer.
        /// </summary>
        /// <value>The color of the sp outer.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Color SP_OuterColor
        {
            get { return progressInput.SP_OuterColor; }
            set
            {
                progressInput.SP_OuterColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp solid.
        /// </summary>
        /// <value>The color of the sp solid.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Color SP_SolidColor
        {
            get { return progressInput.SP_SolidColor; }
            set
            {
                progressInput.SP_SolidColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the sp gradient.
        /// </summary>
        /// <value>The color of the sp gradient.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Color[] SP_GradientColor
        {
            get { return progressInput.SP_GradientColor; }
            set
            {
                progressInput.SP_GradientColor = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress Supreme")]
        //[Browsable(false)]
        //public Supreme_colorMode SP_DrawMode
        //{
        //    get { return progressInput.SP_DrawMode; }
        //    set
        //    {
        //        progressInput.SP_DrawMode = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the sp angle.
        /// </summary>
        /// <value>The sp angle.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public float SP_Angle
        {
            get
            {
                return progressInput.SP_Angle;

            }
            set
            {
                progressInput.SP_Angle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp outer border.
        /// </summary>
        /// <value>The sp outer border.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_OuterBorder
        {
            get { return progressInput.SP_OuterBorder; }
            set
            {
                progressInput.SP_OuterBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp inner border.
        /// </summary>
        /// <value>The sp inner border.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public int SP_InnerBorder
        {
            get { return progressInput.SP_InnerBorder; }
            set
            {
                progressInput.SP_InnerBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp gradient mode.
        /// </summary>
        /// <value>The sp gradient mode.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public LinearGradientMode SP_GradientMode
        {
            get { return progressInput.SP_GradientMode; }
            set
            {
                progressInput.SP_GradientMode = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the sp draw mode.
        /// </summary>
        /// <value>The sp draw mode.</value>
        [Category("CircularProgress Supreme")]
        [Browsable(false)]
        public Supreme_colorMode SP_DrawMode
        {
            get { return progressInput.SP_DrawMode; }
            set
            {
                progressInput.SP_DrawMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor


        #endregion

        #region Private Methods


        /// <summary>
        /// Supremes the center string.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="T">The t.</param>
        /// <param name="F">The f.</param>
        /// <param name="C">The c.</param>
        /// <param name="R">The r.</param>
        public static void Supreme_CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);

            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point(R.Width / 2 - (int)(TS.Width / 2), R.Height / 2 - (int)(TS.Height / 2)));
            }
        }

        /// <summary>
        /// Paints the progress bar.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PaintProgressBar(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
            //Graphics graphic = Graphics.FromImage(bitmap);

            //Bitmap b = new Bitmap(Width, Height);
            Graphics graphic = e.Graphics;
            //graphic.SmoothingMode = Smoothing;
            //graphic.TextRenderingHint = TextRendering;

            
            //graphic.Clear(BackColor);

            Rectangle rectangle = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen pen = new Pen(SP_OuterColor)
            {
                Width = (float)this.SP_OuterBorder
            };

            pen.StartCap = Supreme_StartCap;
            pen.EndCap = Supreme_EndCap;

            if (AllowTransparency)
            {
                MakeTransparent(this, graphic);
            }

            graphic.DrawArc(pen, rectangle, /*0f*/ Supreme_StartAngle, /*360f*/ Supreme_SweepAngle);

            

            switch (SP_DrawMode)
            {
                case Supreme_colorMode.Solid:
                    graphic.FillEllipse(new SolidBrush(SP_SolidColor), SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)));
                    break;
                case Supreme_colorMode.Gradient:
                    LinearGradientBrush linbrBrush = new LinearGradientBrush(
                        new RectangleF(SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                            SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder))),
                        SP_GradientColor[0], SP_GradientColor[1], SP_GradientMode);
                    graphic.FillEllipse(linbrBrush, SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                    (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                    (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)));
                    break;
                default:
                    break;
            }


            Rectangle rectangle1 = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen outerpen = new Pen(this.SP_ProgressColor)
            {
                Width = (float)this.SP_InnerBorder
            };

            outerpen.StartCap = Supreme_StartCap;
            outerpen.EndCap = Supreme_EndCap;

            graphic.DrawArc(
                outerpen,
                rectangle1,
                (float)this.SP_Angle,
                (float)checked((int)System.Math.Round((double)(checked(/*360*/ Supreme_SweepAngle * Value)) / Maximum)));

            


            //e.Graphics.DrawImage(b, 0, 0);

        }

        /// <summary>
        /// Paints the supreme pie.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void PaintSupremePie(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
            //Graphics graphic = Graphics.FromImage(bitmap);

            Graphics graphic = e.Graphics;
            //graphic.SmoothingMode = Smoothing;

           
            //graphic.Clear(BackColor);

            Rectangle rectangle = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen pen = new Pen(SP_OuterColor)
            {
                Width = (float)this.SP_OuterBorder
            };

            pen.StartCap = Supreme_StartCap;
            pen.EndCap = Supreme_EndCap;

            if (AllowTransparency)
            {
                MakeTransparent(this, graphic);
                SP_SolidColor = Color.Transparent;
            }

            graphic.DrawArc(pen, rectangle, Supreme_StartAngle, Supreme_SweepAngle);

            
            switch (SP_DrawMode)
            {
                case Supreme_colorMode.Solid:
                    
                    graphic.FillPie(new SolidBrush(SP_SolidColor), SP_Position_Horizontal + (float) ((double) this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float) ((double) this.SP_OuterBorder / 2),
                        (float) (checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float) (checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)), Supreme_StartAngle, Supreme_SweepAngle);

                    break;
                case Supreme_colorMode.Gradient:
                    LinearGradientBrush linbrBrush = new LinearGradientBrush(
                        new RectangleF(SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                            SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder))),
                        SP_GradientColor[0], SP_GradientColor[1], SP_GradientMode);
                    
                    graphic.FillPie(linbrBrush, SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)), Supreme_StartAngle, Supreme_SweepAngle);
                    break;
                default:
                    break;
            }


            Rectangle rectangle1 = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));

            Pen outerpen = new Pen(this.SP_ProgressColor)
            {
                Width = (float)this.SP_InnerBorder
            };

            outerpen.StartCap = Supreme_StartCap;
            outerpen.EndCap = Supreme_EndCap;



            graphic.DrawArc(
                outerpen,
                rectangle1,
                (float)this./*SP_Angle*/Supreme_StartAngle,
                (float)checked((int)System.Math.Round((double)(checked(Supreme_SweepAngle * Value)) / Maximum)));

            

        }


        #endregion

        #region Overrides

        /// <summary>
        /// Sps the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void SP_OnPaint(PaintEventArgs e)
        {
            switch (Supreme_Type)
            {
                case Supreme_type.Pie:
                    PaintSupremePie(e);
                    break;
                case Supreme_type.Circle:
                    PaintProgressBar(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            if (ShowText)
            {
                Supreme_CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font, ForeColor, this.ClientRectangle);

            }

        }


        #endregion

        #region Timer Event

        /// <summary>
        /// Handles the Tick event of the SP_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SP_Timer_Tick(object sender, EventArgs e)
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
        /// Handles the Tick event of the SP_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SP_Timer_Reduced_Tick(object sender, EventArgs e)
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

        /// <summary>
        /// Handles the Tick event of the SP_Angle_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SP_Angle_Timer_Tick(object sender, EventArgs e)
        {
            if (this.SP_Angle + 1 > 360 && this.SP_Angle <-360)
            {
                this.SP_Angle = 0;
            }

            else
            {
                this.SP_Angle++;
                Invalidate();
            }
        }

        #endregion
        
    }
}
