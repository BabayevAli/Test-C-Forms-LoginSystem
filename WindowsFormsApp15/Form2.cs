using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.ToLower() == "e-mail" || textBox2.Text == "" || textBox2.Text.ToLower() == "username" || textBox3.Text == "" || textBox3.Text.ToLower() == "password" || textBox4.Text == "" && textBox3.Text == textBox4.Text || textBox3.Text.ToLower() == "password")
            {
                return;
            }
            else
            {
                MessageBox.Show("Qeydiyyat Kecdiniz!!");
                Form1.DbUser.Add(textBox1.Text,textBox2.Text, textBox3.Text);
                
                Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
