
namespace AimTrainingProgram
{
    partial class AnalyzeForm
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
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listBoxDatewise = new System.Windows.Forms.ListBox();
            this.listBoxSensitivitywise = new System.Windows.Forms.ListBox();
            this.lblDatewise = new System.Windows.Forms.Label();
            this.lblSensitivitywise = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(9, 9);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(208, 52);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(860, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 52);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(648, 9);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(208, 52);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(435, 9);
            this.btnScore.Margin = new System.Windows.Forms.Padding(2);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(208, 52);
            this.btnScore.TabIndex = 9;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(223, 9);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(208, 52);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // listBoxDatewise
            // 
            this.listBoxDatewise.FormattingEnabled = true;
            this.listBoxDatewise.ItemHeight = 18;
            this.listBoxDatewise.Location = new System.Drawing.Point(74, 140);
            this.listBoxDatewise.Name = "listBoxDatewise";
            this.listBoxDatewise.Size = new System.Drawing.Size(654, 112);
            this.listBoxDatewise.TabIndex = 12;
            // 
            // listBoxSensitivitywise
            // 
            this.listBoxSensitivitywise.FormattingEnabled = true;
            this.listBoxSensitivitywise.ItemHeight = 18;
            this.listBoxSensitivitywise.Location = new System.Drawing.Point(74, 353);
            this.listBoxSensitivitywise.Name = "listBoxSensitivitywise";
            this.listBoxSensitivitywise.Size = new System.Drawing.Size(654, 112);
            this.listBoxSensitivitywise.TabIndex = 13;
            // 
            // lblDatewise
            // 
            this.lblDatewise.AutoSize = true;
            this.lblDatewise.Location = new System.Drawing.Point(71, 119);
            this.lblDatewise.Name = "lblDatewise";
            this.lblDatewise.Size = new System.Drawing.Size(146, 18);
            this.lblDatewise.TabIndex = 14;
            this.lblDatewise.Text = "날짜별 평균 점수";
            // 
            // lblSensitivitywise
            // 
            this.lblSensitivitywise.AutoSize = true;
            this.lblSensitivitywise.Location = new System.Drawing.Point(71, 332);
            this.lblSensitivitywise.Name = "lblSensitivitywise";
            this.lblSensitivitywise.Size = new System.Drawing.Size(146, 18);
            this.lblSensitivitywise.TabIndex = 15;
            this.lblSensitivitywise.Text = "감도별 평균 점수";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 678);
            this.Controls.Add(this.lblSensitivitywise);
            this.Controls.Add(this.lblDatewise);
            this.Controls.Add(this.listBoxSensitivitywise);
            this.Controls.Add(this.listBoxDatewise);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzeForm";
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListBox listBoxDatewise;
        private System.Windows.Forms.ListBox listBoxSensitivitywise;
        private System.Windows.Forms.Label lblDatewise;
        private System.Windows.Forms.Label lblSensitivitywise;
    }
}
