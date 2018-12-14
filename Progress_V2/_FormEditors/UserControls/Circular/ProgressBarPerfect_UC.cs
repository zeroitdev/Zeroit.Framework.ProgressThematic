// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerfect_UC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    public partial class ProgressBarPerfect_UC : UserControl
    {
        public ProgressBarPerfect_UC()
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

        private void ProgressBarPerfect_UC_Load(object sender, EventArgs e)
        {

        }

        private void circular_Perfect_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressBarPerfect_AnimationSpeed = (int)circular_Perfect_AnimationSpeed_Numeric.Value;
        }

        private void circular_Perfect_CircleSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_CircleSize = (float)circular_Perfect_CircleSize_Numeric.Value;
        }

        private void circular_Perfect_NoOfCircles_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_NumberOfCircles = (int)circular_Perfect_NoOfCircles_Numeric.Value;

        }

        private void circular_Perfect_Percentage_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_Percentage = (int)circular_Perfect_Percentage_Numeric.Value;
        }

        private void circular_Perfect_NoOfVisibleCircles_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_NumberOfVisibleCircles = (int)circular_Perfect_NoOfVisibleCircles_Numeric.Value;
        }

        private void circular_Perfect_CircleColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressPerfect_CircleColor = colorSelector.Color;

                circular_Perfect_CircleColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Perfect_Rotation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_Rotation =
                (RotationType1)Enum.Parse(typeof
                        (RotationType1),
                    circular_Perfect_Rotation_ComboBox.SelectedItem.ToString());

        }

        private void circular_Perfect_TextDisplay_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressPerfect_TextDisplay =
                (TextDisplayModes1)Enum.Parse(typeof
                        (TextDisplayModes1),
                    circular_Perfect_TextDisplay_ComboBox.SelectedItem.ToString());

        }

        private void circular_Perfect_ShowText_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Perfect_ShowText_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ProgressBarPerfect_ShowText = true;

            }
            else
            {
                ZeroitThematicProgress1.ProgressBarPerfect_ShowText = false;
            }
        }

        private void circular_Perfect_ShowPercentage_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Perfect_ShowPercentage_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.ProgressPerfect_ShowPercentage = true;

            }
            else
            {
                ZeroitThematicProgress1.ProgressPerfect_ShowPercentage = false;
            }
        }

        private void circular_Perfect_CustomText_TextBox_TextChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressBarPerfect_CustomText = circular_Perfect_CustomText_TextBox.Text;
        }
    }
}
