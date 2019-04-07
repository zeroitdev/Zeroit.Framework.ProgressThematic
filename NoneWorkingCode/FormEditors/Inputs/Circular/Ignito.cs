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


        private float Ignito_outerborder = 1;

        private float Ignito_innerborder = 1;

        Color[] Ignito_colors = new Color[]
        {
            Color.Orange,
            Color.FromArgb(152, 212, 204),
            Color.Gray,
            Color.Black,
            Color.DarkSlateGray,
            Color.LightGray,
            Color.DimGray,
            Color.Black,
            Color.Green,
            Color.LightGray,
            Color.Gray,
            Color.LightGray,
        };

        private bool Ignito_enableHatch = false;

        private LineCap Ignito_cap = LineCap.Round;

        private Ignito_innerRotatingAngle Ignito_innerRotaAngle = Ignito_innerRotatingAngle.AntiClockwise;

        private Ignito_outterRotatingAngle Ignito_outterRotaAngle = Ignito_outterRotatingAngle.Clockwise;

        private Ignito_drawMode ignito_drawMode = Ignito_drawMode.Solid;

        private DashStyle Ignito_borderStyleouter = DashStyle.DashDot;

        private DashStyle Ignito_borderStyleInner = DashStyle.DashDot;
        

        #endregion

        #region Public Properties
        
        public Ignito_innerRotatingAngle IG_InnerRotatingAnlge
        {
            get { return Ignito_innerRotaAngle; }
            set
            {
                Ignito_innerRotaAngle = value;
                
            }
        }

        
        public Ignito_outterRotatingAngle IG_OutterRotatingAngle
        {
            get { return Ignito_outterRotaAngle; }
            set
            {
                Ignito_outterRotaAngle = value;
                
            }
        }

        
        public float IG_OuterBorder
        {
            get { return Ignito_outerborder; }
            set
            {
                Ignito_outerborder = value;
                
            }
        }

        
        public float IG_InnerBorder
        {
            get { return Ignito_innerborder; }
            set
            {
                Ignito_innerborder = value;
                
            }
        }

        
        public LineCap IG_Caps
        {
            get { return Ignito_cap; }
            set
            {
                Ignito_cap = value;
                
            }
        }

        
        public DashStyle IG_BorderStyleOuter
        {
            get { return Ignito_borderStyleouter; }
            set
            {
                Ignito_borderStyleouter = value;
                
            }
        }

        
        public DashStyle IG_BorderStyleInner
        {
            get { return Ignito_borderStyleInner; }
            set
            {
                Ignito_borderStyleInner = value;
                
            }
        }

        
        public Color[] IG_Colors
        {
            get { return Ignito_colors; }
            set
            {
                Ignito_colors = value;
                
            }
        }

        
        public bool IG_EnableHatch
        {
            get { return Ignito_enableHatch; }
            set
            {
                Ignito_enableHatch = value;
                
            }
        }

        
        
        public Ignito_drawMode IG_DrawMode
        {
            get { return ignito_drawMode; }
            set
            {
                ignito_drawMode = value;
                
            }
        }

        
        #endregion

    }
}
