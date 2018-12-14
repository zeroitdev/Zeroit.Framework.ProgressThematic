// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Gorgeous.cs" company="Zeroit Dev Technologies">
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

        private void Set_Gorgeous_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            gorgeous_UC.Preview_Btn.Click += Preview_Gorgeous_Click;

            #endregion

            #region Enum

            #region Add Rotating Angle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(ZeroitThematicProgress.Gorgeous_rotatingAngle)))
            {
                gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.Items.Count; i++)
            {
                if (progressInput.RotatingAngle ==
                    (ZeroitThematicProgress.Gorgeous_rotatingAngle)Enum.Parse(typeof
                            (ZeroitThematicProgress.Gorgeous_rotatingAngle),
                        gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.Items[i].ToString()))
                {
                    gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.SelectedIndex = i;

                    gorgeous_UC.ZeroitThematicProgress1.RotatingAngle =
                        (ZeroitThematicProgress.Gorgeous_rotatingAngle)Enum.Parse(typeof
                                (ZeroitThematicProgress.Gorgeous_rotatingAngle),
                            gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Rotating Angle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string rotatingAngle in Enum.GetNames(typeof(ZeroitThematicProgress.Gorgeous_drawMode)))
            {
                gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.Items.Add(rotatingAngle);

            }

            for (int i = 0; i < gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.GorgeousDrawMode ==
                    (ZeroitThematicProgress.Gorgeous_drawMode)Enum.Parse(typeof
                            (ZeroitThematicProgress.Gorgeous_drawMode),
                        gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.Items[i].ToString()))
                {
                    gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.SelectedIndex = i;

                    gorgeous_UC.ZeroitThematicProgress1.GorgeousDrawMode =
                        (ZeroitThematicProgress.Gorgeous_drawMode)Enum.Parse(typeof
                                (ZeroitThematicProgress.Gorgeous_drawMode),
                            gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion


            #endregion

            #region Values

            gorgeous_UC.circular_Gorgeous_Border_Numeric.Value = progressInput.Border;
            gorgeous_UC.circular_Gorgeous_ShiftInner_Numeric.Value = progressInput.ShiftInner;
            gorgeous_UC.circular_Gorgeous_ShiftInnerCover_Numeric.Value = progressInput.ShiftInnerCover;
            gorgeous_UC.circular_Gorgeous_ShiftOuter_Numeric.Value = progressInput.ShiftOuter;
            gorgeous_UC.circular_Gorgeous_ShiftSmallRect_Numeric.Value = progressInput.ShiftSmallRect;

            gorgeous_UC.ZeroitThematicProgress1.Border = progressInput.Border;
            gorgeous_UC.ZeroitThematicProgress1.ShiftInner = progressInput.ShiftInner;
            gorgeous_UC.ZeroitThematicProgress1.ShiftInnerCover = progressInput.ShiftInnerCover;
            gorgeous_UC.ZeroitThematicProgress1.ShiftOuter = progressInput.ShiftOuter;
            gorgeous_UC.ZeroitThematicProgress1.ShiftSmallRect = progressInput.ShiftSmallRect;


            #endregion

            #region Gradient Colors

            gorgeous_UC.circular_Gorgeous_GradientColor1_Btn.BackColor = progressInput.GradientColor[0];
            gorgeous_UC.circular_Gorgeous_GradientColor2_Btn.BackColor = progressInput.GradientColor[1];

            gorgeous_UC.ZeroitThematicProgress1.GradientColor[0] = progressInput.GradientColor[0];
            gorgeous_UC.ZeroitThematicProgress1.GradientColor[1] = progressInput.GradientColor[1];

            #endregion

            #region Solid Colors

            gorgeous_UC.circular_Gorgeous_Color1_Btn.BackColor = progressInput.SolidColors[0];
            gorgeous_UC.circular_Gorgeous_Color2_Btn.BackColor = progressInput.SolidColors[1];
            gorgeous_UC.circular_Gorgeous_Color3_Btn.BackColor = progressInput.SolidColors[2];
            gorgeous_UC.circular_Gorgeous_Color4_Btn.BackColor = progressInput.SolidColors[3];
            gorgeous_UC.circular_Gorgeous_Color5_Btn.BackColor = progressInput.SolidColors[4];

            gorgeous_UC.ZeroitThematicProgress1.SolidColors[0] = progressInput.SolidColors[0];
            gorgeous_UC.ZeroitThematicProgress1.SolidColors[1] = progressInput.SolidColors[1];
            gorgeous_UC.ZeroitThematicProgress1.SolidColors[2] = progressInput.SolidColors[2];
            gorgeous_UC.ZeroitThematicProgress1.SolidColors[3] = progressInput.SolidColors[3];
            gorgeous_UC.ZeroitThematicProgress1.SolidColors[4] = progressInput.SolidColors[4];

            gorgeous_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = progressInput.ColorHatchBrushgradient1;
            gorgeous_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = progressInput.ColorHatchBrushgradient2;

            #endregion

            #region Bool

            if (progressInput.EnableInnerCover == true)
            {
                gorgeous_UC.circular_Gorgeous_EnableCover_Yes_RadioBtn.Checked = true;

                gorgeous_UC.ZeroitThematicProgress1.EnableInnerCover = true;
            }
            else
            {
                gorgeous_UC.circular_Gorgeous_EnableCover_No_RadioBtn.Checked = true;

                gorgeous_UC.ZeroitThematicProgress1.EnableInnerCover = false;
            }

            #endregion


        }


        private void Set_Gorgeous_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.RotatingAngle =
                (ZeroitThematicProgress.Gorgeous_rotatingAngle)Enum.Parse(typeof
                        (ZeroitThematicProgress.Gorgeous_rotatingAngle),
                    gorgeous_UC.circular_Gorgeous_RotatingAngle_ComboBox.SelectedItem.ToString());

            progressInput.GorgeousDrawMode =
                (ZeroitThematicProgress.Gorgeous_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.Gorgeous_drawMode),
                    gorgeous_UC.circular_Gorgeous_DrawMode_ComboBox.SelectedItem.ToString());


            #endregion

            #region Values

            progressInput.Border = (int)gorgeous_UC.circular_Gorgeous_Border_Numeric.Value;
            progressInput.ShiftInner = (int)gorgeous_UC.circular_Gorgeous_ShiftInner_Numeric.Value;
            progressInput.ShiftInnerCover = (int)gorgeous_UC.circular_Gorgeous_ShiftInnerCover_Numeric.Value;
            progressInput.ShiftOuter = (int)gorgeous_UC.circular_Gorgeous_ShiftOuter_Numeric.Value;
            progressInput.ShiftSmallRect = (int)gorgeous_UC.circular_Gorgeous_ShiftSmallRect_Numeric.Value;

            #endregion

            #region Gradient Colors

            progressInput.GradientColor[0] = gorgeous_UC.circular_Gorgeous_GradientColor1_Btn.BackColor;
            progressInput.GradientColor[1] = gorgeous_UC.circular_Gorgeous_GradientColor2_Btn.BackColor;

            #endregion

            #region Solid Colors

            progressInput.SolidColors[0] = gorgeous_UC.circular_Gorgeous_Color1_Btn.BackColor;
            progressInput.SolidColors[1] = gorgeous_UC.circular_Gorgeous_Color2_Btn.BackColor;
            progressInput.SolidColors[2] = gorgeous_UC.circular_Gorgeous_Color3_Btn.BackColor;
            progressInput.SolidColors[3] = gorgeous_UC.circular_Gorgeous_Color4_Btn.BackColor;
            progressInput.SolidColors[4] = gorgeous_UC.circular_Gorgeous_Color5_Btn.BackColor;
            
            #endregion

            #region Bool

            if (gorgeous_UC.circular_Gorgeous_EnableCover_Yes_RadioBtn.Checked == true)
            {
                progressInput.EnableInnerCover = true;
                
            }
            else
            {
                progressInput.EnableInnerCover = false;
            }

            #endregion


        }


        #region Preview Events

        private void Preview_Gorgeous_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (gorgeous_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    gorgeous_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    gorgeous_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                gorgeous_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (gorgeous_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    gorgeous_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    gorgeous_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                gorgeous_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
