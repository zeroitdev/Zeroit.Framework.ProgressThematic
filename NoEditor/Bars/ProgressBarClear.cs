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
    #region ZeroitProgressBarClear

    public partial class ThematicProgress 
    {
        #region Private Fields


        private Color ProgressBarClear_glow = Color.FromArgb(230, 230, 230);
        private Color ProgressBarClear_edge = Color.FromArgb(170, 170, 170);
        private Color ProgressBarClear_gradient1 = Color.FromArgb(230, 230, 230);
        private Color ProgressBarClear_gradient2 = Color.FromArgb(210, 210, 210);
        private coloringMode _coloringMode = coloringMode.Hatch;


        public enum coloringMode
        {
            Solid,
            Gradient,
            Hatch
        }


        int GlowPosition;

        #endregion

        #region Properties

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGlow
        {
            get { return ProgressBarClear_glow; }
            set
            {
                ProgressBarClear_glow = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorBorder
        {
            get { return ProgressBarClear_edge; }
            set
            {
                ProgressBarClear_edge = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient1
        {
            get { return ProgressBarClear_gradient1; }
            set
            {
                ProgressBarClear_gradient1 = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient2
        {
            get { return ProgressBarClear_gradient2; }
            set
            {
                ProgressBarClear_gradient2 = value;
                Invalidate();
            }
        }

        [Category("RectangularProgress Clear")]
        public coloringMode Mode
        {
            get { return _coloringMode; }
            set
            {
                _coloringMode = value;
                Invalidate();
            }
        }
        
        //public int Minimum
        //{
        //    get { return _Minimum; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Minimum = value;
        //        if (value > _Value)
        //            _Value = value;
        //        if (value > _Maximum)
        //            _Maximum = value;
        //        Invalidate();
        //    }
        //}
        //public int Maximum
        //{
        //    get { return _Maximum; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Maximum = value;
        //        if (value < _Value)
        //            _Value = value;
        //        if (value < _Minimum)
        //            _Minimum = value;
        //        Invalidate();
        //    }
        //}
        //public bool Animated
        //{
        //    get { return IsAnimated; }
        //    set
        //    {
        //        IsAnimated = value;
        //        Invalidate();
        //    }
        //}
        //public int Value
        //{
        //    get { return _Value; }
        //    set
        //    {
        //        if (value > _Maximum || value < _Minimum)
        //        {
        //            throw new Exception("Property value is not valid.");
        //        }

        //        _Value = value;
        //        Invalidate();
        //    }
        //}
        //public ProgressThematic.ThematicProgress.HatchBrushType HatchBrush
        //{
        //    get
        //    {
        //        return hatchBrushType;
        //    }

        //    set
        //    {
        //        hatchBrushType = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        public void ZeroitProgressBarClear()
        {
            
        }
        

        //protected override void OnAnimation()
        //{
        //    if (GlowPosition == 0)
        //    {
        //        GlowPosition = 7;
        //    }
        //    else
        //    {
        //        GlowPosition -= 1;
        //    }
        //}

        private void ProgressBarClear_Paint(PaintEventArgs e)
        {
            G = e.Graphics;

            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;

            G.Clear(ProgressBarClear_ColorGradient1);

            Rectangle rectangle = new Rectangle(0, 0,
                (int) (Helper.ValueToPercentage((int) Value, (int) Maximum, (int) Minimum) * Width), Height);

            //g.FillRectangle(l, new Rectangle(0, 0, (int)(Helper.ValueToPercentage((int)Value, (int)Maximum, (int)Minimum) * Width), Height));

            switch (Mode)
            {
                case coloringMode.Solid:
                    G.FillRectangle(new SolidBrush(ProgressBarClear_ColorGlow), new Rectangle(new Point(1, 1), new Size(((int)Value / (int)Maximum) * Width - 1, (Height / 2) - 3)));

                    break;
                case coloringMode.Gradient:
                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)), ProgressBarClear_ColorGradient1, ProgressBarClear_ColorGradient2, 90f);
                    G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(((int)Value / (int)Maximum) * Width - 1, Height - 2)));

                    break;
                case coloringMode.Hatch:

                    switch (HatchBrush)
                    {
                        case ProgressThematic.ThematicProgress.HatchBrushType.BackwardDiagonal:
                            HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Cross:
                            HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB1, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkDownwardDiagonal:
                            HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB2, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkHorizontal:
                            HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB3, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkUpwardDiagonal:
                            HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB4, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DarkVertical:
                            HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB5, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedDownwardDiagonal:
                            HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB6, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedHorizontal:
                            HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB7, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedUpwardDiagonal:
                            HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB8, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DashedVertical:
                            HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB9, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalBrick:
                            HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBA, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalCross:
                            HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBB, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Divot:
                            HatchBrush HBC = new HatchBrush(HatchStyle.Divot, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBC, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DottedDiamond:
                            HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBD, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.DottedGrid:
                            HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBE, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.ForwardDiagonal:
                            HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBF, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Horizontal:
                            HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBG, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.HorizontalBrick:
                            HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBH, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeCheckerBoard:
                            HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBI, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeConfetti:
                            HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBJ, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LargeGrid:
                            HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBK, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightDownwardDiagonal:
                            HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBL, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightHorizontal:
                            HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBM, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightUpwardDiagonal:
                            HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBN, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.LightVertical:
                            HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBO, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Max:
                            HatchBrush HBP = new HatchBrush(HatchStyle.Max, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBP, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Min:
                            HatchBrush HBQ = new HatchBrush(HatchStyle.Min, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBQ, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.NarrowHorizontal:
                            HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBR, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.NarrowVertical:
                            HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBS, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.OutlinedDiamond:
                            HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBT, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent05:
                            HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBU, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent10:
                            HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBV, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent20:
                            HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBW, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent25:
                            HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBX, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent30:
                            HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBY, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent40:
                            HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HBZ, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent50:
                            HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB10, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent60:
                            HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB11, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent70:
                            HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB12, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent75:
                            HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB13, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent80:
                            HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB14, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Percent90:
                            HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB15, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Plaid:
                            HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB16, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Shingle:
                            HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB17, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallCheckerBoard:
                            HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB18, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallConfetti:
                            HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB19, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SmallGrid:
                            HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB20, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.SolidDiamond:
                            HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB21, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Sphere:
                            HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB22, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Trellis:
                            HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB23, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Vertical:
                            HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB24, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Wave:
                            HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB25, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.Weave:
                            HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB26, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.WideDownwardDiagonal:
                            HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB27, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.WideUpwardDiagonal:
                            HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB28, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        case ProgressThematic.ThematicProgress.HatchBrushType.ZigZag:
                            HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                            G.FillRectangle(HB29, new Rectangle(new Point(1, 2), new Size((Width / (int)Maximum) * (int)Value - 1, Height - 3)));
                            break;
                        default:
                            break;
                    }

                    break;
            }
            
            
            G.RenderingOrigin = new Point(GlowPosition, 0);
            
            G.DrawLine(new Pen(ProgressBarClear_ColorBorder), new Point(((int)Value / (int)Maximum) * Width - 1, 1), new Point(((int)Value / (int)Maximum) * Width - 1, Height - 1));
            G.DrawRectangle(new Pen(ProgressBarClear_ColorBorder), new Rectangle(new Point(1, 1), new Size(Width, Height)));

            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font, new SolidBrush(ForeColor),
                    this.ClientRectangle);
            }
            
        }



        #region Event

        private void ProgressBarClear_Timer_Tick(object sender, EventArgs e)
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

            if (GlowPosition == 0)
            {
                GlowPosition = 7;
            }
            else
            {
                GlowPosition -= 1;
            }
        }

        #endregion
        

    }


    

    #endregion
}
