#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
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

#endregion

namespace Zeroit.Framework.Progress
{
    #region ZeroitProgressBarTransparent

    [Designer(typeof(ZeroitProgressBarTransparentDesigner))]

    public class ZeroitProgressBarTransparent : Control
    {

        #region Include in Private Field


        private bool autoAnimate = true;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        private int interval = 100;

        #endregion

        #region Include in Public Properties

        public int TimerInterval
        {
            get
            {
                return interval;
            }

            set
            {
                interval = value;
                Invalidate();
            }
        }

        public bool AutoAnimate
        {
            get { return autoAnimate; }
            set
            {
                autoAnimate = value;

                if (value == true)
                {
                    timer.Enabled = true;
                }

                else
                {
                    timer.Enabled = false;
                }

                Invalidate();
            }
        }

        #endregion

        #region Event

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
                this.Value = 0;
            else
                this.Value++;
        }

        #endregion

        #region Private Fields
        private Int32 _Maximum = 100;
        private Int32 _Minimum, _Value = 0;
        private Boolean _ShowText = true;
        private Color _ProgressBackground = Color.Blue;
        private Color _ProgressColor1 = Color.Red;
        private Color _ProgressColor2 = Color.Gray;

        #endregion

        #region Public Properties

        public Int32 Maximum
        {
            get { return _Maximum; }
            set
            {
                if (value > Int32.MaxValue)
                    throw new OverflowException();
                if (value < _Minimum)
                    _Minimum = value - 1;
                if (_Value > _Maximum)
                    _Value = value;
                _Maximum = value;
                Invalidate();
            }
        }

        public Int32 Minimum
        {
            get { return _Minimum; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Minimum", "Value cannot go below 0.");
                if (value < _Minimum)
                    _Value = value;
                if (value > _Maximum)
                    _Maximum = value + 1;
                _Minimum = value;
                Invalidate();
            }
        }

        public Int32 Value
        {
            get { return _Value; }
            set
            {
                if (value > _Maximum)
                    _Value = _Maximum;
                else if (value < _Minimum)
                    _Value = _Minimum;
                else _Value = value;
                Invalidate();
            }
        }

        public Boolean ShowText
        {
            get { return _ShowText; }
            set { _ShowText = value; Invalidate(); }
        }

        public Color ProgressBackground
        {
            get
            {
                return this._ProgressBackground;
            }

            set
            {
                this._ProgressBackground = value;
                Invalidate();
            }

        }

        public Color ProgressColor1
        {
            get
            {
                return this._ProgressColor1;
            }

            set
            {
                this._ProgressColor1 = value;
                Invalidate();
            }

        }

