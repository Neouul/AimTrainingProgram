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
    public partial class TargetingForm: Form
    {
        private Form previousForm;

        public TargetingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

          
            this.previousForm = previousForm;
        }
        public TargetingForm() : this(null) { }


        private void TargetingForm_Load(object sender, EventArgs e)
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Close();
        }
    }
}
