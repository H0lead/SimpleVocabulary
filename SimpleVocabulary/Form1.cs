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

        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
        }

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

        private void aboutPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                try
                {
                    if (saveVocabularyFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        vocabulary.saveFile(saveVocabularyFileDialog.FileName, vocabulary.Data);
                        vocabulary.Path = saveVocabularyFileDialog.FileName;
                        saveToolStripMenuItem.Enabled = false;
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка! Файл не знайдено!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                if (vocabulary.IsInSearch)
                {
                    exportListBox.Items.Clear();
                    findTextBox.Text = string.Empty;
                    OpenProgressbar openProgressbar = new OpenProgressbar("Зачекайте, виводимо словник...");
                    ProgressBar progressBar = openProgressbar.openProgressBarUI;
                    progressBar.Maximum = vocabulary.VocabularyLength;
                    openProgressbar.Show();

                    vocabulary.print(exportListBox, progressBar);

                    openProgressbar.Close();
                }   
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (vocabulary != null)
            {
                if (findTextBox.Text == "")
                {
                    return;
                }

                string[,] result;

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
            else
            {
                MessageBox.Show("Спочатку відкрийте словник!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord(this, vocabulary);
            addWord.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord(this, vocabulary);
            deleteWord.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWord addWord = new AddWord(this, vocabulary);
            addWord.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteWord deleteWord = new DeleteWord(this, vocabulary);
            deleteWord.Show();
        }
    }
}
