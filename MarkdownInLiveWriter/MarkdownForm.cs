using System;
using System.Windows.Forms;
using MarkdownSharp;
using Timer = System.Threading.Timer;

namespace MarkdownInLiveWriter
{
    public partial class MarkdownForm : Form
    {
        private string m_HtmlCode;
        private readonly Timer m_Timer;
        private string m_MarddownText = string.Empty;
        readonly Markdown m_Markdown = new Markdown();

        public MarkdownForm()
        {
            InitializeComponent();
            m_Timer = new Timer(preview, null, 1000, -1);
        }

        private void preview(object state)
        {
            if (!m_MarddownText.Equals(markdownTextBox.Text))
            {
                m_MarddownText = markdownTextBox.Text;

                m_HtmlCode = m_Markdown.Transform(m_MarddownText);
                previewWebBrowser.DocumentText = m_HtmlCode;
                sourceTextBox.Text = m_HtmlCode;
            }
            m_Timer.Change(100, 0);
        }

        public string GetHtmlCode()
        {
            return m_HtmlCode;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            m_Timer.Dispose();
        }
    }
}
