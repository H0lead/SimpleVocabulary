using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVocabulary
{
    public abstract class FileManager
    {
        internal bool isSaved = false;

        // Метод зчитування даних. Якщо заданий файл не порожній, файл сортується, далі зчитується по рядку. Рядки розділяються та записуються у двовимірний масив.
        public string[,] readFile(string path)
        {
            try
            {
                if (File.ReadAllLines(path).Length != 0)
                {
                    sort(path);
                    
                    string[] lines = File.ReadAllLines(path);

                    string[,] result = new string[lines.GetUpperBound(0) + 1, 2];

                    for (int i = 0; i < lines.GetUpperBound(0) + 1; i++)
                    {
                        string[] splitLine = lines[i].Split('=');

                        result[i, 0] = splitLine[0];
                        result[i, 1] = splitLine[1];
                    }

                    return result;
                }
                else
                {
                    throw new NullReferenceException("Файл порожній");
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Не знайдено файлу за таким шляхом!");
            }
        }

        // Метод для збереження файлу. Перезаписує все даними з наданого двовимірного масиву data.
        public void saveFile(string path, string[,] data)
        {
            try
            {
                if (data != null)
                {
                    File.WriteAllText(path, String.Empty);

                    for (int i = 0; i < data.GetUpperBound(0) + 1; i++)
                    {
                        File.AppendAllText(path, data[i, 0] + "=" + data[i, 1] + "\n");
                    }

                    isSaved = true;
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.Message);
            }

        }

        // Метод сортує файл.
        public void sort(string path)
        {
            string[] lines = File.ReadAllLines(path);

            if (lines.Length != 0)
            {
                Array.Sort(lines);

                File.WriteAllText(path, String.Empty);

                foreach (string line in lines)
                {
                    File.AppendAllText(path, line + "\n");
                }
            }
        }

    }
}
