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
    #region CircularProgressv3

    public partial class ThematicProgress
    {

        #region Private Fields

        private int CPv3_progressWidth = 2;
        private int CPv3_shift = 0;
        int CPv3_remainderAngle = 0;
        int CPv3_startangle = -90;
        private bool CPv3_showText = true;
        private Color CPv3_progressColor = Color.LightSeaGreen;
        private Color CPv3_progressEmptyColor = Color.LightGray;

        #endregion

        #region Public Properties
        [Category("CircularProgress CircularProgressV3")]
        public Color CPv3_Color
        {
            get { return CPv3_progressColor; }
            set
            {
                CPv3_progressColor = value;
                Invalidate();

            }
        }

        [Category("CircularProgress CircularProgressV3")]
        public Color CPv3_ColorEmpty
        {
            get { return CPv3_progressEmptyColor; }
            set
            {
                CPv3_progressEmptyColor = value;
                Invalidate();

            }
        }

        [Category("CircularProgress CircularProgressV3")]
        public bool CPv3_ShowText
        {
            get { return CPv3_showText; }
            set
            {
                CPv3_showText = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV3")]
        //public int Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        //[Category("CircularProgress CircularProgressV3")]
        //public int Value
        //{
        //    get { return _Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //        {
        //            value = Maximum;
        //        }

        //        _Value = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress CircularProgressV3")]
        public int CPv3_StartAngle
        {
            get { return CPv3_startangle; }
            set
            {
                CPv3_startangle = value;
                Invalidate();
            }
        }


        [Category("CircularProgress CircularProgressV3")]
        public int CPv3_Shift
        {
            get { return CPv3_shift; }
            set
            {
                CPv3_shift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV3")]
        public int CPv3_ProgressWidth
        {
            get { return CPv3_progressWidth; }
            set
            {
                CPv3_progressWidth = value;
                Invalidate();
            }
        }

        #endregion

        #region Event

        private void CPv3_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
            {
                this.Value = 0;
            }

            else
            {
                this.Value++;

                //Invalidate();
            }

           


        }

        #endregion
        

        #region Paint Events
        

        private void CPv3_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;

            g.Clear(BackColor);
            
            Rectangle rect = new Rectangle(CPv3_Shift + 1, CPv3_Shift, Width - CPv3_ProgressWidth -1, Height - CPv3_ProgressWidth);

            float percentage = Value;

            //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

            float progressAngle = Convert.ToSingle(360 * (percentage / Maximum));

            CPv3_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(CPv3_Color, CPv3_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(CPv3_ColorEmpty, CPv3_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, CPv3_StartAngle, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - 90, CPv3_remainderAngle);
                }
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 14))
            {

                string text = Convert.ToInt32(percentage).ToString() + PostFix;
                dynamic textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text

                if (ShowText)
                {
                    g.DrawString(text, Font, new SolidBrush(ForeColor), textPoint);
                }

                else
                {
                    g.DrawString(text, Font, new SolidBrush(Color.Transparent), textPoint);
                }

            }

            //Form2_Paint(e);
        }

        
        private void CPv3_DrawProgress(Graphics g, Rectangle rect, float percentage)
        {
            //work out the angles for each arc
            float progressAngle = Convert.ToSingle(360 / 100 * percentage);
            int CPv3_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(Color.LightSeaGreen, CPv3_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(Color.LightGray, CPv3_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, -60, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - 90, CPv3_remainderAngle);
                }
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 14))
            {
                string text = percentage.ToString() + "%";
                dynamic textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text
                g.DrawString(text, fnt, Brushes.Black, textPoint);
            }
        }

        #endregion

    }

    #endregion
}
