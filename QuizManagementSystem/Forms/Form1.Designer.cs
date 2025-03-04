
namespace QuizManagementSystem
{
    partial class sf
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            userSlecter = new ComboBox();
            button1 = new Button();
            panelMaster = new Panel();
            wrongUsernamePasswordMaster = new Label();
            label6 = new Label();
            buttonSignUpMaster = new Button();
            buttonLogingMaster = new Button();
            masterPasswordInput = new TextBox();
            masterUsernameInput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            playerSignup = new Panel();
            textBoxEmailP = new TextBox();
            errorSingupP = new Label();
            buttonCreateP = new Button();
            label22 = new Label();
            textBoxPasswordP = new TextBox();
            textBoxUsernameP = new TextBox();
            textBoxNameP = new TextBox();
            label23 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panelPlayer = new Panel();
            wrongUsernamePasswordPlayer = new Label();
            label8 = new Label();
            buttonSignUpPlayer = new Button();
            buttonLoginPlayer = new Button();
            playerPasswordInput = new TextBox();
            playerUsernameInput = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            masterSignup = new Panel();
            textBoxEmail = new TextBox();
            label21 = new Label();
            textBoxName = new TextBox();
            label12 = new Label();
            errorSignupM = new Label();
            buttonCreateM = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            panel1 = new Panel();
            label17 = new Label();
            label16 = new Label();
            label7 = new Label();
            panelMaster.SuspendLayout();
            playerSignup.SuspendLayout();
            panelPlayer.SuspendLayout();
            masterSignup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(72, 798);
            label2.Name = "label2";
            label2.Size = new Size(182, 26);
            label2.TabIndex = 1;
            label2.Text = "Select User Type";
            // 
            // userSlecter
            // 
            userSlecter.BackColor = SystemColors.InactiveBorder;
            userSlecter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userSlecter.ForeColor = SystemColors.InfoText;
            userSlecter.FormattingEnabled = true;
            userSlecter.Items.AddRange(new object[] { "Player", "Quiz Master" });
            userSlecter.Location = new Point(72, 842);
            userSlecter.Name = "userSlecter";
            userSlecter.Size = new Size(182, 46);
            userSlecter.TabIndex = 2;
            userSlecter.SelectedIndexChanged += userSlecter_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaptionText;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(1454, 933);
            button1.Name = "button1";
            button1.Size = new Size(134, 55);
            button1.TabIndex = 3;
            button1.Text = "Exit ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelMaster
            // 
            panelMaster.BackColor = SystemColors.Window;
            panelMaster.Controls.Add(wrongUsernamePasswordMaster);
            panelMaster.Controls.Add(label6);
            panelMaster.Controls.Add(buttonSignUpMaster);
            panelMaster.Controls.Add(buttonLogingMaster);
            panelMaster.Controls.Add(masterPasswordInput);
            panelMaster.Controls.Add(masterUsernameInput);
            panelMaster.Controls.Add(label5);
            panelMaster.Controls.Add(label4);
            panelMaster.Controls.Add(label3);
            panelMaster.Location = new Point(928, 75);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(640, 800);
            panelMaster.TabIndex = 4;
            // 
            // wrongUsernamePasswordMaster
            // 
            wrongUsernamePasswordMaster.AutoSize = true;
            wrongUsernamePasswordMaster.Font = new Font("Times New Roman", 14F);
            wrongUsernamePasswordMaster.ForeColor = Color.Red;
            wrongUsernamePasswordMaster.Location = new Point(144, 644);
            wrongUsernamePasswordMaster.Name = "wrongUsernamePasswordMaster";
            wrongUsernamePasswordMaster.Size = new Size(364, 33);
            wrongUsernamePasswordMaster.TabIndex = 8;
            wrongUsernamePasswordMaster.Text = "Wrong user name or password !";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14F);
            label6.Location = new Point(161, 501);
            label6.Name = "label6";
            label6.Size = new Size(306, 33);
            label6.TabIndex = 7;
            label6.Text = "Do not have an Account  ?";
            // 
            // buttonSignUpMaster
            // 
            buttonSignUpMaster.BackColor = SystemColors.WindowText;
            buttonSignUpMaster.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSignUpMaster.ForeColor = SystemColors.Window;
            buttonSignUpMaster.Location = new Point(34, 551);
            buttonSignUpMaster.Name = "buttonSignUpMaster";
            buttonSignUpMaster.Size = new Size(575, 70);
            buttonSignUpMaster.TabIndex = 6;
            buttonSignUpMaster.Text = "Sign Up";
            buttonSignUpMaster.UseVisualStyleBackColor = false;
            buttonSignUpMaster.Click += buttonSignUpMaster_Click;
            // 
            // buttonLogingMaster
            // 
            buttonLogingMaster.BackColor = SystemColors.WindowText;
            buttonLogingMaster.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLogingMaster.ForeColor = SystemColors.Window;
            buttonLogingMaster.Location = new Point(34, 387);
            buttonLogingMaster.Name = "buttonLogingMaster";
            buttonLogingMaster.Size = new Size(575, 70);
            buttonLogingMaster.TabIndex = 5;
            buttonLogingMaster.Text = "Login";
            buttonLogingMaster.UseVisualStyleBackColor = false;
            buttonLogingMaster.Click += buttonLogingMaster_Click;
            // 
            // masterPasswordInput
            // 
            masterPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            masterPasswordInput.Font = new Font("Segoe UI", 12F);
            masterPasswordInput.Location = new Point(205, 232);
            masterPasswordInput.Name = "masterPasswordInput";
            masterPasswordInput.Size = new Size(404, 39);
            masterPasswordInput.TabIndex = 4;
            masterPasswordInput.TextAlign = HorizontalAlignment.Center;
            // 
            // masterUsernameInput
            // 
            masterUsernameInput.BorderStyle = BorderStyle.FixedSingle;
            masterUsernameInput.Font = new Font("Segoe UI", 12F);
            masterUsernameInput.Location = new Point(205, 151);
            masterUsernameInput.Name = "masterUsernameInput";
            masterUsernameInput.Size = new Size(404, 39);
            masterUsernameInput.TabIndex = 3;
            masterUsernameInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16F);
            label5.Location = new Point(34, 235);
            label5.Margin = new Padding(1);
            label5.Name = "label5";
            label5.Size = new Size(135, 36);
            label5.TabIndex = 2;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16F);
            label4.Location = new Point(34, 156);
            label4.Margin = new Padding(1);
            label4.Name = "label4";
            label4.Size = new Size(155, 36);
            label4.TabIndex = 1;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 17);
            label3.Name = "label3";
            label3.Size = new Size(273, 36);
            label3.TabIndex = 0;
            label3.Text = "Quiz Master Login";
            // 
            // playerSignup
            // 
            playerSignup.BackColor = SystemColors.Window;
            playerSignup.Controls.Add(textBoxEmailP);
            playerSignup.Controls.Add(errorSingupP);
            playerSignup.Controls.Add(buttonCreateP);
            playerSignup.Controls.Add(label22);
            playerSignup.Controls.Add(textBoxPasswordP);
            playerSignup.Controls.Add(textBoxUsernameP);
            playerSignup.Controls.Add(textBoxNameP);
            playerSignup.Controls.Add(label23);
            playerSignup.Controls.Add(label13);
            playerSignup.Controls.Add(label14);
            playerSignup.Controls.Add(label15);
            playerSignup.Location = new Point(928, 72);
            playerSignup.Name = "playerSignup";
            playerSignup.Size = new Size(640, 800);
            playerSignup.TabIndex = 9;
            // 
            // textBoxEmailP
            // 
            textBoxEmailP.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailP.Font = new Font("Segoe UI", 12F);
            textBoxEmailP.Location = new Point(202, 231);
            textBoxEmailP.Name = "textBoxEmailP";
            textBoxEmailP.Size = new Size(404, 39);
            textBoxEmailP.TabIndex = 16;
            textBoxEmailP.TextAlign = HorizontalAlignment.Center;
            // 
            // errorSingupP
            // 
            errorSingupP.AutoSize = true;
            errorSingupP.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorSingupP.ForeColor = Color.Red;
            errorSingupP.Location = new Point(110, 644);
            errorSingupP.Name = "errorSingupP";
            errorSingupP.Size = new Size(427, 33);
            errorSingupP.TabIndex = 8;
            errorSingupP.Text = "User name already Exit, Try another !";
            // 
            // buttonCreateP
            // 
            buttonCreateP.BackColor = SystemColors.WindowText;
            buttonCreateP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateP.ForeColor = SystemColors.Window;
            buttonCreateP.Location = new Point(31, 520);
            buttonCreateP.Name = "buttonCreateP";
            buttonCreateP.Size = new Size(575, 70);
            buttonCreateP.TabIndex = 6;
            buttonCreateP.Text = "Create the Account";
            buttonCreateP.UseVisualStyleBackColor = false;
            buttonCreateP.Click += buttonCreateP_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 16F);
            label22.Location = new Point(31, 235);
            label22.Margin = new Padding(1);
            label22.Name = "label22";
            label22.Size = new Size(90, 36);
            label22.TabIndex = 15;
            label22.Text = "Email";
            // 
            // textBoxPasswordP
            // 
            textBoxPasswordP.BorderStyle = BorderStyle.FixedSingle;
            textBoxPasswordP.Font = new Font("Segoe UI", 12F);
            textBoxPasswordP.Location = new Point(202, 397);
            textBoxPasswordP.Name = "textBoxPasswordP";
            textBoxPasswordP.Size = new Size(404, 39);
            textBoxPasswordP.TabIndex = 4;
            textBoxPasswordP.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUsernameP
            // 
            textBoxUsernameP.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsernameP.Font = new Font("Segoe UI", 12F);
            textBoxUsernameP.Location = new Point(202, 320);
            textBoxUsernameP.Name = "textBoxUsernameP";
            textBoxUsernameP.Size = new Size(404, 39);
            textBoxUsernameP.TabIndex = 3;
            textBoxUsernameP.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNameP
            // 
            textBoxNameP.BorderStyle = BorderStyle.FixedSingle;
            textBoxNameP.Font = new Font("Segoe UI", 12F);
            textBoxNameP.Location = new Point(202, 146);
            textBoxNameP.Name = "textBoxNameP";
            textBoxNameP.Size = new Size(404, 39);
            textBoxNameP.TabIndex = 14;
            textBoxNameP.TextAlign = HorizontalAlignment.Center;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Times New Roman", 16F);
            label23.Location = new Point(31, 150);
            label23.Margin = new Padding(1);
            label23.Name = "label23";
            label23.Size = new Size(89, 36);
            label23.TabIndex = 13;
            label23.Text = "Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 16F);
            label13.Location = new Point(31, 398);
            label13.Margin = new Padding(1);
            label13.Name = "label13";
            label13.Size = new Size(135, 36);
            label13.TabIndex = 2;
            label13.Text = "Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 16F);
            label14.Location = new Point(31, 323);
            label14.Margin = new Padding(1);
            label14.Name = "label14";
            label14.Size = new Size(155, 36);
            label14.TabIndex = 1;
            label14.Text = "User Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(210, 17);
            label15.Name = "label15";
            label15.Size = new Size(214, 36);
            label15.TabIndex = 0;
            label15.Text = "Player SignUP";
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = SystemColors.Window;
            panelPlayer.Controls.Add(wrongUsernamePasswordPlayer);
            panelPlayer.Controls.Add(label8);
            panelPlayer.Controls.Add(buttonSignUpPlayer);
            panelPlayer.Controls.Add(buttonLoginPlayer);
            panelPlayer.Controls.Add(playerPasswordInput);
            panelPlayer.Controls.Add(playerUsernameInput);
            panelPlayer.Controls.Add(label9);
            panelPlayer.Controls.Add(label10);
            panelPlayer.Controls.Add(label11);
            panelPlayer.Location = new Point(928, 69);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(640, 800);
            panelPlayer.TabIndex = 5;
            // 
            // wrongUsernamePasswordPlayer
            // 
            wrongUsernamePasswordPlayer.AutoSize = true;
            wrongUsernamePasswordPlayer.Font = new Font("Times New Roman", 14F);
            wrongUsernamePasswordPlayer.ForeColor = Color.Red;
            wrongUsernamePasswordPlayer.Location = new Point(137, 644);
            wrongUsernamePasswordPlayer.Name = "wrongUsernamePasswordPlayer";
            wrongUsernamePasswordPlayer.Size = new Size(364, 33);
            wrongUsernamePasswordPlayer.TabIndex = 8;
            wrongUsernamePasswordPlayer.Text = "Wrong user name or password !";
            wrongUsernamePasswordPlayer.TextChanged += wrongUsernamePasswordPlayer_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14F);
            label8.Location = new Point(184, 501);
            label8.Name = "label8";
            label8.Size = new Size(306, 33);
            label8.TabIndex = 7;
            label8.Text = "Do not have an Account  ?";
            // 
            // buttonSignUpPlayer
            // 
            buttonSignUpPlayer.BackColor = SystemColors.WindowText;
            buttonSignUpPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSignUpPlayer.ForeColor = SystemColors.Window;
            buttonSignUpPlayer.Location = new Point(31, 551);
            buttonSignUpPlayer.Name = "buttonSignUpPlayer";
            buttonSignUpPlayer.Size = new Size(575, 70);
            buttonSignUpPlayer.TabIndex = 6;
            buttonSignUpPlayer.Text = "Sign Up";
            buttonSignUpPlayer.UseVisualStyleBackColor = false;
            buttonSignUpPlayer.Click += buttonSignUpPlayer_Click;
            // 
            // buttonLoginPlayer
            // 
            buttonLoginPlayer.BackColor = SystemColors.WindowText;
            buttonLoginPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonLoginPlayer.ForeColor = SystemColors.Window;
            buttonLoginPlayer.Location = new Point(31, 384);
            buttonLoginPlayer.Name = "buttonLoginPlayer";
            buttonLoginPlayer.Size = new Size(575, 70);
            buttonLoginPlayer.TabIndex = 5;
            buttonLoginPlayer.Text = "Login";
            buttonLoginPlayer.UseVisualStyleBackColor = false;
            buttonLoginPlayer.Click += buttonLoginPlayer_Click;
            // 
            // playerPasswordInput
            // 
            playerPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            playerPasswordInput.Font = new Font("Segoe UI", 12F);
            playerPasswordInput.Location = new Point(202, 235);
            playerPasswordInput.Name = "playerPasswordInput";
            playerPasswordInput.Size = new Size(404, 39);
            playerPasswordInput.TabIndex = 4;
            playerPasswordInput.TextAlign = HorizontalAlignment.Center;
            // 
            // playerUsernameInput
            // 
            playerUsernameInput.BorderStyle = BorderStyle.FixedSingle;
            playerUsernameInput.Font = new Font("Segoe UI", 12F);
            playerUsernameInput.Location = new Point(202, 151);
            playerUsernameInput.Name = "playerUsernameInput";
            playerUsernameInput.Size = new Size(404, 39);
            playerUsernameInput.TabIndex = 3;
            playerUsernameInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16F);
            label9.Location = new Point(31, 235);
            label9.Margin = new Padding(1);
            label9.Name = "label9";
            label9.Size = new Size(135, 36);
            label9.TabIndex = 2;
            label9.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 16F);
            label10.Location = new Point(27, 151);
            label10.Margin = new Padding(1);
            label10.Name = "label10";
            label10.Size = new Size(155, 36);
            label10.TabIndex = 1;
            label10.Text = "User Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(228, 17);
            label11.Name = "label11";
            label11.Size = new Size(190, 36);
            label11.TabIndex = 0;
            label11.Text = "Player Login";
            // 
            // masterSignup
            // 
            masterSignup.BackColor = SystemColors.Window;
            masterSignup.Controls.Add(textBoxEmail);
            masterSignup.Controls.Add(label21);
            masterSignup.Controls.Add(textBoxName);
            masterSignup.Controls.Add(label12);
            masterSignup.Controls.Add(errorSignupM);
            masterSignup.Controls.Add(buttonCreateM);
            masterSignup.Controls.Add(textBoxPassword);
            masterSignup.Controls.Add(textBoxUsername);
            masterSignup.Controls.Add(label18);
            masterSignup.Controls.Add(label19);
            masterSignup.Controls.Add(label20);
            masterSignup.Location = new Point(928, 72);
            masterSignup.Name = "masterSignup";
            masterSignup.Size = new Size(640, 800);
            masterSignup.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(201, 232);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(404, 39);
            textBoxEmail.TabIndex = 12;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 16F);
            label21.Location = new Point(30, 235);
            label21.Margin = new Padding(1);
            label21.Name = "label21";
            label21.Size = new Size(90, 36);
            label21.TabIndex = 11;
            label21.Text = "Email";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(201, 147);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(404, 39);
            textBoxName.TabIndex = 10;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 16F);
            label12.Location = new Point(30, 150);
            label12.Margin = new Padding(1);
            label12.Name = "label12";
            label12.Size = new Size(89, 36);
            label12.TabIndex = 9;
            label12.Text = "Name";
            // 
            // errorSignupM
            // 
            errorSignupM.AutoSize = true;
            errorSignupM.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorSignupM.ForeColor = Color.Red;
            errorSignupM.Location = new Point(96, 644);
            errorSignupM.Name = "errorSignupM";
            errorSignupM.Size = new Size(427, 33);
            errorSignupM.TabIndex = 8;
            errorSignupM.Text = "User name already Exit, Try another !";
            // 
            // buttonCreateM
            // 
            buttonCreateM.BackColor = SystemColors.WindowText;
            buttonCreateM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreateM.ForeColor = SystemColors.Window;
            buttonCreateM.Location = new Point(30, 520);
            buttonCreateM.Name = "buttonCreateM";
            buttonCreateM.Size = new Size(575, 70);
            buttonCreateM.TabIndex = 6;
            buttonCreateM.Text = "Create the Account";
            buttonCreateM.UseVisualStyleBackColor = false;
            buttonCreateM.Click += buttonCreateM_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.Location = new Point(201, 398);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(404, 39);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Segoe UI", 12F);
            textBoxUsername.Location = new Point(201, 322);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(404, 39);
            textBoxUsername.TabIndex = 3;
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 16F);
            label18.Location = new Point(30, 401);
            label18.Margin = new Padding(1);
            label18.Name = "label18";
            label18.Size = new Size(135, 36);
            label18.TabIndex = 2;
            label18.Text = "Password";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 16F);
            label19.Location = new Point(30, 323);
            label19.Margin = new Padding(1);
            label19.Name = "label19";
            label19.Size = new Size(155, 36);
            label19.TabIndex = 1;
            label19.Text = "User Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(190, 17);
            label20.Name = "label20";
            label20.Size = new Size(224, 36);
            label20.TabIndex = 0;
            label20.Text = "Master SignUP";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowText;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(userSlecter);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 1000);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Window;
            label17.Location = new Point(54, 320);
            label17.Name = "label17";
            label17.Size = new Size(412, 109);
            label17.TabIndex = 13;
            label17.Text = "Together";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Window;
            label16.Location = new Point(54, 238);
            label16.Name = "label16";
            label16.Size = new Size(582, 63);
            label16.TabIndex = 12;
            label16.Text = "Lets Change the World";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(54, 81);
            label7.Name = "label7";
            label7.Size = new Size(383, 63);
            label7.TabIndex = 11;
            label7.Text = "Welcome Back";
            label7.Click += label7_Click;
            // 
            // sf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1600, 1000);
            Controls.Add(panelPlayer);
            Controls.Add(masterSignup);
            Controls.Add(playerSignup);
            Controls.Add(panel1);
            Controls.Add(panelMaster);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelMaster.ResumeLayout(false);
            panelMaster.PerformLayout();
            playerSignup.ResumeLayout(false);
            playerSignup.PerformLayout();
            panelPlayer.ResumeLayout(false);
            panelPlayer.PerformLayout();
            masterSignup.ResumeLayout(false);
            masterSignup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label2;
        private ComboBox userSlecter;
        private Button button1;
        private Panel panelMaster;
        private Label label3;
        private Label label4;
        private TextBox masterUsernameInput;
        private Label label5;
        private Button buttonLogingMaster;
        private TextBox masterPasswordInput;
        private Label label6;
        private Button buttonSignUpMaster;
        private Label wrongUsernamePasswordMaster;
        private Panel panelPlayer;
        private Label wrongUsernamePasswordPlayer;
        private Label label8;
        private Button buttonSignUpPlayer;
        private Button buttonLoginPlayer;
        private TextBox playerPasswordInput;
        private TextBox playerUsernameInput;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel playerSignup;
        private Label errorSingupP;
        private Button buttonCreateP;
        private TextBox textBoxPasswordP;
        private TextBox textBoxUsernameP;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel masterSignup;
        private TextBox textBoxName;
        private Label label12;
        private Label errorSignupM;
        private Button buttonCreateM;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBoxEmail;
        private Label label21;
        private TextBox textBoxEmailP;
        private Label label22;
        private TextBox textBoxNameP;
        private Label label23;
        private Panel panel1;
        private Label label17;
        private Label label16;
        private Label label7;
    }
}
