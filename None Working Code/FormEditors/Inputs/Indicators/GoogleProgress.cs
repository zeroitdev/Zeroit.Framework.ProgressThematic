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

        #region Fields
        private Color GoogleProgress_annulus_color = Color.PaleTurquoise;
        //private int GoogleProgress_annulus_thickness;
        private Color GoogleProgress_background_color = SystemColors.Control;
        private int GoogleProgress_indicator_angle = 0;
        private int GoogleProgress_indicator_angular_advance = 10;
        private Color GoogleProgress_indicator_color = Color.White;
        private GoogleProgress_INDICATORTYPES GoogleProgress_indicator_type =
            GoogleProgress_INDICATORTYPES.ANIMATED;
        private int inner_radius = 20;
        private int outer_radius/* = 84*/ = 24;
        private int GoogleProgress_refresh_rate = 100;
        private float GoogleProgress_angle = 90;
        private Color transition_color = Color.Gray;
        private Color color1bigcircle = Color.Red;
        private Color color2bigcircle = Color.Yellow;
        private Color color1indicator = Color.Gray;
        private Color color2indicator = Color.DarkBlue;
        private Color inner_color = Color.DarkBlue;
        private int inner_border = 1;
        
        #endregion


        #region Public Properties

        // ********************************************* GoogleProgress_Pulse method


        public int InnerBorder
        {
            get { return inner_border; }
            set
            {
                inner_border = value;

                
            }
        }

        
        public Color ColorInnerBorder
        {
            get { return inner_color; }
            set
            {
                inner_color = value;

                
            }
        }

        
        public Color Color1Bigcircle
        {
            get { return color1bigcircle; }
            set
            {
                color1bigcircle = value;

                
            }
        }
       
        public Color Color2Bigcircle
        {
            get { return color2bigcircle; }
            set
            {
                color2bigcircle = value;
                
            }
        }

        
        public Color Color1Indicator
        {
            get { return color1indicator; }
            set
            {
                color1indicator = value;


                
            }
        }

        
        public Color Color2Indicator
        {
            get { return color2indicator; }
            set
            {
                color2indicator = value;

                
            }
        }

        
        public float ColorAngle
        {
            get { return GoogleProgress_angle; }
            set
            {
                GoogleProgress_angle = value;

                
            }
        }
        

        public Color AnnulusColor
        {
            get
            {
                return (GoogleProgress_annulus_color);
            }

            set
            {
                GoogleProgress_annulus_color = value;

                
            }
        }

        // ********************************* GoogleProgress_BackgroundColor property

        public Color GoogleProgress_BackgroundColor
        {

            get
            {
                return (GoogleProgress_background_color);
            }

            set
            {
                GoogleProgress_background_color = value;

                
                
            }
        }


        // ********************************** IndicatorAngularAdvance

        public int IndicatorAngularAdvance
        {

            get
            {
                return (GoogleProgress_indicator_angular_advance);
            }

            set
            {
                GoogleProgress_indicator_angular_advance = value;

                
            }
        }

        // ********************************** GoogleProgress_IndicatorColor property

        public Color GoogleProgress_IndicatorColor
        {

            get
            {
                return (GoogleProgress_indicator_color);
            }

            set
            {
                GoogleProgress_indicator_color = value;

                
            }
        }

        // ******************************************** GoogleProgress_IndicatorType

        public GoogleProgress_INDICATORTYPES GoogleProgress_IndicatorType
        {

            get
            {
                return (GoogleProgress_indicator_type);
            }

            set
            {
                GoogleProgress_indicator_type = value;

                
                
            }
        }

        // ************************************* InnerRadius property

        public int InnerRadius
        {

            get
            {
                return (inner_radius);
            }

            set
            {
                inner_radius = value;
                
            }
        }

        // ************************************* OuterRadius property

        public int OuterRadius
        {

            get
            {
                return (outer_radius);
            }

            set
            {
                outer_radius = value;
                
            }
        }

        // ************************************* GoogleProgress_RefreshRate property


        
        public int GoogleProgress_RefreshRate
        {

            get
            {
                return (GoogleProgress_refresh_rate);
            }

            set
            {


                GoogleProgress_refresh_rate = value;

                
            }
        }

        // ********************************* TransitionColor property

        public Color TransitionColor
        {

            get
            {
                return (transition_color);
            }

            set
            {
                transition_color = value;
                
            }
        }

        // *********************************** create_annulus_graphic 
        #endregion


    }
}
