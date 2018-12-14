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
    #region ZeroitProgressBarTransparent

    
    public partial class ThematicProgress
    {
        
        #region Event

        private void Transparent_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > this.Maximum)
                this.Value = 0;
            else
                this.Value++;
        }

        #endregion

        #region Private Fields
        
        //private Boolean Trans_ShowText = true;
        //private Color Trans_Background = Color.Blue;
        //private Color Trans_ProgressColor1 = Color.Red;
        //private Color Trans_ProgressColor2 = Color.Gray;

        #endregion

        #region Public Properties

        [Category("RectangularProgress Transparent")]
        public Boolean Trans_ShowText
        {
            get { return progressInput.Trans_ShowText; }
            set
            {
                progressInput.Trans_ShowText = value;
                Invalidate(); 
            }
        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_Background
        {
            get
            {
                return progressInput.Trans_Background;
            }

            set
            {
                progressInput.Trans_Background = value;
                Invalidate();
            }

        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor1
        {
            get
            {
                return progressInput.Trans_ProgressColor1;
            }

            set
            {
                progressInput.Trans_ProgressColor1 = value;
                Invalidate();
            }

        }

        [Category("RectangularProgress Transparent")]
        public Color Trans_ProgressColor2
        {
            get
            {
                return progressInput.Trans_ProgressColor2;
            }

            set
            {
                progressInput.Trans_ProgressColor2 = value;
                Invalidate();
            }

        }

        
        
        #endregion

        public void ZeroitProgressBarTransparent()
        {
            
        }

        private void Transparent_Paint(PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(BackColor);


            LinearGradientBrush l = new LinearGradientBrush(new Point(0, 0), new Point(Width + (int)Value + 50, Height), Trans_ProgressColor1, Trans_ProgressColor2);

           //g.Clear(BackColor);

            g.FillRectangle(l, new Rectangle(0, 0, (int)(Helper.ValueToPercentage((int)Value, (int)Maximum, (int)Minimum) * Width), Height));

            Helper.RoundRect(g, 0, 0, Width - 1, Height - 1, 1, BackColor);

            if (Trans_ShowText)
                Helper.CenterString(g, Convert.ToInt32(Value).ToString() + PostFix, Font, ForeColor, new Rectangle(0, 0, Width, Height));

            Helper.MultiDispose(l);

        }


    }


    

    #endregion
}
