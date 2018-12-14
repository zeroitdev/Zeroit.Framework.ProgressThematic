// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV5.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressV5_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressV5_UC.Preview_Btn.Click += Preview_CircularProgressV5_Click;

            #endregion
            
            #region Numerics

            circularProgressV5_UC.circular_V5_Width_Numeric.Value = progressInput.BarWidth;
            circularProgressV5_UC.circular_V5_OuterSpeed_Numeric.Value = progressInput.CPv5_OuterSpeed;
            circularProgressV5_UC.circular_V5_MarqueeSpeed_Numeric.Value = progressInput.MarqueeSpeed;
            circularProgressV5_UC.circular_V5_Speed_Numeric.Value = progressInput.CPv5_Interval;
            circularProgressV5_UC.circular_V5_Separation_Numeric.Value = progressInput.Seperation;

            circularProgressV5_UC.ZeroitThematicProgress1.BarWidth = progressInput.BarWidth;
            circularProgressV5_UC.ZeroitThematicProgress1.CPv5_OuterSpeed = progressInput.CPv5_OuterSpeed;
            circularProgressV5_UC.ZeroitThematicProgress1.MarqueeSpeed = progressInput.MarqueeSpeed;
            circularProgressV5_UC.ZeroitThematicProgress1.CPv5_Interval = progressInput.CPv5_Interval;
            circularProgressV5_UC.ZeroitThematicProgress1.Seperation = progressInput.Seperation;



            #endregion

            #region Bool

            //RESET 
            if (progressInput.CPv5_Reset == true)
            {
                circularProgressV5_UC.circular_V5_Reset_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.CPv5_Reset = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Reset_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.CPv5_Reset = false;
            }

            //SHADOW 
            if (progressInput.TextShadow == true)
            {
                circularProgressV5_UC.circular_V5_Shadow_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.TextShadow = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Shadow_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.TextShadow = false;
            }

            //DISPLAY PERCENTAGES
            if (progressInput.DisplayPercentage == true)
            {
                circularProgressV5_UC.circular_V5_DisplayPercentages_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.DisplayPercentage = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_DisplayPercentages_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.DisplayPercentage = false;
            }

            //DISPLAY TOTAL PERCENTAGES
            if (progressInput.DisplayTotalPercentage == true)
            {
                circularProgressV5_UC.circular_V5_DisplayTotalPercentages_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.DisplayTotalPercentage = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_DisplayTotalPercentages_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.DisplayTotalPercentage = false;
            }

            //IMAGE ENABLED
            if (progressInput.ImageEnabled == true)
            {
                circularProgressV5_UC.circular_V5_ImageEnabled_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.ImageEnabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_ImageEnabled_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.ImageEnabled = false;
            }

            //BORDERS ENABLED
            if (progressInput.BorderEnabled == true)
            {
                circularProgressV5_UC.circular_V5_BordersEnabled_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.BorderEnabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_BordersEnabled_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.BorderEnabled = false;
            }

            //MARQUEE
            if (progressInput.Marquee == true)
            {
                circularProgressV5_UC.circular_V5_Marquee_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Marquee = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Marquee_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Marquee = false;
            }

            //SMOOTH BARS
            if (progressInput.SmoothBars == true)
            {
                circularProgressV5_UC.circular_V5_Smooth_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.SmoothBars = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Smooth_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.SmoothBars = false;
            }

            //INACTIVE COLOR
            if (progressInput.InactiveColorEnabled == true)
            {
                circularProgressV5_UC.circular_V5_InactiveColorEnabled_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.InactiveColorEnabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_InactiveColorEnabled_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.InactiveColorEnabled = false;
            }

            #endregion

            #region Bars

            #region General - Bool

            //BAR 1 ENABLED
            if (progressInput.Bar1Enabling == true)
            {
                circularProgressV5_UC.circular_V5_Bar1_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar1.Enabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Bar1_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar1.Enabled = false;
            }

            //BAR 2 ENABLED
            if (progressInput.Bar2Enabling == true)
            {
                circularProgressV5_UC.circular_V5_Bar2_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar2.Enabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Bar2_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar2.Enabled = false;
            }

            //BAR 3 ENABLED
            if (progressInput.Bar3Enabling == true)
            {
                circularProgressV5_UC.circular_V5_Bar3_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar3.Enabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Bar3_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar3.Enabled = false;
            }

            //BAR 4 ENABLED
            if (progressInput.Bar4Enabling == true)
            {
                circularProgressV5_UC.circular_V5_Bar4_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar4.Enabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Bar4_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar4.Enabled = false;
            }

            //BAR 5 ENABLED
            if (progressInput.Bar5Enabling == true)
            {
                circularProgressV5_UC.circular_V5_Bar5_Yes_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar5.Enabled = true;
            }
            else
            {
                circularProgressV5_UC.circular_V5_Bar5_No_RadioBtn.Checked = true;

                circularProgressV5_UC.ZeroitThematicProgress1.Bar5.Enabled = false;
            }

            #endregion

            #region Bar 1
            //--------Colors
            circularProgressV5_UC.circular_V5_Bar1_ActiveColor_Btn.BackColor = progressInput.Bar1ActiveColor;
            circularProgressV5_UC.circular_V5_Bar1_BorderColor_Btn.BackColor = progressInput.Bar1BorderColor;
            circularProgressV5_UC.circular_V5_Bar1_FinishColor_Btn.BackColor = progressInput.Bar1FinishColor;
            circularProgressV5_UC.circular_V5_Bar1_InactiveColor_Btn.BackColor = progressInput.Bar1InactiveColor;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.ActiveColor = progressInput.Bar1ActiveColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.BorderColor = progressInput.Bar1BorderColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.FinishColor = progressInput.Bar1FinishColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.InactiveColor = progressInput.Bar1InactiveColor;

            //--------Values
            circularProgressV5_UC.circular_V5_Bar1_Smooth_Numeric.Value = progressInput.Bar1Smooth;
            circularProgressV5_UC.circular_V5_Bar1_Maximum_Numeric.Value = progressInput.Bar1Maximum;
            circularProgressV5_UC.circular_V5_Bar1_Value_Numeric.Value = progressInput.Bar1Value;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.SmoothAmount = progressInput.Bar1Smooth;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.Maximum = progressInput.Bar1Maximum;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar1.Value = progressInput.Bar1Value;

            #endregion

            #region Bar 2
            //--------Colors
            circularProgressV5_UC.circular_V5_Bar2_ActiveColor_Btn.BackColor = progressInput.Bar2ActiveColor;
            circularProgressV5_UC.circular_V5_Bar2_BorderColor_Btn.BackColor = progressInput.Bar2BorderColor;
            circularProgressV5_UC.circular_V5_Bar2_FinishColor_Btn.BackColor = progressInput.Bar2FinishColor;
            circularProgressV5_UC.circular_V5_Bar2_InactiveColor_Btn.BackColor = progressInput.Bar2InactiveColor;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.ActiveColor = progressInput.Bar2ActiveColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.BorderColor = progressInput.Bar2BorderColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.FinishColor = progressInput.Bar2FinishColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.InactiveColor = progressInput.Bar2InactiveColor;


            //--------Values
            circularProgressV5_UC.circular_V5_Bar2_Smooth_Numeric.Value = progressInput.Bar2Smooth;
            circularProgressV5_UC.circular_V5_Bar2_Maximum_Numeric.Value = progressInput.Bar2Maximum;
            circularProgressV5_UC.circular_V5_Bar2_Value_Numeric.Value = progressInput.Bar2Value;


            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.SmoothAmount = progressInput.Bar2Smooth;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.Maximum = progressInput.Bar2Maximum;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar2.Value = progressInput.Bar2Value;

            #endregion

            #region Bar 3
            //--------Colors
            circularProgressV5_UC.circular_V5_Bar3_ActiveColor_Btn.BackColor = progressInput.Bar3ActiveColor;
            circularProgressV5_UC.circular_V5_Bar3_BorderColor_Btn.BackColor = progressInput.Bar3BorderColor;
            circularProgressV5_UC.circular_V5_Bar3_FinishColor_Btn.BackColor = progressInput.Bar3FinishColor;
            circularProgressV5_UC.circular_V5_Bar3_InactiveColor_Btn.BackColor = progressInput.Bar3InactiveColor;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.ActiveColor = progressInput.Bar3ActiveColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.BorderColor = progressInput.Bar3BorderColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.FinishColor = progressInput.Bar3FinishColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.InactiveColor = progressInput.Bar3InactiveColor;

            //--------Values
            circularProgressV5_UC.circular_V5_Bar3_Smooth_Numeric.Value = progressInput.Bar3Smooth;
            circularProgressV5_UC.circular_V5_Bar3_Maximum_Numeric.Value = progressInput.Bar3Maximum;
            circularProgressV5_UC.circular_V5_Bar3_Value_Numeric.Value = progressInput.Bar3Value;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.SmoothAmount = progressInput.Bar3Smooth;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.Maximum = progressInput.Bar3Maximum;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar3.Value = progressInput.Bar3Value;

            #endregion

            #region Bar 4
            //--------Colors
            circularProgressV5_UC.circular_V5_Bar4_ActiveColor_Btn.BackColor = progressInput.Bar4ActiveColor;
            circularProgressV5_UC.circular_V5_Bar4_BorderColor_Btn.BackColor = progressInput.Bar4BorderColor;
            circularProgressV5_UC.circular_V5_Bar4_FinishColor_Btn.BackColor = progressInput.Bar4FinishColor;
            circularProgressV5_UC.circular_V5_Bar4_InactiveColor_Btn.BackColor = progressInput.Bar4InactiveColor;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.ActiveColor = progressInput.Bar4ActiveColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.BorderColor = progressInput.Bar4BorderColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.FinishColor = progressInput.Bar4FinishColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.InactiveColor = progressInput.Bar4InactiveColor;

            //--------Values
            circularProgressV5_UC.circular_V5_Bar4_Smooth_Numeric.Value = progressInput.Bar4Smooth;
            circularProgressV5_UC.circular_V5_Bar4_Maximum_Numeric.Value = progressInput.Bar4Maximum;
            circularProgressV5_UC.circular_V5_Bar4_Value_Numeric.Value = progressInput.Bar4Value;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.SmoothAmount = progressInput.Bar4Smooth;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.Maximum = progressInput.Bar4Maximum;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar4.Value = progressInput.Bar4Value;

            #endregion

            #region Bar 5
            //--------Colors
            circularProgressV5_UC.circular_V5_Bar5_ActiveColor_Btn.BackColor = progressInput.Bar5ActiveColor;
            circularProgressV5_UC.circular_V5_Bar5_BorderColor_Btn.BackColor = progressInput.Bar5BorderColor;
            circularProgressV5_UC.circular_V5_Bar5_FinishColor_Btn.BackColor = progressInput.Bar5FinishColor;
            circularProgressV5_UC.circular_V5_Bar5_InactiveColor_Btn.BackColor = progressInput.Bar5InactiveColor;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.ActiveColor = progressInput.Bar5ActiveColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.BorderColor = progressInput.Bar5BorderColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.FinishColor = progressInput.Bar5FinishColor;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.InactiveColor = progressInput.Bar5InactiveColor;

            //--------Values
            circularProgressV5_UC.circular_V5_Bar5_Smooth_Numeric.Value = progressInput.Bar5Smooth;
            circularProgressV5_UC.circular_V5_Bar5_Maximum_Numeric.Value = progressInput.Bar5Maximum;
            circularProgressV5_UC.circular_V5_Bar5_Value_Numeric.Value = progressInput.Bar5Value;

            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.SmoothAmount = progressInput.Bar5Smooth;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.Maximum = progressInput.Bar5Maximum;
            circularProgressV5_UC.ZeroitThematicProgress1.Bar5.Value = progressInput.Bar5Value;

            #endregion

            #endregion


        }

        private void Set_CircularProgressV5_Retrieved_Values(ProgressInput progressInput)
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
            
            #region Numerics

            progressInput.BarWidth = (int)circularProgressV5_UC.circular_V5_Width_Numeric.Value;
            progressInput.CPv5_OuterSpeed = (int)circularProgressV5_UC.circular_V5_OuterSpeed_Numeric.Value;
            progressInput.MarqueeSpeed = (int)circularProgressV5_UC.circular_V5_MarqueeSpeed_Numeric.Value;
            progressInput.CPv5_Interval = (int)circularProgressV5_UC.circular_V5_Speed_Numeric.Value;
            progressInput.Seperation = (int)circularProgressV5_UC.circular_V5_Separation_Numeric.Value;

            #endregion

            #region Bool

            //RESET 
            if (circularProgressV5_UC.circular_V5_Reset_Yes_RadioBtn.Checked == true)
            {
                progressInput.CPv5_Reset = true;
                
            }
            else
            {
                progressInput.CPv5_Reset = false;
            }

            //SHADOW 
            if (circularProgressV5_UC.circular_V5_Shadow_Yes_RadioBtn.Checked == true)
            {
                progressInput.TextShadow = true;
                
            }
            else
            {
                progressInput.TextShadow = false;
            }

            //DISPLAY PERCENTAGES
            if (circularProgressV5_UC.circular_V5_DisplayPercentages_Yes_RadioBtn.Checked == true)
            {
                progressInput.DisplayPercentage = true;
                
            }
            else
            {
                progressInput.DisplayPercentage = false;
            }

            //DISPLAY TOTAL PERCENTAGES
            if (circularProgressV5_UC.circular_V5_DisplayTotalPercentages_Yes_RadioBtn.Checked == true)
            {
                progressInput.DisplayTotalPercentage = true;
                
            }
            else
            {
                progressInput.DisplayTotalPercentage = false;
            }

            //IMAGE ENABLED
            if (circularProgressV5_UC.circular_V5_ImageEnabled_Yes_RadioBtn.Checked == true)
            {
                progressInput.ImageEnabled = true;

            }
            else
            {
                progressInput.ImageEnabled = false;
            }

            //BORDERS ENABLED
            if (circularProgressV5_UC.circular_V5_BordersEnabled_Yes_RadioBtn.Checked == true)
            {
                progressInput.BorderEnabled = true;
                
            }
            else
            {
                progressInput.BorderEnabled = false;
            }

            //MARQUEE
            if (circularProgressV5_UC.circular_V5_Marquee_Yes_RadioBtn.Checked == true)
            {
                progressInput.Marquee = true;
                
            }
            else
            {
                progressInput.Marquee = false;
            }

            //SMOOTH BARS
            if (circularProgressV5_UC.circular_V5_Smooth_Yes_RadioBtn.Checked == true)
            {
                progressInput.SmoothBars = true;
                
            }
            else
            {
                progressInput.SmoothBars = false;
            }

            //INACTIVE COLOR
            if (circularProgressV5_UC.circular_V5_InactiveColorEnabled_Yes_RadioBtn.Checked == true)
            {
                progressInput.InactiveColorEnabled = true;
                
            }
            else
            {
                progressInput.InactiveColorEnabled = false;
            }

            #endregion

            #region Bars

            #region General - Bool

            //BAR 1 ENABLED
            if (circularProgressV5_UC.circular_V5_Bar1_Yes_RadioBtn.Checked == true)
            {
                progressInput.Bar1Enabling = true;
                
            }
            else
            {
                progressInput.Bar1Enabling = false;
            }

            //BAR 2 ENABLED
            if (circularProgressV5_UC.circular_V5_Bar2_Yes_RadioBtn.Checked == true)
            {
                progressInput.Bar2Enabling = true;
                
            }
            else
            {
                progressInput.Bar2Enabling = false;
            }

            //BAR 3 ENABLED
            if (circularProgressV5_UC.circular_V5_Bar3_Yes_RadioBtn.Checked == true)
            {
                progressInput.Bar3Enabling = true;
                
            }
            else
            {
                progressInput.Bar3Enabling = false;
            }

            //BAR 4 ENABLED
            if (circularProgressV5_UC.circular_V5_Bar4_Yes_RadioBtn.Checked == true)
            {
                progressInput.Bar4Enabling = true;
                
            }
            else
            {
                progressInput.Bar4Enabling = false;
            }

            //BAR 5 ENABLED
            if (circularProgressV5_UC.circular_V5_Bar5_Yes_RadioBtn.Checked == true)
            {
                progressInput.Bar5Enabling = true;
                
            }
            else
            {
                progressInput.Bar5Enabling = false;
            }

            #endregion

            #region Bar 1
            //--------Colors
            progressInput.Bar1ActiveColor = circularProgressV5_UC.circular_V5_Bar1_ActiveColor_Btn.BackColor;
            progressInput.Bar1BorderColor = circularProgressV5_UC.circular_V5_Bar1_BorderColor_Btn.BackColor;
            progressInput.Bar1FinishColor = circularProgressV5_UC.circular_V5_Bar1_FinishColor_Btn.BackColor;
            progressInput.Bar1InactiveColor = circularProgressV5_UC.circular_V5_Bar1_InactiveColor_Btn.BackColor;

            //--------Values
            progressInput.Bar1Smooth = (int)circularProgressV5_UC.circular_V5_Bar1_Smooth_Numeric.Value;
            progressInput.Bar1Maximum = (int)circularProgressV5_UC.circular_V5_Bar1_Maximum_Numeric.Value;
            progressInput.Bar1Value = (int)circularProgressV5_UC.circular_V5_Bar1_Value_Numeric.Value;

            #endregion

            #region Bar 2
            //--------Colors
            progressInput.Bar2ActiveColor = circularProgressV5_UC.circular_V5_Bar2_ActiveColor_Btn.BackColor;
            progressInput.Bar2BorderColor = circularProgressV5_UC.circular_V5_Bar2_BorderColor_Btn.BackColor;
            progressInput.Bar2FinishColor = circularProgressV5_UC.circular_V5_Bar2_FinishColor_Btn.BackColor;
            progressInput.Bar2InactiveColor = circularProgressV5_UC.circular_V5_Bar2_InactiveColor_Btn.BackColor;

            //--------Values
            progressInput.Bar2Smooth = (int)circularProgressV5_UC.circular_V5_Bar2_Smooth_Numeric.Value;
            progressInput.Bar2Maximum = (int)circularProgressV5_UC.circular_V5_Bar2_Maximum_Numeric.Value;
            progressInput.Bar2Value = (int)circularProgressV5_UC.circular_V5_Bar2_Value_Numeric.Value;

            #endregion

            #region Bar 3
            //--------Colors
            progressInput.Bar3ActiveColor = circularProgressV5_UC.circular_V5_Bar3_ActiveColor_Btn.BackColor;
            progressInput.Bar3BorderColor = circularProgressV5_UC.circular_V5_Bar3_BorderColor_Btn.BackColor;
            progressInput.Bar3FinishColor = circularProgressV5_UC.circular_V5_Bar3_FinishColor_Btn.BackColor;
            progressInput.Bar3InactiveColor = circularProgressV5_UC.circular_V5_Bar3_InactiveColor_Btn.BackColor;

            //--------Values
            progressInput.Bar3Smooth = (int)circularProgressV5_UC.circular_V5_Bar3_Smooth_Numeric.Value;
            progressInput.Bar3Maximum = (int)circularProgressV5_UC.circular_V5_Bar3_Maximum_Numeric.Value;
            progressInput.Bar3Value = (int)circularProgressV5_UC.circular_V5_Bar3_Value_Numeric.Value;

            #endregion

            #region Bar 4
            //--------Colors
            progressInput.Bar4ActiveColor = circularProgressV5_UC.circular_V5_Bar4_ActiveColor_Btn.BackColor;
            progressInput.Bar4BorderColor = circularProgressV5_UC.circular_V5_Bar4_BorderColor_Btn.BackColor;
            progressInput.Bar4FinishColor = circularProgressV5_UC.circular_V5_Bar4_FinishColor_Btn.BackColor;
            progressInput.Bar4InactiveColor = circularProgressV5_UC.circular_V5_Bar4_InactiveColor_Btn.BackColor;

            //--------Values
            progressInput.Bar4Smooth = (int)circularProgressV5_UC.circular_V5_Bar4_Smooth_Numeric.Value;
            progressInput.Bar4Maximum = (int)circularProgressV5_UC.circular_V5_Bar4_Maximum_Numeric.Value;
            progressInput.Bar4Value = (int)circularProgressV5_UC.circular_V5_Bar4_Value_Numeric.Value;

            #endregion

            #region Bar 5

            //--------Colors
            progressInput.Bar5ActiveColor = circularProgressV5_UC.circular_V5_Bar5_ActiveColor_Btn.BackColor;
            progressInput.Bar5BorderColor = circularProgressV5_UC.circular_V5_Bar5_BorderColor_Btn.BackColor;
            progressInput.Bar5FinishColor = circularProgressV5_UC.circular_V5_Bar5_FinishColor_Btn.BackColor;
            progressInput.Bar5InactiveColor = circularProgressV5_UC.circular_V5_Bar5_InactiveColor_Btn.BackColor;

            //--------Values
            progressInput.Bar5Smooth = (int)circularProgressV5_UC.circular_V5_Bar5_Smooth_Numeric.Value;
            progressInput.Bar5Maximum = (int)circularProgressV5_UC.circular_V5_Bar5_Maximum_Numeric.Value;
            progressInput.Bar5Value = (int)circularProgressV5_UC.circular_V5_Bar5_Value_Numeric.Value;

            #endregion

            #endregion

        }


        #region Preview Events

        private void Preview_CircularProgressV5_Click(object sender, EventArgs e)
        {

            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressV5_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {

                if (circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressV5_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
