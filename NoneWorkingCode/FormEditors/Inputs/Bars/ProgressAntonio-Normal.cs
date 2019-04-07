using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.Progress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    public partial class ProgressInput
    {

        #region Private Fields

        private ThematicProgress.progressNormalType _progressNormalType = ThematicProgress.progressNormalType.Normal;
        private int ProgressBarNormal_step = 5;
        private ThematicProgress.TextColorTypes _TextColorType = ThematicProgress.TextColorTypes.Automatic;
        private ThematicProgress.TextAlignmentTypes _TextAlign = ThematicProgress.TextAlignmentTypes.Center;
        private bool _DisplayProgress = false;
        private Color _ColorProgress = Color.Blue;
        private ThematicProgress.BorderTypes _BorderType = ThematicProgress.BorderTypes.None;
        private Color ProgressBarNormal_borderColor = Color.Black;
        private int _RollBlockPercent = 20;
        private ThematicProgress.RollingTypes _RollingType = ThematicProgress.RollingTypes.None;
        private int antonioInterval = 100;

        #endregion


        #region Properties

        public ThematicProgress.progressNormalType ProgressNormalType
        {
            get { return _progressNormalType; }
            set
            {
                _progressNormalType = value;
                
            }
        }

        
        public int ProgressBarNormal_Step
        {
            get
            {
                return ProgressBarNormal_step;
            }
            set
            {
                ProgressBarNormal_step = value;
                
            }
        }

        
        public Color ColorProgress
        {
            get
            {
                return _ColorProgress;
            }
            set
            {
                _ColorProgress = value;
                
                
            }
        }

        
        public bool DisplayProgress
        {
            get
            {
                return _DisplayProgress;
            }
            set
            {
                _DisplayProgress = value;
                
            }
        }

        
        public ThematicProgress.TextColorTypes TextColorType
        {
            get
            {
                return _TextColorType;
            }
            set
            {
                _TextColorType = value;
                
            }
        }


        public ThematicProgress.TextAlignmentTypes TextAlign
        {
            get
            {
                return _TextAlign;
            }
            set
            {
                _TextAlign = value;
                
            }
        }


        public ThematicProgress.BorderTypes BorderType
        {
            get
            {
                return _BorderType;
            }
            set
            {
                _BorderType = value;
                
            }
        }


        public Color ProgressBarNormal_BorderColor
        {
            get
            {
                return ProgressBarNormal_borderColor;
            }
            set
            {
                
                ProgressBarNormal_borderColor = value;
                
            }
        }


        #endregion

        #region Rolling
        
        public int RollBlockPercent
        {
            get
            {
                return _RollBlockPercent;
            }
            set
            {
                _RollBlockPercent = value;
                
            }
        }
        
        public ThematicProgress.RollingTypes RollingType
        {
            get
            {
                return _RollingType;
            }
            set
            {
                _RollingType = value;
                
            }
        }
        
        public int RollTimer
        {
            get
            {
                return antonioInterval;
            }
            set
            {
                antonioInterval = value;
            }
        }

        


        #endregion

    }
}
