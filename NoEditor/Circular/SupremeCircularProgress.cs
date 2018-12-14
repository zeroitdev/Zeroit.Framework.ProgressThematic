using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    public partial class ThematicProgress
    {

        #region Private Fields
        public enum Supreme_colorMode
        {
            Solid,
            Gradient
        }

        public enum Supreme_type
        {
            Pie,
            Circle
        }

        private Supreme_colorMode SP_colorMode = Supreme_colorMode.Solid;
        private Color progressColor = SystemColors.HotTrack;
        private Color outerColor = Color.LightGray;
        private Color solidColor = SystemColors.Control;
        private Color[] gradientColor = new Color[]
        {
            Color.Orange,
            Color.DarkSlateGray
        };
        private LinearGradientMode linMode = LinearGradientMode.BackwardDiagonal;
        private float SP_angle = -90f;
        private int outerborder = 5;
        private int innerborder = 15;

        private float supreme_StartAngle = 180f;
        private float supreme_SweepAngle = 360f;
        private LineCap supreme_StartCap = LineCap.Round;
        private LineCap supreme_EndCap = LineCap.Round;
        private Supreme_type supreme_Type = Supreme_type.Circle;

        private int supreme_width_Tweak = 20;
        private int supreme_height_Tweak = 20;

        private int supreme_position_horizontal = 10;
        private int supreme_position_vertical = 10;


        #endregion

        #region Public Properties

        [Category("CircularProgress Supreme")]
        public int SP_Width_Tweak
        {
            get { return supreme_width_Tweak; }
            set
            {
                supreme_width_Tweak = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_Height_Tweak
        {
            get { return supreme_height_Tweak; }
            set
            {
                supreme_height_Tweak = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_Position_Horizontal
        {
            get { return supreme_position_horizontal; }
            set
            {
                supreme_position_horizontal = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_Position_Vertical
        {
            get { return supreme_position_vertical; }
            set
            {
                supreme_position_vertical = value;
                Invalidate();
            }
        }
        
        [Category("CircularProgress Supreme")]
        public Supreme_type Supreme_Type
        {
            get { return supreme_Type; }
            set
            {
                supreme_Type = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public float Supreme_StartAngle
        {
            get { return supreme_StartAngle; }
            set
            {
                supreme_StartAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public float Supreme_SweepAngle
        {
            get { return supreme_SweepAngle; }
            set
            {
                supreme_SweepAngle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public LineCap Supreme_StartCap
        {
            get { return supreme_StartCap; }
            set
            {
                supreme_StartCap = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public LineCap Supreme_EndCap
        {
            get { return supreme_EndCap; }
            set
            {
                supreme_EndCap = value;
                Invalidate();
            }
        }
        

        [Category("CircularProgress Supreme")]
        public Color SP_ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color SP_OuterColor
        {
            get { return outerColor; }
            set
            {
                outerColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color SP_SolidColor
        {
            get { return solidColor; }
            set
            {
                solidColor = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Color[] SP_GradientColor
        {
            get { return gradientColor; }
            set
            {
                gradientColor = value;
                Invalidate();
            }
        }

        //[Category("CircularProgress Supreme")]
        //public Supreme_colorMode SP_DrawMode
        //{
        //    get { return progressInput.SP_DrawMode; }
        //    set
        //    {
        //        progressInput.SP_DrawMode = value;
        //        Invalidate();
        //    }
        //}

        [Category("CircularProgress Supreme")]
        public float SP_Angle
        {
            get
            {
                return SP_angle;

            }
            set
            {
                SP_angle = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_OuterBorder
        {
            get { return outerborder; }
            set
            {
                outerborder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public int SP_InnerBorder
        {
            get { return innerborder; }
            set
            {
                innerborder = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public LinearGradientMode SP_GradientMode
        {
            get { return linMode; }
            set
            {
                linMode = value;
                Invalidate();
            }
        }

        [Category("CircularProgress Supreme")]
        public Supreme_colorMode SP_DrawMode
        {
            get { return SP_colorMode; }
            set
            {
                SP_colorMode = value;
                Invalidate();
            }
        }
        
        #endregion

        #region Constructor

        
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
            graphic.SmoothingMode = Smoothing;
            graphic.TextRenderingHint = TextRendering;
            graphic.Clear(BackColor);

            Rectangle rectangle = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen pen = new Pen(SP_OuterColor)
            {
                Width = (float)this.SP_OuterBorder
            };

            pen.StartCap = Supreme_StartCap;
            pen.EndCap = Supreme_EndCap;

            graphic.DrawArc(pen, rectangle, /*0f*/ Supreme_StartAngle, /*360f*/ Supreme_SweepAngle);

            switch (SP_DrawMode)
            {
                case Supreme_colorMode.Solid:
                    graphic.FillEllipse(new SolidBrush(SP_SolidColor), SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)));
                    break;
                case Supreme_colorMode.Gradient:
                    LinearGradientBrush linbrBrush = new LinearGradientBrush(
                        new RectangleF(SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                            SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder))),
                        SP_GradientColor[0], SP_GradientColor[1], SP_GradientMode);
                    graphic.FillEllipse(linbrBrush, SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                    (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                    (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)));
                    break;
                default:
                    break;
            }


            Rectangle rectangle1 = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen outerpen = new Pen(this.SP_ProgressColor)
            {
                Width = (float)this.SP_InnerBorder
            };

            outerpen.StartCap = Supreme_StartCap;
            outerpen.EndCap = Supreme_EndCap;

            graphic.DrawArc(
                outerpen,
                rectangle1,
                (float)this.SP_Angle,
                (float)checked((int)Math.Round((double)(checked(/*360*/ Supreme_SweepAngle * Value)) / Maximum)));


        }

        private void PaintSupremePie(PaintEventArgs e)
        {
            //Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
            //Graphics graphic = Graphics.FromImage(bitmap);

            Graphics graphic = e.Graphics;
            graphic.SmoothingMode = Smoothing;
            graphic.Clear(BackColor);

            Rectangle rectangle = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));
            Pen pen = new Pen(SP_OuterColor)
            {
                Width = (float)this.SP_OuterBorder
            };

            pen.StartCap = Supreme_StartCap;
            pen.EndCap = Supreme_EndCap;

            graphic.DrawArc(pen, rectangle, Supreme_StartAngle, Supreme_SweepAngle);

            switch (SP_DrawMode)
            {
                case Supreme_colorMode.Solid:
                    
                    graphic.FillPie(new SolidBrush(SP_SolidColor), SP_Position_Horizontal + (float) ((double) this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float) ((double) this.SP_OuterBorder / 2),
                        (float) (checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float) (checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)), Supreme_StartAngle, Supreme_SweepAngle);

                    break;
                case Supreme_colorMode.Gradient:
                    LinearGradientBrush linbrBrush = new LinearGradientBrush(
                        new RectangleF(SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                            SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder))),
                        SP_GradientColor[0], SP_GradientColor[1], SP_GradientMode);
                    
                    graphic.FillPie(linbrBrush, SP_Position_Horizontal + (float)((double)this.SP_OuterBorder / 2),
                        SP_Position_Vertical + (float)((double)this.SP_OuterBorder / 2),
                        (float)(checked(checked(base.Width - SP_Width_Tweak) - this.SP_OuterBorder)),
                        (float)(checked(checked(base.Height - SP_Height_Tweak) - this.SP_OuterBorder)), Supreme_StartAngle, Supreme_SweepAngle);
                    break;
                default:
                    break;
            }


            Rectangle rectangle1 = new Rectangle(SP_Position_Horizontal, SP_Position_Vertical, checked(base.Width - SP_Width_Tweak),
                checked(base.Height - SP_Height_Tweak));

            Pen outerpen = new Pen(this.SP_ProgressColor)
            {
                Width = (float)this.SP_InnerBorder
            };

            outerpen.StartCap = Supreme_StartCap;
            outerpen.EndCap = Supreme_EndCap;



            graphic.DrawArc(
                outerpen,
                rectangle1,
                (float)this./*SP_Angle*/Supreme_StartAngle,
                (float)checked((int)Math.Round((double)(checked(Supreme_SweepAngle * Value)) / Maximum)));


        }


        #endregion

        #region Overrides

        private void SP_OnPaint(PaintEventArgs e)
        {
            switch (Supreme_Type)
            {
                case Supreme_type.Pie:
                    PaintSupremePie(e);
                    break;
                case Supreme_type.Circle:
                    PaintProgressBar(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
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
            if (this.SP_Angle + 1 > 360 && this.SP_Angle <-360)
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
