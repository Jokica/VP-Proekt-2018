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
       
        public List<Reservations> reservations { get; set; }

        public Form1()
        {
            InitializeComponent();
            pnlSide.Height = btnHome.Height;
            pnlSide.Top = btnHome.Top;
            reservations = new List<Reservations>();
            this.user.Visible = false;
        
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
            this.pnlHomePage.Visible = true;
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
          if(om.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
          
        }

        private void btnAbouth_Click(object sender, EventArgs e)
        {
            pnlSide.Height = btnAbouth.Height;
            pnlSide.Top = btnAbouth.Top;

            pnlAbouth.Visible = true;
            user.Visible = false;
            pnlHomePage.Visible = false;
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreeen ls = new LoginScreeen();
            ls.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstbxRes.Items.Clear();
            lstbxRes.Items.AddRange(reservations.ToArray());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime dateTime = this.dateTimePicker1.Value;
            int people =(int) numericUpDown1.Value;
            string name = this.textBox1.Text;
            bool smko = this.checkBox1.Checked;
            reservations.Add(new Reservations(name, smko, people, dateTime));
            button3_Click(null, null);
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            DrinksPromo drinks = new DrinksPromo();
            drinks.ShowDialog();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            FoodPromo drinks = new FoodPromo();
            drinks.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PuzzleGame puzzle = new PuzzleGame();
            puzzle.ShowDialog();
        }
    }
}
