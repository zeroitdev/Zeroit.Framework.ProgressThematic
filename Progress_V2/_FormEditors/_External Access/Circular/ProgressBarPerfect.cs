// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPerfect.cs" company="Zeroit Dev Technologies">
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


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProgressDialog
    {

        private void Set_Perfect_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            progressBarPerfect_UC.Preview_Btn.Click += Preview_Perfect_Click;

            #endregion

            #region Enum

            #region Add Rotation to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressBarStyle in Enum.GetNames(typeof(RotationType1)))
            {
                progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.Items.Add(progressBarStyle);

            }

            for (int i = 0; i < progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressPerfect_Rotation ==
                    (RotationType1)Enum.Parse(typeof
                            (RotationType1),
                        progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.Items[i].ToString()))
                {
                    progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.SelectedIndex = i;

                    progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_Rotation =
                        (RotationType1)Enum.Parse(typeof
                                (RotationType1),
                            progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add TextDisplay to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string textDisplay in Enum.GetNames(typeof(TextDisplayModes1)))
            {
                progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.Items.Add(textDisplay);

            }

            for (int i = 0; i < progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressPerfect_TextDisplay ==
                    (TextDisplayModes1)Enum.Parse(typeof
                            (TextDisplayModes1),
                        progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.Items[i].ToString()))
                {
                    progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.SelectedIndex = i;

                    progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_TextDisplay =
                        (TextDisplayModes1)Enum.Parse(typeof
                                (TextDisplayModes1),
                            progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.SelectedItem.ToString());


                }

            }

            #endregion

            #endregion

            #region Values

            progressBarPerfect_UC.circular_Perfect_AnimationSpeed_Numeric.Value = progressInput.ProgressBarPerfect_AnimationSpeed;
            progressBarPerfect_UC.circular_Perfect_CircleSize_Numeric.Value = (decimal)progressInput.ProgressPerfect_CircleSize;
            progressBarPerfect_UC.circular_Perfect_NoOfCircles_Numeric.Value = (decimal)progressInput.ProgressPerfect_NumberOfCircles;
            progressBarPerfect_UC.circular_Perfect_Percentage_Numeric.Value = (decimal)progressInput.ProgressPerfect_Percentage;
            progressBarPerfect_UC.circular_Perfect_NoOfVisibleCircles_Numeric.Value = progressInput.ProgressPerfect_NumberOfVisibleCircles;

            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressBarPerfect_AnimationSpeed = progressInput.ProgressBarPerfect_AnimationSpeed;
            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_CircleSize = progressInput.ProgressPerfect_CircleSize;
            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_NumberOfCircles = progressInput.ProgressPerfect_NumberOfCircles;
            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_Percentage = progressInput.ProgressPerfect_Percentage;
            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_NumberOfVisibleCircles = progressInput.ProgressPerfect_NumberOfVisibleCircles;

            //progressBarPerfect_UC.circular_Perfect_NoOfCircles_Numeric.Value = (decimal)progressInput.Maximum;


            #endregion

            #region Colors

            progressBarPerfect_UC.circular_Perfect_CircleColor_Btn.BackColor = progressInput.ProgressPerfect_CircleColor;

            progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_CircleColor = progressInput.ProgressPerfect_CircleColor;


            #endregion

            #region Bool

            if (progressInput.ProgressBarPerfect_ShowText == true)
            {
                progressBarPerfect_UC.circular_Perfect_ShowText_Yes_RadioBtn.Checked = true;

                progressBarPerfect_UC.ZeroitThematicProgress1.ProgressBarPerfect_ShowText = true;
            }
            else
            {
                progressBarPerfect_UC.circular_Perfect_ShowText_No_RadioBtn.Checked = true;

                progressBarPerfect_UC.ZeroitThematicProgress1.ProgressBarPerfect_ShowText = false;
            }

            if (progressInput.ProgressPerfect_ShowPercentage == true)
            {
                progressBarPerfect_UC.circular_Perfect_ShowPercentage_Yes_RadioBtn.Checked = true;

                progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_ShowPercentage = true;
            }
            else
            {
                progressBarPerfect_UC.circular_Perfect_ShowPercentage_No_RadioBtn.Checked = true;

                progressBarPerfect_UC.ZeroitThematicProgress1.ProgressPerfect_ShowPercentage = false;
            }

            #endregion

            #region String

            progressBarPerfect_UC.circular_Perfect_CustomText_TextBox.Text =
                progressInput.ProgressBarPerfect_CustomText;

            #endregion

        }

        private void Set_Perfect_Retrieved_Values(ProgressInput progressInput)
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

            #region Enum

            progressInput.ProgressPerfect_Rotation =
                (RotationType1)Enum.Parse(typeof
                        (RotationType1),
                    progressBarPerfect_UC.circular_Perfect_Rotation_ComboBox.SelectedItem.ToString());

            progressInput.ProgressPerfect_TextDisplay =
                (TextDisplayModes1)Enum.Parse(typeof
                        (TextDisplayModes1),
                    progressBarPerfect_UC.circular_Perfect_TextDisplay_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            progressInput.ProgressBarPerfect_AnimationSpeed = (int)progressBarPerfect_UC.circular_Perfect_AnimationSpeed_Numeric.Value;
            progressInput.ProgressPerfect_CircleSize = (float)progressBarPerfect_UC.circular_Perfect_CircleSize_Numeric.Value;
            progressInput.ProgressPerfect_NumberOfCircles = (float)progressBarPerfect_UC.circular_Perfect_NoOfCircles_Numeric.Value;
            progressInput.ProgressPerfect_Percentage = (float)progressBarPerfect_UC.circular_Perfect_Percentage_Numeric.Value;
            progressInput.ProgressPerfect_NumberOfVisibleCircles = (int)progressBarPerfect_UC.circular_Perfect_NoOfVisibleCircles_Numeric.Value;
            
            #endregion

            #region Colors

            progressInput.ProgressPerfect_CircleColor = progressBarPerfect_UC.circular_Perfect_CircleColor_Btn.BackColor;

            #endregion

            #region Bool

            if (progressBarPerfect_UC.circular_Perfect_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressInput.ProgressBarPerfect_ShowText = true;
                
            }
            else
            {
                progressInput.ProgressBarPerfect_ShowText = false;
            }

            if (progressBarPerfect_UC.circular_Perfect_ShowPercentage_Yes_RadioBtn.Checked == true)
            {
                progressInput.ProgressPerfect_ShowPercentage = true;
                
            }
            else
            {
                progressInput.ProgressPerfect_ShowPercentage = false;
            }
            #endregion

            #region String

            progressInput.ProgressBarPerfect_CustomText =
                progressBarPerfect_UC.circular_Perfect_CustomText_TextBox.Text;

            #endregion

        }


        #region Preview Events

        private void Preview_Perfect_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                progressBarPerfect_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                progressBarPerfect_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
