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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
            lblPromotions.Visible = true;
            user.Visible = false;
            pnlAbouth.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnReservation.Height;
            pnlSide.Top = btnReservation.Top;

            lblPromotions.Visible = false;
            user.Visible = true;
            pnlAbouth.Visible = false;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlSide.Height =btnOrder.Height;
            pnlSide.Top = btnOrder.Top;

            this.Hide();
            OrderMenu om = new OrderMenu();
            om.ShowDialog();
        }

        private void btnAbouth_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnAbouth.Height;
            pnlSide.Top = btnAbouth.Top;

            pnlAbouth.Visible = true;
            user.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreeen ls = new LoginScreeen();
            ls.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
