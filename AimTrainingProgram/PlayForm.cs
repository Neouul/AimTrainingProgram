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
            NonTargetForm nonTargetForm = new NonTargetForm();
            nonTargetForm.Show();
            this.Hide();
        }
    }

}
