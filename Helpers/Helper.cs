// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Helper_For_ProgressBarTransparent.cs" company="Zeroit Dev Technologies">
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

using System;
using System.Drawing;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class Helper.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Struct Fonts
        /// </summary>
        public struct Fonts
        {
            /// <summary>
            /// The primary
            /// </summary>
            public static Font Primary = new Font("Segoe UI", 9);
            /// <summary>
            /// The primary bold
            /// </summary>
            public static Font PrimaryBold = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        /// <summary>
        /// Struct Colors
        /// </summary>
        public struct Colors
        {
            /// <summary>
            /// The foreground
            /// </summary>
            public static Color Foreground = Color.White;
            /// <summary>
            /// The background
            /// </summary>
            public static Color Background = Color.FromArgb(48, 57, 65);
        }


        /// <summary>
        /// Enum MouseState
        /// </summary>
        public enum MouseState : byte
        {
            /// <summary>
            /// The none
            /// </summary>
            None = 0,
            /// <summary>
            /// The hover
            /// </summary>
            Hover = 1,
            /// <summary>
            /// Down
            /// </summary>
            Down = 2
        }

        /// <summary>
        /// Enum Direction
        /// </summary>
        public enum Direction : byte
        {
            /// <summary>
            /// Up
            /// </summary>
            Up = 0,
            /// <summary>
            /// Down
            /// </summary>
            Down = 1,
            /// <summary>
            /// The left
            /// </summary>
            Left = 3,
            /// <summary>
            /// The right
            /// </summary>
            Right = 4
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <param name="c">The c.</param>
        /// <exception cref="ArgumentException">Curve must be Greater than 0. - Curve</exception>
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

        /// <summary>
        /// Draws the triangle.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="r">The r.</param>
        /// <param name="d">The d.</param>
        /// <param name="c">The c.</param>
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

        /// <summary>
        /// Centers the string.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="Text">The text.</param>
        /// <param name="Font">The font.</param>
        /// <param name="c">The c.</param>
        /// <param name="rect">The rect.</param>
        /// <param name="Shadow">The shadow.</param>
        /// <param name="yOffset">The y offset.</param>
        public static void CenterString(Graphics g, String Text, Font Font, Color c, Rectangle rect, Boolean Shadow = false, Int32 yOffset = 1)
        {
            CenterString(g, Text, Font, new SolidBrush(c), rect, Shadow, yOffset);
        }

        /// <summary>
        /// Centers the string.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="Text">The text.</param>
        /// <param name="Font">The font.</param>
        /// <param name="b">The b.</param>
        /// <param name="rect">The rect.</param>
        /// <param name="Shadow">The shadow.</param>
        /// <param name="yOffset">The y offset.</param>
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

        /// <summary>
        /// Values to percentage.
        /// </summary>
        /// <param name="Value">The value.</param>
        /// <param name="Maximum">The maximum.</param>
        /// <param name="Minimum">The minimum.</param>
        /// <returns>Single.</returns>
        public static Single ValueToPercentage(Int32 Value, Int32 Maximum, Int32 Minimum)
        {
            return (Single)(Value - Minimum) / (Maximum - Minimum);
        }

        /// <summary>
        /// Multis the dispose.
        /// </summary>
        /// <param name="Disposables">The disposables.</param>
        public static void MultiDispose(params IDisposable[] Disposables)
        {
            foreach (var Disposable in Disposables)
            {

                Disposable.Dispose();


            }
        }
    }

}
