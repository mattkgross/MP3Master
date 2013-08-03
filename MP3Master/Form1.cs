using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Master
{
    public partial class Main_Form : Form
    {
        private static string exportDirectory;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            exportDirectory = exportDirectoryBrowser.RootFolder.ToString();
        }

        private void Updater()
        {
            exportDirectory = exportDirectoryTextBox.Text;
        }

        private void exportDirectoryButton_Click(object sender, EventArgs e)
        {
            if (exportDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                exportDirectoryTextBox.Text = exportDirectoryBrowser.SelectedPath;
                Updater();
            }
        }

        private void exportDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            Updater();
        }
    }
}
