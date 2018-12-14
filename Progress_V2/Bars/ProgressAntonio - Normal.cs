// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio - Normal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.ComponentModel;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region Control

    /// <summary>
    /// Class ZeroitProgressNormalResourceFinder.
    /// </summary>
    internal class ZeroitProgressNormalResourceFinder
    {

    }

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region Enums

        /// <summary>
        /// Enum TextColorTypes
        /// </summary>
        public enum TextColorTypes
        {
            /// <summary>
            /// The specific
            /// </summary>
            Specific,
            /// <summary>
            /// The automatic
            /// </summary>
            Automatic
        }

        /// <summary>
        /// Enum TextAlignmentTypes
        /// </summary>
        public enum TextAlignmentTypes
        {
            /// <summary>
            /// The start
            /// </summary>
            Start,
            /// <summary>
            /// The center
            /// </summary>
            Center,
            /// <summary>
            /// The end
            /// </summary>
            End
        }

        /// <summary>
        /// Enum BorderTypes
        /// </summary>
        public enum BorderTypes
        {
            /// <summary>
            /// The none
            /// </summary>
            None,
            /// <summary>
            /// The single
            /// </summary>
            Single
        }

        /// <summary>
        /// Enum RollingTypes
        /// </summary>
        public enum RollingTypes
        /// <summary>
        /// The none
        /// </summary>
        /// <summary>
        /// The edge to edge
        /// </summary>
        /// <summary>
        /// The bouncing
        /// </summary>
        { None, EdgeToEdge, Bouncing }

        /// <summary>
        /// Enum progressNormalType
        /// </summary>
        public enum progressNormalType
        {
            /// <summary>
            /// The normal
            /// </summary>
            Normal,
            /// <summary>
            /// The boxed
            /// </summary>
            Boxed,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient
        }


        #endregion

        #region Private Fields

        //private progressNormalType ProgressNormalType = progressNormalType.Normal;
        /// <summary>
        /// The x brushes
        /// </summary>
        BrushTable xBrushes = new BrushTable();
        /// <summary>
        /// The x pens
        /// </summary>
        PenTable xPens = new PenTable();
        //private int ProgressBarNormal_Step;
        /// <summary>
        /// The turn off invalidation
        /// </summary>
        private bool _TurnOffInvalidation;
        /// <summary>
        /// The i percent
        /// </summary>
        private float _iPercent = 0;
        /// <summary>
        /// The f percent
        /// </summary>
        private float _fPercent = 0;
        //private TextColorTypes TextColorType;
        //private TextAlignmentTypes TextAlignType;
        //private bool DisplayProgress;
        /// <summary>
        /// The brush progress
        /// </summary>
        protected const string BrushProgress = "BrushProgress";
        /// <summary>
        /// The brush back ground
        /// </summary>
        protected const string BrushBackGround = "BrushBackGround";
        /// <summary>
        /// The brush text
        /// </summary>
        protected const string BrushText = "BrushText";
        /// <summary>
        /// The progress bar normal pen border
        /// </summary>
        protected const string ProgressBarNormal_penBorder = "ProgressBarNormal_penBorder";
        //protected Color ColorProgress;
        //private BorderTypes BorderType;
        // Color ProgressBarNormal_BorderColor;

        #endregion

        #region Constructor
        /// <summary>
        /// Zeroits the progress bar normal.
        /// </summary>
        public void ZeroitProgressBarNormal()
        {

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);


            //BackColor = Color.Transparent;

            //Minimum = 0;
            //Maximum = 100;
            ProgressBarNormal_Step = 5;
            _TurnOffInvalidation = false;
            DisplayProgress = false;
            BorderType = BorderTypes.Single;
            TextAlignType = TextAlignmentTypes.Center;
            TextColorType = TextColorTypes.Automatic;
            RollBlockPercent = 20;
            RollingType = RollingTypes.None;


            _TurnOffInvalidation = true;
            ColorProgress = Color.Blue;
            _TurnOffInvalidation = true;
            ProgressBarNormal_BorderColor = Color.Black;
            _TurnOffInvalidation = true;
            //BackColor = Color.White;
            _TurnOffInvalidation = true;
            //ForeColor = Color.White;
            //Value = 50;
            Size = new Size(100, 20);
            RollTimer = 200;

            _iPercent = Value/Maximum * 100;

        }

        #endregion

        #region Timer Event

        /// <summary>
        /// Handles the Tick event of the ProgressNormal_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressNormal_Timer_Tick(object sender, EventArgs e)
        {
            #region Old Code
            //if (this.Value + 1 > this.Maximum)
            //{
            //    this.Value = 0;
            //}

            //else
            //{
            //    this.Value++;
            //    ProgressBarNormal_Invalidate();
            //} 
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
                    ProgressBarNormal_Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    ProgressBarNormal_Invalidate();
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
                    ProgressBarNormal_Invalidate();
                }

                else
                {
                    this.Value += (Change * SpeedMultiplier);
                    ProgressBarNormal_Invalidate();
                }
            }
        }

        /// <summary>
        /// Handles the Tick event of the ProgressNormal_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressNormal_Timer_Reduced_Tick(object sender, EventArgs e)
        {

            if (this.Value < this.Minimum)
            {
                timerDecrement.Stop();
                timerDecrement.Enabled = false;
                timer.Enabled = true;
                timer.Start();
                //timer.Tick += Timer_Tick;
                ProgressBarNormal_Invalidate();
            }

            else
            {
                this.Value -= (Change * SpeedMultiplier);
                ProgressBarNormal_Invalidate();
            }
            

        }

        #endregion

        #region Drawing

        /// <summary>
        /// Progresses the bar normal prepare2 parts.
        /// </summary>
        /// <returns>Rectangle[].</returns>
        private Rectangle[] ProgressBarNormal_Prepare2Parts()
        {
            return Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitByPercent(ClientRectangle, new int[] { (int)_iPercent, 100 - (int)_iPercent }, Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitType.Horizontal);
        }

        /// <summary>
        /// Progresses the bar normal prepare3 parts.
        /// </summary>
        /// <returns>Rectangle[].</returns>
        private Rectangle[] ProgressBarNormal_Prepare3Parts()
        {
            Rectangle xRec = ClientRectangle;
            int MiddleWidth = MathHelpers.MyMaths.Percent(xRec.Width, RollBlockPercent);
            xRec.Inflate(MiddleWidth, 0);
            int Left = MathHelpers.MyMaths.Percent(ClientRectangle.Width + MiddleWidth, (int)_iPercent);
            int Right = xRec.Width - -MiddleWidth - Left;
            return ProgressThematic.Drawing.MyRectangle.SplitByPixels(xRec, new int[] { Left, MiddleWidth, Right }, Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitType.Horizontal);
        }

        /// <summary>
        /// Progresses the bar normal paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void ProgressBarNormal_Paint(System.Windows.Forms.PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;
            //g.Clear(BackColor);

            if (allowTransparency)
            {
                MakeTransparent(this, g);
            }

            _iPercent = ((Value) / Maximum) * (100f);

            switch (ProgressNormalType)
            {
                case progressNormalType.Normal:
                    if (RollingType == RollingTypes.None)
                        ProgressBarNormal_DrawBackground(g);
                    else
                        ProgressBarNormal_DrawBackgroundRolling(g);
                    break;
                case progressNormalType.Boxed:
                    if (RollingType == RollingTypes.None)
                        ProgressBarBoxed_DrawBackground(g);
                    else
                        ProgressBarNormal_DrawBackgroundRolling(g);
                    break;
                case progressNormalType.Gradient:
                    if (RollingType == RollingTypes.None)
                        ProgressBarGradient_DrawBackground(g);
                    else
                        ProgressBarGradient_DrawBackgroundRolling(g);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


            if (RollingType == RollingTypes.None)
            {
                if (ShowText)
                    ProgressBarNormal_DrawText(g);
            }

            //if (ShowText)
            //{
            //    DisplayProgress = true;
            //    ProgressBarNormal_DrawText(g);
            //}



            ProgressBarNormal_DrawBorder(g);

            //g.Dispose();

        }

        /// <summary>
        /// Progresses the bar normal draw background rolling.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarNormal_DrawBackgroundRolling(Graphics g)
        {
            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
            }
            Rectangle[] xRecs = ProgressBarNormal_Prepare3Parts();
            ProgressBarNormal_FillRectangle(g, xRecs[1], xBrushes[BrushProgress]);

        }

        /// <summary>
        /// Progresses the bar normal draw background.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarNormal_DrawBackground(Graphics g)
        {
            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                //return;
            }
            Rectangle[] xRecs = null;
            xRecs = ProgressBarNormal_Prepare2Parts();
            Rectangle xRectLeft = xRecs[0];
            Rectangle xRectRight = xRecs[1];
            ProgressBarNormal_FillRectangle(g, xRectLeft, xBrushes[BrushProgress]);
            //BrushAndFill(g, xRectLeft, ColorProgress);
        }

        /// <summary>
        /// Progresses the bar normal draw text.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarNormal_DrawText(Graphics g)
        {
            if (!ShowText || RollingType != RollingTypes.None)
                return;
            string sProgress = Convert.ToInt32(_iPercent).ToString() + PostFix;
            StringFormat xFormat = new StringFormat();
            xFormat.LineAlignment = StringAlignment.Center;
            xFormat.Alignment = StringAlignment.Center;
            Rectangle TextRect = ClientRectangle;
            Color TextColor = ForeColor;
            Rectangle[] xRecs = ProgressBarNormal_Prepare2Parts();
            switch (TextAlignType)
            {
                case TextAlignmentTypes.Start:
                    TextRect = xRecs[0];
                    TextColor = Zeroit.Framework.ProgressThematic.Drawing.MyColor.GetBestContrast(ColorProgress);
                    break;
                case TextAlignmentTypes.Center:
                    if (_iPercent > 50)
                        TextColor = Zeroit.Framework.ProgressThematic.Drawing.MyColor.GetBestContrast(ColorProgress);
                    else
                        TextColor = Zeroit.Framework.ProgressThematic.Drawing.MyColor.GetBestContrast(BackColor);
                    TextRect = ClientRectangle;
                    break;
                case TextAlignmentTypes.End:
                    TextRect = xRecs[1];
                    TextColor = Zeroit.Framework.ProgressThematic.Drawing.MyColor.GetBestContrast(BackColor);
                    break;
            }
            if (TextColorType == TextColorTypes.Specific)
                TextColor = ForeColor;
            if (ProgressThematic.Drawing.MySize.Compare(g.MeasureString(sProgress, Font).ToSize(), TextRect.Size) == ProgressThematic.Drawing.MySize.CompareOutputTypes.Smaller)
                g.DrawString(sProgress, Font, new SolidBrush(TextColor), TextRect, xFormat);
        }

        /// <summary>
        /// Progresses the bar normal draw border.
        /// </summary>
        /// <param name="g">The g.</param>
        private void ProgressBarNormal_DrawBorder(Graphics g)
        {
            switch (BorderType)
            {
                case BorderTypes.None:
                    break;
                case BorderTypes.Single:
                    g.DrawLines(xPens[ProgressBarNormal_penBorder], Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.PathAround(ClientRectangle));
                    break;
            }
        }

        /// <summary>
        /// Progresses the bar normal fill rectangle.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="xRec">The x record.</param>
        /// <param name="xBrush">The x brush.</param>
        private void ProgressBarNormal_FillRectangle(Graphics g, Rectangle xRec, Brush xBrush)
        {
            if (xRec.Width == 0)
                return;
            if (xBrush == null)
                return;
            g.FillRectangle(xBrush, xRec);
        }

        /// <summary>
        /// Progresses the bar normal dispose.
        /// </summary>
        /// <param name="disposing">if set to <c>true</c> [disposing].</param>
        private void ProgressBarNormal_Dispose(bool disposing)
        {
            if (disposing)
            {
                xBrushes.DisposeAll();
                xPens.DisposeAll();
            }
            //base.Dispose(disposing);
        }

        /// <summary>
        /// Progresses the bar normal invalidate.
        /// </summary>
        private void ProgressBarNormal_Invalidate()
        {
            if (!_TurnOffInvalidation)
                base.Invalidate();
            _TurnOffInvalidation = false;
        }


        /// <summary>
        /// Performs Value Calculation based on Minimum,Maximum and ProgressBarNormal_Step
        /// </summary>
        private void ProgressBarNormal_PerformStep()
        {
            if (Value + ProgressBarNormal_Step <= Maximum && Value + ProgressBarNormal_Step >= Minimum)
            {
                Value += ProgressBarNormal_Step;
                return;
            }
            if (RollingType == RollingTypes.None)
                return;
            if (RollingType == RollingTypes.Bouncing)
            {
                ProgressBarNormal_Step = -ProgressBarNormal_Step;
                ProgressBarNormal_PerformStep();
                return;
            }
            if (RollingType == RollingTypes.EdgeToEdge)
            {
                if (Value + ProgressBarNormal_Step > Maximum)
                    Value += ProgressBarNormal_Step - (Maximum - Minimum);
            }
        }


        #endregion

        #region Properties


        /// <summary>
        /// Gets or sets the roll block percent.
        /// </summary>
        /// <value>The roll block percent.</value>
        /// <exception cref="ArgumentOutOfRangeException">RollBlockPercent - Must be between 10 and 90</exception>
        [Description("Middle Percentage of Control"),
         Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public int RollBlockPercent
        {
            get
            {
                return progressInput.RollBlockPercent;
            }
            set
            {
                if (value < 10 || value > 90)
                    throw new ArgumentOutOfRangeException("RollBlockPercent", "Must be between 10 and 90");
                progressInput.RollBlockPercent = value;
                ProgressBarNormal_Invalidate();
            }
        }

        //private RollingTypes RollingType;

        /// <summary>
        /// Gets or sets the type of the rolling.
        /// </summary>
        /// <value>The type of the rolling.</value>
        [Description("Rolling Type"),
         Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public RollingTypes RollingType
        {
            get
            {
                return progressInput.RollingType;
            }
            set
            {
                progressInput.RollingType = value;
                if (value == RollingTypes.None)
                {
                    RollStop();
                    progressInput.ProgressBarNormal_Step = Math.Abs(ProgressBarNormal_Step);
                }
                else
                {
                    //throw new ArgumentException("Not Supported");
                    Minimum = 0;
                    Maximum = 100;
                    Value = 0;
                    //_RollImage.
                }
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the roll timer.
        /// </summary>
        /// <value>The roll timer.</value>
        [Description("Rolling Interval"),
         Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public int RollTimer
        {
            get
            {
                return progressInput.RollTimer;
            }
            set
            {
                progressInput.RollTimer = value;
                _RollTimer.Interval = progressInput.RollTimer;
            }
        }


        /// <summary>
        /// Gets or sets the type of the progress normal.
        /// </summary>
        /// <value>The type of the progress normal.</value>
        [Description("Display the Type of Progress"),
        Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public progressNormalType ProgressNormalType
        {
            get { return progressInput.ProgressNormalType; }
            set
            {
                progressInput.ProgressNormalType = value;
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress bar normal step.
        /// </summary>
        /// <value>The progress bar normal step.</value>
        [Description("Sets the step"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public int ProgressBarNormal_Step
        {
            get
            {
                return progressInput.ProgressBarNormal_Step;
            }
            set
            {
                progressInput.ProgressBarNormal_Step = value;
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color progress.
        /// </summary>
        /// <value>The color progress.</value>
        [Description("Fill Color Start"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public Color ColorProgress
        {
            get
            {
                return progressInput.ColorProgress;
            }
            set
            {
                progressInput.ColorProgress = value;
                xBrushes[BrushProgress] = new SolidBrush(progressInput.ColorProgress);
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [display progress].
        /// </summary>
        /// <value><c>true</c> if [display progress]; otherwise, <c>false</c>.</value>
        [Description("Display Progress Percentage"),
         Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public bool DisplayProgress
        {
            get
            {
                return progressInput.DisplayProgress;
            }
            set
            {
                progressInput.DisplayProgress = value;
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the type of the text color.
        /// </summary>
        /// <value>The type of the text color.</value>
        [Description("Percent Text Color Type"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public TextColorTypes TextColorType
        {
            get
            {
                return progressInput.TextColorType;
            }
            set
            {
                progressInput.TextColorType = value;
                ProgressBarNormal_Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the type of the text align.
        /// </summary>
        /// <value>The type of the text align.</value>
        [Description("Percent Text Align"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public TextAlignmentTypes TextAlignType
        {
            get
            {
                return progressInput.TextAlign;
            }
            set
            {
                progressInput.TextAlign = value;
                ProgressBarNormal_Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the type of the border.
        /// </summary>
        /// <value>The type of the border.</value>
        [Description("Border Type"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public BorderTypes BorderType
        {
            get
            {
                return progressInput.BorderType;
            }
            set
            {
                progressInput.BorderType = value;
                ProgressBarNormal_Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the color of the progress bar normal border.
        /// </summary>
        /// <value>The color of the progress bar normal border.</value>
        [Description("Border Color"), 
            Category("RectangularProgress Antonio-Normal")]
        [Browsable(false)]
        public Color ProgressBarNormal_BorderColor
        {
            get
            {
                return progressInput.ProgressBarNormal_BorderColor;
            }
            set
            {
                xPens[ProgressBarNormal_penBorder] = new Pen(value, 1);
                progressInput.ProgressBarNormal_BorderColor = value;
                ProgressBarNormal_Invalidate();
            }
        }


        #endregion

        #region Rolling
        /*
        private Bitmap[] _RollImage = new Bitmap[100];
        private void PrepareRollImages()
        {
            int OriginalPercent=_iPercent;
            for(int i=0;i<100;i++)
            {
                if (_RollImage[i] == null)
                    _RollImage = new Bitmap(10, 10);
                Graphics g=Graphics.FromImage(_RollImage[i]);
                BrushAndFill(g, _RollImage[i].GetBounds(GraphicsUnit.Pixel));
                _iPercent=i;
                Rectangle[] xRecs = Prepare4Parts();
                if (_ProgressBarType == ProgressBarTypes.Simple)
                {
                    BrushAndFill(g, xRecs[1], _ColorStart);
                    BrushAndFill(g, xRecs[2], _ColorStart);
                }
                if (_ProgressBarType == ProgressBarTypes.SpecificWidthGradient || _ProgressBarType == ProgressBarTypes.FullWidthGradient)
                {
                    xRecs[1].Width++;
                    BrushAndFill(g, xRecs[2], _ColorStart, _ColorEnd);
                    BrushAndFill(g, xRecs[1], _ColorEnd, _ColorStart);
                }
                g.Dispose();
            }
        }
        */

        //private int RollBlockPercent;

        /// <summary>
        /// The roll timer
        /// </summary>
        private System.Windows.Forms.Timer _RollTimer = new System.Windows.Forms.Timer();



        /// <summary>
        /// Rolls the start.
        /// </summary>
        public void RollStart()
        {
            _RollTimer.Start();
        }

        /// <summary>
        /// Rolls the stop.
        /// </summary>
        public void RollStop()
        {
            _RollTimer.Stop();
        }

        /// <summary>
        /// Handles the Tick event of the _RollTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void _RollTimer_Tick(object sender, EventArgs e)
        {
            if (Value >= Maximum)
                if (RollingType == RollingTypes.EdgeToEdge)
                    Value = Minimum;
                else
                    ProgressBarNormal_Step = -ProgressBarNormal_Step;
            ProgressBarNormal_PerformStep();
        }
        
        
        #endregion
    }


    
    
    
    #endregion
    
}
