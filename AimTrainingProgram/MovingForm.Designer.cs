namespace AimTrainingProgram
{
    partial class MovingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.moveScore = new System.Windows.Forms.Label();
            this.MousePointer = new System.Windows.Forms.PictureBox();
            this.target = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.target1 = new System.Windows.Forms.PictureBox();
            this.target2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(216, 75);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "홈";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1102, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(214, 75);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(885, 12);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(211, 75);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(668, 12);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(211, 75);
            this.btnAnalyze.TabIndex = 10;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(451, 12);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(211, 75);
            this.btnScore.TabIndex = 9;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(234, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(211, 75);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(1322, 14);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(211, 73);
            this.btnRestart.TabIndex = 23;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            // 
            // moveScore
            // 
            this.moveScore.AutoSize = true;
            this.moveScore.Font = new System.Drawing.Font("굴림", 20F);
            this.moveScore.Location = new System.Drawing.Point(14, 120);
            this.moveScore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.moveScore.Name = "moveScore";
            this.moveScore.Size = new System.Drawing.Size(305, 54);
            this.moveScore.TabIndex = 22;
            this.moveScore.Text = "MoveScore";
            // 
            // MousePointer
            // 
            this.MousePointer.Image = global::AimTrainingProgram.Properties.Resources.pointer;
            this.MousePointer.Location = new System.Drawing.Point(105, 841);
            this.MousePointer.Margin = new System.Windows.Forms.Padding(8);
            this.MousePointer.Name = "MousePointer";
            this.MousePointer.Size = new System.Drawing.Size(29, 47);
            this.MousePointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MousePointer.TabIndex = 21;
            this.MousePointer.TabStop = false;
            this.MousePointer.Visible = false;
            this.MousePointer.Click += new System.EventHandler(this.MousePointer_Click);
            // 
            // target
            // 
            this.target.Image = global::AimTrainingProgram.Properties.Resources.target;
            this.target.Location = new System.Drawing.Point(21, 808);
            this.target.Margin = new System.Windows.Forms.Padding(8);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(81, 80);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.target.TabIndex = 20;
            this.target.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::AimTrainingProgram.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(340, 723);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(68, 76);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 24;
            this.player.TabStop = false;
            // 
            // target1
            // 
            this.target1.Image = global::AimTrainingProgram.Properties.Resources.target;
            this.target1.Location = new System.Drawing.Point(184, 808);
            this.target1.Margin = new System.Windows.Forms.Padding(8);
            this.target1.Name = "target1";
            this.target1.Size = new System.Drawing.Size(81, 80);
            this.target1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.target1.TabIndex = 25;
            this.target1.TabStop = false;
            // 
            // target2
            // 
            this.target2.Image = global::AimTrainingProgram.Properties.Resources.target;
            this.target2.Location = new System.Drawing.Point(327, 810);
            this.target2.Margin = new System.Windows.Forms.Padding(8);
            this.target2.Name = "target2";
            this.target2.Size = new System.Drawing.Size(81, 80);
            this.target2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.target2.TabIndex = 26;
            this.target2.TabStop = false;
            // 
            // MovingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 921);
            this.Controls.Add(this.target2);
            this.Controls.Add(this.target1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.moveScore);
            this.Controls.Add(this.MousePointer);
            this.Controls.Add(this.target);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBack);
            this.Name = "MovingForm";
            this.Text = "MovingForm";
            this.Load += new System.EventHandler(this.MovingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label moveScore;
        private System.Windows.Forms.PictureBox MousePointer;
        private System.Windows.Forms.PictureBox target;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox target1;
        private System.Windows.Forms.PictureBox target2;
    }
}