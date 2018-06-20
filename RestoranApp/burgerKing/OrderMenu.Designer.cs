namespace burgerKing
{
    partial class OrderMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlName = new System.Windows.Forms.Label();
            this.pnlDrink = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(832, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(12, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go back !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(131, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 443);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::burgerKing.Properties.Resources.drinks;
            this.pictureBox2.Location = new System.Drawing.Point(119, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 162);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::burgerKing.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(119, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.pnlName);
            this.panel2.Location = new System.Drawing.Point(228, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 428);
            this.panel2.TabIndex = 7;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(31, 41);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "    Beef Empanadas.---------------------------------------------------------- 10." +
                "00 $",
            "",
            "    Handmade pastries filled with savory beef and potatoes.--------------- 07.99$" +
                "",
            "",
            "    Buttermilk Chicken Jibaritos. -----------------------------------------------" +
                " 15.99$",
            "",
            "    Tostones with Chicken.------------------------------------------------------ " +
                "06.30$",
            "",
            "    Spinach Dip & Chips.-------------------------------------------------------- " +
                "03.50$",
            "",
            "    Lobster & Shrimp Quesadilla.------------------------------------------------ " +
                "20.70$",
            "",
            "    Chicken Quesadilla. ---------------------------------------------------------" +
                "- 03.99$",
            "",
            "    Island Hopper Combo. ------------------------------------------------------ 3" +
                "9.99$",
            "",
            "    Coconut Shrimp.--------------------------------------------------------------" +
                " 15.00$"});
            this.listBox1.Location = new System.Drawing.Point(20, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(507, 308);
            this.listBox1.TabIndex = 1;
            // 
            // pnlName
            // 
            this.pnlName.AutoSize = true;
            this.pnlName.Font = new System.Drawing.Font("Sitka Small", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlName.Location = new System.Drawing.Point(214, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(137, 63);
            this.pnlName.TabIndex = 0;
            this.pnlName.Text = "Food";
            // 
            // pnlDrink
            // 
            this.pnlDrink.Controls.Add(this.button3);
            this.pnlDrink.Controls.Add(this.listBox2);
            this.pnlDrink.Controls.Add(this.label1);
            this.pnlDrink.Location = new System.Drawing.Point(213, 39);
            this.pnlDrink.Name = "pnlDrink";
            this.pnlDrink.Size = new System.Drawing.Size(598, 423);
            this.pnlDrink.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "",
            "    Old Fashioned -------------7.99$",
            "    Martinez -------------4.99$",
            "    Martini-------------5.99$",
            "    Manhattan-------------3.99$",
            "    Brooklyn-------------8.99$",
            "    Daiquiri-------------6.99$",
            "    Margarita-------------9.99$",
            "    Sidecar-------------3.99$",
            "    French 75-------------4.99$",
            "    Bloody Mary-------------3.99$",
            "    Irish Coffee-------------2.99$",
            "    Jack Rose-------------7.99$",
            "    Negroni-------------7.99$",
            "    Boulevardier-------------7.99$",
            "    Sazerac-------------7.99$",
            "    Vieux Carré-------------7.99$",
            "    Ramos Gin Fizz-------------7.99$",
            "    Mint Julep-------------7.99$",
            "    Whiskey Sour-------------7.99$",
            "    Mai Tai-------------7.99$",
            "    Planter\'s Punch-------------7.99$",
            "    Pisco Sour-------------7.99$",
            "    Cosmopolitan-------------7.99$",
            "    Tom Collins-------------7.99$",
            "    Last Word-------------7.99$"});
            this.listBox2.Location = new System.Drawing.Point(31, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(518, 308);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink";
            // 
            // OrderMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDrink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderMenu";
            this.Load += new System.EventHandler(this.OrderMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDrink.ResumeLayout(false);
            this.pnlDrink.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label pnlName;
        private System.Windows.Forms.Panel pnlDrink;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
    }
}