// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV3.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressV3_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressV3_UC.Preview_Btn.Click += Preview_CircularProgressV3_Click;

            #endregion
            
            #region Colors

            circularProgressV3_UC.circular_V3_EmptyColor_Btn.BackColor =
                progressInput.CPv3_ColorEmpty;

            circularProgressV3_UC.circular_V3_Color_Btn.BackColor =
                progressInput.CPv3_Color;

            

            circularProgressV3_UC.ZeroitThematicProgress1.CPv3_ColorEmpty =
                progressInput.CPv3_ColorEmpty;

            circularProgressV3_UC.ZeroitThematicProgress1.CPv3_Color =
                progressInput.CPv3_Color;


            #endregion

            #region Values

            circularProgressV3_UC.circular_V3_ProgressWidth_Numeric.Value = progressInput.CPv3_ProgressWidth;
            circularProgressV3_UC.circular_V3_Shift_Numeric.Value = progressInput.CPv3_Shift;
            circularProgressV3_UC.circular_V3_StartAngle_Numeric.Value = progressInput.CPv3_StartAngle;
            //circularProgressV3_UC.circular_V3_AngleReduced_Numeric.Value = progressInput.CPv3_AngleReduced;



            circularProgressV3_UC.ZeroitThematicProgress1.CPv3_ProgressWidth = progressInput.CPv3_ProgressWidth;
            circularProgressV3_UC.ZeroitThematicProgress1.CPv3_Shift = progressInput.CPv3_Shift;
            circularProgressV3_UC.ZeroitThematicProgress1.CPv3_StartAngle = progressInput.CPv3_StartAngle;
            //circularProgressV3_UC.ZeroitThematicProgress1.CPv3_AngleReduced = progressInput.CPv3_AngleReduced;

            #endregion

            #region Bool

            if (progressInput.CPv3_ShowText == true)
            {
                circularProgressV3_UC.circular_V3_ShowText_Yes_RadioBtn.Checked = true;

                circularProgressV3_UC.ZeroitThematicProgress1.CPv3_ShowText = true;
            }
            else
            {
                circularProgressV3_UC.circular_V3_ShowText_No_RadioBtn.Checked = true;

                circularProgressV3_UC.ZeroitThematicProgress1.CPv3_ShowText = false;
            }

            #endregion

        }


        private void Set_CircularProgressV3_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.CPv3_ColorEmpty =
                circularProgressV3_UC.circular_V3_EmptyColor_Btn.BackColor;

            progressInput.CPv3_Color =
                circularProgressV3_UC.circular_V3_Color_Btn.BackColor;
            

            #endregion

            #region Values

            progressInput.CPv3_ProgressWidth = (int)circularProgressV3_UC.circular_V3_ProgressWidth_Numeric.Value;
            progressInput.CPv3_Shift = (int)circularProgressV3_UC.circular_V3_Shift_Numeric.Value;
            progressInput.CPv3_StartAngle = (int)circularProgressV3_UC.circular_V3_StartAngle_Numeric.Value;
            //progressInput.CPv3_AngleReduced = (int)circularProgressV3_UC.circular_V3_AngleReduced_Numeric.Value;
            #endregion

            #region Bool

            if (circularProgressV3_UC.circular_V3_ShowText_Yes_RadioBtn.Checked == true)
            {
                progressInput.CPv3_ShowText = true;
                
            }
            else
            {
                progressInput.CPv3_ShowText = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_CircularProgressV3_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressV3_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressV3_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
