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
    #region CircularProgressv4


    public partial class ThematicProgress
    {

        #region Private Fields
        private int CPv4_startAngle = -90;
        private int CPv4_thickness = 20;
        private float CPv4_gradAngle = 90f;
        private LineCap CPv4_startCap = LineCap.Round;
        private LineCap CPv4_endCap = LineCap.Round;
        private Color CPv4_innerBorder = Color.Black;
        private Color CPv4_outerBorder = Color.Black;
        private Color CPv4_progGrad1 = Color.DarkSlateGray;
        private Color CPv4_progGrad2 = Color.Orange;
        private Color CPv4_progBackGrad1 = Color.White;
        private Color CPv4_progBackGrad2 = Color.White;
        private int CPv4_speed = 100;

        private int CPv4_innerBorderThickness = 1;
        private int CPv4_outerBorderThickness = 1;
        private Color[] CPv4_fillEllipse = new Color[] { Color.Gray, Color.Black };
        #endregion

        #region Public Properties

        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_Speed
        {
            get { return CPv4_speed; }
            set
            {
                CPv4_speed = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public float CPv4_GradientAngle
        {
            get { return CPv4_gradAngle; }
            set
            {
                CPv4_gradAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressBackGrad1
        {
            get { return CPv4_progBackGrad1; }
            set
            {
                CPv4_progBackGrad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressBackGrad2
        {
            get { return CPv4_progBackGrad2; }
            set
            {
                CPv4_progBackGrad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressGrad1
        {
            get { return CPv4_progGrad1; }
            set
            {
                CPv4_progGrad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressGrad2
        {
            get { return CPv4_progGrad2; }
            set
            {
                CPv4_progGrad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_InnerBorder
        {
            get { return CPv4_innerBorder; }
            set
            {
                CPv4_innerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_OuterBorder
        {
            get { return CPv4_outerBorder; }
            set
            {
                CPv4_outerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color[] CPv4_FillEllipse
        {
            get { return CPv4_fillEllipse; }
            set
            {
                CPv4_fillEllipse = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV4")]
        //public int Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        //[Category("CircularProgress CircularProgressV4")]
        //public int Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //        {
        //            value = Maximum;
        //        }

        //        Value = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_Thickness
        {
            get { return CPv4_thickness; }
            set
            {
                CPv4_thickness = value;
                Invalidate();
            }
        }
        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_InnerBorderThickness
        {
            get { return CPv4_innerBorderThickness; }
            set
            {
                CPv4_innerBorderThickness = value;
                Invalidate();

            }
        }
        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_OuterBorderThickness
        {
            get { return CPv4_outerBorderThickness; }
            set
            {
                CPv4_outerBorderThickness = value;
                Invalidate();

            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_StartAngle
        {
            get { return CPv4_startAngle; }
            set
            {
                CPv4_startAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public LineCap CPv4_StartCap
        {
            get { return CPv4_startCap; }
            set
            {
                CPv4_startCap = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public LineCap CPv4_EndCap
        {
            get { return CPv4_endCap; }
            set
            {
                CPv4_endCap = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint Events
        //Handle PaintBackground to prevent flicker
        

        
        private void CPv4_Paint(PaintEventArgs e)
        {

            //Create image buffer
            //Bitmap B = new Bitmap(Width, Height);
            timer.Interval = CPv4_Speed;
            Graphics G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.Clear(BackColor);
            
            
            float percentage = Value;

            //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

            float progressAngle = Convert.ToSingle(360 * (percentage / Maximum));

            int remainderAngle = 360 - Convert.ToInt32(progressAngle);


            //Draw progress background
            using (LinearGradientBrush T = new LinearGradientBrush(ClientRectangle, CPv4_ProgressGrad1, CPv4_ProgressGrad2, LinearGradientMode.Vertical))
            {
                using (Pen P = new Pen(T, CPv4_Thickness))
                {
                    G.DrawArc(P, Convert.ToInt32(CPv4_Thickness / 2), Convert.ToInt32(CPv4_Thickness / 2), Width - CPv4_Thickness - 1, Height - CPv4_Thickness - 1, 0, /*360 * (Value / Maximum)*/ 360);
                }
            }

            //Draw progress
            using (LinearGradientBrush T = new LinearGradientBrush(ClientRectangle, CPv4_ProgressBackGrad1, CPv4_ProgressBackGrad2, LinearGradientMode.Vertical))
            {
                using (Pen P = new Pen(T, CPv4_Thickness))
                {
                    P.StartCap = CPv4_StartCap;
                    P.EndCap = CPv4_EndCap;
                    G.DrawArc(P, Convert.ToInt32(CPv4_Thickness / 2), Convert.ToInt32(CPv4_Thickness / 2), Width - CPv4_Thickness - 1, Height - CPv4_Thickness - 1, /*CPv4_StartAngle*/progressAngle - 90, /*360 * (Value/Maximum)*/ remainderAngle);
                }
            }

            //Draw center
            LinearGradientBrush fillEllipse = new LinearGradientBrush(ClientRectangle, CPv4_FillEllipse[0], CPv4_FillEllipse[1],
                CPv4_GradientAngle);

            G.FillEllipse(fillEllipse, CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);

            //using ()
            //{
                
            //}

            //Draw progress string
            SizeF S = G.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                G.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, new SolidBrush(ForeColor), Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            //Draw outter border
            G.DrawEllipse(new Pen(CPv4_OuterBorder, CPv4_OuterBorderThickness), 0, 0, Width - 1, Height - 1);

            //Draw inner border
            G.DrawEllipse(new Pen(CPv4_InnerBorder, CPv4_InnerBorderThickness), CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);

            //Output the buffered image
            //e.Graphics.DrawImage(B, 0, 0);

            //base.OnPaint(e);


        }
        #endregion
        

        #region Timer Event

        private void CPv4_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
            {
                this.Value = 0;
            }

            else
            {
                this.Value++;
                Invalidate();
            }

            if (this.CPv4_GradientAngle + 1 > 360)
            {
                this.CPv4_GradientAngle = 0;
            }

            else
            {
                this.CPv4_GradientAngle++;
                Invalidate();
            }
        }

        #endregion

    }

    #endregion
}
