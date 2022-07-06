using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peer4
{
    internal class TabPageExtension : TabPage
    {
        public RichTextBox richTextBox;

        public string path;


        public TabPageExtension(string title)
        {
            richTextBox = new RichTextBox();
            Text = title;
            richTextBox.Dock = DockStyle.Fill;
            Controls.Add(richTextBox);
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            richTextBox.ContextMenuStrip = contextMenuStrip;
            path = "";
        }
    }
}
