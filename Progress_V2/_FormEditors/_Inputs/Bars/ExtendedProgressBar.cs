// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ExtendedProgressBar.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressInput.
    /// </summary>
    /// <seealso cref="System.Runtime.Serialization.ISerializable" />
    public partial class ProgressInput
    {

        #region Private Field

        //private System.ComponentModel.Container components = null;
        /// <summary>
        /// The m edge
        /// </summary>
        private ProgressBarEdge m_Edge = ProgressBarEdge.Rounded;
        /// <summary>
        /// The m edge color
        /// </summary>
        private Color m_EdgeColor = Color.FromKnownColor(KnownColor.Gray);
        /// <summary>
        /// The m edge light color
        /// </summary>
        private Color m_EdgeLightColor = Color.FromKnownColor(KnownColor.LightGray);
        /// <summary>
        /// The m edge width
        /// </summary>
        private int m_EdgeWidth = 1;
        /// <summary>
        /// The m flood style
        /// </summary>
        private ProgressFloodStyle m_FloodStyle = ProgressFloodStyle.Standard;
        /// <summary>
        /// The m float bar flood
        /// </summary>
        private float m_float_BarFlood = 0.20f;
        /// <summary>
        /// The m int bar offset
        /// </summary>
        private int m_int_BarOffset = 1;
        /// <summary>
        /// The m int dash width
        /// </summary>
        private int m_int_DashWidth = 5;
        /// <summary>
        /// The m int dash space
        /// </summary>
        private int m_int_DashSpace = 2;
        /// <summary>
        /// The m style
        /// </summary>
        private ProgressStyle m_Style = ProgressStyle.Dashed;
        /// <summary>
        /// The m color1
        /// </summary>
        private Color m_Color1 = Color.FromArgb(0, 255, 0);
        /// <summary>
        /// The m color2
        /// </summary>
        private Color m_Color2 = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// The m color back
        /// </summary>
        private Color m_color_Back = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// The m int step
        /// </summary>
        private int m_int_Step = 1;
        /// <summary>
        /// The m bool shadow
        /// </summary>
        private bool m_bool_Shadow = true;
        /// <summary>
        /// The m int shadow offset
        /// </summary>
        private int m_int_ShadowOffset = 1;
        /// <summary>
        /// The m bool antialias
        /// </summary>
        private bool m_bool_Antialias = true;
        /// <summary>
        /// The m color shadow
        /// </summary>
        private Color m_color_Shadow = Color.FromKnownColor(KnownColor.White);
        /// <summary>
        /// The m color caption
        /// </summary>
        private Color m_color_Caption = Color.FromKnownColor(KnownColor.Black);
        /// <summary>
        /// The m caption mode
        /// </summary>
        private ProgressCaptionMode m_CaptionMode = ProgressCaptionMode.Percent;
        /// <summary>
        /// The m string caption
        /// </summary>
        private String m_str_Caption = "%";
        /// <summary>
        /// The m bool change by mouse
        /// </summary>
        private bool m_bool_ChangeByMouse = false;
        /// <summary>
        /// The m bool invert
        /// </summary>
        private bool m_bool_Invert = false;
        /// <summary>
        /// The m direction
        /// </summary>
        private ProgressBarDirection m_Direction = ProgressBarDirection.Horizontal;
        /// <summary>
        /// The m int minimum
        /// </summary>
        private int m_int_Minimum = 0;
        /// <summary>
        /// The extended progress interval
        /// </summary>
        private int ExtendedProgress_interval = 100;


        #endregion


        #region Direction

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressInput"/> is invert.
        /// </summary>
        /// <value><c>true</c> if invert; otherwise, <c>false</c>.</value>
        public bool Invert
        {
            get
            {
                return m_bool_Invert;
            }
            set
            {
                m_bool_Invert = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        public ProgressBarDirection Orientation
        {
            get
            {
                return m_Direction;
            }
            set
            {
                m_Direction = value;
                
            }
        }
        #endregion

        #region Edge

        /// <summary>
        /// Gets or sets the edge.
        /// </summary>
        /// <value>The edge.</value>
        public ProgressBarEdge Edge
        {
            get
            {
                return m_Edge;
            }
            set
            {
                m_Edge = value;
                
            }
        }


        /// <summary>
        /// Gets or sets the color of the edge.
        /// </summary>
        /// <value>The color of the edge.</value>
        public Color EdgeColor
        {
            get
            {
                return m_EdgeColor;
            }
            set
            {
                m_EdgeColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the edge light.
        /// </summary>
        /// <value>The color of the edge light.</value>
        public Color EdgeLightColor
        {
            get
            {
                return m_EdgeLightColor;
            }
            set
            {
                m_EdgeLightColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the edge.
        /// </summary>
        /// <value>The width of the edge.</value>
        public int EdgeWidth
        {
            get
            {
                return m_EdgeWidth;
            }
            set
            {
                m_EdgeWidth = value;
                
            }
        }

        #endregion

        #region Progress

        /// <summary>
        /// Gets or sets the flood style.
        /// </summary>
        /// <value>The flood style.</value>
        public ProgressFloodStyle FloodStyle
        {
            get
            {
                return m_FloodStyle;
            }
            set
            {
                m_FloodStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the flood percentage.
        /// </summary>
        /// <value>The flood percentage.</value>
        public float FloodPercentage
        {
            get
            {
                return m_float_BarFlood;
            }
            set
            {
                m_float_BarFlood = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the bar offset.
        /// </summary>
        /// <value>The bar offset.</value>
        public int BarOffset
        {
            get
            {
                return m_int_BarOffset;
            }
            set
            {
                m_int_BarOffset = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the width of the dash.
        /// </summary>
        /// <value>The width of the dash.</value>
        public int DashWidth
        {
            get
            {
                return m_int_DashWidth;
            }
            set
            {
                m_int_DashWidth = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the dash space.
        /// </summary>
        /// <value>The dash space.</value>
        public int DashSpace
        {
            get
            {
                return m_int_DashSpace;
            }
            set
            {
                m_int_DashSpace = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the progress bar style.
        /// </summary>
        /// <value>The progress bar style.</value>
        public ProgressStyle ProgressBarStyle
        {
            get
            {
                return m_Style;
            }
            set
            {
                m_Style = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the main.
        /// </summary>
        /// <value>The color of the main.</value>
        public Color MainColor
        {
            get
            {
                return m_Color1;
            }
            set
            {
                m_Color1 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the second.
        /// </summary>
        /// <value>The color of the second.</value>
        public Color SecondColor
        {
            get
            {
                return m_Color2;
            }
            set
            {
                m_Color2 = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the progress back.
        /// </summary>
        /// <value>The color of the progress back.</value>
        public Color ProgressBackColor
        {
            get
            {
                return m_color_Back;
            }
            set
            {
                m_color_Back = value;
                
            }
        }
        //#####
        #endregion


        /// <summary>
        /// Gets or sets the extended progress timer interval.
        /// </summary>
        /// <value>The extended progress timer interval.</value>
        public int ExtendedProgress_TimerInterval
        {
            get { return ExtendedProgress_interval; }
            set
            {
                ExtendedProgress_interval = value;

            }
        }

        /// <summary>
        /// Gets or sets the extended progress minimum.
        /// </summary>
        /// <value>The extended progress minimum.</value>
        public int ExtendedProgress_Minimum
        {
            get
            {
                return m_int_Minimum;
            }
            set
            {
                if (value < Maximum) m_int_Minimum = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the extended progress step.
        /// </summary>
        /// <value>The extended progress step.</value>
        public int ExtendedProgress_Step
        {
            get
            {
                return m_int_Step;
            }
            set
            {
                m_int_Step = value;
                
            }
        }


        #region Caption


        /// <summary>
        /// Gets or sets a value indicating whether [extended progress shadow].
        /// </summary>
        /// <value><c>true</c> if [extended progress shadow]; otherwise, <c>false</c>.</value>
        public bool ExtendedProgress_Shadow
        {
            get
            {
                return m_bool_Shadow;
            }
            set
            {
                m_bool_Shadow = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets the shadow offset.
        /// </summary>
        /// <value>The shadow offset.</value>
        public int ShadowOffset
        {
            get
            {
                return m_int_ShadowOffset;
            }
            set
            {
                m_int_ShadowOffset = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets a value indicating whether [text antialias].
        /// </summary>
        /// <value><c>true</c> if [text antialias]; otherwise, <c>false</c>.</value>
        public bool TextAntialias
        {
            get
            {
                return m_bool_Antialias;
            }
            set
            {
                m_bool_Antialias = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets the color of the caption shadow.
        /// </summary>
        /// <value>The color of the caption shadow.</value>
        public Color CaptionShadowColor
        {
            get
            {
                return m_color_Shadow;
            }
            set
            {
                m_color_Shadow = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets the color of the caption.
        /// </summary>
        /// <value>The color of the caption.</value>
        public Color CaptionColor
        {
            get
            {
                return m_color_Caption;
            }
            set
            {
                m_color_Caption = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets the caption mode.
        /// </summary>
        /// <value>The caption mode.</value>
        public ProgressCaptionMode CaptionMode
        {
            get
            {
                return m_CaptionMode;
            }
            set
            {
                m_CaptionMode = value;
                
            }
        }
        //#####

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>The caption.</value>
        public String Caption
        {
            get
            {
                return m_str_Caption;
            }
            set
            {
                m_str_Caption = value;
                
            }
        }
        //#####
        #endregion

        #region Custom
        //#####

        /// <summary>
        /// Gets or sets a value indicating whether [change by mouse].
        /// </summary>
        /// <value><c>true</c> if [change by mouse]; otherwise, <c>false</c>.</value>
        public bool ChangeByMouse
        {
            get
            {
                return m_bool_ChangeByMouse;
            }
            set
            {
                m_bool_ChangeByMouse = value;
                
            }
        }
        
        #endregion
    }
}
