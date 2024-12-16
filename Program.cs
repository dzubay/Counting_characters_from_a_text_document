using System;
using System.IO;

class Test
{
    public static void Main()
    {
        // Имя файла
        string filename = "note1.txt";

        // Символ, который нужно подсчитать
        char symbol = 'A';

        // Считываем текст из файла
        string[] lines = File.ReadAllLines(filename);

        // Подсчитываем количество заданного символа
        int count = 0;
        foreach (string line in lines)
        {
            foreach (char c in line)
            {
                if (c == symbol)
                {
                    count++;
                }
            }
        }

        // Выводим результат
        Console.WriteLine($"Количество символов '{symbol}': {count}");

    }
}
