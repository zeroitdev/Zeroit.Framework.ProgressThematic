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

    #region Extended Controls

    #region Enums

    public enum ExtendedBorderStyle
    {
        None,
        Single,
        Raised3D,
        Sunken3D,
        ExtendedProgress_Shadow
    };

    public enum ExtendedOrientation
    {
        Horizontal,
        Vertical
    };

    #endregion

    #region Progress Bar

    #region Enum
    //#####
    public enum ProgressCaptionMode
    {
        None,
        Percent,
        Value,
        Custom
    }
    //#####
    public enum ProgressFloodStyle
    {
        Standard,
        Horizontal
    }
    //#####
    public enum ProgressBarEdge
    {
        None,
        Rectangle,
        Rounded
    }
    //#####
    public enum ProgressBarDirection
    {
        Horizontal,
        Vertical
    }
    //#####
    public enum ProgressStyle
    {
        Dashed,
        Solid
    }
    //#####
    #endregion

    #region Control
    public partial class ThematicProgress 
    {
        private System.ComponentModel.Container components = null;

        #region Private Field

        //private System.ComponentModel.Container components = null;
        private ProgressBarEdge m_Edge = ProgressBarEdge.Rounded;
        private Color m_EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        private Color m_EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        private int m_EdgeWidth = 1;
        private ProgressFloodStyle m_FloodStyle = ProgressFloodStyle.Standard;
        private float m_float_BarFlood = 0.20f;
        private int m_int_BarOffset = 1;
        private int m_int_DashWidth = 5;
        private int m_int_DashSpace = 2;
        private ProgressStyle m_Style = ProgressStyle.Dashed;
        private Color m_Color1 = Color.FromArgb(0, 255, 0);
        private Color m_Color2 = Color.FromKnownColor(KnownColor.White);
        private Color m_color_Back = Color.FromKnownColor(KnownColor.White);
        private int m_int_Step = 1;
        private bool m_bool_Shadow = true;
        private int m_int_ShadowOffset = 1;
        private bool m_bool_Antialias = true;
        private Color m_color_Shadow = Color.FromKnownColor(KnownColor.White);
        private Color m_color_Caption = Color.FromKnownColor(KnownColor.Black);
        private ProgressCaptionMode m_CaptionMode = ProgressCaptionMode.Percent;
        private String m_str_Caption = "%";
        private bool m_bool_ChangeByMouse = false;
        private bool m_bool_Invert = false;
        private ProgressBarDirection m_Direction = ProgressBarDirection.Horizontal;
        private int m_int_Minimum = 0;
        private int ExtendedProgress_interval = 100;


        #endregion

        #region Direction
        //#####
        //private bool Invert = false;
        [Description("Invert the progress direction")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public bool Invert
        {
            get
            {
                return m_bool_Invert;
            }
            set
            {
                m_bool_Invert = value;
                Invalidate();
            }
        }
        //#####
        //private ProgressBarDirection Orientation = ProgressBarDirection.Horizontal;
        [Description("Set the progress control horizontal or vertical")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public ProgressBarDirection Orientation
        {
            get
            {
                return m_Direction;
            }
            set
            {
                m_Direction = value;
                Invalidate();
            }
        }
        #endregion

        #region Edge
        //#####
        //private ProgressBarEdge Edge = ProgressBarEdge.Rounded;
        [Description("Set the edge of the control")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public ProgressBarEdge Edge
        {
            get
            {
                return m_Edge;
            }
            set
            {
                m_Edge = value;
                Invalidate();
            }
        }
        //#####
        //private Color EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        [Description("Set the edge color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color EdgeColor
        {
            get
            {
                return m_EdgeColor;
            }
            set
            {
                m_EdgeColor = value;
                Invalidate();
            }
        }
        //#####
        //private Color EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        [Description("Set the edge light color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color EdgeLightColor
        {
            get
            {
                return m_EdgeLightColor;
            }
            set
            {
                m_EdgeLightColor = value;
                Invalidate();
            }
        }
        //#####
        //private int EdgeWidth = 1;
        [Description("Set the edge width")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int EdgeWidth
        {
            get
            {
                return m_EdgeWidth;
            }
            set
            {
                m_EdgeWidth = value;
                if (m_EdgeWidth < 0) m_EdgeWidth = 0;
                if (m_EdgeWidth > Int16.MaxValue) m_EdgeWidth = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Progress
        //#####
        //private ProgressFloodStyle FloodStyle = ProgressFloodStyle.Standard;
        [Description("Set the floodstyle. Standard draws a standard xp-themed progressbar, and with Horizontal you can create a horizontal flood bar (for the best effect, set FloodPercentage to 1.0.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public ProgressFloodStyle FloodStyle
        {
            get
            {
                return m_FloodStyle;
            }
            set
            {
                m_FloodStyle = value;
                Invalidate();
            }
        }
        //#####
        //private float FloodPercentage = 0.20f;
        [Description("Set the percentage of the flood color, a value between 0.0 and 1.0.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public float FloodPercentage
        {
            get
            {
                return m_float_BarFlood;
            }
            set
            {
                m_float_BarFlood = value;
                if (m_float_BarFlood < 0.0f) m_float_BarFlood = 0.0f;
                if (m_float_BarFlood > 1.0f) m_float_BarFlood = 1.0f;
                Invalidate();
            }
        }
        //#####
        //private int BarOffset = 1;
        [Description("Set the offset for the left, top, right and bottom")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int BarOffset
        {
            get
            {
                return m_int_BarOffset;
            }
            set
            {
                m_int_BarOffset = value;
                if (m_int_BarOffset < 0) m_int_BarOffset = 0;
                if (m_int_BarOffset > Int16.MaxValue) m_int_BarOffset = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private int DashWidth = 5;
        [Description("Set the width of a dash if Dashed mode")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int DashWidth
        {
            get
            {
                return m_int_DashWidth;
            }
            set
            {
                m_int_DashWidth = value;
                if (m_int_DashWidth < 0) m_int_DashWidth = 0;
                if (m_int_DashWidth > Int16.MaxValue) m_int_DashWidth = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private int DashSpace = 2;
        [Description("Set the space between every dash if Dashed mode")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int DashSpace
        {
            get
            {
                return m_int_DashSpace;
            }
            set
            {
                m_int_DashSpace = value;
                if (m_int_DashSpace < 0) m_int_DashSpace = 0;
                if (m_int_DashSpace > Int16.MaxValue) m_int_DashSpace = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private ProgressStyle ProgressBarStyle = ProgressStyle.Dashed;
        [Description("Set progressbar style")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public ProgressStyle ProgressBarStyle
        {
            get
            {
                return m_Style;
            }
            set
            {
                m_Style = value;
                Invalidate();
            }
        }
        //#####
        //private Color MainColor = Color.FromArgb(0, 255, 0);
        [Description("Set the main color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color MainColor
        {
            get
            {
                return m_Color1;
            }
            set
            {
                m_Color1 = value;
                Invalidate();
            }
        }
        //#####
        //private Color SecondColor = Color.FromKnownColor(KnownColor.White);
        [Description("Set the second color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color SecondColor
        {
            get
            {
                return m_Color2;
            }
            set
            {
                m_Color2 = value;
                Invalidate();
            }
        }
        //#####
        //private Color ProgressBackColor = Color.FromKnownColor(KnownColor.White);
        [Description("Set the background color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color ProgressBackColor
        {
            get
            {
                return m_color_Back;
            }
            set
            {
                m_color_Back = value;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Properties
            

        #region Include in Public Properties
        //private int ExtendedProgress_TimerInterval = 100;

        [Category("RectangularProgress ExtendedProgress")]
        public int ExtendedProgress_TimerInterval
        {
            get { return ExtendedProgress_interval; }
            set
            {
                ExtendedProgress_interval = value;
                Invalidate();
            }
        }

        #endregion

        #region Event

        private void Extended_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
                this.Value = 0;
            else
                this.Value++;

        }

        #endregion
        

        //private int ExtendedProgress_Minimum = 0;
        [Description("Set the minimum value of this progress control")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int ExtendedProgress_Minimum
        {
            get
            {
                return m_int_Minimum;
            }
            set
            {
                if (value < Maximum) m_int_Minimum = value;
                Invalidate();
            }
        }

        //private int Maximum = 100;
        //[Description("Set the maximum value of this progress control")]
        //[Category("Rectangular ZeroitExtendedProgress")]
        //[Browsable(true)]
        //public int Maximum
        //{
        //    get
        //    {
        //        return Maximum;
        //    }
        //    set
        //    {
        //        if (value > ExtendedProgress_Minimum) Maximum = value;
        //        Invalidate();
        //    }
        //}

        
            
        //private int Value = 33;
        //[Description("Set the current value of this progress control")]
        //[Category("Rectangular ZeroitExtendedProgress")]
        //[Browsable(true)]
        //public int Value
        //{
        //    get
        //    {
        //        return Value;
        //    }
        //    set
        //    {
        //        Value = value;
        //        if (Value < ExtendedProgress_Minimum) Value = ExtendedProgress_Minimum;
        //        if (Value > Maximum) Value = Maximum;
        //        Invalidate();
        //    }
        //}

        //private int ExtendedProgress_Step = 1;
        [Description("Set the step value")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int ExtendedProgress_Step
        {
            get
            {
                return m_int_Step;
            }
            set
            {
                m_int_Step = value;
                Invalidate();
            }
        }
        #endregion

        #region Constructor
        public void ZeroitExtendedProgressBar()
        {
            ExtendedProgress_InitializeComponent();
            
        }
        #endregion

        #region Caption
        //[Description("Change the font")]
        //[Category("Rectangular ZeroitExtendedProgress")]
        //[Browsable(true)]
        //public override Font Font
        //{
        //    get
        //    {
        //        return base.Font;
        //    }
        //    set
        //    {
        //        base.Font = value;
        //        Invalidate();
        //    }
        //}
        //#####
        //private bool ExtendedProgress_Shadow = true;
        [Description("Enable/Disable shadow")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public bool ExtendedProgress_Shadow
        {
            get
            {
                return m_bool_Shadow;
            }
            set
            {
                m_bool_Shadow = value;
                Invalidate();
            }
        }
        //#####
        //private int ShadowOffset = 1;
        [Description("Set shadow offset")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public int ShadowOffset
        {
            get
            {
                return m_int_ShadowOffset;
            }
            set
            {
                m_int_ShadowOffset = value;
                Invalidate();
            }
        }
        //#####
        //private bool TextAntialias = true;
        [Description("Enable/Disable antialiasing")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public bool TextAntialias
        {
            get
            {
                return m_bool_Antialias;
            }
            set
            {
                m_bool_Antialias = value;
                Invalidate();
            }
        }
        //#####
        //private Color CaptionShadowColor = Color.FromKnownColor(KnownColor.White);
        [Description("Set the caption shadow color.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color CaptionShadowColor
        {
            get
            {
                return m_color_Shadow;
            }
            set
            {
                m_color_Shadow = value;
                Invalidate();
            }
        }
        //#####
        //private Color CaptionColor = Color.FromKnownColor(KnownColor.Black);
        [Description("Set the caption color.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public Color CaptionColor
        {
            get
            {
                return m_color_Caption;
            }
            set
            {
                m_color_Caption = value;
                Invalidate();
            }
        }
        //#####
        //private ProgressCaptionMode CaptionMode = ProgressCaptionMode.Percent;
        [Description("Set the caption mode.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public ProgressCaptionMode CaptionMode
        {
            get
            {
                return m_CaptionMode;
            }
            set
            {
                m_CaptionMode = value;
                Invalidate();
            }
        }
        //#####
        //private String Caption = "Progress";
        [Description("Set the caption.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public String Caption
        {
            get
            {
                return m_str_Caption;
            }
            set
            {
                m_str_Caption = value;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Custom
        //#####
        //private bool ChangeByMouse = false;
        [Description("Allows the user to change the value by clicking the mouse")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(true)]
        public bool ChangeByMouse
        {
            get
            {
                return m_bool_ChangeByMouse;
            }
            set
            {
                m_bool_ChangeByMouse = value;
                Invalidate();
            }
        }
        #endregion

        #region GetCustomCaption
        private String GetCustomCaption(String caption)
        {
            float float_Percentage = ((float)(Value - ExtendedProgress_Minimum) / (float)(Maximum - ExtendedProgress_Minimum)) * 100.0f;

            String toReturn = caption.Replace("<VALUE>", Value.ToString());
            toReturn = caption.Replace("<PERCENTAGE>", float_Percentage.ToString());

            return toReturn;
        }
        #endregion

        #region User Methods
        public void PerformStep()
        {
            Value += ExtendedProgress_Step;
            if (Value < ExtendedProgress_Minimum) Value = ExtendedProgress_Minimum;
            if (Value > Maximum) Value = Maximum;
        }

        public void Increment(int val)
        {
            Value += val;
            if (Value < ExtendedProgress_Minimum) Value = ExtendedProgress_Minimum;
            if (Value > Maximum) Value = Maximum;
        }
        #endregion

        #region Overrides
        private void Extended_Paint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = Smoothing;
            e.Graphics.TextRenderingHint = TextRendering;

            #region OnPaint - Draw Background

            timer.Interval = ExtendedProgress_TimerInterval;

            SolidBrush brsh = new SolidBrush(ProgressBackColor);
            e.Graphics.FillRectangle(brsh, 0, 0, this.Width, this.Height);
            #endregion

            #region OnPaint - Draw ProgressBar
            switch (Orientation)
            {
                #region Horizontal
                case ProgressBarDirection.Horizontal:
                    {
                        float float_ProgressHeight = (float)(this.Height - EdgeWidth * 2 - BarOffset * 2);
                        float float_ProgressTotalWidth = this.Width - EdgeWidth * 2 - BarOffset * 2;
                        float float_ProgressDrawWidth = float_ProgressTotalWidth / (float)(Maximum - ExtendedProgress_Minimum) * (float)(Value - ExtendedProgress_Minimum);

                        int int_NumberOfDashes = (int)(float_ProgressDrawWidth / (float)(DashWidth + DashSpace));
                        int int_TotalDashes = (int)(float_ProgressTotalWidth / (float)(DashWidth + DashSpace));

                        Rectangle rect_Bar2 = new Rectangle(EdgeWidth + BarOffset, EdgeWidth + BarOffset, (int)float_ProgressTotalWidth, (int)float_ProgressHeight);
                        Rectangle rect_Bar;
                        if (Invert)
                        {
                            rect_Bar = new Rectangle(
                                      EdgeWidth + BarOffset + (int)(float_ProgressTotalWidth - float_ProgressDrawWidth)
                                    , EdgeWidth + BarOffset
                                    , (int)float_ProgressDrawWidth
                                    , (int)float_ProgressHeight);
                        }
                        else
                        {
                            rect_Bar = new Rectangle(
                                      EdgeWidth + BarOffset
                                    , EdgeWidth + BarOffset
                                    , (int)float_ProgressDrawWidth
                                    , (int)float_ProgressHeight);
                        }

                        LinearGradientBrush brsh_Bar = new LinearGradientBrush(rect_Bar2, SecondColor, MainColor, (FloodStyle == ProgressFloodStyle.Standard) ? 90.0f : 0.0f);
                        float[] factors = { 0.0f, 1.0f, 1.0f, 0.0f };
                        float[] positions = { 0.0f, FloodPercentage, 1.0f - FloodPercentage, 1.0f };

                        Blend blend = new Blend();
                        blend.Factors = factors;
                        blend.Positions = positions;
                        brsh_Bar.Blend = blend;

                        switch (ProgressBarStyle)
                        {
                            case ProgressStyle.Solid:
                                {
                                    e.Graphics.FillRectangle(brsh_Bar, rect_Bar);
                                    break;
                                }
                            case ProgressStyle.Dashed:
                                {
                                    if (Invert)
                                    {
                                        if (int_NumberOfDashes == 0) int_NumberOfDashes = -1;
                                        for (int i = 0; i < int_NumberOfDashes + 1; i++)
                                        {
                                            int j = i + (int_TotalDashes - int_NumberOfDashes);
                                            e.Graphics.FillRectangle(brsh_Bar, new Rectangle(EdgeWidth + BarOffset + (j * (DashWidth + DashSpace)), EdgeWidth + BarOffset, DashWidth, (int)float_ProgressHeight));
                                        }
                                    }
                                    else
                                    {
                                        if (int_NumberOfDashes == 0) int_NumberOfDashes = -1;
                                        for (int i = 0; i < int_NumberOfDashes + 1; i++)
                                        {
                                            e.Graphics.FillRectangle(brsh_Bar, new Rectangle(EdgeWidth + BarOffset + (i * (DashWidth + DashSpace)), EdgeWidth + BarOffset, DashWidth, (int)float_ProgressHeight));
                                        }
                                    }
                                    break;
                                }
                        }
                        brsh_Bar.Dispose();
                        break;
                    }
                #endregion
                #region Vertical
                case ProgressBarDirection.Vertical:
                    {
                        float float_ProgressWidth = (float)(this.Width - EdgeWidth * 2 - BarOffset * 2);
                        float float_ProgressTotalHeight = this.Height - EdgeWidth * 2 - BarOffset * 2;
                        float float_ProgressDrawHeight = float_ProgressTotalHeight / (float)(Maximum - ExtendedProgress_Minimum) * (float)(Value - ExtendedProgress_Minimum);

                        int int_NumberOfDashes = (int)(float_ProgressDrawHeight / (float)(DashWidth + DashSpace));
                        int int_TotalDashes = (int)(float_ProgressTotalHeight / (float)(DashWidth + DashSpace));

                        Rectangle rect_Bar2 = new Rectangle(EdgeWidth + BarOffset, EdgeWidth + BarOffset, (int)float_ProgressWidth, (int)float_ProgressTotalHeight);
                        Rectangle rect_Bar;
                        if (Invert)
                        {
                            rect_Bar = new Rectangle(
                                  EdgeWidth + BarOffset
                                , EdgeWidth + BarOffset + (int)(float_ProgressTotalHeight - float_ProgressDrawHeight)
                                , (int)float_ProgressWidth
                                , (int)float_ProgressDrawHeight);
                        }
                        else
                        {
                            rect_Bar = new Rectangle(
                                  EdgeWidth + BarOffset
                                , EdgeWidth + BarOffset
                                , (int)float_ProgressWidth
                                , (int)float_ProgressDrawHeight);
                        }

                        LinearGradientBrush brsh_Bar = new LinearGradientBrush(rect_Bar2, SecondColor, MainColor, (FloodStyle == ProgressFloodStyle.Standard) ? 0.0f : 90.0f);
                        float[] factors = { 0.0f, 1.0f, 1.0f, 0.0f };
                        float[] positions = { 0.0f, FloodPercentage, 1.0f - FloodPercentage, 1.0f };

                        Blend blend = new Blend();
                        blend.Factors = factors;
                        blend.Positions = positions;
                        brsh_Bar.Blend = blend;

                        switch (ProgressBarStyle)
                        {
                            case ProgressStyle.Solid:
                                {
                                    e.Graphics.FillRectangle(brsh_Bar, rect_Bar);
                                    break;
                                }
                            case ProgressStyle.Dashed:
                                {
                                    if (Invert)
                                    {
                                        if (int_NumberOfDashes == 0) int_NumberOfDashes = -1;
                                        for (int i = 0; i < int_NumberOfDashes + 1; i++)
                                        {
                                            int j = i + (int_TotalDashes - int_NumberOfDashes);
                                            e.Graphics.FillRectangle(brsh_Bar, new Rectangle(EdgeWidth + BarOffset, EdgeWidth + BarOffset + (j * (DashWidth + DashSpace)), (int)float_ProgressWidth, DashWidth));
                                        }
                                    }
                                    else
                                    {
                                        if (int_NumberOfDashes == 0) int_NumberOfDashes = -1;
                                        for (int i = 0; i < int_NumberOfDashes + 1; i++)
                                        {
                                            e.Graphics.FillRectangle(brsh_Bar, new Rectangle(EdgeWidth + BarOffset, EdgeWidth + BarOffset + (i * (DashWidth + DashSpace)), (int)float_ProgressWidth, DashWidth));
                                        }
                                    }
                                    break;
                                }
                        }
                        brsh_Bar.Dispose();
                        break;
                    }
                    #endregion
            }
            #endregion

            #region OnPaint - Draw Edge
            switch (Edge)
            {
                case ProgressBarEdge.Rectangle:
                    {
                        Pen pen = new Pen(EdgeColor);
                        Pen pen3 = new Pen(EdgeLightColor);
                        for (int i = 0; i < EdgeWidth; i++)
                        {
                            e.Graphics.DrawRectangle(pen, 0 + i, 0 + i, this.Width - 1 - i * 2, this.Height - 1 - i * 2);
                        }
                        e.Graphics.DrawLine(pen3, EdgeWidth, EdgeWidth, this.Width - 1 - EdgeWidth, EdgeWidth);
                        e.Graphics.DrawLine(pen3, EdgeWidth, EdgeWidth, EdgeWidth, this.Height - 1 - EdgeWidth);
                        break;
                    }
                case ProgressBarEdge.Rounded:
                    {
                        Pen pen = new Pen(EdgeColor);
                        Pen pen2 = new Pen(this.BackColor);
                        Pen pen3 = new Pen(EdgeLightColor);
                        for (int i = 0; i < EdgeWidth; i++)
                        {
                            e.Graphics.DrawRectangle(pen, 0 + i, 0 + i, this.Width - 1 - i * 2, this.Height - 1 - i * 2);
                        }
                        e.Graphics.DrawLine(pen2, 0, 0, 1, 0);
                        e.Graphics.DrawLine(pen2, 0, 0, 0, 1);
                        e.Graphics.DrawLine(pen2, 0, this.Height - 1, 1, this.Height - 1);
                        e.Graphics.DrawLine(pen2, 0, this.Height - 1, 0, this.Height - 2);
                        e.Graphics.DrawLine(pen2, this.Width - 2, 0, this.Width - 1, 0);
                        e.Graphics.DrawLine(pen2, this.Width - 1, 0, this.Width - 1, 1);
                        e.Graphics.DrawLine(pen2, this.Width - 2, this.Height - 1, this.Width - 1, this.Height - 1);
                        e.Graphics.DrawLine(pen2, this.Width - 1, this.Height - 2, this.Width - 1, this.Height - 1);

                        e.Graphics.FillRectangle(new SolidBrush(EdgeColor), EdgeWidth, EdgeWidth, 1, 1);
                        e.Graphics.FillRectangle(new SolidBrush(EdgeColor), EdgeWidth, this.Height - 1 - EdgeWidth, 1, 1);
                        e.Graphics.FillRectangle(new SolidBrush(EdgeColor), this.Width - 1 - EdgeWidth, EdgeWidth, 1, 1);
                        e.Graphics.FillRectangle(new SolidBrush(EdgeColor), this.Width - 1 - EdgeWidth, this.Height - 1 - EdgeWidth, 1, 1);

                        e.Graphics.DrawLine(pen3, EdgeWidth + 1, EdgeWidth, this.Width - 2 - EdgeWidth, EdgeWidth);
                        e.Graphics.DrawLine(pen3, EdgeWidth, EdgeWidth + 1, EdgeWidth, this.Height - 2 - EdgeWidth);

                        break;
                    }
            }
            #endregion

            #region OnPaint - Draw Caption
            if (TextAntialias) e.Graphics.TextRenderingHint = TextRendering;
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            format.Trimming = StringTrimming.EllipsisCharacter;
            switch (CaptionMode)
            {
                case ProgressCaptionMode.Value:
                    {
                        if (ExtendedProgress_Shadow)
                        {
                            if(ShowText)
                                e.Graphics.DrawString(Convert.ToInt32(Value).ToString(), this.Font, new SolidBrush(CaptionShadowColor), new Rectangle(ShadowOffset, ShadowOffset, this.Width, this.Height), format);
                        }

                        if(ShowText)
                            e.Graphics.DrawString(Convert.ToInt32(Value).ToString(), this.Font, new SolidBrush(ForeColor), new Rectangle(0, 0, this.Width, this.Height), format);
                        break;
                    }
                case ProgressCaptionMode.Percent:
                    {
                        float float_Percentage = ((float)(Value - ExtendedProgress_Minimum) / (float)(Maximum - ExtendedProgress_Minimum)) * 100.0f;
                        if (ExtendedProgress_Shadow)
                        {
                            if(ShowText)
                            e.Graphics.DrawString(Convert.ToInt32(float_Percentage).ToString() + PostFix, this.Font, new SolidBrush(CaptionShadowColor), new Rectangle(ShadowOffset, ShadowOffset, this.Width, this.Height), format);
                        }
                        if(ShowText)
                            e.Graphics.DrawString(Convert.ToInt32(float_Percentage).ToString() + PostFix, this.Font, new SolidBrush(ForeColor), new Rectangle(0, 0, this.Width, this.Height), format);
                        break;
                    }
                case ProgressCaptionMode.Custom:
                    {
                        if (ExtendedProgress_Shadow)
                        {
                            if(ShowText)
                                e.Graphics.DrawString(GetCustomCaption(Caption), this.Font, new SolidBrush(CaptionShadowColor), new Rectangle(ShadowOffset, ShadowOffset, this.Width, this.Height), format);
                        }

                        if(ShowText)
                            e.Graphics.DrawString(GetCustomCaption(Caption), this.Font, new SolidBrush(ForeColor), new Rectangle(0, 0, this.Width, this.Height), format);
                        break;
                    }
            }
            #endregion

            
        }

        private void Extended_Resize(EventArgs e)
        {
            Invalidate();
            
        }

        
        #endregion

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void ExtendedProgress_InitializeComponent()
        {
            
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBar_MouseDown);

        }
        #endregion

        #region ChangeByMouse
        private void ProgressBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            /**/
        }

        private void ProgressBar_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (ChangeByMouse && e.Button == MouseButtons.Left)
            {
                if (Orientation == ProgressBarDirection.Horizontal)
                {
                    int int_ProgressWidth = this.Width - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.X - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - ExtendedProgress_Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += ExtendedProgress_Minimum;
                    if (int_NewValue < ExtendedProgress_Minimum) int_NewValue = ExtendedProgress_Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                else
                {
                    int int_ProgressWidth = this.Height - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.Y - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - ExtendedProgress_Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += ExtendedProgress_Minimum;
                    if (int_NewValue < ExtendedProgress_Minimum) int_NewValue = ExtendedProgress_Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                Invalidate();
            }
        }

        private void ProgressBar_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (ChangeByMouse)
            {
                if (Orientation == ProgressBarDirection.Horizontal)
                {
                    int int_ProgressWidth = this.Width - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.X - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - ExtendedProgress_Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += ExtendedProgress_Minimum;
                    if (int_NewValue < ExtendedProgress_Minimum) int_NewValue = ExtendedProgress_Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                else
                {
                    int int_ProgressWidth = this.Height - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.Y - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - ExtendedProgress_Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += ExtendedProgress_Minimum;
                    if (int_NewValue < ExtendedProgress_Minimum) int_NewValue = ExtendedProgress_Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                Invalidate();
            }
        }
        #endregion
    }


    #endregion
    
    #endregion

    #region Info

    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class Info
    {
        public Info()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

    #endregion

    #endregion

}
