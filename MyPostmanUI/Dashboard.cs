using MyPostmanLibrary;

namespace MyPostmanUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _api = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
        }

        private async void sendButton_click(object sender, EventArgs e)
        {
            systemStatus.Text = "Sending a request...";
            resultsText.Text = "";

            // Validating Url
            if (!_api.isValidUrl(apiText.Text))
            {
                systemStatus.Text = "Invalid URL.";
                return;
            }

            try
            {
                systemStatus.Text = "Sending a request...";


                resultsText.Text = await _api.CallApiAsync(apiText.Text);

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error:" + ex.Message;
                systemStatus.Text = "Error";
            }

        }
    }
}
