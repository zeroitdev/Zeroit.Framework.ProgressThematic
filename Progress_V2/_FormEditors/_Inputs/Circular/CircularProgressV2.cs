// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV2.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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


        #region Private Field

        /// <summary>
        /// The c PV2 progress width
        /// </summary>
        private int CPv2_progressWidth = 2;
        /// <summary>
        /// The c PV2 shift
        /// </summary>
        private int CPv2_shift = 0;
        /// <summary>
        /// The c PV2 remainder angle
        /// </summary>
        int CPv2_remainderAngle = 0;
        /// <summary>
        /// The c PV2 angle reduced
        /// </summary>
        int CPv2_angleReduced = 90;
        /// <summary>
        /// The c PV2 start angle
        /// </summary>
        int CPv2_startAngle = 80;
        /// <summary>
        /// The c PV2 show text
        /// </summary>
        private bool CPv2_showText = true;
        /// <summary>
        /// The c PV2 progress color
        /// </summary>
        private Color CPv2_progressColor = Color.LightSeaGreen;
        /// <summary>
        /// The c PV2 progress empty color
        /// </summary>
        private Color CPv2_progressEmptyColor = Color.LightGray;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the c PV2.
        /// </summary>
        /// <value>The color of the c PV2.</value>
        public Color CPv2_Color
        {
            get { return CPv2_progressColor; }
            set
            {
                CPv2_progressColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV2 color empty.
        /// </summary>
        /// <value>The c PV2 color empty.</value>
        public Color CPv2_ColorEmpty
        {
            get { return CPv2_progressEmptyColor; }
            set
            {
                CPv2_progressEmptyColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [c PV2 show text].
        /// </summary>
        /// <value><c>true</c> if [c PV2 show text]; otherwise, <c>false</c>.</value>
        public bool CPv2_ShowText
        {
            get { return CPv2_showText; }
            set
            {
                CPv2_showText = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV2 start angle.
        /// </summary>
        /// <value>The c PV2 start angle.</value>
        public int CPv2_StartAngle
        {
            get { return CPv2_startAngle; }
            set
            {
                CPv2_startAngle = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV2 angle reduced.
        /// </summary>
        /// <value>The c PV2 angle reduced.</value>
        public int CPv2_AngleReduced
        {
            get { return CPv2_angleReduced; }
            set
            {
                CPv2_angleReduced = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV2 shift.
        /// </summary>
        /// <value>The c PV2 shift.</value>
        public int CPv2_Shift
        {
            get { return CPv2_shift; }
            set
            {
                CPv2_shift = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the c PV2 progress.
        /// </summary>
        /// <value>The width of the c PV2 progress.</value>
        public int CPv2_ProgressWidth
        {
            get { return CPv2_progressWidth; }
            set
            {
                CPv2_progressWidth = value;
                
            }
        }

        #endregion

    }
}
