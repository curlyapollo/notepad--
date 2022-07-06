using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peer4
{



    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            if (Properties.Settings.Default.color == "")
            {
                Properties.Settings.Default.color = "white";
                Properties.Settings.Default.interval = "1 минута";
            }
            string title = "Вкладка " + (tabControl1.TabCount + 1).ToString();
            TabPageExtension myTabPage = new TabPageExtension(title);
            richTextBox = myTabPage.richTextBox;
            tabControl1.Controls.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
            choiceInterval.SelectedItem = Properties.Settings.Default.interval;
            NewTabsColorForProperties(Properties.Settings.Default.color);
            NewContextMenuStrip();
        }

        private void openText_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openText = new OpenFileDialog();
                if (openText.ShowDialog() == DialogResult.Cancel)
                    return;
                ((TabPageExtension)tabControl1.SelectedTab).path = openText.FileName;
                ((TabPageExtension)tabControl1.SelectedTab).Text = openText.FileName[(openText.FileName.LastIndexOf('\\') + 1)..];
                string fileText = File.ReadAllText(((TabPageExtension)tabControl1.SelectedTab).path);
                ((TabPageExtension)tabControl1.SelectedTab).richTextBox.Text = fileText;
                MessageBox.Show("Файл открыт");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void saveAs_Click(object? sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveAs = new SaveFileDialog();
                if (saveAs.ShowDialog() == DialogResult.Cancel)
                    return;
                string fileName = saveAs.FileName;
                ((TabPageExtension)tabControl1.SelectedTab).path = fileName;
                ((TabPageExtension)tabControl1.SelectedTab).Text = fileName[(fileName.LastIndexOf('\\') + 1)..];
                ((TabPageExtension)tabControl1.SelectedTab).richTextBox.SaveFile(fileName);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openRTF_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openRTF = new OpenFileDialog();
                openRTF.Filter = "RTF files(*.rtf)|*.rtf|All files(*.*)|*.*";
                if (openRTF.ShowDialog() == DialogResult.Cancel)
                    return;
                ((TabPageExtension)tabControl1.SelectedTab).path = openRTF.FileName;
                ((TabPageExtension)tabControl1.SelectedTab).Text = openRTF.FileName[(openRTF.FileName.LastIndexOf('\\') + 1)..];
                if (!((TabPageExtension)tabControl1.SelectedTab).path.Contains('.')
                    || ((TabPageExtension)tabControl1.SelectedTab).path[((TabPageExtension)tabControl1.SelectedTab).path.LastIndexOf('.')..] != ".rtf")
                {
                    MessageBox.Show("Неверный формат файла.");
                    return;
                }
            ((TabPageExtension)tabControl1.SelectedTab).richTextBox.Rtf = File.ReadAllText(((TabPageExtension)tabControl1.SelectedTab).path);
                MessageBox.Show("Файл открыт");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void save_Click(object? sender, EventArgs e)
        {
            try
            {
                if (((TabPageExtension)tabControl1.SelectedTab).path == "")
                {
                    saveAs_Click(sender, e);
                    return;
                }
                ((TabPageExtension)tabControl1.SelectedTab).richTextBox.SaveFile(((TabPageExtension)tabControl1.SelectedTab).path);
                MessageBox.Show("Файл сохранен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void newText_Click(object sender, EventArgs e)
        {
            string title = "Вкладка " + (tabControl1.TabCount + 1).ToString();
            TabPageExtension myTabPage = new TabPageExtension(title);
            richTextBox = myTabPage.richTextBox;
            tabControl1.Controls.Add(myTabPage);
            tabControl1.SelectedTab = myTabPage;
            NewTabsColor(sender, e);
            NewContextMenuStrip();
        }

        private void NewContextMenuStrip()
        {
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            var contextHighlightAll = new ToolStripMenuItem("Выделить всё");
            contextHighlightAll.Click += highlightAll_Click;
            var contextCopy = new ToolStripMenuItem("Копировать");
            contextCopy.Click += copy_Click;
            var contextCut = new ToolStripMenuItem("Вырезать");
            contextCut.Click += cut_Click;
            var contextPaste = new ToolStripMenuItem("Вставить");
            contextPaste.Click += paste_Click;
            var contextBold = new ToolStripMenuItem("Жирный");
            contextBold.Font = new Font(contextBold.Font, FontStyle.Bold);
            contextBold.Click += bold_Click;
            var contextItalic = new ToolStripMenuItem("Курсив");
            contextItalic.Font = new Font(contextItalic.Font, FontStyle.Italic);
            contextItalic.Click += italic_Click;
            var contextUnderline = new ToolStripMenuItem("Подчёеркнутый");
            contextUnderline.Font = new Font(contextUnderline.Font, FontStyle.Underline);
            contextUnderline.Click += underline_Click;
            var contextStrikeOut = new ToolStripMenuItem("Зачёркнутый");
            contextStrikeOut.Font = new Font(contextStrikeOut.Font, FontStyle.Strikeout);
            contextStrikeOut.Click += strikeOut_Click;
            var contextDeleteFormat = new ToolStripMenuItem("Очистить форматирование");
            contextDeleteFormat.Font = new Font(contextDeleteFormat.Font, FontStyle.Regular);
            contextDeleteFormat.Click += deleteFormat_Click;
            currentPage.richTextBox.ContextMenuStrip.Items.AddRange(new[]{ contextHighlightAll, contextCopy, contextCut, contextPaste,
                contextBold, contextItalic, contextUnderline, contextStrikeOut, contextDeleteFormat });
        }

        
        private void NewTabsColor(object sender, EventArgs e)
        {
            string color = "";
            if (white.Checked)
            {
                color = "white";
                white_Click(sender, e);
            }
            else if (black.Checked)
            {
                color = "black";
                black_Click(sender, e);
            }
            else if (red.Checked)
            {
                color = "red";
                red_Click(sender, e);
            }
            else if (orange.Checked)
            {
                color = "orange";
                orange_Click(sender, e);
            }
            else if (yellow.Checked)
            {
                color = "yellow";
                yellow_Click(sender, e);
            }
            else if (green.Checked)
            {
                color = "green";
                green_Click(sender, e);
            }
            else if (blue.Checked)
            {
                color = "blue";
                blue_Click(sender, e);
            }
            else
            {
                color = "violet";
                violet_Click(sender, e);
            }
            Properties.Settings.Default.color = color;
        }

        private void NewTabsColorForProperties(string color)
        {
            switch (color)
            {
                case "white":
                    white.Checked = true;
                    WhiteForProperties();
                    break;
                case "black":
                    black.Checked = true;
                    BlackForProperties();
                    break;
                case "red":
                    red.Checked = true;
                    RedForProperties();
                    break;
                case "orange":
                    orange.Checked = true;
                    YellowForProperties();
                    break;
                case "yellow":
                    yellow.Checked = true;
                    YellowForProperties();
                    break;
                case "green":
                    green.Checked = true;
                    GreenForProperties();
                    break;
                case "blue":
                    blue.Checked = true;
                    BlueForProperties();
                    break;
                default:
                    violet.Checked = true;
                    VioletForProperties();
                    break;
            }
        }

        private void CheckColor()
        {
            string color = "";
            if (white.Checked)
            {
                color = "white";
            }
            else if (black.Checked)
            {
                color = "black";
            }
            else if (red.Checked)
            {
                color = "red";
            }
            else if (orange.Checked)
            {
                color = "orange";
            }
            else if (yellow.Checked)
            {
                color = "yellow";
            }
            else if (green.Checked)
            {
                color = "green";
            }
            else if (blue.Checked)
            {
                color = "blue";
            }
            else
            {
                color = "violet";
            }
            Properties.Settings.Default.color = color;
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (HaveUnsavedFiles())
            {
                string question = @"В твоих открытых файлах есть несохранённые изменения.
Сохранить изменения?";
                string caption = "Закрытие блокнота";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(this, question, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    var pages = tabControl1.TabPages;
                    var previousTab = tabControl1.SelectedTab;
                    foreach (var page in pages)
                    {
                        tabControl1.SelectedTab = (TabPageExtension)page;
                        save_Click(sender, e);
                    }
                    tabControl1.SelectedTab = previousTab;
                    Properties.Settings.Default.interval = choiceInterval.SelectedItem.ToString();
                    CheckColor();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Форма будет закрыта");
                }
                else if (result == DialogResult.No)
                {
                    Properties.Settings.Default.interval = choiceInterval.SelectedItem.ToString();
                    CheckColor();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Форма будет закрыта");
                }
                else
                {
                    MessageBox.Show("Форма не будет закрыта");
                    e.Cancel = true;
                }
                return;
            }
            Properties.Settings.Default.interval = choiceInterval.SelectedItem.ToString();
            CheckColor();
            Properties.Settings.Default.Save();
            MessageBox.Show("Все файлы сохранены. Форма будет закрыта");
        }

        private bool HaveUnsavedFiles()
        {
            try
            {
                var pages = tabControl1.TabPages;
                foreach (var page in pages)
                {
                    var ourPage = (TabPageExtension)page;
                    if (ourPage.richTextBox.Modified)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void exit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void choiceInterval_Click(object? sender, EventArgs e)
        {
            Timer timer = new Timer();
            if (choiceInterval.SelectedItem == null)
            {
                return;
            }
            switch (choiceInterval.SelectedItem.ToString()?.Split()[0])
            {
                case "1":
                    if (choiceInterval.SelectedItem.ToString()?.Split()[1] == "минута")
                    {
                        timer.Interval = 60 * 1000;
                    }
                    else
                    {
                        timer.Interval = 1000;
                    }
                    break;
                default:
                    timer.Interval = int.Parse(choiceInterval.SelectedItem.ToString().Split()[0]) * 1000;
                    break;
            }
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            try 
            {
                var pages = tabControl1.TabPages;
                var previousTab = tabControl1.SelectedTab;
                foreach (var page in pages)
                {
                    var ourPage = (TabPageExtension)page;
                    tabControl1.SelectedTab = ourPage;
                    if (ourPage.richTextBox.Modified)
                    {
                        save_Click(sender, e);
                    }
                }
                tabControl1.SelectedTab = previousTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void font_Click(object sender, EventArgs e)
        {
            FontDialog fonts = new FontDialog();
            fonts.ShowColor = true;
            if (fonts.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            currentPage.richTextBox.Font = fonts.Font;
            currentPage.richTextBox.ForeColor = fonts.Color;
        }

        private void ChangeBackColor(Color color)
        {
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.BackColor = color;
                foreach (ToolStripMenuItem item in mainItem.DropDownItems)
                {
                    item.BackColor = color;
                }
            }
            menu.BackColor = color;
            foreach (var page in tabControl1.TabPages)
            {
                ((TabPageExtension)page).richTextBox.BackColor = color;
                ((TabPageExtension)page).BackColor = color;
            }
        }

        private void ChangeForeColor(Color color)
        {
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.ForeColor = color;
                foreach (ToolStripMenuItem item in mainItem.DropDownItems)
                {
                    item.ForeColor = color;
                }
            }
            menu.ForeColor = color;
            foreach (var page in tabControl1.TabPages)
            {
                ((TabPageExtension)page).richTextBox.ForeColor = color;
                ((TabPageExtension)page).ForeColor = color;
            }
        }

        private void white_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != white)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.WhiteSmoke);
            ChangeForeColor(Color.Black);
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.ForeColor = Color.Red;
            }
        }

        private void WhiteForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != white)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.WhiteSmoke);
            ChangeForeColor(Color.Black);
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.ForeColor = Color.Red;
            }
        }

        private void black_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != black)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DarkGray);
            ChangeForeColor(Color.White);
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.ForeColor = Color.Red;
            }
        }

        private void BlackForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != black)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DarkGray);
            ChangeForeColor(Color.White);
            foreach (ToolStripMenuItem mainItem in menu.Items)
            {
                mainItem.ForeColor = Color.Red;
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != red)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Firebrick);
            ChangeForeColor(Color.Chartreuse);
        }

        private void RedForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != red)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Firebrick);
            ChangeForeColor(Color.Chartreuse);
        }

        private void orange_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != orange)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DarkOrange);
            ChangeForeColor(Color.Blue);
        }

        private void OrangeForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != orange)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DarkOrange);
            ChangeForeColor(Color.Blue);
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != yellow)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Yellow);
            ChangeForeColor(Color.Purple);
        }

        private void YellowForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != yellow)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Yellow);
            ChangeForeColor(Color.Purple);
        }

        private void green_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != green)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Lime);
            ChangeForeColor(Color.Red);
        }

        private void GreenForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != green)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Lime);
            ChangeForeColor(Color.Red);
        }

        private void BlueForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != blue)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Aqua);
            ChangeForeColor(Color.Chocolate);
        }

        private void blue_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != blue)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.Aqua);
            ChangeForeColor(Color.Chocolate);
        }

        private void violet_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != violet)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DeepPink);
            ChangeForeColor(Color.PaleGreen);
        }

        private void VioletForProperties()
        {
            foreach (ToolStripMenuItem color in colorTheme.DropDownItems)
            {
                if (color != violet)
                {
                    color.Checked = false;
                }
            }
            ChangeBackColor(Color.DeepPink);
            ChangeForeColor(Color.PaleGreen);
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            try
            {
                var pages = tabControl1.TabPages;
                var previousTab = tabControl1.SelectedTab;
                foreach (var page in pages)
                {
                    var ourPage = (TabPageExtension)page;
                    tabControl1.SelectedTab = ourPage;
                    if (ourPage.path == "" || File.ReadAllText(ourPage.path) != ourPage.richTextBox.Text)
                    {
                        save_Click(sender, e);
                    }
                }
                tabControl1.SelectedTab = previousTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void highlightAll_Click(object sender, EventArgs e)
        {
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            currentPage.richTextBox.SelectAll();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            if (currentPage.richTextBox.SelectedText.Length > 0)
            {
                currentPage.richTextBox.Cut();
            }
        }

        private void copy_Click(object sender, EventArgs e)
        {
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            if (currentPage.richTextBox.SelectedText.Length > 0)
            {
                currentPage.richTextBox.Copy();
            }
        }

        private void paste_Click(object sender, EventArgs e)
        {
            var currentPage = (TabPageExtension)tabControl1.SelectedTab;
            currentPage.richTextBox.Paste();
        }

        private void bold_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Bold | richTextBox.SelectionFont.Style);
        }

        private void italic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Italic | richTextBox.SelectionFont.Style);
        }

        private void strikeOut_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Strikeout | richTextBox.SelectionFont.Style);
        }

        private void underline_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Underline | richTextBox.SelectionFont.Style);

        }

        private void deleteFormat_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular & richTextBox.SelectionFont.Style);
        }

        private void newWindow_Click(object sender, EventArgs e)
        {
            var window2 = new Notepad();
            window2.Show();
        }


        private void undo_Click(object sender, EventArgs e)
        {
            ((TabPageExtension)tabControl1.SelectedTab).richTextBox.Undo();
        }

        private void redo_Click(object sender, EventArgs e)
        {
            ((TabPageExtension)tabControl1.SelectedTab).richTextBox.Redo();
        }
    }
}
