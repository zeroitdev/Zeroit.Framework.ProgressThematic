// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtendedV1_UC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    public partial class ZeroitMultiCoExtendedV1_UC : UserControl
    {
        public ZeroitMultiCoExtendedV1_UC()
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



        private void circular_MultiCoExV1_NoOfRings_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    circular_MultiCoExV1_NoOfRings_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoExV1_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_InnerBorder = (int)circular_MultiCoExV1_InnerBorder_Numeric.Value;

        }

        private void circular_MultiCoExV1_CorrectShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_CorrectShift = (int)circular_MultiCoExV1_CorrectShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoExV1_RectangleShift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_RectShift = (int)circular_MultiCoExV1_RectangleShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoExV1_Shift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_Shift = (int)circular_MultiCoExV1_ShiftWidth_Numeric.Value;

        }

        private void circular_MultiCoExV1_ShowInnerBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_MultiCoExV1_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ShowInnerBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.ShowInnerBorder = false;
            }
        }

        private void circular_MultiCoExV1_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[0] = colorSelector.Color;

                circular_MultiCoExV1_Color1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[1] = colorSelector.Color;

                circular_MultiCoExV1_Color2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[2] = colorSelector.Color;

                circular_MultiCoExV1_Color3_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[3] = colorSelector.Color;

                circular_MultiCoExV1_Color4_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[4] = colorSelector.Color;

                circular_MultiCoExV1_Color5_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color6_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[5] = colorSelector.Color;

                circular_MultiCoExV1_Color6_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color7_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[6] = colorSelector.Color;

                circular_MultiCoExV1_Color7_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color8_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[7] = colorSelector.Color;

                circular_MultiCoExV1_Color8_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color9_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[8] = colorSelector.Color;

                circular_MultiCoExV1_Color9_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color10_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[9] = colorSelector.Color;

                circular_MultiCoExV1_Color10_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color11_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[10] = colorSelector.Color;

                circular_MultiCoExV1_Color11_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color12_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[11] = colorSelector.Color;

                circular_MultiCoExV1_Color12_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color13_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[12] = colorSelector.Color;

                circular_MultiCoExV1_Color13_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color14_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[13] = colorSelector.Color;

                circular_MultiCoExV1_Color14_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color15_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[14] = colorSelector.Color;

                circular_MultiCoExV1_Color15_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color16_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[15] = colorSelector.Color;

                circular_MultiCoExV1_Color16_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color17_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[16] = colorSelector.Color;

                circular_MultiCoExV1_Color17_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color18_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[17] = colorSelector.Color;

                circular_MultiCoExV1_Color18_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color19_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[18] = colorSelector.Color;

                circular_MultiCoExV1_Color19_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color20_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[19] = colorSelector.Color;

                circular_MultiCoExV1_Color20_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color21_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[20] = colorSelector.Color;

                circular_MultiCoExV1_Color21_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color22_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[21] = colorSelector.Color;

                circular_MultiCoExV1_Color22_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color23_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[22] = colorSelector.Color;

                circular_MultiCoExV1_Color23_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_Color24_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_Colors[23] = colorSelector.Color;

                circular_MultiCoExV1_Color24_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_CorrectShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_CorrectShift_Height = (int)circular_MultiCoExV1_CorrectShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoExV1_RectangleShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_RectShift_Height = (int)circular_MultiCoExV1_RectangleShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoExV1_ShiftHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_Shift_Height = (int)circular_MultiCoExV1_ShiftHeight_Numeric.Value;

        }

        private void circular_MultiCoExV1_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_InnerBorderColor = colorSelector.Color;

                circular_MultiCoExV1_InnerBorderColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_InnerColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_InnerColor = colorSelector.Color;

                circular_MultiCoExV1_InnerColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_MultiCoExV1_OuterBorderStart_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_OuterBorderStart =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_MultiCoExV1_OuterBorderStart_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoExV1_OuterBorderEnd_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_OuterBorderEnd =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_MultiCoExV1_OuterBorderEnd_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoExV1_OuterBorderStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_OuterBorderStyle =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    circular_MultiCoExV1_OuterBorderStyle_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoExV1_GradientAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_GradientAngle = (float)circular_MultiCoExV1_GradientAngle_Numeric.Value;

        }

        private void circular_MultiCoExV1_DivisionsWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_DivisionsWidth = (int)circular_MultiCoExV1_DivisionsWidth_Numeric.Value;

        }

        private void circular_MultiCoExV1_OuterBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_MultiCoExV1_OuterBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.MCExV2_OuterBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.MCExV2_OuterBorder = false;
            }
        }

        private void circular_MultiCoExV1_Divisions_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_MultiCoExV1_Divisions_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.MCExV2_Divisions = true;
            }
            else
            {
                ZeroitThematicProgress1.MCExV2_Divisions = false;
            }

        }

        private void circular_MultiCoExV1_InnerHoleGrad1_Btn_Click(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_InnerHoleGradCol[0] = circular_MultiCoExV1_InnerHoleGrad1_Btn.BackColor;

        }

        private void circular_MultiCoExV1_InnerHoleGrad2_Btn_Click(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_InnerHoleGradCol[1] = circular_MultiCoExV1_InnerHoleGrad2_Btn.BackColor;

        }

        private void circular_MultiCoExV1_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_DrawMode =
                (drawMode)Enum.Parse(typeof
                        (drawMode),
                    circular_MultiCoExV1_DrawMode_ComboBox.SelectedItem.ToString());

        }

        private void circular_MultiCoExV1_OuterBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_OuterBorderWidth = (int)circular_MultiCoExV1_OuterBorder_Numeric.Value;

        }

        private void circular_MultiCoExV1_OuterColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_OuterColor[0] = colorSelector.Color;

                circular_MultiCoExV1_OuterColor1_Btn.BackColor = colorSelector.Color;

            }


        }

        private void circular_MultiCoExV1_OuterColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MCExV2_OuterColor[1] = colorSelector.Color;

                circular_MultiCoExV1_OuterColor2_Btn.BackColor = colorSelector.Color;

            }

        }

        private void circular_MultiCoExV1_HorizontalTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_Position_Horizontal = (int)circular_MultiCoExV1_HorizontalTweak_Numeric.Value;

        }

        private void circular_MultiCoExV1_VerticalTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MCExV2_Position_Vertical = (int)circular_MultiCoExV1_VerticalTweak_Numeric.Value;

        }
    }
}
