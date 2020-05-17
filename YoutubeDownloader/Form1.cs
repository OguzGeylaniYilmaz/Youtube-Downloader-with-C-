using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VideoLibrary;
using MediaToolkit;
using System.Net;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        bool status = true;



        private async void btnDownload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog browserDialog = new FolderBrowserDialog() { Description = "Please select the folder you want to save" })
            {
                if(browserDialog.ShowDialog() == DialogResult.OK)
                {
                    getTitle();
                    label4.Text = "Your download has started. Please wait";
                    label4.ForeColor = Color.Blue;

                    var ytb = YouTube.Default;
                    var video = await ytb.GetVideoAsync(txtUrl.Text);
                    File.WriteAllBytes(browserDialog.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());

                    var inputFile = new MediaToolkit.Model.MediaFile { Filename = browserDialog.SelectedPath + @"\" + video.FullName };
                    var outputFile = new MediaToolkit.Model.MediaFile { Filename = $"{browserDialog.SelectedPath + @"\" + video.FullName}.mp3" };

                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputFile);
                        engine.Convert(inputFile,outputFile);
                    }

                    if(status == true)
                    {
                        File.Delete(browserDialog.SelectedPath + @"\" + video.FullName);
                    }

                    else
                    {
                        File.Delete($"{browserDialog.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                        label4.Text = "Your download has finished.";
                    label4.ForeColor = Color.DarkRed;

                }
                else
                {
                    MessageBox.Show("Please select the file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void getTitle()
        {
            WebRequest request = HttpWebRequest.Create(txtUrl.Text);
            WebResponse response;
            response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string data = streamReader.ReadToEnd();
            int start = data.IndexOf("<title>") + 7;
            int finish = data.Substring(start).IndexOf("</title>");
            string text = data.Substring(start, finish);
            label1.Text = (text);

        }

        private void rdMp4_CheckedChanged(object sender, EventArgs e)
        {
            status = false;
        }

        private void rdMp3_CheckedChanged(object sender, EventArgs e)
        {
            status = true;
        }
    }
}
