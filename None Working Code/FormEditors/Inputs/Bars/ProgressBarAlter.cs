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

        #region  Private Fields
        private Color colorBack = Color.FromArgb(210, 210, 210);
        private Color colorBorder = Color.FromArgb(150, 150, 150);
        private Color colorText = Color.FromArgb(100, 100, 100);
        private Color colorInside = Color.FromArgb(200, 200, 200);
        private Color colorIC = Color.FromArgb(215, 215, 215);
        private Color color1 = Color.FromArgb(220, 220, 220);
        private Color color2 = Color.FromArgb(200, 200, 200);

        private float colorAngle = 90F;
        
        private bool _ShowValue = false;

        private Orientation _Orientation = System.Windows.Forms.Orientation.Horizontal;

        #endregion

        #region Properties

        
        public Color ProgressAlter_ColorBack
        {
            get { return colorBack; }
            set
            {
                colorBack = value;
                
            }
        }

        
        public Color ProgressAlter_ColorBorder
        {
            get { return colorBorder; }
            set
            {
                colorBorder = value;
                
            }
        }

        
        public Color ProgressAlter_ColorText
        {
            get { return colorText; }
            set
            {
                colorText = value;
                
            }
        }

        
        public Color ProgressAlter_ColorInside
        {
            get { return colorInside; }
            set
            {
                colorInside = value;
                
            }
        }

        
        public Color ProgressAlter_ColorIC
        {
            get { return colorIC; }
            set
            {
                colorIC = value;
                
            }
        }

        
        public Color ProgressAlter_Color1
        {
            get { return color1; }
            set
            {
                color1 = value;
                
            }
        }

        
        public Color Color2
        {
            get { return color2; }
            set
            {
                color2 = value;
                
            }
        }

        
        public float ProgressAlter_ColorAngle
        {
            get { return colorAngle; }
            set
            {
                colorAngle = value;
                
            }
        }

        
        public Orientation ProgressAlter_Orientation
        {
            get { return _Orientation; }
            set
            {
                _Orientation = value;
                
            }
        }


        
        public bool ShowValue
        {
            get { return _ShowValue; }
            set
            {
                _ShowValue = value;
                
            }
        }

        #endregion

    }
}
