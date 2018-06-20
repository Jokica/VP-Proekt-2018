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
    public partial class OrderMenu : Form
    {
        public OrderMenu()
        {
            InitializeComponent();
            panel2.Visible = false;
            pnlDrink.Visible = false;
            button3.Text = "Back";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Hide();
            this.pnlDrink.Show();
        }

        private void OrderMenu_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlDrink.Visible = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
