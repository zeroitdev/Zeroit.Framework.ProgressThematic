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
    #region ZeroitProgressBarPie

    public partial class ThematicProgress
    {

        #region Enums

        public enum ProgressPie_ProgressShape
        {
            AnchorMask,
            ArrowAnchor,
            Custom,
            DiamondAnchor,
            Flat,
            NoAnchor,
            Round,
            RoundAnchor,
            Square,
            SquareAnchor,
            Triangle
        }

        #endregion


        #region Variables

        
        //private Color ProgressPie_ProgressColor1 = Color.DarkSlateGray;
        //private Color ProgressPie_ProgressColor2 = Color.DarkOrange;
        //private Color ProgressPie_FillEllipse1 = Color.Transparent;
        //private Color ProgressPie_FillEllipse2 = Color.Transparent;
        //private Color ProgressPie_TextColor = Color.Transparent;
        //private Color ProgressPie_InnerBorderColor = Color.Transparent;
        //private ProgressPie_ProgressShape ProgressPie__ProgressShape = ProgressPie_ProgressShape.DiamondAnchor;
        //private LineCap ProgressPie_WidthStartCap = LineCap.Flat;
        //private LineCap ProgressPie_WidthEndCap = LineCap.Flat;
        //private Double ProgressPie_ProgressWidth = 1f;
        //private float ProgressPie_InnerBorderWidth = 1f;
        //private float ProgressPie_progressWidthToFloat;
        //private bool ProgressPie_ShowText = true;

        //private float ProgressPie_Position = 180.0f;
        //private float ProgressPie_SweepAngle = 180.0f;

        #endregion

        #region Custom Properties

        [Category("CircularProgress ProgressPie")]
        public float ProgressPie_Position
        {
            get { return progressInput.ProgressPie_Position; }
            set
            {
                progressInput.ProgressPie_Position = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public float ProgressPie_SweepAngle
        {
            get { return progressInput.ProgressPie_SweepAngle; }
            set
            {
                progressInput.ProgressPie_SweepAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Boolean ProgressPie_ShowText
        {
            get { return progressInput.ProgressPie_ShowText; }
            set
            {
                if (value == false)
                {
                    this.ProgressPie_TextColor = Color.Transparent;
                }

                else
                {
                    this.ProgressPie_TextColor = Color.White;
                }
                progressInput.ProgressPie_ShowText = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public float ProgressPie_InnerBorderWidth
        {
            get { return progressInput.ProgressPie_InnerBorderWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                progressInput.ProgressPie_InnerBorderWidth = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_InnerBorderColor
        {
            get { return progressInput.ProgressPie_InnerBorderColor; }
            set
            {
                progressInput.ProgressPie_InnerBorderColor = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_TextColor
        {
            get { return progressInput.ProgressPie_TextColor; }
            set
            {
                progressInput.ProgressPie_TextColor = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public LineCap ProgressPie_WidthStartCap
        {
            get { return progressInput.ProgressPie_WidthStartCap; }
            set
            {
                if (progressInput.ProgressPie_WidthStartCap == null)
                {
                    progressInput.ProgressPie_WidthStartCap = LineCap.Flat;
                }
                progressInput.ProgressPie_WidthStartCap = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public LineCap ProgressPie_WidthEndCap
        {
            get { return progressInput.ProgressPie_WidthEndCap; }
            set
            {
                if (progressInput.ProgressPie_WidthEndCap == null)
                {
                    progressInput.ProgressPie_WidthEndCap = LineCap.Flat;
                }
                progressInput.ProgressPie_WidthEndCap = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// This changes the angle of gradient button
        /// </summary>
        [Description("This changes the angle of gradient button"),
        Browsable(true)]
        [Category("CircularProgress ProgressPie")]
        public Double ProgressPie_ProgressWidth
        {
            get { return progressInput.ProgressPie_ProgressWidth; }
            set
            {
                //if (progressInput.ProgressPie_ProgressWidth == null)
                //{
                //    progressInput.ProgressPie_ProgressWidth = 5f;
                //}

                progressInput.ProgressPie_ProgressWidth = value;
                //ProgressPie_progressWidthToFloat = ProgressPie_DoubleToFloat(progressInput.ProgressPie_ProgressWidth);

                this.Invalidate();
            }
        }
        //public long Value
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

        //public long Maximum
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

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_ProgressColor1
        {
            get { return progressInput.ProgressPie_ProgressColor1; }
            set
            {
                progressInput.ProgressPie_ProgressColor1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_ProgressColor2
        {
            get { return progressInput.ProgressPie_ProgressColor2; }
            set
            {
                progressInput.ProgressPie_ProgressColor2 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_FillEllipse1
        {
            get { return progressInput.ProgressPie_FillEllipse1; }
            set
            {
                progressInput.ProgressPie_FillEllipse1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ProgressPie")]
        public Color ProgressPie_FillEllipse2
        {
            get { return progressInput.ProgressPie_FillEllipse2; }
            set
            {
                progressInput.ProgressPie_FillEllipse2 = value;
                Invalidate();
            }
        }

        public ProgressPie_ProgressShape ProgressPie__ProgressShape
        {
            get { return progressInput.ProgressPie__ProgressShape; }
            set
            {
                progressInput.ProgressPie__ProgressShape = value;
                Invalidate();
            }
        }


        public static float ProgressPie_DoubleToFloat(double dValue)
        {
            if (float.IsPositiveInfinity(Convert.ToSingle(dValue)))
            {
                return float.MaxValue;
            }
            if (float.IsNegativeInfinity(Convert.ToSingle(dValue)))
            {
                return float.MinValue;
            }
            return Convert.ToSingle(dValue);
        }

        #endregion

        #region EventArgs

        private void ProgressPie_OnResize(EventArgs e)
        {
            
            ProgressPie_SetStandardSize();
        }

        private void ProgressPie_OnSizeChanged(EventArgs e)
        {
            ProgressPie_SetStandardSize();
        }


        #endregion
        
        public void ZeroitProgressBarPie()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

            //SetStyle(ControlStyles.SupportsTransparentBackColor, transparency);
            //BackColor = Color.Transparent;
            //Size = new Size(130, 130);
            //Font = new Font("Segoe UI", 15);
            //MinimumSize = new Size(10, 100);
            //DoubleBuffered = true;
            

            #region Zeroit AutoStartSpinner Code (Work in Progress)
            timerAnimationAutoSpin.Tick += new System.EventHandler(timerAnimationAutoSpin_Tick);
            if (AutoStartSpinner)
                timerAnimationAutoSpin.Start();
            #endregion


        }

        #region Timer

        

        private System.Windows.Forms.Timer timerAnimationAutoSpin = new System.Windows.Forms.Timer();
        private bool enableAutoSpin;
        private int _autoStartInterval = 100;

        
        public int AutoSpinStartInterval
        {
            get { return _autoStartInterval; }
            set
            {
                _autoStartInterval = value;
                timerAnimationAutoSpin.Interval = _autoStartInterval;
                Invalidate();
            }
        }

        
        public bool AutoStartSpinner
        {
            get { return enableAutoSpin; }
            set
            {
                if (value == true)
                {
                    timerAnimationAutoSpin.Enabled = true;
                }

                else
                {
                    timerAnimationAutoSpin.Enabled = false;
                    this.ProgressPie_Position = 180f;
                    //this.Text = Value.ToString();
                }

                enableAutoSpin = value;
                Invalidate();

            }
        }

        private void ProgressBarPie_Timer_Tick(object sender, EventArgs e)
        {
            if (Value + 1 > Maximum)
            {
                Value = 0;
            }

            else
            {
                Value++;
                Invalidate();
            }

        }

        private void timerAnimationAutoSpin_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                try
                {
                    Value += 1;
                    //Value = 100;
                    ProgressPie_Position += 10;
                    //Text = Value.ToString();

                    if (Value == Maximum)
                    {

                        Value = 0;
                        ProgressPie_Position = 0;
                    }
                }
                catch (Exception ex)
                {


                }
            }

            if (DesignMode)
            {
                try
                {
                    Value += 1;
                    ProgressPie_Position += 10;
                    //Text = Value.ToString();

                    if (Value == Maximum)
                    {
                        Value = 0;
                        ProgressPie_Position = 0;
                    }
                }
                catch (Exception ex)
                {


                }
            }

            //if (DesignMode)
            //{

            //}
        }

        #endregion

        private void ProgressPie_SetStandardSize()
        {
            int _Size = Math.Max(Width, Height);
            Size = new Size(_Size, _Size);
        }

        //public void Increment(int Val)
        //{
        //    this.Value += Val;
        //    Invalidate();
        //}

        public void Decrement(int Val)
        {
            this.Value -= Val;
            Invalidate();
        }

        private void ProgressPie_Paint(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(this.Width, this.Height);
            //Graphics graphics = Graphics.FromImage(bitmap);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = Smoothing;
            graphics.Clear(BackColor);

            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ProgressPie_ProgressColor1,
                this.ProgressPie_ProgressColor2, LinearGradientMode.ForwardDiagonal);

            Pen pen = new Pen(brush, (float)ProgressPie_ProgressWidth);


            switch (this.ProgressPie__ProgressShape)
            {
                case ProgressPie_ProgressShape.AnchorMask:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.ArrowAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Custom:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.DiamondAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Flat:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.NoAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Round:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.RoundAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Square:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.SquareAnchor:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                case ProgressPie_ProgressShape.Triangle:
                    pen.StartCap = ProgressPie_WidthStartCap;
                    pen.EndCap = ProgressPie_WidthEndCap;
                    break;

                default:
                    break;
            }
            try
            {
                graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, ProgressPie_Position, (int)Math.Round((double)((ProgressPie_SweepAngle / ((double)this.Maximum)) * this.Value)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add this code to the form constructor:  SetStyle(ControlStyles.SupportsTransparentBackColor, true);");
                throw;
            }

            LinearGradientBrush brush2 = new LinearGradientBrush(this.ClientRectangle, ProgressPie_FillEllipse1,
                ProgressPie_FillEllipse2, LinearGradientMode.Vertical);

            graphics.FillPie(brush2, 0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1, ProgressPie_Position, ProgressPie_SweepAngle);
            Pen BorderColor = new Pen(ProgressPie_InnerBorderColor, ProgressPie_InnerBorderWidth);
            graphics.DrawArc(BorderColor, new Rectangle(0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1), ProgressPie_Position /*90f*//*ProgressPie_SweepAngle / 2*/, ProgressPie_SweepAngle);

            SolidBrush TexTColor = new SolidBrush(ForeColor);
            SizeF MS = graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, TexTColor, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));

            //e.Graphics.DrawImage(bitmap, 0, 0);
            //graphics.Dispose();
            //bitmap.Dispose();

            
        }
        
    }


    

    #endregion
}
