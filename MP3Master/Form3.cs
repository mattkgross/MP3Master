using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttributeSystemProvider;
using iTunesLib;

namespace MP3Master
{
    public partial class Form3 : Form
    {
        private iTunesAppClass _itunes;
        private MP3File _mp3;
        private List<IITPlaylist> _playlists;

        public Form3()
        {
            InitializeComponent();
            _itunes = new iTunesAppClass();
            _mp3 = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (IITPlaylist play in _itunes.LibrarySource.Playlists)
            {
                playlistsListBox.Items.Add(play.Name);
            }
        }

        public void LoadForm2Components(MP3File file)
        {
            _mp3 = file;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // TODO: Figure out how to pass the _playlists back to form 1 for adding
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the playlists you wish to add the song to by holding down CTRL and clicking on those you desire.", "Playlist Selection Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void playlistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _playlists.Clear();
            foreach (var item in playlistsListBox.SelectedItems)
            {
                _playlists.Add(_itunes.LibrarySource.Playlists.get_ItemByName(item.ToString()));
            }
        }
    }
}
