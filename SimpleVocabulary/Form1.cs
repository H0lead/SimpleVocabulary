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

namespace SimpleVocabulary
{
    public partial class Form1 : Form
    {
        Vocabulary vocabulary;

        // Вимкнення кнопок збереження при запускі програми.
        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

        // Метод оновлює вивід у exportListBox, присутній Progressbar.
        public void updateExportList()
        {
            exportListBox.Items.Clear();
            OpenProgressbar openProgressbar = new OpenProgressbar("Зачекайте, виводимо словник...");
            ProgressBar progressBar = openProgressbar.openProgressBarUI;
            progressBar.Maximum = vocabulary.VocabularyLength;

            openProgressbar.Show();
            vocabulary.print(exportListBox, progressBar);
            openProgressbar.Close();
        }

        // Виклик вікна "About"
        private void aboutPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        // Вихід з додатку.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка відкриття файлу. Намагається прочитати файл. Якщо вдалось то записує у словник.
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openVocabularyFileDialog.ShowDialog() == DialogResult.OK)
            {
                exportListBox.Items.Clear();
                try
                {
                    vocabulary = new Vocabulary(openVocabularyFileDialog.FileName);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception) 
                {
                    MessageBox.Show("Помилка у читанні словника, або невірний формат даних.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                vocabulary.isSaved = true;
                saveAsToolStripMenuItem.Enabled = true;
                OpenProgressbar openProgressbar = new OpenProgressbar("Зачекайте, читаємо словник...");
                ProgressBar progressBar = openProgressbar.openProgressBarUI;
                progressBar.Maximum = vocabulary.VocabularyLength * 2;
                
                openProgressbar.Show();
                vocabulary.setAutoCompleteWords(findTextBox.AutoCompleteCustomSource, progressBar);
                vocabulary.print(exportListBox, progressBar);
                openProgressbar.Close();
            }
        }

        // Збереження файлу.
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                try
                {
                    vocabulary.saveFile(vocabulary.Path, vocabulary.Data);
                    saveToolStripMenuItem.Enabled = false;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Обробка події закривання форми. Якщо користувая не зберіг зміни у файл, його про це попереджають та пропонують зберегти.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vocabulary != null)
            {
                if (!vocabulary.isSaved)
                {
                    if (MessageBox.Show($"Ви хочете зберегти зміни у словинку: {vocabulary.Path}", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        vocabulary.saveFile(vocabulary.Path, vocabulary.Data);
                    }
                }
            }
        }

        // Зберегти як. Зберігає в окремий файл.
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                if (saveVocabularyFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    { 
                        vocabulary.saveFile(saveVocabularyFileDialog.FileName, vocabulary.Data);
                        vocabulary.Path = saveVocabularyFileDialog.FileName;
                        saveToolStripMenuItem.Enabled = false;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка! Файл не знайдено!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        // Скасування "режиму пошуку".
        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            if (vocabulary != null && vocabulary.IsInSearch)
            {
                findTextBox.Text = String.Empty;

                updateExportList();
            }
        }

        // Кнопка пошуку. Шукає слова за заданим полем та виводить їх у ListBox.
        private void findButton_Click(object sender, EventArgs e)
        {
            if (findTextBox.Text == "")
            {
                MessageBox.Show("Поле для пошуку пусте!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[,] result;

            try
            {
                switch (findTextBox.Text.Length)
                {
                    case 1:
                        result = vocabulary.searchForFirst(findTextBox.Text[0]);
                        break;
                    default:
                        result = vocabulary.searchWord(findTextBox.Text);
                        break;
                }

                vocabulary.printArray(exportListBox, result);
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Спочатку відкрийте словник!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Кнопка додавання слова, викликає форму
        private void addButton_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord(this, vocabulary);
            addWord.Show();
        }

        // Кнопка видалення слова, викликає форму
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord(this, vocabulary);
            deleteWord.Show();
        }

        // Кнопка додавання слова, викликає форму
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord(this, vocabulary);
            addWord.Show();
        }

        // Кнопка видалення слова, викликає форму
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord(this, vocabulary);
            deleteWord.Show();
        }
    }
}
