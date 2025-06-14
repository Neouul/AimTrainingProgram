using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            AnalyzeHitMap(); // 로딩 시 분석 실행
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

        private void DisplayDatewiseAverage(List<ScoreData> scores)
        {

        }
        private void DisplaySensitivitywiseAverage(List<ScoreData> scores)
        {

        }

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
            comboModeSelect.SelectedIndex = 0;

            comboModeSelect.SelectedIndexChanged += ComboModeSelect_SelectedIndexChanged;

            AnalyzeAndDisplayRecommendation();

            LoadAnalysisData();
        }
        private void ComboModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnalyzeAndDisplayRecommendation();
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

            // 감도별 그룹
            var grouped = scores
                .GroupBy(s => s.GameSensitivity)
                .Select(g => new
                {
                    Sensitivity = g.Key,
                    Avg = g.Average(x => x.Score),
                    StdDev = Math.Sqrt(g.Average(x => Math.Pow(x.Score - g.Average(y => y.Score), 2))),
                    Count = g.Count()
                })
                .ToList();

            // 추천 감도 (가중 평균 방식)
            var best = grouped
                .OrderByDescending(g => g.Avg * g.Count)
                .First();

            // 고득점 감도 범위 탐색 (예: 평균 8 이상)
            var highScoring = grouped
                .Where(g => g.Avg >= 8)
                .OrderBy(g => g.Sensitivity)
                .ToList();

            float rangeMin = highScoring.FirstOrDefault()?.Sensitivity ?? best.Sensitivity;
            float rangeMax = highScoring.LastOrDefault()?.Sensitivity ?? best.Sensitivity;

            // 결과 텍스트 구성
            labelRecommendation.Text = $"당신의 추천 감도: {best.Sensitivity:F2}\n\n" +
                                       $"- 평균 점수: {best.Avg:F1} / 10\n" +
                                       $"- 시도 횟수: {best.Count}회\n" +
                                       $"- 표준편차: ±{best.StdDev:F1}\n\n" +
                                       $"높은 점수를 기록한 감도 구간:\n" +
                                       $"{rangeMin:F1} ~ {rangeMax:F1}";
        }
        private void AnalyzeHitMap()
        {
            var recentRecords = DataManager.LoadRecentHitRecords(5);

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




        //버튼
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
                AnalyzeHitMap(); // PictureBox 갱신
            }
        }
    }
}