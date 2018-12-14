// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-12-2018
// ***********************************************************************
// <copyright file="Maze.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        

        private void Set_Maze_Initial_Values(ProgressInput progressInput)
        {
            #region Preview Button

            maze_UC.Preview_Btn.Click += Preview_Maze_Btn_Click;

            #endregion

            #region Add MazeStyle to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(MazeStyleType)))
            {
                maze_UC.bars_Maze_MazeStyle_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < maze_UC.bars_Maze_MazeStyle_ComboBox.Items.Count; i++)
            {
                if (progressInput.MazeStyle ==
                    (MazeStyleType)Enum.Parse(typeof
                            (MazeStyleType),
                        maze_UC.bars_Maze_MazeStyle_ComboBox.Items[i].ToString()))
                {
                    maze_UC.bars_Maze_MazeStyle_ComboBox.SelectedIndex = i;

                    maze_UC.ZeroitThematicProgress1.MazeStyle = 
                        (MazeStyleType) Enum.Parse(typeof
                        (MazeStyleType),
                        maze_UC.bars_Maze_MazeStyle_ComboBox.SelectedItem.ToString());
                }

            }

            #endregion

            #region Add Gradient to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(Maze_GradientType)))
            {
                maze_UC.bars_Maze_Gradient_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < maze_UC.bars_Maze_Gradient_ComboBox.Items.Count; i++)
            {
                if (progressInput.Gradient ==
                    (Maze_GradientType)Enum.Parse(typeof
                            (Maze_GradientType),
                        maze_UC.bars_Maze_Gradient_ComboBox.Items[i].ToString()))
                {
                    maze_UC.bars_Maze_Gradient_ComboBox.SelectedIndex = i;

                    maze_UC.ZeroitThematicProgress1.Gradient =
                        (Maze_GradientType)Enum.Parse(typeof
                        (Maze_GradientType),
                        maze_UC.bars_Maze_Gradient_ComboBox.SelectedItem.ToString());
                }

            }

            #endregion

            #region Add Style to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string barType in Enum.GetNames(typeof(ProgressBarStyle)))
            {
                maze_UC.bars_Maze_Style_ComboBox.Items.Add(barType);

            }

            for (int i = 0; i < maze_UC.bars_Maze_Style_ComboBox.Items.Count; i++)
            {
                if (progressInput.Style ==
                    (ProgressBarStyle)Enum.Parse(typeof
                            (ProgressBarStyle),
                        maze_UC.bars_Maze_Style_ComboBox.Items[i].ToString()))
                {
                    maze_UC.bars_Maze_Style_ComboBox.SelectedIndex = i;

                    maze_UC.ZeroitThematicProgress1.Style =
                        (ProgressBarStyle)Enum.Parse(typeof
                        (ProgressBarStyle),
                        maze_UC.bars_Maze_Style_ComboBox.SelectedItem.ToString());

                }

            }

            #endregion

            #region Values

            maze_UC.bars_Maze_BorderSize_Numeric.Value = progressInput.BorderSize;
            maze_UC.bars_Maze_MarqueeSpeed_Numeric.Value = (decimal)progressInput.MarqueeAnimationSpeed;
            maze_UC.bars_Maze_RowCount_Numeric.Value = progressInput.RowCount;
            maze_UC.bars_Maze_WallSize_Numeric.Value = progressInput.WallSize;

            maze_UC.ZeroitThematicProgress1.BorderSize = progressInput.BorderSize;
            maze_UC.ZeroitThematicProgress1.MarqueeAnimationSpeed = progressInput.MarqueeAnimationSpeed;
            maze_UC.ZeroitThematicProgress1.RowCount = progressInput.RowCount;
            maze_UC.ZeroitThematicProgress1.WallSize = progressInput.WallSize;

            #endregion

            #region Colors - Button

            maze_UC.bars_Maze_GradientStartColor_Btn.BackColor = progressInput.GradientStartColor;
            maze_UC.bars_Maze_GradientEndColor_Btn.BackColor = progressInput.GradientEndColor;
            maze_UC.bars_Maze_BackColor_Btn.BackColor = progressInput.Maze_BackgroundColor;
            maze_UC.bars_Maze_BorderColor_Btn.BackColor = progressInput.Maze_BorderColor;
            maze_UC.bars_Maze_SolidColor_Btn.BackColor = progressInput.Maze_SolidColor;
            maze_UC.bars_Maze_WallColor_Btn.BackColor = progressInput.WallColor;

            maze_UC.ZeroitThematicProgress1.GradientStartColor = progressInput.GradientStartColor;
            maze_UC.ZeroitThematicProgress1.GradientEndColor = progressInput.GradientEndColor;
            maze_UC.ZeroitThematicProgress1.Maze_BackgroundColor = progressInput.Maze_BackgroundColor;
            maze_UC.ZeroitThematicProgress1.Maze_BorderColor = progressInput.Maze_BorderColor;
            maze_UC.ZeroitThematicProgress1.Maze_SolidColor = progressInput.Maze_SolidColor;
            maze_UC.ZeroitThematicProgress1.WallColor = progressInput.WallColor;


            #endregion

            #region Bool

            if (progressInput.BorderGradient == true)
            {
                maze_UC.bars_Maze_BorderGrad_Yes_RadioBtn.Checked = true;

                maze_UC.ZeroitThematicProgress1.BorderGradient = true;
            }
            else
            {
                maze_UC.bars_Maze_BorderGrad_No_RadioBtn.Checked = true;

                maze_UC.ZeroitThematicProgress1.BorderGradient = false;
            }

            if (progressInput.BorderRoundCorners == true)
            {
                maze_UC.bars_Maze_RoundCorner_Yes_RadioBtn.Checked = true;

                maze_UC.ZeroitThematicProgress1.BorderRoundCorners = true;
            }
            else
            {
                maze_UC.bars_Maze_RoundCorner_No_RadioBtn.Checked = true;

                maze_UC.ZeroitThematicProgress1.BorderRoundCorners = false;
            }

            #endregion

            #region Index Changed

            maze_UC.bars_Maze_MazeStyle_ComboBox.SelectedIndexChanged += Bars_Maze_MazeStyle_ComboBox_SelectedIndexChanged;
            maze_UC.bars_Maze_Gradient_ComboBox.SelectedIndexChanged += Bars_Maze_Gradient_ComboBox_SelectedIndexChanged;
            maze_UC.bars_Maze_Style_ComboBox.SelectedIndexChanged += Bars_Maze_Style_ComboBox_SelectedIndexChanged;
            #endregion

            #region Value Changed

            maze_UC.bars_Maze_BorderSize_Numeric.ValueChanged += Bars_Maze_BorderSize_Numeric_ValueChanged;
            maze_UC.bars_Maze_MarqueeSpeed_Numeric.ValueChanged += Bars_Maze_MarqueeSpeed_Numeric_ValueChanged;
            maze_UC.bars_Maze_RowCount_Numeric.ValueChanged += Bars_Maze_RowCount_Numeric_ValueChanged;
            maze_UC.bars_Maze_WallSize_Numeric.ValueChanged += Bars_Maze_WallSize_Numeric_ValueChanged;

            #endregion

            #region Color Changed

            maze_UC.bars_Maze_GradientStartColor_Btn.Click += Bars_Maze_GradientStartColor_Btn_Click;
            maze_UC.bars_Maze_GradientEndColor_Btn.Click += Bars_Maze_GradientEndColor_Btn_Click;
            maze_UC.bars_Maze_BackColor_Btn.Click += Bars_Maze_BackColor_Btn_Click;
            maze_UC.bars_Maze_BorderColor_Btn.Click += Bars_Maze_BorderColor_Btn_Click;
            maze_UC.bars_Maze_SolidColor_Btn.Click += Bars_Maze_SolidColor_Btn_Click;
            maze_UC.bars_Maze_WallColor_Btn.Click += Bars_Maze_WallColor_Btn_Click;
            #endregion

            #region Bool - RadioButton

            maze_UC.bars_Maze_BorderGrad_Yes_RadioBtn.CheckedChanged += Bars_Maze_BorderGrad_Yes_RadioBtn_CheckedChanged;
            maze_UC.bars_Maze_RoundCorner_Yes_RadioBtn.CheckedChanged += Bars_Maze_RoundCorner_Yes_RadioBtn_CheckedChanged;
            #endregion

        }

        
        private void Set_Maze_Retrieved_Values(ProgressInput progressInput)
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

            progressInput.MazeStyle = 
                (MazeStyleType)Enum.Parse(typeof
                (MazeStyleType),
                maze_UC.bars_Maze_MazeStyle_ComboBox.SelectedItem.ToString());

            progressInput.Gradient = 
                (Maze_GradientType)Enum.Parse(typeof
                (Maze_GradientType),
                maze_UC.bars_Maze_Gradient_ComboBox.SelectedItem.ToString());

            progressInput.Style =
                (ProgressBarStyle)Enum.Parse(typeof
                (ProgressBarStyle),
                maze_UC.bars_Maze_Style_ComboBox.SelectedItem.ToString()); 

            #endregion

            #region Values

            progressInput.BorderSize = (int)maze_UC.bars_Maze_BorderSize_Numeric.Value;
            progressInput.MarqueeAnimationSpeed = (int)maze_UC.bars_Maze_MarqueeSpeed_Numeric.Value;
            progressInput.RowCount = (int)maze_UC.bars_Maze_RowCount_Numeric.Value;
            progressInput.WallSize = (int)maze_UC.bars_Maze_WallSize_Numeric.Value;

            #endregion

            #region Color

            progressInput.GradientStartColor = maze_UC.bars_Maze_GradientStartColor_Btn.BackColor;
            progressInput.GradientEndColor = maze_UC.bars_Maze_GradientEndColor_Btn.BackColor;
            progressInput.Maze_BackgroundColor = maze_UC.bars_Maze_BackColor_Btn.BackColor;
            progressInput.Maze_BorderColor = maze_UC.bars_Maze_BorderColor_Btn.BackColor;
            progressInput.Maze_SolidColor = maze_UC.bars_Maze_SolidColor_Btn.BackColor;
            progressInput.WallColor = maze_UC.bars_Maze_WallColor_Btn.BackColor;

            #endregion

            #region Bool

            if (maze_UC.bars_Maze_BorderGrad_Yes_RadioBtn.Checked == true)
            {
                progressInput.BorderGradient = true;
                
            }

            else
            {
                progressInput.BorderGradient = false;
            }

            if (maze_UC.bars_Maze_RoundCorner_Yes_RadioBtn.Checked == true)
            {
                progressInput.BorderRoundCorners = true;
                
            }

            else
            {
                progressInput.BorderRoundCorners = false;
            }

            #endregion

        }



        #region Bool Events

        private void Bars_Maze_RoundCorner_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maze_UC.bars_Maze_RoundCorner_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.BorderRoundCorners = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.BorderRoundCorners = false;
            }
        }

        private void Bars_Maze_BorderGrad_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maze_UC.bars_Maze_BorderGrad_Yes_RadioBtn.Checked == true)
            {
                maze_UC.ZeroitThematicProgress1.BorderGradient = true;
            }
            else
            {
                maze_UC.ZeroitThematicProgress1.BorderGradient = false;
            }
        }

        #endregion

        #region Color - Click Events

        private void Bars_Maze_BackColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_BackColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.Maze_BackgroundColor = maze_UC.colorSelector.Color;

            }
        }


        private void Bars_Maze_WallColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_WallColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.WallColor = maze_UC.colorSelector.Color;

            }
        }

        private void Bars_Maze_SolidColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_SolidColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.Maze_SolidColor = maze_UC.colorSelector.Color;

            }
        }

        private void Bars_Maze_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_BorderColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.Maze_BorderColor = maze_UC.colorSelector.Color;

            }
        }

        private void Bars_Maze_GradientEndColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_GradientEndColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.GradientEndColor = maze_UC.colorSelector.Color;

            }
        }

        private void Bars_Maze_GradientStartColor_Btn_Click(object sender, EventArgs e)
        {
            if (maze_UC.colorSelector.ShowDialog() == DialogResult.OK)
            {
                maze_UC.bars_Maze_GradientStartColor_Btn.BackColor = maze_UC.colorSelector.Color;
                maze_UC.ZeroitThematicProgress1.GradientStartColor = maze_UC.colorSelector.Color;

            }

        }

        #endregion

        #region Numeric Events
        private void Bars_Maze_WallSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.WallSize = (int)maze_UC.bars_Maze_WallSize_Numeric.Value;

        }

        private void Bars_Maze_RowCount_Numeric_ValueChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.RowCount = (int)maze_UC.bars_Maze_RowCount_Numeric.Value;

        }

        private void Bars_Maze_MarqueeSpeed_Numeric_ValueChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.MarqueeAnimationSpeed = (int)maze_UC.bars_Maze_MarqueeSpeed_Numeric.Value;

        }

        private void Bars_Maze_BorderSize_Numeric_ValueChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.BorderSize = (int)maze_UC.bars_Maze_BorderSize_Numeric.Value;

        }

        #endregion

        #region ComboBox Events
        private void Bars_Maze_Style_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.Style =
                (ProgressBarStyle)Enum.Parse(typeof
                        (ProgressBarStyle),
                    maze_UC.bars_Maze_Style_ComboBox.SelectedItem.ToString());
        }

        private void Bars_Maze_Gradient_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.Gradient =
                (Maze_GradientType)Enum.Parse(typeof
                        (Maze_GradientType),
                    maze_UC.bars_Maze_Gradient_ComboBox.SelectedItem.ToString());
        }

        private void Bars_Maze_MazeStyle_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maze_UC.ZeroitThematicProgress1.MazeStyle =
                (MazeStyleType)Enum.Parse(typeof
                (MazeStyleType),
                maze_UC.bars_Maze_MazeStyle_ComboBox.SelectedItem.ToString());



        }

        #endregion

        

        
        #region Preview Events

        private void Preview_Maze_Btn_Click(object sender, EventArgs e)
        {
            
            if (mainControl_AutoAnimate_Yes_RadioBtn.Checked)
            {

                if (maze_UC.ZeroitThematicProgress1.AutoAnimate == true)
                {
                    maze_UC.ZeroitThematicProgress1.AutoAnimate = false;

                }
                else
                {
                    maze_UC.ZeroitThematicProgress1.AutoAnimate = true;

                }


            }
            else
            {

                maze_UC.ZeroitThematicProgress1.AutoAnimate = false;
            }

            if (mainControl_AutoIncrement_Yes_RadioBtn.Checked)
            {
                
                if (maze_UC.ZeroitThematicProgress1.AutoIncrement == true)
                {
                    maze_UC.ZeroitThematicProgress1.AutoIncrement = false;

                }
                else
                {
                    maze_UC.ZeroitThematicProgress1.AutoIncrement = true;

                }

            }
            else
            {
                maze_UC.ZeroitThematicProgress1.AutoIncrement = false;
            }

        }

        #endregion

    }
}
