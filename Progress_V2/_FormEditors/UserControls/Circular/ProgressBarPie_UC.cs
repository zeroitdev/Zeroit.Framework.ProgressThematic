// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPie_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgressBarPie_UC : UserControl
    {
        public ProgressBarPie_UC()
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

        private void circular_Pie_InnerBorderWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_InnerBorderWidth = (float)circular_Pie_InnerBorderWidth_Numeric.Value;
        }

        private void circular_Pie_Position_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_Position = (float)circular_Pie_Position_Numeric.Value;
        }

        private void circular_Pie_ProgressWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_ProgressWidth = (double)circular_Pie_ProgressWidth_Numeric.Value;
        }

        private void circular_Pie_SweepAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_SweepAngle = (float)circular_Pie_SweepAngle_Numeric.Value;
        }

        private void circular_Pie_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_WidthStartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_Pie_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_Pie_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie_WidthEndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_Pie_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_Pie_ProgressShape_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPie__ProgressShape =
                (ZeroitThematicProgress.ProgressPie_ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress.ProgressPie_ProgressShape),
                    circular_Pie_ProgressShape_ComboBox.SelectedItem.ToString());

        }

        private void circular_Pie_FillEllipse1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_FillEllipse1 = colorSelector.Color;

                circular_Pie_FillEllipse1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_FillEllipse2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_FillEllipse2 = colorSelector.Color;

                circular_Pie_FillEllipse2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_InnerBorderColor = colorSelector.Color;

                circular_Pie_InnerBorder_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_TextColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_TextColor = colorSelector.Color;

                circular_Pie_TextColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_ProgressColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_ProgressColor1 = colorSelector.Color;

                circular_Pie_ProgressColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_ProgressColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPie_ProgressColor2 = colorSelector.Color;

                circular_Pie_ProgressColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Pie_ShowText_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Pie_ShowText_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.ProgressPie_ShowText = true;

            }
            else
            {
                ZeroitThematicProgress1.ProgressPie_ShowText = false;

            }
        }
    }
}
