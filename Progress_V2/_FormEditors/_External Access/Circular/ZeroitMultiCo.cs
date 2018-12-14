// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCo.cs" company="Zeroit Dev Technologies">
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

        private void Set_MultiCo_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            zeroitMultiCo_UC.Preview_Btn.Click += Preview_MultiCo_Click;

            #endregion

            #region Enum

            #region Add Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string noOfRings in Enum.GetNames(typeof(Rings)))
            {
                zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.Items.Add(noOfRings);

            }

            for (int i = 0; i < zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.Items.Count; i++)
            {
                if (progressInput.MC_NoOfRings ==
                    (Rings)Enum.Parse(typeof
                            (Rings),
                        zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.SelectedIndex = i;

                    zeroitMultiCo_UC.ZeroitThematicProgress1.MC_NoOfRings =
                        (Rings)Enum.Parse(typeof
                                (Rings),
                            zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            zeroitMultiCo_UC.circular_MultiCo_InnerBorder_Numeric.Value = progressInput.MC_InnerBorder;
            zeroitMultiCo_UC.circular_MultiCo_CorrectShiftWidth_Numeric.Value = progressInput.MC_CorrectShift;
            zeroitMultiCo_UC.circular_MultiCo_CorrectShiftHeight_Numeric.Value = progressInput.MC_CorrectShift_Height;
            zeroitMultiCo_UC.circular_MultiCo_RectangleShiftWidth_Numeric.Value = progressInput.MC_RectShift;
            zeroitMultiCo_UC.circular_MultiCo_RectangleShiftHeight_Numeric.Value = progressInput.MC_RectShift_Height;
            zeroitMultiCo_UC.circular_MultiCo_ShiftWidth_Numeric.Value = progressInput.MC_Shift;
            zeroitMultiCo_UC.circular_MultiCo_ShiftHeight_Numeric.Value = progressInput.MC_Shift_Height;


            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_InnerBorder = progressInput.MC_InnerBorder;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_CorrectShift = progressInput.MC_CorrectShift;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_CorrectShift_Height = progressInput.MC_CorrectShift_Height;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_RectShift = progressInput.MC_RectShift;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_RectShift_Height = progressInput.MC_RectShift_Height;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Shift = progressInput.MC_Shift;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Shift_Height = progressInput.MC_Shift_Height;

            #endregion

            #region Bool

            if (progressInput.MC_ShowInnerBorder == true)
            {
                zeroitMultiCo_UC.circular_MultiCo_ShowInnerBorder_Yes_RadioBtn.Checked = true;

                zeroitMultiCo_UC.ZeroitThematicProgress1.MC_ShowInnerBorder = true;

            }
            else
            {
                zeroitMultiCo_UC.circular_MultiCo_ShowInnerBorder_No_RadioBtn.Checked = true;

                zeroitMultiCo_UC.ZeroitThematicProgress1.MC_ShowInnerBorder = false;

            }

            #endregion

            #region Colors

            zeroitMultiCo_UC.circular_MultiCo_Color1_Btn.BackColor = progressInput.MC_Colors[0];
            zeroitMultiCo_UC.circular_MultiCo_Color2_Btn.BackColor = progressInput.MC_Colors[1];
            zeroitMultiCo_UC.circular_MultiCo_Color3_Btn.BackColor = progressInput.MC_Colors[2];
            zeroitMultiCo_UC.circular_MultiCo_Color4_Btn.BackColor = progressInput.MC_Colors[3];
            zeroitMultiCo_UC.circular_MultiCo_Color5_Btn.BackColor = progressInput.MC_Colors[4];
            zeroitMultiCo_UC.circular_MultiCo_Color6_Btn.BackColor = progressInput.MC_Colors[5];
            zeroitMultiCo_UC.circular_MultiCo_Color7_Btn.BackColor = progressInput.MC_Colors[6];
            zeroitMultiCo_UC.circular_MultiCo_Color8_Btn.BackColor = progressInput.MC_Colors[7];
            zeroitMultiCo_UC.circular_MultiCo_Color9_Btn.BackColor = progressInput.MC_Colors[8];
            zeroitMultiCo_UC.circular_MultiCo_Color10_Btn.BackColor = progressInput.MC_Colors[9];
            zeroitMultiCo_UC.circular_MultiCo_Color11_Btn.BackColor = progressInput.MC_Colors[10];
            zeroitMultiCo_UC.circular_MultiCo_Color12_Btn.BackColor = progressInput.MC_Colors[11];
            zeroitMultiCo_UC.circular_MultiCo_Color13_Btn.BackColor = progressInput.MC_Colors[12];
            zeroitMultiCo_UC.circular_MultiCo_Color14_Btn.BackColor = progressInput.MC_Colors[13];
            zeroitMultiCo_UC.circular_MultiCo_Color15_Btn.BackColor = progressInput.MC_Colors[14];
            zeroitMultiCo_UC.circular_MultiCo_Color16_Btn.BackColor = progressInput.MC_Colors[15];
            zeroitMultiCo_UC.circular_MultiCo_Color17_Btn.BackColor = progressInput.MC_Colors[16];
            zeroitMultiCo_UC.circular_MultiCo_Color18_Btn.BackColor = progressInput.MC_Colors[17];
            zeroitMultiCo_UC.circular_MultiCo_Color19_Btn.BackColor = progressInput.MC_Colors[18];
            zeroitMultiCo_UC.circular_MultiCo_Color20_Btn.BackColor = progressInput.MC_Colors[19];
            zeroitMultiCo_UC.circular_MultiCo_Color21_Btn.BackColor = progressInput.MC_Colors[20];
            zeroitMultiCo_UC.circular_MultiCo_Color22_Btn.BackColor = progressInput.MC_Colors[21];
            zeroitMultiCo_UC.circular_MultiCo_Color23_Btn.BackColor = progressInput.MC_Colors[22];
            zeroitMultiCo_UC.circular_MultiCo_Color24_Btn.BackColor = progressInput.MC_Colors[23];

            zeroitMultiCo_UC.circular_MultiCo_InnerBorder_Btn.BackColor = progressInput.MC_InnerBorderColor;
            zeroitMultiCo_UC.circular_MultiCo_InnerColor_Btn.BackColor = progressInput.MC_InnerColor;


            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[0] = progressInput.MC_Colors[0];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[1] = progressInput.MC_Colors[1];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[2] = progressInput.MC_Colors[2];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[3] = progressInput.MC_Colors[3];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[4] = progressInput.MC_Colors[4];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[5] = progressInput.MC_Colors[5];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[6] = progressInput.MC_Colors[6];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[7] = progressInput.MC_Colors[7];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[8] = progressInput.MC_Colors[8];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[9] = progressInput.MC_Colors[9];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[10] = progressInput.MC_Colors[10];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[11] = progressInput.MC_Colors[11];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[12] = progressInput.MC_Colors[12];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[13] = progressInput.MC_Colors[13];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[14] = progressInput.MC_Colors[14];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[15] = progressInput.MC_Colors[15];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[16] = progressInput.MC_Colors[16];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[17] = progressInput.MC_Colors[17];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[18] = progressInput.MC_Colors[18];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[19] = progressInput.MC_Colors[19];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[20] = progressInput.MC_Colors[20];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[21] = progressInput.MC_Colors[21];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[22] = progressInput.MC_Colors[22];
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_Colors[23] = progressInput.MC_Colors[23];

            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_InnerBorderColor = progressInput.MC_InnerBorderColor;
            zeroitMultiCo_UC.ZeroitThematicProgress1.MC_InnerColor = progressInput.MC_InnerColor;
            #endregion

        }

        private void Set_MultiCo_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.MC_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    zeroitMultiCo_UC.circular_MultiCo_NoOfRings_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            progressInput.MC_InnerBorder = (int)zeroitMultiCo_UC.circular_MultiCo_InnerBorder_Numeric.Value;
            progressInput.MC_CorrectShift = (int)zeroitMultiCo_UC.circular_MultiCo_CorrectShiftWidth_Numeric.Value;
            progressInput.MC_CorrectShift_Height = (int)zeroitMultiCo_UC.circular_MultiCo_CorrectShiftHeight_Numeric.Value;
            progressInput.MC_RectShift = (int)zeroitMultiCo_UC.circular_MultiCo_RectangleShiftWidth_Numeric.Value;
            progressInput.MC_RectShift_Height = (int)zeroitMultiCo_UC.circular_MultiCo_RectangleShiftHeight_Numeric.Value;
            progressInput.MC_Shift = (int)zeroitMultiCo_UC.circular_MultiCo_ShiftWidth_Numeric.Value;
            progressInput.MC_Shift_Height = (int)zeroitMultiCo_UC.circular_MultiCo_ShiftHeight_Numeric.Value;

            #endregion

            #region Bool

            if (zeroitMultiCo_UC.circular_MultiCo_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.MC_ShowInnerBorder = true;
                
            }
            else
            {
                progressInput.MC_ShowInnerBorder = false;
            }

            #endregion

            #region Colors

            progressInput.MC_Colors[0] = zeroitMultiCo_UC.circular_MultiCo_Color1_Btn.BackColor;
            progressInput.MC_Colors[1] = zeroitMultiCo_UC.circular_MultiCo_Color2_Btn.BackColor;
            progressInput.MC_Colors[2] = zeroitMultiCo_UC.circular_MultiCo_Color3_Btn.BackColor;
            progressInput.MC_Colors[3] = zeroitMultiCo_UC.circular_MultiCo_Color4_Btn.BackColor;
            progressInput.MC_Colors[4] = zeroitMultiCo_UC.circular_MultiCo_Color5_Btn.BackColor;
            progressInput.MC_Colors[5] = zeroitMultiCo_UC.circular_MultiCo_Color6_Btn.BackColor;
            progressInput.MC_Colors[6] = zeroitMultiCo_UC.circular_MultiCo_Color7_Btn.BackColor;
            progressInput.MC_Colors[7] = zeroitMultiCo_UC.circular_MultiCo_Color8_Btn.BackColor;
            progressInput.MC_Colors[8] = zeroitMultiCo_UC.circular_MultiCo_Color9_Btn.BackColor;
            progressInput.MC_Colors[9] = zeroitMultiCo_UC.circular_MultiCo_Color10_Btn.BackColor;
            progressInput.MC_Colors[10] = zeroitMultiCo_UC.circular_MultiCo_Color11_Btn.BackColor;
            progressInput.MC_Colors[11] = zeroitMultiCo_UC.circular_MultiCo_Color12_Btn.BackColor;
            progressInput.MC_Colors[12] = zeroitMultiCo_UC.circular_MultiCo_Color13_Btn.BackColor;
            progressInput.MC_Colors[13] = zeroitMultiCo_UC.circular_MultiCo_Color14_Btn.BackColor;
            progressInput.MC_Colors[14] = zeroitMultiCo_UC.circular_MultiCo_Color15_Btn.BackColor;
            progressInput.MC_Colors[15] = zeroitMultiCo_UC.circular_MultiCo_Color16_Btn.BackColor;
            progressInput.MC_Colors[16] = zeroitMultiCo_UC.circular_MultiCo_Color17_Btn.BackColor;
            progressInput.MC_Colors[17] = zeroitMultiCo_UC.circular_MultiCo_Color18_Btn.BackColor;
            progressInput.MC_Colors[18] = zeroitMultiCo_UC.circular_MultiCo_Color19_Btn.BackColor;
            progressInput.MC_Colors[19] = zeroitMultiCo_UC.circular_MultiCo_Color20_Btn.BackColor;
            progressInput.MC_Colors[20] = zeroitMultiCo_UC.circular_MultiCo_Color21_Btn.BackColor;
            progressInput.MC_Colors[21] = zeroitMultiCo_UC.circular_MultiCo_Color22_Btn.BackColor;
            progressInput.MC_Colors[22] = zeroitMultiCo_UC.circular_MultiCo_Color23_Btn.BackColor;
            progressInput.MC_Colors[23] = zeroitMultiCo_UC.circular_MultiCo_Color24_Btn.BackColor;


            progressInput.MC_InnerBorderColor = zeroitMultiCo_UC.circular_MultiCo_InnerBorder_Btn.BackColor;
            progressInput.MC_InnerBorderColor = zeroitMultiCo_UC.circular_MultiCo_InnerColor_Btn.BackColor;
            #endregion


        }

        #region Preview Events

        private void Preview_MultiCo_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                zeroitMultiCo_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
