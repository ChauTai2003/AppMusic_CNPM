﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class Change_password : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
              (
                 int nLeftRect,
                 int nTopRect,
                 int nRightRect,
                 int nBottomRect,
                 int nWidthEllipse,
                 int nHeightEllipse
              );
        public Change_password()
        {
            InitializeComponent();
        }

        private void Change_password_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
        button1.Height, 12, 12));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
        panel1.Height, 12, 12));
        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 24;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 24;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
