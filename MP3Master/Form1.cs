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
            schemaBox1.Items.AddRange(DataEnums.schemaOptions);
            schemaBox2.Items.AddRange(DataEnums.schemaOptions);
        }

        #region State Change Handlers
        private void Updater()
        {
            exportDirectory = exportDirectoryTextBox.Text;
            sourceDirectory = sourceDirectoryTextBox.Text;
        }

        private bool Validater()
        {
            if (String.IsNullOrEmpty(exportDirectory))
            {
                MessageBox.Show("Please specify a directory to where you would like to export your files.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (schemaBox1.SelectedIndex == -1 || schemaBox2.SelectedIndex == -1 || schemaBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please fully configure your desired organization schema.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(sourceDirectory))
            {
                MessageBox.Show("Please specify a directory that contains your music files.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (exportDirectory.Equals(sourceDirectory))
            {
                MessageBox.Show("Export and source directory cannot be the same!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region Directory Selectors
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
        #endregion

        #region Hierarchy Schema
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
        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!Validater())
                return;

            musicProgressLabel.Visible = true;
            musicProgressBar.Visible = true;
        }
    }
}
