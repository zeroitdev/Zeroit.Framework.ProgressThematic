// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAntonio - Helpers.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
