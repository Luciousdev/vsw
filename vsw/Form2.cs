using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace vsw
{
    public partial class getusers : Form
    {
        private string bearerToken;

        public getusers()
        {
            InitializeComponent();
        }

        public getusers(string bearerTokenInput)
        {
            InitializeComponent();
            bearerToken = bearerTokenInput;
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);

                    HttpResponseMessage response = await client.GetAsync("https://swordfish.luciousdev.nl/api/users");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();

                        // Deserialize JSON response to an object containing the users array
                        var responseObject = JsonConvert.DeserializeObject<RootObject>(responseData);

                        // Extract the list of users from the responseObject
                        List<User> users = responseObject.Users;

                        DisplayUsers(users);
                    }
                    else
                    {
                        MessageBox.Show("Failed to fetch user data. Please try again later.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void DisplayUsers(List<User> users)
        {
            // Clear existing data in GUI components
            dataGridView1.Rows.Clear();

            // Add each user to the DataGridView
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(user.Name, user.Email);
            }
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string userEmail = row.Cells["Email"].Value.ToString();

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);

                        HttpResponseMessage response = await client.GetAsync($"https://swordfish.luciousdev.nl/api/post/user?email={userEmail}");

                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            // Assuming responseData contains the posts data in some format
                            MessageBox.Show(responseData, "Posts by " + userEmail, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to fetch posts for the user. Please try again later.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void createuserlinklable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form3(bearerToken).Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Hide();
            MessageBox.Show("You are being logged out.");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form4(bearerToken).Show();
            this.Hide();
        }
    }

    // Define a User class to represent user data
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? EmailVerifiedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int IsAdmin { get; set; }
    }

    public class RootObject
    {
        [JsonProperty("users")]
        public List<User> Users { get; set; }
    }
}
