// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBar.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {
        #region Variables


        /// <summary>
        /// The progress color1
        /// </summary>
        private Color _ProgressColor1 = Color.FromArgb(92, 92, 92);
        /// <summary>
        /// The progress color2
        /// </summary>
        private Color _ProgressColor2 = Color.FromArgb(92, 92, 92);
        /// <summary>
        /// The fill ellipse1
        /// </summary>
        private Color _FillEllipse1 = Color.Black;
        /// <summary>
        /// The fill ellipse2
        /// </summary>
        private Color _FillEllipse2 = Color.Gray;
        /// <summary>
        /// The text color
        /// </summary>
        private Color _TextColor = Color.White;
        /// <summary>
        /// The progress color inner border
        /// </summary>
        private Color _ProgressColorInnerBorder = Color.Transparent;
        /// <summary>
        /// The progress shape value
        /// </summary>
        private _ProgressShape progressShapeVal = _ProgressShape.Round;
        /// <summary>
        /// The start
        /// </summary>
        private LineCap _Start = LineCap.Flat;
        /// <summary>
        /// The end
        /// </summary>
        private LineCap _End = LineCap.Flat;
        /// <summary>
        /// The progress width
        /// </summary>
        public Double _ProgressWidth = 5d;
        /// <summary>
        /// The pen width
        /// </summary>
        private float _PenWidth = 1f;
        //private float _ProgressWidthToFloat;
        /// <summary>
        /// The show text
        /// </summary>
        private bool _showText = true;
        /// <summary>
        /// The zeroit progress bar circular transparency
        /// </summary>
        private bool zeroitProgressBarCircular_transparency = false;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the progress shape value.
        /// </summary>
        /// <value>The progress shape value.</value>
        public _ProgressShape ProgressShapeVal
        {
            get { return progressShapeVal; }
            set
            {
                progressShapeVal = value;
            }
        }

        /// <summary>
        /// Gets or sets the transparent.
        /// </summary>
        /// <value>The transparent.</value>
        public Boolean Transparent
        {
            get { return zeroitProgressBarCircular_transparency; }
            set
            {
                zeroitProgressBarCircular_transparency = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the percentage text.
        /// </summary>
        /// <value>The percentage text.</value>
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

        /// <summary>
        /// Gets or sets the width of the progress inner border.
        /// </summary>
        /// <value>The width of the progress inner border.</value>
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

        /// <summary>
        /// Gets or sets the color5 progress inner border.
        /// </summary>
        /// <value>The color5 progress inner border.</value>
        public Color Color5_ProgressInnerBorder
        {
            get { return _ProgressColorInnerBorder; }
            set
            {
                _ProgressColorInnerBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the color6 text.
        /// </summary>
        /// <value>The color of the color6 text.</value>
        public Color Color6_TextColor
        {
            get { return _TextColor; }
            set
            {
                _TextColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress width start cap.
        /// </summary>
        /// <value>The progress width start cap.</value>
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

        /// <summary>
        /// Gets or sets the progress width end cap.
        /// </summary>
        /// <value>The progress width end cap.</value>
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

        /// <summary>
        /// Gets or sets the width of the progress.
        /// </summary>
        /// <value>The width of the progress.</value>
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

        /// <summary>
        /// Gets or sets the color1 progress.
        /// </summary>
        /// <value>The color1 progress.</value>
        public Color Color1_Progress
        {
            get { return _ProgressColor1; }
            set
            {
                _ProgressColor1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color2 progress.
        /// </summary>
        /// <value>The color2 progress.</value>
        public Color Color2_Progress
        {
            get { return _ProgressColor2; }
            set
            {
                _ProgressColor2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color3 fill ellipse.
        /// </summary>
        /// <value>The color3 fill ellipse.</value>
        public Color Color3_FillEllipse
        {
            get { return _FillEllipse1; }
            set
            {
                _FillEllipse1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color4 fill ellipse.
        /// </summary>
        /// <value>The color4 fill ellipse.</value>
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
