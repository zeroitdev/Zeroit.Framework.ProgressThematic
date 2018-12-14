// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Win8ProgressRing.cs" company="Zeroit Dev Technologies">
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

        private void Set_Win8Ring_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            winRing_UC.Preview_Btn.Click += Preview_Win8Ring_Click;

            #endregion
            
            #region Values

            winRing_UC.indicator_Win8Ring_ControlWidth_Numeric.Value =
                (int)progressInput.Control_Height;

            winRing_UC.indicator_Win8Ring_RefreshRate_Numeric.Value =
                (int)progressInput.WinRing_Refresh_Rate;



            winRing_UC.ZeroitThematicProgress1.Control_Height =
                (int)progressInput.Control_Height;

            winRing_UC.ZeroitThematicProgress1.WinRing_Refresh_Rate =
                (int)progressInput.WinRing_Refresh_Rate;

            #endregion

            #region Colors

            winRing_UC.indicator_Win8Ring_IndicatorColor_Btn.BackColor = progressInput.WinRing_Indicator_Color;

            winRing_UC.ZeroitThematicProgress1.WinRing_Indicator_Color = progressInput.WinRing_Indicator_Color;

            #endregion

            #region Bool

            if (progressInput.WinRing_Animate == true)
            {
                winRing_UC.indicator_Win8Ring_Animate_Yes_RadioBtn.Checked = true;

                winRing_UC.ZeroitThematicProgress1.WinRing_Animate = true;
            }
            else
            {
                winRing_UC.indicator_Win8Ring_Animate_No_RadioBtn.Checked = true;

                winRing_UC.ZeroitThematicProgress1.WinRing_Animate = false;
            }
            
            #endregion


        }

        private void Set_Win8Ring_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.Control_Height =
                (int)winRing_UC.indicator_Win8Ring_ControlWidth_Numeric.Value;

            progressInput.WinRing_Refresh_Rate =
                (int)winRing_UC.indicator_Win8Ring_RefreshRate_Numeric.Value;

            #endregion

            #region Colors

            progressInput.WinRing_Indicator_Color = winRing_UC.indicator_Win8Ring_IndicatorColor_Btn.BackColor;


            #endregion

            #region Bool

            if (winRing_UC.indicator_Win8Ring_Animate_Yes_RadioBtn.Checked == true)
            {

                progressInput.WinRing_Animate = true;
                
            }
            else
            {
                progressInput.WinRing_Animate = false;
            }

            #endregion


        }


        #region Preview Events

        private void Preview_Win8Ring_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (winRing_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    winRing_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    winRing_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                winRing_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (winRing_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    winRing_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    winRing_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                winRing_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion


    }
}
