// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV5a.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region CircularProgressv5a

    #region Control
    //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);




    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress 
    {


        #region Include in Private Field

        /// <summary>
        /// The c PV5 marquee angle
        /// </summary>
        private int CPv5_marqueeAngle = 90;
        //private bool Marquee = false;
        //private int MarqueeSpeed = 100;

        //private int CPv5_Interval = 100;
        //private int CPv5_OuterSpeed = 10;


        /// <summary>
        /// The c PV5 timer1
        /// </summary>
        private System.Windows.Forms.Timer CPv5_timer1 = new System.Windows.Forms.Timer();

        /// <summary>
        /// The c PV5 timer2
        /// </summary>
        private System.Windows.Forms.Timer CPv5_timer2 = new System.Windows.Forms.Timer();

        /// <summary>
        /// The c PV5 timer3
        /// </summary>
        private System.Windows.Forms.Timer CPv5_timer3 = new System.Windows.Forms.Timer();

        /// <summary>
        /// The c PV5 timer4
        /// </summary>
        private System.Windows.Forms.Timer CPv5_timer4 = new System.Windows.Forms.Timer();

        /// <summary>
        /// The marquee timer
        /// </summary>
        private System.Windows.Forms.Timer marqueeTimer = new System.Windows.Forms.Timer();



        #endregion

        #region Public Properties

        //public bool CV5_AutoAnimate
        //{
        //    get { return autoAnimate; }
        //    set
        //    {
        //        autoAnimate = value;

        //        if (value == true)
        //        {
        //            timer.Enabled = true;
        //            CPv5_timer1.Enabled = true;
        //            CPv5_timer2.Enabled = true;
        //            CPv5_timer3.Enabled = true;
        //            CPv5_timer4.Enabled = true;
        //        }

        //        else
        //        {
        //            timer.Enabled = false;
        //            CPv5_timer1.Enabled = false;
        //            CPv5_timer2.Enabled = false;
        //            CPv5_timer3.Enabled = false;
        //            CPv5_timer4.Enabled = false;
        //        }

        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the c PV5 interval.
        /// </summary>
        /// <value>The c PV5 interval.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public int CPv5_Interval
        {
            get { return progressInput.CPv5_Interval; }
            set
            {

                progressInput.CPv5_Interval = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the c PV5 outer speed.
        /// </summary>
        /// <value>The c PV5 outer speed.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public int CPv5_OuterSpeed
        {
            get { return progressInput.CPv5_OuterSpeed; }
            set
            {

                progressInput.CPv5_OuterSpeed = value;

                Invalidate();

            }
        }

        //[Category("CircularProgress CircularProgressV5")]
        //[Browsable(false)]
        //private bool CPv5_Reset = false;

        /// <summary>
        /// Gets or sets a value indicating whether [c PV5 reset].
        /// </summary>
        /// <value><c>true</c> if [c PV5 reset]; otherwise, <c>false</c>.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public bool CPv5_Reset
        {
            get { return progressInput.CPv5_Reset; }
            set
            {
                if (value == true)
                {
                    Bar1.Reset();
                    Bar2.Reset();
                    Bar3.Reset();
                    Bar4.Reset();
                    Bar5.Reset();
                }

                progressInput.CPv5_Reset = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitThematicProgress"/> is marquee.
        /// </summary>
        /// <value><c>true</c> if marquee; otherwise, <c>false</c>.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public bool Marquee
        {
            get { return progressInput.Marquee; }
            set
            {
                progressInput.Marquee = value;

                if (value == true)
                {
                    marqueeTimer.Enabled = true;

                }

                else
                {
                    marqueeTimer.Enabled = false;

                }

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the marquee speed.
        /// </summary>
        /// <value>The marquee speed.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public int MarqueeSpeed
        {
            get { return progressInput.MarqueeSpeed; }
            set
            {

                progressInput.MarqueeSpeed = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the minimum size of the c PV5.
        /// </summary>
        /// <value>The minimum size of the c PV5.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public Size CPv5_MinimumSize
        {
            get { return _minimumSize; }
            set
            {
                if (value.Height < minimumSizeAllowed.Height)
                    value.Height = minimumSizeAllowed.Height;
                if (value.Width < minimumSizeAllowed.Width)
                    value.Height = minimumSizeAllowed.Height;
                _minimumSize = value;
            }
        }

        /// <summary>
        /// Gets or sets the c PV5 text.
        /// </summary>
        /// <value>The c PV5 text.</value>
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public string CPv5_Text
        {
            get { return Info; }
            set
            {
                Info = value;
                RefreshControl();
            }
        }


        #endregion

        #region Bars
        /// <summary>
        /// Gets or sets the bar1.
        /// </summary>
        /// <value>The bar1.</value>
        [DisplayName("Bar #1")]
        [Description("Bar #1 Data")]
        [Category("Bars")]
        [Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar1
        {
            get { return _bars[0]; }
            set
            {

                _bars[0] = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar2.
        /// </summary>
        /// <value>The bar2.</value>
        [DisplayName("Bar #2")]
        [Description("Bar #2 Data")]
        [Category("Bars")]
        [Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar2
        {
            get { return _bars[1]; }
            set { _bars[1] = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the bar3.
        /// </summary>
        /// <value>The bar3.</value>
        [DisplayName("Bar #3")]
        [Description("Bar #3 Data")]
        [Category("Bars")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar3
        {
            get { return _bars[2]; }
            set
            {
                _bars[2] = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar4.
        /// </summary>
        /// <value>The bar4.</value>
        [DisplayName("Bar #4")]
        [Description("Bar #4 Data")]
        [Category("Bars")]
        [Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar4
        {
            get { return _bars[3]; }
            set { _bars[3] = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the bar5.
        /// </summary>
        /// <value>The bar5.</value>
        [DisplayName("Bar #5")]
        [Description("Bar #5 Data")]
        [Category("Bars")]
        [Browsable(false)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar5
        {
            get { return _bars[4]; }
            set { _bars[4] = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the seperation.
        /// </summary>
        /// <value>The seperation.</value>
        [DefaultValue(1)]
        [DisplayName("Bar Seperation")]
        [Description("Gets or Sets the bar seperation value. This is the amount in pixels the distance between each bar defined.")]
        [Category("Bars")]
        [Browsable(false)]
        public int Seperation
        {
            get { return progressInput.Seperation; }
            set
            {
                if (value < 0)
                    value = 0;
                progressInput.Seperation = value;

                SetMinimumSize();

                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the width of the bar.
        /// </summary>
        /// <value>The width of the bar.</value>
        [DefaultValue(4)]
        [DisplayName("Bar Width")]
        [Description("Gets or Sets the bar width. This is the actual bar width, per bar.")]
        [Category("Bars")]
        [Browsable(false)]
        public int BarWidth
        {
            get { return progressInput.BarWidth; }
            set
            {
                progressInput.BarWidth = value;

                SetMinimumSize();
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display percentage].
        /// </summary>
        /// <value><c>true</c> if [display percentage]; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        [DisplayName("Display Percentages")]
        [Description("Gets or Sets the display of bar percentages. This will display a percentage per bar displayed.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool DisplayPercentage
        {
            get { return progressInput.DisplayPercentage; }
            set
            {
                if (value == false)
                {
                    ForeColor = Color.Transparent;
                }
                progressInput.DisplayPercentage = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display total percentage].
        /// </summary>
        /// <value><c>true</c> if [display total percentage]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [DisplayName("Display Total Percentage")]
        [Description("Gets or Sets the display of a total percentage. This will calculate all the bars and display only one percentage.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool DisplayTotalPercentage
        {
            get { return progressInput.DisplayTotalPercentage; }
            set
            {
                progressInput.DisplayTotalPercentage = value;
                RefreshControl();
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [smooth bars].
        /// </summary>
        /// <value><c>true</c> if [smooth bars]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [DisplayName("Smooth Bars")]
        [Description("Gets or Sets if the bars will increment in a smooth motion. This is good if your values change heavier and you want a smooth look to them.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool SmoothBars
        {
            get { return progressInput.SmoothBars; }
            set
            {
                progressInput.SmoothBars = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        /// <value>The information.</value>
        [DefaultValue("Data")]
        [DisplayName("Info Data")]
        [Description("Gets or Sets the text when percentages is not enabled. This will display a set text (that can be edited at runtime) rather then percentages if 'Display Percentages' is disabled.")]
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public string Info
        {
            get { return progressInput.Info; }
            set
            {
                progressInput.Info = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [text shadow].
        /// </summary>
        /// <value><c>true</c> if [text shadow]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [DisplayName("Info Shadow")]
        [Description("Gets or Sets there will be text shadowing.")]
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public bool TextShadow
        {
            get { return progressInput.TextShadow; }
            set
            {
                progressInput.TextShadow = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets the color of the text shadow.
        /// </summary>
        /// <value>The color of the text shadow.</value>
        [DefaultValue(typeof(Color), "Color.White")]
        [DisplayName("Info Shadow Color")]
        [Description("Gets or Sets the color of text shadowing. This requires the Info Shadow boolean to be true.")]
        [Category("CircularProgress CircularProgressV5")]
        [Browsable(false)]
        public Color TextShadowColor
        {
            get { return progressInput.TextShadowColor; }
            set
            {
                progressInput.TextShadowColor = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets the set image.
        /// </summary>
        /// <value>The set image.</value>
        [DefaultValue("Nothing")]
        [DisplayName("Image")]
        [Description("Gets or Sets the bar image. This will display a bar image in the middle of the bar.")]
        [Category("Bars")]
        [Browsable(false)]
        public Image SetImage
        {
            get { return _image; }
            set
            {
                _image = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [border enabled].
        /// </summary>
        /// <value><c>true</c> if [border enabled]; otherwise, <c>false</c>.</value>
        [DefaultValue(false)]
        [DisplayName("Borders Enabled")]
        [Description("Gets or Sets the enabled value of the border around the bar.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool BorderEnabled
        {
            get { return progressInput.BorderEnabled; }
            set
            {
                progressInput.BorderEnabled = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [inactive color enabled].
        /// </summary>
        /// <value><c>true</c> if [inactive color enabled]; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        [DisplayName("Inactive Colors Enabled")]
        [Description("Gets or Sets the enabled value of the inactive colors. If this is disabled, then the inactive bars won't be displayed.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool InactiveColorEnabled
        {
            get { return progressInput.InactiveColorEnabled; }
            set
            {
                progressInput.InactiveColorEnabled = value;
                RefreshControl();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [image enabled].
        /// </summary>
        /// <value><c>true</c> if [image enabled]; otherwise, <c>false</c>.</value>
        [DefaultValue(true)]
        [DisplayName("Image Enabled")]
        [Description("Gets or Sets the enabled value of the image. If this is disabled, the image will not be rendered.")]
        [Category("Bars")]
        [Browsable(false)]
        public bool ImageEnabled
        {
            get { return progressInput.ImageEnabled; }
            set
            {
                progressInput.ImageEnabled = value;
                RefreshControl();
            }
        }



        #endregion

        #region Additions

        #region Bool
        /// <summary>
        /// Gets or sets a value indicating whether [bar1 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar1 enabling]; otherwise, <c>false</c>.</value>
        [Category("Bars")]
        [Browsable(false)]
        public bool Bar1Enabling
        {
            get { return progressInput.Bar1Enabling; }
            set {

                if (value == true)
                {
                    _bars[0].Enabled = true;
                }
                else
                {
                    _bars[0].Enabled = false;
                }


                progressInput.Bar1Enabling = value;
                Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [bar2 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar2 enabling]; otherwise, <c>false</c>.</value>
        [Category("Bars")]
        [Browsable(false)]
        public bool Bar2Enabling
        {
            get { return progressInput.Bar2Enabling; }
            set
            {
                if (value == true)
                {
                    Bar2.Enabled = true;
                }
                else
                {
                    Bar2.Enabled = false;
                }

                progressInput.Bar2Enabling = value; Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [bar3 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar3 enabling]; otherwise, <c>false</c>.</value>
        [Category("Bars")]
        [Browsable(false)]
        public bool Bar3Enabling
        {
            get { return progressInput.Bar3Enabling; }
            set
            {
                if (value == true)
                {
                    Bar3.Enabled = true;
                }
                else
                {
                    Bar3.Enabled = false;
                }


                progressInput.Bar3Enabling = value; Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [bar4 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar4 enabling]; otherwise, <c>false</c>.</value>
        [Category("Bars")]
        [Browsable(false)]
        public bool Bar4Enabling
        {
            get { return progressInput.Bar4Enabling; }
            set
            {
                if (value == true)
                {
                    Bar4.Enabled = true;
                }
                else
                {
                    Bar4.Enabled = false;
                }

                progressInput.Bar4Enabling = value; Invalidate();
            }
        }
        /// <summary>
        /// Gets or sets a value indicating whether [bar5 enabling].
        /// </summary>
        /// <value><c>true</c> if [bar5 enabling]; otherwise, <c>false</c>.</value>
        [Category("Bars")]
        [Browsable(false)]
        public bool Bar5Enabling
        {
            get { return progressInput.Bar5Enabling; }
            set
            {
                if (value == true)
                {
                    Bar5.Enabled = true;
                }
                else
                {
                    Bar5.Enabled = false;
                }

                progressInput.Bar5Enabling = value; Invalidate();
            }
        }

        #endregion

        #region Colors
        /// <summary>
        /// Gets or sets the color of the bar1 active.
        /// </summary>
        /// <value>The color of the bar1 active.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar1ActiveColor
        {
            get { return progressInput.Bar1ActiveColor; }
            set
            {
                Bar1.ActiveColor = value;

                progressInput.Bar1ActiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 active.
        /// </summary>
        /// <value>The color of the bar2 active.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar2ActiveColor
        {
            get { return progressInput.Bar2ActiveColor; }
            set
            {
                Bar2.ActiveColor = value;
                progressInput.Bar2ActiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 active.
        /// </summary>
        /// <value>The color of the bar3 active.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar3ActiveColor
        {
            get { return progressInput.Bar3ActiveColor; }
            set
            {
                Bar3.ActiveColor = value;
                progressInput.Bar3ActiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 active.
        /// </summary>
        /// <value>The color of the bar4 active.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar4ActiveColor
        {
            get { return progressInput.Bar4ActiveColor; }
            set
            {
                Bar4.ActiveColor = value;
                progressInput.Bar4ActiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 active.
        /// </summary>
        /// <value>The color of the bar5 active.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar5ActiveColor
        {
            get { return progressInput.Bar5ActiveColor; }
            set
            {
                Bar5.ActiveColor = value;
                progressInput.Bar5ActiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 finish.
        /// </summary>
        /// <value>The color of the bar1 finish.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar1FinishColor
        {
            get { return progressInput.Bar1FinishColor; }
            set
            {
                Bar1.FinishColor = value;
                progressInput.Bar1FinishColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 finish.
        /// </summary>
        /// <value>The color of the bar2 finish.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar2FinishColor
        {
            get { return progressInput.Bar2FinishColor; }
            set
            {
                Bar2.FinishColor = value;
                progressInput.Bar2FinishColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 finish.
        /// </summary>
        /// <value>The color of the bar3 finish.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar3FinishColor
        {
            get { return progressInput.Bar3FinishColor; }
            set
            {
                Bar3.FinishColor = value;
                progressInput.Bar3FinishColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 finish.
        /// </summary>
        /// <value>The color of the bar4 finish.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar4FinishColor
        {
            get { return progressInput.Bar4FinishColor; }
            set
            {
                Bar4.FinishColor = value;
                progressInput.Bar4FinishColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 finish.
        /// </summary>
        /// <value>The color of the bar5 finish.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar5FinishColor
        {
            get { return progressInput.Bar5FinishColor; }
            set
            {
                Bar5.FinishColor = value;
                progressInput.Bar5FinishColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 border.
        /// </summary>
        /// <value>The color of the bar1 border.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar1BorderColor
        {
            get { return progressInput.Bar1BorderColor; }
            set
            {
                Bar1.BorderColor = value;
                progressInput.Bar1BorderColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 border.
        /// </summary>
        /// <value>The color of the bar2 border.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar2BorderColor
        {
            get { return progressInput.Bar2BorderColor; }
            set
            {
                Bar2.BorderColor = value;
                progressInput.Bar2BorderColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 border.
        /// </summary>
        /// <value>The color of the bar3 border.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar3BorderColor
        {
            get { return progressInput.Bar3BorderColor; }
            set
            {
                Bar3.BorderColor = value;
                progressInput.Bar3BorderColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 border.
        /// </summary>
        /// <value>The color of the bar4 border.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar4BorderColor
        {
            get { return progressInput.Bar4BorderColor; }
            set
            {
                Bar4.BorderColor = value;
                progressInput.Bar4BorderColor = value; Invalidate(); 
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 border.
        /// </summary>
        /// <value>The color of the bar5 border.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar5BorderColor
        {
            get { return progressInput.Bar5BorderColor; }
            set
            {
                Bar5.BorderColor = value;
                progressInput.Bar5BorderColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar1 inactive.
        /// </summary>
        /// <value>The color of the bar1 inactive.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar1InactiveColor
        {
            get { return progressInput.Bar1InactiveColor; }
            set
            {
                Bar1.InactiveColor = value;
                progressInput.Bar1InactiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar2 inactive.
        /// </summary>
        /// <value>The color of the bar2 inactive.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar2InactiveColor
        {
            get { return progressInput.Bar2InactiveColor; }
            set
            {
                Bar2.InactiveColor = value;
                progressInput.Bar2InactiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar3 inactive.
        /// </summary>
        /// <value>The color of the bar3 inactive.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar3InactiveColor
        {
            get { return progressInput.Bar3InactiveColor; }
            set
            {
                Bar3.InactiveColor = value;
                progressInput.Bar3InactiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar4 inactive.
        /// </summary>
        /// <value>The color of the bar4 inactive.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar4InactiveColor
        {
            get { return progressInput.Bar4InactiveColor; }
            set
            {
                Bar4.InactiveColor = value;
                progressInput.Bar4InactiveColor = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the bar5 inactive.
        /// </summary>
        /// <value>The color of the bar5 inactive.</value>
        [Category("Bars")]
        [Browsable(false)]
        public Color Bar5InactiveColor
        {
            get { return progressInput.Bar5InactiveColor; }
            set
            {
                Bar5.InactiveColor = value;
                progressInput.Bar5InactiveColor = value; Invalidate();
            }
        }

        #endregion

        #region Values

        /// <summary>
        /// Gets or sets the bar1 smooth.
        /// </summary>
        /// <value>The bar1 smooth.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar1Smooth
        {
            get { return progressInput.Bar1Smooth; }
            set
            {
                Bar1.SmoothAmount = value;
                progressInput.Bar1Smooth = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar2 smooth.
        /// </summary>
        /// <value>The bar2 smooth.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar2Smooth
        {
            get { return progressInput.Bar2Smooth; }
            set
            {
                Bar2.SmoothAmount = value;
                progressInput.Bar2Smooth = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar3 smooth.
        /// </summary>
        /// <value>The bar3 smooth.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar3Smooth
        {
            get { return progressInput.Bar3Smooth; }
            set
            {
                Bar3.SmoothAmount = value;
                progressInput.Bar3Smooth = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar4 smooth.
        /// </summary>
        /// <value>The bar4 smooth.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar4Smooth
        {
            get { return progressInput.Bar4Smooth; }
            set
            {
                Bar4.SmoothAmount = value;
                progressInput.Bar4Smooth = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar5 smooth.
        /// </summary>
        /// <value>The bar5 smooth.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar5Smooth
        {
            get { return progressInput.Bar5Smooth; }
            set
            {
                Bar5.SmoothAmount = value;
                progressInput.Bar5Smooth = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar1 maximum.
        /// </summary>
        /// <value>The bar1 maximum.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar1Maximum
        {
            get { return progressInput.Bar1Maximum; }
            set
            {
                Bar1.Maximum = value;
                progressInput.Bar1Maximum = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar2 maximum.
        /// </summary>
        /// <value>The bar2 maximum.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar2Maximum
        {
            get { return progressInput.Bar2Maximum; }
            set
            {
                Bar2.Maximum = value;
                progressInput.Bar2Maximum = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar3 maximum.
        /// </summary>
        /// <value>The bar3 maximum.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar3Maximum
        {
            get { return progressInput.Bar3Maximum; }
            set
            {
                Bar3.Maximum = value;
                progressInput.Bar3Maximum = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar4 maximum.
        /// </summary>
        /// <value>The bar4 maximum.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar4Maximum
        {
            get { return progressInput.Bar4Maximum; }
            set
            {
                Bar4.Maximum = value;
                progressInput.Bar4Maximum = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar5 maximum.
        /// </summary>
        /// <value>The bar5 maximum.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar5Maximum
        {
            get { return progressInput.Bar5Maximum; }
            set
            {
                Bar5.Maximum = value;
                progressInput.Bar5Maximum = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar1 value.
        /// </summary>
        /// <value>The bar1 value.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar1Value
        {
            get { return progressInput.Bar1Value; }
            set
            {
                Bar1.Value = value;
                progressInput.Bar1Value = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar2 value.
        /// </summary>
        /// <value>The bar2 value.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar2Value
        {
            get { return progressInput.Bar2Value; }
            set
            {
                Bar1.Value = value;
                progressInput.Bar2Value = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar3 value.
        /// </summary>
        /// <value>The bar3 value.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar3Value
        {
            get { return progressInput.Bar3Value; }
            set
            {
                Bar3.Value = value;
                progressInput.Bar3Value = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar4 value.
        /// </summary>
        /// <value>The bar4 value.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar4Value
        {
            get { return progressInput.Bar4Value; }
            set
            {
                Bar4.Value = value;
                progressInput.Bar4Value = value; Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the bar5 value.
        /// </summary>
        /// <value>The bar5 value.</value>
        [Category("Bars")]
        [Browsable(false)]
        public int Bar5Value
        {
            get { return progressInput.Bar5Value; }
            set
            {
                Bar5.Value = value;
                progressInput.Bar5Value = value; Invalidate();
            }
        }

        #endregion

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the CPv5_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Tick(object sender, EventArgs e)
        {

            #region Old Code

            //if (this.Bar1.Value + 1 > Bar1.Maximum)
            //{
            //    this.Bar1.Value = 0;
            //}

            //else
            //{
            //    this.Bar1.Value++;
            //    Invalidate();
            //}

            //if (this.Bar2.Value + 1 > Bar2.Maximum)
            //{
            //    this.Bar2.Value = 0;
            //}

            //else
            //{
            //    this.Bar2.Value++;
            //    Invalidate();
            //}

            //if (this.Bar3.Value + 1 > Bar3.Maximum)
            //{
            //    this.Bar3.Value = 0;
            //}

            //else
            //{
            //    this.Bar3.Value++;
            //    Invalidate();
            //}

            //if (this.Bar4.Value + 1 > Bar4.Maximum)
            //{
            //    this.Bar4.Value = 0;
            //}

            //else
            //{
            //    this.Bar4.Value++;
            //    Invalidate();
            //}

            //if (this.Bar5.Value + 1 > Bar5.Maximum)
            //{
            //    this.Bar5.Value = 0;
            //}

            //else
            //{
            //    this.Bar5.Value++;
            //    Invalidate();
            //} 
            #endregion

            if (Reverse)
            {
                if (this.Bar1.Value + (Change * SpeedMultiplier) > this.Bar1.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar1.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar2.Value + (Change * SpeedMultiplier) > this.Bar2.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar2.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar3.Value + (Change * SpeedMultiplier) > this.Bar3.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar3.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar4.Value + (Change * SpeedMultiplier) > this.Bar4.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar4.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar5.Value + (Change * SpeedMultiplier) > this.Bar5.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar5.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Bar1.Value + (Change * SpeedMultiplier) > this.Bar1.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    this.Bar1.Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar1.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar2.Value + (Change * SpeedMultiplier) > this.Bar2.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    this.Bar2.Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar2.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar3.Value + (Change * SpeedMultiplier) > this.Bar3.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    this.Bar3.Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar3.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar4.Value + (Change * SpeedMultiplier) > this.Bar4.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    this.Bar4.Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar4.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }

                if (this.Bar5.Value + (Change * SpeedMultiplier) > this.Bar5.Maximum)
                {
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    this.Bar5.Value = 0;
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar5.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            


        }

        /// <summary>
        /// Handles the Tick event of the CPv5_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Reduced_Tick(object sender, EventArgs e)
        {

            if (this.Bar1.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar1.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

            if (this.Bar2.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar2.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

            if (this.Bar3.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar3.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

            if (this.Bar4.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar4.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

            if (this.Bar5.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar5.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

        }


        /// <summary>
        /// Handles the Tick1 event of the CPv5_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Tick1(object sender, EventArgs e)
        {


            #region Old Code
            //if (this.Bar2.Value + 1 > Bar2.Maximum)
            //{
            //    this.Bar2.Value = 0;
            //}

            //else
            //{
            //    this.Bar2.Value++;
            //    Invalidate();
            //} 
            #endregion

            
            if (Reverse)
            {
                if (this.Bar2.Value + (Change * SpeedMultiplier) > this.Bar2.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar2.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Bar2.Value + (Change * SpeedMultiplier) > this.Bar2.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Bar2.Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Bar2.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }



        }

        /// <summary>
        /// Handles the Tick1 event of the CPv5_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Reduced_Tick1(object sender, EventArgs e)
        {


            if (this.Bar2.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar2.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }


        }

        /// <summary>
        /// Handles the Tick2 event of the CPv5_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Tick2(object sender, EventArgs e)
        {


            #region Old Code
            //if (this.Bar3.Value + 1 > Bar3.Maximum)
            //{
            //    this.Bar3.Value = 0;
            //}

            //else
            //{
            //    this.Bar3.Value++;
            //    Invalidate();
            //} 
            #endregion

            
            if (Reverse)
            {
                if (this.Bar3.Value + (Change * SpeedMultiplier) > this.Bar3.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar3.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Bar3.Value + (Change * SpeedMultiplier) > this.Bar3.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Bar3.Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Bar3.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }


        }

        /// <summary>
        /// Handles the Tick2 event of the CPv5_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Reduced_Tick2(object sender, EventArgs e)
        {

            if (this.Bar3.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar3.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

        }

        /// <summary>
        /// Handles the Tick3 event of the CPv5_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Tick3(object sender, EventArgs e)
        {


            if (Reverse)
            {
                if (this.Bar4.Value + (Change * SpeedMultiplier) > this.Bar4.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar4.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Bar4.Value + (Change * SpeedMultiplier) > this.Bar4.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Bar4.Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Bar4.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }
            

        }

        /// <summary>
        /// Handles the Tick3 event of the CPv5_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Reduced_Tick3(object sender, EventArgs e)
        {

            if (this.Bar4.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar4.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }

        }

        /// <summary>
        /// Handles the Tick4 event of the CPv5_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Tick4(object sender, EventArgs e)
        {

            #region Old Code
            //if (this.Bar5.Value + 1 > Bar5.Maximum)
            //{
            //    this.Bar5.Value = 0;
            //}

            //else
            //{
            //    this.Bar5.Value++;
            //    Invalidate();
            //} 
            #endregion

            if (Reverse)
            {
                if (this.Bar5.Value + (Change * SpeedMultiplier) > this.Bar5.Maximum)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.Bar5.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Bar5.Value + (Change * SpeedMultiplier) > this.Bar5.Maximum)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Bar5.Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Bar5.Value += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

        }

        /// <summary>
        /// Handles the Tick4 event of the CPv5_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_Timer_Reduced_Tick4(object sender, EventArgs e)
        {
            if (this.Bar5.Value < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.Bar5.Value -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }
        }

        /// <summary>
        /// Handles the Tick event of the CPv5_MarqueeTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_MarqueeTimer_Tick(object sender, EventArgs e)
        {


            #region Old Code
            //if (this.CPv5_marqueeAngle + 1 > 360)
            //{
            //    this.CPv5_marqueeAngle = 0;
            //}

            //else
            //{
            //    this.CPv5_marqueeAngle++;
            //    Invalidate();
            //} 
            #endregion

            
            if (Reverse)
            {
                if (this.CPv5_marqueeAngle + (Change * SpeedMultiplier) > 360)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    timerDecrement.Enabled = true;
                    timerDecrement.Start();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Invalidate();
                }

                else
                {
                    this.CPv5_marqueeAngle += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.CPv5_marqueeAngle + (Change * SpeedMultiplier) > 360)
                {

                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    CPv5_marqueeAngle = 0;
                    Invalidate();
                }

                else
                {
                    this.CPv5_marqueeAngle += (int)(Change * SpeedMultiplier);
                    Invalidate();
                }
            }



        }

        /// <summary>
        /// Handles the Tick event of the CPv5_MarqueeTimer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_MarqueeTimer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.CPv5_marqueeAngle < 0)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                Invalidate();
            }

            else
            {
                this.CPv5_marqueeAngle -= (int)(Change * SpeedMultiplier);
                Invalidate();
            }
        }

        #endregion


        #region "Declares"
        /// <summary>
        /// The minimum size allowed
        /// </summary>
        private Size minimumSizeAllowed/* = new Size(100,100)*/;
        /// <summary>
        /// The minimum size
        /// </summary>
        private Size _minimumSize/* = new Size(200,200)*/;
        /// <summary>
        /// The bar count
        /// </summary>
        private int _barCount = 4;
        /// <summary>
        /// The bars
        /// </summary>
        private BarData[] _bars = new BarData[5];
        /// <summary>
        /// The smooth timer
        /// </summary>
        private System.Timers.Timer _smoothTimer = new System.Timers.Timer();
        //private bool BorderEnabled = false;
        /// <summary>
        /// The image
        /// </summary>
        private Image _image = new Bitmap(1,1);
        //private int Seperation = 1;
        //private int BarWidth = 4;
        //private bool DisplayPercentage = true;
        //private bool DisplayTotalPercentage = false;
        //private bool SmoothBars = false;
        //private string Info = "Data";
        //private bool TextShadow = false;
        //private Color TextShadowColor = Color.White;
        //private bool InactiveColorEnabled = true;
        #endregion

        //private bool ImageEnabled = true;

        /// <summary>
        /// The real percentage
        /// </summary>
        float[] realPercentage;
        /// <summary>
        /// The set percentage
        /// </summary>
        float[] setPercentage;
        /// <summary>
        /// The current angle
        /// </summary>
        float[] currentAngle;
        /// <summary>
        /// The remainder angle
        /// </summary>
        float[] remainderAngle;

        #region "Constructor"
        /// <summary>
        /// Circulars the progress barv5.
        /// </summary>
        public void CircularProgressBarv5()
        {

            for (int i = 0; i <= _bars.Count() - 1; i++)
            {
                _bars[i] = new BarData(i + 1);
                _bars[i].PropertyChanged += Bars_PropertyChanged;
            }


            //#region Colors

            //Bar1.ActiveColor = Bar1ActiveColor;
            //Bar1.FinishColor = Bar1FinishColor;
            //Bar1.InactiveColor = Bar1InactiveColor;
            //Bar1.BorderColor = Bar1BorderColor;

            //Bar2.ActiveColor = Bar2ActiveColor;
            //Bar2.FinishColor = Bar2FinishColor;
            //Bar2.InactiveColor = Bar2InactiveColor;
            //Bar2.BorderColor = Bar2BorderColor;

            //Bar3.ActiveColor = Bar3ActiveColor;
            //Bar3.FinishColor = Bar3FinishColor;
            //Bar3.InactiveColor = Bar3InactiveColor;
            //Bar3.BorderColor = Bar3BorderColor;

            //Bar4.ActiveColor = Bar4ActiveColor;
            //Bar4.FinishColor = Bar4FinishColor;
            //Bar4.InactiveColor = Bar4InactiveColor;
            //Bar4.BorderColor = Bar4BorderColor;

            //Bar5.ActiveColor = Bar1ActiveColor;
            //Bar5.FinishColor = Bar1FinishColor;
            //Bar5.InactiveColor = Bar1InactiveColor;
            //Bar5.BorderColor = Bar1BorderColor;
            //#endregion

            //#region Enabling

            //Bar1.Enabled = Bar1Enabling;
            //Bar2.Enabled = Bar2Enabling;
            //Bar3.Enabled = Bar3Enabling;
            //Bar4.Enabled = Bar4Enabling;
            //Bar5.Enabled = Bar5Enabling;

            //#endregion

            //#region Maximum

            //Bar1.Maximum = Bar1Maximum;
            //Bar2.Maximum = Bar2Maximum;
            //Bar3.Maximum = Bar3Maximum;
            //Bar4.Maximum = Bar4Maximum;
            //Bar5.Maximum = Bar5Maximum;

            //#endregion

            //#region Value

            //Bar1.Value = Bar1Value;
            //Bar2.Value = Bar2Value;
            //Bar3.Value = Bar3Value;
            //Bar4.Value = Bar4Value;
            //Bar5.Value = Bar5Value;

            //#endregion


            _smoothTimer.Elapsed += Smoother_Tick;
            _smoothTimer.Enabled = false;
            _smoothTimer.Interval = 1;



            #region Timer
            

            if (DesignMode)
            {
                CPv5_timer1.Tick += CPv5_Timer_Tick1;
                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer1.Start();
                }
            }

            if (!DesignMode)
            {
                CPv5_timer1.Tick += CPv5_Timer_Tick1;

                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer1.Start();
                }
            }

            if (DesignMode)
            {
                CPv5_timer2.Tick += CPv5_Timer_Tick2;
                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer2.Start();
                }
            }

            if (!DesignMode)
            {
                CPv5_timer2.Tick += CPv5_Timer_Tick2;

                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer2.Start();
                }
            }

            if (DesignMode)
            {
                CPv5_timer3.Tick += CPv5_Timer_Tick3;
                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer3.Start();
                }
            }

            if (!DesignMode)
            {
                CPv5_timer3.Tick += CPv5_Timer_Tick3;

                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer3.Start();
                }
            }

            if (DesignMode)
            {
                CPv5_timer4.Tick += CPv5_Timer_Tick4;
                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer4.Start();
                }
            }

            if (!DesignMode)
            {
                CPv5_timer4.Tick += CPv5_Timer_Tick4;

                if (AutoAnimate)
                {
                    //timer.CPv5_Interval = 100;
                    CPv5_timer4.Start();
                }
            }



            #endregion

            #region Marquee Timer

            if (DesignMode)
            {
                marqueeTimer.Tick += CPv5_MarqueeTimer_Tick;
                if (Marquee)
                {
                    //timer.CPv5_Interval = 100;
                    marqueeTimer.Start();
                }
            }

            if (!DesignMode)
            {
                marqueeTimer.Tick += CPv5_MarqueeTimer_Tick;
                if (Marquee)
                {
                    //timer.CPv5_Interval = 100;
                    marqueeTimer.Start();
                }
            }

            #endregion

            SetMinimumSize();
        }
        #endregion

        #region "Overrides"

        //protected override System.Windows.Forms.CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle = 0x20;
        //        return cp;
        //    }
        //}

        /// <summary>
        /// cs the PV5 on resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CPv5_OnResize(EventArgs e)
        {
            Bar1.Enabled = Bar1Enabling;
            Bar1.ActiveColor = Bar1ActiveColor;
            Bar1.FinishColor = Bar1FinishColor;
            Bar1.BorderColor = Bar1BorderColor;
            Bar1.InactiveColor = Bar1BorderColor;
            Bar1.Maximum = Bar1Maximum;
            Bar1.Value = Bar1Value;
            Bar1.SmoothAmount = Bar1Smooth;

            Bar2.Enabled = Bar2Enabling;
            Bar2.ActiveColor = Bar2ActiveColor;
            Bar2.FinishColor = Bar2FinishColor;
            Bar2.BorderColor = Bar2BorderColor;
            Bar2.InactiveColor = Bar2BorderColor;
            Bar2.Maximum = Bar2Maximum;
            Bar2.Value = Bar2Value;
            Bar2.SmoothAmount = Bar2Smooth;

            Bar3.Enabled = Bar3Enabling;
            Bar3.ActiveColor = Bar3ActiveColor;
            Bar3.FinishColor = Bar3FinishColor;
            Bar3.BorderColor = Bar3BorderColor;
            Bar3.InactiveColor = Bar3BorderColor;
            Bar3.Maximum = Bar3Maximum;
            Bar3.Value = Bar3Value;
            Bar3.SmoothAmount = Bar3Smooth;

            Bar4.Enabled = Bar4Enabling;
            Bar4.ActiveColor = Bar4ActiveColor;
            Bar4.FinishColor = Bar4FinishColor;
            Bar4.BorderColor = Bar4BorderColor;
            Bar4.InactiveColor = Bar4BorderColor;
            Bar4.Maximum = Bar4Maximum;
            Bar4.Value = Bar4Value;
            Bar4.SmoothAmount = Bar4Smooth;

            Bar5.Enabled = Bar5Enabling;
            Bar5.ActiveColor = Bar5ActiveColor;
            Bar5.FinishColor = Bar5FinishColor;
            Bar5.BorderColor = Bar5BorderColor;
            Bar5.InactiveColor = Bar5BorderColor;
            Bar5.Maximum = Bar5Maximum;
            Bar5.Value = Bar5Value;
            Bar5.SmoothAmount = Bar5Smooth;
        }

        /// <summary>
        /// cs the PV5 paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CPv5_Paint(PaintEventArgs e)
        {
            //Bitmap B = new Bitmap(Width, Height);

            Graphics G = e.Graphics;
            //G.TextRenderingHint = TextRendering;
            //G.SmoothingMode = Smoothing;
            //G.Clear(BackColor);

            //if (BackColor != Color.Transparent)
            //{
            //    G.Clear(BackColor);
            //}

            if (AllowTransparency)
            {
                MakeTransparent(this, G);
            }

            //timer.Interval = CPv5_Interval;
            CPv5_timer1.Interval = CPv5_Interval + (2 * CPv5_OuterSpeed);
            CPv5_timer2.Interval = CPv5_Interval + (4 * CPv5_OuterSpeed);
            CPv5_timer3.Interval = CPv5_Interval + (6 * CPv5_OuterSpeed);
            CPv5_timer4.Interval = CPv5_Interval + (8 * CPv5_OuterSpeed);

            marqueeTimer.Interval = MarqueeSpeed;

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

                setPercentage[i] = _bars[i].Value;

                currentAngle[i] = Convert.ToSingle(360 * (setPercentage[i] / _bars[i].Maximum));

                remainderAngle[i] = 360 - Convert.ToInt32(currentAngle[i]);


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
                                    G.DrawArc(BorderPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), -CPv5_marqueeAngle, currentAngle[i]);
                                }
                            }
                            G.DrawArc(progressPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), -CPv5_marqueeAngle, currentAngle[i]);
                            if (InactiveColorEnabled)
                                G.DrawArc(remainderPen, (Seperation * i) + (circleSize * (i + 1)), (Seperation * i) + (circleSize * (i + 1)), Width - (Seperation * i * 2) - ((i + 1) * circleSize * 2), Height - (Seperation * i * 2) - ((i + 1) * circleSize * 2), currentAngle[i] - CPv5_marqueeAngle, remainderAngle[i]);
                        }
                    }
                }
            }

            if (SetImage != null)
                G.DrawImage(SetImage, new Point(Convert.ToInt32(Width / 2) - (SetImage.Width / 2), Convert.ToInt32(Height / 2) - (SetImage.Height / 2)));

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
                        textDisplay += percentageCalculate.ToString() + PostFix;
                    }
                    else
                    {
                        for (int i = 0; i <= _barCount; i++)
                        {
                            if (!_bars[i].Enabled)
                                continue;
                            if (textDisplay == string.Empty)
                            {
                                textDisplay += Convert.ToInt32(setPercentage[i]).ToString() + PostFix;
                            }
                            else
                            {
                                textDisplay += Constants.vbNewLine + Convert.ToInt32(setPercentage[i]).ToString() + PostFix;
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

                    if(ShowText)
                        G.DrawString(textDisplay, fnt, new SolidBrush(TextShadowColor), textRectShadow, stringFormat);
                }

                if(ShowText)
                    G.DrawString(textDisplay, fnt, new SolidBrush(ForeColor), textRect, stringFormat);
            }
            //e.Graphics.DrawImageUnscaled(B, 0, 0);


        }

        #region Public Properties

        //[DisplayName("BackColor")]
        //[Description("Gets or Sets the enabled value of the back color to use.")]
        //[Category("Bar Info")]
        //public override Color BackColor
        //{
        //    get { return base.BackColor; }
        //    set
        //    {
        //        base.BackColor = value;
        //        RefreshControl();
        //    }
        //}




        #endregion

        #endregion

        #region "Subs/Functions"
        /// <summary>
        /// Handles the Tick event of the Smoother control.
        /// </summary>
        /// <param name="source">The source of the event.</param>
        /// <param name="e">The <see cref="System.Timers.ElapsedEventArgs"/> instance containing the event data.</param>
        private void Smoother_Tick(object source, System.Timers.ElapsedEventArgs e)
        {
            bool allDone = true;
            for (int i = 0; i <= _barCount; i++)
            {
                if (_bars[i].Value > _bars[i].SmoothValue)
                {
                    _bars[i].SmoothValue += _bars[i].SmoothAmount;
                    if (_bars[i].SmoothValue > _bars[i].Value)
                        _bars[i].SmoothValue = _bars[i].Value;
                    allDone = false;
                }
                else if (_bars[i].Value < _bars[i].SmoothValue)
                {
                    _bars[i].SmoothValue -= _bars[i].SmoothAmount;
                    if (_bars[i].SmoothValue < _bars[i].Value)
                        _bars[i].SmoothValue = _bars[i].Value;
                    allDone = false;
                }
            }
            if (allDone)
                _smoothTimer.Enabled = false;
        }

        /// <summary>
        /// Refreshes the control.
        /// </summary>
        private void RefreshControl()
        {
            Invalidate();
        }

        /// <summary>
        /// Shoulds the serialize bars.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ShouldSerializeBars()
        {
            return (_bars != null);
        }

        /// <summary>
        /// Resets the bars.
        /// </summary>
        public void ResetBars()
        {
            for (int i = 0; i <= _bars.Count() - 1; i++)
            {
                _bars[i] = new BarData(i);
                _bars[i].PropertyChanged += Bars_PropertyChanged;
            }
        }

        /// <summary>
        /// Handles the PropertyChanged event of the Bars control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PropertyChangedEventArgs"/> instance containing the event data.</param>
        [System.ComponentModel.Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        private void Bars_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Enabled")
                SetMinimumSize();
            if (e.PropertyName == "Value")
            {
                if (SmoothBars == true)
                {
                    _smoothTimer.Enabled = true;
                }
                else
                {
                    BarData bar = (BarData)sender;
                    bar.SmoothValue = bar.Value;
                }
            }
            RefreshControl();
        }

        /// <summary>
        /// Sets the minimum size.
        /// </summary>
        private void SetMinimumSize()
        {
            int bCount = 0;
            for (int i = _bars.Count() - 1; i >= 0; i += -1)
            {
                if (_bars[i].Enabled)
                {
                    bCount = i + 1;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }

            int minSize = (bCount + 1) * (BarWidth + Seperation) * 2;
            minimumSizeAllowed = new Size(minSize, minSize);
            CPv5_MinimumSize = minimumSizeAllowed;
            int width = Size.Width;
            int height = Size.Width;
            if (width < minSize)
                width = minSize;
            if (height < minSize)
                height = minSize;
            Size = new Size(width, height);
        }
        #endregion



    }




    #endregion

    #endregion
    
}
