// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerV1.cs" company="Zeroit Dev Technologies">
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

        private void Set_DaggerV1_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            daggerV2_UC.Preview_Btn.Click += Preview_DaggerV1_Click;

            #endregion

            #region Add Alignment to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(PenAlignment)))
            {
                daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.Alignment ==
                    (PenAlignment)Enum.Parse(typeof
                            (PenAlignment),
                        daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.Alignment =
                        (PenAlignment)Enum.Parse(typeof
                                (PenAlignment),
                            daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Dash Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(DashCap)))
            {
                daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.DashCap ==
                    (DashCap)Enum.Parse(typeof
                            (DashCap),
                        daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.DashCap =
                        (DashCap)Enum.Parse(typeof
                                (DashCap),
                            daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Dash Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(DashStyle)))
            {
                daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.DashStyle ==
                    (DashStyle)Enum.Parse(typeof
                            (DashStyle),
                        daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.DashStyle =
                        (DashStyle)Enum.Parse(typeof
                                (DashStyle),
                            daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineCap)))
            {
                daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.StartCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.StartCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineCap)))
            {
                daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.EndCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.EndCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Line Join to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineJoin)))
            {
                daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressEffects.LineJoin ==
                    (LineJoin)Enum.Parse(typeof
                            (LineJoin),
                        daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.Items[i].ToString()))
                {
                    daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.SelectedIndex = i;

                    daggerV2_UC.ZeroitThematicProgress1.ProgressEffects.LineJoin =
                        (LineJoin)Enum.Parse(typeof
                                (LineJoin),
                            daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Values

            daggerV2_UC.circular_DaggerV2_BorderWidth_Numeric.Value = progressInput.DagInnerBorderWidth;
            //daggerV2_UC.circular_DaggerV2_EndAngle_Numeric.Value = progressInput.DagFilledColorAlpha;
            daggerV2_UC.circular_DaggerV2_FilledThickness_Numeric.Value = progressInput.DagUpFilledThickness;
            daggerV2_UC.circular_DaggerV2_InnerFilledThickness_Numeric.Value = progressInput.DagUpFilledThicknessInner;
            daggerV2_UC.circular_DaggerV2_UnfilledThickness_Numeric.Value = progressInput.DagUpUnfilledThickness;
            //daggerV2_UC.circular_DaggerV2_InnerUnfilledThickness_Numeric.Value = progressInput.DagUpFilledThicknessInner;
            daggerV2_UC.circular_DaggerV2_AnimationSpeed_Numeric.Value = progressInput.DagAnimUpSpeed;
            daggerV2_UC.circular_DaggerV2_InnerTransparency_Numeric.Value = progressInput.DagUpFilledColorAlphaInner;
            daggerV2_UC.circular_DaggerV2_OuterTransparency_Numeric.Value = progressInput.DagUpFilledColorAlpha;


            daggerV2_UC.ZeroitThematicProgress1.DagInnerBorderWidth = progressInput.DagInnerBorderWidth;
            //daggerV2_UC.circular_DaggerV2_EndAngle_Numeric.Value = progressInput.DagFilledColorAlpha;
            daggerV2_UC.ZeroitThematicProgress1.DagUpFilledThickness = progressInput.DagUpFilledThickness;
            daggerV2_UC.ZeroitThematicProgress1.DagUpFilledThicknessInner = progressInput.DagUpFilledThicknessInner;
            daggerV2_UC.ZeroitThematicProgress1.DagUpUnfilledThickness = progressInput.DagUpUnfilledThickness;
            //daggerV2_UC.ZeroitThematicProgress1.DagUpFilledThicknessInner = progressInput.DagUpFilledThicknessInner;
            daggerV2_UC.ZeroitThematicProgress1.DagAnimUpSpeed = progressInput.DagAnimUpSpeed;
            daggerV2_UC.ZeroitThematicProgress1.DagUpFilledColorAlphaInner = progressInput.DagUpFilledColorAlphaInner;
            daggerV2_UC.ZeroitThematicProgress1.DagUpFilledColorAlpha = progressInput.DagUpFilledColorAlpha;

            daggerV2_UC.ZeroitThematicProgress1.Value = 30;

            #endregion

            #region Colors

            daggerV2_UC.circular_DaggerV2_InnerCircleBorderColor_Btn.BackColor = progressInput.DagInnerBorder;
            daggerV2_UC.circular_DaggerV2_UnfilledColor_Btn.BackColor = progressInput.DagUpUnFilledColor;
            daggerV2_UC.circular_DaggerV2_FilledColor_Btn.BackColor = progressInput.DagUpFilledColor;
            daggerV2_UC.circular_DaggerV2_InnerFilledColor_Btn.BackColor = progressInput.DagUpInnerFilledColor;
            daggerV2_UC.circular_DaggerV2_InnerCircleColor_Btn.BackColor = progressInput.DagInnerColor;

            daggerV2_UC.ZeroitThematicProgress1.DagInnerBorder = progressInput.DagInnerBorder;
            daggerV2_UC.ZeroitThematicProgress1.DagUpUnFilledColor = progressInput.DagUpUnFilledColor;
            daggerV2_UC.ZeroitThematicProgress1.DagUpFilledColor = progressInput.DagUpFilledColor;
            daggerV2_UC.ZeroitThematicProgress1.DagUpInnerFilledColor = progressInput.DagUpInnerFilledColor;
            daggerV2_UC.ZeroitThematicProgress1.DagInnerColor = progressInput.DagInnerColor;
            
            #endregion

            #region Bool

            if (progressInput.DagUpIsAnimated == true)
            {
                daggerV2_UC.circular_DaggerV2_Animated_Yes_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagUpIsAnimated = true;
            }
            else
            {
                daggerV2_UC.circular_DaggerV2_Animated_No_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagUpIsAnimated = false;
            }

            if (progressInput.DagStyled == true)
            {
                daggerV2_UC.circular_DaggerV2_Styled_Yes_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagStyled = true;
            }
            else
            {
                daggerV2_UC.circular_DaggerV2_Styled_No_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagStyled = false;
            }

            if (progressInput.DagDrawInnerCircle == true)
            {
                daggerV2_UC.circular_DaggerV2_InnerCircle_Yes_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagDrawInnerCircle = true;
            }
            else
            {
                daggerV2_UC.circular_DaggerV2_InnerCircle_No_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagDrawInnerCircle = false;
            }

            if (progressInput.DagUpInnerBorder == true)
            {
                daggerV2_UC.circular_DaggerV2_InnerBorder_Yes_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagUpInnerBorder = true;
            }
            else
            {
                daggerV2_UC.circular_DaggerV2_InnerBorder_No_RadioBtn.Checked = true;

                daggerV2_UC.ZeroitThematicProgress1.DagUpInnerBorder = false;
            }

            #endregion


        }


        private void Set_DaggerV1_Retrieved_Values(ProgressInput progressInput)
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

            #region Add Alignment to ComboBox

            progressInput.ProgressEffects.Alignment =
                (PenAlignment) Enum.Parse(typeof
                        (PenAlignment),
                    daggerV2_UC.circular_DaggerV2_Alignment_ComboBox.SelectedItem.ToString());
            
            #endregion

            #region Add Dash Cap to ComboBox
            
            progressInput.ProgressEffects.DashCap =
                (DashCap) Enum.Parse(typeof
                        (DashCap),
                    daggerV2_UC.circular_DaggerV2_DashCap_ComboBox.SelectedItem.ToString());

            #endregion

            #region Add Dash Style to ComboBox

            progressInput.ProgressEffects.DashStyle =
                (DashStyle) Enum.Parse(typeof
                        (DashStyle),
                    daggerV2_UC.circular_DaggerV2_DashStyle_ComboBox.SelectedItem.ToString());

            #endregion

            #region Add Start Cap to ComboBox

            progressInput.ProgressEffects.StartCap =
                (LineCap) Enum.Parse(typeof
                        (LineCap),
                    daggerV2_UC.circular_DaggerV2_StartCap_ComboBox.SelectedItem.ToString());

            #endregion

            #region Add End Cap to ComboBox

            progressInput.ProgressEffects.EndCap =
                (LineCap) Enum.Parse(typeof
                        (LineCap),
                    daggerV2_UC.circular_DaggerV2_EndCap_ComboBox.SelectedItem.ToString());

            #endregion

            #region Add Line Join to ComboBox

            progressInput.ProgressEffects.LineJoin =
                (LineJoin) Enum.Parse(typeof
                        (LineJoin),
                    daggerV2_UC.circular_DaggerV2_LineJoin_ComboBox.SelectedItem.ToString());

            #endregion


            #endregion

            #region Values

            progressInput.DagInnerBorderWidth = (int)daggerV2_UC.circular_DaggerV2_BorderWidth_Numeric.Value;
            progressInput.DagUpFilledThickness = (int)daggerV2_UC.circular_DaggerV2_FilledThickness_Numeric.Value;
            progressInput.DagUpFilledThicknessInner = (int)daggerV2_UC.circular_DaggerV2_InnerFilledThickness_Numeric.Value;
            progressInput.DagUpUnfilledThickness = (int)daggerV2_UC.circular_DaggerV2_UnfilledThickness_Numeric.Value;
            //progressInput.DagUpFilledThicknessInner = (int)daggerV2_UC.circular_DaggerV2_InnerUnfilledThickness_Numeric.Value;
            progressInput.DagAnimUpSpeed = (int)daggerV2_UC.circular_DaggerV2_AnimationSpeed_Numeric.Value;
            progressInput.DagUpFilledColorAlphaInner = (int)daggerV2_UC.circular_DaggerV2_InnerTransparency_Numeric.Value;
            progressInput.DagUpFilledColorAlpha = (int)daggerV2_UC.circular_DaggerV2_OuterTransparency_Numeric.Value;

            #endregion

            #region Colors

            progressInput.DagInnerBorder = daggerV2_UC.circular_DaggerV2_InnerCircleBorderColor_Btn.BackColor;
            progressInput.DagUpUnFilledColor = daggerV2_UC.circular_DaggerV2_UnfilledColor_Btn.BackColor;
            progressInput.DagUpFilledColor = daggerV2_UC.circular_DaggerV2_FilledColor_Btn.BackColor;
            progressInput.DagUpInnerFilledColor = daggerV2_UC.circular_DaggerV2_InnerFilledColor_Btn.BackColor;
            progressInput.DagInnerColor = daggerV2_UC.circular_DaggerV2_InnerCircleColor_Btn.BackColor;

            #endregion

            #region Bool

            if (daggerV2_UC.circular_DaggerV2_Animated_Yes_RadioBtn.Checked == true)
            {
                progressInput.DagUpIsAnimated = true;
                
            }
            else
            {
                progressInput.DagUpIsAnimated = false;
            }

            if (daggerV2_UC.circular_DaggerV2_Styled_Yes_RadioBtn.Checked == true)
            {
                progressInput.DagStyled = true;
                
            }
            else
            {
                progressInput.DagStyled = false;
            }

            if (daggerV2_UC.circular_DaggerV2_InnerCircle_Yes_RadioBtn.Checked == true)
            {

                progressInput.DagDrawInnerCircle = true;
                
            }
            else
            {
                progressInput.DagDrawInnerCircle = false;
            }

            if (daggerV2_UC.circular_DaggerV2_InnerBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.DagUpInnerBorder = true;
                
            }
            else
            {
                progressInput.DagUpInnerBorder = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_DaggerV1_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (daggerV2_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    daggerV2_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    daggerV2_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                daggerV2_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (daggerV2_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    daggerV2_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    daggerV2_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                daggerV2_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
