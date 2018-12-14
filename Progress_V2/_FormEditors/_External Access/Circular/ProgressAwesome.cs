// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgressAwesome.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProgressDialog
    {

        private void Set_Awesome_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            progressAwesome_UC.Preview_Btn.Click += Preview_Awesome_Click;

            #endregion

            #region Enum

            #region Add Start Cap to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressBarStyle in Enum.GetNames(typeof(ProgressBarStyle)))
            {
                progressAwesome_UC.circular_Awesome_Style_ComboBox.Items.Add(progressBarStyle);

            }

            for (int i = 0; i < progressAwesome_UC.circular_Awesome_Style_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressBarAwesomeStyle ==
                    (ProgressBarStyle)Enum.Parse(typeof
                            (ProgressBarStyle),
                        progressAwesome_UC.circular_Awesome_Style_ComboBox.Items[i].ToString()))
                {
                    progressAwesome_UC.circular_Awesome_Style_ComboBox.SelectedIndex = i;

                    progressAwesome_UC.ZeroitThematicProgress1.ProgressBarAwesomeStyle =
                        (ProgressBarStyle)Enum.Parse(typeof
                                (ProgressBarStyle),
                            progressAwesome_UC.circular_Awesome_Style_ComboBox.SelectedItem.ToString());


                }

            }
            #endregion

            #endregion

            #region Values

            progressAwesome_UC.circular_Awesome_InnerMargin_Numeric.Value = progressInput.InnerMargin;
            progressAwesome_UC.circular_Awesome_InnerWidth_Numeric.Value = progressInput.InnerWidth;
            progressAwesome_UC.circular_Awesome_OuterMargin_Numeric.Value = progressInput.OuterMargin;
            progressAwesome_UC.circular_Awesome_OuterWidth_Numeric.Value = progressInput.OuterWidth;
            progressAwesome_UC.circular_Awesome_AnimationSpeed_Numeric.Value = progressInput.ProgressAwesome_AnimationSpeed;
            progressAwesome_UC.circular_Awesome_ProgressWidth_Numeric.Value = progressInput.ProgressAwesome_ProgressWidth;
            progressAwesome_UC.circular_Awesome_StartAngle_Numeric.Value = progressInput.StartAngle;
            progressAwesome_UC.circular_Awesome_SpMarginTop_Numeric.Value = progressInput.SuperscriptMargin.Top;
            progressAwesome_UC.circular_Awesome_SpMarginLeft_Numeric.Value = progressInput.SuperscriptMargin.Left;
            progressAwesome_UC.circular_Awesome_SbMarginTop_Numeric.Value = progressInput.SubscriptMargin.Top;
            progressAwesome_UC.circular_Awesome_SbMarginLeft_Numeric.Value = progressInput.SubscriptMargin.Left;
            progressAwesome_UC.circular_Awesome_SbMarginAll_Numeric.Value = progressInput.SubscriptMargin.All;
            progressAwesome_UC.circular_Awesome_TxtMarginTop_Numeric.Value = progressInput.TextMargin.Top;
            progressAwesome_UC.circular_Awesome_TxtMarginLeft_Numeric.Value = progressInput.TextMargin.Left;
            progressAwesome_UC.circular_Awesome_TxtMarginAll_Numeric.Value = progressInput.TextMargin.All;
            progressAwesome_UC.circular_Awesome_SpMarginBottom_Numeric.Value = progressInput.SuperscriptMargin.Bottom;
            progressAwesome_UC.circular_Awesome_SpMarginRight_Numeric.Value = progressInput.SuperscriptMargin.Right;
            progressAwesome_UC.circular_Awesome_SbMarginBottom_Numeric.Value = progressInput.SubscriptMargin.Bottom;
            progressAwesome_UC.circular_Awesome_SpMarginAll_Numeric.Value = progressInput.SuperscriptMargin.All;
            progressAwesome_UC.circular_Awesome_TxtMarginBottom_Numeric.Value = progressInput.TextMargin.Bottom;
            progressAwesome_UC.circular_Awesome_TxtMarginRight_Numeric.Value = progressInput.TextMargin.Right;

            progressAwesome_UC.ZeroitThematicProgress1.InnerMargin = progressInput.InnerMargin;
            progressAwesome_UC.ZeroitThematicProgress1.InnerWidth = progressInput.InnerWidth;
            progressAwesome_UC.ZeroitThematicProgress1.OuterMargin = progressInput.OuterMargin;
            progressAwesome_UC.ZeroitThematicProgress1.OuterWidth = progressInput.OuterWidth;
            progressAwesome_UC.ZeroitThematicProgress1.ProgressAwesome_AnimationSpeed = progressInput.ProgressAwesome_AnimationSpeed;
            progressAwesome_UC.ZeroitThematicProgress1.ProgressAwesome_ProgressWidth = progressInput.ProgressAwesome_ProgressWidth;
            progressAwesome_UC.ZeroitThematicProgress1.StartAngle = progressInput.StartAngle;
            progressAwesome_UC.ZeroitThematicProgress1.SuperscriptMargin = new Padding(
                progressInput.SuperscriptMargin.Left, progressInput.SuperscriptMargin.Top,
                progressInput.SuperscriptMargin.Right, progressInput.SuperscriptMargin.Bottom);
            progressAwesome_UC.ZeroitThematicProgress1.SubscriptMargin = new Padding(
                progressInput.SubscriptMargin.Left, progressInput.SubscriptMargin.Top,
                progressInput.SubscriptMargin.Right, progressInput.SubscriptMargin.Bottom);
            progressAwesome_UC.ZeroitThematicProgress1.TextMargin = new Padding(
                progressInput.TextMargin.Left, progressInput.TextMargin.Top,
                progressInput.TextMargin.Right, progressInput.TextMargin.Bottom);
            


            #endregion

            #region Colors

            progressAwesome_UC.circular_Awesome_SpColor_Btn.BackColor = progressInput.SuperscriptColor;
            progressAwesome_UC.circular_Awesome_InnerColor_Btn.BackColor = progressInput.InnerColor;
            progressAwesome_UC.circular_Awesome_SbColor_Btn.BackColor = progressInput.SubscriptColor;
            progressAwesome_UC.circular_Awesome_ProgressColor_Btn.BackColor = progressInput.ProgressColor;
            progressAwesome_UC.circular_Awesome_OuterColor_Btn.BackColor = progressInput.OuterColor;

            progressAwesome_UC.ZeroitThematicProgress1.SuperscriptColor = progressInput.SuperscriptColor;
            progressAwesome_UC.ZeroitThematicProgress1.InnerColor = progressInput.InnerColor;
            progressAwesome_UC.ZeroitThematicProgress1.SubscriptColor = progressInput.SubscriptColor;
            progressAwesome_UC.ZeroitThematicProgress1.ProgressColor = progressInput.ProgressColor;
            progressAwesome_UC.ZeroitThematicProgress1.OuterColor = progressInput.OuterColor;


            #endregion

            #region TextBox - String

            progressAwesome_UC.circular_Awesome_SbText_TextBox.Text = progressInput.SubscriptText;
            progressAwesome_UC.circular_Awesome_SpText_TextBox.Text = progressInput.SuperscriptText;

            progressAwesome_UC.ZeroitThematicProgress1.SubscriptText = progressInput.SubscriptText;
            progressAwesome_UC.ZeroitThematicProgress1.SuperscriptText = progressInput.SuperscriptText;


            #endregion

            #region Font

            progressAwesome_UC.circular_Awesome_SecondaryFontName_Label.Text = progressInput.SecondaryFont.Name;
            progressAwesome_UC.circular_Awesome_SecondaryFontSize_Label.Text = progressInput.SecondaryFont.Size.ToString();

            progressAwesome_UC.ZeroitThematicProgress1.SecondaryFont = new Font(progressInput.SecondaryFont.Name, progressInput.SecondaryFont.Size);

            #endregion

            #region Value

            progressAwesome_UC.ZeroitThematicProgress1.Value = progressInput.Value;

            #endregion

        }

        private void Set_Awesome_Retrieved_Values(ProgressInput progressInput)
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

            #region Add Start Cap to ComboBox

            progressInput.ProgressBarAwesomeStyle =
                (ProgressBarStyle)Enum.Parse(typeof
                        (ProgressBarStyle),
                    progressAwesome_UC.circular_Awesome_Style_ComboBox.SelectedItem.ToString());


            #endregion

            #endregion

            #region Values

            progressInput.InnerMargin = (int)progressAwesome_UC.circular_Awesome_InnerMargin_Numeric.Value;
            progressInput.InnerWidth = (int)progressAwesome_UC.circular_Awesome_InnerWidth_Numeric.Value;
            progressInput.OuterMargin = (int)progressAwesome_UC.circular_Awesome_OuterMargin_Numeric.Value;
            progressInput.OuterWidth = (int)progressAwesome_UC.circular_Awesome_OuterWidth_Numeric.Value;
            progressInput.ProgressAwesome_AnimationSpeed = (int)progressAwesome_UC.circular_Awesome_AnimationSpeed_Numeric.Value;
            progressInput.ProgressAwesome_ProgressWidth = (int)progressAwesome_UC.circular_Awesome_ProgressWidth_Numeric.Value;
            progressInput.StartAngle = (int)progressAwesome_UC.circular_Awesome_StartAngle_Numeric.Value;

            progressInput.SuperscriptMargin = new Padding((int)progressAwesome_UC.circular_Awesome_SpMarginLeft_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SpMarginTop_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SpMarginRight_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SpMarginBottom_Numeric.Value);

            progressInput.SubscriptMargin = new Padding((int)progressAwesome_UC.circular_Awesome_SbMarginLeft_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SbMarginTop_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SbMarginRight_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_SbMarginBottom_Numeric.Value);

            progressInput.TextMargin = new Padding((int)progressAwesome_UC.circular_Awesome_TxtMarginLeft_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_TxtMarginTop_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_TxtMarginRight_Numeric.Value,
                (int)progressAwesome_UC.circular_Awesome_TxtMarginBottom_Numeric.Value);


            #endregion

            #region Colors

            progressInput.SuperscriptColor = progressAwesome_UC.circular_Awesome_SpColor_Btn.BackColor;
            progressInput.InnerColor = progressAwesome_UC.circular_Awesome_InnerColor_Btn.BackColor;
            progressInput.SubscriptColor = progressAwesome_UC.circular_Awesome_SbColor_Btn.BackColor;
            progressInput.ProgressColor = progressAwesome_UC.circular_Awesome_ProgressColor_Btn.BackColor;
            progressInput.OuterColor = progressAwesome_UC.circular_Awesome_OuterColor_Btn.BackColor;
            #endregion

            #region TextBox - String

            progressInput.SubscriptText = progressAwesome_UC.circular_Awesome_SbText_TextBox.Text;
            progressInput.SuperscriptText = progressAwesome_UC.circular_Awesome_SpText_TextBox.Text;

            #endregion

            #region Font

            progressInput.SecondaryFont = new Font(
                progressAwesome_UC.circular_Awesome_SecondaryFontName_Label.Text,
                Convert.ToInt32(progressAwesome_UC.circular_Awesome_SecondaryFontSize_Label.Text));
            
            #endregion

        }


        #region Preview Events

        private void Preview_Awesome_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                progressAwesome_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                progressAwesome_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
