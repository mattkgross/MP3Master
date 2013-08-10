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

            this.Text += " - " + mp3.GetFile().Name;
        }

        public void LoadMP3(MP3File file)
        {
            mp3 = file;
        }

        private void saveTagsButton_Click(object sender, EventArgs e)
        {
            // Save Current Data

            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
