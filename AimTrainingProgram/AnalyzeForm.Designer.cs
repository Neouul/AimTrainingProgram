
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboModeSelect = new System.Windows.Forms.ComboBox();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.btnClearRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDateScores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDifficultyStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDateScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifficultyStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModeSelect
            // 
            this.comboModeSelect.FormattingEnabled = true;
            this.comboModeSelect.Items.AddRange(new object[] {
            "Targeting",
            "Moving"});
            this.comboModeSelect.Location = new System.Drawing.Point(48, 91);
            this.comboModeSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboModeSelect.Name = "comboModeSelect";
            this.comboModeSelect.Size = new System.Drawing.Size(98, 23);
            this.comboModeSelect.TabIndex = 14;
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRecommendation.Location = new System.Drawing.Point(15, 51);
            this.labelRecommendation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(66, 28);
            this.labelRecommendation.TabIndex = 15;
            this.labelRecommendation.Text = "label1";
            // 
            // btnClearRecords
            // 
            this.btnClearRecords.Location = new System.Drawing.Point(1308, 78);
            this.btnClearRecords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearRecords.Name = "btnClearRecords";
            this.btnClearRecords.Size = new System.Drawing.Size(82, 31);
            this.btnClearRecords.TabIndex = 17;
            this.btnClearRecords.Text = "초기화";
            this.btnClearRecords.UseVisualStyleBackColor = true;
            this.btnClearRecords.Click += new System.EventHandler(this.btnClearRecords_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(857, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "최근 게임 기록 - Targeting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.chartDateScores);
            this.panel1.Controls.Add(this.chartDifficultyStats);
            this.panel1.Controls.Add(this.labelRecommendation);
            this.panel1.Location = new System.Drawing.Point(30, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 613);
            this.panel1.TabIndex = 19;
            // 
            // chartDateScores
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDateScores.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDateScores.Legends.Add(legend3);
            this.chartDateScores.Location = new System.Drawing.Point(37, 332);
            this.chartDateScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDateScores.Name = "chartDateScores";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDateScores.Series.Add(series3);
            this.chartDateScores.Size = new System.Drawing.Size(716, 250);
            this.chartDateScores.TabIndex = 20;
            this.chartDateScores.Text = "chart1";
            // 
            // chartDifficultyStats
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDifficultyStats.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDifficultyStats.Legends.Add(legend4);
            this.chartDifficultyStats.Location = new System.Drawing.Point(334, 41);
            this.chartDifficultyStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDifficultyStats.Name = "chartDifficultyStats";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDifficultyStats.Series.Add(series4);
            this.chartDifficultyStats.Size = new System.Drawing.Size(411, 250);
            this.chartDifficultyStats.TabIndex = 20;
            this.chartDifficultyStats.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 27;
            this.button2.Text = "Score";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 47);
            this.button3.TabIndex = 26;
            this.button3.Text = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::AimTrainingProgram.Properties.Resources.homeicon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(30, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 47);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::AimTrainingProgram.Properties.Resources.backicon;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(565, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 47);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(868, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 429);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboModeSelect);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnalyzeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDateScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifficultyStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboModeSelect;
        private System.Windows.Forms.Label labelRecommendation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDifficultyStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDateScores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}