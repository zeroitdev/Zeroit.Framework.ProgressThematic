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

        private int ProgressPerfect_interval = 100;
        private Color ProgressPerfect_circleColor = Color.FromArgb(20, 20, 20);
        //private bool _stopped = true;
        private float ProgressPerfect_circleSize = 0.2F;
        private float _numberOfCircles = 180;
        private int _numberOfVisibleCircles = 30;
        private RotationType1 ProgressPerfect_rotation = RotationType1.Clockwise;
        private float ProgressPerfect_percentage = 0;
        private bool ProgressPerfect_showPercentage = false;
        private bool ProgressBarPerfect_showText = false;
        private TextDisplayModes1 ProgressPerfect_textDisplay = TextDisplayModes1.None;

        #endregion

        #region Public Properties
        
        public Color ProgressPerfect_CircleColor
        {
            get { return ProgressPerfect_circleColor; }
            set
            {
                ProgressPerfect_circleColor = value;
                
            }
        }
        
        public float ProgressPerfect_CircleSize
        {
            get { return ProgressPerfect_circleSize; }
            set
            {
                ProgressPerfect_circleSize = value;
                
            }
        }

        public int ProgressBarPerfect_AnimationSpeed
        {
            get { return ProgressPerfect_interval; }
            set
            {
                ProgressPerfect_interval = value;
            }
        }

        public float ProgressPerfect_NumberOfCircles
        {
            get { return Maximum; }
            set
            {
                
                Maximum = value;
                
            }
        }


        //---------------------------------------------------Number Of Circles-------------------------------------//

        public int ProgressPerfect_NumberOfVisibleCircles
        {
            get { return _numberOfVisibleCircles; }
            set
            {
                _numberOfVisibleCircles = value;
                
            }
        }

        public RotationType1 ProgressPerfect_Rotation
        {
            get { return ProgressPerfect_rotation; }
            set { ProgressPerfect_rotation = value; }
        }

        public float ProgressPerfect_Percentage
        {
            get { return ProgressPerfect_percentage; }
            set
            {
                
                ProgressPerfect_percentage = value;
            }
        }

        public bool ProgressPerfect_ShowPercentage
        {
            get { return ProgressPerfect_showPercentage; }
            set
            {
                ProgressPerfect_showPercentage = value;

                
            }
        }

        public bool ProgressBarPerfect_ShowText
        {
            get { return ProgressBarPerfect_showText; }
            set
            {
                ProgressBarPerfect_showText = value;

                
            }
        }

        /// <summary>
        /// Gets or sets the property that will be shown in the control.
        /// </summary>
        [DefaultValue(TextDisplayModes1.None)]
        [Description("Gets or sets the property that will be shown in the control.")]
        [Category("CircularProgress Perfect")]
        public TextDisplayModes1 ProgressPerfect_TextDisplay
        {
            get { return ProgressPerfect_textDisplay; }
            set
            {
                ProgressPerfect_textDisplay = value;

                
            }
        }

        #endregion

    }
}
