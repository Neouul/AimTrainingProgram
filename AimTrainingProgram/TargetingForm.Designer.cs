namespace AimTrainingProgram
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(30, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 75);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1107, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 75);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(890, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(211, 75);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(673, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(211, 75);
            this.btnAnalyze.TabIndex = 14;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(456, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(211, 75);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(239, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(211, 75);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // TargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 874);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Name = "TargetingForm";
            this.Text = "TargetingForm";
            this.Load += new System.EventHandler(this.TargetingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
    }
}