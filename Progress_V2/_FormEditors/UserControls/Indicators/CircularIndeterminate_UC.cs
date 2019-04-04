// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularIndeterminate_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class CircularIndeterminate_UC : UserControl
    {
        public CircularIndeterminate_UC()
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

        private void indicator_Indeterminate_IndicatorType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IndicatorType =
                (ZeroitThematicProgress.INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.INDICATORTYPES),
                    indicator_Indeterminate_IndicatorType_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Indeterminate_CirclesCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CirclesCount =
                (int)indicator_Indeterminate_CirclesCount_Numeric.Value;
        }

        private void indicator_Indeterminate_IndicatorDiameter_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IndicatorDiameter =
                (int)indicator_Indeterminate_IndicatorDiameter_Numeric.Value;

        }

        private void indicator_Indeterminate_ControlSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ControlWidthHeight =
                (int)indicator_Indeterminate_ControlSize_Numeric.Value;

        }

        private void indicator_Indeterminate_RefreshRate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RefreshRate =
                (int)indicator_Indeterminate_RefreshRate_Numeric.Value;

        }

        private void indicator_Indeterminate_BackgroundColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.BackgroundColor = colorSelector.Color;

                indicator_Indeterminate_BackgroundColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void indicator_Indeterminate_IndicatorColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IndicatorColor = colorSelector.Color;

                indicator_Indeterminate_IndicatorColor_Btn.BackColor = colorSelector.Color;
            }
        }
    }
}
