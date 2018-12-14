// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressIndicatorUnique.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        private void Set_ProgressIndicatorUnique_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            progressIndicatorUnique_UC.Preview_Btn.Click += Preview_ProgressIndicatorUnique_Click;

            #endregion

            #region Enum


            #region Add Rotation to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(Unique_RotationType)))
            {
                progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.Items.Count; i++)
            {
                if (progressInput.Unique_Rotation ==
                    (Unique_RotationType)Enum.Parse(typeof
                    (Unique_RotationType),
                    progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.Items[i].ToString()))
                {
                    progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.SelectedIndex = i;

                    progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_Rotation =
                        (Unique_RotationType)Enum.Parse(typeof
                        (Unique_RotationType),
                        progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add TextDisplay Modes to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(Unique_TextDisplayModes)))
            {
                progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.Items.Count; i++)
            {
                if (progressInput.Unique_TextDisplay ==
                    (Unique_TextDisplayModes)Enum.Parse(typeof
                            (Unique_TextDisplayModes),
                        progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.Items[i].ToString()))
                {
                    progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.SelectedIndex = i;

                    progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_TextDisplay =
                        (Unique_TextDisplayModes)Enum.Parse(typeof
                                (Unique_TextDisplayModes),
                            progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion


            #endregion

            #region Values

            progressIndicatorUnique_UC.indicator_Unique_CircleSize_Numeric.Value =
                (int)progressInput.Unique_CircleSize;

            progressIndicatorUnique_UC.indicator_Unique_AnimationSpeed_Numeric.Value =
                (int)progressInput.Unique_AnimationSpeed;

            progressIndicatorUnique_UC.indicator_Unique_NoOfVisibleCircles_Numeric.Value =
                (int)progressInput.Unique_NumberOfVisibleCircles;

            progressIndicatorUnique_UC.indicator_Unique_NoOfCircles_Numeric.Value =
                (int)progressInput.Unique_NumberOfCircles;

            progressIndicatorUnique_UC.indicator_Unique_Percentage_Numeric.Value =
                (int)progressInput.Unique_Percentage;




            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_CircleSize =
                (int)progressInput.Unique_CircleSize;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_AnimationSpeed =
                (int)progressInput.Unique_AnimationSpeed;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_NumberOfVisibleCircles =
                (int)progressInput.Unique_NumberOfVisibleCircles;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_NumberOfCircles =
                (int)progressInput.Unique_NumberOfCircles;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_Percentage =
                (int)progressInput.Unique_Percentage;
            #endregion

            #region Colors

            progressIndicatorUnique_UC.indicator_Unique_CircleColor_Btn.BackColor = progressInput.Unique_CircleColor;

            progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_CircleColor = progressInput.Unique_CircleColor;

            #endregion

            #region Bool 

            if (progressInput.Unique_ShowText == true)
            {
                progressIndicatorUnique_UC.indicator_Unique_ShowText_Yes_RadioBtn.Checked = true;

                progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_ShowText = true;
            }
            else
            {
                progressIndicatorUnique_UC.indicator_Unique_ShowText_No_RadioBtn.Checked = true;

                progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_ShowText = false;
            }

            if (progressInput.Unique_ShowPercentage == true)
            {
                progressIndicatorUnique_UC.indicator_Unique_ShowPercentage_Yes_RadioBtn.Checked = true;

                progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_ShowPercentage = true;
            }
            else
            {
                progressIndicatorUnique_UC.indicator_Unique_ShowPercentage_No_RadioBtn.Checked = true;

                progressIndicatorUnique_UC.ZeroitThematicProgress1.Unique_ShowPercentage = false;
            }

            #endregion

            #region String

            progressIndicatorUnique_UC.indicator_Unique_CustomText_TextBox.Text = progressInput.Unique_CustomText;

            #endregion

        }


        private void Set_ProgressIndicatorUnique_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.Unique_Rotation =
                (Unique_RotationType)Enum.Parse(typeof
                        (Unique_RotationType),
                    progressIndicatorUnique_UC.indicator_Unique_Rotation_ComboBox.SelectedItem.ToString());

            progressInput.Unique_TextDisplay =
                (Unique_TextDisplayModes)Enum.Parse(typeof
                        (Unique_TextDisplayModes),
                    progressIndicatorUnique_UC.indicator_Unique_TextDisplay_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            progressInput.Unique_CircleSize =
                (float)progressIndicatorUnique_UC.indicator_Unique_CircleSize_Numeric.Value;

            progressInput.Unique_AnimationSpeed =
                (int)progressIndicatorUnique_UC.indicator_Unique_AnimationSpeed_Numeric.Value;

            progressInput.Unique_NumberOfVisibleCircles =
                (int)progressIndicatorUnique_UC.indicator_Unique_NoOfVisibleCircles_Numeric.Value;

            progressInput.Unique_NumberOfCircles =
                (float)progressIndicatorUnique_UC.indicator_Unique_NoOfCircles_Numeric.Value;

            progressInput.Unique_Percentage =
                (float)progressIndicatorUnique_UC.indicator_Unique_Percentage_Numeric.Value;

            #endregion

            #region Colors

            progressInput.Unique_CircleColor = progressIndicatorUnique_UC.indicator_Unique_CircleColor_Btn.BackColor;

            #endregion

            #region Bool 

            if (progressIndicatorUnique_UC.indicator_Unique_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressInput.Unique_ShowText = true;
            }
            else
            {
                progressInput.Unique_ShowText = false;
            }

            if (progressIndicatorUnique_UC.indicator_Unique_ShowPercentage_Yes_RadioBtn.Checked == true)
            {
                progressInput.Unique_ShowPercentage = true;
            }
            else
            {
                progressInput.Unique_ShowPercentage = false;
            }

            #endregion

            #region String

            progressInput.Unique_CustomText = progressIndicatorUnique_UC.indicator_Unique_CustomText_TextBox.Text;

            #endregion


        }


        #region Preview Events

        private void Preview_ProgressIndicatorUnique_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                progressIndicatorUnique_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
