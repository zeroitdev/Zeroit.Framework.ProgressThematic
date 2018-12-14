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
    #region Circular ProgressBar


    public partial class ThematicProgress
    {

        #region Enums

        public enum _ProgressShape
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

        
        //private Color Color1_Progress = Color.FromArgb(92, 92, 92);
        //private Color Color2_Progress = Color.FromArgb(92, 92, 92);
        //private Color Color3_FillEllipse = Color.Black;
        //private Color Color4_FillEllipse = Color.Gray;
        //private Color Color6_TextColor = Color.White;
        //private Color Color5_ProgressInnerBorder = Color.Transparent;
        //private _ProgressShape ProgressShapeVal;
        //private LineCap ProgressWidthStartCap = LineCap.Flat;
        //private LineCap ProgressWidthEndCap = LineCap.Flat;
        //private Double ProgressWidth = 5f;
        //private float ProgressInnerBorderWidth = 1f;
        //private SmoothingMode smoothing = SmoothingMode.HighQuality;
        //private float _ProgressWidthToFloat;
        //private bool ShowText = true;

        //private bool Transparent = false;


        #endregion

        #region Custom Properties

        [Category("CircularProgress ZeroitProgressCircular")]
        public _ProgressShape ProgressShapeVal
        {
            get { return progressInput.ProgressShapeVal; }
            set
            {
                progressInput.ProgressShapeVal = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Boolean Transparent
        {
            get { return progressInput.Transparent; }
            set
            {
                progressInput.Transparent = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Boolean Percentage_Text
        {
            get { return progressInput.ShowText; }
            set
            {
                if (value == false)
                {
                    this.Color6_TextColor = Color.Transparent;
                }

                else
                {
                    this.Color6_TextColor = Color.White;
                }
                this.progressInput.ShowText = value;
                this.Invalidate();
            }
        }

        

        [Category("CircularProgress ZeroitProgressCircular")]
        public float ProgressInnerBorderWidth
        {
            get { return progressInput.ProgressInnerBorderWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                progressInput.ProgressInnerBorderWidth = value;
                this.Invalidate();
            }
        }

        //[Category("CircularProgress ZeroitProgressCircular")]
        //public SmoothingMode Smoothing
        //{
        //    get { return this.smoothing; }
        //    set
        //    {
        //        this.smoothing = value;
        //        this.Invalidate();
        //    }
        //}

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color5_ProgressInnerBorder
        {
            get { return progressInput.Color5_ProgressInnerBorder; }
            set
            {
                progressInput.Color5_ProgressInnerBorder = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color6_TextColor
        {
            get { return progressInput.Color6_TextColor; }
            set
            {
                progressInput.Color6_TextColor = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public LineCap ProgressWidthStartCap
        {
            get { return progressInput.ProgressWidthStartCap; }
            set
            {
                if (progressInput.ProgressWidthStartCap == null)
                {
                    progressInput.ProgressWidthStartCap = LineCap.Flat;
                }
                progressInput.ProgressWidthStartCap = value;
                this.Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public LineCap ProgressWidthEndCap
        {
            get { return progressInput.ProgressWidthEndCap; }
            set
            {
                if (progressInput.ProgressWidthEndCap == null)
                {
                    progressInput.ProgressWidthEndCap = LineCap.Flat;
                }
                progressInput.ProgressWidthEndCap = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// This changes the angle of gradient button
        /// </summary>
        [Description("This changes the angle of gradient button"),
        Browsable(true)]
        [Category("CircularProgress ZeroitProgressCircular")]
        public Double ProgressWidth
        {
            get { return progressInput.ProgressWidth; }
            set
            {
                //if (progressInput.ProgressWidth == null)
                //{
                //    progressInput.ProgressWidth = 5f;
                //}

                progressInput.ProgressWidth = value;
                //_ProgressWidthToFloat = DoubleToFloat(ProgressWidth);

                this.Invalidate();
            }
        }

        

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color1_Progress
        {
            get { return progressInput.Color1_Progress; }
            set
            {
                progressInput.Color1_Progress = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color2_Progress
        {
            get { return progressInput.Color2_Progress; }
            set
            {
                progressInput.Color2_Progress = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color3_FillEllipse
        {
            get { return progressInput.Color3_FillEllipse; }
            set
            {
                progressInput.Color3_FillEllipse = value;
                Invalidate();
            }
        }

        [Category("CircularProgress ZeroitProgressCircular")]
        public Color Color4_FillEllipse
        {
            get { return progressInput.Color4_FillEllipse; }
            set
            {
                progressInput.Color4_FillEllipse = value;
                Invalidate();
            }
        }

        

        public static float DoubleToFloat(double dValue)
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
        

        #region Constructor
        public void ZeroitProgressBarCircular()
        {
            //SetStyle(//ControlStyles.AllPaintingInWmPaint | 
            //    //ControlStyles.OptimizedDoubleBuffer | 
            //    //ControlStyles.ResizeRedraw | 
            //    ControlStyles.SupportsTransparentBackColor //| 
            //    /*ControlStyles.UserPaint*/, true);

            
            //Size = new Size(130, 130);
            //Font = new Font("Segoe UI", 15);
            //MinimumSize = new Size(10, 100);
            //DoubleBuffered = true;
            //smoothing = SmoothingMode.HighQuality;

            
        }
        #endregion

        #region Private Methods
        
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

        #endregion

        #region Overrides
        

        protected void ZeroitProgressCircular_Paint(PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            //Graphics graphics = e.Graphics;

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(BackColor);

            graphics.TextRenderingHint = TextRendering;

            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.Color1_Progress,
                this.Color2_Progress, LinearGradientMode.ForwardDiagonal);

            Pen pen = new Pen(brush, (float)ProgressWidth);

            LinearGradientBrush brush2 = new LinearGradientBrush(this.ClientRectangle, Color3_FillEllipse, Color4_FillEllipse,
                LinearGradientMode.Vertical);


            switch (this.ProgressShapeVal)
                            {
                                case _ProgressShape.AnchorMask:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.ArrowAnchor:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.Custom:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.DiamondAnchor:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.Flat:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.NoAnchor:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.Round:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.RoundAnchor:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.Square:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.SquareAnchor:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                case _ProgressShape.Triangle:
                                    pen.StartCap = ProgressWidthStartCap;
                                    pen.EndCap = ProgressWidthEndCap;
                                    break;

                                default:
                                    break;
                            }

            try

            {

                graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, -90, (int)Math.Round((double)((360.0 / ((double)this.Maximum)) * this.Value)));
                
            }

            catch (Exception ex)

            {
                                
                //MessageBox.Show("Add this code to the form constructor:  SetStyle(ControlStyles.SupportsTransparentBackColor, true);");
                                throw;
                
            }
            
            
            graphics.FillEllipse(brush2, 0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1);
            Pen BorderColor = new Pen(Color5_ProgressInnerBorder, ProgressInnerBorderWidth);
            graphics.DrawArc(BorderColor, new Rectangle(0x18, 0x18, (this.Width - 0x30) - 1, (this.Height - 0x30) - 1), 0f, 360f);

               
            SolidBrush TexTColor = new SolidBrush(Color6_TextColor);
            SizeF MS = graphics.MeasureString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)), Font);

            if(ShowText)
                graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, TexTColor, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));
            
            e.Graphics.DrawImage(bitmap, 0, 0);
            //graphics.Dispose();
            //bitmap.Dispose();
                
        }

        #endregion


        






    }


    

    #endregion
}
