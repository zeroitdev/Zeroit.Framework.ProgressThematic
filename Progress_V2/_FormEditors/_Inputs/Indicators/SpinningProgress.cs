// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SpinningProgress.cs" company="Zeroit Dev Technologies">
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
        /// The m inactive colour
        /// </summary>
        private Color m_InactiveColour = Color.FromArgb(218, 218, 218);
        /// <summary>
        /// The m active colour
        /// </summary>
        private Color m_ActiveColour = Color.FromArgb(35, 146, 33);
        /// <summary>
        /// The m transistion colour
        /// </summary>
        private Color m_TransistionColour = Color.FromArgb(129, 242, 121);
        /// <summary>
        /// The m automatic increment
        /// </summary>
        private bool m_AutoIncrement = false;
        /// <summary>
        /// The m increment frequency
        /// </summary>
        private double m_IncrementFrequency = 100;
        /// <summary>
        /// The m behind is active
        /// </summary>
        private bool m_BehindIsActive = true;
        /// <summary>
        /// The m transition segment
        /// </summary>
        private int m_TransitionSegment = 0;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the inactive segment colour.
        /// </summary>
        /// <value>The inactive segment colour.</value>
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


        /// <summary>
        /// Gets or sets the active segment colour.
        /// </summary>
        /// <value>The active segment colour.</value>
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


        /// <summary>
        /// Gets or sets the transistion segment colour.
        /// </summary>
        /// <value>The transistion segment colour.</value>
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


        /// <summary>
        /// Gets or sets a value indicating whether [behind transistion segment is active].
        /// </summary>
        /// <value><c>true</c> if [behind transistion segment is active]; otherwise, <c>false</c>.</value>
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


        /// <summary>
        /// Gets or sets the transistion segment.
        /// </summary>
        /// <value>The transistion segment.</value>
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

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressInput"/> is automate.
        /// </summary>
        /// <value><c>true</c> if automate; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets the automatic increment frequency.
        /// </summary>
        /// <value>The automatic increment frequency.</value>
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
