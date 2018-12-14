// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Splitter_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgBar_Splitter_UC : UserControl
    {
        public ProgBar_Splitter_UC()
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

        private void bars_Splitter_BorderStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Splitter_BoderStyle =
                (TProgressBarBorderStyle)Enum.Parse(typeof
                        (TProgressBarBorderStyle),
                    bars_Splitter_BorderStyle_ComboBox.SelectedItem.ToString());

        }

        private void bars_Splitter_BlockSpace_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Splitter_BlockSpace = (int)bars_Splitter_BlockSpace_Numeric.Value;
        }

        private void bars_Splitter_BlockWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Splitter_BlockWidth = (int)bars_Splitter_BlockWidth_Numeric.Value;
        }

        private void bars_Splitter_FillColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Splitter_FillColor = colorSelector.Color;

                bars_Splitter_FillColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void bars_Splitter_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Splitter_BorderColor = colorSelector.Color;

                bars_Splitter_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void bars_Splitter_MarginOffset_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bars_Splitter_MarginOffset_Yes_RadioBtn.Checked == true)
            {


                ZeroitThematicProgress1.Splitter_MarginOffset = true;
            }
            else
            {

                ZeroitThematicProgress1.Splitter_MarginOffset = false;
            }
        }

        private void bars_Splitter_Percent_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bars_Splitter_Percent_Yes_RadioBtn.Checked == true)
            {


                ZeroitThematicProgress1.Splitter_Percent = true;
            }
            else
            {

                ZeroitThematicProgress1.Splitter_Percent = false;
            }
        }

        
    }
}
