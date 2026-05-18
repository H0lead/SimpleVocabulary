using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVocabulary
{
    public partial class AddWord : Form
    {

        private Form1 mainForm;

        private Vocabulary vocabulary;

        private bool wordAdded = false;

        // Передаємо головну форму для того, щоб потім встановити стан кнопок збереження.
        public AddWord(Form1 form, Vocabulary value)
        {
            InitializeComponent();
            mainForm = form;
            vocabulary = value;
        }

        // Заборона писати "=" у полях. Може зламати словник, так як він парситься за цим символом.
        private void wordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=') 
            {
                e.Handled = true;
            }
        }

        // Заборона писати "=" у полях. Може зламати словник, так як він парситься за цим символом.
        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '=')
            {
                e.Handled = true;
            }
        }

        // Обробка кнопки додовання терміну.
        private void addWordButton_Click(object sender, EventArgs e)
        {
            if (wordtextBox.Text != "" && valueTextBox.Text != "")
            {
                try
                {
                    vocabulary.addWord(wordtextBox.Text, valueTextBox.Text);
                    exportLabel.Text = "Слово успішно додано!";
                    vocabulary.isSaved = false;
                    wordAdded = true;
                    mainForm.saveToolStripMenuItem.Enabled = true;
                    mainForm.findTextBox.AutoCompleteCustomSource.Add(wordtextBox.Text);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Спочатку відкрите словник!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                exportLabel.Text = "Одне з значень пусте!";
            }
        }

        // Коли форма закривається на головний формі оновлюється ListBox з новими даними.
        private void AddWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vocabulary != null)
            {
                if (wordAdded)
                {
                    mainForm.updateExportList();
                }
            }
        }
    }
}
