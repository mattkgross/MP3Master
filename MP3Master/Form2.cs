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

            if (mp3.GetAlbumArt() != null)
            {
                IPicture pic = mp3.GetAlbumArt();
                MemoryStream ms = new MemoryStream(pic.Data.Data);
                UpdatePic(Image.FromStream(ms));
            }
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
            mp3.SetYear(String.IsNullOrEmpty(yearTextBox.Text) ? 0 : Convert.ToUInt32(yearTextBox.Text));
            mp3.SetTrackNumber(String.IsNullOrEmpty(trackNumberTextBox.Text) ? 0 : Convert.ToUInt32(trackNumberTextBox.Text));
            mp3.SetTrackCount(String.IsNullOrEmpty(trackCountTextBox.Text) ? 0 : Convert.ToUInt32(trackCountTextBox.Text));
            mp3.SetDiscNumber(String.IsNullOrEmpty(albumNumberTextBox.Text) ? 0 : Convert.ToUInt32(albumNumberTextBox.Text));
            mp3.SetDiscCount(String.IsNullOrEmpty(albumCountTextBox.Text) ? 0 : Convert.ToUInt32(albumCountTextBox.Text));
            mp3.SetGenre(new Genre(genreComboBox.SelectedText));

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
                    Picture pic = new Picture(new ByteVector((byte[])new ImageConverter().ConvertTo(Image.FromFile(dialog.FileName), typeof(byte[]))));
                    mp3.SetAlbumArt(pic);
                    UpdatePic(Image.FromFile(dialog.FileName));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Album Art Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
