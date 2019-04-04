// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="GoogleProgress_UC.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
    public partial class GoogleProgress_UC : UserControl
    {
        public GoogleProgress_UC()
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

        private void indicator_GoogleProg_IndicatorType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.GoogleProgress_IndicatorType =
                (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES),
                    indicator_GoogleProg_IndicatorType_ComboBox.SelectedItem.ToString());

        }

        private void indicator_GoogleProg_ColorAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ColorAngle =
                (float)indicator_GoogleProg_ColorAngle_Numeric.Value;

        }

        private void indicator_GoogleProg_RefreshRate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.GoogleProgress_RefreshRate =
                (int)indicator_GoogleProg_RefreshRate_Numeric.Value;

        }

        private void indicator_GoogleProg_IndicatorAngularAdv_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.IndicatorAngularAdvance =
                (int)indicator_GoogleProg_IndicatorAngularAdv_Numeric.Value;

        }

        private void indicator_GoogleProg_InnerRadius_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerRadius =
                (int)indicator_GoogleProg_InnerRadius_Numeric.Value;

        }

        private void indicator_GoogleProg_OuterRadius_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.OuterRadius =
                (int)indicator_GoogleProg_OuterRadius_Numeric.Value;

        }

        private void indicator_GoogleProg_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerBorder =
                (int)indicator_GoogleProg_InnerBorder_Numeric.Value;

        }

        private void indicator_GoogleProg_AnnulusColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.AnnulusColor = colorSelector.Color;

                indicator_GoogleProg_AnnulusColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_BicCirc1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Color1Bigcircle = colorSelector.Color;

                indicator_GoogleProg_BicCirc1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_BicCirc2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Color2Bigcircle = colorSelector.Color;

                indicator_GoogleProg_BicCirc2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_IndicatorCol1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Color1Indicator = colorSelector.Color;

                indicator_GoogleProg_IndicatorCol1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_IndicatorCol2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Color2Indicator = colorSelector.Color;

                indicator_GoogleProg_IndicatorCol2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_TransitionColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.TransitionColor = colorSelector.Color;

                indicator_GoogleProg_TransitionColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_IndicatorColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.GoogleProgress_IndicatorColor = colorSelector.Color;

                indicator_GoogleProg_IndicatorColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ColorInnerBorder = colorSelector.Color;

                indicator_GoogleProg_InnerBorder_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_GoogleProg_Background_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.GoogleProgress_BackgroundColor = colorSelector.Color;

                indicator_GoogleProg_Background_Btn.BackColor = colorSelector.Color;

            }
        }
    }
}
