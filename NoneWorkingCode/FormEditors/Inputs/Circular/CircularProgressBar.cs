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


        private Color _ProgressColor1 = Color.FromArgb(92, 92, 92);
        private Color _ProgressColor2 = Color.FromArgb(92, 92, 92);
        private Color _FillEllipse1 = Color.Black;
        private Color _FillEllipse2 = Color.Gray;
        private Color _TextColor = Color.White;
        private Color _ProgressColorInnerBorder = Color.Transparent;
        private _ProgressShape progressShapeVal = _ProgressShape.Round;
        private LineCap _Start = LineCap.Flat;
        private LineCap _End = LineCap.Flat;
        public Double _ProgressWidth = 5d;
        private float _PenWidth = 1f;
        //private float _ProgressWidthToFloat;
        private bool _showText = true;
        private bool zeroitProgressBarCircular_transparency = false;


        #endregion

        #region Public Properties

        public _ProgressShape ProgressShapeVal
        {
            get { return progressShapeVal; }
            set
            {
                progressShapeVal = value;
            }
        }


        public Boolean Transparent
        {
            get { return zeroitProgressBarCircular_transparency; }
            set
            {
                zeroitProgressBarCircular_transparency = value;
                
            }
        }

        
        public Boolean Percentage_Text
        {
            get { return _showText; }
            set
            {
                if (value == false)
                {
                    _TextColor = Color.Transparent;
                }

                else
                {
                    _TextColor = Color.White;
                }
                _showText = value;
                
            }
        }
        
        public float ProgressInnerBorderWidth
        {
            get { return _PenWidth; }
            set
            {
                if (value > 5)
                {
                    value = 5;
                }
                _PenWidth = value;
                
            }
        }
        
        
        public Color Color5_ProgressInnerBorder
        {
            get { return _ProgressColorInnerBorder; }
            set
            {
                _ProgressColorInnerBorder = value;
                
            }
        }

        
        public Color Color6_TextColor
        {
            get { return _TextColor; }
            set
            {
                _TextColor = value;
                
            }
        }

        
        public LineCap ProgressWidthStartCap
        {
            get { return _Start; }
            set
            {
                if (_Start == null)
                {
                    _Start = LineCap.Flat;
                }
                _Start = value;
                
            }
        }

        
        public LineCap ProgressWidthEndCap
        {
            get { return _End; }
            set
            {
                if (_End == null)
                {
                    _End = LineCap.Flat;
                }
                _End = value;
                
            }
        }

        
        public Double ProgressWidth
        {
            get { return _ProgressWidth; }
            set
            {
                if (_ProgressWidth == null)
                {
                    _ProgressWidth = 5f;
                }

                _ProgressWidth = value;
                //_ProgressWidthToFloat = DoubleToFloat(_ProgressWidth);

                
            }
        }
        
        public Color Color1_Progress
        {
            get { return _ProgressColor1; }
            set
            {
                _ProgressColor1 = value;
                
            }
        }
        
        public Color Color2_Progress
        {
            get { return _ProgressColor2; }
            set
            {
                _ProgressColor2 = value;
                
            }
        }
        
        public Color Color3_FillEllipse
        {
            get { return _FillEllipse1; }
            set
            {
                _FillEllipse1 = value;
                
            }
        }

        
        public Color Color4_FillEllipse
        {
            get { return _FillEllipse2; }
            set
            {
                _FillEllipse2 = value;
                
            }
        }
        
        #endregion

    }
}
