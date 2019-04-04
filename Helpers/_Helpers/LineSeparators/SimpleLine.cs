// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SimpleLine.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.AnimationHelpers.LineSeparators
{

    #region Simple Line 1 !!!!!!!!!!!!!!!!!!!!!!!!! Default !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


    #region E N U M S    
    /// <summary>
    /// Enum for retrieving the Line style for <c><see cref="LineSimple"/></c>;
    /// </summary>
    public enum ZeroitSimpleLineLineStyle
    {
        /// <summary>
        /// The none
        /// </summary>
        None = 0,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical = 1,
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal = 2,
        /// <summary>
        /// The box
        /// </summary>
        Box = 3
    }

    /// <summary>
    /// Enum for setting the line gradient direction of  <c><see cref="LineSimple"/></c>;
    /// </summary>
    public enum ZeroitSimpleLineGradientDirection
    {
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal = 1,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical = 2
    }

    #endregion

    /// <summary>
    /// A class collection for rendering a line. 
    /// <br></br>
    /// Features include : 
    /// <ul>
    /// <li>Vertical</li>
    /// <li>Horizontal</li>
    /// <li>Box</li>
    /// </ul>
    /// </summary>
    /// 
    [Designer(typeof(ZeroitSimpleLineDesigner))]
    [ToolboxItem(false)]
    public class LineSimple : System.Windows.Forms.UserControl
    {

        #region D E C L A R A T I O N S

        private System.Drawing.Color _color = System.Drawing.Color.Black;
        private System.Drawing.Color _fillColor = System.Drawing.Color.Transparent;
        private int _lineWidth = 1;
        private ZeroitSimpleLineLineStyle _lineStyle;
        private bool _fitToParent = false;
        private System.Drawing.Color _Gradient = System.Drawing.Color.Transparent;
        private bool _useGradient = false;
        private ZeroitSimpleLineGradientDirection _gradientAngle = ZeroitSimpleLineGradientDirection.Horizontal;
        private float angle = 0f;

        // Added AfterPaint event, which will be raised after the control paints itself
        public event PaintEventHandler AfterPaint;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region C O N S T R U C T O R
        public LineSimple()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            DrawLine();

            // TODO: Add any initialization after the InitComponent call
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region P R O P E R T I E S

        /// <summary>
        /// Gets and sets the line gradient angle.
        /// </summary>
        [Category("Custom")]
        public ZeroitSimpleLineGradientDirection GradientAngle
        {
            get { return _gradientAngle; }
            set
            {
                _gradientAngle = value;
                DrawLine();
            }
        }

        /// <summary>
        /// For lines, this will scale the line to fit right-to-left, or top-to-bottom
        /// </summary>
        [Category("Custom")]
        public bool FitToParent
        {
            get { return _fitToParent; }
            set
            {
                _fitToParent = value;
                DrawLine();
            }
        }

        /// <summary>
        /// If set to true, gradient will draw with FillColor and Gradient color
        /// </summary>
        [Category("Custom")]
        public bool UseGradient
        {
            get { return _useGradient; }
            set
            {
                if (FillColor == Color.Transparent && Gradient == Color.Transparent)
                {
                    Gradient = Color.Teal;
                    FillColor = Color.Orange;
                    //MessageBox.Show("Please Choose colors for the Gradient and FillColor");
                }
                _useGradient = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the color of the fill.
        /// </summary>
        /// <value>The color of the fill.</value>
        [Category("Custom")]
        public System.Drawing.Color FillColor
        {
            get { return _fillColor; }
            set
            {
                _fillColor = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the gradient color.
        /// </summary>
        /// <value>The gradient.</value>
        [Category("Custom")]
        public System.Drawing.Color Gradient
        {
            get { return _Gradient; }
            set
            {
                _Gradient = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the color of the line.
        /// </summary>
        /// <value>The color of the line.</value>
        [Category("Custom")]
        public System.Drawing.Color LineColor
        {
            get
            {
                if (_color == Color.Transparent) { _color = Parent.BackColor; }
                return _color;

            }
            set
            {
                _color = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the width of the line.
        /// </summary>
        /// <value>The width of the line.</value>
        [Category("Custom")]
        public int LineWidth
        {
            get { return _lineWidth; }
            set
            {
                _lineWidth = value;
                DrawLine();
            }
        }

        /// <summary>
        /// Gets or sets the value whether the line is horizontal, vertical, or box.
        /// </summary>
        [Category("Custom")]
        public ZeroitSimpleLineLineStyle Style
        {
            get { return _lineStyle; }
            set
            {
                _lineStyle = value;
                if (value == ZeroitSimpleLineLineStyle.Vertical && Height <= LineWidth) { Height = 50; Width = LineWidth; }
                if (value == ZeroitSimpleLineLineStyle.Horizontal && Width <= LineWidth) { Width = 50; Height = LineWidth; }
                if ((value == ZeroitSimpleLineLineStyle.Box) && ((Width <= LineWidth) || (Height <= LineWidth)))
                {
                    Height = 50;
                    Width = 50;
                }
                DrawLine();
            }
        }
        #endregion

        #region E V E N T S

        protected override void InitLayout()
        {
            DrawLine();
        }


        #endregion

        #region M E T H O D S

        public void DrawLine()
        {
            if (this.Parent == null) { return; } //we don't want the control to draw on itself at design time

            if (this.Style == ZeroitSimpleLineLineStyle.None) //default to Horizontal line, when placed on a parent
            {
                _lineStyle = ZeroitSimpleLineLineStyle.Horizontal;
                _lineWidth = 1;
                this.Left = (Parent.Width / 2) - this.Width / 2;
                this.Top = Parent.Height / 2;
            }

            Graphics g = this.CreateGraphics(); //create the graphics object
            g.Clear(Parent.BackColor);
            Pen pn;
            if (this.Style == ZeroitSimpleLineLineStyle.Vertical || this.Style == ZeroitSimpleLineLineStyle.Horizontal)
                pn = new Pen(LineColor, LineWidth * 2);
            else
                pn = new Pen(LineColor, LineWidth);

            Point pt1 = new Point(0, 0);
            Point pt2;
            if (this.Style == ZeroitSimpleLineLineStyle.Horizontal)
            {
                if (FitToParent == true)
                {
                    this.Left = 0;
                    this.Width = Parent.ClientRectangle.Width;
                }

                this.Height = LineWidth;
                if (this.Height < 1) { this.Height = 1; }

                pt2 = new Point(Width, 0);
                if (UseGradient == false)
                {
                    g.DrawLine(pn, pt1, pt2);

                }
                else
                {
                    Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.ClientRectangle.Width, LineWidth));
                    if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                    {
                        LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, 0, false);
                        g.FillRectangle(lgb, 0, 0, this.Width, LineWidth);
                    }
                }
            }
            else if (this.Style == ZeroitSimpleLineLineStyle.Vertical)
            {
                if (FitToParent == true)
                {
                    this.Top = 0;
                    this.Height = Parent.Height;
                }

                this.Width = LineWidth;
                if (this.Width < 1) { this.Width = 1; }

                pt2 = new Point(0, Height);
                if (UseGradient == false)
                {
                    g.DrawLine(pn, pt1, pt2);
                }
                else
                {
                    Rectangle rect = new Rectangle(new Point(0, 0), new Size(LineWidth, this.Height));
                    if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                    {
                        LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, 90, false);
                        g.FillRectangle(lgb, 0, 0, LineWidth, this.Height);

                    }
                }
            }
            else if (this.Style == ZeroitSimpleLineLineStyle.Box)
            {
                if (FitToParent == true)
                {
                    this.Top = 0;
                    this.Left = 0;
                    this.Width = Parent.Width;
                    this.Height = Parent.Height;
                }

                Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width, this.Height));
                if (FillColor == Color.Transparent) { FillColor = Parent.BackColor; }
                if (UseGradient)
                {
                    LinearGradientBrush lgb = new LinearGradientBrush(rect, FillColor, Gradient, GradientAngle == ZeroitSimpleLineGradientDirection.Horizontal ? 0 : 90, false);
                    g.FillRectangle(lgb, 0, 0, this.Width - LineWidth, this.Height - LineWidth);

                }
                else
                {
                    SolidBrush sb = new SolidBrush(FillColor);
                    g.FillRectangle(sb, 0, 0, this.Width - LineWidth, this.Height - LineWidth);

                }

                decimal mod = Decimal.Remainder((decimal)LineWidth, (decimal)2);
                int offset = 0;
                if (mod != 0 && LineWidth != 1) { offset = 1; }

                rect.Offset(LineWidth / 2, LineWidth / 2);
                rect.Height = rect.Height - LineWidth + offset - 1;
                rect.Width = rect.Width - LineWidth + offset - 1;
                if (LineWidth > 0) { g.DrawRectangle(pn, rect); }
            }

            g.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            OnResize(EventArgs.Empty);

            // Added AfterPaint event, which will be raised after the control paints itself
            if (AfterPaint != null)
                AfterPaint(this, e);
        }

        protected override void OnResize(EventArgs e)
        {

            DrawLine();
            base.OnResize(e);
        }



        #endregion

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // simpleLine
            // 
            this.Name = "simpleLine";
            this.Size = new System.Drawing.Size(96, 32);

        }
        #endregion
    }


    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(ZeroitSimpleLineDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ZeroitSimpleLineDesigner : System.Windows.Forms.Design.ControlDesigner
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
                    actionLists.Add(new ZeroitSimpleLineSmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }
    }

    #endregion

    #region SmartTagActionList
    public class ZeroitSimpleLineSmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        private LineSimple colUserControl;


        private DesignerActionUIService designerActionUISvc = null;


        public ZeroitSimpleLineSmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as LineSimple;

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

        public ZeroitSimpleLineGradientDirection GradientAngle
        {
            get
            {
                return colUserControl.GradientAngle;
            }
            set
            {
                GetPropertyByName("GradientAngle").SetValue(colUserControl, value);
            }
        }

        public bool FitToParent
        {
            get
            {
                return colUserControl.FitToParent;
            }
            set
            {
                GetPropertyByName("FitToParent").SetValue(colUserControl, value);
            }
        }

        public bool UseGradient
        {
            get
            {
                return colUserControl.UseGradient;
            }
            set
            {
                GetPropertyByName("UseGradient").SetValue(colUserControl, value);
            }
        }

        public Color FillColor
        {
            get
            {
                return colUserControl.FillColor;
            }
            set
            {
                GetPropertyByName("FillColor").SetValue(colUserControl, value);
            }
        }

        public Color Gradient
        {
            get
            {
                return colUserControl.Gradient;
            }
            set
            {
                GetPropertyByName("Gradient").SetValue(colUserControl, value);
            }
        }

        public Color LineColor
        {
            get
            {
                return colUserControl.LineColor;
            }
            set
            {
                GetPropertyByName("LineColor").SetValue(colUserControl, value);
            }
        }

        public int LineWidth
        {
            get
            {
                return colUserControl.LineWidth;
            }
            set
            {
                GetPropertyByName("LineWidth").SetValue(colUserControl, value);
            }
        }

        public ZeroitSimpleLineLineStyle Style
        {
            get
            {
                return colUserControl.Style;
            }
            set
            {
                GetPropertyByName("Style").SetValue(colUserControl, value);
            }
        }

        #endregion

        #region DesignerActionItemCollection

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));

            items.Add(new DesignerActionPropertyItem("BackColor",
                                 "Back Color", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("ForeColor",
                                 "Fore Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("GradientAngle",
                                 "Gradient Angle", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("FitToParent",
                                 "Fit To Parent", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("UseGradient",
                                 "Use Gradient", "Appearance",
                                 "Selects the background color."));

            items.Add(new DesignerActionPropertyItem("FillColor",
                                 "Fill Color", "Appearance",
                                 "Selects the foreground color."));

            items.Add(new DesignerActionPropertyItem("Gradient",
                                 "Gradient", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("LineColor",
                                 "Line Color", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("LineWidth",
                                 "Line Width", "Appearance",
                                 "Type few characters to filter Cities."));

            items.Add(new DesignerActionPropertyItem("Style",
                                 "Style", "Appearance",
                                 "Type few characters to filter Cities."));

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
