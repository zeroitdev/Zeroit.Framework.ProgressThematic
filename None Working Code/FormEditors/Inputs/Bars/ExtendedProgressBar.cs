using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        #region Private Field

        //private System.ComponentModel.Container components = null;
        private ProgressBarEdge m_Edge = ProgressBarEdge.Rounded;
        private Color m_EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        private Color m_EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        private int m_EdgeWidth = 1;
        private ProgressFloodStyle m_FloodStyle = ProgressFloodStyle.Standard;
        private float m_float_BarFlood = 0.20f;
        private int m_int_BarOffset = 1;
        private int m_int_DashWidth = 5;
        private int m_int_DashSpace = 2;
        private ProgressStyle m_Style = ProgressStyle.Dashed;
        private Color m_Color1 = Color.FromArgb(0, 255, 0);
        private Color m_Color2 = Color.FromKnownColor(KnownColor.White);
        private Color m_color_Back = Color.FromKnownColor(KnownColor.White);
        private int m_int_Step = 1;
        private bool m_bool_Shadow = true;
        private int m_int_ShadowOffset = 1;
        private bool m_bool_Antialias = true;
        private Color m_color_Shadow = Color.FromKnownColor(KnownColor.White);
        private Color m_color_Caption = Color.FromKnownColor(KnownColor.Black);
        private ProgressCaptionMode m_CaptionMode = ProgressCaptionMode.Percent;
        private String m_str_Caption = "Progress";
        private bool m_bool_ChangeByMouse = false;
        private bool m_bool_Invert = false;
        private ProgressBarDirection m_Direction = ProgressBarDirection.Horizontal;

        #endregion


        #region Direction
        
        public bool Invert
        {
            get
            {
                return m_bool_Invert;
            }
            set
            {
                m_bool_Invert = value;
                
            }
        }
        
        public ProgressBarDirection Orientation
        {
            get
            {
                return m_Direction;
            }
            set
            {
                m_Direction = value;
                
            }
        }
        #endregion

        #region Edge
        
        public ProgressBarEdge Edge
        {
            get
            {
                return m_Edge;
            }
            set
            {
                m_Edge = value;
                
            }
        }

        
        public Color EdgeColor
        {
            get
            {
                return m_EdgeColor;
            }
            set
            {
                m_EdgeColor = value;
                
            }
        }
        

        public Color EdgeLightColor
        {
            get
            {
                return m_EdgeLightColor;
            }
            set
            {
                m_EdgeLightColor = value;
                
            }
        }
        
        public int EdgeWidth
        {
            get
            {
                return m_EdgeWidth;
            }
            set
            {
                m_EdgeWidth = value;
                
            }
        }
        
        #endregion

        #region Progress
        
        public ProgressFloodStyle FloodStyle
        {
            get
            {
                return m_FloodStyle;
            }
            set
            {
                m_FloodStyle = value;
                
            }
        }
        
        public float FloodPercentage
        {
            get
            {
                return m_float_BarFlood;
            }
            set
            {
                m_float_BarFlood = value;
                
            }
        }
        
        public int BarOffset
        {
            get
            {
                return m_int_BarOffset;
            }
            set
            {
                m_int_BarOffset = value;
                
            }
        }
        
        public int DashWidth
        {
            get
            {
                return m_int_DashWidth;
            }
            set
            {
                m_int_DashWidth = value;
                
            }
        }
        
        public int DashSpace
        {
            get
            {
                return m_int_DashSpace;
            }
            set
            {
                m_int_DashSpace = value;
                
            }
        }
        
        public ProgressStyle ProgressBarStyle
        {
            get
            {
                return m_Style;
            }
            set
            {
                m_Style = value;
                
            }
        }
        
        public Color MainColor
        {
            get
            {
                return m_Color1;
            }
            set
            {
                m_Color1 = value;
                
            }
        }
        
        public Color SecondColor
        {
            get
            {
                return m_Color2;
            }
            set
            {
                m_Color2 = value;
                
            }
        }
        
        public Color ProgressBackColor
        {
            get
            {
                return m_color_Back;
            }
            set
            {
                m_color_Back = value;
                
            }
        }
        //#####
        #endregion

        
        public int ExtendedProgress_Step
        {
            get
            {
                return m_int_Step;
            }
            set
            {
                m_int_Step = value;
                
            }
        }


        #region Caption
        
        
        public bool ExtendedProgress_Shadow
        {
            get
            {
                return m_bool_Shadow;
            }
            set
            {
                m_bool_Shadow = value;
                
            }
        }
        //#####
        
        public int ShadowOffset
        {
            get
            {
                return m_int_ShadowOffset;
            }
            set
            {
                m_int_ShadowOffset = value;
                
            }
        }
        //#####
        
        public bool TextAntialias
        {
            get
            {
                return m_bool_Antialias;
            }
            set
            {
                m_bool_Antialias = value;
                
            }
        }
        //#####
        
        public Color CaptionShadowColor
        {
            get
            {
                return m_color_Shadow;
            }
            set
            {
                m_color_Shadow = value;
                
            }
        }
        //#####
        
        public Color CaptionColor
        {
            get
            {
                return m_color_Caption;
            }
            set
            {
                m_color_Caption = value;
                
            }
        }
        //#####
        
        public ProgressCaptionMode CaptionMode
        {
            get
            {
                return m_CaptionMode;
            }
            set
            {
                m_CaptionMode = value;
                
            }
        }
        //#####
        
        public String Caption
        {
            get
            {
                return m_str_Caption;
            }
            set
            {
                m_str_Caption = value;
                
            }
        }
        //#####
        #endregion

        #region Custom
        //#####
        
        public bool ChangeByMouse
        {
            get
            {
                return m_bool_ChangeByMouse;
            }
            set
            {
                m_bool_ChangeByMouse = value;
                
            }
        }
        
        #endregion
    }
}
