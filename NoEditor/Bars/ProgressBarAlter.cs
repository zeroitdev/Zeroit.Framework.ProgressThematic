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

using Zeroit.Framework.ProgressThematic;

#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{


    #region ZeroitProgressBarAlter

    public partial class ThematicProgress
    {
        
        #region  Private Fields
        
        private Graphics G;

        private Color colorBack = Color.FromArgb(210, 210, 210);
        private Color colorBorder = Color.FromArgb(150, 150, 150);
        private Color colorText = Color.FromArgb(100, 100, 100);
        private Color colorInside = Color.FromArgb(200, 200, 200);
        private Color colorIC = Color.FromArgb(215, 215, 215);
        private Color color1 = Color.FromArgb(220, 220, 220);
        private Color color2 = Color.FromArgb(200, 200, 200);

        private float colorAngle = 90F;

        private bool _ShowValue = false;

        private Orientation _Orientation = System.Windows.Forms.Orientation.Horizontal;

        #endregion

        #region Properties

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorBack
        {
            get { return colorBack; }
            set
            {
                colorBack = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorBorder
        {
            get { return colorBorder; }
            set
            {
                colorBorder = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorText
        {
            get { return colorText; }
            set
            {
                colorText = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorInside
        {
            get { return colorInside; }
            set
            {
                colorInside = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorIC
        {
            get { return colorIC; }
            set
            {
                colorIC = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_Color1
        {
            get { return color1; }
            set
            {
                color1 = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color Color2
        {
            get { return color2; }
            set
            {
                color2 = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public float ProgressAlter_ColorAngle
        {
            get { return colorAngle; }
            set
            {
                colorAngle = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Orientation ProgressAlter_Orientation
        {
            get { return _Orientation; }
            set
            {
                _Orientation = value;
                Invalidate();
            }
        }
        

        [Description("Indicates if the value of the progress bar will be shown in the middle of it.")]
        [Category("RectangularProgress Alter")]
        public bool ShowValue
        {
            get { return _ShowValue; }
            set
            {
                _ShowValue = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint Event

        private void ProgressAlter_Paint(PaintEventArgs e)
        {

            G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            switch (ProgressAlter_Orientation)
            {
                case System.Windows.Forms.Orientation.Horizontal:

                    float area = ((Value * (Width - 6)) / Maximum);
                    G.Clear(ProgressAlter_ColorBack);
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), ProgressAlter_Color1, Color2, ProgressAlter_ColorAngle);

                    if (Value == Maximum)
                    {
                        G.FillRectangle(LGB1, new Rectangle(3, 3, Width - 4, Height - 4));

                        DrawBorders(new Pen(ProgressAlter_ColorBorder), 30);
                    }

                    else if (Value == Minimum)
                    {

                    }

                    else
                    {
                        G.FillRectangle(LGB1, new Rectangle(3, 3, (int)area, Height - 4));
                        G.DrawRectangle(new Pen(ProgressAlter_ColorBorder), new Rectangle(3, 3, (int)area - 1, Height - 7));
                    }
                    if (ShowValue)
                    {
                        string val = Value.ToString();
                        DrawText(new SolidBrush(ForeColor), val, HorizontalAlignment.Center, 0, 0);
                    }

                    break;

                case System.Windows.Forms.Orientation.Vertical:

                    float area2 = ((Value * (Height - 6)) / Maximum);

                    G.Clear(ProgressAlter_ColorBack);
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), ProgressAlter_Color1, Color2, 90F);

                    if (Value == Maximum)
                    {
                        G.FillRectangle(LGB2, new Rectangle(3, 3, Width - 4, Height - 4));
                        DrawBorders(new Pen(ProgressAlter_ColorBorder), 3);
                    }
                    else if (Value == Minimum)
                    {

                    }

                    else
                    {
                        G.FillRectangle(LGB2, new Rectangle(3, 3, Width - 4, (int)area2));
                        G.DrawRectangle(new Pen(ProgressAlter_ColorBorder), new Rectangle(3, 3, Width - 7, (int)area2));
                    }
                    if (ShowValue)
                    {
                        string val = Value.ToString();
                        DrawText(new SolidBrush(ForeColor), val, HorizontalAlignment.Center, 0, 0);
                    }

                    break;
            }

            DrawBorders(new Pen(ProgressAlter_ColorInside));
            DrawBorders(new Pen(ProgressAlter_ColorBorder), 1);
        }

        #endregion
        
        #region Event

        private void ProgressAlter_Timer_Tick(object sender, EventArgs e)
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
        }

        #endregion

        
    }


    

    #endregion


}
