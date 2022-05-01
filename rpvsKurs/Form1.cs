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

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button1.Location = new Point(this.Width /2 - button1.Width /2, this.Height / 2 - 2 * button1.Height- 50);
            button2.Location = new Point(this.Width /2 - button1.Width /2, this.Height / 2 - 50);
            button3.Location = new Point(this.Width /2 - button1.Width /2, this.Height / 2 + 2 * button1.Height - 50);
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxFon.Image = Image.FromFile(@"C:\Users\mrudo\OneDrive\Desktop\рпвскурс\fon.jpg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();

            formInfo.Show();
            this.Hide();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSrart formSrart = new FormSrart();
            formSrart.Show();
            this.Hide();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
