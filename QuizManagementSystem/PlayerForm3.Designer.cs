﻿namespace QuizManagementSystem
{
    partial class PlayerForm3
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
            ProfilePanel = new Panel();
            QuestionPanel = new Panel();
            button10 = new Button();
            button8 = new Button();
            button7 = new Button();
            AnswerD = new CheckBox();
            AnswerC = new CheckBox();
            AnswerB = new CheckBox();
            AnswerA = new CheckBox();
            QuestionNumber = new Label();
            Question = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            QuizPanel = new Panel();
            ClickQuizPanel = new Panel();
            QuizID = new Label();
            button9 = new Button();
            button6 = new Button();
            ClickQuizPanelUser = new Label();
            label2 = new Label();
            label1 = new Label();
            ClickQuizPanelMarks = new Label();
            ClickQuizPanelName = new Label();
            button5 = new Button();
            QuizShowPanel = new Panel();
            QuestionPanel.SuspendLayout();
            QuizPanel.SuspendLayout();
            ClickQuizPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProfilePanel
            // 
            ProfilePanel.BackColor = SystemColors.WindowText;
            ProfilePanel.Location = new Point(24, 23);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(457, 898);
            ProfilePanel.TabIndex = 0;
            // 
            // QuestionPanel
            // 
            QuestionPanel.BackColor = SystemColors.Window;
            QuestionPanel.Controls.Add(button10);
            QuestionPanel.Controls.Add(button8);
            QuestionPanel.Controls.Add(button7);
            QuestionPanel.Controls.Add(AnswerD);
            QuestionPanel.Controls.Add(AnswerC);
            QuestionPanel.Controls.Add(AnswerB);
            QuestionPanel.Controls.Add(AnswerA);
            QuestionPanel.Controls.Add(QuestionNumber);
            QuestionPanel.Controls.Add(Question);
            QuestionPanel.Location = new Point(280, 23);
            QuestionPanel.Name = "QuestionPanel";
            QuestionPanel.Size = new Size(1111, 398);
            QuestionPanel.TabIndex = 6;
            // 
            // button10
            // 
            button10.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(757, 328);
            button10.Name = "button10";
            button10.Size = new Size(91, 41);
            button10.TabIndex = 16;
            button10.Text = "Ok";
            button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(864, 328);
            button8.Name = "button8";
            button8.Size = new Size(130, 41);
            button8.TabIndex = 15;
            button8.Text = "Submit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(642, 328);
            button7.Name = "button7";
            button7.Size = new Size(91, 41);
            button7.TabIndex = 14;
            button7.Text = "Skip";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // AnswerD
            // 
            AnswerD.AutoSize = true;
            AnswerD.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerD.Location = new Point(27, 272);
            AnswerD.Name = "AnswerD";
            AnswerD.Size = new Size(150, 36);
            AnswerD.TabIndex = 13;
            AnswerD.Text = "AnswerD";
            AnswerD.UseVisualStyleBackColor = true;
            // 
            // AnswerC
            // 
            AnswerC.AutoSize = true;
            AnswerC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerC.Location = new Point(27, 218);
            AnswerC.Name = "AnswerC";
            AnswerC.Size = new Size(150, 36);
            AnswerC.TabIndex = 12;
            AnswerC.Text = "AnswerC";
            AnswerC.UseVisualStyleBackColor = true;
            // 
            // AnswerB
            // 
            AnswerB.AutoSize = true;
            AnswerB.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerB.Location = new Point(27, 164);
            AnswerB.Name = "AnswerB";
            AnswerB.Size = new Size(150, 36);
            AnswerB.TabIndex = 11;
            AnswerB.Text = "AnswerB";
            AnswerB.UseVisualStyleBackColor = true;
            // 
            // AnswerA
            // 
            AnswerA.AutoSize = true;
            AnswerA.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnswerA.Location = new Point(27, 107);
            AnswerA.Name = "AnswerA";
            AnswerA.Size = new Size(150, 36);
            AnswerA.TabIndex = 10;
            AnswerA.Text = "AnswerA";
            AnswerA.UseVisualStyleBackColor = true;
            // 
            // QuestionNumber
            // 
            QuestionNumber.AutoSize = true;
            QuestionNumber.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            QuestionNumber.Location = new Point(27, 28);
            QuestionNumber.Name = "QuestionNumber";
            QuestionNumber.Size = new Size(42, 32);
            QuestionNumber.TabIndex = 1;
            QuestionNumber.Text = "##";
            // 
            // Question
            // 
            Question.AutoSize = true;
            Question.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            Question.Location = new Point(69, 28);
            Question.Name = "Question";
            Question.Size = new Size(122, 32);
            Question.TabIndex = 0;
            Question.Text = "Question";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(1397, 760);
            button1.Name = "button1";
            button1.Size = new Size(169, 56);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(1397, 865);
            button2.Name = "button2";
            button2.Size = new Size(169, 56);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowText;
            button3.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Window;
            button3.Location = new Point(1397, 23);
            button3.Name = "button3";
            button3.Size = new Size(169, 56);
            button3.TabIndex = 3;
            button3.Text = "Quiz";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowText;
            button4.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(1397, 119);
            button4.Name = "button4";
            button4.Size = new Size(169, 56);
            button4.TabIndex = 4;
            button4.Text = "LeadBoard";
            button4.UseVisualStyleBackColor = false;
            // 
            // QuizPanel
            // 
            QuizPanel.BackColor = SystemColors.WindowText;
            QuizPanel.Controls.Add(ClickQuizPanel);
            QuizPanel.Controls.Add(button5);
            QuizPanel.Controls.Add(QuizShowPanel);
            QuizPanel.Location = new Point(501, 25);
            QuizPanel.Name = "QuizPanel";
            QuizPanel.Size = new Size(879, 896);
            QuizPanel.TabIndex = 5;
            // 
            // ClickQuizPanel
            // 
            ClickQuizPanel.BackColor = SystemColors.WindowFrame;
            ClickQuizPanel.Controls.Add(QuizID);
            ClickQuizPanel.Controls.Add(button9);
            ClickQuizPanel.Controls.Add(button6);
            ClickQuizPanel.Controls.Add(ClickQuizPanelUser);
            ClickQuizPanel.Controls.Add(label2);
            ClickQuizPanel.Controls.Add(label1);
            ClickQuizPanel.Controls.Add(ClickQuizPanelMarks);
            ClickQuizPanel.Controls.Add(ClickQuizPanelName);
            ClickQuizPanel.Location = new Point(49, 76);
            ClickQuizPanel.Name = "ClickQuizPanel";
            ClickQuizPanel.Size = new Size(751, 291);
            ClickQuizPanel.TabIndex = 7;
            // 
            // QuizID
            // 
            QuizID.AutoSize = true;
            QuizID.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuizID.ForeColor = SystemColors.Window;
            QuizID.Location = new Point(580, 75);
            QuizID.Name = "QuizID";
            QuizID.Size = new Size(140, 32);
            QuizID.TabIndex = 8;
            QuizID.Text = "QuizName";
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Window;
            button9.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(54, 215);
            button9.Name = "button9";
            button9.Size = new Size(112, 44);
            button9.TabIndex = 6;
            button9.Text = "Start";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(608, 215);
            button6.Name = "button6";
            button6.Size = new Size(112, 44);
            button6.TabIndex = 5;
            button6.Text = "Back";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ClickQuizPanelUser
            // 
            ClickQuizPanelUser.AutoSize = true;
            ClickQuizPanelUser.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickQuizPanelUser.ForeColor = SystemColors.Window;
            ClickQuizPanelUser.Location = new Point(232, 133);
            ClickQuizPanelUser.Name = "ClickQuizPanelUser";
            ClickQuizPanelUser.Size = new Size(140, 32);
            ClickQuizPanelUser.TabIndex = 4;
            ClickQuizPanelUser.Text = "QuizName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(54, 133);
            label2.Name = "label2";
            label2.Size = new Size(172, 32);
            label2.TabIndex = 3;
            label2.Text = "Created By : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(54, 75);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 2;
            label1.Text = "Total Marks :";
            // 
            // ClickQuizPanelMarks
            // 
            ClickQuizPanelMarks.AutoSize = true;
            ClickQuizPanelMarks.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickQuizPanelMarks.ForeColor = SystemColors.Window;
            ClickQuizPanelMarks.Location = new Point(231, 75);
            ClickQuizPanelMarks.Name = "ClickQuizPanelMarks";
            ClickQuizPanelMarks.Size = new Size(140, 32);
            ClickQuizPanelMarks.TabIndex = 1;
            ClickQuizPanelMarks.Text = "QuizName";
            // 
            // ClickQuizPanelName
            // 
            ClickQuizPanelName.AutoSize = true;
            ClickQuizPanelName.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClickQuizPanelName.ForeColor = SystemColors.Window;
            ClickQuizPanelName.Location = new Point(278, 9);
            ClickQuizPanelName.Name = "ClickQuizPanelName";
            ClickQuizPanelName.Size = new Size(140, 32);
            ClickQuizPanelName.TabIndex = 0;
            ClickQuizPanelName.Text = "QuizName";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Window;
            button5.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(727, 19);
            button5.Name = "button5";
            button5.Size = new Size(133, 51);
            button5.TabIndex = 6;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // QuizShowPanel
            // 
            QuizShowPanel.BackColor = SystemColors.Window;
            QuizShowPanel.Location = new Point(16, 94);
            QuizShowPanel.Name = "QuizShowPanel";
            QuizShowPanel.Size = new Size(844, 786);
            QuizShowPanel.TabIndex = 0;
            // 
            // PlayerForm3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 944);
            Controls.Add(QuestionPanel);
            Controls.Add(QuizPanel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ProfilePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlayerForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayerForm2";
            QuestionPanel.ResumeLayout(false);
            QuestionPanel.PerformLayout();
            QuizPanel.ResumeLayout(false);
            ClickQuizPanel.ResumeLayout(false);
            ClickQuizPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ProfilePanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel QuizPanel;
        private Panel QuizShowPanel;
        private Button button5;
        private Panel ClickQuizPanel;
        private Label ClickQuizPanelUser;
        private Label label2;
        private Button button8;
        private Button button7;
        private Button BackButton;
        private Panel clickQuizPanel;
        private Label clickQuizPanelUser;
        private Label clickQuizPanelMarks;
        private Label clickQuizPanelName;
        private Label ClickQuizPanelName;
        private Label label1;
        private Label ClickQuizPanelMarks;
        private Button button9;
        private Button button6;
        private Label QuizID;
        private Panel QuestionPanel;
        private Label QuestionNumber;
        private Label Question;
        private CheckBox AnswerD;
        private CheckBox AnswerC;
        private CheckBox AnswerB;
        private CheckBox AnswerA;
        private Button button10;
    }
}