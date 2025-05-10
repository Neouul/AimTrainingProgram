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

        public float dpi = 800f;
        public int lolSens = 65;
        public float sensitivityScale; // 생성자에서 설정

        Point lastMousePos;


        public TargetingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (lolSens <= 10) sensitivityScale = (lolSens / 5) / 32f;
            else if (lolSens < 55) sensitivityScale = (lolSens / 5 - 2) / 8f;
            else sensitivityScale = (lolSens / 5 - 6) / 4f;
            lastMousePos = new Point(this.Width / 2, this.Height / 2);
          
            this.previousForm = previousForm;
        }

        public TargetingForm() : this(null) { }


        private void TargetingForm_Load(object sender, EventArgs e)
        {
            HideCursor();
        }

        private void HideCursor()
        {
            Bitmap bmp = new Bitmap(1, 1); // 1x1 투명 비트맵
            IntPtr ptr = bmp.GetHicon();
            Cursor transparentCursor = new Cursor(ptr);
            this.Cursor = transparentCursor;
            //panel1.Cursor = transparentCursor;
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

        public void SensInScreen(object sender, MouseEventArgs e)
        {
            int dx = e.X - lastMousePos.X;
            int dy = e.Y - lastMousePos.Y;

            float scaledDx = dx * sensitivityScale;
            float scaledDy = dy * sensitivityScale;

            AimTarget.Location = new Point(
                AimTarget.Location.X + (int)scaledDx,
                AimTarget.Location.Y + (int)scaledDy
            );

            lastMousePos = e.Location;
        }
    }
}
