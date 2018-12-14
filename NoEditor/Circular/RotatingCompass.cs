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


    #region Rotating Compass


    public partial class ThematicProgress
    {

        #region Private Fields
        //private float Angle = 90f;
        //private float pieSweepAngle = 0f;
        //private int interval = 10;
        //private bool RotatingBorder = false;
        //public enum shape { Pie, Arc }
        //private shape _shape = shape.Arc;
        //private int LineSize = 1;

        //private Color PieColor1 = Color.Beige;
        //private Color PieColor2 = Color.Blue;

        //private Color LineColor1 = Color.Yellow;
        //private Color LineColor2 = Color.Blue;

        //private Color RotatingCompass_LineWidthColor = Color.Transparent;

        //private bool FillPie = false;

        //Graphics g;
        #endregion
            

        #region Event

        private void RotatingCompass_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Angle + 1 > 360)
            {

                this.Angle = 0;
            }
            else
            {
                this.Angle++;
                Invalidate();
            }

            if (Value + 1 > 360)
            {

                this.Value = 0;
            }
            else
            {
                this.Value++;
                Invalidate();
            }

        }


        private void RotatingCompassAngle_Timer_Tick(object sender, EventArgs e)
        {

            //if (Value + 1 > 360)
            //{

            //    this.Value = 0;
            //}
            //else
            //{
            //    this.Value++;
            //    Invalidate();
            //}

        }

        #endregion

        #region Constructor

        public void RotatingCompass()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            if (CircularProgressType == CircularProgress.RotatingArc ||
                CircularProgressType == CircularProgress.RotatingCompass
                )
            {
                Maximum = 360;
            }

        }

        #endregion

        #region Public Properties

        [Category("CircularProgress Compass")]
        public Color RotatingCompass_LineWidthColor
        {
            get { return lineWidthColor; }
            set
            {
                lineWidthColor = value;
                Invalidate();
            }
        }
        

        [Category("CircularProgress Compass")]
        public Color RotatingCompass_PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public Color RotatingCompass_PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public Color RotatingCompass_LineColor1
        {
            get { return lineColor1; }
            set
            {
                lineColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public Color RotatingCompass_LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public bool RotatingCompass_FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public int RotatingCompass_LineSize
        {
            get { return size; }
            set
            {
                size = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Compass")]
        public bool RotatingCompass_RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [Category("CircularProgress Compass")]
        public float RotatingCompass_Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }


        
        #endregion

        #region Overrides

        private void RotatingCompass_OnPaint(PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;
            e.Graphics.Clear(BackColor);

            //timer.Interval = interval;

            //Text = "";
            
            if (RotatingBorder)
            {
                e.Graphics.DrawPie(new Pen(Color.Blue), new Rectangle(0, 0, Width - 2, Height - 2), 180, Value/Maximum * 360);

                if (FillPie)
                {
                    LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, Value / Maximum * 360);
                    e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), 180, Value / Maximum * 360);
                }

            }

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            // Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(Angle);

            #region Line
            // Draw rotated, translated ellipse to screen.
            e.Graphics.DrawRectangle(new Pen(RotatingCompass_LineWidthColor, 1), 0, 0, 1, (Width / 2));

            LinearGradientBrush brushfillrect = new LinearGradientBrush(new Rectangle(0, 0, 1, (Width / 2)), LineColor1, LineColor2, Value / Maximum * 360);

            e.Graphics.FillRectangle(brushfillrect, 0, 0, LineSize, (Width / 2));
            #endregion
            
            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value / Maximum * 100).ToString() + PostFix, Font, ForeColor, new Rectangle(0, 0, Width, Height));

            }
            
        }

        #endregion

        #region Private Methods
        private void RotatingCompass_DrawText(Graphics g)
        {
            g.DrawString("Text", new Font("Verdana", 30, FontStyle.Bold),
                Brushes.Black, 0, 10);
        }
        #endregion


    }


    #endregion


}
