// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBar.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressBar_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressBar_UC.Preview_Btn.Click += Preview_CircularProgressBar_Click;

            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineCap)))
            {
                circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressWidthStartCap == 
                    (LineCap)Enum.Parse(typeof
                    (LineCap),
                    circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.Items[i].ToString()))
                {
                    circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.SelectedIndex = i;

                    circularProgressBar_UC.ZeroitThematicProgress1.ProgressWidthStartCap =
                        (LineCap)Enum.Parse(typeof
                        (LineCap),
                        circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string endCap in Enum.GetNames(typeof(LineCap)))
            {
                circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.Items.Add(endCap);

            }

            for (int i = 0; i < circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressWidthEndCap ==
                    (LineCap)Enum.Parse(typeof
                    (LineCap),
                    circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.Items[i].ToString()))
                {
                    circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.SelectedIndex = i;

                    circularProgressBar_UC.ZeroitThematicProgress1.ProgressWidthEndCap =
                        (LineCap)Enum.Parse(typeof
                        (LineCap),
                        circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Progress Shape Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressShape in Enum.GetNames(typeof(ZeroitThematicProgress._ProgressShape)))
            {
                circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.Items.Add(progressShape);

            }

            for (int i = 0; i < circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressShapeVal ==
                    (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                            (ZeroitThematicProgress._ProgressShape),
                        circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.Items[i].ToString()))
                {
                    circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.SelectedIndex = i;

                    circularProgressBar_UC.ZeroitThematicProgress1.ProgressShapeVal =
                        (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                                (ZeroitThematicProgress._ProgressShape),
                            circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Values

            circularProgressBar_UC.circular_ProgressBar_InnerBorderWidth_Numeric.Value =
                (decimal)progressInput.ProgressInnerBorderWidth;

            circularProgressBar_UC.circular_ProgressBar_ProgressWidth_Numeric.Value =
                (decimal)progressInput.ProgressWidth;

            circularProgressBar_UC.ZeroitThematicProgress1.ProgressInnerBorderWidth =
                progressInput.ProgressInnerBorderWidth;

            circularProgressBar_UC.ZeroitThematicProgress1.ProgressWidth =
                progressInput.ProgressWidth;

            #endregion

            #region Colors

            circularProgressBar_UC.circular_ProgressBar_Color1_Btn.BackColor = progressInput.Color1_Progress;
            circularProgressBar_UC.circular_ProgressBar_Color2_Btn.BackColor = progressInput.Color2_Progress;
            circularProgressBar_UC.circular_ProgressBar_FillEllipse1_Btn.BackColor = progressInput.Color3_FillEllipse;
            circularProgressBar_UC.circular_ProgressBar_FillEllipse2_Btn.BackColor = progressInput.Color4_FillEllipse;
            circularProgressBar_UC.circular_ProgressBar_InnerBorder_Btn.BackColor = progressInput.Color5_ProgressInnerBorder;
            circularProgressBar_UC.circular_ProgressBar_Text_Btn.BackColor = progressInput.Color6_TextColor;

            circularProgressBar_UC.ZeroitThematicProgress1.Color1_Progress = progressInput.Color1_Progress;
            circularProgressBar_UC.ZeroitThematicProgress1.Color2_Progress = progressInput.Color2_Progress;
            circularProgressBar_UC.ZeroitThematicProgress1.Color3_FillEllipse = progressInput.Color3_FillEllipse;
            circularProgressBar_UC.ZeroitThematicProgress1.Color4_FillEllipse = progressInput.Color4_FillEllipse;
            circularProgressBar_UC.ZeroitThematicProgress1.Color5_ProgressInnerBorder = progressInput.Color5_ProgressInnerBorder;
            circularProgressBar_UC.ZeroitThematicProgress1.Color6_TextColor = progressInput.Color6_TextColor;


            #endregion

            #region Bool

            if (progressInput.Percentage_Text)
            {
                circularProgressBar_UC.circular_ProgressBar_Percentage_Yes_RadioBtn.Checked = true;
            }
            else
            {
                circularProgressBar_UC.circular_ProgressBar_Percentage_No_RadioBtn.Checked = true;
            }

            if (progressInput.Transparent)
            {
                circularProgressBar_UC.circular_ProgressBar_Transparent_Yes_RadioBtn.Checked = true;
            }
            else
            {
                circularProgressBar_UC.circular_ProgressBar_Transparent_No_RadioBtn.Checked = true;
            }
            
            #endregion


        }


        private void Set_CircularProgressBar_Retrieved_Values(ProgressInput progressInput)
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

            #region Enums

            progressInput.ProgressWidthStartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circularProgressBar_UC.circular_ProgressBar_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.ProgressWidthEndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circularProgressBar_UC.circular_ProgressBar_EndCap_ComboBox.SelectedItem.ToString());

            progressInput.ProgressShapeVal =
                (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress._ProgressShape),
                    circularProgressBar_UC.circular_ProgressBar_ProgressShape_ComboBox.SelectedItem.ToString());

            #endregion

            #region Values

            progressInput.ProgressInnerBorderWidth =
                (float) circularProgressBar_UC.circular_ProgressBar_InnerBorderWidth_Numeric.Value;

            progressInput.ProgressWidth =
                (double)circularProgressBar_UC.circular_ProgressBar_ProgressWidth_Numeric.Value;

            #endregion

            #region Colors

            progressInput.Color1_Progress = circularProgressBar_UC.circular_ProgressBar_Color1_Btn.BackColor;
            progressInput.Color2_Progress = circularProgressBar_UC.circular_ProgressBar_Color2_Btn.BackColor;
            progressInput.Color3_FillEllipse = circularProgressBar_UC.circular_ProgressBar_FillEllipse1_Btn.BackColor;
            progressInput.Color4_FillEllipse = circularProgressBar_UC.circular_ProgressBar_FillEllipse2_Btn.BackColor;
            progressInput.Color5_ProgressInnerBorder = circularProgressBar_UC.circular_ProgressBar_InnerBorder_Btn.BackColor;
            progressInput.Color6_TextColor = circularProgressBar_UC.circular_ProgressBar_Text_Btn.BackColor;

            #endregion

            #region Bool

            if (circularProgressBar_UC.circular_ProgressBar_Percentage_Yes_RadioBtn.Checked == true)
            {
                progressInput.Percentage_Text = true;
                
            }
            else
            {
                progressInput.Percentage_Text = false;
            }

            if (circularProgressBar_UC.circular_ProgressBar_Transparent_Yes_RadioBtn.Checked == true)
            {
                progressInput.Transparent = true;
                
            }
            else
            {
                progressInput.Transparent = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_CircularProgressBar_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressBar_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressBar_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
