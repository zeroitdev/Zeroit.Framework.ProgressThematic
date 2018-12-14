// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAwesome_UC.cs" company="Zeroit Dev Technologies">
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
    public partial class ProgressAwesome_UC : UserControl
    {
        public ProgressAwesome_UC()
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

        private void Preview_Awesome_MouseEnter(object sender, EventArgs e)
        {
            circular_Awesome_SecondaryFont_Btn.FlatAppearance.BorderSize = 1;
            circular_Awesome_SecondaryFont_Btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255);

            label33.BackColor = Color.FromArgb(30, 30, 30);
            label34.BackColor = Color.FromArgb(30, 30, 30);
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label37.BackColor = Color.FromArgb(30, 30, 30);
            circular_Awesome_SecondaryFontSize_Label.BackColor = Color.FromArgb(30, 30, 30);
            circular_Awesome_SecondaryFontName_Label.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void Preview_Awesome_MouseLeave(object sender, EventArgs e)
        {
            circular_Awesome_SecondaryFont_Btn.FlatAppearance.BorderSize = 1;
            circular_Awesome_SecondaryFont_Btn.FlatAppearance.BorderColor = Color.Gray;

            label33.BackColor = Color.FromArgb(25, 25, 25);
            label34.BackColor = Color.FromArgb(25, 25, 25);
            label3.BackColor = Color.FromArgb(25, 25, 25);
            label37.BackColor = Color.FromArgb(25, 25, 25);
            circular_Awesome_SecondaryFontSize_Label.BackColor = Color.FromArgb(25, 25, 25);
            circular_Awesome_SecondaryFontName_Label.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void circular_Awesome_SecondaryFont_Btn_Click(object sender, EventArgs e)
        {
            if (fontSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SecondaryFont = fontSelector.Font;

                circular_Awesome_SecondaryFontName_Label.Text = fontSelector.Font.Name;

                circular_Awesome_SecondaryFontSize_Label.Text = fontSelector.Font.Size.ToString();
            }
        }

        private void circular_Awesome_InnerMargin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerMargin = (int)circular_Awesome_InnerMargin_Numeric.Value;
        }

        private void circular_Awesome_InnerWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.InnerWidth = (int)circular_Awesome_InnerWidth_Numeric.Value;
        }

        private void circular_Awesome_OuterMargin_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.OuterMargin = (int)circular_Awesome_OuterMargin_Numeric.Value;
        }

        private void circular_Awesome_OuterWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.OuterWidth = (int)circular_Awesome_OuterWidth_Numeric.Value;
        }

        private void circular_Awesome_AnimationSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressAwesome_AnimationSpeed = (int)circular_Awesome_AnimationSpeed_Numeric.Value;
        }

        private void circular_Awesome_ProgressWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressAwesome_ProgressWidth = (int)circular_Awesome_ProgressWidth_Numeric.Value;
        }

        private void circular_Awesome_StartAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.StartAngle = (int)circular_Awesome_StartAngle_Numeric.Value;
        }

        private void circular_Awesome_SpMarginTop_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SuperscriptMargin = new Padding((int) circular_Awesome_SpMarginLeft_Numeric.Value,
                (int) circular_Awesome_SpMarginTop_Numeric.Value, (int) circular_Awesome_SpMarginRight_Numeric.Value,
                (int) circular_Awesome_SpMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SpMarginLeft_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SuperscriptMargin = new Padding((int)circular_Awesome_SpMarginLeft_Numeric.Value,
                (int)circular_Awesome_SpMarginTop_Numeric.Value, (int)circular_Awesome_SpMarginRight_Numeric.Value,
                (int)circular_Awesome_SpMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SbMarginTop_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SbMarginLeft_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SbMarginAll_Numeric_ValueChanged(object sender, EventArgs e)
        {
            circular_Awesome_SbMarginLeft_Numeric.Value = circular_Awesome_SbMarginAll_Numeric.Value;
            circular_Awesome_SbMarginTop_Numeric.Value = circular_Awesome_SbMarginAll_Numeric.Value;
            circular_Awesome_SbMarginRight_Numeric.Value = circular_Awesome_SbMarginAll_Numeric.Value;
            circular_Awesome_SbMarginBottom_Numeric.Value = circular_Awesome_SbMarginAll_Numeric.Value;

            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginAll_Numeric.Value,
                (int)circular_Awesome_SbMarginAll_Numeric.Value, (int)circular_Awesome_SbMarginAll_Numeric.Value,
                (int)circular_Awesome_SbMarginAll_Numeric.Value);

        }

        private void circular_Awesome_SpMarginAll_Numeric_ValueChanged(object sender, EventArgs e)
        {
            circular_Awesome_SpMarginLeft_Numeric.Value = circular_Awesome_SpMarginAll_Numeric.Value;
            circular_Awesome_SpMarginTop_Numeric.Value = circular_Awesome_SpMarginAll_Numeric.Value;
            circular_Awesome_SpMarginRight_Numeric.Value = circular_Awesome_SpMarginAll_Numeric.Value;
            circular_Awesome_SpMarginBottom_Numeric.Value = circular_Awesome_SpMarginAll_Numeric.Value;

            ZeroitThematicProgress1.SuperscriptMargin = new Padding((int)circular_Awesome_SpMarginAll_Numeric.Value,
                (int)circular_Awesome_SpMarginAll_Numeric.Value, (int)circular_Awesome_SpMarginAll_Numeric.Value,
                (int)circular_Awesome_SpMarginAll_Numeric.Value);
        }

        private void circular_Awesome_TxtMarginTop_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.TextMargin = new Padding((int)circular_Awesome_TxtMarginLeft_Numeric.Value,
                (int)circular_Awesome_TxtMarginTop_Numeric.Value, (int)circular_Awesome_TxtMarginRight_Numeric.Value,
                (int)circular_Awesome_TxtMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_TxtMarginBottom_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.TextMargin = new Padding((int)circular_Awesome_TxtMarginLeft_Numeric.Value,
                (int)circular_Awesome_TxtMarginTop_Numeric.Value, (int)circular_Awesome_TxtMarginRight_Numeric.Value,
                (int)circular_Awesome_TxtMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SbMarginRight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SbMarginBottom_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SpMarginRight_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_SpMarginBottom_Numeric_ValueChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptMargin = new Padding((int)circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)circular_Awesome_SbMarginTop_Numeric.Value, (int)circular_Awesome_SbMarginRight_Numeric.Value,
                (int)circular_Awesome_SbMarginBottom_Numeric.Value);
        }

        private void circular_Awesome_TxtMarginAll_Numeric_ValueChanged(object sender, EventArgs e)
        {
            circular_Awesome_TxtMarginLeft_Numeric.Value = circular_Awesome_TxtMarginAll_Numeric.Value;
            circular_Awesome_TxtMarginTop_Numeric.Value = circular_Awesome_TxtMarginAll_Numeric.Value;
            circular_Awesome_TxtMarginRight_Numeric.Value = circular_Awesome_TxtMarginAll_Numeric.Value;
            circular_Awesome_TxtMarginBottom_Numeric.Value = circular_Awesome_TxtMarginAll_Numeric.Value;

            ZeroitThematicProgress1.TextMargin = new Padding((int)circular_Awesome_TxtMarginAll_Numeric.Value,
                (int)circular_Awesome_TxtMarginAll_Numeric.Value, (int)circular_Awesome_TxtMarginAll_Numeric.Value,
                (int)circular_Awesome_TxtMarginAll_Numeric.Value);
        }

        private void circular_Awesome_SpColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SuperscriptColor = colorSelector.Color;

                circular_Awesome_SpColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Awesome_OuterColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.OuterColor = colorSelector.Color;

                circular_Awesome_OuterColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Awesome_ProgressColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.ProgressColor = colorSelector.Color;

                circular_Awesome_ProgressColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Awesome_SbColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.SubscriptColor = colorSelector.Color;

                circular_Awesome_SbColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Awesome_InnerColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                ZeroitThematicProgress1.InnerColor = colorSelector.Color;

                circular_Awesome_InnerColor_Btn.BackColor = colorSelector.Color;
            }
        }

        private void circular_Awesome_Style_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.ProgressBarAwesomeStyle =
                (ProgressBarStyle)Enum.Parse(typeof
                        (ProgressBarStyle),
                    circular_Awesome_Style_ComboBox.SelectedItem.ToString());

        }

        private void circular_Awesome_SbText_TextBox_TextChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SubscriptText = circular_Awesome_SbText_TextBox.Text;
        }

        private void circular_Awesome_SpText_TextBox_TextChanged(object sender, EventArgs e)
        {
            ZeroitThematicProgress1.SuperscriptText = circular_Awesome_SpText_TextBox.Text;
        }
    }
}
