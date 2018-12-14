﻿#region Imports

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
using Zeroit.Framework.Functions;
using Zeroit.Framework.Transitions.WinformAnimation;



#endregion

namespace Zeroit.Framework.ProgressThematic
{
    public partial class ThematicProgress 
    {

        

        #region Private Properties

        //private LineCap MCExV2_OuterBorderStart = LineCap.Round;
        //private LineCap MCExV2_OuterBorderEnd = LineCap.ArrowAnchor;

        //private DashStyle MCExV2_OuterBorderStyle = DashStyle.Dash;


        //private float MCExV2_GradientAngle = 90f;

        //bool MCExV2_OuterBorder = false;
        //bool MCExV2_RotatingBorder = true;

        //bool MCExV2_Divisions = true;
        //int MCExV2_DivisionsWidth = 5;

        //public enum drawMode
        //{
        //    Solid,
        //    Gradient
        //}

        //private drawMode MCExV2_DrawMode = drawMode.Solid;

        //PeaceAnimator peaceAnimator = new PeaceAnimator();

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

        //private easingType _easingType = easingType.BounceEaseIn;

        //private float valConverted = 0;

        //private bool ShowInnerBorder = true;

        //private bool autoIncrement = false;

        //public int speed = 100;

        //private int MCExV2_InnerBorder = 2;

        //private int MCExV2_Shift = 15;

        //private int MCExV2_CorrectShift = 6;

        //private int MCExV2_RectShift = 3;

        //private Rings MCExV2_NoOfRings = Rings.One;

        //private Color MCExV2_InnerHole = Color.Transparent;
        //private Color[] MCExV2_InnerHoleGradCol = new Color[]
        //{
        //    Color.Azure,
        //    Color.Bisque
        //};

        //private Color MCExV2_InnerBorderColor = Color.Gray;

        //Color[,] MCExV2_linColors = new Color[,] {

        //    {Color.Red, Color.Yellow },
        //    {Color.Blue, Color.LightGreen },
        //    {Color.LightPink, Color.LightSkyBlue },
        //    {Color.Yellow, Color.Green },
        //    {Color.BlanchedAlmond, Color.DarkGoldenrod },
        //    {Color.DarkTurquoise, Color.DimGray },
        //    {Color.Beige, Color.BlanchedAlmond },
        //    {Color.BurlyWood, Color.Chartreuse },
        //    {Color.DarkOrange, Color.DarkOrchid },
        //    {Color.GreenYellow, Color.Honeydew },
        //    {Color.HotPink, Color.Indigo },
        //    {Color.Magenta, Color.Maroon },
        //    {Color.OldLace, Color.Plum },
        //    {Color.PowderBlue, Color.Purple },
        //    {Color.SlateBlue, Color.Thistle },
        //    {Color.Sienna, Color.SeaShell },
        //    {Color.Peru, Color.Navy },
        //    {Color.MistyRose, Color.MidnightBlue },
        //    {Color.LemonChiffon, Color.LawnGreen },
        //    {Color.Khaki, Color.HotPink },
        //    {Color.ForestGreen, Color.Yellow },
        //    {Color.DarkSlateGray, Color.Crimson },
        //    {Color.Cornsilk, Color.CornflowerBlue },
        //    {Color.Beige, Color.Cyan }

        //};

        //Color[] MCExV2_GradientLine1 = new Color[] {

        //    Color.Red,
        //    Color.Blue,
        //    Color.LightPink,
        //    Color.Yellow,
        //    Color.BlanchedAlmond,
        //    Color.DarkTurquoise,
        //    Color.Beige,
        //    Color.BurlyWood,
        //    Color.DarkOrange,
        //    Color.GreenYellow,
        //    Color.HotPink,
        //    Color.Magenta,
        //    Color.OldLace,
        //    Color.PowderBlue,
        //    Color.SlateBlue,
        //    Color.Sienna,
        //    Color.Peru,
        //    Color.MistyRose,
        //    Color.LemonChiffon,
        //    Color.Khaki,
        //    Color.ForestGreen,
        //    Color.DarkSlateGray,
        //    Color.Cornsilk,
        //    Color.Beige

