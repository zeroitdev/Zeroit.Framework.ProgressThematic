// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicator.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

#region Imports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region Progress Indicator

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Variables

        /// <summary>
        /// The base color
        /// </summary>
        private readonly SolidBrush BaseColor = new SolidBrush(Color.DarkGray);
        /// <summary>
        /// The animation color
        /// </summary>
        private readonly SolidBrush AnimationColor = new SolidBrush(Color.DimGray);

        //private readonly System.Windows.Forms.Timer ProgIndicator_animationSpeed = new System.Windows.Forms.Timer();
        /// <summary>
        /// The float point
        /// </summary>
        private PointF[] FloatPoint;
        /// <summary>
        /// The buff graphics
        /// </summary>
        private BufferedGraphics BuffGraphics;
        //private Graphics G;
        /// <summary>
        /// The indicator index
        /// </summary>
        private int IndicatorIndex;
        /// <summary>
        /// The graphics context
        /// </summary>
        private readonly BufferedGraphicsContext GraphicsContext = BufferedGraphicsManager.Current;

        //private float ProgIndicator_NumberOfCircles = 45f;
        //private double ProgIndicator_Radian = 180f;
        //private float ProgIndicator_CircleWidth = 15f;

        #endregion

        #region Custom Properties

        /// <summary>
        /// Gets or sets the prog indicator number of circles.
        /// </summary>
        /// <value>The prog indicator number of circles.</value>
        [Category("Indicator Progress V1")]
        [Browsable(false)]
        public float ProgIndicator_NumberOfCircles
        {
            get { return progressInput.ProgIndicator_NumberOfCircles; }
            set
            {
                progressInput.ProgIndicator_NumberOfCircles = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the prog indicator circle.
        /// </summary>
        /// <value>The width of the prog indicator circle.</value>
        [Category("Indicator Progress V1")]
        [Browsable(false)]
        public float ProgIndicator_CircleWidth
        {
            get { return progressInput.ProgIndicator_CircleWidth; }
            set
            {
                progressInput.ProgIndicator_CircleWidth = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the prog indicator radian.
        /// </summary>
        /// <value>The prog indicator radian.</value>
        [Category("Indicator Progress V1")]
        [Browsable(false)]
        public Double ProgIndicator_Radian
        {
            get { return progressInput.ProgIndicator_Radian; }
            set
            {
                progressInput.ProgIndicator_Radian = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the p base.
        /// </summary>
        /// <value>The color of the p base.</value>
        [Category("Indicator Progress V1")]
        [Browsable(false)]
        public Color P_BaseColor
        {
            get
            {
                return progressInput.P_BaseColor;
            }
            set
            {
                progressInput.P_BaseColor = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the color of the p animation.
        /// </summary>
        /// <value>The color of the p animation.</value>
        [Category("Indicator Progress V1")]
        [Browsable(false)]
        public Color P_AnimationColor
        {
            get
            {
                return progressInput.P_AnimationColor;
            }
            set
            {
                progressInput.P_AnimationColor = value;
                Invalidate();
            }
        }

        //public int P_AnimationSpeed
        //{
        //    get { return ProgIndicator_animationSpeed.Interval; }
        //    set { ProgIndicator_animationSpeed.Interval = value; }
        //}

        #endregion

        #region EventArgs


        /// <summary>
        /// Progs the indicator v1 on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgIndicatorV1_OnSizeChanged(EventArgs e)
        {
            ProgIndicatorV1_SetStandardSize();
            UpdateGraphics();
            ProgIndicator_SetPoints();
        }



        /// <summary>
        /// Handles the Tick event of the ProgIndicatorV1_AnimationSpeed control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgIndicatorV1_AnimationSpeed_Tick(object sender, EventArgs e)
        {
            if (IndicatorIndex.Equals(0))
            {
                IndicatorIndex = FloatPoint.Length - 1;
            }
            else
            {
                IndicatorIndex -= 1;
            }
            this.Invalidate(false);
        }

        #endregion

        /// <summary>
        /// Zeroits the progress indicator v1.
        /// </summary>
        public void ZeroitProgressIndicatorV1()
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);

            //Size = new Size(80, 80);
            //Text = string.Empty;
            //MinimumSize = new Size(80, 80);
            ProgIndicator_SetPoints();
            //ProgIndicator_animationSpeed.Interval = 100;
            //DoubleBuffered = true;

            BaseColor.Color = P_BaseColor;
            AnimationColor.Color = P_AnimationColor;

        }

        /// <summary>
        /// Progs the size of the indicator v1 set standard.
        /// </summary>
        private void ProgIndicatorV1_SetStandardSize()
        {
            if (FixedSize)
            {
                int _Size = System.Math.Max(Width, Height);
                Size = new Size(_Size, _Size);
            }
            
        }

        /// <summary>
        /// Progs the indicator set points.
        /// </summary>
        private void ProgIndicator_SetPoints()
        {
            Stack<PointF> stack = new Stack<PointF>();
            PointF startingFloatPoint = new PointF(((float)this.Width) / 2f, ((float)this.Height) / 2f);
            for (float i = 0f; i < 360f; i += ProgIndicator_NumberOfCircles)
            {
                this.SetValue(startingFloatPoint, (int)System.Math.Round((double)((((double)this.Width) / 2.0) - 15.0)), (double)i);
                PointF endPoint = this.EndPoint;
                endPoint = new PointF(endPoint.X - 7.5f, endPoint.Y - 7.5f);
                stack.Push(endPoint);
            }
            this.FloatPoint = stack.ToArray();
        }

        /// <summary>
        /// Updates the graphics.
        /// </summary>
        private void UpdateGraphics()
        {
            if ((this.Width > 0) && (this.Height > 0))
            {
                Size size2 = new Size(this.Width + 1, this.Height + 1);
                this.GraphicsContext.MaximumBuffer = size2;
                this.BuffGraphics = this.GraphicsContext.Allocate(this.CreateGraphics(), this.ClientRectangle);
                this.BuffGraphics.Graphics.SmoothingMode = smoothing;
            }
        }

        /// <summary>
        /// Progs the indicator v1 on paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgIndicatorV1_OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            //this.BuffGraphics = this.GraphicsContext.Allocate(this.CreateGraphics(), this.ClientRectangle);
            //this.BuffGraphics.Graphics.SmoothingMode = Smoothing;
            //this.BuffGraphics.Graphics.TextRenderingHint = TextRendering;

            //BuffGraphics.Graphics.Clear(BackColor);
            //G.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, G);
            }

            BaseColor.Color = P_BaseColor;
            AnimationColor.Color = P_AnimationColor;

            int num2 = this.FloatPoint.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (this.IndicatorIndex == i)
                {
                    //this.BuffGraphics.Graphics.FillEllipse(this.AnimationColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);
                    G.FillEllipse(this.AnimationColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);

                }
                else
                {
                    //this.BuffGraphics.Graphics.FillEllipse(this.BaseColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);
                    G.FillEllipse(this.BaseColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);

                }
            }

            //this.BuffGraphics.Render(e.Graphics);
            
        }

        /// <summary>
        /// The rise
        /// </summary>
        private double Rise;
        /// <summary>
        /// The run
        /// </summary>
        private double Run;
        /// <summary>
        /// The starting float point
        /// </summary>
        private PointF _StartingFloatPoint;

        /// <summary>
        /// Assigns the values.
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="Run">The run.</param>
        /// <param name="Length">The length.</param>
        /// <returns>X.</returns>
        private X AssignValues<X>(ref X Run, X Length)
        {
            Run = Length;
            return Length;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="StartingFloatPoint">The starting float point.</param>
        /// <param name="Length">The length.</param>
        /// <param name="Angle">The angle.</param>
        private void SetValue(PointF StartingFloatPoint, int Length, double Angle)
        {
            double CircleRadian = System.Math.PI * Angle / ProgIndicator_Radian;

            _StartingFloatPoint = StartingFloatPoint;
            Rise = AssignValues(ref Run, Length);
            Rise = System.Math.Sin(CircleRadian) * Rise;
            Run = System.Math.Cos(CircleRadian) * Run;
        }

        /// <summary>
        /// Gets the end point.
        /// </summary>
        /// <value>The end point.</value>
        private PointF EndPoint
        {
            get
            {
                float LocationX = Convert.ToSingle(_StartingFloatPoint.Y + Rise);
                float LocationY = Convert.ToSingle(_StartingFloatPoint.X + Run);

                return new PointF(LocationY, LocationX);
            }
        }
        
    }


    


    #endregion

}
