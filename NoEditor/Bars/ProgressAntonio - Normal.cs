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

using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region Control

    internal class ZeroitProgressNormalResourceFinder
    {

    }

    public partial class ThematicProgress
    {
        
        #region Enums

        public enum TextColorTypes
        {
            Specific,
            Automatic
        }

        public enum TextAlignmentTypes
        {
            Start,
            Center,
            End
        }

        public enum BorderTypes
        {
            None,
            Single
        }

        public enum RollingTypes
        { None, EdgeToEdge, Bouncing }

        public enum progressNormalType
        {
            Normal,
            Boxed,
            Gradient
        }


        #endregion

        #region Private Fields

        //private progressNormalType ProgressNormalType = progressNormalType.Normal;
        //private TextColorTypes TextColorType;
        //private TextAlignmentTypes TextAlign;
        //private bool DisplayProgress;
        //private int ProgressBarNormal_Step;
        //protected Color ColorProgress;
        //private BorderTypes BorderType;
        // Color ProgressBarNormal_BorderColor;

        BrushTable xBrushes = new BrushTable();
        PenTable xPens = new PenTable();
        private bool _TurnOffInvalidation;
        private float _iPercent = 0;
        private float _fPercent = 0;
        protected const string BrushProgress = "BrushProgress";
        protected const string BrushBackGround = "BrushBackGround";
        protected const string BrushText = "BrushText";
        protected const string ProgressBarNormal_penBorder = "ProgressBarNormal_penBorder";

        private ThematicProgress.progressNormalType _progressNormalType = ThematicProgress.progressNormalType.Normal;
        private int ProgressBarNormal_step = 5;
        private ThematicProgress.TextColorTypes _TextColorType = ThematicProgress.TextColorTypes.Automatic;
        private ThematicProgress.TextAlignmentTypes _TextAlign = ThematicProgress.TextAlignmentTypes.Center;
        private bool _DisplayProgress = false;
        private Color _ColorProgress = Color.Blue;
        private ThematicProgress.BorderTypes _BorderType = ThematicProgress.BorderTypes.None;
        private Color ProgressBarNormal_borderColor = Color.Black;
        private int _RollBlockPercent = 20;
        private ThematicProgress.RollingTypes _RollingType = ThematicProgress.RollingTypes.Bouncing;
        private int antonioInterval = 100;


        private int _GradientPercent = 20;
        private ThematicProgress.GradientTypes _GradientType = ThematicProgress.GradientTypes.FullWidthGradient;


        #endregion

        #region Constructor
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
            TextAlign = TextAlignmentTypes.Center;
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

        private void ProgressNormal_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
            {
                this.Value = 0;
            }

            else
            {
                this.Value++;
                ProgressBarNormal_Invalidate();
            }

        }

        #endregion
        
        #region Drawing
        
        private Rectangle[] ProgressBarNormal_Prepare2Parts()
        {
            return Zeroit.Framework.Functions.Drawing.MyRectangle.SplitByPercent(ClientRectangle, new int[] { (int)_iPercent, 100 - (int)_iPercent }, Zeroit.Framework.Functions.Drawing.MyRectangle.SplitType.Horizontal);
        }

        private Rectangle[] ProgressBarNormal_Prepare3Parts()
        {
            Rectangle xRec = ClientRectangle;
            int MiddleWidth = Functions.Math.MyMaths.Percent(xRec.Width, RollBlockPercent);
            xRec.Inflate(MiddleWidth, 0);
            int Left = Functions.Math.MyMaths.Percent(ClientRectangle.Width + MiddleWidth, (int)_iPercent);
            int Right = xRec.Width - -MiddleWidth - Left;
            return Functions.Drawing.MyRectangle.SplitByPixels(xRec, new int[] { Left, MiddleWidth, Right }, Zeroit.Framework.Functions.Drawing.MyRectangle.SplitType.Horizontal);
        }

        private void ProgressBarNormal_Paint(System.Windows.Forms.PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;
            g.Clear(BackColor);

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

        private void ProgressBarNormal_DrawBackgroundRolling(Graphics g)
        {
            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
            }
            Rectangle[] xRecs = ProgressBarNormal_Prepare3Parts();
            ProgressBarNormal_FillRectangle(g, xRecs[1], xBrushes[BrushProgress]);

        }

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

        private void ProgressBarNormal_DrawText(Graphics g)
        {
            if (!DisplayProgress || RollingType != RollingTypes.None)
                return;
            string sProgress = _iPercent.ToString() + PostFix;
            StringFormat xFormat = new StringFormat();
            xFormat.LineAlignment = StringAlignment.Center;
            xFormat.Alignment = StringAlignment.Center;
            Rectangle TextRect = ClientRectangle;
            Color TextColor = ForeColor;
            Rectangle[] xRecs = ProgressBarNormal_Prepare2Parts();
            switch (TextAlign)
            {
                case TextAlignmentTypes.Start:
                    TextRect = xRecs[0];
                    TextColor = Zeroit.Framework.Functions.Drawing.MyColor.GetBestContrast(ColorProgress);
                    break;
                case TextAlignmentTypes.Center:
                    if (_iPercent > 50)
                        TextColor = Zeroit.Framework.Functions.Drawing.MyColor.GetBestContrast(ColorProgress);
                    else
                        TextColor = Zeroit.Framework.Functions.Drawing.MyColor.GetBestContrast(BackColor);
                    TextRect = ClientRectangle;
                    break;
                case TextAlignmentTypes.End:
                    TextRect = xRecs[1];
                    TextColor = Zeroit.Framework.Functions.Drawing.MyColor.GetBestContrast(BackColor);
                    break;
            }
            if (TextColorType == TextColorTypes.Specific)
                TextColor = ForeColor;
            if (Functions.Drawing.MySize.Compare(g.MeasureString(sProgress, Font).ToSize(), TextRect.Size) == Functions.Drawing.MySize.CompareOutputTypes.Smaller)
                g.DrawString(sProgress, Font, new SolidBrush(TextColor), TextRect, xFormat);
        }

        private void ProgressBarNormal_DrawBorder(Graphics g)
        {
            switch (BorderType)
            {
                case BorderTypes.None:
                    break;
                case BorderTypes.Single:
                    g.DrawLines(xPens[ProgressBarNormal_penBorder], Zeroit.Framework.Functions.Drawing.MyRectangle.PathAround(ClientRectangle));
                    break;
            }
        }

        private void ProgressBarNormal_FillRectangle(Graphics g, Rectangle xRec, Brush xBrush)
        {
            if (xRec.Width == 0)
                return;
            if (xBrush == null)
                return;
            g.FillRectangle(xBrush, xRec);
        }

        private void ProgressBarNormal_Dispose(bool disposing)
        {
            if (disposing)
            {
                xBrushes.DisposeAll();
                xPens.DisposeAll();
            }
            //base.Dispose(disposing);
        }

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


        [Description("Middle Percentage of Control"),
         Category("RectangularProgress Antonio-Normal")]
        public int RollBlockPercent
        {
            get
            {
                return _RollBlockPercent;
            }
            set
            {
                if (value < 10 || value > 90)
                    throw new ArgumentOutOfRangeException("RollBlockPercent", "Must be between 10 and 90");
                _RollBlockPercent = value;
                ProgressBarNormal_Invalidate();
            }
        }

        //private RollingTypes RollingType;

        [Description("Rolling Type"),
         Category("RectangularProgress Antonio-Normal")]
        public RollingTypes RollingType
        {
            get
            {
                return _RollingType;
            }
            set
            {
                _RollingType = value;
                if (value == RollingTypes.None)
                {
                    RollStop();
                    ProgressBarNormal_Step = Math.Abs(ProgressBarNormal_Step);
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

        [Description("Rolling Interval"),
         Category("RectangularProgress Antonio-Normal")]
        public int RollTimer
        {
            get
            {
                return antonioInterval;
            }
            set
            {
                antonioInterval = value;
                _RollTimer.Interval = antonioInterval;
            }
        }


        [Description("Display the Type of Progress"),
        Category("RectangularProgress Antonio-Normal")]
        public progressNormalType ProgressNormalType
        {
            get { return _progressNormalType; }
            set
            {
                _progressNormalType = value;
                ProgressBarNormal_Invalidate();
            }
        }
        
        [Description("Sets the step"), 
            Category("RectangularProgress Antonio-Normal")]
        public int ProgressBarNormal_Step
        {
            get
            {
                return ProgressBarNormal_step;
            }
            set
            {
                ProgressBarNormal_step = value;
                ProgressBarNormal_Invalidate();
            }
        }

        [Description("Fill Color Start"), 
            Category("RectangularProgress Antonio-Normal")]
        public Color ColorProgress
        {
            get
            {
                return _ColorProgress;
            }
            set
            {
                _ColorProgress = value;
                xBrushes[BrushProgress] = new SolidBrush(_ColorProgress);
                ProgressBarNormal_Invalidate();
            }
        }

        [Description("Display Progress Percentage"),
         Category("RectangularProgress Antonio-Normal")]
        public bool DisplayProgress
        {
            get
            {
                return _DisplayProgress;
            }
            set
            {
                _DisplayProgress = value;
                ProgressBarNormal_Invalidate();
            }
        }
        
        [Description("Percent Text Color Type"), 
            Category("RectangularProgress Antonio-Normal")]
        public TextColorTypes TextColorType
        {
            get
            {
                return _TextColorType;
            }
            set
            {
                _TextColorType = value;
                ProgressBarNormal_Invalidate();
            }
        }
        

        [Description("Percent Text Align"), 
            Category("RectangularProgress Antonio-Normal")]
        public TextAlignmentTypes TextAlign
        {
            get
            {
                return _TextAlign;
            }
            set
            {
                _TextAlign = value;
                ProgressBarNormal_Invalidate();
            }
        }

        
        [Description("Border Type"), 
            Category("RectangularProgress Antonio-Normal")]
        public BorderTypes BorderType
        {
            get
            {
                return _BorderType;
            }
            set
            {
                _BorderType = value;
                ProgressBarNormal_Invalidate();
            }
        }
        

        [Description("Border Color"), 
            Category("RectangularProgress Antonio-Normal")]
        public Color ProgressBarNormal_BorderColor
        {
            get
            {
                return ProgressBarNormal_borderColor;
            }
            set
            {
                xPens[ProgressBarNormal_penBorder] = new Pen(value, 1);
                ProgressBarNormal_borderColor = value;
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

        private System.Windows.Forms.Timer _RollTimer = new System.Windows.Forms.Timer();

        

        public void RollStart()
        {
            _RollTimer.Start();
        }

        public void RollStop()
        {
            _RollTimer.Stop();
        }

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
