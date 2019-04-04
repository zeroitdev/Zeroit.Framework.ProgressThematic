// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SpinnerCircle_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class SpinnerCircle_UC : UserControl
    {
        public SpinnerCircle_UC()
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

        private void indicator_SpinnerCircle_StylePreset_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.StylePreset =
                (ZeroitThematicProgress.StylePresets)Enum.Parse(typeof
                        (ZeroitThematicProgress.StylePresets),
                    indicator_SpinnerCircle_StylePreset_ComboBox.SelectedItem.ToString());

            if (ZeroitThematicProgress1.StylePreset == ZeroitThematicProgress.StylePresets.MacOSX)
            {
                indicator_SpinnerCircle_InnerCircRadius_Numeric.Maximum = 5;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Maximum = 11;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Maximum = 12;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Maximum = 2;

                indicator_SpinnerCircle_InnerCircRadius_Numeric.Value = 5;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Value = 11;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Value = 12;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Value = 2;

                
            }
            else if (ZeroitThematicProgress1.StylePreset == ZeroitThematicProgress.StylePresets.Firefox)
            {
                indicator_SpinnerCircle_InnerCircRadius_Numeric.Maximum = 6;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Maximum = 7;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Maximum = 9;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Maximum = 4;

                indicator_SpinnerCircle_InnerCircRadius_Numeric.Value = 6;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Value = 7;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Value = 9;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Value = 4;

                
            }
            else if (ZeroitThematicProgress1.StylePreset == ZeroitThematicProgress.StylePresets.IE7)
            {
                indicator_SpinnerCircle_InnerCircRadius_Numeric.Maximum = 8;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Maximum = 9;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Maximum = 24;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Maximum = 4;

                indicator_SpinnerCircle_InnerCircRadius_Numeric.Value = 8;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Value = 9;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Value = 24;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Value = 4;

                
            }

            else if (ZeroitThematicProgress1.StylePreset == ZeroitThematicProgress.StylePresets.Zeroit)
            {
                indicator_SpinnerCircle_InnerCircRadius_Numeric.Maximum = 45;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Maximum = 50;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Maximum = 255;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Maximum = 10;

                indicator_SpinnerCircle_InnerCircRadius_Numeric.Value = 45;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Value = 50;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Value = 255;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Value = 10;
                
            }
            else
            {
                indicator_SpinnerCircle_InnerCircRadius_Numeric.Maximum = 10000;
                indicator_SpinnerCircle_OuterCircRadius_Numeric.Maximum = 10000;
                indicator_SpinnerCircle_NoOfSpoke_Numeric.Maximum = 10000;
                indicator_SpinnerCircle_SpokeThickness_Numeric.Maximum = 10000;
            }
        }

        private void indicator_SpinnerCircle_InnerCircRadius_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerCircleRadius =
                (int)indicator_SpinnerCircle_InnerCircRadius_Numeric.Value;

        }

        private void indicator_SpinnerCircle_NoOfSpoke_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.NumberSpoke =
                (int)indicator_SpinnerCircle_NoOfSpoke_Numeric.Value;

        }

        private void indicator_SpinnerCircle_OuterCircRadius_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.OuterCircleRadius =
                (int)indicator_SpinnerCircle_OuterCircRadius_Numeric.Value;

        }

        private void indicator_SpinnerCircle_RotationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotationSpeed =
                (int)indicator_SpinnerCircle_RotationSpeed_Numeric.Value;

        }

        private void indicator_SpinnerCircle_SpokeThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SpokeThickness =
                (int)indicator_SpinnerCircle_SpokeThickness_Numeric.Value;

        }

        private void indicator_SpinnerCircle_SpokeColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SpokeColor = colorSelector.Color;

                indicator_SpinnerCircle_SpokeColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_SpinnerCircle_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Spinner_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_SpinnerCircle_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void indicator_SpinnerCircle_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Spinner_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_SpinnerCircle_EndCap_ComboBox.SelectedItem.ToString());

        }
    }
}
