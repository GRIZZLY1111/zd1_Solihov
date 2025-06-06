using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd1_Solihov
{
    public partial class Zad3 : Form
    {
        private Playlist playlist = new Playlist();
        public Zad3()
        {
            InitializeComponent();
        }

        private void Zad3_Load(object sender, EventArgs e)
        {
        }
        //Обновляем листбокс
        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var song in playlist.GetSongs())
            {
                listBox1.Items.Add($"Автор песни: {song.Author} Название песни: {song.Title} - Путь к файлу песни: {song.Filename}");
            }

            if (playlist.Count > 0)
                listBox1.SelectedIndex = playlist.CurrentIndex;
        }
        //Добавляем запись
        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text.Trim();
            string title = textBox2.Text.Trim();
            string filename = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            playlist.AddSong(author, title, filename);
            UpdateListBox();
        }
        //Переходим на следующую запись
        private void button5_Click(object sender, EventArgs e)
        {
            playlist.Next();
            UpdateListBox();
        }
        //Переходим на предыдующую запись
        private void button4_Click(object sender, EventArgs e)
        {
            playlist.Previous();
            UpdateListBox();
        }
        //Переходим в начало списка записей
        private void button3_Click(object sender, EventArgs e)
        {
            playlist.GoToStart();
            UpdateListBox();
        }
        //Переходим по индексу к записе
        private void button2_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(numericUpDown1.Value);
            playlist.GoToIndex(index);
            UpdateListBox();
        }
        
        //Очищаем плейлист
        private void очиститьПлейлистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            UpdateListBox();
        }
        //Удаляем выбранную запись по индексу
        private void поИндексуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверяем выбрана ли песня
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex;
                playlist.RemoveAt(index);
                UpdateListBox();
            }
        }
        //Удаляем выбранную запись по значению типа Song
        private void поЗначениюТипаSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Проверяем выбрана ли песня
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите песню для удаления");
                return;
            }
            int selectedIndex = listBox1.SelectedIndex;
            // Получаем Song из плейлиста по индексу
            Song songToRemove = playlist.GetSongs()[selectedIndex];
            // Удаляем по значению
            if (playlist.Remove(songToRemove))
            {
                UpdateListBox();
                MessageBox.Show("Песня успешно удалена");
            }
            else
            {
                MessageBox.Show("Ошибка при удалении песни");
            }
        }
    }
}
