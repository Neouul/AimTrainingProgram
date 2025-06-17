<<<<<<< Updated upstream
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
            this.btnHome.Location = new System.Drawing.Point(29, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 75);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1107, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 75);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(890, 13);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(211, 75);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(673, 13);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(211, 75);
            this.btnAnalyze.TabIndex = 14;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(457, 13);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(211, 75);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(239, 13);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(211, 75);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MousePointer
            // 
            this.MousePointer.Image = global::AimTrainingProgram.Properties.Resources.pointer;
            this.MousePointer.Location = new System.Drawing.Point(101, 787);
            this.MousePointer.Margin = new System.Windows.Forms.Padding(8);
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
            this.AimTarget.Location = new System.Drawing.Point(17, 754);
            this.AimTarget.Margin = new System.Windows.Forms.Padding(8);
            this.AimTarget.Name = "AimTarget";
            this.AimTarget.Size = new System.Drawing.Size(81, 80);
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
            this.TargetScore.Location = new System.Drawing.Point(35, 113);
            this.TargetScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(330, 54);
            this.TargetScore.TabIndex = 18;
            this.TargetScore.Text = "TargetScore";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(562, 94);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 73);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // TargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 874);
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
            this.Name = "TargetingForm";
            this.Text = "TargetingForm";
            this.Load += new System.EventHandler(this.TargetingForm_Load);
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
=======
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
            this.TargetScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MousePointer = new System.Windows.Forms.PictureBox();
            this.AimTarget = new System.Windows.Forms.PictureBox();
            this.comboModeSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // TargetScore
            // 
            this.TargetScore.AutoSize = true;
            this.TargetScore.Font = new System.Drawing.Font("굴림", 20F);
            this.TargetScore.Location = new System.Drawing.Point(36, 114);
            this.TargetScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(330, 54);
            this.TargetScore.TabIndex = 18;
            this.TargetScore.Text = "TargetScore";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(562, 94);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 74);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::AimTrainingProgram.Properties.Resources.backicon;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(1112, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(214, 75);
            this.button7.TabIndex = 24;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::AimTrainingProgram.Properties.Resources.homeicon;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(21, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 75);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 75);
            this.button5.TabIndex = 26;
            this.button5.Text = "Play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(895, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 75);
            this.button2.TabIndex = 29;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 75);
            this.button3.TabIndex = 28;
            this.button3.Text = "Analyze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 75);
            this.button4.TabIndex = 27;
            this.button4.Text = "Score";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // MousePointer
            // 
            this.MousePointer.Image = global::AimTrainingProgram.Properties.Resources.pointer;
            this.MousePointer.Location = new System.Drawing.Point(101, 787);
            this.MousePointer.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
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
            this.AimTarget.Location = new System.Drawing.Point(16, 754);
            this.AimTarget.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.AimTarget.Name = "AimTarget";
            this.AimTarget.Size = new System.Drawing.Size(81, 80);
            this.AimTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AimTarget.TabIndex = 16;
            this.AimTarget.TabStop = false;
            this.AimTarget.Visible = false;
            this.AimTarget.Click += new System.EventHandler(this.AimTarget_Click);
            // 
            // comboModeSelect
            // 
            this.comboModeSelect.FormattingEnabled = true;
            this.comboModeSelect.Items.AddRange(new object[] {
            "일반 모드",
            "약점 분석 모드"});
            this.comboModeSelect.Location = new System.Drawing.Point(847, 116);
            this.comboModeSelect.Name = "comboModeSelect";
            this.comboModeSelect.Size = new System.Drawing.Size(121, 32);
            this.comboModeSelect.TabIndex = 30;
            // 
            // TargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 874);
            this.Controls.Add(this.comboModeSelect);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.TargetScore);
            this.Controls.Add(this.MousePointer);
            this.Controls.Add(this.AimTarget);
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
        private System.Windows.Forms.PictureBox AimTarget;
        private System.Windows.Forms.PictureBox MousePointer;
        private System.Windows.Forms.Label TargetScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboModeSelect;
    }
>>>>>>> Stashed changes
}