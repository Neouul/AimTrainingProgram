using System;
using System.Drawing;
using System.Windows.Forms;

namespace AimTrainingProgram
{
    public partial class MovingForm : Form
    {
        // --- 추가된 필드 ---
        private Form previousForm;

        // 게임 설정
        private const int MAX_ATTEMPTS = 10;
        private const float BLITZ_Q_SPEED = 12f;
        private const int BLITZ_Q_RANGE = 350;
        private const int FLASH_DISTANCE = 150;

        // 게임 상태
        private int attempts = 0;
        private int successes = 0;
        private bool isProjectileActive = false;
        private bool gameOver = false;

        // 발사체 관련
        private PointF projectileDirection;
        private Timer projectileTimer = new Timer();
        private Timer shootDelayTimer = new Timer();

        // 플레이어 이동
        private Point playerTargetPosition;
        private Timer playerMoveTimer;
        private int playerMoveSpeed = 8;

        // 기타
        private Random rand = new Random();

        // 커스텀 포인터 관련 필드 (필요시)
        private Point lastMousePos;
        private Point pointerPosition = Point.Empty;
        private Bitmap pointerBitmap = Properties.Resources.pointer;
        private float sensitivityScale = 1.0f;
        private float accumulatedDx = 0;
        private float accumulatedDy = 0;

        // --- 생성자 ---
        public MovingForm(Form previousForm)
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            this.FormClosing += MovingForm_FormClosing;

            // 플레이어 초기 위치
            player.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            playerTargetPosition = player.Location;

            // 타이머 설정
            projectileTimer.Interval = 16;
            projectileTimer.Tick += ProjectileTimer_Tick;

            shootDelayTimer.Interval = rand.Next(100, 500);
            shootDelayTimer.Tick += ShootDelayTimer_Tick;

            playerMoveTimer = new Timer();
            playerMoveTimer.Interval = 20;
            playerMoveTimer.Tick += PlayerMoveTimer_Tick;

            target.Visible = false;

            // 커스텀 포인터
            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            pointerPosition = new Point(center.X - 20, center.Y - 20);
            lastMousePos = center;
            this.MouseMove += SensInScreen;
            this.Paint += MovingForm_Paint;
            HideCursor();

            // 마우스 클릭 이동
            this.MouseClick += MovingForm_MouseClick;

            btnRestart.Click += btnRestart_Click_1;
           
            StartGame();
            this.previousForm = previousForm;
        }

        public MovingForm() : this(null) { }

        private void StartGame()
        {
            attempts = 0;
            successes = 0;
            UpdateScoreDisplay();
            ResetPositions();
            isProjectileActive = false;
            gameOver = false;
            btnRestart.Enabled = false;
        }

        private void ResetPositions()
        {
            player.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            playerTargetPosition = player.Location;
            MoveBotToRandomPosition();
            target.Visible = false;
        }

        private void MoveBotToRandomPosition()
        {
            bot.Location = GetRandomPositionInRange(player.Location, BLITZ_Q_RANGE);
            shootDelayTimer.Stop();
            shootDelayTimer.Interval = rand.Next(500, 1000);
            shootDelayTimer.Start();
        }

        private void ShootDelayTimer_Tick(object sender, EventArgs e)
        {
            shootDelayTimer.Stop();
            StartProjectile();
        }

        private void StartProjectile()
        {
            if (gameOver) return;

            target.Location = bot.Location;
            target.Visible = true;

            Point start = bot.Location;
            Point targetPos = player.Location;

            float dx = targetPos.X - start.X;
            float dy = targetPos.Y - start.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            projectileDirection = new PointF(dx / distance, dy / distance);

            isProjectileActive = true;
            projectileTimer.Start();
        }

        private void ProjectileTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            float newX = target.Location.X + projectileDirection.X * BLITZ_Q_SPEED;
            float newY = target.Location.Y + projectileDirection.Y * BLITZ_Q_SPEED;

            // 화면 경계 제한
            newX = Clamp((int)newX, 0, ClientSize.Width - target.Width);
            newY = Clamp((int)newY, 100, ClientSize.Height - target.Height);

            target.Location = new Point((int)newX, (int)newY);

            // 충돌 체크
            if (target.Bounds.IntersectsWith(player.Bounds))
            {
                projectileTimer.Stop();
                target.Visible = false;
                isProjectileActive = false;
                attempts++;
                UpdateScoreDisplay();
                NextAttempt();
                return;
            }

