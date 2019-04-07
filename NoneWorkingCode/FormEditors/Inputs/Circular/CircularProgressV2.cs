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


        #region Private Field

        private int CPv2_progressWidth = 2;
        private int CPv2_shift = 0;
        int CPv2_remainderAngle = 0;
        int CPv2_startAngle = 80;
        private bool CPv2_showText = true;
        private Color CPv2_progressColor = Color.LightSeaGreen;
        private Color CPv2_progressEmptyColor = Color.LightGray;


        #endregion

        #region Public Properties
        
        public Color CPv2_Color
        {
            get { return CPv2_progressColor; }
            set
            {
                CPv2_progressColor = value;
                
            }
        }
        
        public Color CPv2_ColorEmpty
        {
            get { return CPv2_progressEmptyColor; }
            set
            {
                CPv2_progressEmptyColor = value;
                
            }
        }
        
        public bool CPv2_ShowText
        {
            get { return CPv2_showText; }
            set
            {
                CPv2_showText = value;
                
            }
        }
        
        public int CPv2_StartAngle
        {
            get { return CPv2_startAngle; }
            set
            {
                CPv2_startAngle = value;
                
            }
        }
        
        public int CPv2_Shift
        {
            get { return CPv2_shift; }
            set
            {
                CPv2_shift = value;
                
            }
        }
        
        public int CPv2_ProgressWidth
        {
            get { return CPv2_progressWidth; }
            set
            {
                CPv2_progressWidth = value;
                
            }
        }

        #endregion

    }
}
