using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JumbleCoding
{
    public partial class Form1 : Form
    {
        int windowHeight = 768;
        int windowWidth = 1024;
        public Form1()
        {
            InitializeComponent();
            this.Height = windowHeight;
            this.Width = windowWidth;
            this.textBox1.Width = (int)(windowWidth * 0.4);
            this.textBox1.Height = (int)(windowHeight * 0.9);
            this.textBox1.Location = new Point(20,20);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
