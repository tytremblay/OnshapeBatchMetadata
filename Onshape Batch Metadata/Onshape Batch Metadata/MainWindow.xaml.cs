using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Onshape.Api;
using Onshape.Api.Client.Model;

namespace Onshape_Batch_Metadata
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private OnshapeClient GetClient()
        {
            String baseUri = Environment.GetEnvironmentVariable(Constants.ONSHAPE_BASE_URI);
            String clientId = Environment.GetEnvironmentVariable(Constants.ONSHAPE_CLIENT_ID);
            String clientSecret = Environment.GetEnvironmentVariable(Constants.ONSHAPE_CLIENT_SECRET);
            String oauthToken = Environment.GetEnvironmentVariable(Constants.ONSHAPE_OAUTH_TOKEN);

            // Read refresh token from registry
            String oauthRefreshToken = Utils.GetRegistry(Constants.REFRESH_TOKEN_KEY_NAME);

            // Authenticate as Onshape Application
            OnshapeOAuth onshapeOAuth = new OnshapeOAuth(baseUri, clientId, clientSecret);
            Console.WriteLine("Opening browser window for Onshape authentication...");
            onshapeOAuth.AuthenticateBlocking();
            oauthToken = onshapeOAuth.AccessToken;
            oauthRefreshToken = onshapeOAuth.RefreshToken;
            Utils.SetRegistry(Constants.REFRESH_TOKEN_KEY_NAME, oauthRefreshToken);

            // Initialize Onshape client
            OnshapeClient client = new OnshapeClient { AccessToken = oauthToken, RefreshToken = oauthRefreshToken, BaseUri = baseUri, ClientId = clientId, ClientSecret = clientSecret };

            /* Refresh token if needed
            if (oauthToken == null)
            {
                Task<string> t = client.GetRefreshedOAuthToken();
                try
                {
                    t.Wait(Constants.TOKEN_REFRESH_TIME_OUT);
                    client.AccessToken = t.Result;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: token refresh failed");
                }
            }*/

            return client;
        }

        private async void GetButton_Click(object sender, RoutedEventArgs e)
        {
            var client = GetClient();

            var doc = await client.GetDocument(DocumentIdTextBox.Text);
            var part = await client.GetPartMetadata(DocumentIdTextBox.Text, "w", WorkspaceIdTextBox.Text, ElementIdTextBox.Text, PartIdTextBox.Text);

            NameTextBox.Text = part.name;
        }

        private async void SetButton_Click(object sender, RoutedEventArgs e)
        {
            var client = GetClient();
            
            var part = await client.GetPartMetadata(DocumentIdTextBox.Text, "w", WorkspaceIdTextBox.Text, ElementIdTextBox.Text, PartIdTextBox.Text);

            part.description = "i changed this via the api!!!!";

            await client.UpdateWorkspacePartMetadata(DocumentIdTextBox.Text, WorkspaceIdTextBox.Text, part);


        }
    }
}
