using System;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;
using MarkdownSharp;
using Timer = System.Windows.Forms.Timer;


namespace MarkdownInLiveWriter
{
    public partial class MarkdownForm : Form
    {
        private readonly Timer m_Timer;
        private string m_MarddownText = string.Empty;
        readonly Markdown m_Markdown = new Markdown();

        public MarkdownForm()
        {
            InitializeComponent();
            m_Timer = new Timer();
            m_Timer.Interval = 500;
            m_Timer.Tick += preview;
            m_Timer.Start();
            initLanguage();

            initStyle();
        }

        private void initStyle()
        {
            styleComboBox.Items.Clear();
            styleComboBox.Items.Add("vs");
            styleComboBox.Items.Add("colorful");
            styleComboBox.Items.Add("emacs");
            styleComboBox.Items.Add("vim");
            loadFromConfig(styleComboBox, @"Plugins\CodeInLiveWriterStyle.txt");

            styleComboBox.SelectedIndex = 0;
        }

        private void initLanguage()
        {
            languageComboBox.Items.Clear();
            languageComboBox.Items.Add("c#");
            languageComboBox.Items.Add("c++");
            languageComboBox.Items.Add("java");
            languageComboBox.Items.Add("python");
            languageComboBox.Items.Add("ruby");
            languageComboBox.Items.Add("c");
            languageComboBox.Items.Add("sql");
            languageComboBox.Items.Add("html");
            languageComboBox.Items.Add("xml");
            languageComboBox.Items.Add("bat");
            languageComboBox.Items.Add("bash");
            languageComboBox.Items.Add("powershell");
            languageComboBox.Items.Add("registry");

            loadFromConfig(languageComboBox, @"Plugins\CodeInLiveWriterLanguage.txt");

            languageComboBox.SelectedIndex = 0;
        }

        private void loadFromConfig(ComboBox comboBoxStyle, string config)
        {
            try
            {
                using (StreamReader sr = new StreamReader(config))
                {
                    while (!sr.EndOfStream)
                    {
                        string language = sr.ReadLine().Trim();
                        if (!comboBoxStyle.Items.Contains(language))
                        {
                            comboBoxStyle.Items.Add(language);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void preview(object state, EventArgs eventArgs)
        {
            if (!m_MarddownText.Equals(markdownTextBox.Text))
            {
                m_MarddownText = markdownTextBox.Text;

                previewWebBrowser.DocumentText = m_Markdown.Transform(m_MarddownText);
                sourceTextBox.Text = previewWebBrowser.DocumentText;
            }
        }

        public string GetHtmlCode()
        {
            return sourceTextBox.Text;
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            m_Timer.Stop();
            highlightCode();
            DialogResult = DialogResult.OK;
        }

        private void highlightBtn_Click(object sender, EventArgs e)
        {
            highlightCode();
        }

        private void highlightCode()
        {
            if (highlightCheckbox.Checked)
            {
                foreach (HtmlElement element in previewWebBrowser.Document.GetElementsByTagName("code"))
                {
                    element.OuterHtml = getHtmlStyleCode(
                        languageComboBox
                            .SelectedItem
                            .ToString(),
                        element.InnerText,
                        showLineCheckBox.Checked,
                        styleComboBox
                            .SelectedItem
                            .ToString());
                }
                sourceTextBox.Text = previewWebBrowser.Document.Body.InnerHtml;
            }
        }


        private string getHtmlStyleCode(string language, string code, bool showline, string style)
        {
            try
            {
                HttpWebRequest httpWebRequest = WebRequest.Create("http://hilite.me/api") as HttpWebRequest;
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";

                string parameters = string.Format("lexer={0}&code={1}&{2}&style={3}",
                                                  HttpUtility.UrlEncode(language),
                                                  HttpUtility.UrlEncode(code),
                                                  showline ? "&linenos=1" : "",
                                                  style);

                using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(parameters);
                }
                string result;
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
                return result;
            }
            catch
            {
                return code;
            }
        }
    }
}