        //};

        //Color[] MCExV2_GradientLine2 = new Color[] {

        //    Color.Yellow ,
        //    Color.LightGreen,
        //    Color.LightSkyBlue ,
        //    Color.Green ,
        //    Color.DarkGoldenrod ,
        //    Color.DimGray ,
        //    Color.BlanchedAlmond ,
        //    Color.Chartreuse ,
        //    Color.DarkOrchid ,
        //    Color.Honeydew ,
        //    Color.Indigo ,
        //    Color.Maroon ,
        //    Color.Plum ,
        //    Color.Purple ,
        //    Color.Thistle ,
        //    Color.SeaShell ,
        //    Color.Navy,
        //    Color.MidnightBlue ,
        //    Color.LawnGreen ,
        //    Color.HotPink ,
        //    Color.Yellow ,
        //    Color.Crimson ,
        //    Color.CornflowerBlue ,
        //    Color.Cyan 

        //};


        //Color[] MCExV2_Colors = new Color[]
        //    {
        //        Color.Red,
        //        Color.Yellow,
        //        Color.Green,
        //        Color.AliceBlue,
        //        Color.Brown,
        //        Color.Chocolate,
        //        Color.DarkOrange,
        //        Color.DarkRed,
        //        Color.DeepPink,
        //        Color.Indigo,
        //        Color.Ivory,
        //        Color.Lavender,
        //        Color.LightSeaGreen,
        //        Color.Maroon,
        //        Color.OrangeRed,
        //        Color.Orchid,
        //        Color.PaleGoldenrod,
        //        Color.PapayaWhip,
        //        Color.Teal,
        //        Color.Tomato,
        //        Color.YellowGreen,
        //        Color.Thistle,
        //        Color.Tan,
        //        Color.SlateGray,
        //    };

        private float[] MCExV2_oneRinga = new float[] { 270f };
        private float[] MCExV2_oneRingb = new float[] { 0f };
        private float MCExV2_oneRingMax = 360;

        private float[] MCExV2_twoRinga = new float[] { 270f, 0f };
        private float[] MCExV2_twoRingb = new float[] { 90f, 0f };
        private float MCExV2_twoRingMax = 180;

        private float[] MCExV2_fourRinga = new float[] { 270f, 0f, 90f, 180f };
        private float[] MCExV2_fourRingb = new float[] { 0f, 0f, 0f, 0f };
        private float MCExV2_fourRingMax = 90;

        private float[] MCExV2_eightRinga = new float[] { 270f, 315f, 0f, 45f, 90f, 135f, 180f, 225f };
        private float[] MCExV2_eightRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCExV2_eightRingMax = 45;

        private float[] MCExV2_twelveRinga = new float[] { 270f, 300f, 330f, 0f, 30f, 60f, 90f, 120f, 150f, 180f, 210f, 240f };
        private float[] MCExV2_twelveRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCExV2_twelveRingMax = 30;



        private float[] MCExV2_twentyFourRinga = new float[] { 270f, 285f, 300f, 315f, 330f, 345f, 0f, 15f, 30f, 45f, 60f, 75f, 90f, 105f, 120f, 135f, 150f, 165f, 180f, 195f, 210, 225, 240f, 255 };
        private float[] MCExV2_twentyFourRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCExV2_twentyFourRingMax = 15;

        private float valueConvertMCExV2 = 0;
        #endregion

        #region Public Properties

