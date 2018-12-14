// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressV4.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressV4_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressV4_UC.Preview_Btn.Click += Preview_CircularProgressV4_Click;

            #endregion

            #region Enums

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string startCap in Enum.GetNames(typeof(LineCap)))
            {
                circularProgressV4_UC.circular_V4_StartCap_ComboBox.Items.Add(startCap);

            }

            for (int i = 0; i < circularProgressV4_UC.circular_V4_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.CPv4_StartCap ==
                    (LineCap)Enum.Parse(typeof
                    (LineCap),
                        circularProgressV4_UC.circular_V4_StartCap_ComboBox.Items[i].ToString()))
                {
                    circularProgressV4_UC.circular_V4_StartCap_ComboBox.SelectedIndex = i;

                    circularProgressV4_UC.ZeroitThematicProgress1.CPv4_StartCap =
                        (LineCap)Enum.Parse(typeof
                        (LineCap),
                            circularProgressV4_UC.circular_V4_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string endCap in Enum.GetNames(typeof(LineCap)))
            {
                circularProgressV4_UC.circular_V4_EndCap_ComboBox.Items.Add(endCap);

            }

            for (int i = 0; i < circularProgressV4_UC.circular_V4_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.CPv4_EndCap ==
                    (LineCap)Enum.Parse(typeof
                    (LineCap),
                        circularProgressV4_UC.circular_V4_EndCap_ComboBox.Items[i].ToString()))
                {
                    circularProgressV4_UC.circular_V4_EndCap_ComboBox.SelectedIndex = i;

                    circularProgressV4_UC.ZeroitThematicProgress1.CPv4_EndCap =
                        (LineCap)Enum.Parse(typeof
                        (LineCap),
                            circularProgressV4_UC.circular_V4_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion
            
            #region Values

            circularProgressV4_UC.circular_V4_Thickness_Numeric.Value = progressInput.CPv4_Thickness;
            circularProgressV4_UC.circular_V4_StartAngle_Numeric.Value = progressInput.CPv4_StartAngle;
            circularProgressV4_UC.circular_V4_GradientAngle_Numeric.Value = (decimal)progressInput.CPv4_GradientAngle;
            circularProgressV4_UC.circular_V4_InnerBorderThickness_Numeric.Value = progressInput.CPv4_InnerBorderThickness;
            circularProgressV4_UC.circular_V4_OuterBorderThickness_Numeric.Value = progressInput.CPv4_OuterBorderThickness;

            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_Thickness = progressInput.CPv4_Thickness;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_StartAngle = progressInput.CPv4_StartAngle;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_GradientAngle = progressInput.CPv4_GradientAngle;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_InnerBorderThickness = progressInput.CPv4_InnerBorderThickness;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_OuterBorderThickness = progressInput.CPv4_OuterBorderThickness;


            #endregion

            #region Colors

            circularProgressV4_UC.circular_V4_ProgressColor1_Btn.BackColor = progressInput.CPv4_ProgressGrad1;
            circularProgressV4_UC.circular_V4_ProgressColor2_Btn.BackColor = progressInput.CPv4_ProgressGrad2;
            circularProgressV4_UC.circular_V4_BackColor1_Btn.BackColor = progressInput.CPv4_ProgressBackGrad1;
            circularProgressV4_UC.circular_V4_BackColor2_Btn.BackColor = progressInput.CPv4_ProgressBackGrad2;
            circularProgressV4_UC.circular_V4_InnerBorder_Btn.BackColor = progressInput.CPv4_InnerBorder;
            circularProgressV4_UC.circular_V4_OuterBorder_Btn.BackColor = progressInput.CPv4_OuterBorder;
            circularProgressV4_UC.circular_V4_FillEllipse1_Btn.BackColor = progressInput.CPv4_FillEllipse[0];
            circularProgressV4_UC.circular_V4_FillEllipse2_Btn.BackColor = progressInput.CPv4_FillEllipse[1];

            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_ProgressGrad1 = progressInput.CPv4_ProgressGrad1;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_ProgressGrad2 = progressInput.CPv4_ProgressGrad2;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_ProgressBackGrad1 = progressInput.CPv4_ProgressBackGrad1;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_ProgressBackGrad2 = progressInput.CPv4_ProgressBackGrad2;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_InnerBorder = progressInput.CPv4_InnerBorder;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_OuterBorder = progressInput.CPv4_OuterBorder;
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_FillEllipse[0] = progressInput.CPv4_FillEllipse[0];
            circularProgressV4_UC.ZeroitThematicProgress1.CPv4_FillEllipse[1] = progressInput.CPv4_FillEllipse[1];


            #endregion



        }


        private void Set_CircularProgressV4_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.CPv4_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circularProgressV4_UC.circular_V4_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.CPv4_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    circularProgressV4_UC.circular_V4_EndCap_ComboBox.SelectedItem.ToString());



            #endregion
            
            #region Values

            progressInput.CPv4_Thickness = (int)circularProgressV4_UC.circular_V4_Thickness_Numeric.Value;
            progressInput.CPv4_StartAngle = (int)circularProgressV4_UC.circular_V4_StartAngle_Numeric.Value;
            progressInput.CPv4_GradientAngle = (float)circularProgressV4_UC.circular_V4_GradientAngle_Numeric.Value;
            progressInput.CPv4_InnerBorderThickness = (int)circularProgressV4_UC.circular_V4_InnerBorderThickness_Numeric.Value;
            progressInput.CPv4_OuterBorderThickness = (int)circularProgressV4_UC.circular_V4_OuterBorderThickness_Numeric.Value;


            #endregion

            #region Colors

            progressInput.CPv4_ProgressGrad1 = circularProgressV4_UC.circular_V4_ProgressColor1_Btn.BackColor;
            progressInput.CPv4_ProgressGrad2 = circularProgressV4_UC.circular_V4_ProgressColor2_Btn.BackColor;
            progressInput.CPv4_ProgressBackGrad1 = circularProgressV4_UC.circular_V4_BackColor1_Btn.BackColor;
            progressInput.CPv4_ProgressBackGrad2 = circularProgressV4_UC.circular_V4_BackColor2_Btn.BackColor;
            progressInput.CPv4_InnerBorder = circularProgressV4_UC.circular_V4_InnerBorder_Btn.BackColor;
            progressInput.CPv4_OuterBorder = circularProgressV4_UC.circular_V4_OuterBorder_Btn.BackColor;
            progressInput.CPv4_FillEllipse[0] = circularProgressV4_UC.circular_V4_FillEllipse1_Btn.BackColor;
            progressInput.CPv4_FillEllipse[1] = circularProgressV4_UC.circular_V4_FillEllipse2_Btn.BackColor;

            #endregion
        }


        #region Preview Events

        private void Preview_CircularProgressV4_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressV4_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressV4_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
