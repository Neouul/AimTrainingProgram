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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboModeSelect = new System.Windows.Forms.ComboBox();
            this.chartSensitivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDifficulty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModeSelect
            // 
            this.comboModeSelect.FormattingEnabled = true;
            this.comboModeSelect.Items.AddRange(new object[] {
            "Targeting",
            "Moving"});
            this.comboModeSelect.Location = new System.Drawing.Point(43, 91);
            this.comboModeSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboModeSelect.Name = "comboModeSelect";
            this.comboModeSelect.Size = new System.Drawing.Size(98, 23);
            this.comboModeSelect.TabIndex = 15;
            // 
            // chartSensitivity
            // 
            chartArea13.Name = "ChartArea1";
            this.chartSensitivity.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartSensitivity.Legends.Add(legend13);
            this.chartSensitivity.Location = new System.Drawing.Point(120, 151);
            this.chartSensitivity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartSensitivity.Name = "chartSensitivity";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chartSensitivity.Series.Add(series13);
            this.chartSensitivity.Size = new System.Drawing.Size(714, 282);
            this.chartSensitivity.TabIndex = 16;
            this.chartSensitivity.Text = "chart1";
            // 
            // chartDifficulty
            // 
            chartArea14.Name = "ChartArea1";
            this.chartDifficulty.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartDifficulty.Legends.Add(legend14);
            this.chartDifficulty.Location = new System.Drawing.Point(120, 492);
            this.chartDifficulty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDifficulty.Name = "chartDifficulty";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chartDifficulty.Series.Add(series14);
            this.chartDifficulty.Size = new System.Drawing.Size(303, 282);
            this.chartDifficulty.TabIndex = 17;
            this.chartDifficulty.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(394, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "감도별 평균 점수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(198, 786);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "난이도별 평균 점수";
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
            this.button2.Location = new System.Drawing.Point(298, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Analyze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(164, 11);
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
            this.button4.Location = new System.Drawing.Point(27, 11);
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
            this.button5.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 822);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDifficulty);
            this.Controls.Add(this.chartSensitivity);
            this.Controls.Add(this.comboModeSelect);
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
        private System.Windows.Forms.ComboBox comboModeSelect;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensitivity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}