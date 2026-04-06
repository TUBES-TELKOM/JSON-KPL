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

        public class UserData
        {
            public string nama { get; set; } = string.Empty;
            public string id { get; set; } = string.Empty;
            public string username { get; set; } = string.Empty;
            public string email { get; set; } = string.Empty;

            public UserData(string nama, string id, string username, string email)
            {
                this.nama = nama;
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
        }
    }
}
