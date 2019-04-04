// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarClear.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using static Zeroit.Framework.ProgressThematic.ZeroitThematicProgress;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Private Fields


        /// <summary>
        /// The progress bar clear glow
        /// </summary>
        private Color ProgressBarClear_glow = Color.FromArgb(230, 230, 230);
        /// <summary>
        /// The progress bar clear edge
        /// </summary>
        private Color ProgressBarClear_edge = Color.FromArgb(170, 170, 170);
        /// <summary>
        /// The progress bar clear gradient1
        /// </summary>
        private Color ProgressBarClear_gradient1 = Color.FromArgb(230, 230, 230);
        /// <summary>
        /// The progress bar clear gradient2
        /// </summary>
        private Color ProgressBarClear_gradient2 = Color.FromArgb(210, 210, 210);
        /// <summary>
        /// The coloring mode
        /// </summary>
        private coloringMode _coloringMode = coloringMode.Hatch;
        //int GlowPosition;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the progress bar clear color glow.
        /// </summary>
        /// <value>The progress bar clear color glow.</value>
        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGlow
        {
            get { return ProgressBarClear_glow; }
            set
            {
                ProgressBarClear_glow = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color border.
        /// </summary>
        /// <value>The progress bar clear color border.</value>
        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorBorder
        {
            get { return ProgressBarClear_edge; }
            set
            {
                ProgressBarClear_edge = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color gradient1.
        /// </summary>
        /// <value>The progress bar clear color gradient1.</value>
        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient1
        {
            get { return ProgressBarClear_gradient1; }
            set
            {
                ProgressBarClear_gradient1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar clear color gradient2.
        /// </summary>
        /// <value>The progress bar clear color gradient2.</value>
        [Category("RectangularProgress Clear")]
        public Color ProgressBarClear_ColorGradient2
        {
            get { return ProgressBarClear_gradient2; }
            set
            {
                ProgressBarClear_gradient2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        [Category("RectangularProgress Clear")]
        public coloringMode Mode
        {
            get { return _coloringMode; }
            set
            {
                _coloringMode = value;
                
            }
        }

        

        #endregion


    }
}
