using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Zeroit.Framework.ProgressThematic.ThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {


        #region Variables


        private Color ProgressPie_progressColor1 = Color.DarkSlateGray;
        private Color ProgressPie_progressColor2 = Color.DarkOrange;
        private Color ProgressPie_fillEllipse1 = Color.Transparent;
        private Color ProgressPie_fillEllipse2 = Color.Transparent;
        private Color ProgressPie_textColor = Color.Transparent;
        private Color ProgressPie_progressColorInnerBorder = Color.Transparent;
        private ProgressPie_ProgressShape ProgressPie_progressShapeVal = ProgressPie_ProgressShape.Round;
        private LineCap ProgressPie_start = LineCap.Flat;
        private LineCap ProgressPie_end = LineCap.Flat;
        private Double ProgressPie_progressWidth = 1f;
        private float ProgressPie_penWidth = 1f;
        //private float ProgressPie_progressWidthToFloat;
        private bool ProgressPie_showText = true;
        private float ProgressPie_position = 180.0f;
        private float ProgressPie_sweepAngle = 180.0f;

        #endregion

        #region Custom Properties
        
        public float ProgressPie_Position
        {
            get { return ProgressPie_position; }
            set
            {
                ProgressPie_position = value;
                
            }
        }
        
        public float ProgressPie_SweepAngle
        {
            get { return ProgressPie_sweepAngle; }
            set
            {
                ProgressPie_sweepAngle = value;
                
            }
        }
        
        public Boolean ProgressPie_ShowText
        {
            get { return ProgressPie_showText; }
            set
            {
                if (value == false)
                {
                    ProgressPie_textColor = Color.Transparent;
                }

                else
                {
                    ProgressPie_textColor = Color.White;
                }
                ProgressPie_showText = value;
                
            }
        }
        
        public float ProgressPie_InnerBorderWidth
        {
            get { return ProgressPie_penWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                ProgressPie_penWidth = value;
                
            }
        }
        
        public Color ProgressPie_InnerBorderColor
        {
            get { return ProgressPie_progressColorInnerBorder; }
            set
            {
                ProgressPie_progressColorInnerBorder = value;
                
            }
        }
        
        public Color ProgressPie_TextColor
        {
            get { return ProgressPie_textColor; }
            set
            {
                ProgressPie_textColor = value;
                
            }
        }

        public LineCap ProgressPie_WidthStartCap
        {
            get { return ProgressPie_start; }
            set
            {
                if (ProgressPie_start == null)
                {
                    ProgressPie_start = LineCap.Flat;
                }
                ProgressPie_start = value;
                
            }
        }
        
        public LineCap ProgressPie_WidthEndCap
        {
            get { return ProgressPie_end; }
            set
            {
                if (ProgressPie_end == null)
                {
                    ProgressPie_end = LineCap.Flat;
                }
                ProgressPie_end = value;
                
            }
        }
        
        public Double ProgressPie_ProgressWidth
        {
            get { return ProgressPie_progressWidth; }
            set
            {
                if (ProgressPie_progressWidth == null)
                {
                    ProgressPie_progressWidth = 5f;
                }

                ProgressPie_progressWidth = value;
                //ProgressPie_progressWidthToFloat = ProgressPie_DoubleToFloat(ProgressPie_progressWidth);

                
            }
        }
        
        public Color ProgressPie_ProgressColor1
        {
            get { return ProgressPie_progressColor1; }
            set
            {
                ProgressPie_progressColor1 = value;
                
            }
        }
        
        public Color ProgressPie_ProgressColor2
        {
            get { return ProgressPie_progressColor2; }
            set
            {
                ProgressPie_progressColor2 = value;
                
            }
        }
        
        public Color ProgressPie_FillEllipse1
        {
            get { return ProgressPie_fillEllipse1; }
            set
            {
                ProgressPie_fillEllipse1 = value;
                
            }
        }
        
        public Color ProgressPie_FillEllipse2
        {
            get { return ProgressPie_fillEllipse2; }
            set
            {
                ProgressPie_fillEllipse2 = value;
                
            }
        }

        public ProgressPie_ProgressShape ProgressPie__ProgressShape
        {
            get { return ProgressPie_progressShapeVal; }
            set
            {
                ProgressPie_progressShapeVal = value;
                
            }
        }

        #endregion


    }
}
