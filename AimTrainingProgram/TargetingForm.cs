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
{    public partial class TargetingForm: Form
    {
        private Form previousForm;

        private int lolSens = SettingForm.GameSensitivity;
        private int pcSens = SettingForm.ControlPanelSpeed;
        private float sensitivityScale; // 생성자에서 설정

        Point lastMousePos;


        public TargetingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            if (lolSens <= 10) sensitivityScale = (lolSens / 5) / 32f;
            else if (lolSens < 55) sensitivityScale = (lolSens / 5 - 2) / 8f;
            else sensitivityScale = (lolSens / 5 - 6) / 4f;

            switch (pcSens)
            {
                case 1:
                    sensitivityScale /= 0.03125f;
                    break;
                case 2:
                    sensitivityScale /= 0.125f;
                    break;
                case 3:
                    sensitivityScale /= 0.25f;
                    break;
                case 4:
                    sensitivityScale /= 0.5f;
                    break;
                case 5:
                    sensitivityScale /= 0.75f;
                    break;
                case 7:
                    sensitivityScale /= 1.5f;
                    break;
                case 8:
                    sensitivityScale /= 2.0f;
                    break;
                case 9:
                    sensitivityScale /= 2.5f;
                    break;
                case 10:
                    sensitivityScale /= 3.0f;
                    break;
                case 11:
                    sensitivityScale /= 3.5f;
                    break;
            }

            lastMousePos = new Point(this.Width / 2, this.Height / 2);

            this.previousForm = previousForm;
        }
        public TargetingForm() : this(null) { }


        private void TargetingForm_Load(object sender, EventArgs e)
        {
            // 폼 클라이언트 영역 중심 위치 계산
            Point center = new Point(this.Width / 2, this.Height / 2);
            // 커서 위치 설정 (스크린 좌표 기준)
            Cursor.Position = center;
            int pointerLeft = (this.ClientSize.Width - MousePointer.Width) / 2;
            int pointerTop = (this.ClientSize.Height - MousePointer.Height) / 2;
            MousePointer.Left = pointerLeft;
            MousePointer.Top = pointerTop;
            lastMousePos = new Point(pointerLeft, pointerTop);

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

        private bool isCursorHidden = true; // 현재 커서 숨겨진 상태인지 추적

        public void SensInScreen(object sender, MouseEventArgs e)
        {
            int dx = e.X - lastMousePos.X;
            int dy = e.Y - lastMousePos.Y;

            float scaledDx = dx * sensitivityScale;
            float scaledDy = dy * sensitivityScale;

            MousePointer.Location = new Point(
                MousePointer.Location.X + (int)scaledDx,
                MousePointer.Location.Y + (int)scaledDy
            );

            lastMousePos = e.Location;

            lastMousePos = e.Location;

            HandleCursorVisibility(); // 이동 후 커서 상태 갱신
        }

        private void HandleCursorVisibility()
        {
            int thresholdY = 50; // 예: 50픽셀보다 위로 가면 커서 보임

            if (MousePointer.Top < thresholdY && isCursorHidden)
            {
                // 커서 보이게
                this.Cursor = Cursors.Default;
                isCursorHidden = false;
            }
            else if (MousePointer.Top >= thresholdY && !isCursorHidden)
            {
                // 커서 숨기기
                HideCursor();
                isCursorHidden = true;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
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
    }
}
