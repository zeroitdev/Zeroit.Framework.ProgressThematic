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

        int control_width = 462;
        Color WinHR_indicator_color = Color.White;
        int WinHR_refresh_rate = 100;
        double timer_interval = 100;
        bool winHR_Animate = false;

        #endregion

        #region Public Properties

        public bool WinHR_Animate
        {

            get
            {
                return (winHR_Animate);
            }

            set
            {
                winHR_Animate = value;
            }
        }


        public int Control_Width
        {

            get
            {
                return (control_width);
            }
            set
            {

                control_width = value;


            }
        }


        public Color Indicator_Color
        {

            get
            {
                return (WinHR_indicator_color);
            }
            set
            {

                WinHR_indicator_color = value;

            }
        }


        public int Refresh_Rate
        {

            get
            {
                return (WinHR_refresh_rate);
            }

            set
            {
                WinHR_refresh_rate = value;

            }
        } 

        #endregion

    }
}
