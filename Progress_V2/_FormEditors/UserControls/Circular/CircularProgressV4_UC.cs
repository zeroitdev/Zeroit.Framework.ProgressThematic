// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV4_UC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    public partial class CircularProgressV4_UC : UserControl
    {
        public CircularProgressV4_UC()
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

        private void circular_V4_Thickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_Thickness = (int)circular_V4_Thickness_Numeric.Value;
        }

        private void circular_V4_GradientAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_GradientAngle = (int)circular_V4_GradientAngle_Numeric.Value;
        }

        private void circular_V4_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_StartAngle = (int)circular_V4_StartAngle_Numeric.Value;
        }

        private void circular_V4_ProgressColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_ProgressGrad1 = colorSelector.Color;

                circular_V4_ProgressColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_ProgressColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_ProgressGrad2 = colorSelector.Color;

                circular_V4_ProgressColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_BackColor1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_ProgressBackGrad1 = colorSelector.Color;

                circular_V4_BackColor1_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_BackColor2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_ProgressBackGrad2 = colorSelector.Color;

                circular_V4_BackColor2_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_InnerBorder = colorSelector.Color;

                circular_V4_InnerBorder_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_OuterBorder_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_OuterBorder = colorSelector.Color;

                circular_V4_OuterBorder_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V4_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_V4_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_V4_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_V4_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_V4_InnerBorderThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_InnerBorderThickness = (int)circular_V4_InnerBorderThickness_Numeric.Value;
        }

        private void circular_V4_OuterBorderThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv4_OuterBorderThickness = (int)circular_V4_OuterBorderThickness_Numeric.Value;
        }

        private void circular_V4_FillEllipse1_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_FillEllipse[0] = colorSelector.Color;

                circular_V4_FillEllipse1_Btn.BackColor = colorSelector.Color;
            }
            
        }

        private void circular_V4_FillEllipse2_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.CPv4_FillEllipse[1] = colorSelector.Color;

                circular_V4_FillEllipse2_Btn.BackColor = colorSelector.Color;
            }
            
        }
    }
}
