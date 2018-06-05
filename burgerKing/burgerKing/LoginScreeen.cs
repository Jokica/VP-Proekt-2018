using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burgerKing
{
    public partial class LoginScreeen : Form
    {  public Users AllAccounts;
        public LoginScreeen()
        {
            InitializeComponent();
            AllAccounts = new Users();
            AllAccounts.addUser(new User("Jovan", "Jovan.Joksi@hotmail.com",20,"ajvar"));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            if (txtPassSignUp.Text == txtPassSingUp2.Text)
            {
                AllAccounts.addUser(new User(txtUserSignUp.Text,
                    txtEmailSignUp.Text,
                    Convert.ToInt32(txtAgeSignUp.Text),
                    txtPassSignUp.Text));
                pnlSignIn.Visible = false;
                button1.Visible = true;
            }
            else
            {
                lblWarning.Text = "Wrong password motherfucker!";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (AllAccounts.shouldLogin(txtUser.Text, txtPassword.Text))
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();

            }
            else
            {
                MessageBox.Show("Password or UserName is incorrect");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            pnlSignIn.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
