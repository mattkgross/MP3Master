namespace MP3Master
{
    partial class Main_Form
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
            this.exportDirectoryLabel = new System.Windows.Forms.Label();
            this.exportDirectoryButton = new System.Windows.Forms.Button();
            this.exportDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.exportDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.schemaBox1 = new System.Windows.Forms.ComboBox();
            this.schemaBox2 = new System.Windows.Forms.ComboBox();
            this.schemaBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.sourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.sourceDirectoryButton = new System.Windows.Forms.Button();
            this.sourceDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.submitButton = new System.Windows.Forms.Button();
            this.musicProgressBar = new System.Windows.Forms.ProgressBar();
            this.musicProgressLabel = new System.Windows.Forms.Label();
            this.subdirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.editTagsBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exportDirectoryLabel
            // 
            this.exportDirectoryLabel.AutoSize = true;
            this.exportDirectoryLabel.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportDirectoryLabel.Location = new System.Drawing.Point(13, 13);
            this.exportDirectoryLabel.Name = "exportDirectoryLabel";
            this.exportDirectoryLabel.Size = new System.Drawing.Size(176, 17);
            this.exportDirectoryLabel.TabIndex = 0;
            this.exportDirectoryLabel.Text = "Export Organized Music To...";
            // 
            // exportDirectoryButton
            // 
            this.exportDirectoryButton.Location = new System.Drawing.Point(195, 31);
            this.exportDirectoryButton.Name = "exportDirectoryButton";
            this.exportDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.exportDirectoryButton.TabIndex = 1;
            this.exportDirectoryButton.Text = "Browse...";
            this.exportDirectoryButton.UseVisualStyleBackColor = true;
            this.exportDirectoryButton.Click += new System.EventHandler(this.exportDirectoryButton_Click);
            // 
            // exportDirectoryTextBox
            // 
            this.exportDirectoryTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.exportDirectoryTextBox.Location = new System.Drawing.Point(16, 33);
            this.exportDirectoryTextBox.Name = "exportDirectoryTextBox";
            this.exportDirectoryTextBox.ReadOnly = true;
            this.exportDirectoryTextBox.Size = new System.Drawing.Size(173, 20);
            this.exportDirectoryTextBox.TabIndex = 2;
            this.exportDirectoryTextBox.TextChanged += new System.EventHandler(this.exportDirectoryTextBox_TextChanged);
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaLabel.Location = new System.Drawing.Point(13, 61);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(105, 17);
            this.schemaLabel.TabIndex = 3;
            this.schemaLabel.Text = "Select a Schema:";
            // 
            // schemaBox1
            // 
            this.schemaBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.schemaBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaBox1.FormattingEnabled = true;
            this.schemaBox1.Location = new System.Drawing.Point(16, 81);
            this.schemaBox1.Name = "schemaBox1";
            this.schemaBox1.Size = new System.Drawing.Size(121, 21);
            this.schemaBox1.TabIndex = 4;
            this.schemaBox1.SelectedIndexChanged += new System.EventHandler(this.schemaBox1_SelectedIndexChanged);
            // 
            // schemaBox2
            // 
            this.schemaBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.schemaBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaBox2.FormattingEnabled = true;
            this.schemaBox2.Location = new System.Drawing.Point(162, 81);
            this.schemaBox2.Name = "schemaBox2";
            this.schemaBox2.Size = new System.Drawing.Size(121, 21);
            this.schemaBox2.TabIndex = 5;
            this.schemaBox2.SelectedIndexChanged += new System.EventHandler(this.schemaBox2_SelectedIndexChanged);
            // 
            // schemaBox3
            // 
            this.schemaBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.schemaBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schemaBox3.FormattingEnabled = true;
            this.schemaBox3.Location = new System.Drawing.Point(308, 81);
            this.schemaBox3.Name = "schemaBox3";
            this.schemaBox3.Size = new System.Drawing.Size(121, 21);
            this.schemaBox3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "/";
            // 
            // sourceDirectoryLabel
            // 
            this.sourceDirectoryLabel.AutoSize = true;
            this.sourceDirectoryLabel.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceDirectoryLabel.Location = new System.Drawing.Point(13, 115);
            this.sourceDirectoryLabel.Name = "sourceDirectoryLabel";
            this.sourceDirectoryLabel.Size = new System.Drawing.Size(158, 17);
            this.sourceDirectoryLabel.TabIndex = 9;
            this.sourceDirectoryLabel.Text = "Select a Directory Source:";
            // 
            // sourceDirectoryTextBox
            // 
            this.sourceDirectoryTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sourceDirectoryTextBox.Location = new System.Drawing.Point(16, 136);
            this.sourceDirectoryTextBox.Name = "sourceDirectoryTextBox";
            this.sourceDirectoryTextBox.ReadOnly = true;
            this.sourceDirectoryTextBox.Size = new System.Drawing.Size(173, 20);
            this.sourceDirectoryTextBox.TabIndex = 10;
            this.sourceDirectoryTextBox.TextChanged += new System.EventHandler(this.sourceDirectoryTextBox_TextChanged);
            // 
            // sourceDirectoryButton
            // 
            this.sourceDirectoryButton.Location = new System.Drawing.Point(195, 134);
            this.sourceDirectoryButton.Name = "sourceDirectoryButton";
            this.sourceDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.sourceDirectoryButton.TabIndex = 11;
            this.sourceDirectoryButton.Text = "Browse...";
            this.sourceDirectoryButton.UseVisualStyleBackColor = true;
            this.sourceDirectoryButton.Click += new System.EventHandler(this.sourceDirectoryButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(16, 211);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Organize Music";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // musicProgressBar
            // 
            this.musicProgressBar.Location = new System.Drawing.Point(146, 211);
            this.musicProgressBar.Name = "musicProgressBar";
            this.musicProgressBar.Size = new System.Drawing.Size(283, 23);
            this.musicProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.musicProgressBar.TabIndex = 13;
            this.musicProgressBar.Visible = false;
            // 
            // musicProgressLabel
            // 
            this.musicProgressLabel.AutoSize = true;
            this.musicProgressLabel.Location = new System.Drawing.Point(143, 195);
            this.musicProgressLabel.Name = "musicProgressLabel";
            this.musicProgressLabel.Size = new System.Drawing.Size(51, 13);
            this.musicProgressLabel.TabIndex = 14;
            this.musicProgressLabel.Text = "Progress:";
            this.musicProgressLabel.Visible = false;
            // 
            // subdirectoryCheckBox
            // 
            this.subdirectoryCheckBox.AutoSize = true;
            this.subdirectoryCheckBox.Checked = true;
            this.subdirectoryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.subdirectoryCheckBox.Location = new System.Drawing.Point(292, 138);
            this.subdirectoryCheckBox.Name = "subdirectoryCheckBox";
            this.subdirectoryCheckBox.Size = new System.Drawing.Size(131, 17);
            this.subdirectoryCheckBox.TabIndex = 15;
            this.subdirectoryCheckBox.Text = "Include Subdirectories";
            this.subdirectoryCheckBox.UseVisualStyleBackColor = true;
            this.subdirectoryCheckBox.CheckedChanged += new System.EventHandler(this.subdirectoryCheckBox_CheckedChanged);
            // 
            // editTagsBox
            // 
            this.editTagsBox.AutoSize = true;
            this.editTagsBox.Checked = true;
            this.editTagsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.editTagsBox.Location = new System.Drawing.Point(16, 171);
            this.editTagsBox.Name = "editTagsBox";
            this.editTagsBox.Size = new System.Drawing.Size(221, 17);
            this.editTagsBox.TabIndex = 16;
            this.editTagsBox.Text = "Prompt me to fill in missing data for songs.";
            this.editTagsBox.UseVisualStyleBackColor = true;
            this.editTagsBox.CheckedChanged += new System.EventHandler(this.editTagsBox_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.editTagsBox);
            this.Controls.Add(this.subdirectoryCheckBox);
            this.Controls.Add(this.musicProgressLabel);
            this.Controls.Add(this.musicProgressBar);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sourceDirectoryButton);
            this.Controls.Add(this.sourceDirectoryTextBox);
            this.Controls.Add(this.sourceDirectoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.schemaBox3);
            this.Controls.Add(this.schemaBox2);
            this.Controls.Add(this.schemaBox1);
            this.Controls.Add(this.schemaLabel);
            this.Controls.Add(this.exportDirectoryTextBox);
            this.Controls.Add(this.exportDirectoryButton);
            this.Controls.Add(this.exportDirectoryLabel);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 Master";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exportDirectoryLabel;
        private System.Windows.Forms.Button exportDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog exportDirectoryBrowser;
        private System.Windows.Forms.TextBox exportDirectoryTextBox;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.ComboBox schemaBox1;
        private System.Windows.Forms.ComboBox schemaBox2;
        private System.Windows.Forms.ComboBox schemaBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sourceDirectoryLabel;
        private System.Windows.Forms.TextBox sourceDirectoryTextBox;
        private System.Windows.Forms.Button sourceDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog sourceDirectoryBrowser;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ProgressBar musicProgressBar;
        private System.Windows.Forms.Label musicProgressLabel;
        private System.Windows.Forms.CheckBox subdirectoryCheckBox;
        private System.Windows.Forms.CheckBox editTagsBox;
    }
}

