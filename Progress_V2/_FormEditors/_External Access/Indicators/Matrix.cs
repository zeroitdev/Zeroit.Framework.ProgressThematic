// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Matrix.cs" company="Zeroit Dev Technologies">
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

        private void Set_Matrix_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            matrix_UC.Preview_Btn.Click += Preview_Matrix_Click;

            #endregion

            #region Add Automatic Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(MacOSX_automatic)))
            {
                matrix_UC.indicator_Matrix_Automatic_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < matrix_UC.indicator_Matrix_Automatic_ComboBox.Items.Count; i++)
            {
                if (progressInput.MacOSX_Automatic == 
                    (MacOSX_automatic)Enum.Parse(typeof
                    (MacOSX_automatic),
                    matrix_UC.indicator_Matrix_Automatic_ComboBox.Items[i].ToString()))
                {
                    matrix_UC.indicator_Matrix_Automatic_ComboBox.SelectedIndex = i;

                    matrix_UC.ZeroitThematicProgress1.MacOSX_Automatic =
                        (MacOSX_automatic)Enum.Parse(typeof
                        (MacOSX_automatic),
                        matrix_UC.indicator_Matrix_Automatic_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Rotation to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(ZeroitThematicProgress.MacOSX_Direction)))
            {
                matrix_UC.indicator_Matrix_Rotation_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < matrix_UC.indicator_Matrix_Rotation_ComboBox.Items.Count; i++)
            {
                if (progressInput.MacOSX_Matrix_Rotation ==
                    (ZeroitThematicProgress.MacOSX_Direction)Enum.Parse(typeof
                            (ZeroitThematicProgress.MacOSX_Direction),
                        matrix_UC.indicator_Matrix_Rotation_ComboBox.Items[i].ToString()))
                {
                    matrix_UC.indicator_Matrix_Rotation_ComboBox.SelectedIndex = i;

                    matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_Rotation =
                        (ZeroitThematicProgress.MacOSX_Direction)Enum.Parse(typeof
                                (ZeroitThematicProgress.MacOSX_Direction),
                            matrix_UC.indicator_Matrix_Rotation_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(LineCap)))
            {
                matrix_UC.indicator_Matrix_StartCap_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < matrix_UC.indicator_Matrix_StartCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.MacOSX_Matrix_StartCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        matrix_UC.indicator_Matrix_StartCap_ComboBox.Items[i].ToString()))
                {
                    matrix_UC.indicator_Matrix_StartCap_ComboBox.SelectedIndex = i;

                    matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_StartCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            matrix_UC.indicator_Matrix_StartCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #region Add End Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(LineCap)))
            {
                matrix_UC.indicator_Matrix_EndCap_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < matrix_UC.indicator_Matrix_EndCap_ComboBox.Items.Count; i++)
            {
                if (progressInput.MacOSX_Matrix_EndCap ==
                    (LineCap)Enum.Parse(typeof
                            (LineCap),
                        matrix_UC.indicator_Matrix_EndCap_ComboBox.Items[i].ToString()))
                {
                    matrix_UC.indicator_Matrix_EndCap_ComboBox.SelectedIndex = i;

                    matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_EndCap =
                        (LineCap)Enum.Parse(typeof
                                (LineCap),
                            matrix_UC.indicator_Matrix_EndCap_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion
            
            #region Values

            matrix_UC.indicator_Matrix_Interval_Numeric.Value =
                (int)progressInput.MacOSX_Matrix_Interval;

            matrix_UC.indicator_Matrix_StartAngle_Numeric.Value =
                (int)progressInput.MacOSX_Matrix_StartAngle;

            matrix_UC.indicator_Matrix_CircleCount_Numeric.Value =
                (int)progressInput.MacOSX_Matrix_SpokesCount;

            matrix_UC.indicator_MacOSX_MaxSpokes_Numeric.Value =
                (int)progressInput.MacOSX_MaxSpokes;


            matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_Interval =
                (int)progressInput.MacOSX_Matrix_Interval;

            matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_StartAngle =
                (int)progressInput.MacOSX_Matrix_StartAngle;

            matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_SpokesCount =
                (int)progressInput.MacOSX_Matrix_SpokesCount;

            matrix_UC.ZeroitThematicProgress1.MacOSX_MaxSpokes =
                (int)progressInput.MacOSX_MaxSpokes;

            #endregion

            #region Colors

            matrix_UC.indicator_Matrix_TickColor_Btn.BackColor = progressInput.MacOSX_Matrix_TickColor;

            matrix_UC.ZeroitThematicProgress1.MacOSX_Matrix_TickColor = progressInput.MacOSX_Matrix_TickColor;

            #endregion


        }


        private void Set_Matrix_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.MacOSX_Automatic =
                (MacOSX_automatic)Enum.Parse(typeof
                        (MacOSX_automatic),
                    matrix_UC.indicator_Matrix_Automatic_ComboBox.SelectedItem.ToString());

            progressInput.MacOSX_Matrix_Rotation =
                (ZeroitThematicProgress.MacOSX_Direction)Enum.Parse(typeof
                        (ZeroitThematicProgress.MacOSX_Direction),
                    matrix_UC.indicator_Matrix_Rotation_ComboBox.SelectedItem.ToString());

            progressInput.MacOSX_Matrix_StartCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    matrix_UC.indicator_Matrix_StartCap_ComboBox.SelectedItem.ToString());

            progressInput.MacOSX_Matrix_EndCap =
                (LineCap)Enum.Parse(typeof
                        (LineCap),
                    matrix_UC.indicator_Matrix_EndCap_ComboBox.SelectedItem.ToString());


            #endregion
            
            #region Values

            progressInput.MacOSX_Matrix_Interval =
                (int)matrix_UC.indicator_Matrix_Interval_Numeric.Value;

            progressInput.MacOSX_Matrix_StartAngle =
                (int)matrix_UC.indicator_Matrix_StartAngle_Numeric.Value;

            progressInput.MacOSX_Matrix_SpokesCount =
                (int)matrix_UC.indicator_Matrix_CircleCount_Numeric.Value;

            progressInput.MacOSX_MaxSpokes =
                (int)matrix_UC.indicator_MacOSX_MaxSpokes_Numeric.Value;

            #endregion

            #region Colors

            progressInput.MacOSX_Matrix_TickColor = matrix_UC.indicator_Matrix_TickColor_Btn.BackColor;

            #endregion


        }


        #region Preview Events

        private void Preview_Matrix_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (matrix_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    matrix_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    matrix_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                matrix_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (matrix_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    matrix_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    matrix_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                matrix_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
