// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio - Boxed.cs" company="Zeroit Dev Technologies">
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

    #region ProgressBarBoxed

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        /// <summary>
        /// The progress bar boxed active color
        /// </summary>
        private Color ProgressBarBoxed_activeColor = Color.Red;
        /// <summary>
        /// The brush active block
        /// </summary>
        protected const string BrushActiveBlock = "BrushActiveBlock";

        /// <summary>
        /// The progress bar boxed inner grid type
        /// </summary>
        private ProgressBarBoxed_InnerGridTypes ProgressBarBoxed_InnerGridType;

        /// <summary>
        /// The progress bar boxed active block color
        /// </summary>
        private Color ProgressBarBoxed_activeBlockColor = Color.Red;

        /// <summary>
        /// The progress bar boxed number of blocks
        /// </summary>
        private int ProgressBarBoxed_numberOfBlocks;

        /// <summary>
        /// The progress bar boxed block rects
        /// </summary>
        private Rectangle[] ProgressBarBoxed_blockRects = null;

        /// <summary>
        /// Enum ProgressBarBoxed_InnerGridTypes
        /// </summary>
        public enum ProgressBarBoxed_InnerGridTypes { None, UntilActive, Full }


        /// <summary>
        /// Zeroits the progress bar boxed.
        /// </summary>
        public void ZeroitProgressBarBoxed()
        {

            
            ProgressBarBoxed_InnerGridType = ProgressBarBoxed_InnerGridTypes.Full;

            ProgressBarBoxed_ActiveBlockColor = ProgressBarBoxed_activeColor;

            ProgressBarBoxed_NumberOfBlocks = 5;
        }


        #region Drawing
        /// <summary>
        /// The progress bar boxed maximum block to draw
        /// </summary>
        private int ProgressBarBoxed_MaxBlockToDraw = -1;
        /// <summary>
        /// Progresses the bar boxed draw background.
        /// </summary>
        /// <param name="g">The g.</param>
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

        /// <summary>
        /// Progresses the bar boxed draw inner grid.
        /// </summary>
        /// <param name="g">The g.</param>
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
                Point[] PathAround = Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.PathAround(ProgressBarBoxed_blockRects[i]);
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


        /// <summary>
        /// Gets or sets the color of the progress bar boxed active back.
        /// </summary>
        /// <value>The color of the progress bar boxed active back.</value>
        [DefaultValue(typeof(Color), "Red"),
         Category("RectangularProgress Antonio-Boxed")]
        [Browsable(false)]
        public Color ProgressBarBoxed_ActiveBackColor
        {
            get { return ProgressBarBoxed_activeColor; }
            set
            {
                ProgressBarBoxed_activeColor = value;
                ProgressBarNormal_Invalidate();
            }


        }

        /// <summary>
        /// Gets or sets the type of the inner grid.
        /// </summary>
        /// <value>The type of the inner grid.</value>
        [Description("Inner Grid Type"),
            Category("RectangularProgress Antonio-Boxed")]
        [Browsable(false)]
        public ProgressBarBoxed_InnerGridTypes InnerGridType
        {
            get { return ProgressBarBoxed_InnerGridType; }
            set
            {
                ProgressBarBoxed_InnerGridType = value;
                ProgressBarNormal_Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress bar boxed active block.
        /// </summary>
        /// <value>The color of the progress bar boxed active block.</value>
        [Description("Active Block Color"),
            Category("RectangularProgress Antonio-Boxed")]
        [Browsable(false)]
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


        /// <summary>
        /// Gets or sets the progress bar boxed number of blocks.
        /// </summary>
        /// <value>The progress bar boxed number of blocks.</value>
        /// <exception cref="ArgumentOutOfRangeException">ProgressBarBoxed_NumberOfBlocks - Value must greater than 1</exception>
        [Description("Number of Blocks"),
            Category("RectangularProgress Antonio-Boxed")]
        [Browsable(false)]
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
        /// <summary>
        /// Progresses the bar boxed compute maximum block to draw.
        /// </summary>
        private void ProgressBarBoxed_ComputeMaxBlockToDraw()
        {
            if (_iPercent > 0)
                ProgressBarBoxed_MaxBlockToDraw = (int)Math.Floor(_fPercent / 100 * ProgressBarBoxed_numberOfBlocks);
            else
                ProgressBarBoxed_MaxBlockToDraw = -1;
            //if (ProgressBarBoxed_MaxBlockToDraw > ProgressBarBoxed_numberOfBlocks-1)
            //    ProgressBarBoxed_MaxBlockToDraw = ProgressBarBoxed_numberOfBlocks-1;
        }



        /// <summary>
        /// Progresses the bar boxed prepare blocks.
        /// </summary>
        private void ProgressBarBoxed_PrepareBlocks()
        {
            ProgressBarBoxed_blockRects = Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitInParts(ClientRectangle, ProgressBarBoxed_numberOfBlocks, Zeroit.Framework.ProgressThematic.Drawing.MyRectangle.SplitType.Horizontal);
        }

        /// <summary>
        /// Progresses the bar boxed get blocks.
        /// </summary>
        /// <returns>Rectangle[].</returns>
        private Rectangle[] ProgressBarBoxed_GetBlocks()
        {
            return ProgressBarBoxed_blockRects;
        }

        /// <summary>
        /// Progresses the bar normal on size changed.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Progresses the bar boxed paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressBarBoxed_Paint(PaintEventArgs e)
        {
            ProgressBarNormal_Paint(e);
            Graphics g = e.Graphics;
            //g.SmoothingMode = Smoothing;
            //g.TextRenderingHint = TextRendering;

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
