// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Perplex.cs" company="Zeroit Dev Technologies">
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

        

        private void Set_Perplex_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            perplex_UC.Preview_Btn.Click += Preview_Perplex_Btn_Click;

            #endregion

            #region Add Mode Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string orientation in Enum.GetNames(typeof(ZeroitThematicProgress.perplex_DrawMode)))
            {
                perplex_UC.bars_Perplex_DrawMode_ComboBox.Items.Add(orientation);

            }

            for (int i = 0; i < perplex_UC.bars_Perplex_DrawMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.Perplex_DrawMode ==
                    (ZeroitThematicProgress.perplex_DrawMode)Enum.Parse(typeof
                    (ZeroitThematicProgress.perplex_DrawMode),
                    perplex_UC.bars_Perplex_DrawMode_ComboBox.Items[i].ToString()))
                {
                    perplex_UC.bars_Perplex_DrawMode_ComboBox.SelectedIndex = i;

                    perplex_UC.ZeroitThematicProgress1.Perplex_DrawMode = 
                        (ZeroitThematicProgress.perplex_DrawMode) Enum.Parse(typeof
                        (ZeroitThematicProgress.perplex_DrawMode),
                        perplex_UC.bars_Perplex_DrawMode_ComboBox.SelectedItem.ToString());

                    
                }
                
            }

            #endregion

            #region Value

            perplex_UC.bars_Perplex_ColorGradientAngle_Numeric.Value = (decimal)progressInput.ColorGradientAngle;

            perplex_UC.ZeroitThematicProgress1.ColorGradientAngle = progressInput.ColorGradientAngle;
            ;
            #endregion

            #region Color - Button

            perplex_UC.bars_Perplex_BorderColor_Btn.BackColor = progressInput.Perplex_BorderColor;
            perplex_UC.bars_Perplex_GradientColor1_Btn.BackColor = progressInput.Perplex_ColorGradient1;
            perplex_UC.bars_Perplex_GradientColor2_Btn.BackColor = progressInput.Perplex_ColorGradient2;
            perplex_UC.bars_Perplex_GradientColor3_Btn.BackColor = progressInput.Perplex_ColorGradient3;
            perplex_UC.bars_Perplex_GradientColor4_Btn.BackColor = progressInput.Perplex_ColorGradient4;

            perplex_UC.ZeroitThematicProgress1.Perplex_BorderColor = progressInput.Perplex_BorderColor;
            perplex_UC.ZeroitThematicProgress1.Perplex_ColorGradient1 = progressInput.Perplex_ColorGradient1;
            perplex_UC.ZeroitThematicProgress1.Perplex_ColorGradient2 = progressInput.Perplex_ColorGradient2;
            perplex_UC.ZeroitThematicProgress1.Perplex_ColorGradient3 = progressInput.Perplex_ColorGradient3;
            perplex_UC.ZeroitThematicProgress1.Perplex_ColorGradient4 = progressInput.Perplex_ColorGradient4;

            perplex_UC.ZeroitThematicProgress1.ColorHatchBrushgradient1 = progressInput.ColorHatchBrushgradient1;
            perplex_UC.ZeroitThematicProgress1.ColorHatchBrushgradient2 = progressInput.ColorHatchBrushgradient2;
            #endregion

            #region Bool

            if (progressInput.Perplex_ShowPercentage == true)
            {
                perplex_UC.bars_Perplex_ShowPercentage_Yes_RadioBtn.Checked = true;

            }
            else
            {
                perplex_UC.bars_Perplex_ShowPercentage_No_RadioBtn.Checked = true;
            }

            #endregion

            perplex_UC.bars_Perplex_DrawMode_ComboBox.SelectedIndexChanged += Bars_Perplex_DrawMode_ComboBox_SelectedIndexChanged;


        }

        private void Bars_Perplex_DrawMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            perplex_UC.ZeroitThematicProgress1.Perplex_DrawMode =
                (ZeroitThematicProgress.perplex_DrawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.perplex_DrawMode),
                    perplex_UC.bars_Perplex_DrawMode_ComboBox.SelectedItem.ToString());

        }

        private void Set_Perplex_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.Perplex_DrawMode =
                (ZeroitThematicProgress.perplex_DrawMode)Enum.Parse(typeof
                        (ZeroitThematicProgress.perplex_DrawMode),
                    perplex_UC.bars_Perplex_DrawMode_ComboBox.SelectedItem.ToString());



            #endregion

            #region Value

            perplex_UC.bars_Perplex_ColorGradientAngle_Numeric.Value = (decimal)progressInput.ColorGradientAngle;

            perplex_UC.ZeroitThematicProgress1.ColorGradientAngle = progressInput.ColorGradientAngle;
            
            #endregion

            #region Color - Button

            progressInput.Perplex_BorderColor = perplex_UC.bars_Perplex_BorderColor_Btn.BackColor;
            progressInput.Perplex_ColorGradient1 = perplex_UC.bars_Perplex_GradientColor1_Btn.BackColor;
            progressInput.Perplex_ColorGradient2 = perplex_UC.bars_Perplex_GradientColor2_Btn.BackColor;
            progressInput.Perplex_ColorGradient3 = perplex_UC.bars_Perplex_GradientColor3_Btn.BackColor;
            progressInput.Perplex_ColorGradient4 = perplex_UC.bars_Perplex_GradientColor4_Btn.BackColor;

            
            #endregion

            #region Bool

            if (perplex_UC.bars_Perplex_ShowPercentage_Yes_RadioBtn.Checked == true)
            {
                progressInput.Perplex_ShowPercentage = true;
                
            }
            else
            {
                progressInput.Perplex_ShowPercentage = true;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_Perplex_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (perplex_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    perplex_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    perplex_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                perplex_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (perplex_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    perplex_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    perplex_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                perplex_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
