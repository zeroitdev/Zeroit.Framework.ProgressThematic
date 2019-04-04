// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="ProgBar_Alter.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;


namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    /// <summary>
    /// Class ProgressDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProgressDialog
    {

        

        private void Set_Alter_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            alter_UC.Preview_Btn.Click += Preview_Alter_Btn_Click;

            #endregion

            #region Add Orientation Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string orientation in Enum.GetNames(typeof(Orientation)))
            {
                alter_UC.bars_Alter_Orientation_ComboBox.Items.Add(orientation);

            }

            for (int i = 0; i < alter_UC.bars_Alter_Orientation_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressAlter_Orientation ==
                    (Orientation)Enum.Parse(typeof
                    (Orientation),
                    alter_UC.bars_Alter_Orientation_ComboBox.Items[i].ToString()))
                {
                    alter_UC.bars_Alter_Orientation_ComboBox.SelectedIndex = i;

                    alter_UC.ZeroitThematicProgress1.ProgressAlter_Orientation = 
                        (Orientation) Enum.Parse(typeof
                        (Orientation),
                        alter_UC.bars_Alter_Orientation_ComboBox.SelectedItem.ToString());
                }
                
            }

            #endregion

            #region Value

            alter_UC.bars_Alter_ColorAngle_Numeric.Value = (decimal)progressInput.ProgressAlter_ColorAngle;

            alter_UC.ZeroitThematicProgress1.ProgressAlter_ColorAngle = progressInput.ProgressAlter_ColorAngle;
            
            #endregion

            #region Colors

            alter_UC.bars_Alter_BackColor_Btn.BackColor = progressInput.ProgressAlter_ColorBack;
            alter_UC.bars_Alter_Color1_Btn.BackColor = progressInput.ProgressAlter_Color1;
            alter_UC.bars_Alter_Color2_Btn.BackColor = progressInput.Color2;
            alter_UC.bars_Alter_Border_Btn.BackColor = progressInput.ProgressAlter_ColorBorder;
            alter_UC.bars_Alter_IC_Btn.BackColor = progressInput.ProgressAlter_ColorIC;
            alter_UC.bars_Alter_Text_Btn.BackColor = progressInput.ProgressAlter_ColorText;

            alter_UC.ZeroitThematicProgress1.ProgressAlter_ColorBack = progressInput.ProgressAlter_ColorBack;
            alter_UC.ZeroitThematicProgress1.ProgressAlter_Color1 = progressInput.ProgressAlter_Color1;
            alter_UC.ZeroitThematicProgress1.Color2 = progressInput.Color2;
            alter_UC.ZeroitThematicProgress1.ProgressAlter_ColorBorder = progressInput.ProgressAlter_ColorBorder;
            alter_UC.ZeroitThematicProgress1.ProgressAlter_ColorIC = progressInput.ProgressAlter_ColorIC;
            alter_UC.ZeroitThematicProgress1.ProgressAlter_ColorText = progressInput.ProgressAlter_ColorText;


            #endregion

            #region Bool

            if (progressInput.ShowValue)
            {
                alter_UC.bars_Alter_ShowValue_Yes_RadioBtn.Checked = true;

                alter_UC.ZeroitThematicProgress1.ShowValue = true;
            }
            else
            {
                alter_UC.bars_Alter_ShowValue_No_RadioBtn.Checked = true;

                alter_UC.ZeroitThematicProgress1.ShowValue = false;
            }


            #endregion

            #region Events

            alter_UC.bars_Alter_Orientation_ComboBox.SelectedIndexChanged += Bars_Alter_Orientation_ComboBox_SelectedIndexChanged;

            #endregion

        }

        private void Bars_Alter_Orientation_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            alter_UC.ZeroitThematicProgress1.ProgressAlter_Orientation =
                (Orientation)Enum.Parse(typeof
                (Orientation),
                alter_UC.bars_Alter_Orientation_ComboBox.SelectedItem.ToString());

        }

        private void Set_Alter_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.ProgressAlter_Orientation =
                (Orientation)Enum.Parse(typeof
                        (Orientation),
                    alter_UC.bars_Alter_Orientation_ComboBox.SelectedItem.ToString());



            #endregion
            
            #region Value

            progressInput.ProgressAlter_ColorAngle = (int)alter_UC.bars_Alter_ColorAngle_Numeric.Value;

            #endregion

            #region Colors

            progressInput.ProgressAlter_ColorBack = alter_UC.bars_Alter_BackColor_Btn.BackColor;
            progressInput.ProgressAlter_Color1 = alter_UC.bars_Alter_Color1_Btn.BackColor;
            progressInput.Color2 = alter_UC.bars_Alter_Color2_Btn.BackColor;
            progressInput.ProgressAlter_ColorBorder = alter_UC.bars_Alter_Border_Btn.BackColor;
            progressInput.ProgressAlter_ColorIC = alter_UC.bars_Alter_IC_Btn.BackColor;
            progressInput.ProgressAlter_ColorText = alter_UC.bars_Alter_Text_Btn.BackColor;
            #endregion

            #region Bool

            if (alter_UC.bars_Alter_ShowValue_Yes_RadioBtn.Checked == true)
            {
                progressInput.ShowValue = true;

                
            }
            else
            {
                progressInput.ShowValue = true;
            }


            #endregion
        }


        #region Preview Events

        private void Preview_Alter_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (alter_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    alter_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    alter_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                alter_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (alter_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    alter_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    alter_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                alter_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
