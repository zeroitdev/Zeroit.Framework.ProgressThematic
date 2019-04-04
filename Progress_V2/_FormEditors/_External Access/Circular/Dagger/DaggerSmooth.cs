// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="DaggerSmooth.cs" company="Zeroit Dev Technologies">
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

        private void Set_DaggerSmooth_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            daggerSmooth_UC.Preview_Btn.Click += Preview_DaggerSmooth_Click;

            #endregion
            
            #region Values

            //daggerSmooth_UC.circular_DaggerSmooth_BorderWidth_Numeric.Value = progressInput.DagInnerBorderWidth;
            daggerSmooth_UC.circular_DaggerSmooth_FilledThickness_Numeric.Value = progressInput.DagSmoothFilledThickness;
            daggerSmooth_UC.circular_DaggerSmooth_InnerFilledThickness_Numeric.Value = progressInput.DagSmoothFilledThicknessInner;
            daggerSmooth_UC.circular_DaggerSmooth_UnfilledThickness_Numeric.Value = progressInput.DagSmoothUnfilledThickness;
            daggerSmooth_UC.circular_DaggerSmooth_AnimationSpeed_Numeric.Value = progressInput.DagSmoothAnimSpeed;
            daggerSmooth_UC.circular_DaggerSmooth_InnerTransparency_Numeric.Value = progressInput.DagSmoothFilledColorAlphaInner;
            daggerSmooth_UC.circular_DaggerSmooth_OuterTransparency_Numeric.Value = progressInput.DagSmoothFilledColorAlpha;
            daggerSmooth_UC.circular_DaggerSmooth_EndAngle_Numeric.Value = progressInput.DagSmoothEndAngle;


            //daggerSmooth_UC.ZeroitThematicProgress1.DagInnerBorderWidth = progressInput.DagInnerBorderWidth;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothFilledThickness = progressInput.DagSmoothFilledThickness;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothFilledThicknessInner = progressInput.DagSmoothFilledThicknessInner;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothUnfilledThickness = progressInput.DagSmoothUnfilledThickness;
            daggerSmooth_UC.ZeroitThematicProgress1.DagAnimUpSpeed = progressInput.DagSmoothAnimSpeed;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothFilledColorAlphaInner = progressInput.DagSmoothFilledColorAlphaInner;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothFilledColorAlpha = progressInput.DagSmoothFilledColorAlpha;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothEndAngle = progressInput.DagSmoothEndAngle;

            daggerSmooth_UC.ZeroitThematicProgress1.Value = 30;

            #endregion

            #region Colors

            daggerSmooth_UC.circular_DaggerSmooth_UnfilledColor_Btn.BackColor = progressInput.DagSmoothUnFilledColor;
            daggerSmooth_UC.circular_DaggerSmooth_FilledColor_Btn.BackColor = progressInput.DagSmoothFilledColor;
            daggerSmooth_UC.circular_DaggerSmooth_InnerFilledColor_Btn.BackColor = progressInput.DagSmoothInnerFilledColor;
            
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothUnFilledColor = progressInput.DagSmoothUnFilledColor;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothFilledColor = progressInput.DagSmoothFilledColor;
            daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothInnerFilledColor = progressInput.DagSmoothInnerFilledColor;
            
            #endregion

            #region Bool

            if (progressInput.DagSmoothIsAnimated == true)
            {
                daggerSmooth_UC.circular_DaggerSmooth_Animated_Yes_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothIsAnimated = true;
            }
            else
            {
                daggerSmooth_UC.circular_DaggerSmooth_Animated_No_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothIsAnimated = false;
            }

            if (progressInput.DagSmoothRotate == true)
            {
                daggerSmooth_UC.circular_DaggerSmooth_Rotate_Yes_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothRotate = true;
            }
            else
            {
                daggerSmooth_UC.circular_DaggerSmooth_Rotate_No_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothRotate = false;
            }

            
            if (progressInput.DagSmoothAnimEndAngle == true)
            {
                daggerSmooth_UC.circular_DaggerSmooth_AnimateEndAngle_Yes_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothAnimEndAngle = true;
            }
            else
            {
                daggerSmooth_UC.circular_DaggerSmooth_AnimateEndAngle_No_RadioBtn.Checked = true;

                daggerSmooth_UC.ZeroitThematicProgress1.DagSmoothAnimEndAngle = false;
            }

            #endregion


        }


        private void Set_DaggerSmooth_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.DagSmoothFilledThickness = (int)daggerSmooth_UC.circular_DaggerSmooth_FilledThickness_Numeric.Value;
            progressInput.DagSmoothFilledThicknessInner = (int)daggerSmooth_UC.circular_DaggerSmooth_InnerFilledThickness_Numeric.Value;
            progressInput.DagSmoothUnfilledThickness = (int)daggerSmooth_UC.circular_DaggerSmooth_UnfilledThickness_Numeric.Value;
            progressInput.DagSmoothAnimSpeed = (int)daggerSmooth_UC.circular_DaggerSmooth_AnimationSpeed_Numeric.Value;
            progressInput.DagSmoothFilledColorAlphaInner = (int)daggerSmooth_UC.circular_DaggerSmooth_InnerTransparency_Numeric.Value;
            progressInput.DagSmoothFilledColorAlpha = (int)daggerSmooth_UC.circular_DaggerSmooth_OuterTransparency_Numeric.Value;
            progressInput.DagSmoothEndAngle = (int)daggerSmooth_UC.circular_DaggerSmooth_EndAngle_Numeric.Value;

            #endregion

            #region Colors

            progressInput.DagSmoothUnFilledColor = daggerSmooth_UC.circular_DaggerSmooth_UnfilledColor_Btn.BackColor;
            progressInput.DagSmoothFilledColor = daggerSmooth_UC.circular_DaggerSmooth_FilledColor_Btn.BackColor;
            progressInput.DagSmoothInnerFilledColor = daggerSmooth_UC.circular_DaggerSmooth_InnerFilledColor_Btn.BackColor;
            
            #endregion

            #region Bool

            if (daggerSmooth_UC.circular_DaggerSmooth_Animated_Yes_RadioBtn.Checked == true)
            {
                progressInput.DagSmoothIsAnimated = true;
                
            }
            else
            {
                progressInput.DagSmoothIsAnimated = false;

            }

            if (daggerSmooth_UC.circular_DaggerSmooth_Rotate_Yes_RadioBtn.Checked == true)
            {

                progressInput.DagSmoothRotate = true;
                
            }
            else
            {
                progressInput.DagSmoothRotate = false;
            }


            if (daggerSmooth_UC.circular_DaggerSmooth_AnimateEndAngle_Yes_RadioBtn.Checked == true)
            {
                
                progressInput.DagSmoothAnimEndAngle = true;
            }
            else
            {
                progressInput.DagSmoothAnimEndAngle = false;
            }



            #endregion

        }


        #region Preview Events

        private void Preview_DaggerSmooth_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                daggerSmooth_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                daggerSmooth_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
