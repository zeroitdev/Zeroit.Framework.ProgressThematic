// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Ignito.cs" company="Zeroit Dev Technologies">
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

        private void Set_Ignito_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            ignito_UC.Preview_Btn.Click += Preview_Ignito_Click;

            #endregion

            #region Enum

            #region Add Caps to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(LineCap)))
            {
                ignito_UC.circular_Ignito_Caps_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_Caps_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_Caps ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        ignito_UC.circular_Ignito_Caps_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_Caps_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_Caps =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            ignito_UC.circular_Ignito_Caps_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Draw Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(ZeroitThematicProgress.Ignito_drawMode)))
            {
                ignito_UC.circular_Ignito_DrawMode_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_DrawMode ==
                    (ZeroitThematicProgress.Ignito_drawMode)Enum.Parse(typeof
                            (ZeroitThematicProgress.Ignito_drawMode),
                        ignito_UC.circular_Ignito_DrawMode_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_DrawMode_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_DrawMode =
                        (ZeroitThematicProgress.Ignito_drawMode)Enum.Parse(typeof
                                (ZeroitThematicProgress.Ignito_drawMode),
                            ignito_UC.circular_Ignito_DrawMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Border Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(DashStyle)))
            {
                ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_BorderStyleInner ==
                    (DashStyle)Enum.Parse(typeof
                            (DashStyle),
                        ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_BorderStyleInner =
                        (DashStyle)Enum.Parse(typeof
                                (DashStyle),
                            ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Border Style Outer to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(DashStyle)))
            {
                ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_BorderStyleOuter ==
                    (DashStyle)Enum.Parse(typeof
                            (DashStyle),
                        ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_BorderStyleOuter =
                        (DashStyle)Enum.Parse(typeof
                                (DashStyle),
                            ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Outer Rotating Angle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(ZeroitThematicProgress.Ignito_outterRotatingAngle)))
            {
                ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_OutterRotatingAngle ==
                    (ZeroitThematicProgress.Ignito_outterRotatingAngle)Enum.Parse(typeof
                            (ZeroitThematicProgress.Ignito_outterRotatingAngle),
                        ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_OutterRotatingAngle =
                        (ZeroitThematicProgress.Ignito_outterRotatingAngle)Enum.Parse(typeof
                                (ZeroitThematicProgress.Ignito_outterRotatingAngle),
                            ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Inner Rotating Angle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(ZeroitThematicProgress.Ignito_innerRotatingAngle)))
            {
                ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.Items.Count; i++)
            {
                if (progressInput.IG_InnerRotatingAnlge ==
                    (ZeroitThematicProgress.Ignito_innerRotatingAngle)Enum.Parse(typeof
                            (ZeroitThematicProgress.Ignito_innerRotatingAngle),
                        ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.Items[i].ToString()))
                {
                    ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.SelectedIndex = i;

                    ignito_UC.ZeroitThematicProgress1.IG_InnerRotatingAnlge =
                        (ZeroitThematicProgress.Ignito_innerRotatingAngle)Enum.Parse(typeof
                                (ZeroitThematicProgress.Ignito_innerRotatingAngle),
                            ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            ignito_UC.circular_Ignito_OuterBorder_Numeric.Value = (decimal)progressInput.IG_OuterBorder;
            ignito_UC.circular_Ignito_InnerBorder_Numeric.Value = (decimal)progressInput.IG_InnerBorder;

            ignito_UC.ZeroitThematicProgress1.IG_OuterBorder = progressInput.IG_OuterBorder;
            ignito_UC.ZeroitThematicProgress1.IG_InnerBorder = progressInput.IG_InnerBorder;

            #endregion

            #region Colors

            ignito_UC.circular_Ignito_Color1_Btn.BackColor = progressInput.IG_Colors[0];
            ignito_UC.circular_Ignito_Color2_Btn.BackColor = progressInput.IG_Colors[1];
            ignito_UC.circular_Ignito_Color3_Btn.BackColor = progressInput.IG_Colors[2];
            ignito_UC.circular_Ignito_Color4_Btn.BackColor = progressInput.IG_Colors[3];
            ignito_UC.circular_Ignito_Color5_Btn.BackColor = progressInput.IG_Colors[4];
            ignito_UC.circular_Ignito_Color6_Btn.BackColor = progressInput.IG_Colors[5];
            ignito_UC.circular_Ignito_Color7_Btn.BackColor = progressInput.IG_Colors[6];
            ignito_UC.circular_Ignito_Color8_Btn.BackColor = progressInput.IG_Colors[7];
            ignito_UC.circular_Ignito_Color9_Btn.BackColor = progressInput.IG_Colors[8];
            ignito_UC.circular_Ignito_Color10_Btn.BackColor = progressInput.IG_Colors[9];
            ignito_UC.circular_Ignito_Color11_Btn.BackColor = progressInput.IG_Colors[10];
            ignito_UC.circular_Ignito_Color12_Btn.BackColor = progressInput.IG_Colors[11];

            ignito_UC.ZeroitThematicProgress1.IG_Colors[0] = progressInput.IG_Colors[0];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[1] = progressInput.IG_Colors[1];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[2] = progressInput.IG_Colors[2];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[3] = progressInput.IG_Colors[3];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[4] = progressInput.IG_Colors[4];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[5] = progressInput.IG_Colors[5];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[6] = progressInput.IG_Colors[6];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[7] = progressInput.IG_Colors[7];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[8] = progressInput.IG_Colors[8];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[9] = progressInput.IG_Colors[9];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[10] = progressInput.IG_Colors[10];
            ignito_UC.ZeroitThematicProgress1.IG_Colors[11] = progressInput.IG_Colors[11];

            ignito_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = progressInput.ColorHatchBrushgradient1;
            ignito_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = progressInput.ColorHatchBrushgradient2;

            #endregion

            #region Gradient Colors

            ignito_UC.circular_Ignito_GradientColor1_Btn.BackColor = progressInput.IG_GradientColors[0];
            ignito_UC.circular_Ignito_GradientColor2_Btn.BackColor = progressInput.IG_GradientColors[1];
            ignito_UC.circular_Ignito_GradientColor3_Btn.BackColor = progressInput.IG_GradientColors[2];
            ignito_UC.circular_Ignito_GradientColor4_Btn.BackColor = progressInput.IG_GradientColors[3];

            ignito_UC.ZeroitThematicProgress1.IG_GradientColors[0] = progressInput.IG_GradientColors[0];
            ignito_UC.ZeroitThematicProgress1.IG_GradientColors[1] = progressInput.IG_GradientColors[1];
            ignito_UC.ZeroitThematicProgress1.IG_GradientColors[2] = progressInput.IG_GradientColors[2];
            ignito_UC.ZeroitThematicProgress1.IG_GradientColors[3] = progressInput.IG_GradientColors[3];


            #endregion

            #region Bool

            if (progressInput.IG_EnableHatch == true)
            {
                ignito_UC.circular_Ignito_EnableHatch_Yes_RadioBtn.Checked = true;

                ignito_UC.ZeroitThematicProgress1.IG_EnableHatch = true;
            }
            else
            {
                ignito_UC.circular_Ignito_EnableHatch_No_RadioBtn.Checked = true;

                ignito_UC.ZeroitThematicProgress1.IG_EnableHatch = false;
            }

            #endregion


        }


        private void Set_Ignito_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.IG_Caps =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    ignito_UC.circular_Ignito_Caps_ComboBox.SelectedItem.ToString());

            progressInput.IG_DrawMode =
                (ZeroitThematicProgress.Ignito_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_drawMode),
                    ignito_UC.circular_Ignito_DrawMode_ComboBox.SelectedItem.ToString());

            progressInput.IG_BorderStyleInner =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    ignito_UC.circular_Ignito_BorderStyleInner_ComboBox.SelectedItem.ToString());

            progressInput.IG_BorderStyleOuter =
                (DashStyle)Enum.Parse(typeof
                        (DashStyle),
                    ignito_UC.circular_Ignito_BorderStyleOuter_ComboBox.SelectedItem.ToString());

            progressInput.IG_OutterRotatingAngle =
                (ZeroitThematicProgress.Ignito_outterRotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_outterRotatingAngle),
                    ignito_UC.circular_Ignito_OuterRotatingAngle_ComboBox.SelectedItem.ToString());


            progressInput.IG_InnerRotatingAnlge =
                (ZeroitThematicProgress.Ignito_innerRotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Ignito_innerRotatingAngle),
                    ignito_UC.circular_Ignito_InnerRotatingAngle_ComboBox.SelectedItem.ToString());



            #endregion

            #region Values

            progressInput.IG_OuterBorder = (float)ignito_UC.circular_Ignito_OuterBorder_Numeric.Value;
            progressInput.IG_InnerBorder = (float)ignito_UC.circular_Ignito_InnerBorder_Numeric.Value;

            #endregion

            #region Colors

            progressInput.IG_Colors[0] = ignito_UC.circular_Ignito_Color1_Btn.BackColor;
            progressInput.IG_Colors[1] = ignito_UC.circular_Ignito_Color2_Btn.BackColor;
            progressInput.IG_Colors[2] = ignito_UC.circular_Ignito_Color3_Btn.BackColor;
            progressInput.IG_Colors[3] = ignito_UC.circular_Ignito_Color4_Btn.BackColor;
            progressInput.IG_Colors[4] = ignito_UC.circular_Ignito_Color5_Btn.BackColor;
            progressInput.IG_Colors[5] = ignito_UC.circular_Ignito_Color6_Btn.BackColor;
            progressInput.IG_Colors[6] = ignito_UC.circular_Ignito_Color7_Btn.BackColor;
            progressInput.IG_Colors[7] = ignito_UC.circular_Ignito_Color8_Btn.BackColor;
            progressInput.IG_Colors[8] = ignito_UC.circular_Ignito_Color9_Btn.BackColor;
            progressInput.IG_Colors[9] = ignito_UC.circular_Ignito_Color10_Btn.BackColor;
            progressInput.IG_Colors[10] = ignito_UC.circular_Ignito_Color11_Btn.BackColor;
            progressInput.IG_Colors[11] = ignito_UC.circular_Ignito_Color12_Btn.BackColor;



            #endregion

            #region Gradient Colors

            progressInput.IG_GradientColors[0] = ignito_UC.circular_Ignito_GradientColor1_Btn.BackColor;
            progressInput.IG_GradientColors[1] = ignito_UC.circular_Ignito_GradientColor2_Btn.BackColor;
            progressInput.IG_GradientColors[2] = ignito_UC.circular_Ignito_GradientColor3_Btn.BackColor;
            progressInput.IG_GradientColors[3] = ignito_UC.circular_Ignito_GradientColor4_Btn.BackColor;
            
            #endregion

            #region Bool

            if (ignito_UC.circular_Ignito_EnableHatch_Yes_RadioBtn.Checked == true)
            {
                progressInput.IG_EnableHatch = true;

            }
            else
            {
                progressInput.IG_EnableHatch = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_Ignito_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (ignito_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    ignito_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    ignito_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                ignito_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (ignito_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    ignito_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    ignito_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                ignito_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
