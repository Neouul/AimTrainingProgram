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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AimTrainingProgram
{
    public partial class PlayForm : Form
    {
        private Form previousForm;

        public PlayForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            previousForm = previous;
        }

        public PlayForm() : this(null) { }

  


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

        

        private void PlayForm_Load(object sender, EventArgs e)
        {

            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AimTrainingProgram\GameSensitivities");
                if (rk != null)
                {
                    // 🎯 PC 제어판 감도 로드
                    object value = rk.GetValue("PcSens");
                    if (value != null && int.TryParse(value.ToString(), out int result))
                        SettingForm.ControlPanelSpeed = result;

                    // 🎯 마지막 선택된 게임 이름 로드
                    object lastCombo = rk.GetValue("LastSelectedCombo");
                    if (lastCombo != null)
                    {
                        string gameName = lastCombo.ToString();

                        // 🎯 해당 게임에 대한 감도값 로드
                        object gameSensi = rk.GetValue($"GameSensi_{gameName}");
                        if (gameSensi != null && float.TryParse(gameSensi.ToString(), out float parsed))
                        {
                            SettingForm.GameSensitivity = parsed;
                        }
                    }

                    rk.Close(); // 레지스트리 닫기
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("레지스트리 불러오기 실패: " + ex.Message);
            }
        }
        

        private void btnTargeting_Click(object sender, EventArgs e)
        {
            TargetingForm targetingform = new TargetingForm(this);
            targetingform.Show();
            this.Hide();
        }

        private void btnMoving_Click(object sender, EventArgs e)
        {
            MovingForm movingform = new MovingForm(this);
            movingform.Show();
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }

        private void btnNontargeting_Click(object sender, EventArgs e)
        {
            NontargetingForm nontargetingForm = new NontargetingForm(this);
            nontargetingForm.Show();
            this.Hide();
        }
    }

}
