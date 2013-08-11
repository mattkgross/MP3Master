using AttributeSystemProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Master
{
    public partial class Form2 : Form
    {
        private MP3File mp3 = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (mp3 == null)
            {
                MessageBox.Show("MP3 file pointer not found.", "MP3 Tag Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            string name = mp3.GetFile().Name;
            int start, end;
            start = name.LastIndexOf("\\") + 1;
            end = name.LastIndexOf(".") - start;
            this.Text = name.Substring(start, end);


            // Load Pre-existing data into form
            trackNameTextBox.Text = mp3.GetTrackName();
            artistTextBox.Text = mp3.GetFirstArtist();
            albumTextBox.Text = mp3.GetAlbum();
            yearTextBox.Text = mp3.GetYear() == 0 ? "" : mp3.GetYear().ToString();
            trackNumberTextBox.Text = mp3.GetTrackNumber() == 0 ? "" : mp3.GetTrackNumber().ToString();
            trackCountTextBox.Text = mp3.GetTrackCount() == 0 ? "" : mp3.GetTrackCount().ToString();
            albumNumberTextBox.Text = mp3.GetDiscNumber() == 0 ? "" : mp3.GetDiscNumber().ToString();
            albumCountTextBox.Text = mp3.GetDiscCount() == 0 ? "" : mp3.GetDiscCount().ToString();
            genreComboBox.SelectedText = String.IsNullOrEmpty(mp3.GetGenre()) ? "" : new Genre(mp3.GetGenre()).GetGenre();
            genreComboBox.Items.AddRange(DataEnums.genreOptions.Values.ToArray());
        }

        public void LoadMP3(MP3File file)
        {
            mp3 = file;
        }

        private void saveTagsButton_Click(object sender, EventArgs e)
        {
            if (clearOthersCheckBox.Checked)
                mp3.ClearAllTags();

            // Save Current Data
            mp3.SetTrackName(trackNameTextBox.Text);
            mp3.SetArtists(artistTextBox.Text);
            mp3.SetAlbum(albumTextBox.Text);
            mp3.SetYear(Convert.ToUInt32(yearTextBox.Text));
            mp3.SetTrackNumber(Convert.ToUInt32(trackNumberTextBox.Text));
            mp3.SetTrackCount(Convert.ToUInt32(trackCountTextBox.Text));
            mp3.SetDiscNumber(Convert.ToUInt32(albumNumberTextBox.Text));
            mp3.SetDiscCount(Convert.ToUInt32(albumCountTextBox.Text));
            mp3.SetGenre(new Genre(genreComboBox.SelectedText));

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
