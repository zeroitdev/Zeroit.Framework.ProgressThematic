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
    #region CircularProgressv4


    public partial class ThematicProgress
    {

        #region Private Fields
        //private int CPv4_StartAngle = -90;
        //private int Value;
        //private int Maximum = 100;
        //private int CPv4_Thickness = 20;
        //private float CPv4_GradientAngle = 90f;

        //private LineCap CPv4_StartCap = LineCap.Round;
        //private LineCap CPv4_EndCap = LineCap.Round;
        //private Color CPv4_InnerBorder = Color.Black;
        //private Color CPv4_OuterBorder = Color.Black;

        //private Color CPv4_ProgressGrad1 = Color.DarkSlateGray;
        //private Color CPv4_ProgressGrad2 = Color.Orange;

        //private Color CPv4_ProgressBackGrad1 = Color.White;
        //private Color CPv4_ProgressBackGrad2 = Color.White;

        //private int CPv4_Speed = 100;



        #endregion
        

        #region Public Properties

        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_Speed
        {
            get { return progressInput.CPv4_Speed; }
            set
            {
                progressInput.CPv4_Speed = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public float CPv4_GradientAngle
        {
            get { return progressInput.CPv4_GradientAngle; }
            set
            {
                progressInput.CPv4_GradientAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressBackGrad1
        {
            get { return progressInput.CPv4_ProgressBackGrad1; }
            set
            {
                progressInput.CPv4_ProgressBackGrad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressBackGrad2
        {
            get { return progressInput.CPv4_ProgressBackGrad2; }
            set
            {
                progressInput.CPv4_ProgressBackGrad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressGrad1
        {
            get { return progressInput.CPv4_ProgressGrad1; }
            set
            {
                progressInput.CPv4_ProgressGrad1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_ProgressGrad2
        {
            get { return progressInput.CPv4_ProgressGrad2; }
            set
            {
                progressInput.CPv4_ProgressGrad2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_InnerBorder
        {
            get { return progressInput.CPv4_InnerBorder; }
            set
            {
                progressInput.CPv4_InnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public Color CPv4_OuterBorder
        {
            get { return progressInput.CPv4_OuterBorder; }
            set
            {
                progressInput.CPv4_OuterBorder = value;
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
            get { return progressInput.CPv4_Thickness; }
            set
            {
                progressInput.CPv4_Thickness = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public int CPv4_StartAngle
        {
            get { return progressInput.CPv4_StartAngle; }
            set
            {
                progressInput.CPv4_StartAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public LineCap CPv4_StartCap
        {
            get { return progressInput.CPv4_StartCap; }
            set
            {
                progressInput.CPv4_StartCap = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV4")]
        public LineCap CPv4_EndCap
        {
            get { return progressInput.CPv4_EndCap; }
            set
            {
                progressInput.CPv4_EndCap = value;
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
            G.Clear(BackColor);

            G.TextRenderingHint = TextRendering;

            //Enable anti-aliasing to prevent rough edges
            G.SmoothingMode = SmoothingMode.HighQuality;

            //Fill background color
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
                    G.DrawArc(P, Convert.ToInt32(CPv4_Thickness / 2), Convert.ToInt32(CPv4_Thickness / 2), Width - CPv4_Thickness - 1, Height - CPv4_Thickness - 1, /*CPv4_StartAngle*/progressAngle - /*90*/ CPv4_StartAngle, /*360 * (Value/Maximum)*/ remainderAngle);
                }
            }

            //Draw center
            using (LinearGradientBrush T = new LinearGradientBrush(ClientRectangle, Color.Gray, Color.Black, CPv4_GradientAngle))
            {
                G.FillEllipse(T, CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);
            }

            //Draw progress string
            SizeF S = G.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                G.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, new SolidBrush(ForeColor), Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            //Draw outter border
            G.DrawEllipse(new Pen(CPv4_OuterBorder), 0, 0, Width - 1, Height - 1);

            //Draw inner border
            G.DrawEllipse(new Pen(CPv4_InnerBorder), CPv4_Thickness, CPv4_Thickness, Width - CPv4_Thickness * 2 - 1, Height - CPv4_Thickness * 2 - 1);

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
