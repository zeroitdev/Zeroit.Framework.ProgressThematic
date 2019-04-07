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


        #region Private Fields

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

        #endregion

        #region Public Properties


        
        public Color SP_ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                
            }
        }

        
        public Color SP_OuterColor
        {
            get { return outerColor; }
            set
            {
                outerColor = value;
                
            }
        }

        
        public Color SP_SolidColor
        {
            get { return solidColor; }
            set
            {
                solidColor = value;
                
            }
        }

        
        public Color[] SP_GradientColor
        {
            get { return gradientColor; }
            set
            {
                gradientColor = value;
                
            }
        }

        
        public Supreme_colorMode SP_ColorMode
        {
            get { return SP_colorMode; }
            set
            {
                SP_colorMode = value;
                
            }
        }

        
        public float SP_Angle
        {
            get
            {
                return SP_angle;

            }
            set
            {
                SP_angle = value;
                
            }
        }

        
        public int SP_OuterBorder
        {
            get { return outerborder; }
            set
            {
                outerborder = value;
                
            }
        }

        
        public int SP_InnerBorder
        {
            get { return innerborder; }
            set
            {
                innerborder = value;
                
            }
        }

        
        public LinearGradientMode SP_GradientMode
        {
            get { return linMode; }
            set
            {
                linMode = value;
                
            }
        }

        
        public Supreme_colorMode SP_DrawMode
        {
            get { return SP_colorMode; }
            set
            {
                SP_colorMode = value;
                
            }
        }

        #endregion

    }
}
