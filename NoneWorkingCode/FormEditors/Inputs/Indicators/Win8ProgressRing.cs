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

        int WinRing_control_height = 100;
        Color WinRing_indicator_color = Color.White;
        int WinRing_refresh_rate = (int)100.0;
        bool winRing_Animate = false; 

        #endregion

        #region Public Properties

        public bool WinRing_Animate
        {

            get
            {
                return winRing_Animate;
            }

            set
            {
                winRing_Animate = value;
            }
        }

        
        public int Control_Height
        {

            get
            {
                return (WinRing_control_height);
            }
            set
            {
                
                WinRing_control_height = value;
                
            }
        }

       
        public Color WinRing_Indicator_Color
        {

            get
            {
                return (WinRing_indicator_color);
            }
            set
            {
                
                WinRing_indicator_color = value;
                
            }
        }

        
        public int WinRing_Refresh_Rate
        {

            get
            {
                return (WinRing_refresh_rate);
            }

            set
            {
                
                WinRing_refresh_rate = value;
                
            }
        }
        #endregion


    }
}
