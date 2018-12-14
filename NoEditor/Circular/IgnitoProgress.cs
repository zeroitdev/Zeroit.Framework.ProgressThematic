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

using Zeroit.Framework.Transitions.WinformAnimation;
using Zeroit.Framework.ProgressThematic;



#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{


    public partial class ThematicProgress
    {

        #region Enumerations

        public enum Ignito_drawMode
        {
            Solid,
            Gradient
        }

        public enum Ignito_innerRotatingAngle
        {
            Clockwise,
            AntiClockwise
        }

        public enum Ignito_outterRotatingAngle
        {
            Clockwise,
            AntiClockwise
        }

        //public enum easingType
        //{
        //    BounceEaseIn,
        //    BounceEaseInOut,
        //    BounceEaseOut,
        //    BounceEaseOutIn,
        //    CircularEaseIn,
        //    CircularEaseInOut,
        //    CircularEaseOut,
        //    CubicEaseIn,
        //    CubicEaseInOut,
        //    CubicEaseOut,
        //    ExponentialEaseIn,
        //    ExponentialEaseInOut,
        //    ExponentialEaseOut,
        //    Liner,
        //    None,
        //    QuadraticEaseIn,
        //    QuadraticEaseInOut,
        //    QuadraticEaseOut,
        //    QuarticEaseIn,
        //    QuarticEaseInOut,
        //    QuarticEaseOut,
        //    QuinticEaseIn,
        //    QuinticEaseInOut,
        //    QuinticEaseOut,
        //    SinusoidalEaseIn,
        //    SinusoidalEaseInOut,
        //    SinusoidalEaseOut
        //} 

        #endregion

        #region Private Fields
            
        private float Ignito_outerborder = 1;

        private float Ignito_innerborder = 1;

        Color[] Ignito_colors = new Color[]
        {
            Color.Orange,
            Color.FromArgb(152, 212, 204),
            Color.Gray,
            Color.Black,
            Color.DarkSlateGray,
            Color.LightGray,
            Color.DimGray,
            Color.Black,
            Color.Green,
            Color.LightGray,
            Color.Gray,
            Color.LightGray,
        };

        private Color[] grad = new Color[]
        {
            Color.AliceBlue, Color.Azure, Color.GreenYellow, Color.Orange
        };

        private bool Ignito_enableHatch = false;

        private LineCap Ignito_cap = LineCap.Round;

        private Ignito_innerRotatingAngle Ignito_innerRotaAngle = Ignito_innerRotatingAngle.AntiClockwise;

        private Ignito_outterRotatingAngle Ignito_outterRotaAngle = Ignito_outterRotatingAngle.Clockwise;

        private Ignito_drawMode ignito_drawMode = Ignito_drawMode.Solid;

        private DashStyle Ignito_borderStyleouter = DashStyle.DashDot;

        private DashStyle Ignito_borderStyleInner = DashStyle.DashDot;

        #endregion

        #region Public Properties



        //public int[] AnimationSpeed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        for(int i = 0; i <=1; i++)
        //        if( value[0] < 1)
        //        {
        //                value[0] = 1;
        //        }

        //        if (value[1] < 1)
        //        {
        //            value[1] = 1;
        //        }

        //        speed = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress Ignito")]
        public Ignito_innerRotatingAngle IG_InnerRotatingAnlge
        {
            get { return Ignito_innerRotaAngle; }
            set
            {
                Ignito_innerRotaAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public Ignito_outterRotatingAngle IG_OutterRotatingAngle
        {
            get { return Ignito_outterRotaAngle; }
            set
            {
                Ignito_outterRotaAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public float IG_OuterBorder
        {
            get { return Ignito_outerborder; }
            set
            {
                Ignito_outerborder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public float IG_InnerBorder
        {
            get { return Ignito_innerborder; }
            set
            {
                Ignito_innerborder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public LineCap IG_Caps
        {
            get { return Ignito_cap; }
            set
            {
                Ignito_cap = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public DashStyle IG_BorderStyleOuter
        {
            get { return Ignito_borderStyleouter; }
            set
            {
                Ignito_borderStyleouter = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public DashStyle IG_BorderStyleInner
        {
            get { return Ignito_borderStyleInner; }
            set
            {
                Ignito_borderStyleInner = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public Color [] IG_Colors
        {
            get { return Ignito_colors; }
            set
            {
                Ignito_colors = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Ignito")]
        public bool IG_EnableHatch
        {
            get { return Ignito_enableHatch; }
            set
            {
                Ignito_enableHatch = value;
                Invalidate();
            }
        }

        //public bool AutoIncrement
        //{
        //    get { return autoIncrement; }
        //    set
        //    {

        //        if (value == true)
        //        {

        //            peaceAnimator.Start();
        //        }

        //        else
        //        {
        //            peaceAnimator.Stop();
        //        }

        //        autoIncrement = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress Ignito")]
        public Ignito_drawMode IG_DrawMode
        {
            get { return ignito_drawMode; }
            set
            {
                ignito_drawMode = value;
                Invalidate();
            }
        }
        [Category("CircularProgress Ignito")]
        public Color[] IG_GradientColors
        {
            get { return grad; }
            set
            {
                grad = value;
                Invalidate();
            }
        }

        //public float Maximum
        //{
        //    get { return Maximum; }
        //    set
        //    {
        //        Maximum = value;
        //        Invalidate();
        //    }
        //}

        //public float Value
        //{
        //    get { return this.value; }
        //    set
        //    {

        //        this.value = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        #region Animation Code


        #region Event

        private void Ignito_Timer_Tick(object sender, EventArgs e)
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
        

        #endregion

        #region Constructor

        public void IgnitoProgress()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //#region AutoAnimate
            //if (DesignMode)
            //{
            //    timer.Tick += Timer_Tick;
            //    if (AutoAnimate)
            //    {
            //        //timer.Interval = 100;
            //        timer.Start();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    timer.Tick += Timer_Tick;

            //    if (AutoAnimate)
            //    {
            //        //timer.Interval = 100;
            //        timer.Start();
            //    }
            //}



            //#endregion

            //#region AutoIncrement Animation

            //peaceAnimator.Control = this;
            //peaceAnimator.DurationValue = (ulong)speed[2];
            //peaceAnimator.Repeat = true;
            //peaceAnimator.Reverse = true;
            //peaceAnimator.OneDProperty = Transitions.WinFormAnimation.Animator.KnownProperties.Value;
            //peaceAnimator.StartValue = 0;
            //peaceAnimator.EndValue = 100;


            //#endregion


            //#region StartingAngle Animation
            //if (DesignMode)
            //{
            //    timerStartingAngle.Tick += Timer_Tick_StartAngle;
            //    if (AnimateStartAngle)
            //    {
            //        //timerStartingAngle.Interval = 100;
            //        timerStartingAngle.Start();
            //    }
            //}

            //if (!DesignMode)
            //{
            //    timerStartingAngle.Tick += Timer_Tick_StartAngle;

            //    if (AnimateStartAngle)
            //    {
            //        //timerStartingAngle.Interval = 100;
            //        timerStartingAngle.Start();
            //    }
            //}



            //#endregion

            
        }


        #endregion

        #region Paint Event Arguments

        private void Ignito_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;
            g.Clear(BackColor);
            
            Rectangle circRect = new Rectangle(2, 2, Width - 5, Height - 5);
            Pen outera = new Pen(IG_Colors[0], 10);
            outera.EndCap = IG_Caps;
            outera.DashStyle = IG_BorderStyleOuter;

            Pen outerb = new Pen(IG_Colors[1], 10);
            outerb.EndCap = IG_Caps;
            outerb.DashStyle = IG_BorderStyleInner;

            Pen outergradienta = new Pen(new LinearGradientBrush(new Rectangle(10, 10, Width - 20, Height - 20), IG_GradientColors[0], IG_GradientColors[1], 90f), 10);
            Pen outergradientb = new Pen(new LinearGradientBrush(new Rectangle(45, 45, Width - 90, Height - 90), IG_GradientColors[2], IG_GradientColors[3], 90f), 15);

            g.FillEllipse(new SolidBrush(IG_Colors[2]), circRect);
            g.DrawEllipse(new Pen(IG_Colors[3], IG_OuterBorder), circRect);

            
            switch (IG_DrawMode)
            {
                case Ignito_drawMode.Solid:
                    switch (IG_OutterRotatingAngle)
                    {
                        case Ignito_outterRotatingAngle.Clockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            g.DrawPie(outera, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_outterRotatingAngle.AntiClockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            g.DrawPie(outera, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    break;
                case Ignito_drawMode.Gradient:
                    switch (IG_OutterRotatingAngle)
                    {
                        case Ignito_outterRotatingAngle.Clockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            g.DrawPie(outergradienta, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_outterRotatingAngle.AntiClockwise:
                            g.FillPie(new SolidBrush(IG_Colors[4]), new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            g.DrawPie(outergradienta, new Rectangle(10, 10, Width - 20, Height - 20), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


            if(IG_EnableHatch)
            {
                #region HatchBrush Paint
                switch (HatchBrush)
                {
                    case ProgressThematic.ThematicProgress.HatchBrushType.BackwardDiagonal:
                        HatchBrush HB = new HatchBrush(HatchStyle.BackwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Cross:
                        HatchBrush HB1 = new HatchBrush(HatchStyle.Cross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB1, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DarkDownwardDiagonal:
                        HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB2, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DarkHorizontal:
                        HatchBrush HB3 = new HatchBrush(HatchStyle.DarkHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB3, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DarkUpwardDiagonal:
                        HatchBrush HB4 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB4, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DarkVertical:
                        HatchBrush HB5 = new HatchBrush(HatchStyle.DarkVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB5, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DashedDownwardDiagonal:
                        HatchBrush HB6 = new HatchBrush(HatchStyle.DashedDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB6, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DashedHorizontal:
                        HatchBrush HB7 = new HatchBrush(HatchStyle.DashedHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB7, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DashedUpwardDiagonal:
                        HatchBrush HB8 = new HatchBrush(HatchStyle.DashedUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB8, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DashedVertical:
                        HatchBrush HB9 = new HatchBrush(HatchStyle.DashedVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB9, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalBrick:
                        HatchBrush HBA = new HatchBrush(HatchStyle.DiagonalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBA, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DiagonalCross:
                        HatchBrush HBB = new HatchBrush(HatchStyle.DiagonalCross, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBB, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Divot:
                        HatchBrush HBC = new HatchBrush(HatchStyle.Divot, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBC, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DottedDiamond:
                        HatchBrush HBD = new HatchBrush(HatchStyle.DottedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBD, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.DottedGrid:
                        HatchBrush HBE = new HatchBrush(HatchStyle.DottedGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBE, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.ForwardDiagonal:
                        HatchBrush HBF = new HatchBrush(HatchStyle.ForwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBF, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Horizontal:
                        HatchBrush HBG = new HatchBrush(HatchStyle.Horizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBG, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.HorizontalBrick:
                        HatchBrush HBH = new HatchBrush(HatchStyle.HorizontalBrick, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBH, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LargeCheckerBoard:
                        HatchBrush HBI = new HatchBrush(HatchStyle.LargeCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBI, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LargeConfetti:
                        HatchBrush HBJ = new HatchBrush(HatchStyle.LargeConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBJ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LargeGrid:
                        HatchBrush HBK = new HatchBrush(HatchStyle.LargeGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBK, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LightDownwardDiagonal:
                        HatchBrush HBL = new HatchBrush(HatchStyle.LightDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBL, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LightHorizontal:
                        HatchBrush HBM = new HatchBrush(HatchStyle.LightHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBM, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LightUpwardDiagonal:
                        HatchBrush HBN = new HatchBrush(HatchStyle.LightUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBN, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.LightVertical:
                        HatchBrush HBO = new HatchBrush(HatchStyle.LightVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBO, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Max:
                        HatchBrush HBP = new HatchBrush(HatchStyle.Max, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBP, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Min:
                        HatchBrush HBQ = new HatchBrush(HatchStyle.Min, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBQ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.NarrowHorizontal:
                        HatchBrush HBR = new HatchBrush(HatchStyle.NarrowHorizontal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBR, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.NarrowVertical:
                        HatchBrush HBS = new HatchBrush(HatchStyle.NarrowVertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBS, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.OutlinedDiamond:
                        HatchBrush HBT = new HatchBrush(HatchStyle.OutlinedDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBT, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent05:
                        HatchBrush HBU = new HatchBrush(HatchStyle.Percent05, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBU, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent10:
                        HatchBrush HBV = new HatchBrush(HatchStyle.Percent10, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBV, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent20:
                        HatchBrush HBW = new HatchBrush(HatchStyle.Percent20, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBW, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent25:
                        HatchBrush HBX = new HatchBrush(HatchStyle.Percent25, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBX, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent30:
                        HatchBrush HBY = new HatchBrush(HatchStyle.Percent30, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBY, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent40:
                        HatchBrush HBZ = new HatchBrush(HatchStyle.Percent40, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HBZ, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent50:
                        HatchBrush HB10 = new HatchBrush(HatchStyle.Percent50, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB10, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent60:
                        HatchBrush HB11 = new HatchBrush(HatchStyle.Percent60, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB11, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent70:
                        HatchBrush HB12 = new HatchBrush(HatchStyle.Percent70, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB12, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent75:
                        HatchBrush HB13 = new HatchBrush(HatchStyle.Percent75, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB13, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent80:
                        HatchBrush HB14 = new HatchBrush(HatchStyle.Percent80, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB14, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Percent90:
                        HatchBrush HB15 = new HatchBrush(HatchStyle.Percent90, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB15, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Plaid:
                        HatchBrush HB16 = new HatchBrush(HatchStyle.Plaid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB16, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Shingle:
                        HatchBrush HB17 = new HatchBrush(HatchStyle.Shingle, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB17, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.SmallCheckerBoard:
                        HatchBrush HB18 = new HatchBrush(HatchStyle.SmallCheckerBoard, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB18, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.SmallConfetti:
                        HatchBrush HB19 = new HatchBrush(HatchStyle.SmallConfetti, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB19, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.SmallGrid:
                        HatchBrush HB20 = new HatchBrush(HatchStyle.SmallGrid, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB20, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.SolidDiamond:
                        HatchBrush HB21 = new HatchBrush(HatchStyle.SolidDiamond, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB21, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Sphere:
                        HatchBrush HB22 = new HatchBrush(HatchStyle.Sphere, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB22, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Trellis:
                        HatchBrush HB23 = new HatchBrush(HatchStyle.Trellis, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB23, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Vertical:
                        HatchBrush HB24 = new HatchBrush(HatchStyle.Vertical, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB24, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Wave:
                        HatchBrush HB25 = new HatchBrush(HatchStyle.Wave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB25, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.Weave:
                        HatchBrush HB26 = new HatchBrush(HatchStyle.Weave, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB26, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.WideDownwardDiagonal:
                        HatchBrush HB27 = new HatchBrush(HatchStyle.WideDownwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB27, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.WideUpwardDiagonal:
                        HatchBrush HB28 = new HatchBrush(HatchStyle.WideUpwardDiagonal, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB28, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    case ProgressThematic.ThematicProgress.HatchBrushType.ZigZag:
                        HatchBrush HB29 = new HatchBrush(HatchStyle.ZigZag, ColorHatchBrushgradient1, ColorHatchBrushgradient2);
                        g.FillEllipse(HB29, new Rectangle(15, 15, Width - 30, Height - 30));
                        break;
                    default:
                        break;
                }
                #endregion
            }

            else
            {
                g.FillEllipse(new SolidBrush(IG_Colors[4]), new Rectangle(15, 15, Width - 30, Height - 30));
            }
            g.DrawEllipse(new Pen(IG_Colors[5], 3), new Rectangle(15, 15, Width - 30, Height - 30));

            g.FillEllipse(new SolidBrush(IG_Colors[6]), new Rectangle(30, 30, Width - 60, Height - 60));
            g.DrawEllipse(new Pen(IG_Colors[7], IG_InnerBorder), new Rectangle(30, 30, Width - 60, Height - 60));

            g.FillPie(new SolidBrush(IG_Colors[8]), new Rectangle(50, 50, Width - 100, Height - 100), 270f, /*(this.Value / 100)*/ -360f);

            switch (IG_DrawMode)
            {
                case Ignito_drawMode.Solid:

                    switch (IG_InnerRotatingAnlge)
                    {
                        case Ignito_innerRotatingAngle.Clockwise:
                            g.DrawPie(outerb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_innerRotatingAngle.AntiClockwise:
                            g.DrawPie(outerb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    
                    break;
                case Ignito_drawMode.Gradient:
                    switch (IG_InnerRotatingAnlge)
                    {
                        case Ignito_innerRotatingAngle.Clockwise:
                            g.DrawPie(outergradientb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * 360f);

                            break;
                        case Ignito_innerRotatingAngle.AntiClockwise:
                            g.DrawPie(outergradientb, new Rectangle(45, 45, Width - 90, Height - 90), StartingAngle, (this.Value / 100) * -360f);

                            break;
                        default:
                            break;
                    }
                    
                    break;
                default:
                    break;
            }

            g.FillPie(new SolidBrush(IG_Colors[9]), new Rectangle(50, 50, Width - 100, Height - 100), 270f, /*(this.value / 100) **/ -360f);
            g.DrawPie(new Pen(IG_Colors[10], 5), new Rectangle(55, 55, Width - 110, Height - 110), 270f, -360f);

            g.FillEllipse(new SolidBrush(IG_Colors[11]), new Rectangle(55, 55, Width - 110, Height - 110));

            //if(ShowText)
            //    g.DrawString(((int)Value).ToString() + PostFix, Font, new SolidBrush(ForeColor), (Width / 2) - Font.Size, (Height / 2) - Font.Size);


            if (ShowText)
            {
                Helper.CenterString(g, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

        }

        #endregion


    }






}
