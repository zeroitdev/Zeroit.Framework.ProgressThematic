// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingArc_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class RotatingArc_UC : UserControl
    {
        public RotatingArc_UC()
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

        private void circular_Arc_RotatingType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingType =
                (ZeroitThematicProgress.PieArc)Enum.Parse(typeof
                        (ZeroitThematicProgress.PieArc),
                    circular_Arc_RotatingType_ComboBox.SelectedItem.ToString());
        }

        private void circular_Arc_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingArc_DrawMode =
                (ZeroitThematicProgress.RotatingArc_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.RotatingArc_drawMode),
                    circular_Arc_DrawMode_ComboBox.SelectedItem.ToString());

        }

        private void circular_Arc_Circle1HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle1HeightReduction = (int)circular_Arc_Circle1HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle2HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle2HeightReduction = (int)circular_Arc_Circle2HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle3HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle3HeightReduction = (int)circular_Arc_Circle3HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle4HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle4HeightReduction = (int)circular_Arc_Circle4HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle5HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle5HeightReduction = (int)circular_Arc_Circle5HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle6HeightRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle6HeightReduction = (int)circular_Arc_Circle6HeightRed_Numeric.Value;
        }

        private void circular_Arc_Circle1WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle1WidthReduction = (int)circular_Arc_Circle1WidthRed_Numeric.Value;
        }

        private void circular_Arc_Circle2WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle2WidthReduction = (int)circular_Arc_Circle2WidthRed_Numeric.Value;
        }

        private void circular_Arc_Circle3WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle3WidthReduction = (int)circular_Arc_Circle3WidthRed_Numeric.Value;
        }

        private void circular_Arc_Circle4WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle4WidthReduction = (int)circular_Arc_Circle4WidthRed_Numeric.Value;
        }

        private void circular_Arc_Circle5WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle5WidthReduction = (int)circular_Arc_Circle5WidthRed_Numeric.Value;
        }

        private void circular_Arc_Circle6WidthRed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Innercircle6WidthReduction = (int)circular_Arc_Circle6WidthRed_Numeric.Value;
        }

        private void circular_Arc_FillPie_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {

            // Fill Pie
            if (circular_Arc_FillPie_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.FillPie = true;
            }

            else
            {
                ZeroitThematicProgress1.FillPie = false;
            }

        }

        private void circular_Arc_HeartSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.HeartTimerInterval = (int)circular_Arc_HeartSpeed_Numeric.Value;
        }

        private void circular_Arc_LineSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.LineSize = (int)circular_Arc_LineSize_Numeric.Value;
        }

        private void circular_Arc_InnerCircleBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerCircleBorder = (int)circular_Arc_InnerCircleBorder_Numeric.Value;
        }

        private void circular_Arc_HeartBeat_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // HeartBeat
            if (circular_Arc_HeartBeat_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.HeartBeat = true;

            }
            else
            {
                ZeroitThematicProgress1.HeartBeat = false;
            }
        }

        private void circular_Arc_RotatingBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Rotating Border
            if (circular_Arc_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.RotatingBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.RotatingBorder = false;
            }
        }

        private void circular_Arc_ShowLine_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Line
            if (circular_Arc_ShowLine_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.RotatingBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.RotatingBorder = false;
            }
        }

        private void circular_Arc_ShowCircle1_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Inner Circle 1
            if (circular_Arc_ShowCircle1_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle1 = true;

            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle1 = false;
            }
        }

        private void circular_Arc_ShowCircle2_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Arc_ShowCircle2_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle2 = true;

            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle2 = false;
            }
        }

        private void circular_Arc_ShowCircle3_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Inner Circle 3
            if (circular_Arc_ShowCircle3_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle3 = true;

            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle3 = false;
            }
        }

        private void circular_Arc_ShowCircle4_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Inner Circle 4
            if (circular_Arc_ShowCircle4_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle4 = true;
            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle4 = false;
            }
        }

        private void circular_Arc_ShowCircle5_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Inner Circle 5
            if (circular_Arc_ShowCircle5_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle5 = true;
            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle5 = false;
            }
        }

        private void circular_Arc_ShowCircle6_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // Show Inner Circle 6
            if (circular_Arc_ShowCircle6_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerCircle6 = true;

            }
            else
            {
                ZeroitThematicProgress1.ShowInnerCircle6 = false;
            }
        }

        private void circular_Arc_Circ1Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle1Grad1 = colorSelector.Color;

                circular_Arc_Circ1Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ1Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle1Grad2 = colorSelector.Color;

                circular_Arc_Circ1Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ2Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle2Grad1 = colorSelector.Color;

                circular_Arc_Circ2Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ2Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle2Grad2 = colorSelector.Color;

                circular_Arc_Circ2Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ3Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle3Grad1 = colorSelector.Color;

                circular_Arc_Circ3Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ3Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle3Grad2 = colorSelector.Color;

                circular_Arc_Circ3Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ4Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle4Grad1 = colorSelector.Color;

                circular_Arc_Circ4Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ4Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle4Grad2 = colorSelector.Color;

                circular_Arc_Circ4Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ5Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle5Grad1 = colorSelector.Color;

                circular_Arc_Circ5Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ5Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle5Grad2 = colorSelector.Color;

                circular_Arc_Circ5Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ6Grad1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle6Grad1 = colorSelector.Color;

                circular_Arc_Circ6Grad1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_Circ6Grad2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerCircle6Grad2 = colorSelector.Color;

                circular_Arc_Circ6Grad2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_OuterBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorOuterBorder = colorSelector.Color;

                circular_Arc_OuterBorder_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_FadeColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CustomFadeColor = colorSelector.Color;

                circular_Arc_FadeColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_LineColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.LineColor1 = colorSelector.Color;

                circular_Arc_LineColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_LineColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.LineColor2 = colorSelector.Color;

                circular_Arc_LineColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_PieColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.PieColor1 = colorSelector.Color;

                circular_Arc_PieColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_PieColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.PieColor2 = colorSelector.Color;

                circular_Arc_PieColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Arc_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingArc_StartAngle = (float)circular_Arc_StartAngle_Numeric.Value;
        }

        private void circular_Arc_SweepAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RotatingArc_SweepAngle = (float)circular_Arc_SweepAngle_Numeric.Value;

        }
    }
}
