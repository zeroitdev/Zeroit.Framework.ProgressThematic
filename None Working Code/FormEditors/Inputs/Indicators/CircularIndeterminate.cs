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
        
        
        private Color background_color = SystemColors.Control;
        private int circles_count = 5;
        private Color control_color = SystemColors.Control;
        private int control_width_height = 150;
        private float indicator_angle = 0.0F;
        private float indicator_angular_advance = 0.7F;
        private Color indicator_color = Color.Black;
        private int indicator_diameter = 8;
        private INDICATORTYPES indicator_type = INDICATORTYPES.ANIMATED;
        private int refresh_rate = 100;
        private bool indeterminate_Animate = true;
        
        #endregion


        #region Public Properties
        // *************************************************** Animate

        public bool Animate
        {

            get { return indeterminate_Animate; }
            set
            {
                indeterminate_Animate = value;
            }
        }

        // ******************************************* BackgroundColor

        public Color BackgroundColor
        {

            get
            {
                return (background_color);
            }

            set
            {
                background_color = value;

                
            }
        }

        // ********************************************** CirclesCount

        public int CirclesCount
        {
            get
            {
                return (circles_count);
            }
            set
            {
                circles_count = value;
                
            }
        }

        // **************************************** ControlWidthHeight

        public int ControlWidthHeight
        {

            get
            {
                return (control_width_height);
            }

            set
            {
                control_width_height = value;
                
            }
        }

        // ******************************************** IndicatorColor

        public Color IndicatorColor
        {

            get
            {
                return (indicator_color);
            }

            set
            {
                indicator_color = value;

                
            }
        }

        
        public int IndicatorDiameter
        {

            get
            {
                return (indicator_diameter);
            }

            set
            {
                indicator_diameter = value;
                
            }
        }

        // ********************************************* IndicatorType

        public INDICATORTYPES IndicatorType
        {

            get
            {
                return (indicator_type);
            }

            set
            {
                indicator_type = value;

                
            }
        }

        // *********************************************** RefreshRate
        public int RefreshRate
        {

            get
            {
                return (refresh_rate);
            }

            set
            {
                refresh_rate = value;
                
            }
        }
        
        #endregion

    }
}
