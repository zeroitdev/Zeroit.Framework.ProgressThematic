// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingArc.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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

        private void Set_RotatingArc_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            rotatingArc_UC.Preview_Btn.Click += Preview_RotatingArc_Click;

            #endregion

            #region Enum

            #region Add Rotating Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(ZeroitThematicProgress.PieArc)))
            {
                rotatingArc_UC.circular_Arc_RotatingType_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < rotatingArc_UC.circular_Arc_RotatingType_ComboBox.Items.Count; i++)
            {
                if (progressInput.RotatingType ==
                    (ZeroitThematicProgress.PieArc)Enum.Parse(typeof
                            (ZeroitThematicProgress.PieArc),
                        rotatingArc_UC.circular_Arc_RotatingType_ComboBox.Items[i].ToString()))
                {
                    rotatingArc_UC.circular_Arc_RotatingType_ComboBox.SelectedIndex = i;

                    rotatingArc_UC.ZeroitThematicProgress1.RotatingType =
                        (ZeroitThematicProgress.PieArc)Enum.Parse(typeof
                                (ZeroitThematicProgress.PieArc),
                            rotatingArc_UC.circular_Arc_RotatingType_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Draw Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string endCap in Enum.GetNames(typeof(ZeroitThematicProgress.RotatingArc_drawMode)))
            {
                rotatingArc_UC.circular_Arc_DrawMode_ComboBox.Items.Add(endCap);

            }

            for (int i = 0; i < rotatingArc_UC.circular_Arc_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.RotatingArc_DrawMode ==
                    (ZeroitThematicProgress.RotatingArc_drawMode)Enum.Parse(typeof
                            (ZeroitThematicProgress.RotatingArc_drawMode),
                        rotatingArc_UC.circular_Arc_DrawMode_ComboBox.Items[i].ToString()))
                {
                    rotatingArc_UC.circular_Arc_DrawMode_ComboBox.SelectedIndex = i;

                    rotatingArc_UC.ZeroitThematicProgress1.RotatingArc_DrawMode =
                        (ZeroitThematicProgress.RotatingArc_drawMode)Enum.Parse(typeof
                                (ZeroitThematicProgress.RotatingArc_drawMode),
                            rotatingArc_UC.circular_Arc_DrawMode_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            // Height Reduction
            rotatingArc_UC.circular_Arc_Circle1HeightRed_Numeric.Value = progressInput.Innercircle1HeightReduction;
            rotatingArc_UC.circular_Arc_Circle2HeightRed_Numeric.Value = progressInput.Innercircle2HeightReduction;
            rotatingArc_UC.circular_Arc_Circle3HeightRed_Numeric.Value = progressInput.Innercircle3HeightReduction;
            rotatingArc_UC.circular_Arc_Circle4HeightRed_Numeric.Value = progressInput.Innercircle4HeightReduction;
            rotatingArc_UC.circular_Arc_Circle5HeightRed_Numeric.Value = progressInput.Innercircle5HeightReduction;
            rotatingArc_UC.circular_Arc_Circle6HeightRed_Numeric.Value = progressInput.Innercircle6HeightReduction;

            // Width Reduction
            rotatingArc_UC.circular_Arc_Circle1WidthRed_Numeric.Value = progressInput.Innercircle1WidthReduction;
            rotatingArc_UC.circular_Arc_Circle2WidthRed_Numeric.Value = progressInput.Innercircle2WidthReduction;
            rotatingArc_UC.circular_Arc_Circle3WidthRed_Numeric.Value = progressInput.Innercircle3WidthReduction;
            rotatingArc_UC.circular_Arc_Circle4WidthRed_Numeric.Value = progressInput.Innercircle4WidthReduction;
            rotatingArc_UC.circular_Arc_Circle5WidthRed_Numeric.Value = progressInput.Innercircle5WidthReduction;
            rotatingArc_UC.circular_Arc_Circle6WidthRed_Numeric.Value = progressInput.Innercircle6WidthReduction;

            //General Values
            rotatingArc_UC.circular_Arc_HeartSpeed_Numeric.Value = progressInput.HeartTimerInterval;
            rotatingArc_UC.circular_Arc_LineSize_Numeric.Value = progressInput.LineSize;
            rotatingArc_UC.circular_Arc_InnerCircleBorder_Numeric.Value = progressInput.InnerCircleBorder;
            rotatingArc_UC.circular_Arc_StartAngle_Numeric.Value = (decimal)progressInput.RotatingArc_StartAngle;
            rotatingArc_UC.circular_Arc_SweepAngle_Numeric.Value = (decimal)progressInput.RotatingArc_SweepAngle;


            // Height Reduction
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle1HeightReduction = progressInput.Innercircle1HeightReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle2HeightReduction = progressInput.Innercircle2HeightReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle3HeightReduction = progressInput.Innercircle3HeightReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle4HeightReduction = progressInput.Innercircle4HeightReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle5HeightReduction = progressInput.Innercircle5HeightReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle6HeightReduction = progressInput.Innercircle6HeightReduction;

            // Width Reduction
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle1WidthReduction = progressInput.Innercircle1WidthReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle2WidthReduction = progressInput.Innercircle2WidthReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle3WidthReduction = progressInput.Innercircle3WidthReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle4WidthReduction = progressInput.Innercircle4WidthReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle5WidthReduction = progressInput.Innercircle5WidthReduction;
            rotatingArc_UC.ZeroitThematicProgress1.Innercircle6WidthReduction = progressInput.Innercircle6WidthReduction;

            //General Values
            rotatingArc_UC.ZeroitThematicProgress1.HeartTimerInterval = progressInput.HeartTimerInterval;
            rotatingArc_UC.ZeroitThematicProgress1.LineSize = progressInput.LineSize;
            rotatingArc_UC.ZeroitThematicProgress1.InnerCircleBorder = progressInput.InnerCircleBorder;
            rotatingArc_UC.ZeroitThematicProgress1.RotatingArc_StartAngle = progressInput.RotatingArc_StartAngle;
            rotatingArc_UC.ZeroitThematicProgress1.RotatingArc_SweepAngle = progressInput.RotatingArc_SweepAngle;


            #endregion

            #region Bool

            // Fill Pie
            if (progressInput.FillPie == true)
            {
                rotatingArc_UC.circular_Arc_FillPie_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.FillPie = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_FillPie_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.FillPie = false;
            }

            // HeartBeat
            if (progressInput.HeartBeat == true)
            {
                rotatingArc_UC.circular_Arc_HeartBeat_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.HeartBeat = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_HeartBeat_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.HeartBeat = false;
            }

            // Rotating Border
            if (progressInput.RotatingBorder == true)
            {
                rotatingArc_UC.circular_Arc_RotatingBorder_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.RotatingBorder = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_RotatingBorder_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.RotatingBorder = false;
            }

            // Show Line
            if (progressInput.ShowLine == true)
            {
                rotatingArc_UC.circular_Arc_ShowLine_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowLine = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowLine_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowLine = false;
            }

            // Show Inner Circle 1
            if (progressInput.ShowInnerCircle1 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle1_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle1 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle1_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle1 = false;
            }

            // Show Inner Circle 2
            if (progressInput.ShowInnerCircle2 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle2_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle2 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle2_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle2 = false;
            }

            // Show Inner Circle 3
            if (progressInput.ShowInnerCircle3 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle3_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle3 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle3_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle3 = false;
            }

            // Show Inner Circle 4
            if (progressInput.ShowInnerCircle4 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle4_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle4 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle4_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle4 = false;
            }

            // Show Inner Circle 5
            if (progressInput.ShowInnerCircle5 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle5_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle5 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle5_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle5 = false;
            }

            // Show Inner Circle 6
            if (progressInput.ShowInnerCircle6 == true)
            {
                rotatingArc_UC.circular_Arc_ShowCircle6_Yes_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle6 = true;
            }
            else
            {
                rotatingArc_UC.circular_Arc_ShowCircle6_No_RadioBtn.Checked = true;

                rotatingArc_UC.ZeroitThematicProgress1.ShowInnerCircle6 = false;
            }

            #endregion

            #region Colors

            rotatingArc_UC.circular_Arc_Circ1Grad1_Btn.BackColor = progressInput.ColorInnerCircle1Grad1;
            rotatingArc_UC.circular_Arc_Circ1Grad2_Btn.BackColor = progressInput.ColorInnerCircle1Grad2;

            rotatingArc_UC.circular_Arc_Circ2Grad1_Btn.BackColor = progressInput.ColorInnerCircle2Grad1;
            rotatingArc_UC.circular_Arc_Circ2Grad2_Btn.BackColor = progressInput.ColorInnerCircle2Grad2;

            rotatingArc_UC.circular_Arc_Circ3Grad1_Btn.BackColor = progressInput.ColorInnerCircle3Grad1;
            rotatingArc_UC.circular_Arc_Circ3Grad2_Btn.BackColor = progressInput.ColorInnerCircle3Grad2;

            rotatingArc_UC.circular_Arc_Circ4Grad1_Btn.BackColor = progressInput.ColorInnerCircle4Grad1;
            rotatingArc_UC.circular_Arc_Circ4Grad2_Btn.BackColor = progressInput.ColorInnerCircle4Grad2;

            rotatingArc_UC.circular_Arc_Circ5Grad1_Btn.BackColor = progressInput.ColorInnerCircle5Grad1;
            rotatingArc_UC.circular_Arc_Circ5Grad2_Btn.BackColor = progressInput.ColorInnerCircle5Grad2;

            rotatingArc_UC.circular_Arc_Circ6Grad1_Btn.BackColor = progressInput.ColorInnerCircle6Grad1;
            rotatingArc_UC.circular_Arc_Circ6Grad2_Btn.BackColor = progressInput.ColorInnerCircle6Grad2;

            rotatingArc_UC.circular_Arc_LineColor1_Btn.BackColor = progressInput.LineColor1;
            rotatingArc_UC.circular_Arc_LineColor2_Btn.BackColor = progressInput.LineColor2;

            rotatingArc_UC.circular_Arc_PieColor1_Btn.BackColor = progressInput.PieColor1;
            rotatingArc_UC.circular_Arc_PieColor2_Btn.BackColor = progressInput.PieColor2;

            rotatingArc_UC.circular_Arc_OuterBorder_Btn.BackColor = progressInput.ColorOuterBorder;
            rotatingArc_UC.circular_Arc_FadeColor_Btn.BackColor = progressInput.CustomFadeColor;




            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle1Grad1 = progressInput.ColorInnerCircle1Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle1Grad2 = progressInput.ColorInnerCircle1Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle2Grad1 = progressInput.ColorInnerCircle2Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle2Grad2 = progressInput.ColorInnerCircle2Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle3Grad1 = progressInput.ColorInnerCircle3Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle3Grad2 = progressInput.ColorInnerCircle3Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle4Grad1 = progressInput.ColorInnerCircle4Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle4Grad2 = progressInput.ColorInnerCircle4Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle5Grad1 = progressInput.ColorInnerCircle5Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle5Grad2 = progressInput.ColorInnerCircle5Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle6Grad1 = progressInput.ColorInnerCircle6Grad1;
            rotatingArc_UC.ZeroitThematicProgress1.ColorInnerCircle6Grad2 = progressInput.ColorInnerCircle6Grad2;

            rotatingArc_UC.ZeroitThematicProgress1.LineColor1 = progressInput.LineColor1;
            rotatingArc_UC.ZeroitThematicProgress1.LineColor2 = progressInput.LineColor2;

            rotatingArc_UC.ZeroitThematicProgress1.PieColor1 = progressInput.PieColor1;
            rotatingArc_UC.ZeroitThematicProgress1.PieColor2 = progressInput.PieColor2;

            rotatingArc_UC.ZeroitThematicProgress1.ColorOuterBorder = progressInput.ColorOuterBorder;
            rotatingArc_UC.ZeroitThematicProgress1.CustomFadeColor = progressInput.CustomFadeColor;


            #endregion


        }

        private void Set_RotatingArc_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.RotatingType =
                (ZeroitThematicProgress.PieArc)Enum.Parse(typeof
                        (ZeroitThematicProgress.PieArc),
                    rotatingArc_UC.circular_Arc_RotatingType_ComboBox.SelectedItem.ToString());

            progressInput.RotatingArc_DrawMode =
                (ZeroitThematicProgress.RotatingArc_drawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.RotatingArc_drawMode),
                    rotatingArc_UC.circular_Arc_DrawMode_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            // Height Reduction
            progressInput.Innercircle1HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle1HeightRed_Numeric.Value;
            progressInput.Innercircle2HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle2HeightRed_Numeric.Value;
            progressInput.Innercircle3HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle3HeightRed_Numeric.Value;
            progressInput.Innercircle4HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle4HeightRed_Numeric.Value;
            progressInput.Innercircle5HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle5HeightRed_Numeric.Value;
            progressInput.Innercircle6HeightReduction = (int)rotatingArc_UC.circular_Arc_Circle6HeightRed_Numeric.Value;

            // Width Reduction
            progressInput.Innercircle1WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle1WidthRed_Numeric.Value;
            progressInput.Innercircle2WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle2WidthRed_Numeric.Value;
            progressInput.Innercircle3WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle3WidthRed_Numeric.Value;
            progressInput.Innercircle4WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle4WidthRed_Numeric.Value;
            progressInput.Innercircle5WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle5WidthRed_Numeric.Value;
            progressInput.Innercircle6WidthReduction = (int)rotatingArc_UC.circular_Arc_Circle6WidthRed_Numeric.Value;

            //General Values
            progressInput.HeartTimerInterval = (int)rotatingArc_UC.circular_Arc_HeartSpeed_Numeric.Value;
            progressInput.LineSize = (int)rotatingArc_UC.circular_Arc_LineSize_Numeric.Value;
            progressInput.InnerCircleBorder = (int)rotatingArc_UC.circular_Arc_InnerCircleBorder_Numeric.Value;
            progressInput.RotatingArc_StartAngle = (float)rotatingArc_UC.circular_Arc_StartAngle_Numeric.Value;
            progressInput.RotatingArc_SweepAngle = (float)rotatingArc_UC.circular_Arc_SweepAngle_Numeric.Value;

            #endregion

            #region Bool

            // Fill Pie
            if (rotatingArc_UC.circular_Arc_FillPie_Yes_RadioBtn.Checked == true)
            {
                progressInput.FillPie = true;
            }

            else
            {
                progressInput.FillPie = false;
            }

            // HeartBeat
            if (rotatingArc_UC.circular_Arc_HeartBeat_Yes_RadioBtn.Checked == true)
            {
                progressInput.HeartBeat = true;
                
            }
            else
            {
                progressInput.HeartBeat = false;
            }

            // Rotating Border
            if (rotatingArc_UC.circular_Arc_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.RotatingBorder = true;
                
            }
            else
            {
                progressInput.RotatingBorder = false;
            }

            // Show Line
            if (rotatingArc_UC.circular_Arc_ShowLine_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowLine = true;
                
            }
            else
            {
                progressInput.ShowLine = false;
            }

            // Show Inner Circle 1
            if (rotatingArc_UC.circular_Arc_ShowCircle1_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle1 = true;
                
            }
            else
            {
                progressInput.ShowInnerCircle1 = false;
            }

            // Show Inner Circle 2
            if (rotatingArc_UC.circular_Arc_ShowCircle2_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle2 = true;
                
            }
            else
            {
                progressInput.ShowInnerCircle2 = false;
            }

            // Show Inner Circle 3
            if (rotatingArc_UC.circular_Arc_ShowCircle3_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle3 = true;

            }
            else
            {
                progressInput.ShowInnerCircle3 = false;
            }

            // Show Inner Circle 4
            if (rotatingArc_UC.circular_Arc_ShowCircle4_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle4 = true;
            }
            else
            {
                progressInput.ShowInnerCircle4 = false;
            }

            // Show Inner Circle 5
            if (rotatingArc_UC.circular_Arc_ShowCircle5_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle5 = true;
            }
            else
            {
                progressInput.ShowInnerCircle5 = false;
            }

            // Show Inner Circle 6
            if (rotatingArc_UC.circular_Arc_ShowCircle6_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowInnerCircle6 = true;

            }
            else
            {
                progressInput.ShowInnerCircle6 = false;
            }

            #endregion

            #region Colors

            progressInput.ColorInnerCircle1Grad1 = rotatingArc_UC.circular_Arc_Circ1Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle1Grad2 = rotatingArc_UC.circular_Arc_Circ1Grad2_Btn.BackColor;

            progressInput.ColorInnerCircle2Grad1 = rotatingArc_UC.circular_Arc_Circ2Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle2Grad2 = rotatingArc_UC.circular_Arc_Circ2Grad2_Btn.BackColor;

            progressInput.ColorInnerCircle3Grad1 = rotatingArc_UC.circular_Arc_Circ3Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle3Grad2 = rotatingArc_UC.circular_Arc_Circ3Grad2_Btn.BackColor;

            progressInput.ColorInnerCircle4Grad1 = rotatingArc_UC.circular_Arc_Circ4Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle4Grad2 = rotatingArc_UC.circular_Arc_Circ4Grad2_Btn.BackColor;

            progressInput.ColorInnerCircle5Grad1 = rotatingArc_UC.circular_Arc_Circ5Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle5Grad2 = rotatingArc_UC.circular_Arc_Circ5Grad2_Btn.BackColor;

            progressInput.ColorInnerCircle6Grad1 = rotatingArc_UC.circular_Arc_Circ6Grad1_Btn.BackColor;
            progressInput.ColorInnerCircle6Grad2 = rotatingArc_UC.circular_Arc_Circ6Grad2_Btn.BackColor;

            progressInput.LineColor1 = rotatingArc_UC.circular_Arc_LineColor1_Btn.BackColor;
            progressInput.LineColor2 = rotatingArc_UC.circular_Arc_LineColor2_Btn.BackColor;

            progressInput.PieColor1 = rotatingArc_UC.circular_Arc_PieColor1_Btn.BackColor;
            progressInput.PieColor2 = rotatingArc_UC.circular_Arc_PieColor2_Btn.BackColor;

            progressInput.ColorOuterBorder = rotatingArc_UC.circular_Arc_OuterBorder_Btn.BackColor;
            progressInput.CustomFadeColor = rotatingArc_UC.circular_Arc_FadeColor_Btn.BackColor;


            #endregion

        }


        #region Preview Events

        private void Preview_RotatingArc_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                rotatingArc_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                rotatingArc_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
