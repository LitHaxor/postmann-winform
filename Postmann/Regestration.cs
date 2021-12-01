using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postmann
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
             LoginForm f2 = new LoginForm() ;
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Fill The Field");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Fill The Field");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider3.SetError(this.textBox3, "Fill The Field");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Focus();
                errorProvider4.SetError(this.textBox4, "Fill The Field");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                textBox6.Focus();
                errorProvider5.SetError(this.textBox6, "Fill The Field");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f2 = new LoginForm();
            f2.Show();
        }
    }
}
