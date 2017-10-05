using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace youtube_dl_GUI
{

    public partial class Form1 : Form
    {
        public String buffer = "";
        public String lastbuffer = "";
        public String past = "";
        public String performingAction = "none";
        public static class TextBuffer
        {
            public static String buffer { get; set; }
        }

        private void updateUI()
        {
            while (true)
            {
                if (performingAction.Equals("none"))
                {
                    Thread.Sleep(500);
                    continue;
                }
                if (performingAction.Equals("downloading"))
                {
                    String toAdd = "";
                    toAdd = past + buffer + "\r\n";
                    ShellOutputForm.Text = toAdd;
                    ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
                    ShellOutputForm.ScrollToCaret();
                }
                
                Thread.Sleep(500);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Thread UIThread = new Thread(updateUI);
            comboAudioBox.SelectedIndex = 0; /// We set default choice for audio as MP3
            ///Starting UIThread
            UIThread.IsBackground = true;
            UIThread.Start();
        }
        private void enableControls()
        {
            buttonDownloadAudio.Enabled = true;
            buttonDownloadVideo.Enabled = true;
            buttonUpdate.Enabled = true;
        }
        private void disableControls()
        {
            buttonDownloadAudio.Enabled = false;
            buttonDownloadVideo.Enabled = false;
            buttonUpdate.Enabled = false;
        }
        private void audioYTDL()
        {
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            var downloadLink = linkTextBox.Text;
            var ffmpegpath = "--ffmpeg-location /bin/ffmpeg.exe";
            var audioFormat = "";
            /// Disable controls
            disableControls();

            switch (comboAudioBox.SelectedIndex)
            {
                case 0:
                    audioFormat = "mp3";
                    break;
                case 1:
                    audioFormat = "aac";
                    break;
                case 2:
                    audioFormat = "m4a";
                    break;
                default:
                    audioFormat = "mp3";
                    break;
            }
            var audioOption = "--extract-audio --audio-format " + audioFormat;
            using (Process cmdProcess = new Process())
            {
                cmdProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                cmdProcess.StartInfo.Arguments = downloadLink + " " + ffmpegpath + " " + audioOption;
                cmdProcess.StartInfo.CreateNoWindow = true; 
                cmdProcess.StartInfo.UseShellExecute = false;
                cmdProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                cmdProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                cmdProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                cmdProcess.Start();

                // Start the asynchronous read
                cmdProcess.BeginOutputReadLine();

                cmdProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Audio download has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
            enableControls();
        }
        private void updateYTDL()
        {
            buffer = "Checking for updates, please wait...\r\n";
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            /// Disable controls
            disableControls();

            using (Process cmdProcess = new Process())
            {
                cmdProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                cmdProcess.StartInfo.Arguments = "--update";
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.StartInfo.UseShellExecute = false;
                cmdProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                cmdProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                cmdProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                cmdProcess.Start();

                // Start the asynchronous read
                cmdProcess.BeginOutputReadLine();

                cmdProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Update has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
            enableControls();
        }
        private void runYTDL()
        {
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            var downloadLink = linkTextBox.Text;
            var ffmpegpath = "--ffmpeg-location /bin/ffmpeg.exe";
            /// Disable controls
            disableControls();

            using (Process cmdProcess = new Process())
            {
                cmdProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                cmdProcess.StartInfo.Arguments = downloadLink+" "+ffmpegpath;
                cmdProcess.StartInfo.CreateNoWindow = true;
                cmdProcess.StartInfo.UseShellExecute = false;
                cmdProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                cmdProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                cmdProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                cmdProcess.Start();

                // Start the asynchronous read
                cmdProcess.BeginOutputReadLine();

                cmdProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Download has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
            enableControls();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ///ShellOutputForm.Text = "Checking for updates...\r\n";
            ///Thread updateThread = new Thread(updateYTDL);
            ///updateThread.Start();
            ///updateThread.Join();
            Thread downloadThread = new Thread(runYTDL);
            downloadThread.Start();

        }
        private void TextBoxHandler(object sender, DataReceivedEventArgs e)
        {
            Trace.WriteLine(e.Data);
            this.BeginInvoke(new MethodInvoker(() =>
            {
                buffer = (e.Data ?? string.Empty);
            }));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            Thread updateThread = new Thread(updateYTDL);
            updateThread.Start();
        }

        private void buttonDownloadAudio_Click(object sender, EventArgs e)
        {
            Thread updateThread = new Thread(audioYTDL);
            updateThread.Start();
        }

        private void labelUpdates_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/francescodedomenico/JAYG/releases");
        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/francescodedomenico");
        }

        private void labelAuthor_MouseEnter(object sender, EventArgs e)
        {
            labelAuthor.Font = new Font(labelAuthor.Font.Name, labelAuthor.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelAuthor_MouseLeave(object sender, EventArgs e)
        {
            labelAuthor.Font = new Font(labelAuthor.Font.Name, labelAuthor.Font.SizeInPoints, FontStyle.Regular);
        }

        private void labelUpdates_MouseEnter(object sender, EventArgs e)
        {
            labelUpdates.Font = new Font(labelUpdates.Font.Name, labelUpdates.Font.SizeInPoints, FontStyle.Underline);
        }

        private void labelUpdates_MouseLeave(object sender, EventArgs e)
        {
            labelUpdates.Font = new Font(labelUpdates.Font.Name, labelUpdates.Font.SizeInPoints, FontStyle.Regular);
        }
    }
}
