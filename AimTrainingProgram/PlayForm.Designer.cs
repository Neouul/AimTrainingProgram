namespace AimTrainingProgram
{
    partial class PlayForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTargeting = new System.Windows.Forms.Button();
            this.btnMoving = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnNontargeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(960, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 64);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 64);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTargeting
            // 
            this.btnTargeting.Location = new System.Drawing.Point(150, 110);
            this.btnTargeting.Name = "btnTargeting";
            this.btnTargeting.Size = new System.Drawing.Size(341, 799);
            this.btnTargeting.TabIndex = 2;
            this.btnTargeting.Text = "Targeting Training";
            this.btnTargeting.UseVisualStyleBackColor = true;
            this.btnTargeting.Click += new System.EventHandler(this.btnTargeting_Click);
            // 
            // btnMoving
            // 
            this.btnMoving.Location = new System.Drawing.Point(638, 110);
            this.btnMoving.Name = "btnMoving";
            this.btnMoving.Size = new System.Drawing.Size(341, 799);
            this.btnMoving.TabIndex = 3;
            this.btnMoving.Text = "Moving Training";
            this.btnMoving.UseVisualStyleBackColor = true;
            this.btnMoving.Click += new System.EventHandler(this.btnMoving_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(734, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(220, 64);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(479, 13);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(220, 64);
            this.btnAnalyze.TabIndex = 9;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(224, 13);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(220, 64);
            this.btnScore.TabIndex = 8;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnNontargeting
            // 
            this.btnNontargeting.Location = new System.Drawing.Point(1132, 110);
            this.btnNontargeting.Name = "btnNontargeting";
            this.btnNontargeting.Size = new System.Drawing.Size(341, 799);
            this.btnNontargeting.TabIndex = 11;
            this.btnNontargeting.Text = "Nontargeting Training";
            this.btnNontargeting.UseVisualStyleBackColor = true;
            this.btnNontargeting.Click += new System.EventHandler(this.btnNontargeting_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 939);
            this.Controls.Add(this.btnNontargeting);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnMoving);
            this.Controls.Add(this.btnTargeting);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTargeting;
        private System.Windows.Forms.Button btnMoving;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnNontargeting;
    }
}