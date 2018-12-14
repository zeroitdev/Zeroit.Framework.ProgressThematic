// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Dagger.cs" company="Zeroit Dev Technologies">
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
    public partial class Dagger_UC : UserControl
    {
        public Dagger_UC()
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

        private void circular_Dagger_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagStartAngle = (int)circular_Dagger_StartAngle_Numeric.Value;
        }

        private void circular_Dagger_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagAnimSpeed = (int)circular_Dagger_AnimationSpeed_Numeric.Value;

        }

        private void circular_Dagger_Transparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagFilledColorAlpha = (int)circular_Dagger_Transparency_Numeric.Value;

        }

        private void circular_Dagger_FilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagFilledThickness = (int)circular_Dagger_FilledThickness_Numeric.Value;

        }

        private void circular_Dagger_UnfilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUnfilledThickness = (int)circular_Dagger_UnfilledThickness_Numeric.Value;

        }

        private void circular_Dagger_FilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagFilledColor = colorSelector.Color;

                circular_Dagger_FilledColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Dagger_UnfilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagUnFilledColor = colorSelector.Color;

                circular_Dagger_UnfilledColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Dagger_Animated_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_Dagger_Animated_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.DagIsAnimated = true;
            }
            else
            {
                ZeroitThematicProgress1.DagIsAnimated = false;
            }
        }
    }
}
