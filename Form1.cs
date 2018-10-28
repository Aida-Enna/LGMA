using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FubarDev.FtpServer;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Microsoft.Extensions.DependencyInjection;

namespace LGMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                List<string> ipAddrList = new List<string>();
                foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (item.OperationalStatus == OperationalStatus.Up)
                    {
                        foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                            if(ip.Address.ToString() != "127.0.0.1") cmbIPAddresses.Items.Add(ip.Address.ToString());
                            }
                        }
                    }
                }
            if (cmbIPAddresses.Items.Count == 1) cmbIPAddresses.SelectedItem = cmbIPAddresses.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLocationConf.Text = "{" + Environment.NewLine + "        \"title\":\"LGMA\"," + Environment.NewLine + "        \"url\": \"" + "ftp://" + cmbIPAddresses.SelectedItem.ToString() + ":" + txtPort.Text + "/\"" + Environment.NewLine + "}";
            lblConfig.Visible = true;
            txtLocationConf.Visible = true;

            MainAsync();
        }

        private async void MainAsync()
        {
            Task.Run(async () =>
            {
                // Do any async anything you need here without worry
                // Setup dependency injection
                //Stupid thing doesn't work in .NET Standard yet
                //REEEEEEEEEEEEEEEEEE
                var services = new ServiceCollection();

                //// use %TEMP%/TestFtpServer as root folder
                //services.Configure<DotNetFileSystemOptions>(opt => opt
                //    .RootPath = @"G:\My Drive\NSP");

                // Configuration
                var userName = "zerohell@gmail.com";
                var clientSecretsFile = "client_id.json";

                // Loading the credentials
                UserCredential credential;
                using (var secretsSource = new System.IO.FileStream(clientSecretsFile, FileMode.Open))
                {
                    var secrets = GoogleClientSecrets.Load(secretsSource);
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        secrets.Secrets,
                        new[] { DriveService.Scope.DriveFile, DriveService.Scope.Drive },
                        userName,
                        CancellationToken.None);
                }

                // Add FTP server services
                // DotNetFileSystemProvider = Use the .NET file system functionality
                // AnonymousMembershipProvider = allow only anonymous logins
                services.AddFtpServer(builder => builder
                    //.UseDotNetFileSystem() // Use the .NET file system functionality
                    .UseGoogleDrive(credential)
                    .EnableAnonymousAuthentication()); // allow anonymous logins

                // Configure the FTP server
                services.Configure<FtpServerOptions>(opt => opt.ServerAddress = "192.168.1.16");
                services.Configure<FtpServerOptions>(opt => opt.Port = 4321);

                // Build the service provider
                using (var serviceProvider = services.BuildServiceProvider())
                {
                    // Initialize the FTP server
                    var ftpServer = serviceProvider.GetRequiredService<IFtpServer>();

                    // Start the FTP server
                    ftpServer.Start();

                    Console.WriteLine("Press ENTER/RETURN to close the test application.");
                    Console.ReadLine();

                    // Stop the FTP server
                    ftpServer.Stop();
                }
            }).GetAwaiter().GetResult();
        }
        /*TODO
* Configure port/IP
* Detect local IP?
* Input Google Drive Email
* Optionally use custom API file
* Minimize to Taskbar
*/
    }
}
