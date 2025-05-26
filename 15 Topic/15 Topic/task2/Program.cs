using System;
using System.Collections.Generic;

public class MyDictionary<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> _items = new List<KeyValuePair<TKey, TValue>>();

    public int Count => _items.Count;

    public TValue this[TKey key]
    {
        get
        {
            foreach (var item in _items)
            {
                if (EqualityComparer<TKey>.Default.Equals(item.Key, key))
                    return item.Value;
            }
            throw new KeyNotFoundException($"Key '{key}' not found in dictionary");
        }
        set
        {
            bool found = false;
            for (int i = 0; i < _items.Count; i++)
            {
                if (EqualityComparer<TKey>.Default.Equals(_items[i].Key, key))
                {
                    _items[i] = new KeyValuePair<TKey, TValue>(key, value);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                _items.Add(new KeyValuePair<TKey, TValue>(key, value));
            }
        }
    }

    public void Add(TKey key, TValue value)
    {
        if (ContainsKey(key))
            throw new ArgumentException($"An item with the same key '{key}' already exists");

        _items.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public bool ContainsKey(TKey key)
    {
        foreach (var item in _items)
        {
            if (EqualityComparer<TKey>.Default.Equals(item.Key, key))
                return true;
        }
        return false;
    }

    public void PrintAllItems()
    {
        Console.WriteLine($"Dictionary contains {Count} items:");
        foreach (var item in _items)
        {
            Console.WriteLine($"  {item.Key}: {item.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            var dict = new MyDictionary<string, int>();

            // Добавляем элементы
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict["three"] = 3; // Используем индексатор для добавления

            // Выводим все элементы
            dict.PrintAllItems();

            // Пробуем получить существующий и несуществующий ключ
            Console.WriteLine($"Value for 'two': {dict["two"]}");
            Console.WriteLine($"Value for 'four': {dict["four"]}"); // Выбросит исключение
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}