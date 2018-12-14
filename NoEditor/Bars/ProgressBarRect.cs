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


    #region  ZeroitProgressBarRect

    public partial class ThematicProgress
    {

        #region  RoundRect

        private GraphicsPath ProgressRect_CreateRoundPath;

        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            ProgressRect_CreateRoundPath = new GraphicsPath(FillMode.Winding);
            ProgressRect_CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0.0F, 90.0F);
            ProgressRect_CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90.0F, 90.0F);
            ProgressRect_CreateRoundPath.CloseFigure();
            return ProgressRect_CreateRoundPath;
        }

        #endregion
        
        #region Private Fields
        private float ProgressRect_percent;
        private Color ProgressRect_valueColour = Color.FromArgb(42, 119, 220);
        private Color ProgressRect_colorBackground = Color.FromArgb(51, 52, 55);
        private Color ProgressRect_colorBorder = Color.FromArgb(51, 52, 55);
        private int ProgressRect_corner = 8;

        private Color[] interpolateColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        #endregion

        #region  Custom Properties

        [Category("RectangularProgress ProgressRect")]
        public int ProgressRect_Corner
        {
            get { return ProgressRect_corner; }
            set
            {
                ProgressRect_corner = value;
                this.Invalidate();
            }
        }
        
        [Category("RectangularProgress ProgressRect")]
        public Color ProgressRect_ValueColour
        {
            get
            {
                return ProgressRect_valueColour;
            }
            set
            {
                ProgressRect_valueColour = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress ProgressRect")]
        public Color ProgressRect_ColorBackground
        {
            get { return ProgressRect_colorBackground; }
            set
            {
                ProgressRect_colorBackground = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress ProgressRect")]
        public Color ProgressRect_ColorBorder
        {
            get { return ProgressRect_colorBorder; }
            set
            {
                ProgressRect_colorBorder = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress ProgressRect")]
        public Color[] InterpolateColors
        {
            get { return interpolateColors; }
            set
            {
                interpolateColors = value;
                Invalidate();
            }
        }

        #endregion

        
        #region Event

        private void ProgressRect_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
                this.Value = 0;
            else
                this.Value++;
        }

        #endregion


        public void ZeroitProgressBarRect()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Transparent;
            //DoubleBuffered = true;
            //Size = new Size(100, 10);

            
        }

        
        private void ProgressRect_Paint(System.Windows.Forms.PaintEventArgs e)
        {
            
            Graphics G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            G.Clear(BackColor);

            this.ProgressRect_percent = this.Value / this.Maximum * 100;

            int Slope = ProgressRect_Corner;
            Rectangle MyRect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath BorderPath = CreateRound(MyRect, Slope);
            G.FillPath(new SolidBrush(ProgressRect_ColorBackground), BorderPath);

            ColorBlend ProgressBlend = new ColorBlend(3);
            ProgressBlend.Colors[0] = ProgressRect_ValueColour;
            ProgressBlend.Colors[1] = ProgressRect_ValueColour;
            ProgressBlend.Colors[2] = ProgressRect_ValueColour;
            ProgressBlend.Positions = new Single[] { 0, 0.5F, 1 };
            LinearGradientBrush LGB = new LinearGradientBrush(MyRect, InterpolateColors[0], InterpolateColors[1], 90.0F);
            LGB.InterpolationColors = ProgressBlend;

            Rectangle ProgressRect = new Rectangle(1, 1, (int)Math.Round(((double)this.Width / (double)this.Maximum * (double)this.Value - 3.0)), this.Height - 3);
            GraphicsPath ProgressPath = CreateRound(ProgressRect, Slope);

            if (ProgressRect_percent >= 1)
            {
                G.FillPath(LGB, ProgressPath);
            }

            try
            {
                G.DrawPath(new Pen(ProgressRect_ColorBorder), BorderPath);
            }
            catch (Exception)
            {
            }

            if(ShowText)
            Helper.CenterString(e.Graphics, ProgressRect_percent.ToString() + PostFix, Font, new SolidBrush(ForeColor),
                this.ClientRectangle);
        }
        
    }


    


    #endregion


}
