using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AimTrainingProgram
{
    public partial class MovingForm : Form
    {
        private Form previousForm;

        // 커스텀 포인터 관련 필드
        private Point lastMousePos;
        private Point pointerPosition = Point.Empty;
        private Bitmap pointerBitmap = Properties.Resources.pointer; // 포인터 이미지
        private float sensitivityScale = 1.0f;
        private float accumulatedDx = 0;
        private float accumulatedDy = 0;

        // player 이동 관련 필드
        private Point playerTargetPosition;
        private Timer playerMoveTimer;
        private int playerMoveSpeed = 8; // 픽셀/틱 (속도 증가!)

        // target 관련 필드 (3개)
        private PointF[] targetDirections = new PointF[3];
        private float[] targetSpeeds = new float[3];
        private Timer[] targetMoveTimers = new Timer[3];
        private float speedIncreaseRate = 0.5f; // 초당 증가 속도

        // 게임 시간 관련
        private Stopwatch gameStopwatch;
        private Timer uiTimer;

        // 랜덤 인스턴스 (중복 생성 방지)
        private Random rand = new Random();

        // UI 보호 상단 여백(px)
        private int safeTopMargin = 100;

        public MovingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            this.previousForm = previousForm;

            // 커스텀 포인터 초기화
            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            pointerPosition = new Point(center.X - 20, center.Y - 20);
            lastMousePos = center;
            this.MouseMove += SensInScreen;
            this.Paint += MovingForm_Paint;
            HideCursor();

            // player 이동 타이머
            playerMoveTimer = new Timer();
            playerMoveTimer.Interval = 20;
            playerMoveTimer.Tick += PlayerMoveTimer_Tick;
            this.MouseClick += MovingForm_MouseClick;
            playerTargetPosition = player.Location;

            // target 이동 타이머 및 방향/속도 초기화 (3개)
            for (int i = 0; i < 3; i++)
            {
                targetMoveTimers[i] = new Timer();
                targetMoveTimers[i].Interval = 20;
                int idx = i; // closure 문제 방지
                targetMoveTimers[i].Tick += (s, e) => TargetMoveTimer_Tick(idx);

                double angle = rand.NextDouble() * Math.PI * 2;
                targetDirections[i] = new PointF((float)Math.Cos(angle), (float)Math.Sin(angle));
                targetSpeeds[i] = 2.0f;
            }

            // 게임 시간 타이머
            gameStopwatch = new Stopwatch();
            uiTimer = new Timer();
            uiTimer.Interval = 100; // 0.1초마다 업데이트
            uiTimer.Tick += UiTimer_Tick;

            // 타겟 이미지 및 모양 설정 (필요시)
            // target.Image = Properties.Resources.targetImage;
            target.SizeMode = PictureBoxSizeMode.StretchImage;
            target1.SizeMode = PictureBoxSizeMode.StretchImage;
            target2.SizeMode = PictureBoxSizeMode.StretchImage;

            // 타겟1, 타겟2 비활성화
            target1.Visible = false;
            target2.Visible = false;

            // 게임 시작
            StartGame();
        }

        public MovingForm() : this(null) { }

        private void StartGame()
        {
            // 위치 초기화
            player.Location = new Point(this.ClientSize.Width / 2, safeTopMargin + 50);
            playerTargetPosition = player.Location;
            target.Location = new Point(100, safeTopMargin + 50);
            target1.Location = new Point(200, safeTopMargin + 150);
            target2.Location = new Point(300, safeTopMargin + 250);

            // 속도 초기화
            for (int i = 0; i < 3; i++)
                targetSpeeds[i] = 2.0f;

            // 타겟1, 타겟2 비활성화
            target1.Visible = false;
            target2.Visible = false;

            // 타이머 시작 (타겟0만)
            gameStopwatch.Restart();
            uiTimer.Start();
            targetMoveTimers[0].Start();
            targetMoveTimers[1].Stop();
            targetMoveTimers[2].Stop();
        }

        private void EndGame()
        {
            playerMoveTimer.Stop();
            foreach (var t in targetMoveTimers)
                t.Stop();
            uiTimer.Stop();
            gameStopwatch.Stop();
            MessageBox.Show($"Game Over! Time: {gameStopwatch.Elapsed:mm\\:ss\\.ff}");
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            moveScore.Text = gameStopwatch.Elapsed.ToString("mm\\:ss\\.ff");

            // 30초 경과시 target1 활성화
            if (!target1.Visible && gameStopwatch.Elapsed.TotalSeconds >= 30)
            {
                target1.Visible = true;
                targetMoveTimers[1].Start();
            }
            // 60초 경과시 target2 활성화
            if (!target2.Visible && gameStopwatch.Elapsed.TotalSeconds >= 60)
            {
                target2.Visible = true;
                targetMoveTimers[2].Start();
            }
        }

        // ----------- player 이동 (대각선 직선 경로) -----------

        private void MovingForm_MouseClick(object sender, MouseEventArgs e)
        {
            // player의 중심이 클릭 위치에 오도록 보정
            Point desired = new Point(
                e.X - player.Width / 2,
                e.Y - player.Height / 2
            );
            // 상단 안전영역 제한
            playerTargetPosition = ClampPosition(desired, player.Size);
            if (!playerMoveTimer.Enabled)
                playerMoveTimer.Start();
        }

        private void PlayerMoveTimer_Tick(object sender, EventArgs e)
        {
            int dx = playerTargetPosition.X - player.Location.X;
            int dy = playerTargetPosition.Y - player.Location.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance < playerMoveSpeed || distance == 0)
            {
                player.Location = playerTargetPosition;
                playerMoveTimer.Stop();
                return;
            }

            double directionX = dx / distance;
            double directionY = dy / distance;

            int moveX = (int)Math.Round(directionX * playerMoveSpeed);
            int moveY = (int)Math.Round(directionY * playerMoveSpeed);

            Point next = new Point(
                player.Location.X + moveX,
                player.Location.Y + moveY
            );
            // 상단 안전영역 제한
            player.Location = ClampPosition(next, player.Size);
        }

        // ----------- targets 이동 (튕김, 각도조절, 점점 빨라짐, UI영역 보호) -----------

        private void TargetMoveTimer_Tick(int idx)
        {
            // 타겟 PictureBox 인스턴스 선택
            PictureBox[] targets = { target, target1, target2 };
            if (!targets[idx].Visible) return;

            // 속도 증가 (초당 0.5씩)
            targetSpeeds[idx] = 2.0f + (float)gameStopwatch.Elapsed.TotalSeconds * speedIncreaseRate;

            // 새 위치 계산
            float newX = targets[idx].Location.X + targetDirections[idx].X * targetSpeeds[idx];
            float newY = targets[idx].Location.Y + targetDirections[idx].Y * targetSpeeds[idx];

            // 경계 체크 및 각도 조절
            bool bounced = false;
            if (newX < 0)
            {
                targetDirections[idx].X = -targetDirections[idx].X;
                bounced = true;
                newX = 0;
            }
            else if (newX + targets[idx].Width > ClientSize.Width)
            {
                targetDirections[idx].X = -targetDirections[idx].X;
                bounced = true;
                newX = ClientSize.Width - targets[idx].Width;
            }

            if (newY < safeTopMargin)
            {
                targetDirections[idx].Y = -targetDirections[idx].Y;
                bounced = true;
                newY = safeTopMargin;
            }
            else if (newY + targets[idx].Height > ClientSize.Height)
            {
                targetDirections[idx].Y = -targetDirections[idx].Y;
                bounced = true;
                newY = ClientSize.Height - targets[idx].Height;
            }

            // 튕길 때 각도 조절 (±30도)
            if (bounced)
            {
                double angleOffset = rand.Next(-30, 31) * (Math.PI / 180); // -30~+30도
                double currentAngle = Math.Atan2(targetDirections[idx].Y, targetDirections[idx].X);
                double newAngle = currentAngle + angleOffset;

                targetDirections[idx].X = (float)Math.Cos(newAngle);
                targetDirections[idx].Y = (float)Math.Sin(newAngle);
            }

            // 위치 업데이트 (상단 안전영역 제한)
            targets[idx].Location = ClampPosition(new Point((int)newX, (int)newY), targets[idx].Size);

            // 충돌 체크
            if (player.Bounds.IntersectsWith(targets[idx].Bounds))
            {
                EndGame();
            }
        }

        // ----------- 안전영역 제한 함수 -----------

        private Point ClampPosition(Point position, Size size)
        {
            int x = Math.Max(0, Math.Min(position.X, ClientSize.Width - size.Width));
            int y = Math.Max(safeTopMargin, Math.Min(position.Y, ClientSize.Height - size.Height));
            return new Point(x, y);
        }

        // ----------- 커스텀 포인터 -----------

        private void SensInScreen(object sender, MouseEventArgs e)
        {
            int dx = e.X - lastMousePos.X;
            int dy = e.Y - lastMousePos.Y;

            float scaledDx = dx * sensitivityScale;
            float scaledDy = dy * sensitivityScale;

            accumulatedDx += scaledDx;
            accumulatedDy += scaledDy;

            int moveX = (int)accumulatedDx;
            int moveY = (int)accumulatedDy;

            if (moveX != 0 || moveY != 0)
            {
                pointerPosition = new Point(pointerPosition.X + moveX, pointerPosition.Y + moveY);
                accumulatedDx -= moveX;
                accumulatedDy -= moveY;
                Invalidate();
            }
            lastMousePos = e.Location;
        }

        private void MovingForm_Paint(object sender, PaintEventArgs e)
        {
            int originalW = pointerBitmap.Width;
            int originalH = pointerBitmap.Height;
            float scale = 0.8f;
            int newW = (int)(originalW * scale);
            int newH = (int)(originalH * scale);

            e.Graphics.DrawImage(pointerBitmap, pointerPosition.X, pointerPosition.Y, newW, newH);
        }

        private void HideCursor()
        {
            Bitmap bmp = new Bitmap(1, 1);
            IntPtr ptr = bmp.GetHicon();
            Cursor transparentCursor = new Cursor(ptr);
            this.Cursor = transparentCursor;
        }

        // ----------- 기존 버튼 이벤트 등 -----------

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

        private void MousePointer_Click(object sender, EventArgs e)
        {

        }
        private void MovingForm_Load(object sender, EventArgs e)
        {

        }


        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
