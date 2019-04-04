// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MacOSXOptimized.cs" company="Zeroit Dev Technologies">
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


        #region Members

        /// <summary>
        /// The mac osx optimized m interval
        /// </summary>
        private int MacOSX_Optimized_m_Interval = 60;
        /// <summary>
        /// The mac osx optimized m start angle
        /// </summary>
        float MacOSX_Optimized_m_StartAngle = 30;
        /// <summary>
        /// The mac osx optimized m angle increment
        /// </summary>
        float MacOSX_Optimized_m_AngleIncrement = 0;
        /// <summary>
        /// The mac osx optimized m rotation
        /// </summary>
        MacOSX_Direction MacOSX_Optimized_m_Rotation = MacOSX_Direction.CLOCKWISE;
        /// <summary>
        /// The mac osx optimized tick color
        /// </summary>
        Color macOSX_Optimized_tick_Color = Color.FromArgb(58, 58, 58);

        /// <summary>
        /// The mac osx optimized m spokes count
        /// </summary>
        int MacOSX_Optimized_m_SpokesCount = 12;
        /// <summary>
        /// The mac osx optimized start cap
        /// </summary>
        private LineCap MacOSX_Optimized_startCap = LineCap.Round;
        /// <summary>
        /// The mac osx optimized end cap
        /// </summary>
        private LineCap MacOSX_Optimized_endCap = LineCap.Round;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx optimized start cap.
        /// </summary>
        /// <value>The mac osx optimized start cap.</value>
        public LineCap MacOSX_Optimized_StartCap
        {
            get { return MacOSX_Optimized_startCap; }
            set
            {
                MacOSX_Optimized_startCap = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized end cap.
        /// </summary>
        /// <value>The mac osx optimized end cap.</value>
        public LineCap MacOSX_Optimized_EndCap
        {
            get { return MacOSX_Optimized_endCap; }
            set
            {
                MacOSX_Optimized_endCap = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized spokes count.
        /// </summary>
        /// <value>The mac osx optimized spokes count.</value>
        public int MacOSX_Optimized_SpokesCount
        {
            get { return MacOSX_Optimized_m_SpokesCount; }
            set
            {
                MacOSX_Optimized_m_SpokesCount = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized interval.
        /// </summary>
        /// <value>The mac osx optimized interval.</value>
        public int MacOSX_Optimized_Interval
        {
            get
            {
                return MacOSX_Optimized_m_Interval;
            }
            set
            {
                MacOSX_Optimized_m_Interval = value;


            }
        }

        /// <summary>
        /// Gets or sets the color of the mac osx optimized tick.
        /// </summary>
        /// <value>The color of the mac osx optimized tick.</value>
        public Color MacOSX_Optimized_TickColor
        {
            get { return macOSX_Optimized_tick_Color; }
            set
            {
                macOSX_Optimized_tick_Color = value;
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized rotation.
        /// </summary>
        /// <value>The mac osx optimized rotation.</value>
        public MacOSX_Direction MacOSX_Optimized_Rotation
        {
            get
            {
                return MacOSX_Optimized_m_Rotation;
            }
            set
            {
                MacOSX_Optimized_m_Rotation = value;
                

                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx optimized start angle.
        /// </summary>
        /// <value>The mac osx optimized start angle.</value>
        public float MacOSX_Optimized_StartAngle
        {
            get
            {
                return MacOSX_Optimized_m_StartAngle;
            }
            set
            {
                MacOSX_Optimized_m_StartAngle = value;
                
            }
        }

        #endregion

    }
}
