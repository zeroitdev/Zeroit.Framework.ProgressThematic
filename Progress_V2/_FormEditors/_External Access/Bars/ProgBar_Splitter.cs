// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Splitter.cs" company="Zeroit Dev Technologies">
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
        
        private void Set_Splitter_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            splitter_UC.Preview_Btn.Click += Preview_Splitter_Btn_Click;

            #endregion

            #region Add BorderStyle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string orientation in Enum.GetNames(typeof(TProgressBarBorderStyle)))
            {
                splitter_UC.bars_Splitter_BorderStyle_ComboBox.Items.Add(orientation);

            }

            for (int i = 0; i < splitter_UC.bars_Splitter_BorderStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.Splitter_BoderStyle ==
                    (TProgressBarBorderStyle)Enum.Parse(typeof
                            (TProgressBarBorderStyle),
                        splitter_UC.bars_Splitter_BorderStyle_ComboBox.Items[i].ToString()))
                {
                    splitter_UC.bars_Splitter_BorderStyle_ComboBox.SelectedIndex = i;

                    splitter_UC.ZeroitThematicProgress1.Splitter_BoderStyle =
                        (TProgressBarBorderStyle)Enum.Parse(typeof
                                (TProgressBarBorderStyle),
                            splitter_UC.bars_Splitter_BorderStyle_ComboBox.SelectedItem.ToString());


                }

            }

            #endregion

            #region Values

            splitter_UC.bars_Splitter_BlockSpace_Numeric.Value = progressInput.Splitter_BlockSpace;
            splitter_UC.bars_Splitter_BlockWidth_Numeric.Value = progressInput.Splitter_BlockWidth;

            splitter_UC.ZeroitThematicProgress1.Splitter_BlockSpace = progressInput.Splitter_BlockSpace;
            splitter_UC.ZeroitThematicProgress1.Splitter_BlockWidth = progressInput.Splitter_BlockWidth;

            #endregion

            #region Color

            splitter_UC.bars_Splitter_FillColor_Btn.BackColor = progressInput.Splitter_FillColor;
            splitter_UC.bars_Splitter_BorderColor_Btn.BackColor = progressInput.Splitter_BorderColor;


            splitter_UC.ZeroitThematicProgress1.Splitter_FillColor = progressInput.Splitter_FillColor;
            splitter_UC.ZeroitThematicProgress1.Splitter_BorderColor = progressInput.Splitter_BorderColor;

            #endregion

            #region Bool

            if (progressInput.Splitter_Percent == true)
            {
                splitter_UC.bars_Splitter_Percent_Yes_RadioBtn.Checked = true;

                splitter_UC.ZeroitThematicProgress1.Splitter_Percent = true;
            }
            else
            {
                splitter_UC.bars_Splitter_Percent_No_RadioBtn.Checked = true;

                splitter_UC.ZeroitThematicProgress1.Splitter_Percent = false;
            }

            if (progressInput.Splitter_MarginOffset == true)
            {
                splitter_UC.bars_Splitter_MarginOffset_Yes_RadioBtn.Checked = true;

                splitter_UC.ZeroitThematicProgress1.Splitter_MarginOffset = true;
            }
            else
            {
                splitter_UC.bars_Splitter_MarginOffset_No_RadioBtn.Checked = true;

                splitter_UC.ZeroitThematicProgress1.Splitter_MarginOffset = false;
            }

            #endregion
        }


        private void Set_Splitter_Retrieved_Values(ProgressInput progressInput)
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

            #region Enums

            progressInput.Splitter_BoderStyle =
                (TProgressBarBorderStyle)Enum.Parse(typeof
                        (TProgressBarBorderStyle),
                    splitter_UC.bars_Splitter_BorderStyle_ComboBox.SelectedItem.ToString());

            #endregion

            #region Values

            progressInput.Splitter_BlockSpace = (int)splitter_UC.bars_Splitter_BlockSpace_Numeric.Value;
            progressInput.Splitter_BlockWidth = (int)splitter_UC.bars_Splitter_BlockWidth_Numeric.Value;

            #endregion

            #region Color

            progressInput.Splitter_FillColor = splitter_UC.bars_Splitter_FillColor_Btn.BackColor;
            progressInput.Splitter_BorderColor = splitter_UC.bars_Splitter_BorderColor_Btn.BackColor;

            
            #endregion

            #region Bool

            if (splitter_UC.bars_Splitter_Percent_Yes_RadioBtn.Checked == true)
            {
                progressInput.Splitter_Percent = true;
                
            }
            else
            {
                progressInput.Splitter_Percent = false;
            }

            if (splitter_UC.bars_Splitter_MarginOffset_Yes_RadioBtn.Checked == true)
            {
                progressInput.Splitter_MarginOffset = true;
                
            }
            else
            {
                progressInput.Splitter_MarginOffset = false;
            }

            #endregion
        }


        #region Preview Events

        private void Preview_Splitter_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (splitter_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    splitter_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    splitter_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                splitter_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (splitter_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    splitter_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    splitter_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                splitter_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
