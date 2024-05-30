using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue<Tuple<string, DateTime, TimeSpan, int>> callDataQueue = new Queue<Tuple<string, DateTime, TimeSpan, int>>();//создания кортежа в очереди


        callDataQueue.Enqueue(new Tuple<string, DateTime, TimeSpan, int>("12345678", new DateTime(2023, 4, 1), new TimeSpan(20, 40, 0), 89));
        callDataQueue.Enqueue(new Tuple<string, DateTime, TimeSpan, int>("87654321", new DateTime(2023, 4, 1), new TimeSpan(10, 16, 0), 12));
        callDataQueue.Enqueue(new Tuple<string, DateTime, TimeSpan, int>("12345678", new DateTime(2023, 4, 2), new TimeSpan(9, 0, 0), 18));

        Dictionary<DateTime, int> totalMinutesByDateDict = new Dictionary<DateTime, int>(); //мой словарик 
        Hashtable totalMinutesByDateHashTable = new Hashtable();

        while (callDataQueue.Count > 0)
        {
            var call = callDataQueue.Dequeue();

            if (totalMinutesByDateDict.ContainsKey(call.Item2))//проверка наличия ключа в таблице
            {
                totalMinutesByDateDict[call.Item2] += call.Item4;//Item мы используем чтобы взять элементик из кортежа
            }
            else
            {
                totalMinutesByDateDict.Add(call.Item2, call.Item4);//если что добаавим
            }

            if (totalMinutesByDateHashTable.ContainsKey(call.Item2))
            {
                totalMinutesByDateHashTable[call.Item2] = (int)totalMinutesByDateHashTable[call.Item2] + call.Item4;
            }
            else
            {
                totalMinutesByDateHashTable.Add(call.Item2, call.Item4);
            }
        }

        Console.WriteLine("Дата\t\tСуммарное время разговоров (dictionaty)");

        foreach (var i in totalMinutesByDateDict)
        {

            Console.WriteLine($"{i.Key.ToShortDateString()}\t{i.Value} мин.");
        }

        Console.WriteLine("\nДата\t\tСуммарное время разговоров (hashtable)");
        foreach (DictionaryEntry k in totalMinutesByDateHashTable)
        {
            Console.WriteLine($"{((DateTime)k.Key).ToShortDateString()}\t{k.Value} мин.");
        }
    }
}
