// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingProgress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region Rotating Progress


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class  ZeroitThematicProgress
    {

        #region Private Fields
        //private float Vuvuzela_Angle = 90f;
        /// <summary>
        /// The vuvuzela interval
        /// </summary>
        private int Vuvuzela_interval = 10;
        //private bool Vuvuzela_RotatingBorder = false;
        /// <summary>
        /// Enum Vuvuzela_Shape
        /// </summary>
        public enum Vuvuzela_Shape { Pie, Arc }
        //private Vuvuzela_Shape Shape = Vuvuzela_Shape.Arc;
        //private int ControlSize = 20;

        //private bool Vuvuzela_FillPie = false;

        //private Color Vuvuzela_RotatingCircle = Color.Red;
        //private Color Vuvuzela_Circle1 = Color.Black;
        //private Color Vuvuzela_Circle2 = Color.Green;
        //private Color Vuvuzela_Circle3 = Color.Brown;
        //private Color Vuvuzela_Circle4 = Color.Green;
        //private Color Vuvuzela_Circle5 = Color.Blue;
        //private int Vuvuzela_CircleSize = 1;


        //Graphics g;
        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the Vuvuzela_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Vuvuzela_Timer_Tick(object sender, EventArgs e)
        {

            #region Old Code
            //if (this.Vuvuzela_Angle + 1 > 360)
            //{

            //    this.Vuvuzela_Angle = 0;
            //}
            //else
            //{
            //    this.Vuvuzela_Angle++;
            //    Invalidate();
            //} 
            #endregion

            
            if (Reverse)
            {
                if (this.Vuvuzela_Angle + (Change * SpeedMultiplier) > 360)
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
                    this.Vuvuzela_Angle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            else
            {
                if (this.Vuvuzela_Angle + (Change * SpeedMultiplier) > 360)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Vuvuzela_Angle = 0;
                    Invalidate();
                }

                else
                {
                    this.Vuvuzela_Angle += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick event of the Vuvuzela_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Vuvuzela_Timer_Reduced_Tick(object sender, EventArgs e)
        {

            if (this.Vuvuzela_Angle < 1)
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
                this.Vuvuzela_Angle -= (Change * SpeedMultiplier);
                Invalidate();
            }

        }

        #endregion

        #region Constructor

        /// <summary>
        /// Rotatings the progress.
        /// </summary>
        public void RotatingProgress()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //timer.Tick += Timer_Tick;
            //if (AutoAnimate)
            //{

            //    timer.Start();
            //}

            

        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets a value indicating whether [vuvuzela fill pie].
        /// </summary>
        /// <value><c>true</c> if [vuvuzela fill pie]; otherwise, <c>false</c>.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public bool Vuvuzela_FillPie
        {
            get { return progressInput.Vuvuzela_FillPie; }
            set
            {
                progressInput.Vuvuzela_FillPie = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the control.
        /// </summary>
        /// <value>The size of the control.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public int ControlSize
        {
            get { return progressInput.ControlSize; }
            set
            {
                progressInput.ControlSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shape.
        /// </summary>
        /// <value>The shape.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Vuvuzela_Shape Shape
        {
            get { return progressInput.Shape; }
            set
            {
                progressInput.Shape = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [vuvuzela rotating border].
        /// </summary>
        /// <value><c>true</c> if [vuvuzela rotating border]; otherwise, <c>false</c>.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public bool Vuvuzela_RotatingBorder
        {
            get { return progressInput.Vuvuzela_RotatingBorder; }
            set
            {
                progressInput.Vuvuzela_RotatingBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela angle.
        /// </summary>
        /// <value>The vuvuzela angle.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public float Vuvuzela_Angle
        {
            get { return progressInput.Vuvuzela_Angle; }
            set
            {
                progressInput.Vuvuzela_Angle = value;
                //Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the vuvuzela circle.
        /// </summary>
        /// <value>The size of the vuvuzela circle.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public int Vuvuzela_CircleSize
        {
            get { return progressInput.Vuvuzela_CircleSize; }
            set
            {
                progressInput.Vuvuzela_CircleSize = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle1.
        /// </summary>
        /// <value>The vuvuzela circle1.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_Circle1
        {
            get { return progressInput.Vuvuzela_Circle1; }
            set
            {
                progressInput.Vuvuzela_Circle1 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle2.
        /// </summary>
        /// <value>The vuvuzela circle2.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_Circle2
        {
            get { return progressInput.Vuvuzela_Circle2; }
            set
            {
                progressInput.Vuvuzela_Circle2 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle3.
        /// </summary>
        /// <value>The vuvuzela circle3.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_Circle3
        {
            get { return progressInput.Vuvuzela_Circle3; }
            set
            {
                progressInput.Vuvuzela_Circle3 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle4.
        /// </summary>
        /// <value>The vuvuzela circle4.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_Circle4
        {
            get { return progressInput.Vuvuzela_Circle4; }
            set
            {
                progressInput.Vuvuzela_Circle4 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela circle5.
        /// </summary>
        /// <value>The vuvuzela circle5.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_Circle5
        {
            get { return progressInput.Vuvuzela_Circle5; }
            set
            {
                progressInput.Vuvuzela_Circle5 = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela rotating circle.
        /// </summary>
        /// <value>The vuvuzela rotating circle.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public Color Vuvuzela_RotatingCircle
        {
            get { return progressInput.Vuvuzela_RotatingCircle; }
            set
            {
                progressInput.Vuvuzela_RotatingCircle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela vertical spacing.
        /// </summary>
        /// <value>The vuvuzela vertical spacing.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public int Vuvuzela_VerticalSpacing
        {
            get { return progressInput.Vuvuzela_VerticalSpacing; }
            set
            {
                progressInput.Vuvuzela_VerticalSpacing = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the vuvuzela horizontal spacing.
        /// </summary>
        /// <value>The vuvuzela horizontal spacing.</value>
        [Category("Indicator Progress Vuvuzela")]
        [Browsable(false)]
        public int Vuvuzela_HorizontalSpacing
        {
            get { return progressInput.Vuvuzela_HorizontalSpacing; }
            set
            {
                progressInput.Vuvuzela_HorizontalSpacing = value;
                Invalidate();
            }
        }



        #endregion

        #region Overrides

        /// <summary>
        /// Vuvuzelas the on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Vuvuzela_OnPaint(PaintEventArgs e)
        {

            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;
            //e.Graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            if (Vuvuzela_RotatingBorder)
            {
                e.Graphics.DrawEllipse(new Pen(Vuvuzela_RotatingCircle), new Rectangle(0 + Vuvuzela_HorizontalSpacing, 0 + Vuvuzela_VerticalSpacing, Width - 2, Height - 2));
            }

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            // Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(Vuvuzela_Angle);

            
            switch (Shape)
            {
                case Vuvuzela_Shape.Pie:
                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle1, Vuvuzela_CircleSize), new Rectangle(0 + Vuvuzela_HorizontalSpacing, 0 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle2, Vuvuzela_CircleSize), new Rectangle(10 + Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle3, Vuvuzela_CircleSize), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle4, Vuvuzela_CircleSize), new Rectangle(0 + Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle5, Vuvuzela_CircleSize), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    if (Vuvuzela_FillPie)
                    {
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle1), new Rectangle(0 + Vuvuzela_HorizontalSpacing, 0 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle2), new Rectangle(10 + Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle3), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle4), new Rectangle(0 + Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle5), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    }


                    break;
                case Vuvuzela_Shape.Arc:
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle1, Vuvuzela_CircleSize), new Rectangle(0 + Vuvuzela_HorizontalSpacing, 0 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    //e.Graphics.Vuvuzela_FillPie(new SolidBrush(Color.Transparent), new Rectangle(0, 0, 20, 20), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle2, Vuvuzela_CircleSize), new Rectangle(10 + Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle3, Vuvuzela_CircleSize), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, 10 + Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle4, Vuvuzela_CircleSize), new Rectangle(0 + Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle5, Vuvuzela_CircleSize), new Rectangle(-10 - Vuvuzela_HorizontalSpacing, -10 - Vuvuzela_VerticalSpacing, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    break;
                default:
                    break;
            }


        }

        #endregion

        #region Private Methods
        //private void DrawText(Graphics g)
        //{
        //    g.DrawString("Text", new Font("Verdana", 30, FontStyle.Bold),
        //        Brushes.Black, 0, 10);
        //}
        #endregion


    }

    #endregion


}
