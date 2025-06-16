namespace AimTrainingProgram
{
    partial class ScoreForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.comboModeSelect = new System.Windows.Forms.ComboBox();
            this.chartSensitivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDifficulty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(22, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(232, 51);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(890, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(226, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(694, 14);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(192, 51);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(258, 12);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(235, 53);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(498, 14);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(192, 53);
            this.btnAnalyze.TabIndex = 11;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // comboModeSelect
            // 
            this.comboModeSelect.FormattingEnabled = true;
            this.comboModeSelect.Items.AddRange(new object[] {
            "Targeting",
            "Moving"});
            this.comboModeSelect.Location = new System.Drawing.Point(54, 109);
            this.comboModeSelect.Name = "comboModeSelect";
            this.comboModeSelect.Size = new System.Drawing.Size(121, 26);
            this.comboModeSelect.TabIndex = 15;
            // 
            // chartSensitivity
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSensitivity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSensitivity.Legends.Add(legend1);
            this.chartSensitivity.Location = new System.Drawing.Point(150, 181);
            this.chartSensitivity.Name = "chartSensitivity";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSensitivity.Series.Add(series1);
            this.chartSensitivity.Size = new System.Drawing.Size(893, 338);
            this.chartSensitivity.TabIndex = 16;
            this.chartSensitivity.Text = "chart1";
            // 
            // chartDifficulty
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDifficulty.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDifficulty.Legends.Add(legend2);
            this.chartDifficulty.Location = new System.Drawing.Point(150, 590);
            this.chartDifficulty.Name = "chartDifficulty";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDifficulty.Series.Add(series2);
            this.chartDifficulty.Size = new System.Drawing.Size(379, 338);
            this.chartDifficulty.TabIndex = 17;
            this.chartDifficulty.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(493, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "감도별 평균 점수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(247, 943);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 19;
            this.label2.Text = "난이도별 평균 점수";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 986);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDifficulty);
            this.Controls.Add(this.chartSensitivity);
            this.Controls.Add(this.comboModeSelect);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.ComboBox comboModeSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensitivity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}