// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV4.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;

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
        /// The c PV4 start angle
        /// </summary>
        private int CPv4_startAngle = -90;
        /// <summary>
        /// The c PV4 thickness
        /// </summary>
        private int CPv4_thickness = 20;
        /// <summary>
        /// The c PV4 grad angle
        /// </summary>
        private float CPv4_gradAngle = 90f;
        /// <summary>
        /// The c PV4 start cap
        /// </summary>
        private LineCap CPv4_startCap = LineCap.Round;
        /// <summary>
        /// The c PV4 end cap
        /// </summary>
        private LineCap CPv4_endCap = LineCap.Round;
        /// <summary>
        /// The c PV4 inner border
        /// </summary>
        private Color CPv4_innerBorder = Color.Black;
        /// <summary>
        /// The c PV4 outer border
        /// </summary>
        private Color CPv4_outerBorder = Color.Black;
        /// <summary>
        /// The c PV4 prog grad1
        /// </summary>
        private Color CPv4_progGrad1 = Color.DarkSlateGray;
        /// <summary>
        /// The c PV4 prog grad2
        /// </summary>
        private Color CPv4_progGrad2 = Color.Orange;
        /// <summary>
        /// The c PV4 prog back grad1
        /// </summary>
        private Color CPv4_progBackGrad1 = Color.White;
        /// <summary>
        /// The c PV4 prog back grad2
        /// </summary>
        private Color CPv4_progBackGrad2 = Color.White;
        /// <summary>
        /// The c PV4 speed
        /// </summary>
        private int CPv4_speed = 100;

        /// <summary>
        /// The c PV4 inner border thickness
        /// </summary>
        private int CPv4_innerBorderThickness = 1;
        /// <summary>
        /// The c PV4 outer border thickness
        /// </summary>
        private int CPv4_outerBorderThickness = 1;
        /// <summary>
        /// The c PV4 fill ellipse
        /// </summary>
        private Color[] CPv4_fillEllipse = new Color[] {Color.Gray, Color.Black};
        #endregion


        #region Public Properties


        /// <summary>
        /// Gets or sets the c PV4 speed.
        /// </summary>
        /// <value>The c PV4 speed.</value>
        public int CPv4_Speed
        {
            get { return CPv4_speed; }
            set
            {
                CPv4_speed = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 gradient angle.
        /// </summary>
        /// <value>The c PV4 gradient angle.</value>
        public float CPv4_GradientAngle
        {
            get { return CPv4_gradAngle; }
            set
            {
                CPv4_gradAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 fill ellipse.
        /// </summary>
        /// <value>The c PV4 fill ellipse.</value>
        public Color[] CPv4_FillEllipse
        {
            get { return CPv4_fillEllipse; }
            set
            {
                CPv4_fillEllipse = value;
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 progress back grad1.
        /// </summary>
        /// <value>The c PV4 progress back grad1.</value>
        public Color CPv4_ProgressBackGrad1
        {
            get { return CPv4_progBackGrad1; }
            set
            {
                CPv4_progBackGrad1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 progress back grad2.
        /// </summary>
        /// <value>The c PV4 progress back grad2.</value>
        public Color CPv4_ProgressBackGrad2
        {
            get { return CPv4_progBackGrad2; }
            set
            {
                CPv4_progBackGrad2 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 progress grad1.
        /// </summary>
        /// <value>The c PV4 progress grad1.</value>
        public Color CPv4_ProgressGrad1
        {
            get { return CPv4_progGrad1; }
            set
            {
                CPv4_progGrad1 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 progress grad2.
        /// </summary>
        /// <value>The c PV4 progress grad2.</value>
        public Color CPv4_ProgressGrad2
        {
            get { return CPv4_progGrad2; }
            set
            {
                CPv4_progGrad2 = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 inner border.
        /// </summary>
        /// <value>The c PV4 inner border.</value>
        public Color CPv4_InnerBorder
        {
            get { return CPv4_innerBorder; }
            set
            {
                CPv4_innerBorder = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 outer border.
        /// </summary>
        /// <value>The c PV4 outer border.</value>
        public Color CPv4_OuterBorder
        {
            get { return CPv4_outerBorder; }
            set
            {
                CPv4_outerBorder = value;
                
            }
        }



        /// <summary>
        /// Gets or sets the c PV4 thickness.
        /// </summary>
        /// <value>The c PV4 thickness.</value>
        public int CPv4_Thickness
        {
            get { return CPv4_thickness; }
            set
            {
                CPv4_thickness = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the c PV4 inner border thickness.
        /// </summary>
        /// <value>The c PV4 inner border thickness.</value>
        public int CPv4_InnerBorderThickness
        {
            get { return CPv4_innerBorderThickness; }
            set
            {
                CPv4_innerBorderThickness = value;

            }
        }

        /// <summary>
        /// Gets or sets the c PV4 outer border thickness.
        /// </summary>
        /// <value>The c PV4 outer border thickness.</value>
        public int CPv4_OuterBorderThickness
        {
            get { return CPv4_outerBorderThickness; }
            set
            {
                CPv4_outerBorderThickness = value;

            }
        }
        /// <summary>
        /// Gets or sets the c PV4 start angle.
        /// </summary>
        /// <value>The c PV4 start angle.</value>
        public int CPv4_StartAngle
        {
            get { return CPv4_startAngle; }
            set
            {
                CPv4_startAngle = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 start cap.
        /// </summary>
        /// <value>The c PV4 start cap.</value>
        public LineCap CPv4_StartCap
        {
            get { return CPv4_startCap; }
            set
            {
                CPv4_startCap = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the c PV4 end cap.
        /// </summary>
        /// <value>The c PV4 end cap.</value>
        public LineCap CPv4_EndCap
        {
            get { return CPv4_endCap; }
            set
            {
                CPv4_endCap = value;
                
            }
        }
        #endregion

    }
}
