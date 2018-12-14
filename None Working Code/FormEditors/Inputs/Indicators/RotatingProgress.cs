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

        private float Vuvuzela_angle = 90f;
        private int Vuvuzela_interval = 10;
        private bool Vuvuzela_rotatingBorder = false;
        private Vuvuzela_Shape Vuvuzela_shape = Vuvuzela_Shape.Arc;
        private int Vuvuzela_size = 20;
        private bool Vuvuzela_fillPie = false;
        private Color Vuvuzela_rotatingCircle = Color.Red;
        private Color Vuvuzela_circle1 = Color.Black;
        private Color Vuvuzela_circle2 = Color.Green;
        private Color Vuvuzela_circle3 = Color.Brown;
        private Color Vuvuzela_circle4 = Color.Green;
        private Color Vuvuzela_circle5 = Color.Blue;
        private int Vuvuzela_circleSize = 1;


        //Graphics g;
        #endregion

        #region Public Properties
        
        public int Vuvuzela_CircleSize
        {
            get { return Vuvuzela_circleSize; }
            set
            {
                Vuvuzela_circleSize = value;
                
            }
        }

        
        public Color Vuvuzela_Circle1
        {
            get { return Vuvuzela_circle1; }
            set
            {
                Vuvuzela_circle1 = value;
                
            }
        }

        
        public Color Vuvuzela_Circle2
        {
            get { return Vuvuzela_circle2; }
            set
            {
                Vuvuzela_circle2 = value;
                
            }
        }

        
        public Color Vuvuzela_Circle3
        {
            get { return Vuvuzela_circle3; }
            set
            {
                Vuvuzela_circle3 = value;
                
            }
        }

        
        public Color Vuvuzela_Circle4
        {
            get { return Vuvuzela_circle4; }
            set
            {
                Vuvuzela_circle4 = value;
                
            }
        }

        
        public Color Vuvuzela_Circle5
        {
            get { return Vuvuzela_circle5; }
            set
            {
                Vuvuzela_circle5 = value;
                
            }
        }

        
        public Color Vuvuzela_RotatingCircle
        {
            get { return Vuvuzela_rotatingCircle; }
            set
            {
                Vuvuzela_rotatingCircle = value;
                
            }
        }

        
        public bool Vuvuzela_FillPie
        {
            get { return Vuvuzela_fillPie; }
            set
            {
                Vuvuzela_fillPie = value;
                
            }
        }

        
        public int ControlSize
        {
            get { return Vuvuzela_size; }
            set
            {
                Vuvuzela_size = value;
                
            }
        }

        
        public Vuvuzela_Shape Shape
        {
            get { return Vuvuzela_shape; }
            set
            {
                Vuvuzela_shape = value;
                
            }
        }

        
        public bool Vuvuzela_RotatingBorder
        {
            get { return Vuvuzela_rotatingBorder; }
            set
            {
                Vuvuzela_rotatingBorder = value;
                
            }
        }

        
        public float Vuvuzela_Angle
        {
            get { return Vuvuzela_angle; }
            set
            {
                Vuvuzela_angle = value;
                //
            }
        }


        #endregion
    }
}
