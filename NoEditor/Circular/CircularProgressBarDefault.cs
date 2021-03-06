﻿#region Imports

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
    
    #region Circular ProgressBar Default

    public partial class ThematicProgress
    {

        #region Enums

        //public enum _ProgressShape
        //{
        //    Round,
        //    Flat
        //}

        #endregion

        #region Variables
        private Color CircularDef_ProgressColor1 = Color.FromArgb(92, 92, 92);
        private Color CircularDef_ProgressColor2 = Color.FromArgb(92, 92, 92);

        private Color CircularDef_InnerColor1 = Color.FromArgb(0x34, 0x34, 0x34);
        private Color CircularDef_InnerColor2 = Color.FromArgb(0x34, 0x34, 0x34);
        
        private _ProgressShape CircularDef_ProgressShapeVal = _ProgressShape.Round;

        #endregion

        #region Custom Properties

        //[Category("CircularProgress ZeroitProgressCircularDefault")]
        //public long CircularDefault_Value
        //{
        //    get { return Value; }
        //    set
        //    {
        //        if (value > Maximum)
        //            value = Maximum;
        //        Value = value;
        //        Invalidate();
        //    }
        //}

        //[Category("CircularProgress ZeroitProgressCircularDefault")]
        //public long CircularDefault_Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        if (value < 1)
        //            value = 1;
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress ZeroitProgressCircularDefault")]
        public Color ProgressColor1_Default
        {
            get { return CircularDef_ProgressColor1; }
            set
            {
                CircularDef_ProgressColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircularDefault")]
        public Color ProgressColor2_Default
        {
            get { return CircularDef_ProgressColor2; }
            set
            {
                CircularDef_ProgressColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircularDefault")]
        public _ProgressShape ProgressShape_Default
        {
            get { return CircularDef_ProgressShapeVal; }
            set
            {
                CircularDef_ProgressShapeVal = value;
                Invalidate();
            }
        }

        public Color ProgressInnerColor1_Default
        {
            get { return CircularDef_InnerColor1; }
            set
            {
                CircularDef_InnerColor1 = value;
                Invalidate();

            }
        }

        public Color ProgressInnerColor2_Default
        {
            get { return CircularDef_InnerColor2; }
            set
            {
                CircularDef_InnerColor2 = value;
                Invalidate();

            }
        }


        #endregion

        #region EventArgs





        #endregion

        //public void ZeroitProgressBarCircularDefault()
        //{
        //    Size = new Size(130, 130);
        //    Font = new Font("Segoe UI", 15);
        //    MinimumSize = new Size(100, 100);
        //    DoubleBuffered = true;
        //}


        //public void Increment(int Val)
        //{
        //    this.Value += Val;
        //    Invalidate();
        //}

        //public void Decrement(int Val)
        //{
        //    this.Value -= Val;
        //    Invalidate();
        //}

        private void CircularDef_Timer_Tick(object sender, EventArgs e)
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


        private void ZeroitProgressBarCircularDefault_Paint(PaintEventArgs e)
        {
            
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = Smoothing;
            graphics.TextRenderingHint = TextRendering;

            graphics.Clear(this.BackColor);
            
            LinearGradientBrush brush =
                new LinearGradientBrush(this.ClientRectangle,
                    this.ProgressColor1_Default, this.ProgressColor2_Default,
                    LinearGradientMode.ForwardDiagonal);

            Pen pen = new Pen(brush, 10f);

            LinearGradientBrush brush2 = new LinearGradientBrush(this.ClientRectangle, ProgressInnerColor1_Default,
                ProgressInnerColor2_Default, LinearGradientMode.Vertical);

            switch (this.ProgressShape_Default)
            {
                case _ProgressShape.Round:
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    break;

                case _ProgressShape.Flat:
                    pen.StartCap = LineCap.Flat;
                    pen.EndCap = LineCap.Flat;
                    break;
            }

            graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, -90, (int)Math.Round((float)((360.0 / ((float)this.Maximum)) * this.Value)));

            
            graphics.FillEllipse(brush2, 0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1);
                    
            SizeF MS = graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, Brushes.White, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));

            e.Graphics.DrawImage(bitmap, 0, 0);
            
            //graphics.Dispose();
            //bitmap.Dispose();
            
        }
        

    }


    


    #endregion
    
}
