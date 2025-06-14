using AimTrainingProgram.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AimTrainingProgram
{
    public partial class ScoreForm : Form
    {
        private Form previousForm;

        public ScoreForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            previousForm = previous;
        }

        public ScoreForm() : this(null) { }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            // 콤보박스 항목 추가 및 초기화
            comboModeSelect.Items.Clear();
            comboModeSelect.Items.Add("Targeting");
            comboModeSelect.Items.Add("Moving");
            comboModeSelect.SelectedIndex = 0;

            comboModeSelect.SelectedIndexChanged += ComboModeSelect_SelectedIndexChanged;

            LoadAndDisplayScores();
        }

        private void ComboModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAndDisplayScores();
        }

        private void LoadAndDisplayScores()
        {
            string selectedMode = comboModeSelect.SelectedItem?.ToString() ?? "Targeting";
            var allScores = DataManager.LoadScores();

            var filteredScores = allScores
                .Where(s => s.Mode == selectedMode)
                .ToList();

            UpdateSensitivityChart(filteredScores);
            UpdateDifficultyChart(filteredScores);
        }

        private void InitializeSensitivityChart()
        {
            chartSensitivity.Series.Clear();
            chartSensitivity.ChartAreas.Clear();
            chartSensitivity.Titles.Clear();

            chartSensitivity.ChartAreas.Add("MainArea");
            chartSensitivity.Titles.Add("감도별 평균 명중률");
        }

        private void UpdateSensitivityChart(List<ScoreData> scores)
        {
            InitializeSensitivityChart();

            var grouped = scores
                .GroupBy(s => s.GameSensitivity)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Sensitivity = g.Key,
                    AverageScore = g.Average(s => s.Score)
                });

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "AccuracyBySensitivity",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.Blue
            };

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.Sensitivity, item.AverageScore);
            }

            chartSensitivity.Series.Add(series);
        }
        private void UpdateDifficultyChart(List<ScoreData> scores)
        {
            InitializeDifficultyChart();

            var grouped = scores
                .GroupBy(s => s.Difficulty)
                .OrderBy(g => Array.IndexOf(new[] { "Easy", "Normal", "Hard" }, g.Key))
                .Select(g => new
                {
                    Difficulty = g.Key,
                    AverageScore = g.Average(s => s.Score)
                });

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "AccuracyByDifficulty",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                BorderWidth = 3,
                Color = Color.Orange
            };

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.Difficulty, item.AverageScore);
            }

            chartDifficulty.Series.Add(series);
        }

        private void InitializeDifficultyChart()
        {
            chartDifficulty.Series.Clear();
            chartDifficulty.ChartAreas.Clear();
            chartDifficulty.Titles.Clear();

            chartDifficulty.ChartAreas.Add("MainArea");
            chartDifficulty.Titles.Add("난이도별 평균 명중률");
        }


        // 버튼 이벤트 핸들러 
        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (previousForm != null) previousForm.Show();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(this);
            playForm.Show();
            this.Hide();

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

            AnalyzeForm analyzeForm = new AnalyzeForm(this);
            analyzeForm.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }

    }
}
