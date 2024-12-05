using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace QuizManagementSystem
{
    public partial class PlayerForm : Form
    {
        private UserDetails userDetails;

        public PlayerForm(UserDetails userD)
        {
            InitializeComponent();
            userDetails = userD; 
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            panelProfile.Visible = false;
            QuizP.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sf sf = new sf();
            sf.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

