// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerV2.cs" company="Zeroit Dev Technologies">
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
    public partial class DaggerV2_UC : UserControl
    {
        public DaggerV2_UC()
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

        private void circular_DaggerV2_Alignment_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.Alignment =
                (PenAlignment)Enum.Parse(typeof
                        (PenAlignment),
                    circular_DaggerV2_Alignment_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_DashCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.DashCap =
                (DashCap)Enum.Parse(typeof
                        (DashCap),
                    circular_DaggerV2_DashCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_DashStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.DashStyle =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    circular_DaggerV2_DashStyle_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_StartCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_DaggerV2_StartCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_EndCap_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circular_DaggerV2_EndCap_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_LineJoin_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressEffects.LineJoin =
                (LineJoin)Enum.Parse(typeof
                        (LineJoin),
                    circular_DaggerV2_LineJoin_ComboBox.SelectedItem.ToString());

        }

        private void circular_DaggerV2_BorderWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagInnerBorderWidth = (int)circular_DaggerV2_BorderWidth_Numeric.Value;

        }

        private void circular_DaggerV2_EndAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void circular_DaggerV2_FilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUpFilledThickness = (int)circular_DaggerV2_FilledThickness_Numeric.Value;

        }

        private void circular_DaggerV2_InnerFilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUpFilledThicknessInner = (int)circular_DaggerV2_InnerFilledThickness_Numeric.Value;

        }

        private void circular_DaggerV2_UnfilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUpUnfilledThickness = (int)circular_DaggerV2_UnfilledThickness_Numeric.Value;

        }

        private void circular_DaggerV2_InnerUnfilledThickness_Numeric_ValueChanged(object sender, EventArgs e)
        {
            //ZeroitThematicProgress1.DagUpFilledThicknessInner = (int)circular_DaggerV2_InnerUnfilledThickness_Numeric.Value;

        }

        private void circular_DaggerV2_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagAnimUpSpeed = (int)circular_DaggerV2_AnimationSpeed_Numeric.Value;

        }

        private void circular_DaggerV2_InnerTransparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUpFilledColorAlphaInner = (int)circular_DaggerV2_InnerTransparency_Numeric.Value;

        }

        private void circular_DaggerV2_OuterTransparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.DagUpFilledColorAlpha = (int)circular_DaggerV2_OuterTransparency_Numeric.Value;

        }

        private void circular_DaggerV2_InnerCircleBorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagInnerBorder = colorSelector.Color;

                circular_DaggerV2_InnerCircleBorderColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerV2_UnfilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagUpUnFilledColor = colorSelector.Color;

                circular_DaggerV2_UnfilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerV2_FilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagUpFilledColor = colorSelector.Color;

                circular_DaggerV2_FilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerV2_InnerFilledColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagUpInnerFilledColor = colorSelector.Color;

                circular_DaggerV2_InnerFilledColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerV2_InnerCircleColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.DagInnerColor = colorSelector.Color;

                circular_DaggerV2_InnerCircleColor_Btn.BackColor = colorSelector.Color;

            }
        }

        private void circular_DaggerV2_Animated_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerV2_Animated_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.DagUpIsAnimated = true;

            }
            else
            {
                ZeroitThematicProgress1.DagUpIsAnimated = false;
            }
        }

        private void circular_DaggerV2_Styled_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerV2_Styled_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.DagStyled = true;

            }
            else
            {
                ZeroitThematicProgress1.DagStyled = false;
            }
        }

        private void circular_DaggerV2_InnerCircle_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerV2_InnerCircle_Yes_RadioBtn.Checked == true)
            {

                ZeroitThematicProgress1.DagDrawInnerCircle = true;

            }
            else
            {
                ZeroitThematicProgress1.DagDrawInnerCircle = false;
            }

        }

        private void circular_DaggerV2_InnerBorder_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (circular_DaggerV2_InnerBorder_Yes_RadioBtn.Checked == true)
            {
                ZeroitThematicProgress1.DagUpInnerBorder = true;

            }
            else
            {
                ZeroitThematicProgress1.DagUpInnerBorder = false;
            }

        }
    }
}
