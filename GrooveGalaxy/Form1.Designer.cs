namespace GrooveGalaxy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            Video = new Button();
            Audio = new Button();
            Playlist = new Button();
            UrlLink = new TextBox();
            label3 = new Label();
            Run = new Button();
            NomeDaPasta = new Label();
            ReadNameFolder = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(225, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MinimumSize = new Size(499, 99);
            label1.Name = "label1";
            label1.Size = new Size(499, 99);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(716, 578);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.MinimumSize = new Size(201, 39);
            label2.Name = "label2";
            label2.Size = new Size(201, 39);
            label2.TabIndex = 10;
            // 
            // Video
            // 
            Video.Anchor = AnchorStyles.None;
            Video.BackColor = Color.DarkViolet;
            Video.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Video.Location = new Point(121, 286);
            Video.Margin = new Padding(2, 3, 2, 3);
            Video.Name = "Video";
            Video.Size = new Size(183, 22);
            Video.TabIndex = 1;
            Video.Text = "Video";
            Video.UseVisualStyleBackColor = false;
            Video.Click += Video_Click_1;
            // 
            // Audio
            // 
            Audio.Anchor = AnchorStyles.None;
            Audio.BackColor = Color.DarkViolet;
            Audio.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Audio.Location = new Point(383, 286);
            Audio.Margin = new Padding(2, 3, 2, 3);
            Audio.Name = "Audio";
            Audio.Size = new Size(183, 22);
            Audio.TabIndex = 2;
            Audio.Text = "Audio";
            Audio.UseVisualStyleBackColor = false;
            Audio.Click += Audio_Click;
            // 
            // Playlist
            // 
            Playlist.Anchor = AnchorStyles.None;
            Playlist.BackColor = Color.DarkViolet;
            Playlist.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Playlist.Location = new Point(646, 286);
            Playlist.Margin = new Padding(2, 3, 2, 3);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(183, 22);
            Playlist.TabIndex = 3;
            Playlist.Text = "Playlist";
            Playlist.UseVisualStyleBackColor = false;
            Playlist.Click += Playlist_Click;
            // 
            // UrlLink
            // 
            UrlLink.Anchor = AnchorStyles.None;
            UrlLink.BackColor = Color.DarkViolet;
            UrlLink.BorderStyle = BorderStyle.None;
            UrlLink.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UrlLink.ForeColor = Color.FromArgb(64, 0, 64);
            UrlLink.Location = new Point(352, 410);
            UrlLink.Margin = new Padding(2, 3, 2, 3);
            UrlLink.Name = "UrlLink";
            UrlLink.Size = new Size(288, 14);
            UrlLink.TabIndex = 4;
            UrlLink.TextChanged += UrlLink_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 410);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 7;
            label3.Text = "Cole a url aqui:";
            label3.Click += label3_Click;
            // 
            // Run
            // 
            Run.Anchor = AnchorStyles.None;
            Run.BackColor = Color.DarkViolet;
            Run.Location = new Point(430, 525);
            Run.Margin = new Padding(2, 3, 2, 3);
            Run.Name = "Run";
            Run.Size = new Size(75, 22);
            Run.TabIndex = 6;
            Run.Text = "Run";
            Run.UseVisualStyleBackColor = false;
            Run.Click += button1_Click_1;
            // 
            // NomeDaPasta
            // 
            NomeDaPasta.Anchor = AnchorStyles.None;
            NomeDaPasta.AutoSize = true;
            NomeDaPasta.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            NomeDaPasta.Location = new Point(221, 454);
            NomeDaPasta.Margin = new Padding(2, 0, 2, 0);
            NomeDaPasta.Name = "NomeDaPasta";
            NomeDaPasta.Size = new Size(126, 16);
            NomeDaPasta.TabIndex = 8;
            NomeDaPasta.Text = "Nome da playlist:";
            NomeDaPasta.Visible = false;
            // 
            // ReadNameFolder
            // 
            ReadNameFolder.Anchor = AnchorStyles.None;
            ReadNameFolder.BackColor = Color.DarkViolet;
            ReadNameFolder.BorderStyle = BorderStyle.None;
            ReadNameFolder.Enabled = false;
            ReadNameFolder.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadNameFolder.ForeColor = Color.FromArgb(64, 0, 64);
            ReadNameFolder.Location = new Point(352, 456);
            ReadNameFolder.Margin = new Padding(2, 3, 2, 3);
            ReadNameFolder.Name = "ReadNameFolder";
            ReadNameFolder.Size = new Size(288, 14);
            ReadNameFolder.TabIndex = 5;
            ReadNameFolder.Visible = false;
            ReadNameFolder.TextChanged += ReadNameFolder_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 525);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(933, 628);
            Controls.Add(label4);
            Controls.Add(ReadNameFolder);
            Controls.Add(NomeDaPasta);
            Controls.Add(Run);
            Controls.Add(label3);
            Controls.Add(UrlLink);
            Controls.Add(Playlist);
            Controls.Add(Audio);
            Controls.Add(Video);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Bernard MT Condensed", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            ShowIcon = false;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Video;
        private Button Audio;
        private Button Playlist;
        private TextBox UrlLink;
        private Label label3;
        private Button Run;
        private Label NomeDaPasta;
        private TextBox ReadNameFolder;
        private Label label4;
    }
}
