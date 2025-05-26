using System;

namespace MyListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования MyList<T>
            MyList<int> myList = new MyList<int>();

            // Добавление элементов
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);

            // Вывод элементов
            Console.WriteLine($"Количество элементов: {myList.Count}");
            Console.WriteLine($"Элемент с индексом 1: {myList[1]}");

            // Попытка доступа к несуществующему индексу
            try
            {
                Console.WriteLine(myList[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class MyList<T>
    {
        private T[] _items;
        private int _size;
        private const int DefaultCapacity = 4;

        public MyList()
        {
            _items = new T[DefaultCapacity];
            _size = 0;
        }

        // Свойство для получения количества элементов
        public int Count => _size;

        // Индексатор для доступа к элементам по индексу
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _size)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы списка");
                }
                return _items[index];
            }
        }

        // Метод добавления элемента
        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                EnsureCapacity();
            }
            _items[_size] = item;
            _size++;
        }

        // Увеличение емкости массива при необходимости
        private void EnsureCapacity()
        {
            int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
            T[] newItems = new T[newCapacity];
            Array.Copy(_items, newItems, _size);
            _items = newItems;
        }
    }
}