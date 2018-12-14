// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Supreme.cs" company="Zeroit Dev Technologies">
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

        private void Set_Supreme_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            supreme_UC.Preview_Btn.Click += Preview_Supreme_Click;

            #endregion

            #region Enum

            #region Add Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string type in Enum.GetNames(typeof(ZeroitThematicProgress.Supreme_type)))
            {
                supreme_UC.circular_Supreme_Type_ComboBox.Items.Add(type);

            }

            for (int i = 0; i < supreme_UC.circular_Supreme_Type_ComboBox.Items.Count; i++)
            {
                if (progressInput.Supreme_Type ==
                    (ZeroitThematicProgress.Supreme_type)Enum.Parse(typeof
                            (ZeroitThematicProgress.Supreme_type),
                        supreme_UC.circular_Supreme_Type_ComboBox.Items[i].ToString()))
                {
                    supreme_UC.circular_Supreme_Type_ComboBox.SelectedIndex = i;

                    supreme_UC.ZeroitThematicProgress1.Supreme_Type =
                        (ZeroitThematicProgress.Supreme_type)Enum.Parse(typeof
                                (ZeroitThematicProgress.Supreme_type),
                            supreme_UC.circular_Supreme_Type_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Draw Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string drawMOde in Enum.GetNames(typeof(ZeroitThematicProgress.Supreme_colorMode)))
            {
                supreme_UC.circular_Supreme_DrawMode_ComboBox.Items.Add(drawMOde);

            }

            for (int i = 0; i < supreme_UC.circular_Supreme_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.SP_DrawMode ==
                    (ZeroitThematicProgress.Supreme_colorMode)Enum.Parse(typeof
                            (ZeroitThematicProgress.Supreme_colorMode),
                        supreme_UC.circular_Supreme_DrawMode_ComboBox.Items[i].ToString()))
                {
                    supreme_UC.circular_Supreme_DrawMode_ComboBox.SelectedIndex = i;

                    supreme_UC.ZeroitThematicProgress1.SP_DrawMode =
                        (ZeroitThematicProgress.Supreme_colorMode)Enum.Parse(typeof
                                (ZeroitThematicProgress.Supreme_colorMode),
                            supreme_UC.circular_Supreme_DrawMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Gradient Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string drawMOde in Enum.GetNames(typeof(LinearGradientMode)))
            {
                supreme_UC.circular_Supreme_GradientMode_ComboBox.Items.Add(drawMOde);

            }

            for (int i = 0; i < supreme_UC.circular_Supreme_GradientMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.SP_GradientMode ==
                    (LinearGradientMode)Enum.Parse(typeof
                            (LinearGradientMode),
                        supreme_UC.circular_Supreme_GradientMode_ComboBox.Items[i].ToString()))
                {
                    supreme_UC.circular_Supreme_GradientMode_ComboBox.SelectedIndex = i;

                    supreme_UC.ZeroitThematicProgress1.SP_GradientMode =
                        (LinearGradientMode)Enum.Parse(typeof
                                (LinearGradientMode),
                            supreme_UC.circular_Supreme_GradientMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string drawMOde in Enum.GetNames(typeof(LineCap)))
            {
                supreme_UC.circular_Supreme_StartCap_ComboBox.Items.Add(drawMOde);

            }

            for (int i = 0; i < supreme_UC.circular_Supreme_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.Supreme_StartCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        supreme_UC.circular_Supreme_StartCap_ComboBox.Items[i].ToString()))
                {
                    supreme_UC.circular_Supreme_StartCap_ComboBox.SelectedIndex = i;

                    supreme_UC.ZeroitThematicProgress1.Supreme_StartCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            supreme_UC.circular_Supreme_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string drawMOde in Enum.GetNames(typeof(LineCap)))
            {
                supreme_UC.circular_Supreme_EndCap_ComboBox.Items.Add(drawMOde);

            }

            for (int i = 0; i < supreme_UC.circular_Supreme_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.Supreme_EndCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        supreme_UC.circular_Supreme_EndCap_ComboBox.Items[i].ToString()))
                {
                    supreme_UC.circular_Supreme_EndCap_ComboBox.SelectedIndex = i;

                    supreme_UC.ZeroitThematicProgress1.Supreme_EndCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            supreme_UC.circular_Supreme_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            supreme_UC.circular_Supreme_OuterBorder_Numeric.Value = progressInput.SP_OuterBorder;
            supreme_UC.circular_Supreme_InnerBorder_Numeric.Value = progressInput.SP_InnerBorder;
            supreme_UC.circular_Supreme_Angle_Numeric.Value = (decimal)progressInput.SP_Angle;
            supreme_UC.circular_Supreme_StartAngle_Numeric.Value = (decimal)progressInput.Supreme_StartAngle;
            supreme_UC.circular_Supreme_SweepAngle_Numeric.Value = (decimal)progressInput.Supreme_SweepAngle;
            supreme_UC.circular_Supreme_HorizontalTweak_Numeric.Value = (decimal)progressInput.SP_Position_Horizontal;
            supreme_UC.circular_Supreme_VerticalTweak_Numeric.Value = (decimal)progressInput.SP_Position_Vertical;
            supreme_UC.circular_Supreme_WidthTweak_Numeric.Value = (decimal)progressInput.SP_Width_Tweak;
            supreme_UC.circular_Supreme_HeightTweak_Numeric.Value = (decimal)progressInput.SP_Height_Tweak;



            supreme_UC.ZeroitThematicProgress1.SP_OuterBorder = progressInput.SP_OuterBorder;
            supreme_UC.ZeroitThematicProgress1.SP_InnerBorder = progressInput.SP_InnerBorder;
            supreme_UC.ZeroitThematicProgress1.SP_Angle = progressInput.SP_Angle;
            supreme_UC.ZeroitThematicProgress1.Supreme_StartAngle = progressInput.Supreme_StartAngle;
            supreme_UC.ZeroitThematicProgress1.Supreme_SweepAngle = progressInput.Supreme_SweepAngle;
            supreme_UC.ZeroitThematicProgress1.SP_Position_Horizontal = progressInput.SP_Position_Horizontal;
            supreme_UC.ZeroitThematicProgress1.SP_Position_Vertical = progressInput.SP_Position_Vertical;
            supreme_UC.ZeroitThematicProgress1.SP_Width_Tweak = progressInput.SP_Width_Tweak;
            supreme_UC.ZeroitThematicProgress1.SP_Height_Tweak = progressInput.SP_Height_Tweak;



            #endregion

            #region Colors

            supreme_UC.circular_Supreme_GradColor1_Btn.BackColor = progressInput.SP_GradientColor[0];
            supreme_UC.circular_Supreme_GradColor2_Btn.BackColor = progressInput.SP_GradientColor[1];
            supreme_UC.circular_Supreme_OuterColor_Btn.BackColor = progressInput.SP_OuterColor;
            supreme_UC.circular_Supreme_ProgressColor_Btn.BackColor = progressInput.SP_ProgressColor;
            supreme_UC.circular_Supreme_SolidColor_Btn.BackColor = progressInput.SP_SolidColor;

            supreme_UC.ZeroitThematicProgress1.SP_GradientColor[0] = progressInput.SP_GradientColor[0];
            supreme_UC.ZeroitThematicProgress1.SP_GradientColor[1] = progressInput.SP_GradientColor[1];
            supreme_UC.ZeroitThematicProgress1.SP_OuterColor = progressInput.SP_OuterColor;
            supreme_UC.ZeroitThematicProgress1.SP_ProgressColor = progressInput.SP_ProgressColor;
            supreme_UC.ZeroitThematicProgress1.SP_SolidColor = progressInput.SP_SolidColor;


            #endregion


        }

        private void Set_Supreme_Retrieved_Values(ProgressInput progressInput)
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

            #region Enums

            progressInput.Supreme_Type =
                (ZeroitThematicProgress.Supreme_type)Enum.Parse(typeof
                        (ZeroitThematicProgress.Supreme_type),
                    supreme_UC.circular_Supreme_Type_ComboBox.SelectedItem.ToString());
            
            progressInput.SP_DrawMode =
                (ZeroitThematicProgress.Supreme_colorMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Supreme_colorMode),
                    supreme_UC.circular_Supreme_DrawMode_ComboBox.SelectedItem.ToString());

            progressInput.SP_GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    supreme_UC.circular_Supreme_GradientMode_ComboBox.SelectedItem.ToString());

            progressInput.Supreme_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    supreme_UC.circular_Supreme_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.Supreme_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    supreme_UC.circular_Supreme_EndCap_ComboBox.SelectedItem.ToString());


            #endregion

            #region Values

            progressInput.SP_OuterBorder = (int)supreme_UC.circular_Supreme_OuterBorder_Numeric.Value;
            progressInput.SP_InnerBorder = (int)supreme_UC.circular_Supreme_InnerBorder_Numeric.Value;
            progressInput.SP_Angle = (float)supreme_UC.circular_Supreme_Angle_Numeric.Value;
            progressInput.Supreme_StartAngle = (float)supreme_UC.circular_Supreme_StartAngle_Numeric.Value;
            progressInput.Supreme_SweepAngle = (float)supreme_UC.circular_Supreme_SweepAngle_Numeric.Value;
            progressInput.SP_Position_Horizontal = (int)supreme_UC.circular_Supreme_HorizontalTweak_Numeric.Value;
            progressInput.SP_Position_Vertical = (int)supreme_UC.circular_Supreme_VerticalTweak_Numeric.Value;
            progressInput.SP_Width_Tweak = (int)supreme_UC.circular_Supreme_WidthTweak_Numeric.Value;
            progressInput.SP_Height_Tweak = (int)supreme_UC.circular_Supreme_HeightTweak_Numeric.Value;

            #endregion

            #region Colors

            progressInput.SP_GradientColor[0] = supreme_UC.circular_Supreme_GradColor1_Btn.BackColor;
            progressInput.SP_GradientColor[1] = supreme_UC.circular_Supreme_GradColor2_Btn.BackColor;
            progressInput.SP_OuterColor = supreme_UC.circular_Supreme_OuterColor_Btn.BackColor;
            progressInput.SP_ProgressColor = supreme_UC.circular_Supreme_ProgressColor_Btn.BackColor;
            progressInput.SP_SolidColor = supreme_UC.circular_Supreme_SolidColor_Btn.BackColor;

            #endregion

        }
        
        #region Preview Events

        private void Preview_Supreme_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (supreme_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    supreme_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    supreme_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                supreme_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (supreme_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    supreme_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    supreme_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                supreme_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
