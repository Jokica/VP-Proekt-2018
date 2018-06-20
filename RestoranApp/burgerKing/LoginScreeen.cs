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
            this.btnSignUp.Enabled = false;
            this.DoubleBuffered = true;
            AllAccounts = new Users();
            AllAccounts.addUser(new User("Jovan", "Jovan.Joksi@hotmail.com",20,"ajvar"));
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
                AllAccounts.addUser(new User(txtUserSignUp.Text,
                    txtEmailSignUp.Text,
                    Convert.ToInt32(txtAgeSignUp.Text),
                    txtPassSignUp.Text));
                pnlSignIn.Visible = false;
                button1.Visible = true;
            this.btnSignUp.Enabled = false;

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
            cleanPal2();
        }
        private void cleanPal2()
        {
            txtUserSignUp.Text = "";
            txtEmailSignUp.Text = "";
            txtAgeSignUp.Text = "";
            txtPassSingUp2.Text = "";
            txtPassSignUp.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUserSignUp_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserSignUp.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserSignUp, "Enter UserName");
            }
            else errorProvider1.SetError(txtUserSignUp, null);
        }

        private void txtEmailSignUp_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmailSignUp.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmailSignUp, "Enter E-mail");
            }
            else errorProvider1.SetError(txtEmailSignUp, null);
        }

        private void txtAgeSignUp_Validating(object sender, CancelEventArgs e)
        {
            if (txtAgeSignUp.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAgeSignUp, "Enter UserName");
            }
            else errorProvider1.SetError(txtAgeSignUp, null);
        }

        private void txtPassSignUp_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassSignUp.Text =="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassSignUp, "Fill password");
            }
            else errorProvider1.SetError(txtPassSignUp, null);
        }

        private void txtPassSingUp2_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassSignUp.Text != txtPassSingUp2.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassSingUp2, "Wrong password");
            }
            else errorProvider1.SetError(txtPassSingUp2, null);

            this.btnSignUp.Enabled = true;
        }
    }
}
