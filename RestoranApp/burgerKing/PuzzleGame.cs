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
    public partial class PuzzleGame : Form
    {
        public PuzzleGame()
        {
            InitializeComponent();
            imgNumber=1;
            button5_Click(null, null);
        }
        int imgNumber;
        Image image;
        PictureBox PictureBox=null;
        private void button5_Click(object sender, EventArgs e)
        {
            setImg();
            if(PictureBox == null)
            {
                PictureBox = new PictureBox();
                PictureBox.Height = groupBox2.Height;
                PictureBox.Width = groupBox2.Width;
                groupBox2.Controls.Add(PictureBox);
            }
            PictureBox.Image = image;
            

        }
        private Bitmap CreateBitMapImage(Image image)
        {
            Bitmap bitmap = new Bitmap(groupBox2.Height, groupBox2.Width);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            graphics.DrawImage(image, new Rectangle(0, 0, groupBox2.Width, groupBox2.Height));
            graphics.Flush();

            return bitmap;
        }
        private void CreateBitMapImage(Image img,Image[] imgs,int index,int numRows
            ,int numCol,int unitX,int unitY)
        {
            imgs[index] = new Bitmap(unitX, unitY);
            Graphics graphics = Graphics.FromImage(imgs[index]);
            graphics.Clear(Color.White);
            graphics.DrawImage(img, new Rectangle(0, 0, unitX, unitY)
                                  , new Rectangle(unitX * (index % numCol), unitY * (index / numCol), unitX, unitY)
                                  ,GraphicsUnit.Pixel);
            graphics.Flush();

        }
        private void shuffle(ref int [] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
        private void setImg()
        {
            if (imgNumber == 1)
            {
                imgNumber++;
                
                image = CreateBitMapImage(burgerKing.Properties.Resources._1);
            }
            else if (imgNumber == 2)
            {
                imgNumber++;
                image = CreateBitMapImage(burgerKing.Properties.Resources._2);
            }
            else if (imgNumber == 3)
            {
                imgNumber++;
                image = CreateBitMapImage(burgerKing.Properties.Resources._3);
            }
            if (imgNumber == 4) imgNumber = 1;
        }
        PictureBox[] pictureBoxes = null;
        Image[] images = null;
        const int LEVEL_1_NUM = 4;
        int currentLvl = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            currentLvl = LEVEL_1_NUM;
            this.lblStatus.Text = "Level 1 started";
            PlayLevel();

        }

        private void PlayLevel()
        {
            if (PictureBox != null)
            {
                groupBox2.Controls.Remove(PictureBox);
                PictureBox.Dispose();
                PictureBox = null;
            }
            if (pictureBoxes == null)
            {
                pictureBoxes = new PictureBox[currentLvl];
                images = new Image[currentLvl];
            }
            int NumRows = (int)Math.Sqrt(currentLvl);
            int NumCols = NumRows;
            int unitX = groupBox2.Width / NumRows;
            int unitY = groupBox2.Height / NumCols;
            int[] indice = new int[currentLvl];
            for (int i = 0; i < currentLvl; i++)
            {
                indice[i] = i;
                if (pictureBoxes[i] == null)
                {
                    pictureBoxes[i] = new MyPictureBox();
                    pictureBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    pictureBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                pictureBoxes[i].Width = unitX;
                pictureBoxes[i].Height = unitY;
                ((MyPictureBox)pictureBoxes[i]).Index = i;

                CreateBitMapImage(image, images, i, NumRows, NumCols, unitX, unitY);

                pictureBoxes[i].Location = new Point(unitX * (i % NumCols), unitY * (i / NumCols));

                if (!groupBox2.Controls.Contains(pictureBoxes[i]))
                {
                    groupBox2.Controls.Add(pictureBoxes[i]);
                }
            }
            shuffle(ref indice);
            for (int i = 0; i < currentLvl; i++)
            {
                pictureBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)pictureBoxes[i]).ImageIndex = i;
            }
        }
        private void OnPuzzleClick(object sender,EventArgs e)
        {
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;

            }
            else if (secendBox == null)
            {
                secendBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secendBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImage(firstBox, secendBox);
                firstBox = null;
                secendBox = null;
            }
            //else
            //{
            //    firstBox = secendBox;
            //    firstBox.BorderStyle = BorderStyle.Fixed3D;
            //    secendBox = (MyPictureBox)sender;
            //    secendBox.BorderStyle = BorderStyle.FixedSingle;
            //    SwitchImage(firstBox, secendBox);
            //}
        }
        MyPictureBox firstBox = null;
        MyPictureBox secendBox = null;

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
            
        }
        private bool isSuccsessful()
        {
            for(int i = 0; i < currentLvl; i++)
            {
                if(((MyPictureBox)pictureBoxes[i]).ImageIndex
                    != ((MyPictureBox)pictureBoxes[i]).Index)
                {
                    return false;
                }
                
            }
            return true;
        }
        private void SwitchImage(MyPictureBox box1,MyPictureBox box2)
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;
            if (isSuccsessful())
            {
                this.lblStatus.Text = "Well Done!";
            }
        }
    }
}
