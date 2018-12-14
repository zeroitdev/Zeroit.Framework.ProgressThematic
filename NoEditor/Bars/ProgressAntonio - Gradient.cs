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
    #region ProgressBarGradient

    public partial class ThematicProgress
    {
        
        #region Constructor
        public void ZeroitProgressBarNormalGradient()
        {
            GradientPercent = 100;
            GradientType = GradientTypes.FullWidthGradient;
        } 
        #endregion

        #region Private Methods and Paint Events

        private new Rectangle[] Prepare3Parts()
        {
            Rectangle xRec = ClientRectangle;
            int MiddleWidth = Functions.Math.MyMaths.Percent(xRec.Width, GradientPercent);
            xRec.Inflate(MiddleWidth, 0);
            int Left = Functions.Math.MyMaths.Percent(ClientRectangle.Width + MiddleWidth, (int)_iPercent);
            int Right = xRec.Width - MiddleWidth - Left;
            return Functions.Drawing.MyRectangle.SplitByPixels(xRec, new int[] { Left, MiddleWidth, Right }, Zeroit.Framework.Functions.Drawing.MyRectangle.SplitType.Horizontal);
        }
        private Rectangle[] Prepare4Parts()
        {
            Rectangle[] xRecs = Prepare3Parts();
            Rectangle[] xMiddleparts = Functions.Drawing.MyRectangle.SplitByPercent(xRecs[1], new int[] { 50, 50 }, Zeroit.Framework.Functions.Drawing.MyRectangle.SplitType.Horizontal);
            return new Rectangle[] { xRecs[0], xMiddleparts[0], xMiddleparts[1], xRecs[2] };
        }

        private void ProgressBarGradient_DrawBackgroundRolling(Graphics g)
        {
            if (_iPercent == 0)
            {
               ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                //return;
            }
            Rectangle[] xRecs = Prepare4Parts();
            xRecs[1].Width++;
            BrushAndFill(g, xRecs[2], ColorProgress, BackColor);
            BrushAndFill(g, xRecs[1], BackColor, ColorProgress);

        }

        private void ProgressBarGradient_DrawBackground(Graphics g)
        {
            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                //return;
            }
            Rectangle[] xRecs = null;
            xRecs = Prepare3Parts();
            Rectangle xRectLeft = xRecs[0];
            Rectangle xRectMiddle = xRecs[1];
            Rectangle xRectRight = xRecs[2];
            xRectLeft.Width++;
            BrushAndFill(g, xRectMiddle, ColorProgress, BackColor);
            ProgressBarNormal_FillRectangle(g, xRectLeft, xBrushes[BrushProgress]);
            ProgressBarNormal_FillRectangle(g, xRectRight, xBrushes[BrushBackGround]);

        }

        private void BrushAndFill(Graphics g, Rectangle xRec, Color xColor1, Color xColor2)
        {
            if (xRec.Width == 0)
                return;
            Brush xBrush = new LinearGradientBrush(xRec, xColor1, xColor2, 0f);
            g.FillRectangle(xBrush, xRec);
            xBrush.Dispose();
        }

        private void ProgressBarGradient_Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = Smoothing;
            g.TextRenderingHint = TextRendering;

            g.Clear(BackColor);

            if (RollingType == RollingTypes.None)
                ProgressBarGradient_DrawBackground(g);
            else
                ProgressBarGradient_DrawBackgroundRolling(g);
            if (RollingType == RollingTypes.None)
                ProgressBarNormal_DrawText(g);

            ProgressBarNormal_DrawBorder(g);
        }



        #endregion

        #region Enums
        public enum GradientTypes
        {
            SpecificWidthGradient,
            FullWidthGradient
        }
        #endregion

        #region Private Fields

        private int gradientPercent = 20;
        private GradientTypes gradientType = GradientTypes.FullWidthGradient;

        #endregion

        #region Public  Properties
        //        protected const string BrushGradient = "BrushGradient";
        //        protected const string BrushGradientReversed = "BrushGradientReversed";


        [Description("Gradient Percentage of Control"), 
            Category("RectangularProgress Antonio-Gradient")]
        public int GradientPercent
        {
            get
            {
                return gradientPercent;
            }
            set
            {
                if (value < 1 || value > 100)
                    throw new ArgumentOutOfRangeException("GradientPercent", "Must be between 1 and 100");
                if (GradientType == GradientTypes.FullWidthGradient)
                    return;
                gradientPercent = value;
                Invalidate();
            }
        }

        
        [Description("Gradient Type"), 
            Category("RectangularProgress Antonio-Gradient")]
        public GradientTypes GradientType
        {
            get
            {
                return gradientType;
            }
            set
            {
                if (value == GradientTypes.SpecificWidthGradient)
                    GradientPercent = 50;
                if (value == GradientTypes.FullWidthGradient)
                    GradientPercent = 100;
                gradientType = value;
                Invalidate();
            }
        }


        #endregion
        
        
    }

    #endregion
}
