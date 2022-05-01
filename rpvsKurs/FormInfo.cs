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
    public partial class FormInfo : Form
    {
        int change_photo = 1;
        public FormInfo()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\fon_info.jpg");
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox_Ya.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button_ToMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox_Ya.SizeMode = PictureBoxSizeMode.StretchImage;

            if (change_photo == 1)
            {
                pictureBox_Ya.Show();
                
                pictureBox_Ya.Image = Image.FromFile(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\ya.jpg");
                change_photo = 0;
            }
            else
            {
                pictureBox_Ya.Hide();
                pictureBox_Ya.Image = null;
                pictureBox_Ya.BackColor = Color.Transparent;
                change_photo = 1;
            }
        }
    }
}
