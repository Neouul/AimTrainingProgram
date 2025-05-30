﻿namespace AimTrainingProgram
{
    partial class TargetingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.MousePointer = new System.Windows.Forms.PictureBox();
            this.AimTarget = new System.Windows.Forms.PictureBox();
            this.TargetScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(18, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(125, 47);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(681, 8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(548, 8);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(130, 47);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(414, 8);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(130, 47);
            this.btnAnalyze.TabIndex = 14;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(281, 8);
            this.btnScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(130, 47);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(147, 8);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(130, 47);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MousePointer
            // 
            this.MousePointer.Image = global::AimTrainingProgram.Properties.Resources.pointer;
            this.MousePointer.Location = new System.Drawing.Point(62, 492);
            this.MousePointer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MousePointer.Name = "MousePointer";
            this.MousePointer.Size = new System.Drawing.Size(29, 47);
            this.MousePointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MousePointer.TabIndex = 17;
            this.MousePointer.TabStop = false;
            this.MousePointer.Visible = false;
            this.MousePointer.Click += new System.EventHandler(this.MousePointer_Click);
            // 
            // AimTarget
            // 
            this.AimTarget.Image = global::AimTrainingProgram.Properties.Resources.target;
            this.AimTarget.Location = new System.Drawing.Point(10, 471);
            this.AimTarget.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AimTarget.Name = "AimTarget";
            this.AimTarget.Size = new System.Drawing.Size(50, 50);
            this.AimTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AimTarget.TabIndex = 16;
            this.AimTarget.TabStop = false;
            this.AimTarget.Visible = false;
            this.AimTarget.Click += new System.EventHandler(this.AimTarget_Click);
            // 
            // TargetScore
            // 
            this.TargetScore.AutoSize = true;
            this.TargetScore.Font = new System.Drawing.Font("굴림", 20F);
            this.TargetScore.Location = new System.Drawing.Point(22, 71);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(208, 34);
            this.TargetScore.TabIndex = 18;
            this.TargetScore.Text = "TargetScore";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(346, 59);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(130, 46);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // TargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.TargetScore);
            this.Controls.Add(this.MousePointer);
            this.Controls.Add(this.AimTarget);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TargetingForm";
            this.Text = "TargetingForm";
            this.Load += new System.EventHandler(this.TargetingForm_Load);
            this.VisibleChanged += new System.EventHandler(this.TargetingForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TargetingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SensInScreen);
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox AimTarget;
        private System.Windows.Forms.PictureBox MousePointer;
        private System.Windows.Forms.Label TargetScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
    }
}