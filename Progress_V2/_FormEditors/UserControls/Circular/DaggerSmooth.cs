// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerSmooth.cs" company="Zeroit Dev Technologies">
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
    public partial class DaggerSmooth_UC : UserControl
    {
        public DaggerSmooth_UC()
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

        private void circular_DaggerSmooth_FilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothFilledThickness = (int)circular_DaggerSmooth_FilledThickness_Numeric.Value;

        }

        private void circular_DaggerSmooth_InnerFilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothFilledThicknessInner = (int)circular_DaggerSmooth_InnerFilledThickness_Numeric.Value;

        }

        private void circular_DaggerSmooth_UnfilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothUnfilledThickness = (int)circular_DaggerSmooth_UnfilledThickness_Numeric.Value;

        }

        private void circular_DaggerSmooth_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothAnimSpeed = (int)circular_DaggerSmooth_AnimationSpeed_Numeric.Value;

        }

        private void circular_DaggerSmooth_EndAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothEndAngle = (int)circular_DaggerSmooth_EndAngle_Numeric.Value;

        }

        private void circular_DaggerSmooth_OuterTransparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothFilledColorAlpha = (int)circular_DaggerSmooth_OuterTransparency_Numeric.Value;

        }

        private void circular_DaggerSmooth_InnerTransparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagSmoothFilledColorAlphaInner = (int)circular_DaggerSmooth_InnerTransparency_Numeric.Value;

        }

        private void circular_DaggerSmooth_FilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagSmoothFilledColor = colorSelector.Color;

                circular_DaggerSmooth_FilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerSmooth_UnfilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagSmoothUnFilledColor = colorSelector.Color;

                circular_DaggerSmooth_UnfilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerSmooth_InnerFilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagSmoothInnerFilledColor = colorSelector.Color;

                circular_DaggerSmooth_InnerFilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerSmooth_Animated_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerSmooth_Animated_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.DagSmoothIsAnimated = true;

            }
            else
            {
                ZeroitThematicProgress1.DagSmoothIsAnimated = false;

            }
        }

        private void circular_DaggerSmooth_AnimateEndAngle_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerSmooth_AnimateEndAngle_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.DagSmoothAnimEndAngle = true;
            }
            else
            {
                ZeroitThematicProgress1.DagSmoothAnimEndAngle = false;
            }

        }

        private void circular_DaggerSmooth_Rotate_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerSmooth_Rotate_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.DagSmoothRotate = true;

            }
            else
            {
                ZeroitThematicProgress1.DagSmoothRotate = false;
            }
        }
    }
}
