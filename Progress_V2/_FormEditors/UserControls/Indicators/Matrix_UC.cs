﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Matrix_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class Matrix_UC : UserControl
    {
        public Matrix_UC()
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


        private void indicator_Matrix_Automatic_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Automatic =
                (MacOSX_automatic)Enum.Parse(typeof
                        (MacOSX_automatic),
                    indicator_Matrix_Automatic_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Matrix_Rotation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_Rotation =
                (ZeroitThematicProgress.MacOSX_Direction)Enum.Parse(typeof
                        (ZeroitThematicProgress.MacOSX_Direction),
                    indicator_Matrix_Rotation_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Matrix_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_Matrix_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Matrix_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    indicator_Matrix_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void indicator_Matrix_Interval_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_Interval =
                (int)indicator_Matrix_Interval_Numeric.Value;

        }

        private void indicator_Matrix_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_StartAngle =
                (int)indicator_Matrix_StartAngle_Numeric.Value;

        }

        private void indicator_Matrix_TickColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.MacOSX_Matrix_TickColor = colorSelector.Color;

                indicator_Matrix_TickColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void indicator_Matrix_CircleCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_Matrix_SpokesCount =
                (int)indicator_Matrix_CircleCount_Numeric.Value;

        }

        private void indicator_MacOSX_MaxSpokes_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MacOSX_MaxSpokes =
                (int)indicator_MacOSX_MaxSpokes_Numeric.Value;
        }
    }
}
