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
using TagLib;
using System.IO;

namespace MP3Master
{
    public partial class Form2 : Form
    {
        private MP3File _mp3 = null;
        private Picture _albumArt = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_mp3 == null)
            {
                MessageBox.Show("MP3 file pointer not found.", "MP3 Tag Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            string name = _mp3.GetFile().Name;
            int start, end;
            start = name.LastIndexOf("\\") + 1;
            end = name.LastIndexOf(".") - start;
            this.Text = name.Substring(start, end);


            // Load Pre-existing data into form
            trackNameTextBox.Text = _mp3.GetTrackName();
            artistTextBox.Text = _mp3.GetFirstArtist();
            albumTextBox.Text = _mp3.GetAlbum();
            yearTextBox.Text = _mp3.GetYear() == 0 ? "" : _mp3.GetYear().ToString();
            trackNumberTextBox.Text = _mp3.GetTrackNumber() == 0 ? "" : _mp3.GetTrackNumber().ToString();
            trackCountTextBox.Text = _mp3.GetTrackCount() == 0 ? "" : _mp3.GetTrackCount().ToString();
            albumNumberTextBox.Text = _mp3.GetDiscNumber() == 0 ? "" : _mp3.GetDiscNumber().ToString();
            albumCountTextBox.Text = _mp3.GetDiscCount() == 0 ? "" : _mp3.GetDiscCount().ToString();
            genreComboBox.SelectedText = String.IsNullOrEmpty(_mp3.GetGenre()) ? "" : new Genre(_mp3.GetGenre()).GetGenre();
            genreComboBox.Items.AddRange(DataEnums.genreOptions.Values.ToArray());

            if (_mp3.GetAlbumArt() != null)
            {
                IPicture pic = _mp3.GetAlbumArt();
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                UpdatePic(Image.FromStream(ms));
            }
        }

        public void LoadMP3(MP3File file)
        {
            _mp3 = file;
        }

        private void saveTagsButton_Click(object sender, EventArgs e)
        {
            if (clearOthersCheckBox.Checked)
                _mp3.ClearAllTags();

            // Save Current Data
            _mp3.SetTrackName(trackNameTextBox.Text);
            _mp3.SetArtists(artistTextBox.Text);
            _mp3.SetAlbum(albumTextBox.Text);
            _mp3.SetYear(String.IsNullOrEmpty(yearTextBox.Text) ? 0 : Convert.ToUInt32(yearTextBox.Text));
            _mp3.SetTrackNumber(String.IsNullOrEmpty(trackNumberTextBox.Text) ? 0 : Convert.ToUInt32(trackNumberTextBox.Text));
            _mp3.SetTrackCount(String.IsNullOrEmpty(trackCountTextBox.Text) ? 0 : Convert.ToUInt32(trackCountTextBox.Text));
            _mp3.SetDiscNumber(String.IsNullOrEmpty(albumNumberTextBox.Text) ? 0 : Convert.ToUInt32(albumNumberTextBox.Text));
            _mp3.SetDiscCount(String.IsNullOrEmpty(albumCountTextBox.Text) ? 0 : Convert.ToUInt32(albumCountTextBox.Text));
            _mp3.SetGenre(new Genre(genreComboBox.SelectedItem.ToString()));

            if(_albumArt != null)
                _mp3.SetAlbumArt(_albumArt);

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePic(Image picPath)
        {
            try
            {
                Size size = new Size(albumArtPictureBox.Width, albumArtPictureBox.Height);
                albumArtPictureBox.Image = new Bitmap(picPath, size) as Image;
            }
            catch
            {
                albumArtPictureBox.Image = MP3Master.Properties.Resources.noart;
            }
        }

        private void albumArtButton_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            // 1st attempt
            //dialog.Filter = "JPEG (*.jpeg;*.jpg;*.jpe)|*.jpeg;*.jpg;*.jpe|PNG (*.png)|*.png|All files (*.*)|*.*";
            dialog.Filter = "JPEG (*.jpeg;*.jpg;*.jpe)|*.jpeg;*.jpg;*.jpe";
            dialog.FilterIndex = 3;
            dialog.CheckFileExists = true;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1st attempt
                    //Picture pic = new Picture(dialog.FileName);
                    _albumArt = new Picture(new ByteVector((byte[])new ImageConverter().ConvertTo(Image.FromFile(dialog.FileName), typeof(byte[]))));
                    UpdatePic(Image.FromFile(dialog.FileName));
                }
                catch (Exception ex)
                {
                    _albumArt = null;
                    MessageBox.Show(ex.Message, "Album Art Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clearAlbumArtButton_Click(object sender, EventArgs e)
        {
            _albumArt = null;
            _mp3.DeleteAlbumArt();
            albumArtPictureBox.Image = MP3Master.Properties.Resources.noart;
        }

        private void addPlayistButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.LoadForm2Components(_mp3);
            form3.ShowDialog();
        }
    }
}
