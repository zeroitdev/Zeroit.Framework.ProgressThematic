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

        #region Public Properties

        
        public Color RotatingCompass_PieColor1
        {
            get { return pieColor1; }
            set
            {
                pieColor1 = value;
                
            }
        }

        
        public Color RotatingCompass_PieColor2
        {
            get { return pieColor2; }
            set
            {
                pieColor2 = value;
                
            }
        }

        
        public Color RotatingCompass_LineColor1
        {
            get { return lineColor1; }
            set
            {
                lineColor1 = value;
                
            }
        }

        
        public Color RotatingCompass_LineColor2
        {
            get { return lineColor2; }
            set
            {
                lineColor2 = value;
                
            }
        }

        
        public bool RotatingCompass_FillPie
        {
            get { return fillPie; }
            set
            {
                fillPie = value;
                
            }
        }

        
        public int RotatingCompass_LineSize
        {
            get { return size; }
            set
            {
                size = value;
                
            }
        }

        
        public bool RotatingCompass_RotatingBorder
        {
            get { return rotatingBorder; }
            set
            {
                rotatingBorder = value;
                
            }
        }

        
        public float RotatingCompass_Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                //
            }
        }



        #endregion

    }
}
