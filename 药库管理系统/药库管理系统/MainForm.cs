using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 药库管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.BackColor = System.Drawing.Color.Blue;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.Image = Image.FromFile(@"d:\My Documents\My Pictures\t2.jpg");
            button1.BackColor = Color.FromArgb(243,248,193);
            button1.FlatStyle = FlatStyle.Popup;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.Image = Image.FromFile(@"d:\My Documents\My Pictures\t3.jpg");
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.FromArgb(243, 248, 193);
            button4.FlatStyle = FlatStyle.Popup;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(243, 248, 193);
            button2.FlatStyle = FlatStyle.Popup;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.FromArgb(243, 248, 193);
            button3.FlatStyle = FlatStyle.Popup;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
