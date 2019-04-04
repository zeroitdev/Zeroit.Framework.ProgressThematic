// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="RotatingCompass.cs" company="Zeroit Dev Technologies">
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

        private void Set_RotatingCompass_Initial_Values(ProgressInput progressInput)
        {
            
            #region Preview Button

            rotatingCompass_UC.Preview_Btn.Click += Preview_RotatingCompass_Click;

            #endregion

            #region Value

            rotatingCompass_UC.circular_Compass_LineSize_Numeric.Value = progressInput.RotatingCompass_LineSize;

            rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_LineSize = progressInput.RotatingCompass_LineSize;

            #endregion

            #region Colors

            rotatingCompass_UC.circular_Compass_PieColor1_Btn.BackColor = progressInput.RotatingCompass_PieColor1;
            rotatingCompass_UC.circular_Compass_PieColor2_Btn.BackColor = progressInput.RotatingCompass_PieColor2;
            rotatingCompass_UC.circular_Compass_LineColor1_Btn.BackColor = progressInput.RotatingCompass_LineColor1;
            rotatingCompass_UC.circular_Compass_LineColor2_Btn.BackColor = progressInput.RotatingCompass_LineColor2;

            rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_PieColor1 = progressInput.RotatingCompass_PieColor1;
            rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_PieColor2 = progressInput.RotatingCompass_PieColor2;
            rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_LineColor1 = progressInput.RotatingCompass_LineColor1;
            rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_LineColor2 = progressInput.RotatingCompass_LineColor2;


            #endregion

            #region Bool

            if (progressInput.RotatingCompass_FillPie)
            {
                rotatingCompass_UC.circular_Compass_FillPie_Yes_RadioBtn.Checked = true;

                rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_FillPie = true;
            }
            else
            {
                rotatingCompass_UC.circular_Compass_FillPie_No_RadioBtn.Checked = true;

                rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_FillPie = false;
            }

            if (progressInput.RotatingCompass_RotatingBorder)
            {
                rotatingCompass_UC.circular_Compass_RotatingBorder_Yes_RadioBtn.Checked = true;

                rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_RotatingBorder = true;
            }
            else
            {
                rotatingCompass_UC.circular_Compass_RotatingBorder_No_RadioBtn.Checked = true;

                rotatingCompass_UC.ZeroitThematicProgress1.RotatingCompass_RotatingBorder = false;
            }

            #endregion

        }

        private void Set_RotatingCompass_Retrieved_Values(ProgressInput progressInput)
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
            
            #region Value

            progressInput.RotatingCompass_LineSize = (int)rotatingCompass_UC.circular_Compass_LineSize_Numeric.Value;


            #endregion

            #region Colors

            progressInput.RotatingCompass_PieColor1 = rotatingCompass_UC.circular_Compass_PieColor1_Btn.BackColor;
            progressInput.RotatingCompass_PieColor2 = rotatingCompass_UC.circular_Compass_PieColor2_Btn.BackColor;
            progressInput.RotatingCompass_LineColor1 = rotatingCompass_UC.circular_Compass_LineColor1_Btn.BackColor;
            progressInput.RotatingCompass_LineColor2 = rotatingCompass_UC.circular_Compass_LineColor2_Btn.BackColor;

            #endregion

            #region Bool

            if (rotatingCompass_UC.circular_Compass_FillPie_Yes_RadioBtn.Checked == true)
            {
                progressInput.RotatingCompass_FillPie = true;
                
            }
            else
            {
                progressInput.RotatingCompass_FillPie = false;
            }

            if (rotatingCompass_UC.circular_Compass_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.RotatingCompass_RotatingBorder = true;
                
            }
            else
            {
                progressInput.RotatingCompass_RotatingBorder = false;
            }

            #endregion
            
        }


        #region Preview Events

        private void Preview_RotatingCompass_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                rotatingCompass_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                rotatingCompass_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
