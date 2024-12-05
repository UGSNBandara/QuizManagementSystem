namespace QuizManagementSystem
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            navPanel = new Panel();
            leadboardPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
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
            quizPanel = new Panel();
            addingQuizPanel = new Panel();
            addQuizButton = new Button();
            textBoxTotalMark = new TextBox();
            textBoxQuizName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            addNewQuiz = new Button();
            clickQuizPanel = new Panel();
            quizID = new Label();
            clickQuizPanelBack = new Button();
            clickQuizPanelUser = new Label();
            label10 = new Label();
            clickQuizPanelDelete = new Button();
            clickQuizPanelView = new Button();
            clickQuizPanelMarks = new Label();
            label11 = new Label();
            clickQuizPanelName = new Label();
            quizDisplay = new Panel();
            QuestionPanel = new Panel();
            panelQuestions = new Panel();
            backtoQuizPanel = new Button();
            newQuestionAdd = new Button();
            deleteQuestion = new Button();
            newQuestionForm = new Panel();
            label14 = new Label();
            label12 = new Label();
            label5 = new Label();
            label4 = new Label();
            answernum = new Label();
            correctAnswer = new TextBox();
            cancelQuestion = new Button();
            clearBox = new Button();
            submitQuestion = new Button();
            answerD = new TextBox();
            answerC = new TextBox();
            answerB = new TextBox();
            answerA = new TextBox();
            question = new TextBox();
            navPanel.SuspendLayout();
            panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            quizPanel.SuspendLayout();
            addingQuizPanel.SuspendLayout();
            clickQuizPanel.SuspendLayout();
            QuestionPanel.SuspendLayout();
            newQuestionForm.SuspendLayout();
            SuspendLayout();
            // 
            // navPanel
            // 
            navPanel.Controls.Add(leadboardPanel);
            navPanel.Controls.Add(button4);
            navPanel.Controls.Add(button3);
            navPanel.Controls.Add(button2);
            navPanel.Controls.Add(button1);
            navPanel.Location = new Point(1350, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(250, 1000);
            navPanel.TabIndex = 0;
            // 
            // leadboardPanel
            // 
            leadboardPanel.AutoScroll = true;
            leadboardPanel.BackColor = Color.Violet;
            leadboardPanel.Location = new Point(73, 339);
            leadboardPanel.Name = "leadboardPanel";
            leadboardPanel.Size = new Size(94, 91);
            leadboardPanel.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Times New Roman", 14F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(42, 929);
            button4.Name = "button4";
            button4.Size = new Size(175, 50);
            button4.TabIndex = 10;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Times New Roman", 14F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(42, 845);
            button3.Name = "button3";
            button3.Size = new Size(175, 50);
            button3.TabIndex = 9;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowText;
            button2.Font = new Font("Times New Roman", 14F);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(42, 113);
            button2.Name = "button2";
            button2.Size = new Size(175, 50);
            button2.TabIndex = 8;
            button2.Text = "LeadBoard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowText;
            button1.Font = new Font("Times New Roman", 14F);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(42, 31);
            button1.Name = "button1";
            button1.Size = new Size(175, 50);
            button1.TabIndex = 7;
            button1.Text = "Quizes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            panelProfile.TabIndex = 2;
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
            // quizPanel
            // 
            quizPanel.BackColor = SystemColors.WindowText;
            quizPanel.Controls.Add(addingQuizPanel);
            quizPanel.Controls.Add(addNewQuiz);
            quizPanel.Controls.Add(clickQuizPanel);
            quizPanel.Controls.Add(quizDisplay);
            quizPanel.Location = new Point(471, 13);
            quizPanel.Name = "quizPanel";
            quizPanel.Size = new Size(873, 975);
            quizPanel.TabIndex = 3;
            // 
            // addingQuizPanel
            // 
            addingQuizPanel.BackColor = SystemColors.WindowFrame;
            addingQuizPanel.Controls.Add(addQuizButton);
            addingQuizPanel.Controls.Add(textBoxTotalMark);
            addingQuizPanel.Controls.Add(textBoxQuizName);
            addingQuizPanel.Controls.Add(label9);
            addingQuizPanel.Controls.Add(label8);
            addingQuizPanel.Controls.Add(label7);
            addingQuizPanel.Location = new Point(85, 82);
            addingQuizPanel.Name = "addingQuizPanel";
            addingQuizPanel.Size = new Size(723, 314);
            addingQuizPanel.TabIndex = 4;
            // 
            // addQuizButton
            // 
            addQuizButton.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addQuizButton.Location = new Point(557, 248);
            addQuizButton.Name = "addQuizButton";
            addQuizButton.Size = new Size(122, 44);
            addQuizButton.TabIndex = 2;
            addQuizButton.Text = "Add ";
            addQuizButton.UseVisualStyleBackColor = true;
            addQuizButton.Click += addQuizButton_Click_1;
            // 
            // textBoxTotalMark
            // 
            textBoxTotalMark.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotalMark.Font = new Font("Times New Roman", 12F);
            textBoxTotalMark.Location = new Point(230, 178);
            textBoxTotalMark.Name = "textBoxTotalMark";
            textBoxTotalMark.Size = new Size(156, 35);
            textBoxTotalMark.TabIndex = 4;
            // 
            // textBoxQuizName
            // 
            textBoxQuizName.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuizName.Font = new Font("Times New Roman", 12F);
            textBoxQuizName.Location = new Point(230, 100);
            textBoxQuizName.Name = "textBoxQuizName";
            textBoxQuizName.Size = new Size(449, 35);
            textBoxQuizName.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(20, 178);
            label9.Name = "label9";
            label9.Size = new Size(155, 32);
            label9.TabIndex = 2;
            label9.Text = "Total marks";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(20, 97);
            label8.Name = "label8";
            label8.Size = new Size(132, 32);
            label8.TabIndex = 1;
            label8.Text = "Quiz Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(263, 24);
            label7.Name = "label7";
            label7.Size = new Size(196, 32);
            label7.TabIndex = 0;
            label7.Text = "Add Your Quiz";
            // 
            // addNewQuiz
            // 
            addNewQuiz.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewQuiz.Location = new Point(726, 34);
            addNewQuiz.Name = "addNewQuiz";
            addNewQuiz.Size = new Size(122, 44);
            addNewQuiz.TabIndex = 1;
            addNewQuiz.Text = "Add ";
            addNewQuiz.UseVisualStyleBackColor = true;
            addNewQuiz.Click += addNewQuiz_Click;
            // 
            // clickQuizPanel
            // 
            clickQuizPanel.BackColor = SystemColors.WindowFrame;
            clickQuizPanel.Controls.Add(quizID);
            clickQuizPanel.Controls.Add(clickQuizPanelBack);
            clickQuizPanel.Controls.Add(clickQuizPanelUser);
            clickQuizPanel.Controls.Add(label10);
            clickQuizPanel.Controls.Add(clickQuizPanelDelete);
            clickQuizPanel.Controls.Add(clickQuizPanelView);
            clickQuizPanel.Controls.Add(clickQuizPanelMarks);
            clickQuizPanel.Controls.Add(label11);
            clickQuizPanel.Controls.Add(clickQuizPanelName);
            clickQuizPanel.Location = new Point(85, 84);
            clickQuizPanel.Name = "clickQuizPanel";
            clickQuizPanel.Size = new Size(723, 278);
            clickQuizPanel.TabIndex = 5;
            // 
            // quizID
            // 
            quizID.AutoSize = true;
            quizID.BackColor = SystemColors.Window;
            quizID.Location = new Point(634, 41);
            quizID.Name = "quizID";
            quizID.Size = new Size(27, 25);
            quizID.TabIndex = 8;
            quizID.Text = "id";
            quizID.UseWaitCursor = true;
            // 
            // clickQuizPanelBack
            // 
            clickQuizPanelBack.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickQuizPanelBack.Location = new Point(39, 194);
            clickQuizPanelBack.Name = "clickQuizPanelBack";
            clickQuizPanelBack.Size = new Size(136, 55);
            clickQuizPanelBack.TabIndex = 7;
            clickQuizPanelBack.Text = "Back";
            clickQuizPanelBack.UseVisualStyleBackColor = true;
            clickQuizPanelBack.Click += clickQuizPanelBack_Click;
            // 
            // clickQuizPanelUser
            // 
            clickQuizPanelUser.AutoSize = true;
            clickQuizPanelUser.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            clickQuizPanelUser.ForeColor = SystemColors.Window;
            clickQuizPanelUser.Location = new Point(255, 128);
            clickQuizPanelUser.Name = "clickQuizPanelUser";
            clickQuizPanelUser.Size = new Size(165, 36);
            clickQuizPanelUser.TabIndex = 6;
            clickQuizPanelUser.Text = "User Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(39, 128);
            label10.Name = "label10";
            label10.Size = new Size(196, 36);
            label10.TabIndex = 5;
            label10.Text = "Created By : ";
            // 
            // clickQuizPanelDelete
            // 
            clickQuizPanelDelete.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickQuizPanelDelete.Location = new Point(557, 194);
            clickQuizPanelDelete.Name = "clickQuizPanelDelete";
            clickQuizPanelDelete.Size = new Size(136, 55);
            clickQuizPanelDelete.TabIndex = 4;
            clickQuizPanelDelete.Text = "Delete";
            clickQuizPanelDelete.UseVisualStyleBackColor = true;
            clickQuizPanelDelete.Click += clickQuizPanelDelete_Click;
            // 
            // clickQuizPanelView
            // 
            clickQuizPanelView.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clickQuizPanelView.Location = new Point(195, 194);
            clickQuizPanelView.Name = "clickQuizPanelView";
            clickQuizPanelView.Size = new Size(136, 55);
            clickQuizPanelView.TabIndex = 3;
            clickQuizPanelView.Text = "View";
            clickQuizPanelView.UseVisualStyleBackColor = true;
            clickQuizPanelView.Click += clickQuizPanelView_Click;
            // 
            // clickQuizPanelMarks
            // 
            clickQuizPanelMarks.AutoSize = true;
            clickQuizPanelMarks.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            clickQuizPanelMarks.ForeColor = SystemColors.Window;
            clickQuizPanelMarks.Location = new Point(246, 70);
            clickQuizPanelMarks.Name = "clickQuizPanelMarks";
            clickQuizPanelMarks.Size = new Size(47, 36);
            clickQuizPanelMarks.TabIndex = 2;
            clickQuizPanelMarks.Text = "10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(39, 70);
            label11.Name = "label11";
            label11.Size = new Size(210, 36);
            label11.TabIndex = 1;
            label11.Text = "Total Marks : ";
            // 
            // clickQuizPanelName
            // 
            clickQuizPanelName.AutoSize = true;
            clickQuizPanelName.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            clickQuizPanelName.ForeColor = SystemColors.Window;
            clickQuizPanelName.Location = new Point(279, 16);
            clickQuizPanelName.Name = "clickQuizPanelName";
            clickQuizPanelName.Size = new Size(160, 36);
            clickQuizPanelName.TabIndex = 0;
            clickQuizPanelName.Text = "QuizName";
            clickQuizPanelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quizDisplay
            // 
            quizDisplay.AutoScroll = true;
            quizDisplay.BackColor = SystemColors.Window;
            quizDisplay.Location = new Point(22, 143);
            quizDisplay.Name = "quizDisplay";
            quizDisplay.Size = new Size(826, 800);
            quizDisplay.TabIndex = 1;
            // 
            // QuestionPanel
            // 
            QuestionPanel.BackColor = SystemColors.WindowText;
            QuestionPanel.Controls.Add(panelQuestions);
            QuestionPanel.Controls.Add(backtoQuizPanel);
            QuestionPanel.Controls.Add(newQuestionAdd);
            QuestionPanel.Controls.Add(deleteQuestion);
            QuestionPanel.Location = new Point(471, 12);
            QuestionPanel.Name = "QuestionPanel";
            QuestionPanel.Size = new Size(873, 976);
            QuestionPanel.TabIndex = 4;
            // 
            // panelQuestions
            // 
            panelQuestions.BackColor = SystemColors.Window;
            panelQuestions.Location = new Point(10, 19);
            panelQuestions.Name = "panelQuestions";
            panelQuestions.Size = new Size(849, 864);
            panelQuestions.TabIndex = 0;
            // 
            // backtoQuizPanel
            // 
            backtoQuizPanel.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backtoQuizPanel.Location = new Point(592, 905);
            backtoQuizPanel.Name = "backtoQuizPanel";
            backtoQuizPanel.Size = new Size(118, 47);
            backtoQuizPanel.TabIndex = 3;
            backtoQuizPanel.Text = "Back";
            backtoQuizPanel.UseVisualStyleBackColor = true;
            backtoQuizPanel.Click += backtoQuizPanel_Click;
            // 
            // newQuestionAdd
            // 
            newQuestionAdd.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newQuestionAdd.Location = new Point(10, 905);
            newQuestionAdd.Name = "newQuestionAdd";
            newQuestionAdd.Size = new Size(118, 47);
            newQuestionAdd.TabIndex = 2;
            newQuestionAdd.Text = "Add";
            newQuestionAdd.UseVisualStyleBackColor = true;
            newQuestionAdd.Click += newQuestionAdd_Click;
            // 
            // deleteQuestion
            // 
            deleteQuestion.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteQuestion.Location = new Point(741, 905);
            deleteQuestion.Name = "deleteQuestion";
            deleteQuestion.Size = new Size(118, 47);
            deleteQuestion.TabIndex = 1;
            deleteQuestion.Text = "Delete";
            deleteQuestion.UseVisualStyleBackColor = true;
            deleteQuestion.Click += deleteQuestion_Click;
            // 
            // newQuestionForm
            // 
            newQuestionForm.BackColor = SystemColors.HotTrack;
            newQuestionForm.Controls.Add(label14);
            newQuestionForm.Controls.Add(label12);
            newQuestionForm.Controls.Add(label5);
            newQuestionForm.Controls.Add(label4);
            newQuestionForm.Controls.Add(answernum);
            newQuestionForm.Controls.Add(correctAnswer);
            newQuestionForm.Controls.Add(cancelQuestion);
            newQuestionForm.Controls.Add(clearBox);
            newQuestionForm.Controls.Add(submitQuestion);
            newQuestionForm.Controls.Add(answerD);
            newQuestionForm.Controls.Add(answerC);
            newQuestionForm.Controls.Add(answerB);
            newQuestionForm.Controls.Add(answerA);
            newQuestionForm.Controls.Add(question);
            newQuestionForm.Location = new Point(471, 12);
            newQuestionForm.Name = "newQuestionForm";
            newQuestionForm.Size = new Size(867, 430);
            newQuestionForm.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.HotTrack;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Window;
            label14.Location = new Point(29, 307);
            label14.Name = "label14";
            label14.Size = new Size(114, 38);
            label14.TabIndex = 20;
            label14.Text = "Answer";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.HotTrack;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(548, 234);
            label12.Name = "label12";
            label12.Size = new Size(38, 38);
            label12.TabIndex = 19;
            label12.Text = "D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HotTrack;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(548, 138);
            label5.Name = "label5";
            label5.Size = new Size(35, 38);
            label5.TabIndex = 18;
            label5.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HotTrack;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(29, 235);
            label4.Name = "label4";
            label4.Size = new Size(34, 38);
            label4.TabIndex = 17;
            label4.Text = "C";
            // 
            // answernum
            // 
            answernum.AutoSize = true;
            answernum.BackColor = SystemColors.HotTrack;
            answernum.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answernum.ForeColor = SystemColors.Window;
            answernum.Location = new Point(29, 138);
            answernum.Name = "answernum";
            answernum.Size = new Size(37, 38);
            answernum.TabIndex = 16;
            answernum.Text = "A";
            // 
            // correctAnswer
            // 
            correctAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correctAnswer.Location = new Point(172, 306);
            correctAnswer.Name = "correctAnswer";
            correctAnswer.Size = new Size(76, 39);
            correctAnswer.TabIndex = 15;
            // 
            // cancelQuestion
            // 
            cancelQuestion.Font = new Font("Segoe UI", 14F);
            cancelQuestion.Location = new Point(455, 349);
            cancelQuestion.Name = "cancelQuestion";
            cancelQuestion.Size = new Size(107, 48);
            cancelQuestion.TabIndex = 14;
            cancelQuestion.Text = "Cancel";
            cancelQuestion.UseVisualStyleBackColor = true;
            cancelQuestion.Click += cancelQuestion_Click;
            // 
            // clearBox
            // 
            clearBox.Font = new Font("Segoe UI", 14F);
            clearBox.Location = new Point(600, 349);
            clearBox.Name = "clearBox";
            clearBox.Size = new Size(99, 48);
            clearBox.TabIndex = 13;
            clearBox.Text = "Clear";
            clearBox.UseVisualStyleBackColor = true;
            clearBox.Click += clearBox_Click;
            // 
            // submitQuestion
            // 
            submitQuestion.Font = new Font("Segoe UI", 14F);
            submitQuestion.Location = new Point(741, 349);
            submitQuestion.Name = "submitQuestion";
            submitQuestion.Size = new Size(104, 48);
            submitQuestion.TabIndex = 12;
            submitQuestion.Text = "Add";
            submitQuestion.UseVisualStyleBackColor = true;
            submitQuestion.Click += submitQuestion_Click;
            // 
            // answerD
            // 
            answerD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerD.Location = new Point(600, 234);
            answerD.Name = "answerD";
            answerD.Size = new Size(248, 39);
            answerD.TabIndex = 11;
            // 
            // answerC
            // 
            answerC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerC.Location = new Point(72, 235);
            answerC.Name = "answerC";
            answerC.Size = new Size(248, 39);
            answerC.TabIndex = 10;
            // 
            // answerB
            // 
            answerB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerB.Location = new Point(600, 139);
            answerB.Name = "answerB";
            answerB.Size = new Size(248, 39);
            answerB.TabIndex = 9;
            // 
            // answerA
            // 
            answerA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerA.Location = new Point(72, 139);
            answerA.Name = "answerA";
            answerA.Size = new Size(248, 39);
            answerA.TabIndex = 8;
            // 
            // question
            // 
            question.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question.Location = new Point(23, 34);
            question.Name = "question";
            question.Size = new Size(825, 39);
            question.TabIndex = 7;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1600, 1000);
            Controls.Add(newQuestionForm);
            Controls.Add(QuestionPanel);
            Controls.Add(quizPanel);
            Controls.Add(panelProfile);
            Controls.Add(navPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterForm";
            Load += MasterForm_Load;
            navPanel.ResumeLayout(false);
            panelProfile.ResumeLayout(false);
            panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            quizPanel.ResumeLayout(false);
            addingQuizPanel.ResumeLayout(false);
            addingQuizPanel.PerformLayout();
            clickQuizPanel.ResumeLayout(false);
            clickQuizPanel.PerformLayout();
            QuestionPanel.ResumeLayout(false);
            newQuestionForm.ResumeLayout(false);
            newQuestionForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navPanel;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Panel panelProfile;
        private Label label6;
        private Label label2;
        private Label profileEmail;
        private Label profileUsername;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label13;
        private Label profileName;
        private Panel quizPanel;
        private Panel leadboardPanel;
        private Panel quizDisplay;
        private Button addNewQuiz;
        private Panel addingQuizPanel;
        private Button addQuizButton;
        private TextBox textBoxTotalMark;
        private TextBox textBoxQuizName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel clickQuizPanel;
        private Label clickQuizPanelName;
        private Button clickQuizPanelView;
        private Label clickQuizPanelMarks;
        private Label label11;
        private Button clickQuizPanelDelete;
        private Label clickQuizPanelUser;
        private Label label10;
        private Button clickQuizPanelBack;
        private Label quizID;
        private Panel QuestionPanel;
        private Button deleteQuestion;
        private Panel panelQuestions;
        private Button backtoQuizPanel;
        private Button newQuestionAdd;
        private Panel newQuestionForm;
        private Button submitQuestion;
        private TextBox answerD;
        private TextBox answerC;
        private TextBox answerB;
        private TextBox answerA;
        private TextBox question;
        private Button cancelQuestion;
        private TextBox correctAnswer;
        private Label label5;
        private Label label4;
        private Label answernum;
        private Label label14;
        private Label label12;
        private Button clearBox;
    }
}