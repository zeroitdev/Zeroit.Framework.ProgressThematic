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

        #region Variables

        Color baseColor = Color.DarkGray;
        Color animationColor = Color.DimGray;
        private float _visibleCircles = 45f;
        private double _radian = 180f;
        private float _circleWidth = 15f;

        #endregion

        #region Custom Properties

        
        public float ProgIndicator_NumberOfCircles
        {
            get { return _visibleCircles; }
            set
            {
                _visibleCircles = value;
                
            }
        }

        
        public float ProgIndicator_CircleWidth
        {
            get { return _circleWidth; }
            set
            {
                _circleWidth = value;
                
            }
        }

        
        public Double ProgIndicator_Radian
        {
            get { return _radian; }
            set
            {
                _radian = value;
                
            }
        }

        
        public Color P_BaseColor
        {
            get
            {
                return baseColor;
            }
            set
            {
                baseColor = value;
                
            }
        }

        
        public Color P_AnimationColor
        {
            get
            {
                return animationColor;
            }
            set
            {
                animationColor = value;
                
            }
        }

        

        #endregion

    }
}
