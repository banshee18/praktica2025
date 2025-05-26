using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку с символами '#' (Backspace):");
        string result = ProcessBackspaces(Console.ReadLine());
        Console.WriteLine("Результат после обработки:\n" + result);
    }

    static string ProcessBackspaces(string input)
    {
        var stack = new Stack<char>();
        foreach (char c in input)
        {
            if (c == '#' && stack.Count > 0) stack.Pop();
            else if (c != '#') stack.Push(c);
        }
        return string.Concat(stack.Reverse());
    }
}