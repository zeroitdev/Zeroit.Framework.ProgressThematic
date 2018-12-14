﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="WinHorizontal_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class WinHorizontal_UC : UserControl
    {
        public WinHorizontal_UC()
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

        private void indicator_Win8Horiz_ControlWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Control_Width =
                (int)indicator_Win8Horiz_ControlWidth_Numeric.Value;

        }

        private void indicator_Win8Horiz_RefreshRate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Refresh_Rate =
                (int)indicator_Win8Horiz_RefreshRate_Numeric.Value;

        }

        private void indicator_Win8Horiz_IndicatorColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Indicator_Color = colorSelector.Color;

                indicator_Win8Horiz_IndicatorColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Win8Horiz_Animate_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Win8Horiz_Animate_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.WinHR_Animate = true;

            }
            else
            {
                ZeroitThematicProgress1.WinHR_Animate = false;
            }
        }
    }
}
