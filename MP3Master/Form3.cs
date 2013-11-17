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

namespace MP3Master
{
    public partial class Form3 : Form
    {
        //private iTunesAppClass _itunes; // player handler
        private MP3File _mp3;
        //private List<IITPlaylist> _playlists; // playlist list
        private Form2 _parentForm;

        public Form3()
        {
            InitializeComponent();
            //_itunes = new iTunesAppClass();
            _mp3 = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*foreach (IITPlaylist play in _itunes.LibrarySource.Playlists)
            {
                playlistsListBox.Items.Add(play.Name);
            }

            _playlists = new List<IITPlaylist>();*/
        }

        public void LoadForm2Components(MP3File file, Form2 form)
        {
            _mp3 = file;
            _parentForm = form;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //_parentForm.setPlaylist(_playlists);
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the playlists you wish to add the song to by clicking on those listed you desire.", "Playlist Selection Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void playlistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*_playlists.Clear();
            foreach (var item in playlistsListBox.SelectedItems)
            {
                _playlists.Add(_itunes.LibrarySource.Playlists.get_ItemByName(item.ToString()));
            }*/
        }
    }
}
