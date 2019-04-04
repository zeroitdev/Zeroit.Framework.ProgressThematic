// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="PenParameters.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;


namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class PenParameters.
    /// </summary>
    public class PenParameters
    {
        /// <summary>
        /// The alignment
        /// </summary>
        private PenAlignment alignment = PenAlignment.Center;
        /// <summary>
        /// The dash cap
        /// </summary>
        private DashCap dashCap = DashCap.Flat;
        /// <summary>
        /// The dash offset
        /// </summary>
        private float dashOffset = 0.5f;
        /// <summary>
        /// The dash pattern
        /// </summary>
        private float[] dashPattern = new float[] {0.2f, 0.75f};
        /// <summary>
        /// The dash style
        /// </summary>
        private DashStyle dashStyle = DashStyle.DashDot;
        /// <summary>
        /// The end cap
        /// </summary>
        private LineCap endCap = LineCap.Round;
        /// <summary>
        /// The line join
        /// </summary>
        private LineJoin lineJoin = LineJoin.Bevel;
        /// <summary>
        /// The start cap
        /// </summary>
        private LineCap startCap = LineCap.Triangle;
        /// <summary>
        /// The miter limit
        /// </summary>
        private float miterLimit = 0.7f;
        /// <summary>
        /// The width
        /// </summary>
        private float width = 2f;

        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        /// <value>The alignment.</value>
        public PenAlignment Alignment
        {
            get { return alignment; }
            set { alignment = value; }
        }

        /// <summary>
        /// Gets or sets the dash cap.
        /// </summary>
        /// <value>The dash cap.</value>
        public DashCap DashCap
        {
            get { return dashCap; }
            set { dashCap = value; }
        }

        /// <summary>
        /// Gets or sets the dash offset.
        /// </summary>
        /// <value>The dash offset.</value>
        public float DashOffset
        {
            get { return dashOffset; }
            set { dashOffset = value; }
        }

        /// <summary>
        /// Gets or sets the dash pattern.
        /// </summary>
        /// <value>The dash pattern.</value>
        public float[] DashPattern
        {
            get { return dashPattern; }
            set { dashPattern = value; }
        }

        /// <summary>
        /// Gets or sets the dash style.
        /// </summary>
        /// <value>The dash style.</value>
        public DashStyle DashStyle
        {
            get { return dashStyle; }
            set { dashStyle = value; }
        }

        /// <summary>
        /// Gets or sets the end cap.
        /// </summary>
        /// <value>The end cap.</value>
        public LineCap EndCap
        {
            get { return endCap; }
            set { endCap = value; }
        }

        /// <summary>
        /// Gets or sets the line join.
        /// </summary>
        /// <value>The line join.</value>
        public LineJoin LineJoin
        {
            get { return lineJoin; }
            set { lineJoin = value; }
        }

        /// <summary>
        /// Gets or sets the start cap.
        /// </summary>
        /// <value>The start cap.</value>
        public LineCap StartCap
        {
            get { return startCap; }
            set { startCap = value; }
        }

        /// <summary>
        /// Gets or sets the miter limit.
        /// </summary>
        /// <value>The miter limit.</value>
        public float MiterLimit
        {
            get { return miterLimit; }
            set { miterLimit = value; }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        public float Width
        {
            get { return width; }
            set { width = value; }
        }
    }
}
