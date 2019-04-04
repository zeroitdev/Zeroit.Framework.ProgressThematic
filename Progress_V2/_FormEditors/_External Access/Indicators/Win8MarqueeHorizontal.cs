// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8MarqueeHorizontal.cs" company="Zeroit Dev Technologies">
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

        private void Set_Win8Horizontal_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            winHorizontal_UC.Preview_Btn.Click += Preview_Win8Horizontal_Click;

            #endregion
            
            #region Values

            winHorizontal_UC.indicator_Win8Horiz_ControlWidth_Numeric.Value =
                (int)progressInput.Control_Width;

            winHorizontal_UC.indicator_Win8Horiz_RefreshRate_Numeric.Value =
                (int)progressInput.Refresh_Rate;


            winHorizontal_UC.ZeroitThematicProgress1.Control_Width =
                (int)progressInput.Control_Width;

            winHorizontal_UC.ZeroitThematicProgress1.Refresh_Rate =
                (int)progressInput.Refresh_Rate;

            #endregion

            #region Colors

            winHorizontal_UC.indicator_Win8Horiz_IndicatorColor_Btn.BackColor = progressInput.Indicator_Color;

            winHorizontal_UC.ZeroitThematicProgress1.Indicator_Color = progressInput.Indicator_Color;

            #endregion

            #region Bool

            if (progressInput.WinHR_Animate == true)
            {
                winHorizontal_UC.indicator_Win8Horiz_Animate_Yes_RadioBtn.Checked = true;

                winHorizontal_UC.ZeroitThematicProgress1.WinHR_Animate = true;
            }
            else
            {
                winHorizontal_UC.indicator_Win8Horiz_Animate_No_RadioBtn.Checked = true;

                winHorizontal_UC.ZeroitThematicProgress1.WinHR_Animate = false;
            }
            
            #endregion


        }

        private void Set_Win8Horizontal_Retrieved_Values(ProgressInput progressInput)
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
            
            #region Values

            progressInput.Control_Width =
                (int)winHorizontal_UC.indicator_Win8Horiz_ControlWidth_Numeric.Value;

            progressInput.Refresh_Rate =
                (int)winHorizontal_UC.indicator_Win8Horiz_RefreshRate_Numeric.Value;

            #endregion

            #region Colors

            progressInput.Indicator_Color = winHorizontal_UC.indicator_Win8Horiz_IndicatorColor_Btn.BackColor;


            #endregion

            #region Bool

            if (winHorizontal_UC.indicator_Win8Horiz_Animate_Yes_RadioBtn.Checked == true)
            {

                progressInput.WinHR_Animate = true;
                
            }
            else
            {
                progressInput.WinHR_Animate = false;
            }

            #endregion


        }


        #region Preview Events

        private void Preview_Win8Horizontal_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                winHorizontal_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                winHorizontal_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion


    }
}
