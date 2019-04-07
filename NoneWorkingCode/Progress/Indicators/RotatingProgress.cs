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
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region Rotating Progress


    public partial class  ThematicProgress
    {

        #region Private Fields
        //private float Vuvuzela_Angle = 90f;
        private int Vuvuzela_interval = 10;
        //private bool Vuvuzela_RotatingBorder = false;
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
        public int Vuvuzela_CircleSize
        {
            get { return progressInput.Vuvuzela_CircleSize; }
            set
            {
                progressInput.Vuvuzela_CircleSize = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle1
        {
            get { return progressInput.Vuvuzela_Circle1; }
            set
            {
                progressInput.Vuvuzela_Circle1 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle2
        {
            get { return progressInput.Vuvuzela_Circle2; }
            set
            {
                progressInput.Vuvuzela_Circle2 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle3
        {
            get { return progressInput.Vuvuzela_Circle3; }
            set
            {
                progressInput.Vuvuzela_Circle3 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle4
        {
            get { return progressInput.Vuvuzela_Circle4; }
            set
            {
                progressInput.Vuvuzela_Circle4 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_Circle5
        {
            get { return progressInput.Vuvuzela_Circle5; }
            set
            {
                progressInput.Vuvuzela_Circle5 = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Color Vuvuzela_RotatingCircle
        {
            get { return progressInput.Vuvuzela_RotatingCircle; }
            set
            {
                progressInput.Vuvuzela_RotatingCircle = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public bool Vuvuzela_FillPie
        {
            get { return progressInput.Vuvuzela_FillPie; }
            set
            {
                progressInput.Vuvuzela_FillPie = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public int ControlSize
        {
            get { return progressInput.ControlSize; }
            set
            {
                progressInput.ControlSize = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public Vuvuzela_Shape Shape
        {
            get { return progressInput.Shape; }
            set
            {
                progressInput.Shape = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public bool Vuvuzela_RotatingBorder
        {
            get { return progressInput.Vuvuzela_RotatingBorder; }
            set
            {
                progressInput.Vuvuzela_RotatingBorder = value;
                Invalidate();
            }
        }

        [Category("Indicator Progress - Vuvuzela")]
        public float Vuvuzela_Angle
        {
            get { return progressInput.Vuvuzela_Angle; }
            set
            {
                progressInput.Vuvuzela_Angle = value;
                Invalidate();
                //Invalidate();
            }
        }


        #endregion

        #region Overrides

        private void Vuvuzela_OnPaint(PaintEventArgs e)
        {
            
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.Clear(BackColor);
            
            if (Vuvuzela_RotatingBorder)
            {
                e.Graphics.DrawEllipse(new Pen(Vuvuzela_RotatingCircle), new Rectangle(0, 0, Width - 2, Height - 2));
            }

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            // Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(Vuvuzela_Angle);

            
            switch (Shape)
            {
                case Vuvuzela_Shape.Pie:
                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle1, Vuvuzela_CircleSize), new Rectangle(0, 0, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle2, Vuvuzela_CircleSize), new Rectangle(10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle3, Vuvuzela_CircleSize), new Rectangle(-10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle4, Vuvuzela_CircleSize), new Rectangle(0, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawPie(new Pen(Vuvuzela_Circle5, Vuvuzela_CircleSize), new Rectangle(-10, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    if (Vuvuzela_FillPie)
                    {
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle1), new Rectangle(0, 0, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle2), new Rectangle(10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle3), new Rectangle(-10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle4), new Rectangle(0, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                        e.Graphics.FillPie(new SolidBrush(Vuvuzela_Circle5), new Rectangle(-10, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    }


                    break;
                case Vuvuzela_Shape.Arc:
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle1, Vuvuzela_CircleSize), new Rectangle(0, 0, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    //e.Graphics.Vuvuzela_FillPie(new SolidBrush(Color.Transparent), new Rectangle(0, 0, 20, 20), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle2, Vuvuzela_CircleSize), new Rectangle(10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle3, Vuvuzela_CircleSize), new Rectangle(-10, 10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);
                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle4, Vuvuzela_CircleSize), new Rectangle(0, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

                    e.Graphics.DrawArc(new Pen(Vuvuzela_Circle5, Vuvuzela_CircleSize), new Rectangle(-10, -10, ControlSize, ControlSize), Vuvuzela_Angle + 10, Vuvuzela_Angle);

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
