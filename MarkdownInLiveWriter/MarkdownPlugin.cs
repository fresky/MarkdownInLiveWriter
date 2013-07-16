using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace MarkdownInLiveWriter
{
    [InsertableContentSource("Insert Markdown", SidebarText = "Insert Markdown"), 
    WriterPlugin("90153F7E-D94E-4a70-819C-912CBF7E589F", "Insert Markdown", ImagePath = "markdown.ico")]
    public class MarkdownPlugin : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            DialogResult dialogResult;
            using (MarkdownForm markdownForm = new MarkdownForm())
            {
                dialogResult = markdownForm.ShowDialog(dialogOwner);
                if (dialogResult == DialogResult.OK)
                {
                    content = markdownForm.GetHtmlCode();
                }
            }
            return dialogResult;
        }
    }
}
