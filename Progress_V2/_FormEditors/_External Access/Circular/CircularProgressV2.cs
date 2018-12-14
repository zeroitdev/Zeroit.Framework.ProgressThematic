// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV2.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressV2_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressV2_UC.Preview_Btn.Click += Preview_CircularProgressV2_Click;

            #endregion
            
            #region Colors

            circularProgressV2_UC.circular_V2_EmptyColor_Btn.BackColor =
                progressInput.CPv2_ColorEmpty;

            circularProgressV2_UC.circular_V2_Color_Btn.BackColor =
                progressInput.CPv2_Color;

            

            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_ColorEmpty =
                progressInput.CPv2_ColorEmpty;

            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_Color =
                progressInput.CPv2_Color;


            #endregion

            #region Values

            circularProgressV2_UC.circular_V2_ProgressWidth_Numeric.Value = progressInput.CPv2_ProgressWidth;
            circularProgressV2_UC.circular_V2_Shift_Numeric.Value = progressInput.CPv2_Shift;
            circularProgressV2_UC.circular_V2_StartAngle_Numeric.Value = progressInput.CPv2_StartAngle;
            circularProgressV2_UC.circular_V2_AngleReduced_Numeric.Value = progressInput.CPv2_AngleReduced;



            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_ProgressWidth = progressInput.CPv2_ProgressWidth;
            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_Shift = progressInput.CPv2_Shift;
            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_StartAngle = progressInput.CPv2_StartAngle;
            circularProgressV2_UC.ZeroitThematicProgress1.CPv2_AngleReduced = progressInput.CPv2_AngleReduced;

            #endregion

            #region Bool

            if (progressInput.CPv2_ShowText == true)
            {
                circularProgressV2_UC.circular_V2_ShowText_Yes_RadioBtn.Checked = true;

                circularProgressV2_UC.ZeroitThematicProgress1.CPv2_ShowText = true;
            }
            else
            {
                circularProgressV2_UC.circular_V2_ShowText_No_RadioBtn.Checked = true;

                circularProgressV2_UC.ZeroitThematicProgress1.CPv2_ShowText = false;
            }

            #endregion

        }


        private void Set_CircularProgressV2_Retrieved_Values(ProgressInput progressInput)
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
            
            #region Colors

            progressInput.CPv2_ColorEmpty =
                circularProgressV2_UC.circular_V2_EmptyColor_Btn.BackColor;

            progressInput.CPv2_Color =
                circularProgressV2_UC.circular_V2_Color_Btn.BackColor;
            

            #endregion

            #region Values

            progressInput.CPv2_ProgressWidth = (int)circularProgressV2_UC.circular_V2_ProgressWidth_Numeric.Value;
            progressInput.CPv2_Shift = (int)circularProgressV2_UC.circular_V2_Shift_Numeric.Value;
            progressInput.CPv2_StartAngle = (int)circularProgressV2_UC.circular_V2_StartAngle_Numeric.Value;
            progressInput.CPv2_AngleReduced = (int)circularProgressV2_UC.circular_V2_AngleReduced_Numeric.Value;
            #endregion

            #region Bool

            if (circularProgressV2_UC.circular_V2_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressInput.CPv2_ShowText = true;
                
            }
            else
            {
                progressInput.CPv2_ShowText = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_CircularProgressV2_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressV2_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressV2_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
