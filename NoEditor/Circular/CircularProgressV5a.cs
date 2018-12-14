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

using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region CircularProgressv5a

    #region Control
    //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);


    

    public partial class ThematicProgress 
    {

        #region Private Fields

        //private Size minimumSizeAllowed;
        //private Size _minimumSize = new Size(100, 100);
        //private int _barCount = 4;
        //public BarData[] _bars = new BarData[5];
        private bool _borderEnabled = false;
        //private Image _image;
        private int _barSeperation = 1;
        private int _barWidth = 4;
        private bool _displayPercentage = true;
        private bool _displayTotalPercentage = false;
        private bool _smoothBars = false;
        private string _info = "Data";
        private bool _textShadow = false;
        private Color _textShadowColor = Color.White;
        private bool _inactiveColorEnabled = true;
        private int CPv5_marqueeAngle = 90;
        private bool CPv5_marquee = false;
        private int CPv5_marqueeinterval = 100;
        private int CPv5_interval = 100;
        private int otherinterval = 10;
        private bool CPv5_reset = false;
        private bool _imageEnabled = false;

        //Enabling
        private bool bar1_Enabling = true;
        private bool bar2_Enabling = false;
        private bool bar3_Enabling = false;
        private bool bar4_Enabling = false;
        private bool bar5_Enabling = false;

        //Color - Active
        private Color bar1_Active_Color = Color.LightSeaGreen;
        private Color bar2_Active_Color = Color.LightSeaGreen;
        private Color bar3_Active_Color = Color.LightSeaGreen;
        private Color bar4_Active_Color = Color.LightSeaGreen;
        private Color bar5_Active_Color = Color.LightSeaGreen;

        //Color - Finish
        private Color bar1_Finish_Color = Color.Lime;
        private Color bar2_Finish_Color = Color.Lime;
        private Color bar3_Finish_Color = Color.Lime;
        private Color bar4_Finish_Color = Color.Lime;
        private Color bar5_Finish_Color = Color.Lime;

        //Color - Border
        private Color bar1_Border_Color = Color.Gray;
        private Color bar2_Border_Color = Color.Gray;
        private Color bar3_Border_Color = Color.Gray;
        private Color bar4_Border_Color = Color.Gray;
        private Color bar5_Border_Color = Color.Gray;

        //Color - Inactive
        private Color bar1_Inactive_Color = Color.LightGray;
        private Color bar2_Inactive_Color = Color.LightGray;
        private Color bar3_Inactive_Color = Color.LightGray;
        private Color bar4_Inactive_Color = Color.LightGray;
        private Color bar5_Inactive_Color = Color.LightGray;

        //Smooth
        private int bar1_Smooth = 1;
        private int bar2_Smooth = 1;
        private int bar3_Smooth = 1;
        private int bar4_Smooth = 1;
        private int bar5_Smooth = 1;

        //Maximum
        private int bar1_Maximum = 100;
        private int bar2_Maximum = 100;
        private int bar3_Maximum = 100;
        private int bar4_Maximum = 100;
        private int bar5_Maximum = 100;

        //Value
        private int bar1_Value = 0;
        private int bar2_Value = 0;
        private int bar3_Value = 0;
        private int bar4_Value = 0;
        private int bar5_Value = 0;

        #endregion

        #region Include in Private Field

        
        private System.Windows.Forms.Timer CPv5_timer1 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer2 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer3 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer4 = new System.Windows.Forms.Timer();

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

        [Category("CircularProgress CircularProgressV5")]
        public int CPv5_Interval
        {
            get { return CPv5_interval; }
            set
            {

                CPv5_interval = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV5")]
        public int CPv5_OuterSpeed
        {
            get { return otherinterval; }
            set
            {

                otherinterval = value;

                Invalidate();

            }
        }

        //[Category("CircularProgress CircularProgressV5")]
        //private bool CPv5_Reset = false;

        [Category("CircularProgress CircularProgressV5")]
        public bool CPv5_Reset
        {
            get { return CPv5_reset; }
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

                CPv5_reset = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV5")]
        public bool Marquee
        {
            get { return CPv5_marquee; }
            set
            {
                CPv5_marquee = value;

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

        [Category("CircularProgress CircularProgressV5")]
        public int MarqueeSpeed
        {
            get { return CPv5_marqueeinterval; }
            set
            {

                CPv5_marqueeinterval = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV5")]
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

        [Category("CircularProgress CircularProgressV5")]
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
        [DisplayName("Bar #1")]
        [Description("Bar #1 Data")]
        [Category("Bars")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar1
        {
            get { return _bars[0]; }
            set
            {

                _bars[0] = value; Invalidate();
            }
        }

        [DisplayName("Bar #2")]
        [Description("Bar #2 Data")]
        [Category("Bars")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar2
        {
            get { return _bars[1]; }
            set { _bars[1] = value; Invalidate(); }
        }

        [DisplayName("Bar #3")]
        [Description("Bar #3 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar3
        {
            get { return _bars[2]; }
            set
            {
                _bars[2] = value; Invalidate();
            }
        }

        [DisplayName("Bar #4")]
        [Description("Bar #4 Data")]
        [Category("Bars")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar4
        {
            get { return _bars[3]; }
            set { _bars[3] = value; Invalidate(); }
        }

        [DisplayName("Bar #5")]
        [Description("Bar #5 Data")]
        [Category("Bars")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar5
        {
            get { return _bars[4]; }
            set { _bars[4] = value; Invalidate(); }
        }

        [DefaultValue(1)]
        [DisplayName("Bar Seperation")]
        [Description("Gets or Sets the bar seperation value. This is the amount in pixels the distance between each bar defined.")]
        [Category("Bars")]
        public int Seperation
        {
            get { return _barSeperation; }
            set
            {
                if (value < 0)
                    value = 0;
                _barSeperation = value;

                SetMinimumSize();

                Invalidate();
            }
        }

        [DefaultValue(4)]
        [DisplayName("Bar Width")]
        [Description("Gets or Sets the bar width. This is the actual bar width, per bar.")]
        [Category("Bars")]
        public int BarWidth
        {
            get { return _barWidth; }
            set
            {
                _barWidth = value;

                SetMinimumSize();
                Invalidate();
            }
        }

        [DefaultValue(true)]
        [DisplayName("Display Percentages")]
        [Description("Gets or Sets the display of bar percentages. This will display a percentage per bar displayed.")]
        [Category("Bars")]
        public bool DisplayPercentage
        {
            get { return _displayPercentage; }
            set
            {
                if (value == false)
                {
                    ForeColor = Color.Transparent;
                }
                _displayPercentage = value;
                RefreshControl();
            }
        }

        [DefaultValue(false)]
        [DisplayName("Display Total Percentage")]
        [Description("Gets or Sets the display of a total percentage. This will calculate all the bars and display only one percentage.")]
        [Category("Bars")]
        public bool DisplayTotalPercentage
        {
            get { return _displayTotalPercentage; }
            set
            {
                _displayTotalPercentage = value;
                RefreshControl();
            }
        }
        [DefaultValue(false)]
        [DisplayName("Smooth Bars")]
        [Description("Gets or Sets if the bars will increment in a smooth motion. This is good if your values change heavier and you want a smooth look to them.")]
        [Category("Bars")]
        public bool SmoothBars
        {
            get { return _smoothBars; }
            set
            {
                _smoothBars = value;
                RefreshControl();
            }
        }

        [DefaultValue("Data")]
        [DisplayName("Info Data")]
        [Description("Gets or Sets the text when percentages is not enabled. This will display a set text (that can be edited at runtime) rather then percentages if 'Display Percentages' is disabled.")]
        [Category("CircularProgress CircularProgressV5")]
        public string Info
        {
            get { return _info; }
            set
            {
                _info = value;
                RefreshControl();
            }
        }

        [DefaultValue(false)]
        [DisplayName("Info Shadow")]
        [Description("Gets or Sets there will be text shadowing.")]
        [Category("CircularProgress CircularProgressV5")]
        public bool TextShadow
        {
            get { return _textShadow; }
            set
            {
                _textShadow = value;
                RefreshControl();
            }
        }

        [DefaultValue(typeof(Color), "Color.White")]
        [DisplayName("Info Shadow Color")]
        [Description("Gets or Sets the color of text shadowing. This requires the Info Shadow boolean to be true.")]
        [Category("CircularProgress CircularProgressV5")]
        public Color TextShadowColor
        {
            get { return _textShadowColor; }
            set
            {
                _textShadowColor = value;
                RefreshControl();
            }
        }

        [DefaultValue("Nothing")]
        [DisplayName("Image")]
        [Description("Gets or Sets the bar image. This will display a bar image in the middle of the bar.")]
        [Category("Bars")]
        public Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                RefreshControl();
            }
        }

        [DefaultValue(false)]
        [DisplayName("Borders Enabled")]
        [Description("Gets or Sets the enabled value of the border around the bar.")]
        [Category("Bars")]
        public bool BorderEnabled
        {
            get { return _borderEnabled; }
            set
            {
                _borderEnabled = value;
                RefreshControl();
            }
        }

        [DefaultValue(true)]
        [DisplayName("Inactive Colors Enabled")]
        [Description("Gets or Sets the enabled value of the inactive colors. If this is disabled, then the inactive bars won't be displayed.")]
        [Category("Bars")]
        public bool InactiveColorEnabled
        {
            get { return _inactiveColorEnabled; }
            set
            {
                _inactiveColorEnabled = value;
                RefreshControl();
            }
        }

        [DefaultValue(true)]
        [DisplayName("Image Enabled")]
        [Description("Gets or Sets the enabled value of the image. If this is disabled, the image will not be rendered.")]
        [Category("Bars")]
        public bool ImageEnabled
        {
            get { return _imageEnabled; }
            set
            {
                _imageEnabled = value;
                RefreshControl();
            }
        }



        #endregion

        #region Additions

        #region Bool
        [Category("Bars")]
        public bool Bar1Enabling
        {
            get { return bar1_Enabling; }
            set {

                if (value == true)
                {
                    _bars[0].Enabled = true;
                }
                else
                {
                    _bars[0].Enabled = false;
                }


                bar1_Enabling = value;
                Invalidate();
            }
        }
        [Category("Bars")]
        public bool Bar2Enabling
        {
            get { return bar2_Enabling; }
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

                bar2_Enabling = value; Invalidate();
            }
        }
        [Category("Bars")]
        public bool Bar3Enabling
        {
            get { return bar3_Enabling; }
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


                bar3_Enabling = value; Invalidate();
            }
        }
        [Category("Bars")]
        public bool Bar4Enabling
        {
            get { return bar4_Enabling; }
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

                bar4_Enabling = value; Invalidate();
            }
        }
        [Category("Bars")]
        public bool Bar5Enabling
        {
            get { return bar5_Enabling; }
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

                bar5_Enabling = value; Invalidate();
            }
        }

        #endregion

        #region Colors
        [Category("Bars")]
        public Color Bar1ActiveColor
        {
            get { return bar1_Active_Color; }
            set
            {
                Bar1.ActiveColor = value;

                bar1_Active_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar2ActiveColor
        {
            get { return bar2_Active_Color; }
            set
            {
                Bar2.ActiveColor = value;
                bar2_Active_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar3ActiveColor
        {
            get { return bar3_Active_Color; }
            set
            {
                Bar3.ActiveColor = value;
                bar3_Active_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar4ActiveColor
        {
            get { return bar4_Active_Color; }
            set
            {
                Bar4.ActiveColor = value;
                bar4_Active_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar5ActiveColor
        {
            get { return bar5_Active_Color; }
            set
            {
                Bar5.ActiveColor = value;
                bar5_Active_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar1FinishColor
        {
            get { return bar1_Finish_Color; }
            set
            {
                Bar1.FinishColor = value;
                bar1_Finish_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar2FinishColor
        {
            get { return bar2_Finish_Color; }
            set
            {
                Bar2.FinishColor = value;
                bar2_Finish_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar3FinishColor
        {
            get { return bar3_Finish_Color; }
            set
            {
                Bar3.FinishColor = value;
                bar3_Finish_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar4FinishColor
        {
            get { return bar4_Finish_Color; }
            set
            {
                Bar4.FinishColor = value;
                bar4_Finish_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar5FinishColor
        {
            get { return bar5_Finish_Color; }
            set
            {
                Bar5.FinishColor = value;
                bar5_Finish_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar1BorderColor
        {
            get { return bar1_Border_Color; }
            set
            {
                Bar1.BorderColor = value;
                bar1_Border_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar2BorderColor
        {
            get { return bar2_Border_Color; }
            set
            {
                Bar2.BorderColor = value;
                bar2_Border_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar3BorderColor
        {
            get { return bar3_Border_Color; }
            set
            {
                Bar3.BorderColor = value;
                bar3_Border_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar4BorderColor
        {
            get { return bar4_Border_Color; }
            set
            {
                Bar4.BorderColor = value;
                bar4_Border_Color = value; Invalidate(); 
            }
        }

        [Category("Bars")]
        public Color Bar5BorderColor
        {
            get { return bar5_Border_Color; }
            set
            {
                Bar5.BorderColor = value;
                bar5_Border_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar1InactiveColor
        {
            get { return bar1_Inactive_Color; }
            set
            {
                Bar1.InactiveColor = value;
                bar1_Inactive_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar2InactiveColor
        {
            get { return bar2_Inactive_Color; }
            set
            {
                Bar2.InactiveColor = value;
                bar2_Inactive_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar3InactiveColor
        {
            get { return bar3_Inactive_Color; }
            set
            {
                Bar3.InactiveColor = value;
                bar3_Inactive_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar4InactiveColor
        {
            get { return bar4_Inactive_Color; }
            set
            {
                Bar4.InactiveColor = value;
                bar4_Inactive_Color = value; Invalidate();
            }
        }

        [Category("Bars")]
        public Color Bar5InactiveColor
        {
            get { return bar5_Inactive_Color; }
            set
            {
                Bar5.InactiveColor = value;
                bar5_Inactive_Color = value; Invalidate();
            }
        }

        #endregion

        #region Values

        [Category("Bars")]
        public int Bar1Smooth
        {
            get { return bar1_Smooth; }
            set
            {
                Bar1.SmoothAmount = value;
                bar1_Smooth = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar2Smooth
        {
            get { return bar2_Smooth; }
            set
            {
                Bar2.SmoothAmount = value;
                bar2_Smooth = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar3Smooth
        {
            get { return bar3_Smooth; }
            set
            {
                Bar3.SmoothAmount = value;
                bar3_Smooth = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar4Smooth
        {
            get { return bar4_Smooth; }
            set
            {
                Bar4.SmoothAmount = value;
                bar4_Smooth = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar5Smooth
        {
            get { return bar5_Smooth; }
            set
            {
                Bar5.SmoothAmount = value;
                bar5_Smooth = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar1Maximum
        {
            get { return bar1_Maximum; }
            set
            {
                Bar1.Maximum = value;
                bar1_Maximum = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar2Maximum
        {
            get { return bar2_Maximum; }
            set
            {
                Bar2.Maximum = value;
                bar2_Maximum = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar3Maximum
        {
            get { return bar3_Maximum; }
            set
            {
                Bar3.Maximum = value;
                bar3_Maximum = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar4Maximum
        {
            get { return bar4_Maximum; }
            set
            {
                Bar4.Maximum = value;
                bar4_Maximum = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar5Maximum
        {
            get { return bar5_Maximum; }
            set
            {
                Bar5.Maximum = value;
                bar5_Maximum = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar1Value
        {
            get { return bar1_Value; }
            set
            {
                Bar1.Value = value;
                bar1_Value = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar2Value
        {
            get { return bar2_Value; }
            set
            {
                Bar1.Value = value;
                bar2_Value = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar3Value
        {
            get { return bar3_Value; }
            set
            {
                Bar3.Value = value;
                bar3_Value = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar4Value
        {
            get { return bar4_Value; }
            set
            {
                Bar4.Value = value;
                bar4_Value = value; Invalidate();
            }
        }

        [Category("Bars")]
        public int Bar5Value
        {
            get { return bar5_Value; }
            set
            {
                Bar5.Value = value;
                bar5_Value = value; Invalidate();
            }
        }

        #endregion

        #endregion

        #region Event

        private void CPv5_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Bar1.Value + 1 > Bar1.Maximum)
            {
                this.Bar1.Value = 0;
            }

            else
            {
                this.Bar1.Value++;
                Invalidate();
            }

            if (this.Bar2.Value + 1 > Bar2.Maximum)
            {
                this.Bar2.Value = 0;
            }

            else
            {
                this.Bar2.Value++;
                Invalidate();
            }

            if (this.Bar3.Value + 1 > Bar3.Maximum)
            {
                this.Bar3.Value = 0;
            }

            else
            {
                this.Bar3.Value++;
                Invalidate();
            }

            if (this.Bar4.Value + 1 > Bar4.Maximum)
            {
                this.Bar4.Value = 0;
            }

            else
            {
                this.Bar4.Value++;
                Invalidate();
            }

            if (this.Bar5.Value + 1 > Bar5.Maximum)
            {
                this.Bar5.Value = 0;
            }

            else
            {
                this.Bar5.Value++;
                Invalidate();
            }


            
        }

        private void CPv5_Timer_Tick1(object sender, EventArgs e)
        {


            if (this.Bar2.Value + 1 > Bar2.Maximum)
            {
                this.Bar2.Value = 0;
            }

            else
            {
                this.Bar2.Value++;
                Invalidate();
            }


        }

        private void CPv5_Timer_Tick2(object sender, EventArgs e)
        {


            if (this.Bar3.Value + 1 > Bar3.Maximum)
            {
                this.Bar3.Value = 0;
            }

            else
            {
                this.Bar3.Value++;
                Invalidate();
            }


        }

        private void CPv5_Timer_Tick3(object sender, EventArgs e)
        {


            if (this.Bar4.Value + 1 > Bar4.Maximum)
            {
                this.Bar4.Value = 0;
            }

            else
            {
                this.Bar4.Value++;
                Invalidate();
            }


        }

        private void CPv5_Timer_Tick4(object sender, EventArgs e)
        {


            if (this.Bar5.Value + 1 > Bar5.Maximum)
            {
                this.Bar5.Value = 0;
            }

            else
            {
                this.Bar5.Value++;
                Invalidate();
            }

        }

        private void CPv5_MarqueeTimer_Tick(object sender, EventArgs e)
        {


            if (this.CPv5_marqueeAngle + 1 > 360)
            {
                this.CPv5_marqueeAngle = 0;
            }

            else
            {
                this.CPv5_marqueeAngle++;
                Invalidate();
            }

        }

        #endregion


        #region "Declares"
        private Size minimumSizeAllowed/* = new Size(100,100)*/;
        private Size _minimumSize/* = new Size(200,200)*/;
        private int _barCount = 4;
        private BarData[] _bars = new BarData[5];
        private System.Timers.Timer _smoothTimer = new System.Timers.Timer();
        //private bool BorderEnabled = false;
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

        float[] realPercentage;
        float[] setPercentage;
        float[] currentAngle;
        float[] remainderAngle;

        #region "Constructor"
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
        
        private void CPv5_Paint(PaintEventArgs e)
        {
            //Bitmap B = new Bitmap(Width, Height);

            Graphics G = e.Graphics;
            G.Clear(BackColor);
            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = Smoothing;

            if (BackColor != Color.Transparent)
            {
                G.Clear(BackColor);
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

        private void RefreshControl()
        {
            Invalidate();
        }

        public bool ShouldSerializeBars()
        {
            return (_bars != null);
        }

        public void ResetBars()
        {
            for (int i = 0; i <= _bars.Count() - 1; i++)
            {
                _bars[i] = new BarData(i);
                _bars[i].PropertyChanged += Bars_PropertyChanged;
            }
        }

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
