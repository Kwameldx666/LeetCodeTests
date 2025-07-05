using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    public class SongMusic
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public SongMusic(string name, string author)
        {
            Name = name;
            Author = author;
        }
    }
    internal class MusicDoublyPlaylist
    {
        private DoublyNode<SongMusic> head;
        private DoublyNode<SongMusic> tail;
        public int Count { get; private set; }

        public MusicDoublyPlaylist()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public bool AddSong(SongMusic music)
        {
            DoublyNode<SongMusic> newNode = new(music);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            Count++;
            return true;
        }

        public void ShowPlaylist()
        {
            if (head == null)
            {
                Console.WriteLine("📋 Плейлист пустой");
                return;
            }

            Console.WriteLine("📋 Текущий плейлист:");
            DoublyNode<SongMusic> current = head;
            int position = 1;

            while (current != null)
            {
                Console.WriteLine($"  {position}. 🎵 {current.Value.Name} - {current.Value.Author}");
                current = current.Next;
                position++;
            }

            Console.WriteLine($"📊 Всего песен: {Count}");
        }

        public void ShowPlaylistReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("📋 Плейлист пустой");
                return;
            }
            DoublyNode<SongMusic> current = tail;
            int position = 1;
            while (current != null)
            {
                Console.WriteLine($"  {position}. 🎵 {current.Value.Name} - {current.Value.Author}");
                current = current.Previous;
                position++;
            }

            Console.WriteLine($"📊 Всего песен: {Count}");
        }

        public void SortByName()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                for (int i = 0; i < Count; i++) {
                    for(int j = 0;j < Count - i - 1; j++)
                    {
                        DoublyNode<SongMusic> song1 = GetNodeAt(j + 1);
                        DoublyNode<SongMusic> song2 = GetNodeAt(j);
                        if (song2.Value.Name.CompareTo(song1.Value.Name) > 0)
                        {
                            var tmp = song1.Value;
                            song1.Value = song2.Value;
                            song2.Value = tmp;
                        }
                    }
                }
           
            }
        }
        public void SortByAuthor()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            for (int i = 1; i < Count; i++)
            {
                var keyNode = GetNodeAt(i);
                var keyValue = keyNode.Value;
                int j = i - 1;

                // Сдвигать элементы, пока не найдём место для keyValue
                while (j >= 0)
                {
                    var currNode = GetNodeAt(j);
                    if (string.Compare(currNode.Value.Author, keyValue.Author, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        GetNodeAt(j + 1).Value = currNode.Value; // сдвиг
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                GetNodeAt(j + 1).Value = keyValue; // вставка
            }
        }
        public void Reverse()
        {
            if(head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                DoublyNode<SongMusic> current = head;
                DoublyNode<SongMusic> newHead = null;
                while (current != null)
                {
                    var next = current.Next;
                    current.Next = current.Previous;
                    current.Previous = next;
                    // этот узел станет новым head в конце
                    newHead = current;

                    // идём к «старому» next
                    current = next;
                }
                head = newHead;


            }
        }
            
        public bool RemoveSong(SongMusic song)
        {
            if (head == null)
            {
                Console.WriteLine("пустой плэйлист");
                return false;
            }
            else
            {
                DoublyNode<SongMusic> current = head;
                while (current != null)
                {
                    if (current.Value.Name == song.Name && current.Value.Author == song.Author)
                    {
                        if (current == head)
                        {
                            head = current.Next;
                            if (head != null)
                                head.Previous = null;
                            else
                                tail = null;
                        }
                        else if (current == tail)
                        {
                            tail = current.Previous;
                            if (tail != null)
                                tail.Next = null;
                            else
                                head = null;
                        }
                        else
                        {
                            current.Previous.Next = current.Next;
                            current.Next.Previous = current.Previous;
                        }
                        Count--;
                        return true;
                    }
                    current = current.Next;
                }
                return false;
            }
        }

        public bool InsertSongAt(SongMusic song, int index)
        {
            if (index < 0 || index > Count)
            {
                Console.WriteLine("Index выходит за границы списка");
                return false;
            }

            DoublyNode<SongMusic> newNode = new DoublyNode<SongMusic>(song);

            // Вставка в начало
            if (index == 0)
            {
                newNode.Next = head;
                if (head != null)
                    head.Previous = newNode;
                head = newNode;
                if (Count == 0)
                    tail = newNode; // если список был пуст
                Count++;
                return true;
            }

            // Вставка в конец
            if (index == Count)
            {
                newNode.Previous = tail;
                if (tail != null)
                    tail.Next = newNode;
                tail = newNode;
                if (Count == 0)
                    head = newNode; // если список был пуст
                Count++;
                return true;
            }

            // Вставка в середину
            DoublyNode<SongMusic> current = head;
            for (int i = 0; i < index - 1; i++)
                current = current.Next;

            // current указывает на элемент перед позицией index
            newNode.Next = current.Next;
            newNode.Previous = current;
            current.Next.Previous = newNode;
            current.Next = newNode;

            Count++;
            return true;
        }

        public SongMusic FindSong(string name, string author)
        {
            DoublyNode<SongMusic> current = head;
            while (current != null)
            {
                if (current.Value.Name == name && current.Value.Author == author)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return null;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public DoublyNode<SongMusic> GetNodeAt(int index)
        {
            if (head == null)
            {
                Console.WriteLine("Your list is empty");
                return null;
            }
            else if (index < 0 || index >= Count)
            {
                return null;
            }
            else
            {

                DoublyNode<SongMusic> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current;
            }
        }
        public SongMusic GetSongAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                return null;
            }
            else
            {
                DoublyNode<SongMusic> current = head;
                for (int i = 0; i < index; i++) { current = current.Next; }
                return current.Value;
            }
        }

        public List<SongMusic> FindAllByAuthor(string author)
        {
            DoublyNode<SongMusic> current = head;
            List<SongMusic> listMusic = new List<SongMusic>();
            while (current != null)
            {
                if (current.Value.Author == author)
                {
                    listMusic.Add(current.Value);
                }
                current = current.Next;
            }
            return listMusic;
        }

        public class DoublyNode<T>
        {
            public T Value { get; set; }
            public DoublyNode<T> Next { get; set; }
            public DoublyNode<T> Previous { get; set; }

            public DoublyNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }
        }
    }
}
