using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);


    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BarData : INotifyPropertyChanged
    {

        #region "Declares"
        private int _barID =0;
        private bool _enabled = false;
        private int _smoothAmount = 1;
        private int _smoothValue = 0;
        private int _value = 0;
        private int _maximum = 100;
        private Color _borderColor = Color.Black;
        private Color _finishColor = Color.LightGreen;
        private Color _activeColor = Color.LightSeaGreen;
        #endregion

        private Color _inactiveColor = Color.LightGray;

        #region "Events"
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region "Constructor"
        public BarData(int barID)
        {
            _barID = barID;
            if (_barID == 1)
                Enabled = true;
        }

        //event System.ComponentModel.PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        //{
        //    add
        //    {
        //        throw new NotImplementedException();
        //    }

        //    remove
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        #endregion

        #region "Overrides"
        public override string ToString()
        {
            return "Data #" + _barID;
        }
        #endregion

        #region "Properties"
        [DefaultValue(false)]
        [DisplayName("Enabled")]
        [Description("Gets or Sets the enabled value of the bar. If the bar is enabled, then the bar will be visible.")]
        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (_barID == 1)
                    value = true;
                _enabled = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Enabled"));
                }
            }
        }
        [DefaultValue(1)]
        [DisplayName("Smooth Amount")]
        [Description("Gets or Sets the smooth amount per timer tick. The higher this is, the less smooth it will look, but the faster it will go. Setting it lower will feel more smooth, but may take too long.")]
        public int SmoothAmount
        {
            get { return _smoothAmount; }
            set
            {
                _smoothAmount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SmoothAmount"));
                }
            }
        }

        internal int SmoothValue
        {
            get { return _smoothValue; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > _maximum)
                    value = _maximum;
                _smoothValue = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SmoothValue"));
                }
            }
        }

        [DefaultValue(0)]
        [DisplayName("Value")]
        [Description("Gets or Sets the value. The value cannot be higher then maximum, and less then 0.")]
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 0)
                    value = 0;
                if (value > _maximum)
                    value = _maximum;
                _value = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Value"));
                }
            }
        }

        [DefaultValue(100)]
        [DisplayName("Maximum")]
        [Description("Gets or Sets the maximum value. The value cannot lower then 1.")]
        public int Maximum
        {
            get { return _maximum; }
            set
            {
                if (value < 1)
                    value = 1;
                if (_value > value)
                {
                    _smoothValue = value;
                    _value = value;
                }
                _maximum = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Maximum"));
                }
            }
        }

        [DefaultValue(typeof(Color), "Color.Black")]
        [DisplayName("Border Color")]
        [Description("Gets or Sets the border color. This is the color for the border itself aroudn the bar.")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("BorderColor"));
                }
            }
        }

        [DefaultValue(typeof(Color), "Color.LightGreen")]
        [DisplayName("Finish Color")]
        [Description("Gets or Sets the finish color. This is the color of the bar when the bar value is equal to maximum value.")]
        public Color FinishColor
        {
            get { return _finishColor; }
            set
            {
                _finishColor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FinishColor"));
                }
            }
        }

        [DefaultValue(typeof(Color), "Color.LightSeaGreen")]
        [DisplayName("Active Color")]
        [Description("Gets or Sets the active color. This is the color of the active portion of the bar while not complete.")]
        public Color ActiveColor
        {
            get { return _activeColor; }
            set
            {
                _activeColor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("ActiveColor"));
                }
            }
        }

        [DefaultValue(typeof(Color), "Color.LightGray")]
        [DisplayName("Inactive Color")]
        [Description("Gets or Sets the inactive color. This is the color of the inactive portion of the bar while not complete.")]
        public Color InactiveColor
        {
            get { return _inactiveColor; }
            set
            {
                _inactiveColor = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("InactiveColor"));
                }
            }
        }
        #endregion

        #region "Subs"
        public void Increment(int amount)
        {
            Value += amount;
        }

        public void Decrement(int amount)
        {
            Value -= amount;
        }

        public void Reset()
        {
            Value = 0;
        }

        public void Max()
        {
            Value = Maximum;
        }
        #endregion

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // This is the public factory method.
        //public static BarData CreateNewCustomer()
        //{

        //    //for (int i=0; i <=5; i++)
        //    //return new BarData(i);

        //}

    }
    
}
