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
        private int CPv4_startAngle = -90;
        private int CPv4_thickness = 20;
        private float CPv4_gradAngle = 90f;
        private LineCap CPv4_startCap = LineCap.Round;
        private LineCap CPv4_endCap = LineCap.Round;
        private Color CPv4_innerBorder = Color.Black;
        private Color CPv4_outerBorder = Color.Black;
        private Color CPv4_progGrad1 = Color.DarkSlateGray;
        private Color CPv4_progGrad2 = Color.Orange;
        private Color CPv4_progBackGrad1 = Color.White;
        private Color CPv4_progBackGrad2 = Color.White;
        private int CPv4_speed = 100;



        #endregion


        #region Public Properties

        
        public int CPv4_Speed
        {
            get { return CPv4_speed; }
            set
            {
                CPv4_speed = value;
                
            }
        }

        
        public float CPv4_GradientAngle
        {
            get { return CPv4_gradAngle; }
            set
            {
                CPv4_gradAngle = value;
                
            }
        }

        
        public Color CPv4_ProgressBackGrad1
        {
            get { return CPv4_progBackGrad1; }
            set
            {
                CPv4_progBackGrad1 = value;
                
            }
        }

        
        public Color CPv4_ProgressBackGrad2
        {
            get { return CPv4_progBackGrad2; }
            set
            {
                CPv4_progBackGrad2 = value;
                
            }
        }

        
        public Color CPv4_ProgressGrad1
        {
            get { return CPv4_progGrad1; }
            set
            {
                CPv4_progGrad1 = value;
                
            }
        }

        
        public Color CPv4_ProgressGrad2
        {
            get { return CPv4_progGrad2; }
            set
            {
                CPv4_progGrad2 = value;
                
            }
        }

        
        public Color CPv4_InnerBorder
        {
            get { return CPv4_innerBorder; }
            set
            {
                CPv4_innerBorder = value;
                
            }
        }

        
        public Color CPv4_OuterBorder
        {
            get { return CPv4_outerBorder; }
            set
            {
                CPv4_outerBorder = value;
                
            }
        }

        
        
        public int CPv4_Thickness
        {
            get { return CPv4_thickness; }
            set
            {
                CPv4_thickness = value;
                
            }
        }

        
        public int CPv4_StartAngle
        {
            get { return CPv4_startAngle; }
            set
            {
                CPv4_startAngle = value;
                
            }
        }

        
        public LineCap CPv4_StartCap
        {
            get { return CPv4_startCap; }
            set
            {
                CPv4_startCap = value;
                
            }
        }

        
        public LineCap CPv4_EndCap
        {
            get { return CPv4_endCap; }
            set
            {
                CPv4_endCap = value;
                
            }
        }
        #endregion

    }
}
