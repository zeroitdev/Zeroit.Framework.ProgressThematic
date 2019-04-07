using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        private Color Perplex_colorGradient1 = Color.FromArgb(26, 26, 26);
        private Color Perplex_colorGradient2 = Color.FromArgb(30, 30, 30);
        private Color Perplex_colorGradient3 = Color.FromArgb(174, 195, 30);
        private Color Perplex_colorGradient4 = Color.FromArgb(141, 153, 16);
        private Color colorPen = Color.FromArgb(97, 94, 90);
        private float colorGradientAngle = 90f;
        private bool _ShowPercentage = false;
        private perplex_DrawMode _perplex_DrawMode = perplex_DrawMode.Gradient;


        #endregion

        #region Properties

        [Category("RectangularProgress Perplex")]
        public perplex_DrawMode Perplex_DrawMode
        {
            get { return _perplex_DrawMode; }
            set
            {
                _perplex_DrawMode = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient1
        {
            get { return Perplex_colorGradient1; }
            set
            {
                Perplex_colorGradient1 = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient2
        {
            get { return Perplex_colorGradient2; }
            set
            {
                Perplex_colorGradient2 = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient3
        {
            get { return Perplex_colorGradient3; }
            set
            {
                Perplex_colorGradient3 = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public Color Perplex_ColorGradient4
        {
            get { return Perplex_colorGradient4; }
            set
            {
                Perplex_colorGradient4 = value;
                
            }
        }

        //public Color ColorHatchBrush1
        //{
        //    get { return hatchBrushgradient1; }
        //    set
        //    {
        //        hatchBrushgradient1 = value;
        //        
        //    }
        //}

        //public Color ColorHatchBrush2
        //{
        //    get { return hatchBrushgradient2; }
        //    set
        //    {
        //        hatchBrushgradient2 = value;
        //        
        //    }
        //}
        [Category("RectangularProgress Perplex")]
        public Color Perplex_BorderColor
        {
            get { return colorPen; }
            set
            {
                colorPen = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public float ColorGradientAngle
        {
            get { return colorGradientAngle; }
            set
            {
                colorGradientAngle = value;
                
            }
        }

        [Category("RectangularProgress Perplex")]
        public bool Perplex_ShowPercentage
        {
            get { return _ShowPercentage; }
            set
            {
                _ShowPercentage = value;
                
            }
        }

        #endregion

    }
}
