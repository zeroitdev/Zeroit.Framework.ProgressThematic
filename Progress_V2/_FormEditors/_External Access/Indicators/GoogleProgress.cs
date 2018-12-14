// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="GoogleProgress.cs" company="Zeroit Dev Technologies">
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

        private void Set_Google_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            googleProgress_UC.Preview_Btn.Click += Preview_Google_Click;

            #endregion

            #region Add Indicator Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(ZeroitThematicProgress.GoogleProgress_INDICATORTYPES)))
            {
                googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.Items.Count; i++)
            {
                if (progressInput.GoogleProgress_IndicatorType == 
                    (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES)Enum.Parse(typeof
                    (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES),
                    googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.Items[i].ToString()))
                {
                    googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.SelectedIndex = i;

                    googleProgress_UC.ZeroitThematicProgress1.GoogleProgress_IndicatorType =
                        (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES),
                        googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion
            
            #region Values

            googleProgress_UC.indicator_GoogleProg_ColorAngle_Numeric.Value =
                (int)progressInput.ColorAngle;

            googleProgress_UC.indicator_GoogleProg_RefreshRate_Numeric.Value =
                (int)progressInput.GoogleProgress_RefreshRate;

            googleProgress_UC.indicator_GoogleProg_IndicatorAngularAdv_Numeric.Value =
                (decimal)progressInput.IndicatorAngularAdvance;

            googleProgress_UC.indicator_GoogleProg_InnerRadius_Numeric.Value =
                (decimal)progressInput.InnerRadius /2;

            googleProgress_UC.indicator_GoogleProg_OuterRadius_Numeric.Value =
                (decimal)progressInput.OuterRadius / 2;

            googleProgress_UC.indicator_GoogleProg_InnerBorder_Numeric.Value =
                (decimal)progressInput.InnerBorder;



            googleProgress_UC.ZeroitThematicProgress1.ColorAngle =
                (int)progressInput.ColorAngle;

            googleProgress_UC.ZeroitThematicProgress1.GoogleProgress_RefreshRate =
                (int)progressInput.GoogleProgress_RefreshRate;

            googleProgress_UC.ZeroitThematicProgress1.IndicatorAngularAdvance =
                progressInput.IndicatorAngularAdvance;

            googleProgress_UC.ZeroitThematicProgress1.InnerRadius =
                progressInput.InnerRadius / 2;

            googleProgress_UC.ZeroitThematicProgress1.OuterRadius =
                progressInput.OuterRadius / 2;

            googleProgress_UC.ZeroitThematicProgress1.InnerBorder =
                progressInput.InnerBorder;
            #endregion

            #region Colors

            googleProgress_UC.indicator_GoogleProg_AnnulusColor_Btn.BackColor = progressInput.AnnulusColor;
            googleProgress_UC.indicator_GoogleProg_BicCirc1_Btn.BackColor = progressInput.Color1Bigcircle;
            googleProgress_UC.indicator_GoogleProg_BicCirc2_Btn.BackColor = progressInput.Color2Bigcircle;
            googleProgress_UC.indicator_GoogleProg_IndicatorCol1_Btn.BackColor = progressInput.Color1Indicator;
            googleProgress_UC.indicator_GoogleProg_IndicatorCol2_Btn.BackColor = progressInput.Color2Indicator;
            googleProgress_UC.indicator_GoogleProg_TransitionColor_Btn.BackColor = progressInput.TransitionColor;
            googleProgress_UC.indicator_GoogleProg_IndicatorColor_Btn.BackColor = progressInput.GoogleProgress_IndicatorColor;
            googleProgress_UC.indicator_GoogleProg_InnerBorder_Btn.BackColor = progressInput.ColorInnerBorder;
            googleProgress_UC.indicator_GoogleProg_Background_Btn.BackColor = progressInput.GoogleProgress_BackgroundColor;


            googleProgress_UC.ZeroitThematicProgress1.AnnulusColor = progressInput.AnnulusColor;
            googleProgress_UC.ZeroitThematicProgress1.Color1Bigcircle = progressInput.Color1Bigcircle;
            googleProgress_UC.ZeroitThematicProgress1.Color2Bigcircle = progressInput.Color2Bigcircle;
            googleProgress_UC.ZeroitThematicProgress1.Color1Indicator = progressInput.Color1Indicator;
            googleProgress_UC.ZeroitThematicProgress1.Color2Indicator = progressInput.Color2Indicator;
            googleProgress_UC.ZeroitThematicProgress1.TransitionColor = progressInput.TransitionColor;
            googleProgress_UC.ZeroitThematicProgress1.GoogleProgress_IndicatorColor = progressInput.GoogleProgress_IndicatorColor;
            googleProgress_UC.ZeroitThematicProgress1.ColorInnerBorder = progressInput.ColorInnerBorder;
            googleProgress_UC.ZeroitThematicProgress1.GoogleProgress_BackgroundColor = progressInput.GoogleProgress_BackgroundColor;


            #endregion


        }


        private void Set_Google_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.GoogleProgress_IndicatorType =
                (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.GoogleProgress_INDICATORTYPES),
                    googleProgress_UC.indicator_GoogleProg_IndicatorType_ComboBox.SelectedItem.ToString());

            #endregion
            
            #region Values

            progressInput.ColorAngle =
                (float)googleProgress_UC.indicator_GoogleProg_ColorAngle_Numeric.Value;

            progressInput.GoogleProgress_RefreshRate =
                (int)googleProgress_UC.indicator_GoogleProg_RefreshRate_Numeric.Value;

            progressInput.IndicatorAngularAdvance =
                (int)googleProgress_UC.indicator_GoogleProg_IndicatorAngularAdv_Numeric.Value;

            progressInput.InnerRadius =
                (int)googleProgress_UC.indicator_GoogleProg_InnerRadius_Numeric.Value * 2;

            progressInput.OuterRadius =
                (int)googleProgress_UC.indicator_GoogleProg_OuterRadius_Numeric.Value * 2;

            progressInput.InnerBorder =
                (int)googleProgress_UC.indicator_GoogleProg_InnerBorder_Numeric.Value;

            
            #endregion

            #region Colors

            progressInput.AnnulusColor = googleProgress_UC.indicator_GoogleProg_AnnulusColor_Btn.BackColor;
            progressInput.Color1Bigcircle = googleProgress_UC.indicator_GoogleProg_BicCirc1_Btn.BackColor;
            progressInput.Color2Bigcircle = googleProgress_UC.indicator_GoogleProg_BicCirc2_Btn.BackColor;
            progressInput.Color1Indicator = googleProgress_UC.indicator_GoogleProg_IndicatorCol1_Btn.BackColor;
            progressInput.Color2Indicator = googleProgress_UC.indicator_GoogleProg_IndicatorCol2_Btn.BackColor;
            progressInput.TransitionColor = googleProgress_UC.indicator_GoogleProg_TransitionColor_Btn.BackColor;
            progressInput.GoogleProgress_IndicatorColor = googleProgress_UC.indicator_GoogleProg_IndicatorColor_Btn.BackColor;
            progressInput.ColorInnerBorder = googleProgress_UC.indicator_GoogleProg_InnerBorder_Btn.BackColor;
            progressInput.GoogleProgress_BackgroundColor = googleProgress_UC.indicator_GoogleProg_Background_Btn.BackColor;
            
            #endregion


        }


        #region Preview Events

        private void Preview_Google_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (googleProgress_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    googleProgress_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    googleProgress_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                googleProgress_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (googleProgress_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    googleProgress_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    googleProgress_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                googleProgress_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
