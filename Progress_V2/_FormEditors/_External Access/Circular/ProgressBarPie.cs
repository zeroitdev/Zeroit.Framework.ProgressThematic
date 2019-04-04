// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressBarPie.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularPie_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            progressBarPie_UC.Preview_Btn.Click += Preview_CircularPie_Click;

            #endregion

            #region Enum

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineCap)))
            {
                progressBarPie_UC.circular_Pie_StartCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < progressBarPie_UC.circular_Pie_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressPie_WidthStartCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        progressBarPie_UC.circular_Pie_StartCap_ComboBox.Items[i].ToString()))
                {
                    progressBarPie_UC.circular_Pie_StartCap_ComboBox.SelectedIndex = i;

                    progressBarPie_UC.ZeroitThematicProgress1.ProgressPie_WidthStartCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            progressBarPie_UC.circular_Pie_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string endCap in Enum.GetNames(typeof(LineCap)))
            {
                progressBarPie_UC.circular_Pie_EndCap_ComboBox.Items.Add(endCap);

            }

            for (int i = 0; i < progressBarPie_UC.circular_Pie_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressPie_WidthEndCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        progressBarPie_UC.circular_Pie_EndCap_ComboBox.Items[i].ToString()))
                {
                    progressBarPie_UC.circular_Pie_EndCap_ComboBox.SelectedIndex = i;

                    progressBarPie_UC.ZeroitThematicProgress1.ProgressPie_WidthEndCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            progressBarPie_UC.circular_Pie_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Progress Shape to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressShape in Enum.GetNames(typeof(ZeroitThematicProgress.ProgressPie_ProgressShape)))
            {
                progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.Items.Add(progressShape);

            }

            for (int i = 0; i < progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressPie__ProgressShape ==
                    (ZeroitThematicProgress.ProgressPie_ProgressShape)Enum.Parse(typeof
                            (ZeroitThematicProgress.ProgressPie_ProgressShape),
                        progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.Items[i].ToString()))
                {
                    progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.SelectedIndex = i;

                    progressBarPie_UC.ZeroitThematicProgress1.ProgressPie__ProgressShape =
                        (ZeroitThematicProgress.ProgressPie_ProgressShape)Enum.Parse(typeof
                                (ZeroitThematicProgress.ProgressPie_ProgressShape),
                            progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion
            
            #region Values

            progressBarPie_UC.circular_Pie_InnerBorderWidth_Numeric.Value = (decimal)progressInput.ProgressPie_InnerBorderWidth;
            progressBarPie_UC.circular_Pie_Position_Numeric.Value = (decimal)progressInput.ProgressPie_Position;
            progressBarPie_UC.circular_Pie_ProgressWidth_Numeric.Value = (decimal)progressInput.ProgressPie_ProgressWidth;
            progressBarPie_UC.circular_Pie_SweepAngle_Numeric.Value = (decimal)progressInput.ProgressPie_SweepAngle;
            

            #endregion

            #region Colors

            progressBarPie_UC.circular_Pie_FillEllipse1_Btn.BackColor = progressInput.ProgressPie_FillEllipse1;
            progressBarPie_UC.circular_Pie_FillEllipse2_Btn.BackColor = progressInput.ProgressPie_FillEllipse2;
            progressBarPie_UC.circular_Pie_InnerBorder_Btn.BackColor = progressInput.ProgressPie_InnerBorderColor;
            progressBarPie_UC.circular_Pie_TextColor_Btn.BackColor = progressInput.ProgressPie_TextColor;
            progressBarPie_UC.circular_Pie_ProgressColor1_Btn.BackColor = progressInput.ProgressPie_ProgressColor1;
            progressBarPie_UC.circular_Pie_ProgressColor2_Btn.BackColor = progressInput.ProgressPie_ProgressColor2;


            #endregion

            #region Bool

            if (progressInput.ProgressPie_ShowText == true)
            {
                progressBarPie_UC.circular_Pie_ShowText_Yes_RadioBtn.Checked = true;
                
            }
            else
            {
                progressBarPie_UC.circular_Pie_ShowText_No_RadioBtn.Checked = true;
                
            }
            
            #endregion

            

        }

        private void Set_CircularPie_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.ProgressPie_WidthStartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    progressBarPie_UC.circular_Pie_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.ProgressPie_WidthEndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    progressBarPie_UC.circular_Pie_EndCap_ComboBox.SelectedItem.ToString());

            progressInput.ProgressPie__ProgressShape =
                (ZeroitThematicProgress.ProgressPie_ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress.ProgressPie_ProgressShape),
                    progressBarPie_UC.circular_Pie_ProgressShape_ComboBox.SelectedItem.ToString());



            #endregion
            
            #region Values

            progressInput.ProgressPie_InnerBorderWidth = (float)progressBarPie_UC.circular_Pie_InnerBorderWidth_Numeric.Value;
            progressInput.ProgressPie_Position = (float)progressBarPie_UC.circular_Pie_Position_Numeric.Value;
            progressInput.ProgressPie_ProgressWidth = (double)progressBarPie_UC.circular_Pie_ProgressWidth_Numeric.Value;
            progressInput.ProgressPie_SweepAngle = (float)progressBarPie_UC.circular_Pie_SweepAngle_Numeric.Value;


            #endregion

            #region Colors

            progressInput.ProgressPie_FillEllipse1 = progressBarPie_UC.circular_Pie_FillEllipse1_Btn.BackColor;
            progressInput.ProgressPie_FillEllipse2 = progressBarPie_UC.circular_Pie_FillEllipse2_Btn.BackColor;
            progressInput.ProgressPie_InnerBorderColor = progressBarPie_UC.circular_Pie_InnerBorder_Btn.BackColor;
            progressInput.ProgressPie_TextColor = progressBarPie_UC.circular_Pie_TextColor_Btn.BackColor;
            progressInput.ProgressPie_ProgressColor1 = progressBarPie_UC.circular_Pie_ProgressColor1_Btn.BackColor;
            progressInput.ProgressPie_ProgressColor2 = progressBarPie_UC.circular_Pie_ProgressColor2_Btn.BackColor;


            #endregion

            #region Bool

            if (progressBarPie_UC.circular_Pie_ShowText_Yes_RadioBtn.Checked == true)
            {

                progressInput.ProgressPie_ShowText = true;
                
            }
            else
            {
                progressInput.ProgressPie_ShowText = false;

            }

            #endregion




        }


        #region Preview Events

        private void Preview_CircularPie_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                progressBarPie_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                progressBarPie_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
