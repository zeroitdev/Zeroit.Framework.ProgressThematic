using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        
        private int m_ProgressBarBlockWidth = 6;
        private int m_ProgressBarBlockSpace = 1;
        private bool m_ProgressBarPercent = true;
        private bool m_ProgressBarMarginOffset = true;
        private TProgressBarBorderStyle m_ProgressBarBorderStyle = TProgressBarBorderStyle.Flat;
        private Color m_ProgressBarFillBrush_Color = Color.Coral;

        #endregion

        #region Public Properties

        
        public Color Splitter_FillColor
        {
            get
            {
                return m_ProgressBarFillBrush_Color;
            }

            set
            {
                m_ProgressBarFillBrush_Color = value;
            }
        }

        
        public int Splitter_BlockWidth
        {
            get { return m_ProgressBarBlockWidth; }
            set
            {
                m_ProgressBarBlockWidth = value;
            }
        }

        
        public int Splitter_BlockSpace
        {
            get { return m_ProgressBarBlockSpace; }
            set
            {
                m_ProgressBarBlockSpace = value;
            }
        }

        
        public TProgressBarBorderStyle Splitter_BoderStyle
        {
            get { return m_ProgressBarBorderStyle; }
            set
            {
                if (m_ProgressBarBorderStyle != value)
                {
                    m_ProgressBarBorderStyle = value;
                    
                }
            }
        }

        
        public bool Splitter_Percent
        {
            get { return m_ProgressBarPercent; }
            set
            {
                if (m_ProgressBarPercent != value)
                {
                    m_ProgressBarPercent = value;
                    
                }
            }
        }

        
        public bool Splitter_MarginOffset
        {
            get { return m_ProgressBarMarginOffset; }
            set
            {
                if (m_ProgressBarMarginOffset != value)
                {
                    m_ProgressBarMarginOffset = value;
                    
                }
            }
        }

        

        #endregion

    }
}
