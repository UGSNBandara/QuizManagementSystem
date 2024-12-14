using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagementSystem
{
    public partial class PlayerForm3 : Form
    {
        QuizManager quizManager = new QuizManager();
        UserDetails userDetails = new UserDetails();

        private int currentQuestionIndex = 0;
        private List<Question> playerQuestions;
        private int playerScore = 0;
        private Dictionary<int, List<Question>> questionsDict;

        public PlayerForm3()
        {
            InitializeComponent();
            ProfilePanel.Visible = true;
            ClickQuizPanel.Visible = false;
            QuizPanel.Visible = false;
            QuizID.Visible = false;
            QuestionPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sf f1 = new sf();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadQuizzesToPanel()
        {
            QuizShowPanel.Controls.Clear();
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
                     ClickQuizPanel.Visible = true;
                     //clickQuizPanel.BringToFront();
                     //this.Refresh();
                     ClickQuizPanelName.Text = quiz.QuizName;
                     ClickQuizPanelMarks.Text = quiz.Marks.ToString();
                     ClickQuizPanelUser.Text = quiz.Username;
                     QuizID.Text = quiz.QuizID.ToString();
                 };

                QuizShowPanel.Controls.Add(quizButton);
                yOffset += 150;
            }
        }

        private void LoadQuestionToDictionary()
        {
            questionsDict = quizManager.LoadQuestionsGroupedByQuizID();
        }

        private void StartQuiz(int quizID)
        {
            playerQuestions = questionsDict[quizID];
            //Should be solve this case when there is no question in the quiz
            currentQuestionIndex = 0;
            playerScore = 0;
            DisplayQuestion(currentQuestionIndex);
        }

        private void DisplayQuestion(int CurrentQuestionIndex)
        {
            if (currentQuestionIndex >= playerQuestions.Count)
            {
                ShowResult();
                return;
            }

            Question currentQuestion = playerQuestions[currentQuestionIndex];

            Question.Text = currentQuestion.QuestionText;

            AnswerA.Text = currentQuestion.AnswerA;
            AnswerB.Text = currentQuestion.AnswerB;
            AnswerC.Text = currentQuestion.AnswerC;
            AnswerD.Text = currentQuestion.AnswerD;
            QuestionNumber.Text = (CurrentQuestionIndex + 1).ToString();

            AnswerA.Checked = false;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            AnswerD.Checked = false;
        }

        //for Submit button
        private void button8_Click(object sender, EventArgs e)
        {
            char selectedAnswer = '_';

            if (AnswerA.Checked) selectedAnswer = 'A';
            else if (AnswerB.Checked) selectedAnswer = 'B';
            else if (AnswerC.Checked) selectedAnswer = 'C';
            else if (AnswerD.Checked) selectedAnswer = 'D';

            if (selectedAnswer == '_')
            {
                MessageBox.Show("Please select an answer before submitting.");
                return;
            }

            if (selectedAnswer == playerQuestions[currentQuestionIndex].CorrectAnswer)
            {
                playerScore++;
            }
            currentQuestionIndex++;
            DisplayQuestion(currentQuestionIndex);
        }

        //To skip button
        private void button7_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            DisplayQuestion(currentQuestionIndex);
        }

        private void ShowResult()
        {
            MessageBox.Show($"You have scored {playerScore} out of {playerQuestions.Count}");
            QuestionPanel.Visible = false;
            QuizPanel.Visible = true;
            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuizPanel.Visible = true;
            LoadQuizzesToPanel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClickQuizPanel.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            QuestionPanel.Visible = true;
            ClickQuizPanel.Visible = false;
            QuizPanel.Visible = false;
            LoadQuestionToDictionary();
            StartQuiz(int.Parse(QuizID.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadQuizzesToPanel();
        }

        private void AnswerA_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = true;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            AnswerD.Checked = false;
        }

        private void AnswerB_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            AnswerB.Checked = true;
            AnswerD.Checked = false;
            AnswerC.Checked = false;

        }

        private void AnswerC_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            AnswerB.Checked = false;
            AnswerC.Checked = true;
            AnswerD.Checked = false;
        }

        private void AnswerD_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            AnswerD.Checked = true;
        }
    }
}
