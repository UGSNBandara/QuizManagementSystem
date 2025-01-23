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
        PlayerLogin playerLogin = new PlayerLogin();
        Player userDetails = new Player();

        bool leadboard = false;

        private int currentQuestionIndex = 0;
        private List<Question> playerQuestions;
        private int playerScore = 0;


        public PlayerForm3(Player p)
        {
            InitializeComponent();
            ProfilePanel.Visible = true;
            ClickQuizPanel.Visible = false;
            QuizPanel.Visible = true;
            QuizID.Visible = false;
            QuestionPanel.Visible = false;
            userDetails = p;
            updateProfileData();
            updateSignUpPlayer();
        }

        private void updateProfileData()
        {
            UsernameProfile.Text = userDetails.Username;
            profileName.Text = userDetails.Name;
            profileEmail.Text = userDetails.Email;
            profileUsername.Text = userDetails.Username;
            profileScore.Text = userDetails.Score.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sf f1 = new sf();
            f1.Show();
            this.Hide();
        }

        //to add sigup paler in current DB since not connected DB yet
        private void updateSignUpPlayer()
        {
            playerLogin.AddPlayer(userDetails.Username, userDetails.Name, userDetails.Score, userDetails.Email, userDetails.Password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadQuizzesToPanel()
        {
            QuizShowPanel.Controls.Clear();
            IEnumerable<Quiz> quizzes = quizManager.quizzes.GetQuizzesInLinkedListOrder();

            int yOffset = 20;
            foreach (Quiz quiz in quizzes)
            {
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
                    ClickQuizPanelName.Text = quiz.QuizName;
                    ClickQuizPanelMarks.Text = quiz.Marks.ToString();
                    ClickQuizPanelUser.Text = quiz.Username;
                    QuizID.Text = quiz.QuizID.ToString();
                };

                QuizShowPanel.Controls.Add(quizButton);
                yOffset += 150;
            }
        }

        public void LoadPlayersToLeadBoard()
        {
            QuizShowPanel.Controls.Clear();

            IEnumerable<Player> players = playerLogin.GetPlayersInOder();

            const int buttonWidth = 750;
            const int buttonHeight = 100;
            int yOffset = 20;

            List<Button> quizButtons = new List<Button>();
            int rank = 0; 

            foreach (Player player in players)
            {
                Button quizButton = new Button
                {
                    Text = $"{player.Username}  -  {player.Score}  -  {rank + 1})",
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(20, yOffset),
                    BackColor = Color.RoyalBlue, 
                    ForeColor = Color.White,
                    Font = new Font("Times New Roman", 14)
                };

                quizButtons.Add(quizButton);
                yOffset += 150;
                rank++;
            }

            QuizShowPanel.Controls.AddRange(quizButtons.ToArray());
        }



        private void StartQuiz(int quizID)
        {
            playerQuestions = quizManager.GetQuestionsByQuizID(quizID);
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
                playerLogin.UpdateScore(userDetails.Username, playerScore);
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
            StartQuiz(int.Parse(QuizID.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (leadboard)
            {
                LoadPlayersToLeadBoard();
            }
            else
            {
                LoadQuizzesToPanel();
            }
        }

        private void AnswerA_CheckedChanged(object sender, EventArgs e)
        {
            //AnswerA.Checked = true;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            AnswerD.Checked = false;
        }

        private void AnswerB_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            //AnswerB.Checked = true;
            AnswerD.Checked = false;
            AnswerC.Checked = false;

        }

        private void AnswerC_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            AnswerB.Checked = false;
            //AnswerC.Checked = true;
            AnswerD.Checked = false;
        }

        private void AnswerD_CheckedChanged(object sender, EventArgs e)
        {
            AnswerA.Checked = false;
            AnswerB.Checked = false;
            AnswerC.Checked = false;
            //AnswerD.Checked = true;
        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadPlayersToLeadBoard();
            leadboard = true;
        }
    }
}
