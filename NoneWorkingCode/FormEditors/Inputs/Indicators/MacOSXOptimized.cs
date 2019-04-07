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


        #region Members

        private int MacOSX_Optimized_m_Interval = 60;
        float MacOSX_Optimized_m_StartAngle = 30;
        float MacOSX_Optimized_m_AngleIncrement = 0;
        MacOSX_Direction MacOSX_Optimized_m_Rotation = MacOSX_Direction.CLOCKWISE;
        Color macOSX_Optimized_tick_Color = Color.FromArgb(58, 58, 58);

        int MacOSX_Optimized_m_SpokesCount = 12;
        private LineCap MacOSX_Optimized_startCap = LineCap.Round;
        private LineCap MacOSX_Optimized_endCap = LineCap.Round;


        #endregion

        #region Properties

        public LineCap MacOSX_Optimized_StartCap
        {
            get { return MacOSX_Optimized_startCap; }
            set
            {
                MacOSX_Optimized_startCap = value;
                
            }
        }

        public LineCap MacOSX_Optimized_EndCap
        {
            get { return MacOSX_Optimized_endCap; }
            set
            {
                MacOSX_Optimized_endCap = value;
                
            }
        }

        public int MacOSX_Optimized_SpokesCount
        {
            get { return MacOSX_Optimized_m_SpokesCount; }
            set
            {
                MacOSX_Optimized_m_SpokesCount = value;
                
            }
        }

        public int MacOSX_Optimized_Interval
        {
            get
            {
                return MacOSX_Optimized_m_Interval;
            }
            set
            {
                MacOSX_Optimized_m_Interval = value;


            }
        }

        public Color MacOSX_Optimized_TickColor
        {
            get { return macOSX_Optimized_tick_Color; }
            set
            {
                macOSX_Optimized_tick_Color = value;
            }
        }

        public MacOSX_Direction MacOSX_Optimized_Rotation
        {
            get
            {
                return MacOSX_Optimized_m_Rotation;
            }
            set
            {
                MacOSX_Optimized_m_Rotation = value;
                

                
            }
        }

        public float MacOSX_Optimized_StartAngle
        {
            get
            {
                return MacOSX_Optimized_m_StartAngle;
            }
            set
            {
                MacOSX_Optimized_m_StartAngle = value;
                
            }
        }

        #endregion

    }
}
