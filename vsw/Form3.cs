using System;
using System.Net.Http;
using System.Windows.Forms;

namespace vsw
{
    public partial class Form3 : Form
    {
        private string bearerToken;

        public Form3(string bearerToken)
        {
            InitializeComponent();
            this.bearerToken = bearerToken;
            MessageBox.Show(bearerToken);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account created!");

            try
            {
                var client = new HttpClient();
                var parameters = $"name={name.Text}&email={email.Text}&password={password.Text}&password_confirmation={password_confirmation.Text}";
                MessageBox.Show(parameters);
                var request = new HttpRequestMessage(HttpMethod.Post, "https://swordfish.luciousdev.nl/api/signup?" + parameters);
                request.Headers.Add("Authorization", "Bearer " + bearerToken);
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Request failed: " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new getusers(bearerToken).Show();
            this.Hide();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var parameters = $"name={name.Text}&email={email.Text}&password={password.Text}&password_confirmation={password_confirmation.Text}";
                var request = new HttpRequestMessage(HttpMethod.Post, "https://swordfish.luciousdev.nl/api/signup?" + parameters);
                request.Headers.Add("Authorization", "Bearer " + bearerToken);
                var response = await client.SendAsync(request);
                MessageBox.Show("Account has been created!");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Request failed: " + ex.Message);
            }
        }
    }
}
