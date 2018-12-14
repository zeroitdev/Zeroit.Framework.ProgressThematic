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
using Zeroit.Framework.Functions;
using Zeroit.Framework.Transitions.WinformAnimation;



#endregion

namespace Zeroit.Framework.ProgressThematic
{
    public partial class ThematicProgress
    {

        #region Private Properties



        //private bool MC_ShowInnerBorder = true;

        //public int speed = 100;

        //private int MC_InnerBorder = 2;

        //private int MC_Shift = 15;

        //private int MC_CorrectShift = 6;

        //private int MC_RectShift = 3;

        //private Rings MC_NoOfRings = Rings.One;

        //Color[] MC_Colors = new Color[]
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

        private float[] MC_oneRinga = new float[] { 270f };
        private float[] MC_oneRingb = new float[] { 0f };
        private float MC_oneRingMax = 360;

        private float[] MC_twoRinga = new float[] { 270f, 0f };
        private float[] MC_twoRingb = new float[] { 90f, 0f };
        private float MC_twoRingMax = 180;

        private float[] MC_fourRinga = new float[] { 270f, 0f, 90f, 180f };
        private float[] MC_fourRingb = new float[] { 0f, 0f, 0f, 0f };
        private float MC_fourRingMax = 90;

        private float[] MC_eightRinga = new float[] { 270f, 315f, 0f, 45f, 90f, 135f, 180f, 225f };
        private float[] MC_eightRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MC_eightRingMax = 45;

        private float[] MC_twelveRinga = new float[] { 270f, 300f, 330f, 0f, 30f, 60f, 90f, 120f, 150f, 180f, 210f, 240f };
        private float[] MC_twelveRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MC_twelveRingMax = 30;



        private float[] MC_twentyFourRinga = new float[] { 270f, 285f, 300f, 315f, 330f, 345f, 0f, 15f, 30f, 45f, 60f, 75f, 90f, 105f, 120f, 135f, 150f, 165f, 180f, 195f, 210, 225, 240f, 255 };
        private float[] MC_twentyFourRingb = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
        private float MC_twentyFourRingMax = 15;
        #endregion

        #region Public Properties


