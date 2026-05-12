using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVocabulary
{
    public class Vocabulary : FileManager
    {
        // Словник (У string[,]) та шлях до файлу.
        private string[,] data;
        private string path;
        private bool isInSearch;
        private int vocabularyLength;

        // Гет сет дати.
        public string[,] Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        // Гет сет шляху.
        public string Path
        {
            get { return path; }
            set
            {
                this.path = value;
            }
        }

        // Геттер змінної isInSearch.
        public bool IsInSearch {  get { return isInSearch; } }

        public int VocabularyLength {  get { return vocabularyLength; } }

        // Конструктор. При отриманні значення шляху виклакається метод наслідувального класу який зчитує файл за шляхом, зберігає словник у data та шлях у path.
        public Vocabulary(string path)
        {
            try
            {
                data = readFile(path);
                this.path = path;
                isInSearch = false;
                vocabularyLength = data.GetLength(0);
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }

        // Метод виведення словника.
        public void print(ListBox listBox, ProgressBar progressBar)
        {
            if (data != null)
            {
                isInSearch = false;

                for (int i = 0; i < data.GetUpperBound(0) + 1; i++)
                {
                    listBox.Items.Add(data[i, 0] + " - " + data[i, 1] + "\n");
                    progressBar.Value += 1;
                }
            }
        }

        // Метод для додавання слова та значення. Не зберігає у вихідний файл.
        // Так як напряму у data додати не вийде, бо він фіксованого розміру, спочатку створимо список з масиву, додамо до нього існуючі елементи.
        // Наступним кроком у кінець списку додається задане слово та його термін, список сортується та перетворюється у string[,]. Присвоються data та встановлюємо файл як не збережений.
        public void addWord(string word, string value)
        {
            if (word != null && value != null && data != null)
            {
                List<string[]> temp = new List<string[]>();

                for (int i = 0; i < data.GetUpperBound(0) + 1; i++)
                {
                    temp.Add(new string[] { data[i, 0], data[i, 1] });
                }

                temp.Add(new string[] { word, value });

                temp.Sort((x, y) => string.Compare(x[0], y[0], StringComparison.OrdinalIgnoreCase));

                string[,] result = new string[temp.Count, 2];

                for (int k = 0; k < temp.Count; k++)
                {
                    result[k, 0] = temp[k][0];
                    result[k, 1] = temp[k][1];
                }

                data = result;
                vocabularyLength++;
                isSaved = false;
            }
            else
            {
                throw new NullReferenceException("Значення data, word або value є порожнім!");
            }
        }

        // Метод виводу заданого масиву. Використовується для виведення знайдених слів за допомогою методів searchForFirst(char letter) та searchWord(string word).
        public void printArray(ListBox listBox, string[,] array)
        {
            listBox.Items.Clear();

            if (array != null || array.Length != 0)
            {
                for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
                {
                    listBox.Items.Add(array[i, 0] + " - " + array[i, 1] + "\n");
                }
            }
        }

        // Метод для пошуку слова та терміна за заданою буквою. Так як словник відсортований, метод проходить до першого співпадіня по букві та подалі записує усі слова на цю букву в окремий список.
        // Наступним кроком список перетворюється у string[,] та повертається.
        public string[,] searchForFirst(char letter)
        {
            if (data != null)
            {
                string[,] result;

                isInSearch = true;

                int i = 0;

                int upperbound = data.GetUpperBound(0) + 1;

                char lowerLetter = char.ToLower(letter);

                while ((i < upperbound) && (char.ToLower(data[i, 0][0]) != lowerLetter))
                {
                    i++;
                }
                if (i >= upperbound)
                {
                    return new string[0, 2];
                }
                else
                {

                    List<string[]> temp = new System.Collections.Generic.List<string[]>();

                    while ((i < upperbound) && (char.ToLower(data[i, 0][0]) == lowerLetter))
                    {
                        temp.Add(new string[] { data[i, 0], data[i, 1] });
                        i++;
                    }

                    result = new string[temp.Count, 2];

                    for (int k = 0; k < temp.Count; k++)
                    {
                        result[k, 0] = temp[k][0];
                        result[k, 1] = temp[k][1];
                    }

                    return result;
                }
            }
            else
            {
                throw new NullReferenceException("Значення Data є порожнім!");
            }
        }

        // Метод для видалення слова зі списку. Йде по масиву, поки слово не дорівнює шуканому додає його у новий список. Так виходить, що щукане слово у новий список додаватись не буде.
        // Новий список перетворюєтся у масив та задається для data.
        public void deleteWord(string word)
        {
            if (data != null)
            {
                string[,] result;

                bool wordDeleted = false;

                int upperbound = data.GetUpperBound(0) + 1;

                List<string[]> temp = new System.Collections.Generic.List<string[]>();

                string lowerCaseWord = word.ToLower();

                for (int i = 0; i < upperbound; i++)
                {
                    if (data[i, 0].ToLower() != lowerCaseWord)
                    {
                        temp.Add(new string[] { data[i, 0], data[i, 1] });
                    }
                    else
                    {
                        wordDeleted = true;
                    }
                }

                if (!wordDeleted)
                {
                    throw new WordNotFoundException($"Слова '{word}' не знайдено у словнику.");
                }

                result = new string[temp.Count, 2];

                for (int k = 0; k < temp.Count; k++)
                {
                    result[k, 0] = temp[k][0];
                    result[k, 1] = temp[k][1];
                }

                data = result;
                isSaved = false;
            }
            else
            {
                throw new NullReferenceException("Значення Data є порожнім!");
            }
        }

        // Метод для пошуку слова та терміна за заданим словом. Так як словник відсортований, метод проходить до першого співпадіня по слово та подалі записує усі ці слова в окремий список.
        // Наступним кроком список перетворюється у string[,] та повертається.
        public string[,] searchWord(string word)
        {
            if (data != null)
            {
                string[,] result;

                isInSearch = true;

                int i = 0;

                int upperbound = data.GetUpperBound(0) + 1;

                while ((i < upperbound) && (data[i, 0].ToLower() != word.ToLower()))
                {
                    i++;
                }
                if (i >= upperbound)
                {
                    return new string[0, 2];
                }
                else
                {
                    List<string[]> temp = new System.Collections.Generic.List<string[]>();

                    while ((i < upperbound) && (string.Equals(data[i, 0], word, StringComparison.OrdinalIgnoreCase)))
                    {
                        temp.Add(new string[] { data[i, 0], data[i, 1] });
                        i++;
                    }

                    result = new string[temp.Count, 2];

                    for (int k = 0; k < temp.Count; k++)
                    {
                        result[k, 0] = temp[k][0];
                        result[k, 1] = temp[k][1];
                    }

                    return result;
                }
            }
            else
            {
                throw new NullReferenceException("Значення Data є порожнім!");
            }
        }

        // Метод для отримання списку слів (потрібно для встановлення підказок при пошуку.)
        public void setAutoCompleteWords(AutoCompleteStringCollection autoCompleteStringCollection, ProgressBar progressBar)
        {
            if (data != null)
            {
                for (int i = 0; i < data.GetUpperBound(0) + 1; i++)
                {  
                    autoCompleteStringCollection.Add(data[i, 0]);
                    progressBar.Value += 1;
                }
            }
            else
            {
                throw new NullReferenceException("Список порожній.");
            }
        }

        // Метод для виведення одновимірного масиву.
        public void printOneDimArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}) {array[i]}");
            }
        }
    }
}
