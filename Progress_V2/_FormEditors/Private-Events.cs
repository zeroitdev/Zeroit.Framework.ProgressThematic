// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Private-Events.cs" company="Zeroit Dev Technologies">
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

        private void Set_InitialValues(ProgressInput progressInput)
        {
            
            #region Add ProgressType to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressType in Enum.GetNames(typeof(ProgressType)))
            {
                mainControl_ProgressType_ComboBox.Items.Add(progressType);

            }

            for (int i = 0; i < mainControl_ProgressType_ComboBox.Items.Count; i++)
            {
                if (progressInput.ProgressType == 
                    (ProgressType)Enum.Parse
                    (typeof(ProgressType), 
                    mainControl_ProgressType_ComboBox.Items[i].ToString())
                    )
                {
                    mainControl_ProgressType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add CircularType to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            //foreach (string circularType in Enum.GetNames(typeof(CircularProgress)))
            //{
            //    mainControl_CircularProgress_ComboBox.Items.Add(circularType);

            //}

            //for (int i = 0; i < mainControl_CircularProgress_ComboBox.Items.Count; i++)
            //{
            //    if (progressInput.CircularProgressType ==
            //        (CircularProgress)Enum.Parse
            //        (typeof(CircularProgress),
            //            mainControl_CircularProgress_ComboBox.Items[i].ToString())
            //    )
            //    {
            //        mainControl_CircularProgress_ComboBox.SelectedIndex = i;

            //    }

            //}
            #endregion

            #region Add SolidProgressType to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string progressbar in Enum.GetNames(typeof(ProgressBar)))
            {
                mainControl_BarProgress_ComboBox.Items.Add(progressbar);

            }

            for (int i = 0; i < mainControl_BarProgress_ComboBox.Items.Count; i++)
            {
                if (progressInput.SolidProgressBar ==
                    (ProgressBar)Enum.Parse
                    (typeof(ProgressBar),
                        mainControl_BarProgress_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_BarProgress_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add ProgressIndicatorType to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            //foreach (string indicatorType in Enum.GetNames(typeof(ProgressIndicator)))
            //{
            //    mainControl_IndicatorProgress_ComboBox.Items.Add(indicatorType);

            //}

            //for (int i = 0; i < mainControl_IndicatorProgress_ComboBox.Items.Count; i++)
            //{
            //    if (progressInput.ProgressIndicatorType ==
            //        (ProgressIndicator)Enum.Parse
            //        (typeof(ProgressIndicator),
            //            mainControl_IndicatorProgress_ComboBox.Items[i].ToString())
            //    )
            //    {
            //        mainControl_IndicatorProgress_ComboBox.SelectedIndex = i;

            //    }

            //}
            #endregion

            #region Add SmoothingMode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(SmoothingMode)))
            {
                mainControl_Smoothing_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < mainControl_Smoothing_ComboBox.Items.Count; i++)
            {
                if (progressInput.Smoothing ==
                    (SmoothingMode)Enum.Parse
                    (typeof(SmoothingMode),
                        mainControl_Smoothing_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_Smoothing_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add TextRendering to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(TextRenderingHint)))
            {
                mainControl_TextRendering_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < mainControl_TextRendering_ComboBox.Items.Count; i++)
            {
                if (progressInput.TextRendering ==
                    (TextRenderingHint)Enum.Parse
                    (typeof(TextRenderingHint),
                        mainControl_TextRendering_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_TextRendering_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add PeaceAnimator Easing to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string indicatorType in Enum.GetNames(typeof(PeaceAnimatorEasing)))
            {
                mainControl_IncrementEasing_ComboBox.Items.Add(indicatorType);

            }

            for (int i = 0; i < mainControl_IncrementEasing_ComboBox.Items.Count; i++)
            {
                if (progressInput.EasingType ==
                    (PeaceAnimatorEasing)Enum.Parse
                    (typeof(PeaceAnimatorEasing),
                        mainControl_IncrementEasing_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_IncrementEasing_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add Transparent Easing to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string transparentEasing in Enum.GetNames(typeof(transparencyEasingType)))
            {
                mainControl_TransparentEasing_ComboBox.Items.Add(transparentEasing);

            }

            for (int i = 0; i < mainControl_TransparentEasing_ComboBox.Items.Count; i++)
            {
                if (progressInput.TransparentEasing ==
                    (transparencyEasingType)Enum.Parse
                    (typeof(transparencyEasingType),
                        mainControl_TransparentEasing_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_TransparentEasing_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add Hatch Type to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string hatchType in Enum.GetNames(typeof(ZeroitThematicProgress.HatchBrushType)))
            {
                mainControl_HatchType_ComboBox.Items.Add(hatchType);

            }

            for (int i = 0; i < mainControl_HatchType_ComboBox.Items.Count; i++)
            {
                if (progressInput.HatchBrush ==
                    (ZeroitThematicProgress.HatchBrushType)Enum.Parse
                    (typeof(ZeroitThematicProgress.HatchBrushType),
                        mainControl_HatchType_ComboBox.Items[i].ToString())
                )
                {
                    mainControl_HatchType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Auto Animate

            if (progressInput.AutoAnimate == true)
            {
                mainControl_AutoAnimate_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_AutoAnimate_No_RadioBtn.Checked = true;
            }

            #endregion

            #region Auto Increment

            if (progressInput.AutoIncrement == true)
            {
                mainControl_AutoIncrement_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_AutoIncrement_No_RadioBtn.Checked = true;
            }

            #endregion

            #region Animate Start Angle

            if (progressInput.AnimateStartAngle == true)
            {
                mainControl_AnimateStartAngle_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_AnimateStartAngle_No_RadioBtn.Checked = true;
            }

            #endregion

            #region Show Text

            if (progressInput.ShowText == true)
            {
                mainControl_ShowText_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_ShowText_No_RadioBtn.Checked = true;
            }

            #endregion

            #region Fixed Size

            if (progressInput.FixedSize == true)
            {
                mainControl_FixedSize_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_FixedSize_No_RadioBtn.Checked = true;
            }

            #endregion

            #region PostFix

            mainControl_PostFix_TextBox.Text = progressInput.PostFix;

            #endregion

            #region Hatch Colors

            mainControl_HatchColor1_Btn.BackColor = progressInput.ColorHatchBrushgradient1;

            mainControl_HatchColor2_Btn.BackColor = progressInput.ColorHatchBrushgradient2;

            #endregion

            #region Minimum

            mainControl_Minimum_Numeric.Value = (decimal)progressInput.Minimum;

            #endregion

            #region Maximum

            mainControl_Maximum_Numeric.Value = (decimal)progressInput.Maximum;

            #endregion

            #region Duration

            mainControl_AI_Duration_Numeric.Value = (decimal)progressInput.AnimationSpeed[2];

            #endregion

            #region Speed

            mainControl_AA_Speed_Numeric.Value = (decimal)progressInput.AnimationSpeed[0];

            #endregion

            #region Interval

            mainControl_ASA_Interval_Numeric.Value = (decimal)progressInput.AnimationSpeed[1];

            #endregion
            
            #region Starting Angle

            mainControl_StartingAngle_Numeric.Value = (decimal)progressInput.StartingAngle;

            #endregion

            #region Values



            #endregion

            #region Show Text

            if (progressInput.AllowTransparency == true)
            {
                mainControl_Transparency_Yes_RadioBtn.Checked = true;
            }
            else
            {
                mainControl_Transparency_No_RadioBtn.Checked = true;
            }
            #endregion  
        }

    }
}