            // Q가 사정거리 벗어나면 성공
            if (Distance(bot.Location, target.Location) > BLITZ_Q_RANGE)
            {
                projectileTimer.Stop();
                target.Visible = false;
                isProjectileActive = false;
                attempts++;
                successes++;
                UpdateScoreDisplay();
                NextAttempt();
                return;
            }
        }

        private void NextAttempt()
        {
            if (attempts >= MAX_ATTEMPTS)
            {
                EndGame();
                return;
            }
            MoveBotToRandomPosition();
        }

        private void EndGame()
        {
            projectileTimer.Stop();
            shootDelayTimer.Stop();
            playerMoveTimer.Stop();
            isProjectileActive = false;
            gameOver = true;
            btnRestart.Enabled = true;
            MessageBox.Show($"게임 종료! 성공: {successes}/{MAX_ATTEMPTS}");
        }

        private void btnRestart_Click_1(object sender, EventArgs e) // 추가
        {
            if (!gameOver) return;
            StartGame();
        }

        private void UpdateScoreDisplay()
        {
            lblScore.Text = $"{successes}/{MAX_ATTEMPTS}";
        }

        private Point GetRandomPositionInRange(Point center, int range)
        {
            int angle = rand.Next(0, 360);
            int distance = rand.Next(range / 2, range);

            int x = center.X + (int)(distance * Math.Cos(angle * Math.PI / 180));
            int y = center.Y + (int)(distance * Math.Sin(angle * Math.PI / 180));
            x = Clamp(x, 0, ClientSize.Width - bot.Width);
            y = Clamp(y, 100, ClientSize.Height - bot.Height);
            return new Point(x, y);
        }

        private double Distance(Point a, Point b)
        {
            int dx = a.X - b.X;
            int dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private void MovingForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameOver) return;

            Point clientPos = this.PointToClient(Cursor.Position);
            Point desired = new Point(clientPos.X - player.Width / 2, clientPos.Y - player.Height / 2);
            playerTargetPosition = ClampPosition(desired, player.Size);

            if (!playerMoveTimer.Enabled)
                playerMoveTimer.Start();
        }

        private void PlayerMoveTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

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

            Point next = new Point(player.Location.X + moveX, player.Location.Y + moveY);
            player.Location = ClampPosition(next, player.Size);
        }

        private Point ClampPosition(Point position, Size size)
        {
            int safeTopMargin = 100;
            int x = Clamp(position.X, 0, ClientSize.Width - size.Width);
            int y = Clamp(position.Y, safeTopMargin, ClientSize.Height - size.Height);
            return new Point(x, y);
        }

        private int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : value > max ? max : value;
        }

        // 점멸 기능 (D/F 키)
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (gameOver) return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.D || keyData == Keys.F)
            {
                Flash();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Flash()
        {
            int dx = playerTargetPosition.X - player.Location.X;
            int dy = playerTargetPosition.Y - player.Location.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance == 0) return;

            int moveX = (int)((dx / distance) * FLASH_DISTANCE);
            int moveY = (int)((dy / distance) * FLASH_DISTANCE);

            Point newPos = new Point(player.Location.X + moveX, player.Location.Y + moveY);
            player.Location = ClampPosition(newPos, player.Size);
            playerTargetPosition = player.Location;
        }

        // 커스텀 포인터 등
        private void MovingForm_Paint(object sender, PaintEventArgs e)
        {
            int originalW = pointerBitmap.Width;
            int originalH = pointerBitmap.Height;
            float scale = 0.8f;
            int newW = (int)(originalW * scale);
            int newH = (int)(originalH * scale);
            e.Graphics.DrawImage(pointerBitmap, pointerPosition.X, pointerPosition.Y, newW, newH);
        }

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

        private void HideCursor()
        {
            Bitmap bmp = new Bitmap(1, 1);
            IntPtr ptr = bmp.GetHicon();
            Cursor transparentCursor = new Cursor(ptr);
            this.Cursor = transparentCursor;
        }

        // 폼이 닫힐 때 모든 타이머 Dispose 및 완전 종료
        private void MovingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            projectileTimer.Dispose();
            shootDelayTimer.Dispose();
            playerMoveTimer.Dispose();
            Application.Exit();
        }

        // ---- 기존 버튼 이벤트 핸들러 ----
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
            new MainForm().Show();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            new PlayForm(this).Show();
            this.Hide();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            new ScoreForm(this).Show();
            this.Hide();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            new AnalyzeForm(this).Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new SettingForm(this).Show();
            this.Hide();
        }

        private void MousePointer_Click(object sender, EventArgs e)
        {
            // 필요시 커스텀 포인터 클릭 로직
        }

        private void MovingForm_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 초기화 코드(필요시)
        }
    }
}
