namespace MarkdownInLiveWriter
{
    partial class MarkdownForm
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
            this.markdownTextBox = new System.Windows.Forms.TextBox();
            this.htmlTabControl = new System.Windows.Forms.TabControl();
            this.PreviewPage = new System.Windows.Forms.TabPage();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SourcePage = new System.Windows.Forms.TabPage();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.highlightBtn = new System.Windows.Forms.Button();
            this.highlightCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.showLineCheckBox = new System.Windows.Forms.CheckBox();
            this.htmlTabControl.SuspendLayout();
            this.PreviewPage.SuspendLayout();
            this.SourcePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // markdownTextBox
            // 
            this.markdownTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.markdownTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.markdownTextBox.Location = new System.Drawing.Point(12, 35);
            this.markdownTextBox.Multiline = true;
            this.markdownTextBox.Name = "markdownTextBox";
            this.markdownTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.markdownTextBox.Size = new System.Drawing.Size(509, 683);
            this.markdownTextBox.TabIndex = 0;
            // 
            // htmlTabControl
            // 
            this.htmlTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.htmlTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlTabControl.Controls.Add(this.PreviewPage);
            this.htmlTabControl.Controls.Add(this.SourcePage);
            this.htmlTabControl.Location = new System.Drawing.Point(527, 35);
            this.htmlTabControl.Name = "htmlTabControl";
            this.htmlTabControl.SelectedIndex = 0;
            this.htmlTabControl.Size = new System.Drawing.Size(469, 683);
            this.htmlTabControl.TabIndex = 1;
            // 
            // PreviewPage
            // 
            this.PreviewPage.Controls.Add(this.previewWebBrowser);
            this.PreviewPage.Location = new System.Drawing.Point(4, 4);
            this.PreviewPage.Name = "PreviewPage";
            this.PreviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.PreviewPage.Size = new System.Drawing.Size(461, 657);
            this.PreviewPage.TabIndex = 0;
            this.PreviewPage.Text = "Preview";
            this.PreviewPage.UseVisualStyleBackColor = true;
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.Size = new System.Drawing.Size(455, 651);
            this.previewWebBrowser.TabIndex = 0;
            // 
            // SourcePage
            // 
            this.SourcePage.Controls.Add(this.sourceTextBox);
            this.SourcePage.Location = new System.Drawing.Point(4, 4);
            this.SourcePage.Name = "SourcePage";
            this.SourcePage.Padding = new System.Windows.Forms.Padding(3);
            this.SourcePage.Size = new System.Drawing.Size(461, 657);
            this.SourcePage.TabIndex = 1;
            this.SourcePage.Text = "Source";
            this.SourcePage.UseVisualStyleBackColor = true;
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Location = new System.Drawing.Point(3, 3);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceTextBox.Size = new System.Drawing.Size(455, 651);
            this.sourceTextBox.TabIndex = 0;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(12, 5);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // highlightBtn
            // 
            this.highlightBtn.Location = new System.Drawing.Point(914, 6);
            this.highlightBtn.Name = "highlightBtn";
            this.highlightBtn.Size = new System.Drawing.Size(75, 23);
            this.highlightBtn.TabIndex = 3;
            this.highlightBtn.Text = "Highlight";
            this.highlightBtn.UseVisualStyleBackColor = true;
            this.highlightBtn.Click += new System.EventHandler(this.highlightBtn_Click);
            // 
            // highlightCheckbox
            // 
            this.highlightCheckbox.AutoSize = true;
            this.highlightCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highlightCheckbox.Checked = true;
            this.highlightCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlightCheckbox.Location = new System.Drawing.Point(93, 5);
            this.highlightCheckbox.Name = "highlightCheckbox";
            this.highlightCheckbox.Size = new System.Drawing.Size(101, 17);
            this.highlightCheckbox.TabIndex = 4;
            this.highlightCheckbox.Text = "Highlight Code?";
            this.highlightCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Language:";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(264, 5);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(257, 21);
            this.languageComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Style:";
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(567, 7);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(205, 21);
            this.styleComboBox.TabIndex = 8;
            // 
            // showLineCheckBox
            // 
            this.showLineCheckBox.AutoSize = true;
            this.showLineCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showLineCheckBox.Checked = true;
            this.showLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLineCheckBox.Location = new System.Drawing.Point(778, 8);
            this.showLineCheckBox.Name = "showLineCheckBox";
            this.showLineCheckBox.Size = new System.Drawing.Size(116, 17);
            this.showLineCheckBox.TabIndex = 9;
            this.showLineCheckBox.Text = "Show Line Number";
            this.showLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // MarkdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.showLineCheckBox);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highlightCheckbox);
            this.Controls.Add(this.highlightBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.htmlTabControl);
            this.Controls.Add(this.markdownTextBox);
            this.Name = "MarkdownForm";
            this.Text = "Markdown In Windows Live Writer";
            this.htmlTabControl.ResumeLayout(false);
            this.PreviewPage.ResumeLayout(false);
            this.SourcePage.ResumeLayout(false);
            this.SourcePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox markdownTextBox;
        private System.Windows.Forms.TabControl htmlTabControl;
        private System.Windows.Forms.TabPage PreviewPage;
        private System.Windows.Forms.WebBrowser previewWebBrowser;
        private System.Windows.Forms.TabPage SourcePage;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button highlightBtn;
        private System.Windows.Forms.CheckBox highlightCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.CheckBox showLineCheckBox;
    }
}