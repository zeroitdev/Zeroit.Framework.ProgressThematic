// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="iTunes.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Progress control with an Editor.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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

        
        private void Set_iTunes_Initial_Values(ProgressInput progressInput)
        {

            #region Add Bar Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(BarType)))
            {
                iTunes_UC.bars_iTunes_Bar_Type_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < iTunes_UC.bars_iTunes_Bar_Type_ComboBox.Items.Count; i++)
            {
                if (progressInput.BarType ==
                    (BarType)Enum.Parse(typeof
                            (BarType),
                        iTunes_UC.bars_iTunes_Bar_Type_ComboBox.Items[i].ToString()))
                {
                    iTunes_UC.bars_iTunes_Bar_Type_ComboBox.SelectedIndex = i;

                }

            }
            
            #endregion

            #region Numerics

            iTunes_UC.bars_iTunes_BorderWidth_Numeric.Value = (decimal)progressInput.BarBorderWidth;
            iTunes_UC.bars_iTunes_DividersCount_Numeric.Value = (decimal)progressInput.BarDividersCount;
            iTunes_UC.bars_iTunes_MirrorOpacity_Numeric.Value = (decimal)progressInput.BarMirrorOpacity;
            iTunes_UC.bars_iTunes_StepSize_Numeric.Value = (decimal)progressInput.StepSize;
            iTunes_UC.bars_iTunes_StepInterval_Numeric.Value = (decimal)progressInput.StepInterval;


            iTunes_UC.ZeroitThematicProgress1.BarBorderWidth = progressInput.BarBorderWidth;
            iTunes_UC.ZeroitThematicProgress1.BarDividersCount = progressInput.BarDividersCount;
            iTunes_UC.ZeroitThematicProgress1.BarMirrorOpacity = progressInput.BarMirrorOpacity;
            iTunes_UC.ZeroitThematicProgress1.StepSize = progressInput.StepSize;
            iTunes_UC.ZeroitThematicProgress1.StepInterval = progressInput.StepInterval;


            #endregion

            #region Colors

            iTunes_UC.bars_iTunes_BackgroundDark_Btn.BackColor = progressInput.BarBackgroundDark;
            iTunes_UC.bars_iTunes_BackgroundLight_Btn.BackColor = progressInput.BarBackgroundLight;
            iTunes_UC.bars_iTunes_BorderColor_Btn.BackColor = progressInput.BarBorderColor;
            iTunes_UC.bars_iTunes_BarDark_Btn.BackColor = progressInput.BarDark;
            iTunes_UC.bars_iTunes_BarLight_Btn.BackColor = progressInput.BarLight;

            iTunes_UC.ZeroitThematicProgress1.BarBackgroundDark = progressInput.BarBackgroundDark;
            iTunes_UC.ZeroitThematicProgress1.BarBackgroundLight = progressInput.BarBackgroundLight;
            iTunes_UC.ZeroitThematicProgress1.BarBorderColor = progressInput.BarBorderColor;
            iTunes_UC.ZeroitThematicProgress1.BarDark = progressInput.BarDark;
            iTunes_UC.ZeroitThematicProgress1.BarLight = progressInput.BarLight;


            #endregion

            #region Preview Button

            iTunes_UC.Preview_Btn.Click += Preview_iTunes_Btn_Click;

            #endregion

            #region Index Changed

            iTunes_UC.bars_iTunes_Bar_Type_ComboBox.SelectedIndexChanged += Bars_iTunes_Bar_Type_ComboBox_SelectedIndexChanged;


            #endregion

            #region Value Changed

            iTunes_UC.bars_iTunes_BorderWidth_Numeric.ValueChanged += Bars_iTunes_BorderWidth_Numeric_ValueChanged;
            iTunes_UC.bars_iTunes_DividersCount_Numeric.ValueChanged += Bars_iTunes_DividersCount_Numeric_ValueChanged;
            iTunes_UC.bars_iTunes_MirrorOpacity_Numeric.ValueChanged += Bars_iTunes_MirrorOpacity_Numeric_ValueChanged;
            iTunes_UC.bars_iTunes_StepSize_Numeric.ValueChanged += Bars_iTunes_StepSize_Numeric_ValueChanged;
            iTunes_UC.bars_iTunes_StepInterval_Numeric.ValueChanged += Bars_iTunes_StepInterval_Numeric_ValueChanged;
            #endregion

            #region Color - Button Click

            iTunes_UC.bars_iTunes_BackgroundDark_Btn.Click += Bars_iTunes_BackgroundDark_Btn_Click;
            iTunes_UC.bars_iTunes_BackgroundLight_Btn.Click += Bars_iTunes_BackgroundLight_Btn_Click;
            iTunes_UC.bars_iTunes_BorderColor_Btn.Click += Bars_iTunes_BorderColor_Btn_Click;
            iTunes_UC.bars_iTunes_BarDark_Btn.Click += Bars_iTunes_BarDark_Btn_Click;
            iTunes_UC.bars_iTunes_BarLight_Btn.Click += Bars_iTunes_BarLight_Btn_Click;
            #endregion

        }

        private void Set_iTunes_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.BarType =
                (BarType)Enum.Parse(typeof
                (BarType),
                iTunes_UC.bars_iTunes_Bar_Type_ComboBox.SelectedItem.ToString());

            #endregion

            #region Values

            progressInput.BarBorderWidth = (int)iTunes_UC.bars_iTunes_BorderWidth_Numeric.Value;
            progressInput.BarDividersCount = (int)iTunes_UC.bars_iTunes_DividersCount_Numeric.Value;
            progressInput.BarMirrorOpacity = (int)iTunes_UC.bars_iTunes_MirrorOpacity_Numeric.Value;
            progressInput.StepSize = (int)iTunes_UC.bars_iTunes_StepSize_Numeric.Value;
            progressInput.StepInterval = (int)iTunes_UC.bars_iTunes_StepInterval_Numeric.Value;


            #endregion

            #region Colors

            progressInput.BarBackgroundDark = iTunes_UC.bars_iTunes_BackgroundDark_Btn.BackColor;
            progressInput.BarBackgroundLight = iTunes_UC.bars_iTunes_BackgroundLight_Btn.BackColor;
            progressInput.BarBorderColor = iTunes_UC.bars_iTunes_BorderColor_Btn.BackColor;
            progressInput.BarDark = iTunes_UC.bars_iTunes_BarDark_Btn.BackColor;
            progressInput.BarLight = iTunes_UC.bars_iTunes_BarLight_Btn.BackColor;


            #endregion

        }



        #region Color Events

        private void Bars_iTunes_BarLight_Btn_Click(object sender, EventArgs e)
        {
            if (iTunes_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iTunes_UC.bars_iTunes_BarLight_Btn.BackColor = iTunes_UC.colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.BarLight = iTunes_UC.colorSelector.Color;
            }
            
        }

        private void Bars_iTunes_BarDark_Btn_Click(object sender, EventArgs e)
        {
            if (iTunes_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iTunes_UC.bars_iTunes_BarDark_Btn.BackColor = iTunes_UC.colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.BarDark = iTunes_UC.colorSelector.Color;
            }
            
        }

        private void Bars_iTunes_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (iTunes_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iTunes_UC.bars_iTunes_BorderColor_Btn.BackColor = iTunes_UC.colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.BarBorderColor = iTunes_UC.colorSelector.Color;
            }
            
        }

        private void Bars_iTunes_BackgroundLight_Btn_Click(object sender, EventArgs e)
        {
            if (iTunes_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iTunes_UC.bars_iTunes_BackgroundLight_Btn.BackColor = iTunes_UC.colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.BarBackgroundLight = iTunes_UC.colorSelector.Color;
            }
            
        }

        private void Bars_iTunes_BackgroundDark_Btn_Click(object sender, EventArgs e)
        {
            if (iTunes_UC.colorSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iTunes_UC.bars_iTunes_BackgroundDark_Btn.BackColor = iTunes_UC.colorSelector.Color;
                iTunes_UC.ZeroitThematicProgress1.BarBackgroundDark = iTunes_UC.colorSelector.Color;
            }
            
        }

        #endregion

        #region Numeric Events

        private void Bars_iTunes_StepInterval_Numeric_ValueChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.StepInterval = (int)iTunes_UC.bars_iTunes_StepInterval_Numeric.Value;
        }

        private void Bars_iTunes_StepSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.StepSize = (int)iTunes_UC.bars_iTunes_StepSize_Numeric.Value;
        }

        private void Bars_iTunes_MirrorOpacity_Numeric_ValueChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.BarMirrorOpacity = (int)iTunes_UC.bars_iTunes_MirrorOpacity_Numeric.Value;
        }

        private void Bars_iTunes_DividersCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.BarDividersCount = (int)iTunes_UC.bars_iTunes_DividersCount_Numeric.Value;
        }

        private void Bars_iTunes_BorderWidth_Numeric_ValueChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.BarBorderWidth = (float)iTunes_UC.bars_iTunes_BorderWidth_Numeric.Value;
        }

        private void Bars_iTunes_Bar_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            iTunes_UC.ZeroitThematicProgress1.BarType = 
                (BarType)Enum.Parse(typeof
                (BarType),
                iTunes_UC.bars_iTunes_Bar_Type_ComboBox.SelectedItem.ToString());
        } 
        #endregion

        
        #region Preview Events

        private void Preview_iTunes_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (iTunes_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    iTunes_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    iTunes_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                iTunes_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (iTunes_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    iTunes_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    iTunes_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                iTunes_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
