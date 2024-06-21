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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(241, 94);
            label1.MinimumSize = new Size(571, 93);
            label1.Name = "label1";
            label1.Size = new Size(571, 93);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(756, 555);
            label2.MinimumSize = new Size(229, 37);
            label2.Name = "label2";
            label2.Size = new Size(229, 37);
            label2.TabIndex = 0;
            // 
            // Video
            // 
            Video.Anchor = AnchorStyles.None;
            Video.BackColor = Color.DarkViolet;
            Video.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Video.Location = new Point(134, 266);
            Video.Name = "Video";
            Video.Size = new Size(209, 21);
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
            Audio.Location = new Point(418, 266);
            Audio.Name = "Audio";
            Audio.Size = new Size(209, 21);
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
            Playlist.Location = new Point(704, 266);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(209, 21);
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
            UrlLink.Location = new Point(411, 362);
            UrlLink.Name = "UrlLink";
            UrlLink.Size = new Size(329, 14);
            UrlLink.TabIndex = 5;
            UrlLink.TextChanged += UrlLink_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 360);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 4;
            label3.Text = "Cole a url aqui:";
            label3.Click += label3_Click;
            // 
            // Run
            // 
            Run.Anchor = AnchorStyles.None;
            Run.BackColor = Color.DarkViolet;
            Run.Location = new Point(485, 475);
            Run.Name = "Run";
            Run.Size = new Size(86, 21);
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
            NomeDaPasta.Location = new Point(282, 408);
            NomeDaPasta.Name = "NomeDaPasta";
            NomeDaPasta.Size = new Size(0, 16);
            NomeDaPasta.TabIndex = 0;
            // 
            // ReadNameFolder
            // 
            ReadNameFolder.Anchor = AnchorStyles.None;
            ReadNameFolder.BackColor = Color.DarkViolet;
            ReadNameFolder.BorderStyle = BorderStyle.None;
            ReadNameFolder.Font = new Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadNameFolder.ForeColor = Color.FromArgb(64, 0, 64);
            ReadNameFolder.Location = new Point(411, 410);
            ReadNameFolder.Name = "ReadNameFolder";
            ReadNameFolder.Size = new Size(0, 14);
            ReadNameFolder.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(997, 586);
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
            Font = new Font("Algerian", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Groove galaxy";
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
    }
}
