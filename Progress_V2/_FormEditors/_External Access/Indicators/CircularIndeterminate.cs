// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularIndeterminate.cs" company="Zeroit Dev Technologies">
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

        private void Set_Indeterminate_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularIndeterminate_UC.Preview_Btn.Click += Preview_Indeterminate_Click;

            #endregion

            #region Add Indicator Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(ZeroitThematicProgress.INDICATORTYPES)))
            {
                circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.Items.Count; i++)
            {
                if (progressInput.IndicatorType == 
                    (ZeroitThematicProgress.INDICATORTYPES)Enum.Parse(typeof
                    (ZeroitThematicProgress.INDICATORTYPES),
                    circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.Items[i].ToString()))
                {
                    circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.SelectedIndex = i;

                    circularIndeterminate_UC.ZeroitThematicProgress1.IndicatorType =
                        (ZeroitThematicProgress.INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.INDICATORTYPES),
                        circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion
            
            #region Values

            circularIndeterminate_UC.indicator_Indeterminate_CirclesCount_Numeric.Value =
                (int)progressInput.CirclesCount;

            circularIndeterminate_UC.indicator_Indeterminate_IndicatorDiameter_Numeric.Value =
                (int)progressInput.IndicatorDiameter;

            circularIndeterminate_UC.indicator_Indeterminate_ControlSize_Numeric.Value =
                (decimal)progressInput.ControlWidthHeight;

            circularIndeterminate_UC.indicator_Indeterminate_RefreshRate_Numeric.Value =
                (decimal)progressInput.RefreshRate;


            circularIndeterminate_UC.ZeroitThematicProgress1.CirclesCount =
                progressInput.CirclesCount;

            circularIndeterminate_UC.ZeroitThematicProgress1.IndicatorDiameter =
                progressInput.IndicatorDiameter;

            circularIndeterminate_UC.ZeroitThematicProgress1.ControlWidthHeight =
                progressInput.ControlWidthHeight;

            circularIndeterminate_UC.ZeroitThematicProgress1.RefreshRate =
                progressInput.RefreshRate;



            #endregion

            #region Colors

            circularIndeterminate_UC.indicator_Indeterminate_BackgroundColor_Btn.BackColor = progressInput.BackgroundColor;
            circularIndeterminate_UC.indicator_Indeterminate_IndicatorColor_Btn.BackColor = progressInput.IndicatorColor;

            circularIndeterminate_UC.ZeroitThematicProgress1.BackgroundColor = progressInput.BackgroundColor;
            circularIndeterminate_UC.ZeroitThematicProgress1.IndicatorColor = progressInput.IndicatorColor;


            #endregion
            

        }


        private void Set_Indeterminate_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.IndicatorType =
                (ZeroitThematicProgress.INDICATORTYPES)Enum.Parse(typeof
                        (ZeroitThematicProgress.INDICATORTYPES),
                    circularIndeterminate_UC.indicator_Indeterminate_IndicatorType_ComboBox.SelectedItem.ToString());

            #endregion
            
            #region Values

            progressInput.CirclesCount =
                (int)circularIndeterminate_UC.indicator_Indeterminate_CirclesCount_Numeric.Value;

            progressInput.IndicatorDiameter =
                (int)circularIndeterminate_UC.indicator_Indeterminate_IndicatorDiameter_Numeric.Value;

            progressInput.ControlWidthHeight =
                (int)circularIndeterminate_UC.indicator_Indeterminate_ControlSize_Numeric.Value;

            progressInput.RefreshRate =
                (int)circularIndeterminate_UC.indicator_Indeterminate_RefreshRate_Numeric.Value;



            #endregion

            #region Colors

            progressInput.BackgroundColor = circularIndeterminate_UC.indicator_Indeterminate_BackgroundColor_Btn.BackColor;
            progressInput.IndicatorColor = circularIndeterminate_UC.indicator_Indeterminate_IndicatorColor_Btn.BackColor;


            #endregion

        }


        #region Preview Events

        private void Preview_Indeterminate_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularIndeterminate_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularIndeterminate_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
