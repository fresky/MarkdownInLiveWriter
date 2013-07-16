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
            this.SourcePage = new System.Windows.Forms.TabPage();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
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
            // SourcePage
            // 
            this.SourcePage.Controls.Add(this.sourceTextBox);
            this.SourcePage.Location = new System.Drawing.Point(4, 4);
            this.SourcePage.Name = "SourcePage";
            this.SourcePage.Padding = new System.Windows.Forms.Padding(3);
            this.SourcePage.Size = new System.Drawing.Size(461, 540);
            this.SourcePage.TabIndex = 1;
            this.SourcePage.Text = "Source";
            this.SourcePage.UseVisualStyleBackColor = true;
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
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Location = new System.Drawing.Point(3, 3);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sourceTextBox.Size = new System.Drawing.Size(455, 534);
            this.sourceTextBox.TabIndex = 0;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(12, 6);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 2;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // MarkdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.htmlTabControl);
            this.Controls.Add(this.markdownTextBox);
            this.Name = "MarkdownForm";
            this.Text = "MarkdownForm";
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
    }
}