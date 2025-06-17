namespace AimTrainingProgram
{
    partial class PlayForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNontargeting = new System.Windows.Forms.Button();
            this.btnMoving = new System.Windows.Forms.Button();
            this.btnTargeting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.button2.Location = new System.Drawing.Point(281, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Analyze";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.button3.Location = new System.Drawing.Point(148, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 47);
            this.button3.TabIndex = 27;
            this.button3.Text = "Score";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.button5.BackgroundImage = global::AimTrainingProgram.Properties.Resources.backblue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(548, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 47);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.button1.Location = new System.Drawing.Point(415, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 47);
            this.button1.TabIndex = 29;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.button4.BackgroundImage = global::AimTrainingProgram.Properties.Resources.homeblue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(11, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 47);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNontargeting
            // 
            this.btnNontargeting.BackgroundImage = global::AimTrainingProgram.Properties.Resources.back3;
            this.btnNontargeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNontargeting.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNontargeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.btnNontargeting.Location = new System.Drawing.Point(879, 216);
            this.btnNontargeting.Margin = new System.Windows.Forms.Padding(2);
            this.btnNontargeting.Name = "btnNontargeting";
            this.btnNontargeting.Size = new System.Drawing.Size(300, 600);
            this.btnNontargeting.TabIndex = 11;
            this.btnNontargeting.Text = "Nontargeting Training";
            this.btnNontargeting.UseVisualStyleBackColor = true;
            this.btnNontargeting.Click += new System.EventHandler(this.btnNontargeting_Click);
            // 
            // btnMoving
            // 
            this.btnMoving.BackgroundImage = global::AimTrainingProgram.Properties.Resources.back2;
            this.btnMoving.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoving.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.btnMoving.Location = new System.Drawing.Point(563, 216);
            this.btnMoving.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoving.Name = "btnMoving";
            this.btnMoving.Size = new System.Drawing.Size(300, 600);
            this.btnMoving.TabIndex = 3;
            this.btnMoving.Text = "Moving Training";
            this.btnMoving.UseVisualStyleBackColor = true;
            this.btnMoving.Click += new System.EventHandler(this.btnMoving_Click);
            // 
            // btnTargeting
            // 
            this.btnTargeting.BackgroundImage = global::AimTrainingProgram.Properties.Resources.back1;
            this.btnTargeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTargeting.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTargeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.btnTargeting.Location = new System.Drawing.Point(247, 216);
            this.btnTargeting.Margin = new System.Windows.Forms.Padding(2);
            this.btnTargeting.Name = "btnTargeting";
            this.btnTargeting.Size = new System.Drawing.Size(300, 600);
            this.btnTargeting.TabIndex = 2;
            this.btnTargeting.Text = "Targeting Training";
            this.btnTargeting.UseVisualStyleBackColor = true;
            this.btnTargeting.Click += new System.EventHandler(this.btnTargeting_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AimTrainingProgram.Properties.Resources.mainback;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNontargeting);
            this.Controls.Add(this.btnMoving);
            this.Controls.Add(this.btnTargeting);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTargeting;
        private System.Windows.Forms.Button btnMoving;
        private System.Windows.Forms.Button btnNontargeting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}