// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DrawText.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic
{
    /// <summary>
    /// Class ZeroitThematicProgress.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ZeroitThematicProgress
    {
        /// <summary>
        /// The header
        /// </summary>
        private int _Header = 24;
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>The header.</value>
        private int Header
        {
            get { return _Header; }
            set
            {
                _Header = value;

                //if (!_ControlMode)
                //{
                //    Frame = new Rectangle(7, 7, Width - 14, value - 7);
                //    Invalidate();
                //}
            }
        }

        #region " DrawText "

        /// <summary>
        /// The draw text point
        /// </summary>
        private Point DrawTextPoint;

        /// <summary>
        /// The draw text size
        /// </summary>
        private Size DrawTextSize;
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        private void DrawText(Graphics G, Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(G,b1, Text, a, x, y);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="text">The text.</param>
        /// <param name="a">a.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        private void DrawText(Graphics G, Brush b1, string text, HorizontalAlignment a, int x, int y)
        {
            //Graphics G = CreateGraphics();
            //G.SmoothingMode = SmoothingMode.HighQuality;

            if (text.Length == 0)
                return;

            DrawTextSize = Measure(text);
            DrawTextPoint = new Point(Width / 2 - DrawTextSize.Width / 2, Header / 2 - DrawTextSize.Height / 2);

            switch (a)
            {
                case HorizontalAlignment.Left:
                    G.DrawString(text, Font, b1, x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Center:
                    G.DrawString(text, Font, b1, DrawTextPoint.X + x, DrawTextPoint.Y + y);
                    break;
                case HorizontalAlignment.Right:
                    G.DrawString(text, Font, b1, Width - DrawTextSize.Width - x, DrawTextPoint.Y + y);
                    break;
            }
        }

        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="p1">The p1.</param>
        private void DrawText(Graphics G, Brush b1, Point p1)
        {
            
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        /// <summary>
        /// Draws the text.
        /// </summary>
        /// <param name="b1">The b1.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        private void DrawText(Graphics G, Brush b1, int x, int y)
        {
            
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }




        #endregion

        #region " Measure "

        /// <summary>
        /// The measure bitmap
        /// </summary>
        private Bitmap MeasureBitmap;

        /// <summary>
        /// The measure graphics
        /// </summary>
        private Graphics MeasureGraphics;
        /// <summary>
        /// Measures this instance.
        /// </summary>
        /// <returns>Size.</returns>
        private Size Measure()
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
            }
        }
        /// <summary>
        /// Measures the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Size.</returns>
        private Size Measure(string text)
        {
            MeasureGraphics = CreateGraphics();
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(text, Font, Width).ToSize();
            }
        }

        #endregion
    }
}
