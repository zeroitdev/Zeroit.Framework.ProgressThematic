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
        //private float ProgressRect_percent;
        private Color ProgressRect_valueColour = Color.FromArgb(42, 119, 220);
        private Color ProgressRect_colorBackground = Color.FromArgb(51, 52, 55);
        private Color ProgressRect_colorBorder = Color.FromArgb(51, 52, 55);
        private int ProgressRect_corner = 8;
        #endregion

        #region  Custom Properties

        
        public int ProgressRect_Corner
        {
            get { return ProgressRect_corner; }
            set
            {
                ProgressRect_corner = value;
                
            }
        }

        
        public Color ProgressRect_ValueColour
        {
            get
            {
                return ProgressRect_valueColour;
            }
            set
            {
                ProgressRect_valueColour = value;
                
            }
        }

        
        public Color ProgressRect_ColorBackground
        {
            get { return ProgressRect_colorBackground; }
            set
            {
                ProgressRect_colorBackground = value;
                
            }
        }

        
        public Color ProgressRect_ColorBorder
        {
            get { return ProgressRect_colorBorder; }
            set
            {
                ProgressRect_colorBorder = value;
                
            }
        }

        #endregion


    }
}
