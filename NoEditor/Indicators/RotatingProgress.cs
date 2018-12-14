#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
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

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region Rotating Progress


    public partial class  ThematicProgress
    {

        #region Private Fields
        public enum Vuvuzela_Shape { Pie, Arc }

        private float Vuvuzela_angle = 90f;
        private int Vuvuzela_interval = 10;
        private bool Vuvuzela_rotatingBorder = false;
        private Vuvuzela_Shape Vuvuzela_shape = Vuvuzela_Shape.Arc;
        private int Vuvuzela_size = 20;
        private bool Vuvuzela_fillPie = false;
        private Color Vuvuzela_rotatingCircle = Color.Red;
        private Color Vuvuzela_circle1 = Color.Black;
        private Color Vuvuzela_circle2 = Color.Green;
        private Color Vuvuzela_circle3 = Color.Brown;
        private Color Vuvuzela_circle4 = Color.Green;
        private Color Vuvuzela_circle5 = Color.Blue;
        private int Vuvuzela_circleSize = 1;

        private int Vuvuzela_verticalSpacing = 0;
        private int Vuvuzela_horizontalSpacing = 0;

        #endregion

        #region Event

        private void Vuvuzela_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Vuvuzela_Angle + 1 > 360)
            {

                this.Vuvuzela_Angle = 0;
            }
            else
            {
                this.Vuvuzela_Angle++;
                Invalidate();
            }

        }

        #endregion

        #region Constructor

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

        [Category("Indicator Progress - Vuvuzela")]
        public bool Vuvuzela_FillPie
        {
            get { return Vuvuzela_fillPie; }
            set
            {
                Vuvuzela_fillPie = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public int ControlSize
        {
            get { return Vuvuzela_size; }
            set
            {
                Vuvuzela_size = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Vuvuzela_Shape Shape
        {
            get { return Vuvuzela_shape; }
            set
            {
                Vuvuzela_shape = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public bool Vuvuzela_RotatingBorder
        {
            get { return Vuvuzela_rotatingBorder; }
            set
            {
                Vuvuzela_rotatingBorder = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public float Vuvuzela_Angle
        {
            get { return Vuvuzela_angle; }
            set
            {
                Vuvuzela_angle = value;
                //Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public int Vuvuzela_CircleSize
        {
            get { return Vuvuzela_circleSize; }
            set
            {
                Vuvuzela_circleSize = value;
                Invalidate();

            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle1
        {
            get { return Vuvuzela_circle1; }
            set
            {
                Vuvuzela_circle1 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle2
        {
            get { return Vuvuzela_circle2; }
            set
            {
                Vuvuzela_circle2 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle3
        {
            get { return Vuvuzela_circle3; }
            set
            {
                Vuvuzela_circle3 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle4
        {
            get { return Vuvuzela_circle4; }
            set
            {
                Vuvuzela_circle4 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle5
        {
            get { return Vuvuzela_circle5; }
            set
            {
                Vuvuzela_circle5 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_RotatingCircle
        {
            get { return Vuvuzela_rotatingCircle; }
            set
            {
                Vuvuzela_rotatingCircle = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public int Vuvuzela_VerticalSpacing
        {
            get { return Vuvuzela_verticalSpacing; }
            set
            {
                Vuvuzela_verticalSpacing = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public int Vuvuzela_HorizontalSpacing
        {
            get { return Vuvuzela_horizontalSpacing; }
            set
            {
                Vuvuzela_horizontalSpacing = value;
                Invalidate();
            }
        }



        #endregion

        #region Overrides

        private void Vuvuzela_OnPaint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);
            
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
