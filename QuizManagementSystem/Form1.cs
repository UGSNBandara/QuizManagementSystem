using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace QuizManagementSystem
{
    public partial class sf : Form
    {
        private MasterLogin ml = new MasterLogin();
        private PlayerLogin pl = new PlayerLogin();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public sf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMaster.Visible = false;
            panelPlayer.Visible = false;
            wrongUsernamePasswordMaster.Visible = false;
            wrongUsernamePasswordPlayer.Visible = false;
            masterSignup.Visible = false;
            playerSignup.Visible = false;
        }

        private void userSlecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userSlecter.SelectedIndex == 0)
            {
                panelPlayer.Visible = true;
                panelMaster.Visible = false;
                masterSignup.Visible = false;
                playerSignup.Visible = false;
            }
            else if (userSlecter.SelectedIndex == 1)
            {
                panelMaster.Visible = true;
                panelPlayer.Visible = false;
                masterSignup.Visible = false;
                playerSignup.Visible = false;
            }
        }

        private void wrongUsernamePasswordPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogingMaster_Click(object sender, EventArgs e)
        {

            if (ml.CheckCredentials(masterUsernameInput.Text, masterPasswordInput.Text))
            {
                UserDetails userDetail = new UserDetails();
                userDetail.UserName = masterUsernameInput.Text;
                userDetail.Password = masterPasswordInput.Text;
                userDetail.Name = "Admin";
                userDetail.Email = "Admin@gmail.com";

                MasterForm mf = new MasterForm(userDetail);
                mf.Show();
                this.Hide();
            }
            else
            {
                wrongUsernamePasswordMaster.Visible = true;
                masterPasswordInput.Clear();
                masterUsernameInput.Clear();
            }
        }

        private void buttonLoginPlayer_Click(object sender, EventArgs e)
        {
            if (pl.CheckCredentials(playerUsernameInput.Text, playerPasswordInput.Text))
            {
                UserDetails userDetail = new UserDetails();
                userDetail.UserName = playerUsernameInput.Text;
                userDetail.Password = playerPasswordInput.Text;

                PlayerForm3 pf = new PlayerForm3();
                pf.Show();
                this.Hide();
            }
            else
            {
                wrongUsernamePasswordPlayer.Visible = true;
                playerUsernameInput.Clear();
                playerPasswordInput.Clear();
            }
        }

        private void buttonSignUpMaster_Click(object sender, EventArgs e)
        {
            masterSignup.Visible = true;
            errorSignupM.Visible = false;
            panelMaster.Visible = false;
            panelPlayer.Visible = false;
            playerSignup.Visible = false;
        }

        private void buttonSignUpPlayer_Click(object sender, EventArgs e)
        {
            playerSignup.Visible = true;
            errorSingupP.Visible = false;
            panelPlayer.Visible = false;
            panelMaster.Visible = false;
            masterSignup.Visible = false;
        }

        private void buttonCreateM_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ml.SignUp(name, email, username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateP_Click(object sender, EventArgs e)
        {
            string name = textBoxNameP.Text;
            string email = textBoxEmailP.Text;
            string username = textBoxUsernameP.Text;
            string password = textBoxPasswordP.Text;

            if (pl.SignUp(name, email, username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

