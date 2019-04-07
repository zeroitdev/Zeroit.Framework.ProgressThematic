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

        private int MacOSX_Matrix_m_Interval = 60;
        float MacOSX_Matrix_m_StartAngle = 270;
        MacOSX_Direction MacOSX_Matrix_m_Rotation = MacOSX_Direction.CLOCKWISE;
        Color matrix_tick_Color = Color.FromArgb(58, 58, 58);

        int MacOSX_Matrix_m_SpokesCount = 12;
        private LineCap MacOSX_Matrix_startCap = LineCap.Round;
        private LineCap MacOSX_Matrix_endCap = LineCap.Round;

        #endregion

        #region Properties

        public LineCap MacOSX_Matrix_StartCap
        {
            get { return MacOSX_Matrix_startCap; }
            set
            {
                MacOSX_Matrix_startCap = value;

            }
        }

        public LineCap MacOSX_Matrix_EndCap
        {
            get { return MacOSX_Matrix_endCap; }
            set
            {
                MacOSX_Matrix_endCap = value;

            }
        }

        public int MacOSX_Matrix_SpokesCount
        {
            get { return MacOSX_Matrix_m_SpokesCount; }
            set
            {
                MacOSX_Matrix_m_SpokesCount = value;

            }
        }


        /// <summary>
        /// Time interval for each tick.
        /// </summary>

        public int MacOSX_Matrix_Interval
        {
            get
            {
                return MacOSX_Matrix_m_Interval;
            }
            set
            {
                MacOSX_Matrix_m_Interval = value;
                
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>

        public Color MacOSX_Matrix_TickColor
        {
            get { return matrix_tick_Color; }
            set { matrix_tick_Color = value; }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        
        public MacOSX_Direction MacOSX_Matrix_Rotation
        {
            get
            {
                return MacOSX_Matrix_m_Rotation;
            }
            set
            {
                MacOSX_Matrix_m_Rotation = value;
                

                
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        
        public float MacOSX_Matrix_StartAngle
        {
            get
            {
                return MacOSX_Matrix_m_StartAngle;
            }
            set
            {
                MacOSX_Matrix_m_StartAngle = value;
                
            }
        }

        #endregion



    }
}
