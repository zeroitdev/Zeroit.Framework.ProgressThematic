// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Vuvuzela.cs" company="Zeroit Dev Technologies">
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

        private void Set_Vuvuzela_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            vuvuzela_UC.Preview_Btn.Click += Preview_Vuvuzela_Click;

            #endregion

            #region Enum
            
            #region Add Shape to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(ZeroitThematicProgress.Vuvuzela_Shape)))
            {
                vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.Items.Count; i++)
            {
                if (progressInput.Shape ==
                    (ZeroitThematicProgress.Vuvuzela_Shape)Enum.Parse(typeof
                    (ZeroitThematicProgress.Vuvuzela_Shape),
                    vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.Items[i].ToString()))
                {
                    vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.SelectedIndex = i;

                    vuvuzela_UC.ZeroitThematicProgress1.Shape =
                        (ZeroitThematicProgress.Vuvuzela_Shape)Enum.Parse(typeof
                        (ZeroitThematicProgress.Vuvuzela_Shape),
                        vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion
            
            #endregion

            #region Values

            vuvuzela_UC.indicator_Vuvuzela_ControlSize_Numeric.Value =
                (int)progressInput.ControlSize;

            vuvuzela_UC.indicator_Vuvuzela_Angle_Numeric.Value =
                (int)progressInput.Vuvuzela_Angle;

            vuvuzela_UC.indicator_Vuvuzela_CircleSize_Numeric.Value =
                (int)progressInput.Vuvuzela_CircleSize;

            vuvuzela_UC.indicator_Vuvuzela_HorizontalSpacing_Numeric.Value =
                (int)progressInput.Vuvuzela_HorizontalSpacing;

            vuvuzela_UC.indicator_Vuvuzela_VerticalSpacing_Numeric.Value =
                (int)progressInput.Vuvuzela_VerticalSpacing;



            vuvuzela_UC.ZeroitThematicProgress1.ControlSize =
                (int)progressInput.ControlSize;

            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Angle =
                (int)progressInput.Vuvuzela_Angle;

            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_CircleSize =
                (int)progressInput.Vuvuzela_CircleSize;

            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_HorizontalSpacing =
                (int)progressInput.Vuvuzela_HorizontalSpacing;

            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_VerticalSpacing =
                (int)progressInput.Vuvuzela_VerticalSpacing;

            #endregion

            #region Colors

            vuvuzela_UC.indicator_Vuvuzela_Circle1_Btn.BackColor = progressInput.Vuvuzela_Circle1;
            vuvuzela_UC.indicator_Vuvuzela_Circle2_Btn.BackColor = progressInput.Vuvuzela_Circle2;
            vuvuzela_UC.indicator_Vuvuzela_Circle3_Btn.BackColor = progressInput.Vuvuzela_Circle3;
            vuvuzela_UC.indicator_Vuvuzela_Circle4_Btn.BackColor = progressInput.Vuvuzela_Circle4;
            vuvuzela_UC.indicator_Vuvuzela_Circle5_Btn.BackColor = progressInput.Vuvuzela_Circle5;



            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Circle1 = progressInput.Vuvuzela_Circle1;
            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Circle2 = progressInput.Vuvuzela_Circle2;
            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Circle3 = progressInput.Vuvuzela_Circle3;
            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Circle4 = progressInput.Vuvuzela_Circle4;
            vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_Circle5 = progressInput.Vuvuzela_Circle5;


            #endregion

            #region Bool

            if (progressInput.Vuvuzela_RotatingBorder == true)
            {
                vuvuzela_UC.indicator_Vuvuzela_RotatingBorder_Yes_RadioBtn.Checked = true;

                vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_RotatingBorder = true;
            }
            else
            {
                vuvuzela_UC.indicator_Vuvuzela_RotatingBorder_No_RadioBtn.Checked = true;

                vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_RotatingBorder = false;
            }

            if (progressInput.Vuvuzela_FillPie == true)
            {
                vuvuzela_UC.indicator_Vuvuzela_FillPie_Yes_RadioBtn.Checked = true;

                vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_FillPie = true;
            }
            else
            {
                vuvuzela_UC.indicator_Vuvuzela_FillPie_No_RadioBtn.Checked = true;

                vuvuzela_UC.ZeroitThematicProgress1.Vuvuzela_FillPie = false;
            }

            #endregion


        }

        private void Set_Vuvuzela_Retrieved_Values(ProgressInput progressInput)
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

            #region Enum

            progressInput.Shape =
                (ZeroitThematicProgress.Vuvuzela_Shape)Enum.Parse(typeof
                        (ZeroitThematicProgress.Vuvuzela_Shape),
                    vuvuzela_UC.indicator_Vuvuzela_Shape_ComboBox.SelectedItem.ToString());

            #endregion
            
            #region Values

            progressInput.ControlSize =
                (int)vuvuzela_UC.indicator_Vuvuzela_ControlSize_Numeric.Value;

            progressInput.Vuvuzela_Angle =
                (float)vuvuzela_UC.indicator_Vuvuzela_Angle_Numeric.Value;

            progressInput.Vuvuzela_CircleSize =
                (int)vuvuzela_UC.indicator_Vuvuzela_CircleSize_Numeric.Value;

            progressInput.Vuvuzela_HorizontalSpacing =
                (int)vuvuzela_UC.indicator_Vuvuzela_HorizontalSpacing_Numeric.Value;

            progressInput.Vuvuzela_VerticalSpacing =
                (int)vuvuzela_UC.indicator_Vuvuzela_VerticalSpacing_Numeric.Value;


            #endregion

            #region Colors

            progressInput.Vuvuzela_Circle1 = vuvuzela_UC.indicator_Vuvuzela_Circle1_Btn.BackColor;
            progressInput.Vuvuzela_Circle2 = vuvuzela_UC.indicator_Vuvuzela_Circle2_Btn.BackColor;
            progressInput.Vuvuzela_Circle3 = vuvuzela_UC.indicator_Vuvuzela_Circle3_Btn.BackColor;
            progressInput.Vuvuzela_Circle4 = vuvuzela_UC.indicator_Vuvuzela_Circle4_Btn.BackColor;
            progressInput.Vuvuzela_Circle5 = vuvuzela_UC.indicator_Vuvuzela_Circle5_Btn.BackColor;
            
            #endregion

            #region Bool

            if (vuvuzela_UC.indicator_Vuvuzela_RotatingBorder_Yes_RadioBtn.Checked == true)
            {
                progressInput.Vuvuzela_RotatingBorder = true;
                
            }
            else
            {
                progressInput.Vuvuzela_RotatingBorder = false;
            }

            if (vuvuzela_UC.indicator_Vuvuzela_FillPie_Yes_RadioBtn.Checked == true)
            {
                progressInput.Vuvuzela_FillPie = true;

            }
            else
            {
                progressInput.Vuvuzela_FillPie = false;
            }

            #endregion

        }


        #region Preview Events

        private void Preview_Vuvuzela_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                vuvuzela_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                vuvuzela_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion


    }
}
