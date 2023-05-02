using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box_Övning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"C:\Users\yosef.shiervani\Downloads\Here comes the star-yoi.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\yosef.shiervani\Downloads\Here comes the star-yoi.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox6.Image = Image.FromFile(filePath);
        }
    }
}
