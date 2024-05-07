using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using PostmanCloneLiblary;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly ApiAccess apiAccess = new();

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void callApi_Click(object sender, EventArgs e)
        {
            //url = "https://jsonplaceholder.typicode.com/todos/1";//debug

            try
            {
                systemStatus.Text = "calling...";

                resultsWindow.Text = await apiAccess.CallApiAsync(apiText.Text);
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
