// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicatorUnique_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgressIndicatorUnique_UC : UserControl
    {
        public ProgressIndicatorUnique_UC()
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

        private void indicator_Unique_Rotation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_Rotation =
                (Unique_RotationType)Enum.Parse(typeof
                        (Unique_RotationType),
                    indicator_Unique_Rotation_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Unique_TextDisplay_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_TextDisplay =
                (Unique_TextDisplayModes)Enum.Parse(typeof
                        (Unique_TextDisplayModes),
                    indicator_Unique_TextDisplay_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Unique_NoOfCircles_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_NumberOfCircles =
                (float)indicator_Unique_NoOfCircles_Numeric.Value;

        }

        private void indicator_Unique_Percentage_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_Percentage =
                (float)indicator_Unique_Percentage_Numeric.Value;

        }

        private void indicator_Unique_CircleSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_CircleSize =
                (float)indicator_Unique_CircleSize_Numeric.Value;

        }

        private void indicator_Unique_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_AnimationSpeed =
                (int)indicator_Unique_AnimationSpeed_Numeric.Value;

        }

        private void indicator_Unique_NoOfVisibleCircles_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_NumberOfVisibleCircles =
                (int)indicator_Unique_NoOfVisibleCircles_Numeric.Value;

        }

        private void indicator_Unique_CircleColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Unique_CircleColor = colorSelector.Color;

                indicator_Unique_CircleColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Unique_ShowText_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Unique_ShowText_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Unique_ShowText = true;
            }
            else
            {
                ZeroitThematicProgress1.Unique_ShowText = false;
            }
        }

        private void indicator_Unique_ShowPercentage_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Unique_ShowPercentage_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.Unique_ShowPercentage = true;
            }
            else
            {
                ZeroitThematicProgress1.Unique_ShowPercentage = false;
            }
        }

        private void indicator_Unique_CustomText_TextBox_TextChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Unique_CustomText = indicator_Unique_CustomText_TextBox.Text;

        }
    }
}
