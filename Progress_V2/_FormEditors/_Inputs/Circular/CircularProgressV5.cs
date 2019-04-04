// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV5.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Constructor

        /// <summary>
        /// Circulars the progress v5.
        /// </summary>
        public void CircularProgressV5()
        {
            //for (int i = 0; i <= _bars.Count() - 1; i++)
            //{
            //    _bars[i] = new BarData(i + 1);

            //}

            
        }

        #endregion

        #region Private Fields

        //private Size minimumSizeAllowed;
        /// <summary>
        /// The minimum size
        /// </summary>
        private Size _minimumSize = new Size(100,100);
        //private int _barCount = 4;
        //public BarData[] _bars = new BarData[5];
        /// <summary>
        /// The border enabled
        /// </summary>
        private bool _borderEnabled = false;
        //private Image _image;
        /// <summary>
        /// The bar seperation
        /// </summary>
        private int _barSeperation = 1;
        /// <summary>
        /// The bar width
        /// </summary>
        private int _barWidth = 4;
        /// <summary>
        /// The display percentage
        /// </summary>
        private bool _displayPercentage = true;
        /// <summary>
        /// The display total percentage
        /// </summary>
        private bool _displayTotalPercentage = false;
        /// <summary>
        /// The smooth bars
        /// </summary>
        private bool _smoothBars = false;
        /// <summary>
        /// The information
        /// </summary>
        private string _info = "Data";
        /// <summary>
        /// The text shadow
        /// </summary>
        private bool _textShadow = false;
        /// <summary>
        /// The text shadow color
        /// </summary>
        private Color _textShadowColor = Color.White;
        /// <summary>
        /// The inactive color enabled
        /// </summary>
        private bool _inactiveColorEnabled = true;
        /// <summary>
        /// The c PV5 marquee angle
        /// </summary>
        private int CPv5_marqueeAngle = 90;
        /// <summary>
        /// The c PV5 marquee
        /// </summary>
        private bool CPv5_marquee = false;
        /// <summary>
        /// The c PV5 marqueeinterval
        /// </summary>
        private int CPv5_marqueeinterval = 100;
        /// <summary>
        /// The c PV5 interval
        /// </summary>
        private int CPv5_interval = 100;
        /// <summary>
        /// The otherinterval
        /// </summary>
        private int otherinterval = 10;
        /// <summary>
        /// The c PV5 reset
        /// </summary>
        private bool CPv5_reset = false;
        /// <summary>
        /// The image enabled
        /// </summary>
        private bool _imageEnabled = false;

        //Enabling
        /// <summary>
        /// The bar1 enabling
        /// </summary>
        private bool bar1_Enabling = true;
        /// <summary>
        /// The bar2 enabling
        /// </summary>
        private bool bar2_Enabling = false;
        /// <summary>
        /// The bar3 enabling
        /// </summary>
        private bool bar3_Enabling = false;
        /// <summary>
        /// The bar4 enabling
        /// </summary>
        private bool bar4_Enabling = false;
        /// <summary>
        /// The bar5 enabling
        /// </summary>
        private bool bar5_Enabling = false;

        //Color - Active
        /// <summary>
        /// The bar1 active color
        /// </summary>
        private Color bar1_Active_Color = Color.LightSeaGreen;
        /// <summary>
        /// The bar2 active color
        /// </summary>
        private Color bar2_Active_Color = Color.LightSeaGreen;
        /// <summary>
        /// The bar3 active color
        /// </summary>
        private Color bar3_Active_Color = Color.LightSeaGreen;
        /// <summary>
        /// The bar4 active color
        /// </summary>
        private Color bar4_Active_Color = Color.LightSeaGreen;
        /// <summary>
        /// The bar5 active color
        /// </summary>
        private Color bar5_Active_Color = Color.LightSeaGreen;

        //Color - Finish
        /// <summary>
        /// The bar1 finish color
        /// </summary>
        private Color bar1_Finish_Color = Color.Lime;
        /// <summary>
        /// The bar2 finish color
        /// </summary>
        private Color bar2_Finish_Color = Color.Lime;
        /// <summary>
        /// The bar3 finish color
        /// </summary>
        private Color bar3_Finish_Color = Color.Lime;
        /// <summary>
        /// The bar4 finish color
        /// </summary>
        private Color bar4_Finish_Color = Color.Lime;
        /// <summary>
        /// The bar5 finish color
        /// </summary>
        private Color bar5_Finish_Color = Color.Lime;

        //Color - Border
        /// <summary>
        /// The bar1 border color
        /// </summary>
        private Color bar1_Border_Color = Color.Gray;
        /// <summary>
        /// The bar2 border color
        /// </summary>
        private Color bar2_Border_Color = Color.Gray;
        /// <summary>
        /// The bar3 border color
        /// </summary>
        private Color bar3_Border_Color = Color.Gray;
        /// <summary>
        /// The bar4 border color
        /// </summary>
        private Color bar4_Border_Color = Color.Gray;
        /// <summary>
        /// The bar5 border color
        /// </summary>
        private Color bar5_Border_Color = Color.Gray;

        //Color - Inactive
        /// <summary>
        /// The bar1 inactive color
        /// </summary>
        private Color bar1_Inactive_Color = Color.LightGray;
        /// <summary>
        /// The bar2 inactive color
        /// </summary>
        private Color bar2_Inactive_Color = Color.LightGray;
        /// <summary>
        /// The bar3 inactive color
        /// </summary>
        private Color bar3_Inactive_Color = Color.LightGray;
        /// <summary>
        /// The bar4 inactive color
        /// </summary>
        private Color bar4_Inactive_Color = Color.LightGray;
        /// <summary>
        /// The bar5 inactive color
        /// </summary>
        private Color bar5_Inactive_Color = Color.LightGray;

        //Smooth
        /// <summary>
        /// The bar1 smooth
        /// </summary>
        private int bar1_Smooth = 1;
        /// <summary>
        /// The bar2 smooth
        /// </summary>
        private int bar2_Smooth = 1;
        /// <summary>
        /// The bar3 smooth
        /// </summary>
        private int bar3_Smooth = 1;
        /// <summary>
        /// The bar4 smooth
        /// </summary>
        private int bar4_Smooth = 1;
        /// <summary>
        /// The bar5 smooth
        /// </summary>
        private int bar5_Smooth = 1;

        //Maximum
        /// <summary>
        /// The bar1 maximum
        /// </summary>
        private int bar1_Maximum = 100;
        /// <summary>
        /// The bar2 maximum
        /// </summary>
        private int bar2_Maximum = 100;
        /// <summary>
        /// The bar3 maximum
        /// </summary>
        private int bar3_Maximum = 100;
        /// <summary>
        /// The bar4 maximum
        /// </summary>
        private int bar4_Maximum = 100;
        /// <summary>
        /// The bar5 maximum
        /// </summary>
        private int bar5_Maximum = 100;

        //Value
        /// <summary>
        /// The bar1 value
        /// </summary>
        private int bar1_Value = 0;
        /// <summary>
        /// The bar2 value
        /// </summary>
        private int bar2_Value = 0;
        /// <summary>
        /// The bar3 value
        /// </summary>
        private int bar3_Value = 0;
        /// <summary>
        /// The bar4 value
        /// </summary>
        private int bar4_Value = 0;
        /// <summary>
        /// The bar5 value
        /// </summary>
        private int bar5_Value = 0;

        #endregion

        #region "Properties"

        //public BarData[] _bars
        //{
        //    get
        //    {
        //        return _bars;

        //    }
        //    set
        //    {
        //        _bars = value;
        //    }
        //}

        //public BarData[] Bars
        //{
        //    get { return _bars; }
        //    set
        //    {
        //        _bars = value;
        //    }
        //}

        /// <summary>
        /// Gets or sets the color of the text shadow.
        /// </summary>
        /// <value>The color of the text shadow.</value>
        public Color TextShadowColor
        {
            get { return _textShadowColor; }
            set
            {
                _textShadowColor = value;

            }
        }

        /// <summary>
        /// Gets or sets the c PV5 interval.
        /// </summary>
        /// <value>The c PV5 interval.</value>
        public int CPv5_Interval
        {
            get { return CPv5_interval; }
            set
            {

                CPv5_interval = value;

            }
        }

        /// <summary>
        /// Gets or sets the c PV5 outer speed.
        /// </summary>
        /// <value>The c PV5 outer speed.</value>
        public int CPv5_OuterSpeed
        {
            get { return otherinterval; }
            set
            {

                otherinterval = value;



            }
        }

        /// <summary>
        /// Gets or sets the seperation.
        /// </summary>
        /// <value>The seperation.</value>
        public int Seperation
        {
            get { return _barSeperation; }
            set
            {
                if (value < 0)
                    value = 0;
                _barSeperation = value;


            }
        }

        /// <summary>
        /// Gets or sets the width of the bar.
        /// </summary>
        /// <value>The width of the bar.</value>
        public int BarWidth
        {
            get { return _barWidth; }
            set
            {
                _barWidth = value;


            }
        }

        /// <summary>
        /// Gets or sets the marquee speed.
        /// </summary>
        /// <value>The marquee speed.</value>
        public int MarqueeSpeed
        {
            get { return CPv5_marqueeinterval; }
            set
            {

                CPv5_marqueeinterval = value;

            }
        }

        /// <summary>
        /// Gets or sets the minimum size of the c PV5.
        /// </summary>
        /// <value>The minimum size of the c PV5.</value>
        public Size CPv5_MinimumSize
        {
            get { return _minimumSize; }
            set
            {
                _minimumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the c PV5 text.
        /// </summary>
        /// <value>The c PV5 text.</value>
        public string CPv5_Text
        {
            get { return _info; }
            set
            {
                _info = value;

            }
        }

        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>The information.</value>
        public string Info
        {
            get { return _info; }
            set
            {
                _info = value;

            }
        }

        //public BarData Bar1
        //{
        //    get { return Bars[0]; }
        //    set { Bars[0] = value;  }
        //}

        //public BarData Bar2
        //{
        //    get { return Bars[1]; }
        //    set { Bars[1] = value;  }
        //}

        //public BarData Bar3
        //{
        //    get { return Bars[2]; }
        //    set { Bars[2] = value;  }
        //}

        //public BarData Bar4
        //{
        //    get { return Bars[3]; }
        //    set { Bars[3] = value;  }
        //}

        //public BarData Bar5
        //{
        //    get { return Bars[4]; }
        //    set { Bars[4] = value;  }
        //}

        /// <summary>
        /// Gets or sets a value indicating whether [c PV5 reset].
        /// </summary>
        /// <value><c>true</c> if [c PV5 reset]; otherwise, <c>false</c>.</value>
        public bool CPv5_Reset
        {
            get { return CPv5_reset; }
            set
            {
                //if (value == true)
                //{
                //    Bar1.Reset();
                //    Bar2.Reset();
                //    Bar3.Reset();
                //    Bar4.Reset();
                //    Bar5.Reset();
                //}

                CPv5_reset = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressInput"/> is marquee.
        /// </summary>
        /// <value><c>true</c> if marquee; otherwise, <c>false</c>.</value>
        public bool Marquee
        {
            get { return CPv5_marquee; }
            set
            {
                CPv5_marquee = value;




            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display percentage].
        /// </summary>
        /// <value><c>true</c> if [display percentage]; otherwise, <c>false</c>.</value>
        public bool DisplayPercentage
        {
            get { return _displayPercentage; }
            set
            {
                
                _displayPercentage = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display total percentage].
        /// </summary>
        /// <value><c>true</c> if [display total percentage]; otherwise, <c>false</c>.</value>
        public bool DisplayTotalPercentage
        {
            get { return _displayTotalPercentage; }
            set
            {
                _displayTotalPercentage = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [smooth bars].
        /// </summary>
        /// <value><c>true</c> if [smooth bars]; otherwise, <c>false</c>.</value>
        public bool SmoothBars
        {
            get { return _smoothBars; }
            set
            {
                _smoothBars = value;
                
            }
        }


        //public Image Image
        //{
        //    get { return _image; }
        //    set
        //    {
        //        _image = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets a value indicating whether [text shadow].
        /// </summary>
        /// <value><c>true</c> if [text shadow]; otherwise, <c>false</c>.</value>
        public bool TextShadow
        {
            get { return _textShadow; }
            set
            {
                _textShadow = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [border enabled].
        /// </summary>
        /// <value><c>true</c> if [border enabled]; otherwise, <c>false</c>.</value>
        public bool BorderEnabled
        {
            get { return _borderEnabled; }
            set
            {
                _borderEnabled = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [inactive color enabled].
        /// </summary>
        /// <value><c>true</c> if [inactive color enabled]; otherwise, <c>false</c>.</value>
        public bool InactiveColorEnabled
        {
            get { return _inactiveColorEnabled; }
            set
            {
                _inactiveColorEnabled = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [image enabled].
        /// </summary>
        /// <value><c>true</c> if [image enabled]; otherwise, <c>false</c>.</value>
        public bool ImageEnabled
        {
            get { return _imageEnabled; }
            set
            {
                _imageEnabled = value;
                
            }
        }

        #region Additions

        #region Bool

        /// <summary>
        /// Gets or sets a value indicating whether [bar1 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar1 enabling]; otherwise, <c>false</c>.</value>
        public bool Bar1Enabling
        {
            get { return bar1_Enabling; }
            set { bar1_Enabling = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [bar2 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar2 enabling]; otherwise, <c>false</c>.</value>
        public bool Bar2Enabling
        {
            get { return bar2_Enabling; }
            set { bar2_Enabling = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [bar3 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar3 enabling]; otherwise, <c>false</c>.</value>
        public bool Bar3Enabling
        {
            get { return bar3_Enabling; }
            set { bar3_Enabling = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [bar4 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar4 enabling]; otherwise, <c>false</c>.</value>
        public bool Bar4Enabling
        {
            get { return bar4_Enabling; }
            set { bar4_Enabling = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [bar5 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar5 enabling]; otherwise, <c>false</c>.</value>
        public bool Bar5Enabling
        {
            get { return bar5_Enabling; }
            set { bar5_Enabling = value; }
        }

        #endregion

        #region Colors

        /// <summary>
        /// Gets or sets the color of the bar1 active.
        /// </summary>
        /// <value>The color of the bar1 active.</value>
        public Color Bar1ActiveColor
        {
            get { return bar1_Active_Color; }
            set { bar1_Active_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 active.
        /// </summary>
        /// <value>The color of the bar2 active.</value>
        public Color Bar2ActiveColor
        {
            get { return bar2_Active_Color; }
            set { bar2_Active_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 active.
        /// </summary>
        /// <value>The color of the bar3 active.</value>
        public Color Bar3ActiveColor
        {
            get { return bar3_Active_Color; }
            set { bar3_Active_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 active.
        /// </summary>
        /// <value>The color of the bar4 active.</value>
        public Color Bar4ActiveColor
        {
            get { return bar4_Active_Color; }
            set { bar4_Active_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 active.
        /// </summary>
        /// <value>The color of the bar5 active.</value>
        public Color Bar5ActiveColor
        {
            get { return bar5_Active_Color; }
            set { bar5_Active_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 finish.
        /// </summary>
        /// <value>The color of the bar1 finish.</value>
        public Color Bar1FinishColor
        {
            get { return bar1_Finish_Color; }
            set { bar1_Finish_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 finish.
        /// </summary>
        /// <value>The color of the bar2 finish.</value>
        public Color Bar2FinishColor
        {
            get { return bar2_Finish_Color; }
            set { bar2_Finish_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 finish.
        /// </summary>
        /// <value>The color of the bar3 finish.</value>
        public Color Bar3FinishColor
        {
            get { return bar3_Finish_Color; }
            set { bar3_Finish_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 finish.
        /// </summary>
        /// <value>The color of the bar4 finish.</value>
        public Color Bar4FinishColor
        {
            get { return bar4_Finish_Color; }
            set { bar4_Finish_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 finish.
        /// </summary>
        /// <value>The color of the bar5 finish.</value>
        public Color Bar5FinishColor
        {
            get { return bar5_Finish_Color; }
            set { bar5_Finish_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 border.
        /// </summary>
        /// <value>The color of the bar1 border.</value>
        public Color Bar1BorderColor
        {
            get { return bar1_Border_Color; }
            set { bar1_Border_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 border.
        /// </summary>
        /// <value>The color of the bar2 border.</value>
        public Color Bar2BorderColor
        {
            get { return bar2_Border_Color; }
            set { bar2_Border_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 border.
        /// </summary>
        /// <value>The color of the bar3 border.</value>
        public Color Bar3BorderColor
        {
            get { return bar3_Border_Color; }
            set { bar3_Border_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 border.
        /// </summary>
        /// <value>The color of the bar4 border.</value>
        public Color Bar4BorderColor
        {
            get { return bar4_Border_Color; }
            set { bar4_Border_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 border.
        /// </summary>
        /// <value>The color of the bar5 border.</value>
        public Color Bar5BorderColor
        {
            get { return bar5_Border_Color; }
            set { bar5_Border_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 inactive.
        /// </summary>
        /// <value>The color of the bar1 inactive.</value>
        public Color Bar1InactiveColor
        {
            get { return bar1_Inactive_Color; }
            set { bar1_Inactive_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 inactive.
        /// </summary>
        /// <value>The color of the bar2 inactive.</value>
        public Color Bar2InactiveColor
        {
            get { return bar2_Inactive_Color; }
            set { bar2_Inactive_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 inactive.
        /// </summary>
        /// <value>The color of the bar3 inactive.</value>
        public Color Bar3InactiveColor
        {
            get { return bar3_Inactive_Color; }
            set { bar3_Inactive_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 inactive.
        /// </summary>
        /// <value>The color of the bar4 inactive.</value>
        public Color Bar4InactiveColor
        {
            get { return bar4_Inactive_Color; }
            set { bar4_Inactive_Color = value; }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 inactive.
        /// </summary>
        /// <value>The color of the bar5 inactive.</value>
        public Color Bar5InactiveColor
        {
            get { return bar5_Inactive_Color; }
            set { bar5_Inactive_Color = value; }
        }

        #endregion

        #region Values

        /// <summary>
        /// Gets or sets the bar1 smooth.
        /// </summary>
        /// <value>The bar1 smooth.</value>
        public int Bar1Smooth
        {
            get { return bar1_Smooth; }
            set { bar1_Smooth = value; }
        }

        /// <summary>
        /// Gets or sets the bar2 smooth.
        /// </summary>
        /// <value>The bar2 smooth.</value>
        public int Bar2Smooth
        {
            get { return bar2_Smooth; }
            set { bar2_Smooth = value; }
        }

        /// <summary>
        /// Gets or sets the bar3 smooth.
        /// </summary>
        /// <value>The bar3 smooth.</value>
        public int Bar3Smooth
        {
            get { return bar3_Smooth; }
            set { bar3_Smooth = value; }
        }

        /// <summary>
        /// Gets or sets the bar4 smooth.
        /// </summary>
        /// <value>The bar4 smooth.</value>
        public int Bar4Smooth
        {
            get { return bar4_Smooth; }
            set { bar4_Smooth = value; }
        }

        /// <summary>
        /// Gets or sets the bar5 smooth.
        /// </summary>
        /// <value>The bar5 smooth.</value>
        public int Bar5Smooth
        {
            get { return bar5_Smooth; }
            set { bar5_Smooth = value; }
        }

        /// <summary>
        /// Gets or sets the bar1 maximum.
        /// </summary>
        /// <value>The bar1 maximum.</value>
        public int Bar1Maximum
        {
            get { return bar1_Maximum; }
            set { bar1_Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the bar2 maximum.
        /// </summary>
        /// <value>The bar2 maximum.</value>
        public int Bar2Maximum
        {
            get { return bar2_Maximum; }
            set { bar2_Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the bar3 maximum.
        /// </summary>
        /// <value>The bar3 maximum.</value>
        public int Bar3Maximum
        {
            get { return bar3_Maximum; }
            set { bar3_Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the bar4 maximum.
        /// </summary>
        /// <value>The bar4 maximum.</value>
        public int Bar4Maximum
        {
            get { return bar4_Maximum; }
            set { bar4_Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the bar5 maximum.
        /// </summary>
        /// <value>The bar5 maximum.</value>
        public int Bar5Maximum
        {
            get { return bar5_Maximum; }
            set { bar5_Maximum = value; }
        }

        /// <summary>
        /// Gets or sets the bar1 value.
        /// </summary>
        /// <value>The bar1 value.</value>
        public int Bar1Value
        {
            get { return bar1_Value; }
            set { bar1_Value = value; }
        }

        /// <summary>
        /// Gets or sets the bar2 value.
        /// </summary>
        /// <value>The bar2 value.</value>
        public int Bar2Value
        {
            get { return bar2_Value; }
            set { bar2_Value = value; }
        }

        /// <summary>
        /// Gets or sets the bar3 value.
        /// </summary>
        /// <value>The bar3 value.</value>
        public int Bar3Value
        {
            get { return bar3_Value; }
            set { bar3_Value = value; }
        }

        /// <summary>
        /// Gets or sets the bar4 value.
        /// </summary>
        /// <value>The bar4 value.</value>
        public int Bar4Value
        {
            get { return bar4_Value; }
            set { bar4_Value = value; }
        }

        /// <summary>
        /// Gets or sets the bar5 value.
        /// </summary>
        /// <value>The bar5 value.</value>
        public int Bar5Value
        {
            get { return bar5_Value; }
            set { bar5_Value = value; }
        }

        #endregion

        #endregion


        #endregion


    }
}
