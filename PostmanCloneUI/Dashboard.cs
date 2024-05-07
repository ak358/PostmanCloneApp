using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using PostmanCloneLiblary;

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
            ApiAccess apiAccess = new ApiAccess();
            var url = apiText.Text;

            //url = "https://pokeapi.co/api/v2/pokemon-species/25/";//debug

            try
            {
                systemStatus.Text = "calling...";

                var result = await apiAccess.CallApi(url);
                resultsWindow.Text = result;

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
