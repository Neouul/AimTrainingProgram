<<<<<<< Updated upstream
﻿using System;
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
    public partial class TargetingForm : Form
    {
        private Form previousForm;

        private int lolSens = SettingForm.GameSensitivity;
        private int pcSens = SettingForm.ControlPanelSpeed;
        private float sensitivityScale;

        private float accumulatedDx = 0;
        private float accumulatedDy = 0;

        private Point lastMousePos;
        private Point pointerPosition = Point.Empty;
        private Bitmap pointerBitmap = Properties.Resources.pointer;//이미지 파일
        private Bitmap targetBitmap = Properties.Resources.target;
        private Point targetPosition = Point.Empty;

        private Timer targetTimer;
        private Timer visibilityTimer;
        private int targetCount = 0;
        public int score = 0;
        private Random random = new Random();
        private bool isTargetHit = false;
        private bool isTargetVisible = false;
        private bool isCursorHidden = true;
        private int targetSize = 50; // 기본값

        private string resultMessage = "";
        private Timer resultMessageTimer;
        public TargetingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            if (lolSens <= 10) sensitivityScale = (lolSens / 5) / 32f;
            else if (lolSens < 55) sensitivityScale = (lolSens / 5 - 2) / 8f;
            else sensitivityScale = (lolSens / 5 - 6) / 4f;

            switch (pcSens)
            {
                case 1: sensitivityScale /= 0.03125f; break;
                case 2: sensitivityScale /= 0.125f; break;
                case 3: sensitivityScale /= 0.25f; break;
                case 4: sensitivityScale /= 0.5f; break;
                case 5: sensitivityScale /= 0.75f; break;
                case 7: sensitivityScale /= 1.5f; break;
                case 8: sensitivityScale /= 2.0f; break;
                case 9: sensitivityScale /= 2.5f; break;
                case 10: sensitivityScale /= 3.0f; break;
                case 11: sensitivityScale /= 3.5f; break;
            }

            this.previousForm = previousForm;
        }
        public TargetingForm() : this(null) { }

        private void TargetingForm_Load(object sender, EventArgs e)
        {
            btnRestart.Visible = false;

            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            Cursor.Position = this.PointToScreen(center);
            pointerPosition = new Point(center.X - 20, center.Y - 20);
            lastMousePos = center;

            HideCursor();
            this.Paint += TargetingForm_Paint;
            this.MouseMove += SensInScreen;
            this.MouseDown += TargetingForm_MouseDown;

            targetTimer = new Timer();
            visibilityTimer = new Timer();
            targetTimer.Tick += ShowTarget;
            visibilityTimer.Tick += HideTarget;

            switch (SettingForm.SelectedDifficulty)
            {
                case SettingForm.Difficulty.Easy:
                    targetTimer.Interval = 2000;
                    visibilityTimer.Interval = 1000;
                    targetSize = 70;

                    break;
                case SettingForm.Difficulty.Normal:
                    targetTimer.Interval = 1000;
                    visibilityTimer.Interval = 700;
                    targetSize = 50;

                    break;
                case SettingForm.Difficulty.Hard:
                    targetTimer.Interval = 700;
                    visibilityTimer.Interval = 800;
                    targetSize = 20;

                    break;
            }

            targetTimer.Start();

            resultMessageTimer = new Timer();
            resultMessageTimer.Interval = 1000; // 1초
            resultMessageTimer.Tick += (s, ev) =>
            {
                resultMessage = "";
                resultMessageTimer.Stop();
                Invalidate(); // 메시지 지우기 위해 다시 그리기

            };
        }

        private void TargetingForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (isTargetVisible)
                e.Graphics.DrawImage(targetBitmap, targetPosition.X, targetPosition.Y, targetSize, targetSize);

            // ✅ 마우스 포인터 이미지 비율 유지
            int originalW = pointerBitmap.Width;
            int originalH = pointerBitmap.Height;

            float scale = 0.8f;
            int newW = (int)(originalW * scale);
            int newH = (int)(originalH * scale);

            e.Graphics.DrawImage(pointerBitmap, pointerPosition.X, pointerPosition.Y, newW, newH);

            if (!string.IsNullOrEmpty(resultMessage))
            {
                using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    //메시지에 따라 색상 분기
                    Color color = resultMessage == "Perfect!" ? Color.Green : Color.Red;

                    using (Brush brush = new SolidBrush(color))
                    {
                        SizeF textSize = e.Graphics.MeasureString(resultMessage, font);

                        PointF msgPosition = new PointF(
                            targetPosition.X + targetSize / 2 - textSize.Width / 2,
                            targetPosition.Y - textSize.Height - 2
                        );

                        e.Graphics.DrawString(resultMessage, font, brush, msgPosition);
                    }
                }
            }
        }



        private void ShowTarget(object sender, EventArgs e)
        {
            visibilityTimer.Stop();

            if (targetCount >= 10)
            {
                targetTimer.Stop();
                btnRestart.Visible = true;
                return;
            }

            int marginX = this.ClientSize.Width / 4;
            int marginY = this.ClientSize.Height / 4;
            int rangeX = this.ClientSize.Width / 2 - 50;
            int rangeY = this.ClientSize.Height / 2 - 50;

            int x = random.Next(marginX, marginX + rangeX);
            int y = random.Next(marginY, marginY + rangeY);

            targetPosition = new Point(x, y);
            isTargetVisible = true;
            isTargetHit = false;
            targetCount++;

            visibilityTimer.Start();
            Invalidate();
        }

        private void HideTarget(object sender, EventArgs e)
        {
            isTargetVisible = false;
            visibilityTimer.Stop();
            Invalidate();
        }

        private void HideCursor()
        {
            Bitmap bmp = new Bitmap(1, 1);
            IntPtr ptr = bmp.GetHicon();
            Cursor transparentCursor = new Cursor(ptr);
            this.Cursor = transparentCursor;
        }

        public void SensInScreen(object sender, MouseEventArgs e)
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
            HandleCursorVisibility();
        }

        private void HandleCursorVisibility()
        {
            int thresholdY = 50;
            if (pointerPosition.Y < thresholdY && isCursorHidden)
            {
                this.Cursor = Cursors.Default;
                isCursorHidden = false;
            }
            else if (pointerPosition.Y >= thresholdY && !isCursorHidden)
            {
                HideCursor();
                isCursorHidden = true;
            }
        }

        private void TargetingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isTargetVisible || isTargetHit) return;

            Rectangle targetRect = new Rectangle(targetPosition, new Size(targetSize, targetSize));

            if (targetRect.Contains(pointerPosition))
            {
                score++;
                TargetScore.Text = $"점수: {score}/10";
                isTargetHit = true;
                resultMessage = "Perfect!";
            }
            else
            {
                resultMessage = "Miss..";
            }

            resultMessageTimer.Stop();
            resultMessageTimer.Start();
            Invalidate(); // 메시지 표시 위해 다시 그리기
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            targetCount = 0;
            score = 0;
            isTargetHit = false;
            TargetScore.Text = "점수: 0/10";

            btnRestart.Visible = false;
            isTargetVisible = false;
            visibilityTimer.Stop();
            targetTimer.Start();
            Invalidate();
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

        private void MousePointer_Click(object sender, EventArgs e)
        {

        }

        private void AimTarget_Click(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AimTrainingProgram.Data;
using AimTrainingProgram.Data.AimTrainingProgram.Data;

namespace AimTrainingProgram
{
    public partial class TargetingForm : Form
    {
        private Form previousForm;

        private float lolSens = SettingForm.GameSensitivity;
        private int pcSens = SettingForm.ControlPanelSpeed;
        private float sensitivityScale;

        private float accumulatedDx = 0;
        private float accumulatedDy = 0;

        private Point lastMousePos;
        private Point pointerPosition = Point.Empty;
        private Bitmap pointerBitmap = Properties.Resources.pointer;
        private Bitmap targetBitmap = Properties.Resources.target;
        private Point targetPosition = Point.Empty;

        private Timer targetTimer;
        private Timer visibilityTimer;
        private int targetCount = 0;
        public int score = 0;
        private Random random = new Random();
        private bool isTargetHit = false;
        private bool isTargetVisible = false;
        private bool isCursorHidden = true;
        private int targetSize = 50;

        private string resultMessage = "";
        private Timer resultMessageTimer;

        private List<TargetResult> hitData = new List<TargetResult>();
        private Point currentTargetCenter;
        private List<TargetHitRecord> hitRecords = new List<TargetHitRecord>();

        // ComboBox name: comboModeSelect (폼 디자이너에서 추가)
        // Items: "일반 모드", "약점 분석 모드"

        public TargetingForm(Form previousForm)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            if (lolSens < 5) sensitivityScale = lolSens;
            else
            {
                if (lolSens <= 10) sensitivityScale = (lolSens / 5) / 32f;
                else if (lolSens <= 55) sensitivityScale = (lolSens / 5 - 2) / 8f;
                else sensitivityScale = (lolSens / 5 - 6) / 4f;

                switch (pcSens)
                {
                    case 1: sensitivityScale /= 0.03125f; break;
                    case 2: sensitivityScale /= 0.125f; break;
                    case 3: sensitivityScale /= 0.25f; break;
                    case 4: sensitivityScale /= 0.5f; break;
                    case 5: sensitivityScale /= 0.75f; break;
                    case 7: sensitivityScale /= 1.5f; break;
                    case 8: sensitivityScale /= 2.0f; break;
                    case 9: sensitivityScale /= 2.5f; break;
                    case 10: sensitivityScale /= 3.0f; break;
                    case 11: sensitivityScale /= 3.5f; break;
                }
            }

            this.previousForm = previousForm;
        }
        public TargetingForm() : this(null) { }

        private void TargetingForm_Load(object sender, EventArgs e)
        {
            // 콤보박스 항목 직접 추가
            comboModeSelect.Items.Clear();
            comboModeSelect.Items.Add("일반 모드");
            comboModeSelect.Items.Add("약점 분석 모드");
            comboModeSelect.SelectedIndex = 0;
            comboModeSelect.SelectedIndexChanged += ComboModeSelect_SelectedIndexChanged;

            btnRestart.Visible = false;

            Point center = new Point(this.ClientSize.Width / 2, this.ClientSize.Height / 2);
            Cursor.Position = this.PointToScreen(center);
            pointerPosition = new Point(center.X - 20, center.Y - 20);
            lastMousePos = center;

            HideCursor();
            this.Paint += TargetingForm_Paint;
            this.MouseMove += SensInScreen;
            this.MouseDown += TargetingForm_MouseDown;

            targetTimer = new Timer();
            visibilityTimer = new Timer();
            targetTimer.Tick += ShowTarget;
            visibilityTimer.Tick += HideTarget;

            switch (SettingForm.SelectedDifficulty)
            {
                case SettingForm.Difficulty.Easy:
                    targetTimer.Interval = 2000;
                    visibilityTimer.Interval = 1000;
                    targetSize = 70;
                    break;
                case SettingForm.Difficulty.Normal:
                    targetTimer.Interval = 1000;
                    visibilityTimer.Interval = 700;
                    targetSize = 50;
                    break;
                case SettingForm.Difficulty.Hard:
                    targetTimer.Interval = 700;
                    visibilityTimer.Interval = 800;
                    targetSize = 20;
                    break;
            }

            targetTimer.Start();

            resultMessageTimer = new Timer();
            resultMessageTimer.Interval = 1000;
            resultMessageTimer.Tick += (s, ev) =>
            {
                resultMessage = "";
                resultMessageTimer.Stop();
                Invalidate();
            };
        }

        private void TargetingForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (isTargetVisible)
                e.Graphics.DrawImage(targetBitmap, targetPosition.X, targetPosition.Y, targetSize, targetSize);

            int originalW = pointerBitmap.Width;
            int originalH = pointerBitmap.Height;
            float scale = 0.8f;
            int newW = (int)(originalW * scale);
            int newH = (int)(originalH * scale);

            e.Graphics.DrawImage(pointerBitmap, pointerPosition.X, pointerPosition.Y, newW, newH);

            if (!string.IsNullOrEmpty(resultMessage))
            {
                using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                {
                    Color color = resultMessage == "Perfect!" ? Color.Green : Color.Red;

                    using (Brush brush = new SolidBrush(color))
                    {
                        SizeF textSize = e.Graphics.MeasureString(resultMessage, font);

                        PointF msgPosition = new PointF(
                            targetPosition.X + targetSize / 2 - textSize.Width / 2,
                            targetPosition.Y - textSize.Height - 2
                        );

                        e.Graphics.DrawString(resultMessage, font, brush, msgPosition);
                    }
                }
            }
        }

        // 약점 구역 불러오기
        private List<(int x, int y)> LoadWeakZones()
        {
            var zones = new List<(int, int)>();
            if (File.Exists("weakzones.txt"))
            {
                var data = File.ReadAllText("weakzones.txt");
                foreach (var part in data.Split(';'))
                {
                    var xy = part.Split(',');
                    if (xy.Length == 2 && int.TryParse(xy[0], out int x) && int.TryParse(xy[1], out int y))
                        zones.Add((x, y));
                }
            }
            return zones;
        }

        // 타겟 생성 로직
        private void ShowTarget(object sender, EventArgs e)
        {
            visibilityTimer.Stop();

            if (targetCount >= 10)
            {
                targetTimer.Stop();
                btnRestart.Visible = true;
                // 게임 종료 시 팝업창으로 점수 안내
                MessageBox.Show($"게임 종료!\n최종 점수: {score}/10", "결과", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int marginX = this.ClientSize.Width / 4;
            int marginY = this.ClientSize.Height / 4;
            int rangeX = this.ClientSize.Width / 2 - 50;
            int rangeY = this.ClientSize.Height / 2 - 50;

            int x, y;
            if (comboModeSelect.SelectedItem?.ToString() == "약점 분석 모드")
            {
                var weakZones = LoadWeakZones();
                int gridX = 3, gridY = 2;
                if (weakZones.Count > 0 && random.NextDouble() < 0.7)
                {
                    var zone = weakZones[random.Next(weakZones.Count)];
                    int zoneWidth = this.ClientSize.Width / gridX;
                    int zoneHeight = this.ClientSize.Height / gridY;
                    x = random.Next(zone.x * zoneWidth, (zone.x + 1) * zoneWidth);
                    y = random.Next(zone.y * zoneHeight, (zone.y + 1) * zoneHeight);
                }
                else
                {
                    x = random.Next(marginX, marginX + rangeX);
                    y = random.Next(marginY, marginY + rangeY);
                }
            }
            else // 일반 모드
            {
                x = random.Next(marginX, marginX + rangeX);
                y = random.Next(marginY, marginY + rangeY);
            }

            targetPosition = new Point(x, y);
            currentTargetCenter = new Point(x + targetSize / 2, y + targetSize / 2);

            isTargetVisible = true;
            isTargetHit = false;
            targetCount++;

            resultMessage = "";

            visibilityTimer.Start();
            Invalidate();
        }

        private void HideTarget(object sender, EventArgs e)
        {
            isTargetVisible = false;
            if (!isTargetHit)
            {
                hitData.Add(new TargetResult
                {
                    Position = currentTargetCenter,
                    IsHit = false
                });

                hitRecords.Add(new TargetHitRecord
                {
                    Position = targetPosition,
                    IsHit = false
                });
            }
            visibilityTimer.Stop();
            Invalidate();
        }

        private void HideCursor()
        {
            Bitmap bmp = new Bitmap(1, 1);
            IntPtr ptr = bmp.GetHicon();
            Cursor transparentCursor = new Cursor(ptr);
            this.Cursor = transparentCursor;
        }

        public void SensInScreen(object sender, MouseEventArgs e)
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
            HandleCursorVisibility();
        }

        private void HandleCursorVisibility()
        {
            int thresholdY = 50;
            if (pointerPosition.Y < thresholdY && isCursorHidden)
            {
                this.Cursor = Cursors.Default;
                isCursorHidden = false;
            }
            else if (pointerPosition.Y >= thresholdY && !isCursorHidden)
            {
                HideCursor();
                isCursorHidden = true;
            }
        }

        private void TargetingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isTargetVisible || isTargetHit) return;

            Rectangle targetRect = new Rectangle(targetPosition, new Size(targetSize, targetSize));
            bool hit = targetRect.Contains(pointerPosition);

            hitData.Add(new TargetResult
            {
                Position = currentTargetCenter,
                IsHit = hit
            });

            hitRecords.Add(new TargetHitRecord { Position = targetPosition, IsHit = hit });

            if (hit)
            {
                score++;
                TargetScore.Text = $"점수: {score}/10";
                isTargetHit = true;
                resultMessage = "Perfect!";
            }
            else
            {
                resultMessage = "Miss..";
            }

            resultMessageTimer.Stop();
            resultMessageTimer.Start();
            Invalidate();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            SaveScoreData();
            targetCount = 0;
            score = 0;
            isTargetHit = false;
            TargetScore.Text = "점수: 0/10";

            btnRestart.Visible = false;
            isTargetVisible = false;
            visibilityTimer.Stop();
            targetTimer.Start();
            Invalidate();
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
            SaveScoreData();
            ScoreForm scoreForm = new ScoreForm(this);
            scoreForm.Show();
            this.Hide();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            SaveScoreData();
            AnalyzeForm analyzeForm = new AnalyzeForm(this, hitRecords);
            analyzeForm.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(this);
            settingForm.Show();
            this.Hide();
        }

        private void MousePointer_Click(object sender, EventArgs e) { }
        private void AimTarget_Click(object sender, EventArgs e) { }

        private void SaveScoreData()
        {
            ScoreData data = new ScoreData
            {
                Date = DateTime.Now,
                Score = score,
                GameSensitivity = SettingForm.GameSensitivity,
                ControlPanelSpeed = SettingForm.ControlPanelSpeed,
                Mode = "Targeting",
                Difficulty = SettingForm.SelectedDifficulty.ToString()
            };

            DataManager.SaveScore(data);
            DataManager.SaveHitRecords(hitRecords);
        }

        private void TargetingForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                SaveScoreData();
            }
        }

        // 콤보박스 이벤트 핸들러
        private void ComboModeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            targetCount = 0;
            score = 0;
            btnRestart.Visible = false;
            isTargetVisible = false;
            visibilityTimer.Stop();
            targetTimer.Start();
            Invalidate();
        }
    }
}
>>>>>>> Stashed changes
