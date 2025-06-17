using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AimTrainingProgram
{
    public partial class NontargetingForm : Form
    {
        // 상수
        private const int BOT_SIZE = 60;
        private const int PLAYER_SIZE = 60;
        private const float SKILL_SPEED = 20f;
        private const int MAX_TARGETS = 10;
        private const int SKILL_TIME_LIMIT = 1000; // 1초(ms)

        // 상태 변수
        private Point playerCenter;
        private Point botLocation;
        private bool botActive = false;

        private int score = 0;
        private int targetCount = 0;
        private Random rand = new Random();

        // 투사체(스킬) 관련
        private bool skillActive = false;
        private Point skillTarget;
        private PointF skillCurrent;
        private float unitX, unitY;
        private int skillRadius = 15;
        private int timeLeftMs = SKILL_TIME_LIMIT;

        // 스킬 타입 정의 (작은 반지름)
        private class SkillType
        {
            public string Name { get; }
            public Color EffectColor { get; }
            public int EffectRadius { get; }
            public SkillType(string name, Color color, int radius)
            {
                Name = name;
                EffectColor = color;
                EffectRadius = radius;
            }
        }
        private readonly List<SkillType> skillTypes = new List<SkillType>
        {
            new SkillType("Fireball", Color.OrangeRed, 18),
            new SkillType("Arrow", Color.LightSkyBlue, 12),
            new SkillType("Spear", Color.LimeGreen, 15)
        };
        private SkillType selectedSkill;

        private Form previousForm;

        public NontargetingForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Paint += NontargetingForm_Paint;
            Load += NontargetingForm_Load;
            MouseClick += NontargetingForm_MouseClick;
            timer1.Interval = 20;
            timer1.Tick += Timer1_Tick;
        }

        public NontargetingForm(Form prevForm) : this()
        {
            previousForm = prevForm;
        }

        private void NontargetingForm_Load(object sender, EventArgs e)
        {
            playerCenter = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
            InitSkillComboBox();
            StartNewGame();

            // 이벤트 연결 (디자이너에서 이미 연결되어 있으면 중복 연결 불필요)
            cmbSkillSelect.SelectedIndexChanged += cmbSkillSelect_SelectedIndexChanged;
            btnRestart.Click += btnRestart_Click;
            btnBack.Click += btnBack_Click;
            btnSetting.Click += btnSetting_Click;
            btnAnalyze.Click += btnAnalyze_Click;
            btnScore.Click += btnScore_Click;
            btnHome.Click += btnHome_Click;
            btnPlay.Click += btnPlay_Click;
        }

        private void InitSkillComboBox()
        {
            cmbSkillSelect.Items.Clear();
            foreach (var skill in skillTypes)
                cmbSkillSelect.Items.Add(skill.Name);
            cmbSkillSelect.SelectedIndex = 0;
            selectedSkill = skillTypes[0];
            skillRadius = selectedSkill.EffectRadius;
        }

        private void StartNewGame()
        {
            score = 0;
            targetCount = 0;
            skillActive = false;
            timer1.Stop();
            UpdateScoreLabel();
            SpawnBot();
        }

        private void SpawnBot()
        {
            if (targetCount >= MAX_TARGETS)
            {
                MessageBox.Show($"게임 종료!\n점수: {score}/{MAX_TARGETS}", "결과");
                botActive = false;
                Invalidate();
                return;
            }
            int safeMargin = BOT_SIZE + 10;
            int x = rand.Next(safeMargin, ClientSize.Width - safeMargin);
            int y = rand.Next(safeMargin, ClientSize.Height - safeMargin);
            botLocation = new Point(x, y);
            botActive = true;
            skillActive = false;
            timeLeftMs = SKILL_TIME_LIMIT;
            targetCount++;
            Invalidate();
        }

        private void NontargetingForm_Paint(object sender, PaintEventArgs e)
        {
            // 플레이어(중앙)
            e.Graphics.FillEllipse(Brushes.DarkBlue, playerCenter.X - PLAYER_SIZE / 2, playerCenter.Y - PLAYER_SIZE / 2, PLAYER_SIZE, PLAYER_SIZE);

            // Bot
            if (botActive)
                e.Graphics.FillEllipse(Brushes.Red, botLocation.X, botLocation.Y, BOT_SIZE, BOT_SIZE);

            // 투사체(스킬)
            if (skillActive)
            {
                using (Brush brush = new SolidBrush(selectedSkill.EffectColor))
                {
                    e.Graphics.FillEllipse(brush,
                        skillCurrent.X - selectedSkill.EffectRadius,
                        skillCurrent.Y - selectedSkill.EffectRadius,
                        selectedSkill.EffectRadius * 2,
                        selectedSkill.EffectRadius * 2);
                }
            }
        }

        private void NontargetingForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (skillActive || !botActive) return; // 투사체 이동 중이면 무시

            skillTarget = e.Location;
            skillCurrent = new PointF(playerCenter.X, playerCenter.Y);

            float dx = skillTarget.X - playerCenter.X;
            float dy = skillTarget.Y - playerCenter.Y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            if (dist == 0) return;
            unitX = dx / dist;
            unitY = dy / dist;

            skillRadius = selectedSkill.EffectRadius;
            timeLeftMs = SKILL_TIME_LIMIT;
            skillActive = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!skillActive) return;

            // 이동
            skillCurrent.X += unitX * SKILL_SPEED;
            skillCurrent.Y += unitY * SKILL_SPEED;
            timeLeftMs -= timer1.Interval;

            // 명중 판정
            Point botCenter = new Point(botLocation.X + BOT_SIZE / 2, botLocation.Y + BOT_SIZE / 2);
            float distToBot = (float)Math.Sqrt(
                Math.Pow(skillCurrent.X - botCenter.X, 2) + Math.Pow(skillCurrent.Y - botCenter.Y, 2));
            if (distToBot <= skillRadius + BOT_SIZE / 2)
            {
                score++;
                UpdateScoreLabel();
                skillActive = false;
                botActive = false;
                timer1.Stop();
                Timer t = new Timer { Interval = 500 };
                t.Tick += (s, ev) =>
                {
                    t.Stop();
                    SpawnBot();
                };
                t.Start();
            }
            else
            {
                // 도착 or 제한시간 초과
                float distToTarget = (float)Math.Sqrt(
                    Math.Pow(skillCurrent.X - skillTarget.X, 2) + Math.Pow(skillCurrent.Y - skillTarget.Y, 2));
                if (distToTarget < SKILL_SPEED || timeLeftMs <= 0)
                {
                    // 실패 처리 및 타겟 이동
                    skillActive = false;
                    botActive = false;
                    timer1.Stop();
                    Timer t = new Timer { Interval = 500 };
                    t.Tick += (s, ev) =>
                    {
                        t.Stop();
                        SpawnBot();
                    };
                    t.Start();
                }
            }
            Invalidate();
        }

        private void UpdateScoreLabel()
        {
            TargetScore.Text = $"{score}/{MAX_TARGETS}";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousForm?.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            settingForm.Show();
            this.Close();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzeForm analyzeForm = new AnalyzeForm();
            analyzeForm.Show();
            this.Close();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.Show();
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
            PlayForm playForm = new PlayForm();
            playForm.Show();
            this.Close();
        }

        private void cmbSkillSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSkillSelect.SelectedIndex >= 0 && cmbSkillSelect.SelectedIndex < skillTypes.Count)
            {
                selectedSkill = skillTypes[cmbSkillSelect.SelectedIndex];
                skillRadius = selectedSkill.EffectRadius;
            }
        }
    }
}