        public Color ProgressColor2
        {
            get
            {
                return this._ProgressColor2;
            }

            set
            {
                this._ProgressColor2 = value;
                Invalidate();
            }

        }

        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }

        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; Invalidate(); }
        }

        #endregion

        public ZeroitProgressBarTransparent()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = Helper.Fonts.Primary;


            #region MyRegion
            if (DesignMode)
            {
                timer.Tick += Timer_Tick;
                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }

            if (!DesignMode)
            {
                timer.Tick += Timer_Tick;

                if (AutoAnimate)
                {
                    //timer.Interval = 100;
                    timer.Start();
                }
            }



            #endregion

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            timer.Interval = interval;

            var g = e.Graphics;
            var l = new LinearGradientBrush(new Point(0, 0), new Point(Width + Value + 50, Height), _ProgressColor1, _ProgressColor2);

            g.SmoothingMode = SmoothingMode.HighQuality;


            //g.Clear(BackColor);

            g.FillRectangle(l, new Rectangle(0, 0, (int)(Helper.ValueToPercentage(Value, Maximum, Minimum) * Width), Height));

            Helper.RoundRect(g, 0, 0, Width - 1, Height - 1, 1, BackColor);

            if (ShowText)
                Helper.CenterString(g, Text, Font, Helper.Colors.Foreground, new Rectangle(0, 0, Width, Height));

            Helper.MultiDispose(l);

        }

    }


    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(myControlDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ZeroitProgressBarTransparentDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ZeroitProgressBarTransparentSmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }
    }

    #endregion

    #region SmartTagActionList
    public class ZeroitProgressBarTransparentSmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        private ZeroitProgressBarTransparent colUserControl;


        private DesignerActionUIService designerActionUISvc = null;


        public ZeroitProgressBarTransparentSmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as ZeroitProgressBarTransparent;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(colUserControl)[propName];
            if (null == prop)
                throw new ArgumentException("Matching ColorLabel property not found!", propName);
            else
                return prop;
        }

        #region Properties that are targets of DesignerActionPropertyItem entries.

        public int TimerInterval
        {
            get
            {
                return colUserControl.TimerInterval;
            }
            set
            {
                GetPropertyByName("TimerInterval").SetValue(colUserControl, value);
            }
        }

        public bool AutoAnimate
        {
            get
            {
                return colUserControl.AutoAnimate;
            }
            set
            {
                GetPropertyByName("AutoAnimate").SetValue(colUserControl, value);
            }
        }

        public Color BackColor
        {
            get
            {
                return colUserControl.BackColor;
            }
            set
            {
                GetPropertyByName("BackColor").SetValue(colUserControl, value);
            }
        }

        public Color ForeColor
        {
            get
            {
                return colUserControl.ForeColor;
            }
            set
            {
                GetPropertyByName("ForeColor").SetValue(colUserControl, value);
            }
        }

        public Int32 Maximum
        {
            get
            {
                return colUserControl.Maximum;
            }
            set
            {
                GetPropertyByName("Maximum").SetValue(colUserControl, value);
            }
        }

        public Int32 Minimum
        {
            get
            {
                return colUserControl.Minimum;
            }
            set
            {
                GetPropertyByName("Minimum").SetValue(colUserControl, value);
            }
        }

        public Int32 Value
        {
            get
            {
                return colUserControl.Value;
            }
            set
            {
                GetPropertyByName("Value").SetValue(colUserControl, value);
            }
        }

        public Boolean ShowText
        {
            get
            {
                return colUserControl.ShowText;
            }
            set
            {
                GetPropertyByName("ShowText").SetValue(colUserControl, value);
            }
        }

        public Color ProgressBackground
        {
            get
            {
                return colUserControl.ProgressBackground;
            }
            set
            {
                GetPropertyByName("ProgressBackground").SetValue(colUserControl, value);
            }

        }

        public Color ProgressColor1
        {
            get
            {
                return colUserControl.ProgressColor1;
            }
            set
            {
                GetPropertyByName("ProgressColor1").SetValue(colUserControl, value);
            }

        }

        public Color ProgressColor2
        {
            get
            {
                return colUserControl.ProgressColor2;
            }
            set
            {
                GetPropertyByName("ProgressColor2").SetValue(colUserControl, value);
            }

        }

        public string Text
        {
            get
            {
                return colUserControl.Text;
            }
            set
            {
                GetPropertyByName("Text").SetValue(colUserControl, value);
            }
        }

        public Font Font
        {
            get
            {
                return colUserControl.Font;
            }
            set
            {
                GetPropertyByName("Font").SetValue(colUserControl, value);
            }
        }

        #endregion

        #region DesignerActionItemCollection

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));

            items.Add(new DesignerActionPropertyItem("AutoAnimate",
                                 "Auto Animate", "Appearance",
                                 "Sets the progress to automatically animate."));

            items.Add(new DesignerActionPropertyItem("ShowText",
                                 "Show Text", "Appearance",
                                 "Shows the text of the progress."));

            items.Add(new DesignerActionPropertyItem("TimerInterval",
                                 "Timer Interval", "Appearance",
                                 "Sets the animation speed."));

            items.Add(new DesignerActionPropertyItem("BackColor",
                                 "Back Color", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ForeColor",
                                 "Fore Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("Maximum",
                                 "Maximum", "Appearance",
                                 "Sets the Maximum Value."));

            items.Add(new DesignerActionPropertyItem("Minimum",
                                 "Minimum", "Appearance",
                                 "Sets the Minimum Value."));

            items.Add(new DesignerActionPropertyItem("Value",
                                 "Value", "Appearance",
                                 "Sets the value of the progress."));

            items.Add(new DesignerActionPropertyItem("ProgressBackground",
                                 "Progress Background", "Appearance",
                                 "Sets the background color of the progress."));

            items.Add(new DesignerActionPropertyItem("ProgressColor1",
                                 "Progress Color1", "Appearance",
                                 "Sets the progress value color."));

            items.Add(new DesignerActionPropertyItem("ProgressColor2",
                                 "Progress Color2", "Appearance",
                                 "Sets the progress value color."));

            items.Add(new DesignerActionPropertyItem("Text",
                                 "Text", "Appearance",
                                 "Sets text property of the progress."));

            items.Add(new DesignerActionPropertyItem("Font",
                                 "Font", "Appearance",
                                 "Sets the Font of the progress."));

            //Create entries for static Information section.
            StringBuilder location = new StringBuilder("Product: ");
            location.Append(colUserControl.ProductName);
            StringBuilder size = new StringBuilder("Version: ");
            size.Append(colUserControl.ProductVersion);
            items.Add(new DesignerActionTextItem(location.ToString(),
                             "Information"));
            items.Add(new DesignerActionTextItem(size.ToString(),
                             "Information"));

            return items;
        }

        #endregion




    }

    #endregion

    #endregion

    #endregion
}
