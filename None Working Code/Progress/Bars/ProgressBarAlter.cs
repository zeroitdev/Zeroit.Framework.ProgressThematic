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
using Zeroit.Framework.Functions;
using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic
{


    #region ZeroitProgressBarAlter

    public partial class ThematicProgress
    {
        
        #region  Private Fields
        //private Color ProgressAlter_ColorBack = Color.FromArgb(210, 210, 210);
        //private Color ProgressAlter_ColorBorder = Color.FromArgb(150, 150, 150);
        //private Color ProgressAlter_ColorText = Color.FromArgb(100, 100, 100);
        //private Color ProgressAlter_ColorInside = Color.FromArgb(200, 200, 200);
        //private Color ProgressAlter_ColorIC = Color.FromArgb(215, 215, 215);
        //private Color ProgressAlter_Color1 = Color.FromArgb(220, 220, 220);
        //private Color Color2 = Color.FromArgb(200, 200, 200);

        //private float ProgressAlter_ColorAngle = 90F;

        private Graphics G;
        
        //private int _Value;
        //private bool ShowValue = false;

        //Brush BT;
        //Pen IB, PB;
        //Color BG, IC;

        //private Orientation ProgressAlter_Orientation;

        #endregion

        #region Properties

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorBack
        {
            get { return progressInput.ProgressAlter_ColorBack; }
            set
            {
                progressInput.ProgressAlter_ColorBack = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorBorder
        {
            get { return progressInput.ProgressAlter_ColorBorder; }
            set
            {
                progressInput.ProgressAlter_ColorBorder = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorText
        {
            get { return progressInput.ProgressAlter_ColorText; }
            set
            {
                progressInput.ProgressAlter_ColorText = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorInside
        {
            get { return progressInput.ProgressAlter_ColorInside; }
            set
            {
                progressInput.ProgressAlter_ColorInside = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_ColorIC
        {
            get { return progressInput.ProgressAlter_ColorIC; }
            set
            {
                progressInput.ProgressAlter_ColorIC = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color ProgressAlter_Color1
        {
            get { return progressInput.ProgressAlter_Color1; }
            set
            {
                progressInput.ProgressAlter_Color1 = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Color Color2
        {
            get { return progressInput.Color2; }
            set
            {
                progressInput.Color2 = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public float ProgressAlter_ColorAngle
        {
            get { return progressInput.ProgressAlter_ColorAngle; }
            set
            {
                progressInput.ProgressAlter_ColorAngle = value;
                this.Invalidate();
            }
        }

        [Category("RectangularProgress Alter")]
        public Orientation ProgressAlter_Orientation
        {
            get { return progressInput.ProgressAlter_Orientation; }
            set
            {
                progressInput.ProgressAlter_Orientation = value;
                Invalidate();
            }
        }
        

        [Description("Indicates if the value of the progress bar will be shown in the middle of it.")]
        [Category("RectangularProgress Alter")]
        public bool ShowValue
        {
            get { return progressInput.ShowValue; }
            set
            {
                progressInput.ShowValue = value;
                Invalidate();
            }
        }

        #endregion

        
        private void ProgressAlter_Paint(PaintEventArgs e)
        {
            
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            
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
