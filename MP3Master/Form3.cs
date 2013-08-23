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

        public Form3()
        {
            InitializeComponent();
            _itunes = new iTunesAppClass();
            _mp3 = null;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void LoadForm2Components(MP3File file)
        {
            _mp3 = file;
        }
    }
}