        //public int Speed
        //{
        //    get { return speed; }
        //    set
        //    {
        //        speed = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress MC")]
        public Color[] MC_Colors
        {
            get { return progressInput.MC_Colors; }
            set
            {
                progressInput.MC_Colors = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public Rings MC_NoOfRings
        {
            get { return progressInput.MC_NoOfRings; }
            set
            {
                progressInput.MC_NoOfRings = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public bool MC_ShowInnerBorder
        {
            get { return progressInput.MC_ShowInnerBorder; }
            set
            {
                progressInput.MC_ShowInnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public int MC_InnerBorder
        {
            get { return progressInput.MC_InnerBorder; }
            set
            {
                progressInput.MC_InnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public int MC_CorrectShift
        {
            get { return progressInput.MC_CorrectShift; }
            set
            {
                progressInput.MC_CorrectShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public int MC_Shift
        {
            get { return progressInput.MC_Shift; }
            set
            {
                progressInput.MC_Shift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MC")]
        public int MC_RectShift
        {
            get { return progressInput.MC_RectShift; }
            set
            {
                progressInput.MC_RectShift = value;
                Invalidate();
            }
        }


        #endregion
        

        public void ZeroitProgressMultiCo()
        {

            
            

        }
        

        #region Animation Event

        private void MultiCo_Timer_Tick(object sender, EventArgs e)
        {

            switch (MC_NoOfRings)
            {
                case Rings.Default:
                    break;
                case Rings.One:
                    if (this.MC_oneRingb[0] + 1 > MC_oneRingMax)
                    {
                        this.MC_oneRingb[0] = 0;
                    }

                    else
                    {
                        this.MC_oneRingb[0]++;
                        Invalidate();
                    }
                    break;
                case Rings.Two:

                    if (this.MC_twoRinga[1] + 1 > MC_twoRingMax)
                    {
                        this.MC_twoRinga[1] = MC_twoRingMax;

                        if (MC_twoRinga[1] + 1 > MC_twoRingMax)
                        {
                            this.MC_twoRingb[1]++;
                            Invalidate();

                            if (MC_twoRingb[1] + 1 > MC_twoRingMax)
                            {
                                this.MC_twoRinga[1] = 0f;
                                this.MC_twoRingb[1] = 0f;
                                Invalidate();
                            }
                        }


                        //else
                        //{
                        //    this.MC_twoRinga[1]++;
                        //    Invalidate();
                        //}



                    }

                    else
                    {
                        this.MC_twoRinga[1]++;
                        Invalidate();
                    }

                    break;
                case Rings.Four:

                    if (this.MC_fourRingb[0] + 1 > MC_fourRingMax)
                    {
                        this.MC_fourRingb[0] = MC_fourRingMax;

                        if (MC_fourRingb[0] + 1 > MC_fourRingMax)
                        {
                            this.MC_fourRingb[1]++;
                            Invalidate();

                            if (MC_fourRingb[1] + 1 > MC_fourRingMax)
                            {
                                this.MC_fourRingb[2]++;
                                Invalidate();

                                if (MC_fourRingb[2] + 1 > MC_fourRingMax)
                                {
                                    this.MC_fourRingb[3]++;
                                    Invalidate();

                                    if (MC_fourRingb[3] + 1 > MC_fourRingMax)
                                    {
                                        this.MC_fourRingb[0] = 0f;
                                        this.MC_fourRingb[1] = 0f;
                                        this.MC_fourRingb[2] = 0f;
                                        this.MC_fourRingb[3] = 0f;
                                        Invalidate();
                                    }

                                }

                            }
                        }


                        //else
                        //{
                        //    this.MC_twoRinga[1]++;
                        //    Invalidate();
                        //}



                    }

                    else
                    {
                        this.MC_fourRingb[0]++;
                        Invalidate();
                    }

                    break;
                case Rings.Eight:

                    if (this.MC_eightRingb[0] + 1 > MC_eightRingMax)
                    {
                        this.MC_eightRingb[0] = MC_eightRingMax;

                        if (MC_eightRingb[0] + 1 > MC_eightRingMax)
                        {
                            this.MC_eightRingb[1]++;
                            Invalidate();

                            if (MC_eightRingb[1] + 1 > MC_eightRingMax)
                            {

                                this.MC_eightRingb[2]++;
                                Invalidate();

                                if (MC_eightRingb[2] + 1 > MC_eightRingMax)
                                {

                                    this.MC_eightRingb[3]++;
                                    Invalidate();

                                    if (MC_eightRingb[3] + 1 > MC_eightRingMax)
                                    {
                                        this.MC_eightRingb[3] = MC_eightRingMax;
                                        this.MC_eightRingb[4]++;
                                        Invalidate();

                                        if (MC_eightRingb[4] + 1 > MC_eightRingMax)
                                        {
                                            this.MC_eightRingb[4] = MC_eightRingMax;
                                            this.MC_eightRingb[5]++;
                                            Invalidate();

                                            if (MC_eightRingb[5] + 1 > MC_eightRingMax)
                                            {
                                                this.MC_eightRingb[6]++;
                                                Invalidate();

                                                if (MC_eightRingb[6] + 1 > MC_eightRingMax)
                                                {
                                                    this.MC_eightRingb[7]++;
                                                    Invalidate();

                                                    if (MC_eightRingb[7] + 1 > MC_eightRingMax)
                                                    {
                                                        this.MC_eightRingb[0] = 0f;
                                                        this.MC_eightRingb[1] = 0f;
                                                        this.MC_eightRingb[2] = 0f;
                                                        this.MC_eightRingb[3] = 0f;
                                                        this.MC_eightRingb[4] = 0f;
                                                        this.MC_eightRingb[5] = 0f;
                                                        this.MC_eightRingb[6] = 0f;
                                                        this.MC_eightRingb[7] = 0f;
                                                        Invalidate();

                                                    }

                                                }
                                            }
                                        }


                                    }

                                }

                            }
                        }


                        //else
                        //{
                        //    this.MC_twoRinga[1]++;
                        //    Invalidate();
                        //}



                    }

                    else
                    {
                        this.MC_eightRingb[0]++;
                        Invalidate();
                    }

                    break;
                case Rings.Twelve:

                    if (this.MC_twelveRingb[0] + 1 > MC_twelveRingMax)
                    {
                        this.MC_twelveRingb[0] = MC_twelveRingMax;

                        if (MC_twelveRingb[0] + 1 > MC_twelveRingMax)
                        {
                            this.MC_twelveRingb[1]++;
                            Invalidate();

                            if (MC_twelveRingb[1] + 1 > MC_twelveRingMax)
                            {

                                this.MC_twelveRingb[2]++;
                                Invalidate();

                                if (MC_twelveRingb[2] + 1 > MC_twelveRingMax)
                                {

                                    this.MC_twelveRingb[3]++;
                                    Invalidate();

                                    if (MC_twelveRingb[3] + 1 > MC_twelveRingMax)
                                    {
                                        this.MC_twelveRingb[3] = MC_twelveRingMax;
                                        this.MC_twelveRingb[4]++;
                                        Invalidate();

                                        if (MC_twelveRingb[4] + 1 > MC_twelveRingMax)
                                        {
                                            this.MC_twelveRingb[4] = MC_twelveRingMax;
                                            this.MC_twelveRingb[5]++;
                                            Invalidate();

                                            if (MC_twelveRingb[5] + 1 > MC_twelveRingMax)
                                            {
                                                this.MC_twelveRingb[6]++;
                                                Invalidate();

                                                if (MC_twelveRingb[6] + 1 > MC_twelveRingMax)
                                                {
                                                    this.MC_twelveRingb[7]++;
                                                    Invalidate();

                                                    if (MC_twelveRingb[7] + 1 > MC_twelveRingMax)
                                                    {
                                                        this.MC_twelveRingb[8]++;
                                                        Invalidate();

                                                        if (MC_twelveRingb[8] + 1 > MC_twelveRingMax)
                                                        {
                                                            this.MC_twelveRingb[9]++;
                                                            Invalidate();

                                                            if (MC_twelveRingb[9] + 1 > MC_twelveRingMax)
                                                            {
                                                                this.MC_twelveRingb[10]++;
                                                                Invalidate();

                                                                if (MC_twelveRingb[10] + 1 > MC_twelveRingMax)
                                                                {
                                                                    this.MC_twelveRingb[11]++;
                                                                    Invalidate();

                                                                    if (MC_twelveRingb[11] + 1 > MC_twelveRingMax)
                                                                    {
                                                                        this.MC_twelveRingb[0] = 0f;
                                                                        this.MC_twelveRingb[1] = 0f;
                                                                        this.MC_twelveRingb[2] = 0f;
                                                                        this.MC_twelveRingb[3] = 0f;
                                                                        this.MC_twelveRingb[4] = 0f;
                                                                        this.MC_twelveRingb[5] = 0f;
                                                                        this.MC_twelveRingb[6] = 0f;
                                                                        this.MC_twelveRingb[7] = 0f;
                                                                        this.MC_twelveRingb[8] = 0f;
                                                                        this.MC_twelveRingb[9] = 0f;
                                                                        this.MC_twelveRingb[10] = 0f;
                                                                        this.MC_twelveRingb[11] = 0f;

                                                                        Invalidate();
                                                                    }
                                                                }
                                                            }
                                                        }



                                                    }

                                                }
                                            }
                                        }


                                    }

                                }

                            }
                        }


                        //else
                        //{
                        //    this.MC_twoRinga[1]++;
                        //    Invalidate();
                        //}



                    }

                    else
                    {
                        this.MC_twelveRingb[0]++;
                        Invalidate();
                    }

                    break;
                case Rings.TwentyFour:

                    if (this.MC_twentyFourRingb[0] + 1 > MC_twentyFourRingMax)
                    {
                        this.MC_twentyFourRingb[0] = MC_twentyFourRingMax;

                        if (MC_twentyFourRingb[0] + 1 > MC_twentyFourRingMax)
                        {
                            this.MC_twentyFourRingb[1]++;
                            Invalidate();

                            if (MC_twentyFourRingb[1] + 1 > MC_twentyFourRingMax)
                            {

                                this.MC_twentyFourRingb[2]++;
                                Invalidate();

                                if (MC_twentyFourRingb[2] + 1 > MC_twentyFourRingMax)
                                {

                                    this.MC_twentyFourRingb[3]++;
                                    Invalidate();

                                    if (MC_twentyFourRingb[3] + 1 > MC_twentyFourRingMax)
                                    {
                                        this.MC_twentyFourRingb[3] = MC_twentyFourRingMax;
                                        this.MC_twentyFourRingb[4]++;
                                        Invalidate();

                                        if (MC_twentyFourRingb[4] + 1 > MC_twentyFourRingMax)
                                        {
                                            this.MC_twentyFourRingb[4] = MC_twentyFourRingMax;
                                            this.MC_twentyFourRingb[5]++;
                                            Invalidate();

                                            if (MC_twentyFourRingb[5] + 1 > MC_twentyFourRingMax)
                                            {
                                                this.MC_twentyFourRingb[6]++;
                                                Invalidate();

                                                if (MC_twentyFourRingb[6] + 1 > MC_twentyFourRingMax)
                                                {
                                                    this.MC_twentyFourRingb[7]++;
                                                    Invalidate();

                                                    if (MC_twentyFourRingb[7] + 1 > MC_twentyFourRingMax)
                                                    {
                                                        this.MC_twentyFourRingb[8]++;
                                                        Invalidate();

                                                        if (MC_twentyFourRingb[8] + 1 > MC_twentyFourRingMax)
                                                        {
                                                            this.MC_twentyFourRingb[9]++;
                                                            Invalidate();

                                                            if (MC_twentyFourRingb[9] + 1 > MC_twentyFourRingMax)
                                                            {
                                                                this.MC_twentyFourRingb[10]++;
                                                                Invalidate();

                                                                if (MC_twentyFourRingb[10] + 1 > MC_twentyFourRingMax)
                                                                {
                                                                    this.MC_twentyFourRingb[11]++;
                                                                    Invalidate();

                                                                    if (MC_twentyFourRingb[11] + 1 > MC_twentyFourRingMax)
                                                                    {
                                                                        this.MC_twentyFourRingb[12]++;
                                                                        Invalidate();

                                                                        if (MC_twentyFourRingb[12] + 1 > MC_twentyFourRingMax)
                                                                        {
                                                                            this.MC_twentyFourRingb[13]++;
                                                                            Invalidate();

                                                                            if (MC_twentyFourRingb[13] + 1 > MC_twentyFourRingMax)
                                                                            {

                                                                                this.MC_twentyFourRingb[14]++;
                                                                                Invalidate();

                                                                                if (MC_twentyFourRingb[14] + 1 > MC_twentyFourRingMax)
                                                                                {

                                                                                    this.MC_twentyFourRingb[15]++;
                                                                                    Invalidate();

                                                                                    if (MC_twentyFourRingb[15] + 1 > MC_twentyFourRingMax)
                                                                                    {

                                                                                        this.MC_twentyFourRingb[16]++;
                                                                                        Invalidate();

                                                                                        if (MC_twentyFourRingb[16] + 1 > MC_twentyFourRingMax)
                                                                                        {

                                                                                            this.MC_twentyFourRingb[17]++;
                                                                                            Invalidate();

                                                                                            if (MC_twentyFourRingb[17] + 1 > MC_twentyFourRingMax)
                                                                                            {
                                                                                                this.MC_twentyFourRingb[18]++;
                                                                                                Invalidate();

                                                                                                if (MC_twentyFourRingb[18] + 1 > MC_twentyFourRingMax)
                                                                                                {
                                                                                                    this.MC_twentyFourRingb[19]++;
                                                                                                    Invalidate();

                                                                                                    if (MC_twentyFourRingb[19] + 1 > MC_twentyFourRingMax)
                                                                                                    {
                                                                                                        this.MC_twentyFourRingb[20]++;
                                                                                                        Invalidate();

                                                                                                        if (MC_twentyFourRingb[20] + 1 > MC_twentyFourRingMax)
                                                                                                        {
                                                                                                            this.MC_twentyFourRingb[21]++;
                                                                                                            Invalidate();

                                                                                                            if (MC_twentyFourRingb[21] + 1 > MC_twentyFourRingMax)
                                                                                                            {
                                                                                                                this.MC_twentyFourRingb[22]++;
                                                                                                                Invalidate();

                                                                                                                if (MC_twentyFourRingb[22] + 1 > MC_twentyFourRingMax)
                                                                                                                {
                                                                                                                    this.MC_twentyFourRingb[23]++;
                                                                                                                    Invalidate();

                                                                                                                    if (MC_twentyFourRingb[23] + 1 > MC_twentyFourRingMax)
                                                                                                                    {
                                                                                                                        this.MC_twentyFourRingb[0] = 0f;
                                                                                                                        this.MC_twentyFourRingb[1] = 0f;
                                                                                                                        this.MC_twentyFourRingb[2] = 0f;
                                                                                                                        this.MC_twentyFourRingb[3] = 0f;
                                                                                                                        this.MC_twentyFourRingb[4] = 0f;
                                                                                                                        this.MC_twentyFourRingb[5] = 0f;
                                                                                                                        this.MC_twentyFourRingb[6] = 0f;
                                                                                                                        this.MC_twentyFourRingb[7] = 0f;
                                                                                                                        this.MC_twentyFourRingb[8] = 0f;
                                                                                                                        this.MC_twentyFourRingb[9] = 0f;
                                                                                                                        this.MC_twentyFourRingb[10] = 0f;
                                                                                                                        this.MC_twentyFourRingb[11] = 0f;
                                                                                                                        this.MC_twentyFourRingb[12] = 0f;
                                                                                                                        this.MC_twentyFourRingb[13] = 0f;
                                                                                                                        this.MC_twentyFourRingb[14] = 0f;
                                                                                                                        this.MC_twentyFourRingb[15] = 0f;
                                                                                                                        this.MC_twentyFourRingb[16] = 0f;
                                                                                                                        this.MC_twentyFourRingb[17] = 0f;
                                                                                                                        this.MC_twentyFourRingb[18] = 0f;
                                                                                                                        this.MC_twentyFourRingb[19] = 0f;
                                                                                                                        this.MC_twentyFourRingb[20] = 0f;
                                                                                                                        this.MC_twentyFourRingb[21] = 0f;
                                                                                                                        this.MC_twentyFourRingb[22] = 0f;
                                                                                                                        this.MC_twentyFourRingb[23] = 0f;


                                                                                                                        Invalidate();
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }



                                                                                                    }

                                                                                                }
                                                                                            }
                                                                                        }


                                                                                    }

                                                                                }

                                                                            }
                                                                        }


                                                                    }
                                                                }
                                                            }
                                                        }



                                                    }

                                                }
                                            }
                                        }


                                    }

                                }

                            }
                        }


                        //else
                        //{
                        //    this.MC_twoRinga[1]++;
                        //    Invalidate();
                        //}



                    }

                    else
                    {
                        this.MC_twentyFourRingb[0]++;
                        Invalidate();
                    }


                    break;
                default:
                    break;
            }


        }

        #endregion
        

        private void MultiCo_Paint(PaintEventArgs e)
        {
            
            //timer.Interval = speed;

            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.Clear(BackColor);


            Rectangle rect = new Rectangle(MC_CorrectShift, MC_CorrectShift, Width - MC_Shift, Height - MC_Shift);
            Rectangle coloredRectangle = new Rectangle(0, 0, Width - MC_RectShift, Height - MC_RectShift);



            if (MC_ShowInnerBorder)
            {
                g.FillEllipse(new SolidBrush(Color.Blue), rect);
                g.DrawEllipse(new Pen(Color.Black, MC_InnerBorder), rect);
            }

            else
            {
                g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                g.DrawEllipse(new Pen(Color.Transparent, MC_InnerBorder), rect);

            }


            switch (MC_NoOfRings)
            {
                case Rings.One:

                    #region 1 ring

                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, MC_oneRinga[0], MC_oneRingb[0]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Two:

                    #region 2 rings

                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, 270f, MC_twoRinga[1]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[1]), coloredRectangle, 90f, MC_twoRingb[1]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Four:

                    #region 4 rings

                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, 270f, MC_fourRingb[0]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[1]), coloredRectangle, 0f, MC_fourRingb[1]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[2]), coloredRectangle, 90f, MC_fourRingb[2]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[3]), coloredRectangle, 180f, MC_fourRingb[3]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Eight:


                    #region 8 Rings
                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, 270f, MC_eightRingb[0]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[1]), coloredRectangle, 315f, MC_eightRingb[1]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[2]), coloredRectangle, 0f, MC_eightRingb[2]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[3]), coloredRectangle, 45f, MC_eightRingb[3]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[4]), coloredRectangle, 90f, MC_eightRingb[4]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[5]), coloredRectangle, 135f, MC_eightRingb[5]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[6]), coloredRectangle, 180f, MC_eightRingb[6]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[7]), coloredRectangle, 225f, MC_eightRingb[7]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Twelve:

                    #region 12 Rings
                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, 270f, MC_twelveRingb[0]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[1]), coloredRectangle, 300f, MC_twelveRingb[1]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[2]), coloredRectangle, 330f, MC_twelveRingb[2]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[3]), coloredRectangle, 0f, MC_twelveRingb[3]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[4]), coloredRectangle, 30f, MC_twelveRingb[4]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[5]), coloredRectangle, 60f, MC_twelveRingb[5]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[6]), coloredRectangle, 90f, MC_twelveRingb[6]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[7]), coloredRectangle, 120f, MC_twelveRingb[7]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[8]), coloredRectangle, 150f, MC_twelveRingb[8]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);


                    g.FillPie(new SolidBrush(MC_Colors[9]), coloredRectangle, 180f, MC_twelveRingb[9]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[10]), coloredRectangle, 210f, MC_twelveRingb[10]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[11]), coloredRectangle, 240f, MC_twelveRingb[11]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.TwentyFour:

                    #region 24 Rings
                    g.FillPie(new SolidBrush(MC_Colors[0]), coloredRectangle, 270f, MC_twentyFourRingb[0]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[1]), coloredRectangle, 285f, MC_twentyFourRingb[1]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[2]), coloredRectangle, 300f, MC_twentyFourRingb[2]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[3]), coloredRectangle, 315f, MC_twentyFourRingb[3]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[4]), coloredRectangle, 330f, MC_twentyFourRingb[4]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[5]), coloredRectangle, 345f, MC_twentyFourRingb[5]);
                    //g.DrawPie(new Pen(Color.Yellow, 2), coloredRectangle, 270f, 90f);



                    g.FillPie(new SolidBrush(MC_Colors[6]), coloredRectangle, 0f, MC_twentyFourRingb[6]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[7]), coloredRectangle, 15f, MC_twentyFourRingb[7]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[8]), coloredRectangle, 30f, MC_twentyFourRingb[8]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[9]), coloredRectangle, 45f, MC_twentyFourRingb[9]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[10]), coloredRectangle, 60f, MC_twentyFourRingb[10]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[11]), coloredRectangle, 75f, MC_twentyFourRingb[11]);
                    //g.DrawPie(new Pen(Color.Red, 2), coloredRectangle, 0f, 90f);



                    g.FillPie(new SolidBrush(MC_Colors[12]), coloredRectangle, 90f, MC_twentyFourRingb[12]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[13]), coloredRectangle, 105f, MC_twentyFourRingb[13]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[14]), coloredRectangle, 120f, MC_twentyFourRingb[14]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[15]), coloredRectangle, 135f, MC_twentyFourRingb[15]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[16]), coloredRectangle, 150f, MC_twentyFourRingb[16]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[17]), coloredRectangle, 165f, MC_twentyFourRingb[17]);
                    //g.DrawPie(new Pen(Color.Coral, 2), coloredRectangle, 90f, 90f);



                    g.FillPie(new SolidBrush(MC_Colors[18]), coloredRectangle, 180f, MC_twentyFourRingb[18]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[19]), coloredRectangle, 195f, MC_twentyFourRingb[19]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[20]), coloredRectangle, 210f, MC_twentyFourRingb[20]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 

                    g.FillPie(new SolidBrush(MC_Colors[21]), coloredRectangle, 225f, MC_twentyFourRingb[21]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[22]), coloredRectangle, 240f, MC_twentyFourRingb[22]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f);

                    g.FillPie(new SolidBrush(MC_Colors[23]), coloredRectangle, 255f, MC_twentyFourRingb[23]);
                    //g.DrawPie(new Pen(Color.BlueViolet, 2), coloredRectangle, 180f, 90f); 


                    g.FillEllipse(new SolidBrush(BackColor), rect);
                    //g.DrawEllipse(new Pen(BackColor, 1), rect);

                    #endregion

                    break;
                case Rings.Default:

                    g.FillPie(new SolidBrush(Color.Gray), coloredRectangle, 270f, 360f);
                    //g.DrawPie(new Pen(Color.Black, 2), coloredRectangle, 270f, 90f);


                    g.FillEllipse(new SolidBrush(Color.Transparent), rect);
                    g.DrawEllipse(new Pen(Color.Black, 2), rect);

                    break;
            }


        }



    }

}
