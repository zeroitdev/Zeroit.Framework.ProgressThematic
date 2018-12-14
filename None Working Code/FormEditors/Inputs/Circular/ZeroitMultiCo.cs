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

        private bool MC_showInnerBorder = true;
        private int MC_innerBorder = 2;
        private int MC_shift = 15;
        private int MC_correctShift = 6;
        private int MC_rectShift = 3;
        private Rings MC_noOfRings = Rings.One;
        Color[] MC_colors = new Color[]
        {
            Color.Red,
            Color.Yellow,
            Color.Green,
            Color.AliceBlue,
            Color.Brown,
            Color.Chocolate,
            Color.DarkOrange,
            Color.DarkRed,
            Color.DeepPink,
            Color.Indigo,
            Color.Ivory,
            Color.Lavender,
            Color.LightSeaGreen,
            Color.Maroon,
            Color.OrangeRed,
            Color.Orchid,
            Color.PaleGoldenrod,
            Color.PapayaWhip,
            Color.Teal,
            Color.Tomato,
            Color.YellowGreen,
            Color.Thistle,
            Color.Tan,
            Color.SlateGray,
        }; 

        #endregion

        #region Public Properties

        public Color[] MC_Colors
        {
            get { return MC_colors; }
            set
            {
                MC_colors = value;
                
            }
        }

        
        public Rings MC_NoOfRings
        {
            get { return MC_noOfRings; }
            set
            {
                MC_noOfRings = value;
                
            }
        }
        
        public bool MC_ShowInnerBorder
        {
            get { return MC_showInnerBorder; }
            set
            {
                MC_showInnerBorder = value;
                
            }
        }

        
        public int MC_InnerBorder
        {
            get { return MC_innerBorder; }
            set
            {
                MC_innerBorder = value;
                
            }
        }
        
        public int MC_CorrectShift
        {
            get { return MC_correctShift; }
            set
            {
                MC_correctShift = value;
                
            }
        }

        
        public int MC_Shift
        {
            get { return MC_shift; }
            set
            {
                MC_shift = value;
                
            }
        }

        
        public int MC_RectShift
        {
            get { return MC_rectShift; }
            set
            {
                MC_rectShift = value;
                
            }
        }


        #endregion


    }
}
