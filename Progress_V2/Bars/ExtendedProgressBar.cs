// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ExtendedProgressBar.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region Extended Controls

    #region Enums

    /// <summary>
    /// Enum ExtendedBorderStyle
    /// </summary>
    public enum ExtendedBorderStyle
    {
        /// <summary>
        /// The none
        /// </summary>
        None,
        /// <summary>
        /// The single
        /// </summary>
        Single,
        /// <summary>
        /// The raised3 d
        /// </summary>
        Raised3D,
        /// <summary>
        /// The sunken3 d
        /// </summary>
        Sunken3D,
        /// <summary>
        /// The extended progress shadow
        /// </summary>
        ExtendedProgress_Shadow
    };

    /// <summary>
    /// Enum ExtendedOrientation
    /// </summary>
    public enum ExtendedOrientation
    {
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical
    };

    #endregion

    #region Progress Bar

    #region Enum
    //#####
    /// <summary>
    /// Enum ProgressCaptionMode
    /// </summary>
    public enum ProgressCaptionMode
    {
        /// <summary>
        /// The none
        /// </summary>
        None,
        /// <summary>
        /// The percent
        /// </summary>
        Percent,
        /// <summary>
        /// The value
        /// </summary>
        Value,
        /// <summary>
        /// The custom
        /// </summary>
        Custom
    }
    //#####
    /// <summary>
    /// Enum ProgressFloodStyle
    /// </summary>
    public enum ProgressFloodStyle
    {
        /// <summary>
        /// The standard
        /// </summary>
        Standard,
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal
    }
    //#####
    /// <summary>
    /// Enum ProgressBarEdge
    /// </summary>
    public enum ProgressBarEdge
    {
        /// <summary>
        /// The none
        /// </summary>
        None,
        /// <summary>
        /// The rectangle
        /// </summary>
        Rectangle,
        /// <summary>
        /// The rounded
        /// </summary>
        Rounded
    }
    //#####
    /// <summary>
    /// Enum ProgressBarDirection
    /// </summary>
    public enum ProgressBarDirection
    {
        /// <summary>
        /// The horizontal
        /// </summary>
        Horizontal,
        /// <summary>
        /// The vertical
        /// </summary>
        Vertical
    }
    //#####
    /// <summary>
    /// Enum ProgressStyle
    /// </summary>
    public enum ProgressStyle
    {
        /// <summary>
        /// The dashed
        /// </summary>
        Dashed,
        /// <summary>
        /// The solid
        /// </summary>
        Solid
    }
    //#####
    #endregion

    #region Control
    public partial class ZeroitThematicProgress 
    {
        /// <summary>
        /// The components
        /// </summary>
        private System.ComponentModel.Container components = null;

        #region Direction
        //#####
        //private bool Invert = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ZeroitThematicProgress"/> is invert.
        /// </summary>
        /// <value><c>true</c> if invert; otherwise, <c>false</c>.</value>
        [Description("Invert the progress direction")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private ProgressBarDirection Orientation = ProgressBarDirection.Horizontal;
        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        [Description("Set the progress control horizontal or vertical")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private ProgressBarEdge Edge = ProgressBarEdge.Rounded;
        /// <summary>
        /// Gets or sets the edge.
        /// </summary>
        /// <value>The edge.</value>
        [Description("Set the edge of the control")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        /// <summary>
        /// Gets or sets the color of the edge.
        /// </summary>
        /// <value>The color of the edge.</value>
        [Description("Set the edge color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        /// <summary>
        /// Gets or sets the color of the edge light.
        /// </summary>
        /// <value>The color of the edge light.</value>
        [Description("Set the edge light color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private int EdgeWidth = 1;
        /// <summary>
        /// Gets or sets the width of the edge.
        /// </summary>
        /// <value>The width of the edge.</value>
        [Description("Set the edge width")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int EdgeWidth
        {
            get
            {
                return progressInput.EdgeWidth;
            }
            set
            {
                progressInput.EdgeWidth = value;
                if (progressInput.EdgeWidth < 0) progressInput.EdgeWidth = 0;
                if (progressInput.EdgeWidth > Int16.MaxValue) progressInput.EdgeWidth = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        #endregion

        #region Progress
        //#####
        //private ProgressFloodStyle FloodStyle = ProgressFloodStyle.Standard;
        /// <summary>
        /// Gets or sets the flood style.
        /// </summary>
        /// <value>The flood style.</value>
        [Description("Set the floodstyle. Standard draws a standard xp-themed progressbar, and with Horizontal you can create a horizontal flood bar (for the best effect, set FloodPercentage to 1.0.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private float FloodPercentage = 0.20f;
        /// <summary>
        /// Gets or sets the flood percentage.
        /// </summary>
        /// <value>The flood percentage.</value>
        [Description("Set the percentage of the flood color, a value between 0.0 and 1.0.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public float FloodPercentage
        {
            get
            {
                return progressInput.FloodPercentage;
            }
            set
            {
                progressInput.FloodPercentage = value;
                if (progressInput.FloodPercentage < 0.0f) progressInput.FloodPercentage = 0.0f;
                if (progressInput.FloodPercentage > 1.0f) progressInput.FloodPercentage = 1.0f;
                Invalidate();
            }
        }
        //#####
        //private int BarOffset = 1;
        /// <summary>
        /// Gets or sets the bar offset.
        /// </summary>
        /// <value>The bar offset.</value>
        [Description("Set the offset for the left, top, right and bottom")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int BarOffset
        {
            get
            {
                return progressInput.BarOffset;
            }
            set
            {
                progressInput.BarOffset = value;
                if (progressInput.BarOffset < 0) progressInput.BarOffset = 0;
                if (progressInput.BarOffset > Int16.MaxValue) progressInput.BarOffset = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private int DashWidth = 5;
        /// <summary>
        /// Gets or sets the width of the dash.
        /// </summary>
        /// <value>The width of the dash.</value>
        [Description("Set the width of a dash if Dashed mode")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int DashWidth
        {
            get
            {
                return progressInput.DashWidth;
            }
            set
            {
                progressInput.DashWidth = value;
                if (progressInput.DashWidth < 0) progressInput.DashWidth = 0;
                if (progressInput.DashWidth > Int16.MaxValue) progressInput.DashWidth = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private int DashSpace = 2;
        /// <summary>
        /// Gets or sets the dash space.
        /// </summary>
        /// <value>The dash space.</value>
        [Description("Set the space between every dash if Dashed mode")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int DashSpace
        {
            get
            {
                return progressInput.DashSpace;
            }
            set
            {
                progressInput.DashSpace = value;
                if (progressInput.DashSpace < 0) progressInput.DashSpace = 0;
                if (progressInput.DashSpace > Int16.MaxValue) progressInput.DashSpace = Int16.MaxValue;
                Invalidate();
            }
        }
        //#####
        //private ProgressStyle ProgressBarStyle = ProgressStyle.Dashed;
        /// <summary>
        /// Gets or sets the progress bar style.
        /// </summary>
        /// <value>The progress bar style.</value>
        [Description("Set progressbar style")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color MainColor = Color.FromArgb(0, 255, 0);
        /// <summary>
        /// Gets or sets the color of the main.
        /// </summary>
        /// <value>The color of the main.</value>
        [Description("Set the main color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color SecondColor = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// Gets or sets the color of the second.
        /// </summary>
        /// <value>The color of the second.</value>
        [Description("Set the second color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color ProgressBackColor = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// Gets or sets the color of the progress back.
        /// </summary>
        /// <value>The color of the progress back.</value>
        [Description("Set the background color")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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


        #region Include in Public Properties
        //private int ExtendedProgress_TimerInterval = 100;

        /// <summary>
        /// Gets or sets the extended progress timer interval.
        /// </summary>
        /// <value>The extended progress timer interval.</value>
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int ExtendedProgress_TimerInterval
        {
            get { return progressInput.ExtendedProgress_TimerInterval; }
            set
            {
                progressInput.ExtendedProgress_TimerInterval = value;
                Invalidate();
            }
        }

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the Extended_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Extended_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //    this.Value = 0;
            //else
            //    this.Value++; 
            #endregion

            if (Reverse)
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
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
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            else
            {
                if (this.Value + (Change * SpeedMultiplier) > this.Maximum)
                {
                    
                    timerDecrement.Enabled = false;
                    timerDecrement.Stop();
                    //timerDecrement.Tick += TimerDecrement_Tick;
                    Value = 0;
                    Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    Invalidate();
                }
            }

            

        }

        /// <summary>
        /// Handles the Tick event of the Extended_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Extended_Timer_Reduced_Tick(object sender, EventArgs e)
        {
            if (this.Value < this.Minimum)
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
                this.Value -= (Change * SpeedMultiplier);
                Invalidate();
            }

        }

        #endregion


        //private int ExtendedProgress_Minimum = 0;
        /// <summary>
        /// Gets or sets the extended progress minimum.
        /// </summary>
        /// <value>The extended progress minimum.</value>
        [Description("Set the minimum value of this progress control")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
        public int ExtendedProgress_Minimum
        {
            get
            {
                return progressInput.ExtendedProgress_Minimum;
            }
            set
            {
                if (value < Maximum) progressInput.ExtendedProgress_Minimum = value;
                Invalidate();
            }
        }

        //private int Maximum = 100;
        //[Description("Set the maximum value of this progress control")]
        //[Category("Rectangular ZeroitExtendedProgress")]
        //[Browsable(false)]
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
        //[Browsable(false)]
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
        /// <summary>
        /// Gets or sets the extended progress step.
        /// </summary>
        /// <value>The extended progress step.</value>
        [Description("Set the step value")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        /// <summary>
        /// Zeroits the extended progress bar.
        /// </summary>
        public void ZeroitExtendedProgressBar()
        {
            ExtendedProgress_InitializeComponent();
            
        }
        #endregion

        #region Caption
        //[Description("Change the font")]
        //[Category("Rectangular ZeroitExtendedProgress")]
        //[Browsable(false)]
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
        /// <summary>
        /// Gets or sets a value indicating whether [extended progress shadow].
        /// </summary>
        /// <value><c>true</c> if [extended progress shadow]; otherwise, <c>false</c>.</value>
        [Description("Enable/Disable shadow")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private int ShadowOffset = 1;
        /// <summary>
        /// Gets or sets the shadow offset.
        /// </summary>
        /// <value>The shadow offset.</value>
        [Description("Set shadow offset")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private bool TextAntialias = true;
        /// <summary>
        /// Gets or sets a value indicating whether [text antialias].
        /// </summary>
        /// <value><c>true</c> if [text antialias]; otherwise, <c>false</c>.</value>
        [Description("Enable/Disable antialiasing")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color CaptionShadowColor = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// Gets or sets the color of the caption shadow.
        /// </summary>
        /// <value>The color of the caption shadow.</value>
        [Description("Set the caption shadow color.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private Color CaptionColor = Color.FromKnownColor(KnownColor.Black);
        /// <summary>
        /// Gets or sets the color of the caption.
        /// </summary>
        /// <value>The color of the caption.</value>
        [Description("Set the caption color.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private ProgressCaptionMode CaptionMode = ProgressCaptionMode.Percent;
        /// <summary>
        /// Gets or sets the caption mode.
        /// </summary>
        /// <value>The caption mode.</value>
        [Description("Set the caption mode.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private String Caption = "Progress";
        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        [Description("Set the caption.")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        //private bool ChangeByMouse = false;
        /// <summary>
        /// Gets or sets a value indicating whether [change by mouse].
        /// </summary>
        /// <value><c>true</c> if [change by mouse]; otherwise, <c>false</c>.</value>
        [Description("Allows the user to change the value by clicking the mouse")]
        [Category("RectangularProgress ExtendedProgress")]
        [Browsable(false)]
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
        /// <summary>
        /// Gets the custom caption.
        /// </summary>
        /// <param name="caption">The caption.</param>
        /// <returns>String.</returns>
        private String GetCustomCaption(String caption)
        {
            float float_Percentage = ((float)(Value - ExtendedProgress_Minimum) / (float)(Maximum - ExtendedProgress_Minimum)) * 100.0f;

            String toReturn = caption.Replace("<VALUE>", Value.ToString());
            toReturn = caption.Replace("<PERCENTAGE>", float_Percentage.ToString());

            return toReturn;
        }
        #endregion

        #region User Methods
        /// <summary>
        /// Performs the step.
        /// </summary>
        public void PerformStep()
        {
            Value += ExtendedProgress_Step;
            if (Value < ExtendedProgress_Minimum) Value = ExtendedProgress_Minimum;
            if (Value > Maximum) Value = Maximum;
        }

        /// <summary>
        /// Increments the specified value.
        /// </summary>
        /// <param name="val">The value.</param>
        public void Increment(int val)
        {
            Value += val;
            if (Value < ExtendedProgress_Minimum) Value = ExtendedProgress_Minimum;
            if (Value > Maximum) Value = Maximum;
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Extendeds the paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void Extended_Paint(PaintEventArgs e)
        {
            

            //e.Graphics.SmoothingMode = Smoothing;
            //e.Graphics.TextRenderingHint = TextRendering;

            if (AllowTransparency)
            {
                MakeTransparent(this, e.Graphics);
            }

            #region OnPaint - Draw Background

            //timer.Interval = ExtendedProgress_TimerInterval;

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
            //if (TextAntialias) e.Graphics.TextRenderingHint = TextRendering;
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

        /// <summary>
        /// Extendeds the resize.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
        /// <summary>
        /// Handles the MouseDown event of the ProgressBar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void ProgressBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            /**/
        }

        /// <summary>
        /// Handles the MouseMove event of the ProgressBar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the MouseUp event of the ProgressBar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
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
        /// <summary>
        /// Initializes a new instance of the <see cref="Info"/> class.
        /// </summary>
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
