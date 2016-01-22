using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ArmA3_Launcher
{
    public partial class ModDownloadForm : Form
    {
        
        public ModDownloadForm()
        {
            InitializeComponent();
        }

        private void ModDownloadForm_Load(object sender, EventArgs e)
        {
           // ModDownloadForm load
        }

        public void Exile_Download_Click(object sender, EventArgs e)
        {
             // Creates object of the SaveFileDialog Class
            var ExileDialog = new SaveFileDialog();

            // Opens a dialog box when the download button is selected.
            ExileDialog.ShowDialog();

            // Creates a object from the WebClient class
            WebClient webClientExile = new WebClient();

            // Progress bar eventhandler
            webClientExile.DownloadProgressChanged += (s, t) =>
            {
                progressBar1.Value = t.ProgressPercentage;
            };

            webClientExile.DownloadFileCompleted += (s, t) =>
            {
                progressBar1.Visible = true;
                MessageBox.Show("Download Complete", "Notification");
                
            };
            
            // Performs the download of the file from the URL (Uniform resource locator)
            webClientExile.DownloadFileAsync(new Uri("http://acp-cdn.vilayer.com/exile/@Exile-0.9.18.zip"), ExileDialog.FileName);


        }

        public void A3_Epoch_Download_Click(object sender, EventArgs e)
        {
            // Creates object of the SaveFileDialog Class
            var A3Epoch = new SaveFileDialog();

            // Opens dialog when the user selects the download button.
            A3Epoch.ShowDialog();

            // Creates a object from the WebClient class
            WebClient webClientA3_Epoch = new WebClient();

            // Progress bar event handlers.
           webClientA3_Epoch.DownloadProgressChanged += (s, t) =>
            {
                progressBar1.Value = t.ProgressPercentage;
            };

           webClientA3_Epoch.DownloadFileCompleted += (s, t) =>
            {
                progressBar1.Visible = true;
                MessageBox.Show("Download Complete");
            };

            // Performs the download of the file from the URL (Uniform resource locator), the A3Epoch sets the file name (String)
           webClientA3_Epoch.DownloadFileAsync(new Uri("http://rr.whocaresabout.de/epoch/Epoch_Client_0.3.3.1.zip"), A3Epoch.FileName);
        }

   

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // Progres bar object.
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Save file Dialog box
        }

        private void Cancel_Download_Btn0_Click(object sender, EventArgs e)
        {
            
        }

        private void Cancel_Download_Btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
