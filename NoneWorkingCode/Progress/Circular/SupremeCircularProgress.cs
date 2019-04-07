using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Zeroit.Framework.ProgressThematic
{
    public partial class ThematicProgress
    {

        #region Private Fields
        public enum Supreme_colorMode
        {
            Solid,
            Gradient
        }

        //private Supreme_colorMode SP_ColorMode = Supreme_colorMode.Solid;

        //private Color[] borderColors = new Color[]
        //{
        //    SystemColors.HotTrack,
        //    Color.LightGray
        //};

        //private Color SP_ProgressColor = SystemColors.HotTrack;

        //private Color SP_OuterColor = Color.LightGray;

        //private Color SP_SolidColor = SystemColors.Control;

        //private Color[] SP_GradientColor = new Color[]
        //{
        //    Color.Orange,
        //    Color.DarkSlateGray
        //};

        //private LinearGradientMode SP_GradientMode = LinearGradientMode.BackwardDiagonal;
               

        //private float SP_Angle = -90f;

        //private int SP_OuterBorder = 5;

        //private int SP_InnerBorder = 15; 

        #endregion

        #region Public Properties


        [Category("CircularProgress Supreme")]
        public Color SP_ProgressColor
        {
            get { return progressInput.SP_ProgressColor; }
            set
            {
                progressInput.SP_ProgressColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color SP_OuterColor
        {
            get { return progressInput.SP_OuterColor; }
            set
            {
                progressInput.SP_OuterColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color SP_SolidColor
        {
            get { return progressInput.SP_SolidColor; }
            set
            {
                progressInput.SP_SolidColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color[] SP_GradientColor
        {
            get { return progressInput.SP_GradientColor; }
            set
            {
                progressInput.SP_GradientColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Supreme_colorMode SP_ColorMode
        {
            get { return progressInput.SP_ColorMode; }
            set
            {
                progressInput.SP_ColorMode = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public float SP_Angle
        {
            get
            {
                return progressInput.SP_Angle;

            }
            set
            {
                progressInput.SP_Angle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_OuterBorder
        {
            get { return progressInput.SP_OuterBorder; }
            set
            {
                progressInput.SP_OuterBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_InnerBorder
        {
            get { return progressInput.SP_InnerBorder; }
            set
            {
                progressInput.SP_InnerBorder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public LinearGradientMode SP_GradientMode
        {
            get { return progressInput.SP_GradientMode; }
            set
            {
                progressInput.SP_GradientMode = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Supreme_colorMode SP_DrawMode
        {
            get { return SP_ColorMode; }
            set
            {
                SP_ColorMode = value;
                Invalidate();
            }
        }
        
        #endregion

        #region Constructor

        public void SupremeCircularProgress()
        {

            

        }

        #endregion

        #region Private Methods


        public static void Supreme_CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);

            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point(R.Width / 2 - (int)(TS.Width / 2), R.Height / 2 - (int)(TS.Height / 2)));
            }
        }

        private void PaintProgressBar(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
            //Graphics graphic = Graphics.FromImage(bitmap);

            Graphics graphic = e.Graphics;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.Clear(BackColor);

            Rectangle rectangle = new Rectangle(10, 10, checked(base.Width - 20),
                checked(base.Height - 20));
            Pen pen = new Pen(SP_OuterColor)
            {
                Width = (float)this.SP_OuterBorder
            };

            graphic.DrawArc(pen, rectangle, 0f, 360f);

            switch (SP_ColorMode)
            {
                case Supreme_colorMode.Solid:
                    graphic.FillEllipse(new SolidBrush(SP_SolidColor), 10f + (float)((double)this.SP_OuterBorder / 2), 10f + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - 20) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - 20) - this.SP_OuterBorder)));
                    break;
                case Supreme_colorMode.Gradient:
                    LinearGradientBrush linbrBrush = new LinearGradientBrush(
                        new RectangleF(10f + (float)((double)this.SP_OuterBorder / 2),
                        10f + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - 20) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - 20) - this.SP_OuterBorder))),
                        SP_GradientColor[0], SP_GradientColor[1], SP_GradientMode);
                    graphic.FillEllipse(linbrBrush, 10f + (float)((double)this.SP_OuterBorder / 2),
                    10f + (float)((double)this.SP_OuterBorder / 2),
                    (float)(checked(checked(base.Width - 20) - this.SP_OuterBorder)),
                    (float)(checked(checked(base.Height - 20) - this.SP_OuterBorder)));
                    break;
                default:
                    break;
            }


            Rectangle rectangle1 = new Rectangle(10, 10, checked(base.Width - 20),
                checked(base.Height - 20));
            pen = new Pen(this.SP_ProgressColor)
            {
                Width = (float)this.SP_InnerBorder
            };

            graphic.DrawArc(
                pen,
                rectangle1,
                (float)this.SP_Angle,
                (float)checked((int)Math.Round((double)(checked(360 * Value)) / Maximum)));


        }

        #endregion

        #region Overrides

        private void SP_OnPaint(PaintEventArgs e)
        {
            
            PaintProgressBar(e);

            if (ShowText)
            {
                Supreme_CenterString(e.Graphics, Convert.ToInt32(Value).ToString() + PostFix, Font, ForeColor, this.ClientRectangle);

            }

        }


        #endregion

        #region Timer Event

        private void SP_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Value + 1 > Maximum)
            {
                this.Value = 0;
            }

            else
            {
                this.Value++;
                Invalidate();
            }
        }

        private void SP_Angle_Timer_Tick(object sender, EventArgs e)
        {
            if (this.SP_Angle + 1 > 360)
            {
                this.SP_Angle = 0;
            }

            else
            {
                this.SP_Angle++;
                Invalidate();
            }
        }

        #endregion


    }
}
