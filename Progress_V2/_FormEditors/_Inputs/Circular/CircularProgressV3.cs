// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV3.cs" company="Zeroit Dev Technologies">
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

        #region Private Fields

        /// <summary>
        /// The c PV3 progress width
        /// </summary>
        private int CPv3_progressWidth = 2;
        /// <summary>
        /// The c PV3 shift
        /// </summary>
        private int CPv3_shift = 0;
        /// <summary>
        /// The c PV3 remainder angle
        /// </summary>
        int CPv3_remainderAngle = 0;
        /// <summary>
        /// The c PV3 startangle
        /// </summary>
        int CPv3_startangle = -90;
        /// <summary>
        /// The c PV3 show text
        /// </summary>
        private bool CPv3_showText = true;
        /// <summary>
        /// The c PV3 progress color
        /// </summary>
        private Color CPv3_progressColor = Color.LightSeaGreen;
        /// <summary>
        /// The c PV3 progress empty color
        /// </summary>
        private Color CPv3_progressEmptyColor = Color.LightGray;

        #endregion


        #region Public Properties

        /// <summary>
        /// Gets or sets the color of the c PV3.
        /// </summary>
        /// <value>The color of the c PV3.</value>
        public Color CPv3_Color
        {
            get { return CPv3_progressColor; }
            set
            {
                CPv3_progressColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV3 color empty.
        /// </summary>
        /// <value>The c PV3 color empty.</value>
        public Color CPv3_ColorEmpty
        {
            get { return CPv3_progressEmptyColor; }
            set
            {
                CPv3_progressEmptyColor = value;
                
            }
        }


        /// <summary>
        /// Gets or sets a value indicating whether [c PV3 show text].
        /// </summary>
        /// <value><c>true</c> if [c PV3 show text]; otherwise, <c>false</c>.</value>
        public bool CPv3_ShowText
        {
            get { return CPv3_showText; }
            set
            {
                CPv3_showText = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV3 start angle.
        /// </summary>
        /// <value>The c PV3 start angle.</value>
        public int CPv3_StartAngle
        {
            get { return CPv3_startangle; }
            set
            {
                CPv3_startangle = value;
                
            }
        }



        /// <summary>
        /// Gets or sets the c PV3 shift.
        /// </summary>
        /// <value>The c PV3 shift.</value>
        public int CPv3_Shift
        {
            get { return CPv3_shift; }
            set
            {
                CPv3_shift = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the width of the c PV3 progress.
        /// </summary>
        /// <value>The width of the c PV3 progress.</value>
        public int CPv3_ProgressWidth
        {
            get { return CPv3_progressWidth; }
            set
            {
                CPv3_progressWidth = value;
                
            }
        }

        #endregion

    }
}
