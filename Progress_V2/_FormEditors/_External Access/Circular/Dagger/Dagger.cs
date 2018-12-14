// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Dagger.cs" company="Zeroit Dev Technologies">
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

        private void Set_Dagger_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            dagger_UC.Preview_Btn.Click += Preview_Dagger_Click;

            #endregion
            
            #region Values

            dagger_UC.circular_Dagger_StartAngle_Numeric.Value = progressInput.DagStartAngle;
            dagger_UC.circular_Dagger_AnimationSpeed_Numeric.Value = progressInput.DagAnimSpeed;
            dagger_UC.circular_Dagger_Transparency_Numeric.Value = progressInput.DagFilledColorAlpha;
            dagger_UC.circular_Dagger_FilledThickness_Numeric.Value = progressInput.DagFilledThickness;
            dagger_UC.circular_Dagger_UnfilledThickness_Numeric.Value = progressInput.DagUnfilledThickness;

            dagger_UC.ZeroitThematicProgress1.DagStartAngle = progressInput.DagStartAngle;
            dagger_UC.ZeroitThematicProgress1.DagAnimSpeed = progressInput.DagAnimSpeed;
            dagger_UC.ZeroitThematicProgress1.DagFilledColorAlpha = progressInput.DagFilledColorAlpha;
            dagger_UC.ZeroitThematicProgress1.DagFilledThickness = progressInput.DagFilledThickness;
            dagger_UC.ZeroitThematicProgress1.DagUnfilledThickness = progressInput.DagUnfilledThickness;
            dagger_UC.ZeroitThematicProgress1.Value = progressInput.Value;

            #endregion

            #region Colors

            dagger_UC.circular_Dagger_FilledColor_Btn.BackColor = progressInput.DagFilledColor;
            dagger_UC.circular_Dagger_UnfilledColor_Btn.BackColor = progressInput.DagUnFilledColor;
            
            dagger_UC.ZeroitThematicProgress1.DagUnFilledColor = progressInput.DagUnFilledColor;
            dagger_UC.ZeroitThematicProgress1.DagUnFilledColor = progressInput.DagUnFilledColor;
            
            #endregion

            #region Bool

            if (progressInput.DagIsAnimated == true)
            {
                dagger_UC.circular_Dagger_Animated_Yes_RadioBtn.Checked = true;

                dagger_UC.ZeroitThematicProgress1.DagIsAnimated = true;
            }
            else
            {
                dagger_UC.circular_Dagger_Animated_No_RadioBtn.Checked = true;

                dagger_UC.ZeroitThematicProgress1.DagIsAnimated = false;
            }

            #endregion


        }


        private void Set_Dagger_Retrieved_Values(ProgressInput progressInput)
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


            #region Values

            progressInput.DagStartAngle = (int)dagger_UC.circular_Dagger_StartAngle_Numeric.Value;
            progressInput.DagAnimSpeed = (int)dagger_UC.circular_Dagger_AnimationSpeed_Numeric.Value;
            progressInput.DagFilledColorAlpha = (int)dagger_UC.circular_Dagger_Transparency_Numeric.Value;
            progressInput.DagFilledThickness = (int)dagger_UC.circular_Dagger_FilledThickness_Numeric.Value;
            progressInput.DagUnfilledThickness = (int)dagger_UC.circular_Dagger_UnfilledThickness_Numeric.Value;


            #endregion

            #region Colors

            progressInput.DagFilledColor = dagger_UC.circular_Dagger_FilledColor_Btn.BackColor;
            progressInput.DagUnFilledColor = dagger_UC.circular_Dagger_UnfilledColor_Btn.BackColor;

            
            #endregion

            #region Bool

            if (dagger_UC.circular_Dagger_Animated_Yes_RadioBtn.Checked == true)
            {
                
                progressInput.DagIsAnimated = true;
            }
            else
            {
                progressInput.DagIsAnimated = false;
            }

            #endregion


        }


        #region Preview Events

        private void Preview_Dagger_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (dagger_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    dagger_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    dagger_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                dagger_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (dagger_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    dagger_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    dagger_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                dagger_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
