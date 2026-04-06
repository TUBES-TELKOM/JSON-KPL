using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JSON_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            //string url = "https://jsonplaceholder.typicode.com/users";

            //Console.WriteLine(url);
            // using (HttpClient client = new HttpClient()) {
            //    string json = await client.GetStringAsync(url);
            //    List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            //    dataGridView1.DataSource = users;
            //}

            //using (HttpClient client = new HttpClient()) {
            //    string json = await client.GetStringAsync(url);
            //    List<User> users = JsonSerializer.Deserialize<List<User>>(json);
            //    dataGridView1.DataSource = users;
            //}
        }
    }
}
