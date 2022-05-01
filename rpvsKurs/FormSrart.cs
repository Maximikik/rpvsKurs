using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpvsKurs
{
    public partial class FormSrart : Form
    {
        Image car = new Bitmap(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\carRed.png");
        public FormSrart()
        {
            InitializeComponent();
            //PictureBox kontur = new PictureBox();
            //kontur.Image = Image.FromFile(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\kontur.png");
            //kontur.Location = new Point(this.Location.X, this.Location.Y);
            //pictureBox1.Width = this.Width;
            //pictureBox1.Height = this.Height;
            //pictureBox1.Width = this.Width / 4 * 3;
            //kontur.Show();
        }

        private void FormSrart_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Image = Image.FromFile(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\bridge2.png");
        }

        private void button_To_menu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {

        }
    }
}
