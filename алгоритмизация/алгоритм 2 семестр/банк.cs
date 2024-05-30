using System;
using System.Collections.Generic;
using System.Linq;

public class Account
{
    public int NumSchet { get; set; }
    public string Name { get; set; }
    public double Dohod { get; set; }
    public double Rashod { get; set; }
    public double Nalog => Dohod * 0.05;

    public Account(int ns, string n, double d, double r)
    {
        NumSchet = ns;
        Name = n;
        Dohod = d;
        Rashod = r;
    }
}

class OrderbyDemo
{
    static void Main()
    {
        Account[] accounts =
        {
            new Account(12345, "Кузина Варвара Михайловна", 23.2, 111.23),
            new Account(54321, "Иванов Денис Алексеевич", 23456.5, 12000.00),
            new Account(09876, "Калягина Екатерина Алексеевна", 1500000.7, 25000.55),
            new Account(67890, "Кондаков Николай Сергеевич", 1678000.0, 98000.68),
            new Account(10101, "Матвеев Дмитрий Андреевич", 1500000.0, 98700.19)
        };
        //запрос 1
        var NegativeBalance = accounts.Where(c => c.Dohod - c.Rashod - c.Nalog < 0);
        Console.WriteLine("Клиенты с отрицательным балансом:");
        foreach (var client in NegativeBalance)
        {
            Console.WriteLine(client.Name);
        }
        //запрос 2
        var PositiveBalance = accounts.Count(c => c.Dohod - c.Rashod - c.Nalog > 0);
        Console.WriteLine($"Количество клиентов с положительным балансом: {PositiveBalance}");
        //запрос 3
        var maxDohod = accounts.Max(c => c.Dohod);
        var maxDohodClients = accounts.Where(c => c.Dohod == maxDohod);
        Console.WriteLine("Клиенты с максимальным доходом:");
        foreach (var client in maxDohodClients)
        {
            Console.WriteLine(client.Name);
        }
        //запрос 4 
        var totalNalog = accounts.Sum(c => c.Nalog);
        Console.WriteLine($"Общая сумма налогов: {totalNalog}");
    }
}
