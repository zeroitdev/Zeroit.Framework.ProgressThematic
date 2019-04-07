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
        #region Private Field

        private System.ComponentModel.Container components = null;
        //private ProgressBarEdge Edge = ProgressBarEdge.Rounded;
        //private Color EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        //private Color EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        //private int EdgeWidth = 1;
        //private ProgressFloodStyle FloodStyle = ProgressFloodStyle.Standard;
        //private float FloodPercentage = 0.20f;
        //private int BarOffset = 1;
        //private int DashWidth = 5;
        //private int DashSpace = 2;
        //private ProgressStyle ProgressBarStyle = ProgressStyle.Dashed;
        //private Color MainColor = Color.FromArgb(0, 255, 0);
        //private Color SecondColor = Color.FromKnownColor(KnownColor.White);
        //private Color ProgressBackColor = Color.FromKnownColor(KnownColor.White);
        //private int ExtendedProgress_Step = 1;
        //private bool ExtendedProgress_Shadow = true;
        //private int ShadowOffset = 1;
        //private bool TextAntialias = true;
        //private Color CaptionShadowColor = Color.FromKnownColor(KnownColor.White);
        //private Color CaptionColor = Color.FromKnownColor(KnownColor.Black);
        //private ProgressCaptionMode CaptionMode = ProgressCaptionMode.Percent;
        //private String Caption = "Progress";
        //private bool ChangeByMouse = false;
        //private bool Invert = false;
        //private ProgressBarDirection Orientation = ProgressBarDirection.Horizontal;

        #endregion
            
        #region Direction
        //#####
        [Description("Invert the progress direction")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public bool Invert
        {
            get
            {
                return progressInput.Invert;
            }
            set
            {
                progressInput.Invert = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the progress control horizontal or vertical")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public ProgressBarDirection Orientation
        {
            get
            {
                return progressInput.Orientation;
            }
            set
            {
                progressInput.Orientation = value;
                Invalidate();
            }
        }
        #endregion

        #region Edge
        //#####
        [Description("Set the edge of the control")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public ProgressBarEdge Edge
        {
            get
            {
                return progressInput.Edge;
            }
            set
            {
                progressInput.Edge = value;
                Invalidate();
            }
        }

        //#####
        [Description("Set the edge color")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color EdgeColor
        {
            get
            {
                return progressInput.EdgeColor;
            }
            set
            {
                progressInput.EdgeColor = value;
                Invalidate();
            }
        }
        //#####

        [Description("Set the edge light color")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color EdgeLightColor
        {
            get
            {
                return progressInput.EdgeLightColor;
            }
            set
            {
                progressInput.EdgeLightColor = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the edge width")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int EdgeWidth
        {
            get
            {
                return progressInput.EdgeWidth;
            }
            set
            {
                progressInput.EdgeWidth = value;
                if (value < 0) value = 0;
                if (value > Int16.MaxValue) value = Int16.MaxValue;

                Invalidate();
            }
        }
        //#####
        #endregion

        #region Progress
        //#####
        [Description("Set the floodstyle. Standard draws a standard xp-themed progressbar, and with Horizontal you can create a horizontal flood bar (for the best effect, set FloodPercentage to 1.0.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public ProgressFloodStyle FloodStyle
        {
            get
            {
                return progressInput.FloodStyle;
            }
            set
            {
                progressInput.FloodStyle = value;
                Invalidate();
            }
        }
        //#####

        [Description("Set the percentage of the flood color, a value between 0.0 and 1.0.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public float FloodPercentage
        {
            get
            {
                return progressInput.FloodPercentage;
            }
            set
            {
                progressInput.FloodPercentage = value;
                if (value < 0.0f) value = 0.0f;
                if (value > 1.0f) value = 1.0f;
                Invalidate();
            }
        }
        //#####
        [Description("Set the offset for the left, top, right and bottom")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int BarOffset
        {
            get
            {
                return progressInput.BarOffset;
            }
            set
            {
                progressInput.BarOffset = value;
                if (value < 0) value = 0;
                if (value > Int16.MaxValue) value = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        [Description("Set the width of a dash if Dashed mode")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int DashWidth
        {
            get
            {
                return progressInput.DashWidth;
            }
            set
            {
                progressInput.DashWidth = value;
                if (value < 0) value = 0;
                if (value > Int16.MaxValue) value = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####

        [Description("Set the space between every dash if Dashed mode")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int DashSpace
        {
            get
            {
                return progressInput.DashSpace;
            }
            set
            {
                progressInput.DashSpace = value;
                if (value < 0) value = 0;
                if (value > Int16.MaxValue) value = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        [Description("Set progressbar style")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public ProgressStyle ProgressBarStyle
        {
            get
            {
                return progressInput.ProgressBarStyle;
            }
            set
            {
                progressInput.ProgressBarStyle = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the main color")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color MainColor
        {
            get
            {
                return progressInput.MainColor;
            }
            set
            {
                progressInput.MainColor = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the second color")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color SecondColor
        {
            get
            {
                return progressInput.SecondColor;
            }
            set
            {
                progressInput.SecondColor = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the background color")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color ProgressBackColor
        {
            get
            {
                return progressInput.ProgressBackColor;
            }
            set
            {
                progressInput.ProgressBackColor = value;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Properties

        //private int ExtendedProgress_interval = 100;

        

        #region Include in Public Properties


        //[Category("RectangularProgress ZeroitExtendedProgress")]
        //public int ExtendedProgress_TimerInterval
        //{
        //    get { return ExtendedProgress_interval; }
        //    set
        //    {
        //        ExtendedProgress_interval = value;
        //        Invalidate();
        //    }
        //}

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


        //private int m_int_Minimum = 0;
        //[Description("Set the minimum value of this progress control")]
        //[Category("RectangularProgress ZeroitExtendedProgress")]
        //[Browsable(true)]
        //public int ExtendedProgress_Minimum
        //{
        //    get
        //    {
        //        return Minimum;
        //    }
        //    set
        //    {
        //        if (value < Maximum) Minimum = value;
        //        Invalidate();
        //    }
        //}

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
        //        if (value > Minimum) Maximum = value;
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
        //        if (Value < Minimum) Value = Minimum;
        //        if (Value > Maximum) Value = Maximum;
        //        Invalidate();
        //    }
        //}

        [Description("Set the step value")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int ExtendedProgress_Step
        {
            get
            {
                return progressInput.ExtendedProgress_Step;
            }
            set
            {
                progressInput.ExtendedProgress_Step = value;
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
        [Description("Enable/Disable shadow")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public bool ExtendedProgress_Shadow
        {
            get
            {
                return progressInput.ExtendedProgress_Shadow;
            }
            set
            {
                progressInput.ExtendedProgress_Shadow = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set shadow offset")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public int ShadowOffset
        {
            get
            {
                return progressInput.ShadowOffset;
            }
            set
            {
                progressInput.ShadowOffset = value;
                Invalidate();
            }
        }
        //#####
        [Description("Enable/Disable antialiasing")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public bool TextAntialias
        {
            get
            {
                return progressInput.TextAntialias;
            }
            set
            {
                progressInput.TextAntialias = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the caption shadow color.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color CaptionShadowColor
        {
            get
            {
                return progressInput.CaptionShadowColor;
            }
            set
            {
                progressInput.CaptionShadowColor = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the caption color.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public Color CaptionColor
        {
            get
            {
                return progressInput.CaptionColor;
            }
            set
            {
                progressInput.CaptionColor = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the caption mode.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public ProgressCaptionMode CaptionMode
        {
            get
            {
                return progressInput.CaptionMode;
            }
            set
            {
                progressInput.CaptionMode = value;
                Invalidate();
            }
        }
        //#####
        [Description("Set the caption.")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public String Caption
        {
            get
            {
                return progressInput.Caption;
            }
            set
            {
                progressInput.Caption = value;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Custom
        //#####
        [Description("Allows the user to change the value by clicking the mouse")]
        [Category("RectangularProgress ZeroitExtendedProgress")]
        [Browsable(true)]
        public bool ChangeByMouse
        {
            get
            {
                return progressInput.ChangeByMouse;
            }
            set
            {
                progressInput.ChangeByMouse = value;
                Invalidate();
            }
        }
        #endregion

        #region GetCustomCaption
        private String GetCustomCaption(String caption)
        {
            float float_Percentage = ((float)(Value - Minimum) / (float)(Maximum - Minimum)) * 100.0f;

            String toReturn = caption.Replace("<VALUE>", Value.ToString());
            toReturn = caption.Replace("<PERCENTAGE>", float_Percentage.ToString());

            return toReturn;
        }
        #endregion

        #region User Methods
        public void PerformStep()
        {
            Value += ExtendedProgress_Step;
            if (Value < Minimum) Value = Minimum;
            if (Value > Maximum) Value = Maximum;
        }

        public void Increment(int val)
        {
            Value += val;
            if (Value < Minimum) Value = Minimum;
            if (Value > Maximum) Value = Maximum;
        }
        #endregion

        #region Overrides
        private void Extended_Paint(PaintEventArgs e)
        {
            #region OnPaint - Draw Background

            //timer.Interval = ExtendedProgress_interval;

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
                        float float_ProgressDrawWidth = float_ProgressTotalWidth / (float)(Maximum - Minimum) * (float)(Value - Minimum);

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
                        float float_ProgressDrawHeight = float_ProgressTotalHeight / (float)(Maximum - Minimum) * (float)(Value - Minimum);

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
            if (TextAntialias) e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
                            e.Graphics.DrawString(Convert.ToInt32(Value).ToString(), this.Font, new SolidBrush(CaptionColor), new Rectangle(0, 0, this.Width, this.Height), format);
                        break;
                    }
                case ProgressCaptionMode.Percent:
                    {
                        float float_Percentage = ((float)(Value - Minimum) / (float)(Maximum - Minimum)) * 100.0f;
                        if (ExtendedProgress_Shadow)
                        {
                            if(ShowText)
                            e.Graphics.DrawString(Convert.ToInt32(float_Percentage).ToString() + PostFix, this.Font, new SolidBrush(CaptionShadowColor), new Rectangle(ShadowOffset, ShadowOffset, this.Width, this.Height), format);
                        }
                        if(ShowText)
                            e.Graphics.DrawString(Convert.ToInt32(float_Percentage).ToString() + PostFix, this.Font, new SolidBrush(CaptionColor), new Rectangle(0, 0, this.Width, this.Height), format);
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
                            e.Graphics.DrawString(GetCustomCaption(Caption), this.Font, new SolidBrush(CaptionColor), new Rectangle(0, 0, this.Width, this.Height), format);
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

                    float int_Range = Maximum - Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += Minimum;
                    if (int_NewValue < Minimum) int_NewValue = Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                else
                {
                    int int_ProgressWidth = this.Height - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.Y - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += Minimum;
                    if (int_NewValue < Minimum) int_NewValue = Minimum;
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

                    float int_Range = Maximum - Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += Minimum;
                    if (int_NewValue < Minimum) int_NewValue = Minimum;
                    if (int_NewValue > Maximum) int_NewValue = Maximum;
                    Value = int_NewValue;
                }
                else
                {
                    int int_ProgressWidth = this.Height - BarOffset * 2 - EdgeWidth * 2;
                    int int_MousePos = e.Y - BarOffset - EdgeWidth;

                    float percentageClick = (float)int_MousePos / (float)int_ProgressWidth;

                    float int_Range = Maximum - Minimum;
                    float int_NewValue = (int)((float)int_Range * percentageClick);
                    if (Invert) int_NewValue = int_Range - int_NewValue;
                    int_NewValue += Minimum;
                    if (int_NewValue < Minimum) int_NewValue = Minimum;
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
