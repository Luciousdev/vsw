using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Verdieping_software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private class Post
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }


        private async Task<string> MakeApiCall(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }
            }
        }


   
        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";

            try
            {
                string jsonData = await MakeApiCall(apiUrl);
                List<Post> postList = JsonConvert.DeserializeObject<List<Post>>(jsonData); // Deserialize JSON data to a list of Post objects

                // loop through all items from serialized json data
                foreach (Post post in postList)
                {
                    dataGridView1.Rows.Add(post.UserId, post.Id, post.Title, post.Body); // Add all the items from the API to the gridview
                }

                dataGridView1.Refresh(); // Refresh the DataGridView to update the display
                styleGridView(); // Style the gridview
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Handle exceptions if needed
            }
        }


        private void styleGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
