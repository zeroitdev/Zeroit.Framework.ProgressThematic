﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-30-2018
// ***********************************************************************
// <copyright file="WinHorizontal_UC.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    partial class WinHorizontal_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Preview_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.indicator_Win8Horiz_RefreshRate_Numeric = new System.Windows.Forms.NumericUpDown();
            this.bars_Extended_GroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.indicator_Win8Horiz_Animate_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.indicator_Win8Horiz_ControlWidth_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.indicator_Win8Horiz_IndicatorColor_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorSelector = new System.Windows.Forms.ColorDialog();
            this.ZeroitThematicProgress1 = new Zeroit.Framework.ProgressThematic.ZeroitThematicProgress();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_Win8Horiz_RefreshRate_Numeric)).BeginInit();
            this.bars_Extended_GroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_Win8Horiz_ControlWidth_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Preview_Btn
            // 
            this.Preview_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Preview_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preview_Btn.FlatAppearance.BorderSize = 0;
            this.Preview_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Preview_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Preview_Btn.Location = new System.Drawing.Point(547, 15);
            this.Preview_Btn.Name = "Preview_Btn";
            this.Preview_Btn.Size = new System.Drawing.Size(105, 43);
            this.Preview_Btn.TabIndex = 110;
            this.Preview_Btn.Text = "Preview";
            this.Preview_Btn.UseVisualStyleBackColor = false;
            this.Preview_Btn.MouseEnter += new System.EventHandler(this.Preview_Btn_MouseEnter);
            this.Preview_Btn.MouseLeave += new System.EventHandler(this.Preview_Btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 38);
            this.label1.TabIndex = 219;
            this.label1.Text = "Refresh\r\nRate";
            // 
            // indicator_Win8Horiz_RefreshRate_Numeric
            // 
            this.indicator_Win8Horiz_RefreshRate_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.indicator_Win8Horiz_RefreshRate_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator_Win8Horiz_RefreshRate_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.indicator_Win8Horiz_RefreshRate_Numeric.Location = new System.Drawing.Point(69, 128);
            this.indicator_Win8Horiz_RefreshRate_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.indicator_Win8Horiz_RefreshRate_Numeric.Name = "indicator_Win8Horiz_RefreshRate_Numeric";
            this.indicator_Win8Horiz_RefreshRate_Numeric.Size = new System.Drawing.Size(70, 29);
            this.indicator_Win8Horiz_RefreshRate_Numeric.TabIndex = 220;
            this.indicator_Win8Horiz_RefreshRate_Numeric.ValueChanged += new System.EventHandler(this.indicator_Win8Horiz_RefreshRate_Numeric_ValueChanged);
            // 
            // bars_Extended_GroupBox
            // 
            this.bars_Extended_GroupBox.Controls.Add(this.panel1);
            this.bars_Extended_GroupBox.Controls.Add(this.label7);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_Win8Horiz_ControlWidth_Numeric);
            this.bars_Extended_GroupBox.Controls.Add(this.label2);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_Win8Horiz_IndicatorColor_Btn);
            this.bars_Extended_GroupBox.Controls.Add(this.label6);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_Win8Horiz_RefreshRate_Numeric);
            this.bars_Extended_GroupBox.Controls.Add(this.label1);
            this.bars_Extended_GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bars_Extended_GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bars_Extended_GroupBox.Location = new System.Drawing.Point(3, 5);
            this.bars_Extended_GroupBox.Name = "bars_Extended_GroupBox";
            this.bars_Extended_GroupBox.Size = new System.Drawing.Size(502, 167);
            this.bars_Extended_GroupBox.TabIndex = 112;
            this.bars_Extended_GroupBox.TabStop = false;
            this.bars_Extended_GroupBox.Text = "Win8 Horizontal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.indicator_Win8Horiz_Animate_Yes_RadioBtn);
            this.panel1.Controls.Add(this.indicator_Win8Horiz_Animate_No_RadioBtn);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel1.Location = new System.Drawing.Point(390, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 38);
            this.panel1.TabIndex = 254;
            // 
            // indicator_Win8Horiz_Animate_Yes_RadioBtn
            // 
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.AutoSize = true;
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.Checked = true;
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.Location = new System.Drawing.Point(6, 6);
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.Name = "indicator_Win8Horiz_Animate_Yes_RadioBtn";
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.Size = new System.Drawing.Size(47, 23);
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.TabIndex = 113;
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.TabStop = true;
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.Text = "Yes";
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.UseVisualStyleBackColor = true;
            this.indicator_Win8Horiz_Animate_Yes_RadioBtn.CheckedChanged += new System.EventHandler(this.indicator_Win8Horiz_Animate_Yes_RadioBtn_CheckedChanged);
            // 
            // indicator_Win8Horiz_Animate_No_RadioBtn
            // 
            this.indicator_Win8Horiz_Animate_No_RadioBtn.AutoSize = true;
            this.indicator_Win8Horiz_Animate_No_RadioBtn.Location = new System.Drawing.Point(54, 6);
            this.indicator_Win8Horiz_Animate_No_RadioBtn.Name = "indicator_Win8Horiz_Animate_No_RadioBtn";
            this.indicator_Win8Horiz_Animate_No_RadioBtn.Size = new System.Drawing.Size(45, 23);
            this.indicator_Win8Horiz_Animate_No_RadioBtn.TabIndex = 114;
            this.indicator_Win8Horiz_Animate_No_RadioBtn.Text = "No";
            this.indicator_Win8Horiz_Animate_No_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(322, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 253;
            this.label7.Text = "Animate";
            // 
            // indicator_Win8Horiz_ControlWidth_Numeric
            // 
            this.indicator_Win8Horiz_ControlWidth_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.indicator_Win8Horiz_ControlWidth_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator_Win8Horiz_ControlWidth_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.indicator_Win8Horiz_ControlWidth_Numeric.Location = new System.Drawing.Point(69, 59);
            this.indicator_Win8Horiz_ControlWidth_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.indicator_Win8Horiz_ControlWidth_Numeric.Name = "indicator_Win8Horiz_ControlWidth_Numeric";
            this.indicator_Win8Horiz_ControlWidth_Numeric.Size = new System.Drawing.Size(70, 29);
            this.indicator_Win8Horiz_ControlWidth_Numeric.TabIndex = 248;
            this.indicator_Win8Horiz_ControlWidth_Numeric.ValueChanged += new System.EventHandler(this.indicator_Win8Horiz_ControlWidth_Numeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 38);
            this.label2.TabIndex = 247;
            this.label2.Text = "Control \r\nWidth";
            // 
            // indicator_Win8Horiz_IndicatorColor_Btn
            // 
            this.indicator_Win8Horiz_IndicatorColor_Btn.BackColor = System.Drawing.Color.Black;
            this.indicator_Win8Horiz_IndicatorColor_Btn.FlatAppearance.BorderSize = 0;
            this.indicator_Win8Horiz_IndicatorColor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicator_Win8Horiz_IndicatorColor_Btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.indicator_Win8Horiz_IndicatorColor_Btn.Location = new System.Drawing.Point(233, 57);
            this.indicator_Win8Horiz_IndicatorColor_Btn.Name = "indicator_Win8Horiz_IndicatorColor_Btn";
            this.indicator_Win8Horiz_IndicatorColor_Btn.Size = new System.Drawing.Size(66, 30);
            this.indicator_Win8Horiz_IndicatorColor_Btn.TabIndex = 241;
            this.indicator_Win8Horiz_IndicatorColor_Btn.UseVisualStyleBackColor = false;
            this.indicator_Win8Horiz_IndicatorColor_Btn.Click += new System.EventHandler(this.indicator_Win8Horiz_IndicatorColor_Btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(158, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 38);
            this.label6.TabIndex = 240;
            this.label6.Text = "Indicator \r\nColor";
            // 
            // ZeroitThematicProgress1
            // 
            this.ZeroitThematicProgress1.AllowTransparency = false;
            this.ZeroitThematicProgress1.Angle = 90F;
            this.ZeroitThematicProgress1.Animate_Indeterminate = false;
            this.ZeroitThematicProgress1.AnimateStartAngle = false;
            this.ZeroitThematicProgress1.AnimationFunction = Zeroit.Framework.ProgressThematic.AnimationHelpers.WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ZeroitThematicProgress1.AnimationSpeed = new int[] {
        1000,
        100,
        5000};
            this.ZeroitThematicProgress1.AutoAnimate = false;
            this.ZeroitThematicProgress1.AutoIncrement = false;
            this.ZeroitThematicProgress1.AutoIncrementFrequency = 100D;
            this.ZeroitThematicProgress1.Automate = false;
            this.ZeroitThematicProgress1.AutoSpinStartInterval = 100;
            this.ZeroitThematicProgress1.AutoStartSpinner = false;
            this.ZeroitThematicProgress1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.Bar1.ActiveColor = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.Bar1.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Bar1.Enabled = true;
            this.ZeroitThematicProgress1.Bar1.FinishColor = System.Drawing.Color.LightGreen;
            this.ZeroitThematicProgress1.Bar1.InactiveColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.Bar2.ActiveColor = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.Bar2.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Bar2.FinishColor = System.Drawing.Color.LightGreen;
            this.ZeroitThematicProgress1.Bar2.InactiveColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.Bar3.ActiveColor = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.Bar3.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Bar3.FinishColor = System.Drawing.Color.LightGreen;
            this.ZeroitThematicProgress1.Bar3.InactiveColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.Bar4.ActiveColor = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.Bar4.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Bar4.FinishColor = System.Drawing.Color.LightGreen;
            this.ZeroitThematicProgress1.Bar4.InactiveColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.Bar5.ActiveColor = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.Bar5.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Bar5.FinishColor = System.Drawing.Color.LightGreen;
            this.ZeroitThematicProgress1.Bar5.InactiveColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.BarBackgroundDark = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(201)))));
            this.ZeroitThematicProgress1.BarBackgroundLight = System.Drawing.Color.WhiteSmoke;
            this.ZeroitThematicProgress1.BarBorderColor = System.Drawing.Color.DarkGray;
            this.ZeroitThematicProgress1.BarBorderWidth = 1.25F;
            this.ZeroitThematicProgress1.BarDark = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(68)))), ((int)(((byte)(202)))));
            this.ZeroitThematicProgress1.BarLight = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(144)))), ((int)(((byte)(252)))));
            this.ZeroitThematicProgress1.BarMirrorOpacity = 40F;
            this.ZeroitThematicProgress1.BarOffset = 1;
            this.ZeroitThematicProgress1.BarType = Zeroit.Framework.ProgressThematic.BarType.Static;
            this.ZeroitThematicProgress1.Border = 10;
            this.ZeroitThematicProgress1.BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.BorderGradient = false;
            this.ZeroitThematicProgress1.BorderRoundCorners = false;
            this.ZeroitThematicProgress1.BorderSize = 0;
            this.ZeroitThematicProgress1.BorderType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.BorderTypes.Single;
            this.ZeroitThematicProgress1.Caption = "%";
            this.ZeroitThematicProgress1.CaptionColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.CaptionMode = Zeroit.Framework.ProgressThematic.ProgressCaptionMode.Percent;
            this.ZeroitThematicProgress1.CaptionShadowColor = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.ChangeByMouse = false;
            this.ZeroitThematicProgress1.Color = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Color1_Progress = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ZeroitThematicProgress1.Color1Bigcircle = System.Drawing.Color.Red;
            this.ZeroitThematicProgress1.Color1Indicator = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZeroitThematicProgress1.Color2_Progress = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ZeroitThematicProgress1.Color2Bigcircle = System.Drawing.Color.Yellow;
            this.ZeroitThematicProgress1.Color2Indicator = System.Drawing.Color.DarkBlue;
            this.ZeroitThematicProgress1.Color3_FillEllipse = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Color4_FillEllipse = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.Color5_ProgressInnerBorder = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.Color6_TextColor = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.ColorAngle = 90F;
            this.ZeroitThematicProgress1.ColorGradientAngle = 90F;
            this.ZeroitThematicProgress1.ColorHatchBrushgradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ZeroitThematicProgress1.ColorHatchBrushgradient2 = System.Drawing.Color.DeepPink;
            this.ZeroitThematicProgress1.ColorInnerBorder = System.Drawing.Color.DarkBlue;
            this.ZeroitThematicProgress1.ColorInnerCircle1Grad1 = System.Drawing.Color.Red;
            this.ZeroitThematicProgress1.ColorInnerCircle1Grad2 = System.Drawing.Color.Green;
            this.ZeroitThematicProgress1.ColorInnerCircle2Grad1 = System.Drawing.Color.Yellow;
            this.ZeroitThematicProgress1.ColorInnerCircle2Grad2 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.ColorInnerCircle3Grad1 = System.Drawing.Color.Brown;
            this.ZeroitThematicProgress1.ColorInnerCircle3Grad2 = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.ColorInnerCircle4Grad1 = System.Drawing.Color.RosyBrown;
            this.ZeroitThematicProgress1.ColorInnerCircle4Grad2 = System.Drawing.Color.LightBlue;
            this.ZeroitThematicProgress1.ColorInnerCircle5Grad1 = System.Drawing.Color.Violet;
            this.ZeroitThematicProgress1.ColorInnerCircle5Grad2 = System.Drawing.Color.LightPink;
            this.ZeroitThematicProgress1.ColorInnerCircle6Grad1 = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.ColorInnerCircle6Grad2 = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.ColorOuterBorder = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.ColorProgress = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.Control_Width = 198;
            this.ZeroitThematicProgress1.ControlSize = 20;
            this.ZeroitThematicProgress1.CPv2_AngleReduced = 90;
            this.ZeroitThematicProgress1.CPv2_Color = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.CPv2_ColorEmpty = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.CPv2_ProgressWidth = 2;
            this.ZeroitThematicProgress1.CPv2_Shift = 0;
            this.ZeroitThematicProgress1.CPv2_ShowText = true;
            this.ZeroitThematicProgress1.CPv2_StartAngle = 80;
            this.ZeroitThematicProgress1.CPv3_Color = System.Drawing.Color.LightSeaGreen;
            this.ZeroitThematicProgress1.CPv3_ColorEmpty = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.CPv3_ProgressWidth = 2;
            this.ZeroitThematicProgress1.CPv3_Shift = 0;
            this.ZeroitThematicProgress1.CPv3_ShowText = true;
            this.ZeroitThematicProgress1.CPv3_StartAngle = -90;
            this.ZeroitThematicProgress1.CPv4_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.CPv4_FillEllipse = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Black};
            this.ZeroitThematicProgress1.CPv4_GradientAngle = 90F;
            this.ZeroitThematicProgress1.CPv4_InnerBorder = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.CPv4_InnerBorderThickness = 1;
            this.ZeroitThematicProgress1.CPv4_OuterBorder = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.CPv4_OuterBorderThickness = 1;
            this.ZeroitThematicProgress1.CPv4_ProgressBackGrad1 = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.CPv4_ProgressBackGrad2 = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.CPv4_ProgressGrad1 = System.Drawing.Color.DarkSlateGray;
            this.ZeroitThematicProgress1.CPv4_ProgressGrad2 = System.Drawing.Color.Orange;
            this.ZeroitThematicProgress1.CPv4_Speed = 100;
            this.ZeroitThematicProgress1.CPv4_StartAngle = -90;
            this.ZeroitThematicProgress1.CPv4_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.CPv4_Thickness = 20;
            this.ZeroitThematicProgress1.CPv5_Interval = 100;
            this.ZeroitThematicProgress1.CPv5_MinimumSize = new System.Drawing.Size(28, 28);
            this.ZeroitThematicProgress1.CPv5_OuterSpeed = 10;
            this.ZeroitThematicProgress1.CPv5_Reset = false;
            this.ZeroitThematicProgress1.CPv5_Text = "ZeroitThematicProgress1";
            this.ZeroitThematicProgress1.CustomFadeColor = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.DashSpace = 2;
            this.ZeroitThematicProgress1.DashWidth = 5;
            this.ZeroitThematicProgress1.DisplayProgress = false;
            this.ZeroitThematicProgress1.DrawMode = Zeroit.Framework.ProgressThematic.drawMode.Solid;
            this.ZeroitThematicProgress1.EasingType = Zeroit.Framework.ProgressThematic.PeaceAnimatorEasing.BounceEaseIn;
            this.ZeroitThematicProgress1.Edge = Zeroit.Framework.ProgressThematic.ProgressBarEdge.Rounded;
            this.ZeroitThematicProgress1.EdgeColor = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.EdgeLightColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.EdgeWidth = 1;
            this.ZeroitThematicProgress1.EnableInnerCover = false;
            this.ZeroitThematicProgress1.ExtendedProgress_Minimum = 0;
            this.ZeroitThematicProgress1.ExtendedProgress_Shadow = true;
            this.ZeroitThematicProgress1.ExtendedProgress_Step = 1;
            this.ZeroitThematicProgress1.ExtendedProgress_TimerInterval = 100;
            this.ZeroitThematicProgress1.FillPie = false;
            this.ZeroitThematicProgress1.FillTransparency = 255;
            this.ZeroitThematicProgress1.FixedSize = false;
            this.ZeroitThematicProgress1.FloodPercentage = 0.2F;
            this.ZeroitThematicProgress1.FloodStyle = Zeroit.Framework.ProgressThematic.ProgressFloodStyle.Standard;
            this.ZeroitThematicProgress1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.ZeroitThematicProgress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZeroitThematicProgress1.Glow = false;
            this.ZeroitThematicProgress1.GoogleProgress_BackgroundColor = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.GoogleProgress_RefreshRate = 100;
            this.ZeroitThematicProgress1.GorgeousDrawMode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Gorgeous_drawMode.Solid;
            this.ZeroitThematicProgress1.Gradient = Zeroit.Framework.ProgressThematic.Maze_GradientType.None;
            this.ZeroitThematicProgress1.GradientColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(84))))),
        System.Drawing.Color.DarkSlateGray};
            this.ZeroitThematicProgress1.GradientEndColor = System.Drawing.Color.Lime;
            this.ZeroitThematicProgress1.GradientPercent = 20;
            this.ZeroitThematicProgress1.GradientStartColor = System.Drawing.Color.PaleGreen;
            this.ZeroitThematicProgress1.GradientType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.GradientTypes.FullWidthGradient;
            this.ZeroitThematicProgress1.GraphWidth = 145F;
            this.ZeroitThematicProgress1.HatchBrush = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.HatchBrushType.ForwardDiagonal;
            this.ZeroitThematicProgress1.HeartBeat = false;
            this.ZeroitThematicProgress1.HeartTimerInterval = 100;
            this.ZeroitThematicProgress1.IG_BorderStyleInner = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ZeroitThematicProgress1.IG_BorderStyleOuter = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.ZeroitThematicProgress1.IG_Caps = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.IG_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(212)))), ((int)(((byte)(204))))),
        System.Drawing.Color.Gray,
        System.Drawing.Color.Black,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.Black,
        System.Drawing.Color.Green,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray,
        System.Drawing.Color.LightGray};
            this.ZeroitThematicProgress1.IG_DrawMode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Ignito_drawMode.Solid;
            this.ZeroitThematicProgress1.IG_EnableHatch = false;
            this.ZeroitThematicProgress1.IG_GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Azure,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.Orange};
            this.ZeroitThematicProgress1.IG_InnerBorder = 1F;
            this.ZeroitThematicProgress1.IG_InnerRotatingAnlge = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Ignito_innerRotatingAngle.AntiClockwise;
            this.ZeroitThematicProgress1.IG_OuterBorder = 1F;
            this.ZeroitThematicProgress1.IG_OutterRotatingAngle = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Ignito_outterRotatingAngle.Clockwise;
            this.ZeroitThematicProgress1.Image = null;
            this.ZeroitThematicProgress1.ImageEnabled = false;
            this.ZeroitThematicProgress1.Info = "ZeroitThematicProgress1";
            this.ZeroitThematicProgress1.InnerBorder = 1;
            this.ZeroitThematicProgress1.Innercircle1HeightReduction = 10;
            this.ZeroitThematicProgress1.Innercircle1WidthReduction = 10;
            this.ZeroitThematicProgress1.Innercircle2HeightReduction = 20;
            this.ZeroitThematicProgress1.Innercircle2WidthReduction = 20;
            this.ZeroitThematicProgress1.Innercircle3HeightReduction = 40;
            this.ZeroitThematicProgress1.Innercircle3WidthReduction = 40;
            this.ZeroitThematicProgress1.Innercircle4HeightReduction = 60;
            this.ZeroitThematicProgress1.Innercircle4WidthReduction = 60;
            this.ZeroitThematicProgress1.Innercircle5HeightReduction = 80;
            this.ZeroitThematicProgress1.Innercircle5WidthReduction = 80;
            this.ZeroitThematicProgress1.Innercircle6HeightReduction = 100;
            this.ZeroitThematicProgress1.Innercircle6WidthReduction = 100;
            this.ZeroitThematicProgress1.InnerCircleBorder = 10;
            this.ZeroitThematicProgress1.InnerCircleRadius = 5;
            this.ZeroitThematicProgress1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ZeroitThematicProgress1.InnerGridType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.ProgressBarBoxed_InnerGridTypes.Full;
            this.ZeroitThematicProgress1.InnerMargin = 2;
            this.ZeroitThematicProgress1.InnerRadius = 20;
            this.ZeroitThematicProgress1.InnerWidth = -1;
            this.ZeroitThematicProgress1.InterpolateColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.ZeroitThematicProgress1.Invert = false;
            this.ZeroitThematicProgress1.LineColor1 = System.Drawing.Color.Yellow;
            this.ZeroitThematicProgress1.LineColor2 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.LineSize = 1;
            this.ZeroitThematicProgress1.Location = new System.Drawing.Point(509, 70);
            this.ZeroitThematicProgress1.MacOSX_Automatic = Zeroit.Framework.ProgressThematic.MacOSX_automatic.Start;
            this.ZeroitThematicProgress1.MacOSX_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_Interval = 60;
            this.ZeroitThematicProgress1.MacOSX_Matrix_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_Matrix_Interval = 60;
            this.ZeroitThematicProgress1.MacOSX_Matrix_Rotation = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.MacOSX_Direction.CLOCKWISE;
            this.ZeroitThematicProgress1.MacOSX_Matrix_SpokesCount = 100;
            this.ZeroitThematicProgress1.MacOSX_Matrix_StartAngle = 270F;
            this.ZeroitThematicProgress1.MacOSX_Matrix_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_Matrix_TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ZeroitThematicProgress1.MacOSX_Optimized_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_Optimized_Interval = 60;
            this.ZeroitThematicProgress1.MacOSX_Optimized_Rotation = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.MacOSX_Direction.CLOCKWISE;
            this.ZeroitThematicProgress1.MacOSX_Optimized_SpokesCount = 100;
            this.ZeroitThematicProgress1.MacOSX_Optimized_StartAngle = 30F;
            this.ZeroitThematicProgress1.MacOSX_Optimized_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_Optimized_TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ZeroitThematicProgress1.MacOSX_Rotation = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.MacOSX_Direction.CLOCKWISE;
            this.ZeroitThematicProgress1.MacOSX_SpokesCount = 100;
            this.ZeroitThematicProgress1.MacOSX_StartAngle = 270;
            this.ZeroitThematicProgress1.MacOSX_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MacOSX_TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ZeroitThematicProgress1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.ZeroitThematicProgress1.Marquee = false;
            this.ZeroitThematicProgress1.MarqueeAnimationSpeed = 2000F;
            this.ZeroitThematicProgress1.MarqueeSpeed = 100;
            this.ZeroitThematicProgress1.Maximum = 100F;
            this.ZeroitThematicProgress1.Maze_BackgroundColor = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.Maze_BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Maze_SolidColor = System.Drawing.SystemColors.Highlight;
            this.ZeroitThematicProgress1.MazeStyle = Zeroit.Framework.ProgressThematic.MazeStyleType.SingleRight;
            this.ZeroitThematicProgress1.MC_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Green,
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Brown,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Ivory,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.PapayaWhip,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.Tan,
        System.Drawing.Color.SlateGray};
            this.ZeroitThematicProgress1.MC_CorrectShift = 6;
            this.ZeroitThematicProgress1.MC_CorrectShift_Height = 6;
            this.ZeroitThematicProgress1.MC_InnerBorder = 2;
            this.ZeroitThematicProgress1.MC_InnerBorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.MC_InnerColor = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.MC_NoOfRings = Zeroit.Framework.ProgressThematic.Rings.One;
            this.ZeroitThematicProgress1.MC_Position_Horizontal = 0;
            this.ZeroitThematicProgress1.MC_Position_Vertical = 0;
            this.ZeroitThematicProgress1.MC_RectShift = 3;
            this.ZeroitThematicProgress1.MC_RectShift_Height = 3;
            this.ZeroitThematicProgress1.MC_Shift = 15;
            this.ZeroitThematicProgress1.MC_Shift_Height = 15;
            this.ZeroitThematicProgress1.MC_ShowInnerBorder = true;
            this.ZeroitThematicProgress1.MCEx_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Green,
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Brown,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Ivory,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.PapayaWhip,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.Tan,
        System.Drawing.Color.SlateGray};
            this.ZeroitThematicProgress1.MCEx_CorrectShift = 6;
            this.ZeroitThematicProgress1.MCEx_CorrectShift_Height = 6;
            this.ZeroitThematicProgress1.MCEx_InnerBorder = 2;
            this.ZeroitThematicProgress1.MCEx_InnerBorderColor = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.MCEx_InnerColor = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.MCEx_InnerShift = 3;
            this.ZeroitThematicProgress1.MCEx_NoOfRings = Zeroit.Framework.ProgressThematic.Rings.One;
            this.ZeroitThematicProgress1.MCEx_Position_Horizontal = 0;
            this.ZeroitThematicProgress1.MCEx_Position_Vertical = 0;
            this.ZeroitThematicProgress1.MCEx_RectShift = 3;
            this.ZeroitThematicProgress1.MCEx_RectShift_Height = 3;
            this.ZeroitThematicProgress1.MCEx_Shift = 15;
            this.ZeroitThematicProgress1.MCEx_Shift_Height = 15;
            this.ZeroitThematicProgress1.MCEx_ShowInnerBorder = true;
            this.ZeroitThematicProgress1.MCExV2_Colors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Green,
        System.Drawing.Color.AliceBlue,
        System.Drawing.Color.Brown,
        System.Drawing.Color.Chocolate,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Ivory,
        System.Drawing.Color.Lavender,
        System.Drawing.Color.LightSeaGreen,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.PaleGoldenrod,
        System.Drawing.Color.PapayaWhip,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Tomato,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.Tan,
        System.Drawing.Color.SlateGray};
            this.ZeroitThematicProgress1.MCExV2_CorrectShift = 6;
            this.ZeroitThematicProgress1.MCExV2_CorrectShift_Height = 6;
            this.ZeroitThematicProgress1.MCExV2_Divisions = true;
            this.ZeroitThematicProgress1.MCExV2_DivisionsWidth = 5;
            this.ZeroitThematicProgress1.MCExV2_DrawMode = Zeroit.Framework.ProgressThematic.drawMode.Solid;
            this.ZeroitThematicProgress1.MCExV2_GradientAngle = 90F;
            this.ZeroitThematicProgress1.MCExV2_GradientLine1 = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.BlanchedAlmond,
        System.Drawing.Color.DarkTurquoise,
        System.Drawing.Color.Beige,
        System.Drawing.Color.BurlyWood,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.OldLace,
        System.Drawing.Color.PowderBlue,
        System.Drawing.Color.SlateBlue,
        System.Drawing.Color.Sienna,
        System.Drawing.Color.Peru,
        System.Drawing.Color.MistyRose,
        System.Drawing.Color.LemonChiffon,
        System.Drawing.Color.Khaki,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.Cornsilk,
        System.Drawing.Color.Beige};
            this.ZeroitThematicProgress1.MCExV2_GradientLine2 = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.Green,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.DimGray,
        System.Drawing.Color.BlanchedAlmond,
        System.Drawing.Color.Chartreuse,
        System.Drawing.Color.DarkOrchid,
        System.Drawing.Color.Honeydew,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Plum,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.SeaShell,
        System.Drawing.Color.Navy,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.LawnGreen,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Crimson,
        System.Drawing.Color.CornflowerBlue,
        System.Drawing.Color.Cyan};
            this.ZeroitThematicProgress1.MCExV2_InnerBorder = 2;
            this.ZeroitThematicProgress1.MCExV2_InnerBorderColor = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.MCExV2_InnerColor = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.MCExV2_InnerHole = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.MCExV2_InnerHoleGradCol = new System.Drawing.Color[] {
        System.Drawing.Color.Azure,
        System.Drawing.Color.Bisque};
            this.ZeroitThematicProgress1.MCExV2_InnerShift = 3;
            this.ZeroitThematicProgress1.MCExV2_NoOfRings = Zeroit.Framework.ProgressThematic.Rings.One;
            this.ZeroitThematicProgress1.MCExV2_OuterBorder = false;
            this.ZeroitThematicProgress1.MCExV2_OuterBorderEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.ZeroitThematicProgress1.MCExV2_OuterBorderStart = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.MCExV2_OuterBorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ZeroitThematicProgress1.MCExV2_OuterBorderWidth = 2;
            this.ZeroitThematicProgress1.MCExV2_OuterColor = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Black};
            this.ZeroitThematicProgress1.MCExV2_Position_Horizontal = 0;
            this.ZeroitThematicProgress1.MCExV2_Position_Vertical = 0;
            this.ZeroitThematicProgress1.MCExV2_RectShift = 3;
            this.ZeroitThematicProgress1.MCExV2_RectShift_Height = 3;
            this.ZeroitThematicProgress1.MCExV2_RotatingBorder = true;
            this.ZeroitThematicProgress1.MCExV2_Shift = 15;
            this.ZeroitThematicProgress1.MCExV2_Shift_Height = 15;
            this.ZeroitThematicProgress1.Minimum = 0F;
            this.ZeroitThematicProgress1.MinimumSize = new System.Drawing.Size(28, 28);
            this.ZeroitThematicProgress1.Mode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.coloringMode.Hatch;
            this.ZeroitThematicProgress1.Name = "ZeroitThematicProgress1";
            this.ZeroitThematicProgress1.NumberSpoke = 12;
            this.ZeroitThematicProgress1.Orientation = Zeroit.Framework.ProgressThematic.ProgressBarDirection.Horizontal;
            this.ZeroitThematicProgress1.OuterBorderWidth = 1;
            this.ZeroitThematicProgress1.OuterCircleRadius = 11;
            this.ZeroitThematicProgress1.OuterColor = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.OuterMargin = -25;
            this.ZeroitThematicProgress1.OuterRadius = 74;
            this.ZeroitThematicProgress1.OuterWidth = 26;
            this.ZeroitThematicProgress1.P_AnimationColor = System.Drawing.Color.DimGray;
            this.ZeroitThematicProgress1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.ZeroitThematicProgress1.Percentage_Text = true;
            this.ZeroitThematicProgress1.Perplex_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(94)))), ((int)(((byte)(90)))));
            this.ZeroitThematicProgress1.Perplex_ColorGradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ZeroitThematicProgress1.Perplex_ColorGradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ZeroitThematicProgress1.Perplex_ColorGradient3 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(195)))), ((int)(((byte)(30)))));
            this.ZeroitThematicProgress1.Perplex_ColorGradient4 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(16)))));
            this.ZeroitThematicProgress1.Perplex_DrawMode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.perplex_DrawMode.Gradient;
            this.ZeroitThematicProgress1.Perplex_ShowPercentage = false;
            this.ZeroitThematicProgress1.PieColor1 = System.Drawing.Color.Beige;
            this.ZeroitThematicProgress1.PieColor2 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.PostFix = "%";
            this.ZeroitThematicProgress1.ProgIndicator_CircleWidth = 15F;
            this.ZeroitThematicProgress1.ProgIndicator_NumberOfCircles = 45F;
            this.ZeroitThematicProgress1.ProgIndicator_Radian = 180D;
            this.ZeroitThematicProgress1.ProgressAlter_Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ZeroitThematicProgress1.ProgressAlter_ColorAngle = 90F;
            this.ZeroitThematicProgress1.ProgressAlter_ColorBack = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ZeroitThematicProgress1.ProgressAlter_ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ZeroitThematicProgress1.ProgressAlter_ColorIC = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ZeroitThematicProgress1.ProgressAlter_ColorInside = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ZeroitThematicProgress1.ProgressAlter_ColorText = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ZeroitThematicProgress1.ProgressAlter_Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.ZeroitThematicProgress1.ProgressAwesome_AnimationSpeed = 500;
            this.ZeroitThematicProgress1.ProgressAwesome_ProgressWidth = 5;
            this.ZeroitThematicProgress1.ProgressBackColor = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.ProgressBarAwesomeStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.ZeroitThematicProgress1.ProgressBarBoxed_ActiveBlockColor = System.Drawing.Color.Red;
            this.ZeroitThematicProgress1.ProgressBarBoxed_NumberOfBlocks = 5;
            this.ZeroitThematicProgress1.ProgressBarClear_ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ZeroitThematicProgress1.ProgressBarClear_ColorGlow = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ZeroitThematicProgress1.ProgressBarClear_ColorGradient1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ZeroitThematicProgress1.ProgressBarClear_ColorGradient2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ZeroitThematicProgress1.ProgressBarNormal_BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.ProgressBarNormal_Step = 5;
            this.ZeroitThematicProgress1.ProgressBarPerfect_CustomText = "Perfect";
            this.ZeroitThematicProgress1.ProgressBarStyle = Zeroit.Framework.ProgressThematic.ProgressStyle.Dashed;
            this.ZeroitThematicProgress1.ProgressColor = System.Drawing.Color.Teal;
            this.ZeroitThematicProgress1.ProgressColor1_Default = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ZeroitThematicProgress1.ProgressColor2_Default = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ZeroitThematicProgress1.SolidProgressBar = Zeroit.Framework.ProgressThematic.ProgressBar.IPWin8Horizontal;
            this.ZeroitThematicProgress1.ProgressInnerBorderWidth = 1F;
            this.ZeroitThematicProgress1.ProgressInnerColor1_Default = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ZeroitThematicProgress1.ProgressInnerColor2_Default = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ZeroitThematicProgress1.ProgressNormalType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.progressNormalType.Normal;
            this.ZeroitThematicProgress1.ProgressPerfect_CircleSize = 0.2F;
            this.ZeroitThematicProgress1.ProgressPerfect_NumberOfCircles = 100F;
            this.ZeroitThematicProgress1.ProgressPerfect_NumberOfVisibleCircles = 30;
            this.ZeroitThematicProgress1.ProgressPerfect_Percentage = 0F;
            this.ZeroitThematicProgress1.ProgressPerfect_TextDisplay = Zeroit.Framework.ProgressThematic.TextDisplayModes1.None;
            this.ZeroitThematicProgress1.ProgressPie__ProgressShape = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.ProgressPie_ProgressShape.Round;
            this.ZeroitThematicProgress1.ProgressPie_FillEllipse1 = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.ProgressPie_FillEllipse2 = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.ProgressPie_InnerBorderColor = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.ProgressPie_InnerBorderWidth = 1F;
            this.ZeroitThematicProgress1.ProgressPie_Position = 180F;
            this.ZeroitThematicProgress1.ProgressPie_ProgressColor1 = System.Drawing.Color.DarkSlateGray;
            this.ZeroitThematicProgress1.ProgressPie_ProgressColor2 = System.Drawing.Color.DarkOrange;
            this.ZeroitThematicProgress1.ProgressPie_ProgressWidth = 1D;
            this.ZeroitThematicProgress1.ProgressPie_ShowText = true;
            this.ZeroitThematicProgress1.ProgressPie_SweepAngle = 180F;
            this.ZeroitThematicProgress1.ProgressPie_TextColor = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.ProgressPie_WidthEndCap = System.Drawing.Drawing2D.LineCap.Flat;
            this.ZeroitThematicProgress1.ProgressPie_WidthStartCap = System.Drawing.Drawing2D.LineCap.Flat;
            this.ZeroitThematicProgress1.ProgressRect_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ZeroitThematicProgress1.ProgressRect_ColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ZeroitThematicProgress1.ProgressRect_Corner = 8;
            this.ZeroitThematicProgress1.ProgressRect_ValueColour = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(119)))), ((int)(((byte)(220)))));
            this.ZeroitThematicProgress1.ProgressShape_Default = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress._ProgressShape.Round;
            this.ZeroitThematicProgress1.ProgressShapeVal = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress._ProgressShape.Round;
            this.ZeroitThematicProgress1.ProgressType = Zeroit.Framework.ProgressThematic.ProgressType.Bar;
            this.ZeroitThematicProgress1.ProgressWidth = 5D;
            this.ZeroitThematicProgress1.ProgressWidthEndCap = System.Drawing.Drawing2D.LineCap.Flat;
            this.ZeroitThematicProgress1.ProgressWidthStartCap = System.Drawing.Drawing2D.LineCap.Flat;
            this.ZeroitThematicProgress1.Refresh_Rate = 100;
            this.ZeroitThematicProgress1.RefreshRate = 100;
            this.ZeroitThematicProgress1.RollBlockPercent = 20;
            this.ZeroitThematicProgress1.RollingType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.RollingTypes.None;
            this.ZeroitThematicProgress1.RollTimer = 200;
            this.ZeroitThematicProgress1.RotatingAngle = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Gorgeous_rotatingAngle.Clockwise;
            this.ZeroitThematicProgress1.RotatingArc_DrawMode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.RotatingArc_drawMode.Default;
            this.ZeroitThematicProgress1.RotatingArc_StartAngle = 180F;
            this.ZeroitThematicProgress1.RotatingArc_SweepAngle = 360F;
            this.ZeroitThematicProgress1.RotatingBorder = false;
            this.ZeroitThematicProgress1.RotatingCompass_Angle = 90F;
            this.ZeroitThematicProgress1.RotatingCompass_FillPie = false;
            this.ZeroitThematicProgress1.RotatingCompass_LineColor1 = System.Drawing.Color.Yellow;
            this.ZeroitThematicProgress1.RotatingCompass_LineColor2 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.RotatingCompass_LineSize = 1;
            this.ZeroitThematicProgress1.RotatingCompass_LineWidthColor = System.Drawing.Color.Transparent;
            this.ZeroitThematicProgress1.RotatingCompass_PieColor1 = System.Drawing.Color.Beige;
            this.ZeroitThematicProgress1.RotatingCompass_PieColor2 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.RotatingCompass_RotatingBorder = false;
            this.ZeroitThematicProgress1.RotatingType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.PieArc.Arc;
            this.ZeroitThematicProgress1.RotationSpeed = 1000;
            this.ZeroitThematicProgress1.RowCount = 3;
            this.ZeroitThematicProgress1.SecondaryFont = new System.Drawing.Font("Century Gothic", 14F);
            this.ZeroitThematicProgress1.SecondColor = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.ShadowOffset = 1;
            this.ZeroitThematicProgress1.Shape = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Vuvuzela_Shape.Arc;
            this.ZeroitThematicProgress1.ShiftInner = 26;
            this.ZeroitThematicProgress1.ShiftInnerCover = 32;
            this.ZeroitThematicProgress1.ShiftOuter = 16;
            this.ZeroitThematicProgress1.ShiftSmallRect = 180;
            this.ZeroitThematicProgress1.ShowInnerBorder = true;
            this.ZeroitThematicProgress1.ShowInnerCircle1 = true;
            this.ZeroitThematicProgress1.ShowInnerCircle2 = true;
            this.ZeroitThematicProgress1.ShowInnerCircle3 = true;
            this.ZeroitThematicProgress1.ShowInnerCircle4 = true;
            this.ZeroitThematicProgress1.ShowInnerCircle5 = true;
            this.ZeroitThematicProgress1.ShowInnerCircle6 = true;
            this.ZeroitThematicProgress1.ShowLine = true;
            this.ZeroitThematicProgress1.ShowText = false;
            this.ZeroitThematicProgress1.ShowValue = false;
            this.ZeroitThematicProgress1.Size = new System.Drawing.Size(198, 28);
            this.ZeroitThematicProgress1.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.ZeroitThematicProgress1.SolidColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38))))),
        System.Drawing.Color.Gray};
            this.ZeroitThematicProgress1.SP_Angle = -90F;
            this.ZeroitThematicProgress1.SP_DrawMode = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Supreme_colorMode.Solid;
            this.ZeroitThematicProgress1.SP_GradientColor = new System.Drawing.Color[] {
        System.Drawing.Color.Orange,
        System.Drawing.Color.DarkSlateGray};
            this.ZeroitThematicProgress1.SP_GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ZeroitThematicProgress1.SP_Height_Tweak = 20;
            this.ZeroitThematicProgress1.SP_InnerBorder = 20;
            this.ZeroitThematicProgress1.SP_OuterBorder = 10;
            this.ZeroitThematicProgress1.SP_OuterColor = System.Drawing.Color.LightGray;
            this.ZeroitThematicProgress1.SP_Position_Horizontal = 10;
            this.ZeroitThematicProgress1.SP_Position_Vertical = 10;
            this.ZeroitThematicProgress1.SP_ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.ZeroitThematicProgress1.SP_SolidColor = System.Drawing.SystemColors.Control;
            this.ZeroitThematicProgress1.SP_Width_Tweak = 20;
            this.ZeroitThematicProgress1.Spinner_Active = false;
            this.ZeroitThematicProgress1.Spinner_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.Spinner_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.Splitter_BorderColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.SpokeColor = System.Drawing.Color.DarkGray;
            this.ZeroitThematicProgress1.SpokeThickness = 2;
            this.ZeroitThematicProgress1.StartAngle = 270;
            this.ZeroitThematicProgress1.StartingAngle = 270F;
            this.ZeroitThematicProgress1.StepInterval = 100;
            this.ZeroitThematicProgress1.StepSize = 0F;
            this.ZeroitThematicProgress1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ZeroitThematicProgress1.StylePreset = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.StylePresets.MacOSX;
            this.ZeroitThematicProgress1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ZeroitThematicProgress1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ZeroitThematicProgress1.SubscriptText = ".23";
            this.ZeroitThematicProgress1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ZeroitThematicProgress1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ZeroitThematicProgress1.SuperscriptText = "°C";
            this.ZeroitThematicProgress1.Supreme_EndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.Supreme_StartAngle = 180F;
            this.ZeroitThematicProgress1.Supreme_StartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ZeroitThematicProgress1.Supreme_SweepAngle = 360F;
            this.ZeroitThematicProgress1.Supreme_Type = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.Supreme_type.Circle;
            this.ZeroitThematicProgress1.TabIndex = 113;
            this.ZeroitThematicProgress1.Text = "ZeroitThematicProgress1";
            this.ZeroitThematicProgress1.TextAlignType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.TextAlignmentTypes.Center;
            this.ZeroitThematicProgress1.TextAntialias = true;
            this.ZeroitThematicProgress1.TextColorType = Zeroit.Framework.ProgressThematic.ZeroitThematicProgress.TextColorTypes.Automatic;
            this.ZeroitThematicProgress1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ZeroitThematicProgress1.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ZeroitThematicProgress1.TextShadowColor = System.Drawing.Color.White;
            this.ZeroitThematicProgress1.Timer_Interval = 1000;
            this.ZeroitThematicProgress1.Trans_Background = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.Trans_ProgressColor1 = System.Drawing.Color.Red;
            this.ZeroitThematicProgress1.Trans_ProgressColor2 = System.Drawing.Color.Gray;
            this.ZeroitThematicProgress1.Trans_ShowText = true;
            this.ZeroitThematicProgress1.TransistionSegment = 0;
            this.ZeroitThematicProgress1.Transparent = false;
            this.ZeroitThematicProgress1.TransparentEasing = Zeroit.Framework.ProgressThematic.transparencyEasingType.BounceEaseIn;
            this.ZeroitThematicProgress1.Unique_CustomText = "Unique";
            this.ZeroitThematicProgress1.Unique_NumberOfCircles = 100F;
            this.ZeroitThematicProgress1.Unique_Percentage = 0F;
            this.ZeroitThematicProgress1.Value = 0F;
            this.ZeroitThematicProgress1.Vuvuzela_Angle = 90F;
            this.ZeroitThematicProgress1.Vuvuzela_Circle1 = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.Vuvuzela_Circle2 = System.Drawing.Color.Green;
            this.ZeroitThematicProgress1.Vuvuzela_Circle3 = System.Drawing.Color.Brown;
            this.ZeroitThematicProgress1.Vuvuzela_Circle4 = System.Drawing.Color.Green;
            this.ZeroitThematicProgress1.Vuvuzela_Circle5 = System.Drawing.Color.Blue;
            this.ZeroitThematicProgress1.Vuvuzela_CircleSize = 1;
            this.ZeroitThematicProgress1.Vuvuzela_FillPie = false;
            this.ZeroitThematicProgress1.Vuvuzela_HorizontalSpacing = 0;
            this.ZeroitThematicProgress1.Vuvuzela_RotatingBorder = false;
            this.ZeroitThematicProgress1.Vuvuzela_RotatingCircle = System.Drawing.Color.Red;
            this.ZeroitThematicProgress1.Vuvuzela_VerticalSpacing = 0;
            this.ZeroitThematicProgress1.WallColor = System.Drawing.Color.Black;
            this.ZeroitThematicProgress1.WallSize = 1;
            this.ZeroitThematicProgress1.WinHR_Animate = false;
            this.ZeroitThematicProgress1.WinRing_Animate = false;
            this.ZeroitThematicProgress1.WinRing_Refresh_Rate = 100;
            // 
            // WinHorizontal_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.ZeroitThematicProgress1);
            this.Controls.Add(this.bars_Extended_GroupBox);
            this.Controls.Add(this.Preview_Btn);
            this.DoubleBuffered = true;
            this.Name = "WinHorizontal_UC";
            this.Size = new System.Drawing.Size(700, 178);
            ((System.ComponentModel.ISupportInitialize)(this.indicator_Win8Horiz_RefreshRate_Numeric)).EndInit();
            this.bars_Extended_GroupBox.ResumeLayout(false);
            this.bars_Extended_GroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_Win8Horiz_ControlWidth_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Preview_Btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown indicator_Win8Horiz_RefreshRate_Numeric;
        private System.Windows.Forms.GroupBox bars_Extended_GroupBox;
        public System.Windows.Forms.Button indicator_Win8Horiz_IndicatorColor_Btn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown indicator_Win8Horiz_ControlWidth_Numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton indicator_Win8Horiz_Animate_Yes_RadioBtn;
        public System.Windows.Forms.RadioButton indicator_Win8Horiz_Animate_No_RadioBtn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ColorDialog colorSelector;
        public ZeroitThematicProgress ZeroitThematicProgress1;
    }
}
