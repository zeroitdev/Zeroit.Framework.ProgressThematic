// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV_BarData.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Zeroit.Framework.ProgressThematic
{
    //public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);


    /// <summary>
    /// Class BarData.
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BarData : INotifyPropertyChanged
    {

        #region "Declares"
        /// <summary>
        /// The bar identifier
        /// </summary>
        private int _barID =0;
        /// <summary>
        /// The enabled
        /// </summary>
        private bool _enabled = false;
        /// <summary>
        /// The smooth amount
        /// </summary>
        private int _smoothAmount = 1;
        /// <summary>
        /// The smooth value
        /// </summary>
        private int _smoothValue = 0;
        /// <summary>
        /// The value
        /// </summary>
        private int _value = 0;
        /// <summary>
        /// The maximum
        /// </summary>
        private int _maximum = 100;
        /// <summary>
        /// The border color
        /// </summary>
        private Color _borderColor = Color.Black;
        /// <summary>
        /// The finish color
        /// </summary>
        private Color _finishColor = Color.LightGreen;
        /// <summary>
        /// The active color
        /// </summary>
        private Color _activeColor = Color.LightSeaGreen;
        #endregion

        /// <summary>
        /// The inactive color
        /// </summary>
        private Color _inactiveColor = Color.LightGray;

        #region "Events"
        /// <summary>
        /// Occurs when [property changed].
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Initializes a new instance of the <see cref="BarData"/> class.
        /// </summary>
        /// <param name="barID">The bar identifier.</param>
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
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return "Data #" + _barID;
        }
        #endregion

        #region "Properties"
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BarData"/> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
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
        /// <summary>
        /// Gets or sets the smooth amount.
        /// </summary>
        /// <value>The smooth amount.</value>
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

        /// <summary>
        /// Gets or sets the smooth value.
        /// </summary>
        /// <value>The smooth value.</value>
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

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
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

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
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

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
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

        /// <summary>
        /// Gets or sets the color of the finish.
        /// </summary>
        /// <value>The color of the finish.</value>
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

        /// <summary>
        /// Gets or sets the color of the active.
        /// </summary>
        /// <value>The color of the active.</value>
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

        /// <summary>
        /// Gets or sets the color of the inactive.
        /// </summary>
        /// <value>The color of the inactive.</value>
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
        /// <summary>
        /// Increments the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void Increment(int amount)
        {
            Value += amount;
        }

        /// <summary>
        /// Decrements the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void Decrement(int amount)
        {
            Value -= amount;
        }

        /// <summary>
        /// Resets this instance.
        /// </summary>
        public void Reset()
        {
            Value = 0;
        }

        /// <summary>
        /// Maximums this instance.
        /// </summary>
        public void Max()
        {
            Value = Maximum;
        }
        #endregion

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        /// <summary>
        /// Notifies the property changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
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
