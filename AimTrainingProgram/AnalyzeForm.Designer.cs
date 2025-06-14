
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
            this.comboModeSelect = new System.Windows.Forms.ComboBox();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // comboModeSelect
            // 
            this.comboModeSelect.FormattingEnabled = true;
            this.comboModeSelect.Items.AddRange(new object[] {
            "Targeting",
            "Moving"});
            this.comboModeSelect.Location = new System.Drawing.Point(60, 109);
            this.comboModeSelect.Name = "comboModeSelect";
            this.comboModeSelect.Size = new System.Drawing.Size(121, 26);
            this.comboModeSelect.TabIndex = 14;
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRecommendation.Location = new System.Drawing.Point(57, 161);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(78, 32);
            this.labelRecommendation.TabIndex = 15;
            this.labelRecommendation.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 564);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearRecords
            // 
            this.btnClearRecords.Location = new System.Drawing.Point(686, 454);
            this.btnClearRecords.Name = "btnClearRecords";
            this.btnClearRecords.Size = new System.Drawing.Size(103, 37);
            this.btnClearRecords.TabIndex = 17;
            this.btnClearRecords.Text = "초기화";
            this.btnClearRecords.UseVisualStyleBackColor = true;
            this.btnClearRecords.Click += new System.EventHandler(this.btnClearRecords_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(58, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "최근 게임 기록";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRecommendation);
            this.Controls.Add(this.comboModeSelect);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox comboModeSelect;
        private System.Windows.Forms.Label labelRecommendation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearRecords;
        private System.Windows.Forms.Label label1;
    }
}
