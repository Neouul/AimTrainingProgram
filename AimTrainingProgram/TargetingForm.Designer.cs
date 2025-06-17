namespace AimTrainingProgram
{
    partial class TargetingForm
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
            this.components = new System.ComponentModel.Container();
            this.TargetScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MousePointer = new System.Windows.Forms.PictureBox();
            this.AimTarget = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // TargetScore
            // 
            this.TargetScore.AutoSize = true;
            this.TargetScore.Font = new System.Drawing.Font("굴림", 20F);
            this.TargetScore.Location = new System.Drawing.Point(22, 71);
            this.TargetScore.Name = "TargetScore";
            this.TargetScore.Size = new System.Drawing.Size(208, 34);
            this.TargetScore.TabIndex = 18;
            this.TargetScore.Text = "TargetScore";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(346, 59);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(130, 46);
            this.btnRestart.TabIndex = 19;
            this.btnRestart.Text = "Replay";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::AimTrainingProgram.Properties.Resources.backicon;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(684, 11);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 47);
            this.button7.TabIndex = 24;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::AimTrainingProgram.Properties.Resources.homeicon;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(13, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 47);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 47);
            this.button5.TabIndex = 26;
            this.button5.Text = "Play";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 29;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 47);
            this.button3.TabIndex = 28;
            this.button3.Text = "Analyze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 47);
            this.button4.TabIndex = 27;
            this.button4.Text = "Score";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // MousePointer
            // 
            this.MousePointer.Image = global::AimTrainingProgram.Properties.Resources.pointer;
            this.MousePointer.Location = new System.Drawing.Point(62, 492);
            this.MousePointer.Margin = new System.Windows.Forms.Padding(5);
            this.MousePointer.Name = "MousePointer";
            this.MousePointer.Size = new System.Drawing.Size(29, 47);
            this.MousePointer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MousePointer.TabIndex = 17;
            this.MousePointer.TabStop = false;
            this.MousePointer.Visible = false;
            this.MousePointer.Click += new System.EventHandler(this.MousePointer_Click);
            // 
            // AimTarget
            // 
            this.AimTarget.Image = global::AimTrainingProgram.Properties.Resources.target;
            this.AimTarget.Location = new System.Drawing.Point(10, 471);
            this.AimTarget.Margin = new System.Windows.Forms.Padding(5);
            this.AimTarget.Name = "AimTarget";
            this.AimTarget.Size = new System.Drawing.Size(50, 50);
            this.AimTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AimTarget.TabIndex = 16;
            this.AimTarget.TabStop = false;
            this.AimTarget.Visible = false;
            this.AimTarget.Click += new System.EventHandler(this.AimTarget_Click);
            // 
            // TargetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.TargetScore);
            this.Controls.Add(this.MousePointer);
            this.Controls.Add(this.AimTarget);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TargetingForm";
            this.Text = "TargetingForm";
            this.Load += new System.EventHandler(this.TargetingForm_Load);
            this.VisibleChanged += new System.EventHandler(this.TargetingForm_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TargetingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SensInScreen);
            ((System.ComponentModel.ISupportInitialize)(this.MousePointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AimTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AimTarget;
        private System.Windows.Forms.PictureBox MousePointer;
        private System.Windows.Forms.Label TargetScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}