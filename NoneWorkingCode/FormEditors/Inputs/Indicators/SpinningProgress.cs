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

        private Color m_InactiveColour = Color.FromArgb(218, 218, 218);
        private Color m_ActiveColour = Color.FromArgb(35, 146, 33);
        private Color m_TransistionColour = Color.FromArgb(129, 242, 121);
        private bool m_AutoIncrement = false;
        private double m_IncrementFrequency = 100;
        private bool m_BehindIsActive = true;
        private int m_TransitionSegment = 0;

        
        #endregion

        #region Public Properties

        public Color InactiveSegmentColour
        {
            get
            {
                return m_InactiveColour;
            }
            set
            {
                m_InactiveColour = value;
                
            }
        }


        public Color ActiveSegmentColour
        {
            get
            {
                return m_ActiveColour;
            }
            set
            {
                m_ActiveColour = value;
                
            }
        }


        public Color TransistionSegmentColour
        {
            get
            {
                return m_TransistionColour;
            }
            set
            {
                m_TransistionColour = value;
                
            }
        }


        public bool BehindTransistionSegmentIsActive
        {
            get
            {
                return m_BehindIsActive;
            }
            set
            {
                m_BehindIsActive = value;
                
            }
        }


        public int TransistionSegment
        {
            get
            {
                return m_TransitionSegment;
            }
            set
            {
                
                m_TransitionSegment = value;
                
            }
        }

        public bool Automate
        {
            get
            {
                return m_AutoIncrement;
            }
            set
            {
                m_AutoIncrement = value;

                
            }
        }

        public double AutoIncrementFrequency
        {
            get
            {
                return m_IncrementFrequency;
            }
            set
            {
                m_IncrementFrequency = value;
                
            }
        }


        #endregion


    }
}
