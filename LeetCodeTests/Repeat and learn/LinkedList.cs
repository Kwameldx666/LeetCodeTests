using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Artist} ({Duration} sec)";
        }
        public Song(string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }
    }
    internal class MusicPlaylist
    {
        private Node<Song> head;
        public int Count { get; private set; } = 0;

        public MusicPlaylist()
        {
            head = null;
            Count = 0;
        }
        public MusicPlaylist(Song song)
        {
            head = new Node<Song>(song);
            Count = 1;
        }

        public void AddSong(Song data)
        {
            Node<Song> nodeMusic = new(data);
            if (head == null)
            {
                head = nodeMusic;
            }
            else
            {
                Node<Song> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = nodeMusic;
            }
            Count++;
        }

        public void ShowPlaylist()
        {
            if (head == null)  // Можно сразу проверить head
            {
                Console.WriteLine("📋 Плейлист пустой");
                return;
            }

            Console.WriteLine("📋 Текущий плейлист:");
            Node<Song> current = head;
            int position = 1;  // Добавим нумерацию

            while (current != null)
            {
                var song = current.Value;
                var time = TimeSpan.FromSeconds(song.Duration).ToString(@"m\:ss");
                Console.WriteLine($"  {position}. 🎵 {song.Title} - {song.Artist} [{time}]");

                current = current.Next;
                position++;
            }

            Console.WriteLine($"📊 Всего песен: {Count}");
        }


        public bool AddSongToStart(Song data)
        {
            Node<Song> nodeMusic = new(data);
            nodeMusic.Next = head;
            head = nodeMusic;
            Count++;
            return true;
        }

        public bool FindSong(string title)
        {
            Node<Song> current = head;
            string Title;
            while (current != null)
            {
                Title = current.Value.Title;
                if (Title == title)
                {
                    return true;

                }
                current = current.Next;
            }
            return false;
        }

        public int GetTotalDuration()
        {
            Node<Song> current = head;
            int totalDuration = 0;

            while (current != null)
            {
                totalDuration += current.Value.Duration;
                current = current.Next;
            }

            return totalDuration;
        }

        public bool RemoveSong(string title)
        {
            if (head == null)
            {
                Console.WriteLine($"❌ Плейлист пустой");
                return false;
            }

            Node<Song> current = head;

            if (head.Value.Title == title)
            {
                head = head.Next;
                Count--;
                return true;
            }
            while (current.Next != null)
            {
                if (current.Next.Value.Title.Equals(title))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                current = current.Next;
            }
            return false;

        }


        public bool InsertSongAt(int index, Song song)
        {
            if (index < 0 || Count > index)
            {
                return false;
            }
            if (index == 0)
            {
                return AddSongToStart(song);
            }
            Node<Song> current = head;
            Node<Song> songNode = new(song);
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            songNode.Next = current.Next;
            current.Next = songNode;
            Count++;
            return true;
        }

        public Song GetSongAt(int index)
        {
            Node<Song> current = head;
            if (index < 0 || index > Count)
            {
                return null;
            }
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public bool ClearPlaylist()
        {
            // Проверка на пустой плейлист
            if (head == null)
            {
                Console.WriteLine("📭 Плейлист уже пустой");
                return true;
            }
            int deletedCount = Count;
            head = null;
            Count = 0;
            Console.WriteLine($"🗑️ Плейлист очищен. Удалено {deletedCount} песен");
            return true;
        }

        private Node<Song> GetNodeAt(int index)
        {
            Node<Song> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current;
        }


        public bool ShufflePlaylist()
        {
            if (head == null || Count <= 1)
            {
                Console.WriteLine("🎵 Нечего перемешивать");
                return true;
            }
            Random rand = new Random();
            // Fisher-Yates для односвязанного списка
            for (int i = Count - 1; i > 0; i--)
            {
                // Генерируем случайный индекс от 0 до i
                int j = rand.Next(0, i + 1);

                // Находим узлы по индексам i и j
                Node<Song> nodeI = GetNodeAt(i);
                Node<Song> nodeJ = GetNodeAt(j);

                // Меняем Value местами
                Song temp = nodeI.Value;
                nodeI.Value = nodeJ.Value;
                nodeJ.Value = temp;
            }
            return true;

        }

        public class Node<T>
        {
            public T Value;
            public Node<T> Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
    }
}
