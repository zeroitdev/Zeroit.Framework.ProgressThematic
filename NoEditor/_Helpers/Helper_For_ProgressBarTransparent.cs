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
    #region Helper Class for ProgressBarTransparent
    public static class Helper
    {
        public struct Fonts
        {
            public static Font Primary = new Font("Segoe UI", 9);
            public static Font PrimaryBold = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        public struct Colors
        {
            public static Color Foreground = Color.White;
            public static Color Background = Color.FromArgb(48, 57, 65);
        }


        public enum MouseState : byte
        {
            None = 0,
            Hover = 1,
            Down = 2
        }

        public enum Direction : byte
        {
            Up = 0,
            Down = 1,
            Left = 3,
            Right = 4
        }

        public static void RoundRect(Graphics g, Int32 x, Int32 y, Int32 Width, Int32 Height, Int32 Curve, Color c)
        {
            if (Curve <= 0) throw new ArgumentException("Curve must be Greater than 0.", "Curve");

            var p = new Pen(c);

            var BaseRect = new RectangleF(x, y, Width, Height);
            var ArcRect = new RectangleF(BaseRect.Location, new SizeF(Curve, Curve));

            g.DrawArc(p, ArcRect, 180, 90);
            g.DrawLine(p, x + (Curve / 2), y, y + Width - (Curve / 2), y);

            ArcRect.X = BaseRect.Right - Curve;
            g.DrawArc(p, ArcRect, 270, 90);
            g.DrawLine(p, x + Width, y + (Curve / 2), x + Width, y + Height - (Curve / 2));

            ArcRect.Y = BaseRect.Bottom - Curve;
            g.DrawArc(p, ArcRect, 0, 90);
            g.DrawLine(p, x + (Curve / 2), y + Height, x + Width - (Curve / 2), y + Height);

            ArcRect.X = BaseRect.Left;
            g.DrawArc(p, ArcRect, 90, 30);
            g.DrawLine(p, x, y + (Curve / 2), x, y + Height - (Curve / 2));

            p.Dispose();
        }

        public static void DrawTriangle(Graphics g, Rectangle r, Direction d, Color c)
        {
            var w = r.Width / 2;
            var y = r.Height / 2;

            Point p0 = Point.Empty, p1 = Point.Empty, p2 = Point.Empty;

            switch (d)
            {
                case Direction.Up:
                    p0 = new Point(r.Left + w, r.Top);
                    p1 = new Point(r.Left, r.Bottom);
                    p2 = new Point(r.Right, r.Bottom);
                    break;

                case Direction.Down:
                    p0 = new Point(r.Left + w, r.Bottom);
                    p1 = new Point(r.Left, r.Top);
                    p2 = new Point(r.Right, r.Top);
                    break;

                case Direction.Left:
                    p0 = new Point(r.Left, r.Top + y);
                    p1 = new Point(r.Right, r.Top);
                    p2 = new Point(r.Right, r.Bottom);
                    break;

                case Direction.Right:
                    p0 = new Point(r.Right, r.Top + y);
                    p1 = new Point(r.Left, r.Bottom);
                    p2 = new Point(r.Left, r.Top);
                    break;
            }

            var s = new SolidBrush(c);
            g.FillPolygon(s, new[] { p0, p1, p2 });

            MultiDispose(s);
        }

        public static void CenterString(Graphics g, String Text, Font Font, Color c, Rectangle rect, Boolean Shadow = false, Int32 yOffset = 1)
        {
            CenterString(g, Text, Font, new SolidBrush(c), rect, Shadow, yOffset);
        }

        public static void CenterString(Graphics g, String Text, Font Font, Brush b, Rectangle rect, Boolean Shadow = false, Int32 yOffset = 1)
        {
            var TextSize = g.MeasureString(Text, Font);
            var x = rect.X + (rect.Width / 2) - (TextSize.Width / 2);
            var y = rect.Y + (rect.Height / 2) - (TextSize.Height / 2) + yOffset;

            if (Shadow)
                g.DrawString(Text, Font, Brushes.Black, x + 1, y + 1);
            g.DrawString(Text, Font, b, x, y);

            b.Dispose();
        }

        public static Single ValueToPercentage(Int32 Value, Int32 Maximum, Int32 Minimum)
        {
            return (Single)(Value - Minimum) / (Maximum - Minimum);
        }

        public static void MultiDispose(params IDisposable[] Disposables)
        {
            foreach (var Disposable in Disposables)
            {

                Disposable.Dispose();


            }
        }
    }

    #endregion
}
