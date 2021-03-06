﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        string OpenedFileName = string.Empty;

        //клик на пункт открыть
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            statusLeft.Text = "Открытие...";
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Файл RTF|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            opf.RestoreDirectory = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader input = new StreamReader(opf.FileName, GetActiveEncode()))
                {
                    TextArea.Text = input.ReadToEnd();
                    OpenedFileName = Path.GetFileName(opf.FileName);
                }
            }
            statusLeft.Text = "Готов";
            statusRight.Text = "Сохранено";
        }

        //смена кодировки
        Encoding GetActiveEncode()
        {
            foreach (ToolStripMenuItem item in MenuEncoding.DropDownItems)
            {
                if (item.Checked)
                {
                    switch (item.Name)
                    {
                        case "MenuSelectANSI":
                            return Encoding.ASCII;
                        case "MenuSelectUnicode":
                            return Encoding.Unicode;
                        case "MenuSelectUTF":
                            return Encoding.UTF8;
                        default:
                            return Encoding.Default;
                    }
                }
            }
            return Encoding.Default;
        }

        void MenuEncodeUncheck()
        {
            MenuSelectDefault.Checked = false;
            MenuSelectANSI.Checked = false;
            MenuSelectUnicode.Checked = false;
            MenuSelectUTF.Checked = false;
        }

        //клик на пункт сохранения
        private void MenuSave_Click(object sender, EventArgs e)
        {
            statusLeft.Text = "Сохранение...";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Файл RTF|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
            sfd.FileName = OpenedFileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string SaveFilePath = sfd.FileName;
                if (Path.GetExtension(SaveFilePath).Length == 0) SaveFilePath += ".txt";
                if (File.Exists(SaveFilePath))
                {
                    if (MessageBox.Show(string.Format("Файл с именем {0} уже существует.\n\n Заменить?", Path.GetFileName(SaveFilePath)), "Замена файла", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    {
                        return;
                    }
                }
                using (Stream stream = File.Create(SaveFilePath))
                using (StreamWriter output = new StreamWriter(stream, GetActiveEncode()))
                {
                    output.Write(TextArea.Text);
                }
            }
            statusLeft.Text = "Готов";
            statusRight.Text = "Сохранено";
        }

        //клик на пункт выход
        private void MenuExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сохранить файл?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //елси нажато да
            if (dialogResult == DialogResult.Yes)
            {
                statusLeft.Text = "Сохранение...";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Файл RTF|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
                sfd.FileName = OpenedFileName;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string SaveFilePath = sfd.FileName;
                    if (Path.GetExtension(SaveFilePath).Length == 0) SaveFilePath += ".txt";
                    if (File.Exists(SaveFilePath))
                    {
                        if (MessageBox.Show(string.Format("Файл с именем {0} уже существует.\n\n Заменить?", Path.GetFileName(SaveFilePath)), "Замена файла", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                    using (Stream stream = File.Create(SaveFilePath))
                    using (StreamWriter output = new StreamWriter(stream, GetActiveEncode()))
                    {
                        output.Write(TextArea.Text);
                    }
                    Application.Exit();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void MenuSelectDefault_Click(object sender, EventArgs e)
        {
            MenuEncodeUncheck();
            ((ToolStripMenuItem)sender).Checked = true;
        }

        //о программе
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ищешь помощи? \n\n тебе уже никто не поможет","окно",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        //статусбар при изменении текста
        private void TextArea_TextChanged(object sender, EventArgs e)
        {
            if (statusRight.Text != "Изменено") statusRight.Text = "Изменено";
        }
        
        //очистка текстового поля aka костыль
        private void MenuCreate_Click(object sender, EventArgs e)
        {
            TextArea.Text = "";
        }

        //закрытие формы
        private void NotepadClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Сохранить файл?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //елси нажато да
                if (dialogResult == DialogResult.Yes)
                {
                    statusLeft.Text = "Сохранение...";
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Файл RTF|*.rtf|Текстовые файлы (*.txt)|*.txt|Все файлы|*.*";
                    sfd.FileName = OpenedFileName;
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string SaveFilePath = sfd.FileName;
                        if (Path.GetExtension(SaveFilePath).Length == 0) SaveFilePath += ".txt";
                        if (File.Exists(SaveFilePath))
                        {
                            if (MessageBox.Show(string.Format("Файл с именем {0} уже существует.\n\n Заменить?", Path.GetFileName(SaveFilePath)), "Замена файла", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                        using (Stream stream = File.Create(SaveFilePath))
                        using (StreamWriter output = new StreamWriter(stream, GetActiveEncode()))
                        {
                            output.Write(TextArea.Text);
                        }
                        Application.Exit();
                    }
                    //если нажата отмена при сохранении
                    else if (sfd.ShowDialog() == DialogResult.Cancel)
                    {
                        //устанавливает флаг отмены события в истину
                        e.Cancel = true;
                        //спрашивает стоит ли завершится
                        if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
                //если нажато нет
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void Font(object sender, EventArgs e)
        {
            //вызов диалога
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //получаем шрифт
                Font font = fontDialog1.Font;
                //задаем параметры тексту
                this.TextArea.Font = font;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
