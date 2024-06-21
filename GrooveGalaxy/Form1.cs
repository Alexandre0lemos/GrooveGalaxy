using VideoClass;
using YoutubeExplode;

namespace GrooveGalaxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int select;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Run.BackColor = Color.DarkOrchid;

            var linkInfo = new YoutubeClient();

            try
            {
                var info = await linkInfo.Videos.GetAsync(UrlLink.Text);
                var id = info.Id;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Digite uma url valida!!");
                return;
            }

            var youtube = new YoutubeDownload(UrlLink.Text);

            switch (select)
            {
                case 1:
                    await youtube.BaixarVideoDoYoutube();
                    break;

                case 2:
                    await youtube.BaixarAudioDoYoutube();
                    break;

                case 3:
                    await youtube.BaixarAudiosDePlaylist(ReadNameFolder.Text);
                    break;

                default:
                    break;
            }

            ReadNameFolder.Text = "";

            UrlLink.Text = "";
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            Video.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkViolet;
            Run.BackColor= Color.DarkViolet;
            Playlist.BackColor = Color.DarkOrchid;
            NomeDaPasta.Text = "Nome da playlist: ";
            ReadNameFolder.Size = new System.Drawing.Size(329, 14);
            select = Convert.ToInt32("3");
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            Video.BackColor = Color.DarkViolet;
            Playlist.BackColor = Color.DarkViolet;
            Run.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkOrchid;
            NomeDaPasta.Text = "";
            ReadNameFolder.Size = new System.Drawing.Size(0, 0);
            select = Convert.ToInt32("2");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Video_Click_1(object sender, EventArgs e)
        {
            Playlist.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkViolet;
            Run.BackColor = Color.DarkViolet;
            Video.BackColor = Color.DarkOrchid;
            NomeDaPasta.Text = "";
            ReadNameFolder.Size = new System.Drawing.Size(0, 0);
            select = Convert.ToInt32("1");
        }

        private void UrlLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
