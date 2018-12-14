// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="CircularProgressBarDefault.cs" company="Zeroit Dev Technologies">
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

        private void Set_CircularProgressBarDefault_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            circularProgressBarDefault_UC.Preview_Btn.Click += Preview_CircularProgressBarDefault_Click;

            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string shape in Enum.GetNames(typeof(ZeroitThematicProgress._ProgressShape)))
            {
                circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.Items.Add(shape);

            }

            for (int i = 0; i < circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressShape_Default == 
                    (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                    (ZeroitThematicProgress._ProgressShape),
                    circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.Items[i].ToString()))
                {
                    circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.SelectedIndex = i;

                    circularProgressBarDefault_UC.ZeroitThematicProgress1.ProgressShape_Default =
                        (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress._ProgressShape),
                        circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.SelectedItem.ToString());
                    
                }

            }

            #endregion

            #region Colors

            circularProgressBarDefault_UC.circular_ProgressBarDefault_Color1_Btn.BackColor =
                progressInput.ProgressColor1_Default;

            circularProgressBarDefault_UC.circular_ProgressBarDefault_Color2_Btn.BackColor =
                progressInput.ProgressColor2_Default;

            circularProgressBarDefault_UC.circular_ProgressBarDefault_InnerColor1_Btn.BackColor =
                progressInput.ProgressInnerColor1_Default;

            circularProgressBarDefault_UC.circular_ProgressBarDefault_InnerColor2_Btn.BackColor =
                progressInput.ProgressInnerColor2_Default;



            circularProgressBarDefault_UC.ZeroitThematicProgress1.ProgressColor1_Default =
                progressInput.ProgressColor1_Default;

            circularProgressBarDefault_UC.ZeroitThematicProgress1.ProgressColor2_Default =
                progressInput.ProgressColor2_Default;

            circularProgressBarDefault_UC.ZeroitThematicProgress1.ProgressInnerColor1_Default =
                progressInput.ProgressInnerColor1_Default;

            circularProgressBarDefault_UC.ZeroitThematicProgress1.ProgressInnerColor2_Default =
                progressInput.ProgressInnerColor2_Default;

            #endregion

        }


        private void Set_CircularProgressBarDefault_Retrieved_Values(ProgressInput progressInput)
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

            #region Enums

            progressInput.ProgressShape_Default =
                (ZeroitThematicProgress._ProgressShape)Enum.Parse(typeof
                        (ZeroitThematicProgress._ProgressShape),
                    circularProgressBarDefault_UC.circular_ProgressBarDefault_Shape_ComboBox.SelectedItem.ToString());

            #endregion

            #region Colors

            progressInput.ProgressColor1_Default =
                circularProgressBarDefault_UC.circular_ProgressBarDefault_Color1_Btn.BackColor;

            progressInput.ProgressColor2_Default =
                circularProgressBarDefault_UC.circular_ProgressBarDefault_Color2_Btn.BackColor;

            progressInput.ProgressInnerColor1_Default =
                circularProgressBarDefault_UC.circular_ProgressBarDefault_InnerColor1_Btn.BackColor;

            progressInput.ProgressInnerColor2_Default =
                circularProgressBarDefault_UC.circular_ProgressBarDefault_InnerColor2_Btn.BackColor;

            #endregion

        }


        #region Preview Events

        private void Preview_CircularProgressBarDefault_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                circularProgressBarDefault_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
