// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Indicator.cs" company="Zeroit Dev Technologies">
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

        private void Set_Indicator_Initial_Values(ProgressInput progressInput)
        {
            //For main controls
            indicator_UC.bars_Indicator_GraphWidth_Numeric.Value = (decimal)progressInput.GraphWidth;

            indicator_UC.bars_Indicator_Color_Btn.BackColor = progressInput.Color;

            indicator_UC.bars_Indicator_BorderColor_Btn.BackColor = progressInput.BorderColor;

            //For previewer
            indicator_UC.ZeroitThematicProgress1.GraphWidth = progressInput.GraphWidth;

            indicator_UC.ZeroitThematicProgress1.Color = progressInput.Color;

            indicator_UC.ZeroitThematicProgress1.BorderColor = progressInput.BorderColor;

            #region Events

            indicator_UC.bars_Indicator_GraphWidth_Numeric.ValueChanged += Bars_Indicator_GraphWidth_Numeric_ValueChanged;
            indicator_UC.bars_Indicator_Color_Btn.Click += Bars_Indicator_Color_Btn_Click;
            indicator_UC.bars_Indicator_BorderColor_Btn.Click += Bars_Indicator_BorderColor_Btn_Click;
            #endregion

            #region Preview Button

            indicator_UC.Preview_Btn.Click += Preview_Indicator_Btn_Click;

            #endregion
        }

        private void Set_Indicator_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.GraphWidth = (float)indicator_UC.bars_Indicator_GraphWidth_Numeric.Value;

            progressInput.Color = indicator_UC.bars_Indicator_Color_Btn.BackColor;

            progressInput.BorderColor = indicator_UC.bars_Indicator_BorderColor_Btn.BackColor;
            
        }

        private void Bars_Indicator_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (indicator_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                indicator_UC.ZeroitThematicProgress1.BorderColor = indicator_UC.colorSelector.Color;

                indicator_UC.bars_Indicator_BorderColor_Btn.BackColor = indicator_UC.colorSelector.Color;
            }
        }

        private void Bars_Indicator_Color_Btn_Click(object sender, EventArgs e)
        {
            if (indicator_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                indicator_UC.ZeroitThematicProgress1.Color = indicator_UC.colorSelector.Color;

                indicator_UC.bars_Indicator_Color_Btn.BackColor = indicator_UC.colorSelector.Color;
            }
        }

        private void Bars_Indicator_GraphWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            indicator_UC.ZeroitThematicProgress1.GraphWidth = (float)indicator_UC.bars_Indicator_GraphWidth_Numeric.Value;
        }
        
        #region Preview Events

        private void Preview_Indicator_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (indicator_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    indicator_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    indicator_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                indicator_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (indicator_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    indicator_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    indicator_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                indicator_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion
    }
}
