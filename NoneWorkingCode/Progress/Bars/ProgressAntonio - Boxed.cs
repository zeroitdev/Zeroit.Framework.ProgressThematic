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

namespace Zeroit.Framework.ProgressThematic
{

    #region ProgressBarBoxed

    public partial class ThematicProgress
    {

        private Color ProgressBarBoxed_activeColor = Color.Red;
        protected const string BrushActiveBlock = "BrushActiveBlock";

        private ProgressBarBoxed_InnerGridTypes ProgressBarBoxed_InnerGridType = ProgressBarBoxed_InnerGridTypes.Full;

        private Color ProgressBarBoxed_activeBlockColor = Color.Red;

        private int ProgressBarBoxed_numberOfBlocks = 5;

        private Rectangle[] ProgressBarBoxed_blockRects = null;

        public enum ProgressBarBoxed_InnerGridTypes { None, UntilActive, Full }


        public void ZeroitProgressBarBoxed()
        {

            
            //ProgressBarBoxed_InnerGridType = ProgressBarBoxed_InnerGridTypes.Full;

            //ProgressBarBoxed_ActiveBlockColor = ProgressBarBoxed_activeColor;

            //ProgressBarBoxed_NumberOfBlocks = 5;
        }


        #region Drawing
        private int ProgressBarBoxed_MaxBlockToDraw = -1;
        private void ProgressBarBoxed_DrawBackground(Graphics g)
        {

            //ProgressBarNormal_DrawBackground(g);

            if (_iPercent == 0)
            {
                ProgressBarNormal_FillRectangle(g, ClientRectangle, xBrushes[BrushBackGround]);
                
            }


            for (int i = 0; i < ProgressBarBoxed_MaxBlockToDraw; i++)
            {
                ProgressBarNormal_FillRectangle(g, ProgressBarBoxed_blockRects[i], xBrushes[BrushProgress]);
            }
            if (ProgressBarBoxed_MaxBlockToDraw < ProgressBarBoxed_numberOfBlocks && ProgressBarBoxed_MaxBlockToDraw > -1)
                ProgressBarNormal_FillRectangle(g, ProgressBarBoxed_blockRects[ProgressBarBoxed_MaxBlockToDraw], xBrushes[BrushActiveBlock]);
            
            ProgressBarBoxed_DrawInnerGrid(g);
        }

        private void ProgressBarBoxed_DrawInnerGrid(Graphics g)
        {
            if (ProgressBarBoxed_InnerGridType == ProgressBarBoxed_InnerGridTypes.None)
                return;
            int MaxGrid = 0;
            if (ProgressBarBoxed_InnerGridType == ProgressBarBoxed_InnerGridTypes.UntilActive)
                MaxGrid = ProgressBarBoxed_MaxBlockToDraw + 1;
            if (ProgressBarBoxed_InnerGridType == ProgressBarBoxed_InnerGridTypes.Full)
                MaxGrid = ProgressBarBoxed_numberOfBlocks;
            if (MaxGrid > ProgressBarBoxed_numberOfBlocks)
                MaxGrid = ProgressBarBoxed_numberOfBlocks;
            for (int i = 0; i < MaxGrid; i++)
            {
                Point[] PathAround = Zeroit.Framework.Functions.Drawing.MyRectangle.PathAround(ProgressBarBoxed_blockRects[i]);
                g.DrawLine(xPens[ProgressBarNormal_penBorder], PathAround[1], PathAround[2]);
            }

        }


        #endregion

        #region Overrides
        //[Description("Value Value"), Category("Progress")]
        //public override int Value
        //{
        //    get
        //    {
        //        return base.Value;
        //    }
        //    set
        //    {
        //        int Temp = ProgressBarBoxed_MaxBlockToDraw;
        //        _TurnOffInvalidation = true;
        //        base.Value = value;
        //        ProgressBarBoxed_ComputeMaxBlockToDraw();
        //        if (ProgressBarBoxed_MaxBlockToDraw == Temp)
        //            _TurnOffInvalidation = true;
        //        ProgressBarNormal_Invalidate();
        //    }
        //}
        #endregion

        #region Public Properties


        [DefaultValue(typeof(Color), "Red"),
         Category("RectangularProgress Antonio-Boxed")]
        public Color ProgressBarBoxed_ActiveBackColor
        {
            get { return ProgressBarBoxed_activeColor; }
            set
            {
                ProgressBarBoxed_activeColor = value;
                ProgressBarNormal_Invalidate();
            }


        }

