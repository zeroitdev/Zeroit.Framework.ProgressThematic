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

        private int MacOSX_m_Interval = 60;
        int MacOSX_m_InnerRadius = 0;
        int MacOSX_m_OuterRadius = 0;
        int MacOSX_m_StartAngle = 270;
        int MacOSX_m_AlphaStartValue = 0;
        int MacOSX_m_SpokesCount = 12;
        int MacOSX_m_AngleIncrement = 0;
        int MacOSX_m_AlphaDecrement = 0;
        private MacOSX_automatic _automatic = MacOSX_automatic.Start;
        private Color tick_Color = Color.FromArgb(58, 58, 58);
        MacOSX_Direction macOSX_Rotation = MacOSX_Direction.CLOCKWISE;

        private LineCap MacOSX_startCap = LineCap.Round;
        private LineCap MacOSX_endCap = LineCap.Round;
        #endregion

        #region Properties

        public LineCap MacOSX_StartCap
        {
            get { return MacOSX_startCap; }
            set
            {
                MacOSX_startCap = value;
                
            }
        }

        public LineCap MacOSX_EndCap
        {
            get { return MacOSX_endCap; }
            set
            {
                MacOSX_endCap = value;
                
            }
        }

        public int MacOSX_SpokesCount
        {
            get { return MacOSX_m_SpokesCount; }
            set
            {
                MacOSX_m_SpokesCount = value;
                
            }
        }


        public MacOSX_automatic MacOSX_Automatic
        {
            get { return _automatic; }
            set
            {
                _automatic = value;
                
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        
        public int MacOSX_Interval
        {
            get
            {
                return MacOSX_m_Interval;
            }
            set
            {
                MacOSX_m_Interval = value;
                
                
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        
        public Color MacOSX_TickColor
        {
            get { return tick_Color; }
            set
            {
                tick_Color = value;
            }
        }

        /// <summary>
        /// MacOSX_Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>

        public MacOSX_Direction MacOSX_Rotation
        {
            get { return macOSX_Rotation; }
            set
            {
                macOSX_Rotation = value;
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        
        public int MacOSX_StartAngle
        {
            get
            {
                return MacOSX_m_StartAngle;
            }
            set
            {
                MacOSX_m_StartAngle = value;
                
            }
        }

        #endregion

    }
}
