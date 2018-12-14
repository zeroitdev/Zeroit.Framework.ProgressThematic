// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Clear_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgBar_Clear_UC : UserControl
    {
        
        public ProgBar_Clear_UC()
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

        private void bars_Clear_Gradient1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {

                bars_Clear_Gradient1_Btn.BackColor = colorSelector.Color;

                ZeroitThematicProgress1.ProgressBarClear_ColorGradient1 = colorSelector.Color;

            }
        }

        private void bars_Clear_Gradient2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {

                bars_Clear_Gradient2_Btn.BackColor = colorSelector.Color;

                ZeroitThematicProgress1.ProgressBarClear_ColorGradient2 = colorSelector.Color;

            }
        }

        private void bars_Clear_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {

                bars_Clear_BorderColor_Btn.BackColor = colorSelector.Color;

                ZeroitThematicProgress1.ProgressBarClear_ColorBorder = colorSelector.Color;

            }
        }

        private void bars_Clear_GlowColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {

                bars_Clear_GlowColor_Btn.BackColor = colorSelector.Color;

                ZeroitThematicProgress1.ProgressBarClear_ColorGlow = colorSelector.Color;

            }
        }
    }
}
