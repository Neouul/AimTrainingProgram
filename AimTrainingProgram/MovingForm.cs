using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;
using AimTrainingProgram.Data;
using System.Diagnostics;

namespace AimTrainingProgram
{
    public partial class MovingForm : Form
    {

        private Form previousForm;

        // 게임 상수 설정
        private const int MAX_ATTEMPTS = 10;       // 총 시도 횟수
        private const int BOT_RANGE = 500;     // 발사체 최대 사거리
        private const int FLASH_DISTANCE = 200;    // 플래시 이동 거리

        // 게임 진행 상태 변수
        private int attempts = 0;
        private int successes = 0;
        private bool isProjectileActive = false;
        private bool gameOver = false;

        // 발사체 이동 및 회전 관련 변수
        private PointF projectileDirection;
        private Timer projectileTimer = new Timer();
        private Timer shootDelayTimer = new Timer();

        // 플레이어 이동 관련 변수
        private Point playerTargetPosition;
        private Timer playerMoveTimer;
        private int playerMoveSpeed = 8;

        // 기타 랜덤 및 마우스 입력 처리
        private Random rand = new Random();
        private Point lastMousePos;
        private Point pointerPosition = Point.Empty;
        private Bitmap pointerBitmap = Properties.Resources.pointer;
        private float sensitivityScale = 1.0f;
        private float accumulatedDx = 0;
        private float accumulatedDy = 0;

        // 발사체 위치 및 회전각
        private PointF projectilePosition;
        private float projectileAngle;

        // 발사체 타입 정의 (속도 + 이미지 매핑)
        private class TargetType
        {
            public Image Image { get; set; }
            public float Speed { get; set; }

            public TargetType(Image image, float speed)
            {
                Image = image;
                Speed = speed;
            }
        }

        private List<TargetType> targetTypes;
        private TargetType currentTarget;

        // Bot 관련
        private Point botLocation;
        private Bitmap botImage = Properties.Resources.bot;   // bot 이미지 리소스 적용
        private int botWidth = 80;
        private int botHeight = 80;

        // 발사체 크기 조절 스케일 (원하는 비율로 조정 가능)
        private float projectileScale = 0.2f;

        // 생성자: 폼 초기화 및 이벤트 핸들러 연결
        public MovingForm(Form previousForm)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.PreviewKeyDown += MovingForm_PreviewKeyDown;
            this.GotFocus += MovingForm_GotFocus;
            this.LostFocus += MovingForm_LostFocus;


            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true; // 깜빡임 방지
            this.KeyPreview = true;
            this.AutoValidate = AutoValidate.Disable;
            this.FormClosing += MovingForm_FormClosing;

            player.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            playerTargetPosition = player.Location;

            projectileTimer.Interval = 16; // 약 60FPS
            projectileTimer.Tick += ProjectileTimer_Tick;

            shootDelayTimer.Interval = rand.Next(100, 500);
            shootDelayTimer.Tick += ShootDelayTimer_Tick;

            playerMoveTimer = new Timer();
            playerMoveTimer.Interval = 20;
            playerMoveTimer.Tick += PlayerMoveTimer_Tick;

            // 커스텀 마우스 포인터 설정
            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            pointerPosition = new Point(center.X - 20, center.Y - 20);
            lastMousePos = center;
            this.MouseMove += SensInScreen;
            this.Paint += MovingForm_Paint;
            HideCursor();
            this.MouseClick += MovingForm_MouseClick;

            btnRestart.Click += btnRestart_Click_1;

            // 발사체 종류 (리소스 이미지 + 속도 설정)
            targetTypes = new List<TargetType>()
            {
                new TargetType(Properties.Resources.morgana, 20),
                //new TargetType(Properties.Resources.blitz, 10f),
                new TargetType(Properties.Resources.malphite,30f)
            };

            StartGame();
            this.previousForm = previousForm;
        }

        public MovingForm() : this(null) { }

        private void MovingForm_GotFocus(object sender, EventArgs e)
        {
            Debug.WriteLine("폼이 키보드 포커스 얻음");
        }

