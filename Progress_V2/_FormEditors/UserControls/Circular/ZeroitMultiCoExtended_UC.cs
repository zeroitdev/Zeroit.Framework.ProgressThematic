// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ZeroitMultiCoExtended_UC : UserControl
    {
        public ZeroitMultiCoExtended_UC()
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



        private void circular_MultiCoEx_NoOfRings_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    circular_MultiCoEx_NoOfRings_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoEx_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_InnerBorder = (int)circular_MultiCoEx_InnerBorder_Numeric.Value;

        }

        private void circular_MultiCoEx_CorrectShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_CorrectShift = (int)circular_MultiCoEx_CorrectShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoEx_RectangleShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_RectShift = (int)circular_MultiCoEx_RectangleShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoEx_Shift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_Shift = (int)circular_MultiCoEx_ShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoEx_ShowInnerBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_MultiCoEx_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.MCEx_ShowInnerBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.MCEx_ShowInnerBorder = false;
            }
        }

        private void circular_MultiCoEx_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[0] = colorSelector.Color;

                circular_MultiCoEx_Color1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[1] = colorSelector.Color;

                circular_MultiCoEx_Color2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[2] = colorSelector.Color;

                circular_MultiCoEx_Color3_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[3] = colorSelector.Color;

                circular_MultiCoEx_Color4_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[4] = colorSelector.Color;

                circular_MultiCoEx_Color5_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color6_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[5] = colorSelector.Color;

                circular_MultiCoEx_Color6_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color7_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[6] = colorSelector.Color;

                circular_MultiCoEx_Color7_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color8_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[7] = colorSelector.Color;

                circular_MultiCoEx_Color8_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color9_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[8] = colorSelector.Color;

                circular_MultiCoEx_Color9_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color10_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[9] = colorSelector.Color;

                circular_MultiCoEx_Color10_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color11_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[10] = colorSelector.Color;

                circular_MultiCoEx_Color11_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color12_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[11] = colorSelector.Color;

                circular_MultiCoEx_Color12_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color13_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[12] = colorSelector.Color;

                circular_MultiCoEx_Color13_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color14_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[13] = colorSelector.Color;

                circular_MultiCoEx_Color14_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color15_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[14] = colorSelector.Color;

                circular_MultiCoEx_Color15_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color16_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[15] = colorSelector.Color;

                circular_MultiCoEx_Color16_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color17_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[16] = colorSelector.Color;

                circular_MultiCoEx_Color17_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color18_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[17] = colorSelector.Color;

                circular_MultiCoEx_Color18_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color19_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[18] = colorSelector.Color;

                circular_MultiCoEx_Color19_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color20_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[19] = colorSelector.Color;

                circular_MultiCoEx_Color20_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color21_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[20] = colorSelector.Color;

                circular_MultiCoEx_Color21_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color22_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[21] = colorSelector.Color;

                circular_MultiCoEx_Color22_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color23_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[22] = colorSelector.Color;

                circular_MultiCoEx_Color23_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_Color24_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_Colors[23] = colorSelector.Color;

                circular_MultiCoEx_Color24_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_CorrectShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_CorrectShift_Height = (int)circular_MultiCoEx_CorrectShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoEx_RectangleShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_RectShift_Height = (int)circular_MultiCoEx_RectangleShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoEx_ShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCEx_Shift_Height = (int)circular_MultiCoEx_ShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoEx_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_InnerBorderColor = colorSelector.Color;

                circular_MultiCoEx_InnerBorderColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoEx_InnerColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCEx_InnerColor = colorSelector.Color;

                circular_MultiCoEx_InnerColor_Btn.BackColor = colorSelector.Color;

            }
        }

    }
}
