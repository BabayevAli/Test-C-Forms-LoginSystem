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
    public partial class Form1 : Form
    {

        public class User
        {
            public string username, email;
            string password;
            public string Password
            {
                get
                {
                    //string a = "";
                    //foreach (var item in password)
                    //{
                    //    a += (char)item ^ 0x0009;
                    //}
                    //return a;
                    return password;
                }
                set
                {
                    //string a = "";
                    //foreach (var item in value)
                    //{
                    //    a += (char)item ^ 0x0009;
                    //}

                    password = value;
                }
            }
            public User(string use, string ema, string pas)
            {
                username = use;
                email = ema;
                Password = pas;
            }
        }
        public class DbUser
        {
            static List<User> users;
            static DbUser()
            {
                users = new List<User>();
            }
            static public void Add(string ema, string use, string pass)
            {
                users.Add(new User(use, ema, pass));
            }
            static public bool Check(string use, string pass)
            {
                foreach (var item in users)
                {
                    if (item.username == use && item.Password == pass)
                    {
                        return true;
                    }
                }
                return false;
            }
            static public User Info(string use, string pass)
            {

                foreach (var item in users)
                {
                    if (item.username == use && item.Password == pass)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        Form3 b;
        public Form1()
        {
            InitializeComponent();
            b = new Form3();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DbUser.Check(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Giris etdiniz!!!");
                User c = DbUser.Info(textBox1.Text, textBox2.Text);
                if (c != null)
                {
                    b.Add(new string[] { c.email, c.username ,c.Password });
                    b.ShowDialog();
                }
            }
        }
    }
}