        [Description("Inner Grid Type"),
            Category("RectangularProgress Antonio-Boxed")]
        public ProgressBarBoxed_InnerGridTypes InnerGridType
        {
            get { return ProgressBarBoxed_InnerGridType; }
            set
            {
                ProgressBarBoxed_InnerGridType = value;
                ProgressBarNormal_Invalidate();
            }
        }

        [Description("Active Block Color"),
            Category("RectangularProgress Antonio-Boxed")]
        public Color ProgressBarBoxed_ActiveBlockColor
        {
            get
            {
                return ProgressBarBoxed_activeBlockColor;
            }
            set
            {
                xBrushes[BrushActiveBlock] = new SolidBrush(value);
                ProgressBarBoxed_activeBlockColor = value;
                ProgressBarNormal_Invalidate();
            }
        }


        [Description("Number of Blocks"),
            Category("RectangularProgress Antonio-Boxed")]
        public int ProgressBarBoxed_NumberOfBlocks
        {
            get
            {
                return ProgressBarBoxed_numberOfBlocks;
            }
            set
            {
                if (value < 2)
                    throw new ArgumentOutOfRangeException("ProgressBarBoxed_NumberOfBlocks", "Value must greater than 1");
                ProgressBarBoxed_numberOfBlocks = value;
                ProgressBarBoxed_ComputeMaxBlockToDraw();
                ProgressBarBoxed_PrepareBlocks();
                ProgressBarNormal_Invalidate();
            }
        }


        #endregion

        #region Blocks
        private void ProgressBarBoxed_ComputeMaxBlockToDraw()
        {
            if (_iPercent > 0)
                ProgressBarBoxed_MaxBlockToDraw = (int)Math.Floor(_fPercent / 100 * ProgressBarBoxed_numberOfBlocks);
            else
                ProgressBarBoxed_MaxBlockToDraw = -1;
            //if (ProgressBarBoxed_MaxBlockToDraw > ProgressBarBoxed_numberOfBlocks-1)
            //    ProgressBarBoxed_MaxBlockToDraw = ProgressBarBoxed_numberOfBlocks-1;
        }

        

        private void ProgressBarBoxed_PrepareBlocks()
        {
            ProgressBarBoxed_blockRects = Zeroit.Framework.Functions.Drawing.MyRectangle.SplitInParts(ClientRectangle, ProgressBarBoxed_numberOfBlocks, Zeroit.Framework.Functions.Drawing.MyRectangle.SplitType.Horizontal);
        }

        private Rectangle[] ProgressBarBoxed_GetBlocks()
        {
            return ProgressBarBoxed_blockRects;
        }

        private void ProgressBarNormal_OnSizeChanged(EventArgs e)
        {
            ProgressBarBoxed_PrepareBlocks();
            //base.OnSizeChanged(e);
        }
        
        #endregion

        #region Hidding Properties
        //[Browsable(false)]
        //public override Color ForeColor
        //{
        //    get
        //    {
        //        return base.ForeColor;
        //    }
        //}
        //[Browsable(false)]
        //public override TextAlignmentTypes TextAlign
        //{
        //    get
        //    {
        //        return base.TextAlign;
        //    }
        //}

        //[Browsable(false)]
        //public override TextColorTypes TextColorType
        //{
        //    get
        //    {
        //        return base.TextColorType;
        //    }
        //}

        //[Browsable(false)]
        //public override bool DisplayProgress
        //{
        //    get
        //    {
        //        return base.DisplayProgress;
        //    }
        //}

        //[Browsable(false)]
        //public override int RollBlockPercent
        //{
        //    get
        //    {
        //        return base.RollBlockPercent;
        //    }
        //}
        //[Browsable(false)]
        //public override RollingTypes RollingType
        //{
        //    get
        //    {
        //        return base.RollingType;
        //    }
        //}
        //[Browsable(false)]
        //public override int RollTimer
        //{
        //    get
        //    {
        //        return base.RollTimer;
        //    }
        //}

        #endregion
            
        private void ProgressBarBoxed_Paint(PaintEventArgs e)
        {
            ProgressBarNormal_Paint(e);
            Graphics g = e.Graphics;
            //g.Clear(BackColor);


            if (RollingType == RollingTypes.None)
                ProgressBarBoxed_DrawBackground(g);
            else
                ProgressBarNormal_DrawBackgroundRolling(g);
            
            if (RollingType == RollingTypes.None)
                ProgressBarNormal_DrawText(g);

            ProgressBarNormal_DrawBorder(g);

            //g.Dispose();
        }


    }

    #endregion

}
