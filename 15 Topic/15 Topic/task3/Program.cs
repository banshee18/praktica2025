using System;
using System.Collections.Generic;

// Класс MyList<T> из предыдущего задания
public class MyList<T>
{
    private T[] _items;
    private int _count;
    private const int DefaultCapacity = 4;

    public MyList()
    {
        _items = new T[DefaultCapacity];
        _count = 0;
    }

    public int Count => _count;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Индекс выходит за пределы списка");
            return _items[index];
        }
    }

    public void Add(T item)
    {
        if (_count == _items.Length)
            EnsureCapacity();
        _items[_count] = item;
        _count++;
    }

    private void EnsureCapacity()
    {
        int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
        T[] newItems = new T[newCapacity];
        Array.Copy(_items, newItems, _count);
        _items = newItems;
    }
}

// Класс с расширяющими методами
public static class MyListExtensions
{
    // Расширяющий метод для преобразования MyList<T> в массив
    public static T[] GetArray<T>(this MyList<T> list)
    {
        T[] array = new T[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            array[i] = list[i];
        }
        return array;
    }
}

class Program
{
    static void Main()
    {
        // Создаем экземпляр MyList<int>
        MyList<int> myList = new MyList<int>();

        // Добавляем элементы
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        // Применяем расширяющий метод
        int[] array = myList.GetArray();

        // Выводим элементы массива
        Console.WriteLine("Элементы массива:");
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}