        private void MovingForm_LostFocus(object sender, EventArgs e)
        {
            Debug.WriteLine("폼이 키보드 포커스 잃음");
        }
        // 게임 초기화 시작
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
        }

        // Bot 랜덤 위치 배치 (플레이어 기준)
        private void MoveBotToRandomPosition()
        {
            botLocation = GetRandomPositionInRange(player.Location, BOT_RANGE);
            shootDelayTimer.Stop();
            shootDelayTimer.Interval = rand.Next(500, 1000);
            shootDelayTimer.Start();
        }

        private void ShootDelayTimer_Tick(object sender, EventArgs e)
        {
            shootDelayTimer.Stop();
            StartProjectile();
        }

        // 발사체 시작 (방향 및 각도 계산)
        private void StartProjectile()
        {
            if (gameOver) return;

            currentTarget = targetTypes[rand.Next(targetTypes.Count)];
            projectilePosition = botLocation;

            float dx = player.Location.X - botLocation.X;
            float dy = player.Location.Y - botLocation.Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            // 단위 벡터 (방향 벡터)
            projectileDirection = new PointF(dx / distance, dy / distance);

            // 회전 각도 계산 (중앙 기준 회전)
            // 1단계: 기본 방향 계산
            projectileAngle = (float)(Math.Atan2(dy, dx) * 180 / Math.PI);

            // 2단계: 시계방향으로 45도 추가
            projectileAngle += 45f;

            isProjectileActive = true;
            projectileTimer.Start();
        }

        private void ProjectileTimer_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;

            // 발사체 이동 (속도 적용)
            projectilePosition.X += projectileDirection.X * currentTarget.Speed;
            projectilePosition.Y += projectileDirection.Y * currentTarget.Speed;

            Invalidate();  // 화면 다시 그리기 요청

            // 발사체 바운딩 박스 계산
            Rectangle projectileRect = new Rectangle(
                (int)projectilePosition.X,
                (int)projectilePosition.Y,
                (int)(currentTarget.Image.Width * projectileScale),
                (int)(currentTarget.Image.Height * projectileScale)
            );

            // 충돌 판정 (BoundingBox vs BoundingBox)
            if (player.Bounds.IntersectsWith(projectileRect))
            {
                projectileTimer.Stop();
                isProjectileActive = false;
                attempts++;
                UpdateScoreDisplay();
                NextAttempt();
                return;
            }

            // 사거리 벗어났는지 검사
            if (Distance(botLocation, Point.Round(projectilePosition)) > BOT_RANGE)
            {
                projectileTimer.Stop();
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

            SaveScoreData();
            
            MessageBox.Show($"게임 종료! 성공: {successes}/{MAX_ATTEMPTS}");
        }

        private void SaveScoreData()
        {
            ScoreData data = new ScoreData
            {
                Date = DateTime.Now,
                Score = successes,
                GameSensitivity = SettingForm.GameSensitivity,
                ControlPanelSpeed = SettingForm.ControlPanelSpeed,
                Mode = "Moving",
                Difficulty = SettingForm.SelectedDifficulty.ToString() 
            };

            DataManager.SaveScore(data);
        }


        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            if (!gameOver) return;
            StartGame();
        }

        private void UpdateScoreDisplay()
        {
            lblScore.Text = $"{successes}/{MAX_ATTEMPTS}";
        }

        // 플레이어 주변 원형 범위 내 랜덤 위치 반환
        private Point GetRandomPositionInRange(Point center, int range)
        {
            int angle = rand.Next(0, 360);
            int distance = rand.Next(range / 2, range);

            int x = center.X + (int)(distance * Math.Cos(angle * Math.PI / 180));
            int y = center.Y + (int)(distance * Math.Sin(angle * Math.PI / 180));
            x = Clamp(x, 0, ClientSize.Width - botWidth);
            y = Clamp(y, 100, ClientSize.Height - botHeight);
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
            this.ActiveControl = null;  // <- 이거 넣자. 핵심 한방

            if (gameOver) return;

            Point clientPos = this.PointToClient(Cursor.Position);
            Point desired = new Point(clientPos.X - player.Width / 2, clientPos.Y - player.Height / 2);
            playerTargetPosition = ClampPosition(desired, player.Size);

            if (!playerMoveTimer.Enabled)
                playerMoveTimer.Start();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Focus();

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

        // 핵심 GDI+ 수동 드로잉
        private void MovingForm_Paint(object sender, PaintEventArgs e)
        {
            // 커스텀 마우스 포인터 그리기
            int originalW = pointerBitmap.Width;
            int originalH = pointerBitmap.Height;
            float scale = 0.8f;
            int newW = (int)(originalW * scale);
            int newH = (int)(originalH * scale);
            e.Graphics.DrawImage(pointerBitmap, pointerPosition.X, pointerPosition.Y, newW, newH);

            // Bot 이미지 그리기
            e.Graphics.DrawImage(botImage, botLocation.X, botLocation.Y, botWidth, botHeight);

            // 발사체 그리기 (회전 포함)
            if (isProjectileActive && currentTarget != null)
            {
                int projWidth = (int)(currentTarget.Image.Width * projectileScale);
                int projHeight = (int)(currentTarget.Image.Height * projectileScale);

                e.Graphics.TranslateTransform(projectilePosition.X + projWidth / 2, projectilePosition.Y + projHeight / 2);
                e.Graphics.RotateTransform(projectileAngle);
                e.Graphics.TranslateTransform(-projWidth / 2, -projHeight / 2);
                e.Graphics.DrawImage(currentTarget.Image, 0, 0, projWidth, projHeight);
                e.Graphics.ResetTransform();
            }
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

        private void MovingForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (gameOver) return;

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.F)
            {
                Flash();
            }
        }
    }
}