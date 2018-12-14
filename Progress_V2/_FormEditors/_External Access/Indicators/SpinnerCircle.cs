// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="SpinnerCircle.cs" company="Zeroit Dev Technologies">
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

        private void Set_SpinnerCircle_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            spinnerCircle_UC.Preview_Btn.Click += Preview_SpinnerCircle_Click;

            #endregion

            #region Enum
            
            #region Add Style Preset to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(ZeroitThematicProgress.StylePresets)))
            {
                spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.Items.Count; i++)
            {
                if (progressInput.StylePreset ==
                    (ZeroitThematicProgress.StylePresets)Enum.Parse(typeof
                    (ZeroitThematicProgress.StylePresets),
                    spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.Items[i].ToString()))
                {
                    spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.SelectedIndex = i;

                    spinnerCircle_UC.ZeroitThematicProgress1.StylePreset =
                        (ZeroitThematicProgress.StylePresets)Enum.Parse(typeof
                        (ZeroitThematicProgress.StylePresets),
                        spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(LineCap)))
            {
                spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.Spinner_StartCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.Items[i].ToString()))
                {
                    spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.SelectedIndex = i;

                    spinnerCircle_UC.ZeroitThematicProgress1.Spinner_StartCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(LineCap)))
            {
                spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.Spinner_EndCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.Items[i].ToString()))
                {
                    spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.SelectedIndex = i;

                    spinnerCircle_UC.ZeroitThematicProgress1.Spinner_EndCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            
            #endregion

            #endregion

            #region Values

            spinnerCircle_UC.indicator_SpinnerCircle_InnerCircRadius_Numeric.Value =
                (int)progressInput.InnerCircleRadius;

            spinnerCircle_UC.indicator_SpinnerCircle_NoOfSpoke_Numeric.Value =
                (int)progressInput.NumberSpoke;

            spinnerCircle_UC.indicator_SpinnerCircle_OuterCircRadius_Numeric.Value =
                (int)progressInput.OuterCircleRadius;

            spinnerCircle_UC.indicator_SpinnerCircle_RotationSpeed_Numeric.Value =
                (int)progressInput.RotationSpeed;

            spinnerCircle_UC.indicator_SpinnerCircle_SpokeThickness_Numeric.Value =
                (int)progressInput.SpokeThickness;



            spinnerCircle_UC.ZeroitThematicProgress1.InnerCircleRadius =
                (int)progressInput.InnerCircleRadius;

            spinnerCircle_UC.ZeroitThematicProgress1.NumberSpoke =
                (int)progressInput.NumberSpoke;

            spinnerCircle_UC.ZeroitThematicProgress1.OuterCircleRadius =
                (int)progressInput.OuterCircleRadius;

            spinnerCircle_UC.ZeroitThematicProgress1.RotationSpeed =
                (int)progressInput.RotationSpeed;

            spinnerCircle_UC.ZeroitThematicProgress1.SpokeThickness =
                (int)progressInput.SpokeThickness;

            #endregion

            #region Colors

            spinnerCircle_UC.indicator_SpinnerCircle_SpokeColor_Btn.BackColor = progressInput.SpokeColor;

            spinnerCircle_UC.ZeroitThematicProgress1.SpokeColor = progressInput.SpokeColor;

            #endregion

        }
        
        private void Set_SpinnerCircle_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.StylePreset =
                (ZeroitThematicProgress.StylePresets)Enum.Parse(typeof
                        (ZeroitThematicProgress.StylePresets),
                    spinnerCircle_UC.indicator_SpinnerCircle_StylePreset_ComboBox.SelectedItem.ToString());

            progressInput.Spinner_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    spinnerCircle_UC.indicator_SpinnerCircle_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.Spinner_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    spinnerCircle_UC.indicator_SpinnerCircle_EndCap_ComboBox.SelectedItem.ToString());


            #endregion

            #region Values

            progressInput.InnerCircleRadius =
                (int)spinnerCircle_UC.indicator_SpinnerCircle_InnerCircRadius_Numeric.Value;

            progressInput.NumberSpoke =
                (int)spinnerCircle_UC.indicator_SpinnerCircle_NoOfSpoke_Numeric.Value;

            progressInput.OuterCircleRadius =
                (int)spinnerCircle_UC.indicator_SpinnerCircle_OuterCircRadius_Numeric.Value;

            progressInput.RotationSpeed =
                (int)spinnerCircle_UC.indicator_SpinnerCircle_RotationSpeed_Numeric.Value;

            progressInput.SpokeThickness =
                (int)spinnerCircle_UC.indicator_SpinnerCircle_SpokeThickness_Numeric.Value;



            #endregion

            #region Colors

            progressInput.SpokeColor = spinnerCircle_UC.indicator_SpinnerCircle_SpokeColor_Btn.BackColor;

            #endregion

        }


        #region Preview Events

        private void Preview_SpinnerCircle_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                spinnerCircle_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                spinnerCircle_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion


    }
}
