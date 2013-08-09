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
            this.SuspendLayout();
            // 
            // saveTagsButton
            // 
            this.saveTagsButton.Location = new System.Drawing.Point(58, 226);
            this.saveTagsButton.Name = "saveTagsButton";
            this.saveTagsButton.Size = new System.Drawing.Size(75, 23);
            this.saveTagsButton.TabIndex = 0;
            this.saveTagsButton.Text = "Save Tags";
            this.saveTagsButton.UseVisualStyleBackColor = true;
            this.saveTagsButton.Click += new System.EventHandler(this.saveTagsButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(150, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveTagsButton);
            this.Name = "Form2";
            this.Text = "Edit MP3 Tags";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveTagsButton;
        private System.Windows.Forms.Button closeButton;
    }
}