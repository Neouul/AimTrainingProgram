using System;
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

    public partial class SettingForm: Form
    {
        private Form previousForm;

        public static int GameSensitivity;
        public static int ControlPanelSpeed;
        public enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        public static string LastPcSens = "";
        public static string LastGameSens = "";
        public static string LastSelectedCombo = "";

        public static Difficulty SelectedDifficulty = Difficulty.Easy;

        public SettingForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            previousForm = previous;


        }

        public SettingForm() : this(null) { }




        private void btnBack_Click(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            PcSens.Text = LastPcSens;
            GameSens.Text = LastGameSens;
            comboBox1.Text = LastSelectedCombo;
            comboBox1.SelectedItem = LastSelectedCombo;


            switch (SelectedDifficulty)
            {
                case Difficulty.Easy: radioEasy.Checked = true; break;
                case Difficulty.Normal: radioNormal.Checked = true; break;
                case Difficulty.Hard: radioHard.Checked = true; break;
            }
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

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzeForm analyzeForm = new AnalyzeForm(this);
            analyzeForm.Show();
            this.Hide();

        }

        private void PcSens_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(PcSens.Text, out int value))
                SettingForm.ControlPanelSpeed = value;
        }

        private void GameSens_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(GameSens.Text, out int value))
                SettingForm.GameSensitivity = value;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PcSens.Text, out int value))
                SettingForm.ControlPanelSpeed = value;

            if (int.TryParse(GameSens.Text, out int value2))
                SettingForm.GameSensitivity = value2;

            LastPcSens = PcSens.Text;
            LastGameSens = GameSens.Text;
            LastSelectedCombo = comboBox1.Text;

            if (radioEasy.Checked)
                SelectedDifficulty = Difficulty.Easy;
            else if (radioNormal.Checked)
                SelectedDifficulty = Difficulty.Normal;
            else if (radioHard.Checked)
                SelectedDifficulty = Difficulty.Hard;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PcSens.Text, out int value))
                ControlPanelSpeed = value;

            if (int.TryParse(GameSens.Text, out int value2))
                GameSensitivity = value2;

            // 라디오 버튼 상태 저장
            if (radioEasy.Checked)
                SelectedDifficulty = Difficulty.Easy;
            else if (radioNormal.Checked)
                SelectedDifficulty = Difficulty.Normal;
            else if (radioHard.Checked)
                SelectedDifficulty = Difficulty.Hard;
        }
    }
}
