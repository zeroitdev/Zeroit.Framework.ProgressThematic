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
        
        // Attributes ========================================================
        private bool Spinner_m_IsTimerActive = false;
        private int m_NumberOfSpoke = 10;
        private int m_SpokeThickness = 4;
        private int m_OuterCircleRadius = 10;
        private int m_InnerCircleRadius = 8;
        private Color m_Color = Color.DarkGray;
        private StylePresets m_StylePreset = StylePresets.MacOSX;
        private int _Timer_Interval = 1000;
        #endregion

        #region Public Properties
        public Color SpokeColor
        {
            get
            {
                return m_Color;
            }
            set
            {
                m_Color = value;

                
            }
        }

        public int OuterCircleRadius
        {
            get
            {
                
                return m_OuterCircleRadius;
            }
            set
            {
                m_OuterCircleRadius = value;
                
            }
        }

        public int InnerCircleRadius
        {
            get
            {
                
                return m_InnerCircleRadius;
            }
            set
            {
                m_InnerCircleRadius = value;
                
            }
        }

        public int NumberSpoke
        {
            get
            {
                
                return m_NumberOfSpoke;
            }
            set
            {
                m_NumberOfSpoke = value;
                
            }
        }

        public bool Spinner_Active
        {
            get
            {
                return Spinner_m_IsTimerActive;
            }
            set
            {
                Spinner_m_IsTimerActive = value;
                
            }
        }

        public int SpokeThickness
        {
            get
            {
                
                return m_SpokeThickness;
            }
            set
            {
                m_SpokeThickness = value;
                
            }
        }

        public int RotationSpeed
        {
            get
            {
                return _Timer_Interval;
            }
            set
            {

                _Timer_Interval = value;
            }
        }

        public int Timer_Interval
        {
            get
            {
                return _Timer_Interval;
            }
            set
            {
                _Timer_Interval = value;

            }
        }

        public StylePresets StylePreset
        {
            get { return m_StylePreset; }
            set
            {
                m_StylePreset = value;

                
            }
        }

        #endregion

    }
}
