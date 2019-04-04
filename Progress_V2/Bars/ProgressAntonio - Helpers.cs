// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio - Helpers.cs" company="Zeroit Dev Technologies">
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
#region Imports

using System.Collections.Generic;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.ProgressThematic
{

    #region BrushTable
    /// <summary>
    /// Class BrushTable.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ProgressThematic.GraphicTable" />
    public class BrushTable : GraphicTable
    {
        /// <summary>
        /// Gets or sets the <see cref="Brush"/> with the specified key.
        /// </summary>
        /// <param name="Key">The key.</param>
        /// <returns>Brush.</returns>
        public new Brush this[string Key]
        {
            get
            {
                if (base[Key] == null)
                    return null;
                return (Brush)base[Key];
            }
            set
            {
                base[Key] = value;
            }
        }
    }
    #endregion

    #region GraphicTable
    /// <summary>
    /// Class GraphicTable.
    /// </summary>
    /// <seealso cref="System.Collections.Generic.Dictionary{System.String, System.Object}" />
    public class GraphicTable : Dictionary<string, object>
    {
        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> with the specified key.
        /// </summary>
        /// <param name="Key">The key.</param>
        /// <returns>System.Object.</returns>
        public new object this[string Key]
        {
            get
            {
                if (!ContainsKey(Key))
                    return null;
                return (object)base[Key];
            }
            set
            {
                if (this[Key] != null)
                {
                    if (this[Key].GetType().GetInterface("System.IDisposable") != null)
                        ((System.IDisposable)this[Key]).Dispose();
                    base[Key] = value;
                }
                else
                    Add(Key, value);
            }
        }
        /// <summary>
        /// Disposes all.
        /// </summary>
        public void DisposeAll()
        {
            foreach (object xObj in Values)
            {
                if (xObj.GetType().GetInterface("System.IDisposable") != null)
                    ((System.IDisposable)xObj).Dispose();
            }
        }

    }
    #endregion

    #region PenTable
    /// <summary>
    /// Class PenTable.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ProgressThematic.GraphicTable" />
    public class PenTable : GraphicTable
    {
        /// <summary>
        /// Gets or sets the <see cref="Pen"/> with the specified key.
        /// </summary>
        /// <param name="Key">The key.</param>
        /// <returns>Pen.</returns>
        public new Pen this[string Key]
        {
            get
            {
                if (base[Key] == null)
                    return null;
                return (Pen)base[Key];
            }
            set
            {
                base[Key] = value;
            }
        }
    }
    #endregion
    
}
