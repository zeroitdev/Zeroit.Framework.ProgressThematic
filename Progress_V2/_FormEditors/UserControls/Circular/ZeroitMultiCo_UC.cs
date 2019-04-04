// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCo_UC.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [ToolboxItem(false)]
    public partial class ZeroitMultiCo_UC : UserControl
    {
        public ZeroitMultiCo_UC()
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


        private void circular_MultiCo_NoOfRings_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    circular_MultiCo_NoOfRings_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCo_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_InnerBorder = (int)circular_MultiCo_InnerBorder_Numeric.Value;

        }

        private void circular_MultiCo_CorrectShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_CorrectShift = (int)circular_MultiCo_CorrectShiftWidth_Numeric.Value;

        }

        private void circular_MultiCo_RectangleShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_RectShift = (int)circular_MultiCo_RectangleShiftWidth_Numeric.Value;

        }

        private void circular_MultiCo_Shift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_Shift = (int)circular_MultiCo_ShiftWidth_Numeric.Value;

        }

        private void circular_MultiCo_ShowInnerBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_MultiCo_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.MC_ShowInnerBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.MC_ShowInnerBorder = false;
            }
        }

        private void circular_MultiCo_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[0] = colorSelector.Color;

                circular_MultiCo_Color1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[1] = colorSelector.Color;

                circular_MultiCo_Color2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[2] = colorSelector.Color;

                circular_MultiCo_Color3_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[3] = colorSelector.Color;

                circular_MultiCo_Color4_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[4] = colorSelector.Color;

                circular_MultiCo_Color5_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color6_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[5] = colorSelector.Color;

                circular_MultiCo_Color6_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color7_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[6] = colorSelector.Color;

                circular_MultiCo_Color7_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color8_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[7] = colorSelector.Color;

                circular_MultiCo_Color8_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color9_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[8] = colorSelector.Color;

                circular_MultiCo_Color9_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color10_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[9] = colorSelector.Color;

                circular_MultiCo_Color10_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color11_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[10] = colorSelector.Color;

                circular_MultiCo_Color11_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color12_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[11] = colorSelector.Color;

                circular_MultiCo_Color12_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color13_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[12] = colorSelector.Color;

                circular_MultiCo_Color13_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color14_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[13] = colorSelector.Color;

                circular_MultiCo_Color14_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color15_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[14] = colorSelector.Color;

                circular_MultiCo_Color15_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color16_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[15] = colorSelector.Color;

                circular_MultiCo_Color16_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color17_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[16] = colorSelector.Color;

                circular_MultiCo_Color17_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color18_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[17] = colorSelector.Color;

                circular_MultiCo_Color18_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color19_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[18] = colorSelector.Color;

                circular_MultiCo_Color19_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color20_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[19] = colorSelector.Color;

                circular_MultiCo_Color20_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color21_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[20] = colorSelector.Color;

                circular_MultiCo_Color21_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color22_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[21] = colorSelector.Color;

                circular_MultiCo_Color22_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color23_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[22] = colorSelector.Color;

                circular_MultiCo_Color23_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_Color24_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_Colors[23] = colorSelector.Color;

                circular_MultiCo_Color24_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_CorrectShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_CorrectShift_Height = (int)circular_MultiCo_CorrectShiftHeight_Numeric.Value;

        }

        private void circular_MultiCo_RectangleShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_RectShift_Height = (int)circular_MultiCo_RectangleShiftHeight_Numeric.Value;

        }

        private void circular_MultiCo_ShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MC_Shift_Height = (int)circular_MultiCo_ShiftHeight_Numeric.Value;

        }

        private void circular_MultiCo_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_InnerBorderColor = colorSelector.Color;

                circular_MultiCo_InnerBorder_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCo_InnerColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MC_InnerColor = colorSelector.Color;

                circular_MultiCo_InnerColor_Btn.BackColor = colorSelector.Color;

            }
        }
    }
}
