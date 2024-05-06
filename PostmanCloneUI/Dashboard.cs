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
            try
            {
                systemStatus.Text = "calling:...";
                await Task.Delay(1000);
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
