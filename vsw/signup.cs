using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsw
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var parameters = $"name={name.Text}&email={email.Text}&password={password.Text}&password_confirmation={password_confirmation.Text}";
                var request = new HttpRequestMessage(HttpMethod.Post, "https://swordfish.luciousdev.nl/api/signup?" + parameters);
                var response = await client.SendAsync(request);
                MessageBox.Show("Account has been created!");
                new Form1().Show(); // redirect to login page
                this.Hide();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Request failed: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
