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
    #region Indicator Control

    public partial class ThematicProgress
    {

        #region Private Fields
        public float _GraphWidth = 33;
        private Color paintColor = Color.Black;
        private Color penColor = Color.Black;
        //Int32 _Maximum;

        //Int32 _Value;



        //private Color Color = Color.Black;

        //private Color BorderColor = Color.Black;
        #endregion

        #region Constructor

        public void ZeroitIndicator()
        {
            //SetStyle(
            //    ControlStyles.UserPaint |
            //    //ControlStyles.DoubleBuffer |
            //    ControlStyles.ResizeRedraw,
            //    true
            //    );
            //_Maximum = Int32.MaxValue;
            //_Minimum = 0;
            //_Value = 0;
            //_GraphWidth = 33;

            _GraphWidth = Size.Width - 3;
            

        }

        #endregion

        #region Public Properties


        [Category("RectangularProgress ZeroitExtendedProgress")]
        public float GraphWidth
        {
            get
            {
                return _GraphWidth;
            }
            set
            {
                _GraphWidth = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress ZeroitExtendedProgress")]
        public Color Color
        {
            get { return paintColor; }
            set
            {
                paintColor = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress ZeroitExtendedProgress")]
        public Color BorderColor
        {
            get { return penColor; }
            set
            {
                penColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Overrides

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x00000200; // WS_EX_CLIENTEDGE
        //        return cp;
        //    }
        //}


        private void ZeroitIndicator_Paint(PaintEventArgs e)
        {
            //Graphics graph = CreateGraphics();

            //Graphics graph = e.Graphics;

            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            e.Graphics.Clear(BackColor);

            SolidBrush b = new SolidBrush(Color);
            float w = this.ClientSize.Width;
            float h = this.ClientSize.Height;
            float y = h;
            // draw text
            y -= this.Font.Height + 4;
            RectangleF r = new RectangleF(0, y, w, h);
            StringFormat f = new StringFormat(StringFormatFlags.NoWrap);
            f.Alignment = StringAlignment.Center;
            //e.Graphics.DrawString(Convert.ToInt32(Value).ToString() + postFix, this.Font, b, r, f);

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

            // draw graph
            float graphheight = h - 6 - 4 - this.Font.Height - 4;
            graphheight += 1;
            float lines = graphheight / 3;
            Byte red = (Byte)(this.Color.R / 2);
            Byte green = (Byte)(this.Color.G / 2);
            Byte blue = (Byte)(this.Color.B / 2);
            Color dimmed = Color.FromArgb(red, green, blue);
            Pen dpen = new Pen(dimmed);
            Pen hpen = new Pen(this.BorderColor);
            dpen.DashStyle = DashStyle.Dot;
            float lx = (w - this.GraphWidth) / 2;
            float ly = h - 4 - this.Font.Height - 7;
            float lw = this.GraphWidth / 2;
            float x0 = lx;
            float y0 = 0;
            float x1 = 0;
            float y1 = 0;
            float linestohighlite = (this.Value - this.Minimum) * 1.0f /((this.Maximum - this.Minimum * 1.0f) / lines); 
                //(float)Math.Ceiling(
            //    (this.Value - this.Minimum) * 1.0 /
            //    ((this.Maximum - this.Minimum * 1.0) / lines)
            //    );
            for (float i = 0; i < lines; i++)
            {
                x0 = lx;
                y0 = ly - (i * 3) - 1;
                x1 = x0 + lw;
                y1 = y0;
                if (i < linestohighlite)
                {
                    e.Graphics.FillRectangle(b, x0, y0, lw, 2);
                    e.Graphics.FillRectangle(b, x1 + 1, y0, lw, 2);
                }
                else
                {
                    // left two lines
                    e.Graphics.DrawLine(dpen, x0, y0, x1, y1);
                    e.Graphics.DrawLine(dpen, x0 + 1, y0 + 1, x1, y1 + 1);
                    // right two lines
                    x0 = x1 + 1;
                    x1 = x0 + lw;
                    e.Graphics.DrawLine(dpen, x0, y0, x1, y1);
                    e.Graphics.DrawLine(dpen, x0 + 1, y0 + 1, x1, y1 + 1);
                }
            }
            //hpen.Dispose();
            //dpen.Dispose();
            //b.Dispose();
        }


        #endregion
        
        #region Event

        private void ZeroitIndicator_Timer_Tick(object sender, EventArgs e)
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





    }

    #endregion
}
