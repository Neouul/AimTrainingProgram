<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AimTrainingProgram
{
    public partial class AnalyzeForm: Form
    {
        private Form previousForm;

        public AnalyzeForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            previousForm = previous;
        }

        public AnalyzeForm() : this(null) { }




        private void btnBack_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(this);
            playForm.Show();
            this.Hide();

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm(this);
            scoreForm.Show();
            this.Hide();

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AimTrainingProgram.Data;
using AimTrainingProgram.Data.AimTrainingProgram.Data;

namespace AimTrainingProgram
{
    public partial class AnalyzeForm : Form
    {
        private Form previousForm;
        private List<TargetHitRecord> records;

        public AnalyzeForm(Form previous, List<TargetHitRecord> records)
        {
            InitializeComponent();
            this.records = records;
            this.previousForm = previous;
            AnalyzeHitMap();
        }

        public AnalyzeForm() : this(null, new List<TargetHitRecord>()) { }
        public AnalyzeForm(Form previous) : this(previous, new List<TargetHitRecord>()) { }

        private void LoadAnalysisData()
        {
            List<ScoreData> scores = DataManager.LoadScores();

            if (scores.Count == 0)
            {
                MessageBox.Show("데이터가 없습니다.");
                return;
            }

            DisplayDatewiseAverage(scores);
            DisplaySensitivitywiseAverage(scores);
        }

        private void DisplayDatewiseAverage(List<ScoreData> scores) { }
        private void DisplaySensitivitywiseAverage(List<ScoreData> scores) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            comboModeSelect.SelectedIndexChanged += ComboModeSelect_SelectedIndexChanged;
            AnalyzeAndDisplayRecommendation();
            comboModeSelect.SelectedIndex = 0;
            ComboModeSelect_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void ComboModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnalyzeAndDisplayRecommendation();
            var scores = DataManager.LoadScores();
            DisplayDateAverage(scores);
        }

        private void AnalyzeAndDisplayRecommendation()
        {
            string selectedMode = comboModeSelect.SelectedItem?.ToString() ?? "Targeting";
            var scores = DataManager.LoadScores()
                .Where(s => s.Mode == selectedMode)
                .ToList();

            if (scores.Count == 0)
            {
                labelRecommendation.Text = "분석할 데이터가 없습니다.";
                return;
            }

            float GetDifficultyWeight(string difficulty)
            {
                switch (difficulty)
                {
                    case "Easy": return 1f;
                    case "Normal": return 2f;
                    case "Hard": return 3f;
                    default: return 1f;
                }
            }

            var grouped = scores
                .GroupBy(s => s.GameSensitivity)
                .Select(g =>
                {
                    double weightedScoreSum = 0;
                    double weightSum = 0;
                    foreach (var s in g)
                    {
                        float weight = GetDifficultyWeight(s.Difficulty);
                        weightedScoreSum += s.Score * weight;
                        weightSum += weight;
                    }

                    double avgWeightedScore = weightSum > 0 ? weightedScoreSum / weightSum : 0;

                    double stdDev = Math.Sqrt(g.Average(x =>
                    {
                        float weight = GetDifficultyWeight(x.Difficulty);
                        return Math.Pow(x.Score - avgWeightedScore, 2) * weight;
                    }));

                    return new
                    {
                        Sensitivity = g.Key,
                        Avg = avgWeightedScore,
                        StdDev = stdDev,
                        Count = g.Count()
                    };
                })
                .ToList();

            var best = grouped
                .OrderByDescending(g => g.Avg * g.Count)
                .First();

            var highScoring = grouped
                .Where(g => g.Avg >= 8)
                .OrderBy(g => g.Sensitivity)
                .ToList();

            float rangeMin = highScoring.FirstOrDefault()?.Sensitivity ?? best.Sensitivity;
            float rangeMax = highScoring.LastOrDefault()?.Sensitivity ?? best.Sensitivity;

            labelRecommendation.Text = $"당신의 추천 감도 : {best.Sensitivity:F2}\n\n" +
                                       $"- 평균 점수 : {best.Avg:F1} / 10\n" +
                                       $"- 시도 횟수 : {best.Count}회\n" +
                                       $"- 표준편차 : ±{best.StdDev:F1}\n\n" +
                                       $"높은 점수를 기록한 감도 구간 :\n" +
                                       $"{rangeMin:F1} ~ {rangeMax:F1}";

            var difficultyLevels = new[] { "Easy", "Normal", "Hard" };

            var bestScores = scores
                .Where(s => Math.Abs(s.GameSensitivity - best.Sensitivity) < 0.0001f)
                .ToList();

            Dictionary<string, double> avgByDifficulty = new Dictionary<string, double>();
            foreach (var level in difficultyLevels)
            {
                var levelScores = bestScores
                    .Where(s => s.Difficulty.Trim().Equals(level, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (levelScores.Count > 0)
                    avgByDifficulty[level] = levelScores.Average(s => s.Score);
                else
                    avgByDifficulty[level] = 0;
            }

            chartDifficultyStats.Series.Clear();
            chartDifficultyStats.ChartAreas.Clear();
            chartDifficultyStats.Titles.Clear();

            chartDifficultyStats.ChartAreas.Add(new ChartArea("Main"));
            var series = new Series("평균 점수")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (var level in difficultyLevels)
            {
                series.Points.AddXY(level, avgByDifficulty[level]);
            }

            chartDifficultyStats.Series.Add(series);
            chartDifficultyStats.Titles.Add($"추천 감도 {best.Sensitivity:F2}의 난이도별 평균 점수");
        }

        private void AnalyzeHitMap()
        {
            var recentRecords = DataManager.LoadRecentHitRecords();

            int mapWidth = 800;
            int mapHeight = 600;
            Bitmap map = new Bitmap(mapWidth, mapHeight);

            using (Graphics g = Graphics.FromImage(map))
            {
                g.Clear(Color.White);

                if (recentRecords.Count == 0)
                {
                    g.DrawString("최근 기록이 없습니다.", new Font("Segoe UI", 14), Brushes.Gray, new PointF(200, 280));
                }
                else
                {
                    foreach (var record in recentRecords)
                    {
                        int x = Math.Min(mapWidth - 10, Math.Max(0, record.Position.X / 2));
                        int y = Math.Min(mapHeight - 10, Math.Max(0, record.Position.Y / 2));
                        Brush brush = record.IsHit ? Brushes.Green : Brushes.Red;
                        g.FillEllipse(brush, x - 5, y - 5, 12, 12);
                    }
                }
            }

            pictureBox1.Image = map;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Invalidate();
            pictureBox1.Refresh();
        }

        // 약점 구역 분석 및 파일 저장
        private void AnalyzeAndSaveWeakZones()
        {
            var recentRecords = DataManager.LoadRecentHitRecords();
            int gridX = 3, gridY = 2;
            int mapWidth = 800, mapHeight = 600;
            int[,] hitCount = new int[gridX, gridY];
            int[,] totalCount = new int[gridX, gridY];

            foreach (var record in recentRecords)
            {
                int xIdx = Math.Min(gridX - 1, record.Position.X * gridX / mapWidth);
                int yIdx = Math.Min(gridY - 1, record.Position.Y * gridY / mapHeight);
                totalCount[xIdx, yIdx]++;
                if (record.IsHit) hitCount[xIdx, yIdx]++;
            }

            List<(int x, int y)> weakZones = new List<(int, int)>();
            for (int x = 0; x < gridX; x++)
                for (int y = 0; y < gridY; y++)
                    if (totalCount[x, y] > 0 && (float)hitCount[x, y] / totalCount[x, y] < 0.5f)
                        weakZones.Add((x, y));

            File.WriteAllText("weakzones.txt",
                string.Join(";", weakZones.Select(z => $"{z.x},{z.y}")));
        }

        private void btnAnalyzeWeakZones_Click(object sender, EventArgs e)
        {
            AnalyzeAndSaveWeakZones();
            MessageBox.Show("약점 구역 분석 및 저장 완료!");
        }

        private void AnalyzeForm_Activated(object sender, EventArgs e)
        {
            LoadAnalysisData();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(this);
            playForm.Show();
            this.Hide();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm(this);
            scoreForm.Show();
            this.Hide();
        }

        private void btnClearRecords_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("기록을 초기화하시겠습니까?", "확인", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DataManager.ClearHitRecords();
                MessageBox.Show("기록이 초기화되었습니다.");
                AnalyzeHitMap();
            }
        }

        private void DisplayDateAverage(List<ScoreData> scores)
        {
            string selectedMode = comboModeSelect.SelectedItem?.ToString() ?? "Targeting";
            var filtered = scores
                .Where(s => s.Mode == selectedMode)
                .ToList();

            if (filtered.Count == 0)
            {
                chartDateScores.Series.Clear();
                chartDateScores.Titles.Clear();
                chartDateScores.ChartAreas.Clear();
                return;
            }

            var grouped = filtered
                .GroupBy(s => s.Date.ToString("MM/dd"))
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    DateLabel = g.Key,
                    Average = g.Average(s => s.Score)
                })
                .ToList();

            chartDateScores.Series.Clear();
            chartDateScores.ChartAreas.Clear();
            chartDateScores.Titles.Clear();

            ChartArea area = new ChartArea("DateArea");
            area.AxisX.Interval = 1;
            chartDateScores.ChartAreas.Add(area);

            Series series = new Series("날짜별 평균 점수")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            foreach (var entry in grouped)
            {
                series.Points.AddXY(entry.DateLabel, entry.Average);
            }

            chartDateScores.Series.Add(series);
            chartDateScores.Titles.Add($"{selectedMode} 모드 - 날짜별 평균 점수");
        }
    }
}
>>>>>>> Stashed changes
