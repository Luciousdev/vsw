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

        private async void post_submit_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, $"https://swordfish.luciousdev.nl/api/post/create?title={title.Text}&excerpt={excerpt.Text}&body={body.Text}");
                request.Headers.Add("Authorization", "Bearer " + bearerToken);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync());
                MessageBox.Show("Post has been created!");
            } 
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Something went wrong, please try again later." + ex.Message);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("You are already on this page.");
        }
    }
}
