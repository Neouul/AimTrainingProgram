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
    public partial class ScoreForm: Form
    {
        private Form previousForm;

        public ScoreForm(Form previous)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            previousForm = previous;
        }

        public ScoreForm() : this(null) { }
   

 

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (previousForm != null)
            {
                previousForm.Show();
            }
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm(this);
            playForm.Show();
            this.Hide();

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            AnalyzeForm analyzeForm = new AnalyzeForm(this);
            analyzeForm.Show();
            this.Hide();

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }
    }
}
