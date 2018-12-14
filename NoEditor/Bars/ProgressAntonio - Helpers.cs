#region Imports

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms.Design;
using System.Reflection;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Data;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using Microsoft.Win32;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml;
//using System.Windows.Forms.VisualStyles;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;

using Zeroit.Framework.Progress;

#endregion

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{

    #region BrushTable
    public class BrushTable : GraphicTable
    {
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
    public class GraphicTable : Dictionary<string, object>
    {
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
    public class PenTable : GraphicTable
    {
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
