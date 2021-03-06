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

using Zeroit.Framework.ProgressThematic;
using Zeroit.Framework.Transitions.WinformAnimation;



#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    public partial class ThematicProgress
    {

        #region Private Properties

        private bool MCEx_showInnerBorder = true;
        private int MCEx_innerBorder = 2;
        private int MCEx_shift = 15;
        private int MCEx_correctShift = 6;
        private int MCEx_rectShift = 3;
        private Rings MCEx_noOfRings = Rings.One;
        private Color MCEx_innerBorderColor = Color.Gray;
        Color[] MCEx_colors = new Color[]
        {
            Color.Red,
            Color.Yellow,
            Color.Green,
            Color.AliceBlue,
            Color.Brown,
            Color.Chocolate,
            Color.DarkOrange,
            Color.DarkRed,
            Color.DeepPink,
            Color.Indigo,
            Color.Ivory,
            Color.Lavender,
            Color.LightSeaGreen,
            Color.Maroon,
            Color.OrangeRed,
            Color.Orchid,
            Color.PaleGoldenrod,
            Color.PapayaWhip,
            Color.Teal,
            Color.Tomato,
            Color.YellowGreen,
            Color.Thistle,
            Color.Tan,
            Color.SlateGray,
        };

        private int MCExshift_Height = 15;
        private int MCExcorrectShift_Height = 6;
        private int MCExrectShift_Height = 3;
        private int MCExposition_horizontal = 0;
        private int MCExposition_vertical = 0;
        private Color MCExinnerborderColor = Color.Black;
        private Color MCExinnerColor = Color.Blue;


        private float[] MCEx_oneRinga = new float[] { 270f };
        private float[] MCEx_oneRingb = new float[] { 0f };
        private float MCEx_oneRingMax = 360;

        private float[] MCEx_twoRinga = new float[] { 270f, 0f };
        private float[] MCEx_twoRingb = new float[] { 90f, 0f };
        private float MCEx_twoRingMax = 180;

        private float[] MCEx_fourRinga = new float[] { 270f, 0f, 90f, 180f };
        private float[] MCEx_fourRingb = new float[] { 0f, 0f, 0f, 0f };
        private float MCEx_fourRingMax = 90;

        private float[] MCEx_eightRinga = new float[] { 270f, 315f, 0f, 45f, 90f, 135f, 180f, 225f };
        private float[] MCEx_eightRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCEx_eightRingMax = 45;

        private float[] twelveRinga = new float[] { 270f, 300f, 330f, 0f, 30f, 60f, 90f, 120f, 150f, 180f, 210f, 240f };
        private float[] twelveRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCEx_twelveRingMax = 30;



        private float[] twentyFourRinga = new float[] { 270f, 285f, 300f, 315f, 330f, 345f, 0f, 15f, 30f, 45f, 60f, 75f, 90f, 105f, 120f, 135f, 150f, 165f, 180f, 195f, 210, 225, 240f, 255 };
        private float[] twentyFourRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MCEx_twentyFourRingMax = 15;

        private float valConverted = 0;
        #endregion

        #region Public Properties

        [Category("CircularProgress MCEx")]
        public Color MCEx_InnerColor
        {
            get { return MCExinnerColor; }
            set
            {
                MCExinnerColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public Color MCEx_InnerBorderColor
        {
            get { return MCEx_innerBorderColor; }
            set
            {
                MCEx_innerBorderColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_Position_Horizontal
        {
            get { return MCExposition_horizontal; }
            set
            {
                MCExposition_horizontal = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_Position_Vertical
        {
            get { return MCExposition_vertical; }
            set
            {
                MCExposition_vertical = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_CorrectShift_Height
        {
            get { return MCExcorrectShift_Height; }
            set
            {
                MCExcorrectShift_Height = value;
                Invalidate();

            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_Shift_Height
        {
            get { return MCExshift_Height; }
            set
            {
                MCExshift_Height = value;
                Invalidate();

            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_RectShift_Height
        {
            get { return MCExrectShift_Height; }
            set
            {
                MCExrectShift_Height = value;
                Invalidate();

            }
        }
        

        //public float valConverted
        //{
        //    get
        //    {
        //        return value;
        //    }

        //    set
        //    {
        //        this.value = value;
        //        Invalidate();
        //    }
        //}

        //public int Speed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        speed = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress MCEx")]
        public Color[] MCEx_Colors
        {
            get { return MCEx_colors; }
            set
            {
                MCEx_colors = value;
                Invalidate();
            }
        }
        

        [Category("CircularProgress MCEx")]
        public Rings MCEx_NoOfRings
        {
            get { return MCEx_noOfRings; }
            set
            {
                MCEx_noOfRings = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public bool MCEx_ShowInnerBorder
        {
            get { return MCEx_showInnerBorder; }
            set
            {
                MCEx_showInnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_InnerBorder
        {
            get { return MCEx_innerBorder; }
            set
            {
                MCEx_innerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_InnerShift
        {
            get { return MCEx_RectShift; }
            set
            {
                MCEx_RectShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_CorrectShift
        {
            get { return MCEx_correctShift; }
            set
            {
                MCEx_correctShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_Shift
        {
            get { return MCEx_shift; }
            set
            {
                MCEx_shift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        public int MCEx_RectShift
        {
            get { return MCEx_rectShift; }
            set
            {
                MCEx_rectShift = value;
                Invalidate();
            }
        }

        
        
        #endregion
            
        #region Event

        private void MultiCoExtended_Timer_Tick(object sender, EventArgs e)
        {
            if ((this.Value/Maximum *100) + 1 > 100)
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
        
        #region Paint
        private void MultiCoExtended_Paint(PaintEventArgs e)
        {

            
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;
            g.Clear(BackColor);

            valConverted = (Value / Maximum) * 100;


            Rectangle rect = new Rectangle(MCEx_CorrectShift, MCEx_CorrectShift_Height, Width - MCEx_Shift, Height - MCEx_Shift_Height);
            Rectangle coloredRectangle = new Rectangle(MCEx_Position_Horizontal, MCEx_Position_Vertical, Width - MCEx_RectShift, Height - MCEx_RectShift_Height);
            

            switch (MCEx_NoOfRings)
            {
                case Rings.One:

                    #region 1 ring


                    g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, MCEx_oneRinga[0], (valConverted / 100) * (360f /*+ MCEx_oneRingb[0]*/));
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);


                    #endregion

                    break;
                case Rings.Two:

                    #region 2 rings

                    if (valConverted >= 0 && valConverted < 51)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 50) * 180f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    }

                    else
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 50) * 180f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 90f, ((this.valConverted - 50) / 50) * 180f);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    }

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Four:

                    #region 4 rings

                    if (valConverted >= 0 && valConverted < 26)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 25 && valConverted < 51)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 0f, ((this.valConverted - 25) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                    }

                    else if (valConverted > 50 && valConverted < 76)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 0f, ((this.valConverted - 25) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 90f, ((this.valConverted - 50) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                    }

                    else
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 0f, ((this.valConverted - 25) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 90f, ((this.valConverted - 50) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 180f, ((this.valConverted - 75) / 25) * 90f);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);


                    }

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);


                    #endregion

                    break;
                case Rings.Eight:


                    #region 8 Rings

                    if (valConverted >= 0 && valConverted < 13f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 12f && valConverted < 26)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 25f && valConverted < 38)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                    }

                    else if (valConverted > 37f && valConverted < 51)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 45f, ((this.valConverted - 37.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    }

                    else if (valConverted > 50 && valConverted < 63)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 45f, ((this.valConverted - 37.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 90f, ((this.valConverted - 50) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                    }

                    else if (valConverted > 62 && valConverted < 76)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 45f, ((this.valConverted - 37.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 90f, ((this.valConverted - 50) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 135f, ((this.valConverted - 62.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                    }

                    else if (valConverted > 75 && valConverted < 88)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 45f, ((this.valConverted - 37.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 90f, ((this.valConverted - 50) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 135f, ((this.valConverted - 62.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 180f, ((this.valConverted - 75f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    }


                    else
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 315f, ((this.valConverted - 12.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 0f, ((this.valConverted - 25) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 45f, ((this.valConverted - 37.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 90f, ((this.valConverted - 50) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 135f, ((this.valConverted - 62.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 180f, ((this.valConverted - 75f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 225f, ((this.valConverted - 87.5f) / 12.5f) * 45);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                    }


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Twelve:

                    #region 12 Rings


                    if (valConverted >= 0 && valConverted < 8.4f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 8.5 && valConverted < 17f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    }

                    else if (valConverted > 16.6 && valConverted < 26f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    }

                    else if (valConverted > 25 && valConverted < 34f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                    }

                    else if (valConverted > 33 && valConverted < 43f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                    }

                    else if (valConverted > 42 && valConverted < 51f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                    }

                    else if (valConverted > 50 && valConverted < 60f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    }

                    else if (valConverted > 59 && valConverted < 68f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 120f, ((this.valConverted - 58.3331f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                    }

                    else if (valConverted > 67 && valConverted < 76f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 120f, ((this.valConverted - 58.3331f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 150f, ((this.valConverted - 66.6664f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);




                    }

                    else if (valConverted > 75f && valConverted < 85f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 120f, ((this.valConverted - 58.3331f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 150f, ((this.valConverted - 66.6664f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 180f, ((this.valConverted - 74.9997f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    }

                    else if (valConverted > 84f && valConverted < 93f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 120f, ((this.valConverted - 58.3331f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 150f, ((this.valConverted - 66.6664f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 180f, ((this.valConverted - 74.9997f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 210f, ((this.valConverted - 83.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    }

                    else
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 300f, ((this.valConverted - 8.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 330f, ((this.valConverted - 16.6666f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 0f, ((this.valConverted - 24.9999f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 30f, ((this.valConverted - 33.3332f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 60f, ((this.valConverted - 41.6665f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 90f, ((this.valConverted - 49.9998f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 120f, ((this.valConverted - 58.3331f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 150f, ((this.valConverted - 66.6664f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 180f, ((this.valConverted - 74.9997f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 210f, ((this.valConverted - 83.3333f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 240f, ((this.valConverted - 91.6663f) / 8.3333f) * 30);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                    }


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.TwentyFour:

                    #region 24 Rings

                    if (valConverted >= 0 && valConverted < 5f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    }

                    else if (valConverted > 4 && valConverted < 9f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    }

                    else if (valConverted > 8 && valConverted < 14f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    }

                    else if (valConverted > 13 && valConverted < 18f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 17 && valConverted < 22f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);
                    }

                    else if (valConverted > 21 && valConverted < 26f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    }

                    else if (valConverted > 25 && valConverted < 31f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    }

                    else if (valConverted > 30 && valConverted < 35f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    }

                    else if (valConverted > 34 && valConverted < 39f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                    }

                    else if (valConverted > 38 && valConverted < 43f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);
                    }

                    else if (valConverted > 42 && valConverted < 47f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    }

                    else if (valConverted > 46 && valConverted < 51f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                    }

                    else if (valConverted > 50 && valConverted < 56f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                    }

                    else if (valConverted > 55 && valConverted < 60f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                    }

                    else if (valConverted > 59 && valConverted < 64f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                    }

                    else if (valConverted > 63 && valConverted < 68f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                    }

                    else if (valConverted > 67 && valConverted < 72f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);
                    }

                    else if (valConverted > 71 && valConverted < 76f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                    }

                    else if (valConverted > 75 && valConverted < 81f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                    }

                    else if (valConverted > 80 && valConverted < 85f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[19]), coloredRectangle, 195f, ((this.valConverted - 79.1651f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                    }

                    else if (valConverted > 84 && valConverted < 89f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[19]), coloredRectangle, 195f, ((this.valConverted - 79.1651f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[20]), coloredRectangle, 210f, ((this.valConverted - 83.3316f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 
                    }

                    else if (valConverted > 88 && valConverted < 93f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[19]), coloredRectangle, 195f, ((this.valConverted - 79.1651f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[20]), coloredRectangle, 210f, ((this.valConverted - 83.3316f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                        g.FillPie(new SolidBrush(MCEx_Colors[21]), coloredRectangle, 225f, ((this.valConverted - 87.4983f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                    }

                    else if (valConverted > 92 && valConverted < 97f)
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[19]), coloredRectangle, 195f, ((this.valConverted - 79.1651f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[20]), coloredRectangle, 210f, ((this.valConverted - 83.3316f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                        g.FillPie(new SolidBrush(MCEx_Colors[21]), coloredRectangle, 225f, ((this.valConverted - 87.4983f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[22]), coloredRectangle, 240f, ((this.valConverted - 91.6649f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);
                    }

                    else
                    {
                        g.FillPie(new SolidBrush(MCEx_Colors[0]), coloredRectangle, 270f, (this.valConverted / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[1]), coloredRectangle, 285f, ((this.valConverted - 4.1666f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[2]), coloredRectangle, 300f, ((this.valConverted - 8.3332f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[3]), coloredRectangle, 315f, ((this.valConverted - 12.4999f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[4]), coloredRectangle, 330f, ((this.valConverted - 16.6664f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[5]), coloredRectangle, 345f, ((this.valConverted - 20.8331f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[6]), coloredRectangle, 0f, ((this.valConverted - 24.9997f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[7]), coloredRectangle, 15f, ((this.valConverted - 29.1662f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[8]), coloredRectangle, 30f, ((this.valConverted - 33.3325f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[9]), coloredRectangle, 45f, ((this.valConverted - 37.4991f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[10]), coloredRectangle, 60f, ((this.valConverted - 41.6657f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[11]), coloredRectangle, 75f, ((this.valConverted - 45.8322f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[12]), coloredRectangle, 90f, ((this.valConverted - 49.9989f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                        g.FillPie(new SolidBrush(MCEx_Colors[13]), coloredRectangle, 105f, ((this.valConverted - 54.1655f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[14]), coloredRectangle, 120f, ((this.valConverted - 58.3321f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[15]), coloredRectangle, 135f, ((this.valConverted - 62.4987f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[16]), coloredRectangle, 150f, ((this.valConverted - 66.6653f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[17]), coloredRectangle, 165f, ((this.valConverted - 70.8319f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[18]), coloredRectangle, 180f, ((this.valConverted - 74.9985f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[19]), coloredRectangle, 195f, ((this.valConverted - 79.1651f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[20]), coloredRectangle, 210f, ((this.valConverted - 83.3316f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                        g.FillPie(new SolidBrush(MCEx_Colors[21]), coloredRectangle, 225f, ((this.valConverted - 87.4983f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[22]), coloredRectangle, 240f, ((this.valConverted - 91.6649f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                        g.FillPie(new SolidBrush(MCEx_Colors[23]), coloredRectangle, 255f, ((this.valConverted - 95.8315f) / 4.1666f) * 15);
                        //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                    }

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Default:

                    g.FillPie(new SolidBrush(Color.Transparent), coloredRectangle, 270f, 360f);
                    //g.DrawPie(new Pen(Color.Black, 2), coloredRectangle, 270f, 90f);

                    g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                    g.DrawEllipse(new Pen(Color.Gray, 2), rect);

                    break;
            }

            if (MCEx_ShowInnerBorder)
            {
                g.FillEllipse(new SolidBrush(MCEx_InnerColor), rect);
                g.DrawEllipse(new Pen(MCEx_InnerBorderColor, MCEx_InnerBorder), rect);
            }

            else
            {
                g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                g.DrawEllipse(new Pen(Color.Transparent, MCEx_InnerBorder), rect);

            }


            if (ShowText)
            {
                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font,
                    new SolidBrush(ForeColor), this.ClientRectangle);
            }

        }
        
        #endregion

    }


}
