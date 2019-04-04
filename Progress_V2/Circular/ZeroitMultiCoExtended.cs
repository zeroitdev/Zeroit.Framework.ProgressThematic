// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended.cs" company="Zeroit Dev Technologies">
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
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Private Properties

        //private float value = 0;

        //private bool MCEx_ShowInnerBorder = true;

        //public int speed = 100;

        //private int MCEx_InnerBorder = 2;

        //private int MCEx_Shift = 15;

        //private int MCEx_CorrectShift = 6;

        //private int MCEx_RectShift = 3;

        //private Rings MCEx_NoOfRings = Rings.One;

        //private Color MCEx_InnerBorderColor = Color.Gray;

        //Color[] MCEx_Colors = new Color[]
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

        /// <summary>
        /// Gets or sets the color of the mc ex inner.
        /// </summary>
        /// <value>The color of the mc ex inner.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public Color MCEx_InnerColor
        {
            get { return progressInput.MCEx_InnerColor; }
            set
            {
                progressInput.MCEx_InnerColor = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the mc ex inner border.
        /// </summary>
        /// <value>The color of the mc ex inner border.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public Color MCEx_InnerBorderColor
        {
            get { return progressInput.MCEx_InnerBorderColor; }
            set
            {
                progressInput.MCEx_InnerBorderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex position horizontal.
        /// </summary>
        /// <value>The mc ex position horizontal.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_Position_Horizontal
        {
            get { return progressInput.MCEx_Position_Horizontal; }
            set
            {
                progressInput.MCEx_Position_Horizontal = value;

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex position vertical.
        /// </summary>
        /// <value>The mc ex position vertical.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_Position_Vertical
        {
            get { return progressInput.MCEx_Position_Vertical; }
            set
            {
                progressInput.MCEx_Position_Vertical = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex correct shift.
        /// </summary>
        /// <value>The height of the mc ex correct shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_CorrectShift_Height
        {
            get { return progressInput.MCEx_CorrectShift_Height; }
            set
            {
                progressInput.MCEx_CorrectShift_Height = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex shift.
        /// </summary>
        /// <value>The height of the mc ex shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_Shift_Height
        {
            get { return progressInput.MCEx_Shift_Height; }
            set
            {
                progressInput.MCEx_Shift_Height = value;
                Invalidate();

            }
        }

        /// <summary>
        /// Gets or sets the height of the mc ex rect shift.
        /// </summary>
        /// <value>The height of the mc ex rect shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_RectShift_Height
        {
            get { return progressInput.MCEx_RectShift_Height; }
            set
            {
                progressInput.MCEx_RectShift_Height = value;
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

        /// <summary>
        /// Gets or sets the mc ex colors.
        /// </summary>
        /// <value>The mc ex colors.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public Color[] MCEx_Colors
        {
            get { return progressInput.MCEx_Colors; }
            set
            {
                progressInput.MCEx_Colors = value;
                Invalidate();
            }
        }

        //public enum Rings
        //{
        //    Default,
        //    One,
        //    Two,
        //    Four,
        //    Eight,
        //    Twelve,
        //    TwentyFour
        //}

        /// <summary>
        /// Gets or sets the mc ex no of rings.
        /// </summary>
        /// <value>The mc ex no of rings.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public Rings MCEx_NoOfRings
        {
            get { return progressInput.MCEx_NoOfRings; }
            set
            {
                progressInput.MCEx_NoOfRings = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [mc ex show inner border].
        /// </summary>
        /// <value><c>true</c> if [mc ex show inner border]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public bool MCEx_ShowInnerBorder
        {
            get { return progressInput.MCEx_ShowInnerBorder; }
            set
            {
                progressInput.MCEx_ShowInnerBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex inner border.
        /// </summary>
        /// <value>The mc ex inner border.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_InnerBorder
        {
            get { return progressInput.MCEx_InnerBorder; }
            set
            {
                progressInput.MCEx_InnerBorder = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex inner shift.
        /// </summary>
        /// <value>The mc ex inner shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_InnerShift
        {
            get { return MCEx_RectShift; }
            set
            {
                MCEx_RectShift = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex correct shift.
        /// </summary>
        /// <value>The mc ex correct shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_CorrectShift
        {
            get { return progressInput.MCEx_CorrectShift; }
            set
            {
                progressInput.MCEx_CorrectShift = value;
                Invalidate();
            }
        }

        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_Shift
        {
            get { return progressInput.MCEx_Shift; }
            set
            {
                progressInput.MCEx_Shift = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the mc ex rect shift.
        /// </summary>
        /// <value>The mc ex rect shift.</value>
        [Category("CircularProgress MCEx")]
        [Browsable(false)]
        public int MCEx_RectShift
        {
            get { return progressInput.MCEx_RectShift; }
            set
            {
                progressInput.MCEx_RectShift = value;
                Invalidate();
            }
        }

        //public float ValueSets
        //{
        //    get { return valConverted; }
        //    set
        //    {
        //        if (value != null)
        //        {
        //            valConverted = value / Maximum * 100;
        //        }
        //        valConverted = value;
        //        Invalidate();
        //    }
        //}
        
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
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;
            //g.Clear(BackColor);

            if (AllowTransparency)
            {
                MakeTransparent(this, g);
            }

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
