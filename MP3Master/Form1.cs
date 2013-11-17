using System.Diagnostics;
using System.Runtime.InteropServices;
using AttributeSystemProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Master
{
    public partial class Main_Form : Form
    {
        private static string _exportDirectory;
        private static string _sourceDirectory;
        private static bool _recurseDirectory;
        private static bool _songData;
        //private static iTunesAppClass _itunes;
        private static Process _itunesProcess;
        //private List<IITPlaylist> _playlist;
        private bool _iTunesExists;

            #region DLL Imports
        // DLL IMPORTS
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion


        #region Event Handlers
        public Main_Form()
        {
            InitializeComponent();
            //_itunes = new iTunesAppClass();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //_playlist = new List<IITPlaylist>();
            _recurseDirectory = subdirectoryCheckBox.Checked;
            _songData = editTagsBox.Checked;
            schemaBox1.Items.AddRange(DataEnums.schemaOptions.Keys.ToArray());
            schemaBox2.Items.AddRange(DataEnums.schemaOptions.Keys.ToArray());
            schemaBox3.Items.AddRange(DataEnums.songOptions.Keys.ToArray());

            // Minimize iTunes popup if any
            Process[] iTunesProcesses = Process.GetProcessesByName("iTunes");
            if (iTunesProcesses.Count() > 0)
            {
                _itunesProcess = iTunesProcesses.First();
                ShowWindow(_itunesProcess.MainWindowHandle, 2);
                _iTunesExists = true;
            }
            else
            {
                _iTunesExists = false;
            }
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_itunesProcess != null)
                _itunesProcess.Kill();
        }
        #endregion

        #region State Change Handlers
        private void Updater()
        {
            _exportDirectory = exportDirectoryTextBox.Text;
            _sourceDirectory = sourceDirectoryTextBox.Text;
        }

        private bool Validater()
        {
            if (String.IsNullOrEmpty(_exportDirectory))
            {
                MessageBox.Show("Please specify a directory to where you would like to export your files.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (schemaBox1.SelectedIndex == -1 || schemaBox2.SelectedIndex == -1 || schemaBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please fully configure your desired organization schema.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (String.IsNullOrEmpty(_sourceDirectory))
            {
                MessageBox.Show("Please specify a directory that contains your music files.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_exportDirectory.Equals(_sourceDirectory))
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

        private void subdirectoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _recurseDirectory = subdirectoryCheckBox.Checked;
        }

        private void editTagsBox_CheckedChanged(object sender, EventArgs e)
        {
            _songData = editTagsBox.Checked;
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

        private List<DirectoryInfo> recurseDirectoryAdd(string root)
        {
            List<DirectoryInfo> dirList = new List<DirectoryInfo>();
            DirectoryInfo dirInfo = new DirectoryInfo(root);

            recurseDirectoryHelper(dirList, dirInfo);

            return dirList;
        }

        private void recurseDirectoryHelper(List<DirectoryInfo> list, DirectoryInfo root)
        {
            if (root.EnumerateDirectories().Count() != 0)
            {
                foreach (var directoryInfo in root.EnumerateDirectories())
                {
                    recurseDirectoryHelper(list, directoryInfo);
                }
            }

            list.Add(root);
        }
        #endregion

        /*public void SendPlaylist(List<IITPlaylist> list)
        {
            _playlist = list;
        }*/

        private void UpdateTags(MP3File file)
        {
            Form2 form2 = new Form2();
            form2.LoadMP3(file);
            form2.LoadParent(this, _iTunesExists);
            form2.ShowDialog();            
        }

        private string StructureName(string name, MP3File mp3)
        {
            name = name.Replace(".mp3", "");
            DataEnums.songName type;
            DataEnums.songOptions.TryGetValue(schemaBox3.SelectedItem as string, out type);

            switch (type)
            {
                case DataEnums.songName.Original_Name:
                    name += ".mp3";
                    break;
                case DataEnums.songName.Track_Title:
                    uint track = mp3.GetTrackNumber();
                    string part1 = (track == 0) ? "" : (track.ToString() + " - ");
                    string part2 = string.IsNullOrEmpty(mp3.GetTrackName()) ? name : mp3.GetTrackName();
                    name = part1 + part2 + ".mp3";
                    break;
                case DataEnums.songName.Song_Title:
                    name = string.IsNullOrEmpty(mp3.GetTrackName()) ? name : mp3.GetTrackName() + ".mp3";
                    break;
                default:
                    MessageBox.Show("Song name format type not found. Defaulting to no change.", "Song Name Format Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    name += ".mp3";
                    break;
            }

            return name;
        }

        private string StructuredMove(FileInfo file)
        {
            DirectoryInfo dir = new DirectoryInfo(_exportDirectory);
            MP3File mp3 = new MP3File(file.FullName);
            
            string schema1 = schemaBox1.Text;
            string schema2 = schemaBox2.Text;
            string schemaName1 = "";
            string schemaName2 = "";

            // Reflect mp3 type
            Type mp3Type = mp3.GetType();
            string temp = "";

            // TODO: If invalid folder character in artist or album, regex and replace with underscore

            // Get the function associated with the 1st schema option
            DataEnums.schemaOptions.TryGetValue(schema1, out temp);
            MethodInfo method1 = mp3Type.GetMethod(temp);
            // Use reflection to call the proper GET method associated with the schema
            // to return the string name of the directory we are looking for
            schemaName1 = (method1.Invoke(mp3, null) as string) == null ? "Unknown" : method1.Invoke(mp3, null) as string;

            // Create 1st schema directory if it doesn't already exist
            if(dir.GetDirectories(schemaName1).Length == 0)
                dir.CreateSubdirectory(schemaName1);

            // Get the function associated with the 2nd schema option
            DataEnums.schemaOptions.TryGetValue(schema2, out temp);
            MethodInfo method2 = mp3Type.GetMethod(temp);
            // Use reflection to call the proper GET method associated with the schema
            // to return the string name of the directory we are looking for
            schemaName2 = (method2.Invoke(mp3, null) as string) == null ? "Unknown" : method2.Invoke(mp3, null) as string;

            // Create 2nd schema directory if it doesn't already exist
            if (!Directory.Exists(dir.FullName + "\\" + schemaName1 + "\\" + schemaName2))
                Directory.CreateDirectory(dir.FullName + "\\" + schemaName1 + "\\" + schemaName2);

            string finalPath = _exportDirectory + "\\" + schemaName1 + "\\" + schemaName2 + "\\" +
                               StructureName(file.Name, mp3);

            File.Move(file.FullName, finalPath);

            return finalPath;
        }

        private void AddToPlaylists(string path)
        {
            FileInfo file = new FileInfo(path);
            MP3File mp3 = new MP3File(path);

            // Check to see if file is already in playlist
            // TODO: Add to playlists. All playlists selected for the song are stored in _playlists.
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!Validater())
                return;

            musicProgressLabel.Visible = true;
            musicProgressBar.Visible = true;

            List<DirectoryInfo> sourceDirectories;
            if (_recurseDirectory)
            {
                sourceDirectories = recurseDirectoryAdd(_sourceDirectory);
            }
            else
            {
                sourceDirectories = new List<DirectoryInfo>() { new DirectoryInfo(_sourceDirectory) };
            }

            foreach (var dir in sourceDirectories)
            {
                foreach (var file in dir.EnumerateFiles())
                {
                    if (!file.Extension.Equals(".mp3"))
                        continue;

                    // Edit tags if elected
                    if (_songData)
                        UpdateTags(new MP3File(file.FullName));

                    // Move file to destination
                    string newPath = StructuredMove(file);

                    // Add file to selected playlists in iTunes
                    AddToPlaylists(newPath);
                }
            }

            MessageBox.Show("All songs successfully organized.");

            this.Close();
        }
    }
}
