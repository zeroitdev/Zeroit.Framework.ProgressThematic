// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Ignito_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class Ignito_UC : UserControl
    {
        public Ignito_UC()
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

        private void circular_Ignito_BorderStyleInner_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_BorderStyleInner =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    circular_Ignito_BorderStyleInner_ComboBox.SelectedItem.ToString());

        }

        private void circular_Ignito_BorderStyleOuter_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_BorderStyleOuter =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    circular_Ignito_BorderStyleOuter_ComboBox.SelectedItem.ToString());

        }

        private void circular_Ignito_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_DrawMode =
                (ZeroitThematicProgress.Ignito_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_drawMode),
                    circular_Ignito_DrawMode_ComboBox.SelectedItem.ToString());

        }

        private void circular_Ignito_OuterRotatingAngle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_OutterRotatingAngle =
                (ZeroitThematicProgress.Ignito_outterRotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_outterRotatingAngle),
                    circular_Ignito_OuterRotatingAngle_ComboBox.SelectedItem.ToString());

        }

        private void circular_Ignito_InnerRotatingAngle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_InnerRotatingAnlge =
                (ZeroitThematicProgress.Ignito_innerRotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_innerRotatingAngle),
                    circular_Ignito_InnerRotatingAngle_ComboBox.SelectedItem.ToString());


        }

        private void circular_Ignito_Caps_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_Caps =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_Ignito_Caps_ComboBox.SelectedItem.ToString());

        }

        private void circular_Ignito_OuterBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_OuterBorder = (float)circular_Ignito_OuterBorder_Numeric.Value;

        }

        private void circular_Ignito_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IG_InnerBorder = (float)circular_Ignito_InnerBorder_Numeric.Value;

        }

        private void circular_Ignito_EnableHatch_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Ignito_EnableHatch_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.IG_EnableHatch = true;

            }
            else
            {
                ZeroitThematicProgress1.IG_EnableHatch = false;
            }
        }

        private void circular_Ignito_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[0] = colorSelector.Color;

                circular_Ignito_Color1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[1] = colorSelector.Color;

                circular_Ignito_Color2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[2] = colorSelector.Color;

                circular_Ignito_Color3_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[3] = colorSelector.Color;

                circular_Ignito_Color4_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color5_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[4] = colorSelector.Color;

                circular_Ignito_Color5_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color6_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[5] = colorSelector.Color;

                circular_Ignito_Color6_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color7_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[6] = colorSelector.Color;

                circular_Ignito_Color7_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color8_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[7] = colorSelector.Color;

                circular_Ignito_Color8_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color9_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[8] = colorSelector.Color;

                circular_Ignito_Color9_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color10_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[9] = colorSelector.Color;

                circular_Ignito_Color10_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color11_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[10] = colorSelector.Color;

                circular_Ignito_Color11_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_Color12_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_Colors[11] = colorSelector.Color;

                circular_Ignito_Color12_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_GradientColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_GradientColors[0] = colorSelector.Color;

                circular_Ignito_GradientColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_GradientColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_GradientColors[1] = colorSelector.Color;

                circular_Ignito_GradientColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_GradientColor3_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_GradientColors[2] = colorSelector.Color;

                circular_Ignito_GradientColor3_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Ignito_GradientColor4_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IG_GradientColors[3] = colorSelector.Color;

                circular_Ignito_GradientColor4_Btn.BackColor = colorSelector.Color;
            }
        }
    }
}
