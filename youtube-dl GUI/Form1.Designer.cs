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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDownloadAudio = new System.Windows.Forms.Button();
            this.comboAudioBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShellOutputForm
            // 
            this.ShellOutputForm.AccessibleDescription = "ShellOutputForm";
            this.ShellOutputForm.AccessibleName = "ShellOutputForm";
            this.ShellOutputForm.Location = new System.Drawing.Point(12, 146);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Audio format:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(386, 249);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAudioBox);
            this.Controls.Add(this.buttonDownloadAudio);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDownloadAudio;
        private System.Windows.Forms.ComboBox comboAudioBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

