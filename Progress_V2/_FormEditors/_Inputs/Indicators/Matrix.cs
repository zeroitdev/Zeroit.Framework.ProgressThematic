// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Matrix.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        /// The mac osx matrix m interval
        /// </summary>
        private int MacOSX_Matrix_m_Interval = 60;
        /// <summary>
        /// The mac osx matrix m start angle
        /// </summary>
        float MacOSX_Matrix_m_StartAngle = 270;
        /// <summary>
        /// The mac osx matrix m rotation
        /// </summary>
        MacOSX_Direction MacOSX_Matrix_m_Rotation = MacOSX_Direction.CLOCKWISE;
        /// <summary>
        /// The matrix tick color
        /// </summary>
        Color matrix_tick_Color = Color.FromArgb(58, 58, 58);

        /// <summary>
        /// The mac osx matrix m spokes count
        /// </summary>
        int MacOSX_Matrix_m_SpokesCount = 12;
        /// <summary>
        /// The mac osx matrix start cap
        /// </summary>
        private LineCap MacOSX_Matrix_startCap = LineCap.Round;
        /// <summary>
        /// The mac osx matrix end cap
        /// </summary>
        private LineCap MacOSX_Matrix_endCap = LineCap.Round;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the mac osx matrix start cap.
        /// </summary>
        /// <value>The mac osx matrix start cap.</value>
        public LineCap MacOSX_Matrix_StartCap
        {
            get { return MacOSX_Matrix_startCap; }
            set
            {
                MacOSX_Matrix_startCap = value;

            }
        }

        /// <summary>
        /// Gets or sets the mac osx matrix end cap.
        /// </summary>
        /// <value>The mac osx matrix end cap.</value>
        public LineCap MacOSX_Matrix_EndCap
        {
            get { return MacOSX_Matrix_endCap; }
            set
            {
                MacOSX_Matrix_endCap = value;

            }
        }

        /// <summary>
        /// Gets or sets the mac osx matrix spokes count.
        /// </summary>
        /// <value>The mac osx matrix spokes count.</value>
        public int MacOSX_Matrix_SpokesCount
        {
            get { return MacOSX_Matrix_m_SpokesCount; }
            set
            {
                MacOSX_Matrix_m_SpokesCount = value;

            }
        }


        /// <summary>
        /// Time interval for each tick.
        /// </summary>
        /// <value>The mac osx matrix interval.</value>

        public int MacOSX_Matrix_Interval
        {
            get
            {
                return MacOSX_Matrix_m_Interval;
            }
            set
            {
                MacOSX_Matrix_m_Interval = value;
                
            }
        }

        /// <summary>
        /// Color of the tick
        /// </summary>
        /// <value>The color of the mac osx matrix tick.</value>

        public Color MacOSX_Matrix_TickColor
        {
            get { return matrix_tick_Color; }
            set { matrix_tick_Color = value; }
        }

        /// <summary>
        /// Direction of rotation - CLOCKWISE/ANTICLOCKWISE
        /// </summary>
        /// <value>The mac osx matrix rotation.</value>

        public MacOSX_Direction MacOSX_Matrix_Rotation
        {
            get
            {
                return MacOSX_Matrix_m_Rotation;
            }
            set
            {
                MacOSX_Matrix_m_Rotation = value;
                

                
            }
        }

        /// <summary>
        /// Angle at which the tick should start
        /// </summary>
        /// <value>The mac osx matrix start angle.</value>

        public float MacOSX_Matrix_StartAngle
        {
            get
            {
                return MacOSX_Matrix_m_StartAngle;
            }
            set
            {
                MacOSX_Matrix_m_StartAngle = value;
                
            }
        }

        #endregion



    }
}
