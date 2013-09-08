using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace 药库管理系统
{
    public partial class pass : Form
    {
        public pass()
        {
            InitializeComponent();
        }

        private void pass_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.Psw.Text.Trim());    //Psw为输入密码的文本框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            this.textBox3.Text = BitConverter.ToString(output).Replace("-", "");  //textbox3为输出加密文本的文本框
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
