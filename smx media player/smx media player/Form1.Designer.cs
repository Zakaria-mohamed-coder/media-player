namespace smx_media_player
{
    partial class panelsidemenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelsidemenu));
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listFile = new System.Windows.Forms.ListBox();
            this.bntplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(3, 0);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(627, 429);
            this.axWindowsMediaPlayer.TabIndex = 0;
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 16;
            this.listFile.Location = new System.Drawing.Point(630, 0);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(242, 404);
            this.listFile.TabIndex = 1;
            this.listFile.SelectedIndexChanged += new System.EventHandler(this.listFile_SelectedIndexChanged);
            this.listFile.SelectedValueChanged += new System.EventHandler(this.listfile_selectedindex);
            // 
            // bntplay
            // 
            this.bntplay.Location = new System.Drawing.Point(768, 413);
            this.bntplay.Name = "bntplay";
            this.bntplay.Size = new System.Drawing.Size(92, 27);
            this.bntplay.TabIndex = 2;
            this.bntplay.Text = "&Open";
            this.bntplay.UseVisualStyleBackColor = true;
            this.bntplay.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // panelsidemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 497);
            this.Controls.Add(this.bntplay);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "panelsidemenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.panelsidemenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Button bntplay;

    }
}

