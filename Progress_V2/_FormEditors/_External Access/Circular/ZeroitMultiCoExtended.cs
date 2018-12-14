// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended.cs" company="Zeroit Dev Technologies">
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

        private void Set_MultiCoExtended_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            zeroitMultiCoExtended_UC.Preview_Btn.Click += Preview_MultiCoExtended_Click;

            #endregion

            #region Enum

            #region Add Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string noOfRings in Enum.GetNames(typeof(Rings)))
            {
                zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.Items.Add(noOfRings);

            }

            for (int i = 0; i < zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCEx_NoOfRings ==
                    (Rings)Enum.Parse(typeof
                            (Rings),
                        zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_NoOfRings =
                        (Rings)Enum.Parse(typeof
                                (Rings),
                            zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerBorder_Numeric.Value = progressInput.MCEx_InnerBorder;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_CorrectShiftWidth_Numeric.Value = progressInput.MCEx_CorrectShift;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_CorrectShiftHeight_Numeric.Value = progressInput.MCEx_CorrectShift_Height;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_RectangleShiftWidth_Numeric.Value = progressInput.MCEx_RectShift;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_RectangleShiftHeight_Numeric.Value = progressInput.MCEx_RectShift_Height;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_ShiftWidth_Numeric.Value = progressInput.MCEx_Shift;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_ShiftHeight_Numeric.Value = progressInput.MCEx_Shift_Height;


            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_InnerBorder = progressInput.MCEx_InnerBorder;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_CorrectShift = progressInput.MCEx_CorrectShift;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_CorrectShift_Height = progressInput.MCEx_CorrectShift_Height;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_RectShift = progressInput.MCEx_RectShift;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_RectShift_Height = progressInput.MCEx_RectShift_Height;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Shift = progressInput.MCEx_Shift;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Shift_Height = progressInput.MCEx_Shift_Height;

            #endregion

            #region Bool

            if (progressInput.MCEx_ShowInnerBorder == true)
            {
                zeroitMultiCoExtended_UC.circular_MultiCoEx_ShowInnerBorder_Yes_RadioBtn.Checked = true;

                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_ShowInnerBorder = true;

            }
            else
            {
                zeroitMultiCoExtended_UC.circular_MultiCoEx_ShowInnerBorder_No_RadioBtn.Checked = true;

                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_ShowInnerBorder = false;

            }

            #endregion

            #region Colors

            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color1_Btn.BackColor = progressInput.MCEx_Colors[0];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color2_Btn.BackColor = progressInput.MCEx_Colors[1];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color3_Btn.BackColor = progressInput.MCEx_Colors[2];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color4_Btn.BackColor = progressInput.MCEx_Colors[3];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color5_Btn.BackColor = progressInput.MCEx_Colors[4];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color6_Btn.BackColor = progressInput.MCEx_Colors[5];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color7_Btn.BackColor = progressInput.MCEx_Colors[6];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color8_Btn.BackColor = progressInput.MCEx_Colors[7];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color9_Btn.BackColor = progressInput.MCEx_Colors[8];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color10_Btn.BackColor = progressInput.MCEx_Colors[9];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color11_Btn.BackColor = progressInput.MCEx_Colors[10];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color12_Btn.BackColor = progressInput.MCEx_Colors[11];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color13_Btn.BackColor = progressInput.MCEx_Colors[12];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color14_Btn.BackColor = progressInput.MCEx_Colors[13];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color15_Btn.BackColor = progressInput.MCEx_Colors[14];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color16_Btn.BackColor = progressInput.MCEx_Colors[15];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color17_Btn.BackColor = progressInput.MCEx_Colors[16];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color18_Btn.BackColor = progressInput.MCEx_Colors[17];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color19_Btn.BackColor = progressInput.MCEx_Colors[18];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color20_Btn.BackColor = progressInput.MCEx_Colors[19];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color21_Btn.BackColor = progressInput.MCEx_Colors[20];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color22_Btn.BackColor = progressInput.MCEx_Colors[21];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color23_Btn.BackColor = progressInput.MCEx_Colors[22];
            zeroitMultiCoExtended_UC.circular_MultiCoEx_Color24_Btn.BackColor = progressInput.MCEx_Colors[23];

            zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerBorderColor_Btn.BackColor = progressInput.MCEx_InnerBorderColor;
            zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerColor_Btn.BackColor = progressInput.MCEx_InnerColor;


            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[0] = progressInput.MCEx_Colors[0];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[1] = progressInput.MCEx_Colors[1];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[2] = progressInput.MCEx_Colors[2];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[3] = progressInput.MCEx_Colors[3];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[4] = progressInput.MCEx_Colors[4];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[5] = progressInput.MCEx_Colors[5];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[6] = progressInput.MCEx_Colors[6];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[7] = progressInput.MCEx_Colors[7];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[8] = progressInput.MCEx_Colors[8];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[9] = progressInput.MCEx_Colors[9];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[10] = progressInput.MCEx_Colors[10];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[11] = progressInput.MCEx_Colors[11];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[12] = progressInput.MCEx_Colors[12];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[13] = progressInput.MCEx_Colors[13];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[14] = progressInput.MCEx_Colors[14];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[15] = progressInput.MCEx_Colors[15];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[16] = progressInput.MCEx_Colors[16];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[17] = progressInput.MCEx_Colors[17];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[18] = progressInput.MCEx_Colors[18];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[19] = progressInput.MCEx_Colors[19];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[20] = progressInput.MCEx_Colors[20];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[21] = progressInput.MCEx_Colors[21];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[22] = progressInput.MCEx_Colors[22];
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_Colors[23] = progressInput.MCEx_Colors[23];

            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_InnerBorderColor = progressInput.MCEx_InnerBorderColor;
            zeroitMultiCoExtended_UC.ZeroitThematicProgress1.MCEx_InnerColor = progressInput.MCEx_InnerColor;
            #endregion

        }

        private void Set_MultiCoExtended_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.MCEx_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    zeroitMultiCoExtended_UC.circular_MultiCoEx_NoOfRings_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            progressInput.MCEx_InnerBorder = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerBorder_Numeric.Value;
            progressInput.MCEx_CorrectShift = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_CorrectShiftWidth_Numeric.Value;
            progressInput.MCEx_CorrectShift_Height = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_CorrectShiftHeight_Numeric.Value;
            progressInput.MCEx_RectShift = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_RectangleShiftWidth_Numeric.Value;
            progressInput.MCEx_RectShift_Height = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_RectangleShiftHeight_Numeric.Value;
            progressInput.MCEx_Shift = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_ShiftWidth_Numeric.Value;
            progressInput.MCEx_Shift_Height = (int)zeroitMultiCoExtended_UC.circular_MultiCoEx_ShiftHeight_Numeric.Value;

            #endregion

            #region Bool

            if (zeroitMultiCoExtended_UC.circular_MultiCoEx_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.MCEx_ShowInnerBorder = true;
                
            }
            else
            {
                progressInput.MCEx_ShowInnerBorder = false;
            }

            #endregion

            #region Colors

            progressInput.MCEx_Colors[0] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color1_Btn.BackColor;
            progressInput.MCEx_Colors[1] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color2_Btn.BackColor;
            progressInput.MCEx_Colors[2] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color3_Btn.BackColor;
            progressInput.MCEx_Colors[3] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color4_Btn.BackColor;
            progressInput.MCEx_Colors[4] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color5_Btn.BackColor;
            progressInput.MCEx_Colors[5] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color6_Btn.BackColor;
            progressInput.MCEx_Colors[6] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color7_Btn.BackColor;
            progressInput.MCEx_Colors[7] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color8_Btn.BackColor;
            progressInput.MCEx_Colors[8] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color9_Btn.BackColor;
            progressInput.MCEx_Colors[9] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color10_Btn.BackColor;
            progressInput.MCEx_Colors[10] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color11_Btn.BackColor;
            progressInput.MCEx_Colors[11] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color12_Btn.BackColor;
            progressInput.MCEx_Colors[12] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color13_Btn.BackColor;
            progressInput.MCEx_Colors[13] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color14_Btn.BackColor;
            progressInput.MCEx_Colors[14] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color15_Btn.BackColor;
            progressInput.MCEx_Colors[15] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color16_Btn.BackColor;
            progressInput.MCEx_Colors[16] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color17_Btn.BackColor;
            progressInput.MCEx_Colors[17] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color18_Btn.BackColor;
            progressInput.MCEx_Colors[18] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color19_Btn.BackColor;
            progressInput.MCEx_Colors[19] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color20_Btn.BackColor;
            progressInput.MCEx_Colors[20] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color21_Btn.BackColor;
            progressInput.MCEx_Colors[21] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color22_Btn.BackColor;
            progressInput.MCEx_Colors[22] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color23_Btn.BackColor;
            progressInput.MCEx_Colors[23] = zeroitMultiCoExtended_UC.circular_MultiCoEx_Color24_Btn.BackColor;


            progressInput.MCEx_InnerBorderColor = zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerBorderColor_Btn.BackColor;
            progressInput.MCEx_InnerBorderColor = zeroitMultiCoExtended_UC.circular_MultiCoEx_InnerColor_Btn.BackColor;
            #endregion


        }

        #region Preview Events

        private void Preview_MultiCoExtended_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                zeroitMultiCoExtended_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
