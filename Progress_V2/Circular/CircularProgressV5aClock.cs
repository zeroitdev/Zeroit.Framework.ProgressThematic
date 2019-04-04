// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV5aClock.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region CircularProgressv5aClock

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {


        #region Include in Private Field

        /// <summary>
        /// The marquee angle
        /// </summary>
        private int marqueeAngle = 90;

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the CircularProgressv5aClock_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CircularProgressv5aClock_Timer_Tick(object sender, EventArgs e)
        {
            
            string DateTime = System.DateTime.Now.ToString("HH:mm:ss");
            string Hour = System.DateTime.Now.ToString("HH");
            string Minute = System.DateTime.Now.ToString("mm");
            string Second = System.DateTime.Now.ToString("ss");

            Bar3.Enabled = true;
            Bar2.Enabled = true;

            Bar3.Value = Convert.ToInt32(Hour) + 30;
            Bar2.Value = Convert.ToInt32(Minute);
            Bar1.Value = Convert.ToInt32(Second);

            Bar2.ActiveColor = Color.Yellow;

            Bar3.ActiveColor = Color.Red;


            DisplayPercentage = false;


            Text = DateTime.ToString();


        }



        #endregion

        #region "Declares"

        //private Size minimumSizeAllowed;
        //private Size _minimumSize;
        //private int _barCount = 4;
        //private BarData[] _bars = new BarData[5];
        //private System.Timers.Timer _smoothTimer;
        //private bool BorderEnabled = false;
        //private Image _image = null;
        //private int Seperation = 1;
        //private int BarWidth = 4;
        //private bool DisplayPercentage = true;
        //private bool DisplayTotalPercentage = false;
        //private bool _smoothBars = false;
        //private string Info = "Data";
        //private bool TextShadow = false;
        //private Color TextShadowColor = Color.White;
        //private bool InactiveColorEnabled = true;

        //private bool _imageEnabled = true;

        //float[] realPercentage;
        //float[] setPercentage;
        //float[] currentAngle;
        //float[] remainderAngle;
        #endregion

        #region "Constructor"

        //public void CircularProgressBarv5Clock()
        //{


        //    //for (int i = 0; i <= _bars.Count() - 1; i++)
        //    //{
        //    //    _bars[i] = new BarData(i + 1);
        //    //    _bars[i].PropertyChanged += Bars_PropertyChanged;
        //    //}

        //    //Size = new Size(150, 150);
        //    //Font = new Font("Verdana", 14f);
        //    //_smoothTimer = new System.Timers.Timer();
        //    //_smoothTimer.Elapsed += Smoother_Tick;
        //    //_smoothTimer.Enabled = false;
        //    //_smoothTimer.Interval = 1;



        //    //#region Timer
        //    //if (DesignMode)
        //    //{
        //    //    timer.Enabled = true;
        //    //    timer.Start();
        //    //    timer.Tick += Timer_Tick;

        //    //    timer.Interval = 100;


        //    //}

        //    //if (!DesignMode)
        //    //{
        //    //    timer.Enabled = true;
        //    //    timer.Start();
        //    //    timer.Tick += Timer_Tick;

        //    //    timer.Interval = 100;
        //    //}





        //    //#endregion



        //    //SetMinimumSize();
        //}

        #endregion

        #region "Overrides"


        /// <summary>
        /// Circulars the progressv5a clock paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CircularProgressv5aClock_Paint(PaintEventArgs e)
        {
            
            int circleSize = BarWidth;
            realPercentage = new float[_barCount + 1];
            setPercentage = new float[_barCount + 1];
            currentAngle = new float[_barCount + 1];
            remainderAngle = new float[_barCount + 1];

            for (int i = 0; i <= _barCount; i++)
            {
                if (!_bars[i].Enabled)
                    continue;
                //setPercentage[i] = (_bars[i].SmoothValue / _bars[i].Maximum) * 100;
                //realPercentage[i] = (_bars[i].Value / _bars[i].Maximum) * 100;
                //currentAngle[i] = Convert.ToSingle(360 / 100 * setPercentage[i]);
                //remainderAngle[i] = 360 - currentAngle[i];
                //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

                setPercentage[i] = _bars[i].Value * 1.68f;

                currentAngle[i] = Convert.ToSingle(360 * (setPercentage[i] / _bars[i].Maximum));

                remainderAngle[i] = 360 - Convert.ToInt32(currentAngle[i]);
            }

            //Bitmap B = new Bitmap(Width, Height);

            Graphics G = e.Graphics;

            //G.TextRenderingHint = TextRendering;

            //G.SmoothingMode = SmoothingMode.HighQuality;
            //if (BackColor != Color.Transparent)
            //{
            //    G.Clear(BackColor);
            //}

            if (AllowTransparency)
            {
                MakeTransparent(this, G);
            }

            for (int i = 0; i <= _barCount; i++)
            {
                if (!_bars[i].Enabled)
                    continue;
                Color colorToUse = default(Color);
                if (_bars[i].SmoothValue >= _bars[i].Maximum)
                {
                    colorToUse = _bars[i].FinishColor;
                }
                else
                {
                    colorToUse = _bars[i].ActiveColor;
                }

                using (Pen progressPen = new Pen(colorToUse, circleSize))
                {
                    using (Pen remainderPen = new Pen(_bars[i].InactiveColor, circleSize))
                    {
                        using (Pen BorderPen = new Pen(_bars[i].BorderColor, circleSize + 2))
                        {
                            if (BorderEnabled)
                            {
                                if (InactiveColorEnabled)
                                {
                                    G.DrawArc(BorderPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), 0, 360);
                                }
                                else
                                {
                                    G.DrawArc(BorderPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), -marqueeAngle, currentAngle[i]);
                                }
                            }
                            G.DrawArc(progressPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), -marqueeAngle, currentAngle[i]);
                            if (InactiveColorEnabled)
                                G.DrawArc(remainderPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), currentAngle[i] - marqueeAngle, remainderAngle[i]);
                        }
                    }
                }
            }

            if (Image != null)
                G.DrawImage(Image, new Point(Convert.ToInt32(Width / 2) - (Image.Width / 2), Convert.ToInt32(Height / 2) - (Image.Height / 2)));

            using (Font fnt = new Font(Font.FontFamily, Font.Size))
            {
                string textDisplay = string.Empty;

                if (DisplayPercentage)
                {
                    if (DisplayTotalPercentage)
                    {
                        int percentageCalculate = 0;
                        for (int i = 0; i <= _barCount; i++)
                        {
                            if (!_bars[i].Enabled)
                                continue;
                            percentageCalculate += (int)setPercentage[i];
                        }
                        percentageCalculate /= _barCount;
                        textDisplay += percentageCalculate.ToString() + "%";
                    }
                    else
                    {
                        for (int i = 0; i <= _barCount; i++)
                        {
                            if (!_bars[i].Enabled)
                                continue;
                            if (textDisplay == string.Empty)
                            {
                                textDisplay += setPercentage[i].ToString() + "%";
                            }
                            else
                            {
                                textDisplay += Constants.vbNewLine + setPercentage[i].ToString() + "%";
                            }
                        }
                    }
                }
                else
                {
                    textDisplay = Info;
                }
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                Rectangle textRect = new Rectangle(0, 0, Width, Height);
                if (TextShadow)
                {
                    Rectangle textRectShadow = new Rectangle(1, 1, Width, Height);
                    G.DrawString(textDisplay, fnt, new SolidBrush(TextShadowColor), textRectShadow, stringFormat);
                }
                G.DrawString(textDisplay, fnt, new SolidBrush(ForeColor), textRect, stringFormat);
            }
            //e.Graphics.DrawImageUnscaled(B, 0, 0);


        }

        
        #endregion

        



    }

    #endregion
}
