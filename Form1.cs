using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.White;
                panel8.Visible = false;

            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    return;
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel9.Visible = false;

            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Display a messagebox indicating that the registration was successful.
            MessageBox.Show("Login Succesfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (textBox1.Text == "Enter username")
            {
                panel8.Visible = true;
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "Password")
            {
                panel9.Visible = true;
                textBox2.Focus();
                return;
            }

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Display a messagebox indicating that the registration was successful.
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ;

            if (textBox3.Text == "Enter Username")
            {
                pnlUsername.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
            if (textBox4.Text == "Enter Contact")
            {
                pnlContact.Visible = true;
                textBox4.Focus();
                textBox4.SelectAll();
                return;
            }
            if (textBox5.Text == "Enter Password")
            {
                pnlPassword.Visible = true;
                textBox5.Focus();
                textBox5.SelectAll();
                return;
            }
            if (textBox6.Text == "Confirm Password")
            {
                pnlCPassword.Visible = true;
                textBox6.Focus();
                textBox6.SelectAll();
                return;
            }
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlUsername.Visible = pnlContact.Visible = pnlPassword.Visible = pnlCPassword.Visible = false;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.White;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.White;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(30, 30, 30);
            button4.ForeColor = Color.Lime;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
            button4.BackColor = Color.Green;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;
            pnlsignup.Visible = false;
            pnlLogo.Dock = DockStyle.Left;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            pnlsignup.Visible = true;
            pnlLogo.Dock = DockStyle.Right;

            pnlsignup.Dock = DockStyle.Fill;

 
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Hide Form1
            this.Hide();

        }
    }
}