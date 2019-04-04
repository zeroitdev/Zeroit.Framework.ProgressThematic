// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBar_UC.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [ToolboxItem(false)]
    public partial class CircularProgressBar_UC : UserControl
    {
        public CircularProgressBar_UC()
        {
            InitializeComponent();
        }

        private void Preview_Btn_MouseEnter(object sender, EventArgs e)
        {
            Preview_Btn.FlatAppearance.BorderSize = 1;
            Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);
        }

        private void Preview_Btn_MouseLeave(object sender, EventArgs e)
        {
            Preview_Btn.FlatAppearance.BorderSize = 0;
            Preview_Btn.FlatAppearance.BorderColor = Color.FromArgb(31, 31, 31);
        }

        private void circular_ProgressBar_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressWidthStartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_ProgressBar_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_ProgressBar_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressWidthEndCap =
                (LineCap)Enum.Parse(typeof
                    (LineCap),
                    circular_ProgressBar_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_ProgressBar_ProgressShape_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressShapeVal =
                (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress._ProgressShape),
                    circular_ProgressBar_ProgressShape_ComboBox.SelectedItem.ToString());

        }

        private void circular_ProgressBar_InnerBorderWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressInnerBorderWidth =
                (float)circular_ProgressBar_InnerBorderWidth_Numeric.Value;
        }

        private void circular_ProgressBar_ProgressWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressWidth =
                (double)circular_ProgressBar_ProgressWidth_Numeric.Value;
        }

        private void circular_ProgressBar_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color1_Progress = Color.Transparent;

                circular_ProgressBar_Color1_Btn.BackColor = Color.Transparent;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    if (colorSelector.Color == Color.FromArgb(1,2,3))
                    {
                        colorSelector.Color = Color.Transparent;
                    }
                    ZeroitThematicProgress1.Color1_Progress = colorSelector.Color;

                    circular_ProgressBar_Color1_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color2_Progress = colorSelector.Color;

                circular_ProgressBar_Color2_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    ZeroitThematicProgress1.Color2_Progress = colorSelector.Color;

                    circular_ProgressBar_Color2_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_FillEllipse1_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color3_FillEllipse = colorSelector.Color;

                circular_ProgressBar_FillEllipse1_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    ZeroitThematicProgress1.Color3_FillEllipse = colorSelector.Color;

                    circular_ProgressBar_FillEllipse1_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_FillEllipse2_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color4_FillEllipse = colorSelector.Color;

                circular_ProgressBar_FillEllipse2_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    ZeroitThematicProgress1.Color4_FillEllipse = colorSelector.Color;

                    circular_ProgressBar_FillEllipse2_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color5_ProgressInnerBorder = colorSelector.Color;

                circular_ProgressBar_InnerBorder_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    ZeroitThematicProgress1.Color5_ProgressInnerBorder = colorSelector.Color;

                    circular_ProgressBar_InnerBorder_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_Text_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;

                ZeroitThematicProgress1.Color6_TextColor = colorSelector.Color;

                circular_ProgressBar_Text_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {
                    ZeroitThematicProgress1.Color6_TextColor = colorSelector.Color;

                    circular_ProgressBar_Text_Btn.BackColor = colorSelector.Color;

                }
            }
        }

        private void circular_ProgressBar_Percentage_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_ProgressBar_Percentage_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Percentage_Text = true;
            }
            else
            {
                ZeroitThematicProgress1.Percentage_Text = false;
            }
        }

        private void circular_ProgressBar_Transparent_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_ProgressBar_Transparent_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Transparent = true;
                
            }
            else
            {
                ZeroitThematicProgress1.Transparent = false;
            }
        }
    }
}
