// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBarDefault.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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

        #region Variables



        /// <summary>
        /// The circular definition progress color1
        /// </summary>
        private Color CircularDef_ProgressColor1 = Color.FromArgb(92, 92, 92);
        /// <summary>
        /// The circular definition progress color2
        /// </summary>
        private Color CircularDef_ProgressColor2 = Color.FromArgb(92, 92, 92);

        /// <summary>
        /// The circular definition inner color1
        /// </summary>
        private Color CircularDef_InnerColor1 = Color.FromArgb(0x34, 0x34, 0x34);
        /// <summary>
        /// The circular definition inner color2
        /// </summary>
        private Color CircularDef_InnerColor2 = Color.FromArgb(0x34, 0x34, 0x34);


        /// <summary>
        /// The circular definition progress shape value
        /// </summary>
        private _ProgressShape CircularDef_ProgressShapeVal = _ProgressShape.Round;

        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the progress color1 default.
        /// </summary>
        /// <value>The progress color1 default.</value>
        public Color ProgressColor1_Default
        {
            get { return CircularDef_ProgressColor1; }
            set
            {
                CircularDef_ProgressColor1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the progress color2 default.
        /// </summary>
        /// <value>The progress color2 default.</value>
        public Color ProgressColor2_Default
        {
            get { return CircularDef_ProgressColor2; }
            set
            {
                CircularDef_ProgressColor2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress inner color1 default.
        /// </summary>
        /// <value>The progress inner color1 default.</value>
        public Color ProgressInnerColor1_Default
        {
            get { return CircularDef_InnerColor1; }
            set
            {
                CircularDef_InnerColor1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the progress inner color2 default.
        /// </summary>
        /// <value>The progress inner color2 default.</value>
        public Color ProgressInnerColor2_Default
        {
            get { return CircularDef_InnerColor2; }
            set
            {
                CircularDef_InnerColor2 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the progress shape default.
        /// </summary>
        /// <value>The progress shape default.</value>
        public _ProgressShape ProgressShape_Default
        {
            get { return CircularDef_ProgressShapeVal; }
            set
            {
                CircularDef_ProgressShapeVal = value;
                
            }
        }



        #endregion

    }
}
