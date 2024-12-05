﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizManagementSystem
{
    public partial class MasterForm : Form
    {
        QuizManager quizManager = new QuizManager();
        UserDetails userDetails = new UserDetails();
        public MasterForm(UserDetails userD)
        {
            InitializeComponent();
            userDetails = userD;
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            panelProfile.Visible = true;
            quizPanel.Visible = false;
            leadboardPanel.Visible = false;
            addingQuizPanel.Visible = false;
            clickQuizPanel.Visible = false;
            QuestionPanel.Visible = false;
            newQuestionForm.Visible = false;

            //Declared the user details to be displayed in the profile panel
            profileUsername.Text = userDetails.UserName; //Not working 
            profileEmail.Text = userDetails.Email;
            profileName.Text = userDetails.Name;

            LoadQuizzesToPanel();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sf sf = new sf();
            sf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quizPanel.Visible = true;
            leadboardPanel.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            leadboardPanel.Visible = true;
            quizPanel.Visible = false;

        }

        private void LoadQuizzesToPanel()
        {
            quizDisplay.Controls.Clear();
            Dictionary<int, Quiz> quizzes = quizManager.GetQuiz();

            int yOffset = 20;
            foreach (var entry in quizzes)
            {
                Quiz quiz = entry.Value;

                System.Windows.Forms.Button quizButton = new System.Windows.Forms.Button
                {
                    Text = $"{quiz.QuizName} - {quiz.Marks} Marks (Created by: {quiz.Username})",
                    Size = new Size(750, 100),
                    Location = new Point(20, yOffset),
                    BackColor = Color.BlueViolet,
                    ForeColor = Color.White,
                    Font = new Font("Times New Roman", 14)
                };

                quizButton.Click += (s, e) =>
                {
                    clickQuizPanel.Visible = true;
                    quizID.Visible = false;
                    //clickQuizPanel.BringToFront();
                    //this.Refresh();
                    clickQuizPanelName.Text = quiz.QuizName;
                    clickQuizPanelMarks.Text = quiz.Marks.ToString();
                    clickQuizPanelUser.Text = quiz.Username;
                    quizID.Text = quiz.QuizID.ToString();
                };

                quizDisplay.Controls.Add(quizButton);
                yOffset += 150;
            }
        }

        private void DisplayQuestions(int quizID)
        {
            panelQuestions.Controls.Clear();

            Dictionary<int, List<Question>> questionsDict = quizManager.LoadQuestionsGroupedByQuizID();

            if (!questionsDict.ContainsKey(quizID))
            {
                return;
            }

            List<Question> questions = questionsDict[quizID];
            int yOffset = 10;
            int num = 0;
            num++;
            foreach (var question in questions)
            {
                //Question. 
                Label questionLabel = new Label
                {
                    Text = $"Q{num}: {question.QuestionText}",
                    Location = new Point(10, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 12, FontStyle.Bold)
                };
                panelQuestions.Controls.Add(questionLabel);

                yOffset += 30;

                //Answers
                Label answerALabel = new Label
                {
                    Text = $"A: {question.AnswerA}",
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 10)
                };
                panelQuestions.Controls.Add(answerALabel);

                yOffset += 20;

                Label answerBLabel = new Label
                {
                    Text = $"B: {question.AnswerB}",
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 10)
                };
                panelQuestions.Controls.Add(answerBLabel);

                yOffset += 20;

                Label answerCLabel = new Label
                {
                    Text = $"C: {question.AnswerC}",
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 10)
                };
                panelQuestions.Controls.Add(answerCLabel);

                yOffset += 20;

                Label answerDLabel = new Label
                {
                    Text = $"D: {question.AnswerD}",
                    Location = new Point(20, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 10)
                };
                panelQuestions.Controls.Add(answerDLabel);

                yOffset += 30;

                Label correctAnswerLabel = new Label
                {
                    Text = $"Correct Answer: {question.CorrectAnswer}",
                    Location = new Point(10, yOffset),
                    AutoSize = true,
                    Font = new Font("Times New Roman", 10, FontStyle.Italic),
                    ForeColor = Color.Green
                };
                panelQuestions.Controls.Add(correctAnswerLabel);

                yOffset += 40;
            }

            panelQuestions.AutoScroll = true;
        }


        private void AddQuiz(string quizName, int marks, string userName)
        {
            quizManager.AddQuiz(quizName, marks, userName);
            LoadQuizzesToPanel();
        }

        private void addNewQuiz_Click(object sender, EventArgs e)
        {
            addingQuizPanel.Visible = true;
            addingQuizPanel.BringToFront();
        }

        private void addQuizButton_Click_1(object sender, EventArgs e)
        {
            AddQuiz(textBoxQuizName.Text, int.Parse(textBoxTotalMark.Text), userDetails.UserName);
            textBoxQuizName.Clear();
            textBoxTotalMark.Clear();
            addingQuizPanel.Visible = false;
        }

        private void clickQuizPanelBack_Click(object sender, EventArgs e)
        {
            clickQuizPanel.Visible = false;
        }

        private void clickQuizPanelDelete_Click(object sender, EventArgs e)
        {
            quizManager.DeleteQuiz(Int32.Parse(quizID.Text));
            clickQuizPanel.Visible = false;
            LoadQuizzesToPanel();
        }

        private void clickQuizPanelView_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = true;
            clickQuizPanel.Visible = false;
            quizDisplay.Visible = false;

            DisplayQuestions(Int32.Parse(quizID.Text));
        }


        private void newQuestionAdd_Click(object sender, EventArgs e)
        {
            newQuestionForm.Visible = true;
            newQuestionForm.BringToFront();
        }

        private void backtoQuizPanel_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            quizDisplay.Visible = true;
        }

        private void submitQuestion_Click(object sender, EventArgs e)
        {
            quizManager.AddQuestion(Int32.Parse(quizID.Text), question.Text, answerA.Text, answerB.Text, answerC.Text, answerD.Text, correctAnswer.Text.ToCharArray()[0]);
            newQuestionForm.Visible = false;
            DisplayQuestions(Int32.Parse(quizID.Text));
            question.Clear();
            answerA.Clear();
            answerB.Clear();
            answerC.Clear();
            answerD.Clear();
            correctAnswer.Clear();
        }

        private void cancelQuestion_Click(object sender, EventArgs e)
        {
            newQuestionForm.Visible = false;
            question.Clear();
            answerA.Clear();
            answerB.Clear();
            answerC.Clear();
            answerD.Clear();
            correctAnswer.Clear();
        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            question.Clear();
            answerA.Clear();
            answerB.Clear();
            answerC.Clear();
            answerD.Clear();
            correctAnswer.Clear();
        }

        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            quizManager.DeleteQuiz(Int32.Parse(quizID.Text));
            QuestionPanel.Visible = false;
            quizDisplay.Visible = true;
            LoadQuizzesToPanel();
        }
    }
}