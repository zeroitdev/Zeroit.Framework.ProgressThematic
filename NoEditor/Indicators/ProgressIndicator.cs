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

    #region Progress Indicator

    public partial class ThematicProgress
    {

        #region Variables

        private readonly SolidBrush BaseColor = new SolidBrush(Color.DarkGray);
        private readonly SolidBrush AnimationColor = new SolidBrush(Color.DimGray);

        //private readonly System.Windows.Forms.Timer ProgIndicator_animationSpeed = new System.Windows.Forms.Timer();
        private PointF[] FloatPoint;
        private BufferedGraphics BuffGraphics;
        //private Graphics G;
        private int IndicatorIndex;
        private readonly BufferedGraphicsContext GraphicsContext = BufferedGraphicsManager.Current;

        //private float ProgIndicator_NumberOfCircles = 45f;
        //private double ProgIndicator_Radian = 180f;
        //private float ProgIndicator_CircleWidth = 15f;

        Color baseColor = Color.DarkGray;
        Color animationColor = Color.DimGray;
        private float _visibleCircles = 45f;
        private double _radian = 180f;
        private float _circleWidth = 15f;


        #endregion

        #region Custom Properties

        [Category("Indicator Progress - V1")]
        public float ProgIndicator_NumberOfCircles
        {
            get { return _visibleCircles; }
            set
            {
                _visibleCircles = value;
                this.Invalidate();
            }
        }

        [Category("Indicator Progress - V1")]
        public float ProgIndicator_CircleWidth
        {
            get { return _circleWidth; }
            set
            {
                _circleWidth = value;
                this.Invalidate();
            }
        }

        [Category("Indicator Progress - V1")]
        public Double ProgIndicator_Radian
        {
            get { return _radian; }
            set
            {
                _radian = value;
                this.Invalidate();
            }
        }

        [Category("Indicator Progress - V1")]
        public Color P_BaseColor
        {
            get
            {
                return baseColor;
            }
            set
            {
                baseColor = value;
                Invalidate();
            }
        }


        [Category("Indicator Progress - V1")]
        public Color P_AnimationColor
        {
            get
            {
                return animationColor;
            }
            set
            {
                animationColor = value;
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


        private void ProgIndicatorV1_OnSizeChanged(EventArgs e)
        {
            ProgIndicatorV1_SetStandardSize();
            UpdateGraphics();
            ProgIndicator_SetPoints();
        }

        

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

        private void ProgIndicatorV1_SetStandardSize()
        {
            int _Size = Math.Max(Width, Height);
            Size = new Size(_Size, _Size);
        }

        private void ProgIndicator_SetPoints()
        {
            Stack<PointF> stack = new Stack<PointF>();
            PointF startingFloatPoint = new PointF(((float)this.Width) / 2f, ((float)this.Height) / 2f);
            for (float i = 0f; i < 360f; i += ProgIndicator_NumberOfCircles)
            {
                this.SetValue(startingFloatPoint, (int)Math.Round((double)((((double)this.Width) / 2.0) - 15.0)), (double)i);
                PointF endPoint = this.EndPoint;
                endPoint = new PointF(endPoint.X - 7.5f, endPoint.Y - 7.5f);
                stack.Push(endPoint);
            }
            this.FloatPoint = stack.ToArray();
        }

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

        private void ProgIndicatorV1_OnPaint(PaintEventArgs e)
        {

            this.BuffGraphics = this.GraphicsContext.Allocate(this.CreateGraphics(), this.ClientRectangle);
            this.BuffGraphics.Graphics.SmoothingMode = Smoothing;
            this.BuffGraphics.Graphics.TextRenderingHint = TextRendering;

            BuffGraphics.Graphics.Clear(BackColor);

            BaseColor.Color = P_BaseColor;
            AnimationColor.Color = P_AnimationColor;

            int num2 = this.FloatPoint.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if (this.IndicatorIndex == i)
                {
                    this.BuffGraphics.Graphics.FillEllipse(this.AnimationColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);

                }
                else
                {
                    this.BuffGraphics.Graphics.FillEllipse(this.BaseColor, this.FloatPoint[i].X, this.FloatPoint[i].Y, ProgIndicator_CircleWidth, ProgIndicator_CircleWidth);

                }
            }

            this.BuffGraphics.Render(e.Graphics);
            
        }
        
        private double Rise;
        private double Run;
        private PointF _StartingFloatPoint;

        private X AssignValues<X>(ref X Run, X Length)
        {
            Run = Length;
            return Length;
        }

        private void SetValue(PointF StartingFloatPoint, int Length, double Angle)
        {
            double CircleRadian = Math.PI * Angle / ProgIndicator_Radian;

            _StartingFloatPoint = StartingFloatPoint;
            Rise = AssignValues(ref Run, Length);
            Rise = Math.Sin(CircleRadian) * Rise;
            Run = Math.Cos(CircleRadian) * Run;
        }

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
