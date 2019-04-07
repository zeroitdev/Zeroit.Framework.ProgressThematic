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

        private int CPv3_progressWidth = 2;
        private int CPv3_shift = 0;
        int CPv3_remainderAngle = 0;
        int CPv3_startangle = -90;
        private bool CPv3_showText = true;
        private Color CPv3_progressColor = Color.LightSeaGreen;
        private Color CPv3_progressEmptyColor = Color.LightGray;

        #endregion


        #region Public Properties
        
        public Color CPv3_Color
        {
            get { return CPv3_progressColor; }
            set
            {
                CPv3_progressColor = value;
                
            }
        }

        
        public Color CPv3_ColorEmpty
        {
            get { return CPv3_progressEmptyColor; }
            set
            {
                CPv3_progressEmptyColor = value;
                
            }
        }

        
        public bool CPv3_ShowText
        {
            get { return CPv3_showText; }
            set
            {
                CPv3_showText = value;
                
            }
        }

        
        public int CPv3_StartAngle
        {
            get { return CPv3_startangle; }
            set
            {
                CPv3_startangle = value;
                
            }
        }


        
        public int CPv3_Shift
        {
            get { return CPv3_shift; }
            set
            {
                CPv3_shift = value;
                
            }
        }

        
        public int CPv3_ProgressWidth
        {
            get { return CPv3_progressWidth; }
            set
            {
                CPv3_progressWidth = value;
                
            }
        }

        #endregion

    }
}
