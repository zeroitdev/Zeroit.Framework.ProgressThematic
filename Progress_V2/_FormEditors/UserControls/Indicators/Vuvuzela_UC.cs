// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Vuvuzela_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class Vuvuzela_UC : UserControl
    {
        public Vuvuzela_UC()
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

        private void indicator_Vuvuzela_Shape_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Shape =
                (ZeroitThematicProgress.Vuvuzela_Shape)Enum.Parse(typeof
                        (ZeroitThematicProgress.Vuvuzela_Shape),
                    indicator_Vuvuzela_Shape_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Vuvuzela_ControlSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ControlSize =
                (int)indicator_Vuvuzela_ControlSize_Numeric.Value;

        }

        private void indicator_Vuvuzela_Angle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Vuvuzela_Angle =
                (float)indicator_Vuvuzela_Angle_Numeric.Value;

        }

        private void indicator_Vuvuzela_CircleSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Vuvuzela_CircleSize =
                (int)indicator_Vuvuzela_CircleSize_Numeric.Value;
        }

        private void indicator_Vuvuzela_Circle1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Vuvuzela_Circle1 = colorSelector.Color;

                indicator_Vuvuzela_Circle1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Vuvuzela_Circle2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Vuvuzela_Circle2 = colorSelector.Color;

                indicator_Vuvuzela_Circle2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Vuvuzela_Circle3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Vuvuzela_Circle3 = colorSelector.Color;

                indicator_Vuvuzela_Circle3_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Vuvuzela_Circle4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Vuvuzela_Circle4 = colorSelector.Color;

                indicator_Vuvuzela_Circle4_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Vuvuzela_Circle5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Vuvuzela_Circle5 = colorSelector.Color;

                indicator_Vuvuzela_Circle5_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Vuvuzela_RotatingBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Vuvuzela_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Vuvuzela_RotatingBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.Vuvuzela_RotatingBorder = false;
            }
        }

        private void indicator_Vuvuzela_FillPie_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Vuvuzela_FillPie_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Vuvuzela_FillPie = true;

            }
            else
            {
                ZeroitThematicProgress1.Vuvuzela_FillPie = false;
            }
        }

        private void indicator_Vuvuzela_HorizontalSpacing_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Vuvuzela_HorizontalSpacing =
                (int)indicator_Vuvuzela_HorizontalSpacing_Numeric.Value;

        }

        private void indicator_Vuvuzela_VerticalSpacing_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Vuvuzela_VerticalSpacing =
                (int)indicator_Vuvuzela_VerticalSpacing_Numeric.Value;

        }
    }
}
