// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Prog_Antonio - Normal.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProgressDialog
    {

        

        private void Set_Normal_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            antonio_Normal_UC.Preview_Btn.Click += Preview_Normal_Btn_Click;

            #endregion

            #region Add Border Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.BorderTypes)))
            {
                antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.Items.Count; i++)
            {
                if (progressInput.BorderType ==
                    (ZeroitThematicProgress.BorderTypes)Enum.Parse(typeof
                            (ZeroitThematicProgress.BorderTypes),
                        antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.BorderType = 
                        (ZeroitThematicProgress.BorderTypes) Enum.Parse(typeof
                        (ZeroitThematicProgress.BorderTypes),
                        antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.SelectedItem.ToString());
                }
                
            }

            #endregion

            #region Add Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.progressNormalType)))
            {
                antonio_Normal_UC.bars_Antonio_Type_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_Type_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressNormalType ==
                    (ZeroitThematicProgress.progressNormalType)Enum.Parse(typeof
                            (ZeroitThematicProgress.progressNormalType),
                        antonio_Normal_UC.bars_Antonio_Type_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_Type_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.ProgressNormalType =
                        (ZeroitThematicProgress.progressNormalType)Enum.Parse(typeof
                        (ZeroitThematicProgress.progressNormalType),
                        antonio_Normal_UC.bars_Antonio_Type_ComboBox.SelectedItem.ToString());
                    
                }

            }

            #endregion

            #region Add Gradient Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.GradientTypes)))
            {
                antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.Items.Count; i++)
            {
                if (progressInput.GradientType ==
                    (ZeroitThematicProgress.GradientTypes)Enum.Parse(typeof
                            (ZeroitThematicProgress.GradientTypes),
                        antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.GradientType =
                        (ZeroitThematicProgress.GradientTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.GradientTypes),
                        antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.SelectedItem.ToString());

                }

            }

            #endregion

            #region Add Text Color Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.TextColorTypes)))
            {
                antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.Items.Count; i++)
            {
                if (progressInput.TextColorType ==
                    (ZeroitThematicProgress.TextColorTypes)Enum.Parse(typeof
                            (ZeroitThematicProgress.TextColorTypes),
                        antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.TextColorType =
                        (ZeroitThematicProgress.TextColorTypes)Enum.Parse(typeof
                                (ZeroitThematicProgress.TextColorTypes),
                            antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.SelectedItem.ToString());

                }

            }

            #endregion

            #region Add Text Align to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.TextAlignmentTypes)))
            {
                antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.Items.Count; i++)
            {
                if (progressInput.TextAlign ==
                    (ZeroitThematicProgress.TextAlignmentTypes)Enum.Parse(typeof
                            (ZeroitThematicProgress.TextAlignmentTypes),
                        antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.TextAlignType =
                        (ZeroitThematicProgress.TextAlignmentTypes)Enum.Parse(typeof
                                (ZeroitThematicProgress.TextAlignmentTypes),
                            antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.SelectedItem.ToString());

                }

            }

            #endregion

            #region Add Rolling Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ZeroitThematicProgress.RollingTypes)))
            {
                antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.Items.Count; i++)
            {
                if (progressInput.RollingType ==
                    (ZeroitThematicProgress.RollingTypes)Enum.Parse(typeof
                            (ZeroitThematicProgress.RollingTypes),
                        antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.Items[i].ToString()))
                {
                    antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.SelectedIndex = i;

                    antonio_Normal_UC.ZeroitThematicProgress1.RollingType =
                        (ZeroitThematicProgress.RollingTypes)Enum.Parse(typeof
                                (ZeroitThematicProgress.RollingTypes),
                            antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.SelectedItem.ToString());

                }

            }

            #endregion
            

            #region Colors - Button

            antonio_Normal_UC.bars_Antonio_ProgressColor_Btn.BackColor = progressInput.ColorProgress;
            antonio_Normal_UC.bars_Antonio_BorderColor_Btn.BackColor = progressInput.ProgressBarNormal_BorderColor;

            antonio_Normal_UC.ZeroitThematicProgress1.ColorProgress = progressInput.ColorProgress;
            antonio_Normal_UC.ZeroitThematicProgress1.ProgressBarNormal_BorderColor = progressInput.ProgressBarNormal_BorderColor;

            #endregion

            #region Values

            antonio_Normal_UC.bars_Antonio_Step_Numeric.Value = progressInput.ProgressBarNormal_Step;
            antonio_Normal_UC.bars_Antonio_GradientPercent_Numeric.Value = progressInput.GradientPercent;
            antonio_Normal_UC.bars_Antonio_RollBlockPercent_Numeric.Value = progressInput.RollBlockPercent;
            antonio_Normal_UC.bars_Antonio_RollTimer_Numeric.Value = progressInput.RollTimer;

            antonio_Normal_UC.ZeroitThematicProgress1.ProgressBarNormal_Step = progressInput.ProgressBarNormal_Step;
            antonio_Normal_UC.ZeroitThematicProgress1.GradientPercent = progressInput.GradientPercent;

            #endregion

            #region Bool

            if (progressInput.DisplayProgress == true)
            {
                antonio_Normal_UC.bars_Antonio_DisplayProgress_Yes_RadioBtn.Checked = true;

                antonio_Normal_UC.ZeroitThematicProgress1.DisplayProgress = true;
            }
            else
            {
                antonio_Normal_UC.bars_Antonio_DisplayProgress_No_RadioBtn.Checked = true;

                antonio_Normal_UC.ZeroitThematicProgress1.DisplayProgress = false;
            }

            #endregion

            #region Events

            #region Enums

            antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.SelectedIndexChanged += Bars_Antonio_BorderType_ComboBox_SelectedIndexChanged;
            antonio_Normal_UC.bars_Antonio_Type_ComboBox.SelectedIndexChanged += Bars_Antonio_Type_ComboBox_SelectedIndexChanged;
            antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.SelectedIndexChanged += Bars_Antonio_GradientType_ComboBox_SelectedIndexChanged;
            antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.SelectedIndexChanged += Bars_Antonio_TextColorType_ComboBox_SelectedIndexChanged;
            antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.SelectedIndexChanged += Bars_Antonio_RollingType_ComboBox_SelectedIndexChanged;
            #endregion

            #region Color Events

            antonio_Normal_UC.bars_Antonio_ProgressColor_Btn.Click += Bars_Antonio_ProgressColor_Btn_Click;
            antonio_Normal_UC.bars_Antonio_BorderColor_Btn.Click += Bars_Antonio_BorderColor_Btn_Click;

            #endregion

            #region Values

            antonio_Normal_UC.bars_Antonio_Step_Numeric.ValueChanged += Bars_Antonio_Step_Numeric_ValueChanged;
            antonio_Normal_UC.bars_Antonio_GradientPercent_Numeric.ValueChanged += Bars_Antonio_GradientPercent_Numeric_ValueChanged;
            antonio_Normal_UC.bars_Antonio_RollBlockPercent_Numeric.ValueChanged += Bars_Antonio_RollBlockPercent_Numeric_ValueChanged;
            antonio_Normal_UC.bars_Antonio_RollTimer_Numeric.ValueChanged += Bars_Antonio_RollTimer_Numeric_ValueChanged;
            #endregion

            #region Bool

            antonio_Normal_UC.bars_Antonio_DisplayProgress_Yes_RadioBtn.CheckedChanged += Bars_Antonio_DisplayProgress_Yes_RadioBtn_CheckedChanged;

            #endregion

            #endregion
        }

        #region Bool - Checked Changed Events

        private void Bars_Antonio_DisplayProgress_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (antonio_Normal_UC.bars_Antonio_DisplayProgress_Yes_RadioBtn.Checked == true)
            {


                antonio_Normal_UC.ZeroitThematicProgress1.DisplayProgress = true;
            }
            else
            {

                antonio_Normal_UC.ZeroitThematicProgress1.DisplayProgress = false;
            }
        }

        #endregion
        
        #region Value Changed Events

        private void Bars_Antonio_RollTimer_Numeric_ValueChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.RollTimer =
                (int)antonio_Normal_UC.bars_Antonio_RollTimer_Numeric.Value;
        }

        private void Bars_Antonio_RollBlockPercent_Numeric_ValueChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.RollBlockPercent =
                (int)antonio_Normal_UC.bars_Antonio_RollBlockPercent_Numeric.Value;
        }


        private void Bars_Antonio_GradientPercent_Numeric_ValueChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.GradientPercent =
                (int)antonio_Normal_UC.bars_Antonio_GradientPercent_Numeric.Value;
        }

        private void Bars_Antonio_Step_Numeric_ValueChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.ProgressBarNormal_Step =
                (int)antonio_Normal_UC.bars_Antonio_Step_Numeric.Value;
        }

        #endregion

        #region Color - Click Events

        private void Bars_Antonio_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (antonio_Normal_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.ProgressBarNormal_BorderColor = antonio_Normal_UC.colorSelector.Color;
                antonio_Normal_UC.bars_Antonio_BorderColor_Btn.BackColor = antonio_Normal_UC.colorSelector.Color;
            }
        }

        private void Bars_Antonio_ProgressColor_Btn_Click(object sender, EventArgs e)
        {
            if (antonio_Normal_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                antonio_Normal_UC.ZeroitThematicProgress1.ColorProgress = antonio_Normal_UC.colorSelector.Color;
                antonio_Normal_UC.bars_Antonio_ProgressColor_Btn.BackColor = antonio_Normal_UC.colorSelector.Color;
            }
        }

        #endregion

        #region Index Changed Events

        private void Bars_Antonio_RollingType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.RollingType =
                (ZeroitThematicProgress.RollingTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.RollingTypes),
                    antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.SelectedItem.ToString());

        }

        private void Bars_Antonio_TextColorType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.TextColorType =
                (ZeroitThematicProgress.TextColorTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.TextColorTypes),
                    antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.SelectedItem.ToString());

        }

        private void Bars_Antonio_GradientType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.GradientType =
                (ZeroitThematicProgress.GradientTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.GradientTypes),
                    antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.SelectedItem.ToString());

        }

        private void Bars_Antonio_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.ProgressNormalType =
                (ZeroitThematicProgress.progressNormalType)Enum.Parse(typeof
                        (ZeroitThematicProgress.progressNormalType),
                    antonio_Normal_UC.bars_Antonio_Type_ComboBox.SelectedItem.ToString());

        }

        private void Bars_Antonio_BorderType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            antonio_Normal_UC.ZeroitThematicProgress1.BorderType =
                (ZeroitThematicProgress.BorderTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.BorderTypes),
                    antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.SelectedItem.ToString());
        }

        #endregion

        private void Set_Normal_Retrieved_Values(ProgressInput progressInput)
        {

            #region MainControl Inputs

            #region Enums - ComboBox

            progressInput.ProgressType = (ProgressType)Enum.Parse(typeof
                        (ProgressType),
                    mainControl_ProgressType_ComboBox.SelectedItem.ToString());

            progressInput.SolidProgressBar = (ProgressBar)Enum.Parse(typeof
                    (ProgressBar),
                mainControl_BarProgress_ComboBox.SelectedItem.ToString());

            progressInput.Smoothing = (SmoothingMode)Enum.Parse(typeof
                    (SmoothingMode),
                mainControl_Smoothing_ComboBox.SelectedItem.ToString());

            progressInput.TextRendering = (TextRenderingHint)Enum.Parse(typeof
                    (TextRenderingHint),
                mainControl_TextRendering_ComboBox.SelectedItem.ToString());

            progressInput.EasingType = (PeaceAnimatorEasing)Enum.Parse(typeof
                    (PeaceAnimatorEasing),
                mainControl_IncrementEasing_ComboBox.SelectedItem.ToString());

            progressInput.TransparentEasing = (transparencyEasingType)Enum.Parse(typeof
                    (transparencyEasingType),
                mainControl_TransparentEasing_ComboBox.SelectedItem.ToString());

            progressInput.HatchBrush = (ZeroitThematicProgress.HatchBrushType)Enum.Parse(typeof
                    (ZeroitThematicProgress.HatchBrushType),
                mainControl_HatchType_ComboBox.SelectedItem.ToString());

            #endregion

            #region Bool - Radio Buttton

            if (mainControl_Transparency_Yes_RadioBtn.Checked == true)
            {
                progressInput.AllowTransparency = true;
            }
            else
            {
                progressInput.AllowTransparency = false;
            }

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked == true)
            {
                progressInput.AutoAnimate = true;
            }
            else
            {
                progressInput.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked == true)
            {
                progressInput.AutoIncrement = true;
            }
            else
            {
                progressInput.AutoIncrement = false;
            }

            if (mainControl_AnimateStartAngle_Yes_RadioBtn.Checked == true)
            {
                progressInput.AnimateStartAngle = true;
            }
            else
            {
                progressInput.AnimateStartAngle = false;
            }

            if (mainControl_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowText = true;
            }
            else
            {
                progressInput.ShowText = false;
            }

            if (mainControl_FixedSize_Yes_RadioBtn.Checked == true)
            {
                progressInput.FixedSize = true;
            }
            else
            {
                progressInput.FixedSize = false;
            }

            #endregion

            #region String

            progressInput.PostFix = mainControl_PostFix_TextBox.Text;

            #endregion

            #region Hatch Colors

            progressInput.ColorHatchBrushgradient1 = mainControl_HatchColor1_Btn.BackColor;

            progressInput.ColorHatchBrushgradient2 = mainControl_HatchColor2_Btn.BackColor;

            #endregion

            #region Values

            progressInput.Minimum = (float)mainControl_Minimum_Numeric.Value;
            progressInput.Maximum = (float)mainControl_Maximum_Numeric.Value;
            progressInput.AnimationSpeed[2] = (int)mainControl_AI_Duration_Numeric.Value;
            progressInput.AnimationSpeed[0] = (int)mainControl_AA_Speed_Numeric.Value;
            progressInput.AnimationSpeed[1] = (int)mainControl_ASA_Interval_Numeric.Value;
            progressInput.StartingAngle = (float)mainControl_StartingAngle_Numeric.Value;


            #endregion

            #endregion

            #region Enums

            progressInput.BorderType =
                (ZeroitThematicProgress.BorderTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.BorderTypes),
                    antonio_Normal_UC.bars_Antonio_BorderType_ComboBox.SelectedItem.ToString());

            progressInput.ProgressNormalType =
                (ZeroitThematicProgress.progressNormalType)Enum.Parse(typeof
                        (ZeroitThematicProgress.progressNormalType),
                    antonio_Normal_UC.bars_Antonio_Type_ComboBox.SelectedItem.ToString());

            progressInput.GradientType =
                (ZeroitThematicProgress.GradientTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.GradientTypes),
                    antonio_Normal_UC.bars_Antonio_GradientType_ComboBox.SelectedItem.ToString());

            progressInput.TextColorType =
                (ZeroitThematicProgress.TextColorTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.TextColorTypes),
                    antonio_Normal_UC.bars_Antonio_TextColorType_ComboBox.SelectedItem.ToString());

            progressInput.TextAlign =
                (ZeroitThematicProgress.TextAlignmentTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.TextAlignmentTypes),
                    antonio_Normal_UC.bars_Antonio_TextAlign_ComboBox.SelectedItem.ToString());

            progressInput.RollingType =
                (ZeroitThematicProgress.RollingTypes)Enum.Parse(typeof
                        (ZeroitThematicProgress.RollingTypes),
                    antonio_Normal_UC.bars_Antonio_RollingType_ComboBox.SelectedItem.ToString());


            #endregion

            #region Colors - Button

            progressInput.ColorProgress = antonio_Normal_UC.bars_Antonio_ProgressColor_Btn.BackColor;
            progressInput.ProgressBarNormal_BorderColor = antonio_Normal_UC.bars_Antonio_BorderColor_Btn.BackColor;

            #endregion

            #region Values

            progressInput.ProgressBarNormal_Step = (int)antonio_Normal_UC.bars_Antonio_Step_Numeric.Value;

            progressInput.GradientPercent = (int)antonio_Normal_UC.bars_Antonio_GradientPercent_Numeric.Value;

            #endregion

            #region Bool

            if (antonio_Normal_UC.bars_Antonio_DisplayProgress_Yes_RadioBtn.Checked == true)
            {
                progressInput.DisplayProgress = true;
                
            }
            else
            {
                progressInput.DisplayProgress = false;
            }

            #endregion

        }
        

        #region Preview Events

        private void Preview_Normal_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                antonio_Normal_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                antonio_Normal_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
