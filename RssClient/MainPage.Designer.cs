namespace RssClient
{
    partial class MainPage
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
            this.enterUrlLabel = new System.Windows.Forms.Label();
            this.enterUrlTextBox = new System.Windows.Forms.TextBox();
            this.getRssButton = new System.Windows.Forms.Button();
            this.rssDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // enterUrlLabel
            // 
            this.enterUrlLabel.AutoSize = true;
            this.enterUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.enterUrlLabel.Location = new System.Drawing.Point(40, 37);
            this.enterUrlLabel.Name = "enterUrlLabel";
            this.enterUrlLabel.Size = new System.Drawing.Size(253, 24);
            this.enterUrlLabel.TabIndex = 0;
            this.enterUrlLabel.Text = "Введите URL RSS ресурса:";
            // 
            // enterUrlTextBox
            // 
            this.enterUrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterUrlTextBox.Location = new System.Drawing.Point(44, 78);
            this.enterUrlTextBox.Name = "enterUrlTextBox";
            this.enterUrlTextBox.Size = new System.Drawing.Size(423, 26);
            this.enterUrlTextBox.TabIndex = 0;
            // 
            // getRssButton
            // 
            this.getRssButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.getRssButton.Location = new System.Drawing.Point(44, 123);
            this.getRssButton.Name = "getRssButton";
            this.getRssButton.Size = new System.Drawing.Size(109, 35);
            this.getRssButton.TabIndex = 1;
            this.getRssButton.Text = "Получить";
            this.getRssButton.Click += new System.EventHandler(this.OnGetRssButtonClick);
            // 
            // rssDataRichTextBox
            // 
            this.rssDataRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rssDataRichTextBox.Location = new System.Drawing.Point(44, 195);
            this.rssDataRichTextBox.Name = "rssDataRichTextBox";
            this.rssDataRichTextBox.ReadOnly = true;
            this.rssDataRichTextBox.Size = new System.Drawing.Size(870, 400);
            this.rssDataRichTextBox.TabIndex = 0;
            this.rssDataRichTextBox.Text = "";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(742, 168);
            this.FilterComboBox.MaxDropDownItems = 3;
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(172, 28);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.OnFilterComboBoxSelect);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.enterUrlTextBox);
            this.Controls.Add(this.enterUrlLabel);
            this.Controls.Add(this.getRssButton);
            this.Name = "MainPage";
            this.Text = "RSS клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterUrlLabel;
        private System.Windows.Forms.TextBox enterUrlTextBox;
        private System.Windows.Forms.Button getRssButton;
        private System.Windows.Forms.RichTextBox rssDataRichTextBox;
        private System.Windows.Forms.ComboBox FilterComboBox;
    }
}