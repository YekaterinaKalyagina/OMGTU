using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var queue = new Queue<string>(); //создание очереди 
        queue.Enqueue("13455,2023-05-19,19:50,20");//добавление данных в очередь
        queue.Enqueue("13455,2023-05-12,12:40,17");
        queue.Enqueue("65730,2023-05-19,13:45,10");
        var phoneMinutesDictionary = new Dictionary<string, int>();//ключом является строка а значением число
        var phoneMinutesHashtable = new Hashtable();

        while (queue.Count > 0)
        {
            var callData = queue.Dequeue().Split(',');//вывод 1 строки и избавление от пробелов
            var numbertelef = callData[0];//наш ключик:)
            var time = int.Parse(callData[3]);//наше значение 

            if (phoneMinutesDictionary.ContainsKey(numbertelef))// метод для проверки наличия ключа
            {
                phoneMinutesDictionary[numbertelef] += time;
            }

            else
            {
                phoneMinutesDictionary.Add(numbertelef, time);
            }

            if (phoneMinutesHashtable.ContainsKey(numbertelef))
            {
                phoneMinutesHashtable[numbertelef] = (int)phoneMinutesHashtable[numbertelef] + time;
            }

            else
            {
                phoneMinutesHashtable.Add(numbertelef, time);
            }
        }

        Console.WriteLine("Отчет из словаря (Dict):");
        foreach (var i in phoneMinutesDictionary)
        {
            Console.WriteLine($"Номер: {i.Key}, Минуты: {i.Value}");
        }

        Console.WriteLine("\nОтчет из хеш-таблицы (Hash):");
        foreach (DictionaryEntry k in phoneMinutesHashtable)
        {
            Console.WriteLine($"Номер: {k.Key}, Минуты: {k.Value}");
        }
    }
}
