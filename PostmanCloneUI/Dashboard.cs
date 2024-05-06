using System.IO;
using System.Net.Http;
using System.Net.Http.Json;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var api = apiText.Text;

            //api = "https://pokeapi.co/api/v2/pokemon-species/25/";

            try
            {
                systemStatus.Text = "calling...";
                HttpResponseMessage response = await client.GetAsync(api);
                string responseBody = await response.Content.ReadAsStringAsync();
                resultsWindow.Text = responseBody;
                systemStatus.Text = "Ready";
            }
            catch (Exception ex) 
            {
                resultsLabel.Text = ex.Message;
                systemStatus.Text = "Error";
            }
        }
    }
}
