namespace peer4
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newTab = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.openText = new System.Windows.Forms.ToolStripMenuItem();
            this.openRTF = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.highlightAll = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСВыделеннымТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСВыделеннымТекстомToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bold = new System.Windows.Forms.ToolStripMenuItem();
            this.italic = new System.Windows.Forms.ToolStripMenuItem();
            this.underline = new System.Windows.Forms.ToolStripMenuItem();
            this.strikeOut = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.choiceInterval = new System.Windows.Forms.ToolStripComboBox();
            this.colorTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.white = new System.Windows.Forms.ToolStripMenuItem();
            this.black = new System.Windows.Forms.ToolStripMenuItem();
            this.red = new System.Windows.Forms.ToolStripMenuItem();
            this.orange = new System.Windows.Forms.ToolStripMenuItem();
            this.yellow = new System.Windows.Forms.ToolStripMenuItem();
            this.green = new System.Windows.Forms.ToolStripMenuItem();
            this.blue = new System.Windows.Forms.ToolStripMenuItem();
            this.violet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.format,
            this.settings});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(982, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTab,
            this.newWindow,
            this.open,
            this.save,
            this.saveAs,
            this.saveAll,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(59, 24);
            this.file.Text = "Файл";
            // 
            // newTab
            // 
            this.newTab.Name = "newTab";
            this.newTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTab.Size = new System.Drawing.Size(299, 26);
            this.newTab.Text = "Новая вкладка";
            this.newTab.Click += new System.EventHandler(this.newText_Click);
            // 
            // newWindow
            // 
            this.newWindow.Name = "newWindow";
            this.newWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindow.Size = new System.Drawing.Size(299, 26);
            this.newWindow.Text = "Новое окно";
            this.newWindow.Click += new System.EventHandler(this.newWindow_Click);
            // 
            // open
            // 
            this.open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openText,
            this.openRTF});
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(299, 26);
            this.open.Text = "Открыть";
            // 
            // openText
            // 
            this.openText.Name = "openText";
            this.openText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openText.Size = new System.Drawing.Size(317, 26);
            this.openText.Text = "Открыть текстовый файл";
            this.openText.Click += new System.EventHandler(this.openText_Click);
            // 
            // openRTF
            // 
            this.openRTF.Name = "openRTF";
            this.openRTF.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.openRTF.Size = new System.Drawing.Size(317, 26);
            this.openRTF.Text = "Открыть файл \".rtf\"";
            this.openRTF.Click += new System.EventHandler(this.openRTF_Click);
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(299, 26);
            this.save.Text = "Сохранить";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAs.Size = new System.Drawing.Size(299, 26);
            this.saveAs.Text = "Сохранить как...";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // saveAll
            // 
            this.saveAll.Name = "saveAll";
            this.saveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAll.Size = new System.Drawing.Size(299, 26);
            this.saveAll.Text = "Сохранить все";
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(299, 26);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highlightAll,
            this.undo,
            this.redo,
            this.работаСВыделеннымТекстомToolStripMenuItem,
            this.cut,
            this.copy,
            this.paste});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(74, 24);
            this.edit.Text = "Правка";
            // 
            // highlightAll
            // 
            this.highlightAll.Name = "highlightAll";
            this.highlightAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.highlightAll.Size = new System.Drawing.Size(423, 26);
            this.highlightAll.Text = "Выделить всё";
            this.highlightAll.Click += new System.EventHandler(this.highlightAll_Click);
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo.Size = new System.Drawing.Size(423, 26);
            this.undo.Text = "Отменить";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.Name = "redo";
            this.redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.redo.Size = new System.Drawing.Size(423, 26);
            this.redo.Text = "Повторить отменённое действие";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // работаСВыделеннымТекстомToolStripMenuItem
            // 
            this.работаСВыделеннымТекстомToolStripMenuItem.Enabled = false;
            this.работаСВыделеннымТекстомToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.работаСВыделеннымТекстомToolStripMenuItem.Name = "работаСВыделеннымТекстомToolStripMenuItem";
            this.работаСВыделеннымТекстомToolStripMenuItem.Size = new System.Drawing.Size(423, 26);
            this.работаСВыделеннымТекстомToolStripMenuItem.Text = "Работа с выделенным текстом:";
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut.Size = new System.Drawing.Size(423, 26);
            this.cut.Text = "Вырезать";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy.Size = new System.Drawing.Size(423, 26);
            this.copy.Text = "Копировать";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(423, 26);
            this.paste.Text = "Вставить";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.работаСВыделеннымТекстомToolStripMenuItem1,
            this.bold,
            this.italic,
            this.underline,
            this.strikeOut,
            this.deleteFormat});
            this.format.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(77, 24);
            this.format.Text = "Формат";
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.font.Size = new System.Drawing.Size(335, 26);
            this.font.Text = "Шрифт...";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // работаСВыделеннымТекстомToolStripMenuItem1
            // 
            this.работаСВыделеннымТекстомToolStripMenuItem1.Enabled = false;
            this.работаСВыделеннымТекстомToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.работаСВыделеннымТекстомToolStripMenuItem1.Name = "работаСВыделеннымТекстомToolStripMenuItem1";
            this.работаСВыделеннымТекстомToolStripMenuItem1.Size = new System.Drawing.Size(335, 26);
            this.работаСВыделеннымТекстомToolStripMenuItem1.Text = "Работа с выделенным текстом:";
            // 
            // bold
            // 
            this.bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bold.Name = "bold";
            this.bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bold.Size = new System.Drawing.Size(335, 26);
            this.bold.Text = "Жирный";
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italic.Name = "italic";
            this.italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italic.Size = new System.Drawing.Size(335, 26);
            this.italic.Text = "Курсив";
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underline.Name = "underline";
            this.underline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underline.Size = new System.Drawing.Size(335, 26);
            this.underline.Text = "Подчёркнутый";
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // strikeOut
            // 
            this.strikeOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.strikeOut.Name = "strikeOut";
            this.strikeOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.strikeOut.Size = new System.Drawing.Size(335, 26);
            this.strikeOut.Text = "Зачёркнутый";
            this.strikeOut.Click += new System.EventHandler(this.strikeOut_Click);
            // 
            // deleteFormat
            // 
            this.deleteFormat.Name = "deleteFormat";
            this.deleteFormat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteFormat.Size = new System.Drawing.Size(335, 26);
            this.deleteFormat.Text = "Очистить форматирование";
            this.deleteFormat.Click += new System.EventHandler(this.deleteFormat_Click);
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSave,
            this.colorTheme});
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(98, 24);
            this.settings.Text = "Настройки";
            // 
            // autoSave
            // 
            this.autoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.choiceInterval});
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(293, 26);
            this.autoSave.Text = "Автоматическое сохранение";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(250, 27);
            this.toolStripTextBox2.Text = "Интервал периода сохранения";
            // 
            // choiceInterval
            // 
            this.choiceInterval.Items.AddRange(new object[] {
            "1 секунда",
            "10 секунд",
            "20 секунд",
            "30 секунд",
            "40 секунд",
            "50 секунд ",
            "1 минута"});
            this.choiceInterval.Name = "choiceInterval";
            this.choiceInterval.Size = new System.Drawing.Size(121, 28);
            this.choiceInterval.Click += new System.EventHandler(this.choiceInterval_Click);
            // 
            // colorTheme
            // 
            this.colorTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.white,
            this.black,
            this.red,
            this.orange,
            this.yellow,
            this.green,
            this.blue,
            this.violet});
            this.colorTheme.Name = "colorTheme";
            this.colorTheme.Size = new System.Drawing.Size(293, 26);
            this.colorTheme.Text = "Выбор цветовой схемы";
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.WhiteSmoke;
            this.white.CheckOnClick = true;
            this.white.ForeColor = System.Drawing.Color.Black;
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(224, 26);
            this.white.Text = "white";
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.DarkGray;
            this.black.CheckOnClick = true;
            this.black.ForeColor = System.Drawing.Color.White;
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(224, 26);
            this.black.Text = "black";
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Firebrick;
            this.red.CheckOnClick = true;
            this.red.ForeColor = System.Drawing.Color.Chartreuse;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(224, 26);
            this.red.Text = "red";
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.DarkOrange;
            this.orange.CheckOnClick = true;
            this.orange.ForeColor = System.Drawing.Color.Blue;
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(224, 26);
            this.orange.Text = "orange";
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.CheckOnClick = true;
            this.yellow.ForeColor = System.Drawing.Color.Purple;
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(224, 26);
            this.yellow.Text = "yellow";
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Lime;
            this.green.CheckOnClick = true;
            this.green.ForeColor = System.Drawing.Color.Red;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(224, 26);
            this.green.Text = "green";
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Aqua;
            this.blue.CheckOnClick = true;
            this.blue.ForeColor = System.Drawing.Color.Chocolate;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(224, 26);
            this.blue.Text = "blue";
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // violet
            // 
            this.violet.BackColor = System.Drawing.Color.DeepPink;
            this.violet.CheckOnClick = true;
            this.violet.ForeColor = System.Drawing.Color.PaleGreen;
            this.violet.Name = "violet";
            this.violet.Size = new System.Drawing.Size(224, 26);
            this.violet.Text = "violet";
            this.violet.Click += new System.EventHandler(this.violet_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 28);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(982, 425);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 425);
            this.tabControl1.TabIndex = 5;
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Notepad";
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripMenuItem newTab;
        private System.Windows.Forms.ToolStripMenuItem format;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem openText;
        private System.Windows.Forms.ToolStripMenuItem openRTF;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.ToolStripMenuItem autoSave;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripComboBox choiceInterval;
        private System.Windows.Forms.ToolStripMenuItem colorTheme;
        private System.Windows.Forms.ToolStripMenuItem white;
        private System.Windows.Forms.ToolStripMenuItem black;
        private System.Windows.Forms.ToolStripMenuItem red;
        private System.Windows.Forms.ToolStripMenuItem orange;
        private System.Windows.Forms.ToolStripMenuItem yellow;
        private System.Windows.Forms.ToolStripMenuItem green;
        private System.Windows.Forms.ToolStripMenuItem blue;
        private System.Windows.Forms.ToolStripMenuItem violet;
        private System.Windows.Forms.ToolStripMenuItem saveAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem работаСВыделеннымТекстомToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bold;
        private System.Windows.Forms.ToolStripMenuItem italic;
        private System.Windows.Forms.ToolStripMenuItem underline;
        private System.Windows.Forms.ToolStripMenuItem strikeOut;
        private System.Windows.Forms.ToolStripMenuItem deleteFormat;
        private System.Windows.Forms.ToolStripMenuItem newWindow;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem highlightAll;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem работаСВыделеннымТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redo;
    }
}
