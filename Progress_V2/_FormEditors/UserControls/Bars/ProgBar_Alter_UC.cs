// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Alter_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgBar_Alter_UC : UserControl
    {
        
        public ProgBar_Alter_UC()
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

        private void bars_Alter_ColorAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressAlter_ColorAngle = (float)bars_Alter_ColorAngle_Numeric.Value;
        }

        private void bars_Alter_BackColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_BackColor_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.ProgressAlter_ColorBack = colorSelector.Color;
            }
        }

        private void bars_Alter_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_Color1_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.ProgressAlter_Color1 = colorSelector.Color;
            }
        }

        private void bars_Alter_Color2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_Color2_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.Color2 = colorSelector.Color;
            }
        }

        private void bars_Alter_Border_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_Border_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.ProgressAlter_ColorBorder = colorSelector.Color;
            }
        }

        private void bars_Alter_IC_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_IC_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.ProgressAlter_ColorIC = colorSelector.Color;
            }
        }

        private void bars_Alter_Text_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                bars_Alter_Text_Btn.BackColor = colorSelector.Color;
                ZeroitThematicProgress1.ProgressAlter_ColorText = colorSelector.Color;
            }
        }
    }
}
