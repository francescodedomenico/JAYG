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
            comboAudioBox.SelectedIndex = 0;
            UIThread.IsBackground = true;
            UIThread.Start();
        }
        private void audioYTDL()
        {
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            var downloadLink = linkTextBox.Text;
            var ffmpegpath = "--ffmpeg-location /bin/ffmpeg.exe";
            var audioFormat = "";
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
            using (Process sortProcess = new Process())
            {
                sortProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                sortProcess.StartInfo.Arguments = downloadLink + " " + ffmpegpath + " " + audioOption;
                sortProcess.StartInfo.CreateNoWindow = true; 
                sortProcess.StartInfo.UseShellExecute = false;
                sortProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                sortProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                sortProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                sortProcess.Start();

                // Start the asynchronous read
                sortProcess.BeginOutputReadLine();

                sortProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Audio download has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
        }
        private void updateYTDL()
        {
            buffer = "Checking for updates, please wait...\r\n";
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            
            using (Process sortProcess = new Process())
            {
                sortProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                sortProcess.StartInfo.Arguments = "--update";
                sortProcess.StartInfo.CreateNoWindow = true;
                sortProcess.StartInfo.UseShellExecute = false;
                sortProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                sortProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                sortProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                sortProcess.Start();

                // Start the asynchronous read
                sortProcess.BeginOutputReadLine();

                sortProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Update has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
        }
        private void runYTDL()
        {
            past = ShellOutputForm.Text;
            performingAction = "downloading";
            var downloadLink = linkTextBox.Text;
            var ffmpegpath = "--ffmpeg-location /bin/ffmpeg.exe";
            using (Process sortProcess = new Process())
            {
                sortProcess.StartInfo.FileName = @".\bin\youtube-dl.exe";
                sortProcess.StartInfo.Arguments = downloadLink+" "+ffmpegpath;
                sortProcess.StartInfo.CreateNoWindow = true;
                sortProcess.StartInfo.UseShellExecute = false;
                sortProcess.StartInfo.RedirectStandardOutput = true;

                // Set event handler
                sortProcess.OutputDataReceived += new DataReceivedEventHandler(TextBoxHandler);
                sortProcess.ErrorDataReceived += new DataReceivedEventHandler(TextBoxHandler);


                // Start the process.
                sortProcess.Start();

                // Start the asynchronous read
                sortProcess.BeginOutputReadLine();

                sortProcess.WaitForExit();
                performingAction = "none";
            }
            ShellOutputForm.AppendText("Download has ended.\r\n");
            ShellOutputForm.SelectionStart = ShellOutputForm.Text.Length;
            ShellOutputForm.ScrollToCaret();
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
    }
}
