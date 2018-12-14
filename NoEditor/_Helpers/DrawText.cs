using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.WithoutEditor
{
    public partial class ThematicProgress
    {
        private int _Header = 24;
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

        private Point DrawTextPoint;

        private Size DrawTextSize;
        private void DrawText(Brush b1, HorizontalAlignment a, int x, int y)
        {
            DrawText(b1, Text, a, x, y);
        }
        private void DrawText(Brush b1, string text, HorizontalAlignment a, int x, int y)
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

        private void DrawText(Brush b1, Point p1)
        {
            
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, p1);
        }
        private void DrawText(Brush b1, int x, int y)
        {
            
            if (Text.Length == 0)
                return;
            G.DrawString(Text, Font, b1, x, y);
        }




        #endregion

        #region " Measure "

        private Bitmap MeasureBitmap;

        private Graphics MeasureGraphics;
        private Size Measure()
        {
            lock (MeasureGraphics)
            {
                return MeasureGraphics.MeasureString(Text, Font, Width).ToSize();
            }
        }
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
