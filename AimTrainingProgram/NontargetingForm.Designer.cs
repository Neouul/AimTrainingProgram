namespace AimTrainingProgram
{
    partial class NontargetingForm
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
            this.btnRestart = new System.Windows.Forms.Button();
            this.TargetScore = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbSkillSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(534, 93);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 73);
            this.btnRestart.TabIndex = 28;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // TargetScore
            // 
            this.TargetScore.AutoSize = true;
            this.TargetScore.Font = new System.Drawing.Font("굴림", 20F);
            this.TargetScore.Location = new System.Drawing.Point(7, 89);
            this.TargetScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(330, 54);
            this.TargetScore.TabIndex = 27;
            this.TargetScore.Text = "TargetScore";
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(862, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(211, 75);
            this.btnSetting.TabIndex = 25;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(645, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(211, 75);
            this.btnAnalyze.TabIndex = 24;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(429, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(211, 75);
            this.btnScore.TabIndex = 23;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(211, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(211, 75);
            this.btnPlay.TabIndex = 22;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 75);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1079, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 75);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbSkillSelect
            // 
            this.cmbSkillSelect.FormattingEnabled = true;
            this.cmbSkillSelect.Location = new System.Drawing.Point(761, 93);
            this.cmbSkillSelect.Name = "cmbSkillSelect";
            this.cmbSkillSelect.Size = new System.Drawing.Size(121, 32);
            this.cmbSkillSelect.TabIndex = 29;
            this.cmbSkillSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSkillSelect_SelectedIndexChanged);
            // 
            // NontargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 812);
            this.Controls.Add(this.cmbSkillSelect);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.TargetScore);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Name = "NontargetingForm";
            this.Text = "NontargettingForm";
            this.Load += new System.EventHandler(this.NontargetingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label TargetScore;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbSkillSelect;
    }
}