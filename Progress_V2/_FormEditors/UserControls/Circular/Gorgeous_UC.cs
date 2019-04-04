// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Gorgeous_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class Gorgeous_UC : UserControl
    {
        public Gorgeous_UC()
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

        private void circular_Gorgeous_Border_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Border = (int)circular_Gorgeous_Border_Numeric.Value;
        }

        private void circular_Gorgeous_ShiftInner_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ShiftInner = (int)circular_Gorgeous_ShiftInner_Numeric.Value;
        }

        private void circular_Gorgeous_ShiftInnerCover_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ShiftInnerCover = (int)circular_Gorgeous_ShiftInnerCover_Numeric.Value;
        }

        private void circular_Gorgeous_ShiftOuter_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ShiftOuter = (int)circular_Gorgeous_ShiftOuter_Numeric.Value;
        }

        private void circular_Gorgeous_ShiftSmallRect_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ShiftSmallRect = (int)circular_Gorgeous_ShiftSmallRect_Numeric.Value;
        }

        private void circular_Gorgeous_GradientColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.GradientColor[0] = colorSelector.Color;

                circular_Gorgeous_GradientColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_GradientColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.GradientColor[1] = colorSelector.Color;

                circular_Gorgeous_GradientColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SolidColors[0] = colorSelector.Color;

                circular_Gorgeous_Color1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SolidColors[1] = colorSelector.Color;

                circular_Gorgeous_Color2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_Color3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SolidColors[2] = colorSelector.Color;

                circular_Gorgeous_Color3_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_Color4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SolidColors[3] = colorSelector.Color;

                circular_Gorgeous_Color4_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_Color5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SolidColors[4] = colorSelector.Color;

                circular_Gorgeous_Color5_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Gorgeous_RotatingAngle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingAngle =
                (ZeroitThematicProgress.Gorgeous_rotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Gorgeous_rotatingAngle),
                    circular_Gorgeous_RotatingAngle_ComboBox.SelectedItem.ToString());

        }

        private void circular_Gorgeous_EnableCover_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            #region Bool

            if (circular_Gorgeous_EnableCover_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.EnableInnerCover = true;

            }
            else
            {
                ZeroitThematicProgress1.EnableInnerCover = false;
            }

            #endregion
        }

        private void circular_Gorgeous_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.GorgeousDrawMode =
                (ZeroitThematicProgress.Gorgeous_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Gorgeous_drawMode),
                    circular_Gorgeous_DrawMode_ComboBox.SelectedItem.ToString());

        }
    }
}
