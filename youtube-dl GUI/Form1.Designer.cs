namespace youtube_dl_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShellOutputForm = new System.Windows.Forms.TextBox();
            this.buttonDownloadVideo = new System.Windows.Forms.Button();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.buttonDownloadAudio = new System.Windows.Forms.Button();
            this.comboAudioBox = new System.Windows.Forms.ComboBox();
            this.labelAudioFormat = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelUpdates = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShellOutputForm
            // 
            this.ShellOutputForm.AccessibleDescription = "ShellOutputForm";
            this.ShellOutputForm.AccessibleName = "ShellOutputForm";
            this.ShellOutputForm.Location = new System.Drawing.Point(12, 116);
            this.ShellOutputForm.Multiline = true;
            this.ShellOutputForm.Name = "ShellOutputForm";
            this.ShellOutputForm.ReadOnly = true;
            this.ShellOutputForm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShellOutputForm.Size = new System.Drawing.Size(361, 91);
            this.ShellOutputForm.TabIndex = 0;
            // 
            // buttonDownloadVideo
            // 
            this.buttonDownloadVideo.Location = new System.Drawing.Point(45, 38);
            this.buttonDownloadVideo.Name = "buttonDownloadVideo";
            this.buttonDownloadVideo.Size = new System.Drawing.Size(158, 33);
            this.buttonDownloadVideo.TabIndex = 1;
            this.buttonDownloadVideo.Text = "Download Video";
            this.buttonDownloadVideo.UseVisualStyleBackColor = true;
            this.buttonDownloadVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(45, 12);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(328, 20);
            this.linkTextBox.TabIndex = 2;
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(4, 15);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(30, 13);
            this.labelLink.TabIndex = 3;
            this.labelLink.Text = "Link:";
            // 
            // buttonDownloadAudio
            // 
            this.buttonDownloadAudio.Location = new System.Drawing.Point(215, 38);
            this.buttonDownloadAudio.Name = "buttonDownloadAudio";
            this.buttonDownloadAudio.Size = new System.Drawing.Size(158, 33);
            this.buttonDownloadAudio.TabIndex = 4;
            this.buttonDownloadAudio.Text = "Download Audio";
            this.buttonDownloadAudio.UseVisualStyleBackColor = true;
            this.buttonDownloadAudio.Click += new System.EventHandler(this.buttonDownloadAudio_Click);
            // 
            // comboAudioBox
            // 
            this.comboAudioBox.FormattingEnabled = true;
            this.comboAudioBox.Items.AddRange(new object[] {
            "MP3",
            "AAC",
            "M4A"});
            this.comboAudioBox.Location = new System.Drawing.Point(299, 84);
            this.comboAudioBox.Name = "comboAudioBox";
            this.comboAudioBox.Size = new System.Drawing.Size(74, 21);
            this.comboAudioBox.TabIndex = 5;
            // 
            // labelAudioFormat
            // 
            this.labelAudioFormat.AutoSize = true;
            this.labelAudioFormat.Location = new System.Drawing.Point(224, 87);
            this.labelAudioFormat.Name = "labelAudioFormat";
            this.labelAudioFormat.Size = new System.Drawing.Size(69, 13);
            this.labelAudioFormat.TabIndex = 6;
            this.labelAudioFormat.Text = "Audio format:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(45, 77);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(158, 33);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Check for updates";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(293, 211);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 13);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "version 1.0.0a3";
            // 
            // labelUpdates
            // 
            this.labelUpdates.AutoSize = true;
            this.labelUpdates.Location = new System.Drawing.Point(193, 211);
            this.labelUpdates.Name = "labelUpdates";
            this.labelUpdates.Size = new System.Drawing.Size(94, 13);
            this.labelUpdates.TabIndex = 9;
            this.labelUpdates.Text = "Check for updates";
            this.labelUpdates.Click += new System.EventHandler(this.labelUpdates_Click);
            this.labelUpdates.MouseEnter += new System.EventHandler(this.labelUpdates_MouseEnter);
            this.labelUpdates.MouseLeave += new System.EventHandler(this.labelUpdates_MouseLeave);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(12, 211);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 10;
            this.labelAuthor.Text = "Author";
            this.labelAuthor.Click += new System.EventHandler(this.labelAuthor_Click);
            this.labelAuthor.MouseEnter += new System.EventHandler(this.labelAuthor_MouseEnter);
            this.labelAuthor.MouseLeave += new System.EventHandler(this.labelAuthor_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(386, 228);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelUpdates);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelAudioFormat);
            this.Controls.Add(this.comboAudioBox);
            this.Controls.Add(this.buttonDownloadAudio);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.buttonDownloadVideo);
            this.Controls.Add(this.ShellOutputForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JAYG - Just Another Youtube-dl GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShellOutputForm;
        private System.Windows.Forms.Button buttonDownloadVideo;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Button buttonDownloadAudio;
        private System.Windows.Forms.ComboBox comboAudioBox;
        private System.Windows.Forms.Label labelAudioFormat;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelUpdates;
        private System.Windows.Forms.Label labelAuthor;
    }
}

