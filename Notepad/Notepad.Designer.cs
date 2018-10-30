using System;
using System.Windows.Forms;

namespace Notepad
{
    partial class Notepad
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextArea = new System.Windows.Forms.RichTextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEncoding = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectANSI = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectUnicode = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSelectUTF = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.FontChange = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.statusLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextArea
            // 
            this.TextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextArea.Location = new System.Drawing.Point(0, 24);
            this.TextArea.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(662, 364);
            this.TextArea.TabIndex = 0;
            this.TextArea.Text = "";
            this.TextArea.TextChanged += new System.EventHandler(this.TextArea_TextChanged);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.MenuEncoding,
            this.Format,
            this.помощьToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(662, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCreate,
            this.MenuOpen,
            this.MenuSave,
            this.toolStripMenuItem1,
            this.MenuExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuCreate
            // 
            this.MenuCreate.Name = "MenuCreate";
            this.MenuCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuCreate.Size = new System.Drawing.Size(202, 22);
            this.MenuCreate.Text = "Создать";
            this.MenuCreate.Click += new System.EventHandler(this.MenuCreate_Click);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(202, 22);
            this.MenuOpen.Text = "Открыть";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(202, 22);
            this.MenuSave.Text = "Сохранить как...";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.MenuExit.Size = new System.Drawing.Size(202, 22);
            this.MenuExit.Text = "Выход";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuEncoding
            // 
            this.MenuEncoding.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSelectDefault,
            this.MenuSelectANSI,
            this.MenuSelectUnicode,
            this.MenuSelectUTF});
            this.MenuEncoding.Name = "MenuEncoding";
            this.MenuEncoding.Size = new System.Drawing.Size(78, 20);
            this.MenuEncoding.Text = "Кодировка";
            // 
            // MenuSelectDefault
            // 
            this.MenuSelectDefault.Checked = true;
            this.MenuSelectDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuSelectDefault.Name = "MenuSelectDefault";
            this.MenuSelectDefault.Size = new System.Drawing.Size(118, 22);
            this.MenuSelectDefault.Text = "Default";
            this.MenuSelectDefault.Click += new System.EventHandler(this.MenuSelectDefault_Click);
            // 
            // MenuSelectANSI
            // 
            this.MenuSelectANSI.Name = "MenuSelectANSI";
            this.MenuSelectANSI.Size = new System.Drawing.Size(118, 22);
            this.MenuSelectANSI.Text = "ANSI";
            this.MenuSelectANSI.Click += new System.EventHandler(this.MenuSelectDefault_Click);
            // 
            // MenuSelectUnicode
            // 
            this.MenuSelectUnicode.Name = "MenuSelectUnicode";
            this.MenuSelectUnicode.Size = new System.Drawing.Size(118, 22);
            this.MenuSelectUnicode.Text = "Unicode";
            this.MenuSelectUnicode.Click += new System.EventHandler(this.MenuSelectDefault_Click);
            // 
            // MenuSelectUTF
            // 
            this.MenuSelectUTF.Name = "MenuSelectUTF";
            this.MenuSelectUTF.Size = new System.Drawing.Size(118, 22);
            this.MenuSelectUTF.Text = "UTF-8";
            this.MenuSelectUTF.Click += new System.EventHandler(this.MenuSelectDefault_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontChange});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(62, 20);
            this.Format.Text = "Формат";
            // 
            // FontChange
            // 
            this.FontChange.Name = "FontChange";
            this.FontChange.Size = new System.Drawing.Size(113, 22);
            this.FontChange.Text = "Шрифт";
            this.FontChange.Click += new System.EventHandler(this.Font);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(149, 22);
            this.MenuAbout.Text = "О программе";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // Status
            // 
            this.Status.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLeft,
            this.statusRight});
            this.Status.Location = new System.Drawing.Point(0, 387);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(662, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // statusLeft
            // 
            this.statusLeft.Name = "statusLeft";
            this.statusLeft.Size = new System.Drawing.Size(38, 17);
            this.statusLeft.Text = "Готов";
            // 
            // statusRight
            // 
            this.statusRight.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.statusRight.Name = "statusRight";
            this.statusRight.Size = new System.Drawing.Size(67, 17);
            this.statusRight.Text = "Сохранено";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // sfd
            // 
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 409);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadClosing);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextArea;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEncoding;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectANSI;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectUnicode;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectUTF;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripStatusLabel statusLeft;
        private System.Windows.Forms.ToolStripStatusLabel statusRight;
        private System.Windows.Forms.ToolStripMenuItem MenuSelectDefault;
        public System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripMenuItem MenuCreate;
        private ToolStripMenuItem Format;
        private ToolStripMenuItem FontChange;
        private FontDialog fontDialog1;
        private SaveFileDialog sfd;
    }
}

