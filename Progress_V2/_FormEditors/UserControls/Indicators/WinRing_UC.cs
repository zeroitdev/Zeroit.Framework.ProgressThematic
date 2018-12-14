// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="WinRing_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class WinRing_UC : UserControl
    {
        public WinRing_UC()
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


        private void indicator_Win8Ring_ControlHeight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Control_Height =
                (int)indicator_Win8Ring_ControlWidth_Numeric.Value;

        }

        private void indicator_Win8Ring_RefreshRate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.WinRing_Refresh_Rate =
                (int)indicator_Win8Ring_RefreshRate_Numeric.Value;

        }

        private void indicator_Win8Ring_IndicatorColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.WinRing_Indicator_Color = colorSelector.Color;

                indicator_Win8Ring_IndicatorColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Win8Ring_Animate_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (indicator_Win8Ring_Animate_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.WinRing_Animate = true;

            }
            else
            {
                ZeroitThematicProgress1.WinRing_Animate = false;
            }
        }
    }
}
