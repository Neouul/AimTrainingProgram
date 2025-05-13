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


namespace AimTrainingProgram
{
    public partial class AnalyzeForm : Form
    {
        private Form previousForm;

        public AnalyzeForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            previousForm = previous;
            LoadAnalysisData();
        }

        public AnalyzeForm() : this(null) { }

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
            var datewiseAverage = scores
                .GroupBy(s => s.Date.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    AverageScore = g.Average(s => s.Score)
                })
                .OrderByDescending(g => g.Date)
                .ToList();

            listBoxDatewise.Items.Clear();
            foreach (var entry in datewiseAverage)
            {
                listBoxDatewise.Items.Add($"{entry.Date:yyyy-MM-dd}: 평균 점수 {entry.AverageScore:F2}");
            }
        }
        private void DisplaySensitivitywiseAverage(List<ScoreData> scores)
        {
            var senswiseAverage = scores
                .GroupBy(s => s.GameSensitivity)
                .Select(g => new
                {
                    Sensitivity = g.Key,
                    AverageScore = g.Average(s => s.Score)
                })
                .OrderBy(g => g.Sensitivity)
                .ToList();

            listBoxSensitivitywise.Items.Clear();
            foreach (var entry in senswiseAverage)
            {
                listBoxSensitivitywise.Items.Add($"감도 {entry.Sensitivity}: 평균 점수 {entry.AverageScore:F2}");
            }
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