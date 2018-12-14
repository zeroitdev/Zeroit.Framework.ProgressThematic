﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV2_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class CircularProgressV2_UC : UserControl
    {
        public CircularProgressV2_UC()
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

        private void circular_V2_ProgressWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv2_ProgressWidth = (int)circular_V2_ProgressWidth_Numeric.Value;
        }

        private void circular_V2_Shift_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv2_Shift = (int)circular_V2_Shift_Numeric.Value;
        }

        private void circular_V2_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv2_StartAngle = (int)circular_V2_StartAngle_Numeric.Value;
        }

        private void circular_V2_EmptyColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv2_ColorEmpty = colorSelector.Color;

                circular_V2_EmptyColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V2_Color_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv2_Color = colorSelector.Color;

                circular_V2_Color_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V2_AngleReduced_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv2_AngleReduced = (int)circular_V2_AngleReduced_Numeric.Value;
        }
    }
}
