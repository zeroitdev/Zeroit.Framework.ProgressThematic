// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBar.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region Circular ProgressBar


    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Enums

        /// <summary>
        /// Enum _ProgressShape
        /// </summary>
        public enum _ProgressShape
        {
            /// <summary>
            /// The anchor mask
            /// </summary>
            AnchorMask,
            /// <summary>
            /// The arrow anchor
            /// </summary>
            ArrowAnchor,
            /// <summary>
            /// The custom
            /// </summary>
            Custom,
            /// <summary>
            /// The diamond anchor
            /// </summary>
            DiamondAnchor,
            /// <summary>
            /// The flat
            /// </summary>
            Flat,
            /// <summary>
            /// The no anchor
            /// </summary>
            NoAnchor,
            /// <summary>
            /// The round
            /// </summary>
            Round,
            /// <summary>
            /// The round anchor
            /// </summary>
            RoundAnchor,
            /// <summary>
            /// The square
            /// </summary>
            Square,
            /// <summary>
            /// The square anchor
            /// </summary>
            SquareAnchor,
            /// <summary>
            /// The triangle
            /// </summary>
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
        //private _ProgressShape progressShapeVal;
        //private LineCap ProgressWidthStartCap = LineCap.Flat;
        //private LineCap ProgressWidthEndCap = LineCap.Flat;
        //private Double ProgressWidth = 5f;
        //private float ProgressInnerBorderWidth = 1f;
        //private SmoothingMode smoothing = SmoothingMode.HighQuality;
        /// <summary>
        /// The progress width to float
        /// </summary>
        private float _ProgressWidthToFloat;
        //private bool Percentage_Text = true;

        //private bool Transparent = false;


        #endregion

        #region Custom Properties
        /// <summary>
        /// Gets or sets the progress shape value.
        /// </summary>
        /// <value>The progress shape value.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public _ProgressShape ProgressShapeVal
        {
            get { return progressInput.ProgressShapeVal; }
            set
            {
                progressInput.ProgressShapeVal = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the transparent.
        /// </summary>
        /// <value>The transparent.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Boolean Transparent
        {
            get { return progressInput.Transparent; }
            set
            {
                progressInput.Transparent = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the percentage text.
        /// </summary>
        /// <value>The percentage text.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Boolean Percentage_Text
        {
            get { return progressInput.Percentage_Text; }
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
                progressInput.Percentage_Text = value;
                this.Invalidate();
            }
        }



        /// <summary>
        /// Gets or sets the width of the progress inner border.
        /// </summary>
        /// <value>The width of the progress inner border.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
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
        //[Browsable(false)]
        //public SmoothingMode Smoothing
        //{
        //    get { return this.smoothing; }
        //    set
        //    {
        //        this.smoothing = value;
        //        this.Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the color5 progress inner border.
        /// </summary>
        /// <value>The color5 progress inner border.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color5_ProgressInnerBorder
        {
            get { return progressInput.Color5_ProgressInnerBorder; }
            set
            {
                progressInput.Color5_ProgressInnerBorder = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the color6 text.
        /// </summary>
        /// <value>The color of the color6 text.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color6_TextColor
        {
            get { return progressInput.Color6_TextColor; }
            set
            {
                progressInput.Color6_TextColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress width start cap.
        /// </summary>
        /// <value>The progress width start cap.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
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

        /// <summary>
        /// Gets or sets the progress width end cap.
        /// </summary>
        /// <value>The progress width end cap.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
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
        /// <value>The width of the progress.</value>
        [Description("This changes the angle of gradient button")]
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Double ProgressWidth
        {
            get { return progressInput.ProgressWidth; }
            set
            {
                if (value < 1)
                {
                    progressInput.ProgressWidth = 5f;
                }

                progressInput.ProgressWidth = value;
                //_ProgressWidthToFloat = DoubleToFloat(progressInput.ProgressWidth);

                this.Invalidate();
            }
        }



        /// <summary>
        /// Gets or sets the color1 progress.
        /// </summary>
        /// <value>The color1 progress.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color1_Progress
        {
            get { return progressInput.Color1_Progress; }
            set
            {
                progressInput.Color1_Progress = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color2 progress.
        /// </summary>
        /// <value>The color2 progress.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color2_Progress
        {
            get { return progressInput.Color2_Progress; }
            set
            {
                progressInput.Color2_Progress = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color3 fill ellipse.
        /// </summary>
        /// <value>The color3 fill ellipse.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color3_FillEllipse
        {
            get { return progressInput.Color3_FillEllipse; }
            set
            {
                progressInput.Color3_FillEllipse = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color4 fill ellipse.
        /// </summary>
        /// <value>The color4 fill ellipse.</value>
        [Category("CircularProgress ZeroitProgressCircular")]
        [Browsable(false)]
        public Color Color4_FillEllipse
        {
            get { return progressInput.Color4_FillEllipse; }
            set
            {
                progressInput.Color4_FillEllipse = value;
                Invalidate();
            }
        }



        /// <summary>
        /// Doubles to float.
        /// </summary>
        /// <param name="dValue">The d value.</param>
        /// <returns>System.Single.</returns>
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


        /// <summary>
        /// Zeroits the progress circular paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected void ZeroitProgressCircular_Paint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //Graphics graphics = e.Graphics;

            //graphics.SmoothingMode = Smoothing;
            //graphics.TextRenderingHint = TextRendering;

            //graphics.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, graphics);
            }

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

                graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, -90, (int)System.Math.Round((double)((360.0 / ((double)this.Maximum)) * this.Value)));
                
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
            
            //e.Graphics.DrawImage(bitmap, 0, 0);

            //brush.Dispose();
            //pen.Dispose();
            //brush2.Dispose();
            //BorderColor.Dispose();
            //TexTColor.Dispose();
            //graphics.Dispose();
            //bitmap.Dispose();

        }

        /// <summary>
        /// Zeroits the progress circular paint.
        /// </summary>
        /// <param name="e">The e.</param>
        private void ZeroitProgressCircular_Paint(Graphics e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics graphics = Graphics.FromImage(bitmap);

            //Graphics graphics = e.Graphics;

            graphics.SmoothingMode = Smoothing;
            graphics.TextRenderingHint = TextRendering;

            graphics.Clear(BackColor);

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

                graphics.DrawArc(pen, 0x12, 0x12, (this.Width - 0x23) - 2, (this.Height - 0x23) - 2, -90, (int)System.Math.Round((double)((360.0 / ((double)this.Maximum)) * this.Value)));

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

            if (ShowText)
                graphics.DrawString(Convert.ToString(Convert.ToInt32((100 / Maximum) * Value)) + PostFix, Font, TexTColor, Convert.ToInt32(Width / 2 - MS.Width / 2), Convert.ToInt32(Height / 2 - MS.Height / 2));

            e.DrawImage(bitmap, 0, 0);

            //brush.Dispose();
            //pen.Dispose();
            //brush2.Dispose();
            //BorderColor.Dispose();
            //TexTColor.Dispose();
            //graphics.Dispose();
            //bitmap.Dispose();

        }

        #endregion


    }




    #endregion
}
