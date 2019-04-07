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
using Zeroit.Framework.Progress;

using Microsoft.VisualBasic;
#endregion

namespace Zeroit.Framework.ProgressThematic
{
    #region CircularProgressv5a

    #region Control
    //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);


    

    public partial class ThematicProgress 
    {


        #region Include in Private Field

        private int CPv5_marqueeAngle = 90;
        //private bool Marquee = false;
        //private int MarqueeSpeed = 100;

        //private int CPv5_Interval = 100;
        //private int CPv5_OuterSpeed = 10;

        private Image _image = null;

        private System.Windows.Forms.Timer CPv5_timer1 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer2 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer3 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer CPv5_timer4 = new System.Windows.Forms.Timer();

        private System.Windows.Forms.Timer marqueeTimer = new System.Windows.Forms.Timer();



        #endregion

        #region Include in Public Properties

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
            get { return progressInput.CPv5_Interval; }
            set
            {

                progressInput.CPv5_Interval = value;
                Invalidate();
            }
        }

        [Category("CircularProgress CircularProgressV5")]
        public int CPv5_OuterSpeed
        {
            get { return progressInput.CPv5_OuterSpeed; }
            set
            {

                progressInput.CPv5_OuterSpeed = value;

                Invalidate();

            }
        }

        //private bool CPv5_Reset = false;

        [Category("CircularProgress CircularProgressV5")]
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

        [Category("CircularProgress CircularProgressV5")]
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

        [Category("CircularProgress CircularProgressV5")]
        public int MarqueeSpeed
        {
            get { return progressInput.MarqueeSpeed; }
            set
            {

                progressInput.MarqueeSpeed = value;
                Invalidate();
            }
        }


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

        private Size minimumSizeAllowed;
        //private Size CPv5_MinimumSize;
        private int _barCount = 4;
        //private BarData[] progressInput._bars = new BarData[5];
        private System.Timers.Timer _smoothTimer;
        //private bool BorderEnabled = false;
        //private Image Image = null;
        //private int Seperation = 1;
        //private int BarWidth = 4;
        //private bool DisplayPercentage = true;
        //private bool DisplayTotalPercentage = false;
        //private bool SmoothBars = false;
        //private string CPv5_Text = "Data";
        //private bool TextShadow = false;
        //private Color TextShadowColor = Color.White;
        //private bool InactiveColorEnabled = true;
        //private bool ImageEnabled = true;

        float[] realPercentage;
        float[] setPercentage;
        float[] currentAngle;
        float[] remainderAngle;


        #endregion
        
