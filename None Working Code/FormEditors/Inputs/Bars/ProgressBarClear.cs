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


        private Color ProgressBarClear_glow = Color.FromArgb(230, 230, 230);
        private Color ProgressBarClear_edge = Color.FromArgb(170, 170, 170);
        private Color ProgressBarClear_gradient1 = Color.FromArgb(230, 230, 230);
        private Color ProgressBarClear_gradient2 = Color.FromArgb(210, 210, 210);
        private coloringMode _coloringMode = coloringMode.Hatch;
        //int GlowPosition;

        #endregion

        #region Properties

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGlow
        {
            get { return ProgressBarClear_glow; }
            set
            {
                ProgressBarClear_glow = value;
                
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorBorder
        {
            get { return ProgressBarClear_edge; }
            set
            {
                ProgressBarClear_edge = value;
                
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient1
        {
            get { return ProgressBarClear_gradient1; }
            set
            {
                ProgressBarClear_gradient1 = value;
                
            }
        }

        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient2
        {
            get { return ProgressBarClear_gradient2; }
            set
            {
                ProgressBarClear_gradient2 = value;
                
            }
        }

        [Category("RectangularProgress Clear")]
        public coloringMode Mode
        {
            get { return _coloringMode; }
            set
            {
                _coloringMode = value;
                
            }
        }

        

        #endregion


    }
}
