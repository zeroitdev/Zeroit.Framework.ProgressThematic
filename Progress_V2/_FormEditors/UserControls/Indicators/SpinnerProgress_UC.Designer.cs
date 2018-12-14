// ***********************************************************************
// Assembly         : Zeroit.Framework.ProgressThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 03-01-2018
// ***********************************************************************
// <copyright file="SpinnerProgress_UC.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Zeroit.Framework.ProgressThematic.FormEditors
{
    partial class SpinnerProgress_UC
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
            this.indicator_SpinnerDivided_TransSegment_Numeric = new System.Windows.Forms.NumericUpDown();
            this.bars_Extended_GroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.indicator_SpinnerDivided_Automate_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn = new System.Windows.Forms.RadioButton();
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.indicator_SpinnerDivided_TransSegmentCol_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.indicator_SpinnerDivided_InactiveSegment_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.indicator_SpinnerDivided_ActiveSegment_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorSelector = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_SpinnerDivided_TransSegment_Numeric)).BeginInit();
            this.bars_Extended_GroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric)).BeginInit();
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
            this.Preview_Btn.Location = new System.Drawing.Point(793, 6);
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
            this.label1.Location = new System.Drawing.Point(6, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 38);
            this.label1.TabIndex = 219;
            this.label1.Text = "Transition \r\nSegment";
            // 
            // indicator_SpinnerDivided_TransSegment_Numeric
            // 
            this.indicator_SpinnerDivided_TransSegment_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.indicator_SpinnerDivided_TransSegment_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator_SpinnerDivided_TransSegment_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.indicator_SpinnerDivided_TransSegment_Numeric.Location = new System.Drawing.Point(118, 134);
            this.indicator_SpinnerDivided_TransSegment_Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.indicator_SpinnerDivided_TransSegment_Numeric.Name = "indicator_SpinnerDivided_TransSegment_Numeric";
            this.indicator_SpinnerDivided_TransSegment_Numeric.Size = new System.Drawing.Size(70, 29);
            this.indicator_SpinnerDivided_TransSegment_Numeric.TabIndex = 220;
            // 
            // bars_Extended_GroupBox
            // 
            this.bars_Extended_GroupBox.Controls.Add(this.panel2);
            this.bars_Extended_GroupBox.Controls.Add(this.label9);
            this.bars_Extended_GroupBox.Controls.Add(this.panel1);
            this.bars_Extended_GroupBox.Controls.Add(this.label7);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_SpinnerDivided_TransSegmentCol_Btn);
            this.bars_Extended_GroupBox.Controls.Add(this.label5);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_SpinnerDivided_InactiveSegment_Btn);
            this.bars_Extended_GroupBox.Controls.Add(this.label4);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric);
            this.bars_Extended_GroupBox.Controls.Add(this.label2);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_SpinnerDivided_ActiveSegment_Btn);
            this.bars_Extended_GroupBox.Controls.Add(this.label6);
            this.bars_Extended_GroupBox.Controls.Add(this.indicator_SpinnerDivided_TransSegment_Numeric);
            this.bars_Extended_GroupBox.Controls.Add(this.label1);
            this.bars_Extended_GroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bars_Extended_GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bars_Extended_GroupBox.Location = new System.Drawing.Point(3, 5);
            this.bars_Extended_GroupBox.Name = "bars_Extended_GroupBox";
            this.bars_Extended_GroupBox.Size = new System.Drawing.Size(708, 266);
            this.bars_Extended_GroupBox.TabIndex = 112;
            this.bars_Extended_GroupBox.TabStop = false;
            this.bars_Extended_GroupBox.Text = "Spinner Divided";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.indicator_SpinnerDivided_Automate_Yes_RadioBtn);
            this.panel2.Controls.Add(this.indicator_SpinnerDivided_Automate_No_RadioBtn);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel2.Location = new System.Drawing.Point(597, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 38);
            this.panel2.TabIndex = 256;
            // 
            // indicator_SpinnerDivided_Automate_Yes_RadioBtn
            // 
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.AutoSize = true;
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.Checked = true;
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.Location = new System.Drawing.Point(6, 6);
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.Name = "indicator_SpinnerDivided_Automate_Yes_RadioBtn";
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.Size = new System.Drawing.Size(47, 23);
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.TabIndex = 113;
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.TabStop = true;
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.Text = "Yes";
            this.indicator_SpinnerDivided_Automate_Yes_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // indicator_SpinnerDivided_Automate_No_RadioBtn
            // 
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.AutoSize = true;
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.Location = new System.Drawing.Point(54, 6);
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.Name = "indicator_SpinnerDivided_Automate_No_RadioBtn";
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.Size = new System.Drawing.Size(45, 23);
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.TabIndex = 114;
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.Text = "No";
            this.indicator_SpinnerDivided_Automate_No_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(474, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 255;
            this.label9.Text = "Automate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn);
            this.panel1.Controls.Add(this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel1.Location = new System.Drawing.Point(597, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 38);
            this.panel1.TabIndex = 254;
            // 
            // indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn
            // 
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.AutoSize = true;
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.Checked = true;
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.Location = new System.Drawing.Point(6, 6);
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.Name = "indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn";
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.Size = new System.Drawing.Size(47, 23);
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.TabIndex = 113;
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.TabStop = true;
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.Text = "Yes";
            this.indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn
            // 
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.AutoSize = true;
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.Location = new System.Drawing.Point(54, 6);
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.Name = "indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn";
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.Size = new System.Drawing.Size(45, 23);
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.TabIndex = 114;
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.Text = "No";
            this.indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(474, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 38);
            this.label7.TabIndex = 253;
            this.label7.Text = "Behind Transition\r\nSegment";
            // 
            // indicator_SpinnerDivided_TransSegmentCol_Btn
            // 
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.BackColor = System.Drawing.Color.Black;
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.FlatAppearance.BorderSize = 0;
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.Location = new System.Drawing.Point(357, 213);
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.Name = "indicator_SpinnerDivided_TransSegmentCol_Btn";
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.Size = new System.Drawing.Size(66, 24);
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.TabIndex = 252;
            this.indicator_SpinnerDivided_TransSegmentCol_Btn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(228, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 251;
            this.label5.Text = "Transition Segment";
            // 
            // indicator_SpinnerDivided_InactiveSegment_Btn
            // 
            this.indicator_SpinnerDivided_InactiveSegment_Btn.BackColor = System.Drawing.Color.Black;
            this.indicator_SpinnerDivided_InactiveSegment_Btn.FlatAppearance.BorderSize = 0;
            this.indicator_SpinnerDivided_InactiveSegment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicator_SpinnerDivided_InactiveSegment_Btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.indicator_SpinnerDivided_InactiveSegment_Btn.Location = new System.Drawing.Point(357, 138);
            this.indicator_SpinnerDivided_InactiveSegment_Btn.Name = "indicator_SpinnerDivided_InactiveSegment_Btn";
            this.indicator_SpinnerDivided_InactiveSegment_Btn.Size = new System.Drawing.Size(66, 24);
            this.indicator_SpinnerDivided_InactiveSegment_Btn.TabIndex = 250;
            this.indicator_SpinnerDivided_InactiveSegment_Btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(228, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 249;
            this.label4.Text = "Inactive Segment";
            // 
            // indicator_SpinnerDivided_AutoIncremFrequency_Numeric
            // 
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.Location = new System.Drawing.Point(118, 57);
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.Name = "indicator_SpinnerDivided_AutoIncremFrequency_Numeric";
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.Size = new System.Drawing.Size(70, 29);
            this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric.TabIndex = 248;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 247;
            this.label2.Text = "Auto Increment\r\nFrequency";
            // 
            // indicator_SpinnerDivided_ActiveSegment_Btn
            // 
            this.indicator_SpinnerDivided_ActiveSegment_Btn.BackColor = System.Drawing.Color.Black;
            this.indicator_SpinnerDivided_ActiveSegment_Btn.FlatAppearance.BorderSize = 0;
            this.indicator_SpinnerDivided_ActiveSegment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indicator_SpinnerDivided_ActiveSegment_Btn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.indicator_SpinnerDivided_ActiveSegment_Btn.Location = new System.Drawing.Point(357, 60);
            this.indicator_SpinnerDivided_ActiveSegment_Btn.Name = "indicator_SpinnerDivided_ActiveSegment_Btn";
            this.indicator_SpinnerDivided_ActiveSegment_Btn.Size = new System.Drawing.Size(66, 24);
            this.indicator_SpinnerDivided_ActiveSegment_Btn.TabIndex = 241;
            this.indicator_SpinnerDivided_ActiveSegment_Btn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(228, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 240;
            this.label6.Text = "Active Segment";
            // 
            // SpinnerProgress_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.bars_Extended_GroupBox);
            this.Controls.Add(this.Preview_Btn);
            this.DoubleBuffered = true;
            this.Name = "SpinnerProgress_UC";
            this.Size = new System.Drawing.Size(974, 272);
            ((System.ComponentModel.ISupportInitialize)(this.indicator_SpinnerDivided_TransSegment_Numeric)).EndInit();
            this.bars_Extended_GroupBox.ResumeLayout(false);
            this.bars_Extended_GroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator_SpinnerDivided_AutoIncremFrequency_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Preview_Btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown indicator_SpinnerDivided_TransSegment_Numeric;
        private System.Windows.Forms.GroupBox bars_Extended_GroupBox;
        public System.Windows.Forms.Button indicator_SpinnerDivided_ActiveSegment_Btn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button indicator_SpinnerDivided_TransSegmentCol_Btn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button indicator_SpinnerDivided_InactiveSegment_Btn;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown indicator_SpinnerDivided_AutoIncremFrequency_Numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton indicator_SpinnerDivided_Automate_Yes_RadioBtn;
        public System.Windows.Forms.RadioButton indicator_SpinnerDivided_Automate_No_RadioBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton indicator_SpinnerDivided_BehindTransSegment_Yes_RadioBtn;
        public System.Windows.Forms.RadioButton indicator_SpinnerDivided_BehindTransSegment_No_RadioBtn;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ColorDialog colorSelector;
    }
}
