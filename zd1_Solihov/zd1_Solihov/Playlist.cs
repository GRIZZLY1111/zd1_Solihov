using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd1_Solihov
{
    struct Song
    {
        public string Author;
        public string Title;
        public string Filename;
    }
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;
        private int count=0;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public bool IsFileExists(string filename)
        {
            return !list.Any(song => song.Filename == filename);
        }
        //Перегрузка добавления записи
        public void AddSong(Song song)
        {
            list.Add(song);
            count++;
        }
        //Добавление записи
        public void AddSong(string author, string title, string filename)
        {
            if (IsFileExists(filename))
            {
                list.Add(new Song { Author = author, Title = title, Filename = filename });
                count++;
            }
            else
            {
                MessageBox.Show("Файл с таким путем уже сществует");
            }
        }

        //Переход к следующей записи
        public void Next()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Плейлист пуст невозможно перейти");
                return;
            }
            if (count-1 > currentIndex)
            {
                currentIndex = (currentIndex + 1) % list.Count;
            }
            else
            {
                MessageBox.Show("Переход дальше невозможен данная запись является последней");
                return;
            }
        }
        //Переход к предыдующей записи
        public void Previous()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Плейлист пуст невозможно перейти");
                return;
            }
            if (currentIndex > 0)
            {
                currentIndex = (currentIndex - 1 + list.Count) % list.Count;
            }
            else
            {
                MessageBox.Show("Переход дальше невозможен данная запись является первой");
                return;
            }
        }
        //Переход к началу списка
        public void GoToStart()
        {
            if (list.Count > 0)
            {
                currentIndex = 0;
            }
        }
        //Переход по индексу записи
        public void GoToIndex(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                currentIndex = index;
            }
            else if(index<0)
            {
                MessageBox.Show("Индекс записи не может быть меньше нуля");
                return;
            }
            else
            {
                MessageBox.Show("Записи под таким индексом не существует");
                return;
            }
        }

        //Удаление композиции
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                count--;
                MessageBox.Show("Песня успешно удалена");
                //Перемещаем currentIndex если мы удалили последнюю запись
                if (currentIndex >= list.Count && list.Count > 0)
                {
                    currentIndex = list.Count - 1; 
                }
            }
            else
            {
                MessageBox.Show("Ошибка при удалении песни");
            }
        }
        //Перегрузка удаления композиции
        public bool Remove(Song song)
        {
            int index = list.FindIndex(s => s.Author == song.Author && s.Title == song.Title && s.Filename == song.Filename);
            if (index != -1)
            {
                list.RemoveAt(index);
                count--;
                //Перемещаем currentIndex если мы удалили последнюю запись
                if (currentIndex >= list.Count && list.Count > 0)
                {
                    currentIndex = list.Count - 1;
                }
                return true;
            }
            return false;
        }
        // Очистка плейлиста
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
            count = 0;
        }
        //Получение списка для отображения
        public List<Song> GetSongs()
        {
            return list;
        }
        public int Count { get { return list.Count; } }
        public int CurrentIndex { get { return currentIndex; } }
    }
}
