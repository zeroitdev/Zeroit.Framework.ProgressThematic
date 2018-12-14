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
    #region CircularProgressv2

    public partial class ThematicProgress
    {

        #region Private Field

        private int CPv2_progressWidth = 2;
        private int CPv2_shift = 0;
        int CPv2_remainderAngle = 0;
        int CPv2_angleReduced = 90;
        int CPv2_startAngle = 80;
        private bool CPv2_showText = true;
        private Color CPv2_progressColor = Color.LightSeaGreen;
        private Color CPv2_progressEmptyColor = Color.LightGray;


        #endregion


        #region Include in Public Properties
        [Category("CircularProgress CircularProgressV2")]

        public Color CPv2_Color
        {
            get { return CPv2_progressColor; }
            set
            {
                CPv2_progressColor = value;
                Invalidate();

            }
        }

        [Category("CircularProgress CircularProgressV2")]

        public Color CPv2_ColorEmpty
        {
            get { return CPv2_progressEmptyColor; }
            set
            {
                CPv2_progressEmptyColor = value;
                Invalidate();

            }
        }

        [Category("CircularProgress CircularProgressV2")]

        public bool CPv2_ShowText
        {
            get { return CPv2_showText; }
            set
            {
                CPv2_showText = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV2")]

        //public int Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress CircularProgressV2")]

        public int CPv2_StartAngle
        {
            get { return CPv2_startAngle; }
            set
            {
                CPv2_startAngle = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress CircularProgressV2")]

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

        [Category("CircularProgress CircularProgressV2")]

        public int CPv2_Shift
        {
            get { return CPv2_shift; }
            set
            {
                CPv2_shift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV2")]

        public int CPv2_ProgressWidth
        {
            get { return CPv2_progressWidth; }
            set
            {
                CPv2_progressWidth = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV2")]

        public int CPv2_AngleReduced
        {
            get { return CPv2_angleReduced; }
            set
            {
                CPv2_angleReduced = value;
                Invalidate();
            }
        }

        #endregion

        #region Event

        private void CPv2_Timer_Tick(object sender, EventArgs e)
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

            if (CPv2_StartAngle + 1 > 300)
            {
                CPv2_StartAngle = -60;
            }

            else
            {
                CPv2_remainderAngle++;
                Invalidate();
            }


        }

        #endregion
        
        #region Paint Events
        
        private void CPv2_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;

            g.Clear(BackColor);
            
            Rectangle rect = new Rectangle(CPv2_Shift, CPv2_Shift, Width - CPv2_ProgressWidth, Height - CPv2_ProgressWidth);

            float percentage = Value;

            //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

            float progressAngle = Convert.ToSingle(360 * (percentage / Maximum));

            CPv2_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(CPv2_Color, CPv2_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(CPv2_ColorEmpty, CPv2_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, CPv2_StartAngle, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - CPv2_AngleReduced, CPv2_remainderAngle);
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
        
        private void DrawProgress(Graphics g, Rectangle rect, float percentage)
        {
            //work out the angles for each arc
            float progressAngle = Convert.ToSingle(360 / 100 * percentage);
            int CPv2_remainderAngle = 360 - Convert.ToInt32(progressAngle);

            //create pens to use for the arcs
            using (Pen progressPen = new Pen(CPv2_Color, CPv2_ProgressWidth))
            {
                using (Pen remainderPen = new Pen(CPv2_ColorEmpty, CPv2_ProgressWidth))
                {
                    //set the smoothing to high quality for better output
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //draw the blue and white arcs
                    g.DrawArc(progressPen, rect, -60, progressAngle);
                    g.DrawArc(remainderPen, rect, progressAngle - 90, CPv2_remainderAngle);
                }
            }

            //draw the text in the centre by working out how big it is and adjusting the co-ordinates accordingly
            using (Font fnt = new Font(this.Font.FontFamily, 14))
            {
                string text = percentage.ToString() + "%";
                dynamic textSize = g.MeasureString(text, fnt);
                Point textPoint = new Point(Convert.ToInt32(rect.Left + (rect.Width / 2) - (textSize.Width / 2)), Convert.ToInt32(rect.Top + (rect.Height / 2) - (textSize.Height / 2)));
                //now we have all the values draw the text
                g.DrawString(text, fnt, new SolidBrush(ForeColor), textPoint);
            }
        }

        #endregion

    }

    #endregion
}
