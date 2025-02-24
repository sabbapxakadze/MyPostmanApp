using MyPostmanLibrary;
using static MyPostmanLibrary.Enums;

namespace MyPostmanUI
{
    public partial class Dashboard : Form
    {
        private readonly IApiAccess _api = new ApiAccess();

        public Dashboard()
        {
            InitializeComponent();
            httpVerbSelector.SelectedItem = "GET";
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

            HttpAction action;

            if (Enum.TryParse(httpVerbSelector.SelectedItem!.ToString(), out action) == false)
            {
                systemStatus.Text = "Invalid HTTP verb.";
                return;
            }

            // Get JWT token and checkbox state
            string? jwtToken = useJwtCheckBox.Checked ? jwtTokenText.Text : null;

            try
            {

                resultsText.Text = await _api.CallApiAsync(apiText.Text, bodyText.Text, action, true, jwtToken);
                callData.SelectedTab = resultTab;
                resultTab.Focus();

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error:" + ex.Message;
                systemStatus.Text = "Error";
            }

        }

        private void useJwtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            jwtTokenText.Enabled = useJwtCheckBox.Checked;

        }
    }
}
