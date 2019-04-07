using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zeroit.Framework.ProgressThematic.ThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        #region Constructor

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
        private Size _minimumSize = new Size(100,100);
        //private int _barCount = 4;
        public BarData[] _bars = new BarData[5];
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
        private bool _imageEnabled = true;

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

        public int CPv5_Interval
        {
            get { return CPv5_interval; }
            set
            {

                CPv5_interval = value;

            }
        }


        public int CPv5_OuterSpeed
        {
            get { return otherinterval; }
            set
            {

                otherinterval = value;



            }
        }
        
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
        
        public bool Marquee
        {
            get { return CPv5_marquee; }
            set
            {
                CPv5_marquee = value;




            }
        }
        
        public int MarqueeSpeed
        {
            get { return CPv5_marqueeinterval; }
            set
            {

                CPv5_marqueeinterval = value;

            }
        }

        public Size CPv5_MinimumSize
        {
            get { return _minimumSize; }
            set
            {
                _minimumSize = value;
            }
        }

        public string CPv5_Text
        {
            get { return _info; }
            set
            {
                _info = value;

            }
        }

        
        public BarData Bar1
        {
            get { return _bars[0]; }
            set { _bars[0] = value;  }
        }

        
        public BarData Bar2
        {
            get { return _bars[1]; }
            set { _bars[1] = value;  }
        }

        
        public BarData Bar3
        {
            get { return _bars[2]; }
            set { _bars[2] = value;  }
        }

        
        public BarData Bar4
        {
            get { return _bars[3]; }
            set { _bars[3] = value;  }
        }

        
        public BarData Bar5
        {
            get { return _bars[4]; }
            set { _bars[4] = value;  }
        }

        
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

        
        public int BarWidth
        {
            get { return _barWidth; }
            set
            {
                _barWidth = value;

                
            }
        }

        
        public bool DisplayPercentage
        {
            get { return _displayPercentage; }
            set
            {
                
                _displayPercentage = value;
                
            }
        }

        
        public bool DisplayTotalPercentage
        {
            get { return _displayTotalPercentage; }
            set
            {
                _displayTotalPercentage = value;
                
            }
        }
        
        public bool SmoothBars
        {
            get { return _smoothBars; }
            set
            {
                _smoothBars = value;
                
            }
        }

        
        public string Info
        {
            get { return _info; }
            set
            {
                _info = value;
                
            }
        }

        
        public bool TextShadow
        {
            get { return _textShadow; }
            set
            {
                _textShadow = value;
                
            }
        }

        
        public Color TextShadowColor
        {
            get { return _textShadowColor; }
            set
            {
                _textShadowColor = value;
                
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

        
        public bool BorderEnabled
        {
            get { return _borderEnabled; }
            set
            {
                _borderEnabled = value;
                
            }
        }

        
        public bool InactiveColorEnabled
        {
            get { return _inactiveColorEnabled; }
            set
            {
                _inactiveColorEnabled = value;
                
            }
        }

        
        public bool ImageEnabled
        {
            get { return _imageEnabled; }
            set
            {
                _imageEnabled = value;
                
            }
        }
        #endregion

    }
}
