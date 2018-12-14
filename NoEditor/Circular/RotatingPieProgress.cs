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

    #region Rotating RotatingPieProgress with HeartBeat


    public partial class ThematicProgress
    {

        #region Private Fields
        //private float angle = 90f;
        //private float (Value/Maximum) * 360 = 0f;
        //private int interval = 10;
        //private bool RotatingBorder = false;
        //public enum shape { Pie, Arc }
        //private shape _shape = shape.Arc;
        //private int size = 1;

        //private Color PieColor1 = Color.Beige;
        //private Color PieColor2 = Color.Blue;

        //private Color lineColor1 = Color.Yellow;
        //private Color lineColor2 = Color.Blue;

        //private Color lineWidthColor = Color.Transparent;

        //private bool FillPie = false;
        //private bool drawLine = true;

        //private int Innercircle1WidthReduction = 10;
        //private int Innercircle1HeightReduction = 10;

        //Graphics g;

        //private Color ColorOuterBorder = Color.Blue;
        //private Color ColorInnerCircle1Grad1 = Color.Red;
        //private Color ColorInnerCircle1Grad2 = Color.Green;

        //private Color ColorInnerCircle2Grad1 = Color.Yellow;
        //private Color ColorInnerCircle2Grad2 = Color.Blue;

        //private Color ColorInnerCircle3Grad1 = Color.Brown;
        //private Color ColorInnerCircle3Grad2 = Color.Gray;

        //private Color ColorInnerCircle4Grad1 = Color.RosyBrown;
        //private Color ColorInnerCircle4Grad2 = Color.LightBlue;

        //private Color innerCircle5Grad1 = Color.Violet;
        //private Color innerCircle5Grad2 = Color.LightPink;

        //private Color innerCircle6Grad1 = SystemColors.Control;
        //private Color innerCircle6Grad2 = SystemColors.Control;

        //private bool ShowInnerCircle1 = true;
        //private bool ShowInnerCircle2 = true;
        //private bool ShowInnerCircle3 = true;
        //private bool ShowInnerCircle4 = true;
        //private bool ShowInnerCircle5 = true;
        //private bool ShowInnerCircle6 = true;

        //private int OuterBorderWidth = 1;

        //private int InnerCircleBorder = 10;

        //private int Innercircle2WidthReduction = 20;
        //private int Innercircle2HeightReduction = 20;

        //private int Innercircle3WidthReduction = 40;
        //private int Innercircle3HeightReduction = 40;

        //private int Innercircle4WidthReduction = 60;
        //private int Innercircle4HeightReduction = 60;

        //private int Innercircle5WidthReduction = 80;
        //private int Innercircle5HeightReduction = 80;

        //private int Innercircle6WidthReduction = 100;
        //private int Innercircle6HeightReduction = 100;

        private float pieLimit = 360f;


        #endregion

        #region Timer Utility

        

        

        #region Event

        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    if (this.angle + 1 > pieLimit)
        //    {

        //        this.angle = 0;
        //    }
        //    else
        //    {
        //        this.angle++;
        //        Invalidate();
        //    }

        //    if ((Value/Maximum) * 360 + 1 > pieLimit)
        //    {

        //        this.(Value/Maximum) * 360 = 0;
        //    }
        //    else
        //    {
        //        this.(Value/Maximum) * 360++;
        //        Invalidate();
        //    }

        //    //if (InnerCircleBorder + 1 > 10)
        //    //{

        //    //    this.InnerCircleBorder = 1;
        //    //}
        //    //else
        //    //{
        //    //    this.InnerCircleBorder++;
        //    //    Invalidate();
        //    //}

        //}

        //private void HeartTimer_Tick(object sender, EventArgs e)
        //{

        //    if (InnerCircleBorder + 1 > 10)
        //    {

        //        this.InnerCircleBorder = 1;
        //    }
        //    else
        //    {
        //        this.InnerCircleBorder++;
        //        Invalidate();
        //    }

        //}

        #endregion

        #endregion

        #region Constructor

        public void RotatingPieProgress()
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //if (AutoAnimate)
            //{

            //    timer.Start();

            //}

            //if (HeartAutoAnimate)
            //{

            //    heartTimer.Start();

            //}


            //timer.Tick += Timer_Tick;

            //heartTimer.Tick += HeartTimer_Tick;

        }

        #endregion
        
        #region Overrides

        //private void RotatingPie_OnPaint(PaintEventArgs e)
        //{
            
        //    e.Graphics.SmoothingMode = smoothing;

        //    //timer.Interval = interval;
        //    //heartTimer.Interval = heartinterval;

        //    //Text = "";

        //    //e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;



        //    if (RotatingBorder)
        //    {
        //        e.Graphics.DrawPie(new Pen(ColorOuterBorder, OuterBorderWidth), new Rectangle(0, 0, Width - 2, Height - 2), 180, (Value/Maximum) * 360);

        //        if (FillPie)
        //        {
        //            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), PieColor1, PieColor2, (Value/Maximum) * 360);

        //            e.Graphics.FillPie(brush, new Rectangle(0, 0, Width - 2, Height - 2), 180, (Value/Maximum) * 360);
        //        }

        //    }


        //    #region DrawInnerCircles 

        //    if (ShowInnerCircle1)
        //    {
        //        LinearGradientBrush innercircle1brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), ColorInnerCircle1Grad1, ColorInnerCircle1Grad2, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle1brush, new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction, Innercircle1HeightReduction, Width - (2 * Innercircle1WidthReduction), Height - (2 * Innercircle1HeightReduction)), 180, (Value/Maximum) * 360);

        //    }

        //    if (ShowInnerCircle2)
        //    {
        //        LinearGradientBrush innercircle2brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), ColorInnerCircle2Grad1, ColorInnerCircle2Grad2, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle2brush, new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle2WidthReduction, Innercircle1HeightReduction + Innercircle2HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle2WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle2HeightReduction))), 180, (Value/Maximum) * 360);

        //    }

        //    if (ShowInnerCircle3)
        //    {
        //        LinearGradientBrush innercircle3brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), ColorInnerCircle3Grad1, ColorInnerCircle3Grad2, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle3brush, new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle3WidthReduction, Innercircle1HeightReduction + Innercircle3HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle3WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle3HeightReduction))), 180, (Value/Maximum) * 360);
        //    }


        //    if (ShowInnerCircle4)
        //    {
        //        LinearGradientBrush innercircle4brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), Color.RosyBrown, Color.LightBlue, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle4brush, new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle4WidthReduction, Innercircle1HeightReduction + Innercircle4HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle4WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle4HeightReduction))), 180, (Value/Maximum) * 360);
        //    }

        //    if (ShowInnerCircle5)
        //    {

        //        LinearGradientBrush innercircle5brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 80))), Color.Violet, Color.LightPink, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle5brush, new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, InnerCircleBorder), new Rectangle(Innercircle1WidthReduction + Innercircle5WidthReduction, Innercircle1HeightReduction + Innercircle5HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle5WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle5HeightReduction))), 180, (Value/Maximum) * 360);
        //    }

        //    if (ShowInnerCircle6)
        //    {
        //        LinearGradientBrush innercircle6brush = new LinearGradientBrush(new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + 100))), Parent.BackColor, Parent.BackColor, (Value/Maximum) * 360);

        //        e.Graphics.FillPie(innercircle6brush, new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), 180, (Value/Maximum) * 360);
        //        e.Graphics.DrawPie(new Pen(Parent.BackColor, 10), new Rectangle(Innercircle1WidthReduction + Innercircle6WidthReduction, Innercircle1HeightReduction + Innercircle6HeightReduction, Width - (2 * (Innercircle1WidthReduction + Innercircle6WidthReduction)), Height - (2 * (Innercircle1HeightReduction + Innercircle6HeightReduction))), 180, (Value/Maximum) * 360);
        //    }
        //    #endregion

        //    //e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

        //    // Then to rotate, prepending rotation matrix.
        //    //e.Graphics.RotateTransform(angle);

            

            

        //}

        #endregion
        
    }

    #endregion

}