        [Category("CircularProgress MCExV2")]
        public bool MCExV2_RotatingBorder
        {
            get { return progressInput.MCExV2_RotatingBorder; }
            set
            {
                progressInput.MCExV2_RotatingBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public LineCap MCExV2_OuterBorderStart
        {
            get { return progressInput.MCExV2_OuterBorderStart; }
            set
            {
                progressInput.MCExV2_OuterBorderStart = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public LineCap MCExV2_OuterBorderEnd
        {
            get { return progressInput.MCExV2_OuterBorderEnd; }
            set
            {
                progressInput.MCExV2_OuterBorderEnd = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public DashStyle MCExV2_OuterBorderStyle
        {
            get { return progressInput.MCExV2_OuterBorderStyle; }
            set
            {
                progressInput.MCExV2_OuterBorderStyle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public bool MCExV2_OuterBorder
        {
            get { return progressInput.MCExV2_OuterBorder; }
            set
            {
                progressInput.MCExV2_OuterBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public Color[] MCExV2_InnerHoleGradCol
        {
            get { return progressInput.MCExV2_InnerHoleGradCol; }
            set
            {
                progressInput.MCExV2_InnerHoleGradCol = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public Color MCExV2_InnerHole
        {
            get
            {
                return progressInput.MCExV2_InnerHole;
            }

            set
            {
                progressInput.MCExV2_InnerHole = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public float MCExV2_GradientAngle
        {
            get { return progressInput.MCExV2_GradientAngle; }
            set
            {
                progressInput.MCExV2_GradientAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public bool MCExV2_Divisions
        {
            get { return progressInput.MCExV2_Divisions; }
            set
            {
                progressInput.MCExV2_Divisions = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public int MCExV2_DivisionsWidth
        {
            get { return progressInput.MCExV2_DivisionsWidth; }
            set
            {
                progressInput.MCExV2_DivisionsWidth = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public Color[] MCExV2_GradientLine1
        {
            get { return progressInput.MCExV2_GradientLine1; }
            set
            {
                progressInput.MCExV2_GradientLine1 = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public Color[] MCExV2_GradientLine2
        {
            get { return progressInput.MCExV2_GradientLine2; }
            set
            {
                progressInput.MCExV2_GradientLine2 = value;
                Invalidate();
            }
        }

        public drawMode MCExV2_DrawMode
        {
            get { return progressInput.MCExV2_DrawMode; }
            set
            {
                progressInput.MCExV2_DrawMode = value;
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

        //public easingType AnimationType
        //{
        //    get { return _easingType; }
        //    set
        //    {
        //        _easingType = valConverted;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress MCExV2")]
        public Color MCExV2_InnerBorderColor
        {
            get { return progressInput.MCExV2_InnerBorderColor; }
            set
            {
                progressInput.MCExV2_InnerBorderColor = value;
                Invalidate();
            }
        }

        //public float Value
        //{
        //    get
        //    {
        //        return valConverted;
        //    }

        //    set
        //    {
        //        valueConvertMCExV2 = valConverted;
        //        Invalidate();
        //    }
        //}

        //public int Speed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        speed = valConverted;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress MCExV2")]
        public Color[] MCExV2_Colors
        {
            get { return progressInput.MCExV2_Colors; }
            set
            {
                progressInput.MCExV2_Colors = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public Rings MCExV2_NoOfRings
        {
            get { return progressInput.MCExV2_NoOfRings; }
            set
            {
                progressInput.MCExV2_NoOfRings = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public bool ShowInnerBorder
        {
            get { return progressInput.ShowInnerBorder; }
            set
            {
                progressInput.ShowInnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public int MCExV2_InnerBorder
        {
            get { return progressInput.MCExV2_InnerBorder; }
            set
            {
                progressInput.MCExV2_InnerBorder = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Shifts the innerCircle
        /// </summary>
        [Category("CircularProgress MCExV2")]
        public int MCExV2_InnerShift
        {
            get { return MCExV2_RectShift; }
            set
            {
                MCExV2_RectShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public int MCExV2_CorrectShift
        {
            get { return progressInput.MCExV2_CorrectShift; }
            set
            {
                progressInput.MCExV2_CorrectShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public int MCExV2_Shift
        {
            get { return progressInput.MCExV2_Shift; }
            set
            {
                progressInput.MCExV2_Shift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCExV2")]
        public int MCExV2_RectShift
        {
            get { return MCExV2_RectShift; }
            set
            {
                MCExV2_RectShift = value;
                Invalidate();
            }
        }


        #endregion

        
        #region Event

        private void MCExV2_Timer_Tick(object sender, EventArgs e)
        {
            if ((this.Value / Maximum * 100) + 1 > 100)
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
        
        #region Constructor
        public void ZeroitProgressMultiCoExtended1()
        {

            
        }

        #endregion

        private void MCExV2_Paint(PaintEventArgs e)
        {
            
            

            

            Graphics G = e.Graphics;
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.Clear(BackColor);

            valueConvertMCExV2 = (Value / Maximum) * 100;

            Rectangle rect = new Rectangle(MCExV2_CorrectShift, MCExV2_CorrectShift, Width - MCExV2_Shift, Height - MCExV2_Shift);
            Rectangle coloredRectangle = new Rectangle(0, 0, Width - MCExV2_RectShift, Height - MCExV2_RectShift);
            Rectangle outerborderRectangle = new Rectangle(0, 0, Width - MCExV2_RectShift + 1, Height - MCExV2_RectShift + 1);

            Pen outsideBorder = new Pen(Color.Gray, 2);
            Pen outerBorder = new Pen(Color.Black, 2);



            outsideBorder.DashStyle = MCExV2_OuterBorderStyle;
            outsideBorder.EndCap = MCExV2_OuterBorderEnd;
            outsideBorder.StartCap = MCExV2_OuterBorderStart;

            outerBorder.DashStyle = MCExV2_OuterBorderStyle;
            outerBorder.EndCap = MCExV2_OuterBorderEnd;
            outerBorder.StartCap = MCExV2_OuterBorderStart;

            if (ShowInnerBorder)
            {
                g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                g.DrawEllipse(new Pen(MCExV2_InnerBorderColor, MCExV2_InnerBorder), rect);
            }

            else
            {
                g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                g.DrawEllipse(new Pen(Color.Transparent, MCExV2_InnerBorder), rect);

            }


            switch (MCExV2_NoOfRings)
            {
                case Rings.One:

                    #region 1 ring

                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }

                    if (MCExV2_RotatingBorder)
                    {
                        g.DrawPie(outerBorder, outerborderRectangle, 270f, (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));
                    }

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            if (MCExV2_Divisions)
                            {
                                g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, MCExV2_oneRinga[0], (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));
                                g.DrawPie(new Pen(Color.Transparent, MCExV2_DivisionsWidth), coloredRectangle, 270f, 360f);


                                g.FillEllipse(new SolidBrush(BackColor), rect);
                                //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            }

                            else
                            {
                                g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, MCExV2_oneRinga[0], (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));

                                //g.DrawPie(new Pen(Color.Transparent, 2), coloredRectangle, 270f, 90f);

                                g.FillEllipse(new SolidBrush(BackColor), rect);
                                //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            }

                            //if(MCExV2_RotatingBorder)
                            //{
                            //    g.DrawPie(outerBorder, outerborderRectangle, 270f, (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));
                            //}

                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, MCExV2_oneRinga[0], (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));
                                g.DrawPie(new Pen(Color.Transparent, MCExV2_DivisionsWidth), coloredRectangle, 270f, 360f);

                                g.FillEllipse(new SolidBrush(BackColor), rect);
                                //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            }

                            else
                            {
                                g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, MCExV2_oneRinga[0], (valueConvertMCExV2 / 100) * (360f /*+ MCExV2_oneRingb[0]*/));
                                //g.DrawPie(new Pen(Color.Transparent, 2), coloredRectangle, 270f, 90f);

                                g.FillEllipse(new SolidBrush(BackColor), rect);
                                //g.DrawEllipse(new Pen(BackColor, 1), rect);
                                
                            }


                            break;
                        default:
                            break;
                    }

                    #endregion

                    break;
                case Rings.Two:

                    #region 2 rings

                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }



                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:


                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 180f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 180f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 50) * 180f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 180f);

                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);

                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 270f, 180f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 270f, 180f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 50) * 180f);
                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 90f, 180f);

                                }
                            }



                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);



                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 180f);

                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 180f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 50) * 180f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 180f);

                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 270f, 180f);

                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 50) * 180f);
                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 270f, 180f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 50) * 180f);
                                    //g.DrawPie(new Pen(BackColor, 5), coloredRectangle, 90f, 180f);

                                }
                            }


                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            break;
                        default:
                            break;
                    }


                    #endregion

                    break;
                case Rings.Four:

                    #region 4 rings

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 26)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 25 && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 50 && valConverted < 76)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);


                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);


                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 26)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 25 && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 50 && valConverted < 76)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);


                                }
                            }



                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);


                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 26)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 25 && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 50 && valConverted < 76)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);


                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75) / 25) * 90f);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 90f);


                                }

                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 26)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 25 && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 50 && valConverted < 76)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75) / 25) * 90f);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);


                                }

                            }


                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            break;
                        default:
                            break;
                    }

                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }
                    #endregion

                    break;
                case Rings.Eight:


                    #region 8 Rings

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 13f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 12f && valConverted < 26)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 25f && valConverted < 38)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 37f && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);

                                }

                                else if (valConverted > 50 && valConverted < 63)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);

                                }

                                else if (valConverted > 62 && valConverted < 76)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);



                                }

                                else if (valConverted > 75 && valConverted < 88)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);


                                }

                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 13f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 12f && valConverted < 26)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 25f && valConverted < 38)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 37f && valConverted < 51)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 50 && valConverted < 63)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                                }

                                else if (valConverted > 62 && valConverted < 76)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                                }

                                else if (valConverted > 75 && valConverted < 88)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                                }

                            }

                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);


                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 13f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 12f && valConverted < 26)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 25f && valConverted < 38)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);
                                }

                                else if (valConverted > 37f && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);

                                }

                                else if (valConverted > 50 && valConverted < 63)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);



                                }

                                else if (valConverted > 62 && valConverted < 76)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);



                                }

                                else if (valConverted > 75 && valConverted < 88)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);

                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 45f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.5f) / 12.5f) * 45);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 45f);


                                }

                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 13f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 12f && valConverted < 26)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 25f && valConverted < 38)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 37f && valConverted < 51)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 50 && valConverted < 63)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                                }

                                else if (valConverted > 62 && valConverted < 76)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                                }

                                else if (valConverted > 75 && valConverted < 88)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }


                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 25) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 50) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 75f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.5f) / 12.5f) * 45);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                                }

                            }

                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);


                            break;
                        default:
                            break;
                    }


                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }
                    #endregion

                    break;
                case Rings.Twelve:

                    #region 12 Rings

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 8.4f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);
                                }

                                else if (valConverted > 8.5 && valConverted < 17f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);


                                }

                                else if (valConverted > 16.6 && valConverted < 26f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }

                                else if (valConverted > 25 && valConverted < 34f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);


                                }

                                else if (valConverted > 33 && valConverted < 43f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);


                                }

                                else if (valConverted > 42 && valConverted < 51f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);



                                }

                                else if (valConverted > 50 && valConverted < 60f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }

                                else if (valConverted > 59 && valConverted < 68f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);


                                }

                                else if (valConverted > 67 && valConverted < 76f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);




                                }

                                else if (valConverted > 75f && valConverted < 85f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }

                                else if (valConverted > 84f && valConverted < 93f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6663f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }

                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 8.4f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 8.5 && valConverted < 17f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                                }

                                else if (valConverted > 16.6 && valConverted < 26f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 25 && valConverted < 34f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                                }

                                else if (valConverted > 33 && valConverted < 43f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                                }

                                else if (valConverted > 42 && valConverted < 51f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                                }

                                else if (valConverted > 50 && valConverted < 60f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                }

                                else if (valConverted > 59 && valConverted < 68f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 67 && valConverted < 76f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);




                                }

                                else if (valConverted > 75f && valConverted < 85f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }

                                else if (valConverted > 84f && valConverted < 93f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6663f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                }

                            }

                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);


                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 8.4f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);
                                }

                                else if (valConverted > 8.5 && valConverted < 17f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);


                                }

                                else if (valConverted > 16.6 && valConverted < 26f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                }

                                else if (valConverted > 25 && valConverted < 34f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);


                                }

                                else if (valConverted > 33 && valConverted < 43f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);


                                }

                                else if (valConverted > 42 && valConverted < 51f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);



                                }

                                else if (valConverted > 50 && valConverted < 60f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                }

                                else if (valConverted > 59 && valConverted < 68f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);


                                }

                                else if (valConverted > 67 && valConverted < 76f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);


                                }

                                else if (valConverted > 75f && valConverted < 85f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                }

                                else if (valConverted > 84f && valConverted < 93f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 30f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6663f) / 8.3333f) * 30);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 30f);

                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 8.4f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 8.5 && valConverted < 17f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                                }

                                else if (valConverted > 16.6 && valConverted < 26f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 25 && valConverted < 34f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                                }

                                else if (valConverted > 33 && valConverted < 43f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                                }

                                else if (valConverted > 42 && valConverted < 51f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                                }

                                else if (valConverted > 50 && valConverted < 60f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                }

                                else if (valConverted > 59 && valConverted < 68f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 67 && valConverted < 76f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 75f && valConverted < 85f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }

                                else if (valConverted > 84f && valConverted < 93f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6666f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9999f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3332f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6665f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9998f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3331f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6664f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9997f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3333f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6663f) / 8.3333f) * 30);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                }
                            }



                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            break;
                        default:
                            break;
                    }


                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }

                    #endregion

                    break;
                case Rings.TwentyFour:

                    #region 24 Rings

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 5f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 4 && valConverted < 9f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 8 && valConverted < 14f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 13 && valConverted < 18f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 17 && valConverted < 22f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 21 && valConverted < 26f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 25 && valConverted < 31f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 30 && valConverted < 35f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 34 && valConverted < 39f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 38 && valConverted < 43f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 42 && valConverted < 47f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 46 && valConverted < 51f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);



                                }

                                else if (valConverted > 50 && valConverted < 56f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 55 && valConverted < 60f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 59 && valConverted < 64f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 63 && valConverted < 68f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 67 && valConverted < 72f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 71 && valConverted < 76f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 75 && valConverted < 81f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 80 && valConverted < 85f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 84 && valConverted < 89f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 88 && valConverted < 93f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 92 && valConverted < 97f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[22]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[22]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[23]), coloredRectangle, 255f, ((valueConvertMCExV2 - 95.8315f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 5f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 4 && valConverted < 9f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 8 && valConverted < 14f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 13 && valConverted < 18f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 17 && valConverted < 22f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 21 && valConverted < 26f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                                }

                                else if (valConverted > 25 && valConverted < 31f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 30 && valConverted < 35f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 34 && valConverted < 39f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 38 && valConverted < 43f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 42 && valConverted < 47f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 46 && valConverted < 51f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                                }

                                else if (valConverted > 50 && valConverted < 56f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 55 && valConverted < 60f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 59 && valConverted < 64f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 63 && valConverted < 68f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 67 && valConverted < 72f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 71 && valConverted < 76f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 75 && valConverted < 81f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 80 && valConverted < 85f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 84 && valConverted < 89f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 
                                }

                                else if (valConverted > 88 && valConverted < 93f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 92 && valConverted < 97f)
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[22]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else
                                {
                                    g.FillPie(new SolidBrush(MCExV2_Colors[0]), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[1]), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[2]), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[3]), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[4]), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[5]), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[6]), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[7]), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[8]), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[9]), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[10]), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[11]), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[12]), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new SolidBrush(MCExV2_Colors[13]), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[14]), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[15]), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[16]), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[17]), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[18]), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[19]), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[20]), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new SolidBrush(MCExV2_Colors[21]), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[22]), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new SolidBrush(MCExV2_Colors[23]), coloredRectangle, 255f, ((valueConvertMCExV2 - 95.8315f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                                }
                            }

                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);

                            break;
                        case drawMode.Gradient:

                            if (MCExV2_Divisions)
                            {
                                if (valConverted >= 0 && valConverted < 5f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 4 && valConverted < 9f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 8 && valConverted < 14f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 13 && valConverted < 18f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 17 && valConverted < 22f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 21 && valConverted < 26f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 25 && valConverted < 31f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 30 && valConverted < 35f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 34 && valConverted < 39f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 38 && valConverted < 43f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 42 && valConverted < 47f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }

                                else if (valConverted > 46 && valConverted < 51f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);



                                }

                                else if (valConverted > 50 && valConverted < 56f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 55 && valConverted < 60f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 59 && valConverted < 64f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 63 && valConverted < 68f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 67 && valConverted < 72f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 71 && valConverted < 76f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);


                                }

                                else if (valConverted > 75 && valConverted < 81f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 80 && valConverted < 85f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 84 && valConverted < 89f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 88 && valConverted < 93f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 90f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else if (valConverted > 92 && valConverted < 97f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[22], MCExV2_GradientLine2[22], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);
                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 270f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 285f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 300f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 315f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 330f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 345f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 15f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 30f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 45f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 60f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 75f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 15f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 105f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 120f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 135f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 150f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 165f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 180f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 195f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 210f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 225f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[22], MCExV2_GradientLine2[22], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 240f, 15f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[23], MCExV2_GradientLine2[23], MCExV2_GradientAngle), coloredRectangle, 255f, ((valueConvertMCExV2 - 95.8315f) / 4.1666f) * 15);
                                    g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 255f, 15f);

                                }
                            }

                            else
                            {
                                if (valConverted >= 0 && valConverted < 5f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 4 && valConverted < 9f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 8 && valConverted < 14f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                }

                                else if (valConverted > 13 && valConverted < 18f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 17 && valConverted < 22f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                                }

                                else if (valConverted > 21 && valConverted < 26f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                                }

                                else if (valConverted > 25 && valConverted < 31f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 30 && valConverted < 35f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 34 && valConverted < 39f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 38 && valConverted < 43f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                                }

                                else if (valConverted > 42 && valConverted < 47f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                }

                                else if (valConverted > 46 && valConverted < 51f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                                }

                                else if (valConverted > 50 && valConverted < 56f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 55 && valConverted < 60f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(BackColor, MCExV2_DivisionsWidth), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 59 && valConverted < 64f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 63 && valConverted < 68f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 67 && valConverted < 72f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                                }

                                else if (valConverted > 71 && valConverted < 76f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                }

                                else if (valConverted > 75 && valConverted < 81f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 80 && valConverted < 85f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 84 && valConverted < 89f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 
                                }

                                else if (valConverted > 88 && valConverted < 93f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else if (valConverted > 92 && valConverted < 97f)
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[22], MCExV2_GradientLine2[22], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                                }

                                else
                                {
                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[0], MCExV2_GradientLine2[0], MCExV2_GradientAngle), coloredRectangle, 270f, (valueConvertMCExV2 / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[1], MCExV2_GradientLine2[1], MCExV2_GradientAngle), coloredRectangle, 285f, ((valueConvertMCExV2 - 4.1666f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[2], MCExV2_GradientLine2[2], MCExV2_GradientAngle), coloredRectangle, 300f, ((valueConvertMCExV2 - 8.3332f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[3], MCExV2_GradientLine2[3], MCExV2_GradientAngle), coloredRectangle, 315f, ((valueConvertMCExV2 - 12.4999f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[4], MCExV2_GradientLine2[4], MCExV2_GradientAngle), coloredRectangle, 330f, ((valueConvertMCExV2 - 16.6664f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[5], MCExV2_GradientLine2[5], MCExV2_GradientAngle), coloredRectangle, 345f, ((valueConvertMCExV2 - 20.8331f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[6], MCExV2_GradientLine2[6], MCExV2_GradientAngle), coloredRectangle, 0f, ((valueConvertMCExV2 - 24.9997f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[7], MCExV2_GradientLine2[7], MCExV2_GradientAngle), coloredRectangle, 15f, ((valueConvertMCExV2 - 29.1662f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[8], MCExV2_GradientLine2[8], MCExV2_GradientAngle), coloredRectangle, 30f, ((valueConvertMCExV2 - 33.3325f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[9], MCExV2_GradientLine2[9], MCExV2_GradientAngle), coloredRectangle, 45f, ((valueConvertMCExV2 - 37.4991f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[10], MCExV2_GradientLine2[10], MCExV2_GradientAngle), coloredRectangle, 60f, ((valueConvertMCExV2 - 41.6657f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[11], MCExV2_GradientLine2[11], MCExV2_GradientAngle), coloredRectangle, 75f, ((valueConvertMCExV2 - 45.8322f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[12], MCExV2_GradientLine2[12], MCExV2_GradientAngle), coloredRectangle, 90f, ((valueConvertMCExV2 - 49.9989f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[13], MCExV2_GradientLine2[13], MCExV2_GradientAngle), coloredRectangle, 105f, ((valueConvertMCExV2 - 54.1655f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[14], MCExV2_GradientLine2[14], MCExV2_GradientAngle), coloredRectangle, 120f, ((valueConvertMCExV2 - 58.3321f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[15], MCExV2_GradientLine2[15], MCExV2_GradientAngle), coloredRectangle, 135f, ((valueConvertMCExV2 - 62.4987f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[16], MCExV2_GradientLine2[16], MCExV2_GradientAngle), coloredRectangle, 150f, ((valueConvertMCExV2 - 66.6653f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[17], MCExV2_GradientLine2[17], MCExV2_GradientAngle), coloredRectangle, 165f, ((valueConvertMCExV2 - 70.8319f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[18], MCExV2_GradientLine2[18], MCExV2_GradientAngle), coloredRectangle, 180f, ((valueConvertMCExV2 - 74.9985f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[19], MCExV2_GradientLine2[19], MCExV2_GradientAngle), coloredRectangle, 195f, ((valueConvertMCExV2 - 79.1651f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[20], MCExV2_GradientLine2[20], MCExV2_GradientAngle), coloredRectangle, 210f, ((valueConvertMCExV2 - 83.3316f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[21], MCExV2_GradientLine2[21], MCExV2_GradientAngle), coloredRectangle, 225f, ((valueConvertMCExV2 - 87.4983f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[22], MCExV2_GradientLine2[22], MCExV2_GradientAngle), coloredRectangle, 240f, ((valueConvertMCExV2 - 91.6649f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                                    g.FillPie(new LinearGradientBrush(coloredRectangle, MCExV2_GradientLine1[23], MCExV2_GradientLine2[23], MCExV2_GradientAngle), coloredRectangle, 255f, ((valueConvertMCExV2 - 95.8315f) / 4.1666f) * 15);
                                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                                }
                            }



                            g.FillEllipse(new SolidBrush(BackColor), rect);
                            //g.DrawEllipse(new Pen(BackColor, 1), rect);


                            break;
                        default:
                            break;
                    }


                    //Experimental
                    if (MCExV2_OuterBorder)
                    {
                        g.DrawEllipse(outsideBorder, coloredRectangle);
                    }

                    #endregion

                    break;
                case Rings.Default:

                    switch (MCExV2_DrawMode)
                    {
                        case drawMode.Solid:

                            g.FillPie(new SolidBrush(MCExV2_InnerHole), coloredRectangle, 270f, 360f);
                            //g.DrawPie(new Pen(Color.Black, 2), coloredRectangle, 270f, 90f);

                            g.FillEllipse(new SolidBrush(MCExV2_InnerHole), rect);
                            g.DrawEllipse(new Pen(Color.Gray, 2), rect);

                            break;
                        case drawMode.Gradient:

                            g.FillPie(new SolidBrush(MCExV2_InnerHole), coloredRectangle, 270f, 360f);
                            //g.DrawPie(new Pen(Color.Black, 2), coloredRectangle, 270f, 90f);

                            g.FillEllipse(new LinearGradientBrush(coloredRectangle, MCExV2_InnerHoleGradCol[0], MCExV2_InnerHoleGradCol[1], 90f), rect);
                            g.DrawEllipse(new Pen(Color.Gray, 2), rect);
                            break;
                        default:
                            break;
                    }

                    break;

            }


            Helper.CenterString(g, Convert.ToInt32(Value).ToString() + PostFix, Font, new SolidBrush(ForeColor),
                this.ClientRectangle);
        }



    }

}