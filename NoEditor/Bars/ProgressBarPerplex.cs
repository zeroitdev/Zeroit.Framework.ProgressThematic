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
    #region ZeroitProgressBarPerplex

    public partial class ThematicProgress
    {

        

        #region Timer Event

        private void ProgressBarPerplex_Timer_Tick(object sender, EventArgs e)
        {

            if (this.Value + 1 > this.Maximum)
            {
                this.Value = 0;
            }

            else
            {
                this.Value++;
            }


            if (this.ColorGradientAngle + 1 > this.Maximum)
            {
                this.ColorGradientAngle = 0;
            }

            else
            {
                this.ColorGradientAngle++;
            }

        }

        #endregion

        #region Private Fields
        private Color Perplex_colorGradient1 = Color.FromArgb(26, 26, 26);
        private Color Perplex_colorGradient2 = Color.FromArgb(30, 30, 30);
        private Color Perplex_colorGradient3 = Color.FromArgb(174, 195, 30);
        private Color Perplex_colorGradient4 = Color.FromArgb(141, 153, 16);
        private Color colorPen = Color.FromArgb(97, 94, 90);
        private float colorGradientAngle = 90f;
        private bool _ShowPercentage = false;
        private perplex_DrawMode _perplex_DrawMode = perplex_DrawMode.Gradient;


        public enum perplex_DrawMode
        {
            Solid,
            Gradient,
            Hatch
        }


        #endregion

        #region Properties

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient1
        {
            get
            {
                return
                    Perplex_colorGradient1;
            }
            set
            {
                Perplex_colorGradient1 = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient2
        {
            get { return Perplex_colorGradient2; }
            set
            {
                Perplex_colorGradient2 = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient3
        {
            get { return Perplex_colorGradient3; }
            set
            {
                Perplex_colorGradient3 = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient4
        {
            get { return Perplex_colorGradient4; }
            set
            {
                Perplex_colorGradient4 = value;
                Invalidate();
            }
        }

        //public Color ColorHatchBrush1
        //{
        //    get { return ColorHatchBrushgradient1; }
        //    set
        //    {
        //        ColorHatchBrushgradient1 = value;
        //        Invalidate();
        //    }
        //}

        //public Color ColorHatchBrush2
        //{
        //    get { return ColorHatchBrushgradient2; }
        //    set
        //    {
        //        ColorHatchBrushgradient2 = value;
        //        Invalidate();
        //    }
        //}
        [Category("RectangularProgress Perplex")]
        public Color Perplex_BorderColor
        {
            get { return colorPen; }
            set
            {
                colorPen = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public float ColorGradientAngle
        {
            get { return colorGradientAngle; }
            set
            {
                colorGradientAngle = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public bool Perplex_ShowPercentage
        {
            get { return _ShowPercentage; }
            set
            {
                _ShowPercentage = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Perplex")]
        public perplex_DrawMode Perplex_DrawMode
        {
            get { return _perplex_DrawMode; }
            set
            {
                _perplex_DrawMode = value;
                Invalidate();

            }
        }

        #endregion

        public void ZeroitProgressBarPerplex()
        {
            

            
        }

        private void ProgressBarPerplex_Paint(PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = e.Graphics;
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            //Graphics Gtrans = Graphics.FromImage(B);

            G.Clear(BackColor);

            
            
            float val = Value / Maximum;
            int intValue = Convert.ToInt32(val * Width);

            if (intValue < 2)
            {
                intValue = 2;
            }


            Color C1 = Color.FromArgb(174, 195, 30);
            Color C2 = Color.FromArgb(141, 153, 16);
            Rectangle R1 = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle R2 = new Rectangle(0, 0, intValue - 1, Height - 1);
            Rectangle R3 = new Rectangle(0, 0, intValue - 1, Height - 2);
            GraphicsPath GP1 = Zeroit.Framework.ProgressThematic.Draw.RoundRect(R1, 1);
            GraphicsPath GP2 = Zeroit.Framework.ProgressThematic.Draw.RoundRect(R2, 2);
            GraphicsPath GP3 = Zeroit.Framework.ProgressThematic.Draw.RoundRect(R3, 1);

            //LinearGradientBrush gB = new LinearGradientBrush(R1, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90);
            LinearGradientBrush gB = new LinearGradientBrush(R1, Perplex_ColorGradient1, Perplex_ColorGradient2, ColorGradientAngle);
            LinearGradientBrush g1 = new LinearGradientBrush(new Rectangle(2, 2, intValue - 1, Height - 2), Perplex_ColorGradient3, Perplex_ColorGradient4, ColorGradientAngle);
            //HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(50, C1), Color.FromArgb(25, C2));
            HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
            Pen P1 = new Pen(Perplex_BorderColor);


            switch (Perplex_DrawMode)
            {
                case perplex_DrawMode.Solid:
                    G.FillRectangle(new SolidBrush(Perplex_ColorGradient1), R3);
                    break;
                case perplex_DrawMode.Gradient:
                    G.FillPath(gB, GP1);
                    G.FillPath(g1, GP3);
                    break;
                case perplex_DrawMode.Hatch:
                    #region HatchBrush Paint
                    switch (HatchBrush)
                    {
                        case ProgressThematic.ThematicProgress.HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB1, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB2, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB3, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB4, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB5, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB6, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB7, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB8, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB9, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBA, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBB, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBC, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBD, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBE, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBF, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBG, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBH, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBI, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBJ, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBK, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBL, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBM, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBN, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBO, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBP, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBQ, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBR, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBS, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBT, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBU, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBV, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBW, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBX, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBY, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HBZ, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB10, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB11, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB12, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB13, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB14, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB15, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB16, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB17, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB18, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB19, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB20, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB21, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB22, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB23, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB24, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB25, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB26, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB27, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB28, GP3);
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillPath(HB29, GP3);
                            break;
                        default:
                            break;
                    }
                    #endregion
                    break;
                
            }
            
            //G.FillPath(h1, GP3);
            G.DrawPath(P1, GP1);
            //G.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), GP2);
            G.DrawPath(new Pen(Perplex_BorderColor), GP2);
            G.DrawPath(P1, GP2);

            if (Perplex_ShowPercentage)
                G.DrawString(Convert.ToString(string.Concat(Value, PostFix)), Font, new SolidBrush(ForeColor), R1, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            //e.Graphics.DrawImage((Image)B.Clone(), 0, 0);

            
        }


    }


    


    #endregion
}
