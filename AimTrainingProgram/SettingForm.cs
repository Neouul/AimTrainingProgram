using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AimTrainingProgram
{

    public partial class SettingForm: Form
    {
        private Form previousForm;

        public static float GameSensitivity;
        public static int ControlPanelSpeed;
        public enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        private Dictionary<string, string> gameSensMap = new Dictionary<string, string>();

        public static string LastPcSens = "";
        public static string LastGameSens = "";
        public static string LastSelectedCombo = "";

        public static Difficulty SelectedDifficulty = Difficulty.Easy;

        public SettingForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            PcSens.Text = Convert.ToString(SettingForm.ControlPanelSpeed);

            LoadGameSensFromReg();

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

            LoadGameSensFromReg();

            PcSens.Text = LastPcSens;
            GameSens.Text = LastGameSens;
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
            if (float.TryParse(GameSens.Text, out float value))
                SettingForm.GameSensitivity = value;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(PcSens.Text, out int value))
                SettingForm.ControlPanelSpeed = value;

            if (float.TryParse(GameSens.Text, out float value2))
                SettingForm.GameSensitivity = value2;
            LastPcSens = PcSens.Text;
            if (!string.IsNullOrWhiteSpace(LastSelectedCombo))
                gameSensMap[LastSelectedCombo] = GameSens.Text;

            SaveGameSensToReg();

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

            if (float.TryParse(GameSens.Text, out float value2))
                GameSensitivity = value2;

            // 라디오 버튼 상태 저장
            if (radioEasy.Checked)
                SelectedDifficulty = Difficulty.Easy;
            else if (radioNormal.Checked)
                SelectedDifficulty = Difficulty.Normal;
            else if (radioHard.Checked)
                SelectedDifficulty = Difficulty.Hard;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prevGame = LastSelectedCombo;
            string currentGame = comboBox1.SelectedItem.ToString();

            // ✅ 이전 게임 감도 캐시
            if (!string.IsNullOrWhiteSpace(prevGame))
                gameSensMap[prevGame] = GameSens.Text;

            // ✅ 현재 게임 감도 불러오기
            if (gameSensMap.ContainsKey(currentGame))
                GameSens.Text = gameSensMap[currentGame];
            else
                GameSens.Text = "";

            LastSelectedCombo = currentGame;

            if (float.TryParse(GameSens.Text, out float value))
                SettingForm.GameSensitivity = value;
        }

        private void SaveGameSensToReg()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AimTrainingProgram\GameSensitivities");

                foreach (var pair in gameSensMap)
                {
                    string gameName = pair.Key;
                    string sens = pair.Value;
                    rk.SetValue($"GameSensi_{gameName}", sens);
                }

                var PcSens = Convert.ToString(SettingForm.ControlPanelSpeed);
                rk.SetValue("PcSens", PcSens);

                rk.SetValue("LastSelectedCombo", LastSelectedCombo);

                rk.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("레지스트리 저장 실패: " + ex.Message);
            }
        }

        private void LoadGameSensFromReg()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AimTrainingProgram\GameSensitivities");
                if (rk != null)
                {
                    foreach (string game in comboBox1.Items)
                    {
                        object val = rk.GetValue($"GameSensi_{game}");
                        if (val != null)
                            gameSensMap[game] = val.ToString();
                    }

                    object value = rk.GetValue("PcSens");
                    if (value != null && int.TryParse(value.ToString(), out int result))
                        SettingForm.ControlPanelSpeed = result;
                    LastPcSens = Convert.ToString(SettingForm.ControlPanelSpeed);
                    PcSens.Text = LastPcSens;

                    object lastCombo = rk.GetValue("LastSelectedCombo");
                    if (lastCombo != null)
                    {
                        LastSelectedCombo = lastCombo.ToString();

                        comboBox1.SelectedItem = LastSelectedCombo;
                        if (gameSensMap.TryGetValue(LastSelectedCombo, out string sens))
                        {
                            GameSens.Text = sens;
                            LastGameSens = sens;

                            if (float.TryParse(sens, out float parsed))
                            {
                                GameSensitivity = parsed;
                            }
                            else
                            {
                                GameSens.Text = "";
                            }
                        }

                        rk.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("레지스트리 불러오기 실패: " + ex.Message);
            }
        }


    }
}
