
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;

namespace JSON_KPL
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

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

        public class UserData
        {
            public string name { get; set; } = string.Empty;
            public string id { get; set; } = string.Empty;
            public string username { get; set; } = string.Empty;
            public string email { get; set; } = string.Empty;

            public UserData(string nama, string id, string username, string email)
            {
                this.name = nama;
                this.id = id;
                this.username = username;
                this.email = email;
            }
        }

        public static async Task WriteJsonAsync()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            string response = await client.GetStringAsync(url);
            File.WriteAllText("users.json", response);
            var result = JsonConvert.DeserializeObject<List<UserData>>(response);
        }

        public void SimpanFile()
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Form1.WriteJsonAsync();
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText("users.json"));
        }

        private async void Cari_Click(object sender, EventArgs e)
        {
            var users = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText("users.json"));
            string cari = textBox1.Text;

            var hasil = users.Where(u => u.id.Contains(cari, StringComparison.OrdinalIgnoreCase));
            label1.Text = string.Join("\n", hasil.Select(u => $"{u.id} - {u.name}"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<UserData>>(File.ReadAllText("users.json"));
        }
    }
}
