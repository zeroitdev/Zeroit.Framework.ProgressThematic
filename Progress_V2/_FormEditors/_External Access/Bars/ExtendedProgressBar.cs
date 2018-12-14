// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ExtendedProgressBar.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
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

        private void Set_ExtendedBar_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            extended_UC.Preview_Btn.Click += Preview_Btn_Click;

            #endregion

            #region Add Orientation to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string orientation in Enum.GetNames(typeof(ProgressBarDirection)))
            {
                extended_UC.bars_Extended_Orientation_ComboBox.Items.Add(orientation);

            }

            for (int i = 0; i < extended_UC.bars_Extended_Orientation_ComboBox.Items.Count; i++)
            {
                if (progressInput.Orientation == 
                    (ProgressBarDirection)Enum.Parse(typeof
                    (ProgressBarDirection), 
                    extended_UC.bars_Extended_Orientation_ComboBox.Items[i].ToString()))
                {
                    extended_UC.bars_Extended_Orientation_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add ProgressBar Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressStyle in Enum.GetNames(typeof(ProgressStyle)))
            {
                extended_UC.bars_Extended_BarStyle_ComboBox.Items.Add(progressStyle);

            }

            for (int i = 0; i < extended_UC.bars_Extended_BarStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressBarStyle ==
                    (ProgressStyle)Enum.Parse(typeof
                            (ProgressStyle),
                        extended_UC.bars_Extended_BarStyle_ComboBox.Items[i].ToString()))
                {
                    extended_UC.bars_Extended_BarStyle_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add FloodStyle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string floodstyle in Enum.GetNames(typeof(ProgressFloodStyle)))
            {
                extended_UC.bars_Extended_FloodStyle_ComboBox.Items.Add(floodstyle);

            }

            for (int i = 0; i < extended_UC.bars_Extended_FloodStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.FloodStyle ==
                    (ProgressFloodStyle)Enum.Parse(typeof
                            (ProgressFloodStyle),
                        extended_UC.bars_Extended_FloodStyle_ComboBox.Items[i].ToString()))
                {
                    extended_UC.bars_Extended_FloodStyle_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add Edge to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string edge in Enum.GetNames(typeof(ProgressBarEdge)))
            {
                extended_UC.bars_Extended_Edge_ComboBox.Items.Add(edge);

            }

            for (int i = 0; i < extended_UC.bars_Extended_Edge_ComboBox.Items.Count; i++)
            {
                if (progressInput.Edge ==
                    (ProgressBarEdge)Enum.Parse(typeof
                            (ProgressBarEdge),
                        extended_UC.bars_Extended_Edge_ComboBox.Items[i].ToString()))
                {
                    extended_UC.bars_Extended_Edge_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add CaptionMode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string captionMode in Enum.GetNames(typeof(ProgressCaptionMode)))
            {
                extended_UC.bars_Extended_CaptionMode_ComboBox.Items.Add(captionMode);

            }

            for (int i = 0; i < extended_UC.bars_Extended_CaptionMode_ComboBox.Items.Count; i++)
            {
                if (progressInput.CaptionMode ==
                    (ProgressCaptionMode)Enum.Parse(typeof
                            (ProgressCaptionMode),
                        extended_UC.bars_Extended_CaptionMode_ComboBox.Items[i].ToString()))
                {
                    extended_UC.bars_Extended_CaptionMode_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Numeric Values
            //Numeric Values
            extended_UC.bars_Extended_BarOffset_Numeric.Value = progressInput.BarOffset;
            extended_UC.bars_Extended_DashSpace_Numeric.Value = progressInput.DashSpace;
            extended_UC.bars_Extended_DashWidth_Numeric.Value = progressInput.DashWidth;
            extended_UC.bars_Extended_Step_Numeric.Value = progressInput.ExtendedProgress_Step;
            extended_UC.bars_Extended_FloodPercent_Numeric.Value = (decimal)progressInput.FloodPercentage;
            extended_UC.bars_Extended_ShadowOffset_Numeric.Value = (decimal)progressInput.ShadowOffset;
            extended_UC.bars_Extended_EdgeWidth_Numeric.Value = progressInput.EdgeWidth;

            extended_UC.ZeroitThematicProgress1.BarOffset = progressInput.BarOffset;
            extended_UC.ZeroitThematicProgress1.DashSpace = progressInput.DashSpace;
            extended_UC.ZeroitThematicProgress1.DashWidth = progressInput.DashWidth;
            extended_UC.ZeroitThematicProgress1.ExtendedProgress_Step = progressInput.ExtendedProgress_Step;
            extended_UC.ZeroitThematicProgress1.FloodPercentage = progressInput.FloodPercentage;
            extended_UC.ZeroitThematicProgress1.ShadowOffset = progressInput.ShadowOffset;
            extended_UC.ZeroitThematicProgress1.EdgeWidth = progressInput.EdgeWidth;

            #endregion

            #region Caption
            //String bars_Extended_Caption_TextBox
            extended_UC.bars_Extended_Caption_TextBox.Text = progressInput.Caption;
            
            extended_UC.ZeroitThematicProgress1.Caption = progressInput.Caption;

            #endregion

            #region Colors

            //Colors
            extended_UC.bars_Extended_ShadowColor_Btn.BackColor = progressInput.CaptionShadowColor;
            extended_UC.bars_Extended_EdgeColor_Btn.BackColor = progressInput.EdgeColor;
            extended_UC.bars_Extended_MainColor_Btn.BackColor = progressInput.MainColor;
            extended_UC.bars_Extended_BackColor_Btn.BackColor = progressInput.ProgressBackColor;
            extended_UC.bars_Extended_SecondColor_Btn.BackColor = progressInput.SecondColor;
            extended_UC.bars_Extended_CaptionColor_Btn.BackColor = progressInput.CaptionColor;

            extended_UC.ZeroitThematicProgress1.CaptionShadowColor = progressInput.CaptionShadowColor;
            extended_UC.ZeroitThematicProgress1.EdgeColor = progressInput.EdgeColor;
            extended_UC.ZeroitThematicProgress1.MainColor = progressInput.MainColor;
            extended_UC.ZeroitThematicProgress1.ProgressBackColor = progressInput.ProgressBackColor;
            extended_UC.ZeroitThematicProgress1.SecondColor = progressInput.SecondColor;
            extended_UC.ZeroitThematicProgress1.CaptionColor = progressInput.CaptionColor;

            #endregion

            #region Bool - Radio Button

            //Bool - RadioButton

            if (progressInput.TextAntialias == true)
            {
                extended_UC.bars_Extended_AntiAlias_Yes_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.TextAntialias = true;
            }
            else
            {
                extended_UC.bars_Extended_AntiAlias_No_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.TextAntialias = false;
            }

            if (progressInput.ExtendedProgress_Shadow == true)
            {
                extended_UC.bars_Extended_ShadowYes_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.ExtendedProgress_Shadow = true;

            }
            else
            {
                extended_UC.bars_Extended_ShadowNo_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.ExtendedProgress_Shadow = false;
            }

            if (progressInput.ChangeByMouse == true)
            {
                extended_UC.bars_Extended_ChangeByMouse_Yes_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.ChangeByMouse = true;
            }
            else
            {
                extended_UC.bars_Extended_ChangeByMouse_No_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.ChangeByMouse = false;
            }

            if (progressInput.Invert == true)
            {
                extended_UC.bars_Extended_Invert_Yes_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.Invert = true;
            }
            else
            {
                extended_UC.bars_Extended_Invert_No_RadioBtn.Checked = true;

                extended_UC.ZeroitThematicProgress1.Invert = false;
            }


            #endregion
            
            #region Index Changed

            extended_UC.bars_Extended_Orientation_ComboBox.SelectedIndexChanged += Bars_Extended_Orientation_ComboBox_SelectedIndexChanged;
            extended_UC.bars_Extended_BarStyle_ComboBox.SelectedIndexChanged += Bars_Extended_BarStyle_ComboBox_SelectedIndexChanged;
            extended_UC.bars_Extended_FloodStyle_ComboBox.SelectedIndexChanged += Bars_Extended_FloodStyle_ComboBox_SelectedIndexChanged;
            extended_UC.bars_Extended_Edge_ComboBox.SelectedIndexChanged += Bars_Extended_Edge_ComboBox_SelectedIndexChanged;
            extended_UC.bars_Extended_CaptionMode_ComboBox.SelectedIndexChanged += Bars_Extended_CaptionMode_ComboBox_SelectedIndexChanged;

            #endregion

            #region Value Changed

            extended_UC.bars_Extended_BarOffset_Numeric.ValueChanged += Bars_Extended_BarOffset_Numeric_ValueChanged;
            extended_UC.bars_Extended_DashSpace_Numeric.ValueChanged += Bars_Extended_DashSpace_Numeric_ValueChanged;
            extended_UC.bars_Extended_DashWidth_Numeric.ValueChanged += Bars_Extended_DashWidth_Numeric_ValueChanged;
            extended_UC.bars_Extended_Step_Numeric.ValueChanged += Bars_Extended_Step_Numeric_ValueChanged;
            extended_UC.bars_Extended_FloodPercent_Numeric.ValueChanged += Bars_Extended_FloodPercent_Numeric_ValueChanged;
            extended_UC.bars_Extended_ShadowOffset_Numeric.ValueChanged += Bars_Extended_ShadowOffset_Numeric_ValueChanged;
            extended_UC.bars_Extended_EdgeWidth_Numeric.ValueChanged += Bars_Extended_EdgeWidth_Numeric_ValueChanged;
            #endregion

            #region Text Changed

            extended_UC.bars_Extended_Caption_TextBox.TextChanged += Bars_Extended_Caption_TextBox_TextChanged;

            #endregion

            #region Color - Click Events

            extended_UC.bars_Extended_ShadowColor_Btn.Click += Bars_Extended_ShadowColor_Btn_Click;
            extended_UC.bars_Extended_EdgeColor_Btn.Click += Bars_Extended_EdgeColor_Btn_Click;
            extended_UC.bars_Extended_MainColor_Btn.Click += Bars_Extended_MainColor_Btn_Click;
            extended_UC.bars_Extended_BackColor_Btn.Click += Bars_Extended_BackColor_Btn_Click;
            extended_UC.bars_Extended_SecondColor_Btn.Click += Bars_Extended_SecondColor_Btn_Click;
            extended_UC.bars_Extended_CaptionColor_Btn.Click += Bars_Extended_CaptionColor_Btn_Click;
            #endregion

            #region Bool - Events
            extended_UC.bars_Extended_AntiAlias_Yes_RadioBtn.CheckedChanged += Bars_Extended_AntiAlias_Yes_RadioBtn_CheckedChanged;
            extended_UC.bars_Extended_ShadowYes_RadioBtn.CheckedChanged += Bars_Extended_ShadowYes_RadioBtn_CheckedChanged;
            extended_UC.bars_Extended_ChangeByMouse_Yes_RadioBtn.CheckedChanged += Bars_Extended_ChangeByMouse_Yes_RadioBtn_CheckedChanged;
            extended_UC.bars_Extended_Invert_Yes_RadioBtn.CheckedChanged += Bars_Extended_Invert_Yes_RadioBtn_CheckedChanged;


            #endregion

        }


        private void Set_ExtendedBar_Retrieved_Values(ProgressInput progressInput)
        {
            #region MainControl Inputs

            #region Enums - ComboBox

            //progressInput.ProgressType = (ProgressType)Enum.Parse(typeof
            //            (ProgressType),
            //        mainControl_ProgressType_ComboBox.SelectedItem.ToString());

            //progressInput.SolidProgressBar = (ProgressBar)Enum.Parse(typeof
            //        (ProgressBar),
            //    mainControl_BarProgress_ComboBox.SelectedItem.ToString());

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

            if (mainControl_Transparency_Yes_RadioBtn.Checked == true)
            {
                progressInput.AllowTransparency = true;
            }
            else
            {
                progressInput.AllowTransparency = false;
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

            //*************** Enums *******************//

            progressInput.Orientation = 
                (ProgressBarDirection)Enum.Parse(typeof
                (ProgressBarDirection),
                extended_UC.bars_Extended_Orientation_ComboBox.SelectedItem.ToString());
            
            progressInput.ProgressBarStyle = 
                (ProgressStyle)Enum.Parse(typeof
                (ProgressStyle),
                extended_UC.bars_Extended_BarStyle_ComboBox.SelectedItem.ToString());

            
            progressInput.FloodStyle =
                (ProgressFloodStyle)Enum.Parse(typeof
                (ProgressFloodStyle),
                extended_UC.bars_Extended_FloodStyle_ComboBox.SelectedItem.ToString());

            
            progressInput.Edge = 
                (ProgressBarEdge)Enum.Parse(typeof
                (ProgressBarEdge),
                extended_UC.bars_Extended_Edge_ComboBox.SelectedItem.ToString());
            
            
            progressInput.CaptionMode =
                (ProgressCaptionMode)Enum.Parse(typeof
                        (ProgressCaptionMode),
                    extended_UC.bars_Extended_CaptionMode_ComboBox.SelectedItem.ToString());

            //*************** Enums End*******************//


            //***************Numeric Values*******************//

            progressInput.BarOffset = (int)extended_UC.bars_Extended_BarOffset_Numeric.Value;
            progressInput.DashSpace = (int)extended_UC.bars_Extended_DashSpace_Numeric.Value;
            progressInput.DashWidth = (int)extended_UC.bars_Extended_DashWidth_Numeric.Value;
            progressInput.ExtendedProgress_Step = (int)extended_UC.bars_Extended_Step_Numeric.Value;
            progressInput.FloodPercentage = (int)extended_UC.bars_Extended_FloodPercent_Numeric.Value;
            progressInput.ShadowOffset = (int)extended_UC.bars_Extended_ShadowOffset_Numeric.Value;
            progressInput.EdgeWidth = (int)extended_UC.bars_Extended_EdgeWidth_Numeric.Value;

            //*************** Numeric Values End*******************//

            //*************** String Values*******************//

            progressInput.Caption = extended_UC.bars_Extended_Caption_TextBox.Text;

            //*************** String Values End *******************//


            //*************** Colors *******************//

            progressInput.CaptionShadowColor = extended_UC.bars_Extended_ShadowColor_Btn.BackColor;
            progressInput.EdgeColor = extended_UC.bars_Extended_EdgeColor_Btn.BackColor;
            progressInput.MainColor = extended_UC.bars_Extended_MainColor_Btn.BackColor;
            progressInput.ProgressBackColor = extended_UC.bars_Extended_BackColor_Btn.BackColor;
            progressInput.SecondColor = extended_UC.bars_Extended_SecondColor_Btn.BackColor;
            progressInput.CaptionColor = extended_UC.bars_Extended_CaptionColor_Btn.BackColor;

            //*************** Colors End *******************//

            //*************** Bool *******************//

            if (extended_UC.bars_Extended_AntiAlias_Yes_RadioBtn.Checked)
            {
                progressInput.TextAntialias = true;
            }
            else
            {
                progressInput.TextAntialias = false;
            }

            if (extended_UC.bars_Extended_ShadowYes_RadioBtn.Checked)
            {
                progressInput.ExtendedProgress_Shadow = true;
            }
            else
            {
                progressInput.ExtendedProgress_Shadow = false;
            }

            if (extended_UC.bars_Extended_ChangeByMouse_Yes_RadioBtn.Checked)
            {
                progressInput.ChangeByMouse = true;
            }
            else
            {
                progressInput.ChangeByMouse = false;
            }

            if (extended_UC.bars_Extended_Invert_Yes_RadioBtn.Checked)
            {
                progressInput.Invert = true;
            }
            else
            {
                progressInput.Invert = false;
            }

            //*************** Bool End *******************//


        }

        #region Bool Events - Radio Button

        private void Bars_Extended_Invert_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (extended_UC.bars_Extended_Invert_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.Invert = true;

            }
            else
            {
                extended_UC.ZeroitThematicProgress1.Invert = false;

            }
        }

        private void Bars_Extended_ChangeByMouse_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (extended_UC.bars_Extended_ChangeByMouse_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.ChangeByMouse = true;

            }
            else
            {
                extended_UC.ZeroitThematicProgress1.ChangeByMouse = false;

            }
        }

        private void Bars_Extended_AntiAlias_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (extended_UC.bars_Extended_AntiAlias_Yes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.TextAntialias = true;

            }
            else
            {
                extended_UC.ZeroitThematicProgress1.TextAntialias = false;

            }
        }

        private void Bars_Extended_ShadowYes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (extended_UC.bars_Extended_ShadowYes_RadioBtn.Checked == true)
            {
                extended_UC.ZeroitThematicProgress1.ExtendedProgress_Shadow = true;

            }
            else
            {
                extended_UC.ZeroitThematicProgress1.ExtendedProgress_Shadow = false;

            }

        }

        #endregion

        #region Color Events

        private void Bars_Extended_CaptionColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;
                extended_UC.ZeroitThematicProgress1.CaptionColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_CaptionColor_Btn.BackColor = extended_UC.colorSelector.Color;

            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.CaptionColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_CaptionColor_Btn.BackColor = extended_UC.colorSelector.Color;

                }
            }
            
        }

        private void Bars_Extended_SecondColor_Btn_Click(object sender, EventArgs e)
        {

            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;

                extended_UC.ZeroitThematicProgress1.SecondColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_SecondColor_Btn.BackColor = extended_UC.colorSelector.Color;
            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.SecondColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_SecondColor_Btn.BackColor = extended_UC.colorSelector.Color;
                }
            }
        }

        private void Bars_Extended_BackColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;
                extended_UC.ZeroitThematicProgress1.ProgressBackColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_BackColor_Btn.BackColor = extended_UC.colorSelector.Color;

            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.ProgressBackColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_BackColor_Btn.BackColor = extended_UC.colorSelector.Color;

                }
            }
        }

        private void Bars_Extended_MainColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;
                extended_UC.ZeroitThematicProgress1.MainColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_MainColor_Btn.BackColor = extended_UC.colorSelector.Color;
            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.MainColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_MainColor_Btn.BackColor = extended_UC.colorSelector.Color;
                }
            }
        }

        private void Bars_Extended_EdgeColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;

                extended_UC.ZeroitThematicProgress1.EdgeColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_EdgeColor_Btn.BackColor = extended_UC.colorSelector.Color;

            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.EdgeColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_EdgeColor_Btn.BackColor = extended_UC.colorSelector.Color;

                }
            }
        }

        private void Bars_Extended_ShadowColor_Btn_Click(object sender, EventArgs e)
        {
            if (MouseButtons == System.Windows.Forms.MouseButtons.Right)
            {
                extended_UC.colorSelector.Color = Color.Transparent;

                extended_UC.ZeroitThematicProgress1.CaptionShadowColor = extended_UC.colorSelector.Color;

                extended_UC.bars_Extended_ShadowColor_Btn.BackColor = extended_UC.colorSelector.Color;

            }
            else
            {
                if (extended_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    extended_UC.ZeroitThematicProgress1.CaptionShadowColor = extended_UC.colorSelector.Color;

                    extended_UC.bars_Extended_ShadowColor_Btn.BackColor = extended_UC.colorSelector.Color;

                }
            }
        }


        #endregion

        #region Caption Event

        private void Bars_Extended_Caption_TextBox_TextChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.Caption = extended_UC.bars_Extended_Caption_TextBox.Text;

        }


        #endregion

        #region Numeric Events

        private void Bars_Extended_EdgeWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.EdgeWidth = (int)extended_UC.bars_Extended_EdgeWidth_Numeric.Value;

        }


        private void Bars_Extended_ShadowOffset_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.ShadowOffset = (int)extended_UC.bars_Extended_ShadowOffset_Numeric.Value;

        }

        private void Bars_Extended_FloodPercent_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.FloodPercentage = (int)extended_UC.bars_Extended_FloodPercent_Numeric.Value;

        }

        private void Bars_Extended_Step_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.ExtendedProgress_Step = (int)extended_UC.bars_Extended_Step_Numeric.Value;

        }

        private void Bars_Extended_DashWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.DashWidth = (int)extended_UC.bars_Extended_DashWidth_Numeric.Value;

        }

        private void Bars_Extended_DashSpace_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.DashSpace = (int)extended_UC.bars_Extended_DashSpace_Numeric.Value;

        }

        private void Bars_Extended_BarOffset_Numeric_ValueChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.BarOffset = (int)extended_UC.bars_Extended_BarOffset_Numeric.Value;

        }

        #endregion

        #region Enum - ComboBox Events

        private void Bars_Extended_CaptionMode_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.CaptionMode = (ProgressCaptionMode)extended_UC.bars_Extended_CaptionMode_ComboBox.SelectedIndex;

        }

        private void Bars_Extended_Edge_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.Edge = (ProgressBarEdge)extended_UC.bars_Extended_Edge_ComboBox.SelectedIndex;

        }

        private void Bars_Extended_FloodStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.FloodStyle = (ProgressFloodStyle)extended_UC.bars_Extended_FloodStyle_ComboBox.SelectedIndex;

        }

        private void Bars_Extended_BarStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            extended_UC.ZeroitThematicProgress1.ProgressBarStyle = (ProgressStyle)extended_UC.bars_Extended_BarStyle_ComboBox.SelectedIndex;

        }

        private void Bars_Extended_Orientation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            extended_UC.ZeroitThematicProgress1.Orientation = (ProgressBarDirection)extended_UC.bars_Extended_Orientation_ComboBox.SelectedIndex;

        }

        #endregion

        #region Preview Events

        private void Preview_Btn_Click(object sender, EventArgs e)
        {
            animationRunnig = true;

            //if (extended_UC.ZeroitThematicProgress1.AutoAnimate == true)
            //{
            //    extended_UC.ZeroitThematicProgress1.AutoAnimate = false;

            //}


            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (extended_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    extended_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    extended_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                extended_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                //extended_UC.ZeroitThematicProgress1.AutoIncrement = true;

                if (extended_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    extended_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    extended_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                extended_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
