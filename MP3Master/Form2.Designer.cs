namespace MP3Master
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveTagsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearOthersCheckBox = new System.Windows.Forms.CheckBox();
            this.trackNameLabel = new System.Windows.Forms.Label();
            this.trackNameTextBox = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.albumLabel = new System.Windows.Forms.Label();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.trackLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackNumberTextBox = new System.Windows.Forms.TextBox();
            this.trackCountTextBox = new System.Windows.Forms.TextBox();
            this.discLabel = new System.Windows.Forms.Label();
            this.albumCountTextBox = new System.Windows.Forms.TextBox();
            this.albumNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.albumArtPictureBox = new System.Windows.Forms.PictureBox();
            this.albumArtButton = new System.Windows.Forms.Button();
            this.clearAlbumArtButton = new System.Windows.Forms.Button();
            this.decibelTrackBar = new System.Windows.Forms.TrackBar();
            this.decibelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decibelTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // saveTagsButton
            // 
            this.saveTagsButton.Location = new System.Drawing.Point(58, 448);
            this.saveTagsButton.Name = "saveTagsButton";
            this.saveTagsButton.Size = new System.Drawing.Size(75, 23);
            this.saveTagsButton.TabIndex = 0;
            this.saveTagsButton.Text = "Save Tags";
            this.saveTagsButton.UseVisualStyleBackColor = true;
            this.saveTagsButton.Click += new System.EventHandler(this.saveTagsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(150, 448);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearOthersCheckBox
            // 
            this.clearOthersCheckBox.AutoSize = true;
            this.clearOthersCheckBox.Checked = true;
            this.clearOthersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearOthersCheckBox.Location = new System.Drawing.Point(16, 425);
            this.clearOthersCheckBox.Name = "clearOthersCheckBox";
            this.clearOthersCheckBox.Size = new System.Drawing.Size(138, 17);
            this.clearOthersCheckBox.TabIndex = 2;
            this.clearOthersCheckBox.Text = "Clear all other tag fields.";
            this.clearOthersCheckBox.UseVisualStyleBackColor = true;
            // 
            // trackNameLabel
            // 
            this.trackNameLabel.AutoSize = true;
            this.trackNameLabel.Location = new System.Drawing.Point(13, 13);
            this.trackNameLabel.Name = "trackNameLabel";
            this.trackNameLabel.Size = new System.Drawing.Size(66, 13);
            this.trackNameLabel.TabIndex = 3;
            this.trackNameLabel.Text = "Track Name";
            // 
            // trackNameTextBox
            // 
            this.trackNameTextBox.Location = new System.Drawing.Point(16, 29);
            this.trackNameTextBox.Name = "trackNameTextBox";
            this.trackNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.trackNameTextBox.TabIndex = 4;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(12, 58);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(30, 13);
            this.artistLabel.TabIndex = 5;
            this.artistLabel.Text = "Artist";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(16, 74);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(256, 20);
            this.artistTextBox.TabIndex = 6;
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(13, 103);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(36, 13);
            this.albumLabel.TabIndex = 7;
            this.albumLabel.Text = "Album";
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(16, 119);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(256, 20);
            this.albumTextBox.TabIndex = 8;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(22, 155);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "Year";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(16, 171);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(41, 20);
            this.yearTextBox.TabIndex = 10;
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Location = new System.Drawing.Point(112, 155);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(45, 13);
            this.trackLabel.TabIndex = 11;
            this.trackLabel.Text = "Track #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "of";
            // 
            // trackNumberTextBox
            // 
            this.trackNumberTextBox.Location = new System.Drawing.Point(99, 171);
            this.trackNumberTextBox.MaxLength = 2;
            this.trackNumberTextBox.Name = "trackNumberTextBox";
            this.trackNumberTextBox.Size = new System.Drawing.Size(21, 20);
            this.trackNumberTextBox.TabIndex = 13;
            // 
            // trackCountTextBox
            // 
            this.trackCountTextBox.Location = new System.Drawing.Point(147, 171);
            this.trackCountTextBox.MaxLength = 2;
            this.trackCountTextBox.Name = "trackCountTextBox";
            this.trackCountTextBox.Size = new System.Drawing.Size(21, 20);
            this.trackCountTextBox.TabIndex = 14;
            // 
            // discLabel
            // 
            this.discLabel.AutoSize = true;
            this.discLabel.Location = new System.Drawing.Point(216, 155);
            this.discLabel.Name = "discLabel";
            this.discLabel.Size = new System.Drawing.Size(46, 13);
            this.discLabel.TabIndex = 15;
            this.discLabel.Text = "Album #";
            // 
            // albumCountTextBox
            // 
            this.albumCountTextBox.Location = new System.Drawing.Point(251, 171);
            this.albumCountTextBox.MaxLength = 2;
            this.albumCountTextBox.Name = "albumCountTextBox";
            this.albumCountTextBox.Size = new System.Drawing.Size(21, 20);
            this.albumCountTextBox.TabIndex = 18;
            // 
            // albumNumberTextBox
            // 
            this.albumNumberTextBox.Location = new System.Drawing.Point(203, 171);
            this.albumNumberTextBox.MaxLength = 2;
            this.albumNumberTextBox.Name = "albumNumberTextBox";
            this.albumNumberTextBox.Size = new System.Drawing.Size(21, 20);
            this.albumNumberTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "of";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(13, 205);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 19;
            this.genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(15, 221);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(121, 21);
            this.genreComboBox.TabIndex = 20;
            // 
            // albumArtPictureBox
            // 
            this.albumArtPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.albumArtPictureBox.ErrorImage = global::MP3Master.Properties.Resources.noart;
            this.albumArtPictureBox.Image = global::MP3Master.Properties.Resources.noart;
            this.albumArtPictureBox.InitialImage = global::MP3Master.Properties.Resources.noart;
            this.albumArtPictureBox.Location = new System.Drawing.Point(157, 245);
            this.albumArtPictureBox.Name = "albumArtPictureBox";
            this.albumArtPictureBox.Size = new System.Drawing.Size(115, 82);
            this.albumArtPictureBox.TabIndex = 21;
            this.albumArtPictureBox.TabStop = false;
            this.albumArtPictureBox.WaitOnLoad = true;
            // 
            // albumArtButton
            // 
            this.albumArtButton.Location = new System.Drawing.Point(15, 259);
            this.albumArtButton.Name = "albumArtButton";
            this.albumArtButton.Size = new System.Drawing.Size(127, 23);
            this.albumArtButton.TabIndex = 22;
            this.albumArtButton.Text = "Browse for Album Art...";
            this.albumArtButton.UseVisualStyleBackColor = true;
            this.albumArtButton.Click += new System.EventHandler(this.albumArtButton_Click);
            // 
            // clearAlbumArtButton
            // 
            this.clearAlbumArtButton.Location = new System.Drawing.Point(15, 288);
            this.clearAlbumArtButton.Name = "clearAlbumArtButton";
            this.clearAlbumArtButton.Size = new System.Drawing.Size(127, 23);
            this.clearAlbumArtButton.TabIndex = 23;
            this.clearAlbumArtButton.Text = "Clear Album Art";
            this.clearAlbumArtButton.UseVisualStyleBackColor = true;
            this.clearAlbumArtButton.Click += new System.EventHandler(this.clearAlbumArtButton_Click);
            // 
            // decibelTrackBar
            // 
            this.decibelTrackBar.Location = new System.Drawing.Point(12, 374);
            this.decibelTrackBar.Name = "decibelTrackBar";
            this.decibelTrackBar.Size = new System.Drawing.Size(260, 45);
            this.decibelTrackBar.TabIndex = 24;
            // 
            // decibelLabel
            // 
            this.decibelLabel.AutoSize = true;
            this.decibelLabel.Location = new System.Drawing.Point(16, 355);
            this.decibelLabel.Name = "decibelLabel";
            this.decibelLabel.Size = new System.Drawing.Size(74, 13);
            this.decibelLabel.TabIndex = 25;
            this.decibelLabel.Text = "Volume Adjust";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 483);
            this.ControlBox = false;
            this.Controls.Add(this.decibelLabel);
            this.Controls.Add(this.decibelTrackBar);
            this.Controls.Add(this.clearAlbumArtButton);
            this.Controls.Add(this.albumArtButton);
            this.Controls.Add(this.albumArtPictureBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.albumCountTextBox);
            this.Controls.Add(this.albumNumberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discLabel);
            this.Controls.Add(this.trackCountTextBox);
            this.Controls.Add(this.trackNumberTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.trackNameTextBox);
            this.Controls.Add(this.trackNameLabel);
            this.Controls.Add(this.clearOthersCheckBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveTagsButton);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.albumArtPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decibelTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveTagsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox clearOthersCheckBox;
        private System.Windows.Forms.Label trackNameLabel;
        private System.Windows.Forms.TextBox trackNameTextBox;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox trackNumberTextBox;
        private System.Windows.Forms.TextBox trackCountTextBox;
        private System.Windows.Forms.Label discLabel;
        private System.Windows.Forms.TextBox albumCountTextBox;
        private System.Windows.Forms.TextBox albumNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.PictureBox albumArtPictureBox;
        private System.Windows.Forms.Button albumArtButton;
        private System.Windows.Forms.Button clearAlbumArtButton;
        private System.Windows.Forms.TrackBar decibelTrackBar;
        private System.Windows.Forms.Label decibelLabel;
    }
}