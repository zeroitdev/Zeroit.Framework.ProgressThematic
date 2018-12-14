// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicator_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgressIndicator_UC : UserControl
    {
        public ProgressIndicator_UC()
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

        private void indicator_ProgIndicator_BaseColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.P_BaseColor = colorSelector.Color;

                indicator_ProgIndicator_BaseColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_ProgIndicator_AnimationColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.P_AnimationColor = colorSelector.Color;

                indicator_ProgIndicator_AnimationColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_ProgIndicator_CircleWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgIndicator_CircleWidth =
                (int)indicator_ProgIndicator_CircleWidth_Numeric.Value;

        }

        private void indicator_ProgIndicator_NoOfCircles_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgIndicator_NumberOfCircles =
                (int)indicator_ProgIndicator_NoOfCircles_Numeric.Value;

        }

        private void indicator_ProgIndicator_Radian_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgIndicator_Radian =
                (int)indicator_ProgIndicator_Radian_Numeric.Value;

        }
    }
}
