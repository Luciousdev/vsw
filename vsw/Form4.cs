using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsw
{
    public partial class Form4 : Form
    {
        public string bearerToken;

        public Form4(string bearerToken)
        {
            InitializeComponent();
            this.bearerToken = bearerToken;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
            MessageBox.Show("You are being logged out.");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new getusers(bearerToken).Show();
            this.Hide();
        }

        private void createuserlinklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form3(bearerToken).Show();
            this.Hide();
        }
    }
}
