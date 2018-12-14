// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV5_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class CircularProgressV5_UC : UserControl
    {
        public CircularProgressV5_UC()
        {
            InitializeComponent();

            circular_V5_Separation_Numeric.Maximum = 12;
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

        private void circular_V5_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.BarWidth = (int)circular_V5_Width_Numeric.Value;
        }

        private void circular_V5_OuterSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv5_OuterSpeed = (int)circular_V5_OuterSpeed_Numeric.Value;
        }

        private void circular_V5_MarqueeSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.MarqueeSpeed = (int)circular_V5_MarqueeSpeed_Numeric.Value;
        }

        private void circular_V5_Speed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.CPv5_Interval = (int)circular_V5_Speed_Numeric.Value;
        }

        private void circular_V5_Separation_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Seperation = (int)circular_V5_Separation_Numeric.Value;
        }

        private void circular_V5_Reset_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //RESET 
            if (circular_V5_Reset_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.CPv5_Reset = true;
            }
            else
            {
                

                ZeroitThematicProgress1.CPv5_Reset = false;
            }
        }

        private void circular_V5_Shadow_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //SHADOW 
            if (circular_V5_Shadow_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.TextShadow = true;
            }
            else
            {
                
                ZeroitThematicProgress1.TextShadow = false;
            }
        }

        private void circular_V5_DisplayPercentages_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //DISPLAY PERCENTAGES
            if (circular_V5_DisplayPercentages_Yes_RadioBtn.Checked == true)
            {
                
                ZeroitThematicProgress1.DisplayPercentage = true;
            }
            else
            {
                
                ZeroitThematicProgress1.DisplayPercentage = false;
            }
        }

        private void circular_V5_DisplayTotalPercentages_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //DISPLAY TOTALPERCENTAGES
            if (circular_V5_DisplayTotalPercentages_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.DisplayTotalPercentage = true;
            }
            else
            {
                
                ZeroitThematicProgress1.DisplayTotalPercentage = false;
            }
        }

        private void circular_V5_ImageEnabled_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //IMAGE ENABLED
            if (circular_V5_ImageEnabled_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.ImageEnabled = true;
            }
            else
            {
                
                ZeroitThematicProgress1.ImageEnabled = false;
            }
        }

        private void circular_V5_BordersEnabled_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BORDERS ENABLED
            if (circular_V5_BordersEnabled_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.BorderEnabled = true;
            }
            else
            {
                
                ZeroitThematicProgress1.BorderEnabled = false;
            }
        }

        private void circular_V5_Marquee_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //MARQUEE
            if (circular_V5_Marquee_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.Marquee = true;
            }
            else
            {
                
                ZeroitThematicProgress1.Marquee = false;
            }
        }

        private void circular_V5_Smooth_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //SMOOTH BARS
            if (circular_V5_Smooth_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.SmoothBars = true;
            }
            else
            {
                
                ZeroitThematicProgress1.SmoothBars = false;
            }
        }

        private void circular_V5_InactiveColorEnabled_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //INACTIVE COLOR
            if (circular_V5_InactiveColorEnabled_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.InactiveColorEnabled = true;
            }
            else
            {
                
                ZeroitThematicProgress1.InactiveColorEnabled = false;
            }
        }

        private void circular_V5_Bar1_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BAR 1 ENABLED
            if (circular_V5_Bar1_Yes_RadioBtn.Checked == true)
            {
                

                ZeroitThematicProgress1.Bar1.Enabled = true;
            }
            else
            {
                
                ZeroitThematicProgress1.Bar1.Enabled = false;
            }
        }

        private void circular_V5_Bar2_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BAR 2 ENABLED
            if (circular_V5_Bar2_Yes_RadioBtn.Checked == true)
            {
                
                ZeroitThematicProgress1.Bar2.Enabled = true;
            }
            else
            {
                
                ZeroitThematicProgress1.Bar2.Enabled = false;
            }
        }

        private void circular_V5_Bar3_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BAR 3 ENABLED
            if (circular_V5_Bar3_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.Bar3.Enabled = true;
            }
            else
            {

                ZeroitThematicProgress1.Bar3.Enabled = false;
            }
        }

        private void circular_V5_Bar4_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BAR 4 ENABLED
            if (circular_V5_Bar4_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.Bar4.Enabled = true;
            }
            else
            {

                ZeroitThematicProgress1.Bar4.Enabled = false;
            }
        }

        private void circular_V5_Bar5_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //BAR 5 ENABLED
            if (circular_V5_Bar5_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.Bar5.Enabled = true;
            }
            else
            {

                ZeroitThematicProgress1.Bar5.Enabled = false;
            }
        }

        private void circular_V5_Bar1_ActiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar1.ActiveColor = colorSelector.Color;

                circular_V5_Bar1_ActiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar1_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar1.BorderColor = colorSelector.Color;

                circular_V5_Bar1_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar1_FinishColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar1.FinishColor = colorSelector.Color;

                circular_V5_Bar1_FinishColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar1_InactiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar1.InactiveColor = colorSelector.Color;

                circular_V5_Bar1_InactiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar2_ActiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar2.ActiveColor = colorSelector.Color;

                circular_V5_Bar2_ActiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar2_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar2.BorderColor = colorSelector.Color;

                circular_V5_Bar2_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar2_FinishColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar2.FinishColor = colorSelector.Color;

                circular_V5_Bar2_FinishColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar2_InactiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar2.InactiveColor = colorSelector.Color;

                circular_V5_Bar2_InactiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar3_ActiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar3.ActiveColor = colorSelector.Color;

                circular_V5_Bar3_ActiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar3_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar3.BorderColor = colorSelector.Color;

                circular_V5_Bar3_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar3_FinishColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar3.FinishColor = colorSelector.Color;

                circular_V5_Bar3_FinishColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar3_InactiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar3.InactiveColor = colorSelector.Color;

                circular_V5_Bar3_InactiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar4_ActiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar4.ActiveColor = colorSelector.Color;

                circular_V5_Bar4_ActiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar4_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar4.BorderColor = colorSelector.Color;

                circular_V5_Bar4_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar4_FinishColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar4.FinishColor = colorSelector.Color;

                circular_V5_Bar4_FinishColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar4_InactiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar4.InactiveColor = colorSelector.Color;

                circular_V5_Bar4_InactiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar5_ActiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar5.ActiveColor = colorSelector.Color;

                circular_V5_Bar5_ActiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar5_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar5.BorderColor = colorSelector.Color;

                circular_V5_Bar5_BorderColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar5_FinishColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar5.FinishColor = colorSelector.Color;

                circular_V5_Bar5_FinishColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar5_InactiveColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.Bar5.InactiveColor = colorSelector.Color;

                circular_V5_Bar5_InactiveColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_V5_Bar1_Smooth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar1.SmoothAmount = (int)circular_V5_Bar1_Smooth_Numeric.Value;
        }

        private void circular_V5_Bar2_Smooth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar2.SmoothAmount = (int)circular_V5_Bar2_Smooth_Numeric.Value;
        }

        private void circular_V5_Bar3_Smooth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar3.SmoothAmount = (int)circular_V5_Bar3_Smooth_Numeric.Value;
        }

        private void circular_V5_Bar4_Smooth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar4.SmoothAmount = (int)circular_V5_Bar4_Smooth_Numeric.Value;
        }

        private void circular_V5_Bar5_Smooth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar5.SmoothAmount = (int)circular_V5_Bar5_Smooth_Numeric.Value;
        }

        private void circular_V5_Bar1_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar1.Maximum = (int)circular_V5_Bar1_Maximum_Numeric.Value;
        }

        private void circular_V5_Bar2_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar2.Maximum = (int)circular_V5_Bar2_Maximum_Numeric.Value;
        }

        private void circular_V5_Bar3_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar3.Maximum = (int)circular_V5_Bar3_Maximum_Numeric.Value;
        }

        private void circular_V5_Bar4_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar4.Maximum = (int)circular_V5_Bar4_Maximum_Numeric.Value;
        }

        private void circular_V5_Bar5_Maximum_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar5.Maximum = (int)circular_V5_Bar5_Maximum_Numeric.Value;
        }

        private void circular_V5_Bar1_Value_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar1.Value = (int)circular_V5_Bar1_Value_Numeric.Value;
        }

        private void circular_V5_Bar2_Value_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar2.Value = (int)circular_V5_Bar2_Value_Numeric.Value;
        }

        private void circular_V5_Bar3_Value_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar3.Value = (int)circular_V5_Bar3_Value_Numeric.Value;
        }

        private void circular_V5_Bar4_Value_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar4.Value = (int)circular_V5_Bar4_Value_Numeric.Value;
        }

        private void circular_V5_Bar5_Value_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Bar5.Value = (int)circular_V5_Bar5_Value_Numeric.Value;
        }

        private void ZeroitThematicProgress1_Click(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.Invalidate();
        }
    }
}