        #region "Constructor"
        public void CircularProgressBarv5()
        {
            

            for (int i = 0; i <= progressInput._bars.Count() - 1; i++)
            {
                progressInput._bars[i] = new BarData(i + 1);
                progressInput._bars[i].PropertyChanged += Bars_PropertyChanged;
            }
            

            _smoothTimer = new System.Timers.Timer();
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

        [Category("CircularProgress CircularProgressV5")]
        public Size CPv5_MinimumSize
        {
            get { return progressInput.CPv5_MinimumSize; }
            set
            {
                if (value.Height < minimumSizeAllowed.Height)
                    value.Height = minimumSizeAllowed.Height;
                if (value.Width < minimumSizeAllowed.Width)
                    value.Height = minimumSizeAllowed.Height;
                progressInput.CPv5_MinimumSize = value;
            }
        }

        [Category("CircularProgress CircularProgressV5")]
        public string CPv5_Text
        {
            get { return progressInput.CPv5_Text; }
            set
            {
                progressInput.CPv5_Text = value;
                RefreshControl();
            }
        }


        


        private void CPv5_Paint(PaintEventArgs e)
        {
            
            timer.Interval = CPv5_Interval;
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
                if (!progressInput._bars[i].Enabled)
                    continue;
                //setPercentage[i] = (progressInput._bars[i].SmoothValue / progressInput._bars[i].Maximum) * 100;
                //realPercentage[i] = (progressInput._bars[i].Value / progressInput._bars[i].Maximum) * 100;
                //currentAngle[i] = Convert.ToSingle(360 / 100 * setPercentage[i]);
                //remainderAngle[i] = 360 - currentAngle[i];
                //float progressAngle = Convert.ToSingle(360 / 100 * percentage);

                setPercentage[i] = progressInput._bars[i].Value;

                currentAngle[i] = Convert.ToSingle(360 * (setPercentage[i] / progressInput._bars[i].Maximum));

                remainderAngle[i] = 360 - Convert.ToInt32(currentAngle[i]);

                
            }


            Bitmap B = new Bitmap(Width, Height);

            Graphics G = e.Graphics;
            G.Clear(BackColor);
            G.TextRenderingHint = TextRendering;


            G.SmoothingMode = SmoothingMode.HighQuality;
            if (BackColor != Color.Transparent)
            {
                G.Clear(BackColor);
            }

            for (int i = 0; i <= _barCount; i++)
            {
                if (!progressInput._bars[i].Enabled)
                    continue;
                Color colorToUse = default(Color);
                if (progressInput._bars[i].SmoothValue >= progressInput._bars[i].Maximum)
                {
                    colorToUse = progressInput._bars[i].FinishColor;
                }
                else
                {
                    colorToUse = progressInput._bars[i].ActiveColor;
                }

                using (Pen progressPen = new Pen(colorToUse, circleSize))
                {
                    using (Pen remainderPen = new Pen(progressInput._bars[i].InactiveColor, circleSize))
                    {
                        using (Pen BorderPen = new Pen(progressInput._bars[i].BorderColor, circleSize + 2))
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
                            if (!progressInput._bars[i].Enabled)
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
                            if (!progressInput._bars[i].Enabled)
                                continue;
                            if (textDisplay == string.Empty)
                            {
                                textDisplay += setPercentage[i].ToString() + PostFix;
                            }
                            else
                            {
                                textDisplay += Constants.vbNewLine + setPercentage[i].ToString() + PostFix;
                            }
                        }
                    }
                }
                else
                {
                    textDisplay = CPv5_Text;
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
            e.Graphics.DrawImageUnscaled(B, 0, 0);


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


        #region "Properties"
        [DisplayName("Bar #1")]
        [Description("Bar #1 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar1
        {
            get { return progressInput.Bar1; }
            set { progressInput.Bar1 = value; Invalidate(); }
        }

        [DisplayName("Bar #2")]
        [Description("Bar #2 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar2
        {
            get { return progressInput.Bar2; }
            set { progressInput.Bar2 = value; Invalidate(); }
        }

        [DisplayName("Bar #3")]
        [Description("Bar #3 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar3
        {
            get { return progressInput.Bar3; }
            set { progressInput.Bar3 = value; Invalidate(); }
        }

        [DisplayName("Bar #4")]
        [Description("Bar #4 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar4
        {
            get { return progressInput.Bar4; }
            set { progressInput.Bar4 = value; Invalidate(); }
        }

        [DisplayName("Bar #5")]
        [Description("Bar #5 Data")]
        [Category("Bars")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BarData Bar5
        {
            get { return progressInput.Bar5; }
            set
            {
                progressInput.Bar5 = value;
                Invalidate(); 
            }
        }

        [DefaultValue(1)]
        [DisplayName("Bar Seperation")]
        [Description("Gets or Sets the bar seperation value. This is the amount in pixels the distance between each bar defined.")]
        [Category("Bars")]
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

        [DefaultValue(4)]
        [DisplayName("Bar Width")]
        [Description("Gets or Sets the bar width. This is the actual bar width, per bar.")]
        [Category("Bars")]
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

        [DefaultValue(true)]
        [DisplayName("Display Percentages")]
        [Description("Gets or Sets the display of bar percentages. This will display a percentage per bar displayed.")]
        [Category("Bars")]
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

        [DefaultValue(false)]
        [DisplayName("Display Total Percentage")]
        [Description("Gets or Sets the display of a total percentage. This will calculate all the bars and display only one percentage.")]
        [Category("Bars")]
        public bool DisplayTotalPercentage
        {
            get { return progressInput.DisplayTotalPercentage; }
            set
            {
                progressInput.DisplayTotalPercentage = value;
                RefreshControl();
            }
        }
        [DefaultValue(false)]
        [DisplayName("Smooth Bars")]
        [Description("Gets or Sets if the bars will increment in a smooth motion. This is good if your values change heavier and you want a smooth look to them.")]
        [Category("Bars")]
        public bool SmoothBars
        {
            get { return progressInput.SmoothBars; }
            set
            {
                progressInput.SmoothBars = value;
                RefreshControl();
            }
        }

        [DefaultValue("Data")]
        [DisplayName("CPv5_Text Data")]
        [Description("Gets or Sets the text when percentages is not enabled. This will display a set text (that can be edited at runtime) rather then percentages if 'Display Percentages' is disabled.")]
        [Category("CircularProgress CircularProgressV5")]
        public string Info
        {
            get { return CPv5_Text; }
            set
            {
                CPv5_Text = value;
                RefreshControl();
            }
        }

        [DefaultValue(false)]
        [DisplayName("CPv5_Text Shadow")]
        [Description("Gets or Sets there will be text shadowing.")]
        [Category("CircularProgress CircularProgressV5")]
        public bool TextShadow
        {
            get { return progressInput.TextShadow; }
            set
            {
                progressInput.TextShadow = value;
                RefreshControl();
            }
        }

        [DefaultValue(typeof(Color), "Color.White")]
        [DisplayName("CPv5_Text Shadow Color")]
        [Description("Gets or Sets the color of text shadowing. This requires the CPv5_Text Shadow boolean to be true.")]
        [Category("CircularProgress CircularProgressV5")]
        public Color TextShadowColor
        {
            get { return progressInput.TextShadowColor; }
            set
            {
                progressInput.TextShadowColor = value;
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
            get { return progressInput.BorderEnabled; }
            set
            {
                progressInput.BorderEnabled = value;
                RefreshControl();
            }
        }

        [DefaultValue(true)]
        [DisplayName("Inactive Colors Enabled")]
        [Description("Gets or Sets the enabled value of the inactive colors. If this is disabled, then the inactive bars won't be displayed.")]
        [Category("Bars")]
        public bool InactiveColorEnabled
        {
            get { return progressInput.InactiveColorEnabled; }
            set
            {
                progressInput.InactiveColorEnabled = value;
                RefreshControl();
            }
        }

        [DefaultValue(true)]
        [DisplayName("Image Enabled")]
        [Description("Gets or Sets the enabled value of the image. If this is disabled, the image will not be rendered.")]
        [Category("Bars")]
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

        #endregion
        
        #endregion

        #region "Subs/Functions"
        private void Smoother_Tick(object source, System.Timers.ElapsedEventArgs e)
        {
            bool allDone = true;
            for (int i = 0; i <= _barCount; i++)
            {
                if (progressInput._bars[i].Value > progressInput._bars[i].SmoothValue)
                {
                    progressInput._bars[i].SmoothValue += progressInput._bars[i].SmoothAmount;
                    if (progressInput._bars[i].SmoothValue > progressInput._bars[i].Value)
                        progressInput._bars[i].SmoothValue = progressInput._bars[i].Value;
                    allDone = false;
                }
                else if (progressInput._bars[i].Value < progressInput._bars[i].SmoothValue)
                {
                    progressInput._bars[i].SmoothValue -= progressInput._bars[i].SmoothAmount;
                    if (progressInput._bars[i].SmoothValue < progressInput._bars[i].Value)
                        progressInput._bars[i].SmoothValue = progressInput._bars[i].Value;
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
            return (progressInput._bars != null);
        }

        public void ResetBars()
        {
            for (int i = 0; i <= progressInput._bars.Count() - 1; i++)
            {
                progressInput._bars[i] = new BarData(i);
                progressInput._bars[i].PropertyChanged += Bars_PropertyChanged;
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
            for (int i = progressInput._bars.Count() - 1; i >= 0; i += -1)
            {
                if (progressInput._bars[i].Enabled)
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
