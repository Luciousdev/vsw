using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace vsw
{
    public partial class Form1 : Form
    {
        // Define a field to store the bearer token
        private string bearerToken;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Get the email and password from the text boxes
            string email = username.Text;
            string inputPassword = password.Text; // Renamed variable to avoid conflict

            // Make sure email and password are not empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            try
            {
                // Make the API call
                using (HttpClient client = new HttpClient())
                {
                    var parameters = new Dictionary<string, string>
                    {
                        { "email", email },
                        { "password", inputPassword } // Using renamed variable here
                    };

                    var encodedContent = new FormUrlEncodedContent(parameters);

                    HttpResponseMessage response = await client.PostAsync("https://swordfish.luciousdev.nl/api/signin", encodedContent);

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string responseContent = await response.Content.ReadAsStringAsync();
                        var json = JObject.Parse(responseContent);

                        // Check if token exists in the response
                        if (json["token"] != null)
                        {
                            // Store the token
                            bearerToken = json["token"].ToString();

                            new getusers(bearerToken).Show();
                            this.Hide();
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to connect to the server.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signup().Show();
            this.Hide();
        }
    }
}
