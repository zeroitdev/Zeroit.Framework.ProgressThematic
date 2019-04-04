// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="MacOSX.cs" company="Zeroit Dev Technologies">
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
        /// The mac osx m interval
        /// </summary>
        private int MacOSX_m_Interval = 60;
        /// <summary>
        /// The mac osx m inner radius
        /// </summary>
        int MacOSX_m_InnerRadius = 0;
        /// <summary>
        /// The mac osx m outer radius
        /// </summary>
        int MacOSX_m_OuterRadius = 0;
        /// <summary>
        /// The mac osx m start angle
        /// </summary>
        int MacOSX_m_StartAngle = 270;
        /// <summary>
        /// The mac osx m alpha start value
        /// </summary>
        int MacOSX_m_AlphaStartValue = 0;
        /// <summary>
        /// The mac osx m spokes count
        /// </summary>
        int MacOSX_m_SpokesCount = 12;
        /// <summary>
        /// The mac osx m angle increment
        /// </summary>
        int MacOSX_m_AngleIncrement = 0;
        /// <summary>
        /// The mac osx m alpha decrement
        /// </summary>
        int MacOSX_m_AlphaDecrement = 0;
        /// <summary>
        /// The automatic
        /// </summary>
        private MacOSX_automatic _automatic = MacOSX_automatic.Start;
        /// <summary>
        /// The tick color
        /// </summary>
        private Color tick_Color = Color.FromArgb(58, 58, 58);
        /// <summary>
        /// The mac osx rotation
        /// </summary>
        MacOSX_Direction macOSX_Rotation = MacOSX_Direction.CLOCKWISE;

        /// <summary>
        /// The mac osx start cap
        /// </summary>
        private LineCap MacOSX_startCap = LineCap.Round;
        /// <summary>
        /// The mac osx end cap
        /// </summary>
        private LineCap MacOSX_endCap = LineCap.Round;

        /// <summary>
        /// The mac osx maximum spokes
        /// </summary>
        private int macOSX_Max_Spokes = 12;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx maximum spokes.
        /// </summary>
        /// <value>The mac osx maximum spokes.</value>
        public int MacOSX_MaxSpokes
        {
            get { return macOSX_Max_Spokes; }
            set
            {
                macOSX_Max_Spokes = value;

            }
        }

        /// <summary>
        /// Gets or sets the mac osx start cap.
        /// </summary>
        /// <value>The mac osx start cap.</value>
        public LineCap MacOSX_StartCap
        {
            get { return MacOSX_startCap; }
            set
            {
                MacOSX_startCap = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx end cap.
        /// </summary>
        /// <value>The mac osx end cap.</value>
        public LineCap MacOSX_EndCap
        {
            get { return MacOSX_endCap; }
            set
            {
                MacOSX_endCap = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the mac osx spokes count.
        /// </summary>
        /// <value>The mac osx spokes count.</value>
        public int MacOSX_SpokesCount
        {
            get { return MacOSX_m_SpokesCount; }
            set
            {
                MacOSX_m_SpokesCount = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the mac osx automatic.
        /// </summary>
        /// <value>The mac osx automatic.</value>
        public MacOSX_automatic MacOSX_Automatic
        {
            get { return _automatic; }
            set
            {
                _automatic = value;
                
            }
        }

        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        /// <value>The mac osx interval.</value>

        public int MacOSX_Interval
        {
            get
            {
                return MacOSX_m_Interval;
            }
            set
            {
                MacOSX_m_Interval = value;
                
                
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        /// <value>The color of the mac osx tick.</value>

        public Color MacOSX_TickColor
        {
            get { return tick_Color; }
            set
            {
                tick_Color = value;
            }
        }

        /// <summary>
        /// MacOSX_Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        /// <value>The mac osx rotation.</value>

        public MacOSX_Direction MacOSX_Rotation
        {
            get { return macOSX_Rotation; }
            set
            {
                macOSX_Rotation = value;
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        /// <value>The mac osx start angle.</value>

        public int MacOSX_StartAngle
        {
            get
            {
                return MacOSX_m_StartAngle;
            }
            set
            {
                MacOSX_m_StartAngle = value;
                
            }
        }

        #endregion

    }
}
