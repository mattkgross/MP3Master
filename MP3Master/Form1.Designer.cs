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
            this.label1 = new System.Windows.Forms.Label();
            this.exportDirectoryButton = new System.Windows.Forms.Button();
            this.exportDirectoryBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.exportDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Export Organized Music To...";
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
            this.exportDirectoryTextBox.Size = new System.Drawing.Size(173, 20);
            this.exportDirectoryTextBox.TabIndex = 2;
            this.exportDirectoryTextBox.TextChanged += new System.EventHandler(this.exportDirectoryTextBox_TextChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 513);
            this.Controls.Add(this.exportDirectoryTextBox);
            this.Controls.Add(this.exportDirectoryButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "MP3 Master";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exportDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog exportDirectoryBrowser;
        private System.Windows.Forms.TextBox exportDirectoryTextBox;
    }
}

