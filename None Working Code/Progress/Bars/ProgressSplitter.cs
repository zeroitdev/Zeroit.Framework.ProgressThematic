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


    #region SmartProgressBar

    /// <summary>

    /// </summary>

    public partial class ThematicProgress
    {

        #region Private Fields

        private const int m_MaxBarWidth = 20;
        private const int m_MaxBarSpace = 10;
        //private int Splitter_BlockWidth = 6;
        //private int Splitter_BlockSpace = 1;
        //private bool Splitter_Percent = true;
        //private bool Splitter_MarginOffset = true;
        //private TProgressBarBorderStyle Splitter_BoderStyle = TProgressBarBorderStyle.Flat;
        //private SolidBrush m_ProgressBarFillBrush;

        #endregion

        #region Public Properties

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get progress bar fill color.")]
        [DefaultValue(typeof(Color), "Coral")]
        public Color Splitter_FillColor
        {
            get
            {
                return progressInput.Splitter_FillColor;
            }

            set
            {
                if (progressInput.Splitter_FillColor != value)
                {
                    progressInput.Splitter_FillColor = value;
                    this.Invalidate();
                }
            }
        }

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get progress small bar width.")]
        [DefaultValue(6)]
        public int Splitter_BlockWidth
        {
            get { return progressInput.Splitter_BlockWidth; }
            set
            {
                if (progressInput.Splitter_BlockWidth != value)
                {
                    if (value < 1)
                    {
                        progressInput.Splitter_BlockWidth = 1;
                    }
                    else if (value > m_MaxBarWidth)
                    {
                        progressInput.Splitter_BlockWidth = m_MaxBarWidth;
                    }
                    else
                    {
                        progressInput.Splitter_BlockWidth = value;
                    }
                    this.Invalidate();
                }
            }
        }

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get progress bar space width(smooth when 0).")]
        [DefaultValue(1)]
        public int Splitter_BlockSpace
        {
            get { return progressInput.Splitter_BlockSpace; }
            set
            {
                if (progressInput.Splitter_BlockSpace != value)
                {
                    if (value < 0)
                    {
                        progressInput.Splitter_BlockSpace = 0;
                    }
                    else if (value > m_MaxBarSpace)
                    {
                        progressInput.Splitter_BlockSpace = m_MaxBarSpace;
                    }
                    else
                    {
                        progressInput.Splitter_BlockSpace = value;
                    }
                    this.Invalidate();
                }
            }
        }

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get progress bar boder style.")]
        [DefaultValue(typeof(TProgressBarBorderStyle), "Flat")]
        public TProgressBarBorderStyle Splitter_BoderStyle
        {
            get { return progressInput.Splitter_BoderStyle; }
            set
            {
                if (progressInput.Splitter_BoderStyle != value)
                {
                    progressInput.Splitter_BoderStyle = value;
                    this.Invalidate();
                }
            }
        }

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get show percent text or not.")]
        [DefaultValue(true)]
        public bool Splitter_Percent
        {
            get { return progressInput.Splitter_Percent; }
            set
            {
                if (progressInput.Splitter_Percent != value)
                {
                    progressInput.Splitter_Percent = value;
                    this.Invalidate();
                }
            }
        }

        [Category("RectangularProgress Splitter")]
        [Description("Set/Get if progress bar has margin offset.")]
        [DefaultValue(true)]
        public bool Splitter_MarginOffset
        {
            get { return progressInput.Splitter_MarginOffset; }
            set
            {
                if (progressInput.Splitter_MarginOffset != value)
                {
                    progressInput.Splitter_MarginOffset = value;
                    this.Invalidate();
                }
            }
        }

        //[Category("Custom")]
        //[Description("Set/Get progress bar background color.")]
        //[DefaultValue(typeof(Color), "White")]
        //public new Color BackColor
        //{
        //    get { return base.BackColor; }
        //    set
        //    {
        //        if (base.BackColor != value)
        //        {
        //            base.BackColor = value;
        //            this.Invalidate();
        //        }
        //    }
        //}

        //[Category("Custom")]
        //[Description("Set/Get progress bar text color.")]
        //[DefaultValue(typeof(Color), "Blue")]
        //public new Color ForeColor
        //{
        //    get { return base.ForeColor; }
        //    set
        //    {
        //        if (base.ForeColor != value)
        //        {
        //            base.ForeColor = value;
        //            this.Invalidate();
        //        }
        //    }
        //}

        //[Category("Custom")]
        //[Description("Set/Get progress bar maximum value.")]
        //[DefaultValue(100)]
        //public int Maximum
        //{
        //    get { return m_Maximum; }
        //    set
        //    {
        //        if (m_Maximum != value)
        //        {
        //            if (value < 1)
        //            {
        //                m_Maximum = 1;
        //            }
        //            else
        //            {
        //                m_Maximum = value;
        //            }
        //            if (m_Maximum < m_Value)
        //            {
        //                m_Value = m_Maximum;
        //            }

        //            this.Invalidate();
        //        }
        //    }
        //}

        //[Category("Custom")]
        //[Description("Set/Get progress bar current value.")]
        //[DefaultValue(0)]
        //public int Value
        //{
        //    get { return m_Value; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            value = 0;
        //        }
        //        else if (value > m_Maximum)
        //        {
        //            m_Value = m_Maximum;
        //        }
        //        else
        //        {
        //            m_Value = value;
        //        }

        //        this.Invalidate();
        //        this.Update();
        //    }
        //}

        #endregion

        #region Event

        private void ProgressBarSplitter_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
                this.Value = 0;
            else
                this.Value++;
        }

        #endregion

        public void ZeroitProgressSplitter()
        {
            //m_ProgressBarFillBrush = new SolidBrush(Splitter_FillColor);

            //base.BackColor = Color.White;
            //base.ForeColor = Color.Blue;

            //base.AutoSize = false;  // AutoSize is Designer Attribute
            //TextAlign = ContentAlignment.MiddleCenter;   // TextAlign is Designer Attribute
             

            
            
        }

        private void ProgressBarSplitter_Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    // release managed resource
                }
                //m_ProgressBarFillBrush.Dispose();  // release unmanaged resource
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        

        //#region disable base properties

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool AutoSize
        //{
        //    get
        //    {
        //        return base.AutoSize;
        //    }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool AutoEllipsis
        //{
        //    get { return base.AutoEllipsis; }
        //}

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new System.Drawing.ContentAlignment TextAlign
        //{
        //    get
        //    {
        //        return base.TextAlign;
        //    }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool CausesValidation
        //{
        //    get { return base.CausesValidation; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool AllowDrop
        //{
        //    get { return base.AllowDrop; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new Padding Padding
        //{
        //    get { return base.Padding; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new ImeMode ImeMode
        //{
        //    get { return base.ImeMode; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool TabStop
        //{
        //    get { return base.TabStop; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool UseCompatibleTextRendering
        //{
        //    get { return base.UseCompatibleTextRendering; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new bool UseMnemonic
        //{
        //    get { return base.UseMnemonic; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new BorderStyle BorderStyle
        //{
        //    get { return base.BorderStyle; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new FlatStyle FlatStyle
        //{
        //    get { return base.FlatStyle; }
        //}

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new Image Image
        //{
        //    get { return base.Image; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new System.Drawing.ContentAlignment ImageAlign
        //{
        //    get { return base.ImageAlign; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new int ImageIndex
        //{
        //    get { return base.ImageIndex; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new string ImageKey
        //{
        //    get { return base.ImageKey; }
        //}

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new ImageList ImageList
        //{
        //    get { return base.ImageList; }
        //}

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //public new string Text
        //{
        //    get { return base.Text; }
        //}


        //#endregion

        private void ProgressBarSplitter_OnPaint(PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = smoothing;
            e.Graphics.Clear(BackColor);

            this.DrawPrgressBarBorder(e.Graphics);
            this.DrawProgressBar(e.Graphics);

            if (Splitter_Percent)
            {
                //Text = ((double)Value / (double)Maximum).ToString("##0 %");

                //Text = Convert.ToInt32(Value / Maximum).ToString() + PostFix;

                Helper.CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font, ForeColor, new Rectangle(0, 0, Width, Height));
            }
            else
            {
                //base.Text = string.Empty;
            }

            
        }

        private int GetTopOffSet()
        {
            if (!Splitter_MarginOffset)  // use no margin
            {
                if (Splitter_BoderStyle == TProgressBarBorderStyle.Sunken || Splitter_BoderStyle == TProgressBarBorderStyle.Flat)
                {
                    return 2;
                }
                else if (Splitter_BoderStyle == TProgressBarBorderStyle.None)
                {
                    return 0;
                }
                return 1;
            }
            else  // use margin
            {
                if (Splitter_BoderStyle == TProgressBarBorderStyle.Flat || Splitter_BoderStyle == TProgressBarBorderStyle.Sunken)
                {
                    return 3;
                }
                else if (Splitter_BoderStyle == TProgressBarBorderStyle.None)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        private int GetLeftOffSet()
        {
            if (!Splitter_MarginOffset)
            {
                if (Splitter_BoderStyle == TProgressBarBorderStyle.Flat)
                {
                    return 2;
                }
                else if (Splitter_BoderStyle == TProgressBarBorderStyle.None)
                {
                    return 0;
                }
                return 1;
            }
            else
            {
                if (Splitter_BoderStyle == TProgressBarBorderStyle.Flat || Splitter_BoderStyle == TProgressBarBorderStyle.Sunken)
                {
                    return 3;
                }
                else if (Splitter_BoderStyle == TProgressBarBorderStyle.None)
                {
                    return 1;
                }
                return 2;
            }
        }

        private void DrawProgressBar(Graphics g)
        {
            //decimal percent = (decimal)Value / (decimal)Value;

            //m_ProgressBarFillBrush.Color = Splitter_FillColor;

            float percent = Value / Maximum;


            int valueWidth = (int)((this.ClientRectangle.Width - this.GetLeftOffSet() * 2) * percent);  // width corresponds to Value
            int oneBlockWidth = Splitter_BlockWidth + Splitter_BlockSpace;  // bar width + space width
            int blockWidth = (valueWidth / oneBlockWidth) * (oneBlockWidth);  // width corresponds to real blocks

            if (percent > 0.99/*m*/)  // add block length to avoid trunc error
            {
                if (this.ClientRectangle.Width - this.GetLeftOffSet() * 2 - blockWidth > 0)
                {
                    blockWidth += (this.ClientRectangle.Width - this.GetLeftOffSet() * 2 - blockWidth) / (oneBlockWidth);
                }
            }

            int left = this.ClientRectangle.Left + this.GetLeftOffSet();
            int top = this.ClientRectangle.Top + this.GetTopOffSet();
            int height = this.ClientRectangle.Height - this.GetTopOffSet() * 2;

            int drawnBlockWidth = oneBlockWidth;
            while (drawnBlockWidth <= blockWidth)
            {
                g.FillRectangle(new SolidBrush(Splitter_FillColor), left, top, Splitter_BlockWidth, height);
                left += oneBlockWidth;
                drawnBlockWidth += oneBlockWidth;
            }

            // below code used to draw the tail part.

            int tailBarWidth = this.ClientRectangle.Width - left - this.GetLeftOffSet();
            if (tailBarWidth > 0 && tailBarWidth < oneBlockWidth)  // tail is not a full bar
            {
                drawnBlockWidth = this.ClientRectangle.Width - left - this.GetLeftOffSet();
                if (drawnBlockWidth > 0)
                {
                    g.FillRectangle(new SolidBrush(Splitter_FillColor), left, top, drawnBlockWidth, height);  // draw partial bar
                }
            }
        }

        private void DrawPrgressBarBorder(Graphics g)
        {
            if (this.Splitter_BoderStyle == TProgressBarBorderStyle.Single)
            {
                ControlPaint.DrawBorder(g, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }
            else if (this.Splitter_BoderStyle == TProgressBarBorderStyle.Flat)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.Flat);
            }
            else if (this.Splitter_BoderStyle == TProgressBarBorderStyle.Sunken)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.Sunken);
            }
            else if (this.Splitter_BoderStyle == TProgressBarBorderStyle.SunkenInner)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.SunkenInner);
            }
            else if (this.Splitter_BoderStyle == TProgressBarBorderStyle.SunkenOut)
            {
                ControlPaint.DrawBorder3D(g, this.ClientRectangle, Border3DStyle.SunkenOuter);
            }
        }

    }

    /// <summary>
    /// border kind
    /// </summary>
    public enum TProgressBarBorderStyle { Flat, SunkenOut, SunkenInner, Sunken, Single, None }

    

    #endregion


}
