// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularIndeterminate_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class CircularIndeterminate_UC : UserControl
    {
        public CircularIndeterminate_UC()
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

        private void indicator_Indeterminate_IndicatorType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IndicatorType =
                (ZeroitThematicProgress.INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.INDICATORTYPES),
                    indicator_Indeterminate_IndicatorType_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Indeterminate_CirclesCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CirclesCount =
                (int)indicator_Indeterminate_CirclesCount_Numeric.Value;
        }

        private void indicator_Indeterminate_IndicatorDiameter_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IndicatorDiameter =
                (int)indicator_Indeterminate_IndicatorDiameter_Numeric.Value;

        }

        private void indicator_Indeterminate_ControlSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ControlWidthHeight =
                (int)indicator_Indeterminate_ControlSize_Numeric.Value;

        }

        private void indicator_Indeterminate_RefreshRate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.RefreshRate =
                (int)indicator_Indeterminate_RefreshRate_Numeric.Value;

        }

        private void indicator_Indeterminate_BackgroundColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.BackgroundColor = colorSelector.Color;

                indicator_Indeterminate_BackgroundColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void indicator_Indeterminate_IndicatorColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.IndicatorColor = colorSelector.Color;

                indicator_Indeterminate_IndicatorColor_Btn.BackColor = colorSelector.Color;
            }
        }
    }
}
