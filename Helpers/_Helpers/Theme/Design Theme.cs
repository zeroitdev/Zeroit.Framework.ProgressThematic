// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Design Theme.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.ThemeManagers
{


    #region " Design Form "
    /// <summary>
    /// Class Design.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ProgressThematic.ThemeManagers.ThemeContainer" />
    [ToolboxItem(false)]
    public class Design : ThemeContainer
    {
        
        #region Initialization of Variables

        /// <summary>
        /// The locked
        /// </summary>
        private bool Locked = false;

        /// <summary>
        /// The position
        /// </summary>
        private Point Position;
        /// <summary>
        /// The couleur ecriture
        /// </summary>
        Color Couleur_Ecriture = Color.FromArgb(70, 70, 70);

        /// <summary>
        /// The couleur back color
        /// </summary>
        Color Couleur_BackColor = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The couleur degrade1
        /// </summary>
        Color Couleur_Degrade1 = Color.FromArgb(35, 35, 35);

        /// <summary>
        /// The couleur degrade2
        /// </summary>
        Color Couleur_Degrade2 = Color.FromArgb(25, 25, 25);

        /// <summary>
        /// The couleur bordure ext
        /// </summary>
        Color Couleur_BordureExt = Color.Black;
        /// <summary>
        /// The couleur bordure int1 haut
        /// </summary>
        Color Couleur_BordureInt1_Haut = Color.FromArgb(74, 74, 74);
        /// <summary>
        /// The couleur bordure int1 bas
        /// </summary>
        Color Couleur_BordureInt1_Bas = Color.FromArgb(39, 39, 39);

        /// <summary>
        /// The couleur bordure int2
        /// </summary>
        Color Couleur_BordureInt2 = Color.FromArgb(43, 43, 43);
        /// <summary>
        /// The couleur separation1
        /// </summary>
        Color Couleur_Separation1 = Color.Black;
        /// <summary>
        /// The couleur separation2
        /// </summary>
        Color Couleur_Separation2 = Color.FromArgb(0, 255, 0);

        /// <summary>
        /// The couleur separation3
        /// </summary>
        Color Couleur_Separation3 = Color.Black;

        /// <summary>
        /// The hauteur barre
        /// </summary>
        int Hauteur_Barre = 33;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Design"/> class.
        /// </summary>
        public Design()
        {
            Dock = DockStyle.Fill;
            Font = new Font("Verdana", 10, FontStyle.Regular);
            SendToBack();
            DoubleBuffered = true;
            Padding = new Padding(2, 36, 2, 2);

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        #endregion

        #region Color and Paint Methods
        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {

        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        protected override void PaintHook()
        {
            
            G.SmoothingMode = SmoothingMode.HighQuality;
            
            //BACKGROUND

            G.Clear(Couleur_BackColor);

            //HAUT

            Rectangle Rectangle_Haut = new Rectangle(0, 0, Width, Hauteur_Barre);
            LinearGradientBrush Haut_Brush = new LinearGradientBrush(Rectangle_Haut, Couleur_Degrade1, Couleur_Degrade2, LinearGradientMode.Vertical);
            G.FillRectangle(Haut_Brush, Rectangle_Haut);
            Haut_Brush.Dispose();

            //ECRITURE

            StringFormat StringFormat = new StringFormat();
            StringFormat.LineAlignment = StringAlignment.Center;
            StringFormat.Alignment = StringAlignment.Near;

            Rectangle Rectangle_Ecriture = new Rectangle(15, 0, Width - 15, Hauteur_Barre);

            G.DrawString(Text, Font, new SolidBrush(Couleur_Ecriture), Rectangle_Ecriture, StringFormat);
            StringFormat.Dispose();

            //BORDURE INT1

            Rectangle Rectangle_BordureInt1 = new Rectangle(1, 1, Width - 3, Hauteur_Barre - 4);
            Rectangle Rectangle_BordureInt1_AvecBordure = new Rectangle(0, 0, Width - 1, Hauteur_Barre - 2);

            LinearGradientBrush Brush_BordureInt1 = new LinearGradientBrush(Rectangle_BordureInt1_AvecBordure, Couleur_BordureInt1_Haut, Couleur_BordureInt1_Bas, LinearGradientMode.Vertical);
            G.DrawRectangle(new Pen(Brush_BordureInt1, 1), Rectangle_BordureInt1);

            //BORDURE INT2

            Rectangle Rectangle_BordureInt2 = new Rectangle(1, Hauteur_Barre + 2, Width - 3, Height - Hauteur_Barre - 4);
            G.DrawRectangle(new Pen(Couleur_BordureInt2, 1), Rectangle_BordureInt2);

            //SEPARATION

            Point Separation_Point1 = new Point(0, Hauteur_Barre);
            Point Separation_Point2 = new Point(Width, Hauteur_Barre);

            LinearGradientBrush Separation_Brush = new LinearGradientBrush(Separation_Point1, Separation_Point2, Color.Black, Color.Black);

            ColorBlend ColorBlend = new ColorBlend();
            ColorBlend.Colors = new Color[] {
            Couleur_Separation1,
            Couleur_Separation2,
            Couleur_Separation3
        };
            ColorBlend.Positions = new float[] {
            0,
            0.5f,
            1
        };

            Separation_Brush.InterpolationColors = ColorBlend;

            G.DrawLine(new Pen(Separation_Brush, 2), Separation_Point1, Separation_Point2);

            Separation_Brush.Dispose();

            //BORDURE EXT1

            Rectangle Rectangle_BordureExt1 = new Rectangle(0, 0, Width - 1, Hauteur_Barre - 2);
            G.DrawRectangle(new Pen(Couleur_BordureExt, 1), Rectangle_BordureExt1);

            //BORDURE EXT2

            Rectangle Rectangle_BordureExt2 = new Rectangle(0, Hauteur_Barre + 1, Width - 1, Height - Hauteur_Barre - 2);
            G.DrawRectangle(new Pen(Couleur_BordureExt, 1), Rectangle_BordureExt2);

        }

        #endregion

        #region Events in Action



        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle Rectangle = new Rectangle(0, 0, Width, Hauteur_Barre);
            if ((Rectangle.Contains(e.Location)))
            {
                Locked = true;
                Position = e.Location;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Locked = false;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseMove" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if ((Locked))
            {
                Parent.FindForm().Location = new Point(Cursor.Position.X - Position.X, Cursor.Position.Y - Position.Y);
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        

        #endregion
    }

    #endregion
    

}


