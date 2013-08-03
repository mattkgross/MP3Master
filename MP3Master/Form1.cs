using AttributeSystemProvider;
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
        private static string sourceDirectory;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            exportDirectory = exportDirectoryBrowser.RootFolder.ToString();
            schemaBox1.Items.AddRange(DataEnums.schemaOptions);
            schemaBox2.Items.AddRange(DataEnums.schemaOptions);
        }

        private void Updater()
        {
            exportDirectory = exportDirectoryTextBox.Text;
            sourceDirectory = sourceDirectoryTextBox.Text;
        }

        private void exportDirectoryButton_Click(object sender, EventArgs e)
        {
            if (exportDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                exportDirectoryTextBox.Text = exportDirectoryBrowser.SelectedPath;
                Updater();
            }
        }

        // Shouldn't occur anymore. Disabled texBox field.
        private void exportDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            Updater();
        }

        private void schemaBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schemaBox1.SelectedIndex == schemaBox2.SelectedIndex)
            {
                schemaBox2.SelectedIndex = -1;
            }
        }

        private void schemaBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (schemaBox2.SelectedIndex == schemaBox1.SelectedIndex)
            {
                schemaBox1.SelectedIndex = -1;
            }
        }

        private void sourceDirectoryButton_Click(object sender, EventArgs e)
        {
            if (sourceDirectoryBrowser.ShowDialog() == DialogResult.OK)
            {
                sourceDirectoryTextBox.Text = sourceDirectoryBrowser.SelectedPath;
                Updater();
            }
        }

        // Shouldn't occur anymore. Disabled texBox field.
        private void sourceDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            Updater();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
