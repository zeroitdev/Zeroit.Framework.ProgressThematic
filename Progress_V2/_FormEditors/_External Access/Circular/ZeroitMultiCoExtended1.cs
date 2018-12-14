// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ZeroitMultiCoExtended1.cs" company="Zeroit Dev Technologies">
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

        private void Set_MultiCoExtendedV1_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            zeroitMultiCoExtendedV1_UC.Preview_Btn.Click += Preview_MultiCoExtendedV1_Click;

            #endregion

            #region Enum

            #region Add Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string type in Enum.GetNames(typeof(Rings)))
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.Items.Add(type);

            }

            for (int i = 0; i < zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCExV2_NoOfRings ==
                    (Rings)Enum.Parse(typeof
                            (Rings),
                        zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_NoOfRings =
                        (Rings)Enum.Parse(typeof
                                (Rings),
                            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Border Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startEnd in Enum.GetNames(typeof(LineCap)))
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.Items.Add(startEnd);

            }

            for (int i = 0; i < zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCExV2_OuterBorderStart ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorderStart =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Border End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string borderEnd in Enum.GetNames(typeof(LineCap)))
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.Items.Add(borderEnd);

            }

            for (int i = 0; i < zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCExV2_OuterBorderEnd ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorderEnd =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Border Style Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string borderStyle in Enum.GetNames(typeof(DashStyle)))
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.Items.Add(borderStyle);

            }

            for (int i = 0; i < zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCExV2_OuterBorderStyle ==
                    (DashStyle)Enum.Parse(typeof
                            (DashStyle),
                        zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorderStyle =
                        (DashStyle)Enum.Parse(typeof
                                (DashStyle),
                            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Draw Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string borderStyle in Enum.GetNames(typeof(drawMode)))
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.Items.Add(borderStyle);

            }

            for (int i = 0; i < zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.MCExV2_DrawMode ==
                    (drawMode)Enum.Parse(typeof
                            (drawMode),
                        zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.Items[i].ToString()))
                {
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.SelectedIndex = i;

                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_DrawMode =
                        (drawMode)Enum.Parse(typeof
                                (drawMode),
                            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerBorder_Numeric.Value = progressInput.MCExV2_InnerBorder;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_CorrectShiftWidth_Numeric.Value = progressInput.MCExV2_CorrectShift;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_CorrectShiftHeight_Numeric.Value = progressInput.MCExV2_CorrectShift_Height;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_RectangleShiftWidth_Numeric.Value = progressInput.MCExV2_RectShift;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_RectangleShiftHeight_Numeric.Value = progressInput.MCExV2_RectShift_Height;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShiftWidth_Numeric.Value = progressInput.MCExV2_Shift;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShiftHeight_Numeric.Value = progressInput.MCExV2_Shift_Height;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_GradientAngle_Numeric.Value = (decimal)progressInput.MCExV2_GradientAngle;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DivisionsWidth_Numeric.Value = progressInput.MCExV2_DivisionsWidth;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorder_Numeric.Value = progressInput.MCExV2_OuterBorderWidth;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_HorizontalTweak_Numeric.Value = progressInput.MCExV2_Position_Horizontal;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_VerticalTweak_Numeric.Value = progressInput.MCExV2_Position_Vertical;

            

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_InnerBorder = progressInput.MCExV2_InnerBorder;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_CorrectShift = progressInput.MCExV2_CorrectShift;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_CorrectShift_Height = progressInput.MCExV2_CorrectShift_Height;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_RectShift = progressInput.MCExV2_RectShift;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_RectShift_Height = progressInput.MCExV2_RectShift_Height;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Shift = progressInput.MCExV2_Shift;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Shift_Height = progressInput.MCExV2_Shift_Height;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_GradientAngle = progressInput.MCExV2_GradientAngle;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_DivisionsWidth = progressInput.MCExV2_DivisionsWidth;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorderWidth = progressInput.MCExV2_OuterBorderWidth;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Position_Horizontal = progressInput.MCExV2_Position_Horizontal;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Position_Vertical = progressInput.MCExV2_Position_Vertical;
            
            #endregion

            #region Bool

            if (progressInput.ShowInnerBorder == true)
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShowInnerBorder_Yes_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ShowInnerBorder = true;

            }
            else
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShowInnerBorder_No_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.ShowInnerBorder = false;

            }

            if (progressInput.MCExV2_OuterBorder == true)
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorder_Yes_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorder = true;

            }
            else
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorder_No_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterBorder = false;

            }

            if (progressInput.MCExV2_Divisions == true)
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Divisions_Yes_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Divisions = true;

            }
            else
            {
                zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Divisions_No_RadioBtn.Checked = true;

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Divisions = false;

            }

            #endregion

            #region Colors

            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color1_Btn.BackColor = progressInput.MCExV2_Colors[0];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color2_Btn.BackColor = progressInput.MCExV2_Colors[1];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color3_Btn.BackColor = progressInput.MCExV2_Colors[2];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color4_Btn.BackColor = progressInput.MCExV2_Colors[3];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color5_Btn.BackColor = progressInput.MCExV2_Colors[4];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color6_Btn.BackColor = progressInput.MCExV2_Colors[5];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color7_Btn.BackColor = progressInput.MCExV2_Colors[6];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color8_Btn.BackColor = progressInput.MCExV2_Colors[7];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color9_Btn.BackColor = progressInput.MCExV2_Colors[8];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color10_Btn.BackColor = progressInput.MCExV2_Colors[9];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color11_Btn.BackColor = progressInput.MCExV2_Colors[10];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color12_Btn.BackColor = progressInput.MCExV2_Colors[11];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color13_Btn.BackColor = progressInput.MCExV2_Colors[12];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color14_Btn.BackColor = progressInput.MCExV2_Colors[13];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color15_Btn.BackColor = progressInput.MCExV2_Colors[14];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color16_Btn.BackColor = progressInput.MCExV2_Colors[15];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color17_Btn.BackColor = progressInput.MCExV2_Colors[16];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color18_Btn.BackColor = progressInput.MCExV2_Colors[17];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color19_Btn.BackColor = progressInput.MCExV2_Colors[18];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color20_Btn.BackColor = progressInput.MCExV2_Colors[19];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color21_Btn.BackColor = progressInput.MCExV2_Colors[20];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color22_Btn.BackColor = progressInput.MCExV2_Colors[21];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color23_Btn.BackColor = progressInput.MCExV2_Colors[22];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color24_Btn.BackColor = progressInput.MCExV2_Colors[23];

            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerBorderColor_Btn.BackColor = progressInput.MCExV2_InnerBorderColor;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerColor_Btn.BackColor = progressInput.MCExV2_InnerColor;
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerHoleGrad1_Btn.BackColor = progressInput.MCExV2_InnerHoleGradCol[0];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerHoleGrad2_Btn.BackColor = progressInput.MCExV2_InnerHoleGradCol[1];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterColor1_Btn.BackColor = progressInput.MCExV2_OuterColor[0];
            zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterColor2_Btn.BackColor = progressInput.MCExV2_OuterColor[1];


            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[0] = progressInput.MCExV2_Colors[0];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[1] = progressInput.MCExV2_Colors[1];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[2] = progressInput.MCExV2_Colors[2];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[3] = progressInput.MCExV2_Colors[3];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[4] = progressInput.MCExV2_Colors[4];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[5] = progressInput.MCExV2_Colors[5];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[6] = progressInput.MCExV2_Colors[6];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[7] = progressInput.MCExV2_Colors[7];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[8] = progressInput.MCExV2_Colors[8];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[9] = progressInput.MCExV2_Colors[9];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[10] = progressInput.MCExV2_Colors[10];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[11] = progressInput.MCExV2_Colors[11];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[12] = progressInput.MCExV2_Colors[12];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[13] = progressInput.MCExV2_Colors[13];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[14] = progressInput.MCExV2_Colors[14];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[15] = progressInput.MCExV2_Colors[15];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[16] = progressInput.MCExV2_Colors[16];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[17] = progressInput.MCExV2_Colors[17];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[18] = progressInput.MCExV2_Colors[18];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[19] = progressInput.MCExV2_Colors[19];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[20] = progressInput.MCExV2_Colors[20];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[21] = progressInput.MCExV2_Colors[21];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[22] = progressInput.MCExV2_Colors[22];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_Colors[23] = progressInput.MCExV2_Colors[23];

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_InnerBorderColor = progressInput.MCExV2_InnerBorderColor;
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_InnerColor = progressInput.MCExV2_InnerColor;

            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_InnerHoleGradCol[0] = progressInput.MCExV2_InnerHoleGradCol[0];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_InnerHoleGradCol[1] = progressInput.MCExV2_InnerHoleGradCol[1];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterColor[0] = progressInput.MCExV2_OuterColor[0];
            zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.MCExV2_OuterColor[1] = progressInput.MCExV2_OuterColor[1];

            #endregion

        }

        private void Set_MultiCoExtendedV1_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.MCExV2_NoOfRings =
                (Rings)Enum.Parse(typeof
                        (Rings),
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_NoOfRings_ComboBox.SelectedItem.ToString());

            progressInput.MCExV2_OuterBorderStart =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStart_ComboBox.SelectedItem.ToString());

            progressInput.MCExV2_OuterBorderEnd =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderEnd_ComboBox.SelectedItem.ToString());

            progressInput.MCExV2_OuterBorderStyle =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorderStyle_ComboBox.SelectedItem.ToString());

            progressInput.MCExV2_DrawMode =
                (drawMode)Enum.Parse(typeof
                        (drawMode),
                    zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DrawMode_ComboBox.SelectedItem.ToString());


            #endregion

            #region Values

            progressInput.MCExV2_InnerBorder = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerBorder_Numeric.Value;
            progressInput.MCExV2_CorrectShift = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_CorrectShiftWidth_Numeric.Value;
            progressInput.MCExV2_CorrectShift_Height = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_CorrectShiftHeight_Numeric.Value;
            progressInput.MCExV2_RectShift = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_RectangleShiftWidth_Numeric.Value;
            progressInput.MCExV2_RectShift_Height = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_RectangleShiftHeight_Numeric.Value;
            progressInput.MCExV2_Shift = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShiftWidth_Numeric.Value;
            progressInput.MCExV2_Shift_Height = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShiftHeight_Numeric.Value;
            progressInput.MCExV2_GradientAngle = (float)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_GradientAngle_Numeric.Value;
            progressInput.MCExV2_DivisionsWidth = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_DivisionsWidth_Numeric.Value;
            progressInput.MCExV2_OuterBorderWidth = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorder_Numeric.Value;
            progressInput.MCExV2_Position_Horizontal = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_HorizontalTweak_Numeric.Value;
            progressInput.MCExV2_Position_Vertical = (int)zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_VerticalTweak_Numeric.Value;

            #endregion

            #region Bool

            if (zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_ShowInnerBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerBorder = true;
                
            }
            else
            {
                progressInput.ShowInnerBorder = false;
            }

            if (zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.MCExV2_OuterBorder = true;
                
            }
            else
            {
                progressInput.MCExV2_OuterBorder = false;
            }

            if (zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Divisions_Yes_RadioBtn.Checked == true)
            {
                progressInput.MCExV2_Divisions = true;
            }
            else
            {
                progressInput.MCExV2_Divisions = false;
            }

            #endregion

            #region Colors

            progressInput.MCExV2_Colors[0] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color1_Btn.BackColor;
            progressInput.MCExV2_Colors[1] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color2_Btn.BackColor;
            progressInput.MCExV2_Colors[2] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color3_Btn.BackColor;
            progressInput.MCExV2_Colors[3] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color4_Btn.BackColor;
            progressInput.MCExV2_Colors[4] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color5_Btn.BackColor;
            progressInput.MCExV2_Colors[5] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color6_Btn.BackColor;
            progressInput.MCExV2_Colors[6] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color7_Btn.BackColor;
            progressInput.MCExV2_Colors[7] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color8_Btn.BackColor;
            progressInput.MCExV2_Colors[8] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color9_Btn.BackColor;
            progressInput.MCExV2_Colors[9] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color10_Btn.BackColor;
            progressInput.MCExV2_Colors[10] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color11_Btn.BackColor;
            progressInput.MCExV2_Colors[11] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color12_Btn.BackColor;
            progressInput.MCExV2_Colors[12] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color13_Btn.BackColor;
            progressInput.MCExV2_Colors[13] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color14_Btn.BackColor;
            progressInput.MCExV2_Colors[14] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color15_Btn.BackColor;
            progressInput.MCExV2_Colors[15] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color16_Btn.BackColor;
            progressInput.MCExV2_Colors[16] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color17_Btn.BackColor;
            progressInput.MCExV2_Colors[17] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color18_Btn.BackColor;
            progressInput.MCExV2_Colors[18] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color19_Btn.BackColor;
            progressInput.MCExV2_Colors[19] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color20_Btn.BackColor;
            progressInput.MCExV2_Colors[20] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color21_Btn.BackColor;
            progressInput.MCExV2_Colors[21] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color22_Btn.BackColor;
            progressInput.MCExV2_Colors[22] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color23_Btn.BackColor;
            progressInput.MCExV2_Colors[23] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_Color24_Btn.BackColor;


            progressInput.MCExV2_InnerBorderColor = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerBorderColor_Btn.BackColor;
            progressInput.MCExV2_InnerBorderColor = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerColor_Btn.BackColor;
            progressInput.MCExV2_InnerHoleGradCol[0] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerHoleGrad1_Btn.BackColor;
            progressInput.MCExV2_InnerHoleGradCol[1] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_InnerHoleGrad2_Btn.BackColor;

            progressInput.MCExV2_OuterColor[0] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterColor1_Btn.BackColor;
            progressInput.MCExV2_OuterColor[1] = zeroitMultiCoExtendedV1_UC.circular_MultiCoExV1_OuterColor2_Btn.BackColor;


            #endregion

        }

        #region Preview Events

        private void Preview_MultiCoExtendedV1_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                zeroitMultiCoExtendedV1_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
