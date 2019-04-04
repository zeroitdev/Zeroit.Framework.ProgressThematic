// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingCompass_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class RotatingCompass_UC : UserControl
    {
        public RotatingCompass_UC()
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

        private void RotatingCompass_UC_Load(object sender, EventArgs e)
        {

        }

        private void circular_Compass_LineSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingCompass_LineSize = (int)circular_Compass_LineSize_Numeric.Value;

        }

        private void circular_Compass_PieColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.RotatingCompass_PieColor1 = colorSelector.Color;

                circular_Compass_PieColor1_Btn.BackColor = colorSelector.Color;

            }

        }

        private void circular_Compass_PieColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.RotatingCompass_PieColor2 = colorSelector.Color;

                circular_Compass_PieColor2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Compass_LineColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.RotatingCompass_LineColor1 = colorSelector.Color;

                circular_Compass_LineColor1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Compass_LineColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.RotatingCompass_LineColor2 = colorSelector.Color;

                circular_Compass_LineColor2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Compass_FillPie_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Compass_FillPie_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.RotatingCompass_FillPie = true;

            }
            else
            {
                ZeroitThematicProgress1.RotatingCompass_FillPie = false;
            }

        }

        private void circular_Compass_RotatingBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {

            if (circular_Compass_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.RotatingCompass_RotatingBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.RotatingCompass_RotatingBorder = false;
            }

        }
    }
}
