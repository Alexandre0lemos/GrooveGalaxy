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

        private void Power()
        {
            Run.Visible = true;
            Run.Enabled = true;
            label4.Visible = false;
            select = 0;
            ReadNameFolder.Visible = true;
            UrlLink.Visible = true;
            UrlLink.Text = "";
            ReadNameFolder.Text = "";
        }

        private void PowerOff()
        {
            Run.Visible = false;
            Run.Enabled = false;
        }

        private void Baixando()
        {
            PowerOff();
            label4.Text = "Baixando...";
            label4.Visible = true;
        }

        private void Loading()
        {
            PowerOff();
            label4.Text = "validando";
            label4.Visible = true;
        }

        private void OffNameFolder()
        {
            NomeDaPasta.Visible = false;
            ReadNameFolder.Text = "";
        }

        private void VideoSelect()
        {
            Playlist.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkViolet;
            Run.BackColor = Color.DarkViolet;
            Video.BackColor = Color.DarkOrchid;
            OffNameFolder();
            select = 1;
        }

        private void AudioSelect()
        {
            Video.BackColor = Color.DarkViolet;
            Playlist.BackColor = Color.DarkViolet;
            Run.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkOrchid;
            OffNameFolder();
            select = 2;
        }

        private void PlaylistSelect()
        {
            Video.BackColor = Color.DarkViolet;
            Audio.BackColor = Color.DarkViolet;
            Run.BackColor = Color.DarkViolet;
            Playlist.BackColor = Color.DarkOrchid;
            NomeDaPasta.Visible = true;
            ReadNameFolder.Enabled = true;
            ReadNameFolder.Visible = true;
            select = 3;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            Loading();

            var linkInfo = new YoutubeClient();

            try
            {
                var info = await linkInfo.Videos.GetAsync(UrlLink.Text);
                var id = info.Id;
                Baixando();
            }
            catch (System.Exception)
            {
                label4.Text = "Error";
                MessageBox.Show("Digite uma url valida!!");
                Power();
                return;
            }

            var youtube = new YoutubeDownload(UrlLink.Text);

            ReadNameFolder.Visible = false;

            UrlLink.Visible = false;

            switch (select)
            {
                case 1:
                    await youtube.BaixarVideoDoYoutube();
                    Power();
                    break;

                case 2:
                    await youtube.BaixarAudioDoYoutube();
                    Power();
                    break;

                case 3:
                    await youtube.BaixarAudiosDePlaylist(ReadNameFolder.Text);
                    Power();
                    break;

                default:
                    select = 0;
                    label4.Text = "Error";
                    MessageBox.Show("Escolha uma das opções");
                    Power();
                    break;
            }
        }

        private void Playlist_Click(object sender, EventArgs e)
        {
            PlaylistSelect();
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            AudioSelect();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Video_Click_1(object sender, EventArgs e)
        {
            VideoSelect();
        }

        private void UrlLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ReadNameFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
