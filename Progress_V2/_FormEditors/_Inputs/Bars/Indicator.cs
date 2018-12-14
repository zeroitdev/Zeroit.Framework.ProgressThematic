// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Indicator.cs" company="Zeroit Dev Technologies">
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
        /// The graph width
        /// </summary>
        public float _GraphWidth = 33;
        /// <summary>
        /// The paint color
        /// </summary>
        private Color paintColor = Color.Black;
        /// <summary>
        /// The pen color
        /// </summary>
        private Color penColor = Color.Black;

        #endregion

        #region Public Properties


        /// <summary>
        /// Gets or sets the width of the graph.
        /// </summary>
        /// <value>The width of the graph.</value>
        public float GraphWidth
        {
            get
            {
                return _GraphWidth;
            }
            set
            {
                _GraphWidth = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        public Color Color
        {
            get { return paintColor; }
            set
            {
                paintColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the border.
        /// </summary>
        /// <value>The color of the border.</value>
        public Color BorderColor
        {
            get { return penColor; }
            set
            {
                penColor = value;
                
            }
        }

        #endregion

    }
}
