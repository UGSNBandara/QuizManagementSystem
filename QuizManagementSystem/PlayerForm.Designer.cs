namespace QuizManagementSystem
{
    partial class PlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            panelProfile = new Panel();
            label13 = new Label();
            profileName = new Label();
            label6 = new Label();
            label2 = new Label();
            profileEmail = new Label();
            profileUsername = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            leadboardPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            QuizP = new Panel();
            QuizPanel = new Panel();
            button5 = new Button();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            QuizP.SuspendLayout();
            SuspendLayout();
            // 
            // panelProfile
            // 
            panelProfile.BackColor = SystemColors.WindowText;
            panelProfile.Controls.Add(label13);
            panelProfile.Controls.Add(profileName);
            panelProfile.Controls.Add(label6);
            panelProfile.Controls.Add(label2);
            panelProfile.Controls.Add(profileEmail);
            panelProfile.Controls.Add(profileUsername);
            panelProfile.Controls.Add(label3);
            panelProfile.Controls.Add(pictureBox1);
            panelProfile.Controls.Add(label1);
            panelProfile.Location = new Point(12, 12);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(453, 976);
            panelProfile.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(39, 480);
            label13.Name = "label13";
            label13.Size = new Size(79, 33);
            label13.TabIndex = 12;
            label13.Text = "Name";
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileName.ForeColor = SystemColors.Window;
            profileName.Location = new Point(191, 480);
            profileName.Name = "profileName";
            profileName.Size = new Size(233, 33);
            profileName.TabIndex = 11;
            profileName.Text = "UserNameAsStored";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(39, 557);
            label6.Name = "label6";
            label6.Size = new Size(130, 33);
            label6.TabIndex = 8;
            label6.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(39, 629);
            label2.Name = "label2";
            label2.Size = new Size(80, 33);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // profileEmail
            // 
            profileEmail.AutoSize = true;
            profileEmail.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileEmail.ForeColor = SystemColors.Window;
            profileEmail.Location = new Point(191, 629);
            profileEmail.Name = "profileEmail";
            profileEmail.Size = new Size(233, 33);
            profileEmail.TabIndex = 6;
            profileEmail.Text = "UserNameAsStored";
            // 
            // profileUsername
            // 
            profileUsername.AutoSize = true;
            profileUsername.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileUsername.ForeColor = SystemColors.Window;
            profileUsername.Location = new Point(191, 557);
            profileUsername.Name = "profileUsername";
            profileUsername.Size = new Size(233, 33);
            profileUsername.TabIndex = 5;
            profileUsername.Text = "UserNameAsStored";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 496);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(95, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 228);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(114, 303);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 1;
            label1.Text = "User's Name";
            // 
            // leadboardPanel
            // 
            leadboardPanel.AutoScroll = true;
            leadboardPanel.BackColor = Color.Violet;
            leadboardPanel.Location = new Point(1433, 331);
            leadboardPanel.Name = "leadboardPanel";
            leadboardPanel.Size = new Size(94, 91);
            leadboardPanel.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Times New Roman", 14F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1402, 921);
            button4.Name = "button4";
            button4.Size = new Size(175, 50);
            button4.TabIndex = 15;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Times New Roman", 14F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1402, 837);
            button3.Name = "button3";
            button3.Size = new Size(175, 50);
            button3.TabIndex = 14;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.Font = new Font("Times New Roman", 14F);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(1402, 105);
            button2.Name = "button2";
            button2.Size = new Size(175, 50);
            button2.TabIndex = 13;
            button2.Text = "LeadBoard";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Times New Roman", 14F);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1402, 23);
            button1.Name = "button1";
            button1.Size = new Size(175, 50);
            button1.TabIndex = 12;
            button1.Text = "Quizes";
            button1.UseVisualStyleBackColor = false;
            // 
            // QuizP
            // 
            QuizP.BackColor = SystemColors.WindowText;
            QuizP.Controls.Add(button5);
            QuizP.Controls.Add(QuizPanel);
            QuizP.Location = new Point(486, 12);
            QuizP.Name = "QuizP";
            QuizP.Size = new Size(883, 976);
            QuizP.TabIndex = 16;
            // 
            // QuizPanel
            // 
            QuizPanel.BackColor = SystemColors.Window;
            QuizPanel.Location = new Point(18, 93);
            QuizPanel.Name = "QuizPanel";
            QuizPanel.Size = new Size(843, 866);
            QuizPanel.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(728, 11);
            button5.Name = "button5";
            button5.Size = new Size(133, 50);
            button5.TabIndex = 1;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1600, 1000);
            Controls.Add(QuizP);
            Controls.Add(leadboardPanel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panelProfile);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "PlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayerForm";
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            QuizP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProfile;
        private Label label13;
        private Label profileName;
        private Label label6;
        private Label label2;
        private Label profileEmail;
        private Label profileUsername;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel leadboardPanel;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel QuizP;
        private Button button5;
        private Panel QuizPanel;
    }
}