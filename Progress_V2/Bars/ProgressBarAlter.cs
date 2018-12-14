// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarAlter.cs" company="Zeroit Dev Technologies">
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


    #region ZeroitProgressBarAlter

    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {

        #region  Private Fields
        //private Color ProgressAlter_ColorBack = Color.FromArgb(210, 210, 210);
        //private Color ProgressAlter_ColorBorder = Color.FromArgb(150, 150, 150);
        //private Color ProgressAlter_ColorText = Color.FromArgb(100, 100, 100);
        //private Color ProgressAlter_ColorInside = Color.FromArgb(200, 200, 200);
        //private Color ProgressAlter_ColorIC = Color.FromArgb(215, 215, 215);
        //private Color ProgressAlter_Color1 = Color.FromArgb(220, 220, 220);
        //private Color Color2 = Color.FromArgb(200, 200, 200);

        //private float ProgressAlter_ColorAngle = 90F;

        /// <summary>
        /// The g
        /// </summary>
        private Graphics G;

        //private int _Value;
        //private bool ShowValue = false;

        //Brush BT;
        //Pen IB, PB;
        //Color BG, IC;

        //private Orientation ProgressAlter_Orientation;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the progress alter color back.
        /// </summary>
        /// <value>The progress alter color back.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_ColorBack
        {
            get { return progressInput.ProgressAlter_ColorBack; }
            set
            {
                progressInput.ProgressAlter_ColorBack = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color border.
        /// </summary>
        /// <value>The progress alter color border.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_ColorBorder
        {
            get { return progressInput.ProgressAlter_ColorBorder; }
            set
            {
                progressInput.ProgressAlter_ColorBorder = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color text.
        /// </summary>
        /// <value>The progress alter color text.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_ColorText
        {
            get { return progressInput.ProgressAlter_ColorText; }
            set
            {
                progressInput.ProgressAlter_ColorText = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color inside.
        /// </summary>
        /// <value>The progress alter color inside.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_ColorInside
        {
            get { return progressInput.ProgressAlter_ColorInside; }
            set
            {
                progressInput.ProgressAlter_ColorInside = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color ic.
        /// </summary>
        /// <value>The progress alter color ic.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_ColorIC
        {
            get { return progressInput.ProgressAlter_ColorIC; }
            set
            {
                progressInput.ProgressAlter_ColorIC = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color1.
        /// </summary>
        /// <value>The progress alter color1.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color ProgressAlter_Color1
        {
            get { return progressInput.ProgressAlter_Color1; }
            set
            {
                progressInput.ProgressAlter_Color1 = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color2.
        /// </summary>
        /// <value>The color2.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Color Color2
        {
            get { return progressInput.Color2; }
            set
            {
                progressInput.Color2 = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter color angle.
        /// </summary>
        /// <value>The progress alter color angle.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public float ProgressAlter_ColorAngle
        {
            get { return progressInput.ProgressAlter_ColorAngle; }
            set
            {
                progressInput.ProgressAlter_ColorAngle = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the progress alter orientation.
        /// </summary>
        /// <value>The progress alter orientation.</value>
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public Orientation ProgressAlter_Orientation
        {
            get { return progressInput.ProgressAlter_Orientation; }
            set
            {
                progressInput.ProgressAlter_Orientation = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [show value].
        /// </summary>
        /// <value><c>true</c> if [show value]; otherwise, <c>false</c>.</value>
        [Description("Indicates if the value of the progress bar will be shown in the middle of it.")]
        [Category("RectangularProgress Alter")]
        [Browsable(false)]
        public bool ShowValue
        {
            get { return progressInput.ShowValue; }
            set
            {
                progressInput.ShowValue = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint Event

        /// <summary>
        /// Progresses the alter paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void ProgressAlter_Paint(PaintEventArgs e)
        {

            Graphics G = e.Graphics;
            //G.SmoothingMode = Smoothing;
            //G.TextRenderingHint = TextRendering;

            switch (ProgressAlter_Orientation)
            {
                case System.Windows.Forms.Orientation.Horizontal:

                    float area = ((Value * (Width - 6)) / Maximum);
                    G.Clear(ProgressAlter_ColorBack);
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), ProgressAlter_Color1, Color2, ProgressAlter_ColorAngle);

                    if (Value == Maximum)
                    {
                        G.FillRectangle(LGB1, new Rectangle(3, 3, Width - 4, Height - 4));

                        DrawBorders(G,new Pen(ProgressAlter_ColorBorder), 30);
                    }

                    else if (Value == Minimum)
                    {

                    }

                    else
                    {
                        G.FillRectangle(LGB1, new Rectangle(3, 3, (int)area, Height - 4));
                        G.DrawRectangle(new Pen(ProgressAlter_ColorBorder), new Rectangle(3, 3, (int)area - 1, Height - 7));
                    }
                    if (ShowValue)
                    {
                        string val = Convert.ToInt32(Value).ToString();
                        DrawText(G,new SolidBrush(ForeColor), val, HorizontalAlignment.Center, 0, 0);
                    }

                    break;

                case System.Windows.Forms.Orientation.Vertical:

                    float area2 = ((Value * (Height - 6)) / Maximum);

                    G.Clear(ProgressAlter_ColorBack);
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), ProgressAlter_Color1, Color2, 90F);

                    if (Value == Maximum)
                    {
                        G.FillRectangle(LGB2, new Rectangle(3, 3, Width - 4, Height - 4));
                        DrawBorders(G,new Pen(ProgressAlter_ColorBorder), 3);
                    }
                    else if (Value == Minimum)
                    {

                    }

                    else
                    {
                        G.FillRectangle(LGB2, new Rectangle(3, 3, Width - 4, (int)area2));
                        G.DrawRectangle(new Pen(ProgressAlter_ColorBorder), new Rectangle(3, 3, Width - 7, (int)area2));
                    }
                    if (ShowValue)
                    {
                        string val = Convert.ToInt32(Value).ToString();
                        DrawText(G,new SolidBrush(ForeColor), val, HorizontalAlignment.Center, 0, 0);
                    }

                    break;
            }

            DrawBorders(G,new Pen(ProgressAlter_ColorInside));
            DrawBorders(G,new Pen(ProgressAlter_ColorBorder), 1);
        }

        #endregion

        #region Event

        /// <summary>
        /// Handles the Tick event of the ProgressAlter_Timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressAlter_Timer_Tick(object sender, EventArgs e)
        {
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
        /// Handles the Tick event of the ProgressAlter_Timer_Reduced control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProgressAlter_Timer_Reduced_Tick(object sender, EventArgs e)
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


    }


    

    #endregion


}
