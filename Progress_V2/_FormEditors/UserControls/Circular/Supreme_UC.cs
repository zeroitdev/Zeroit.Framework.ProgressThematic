// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Supreme_UC.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    [ToolboxItem(false)]
    public partial class Supreme_UC : UserControl
    {
        public Supreme_UC()
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

        private void circular_Supreme_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_DrawMode =
                (ZeroitThematicProgress.Supreme_colorMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Supreme_colorMode),
                    circular_Supreme_DrawMode_ComboBox.SelectedItem.ToString());

        }

        private void circular_Supreme_GradientMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    circular_Supreme_GradientMode_ComboBox.SelectedItem.ToString());

        }

        private void circular_Supreme_OuterBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_OuterBorder = (int)circular_Supreme_OuterBorder_Numeric.Value;

        }

        private void circular_Supreme_InnerBorder_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_InnerBorder = (int)circular_Supreme_InnerBorder_Numeric.Value;

        }

        private void circular_Supreme_Angle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_Angle = (float)circular_Supreme_Angle_Numeric.Value;

        }

        private void circular_Supreme_GradColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SP_GradientColor[0] = colorSelector.Color;

                circular_Supreme_GradColor1_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Supreme_GradColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SP_GradientColor[1] = colorSelector.Color;

                circular_Supreme_GradColor2_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Supreme_OuterColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SP_OuterColor = colorSelector.Color;

                circular_Supreme_OuterColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Supreme_ProgressColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SP_ProgressColor = colorSelector.Color;

                circular_Supreme_ProgressColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_Supreme_SolidColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                colorSelector.Color = Color.Transparent;
                ZeroitThematicProgress1.SP_SolidColor = colorSelector.Color;

                circular_Supreme_SolidColor_Btn.BackColor = colorSelector.Color;

            }
            else
            {
                if (colorSelector.ShowDialog() == DialogResult.OK)
                {

                    ZeroitThematicProgress1.SP_SolidColor = colorSelector.Color;

                    circular_Supreme_SolidColor_Btn.BackColor = colorSelector.Color;


                }
            }
            
        }

        private void circular_Supreme_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Supreme_Type =
                (ZeroitThematicProgress.Supreme_type)Enum.Parse(typeof
                        (ZeroitThematicProgress.Supreme_type),
                    circular_Supreme_Type_ComboBox.SelectedItem.ToString());


        }

        private void circular_Supreme_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Supreme_StartAngle = (float)circular_Supreme_StartAngle_Numeric.Value;

        }

        private void circular_Supreme_SweepAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Supreme_SweepAngle = (float)circular_Supreme_SweepAngle_Numeric.Value;

        }

        private void circular_Supreme_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Supreme_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_Supreme_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_Supreme_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Supreme_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_Supreme_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_Supreme_HorizontalTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_Position_Horizontal = (int)circular_Supreme_HorizontalTweak_Numeric.Value;

        }

        private void circular_Supreme_VerticalTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_Position_Vertical = (int)circular_Supreme_VerticalTweak_Numeric.Value;

        }

        private void circular_Supreme_WidthTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_Width_Tweak = (int)circular_Supreme_WidthTweak_Numeric.Value;

        }

        private void circular_Supreme_HeightTweak_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SP_Height_Tweak = (int)circular_Supreme_HeightTweak_Numeric.Value;

        }
    }
}
