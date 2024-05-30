using System;
using System.Collections.Generic;
using System.Linq;

public class Worker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public string ProductCategory { get; set; }
    public int ProductCount { get; set; }
    public decimal ProductPrice { get; set; }

    public decimal ProductionValue => ProductCount * ProductPrice;
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Worker> workers = new List<Worker>
        {
            new Worker { Id = 10, Name = "Игольчик", Position = "Молочник", Salary = 22500, ProductCategory = "Молочные продукты", ProductCount = 100, ProductPrice = 310 },
            new Worker { Id = 20, Name = "Пупыркин", Position = "Плотник", Salary = 44000, ProductCategory = "Стульчики", ProductCount = 200, ProductPrice = 160 },
            new Worker { Id = 30, Name = "Синелькин", Position = "Булочник", Salary = 31200, ProductCategory = "Хлебные изделия",  ProductCount = 150, ProductPrice = 370 },
            new Worker { Id = 40, Name = "Мальцев", Position = "Швея", Salary = 25700, ProductCategory = "Платье", ProductCount = 100, ProductPrice = 310 },
            new Worker { Id = 50, Name = "Пугачев", Position = "Плотник", Salary = 49999, ProductCategory = "Стульчики", ProductCount = 200, ProductPrice = 122 },
            new Worker { Id = 60, Name = "Пуговкин", Position = "Кондитер", Salary = 19000, ProductCategory = "Тортики",  ProductCount = 200, ProductPrice = 87 },
        };

        int rabotnikicnizkoizp = workers.Count(w => w.Salary < w.ProductionValue);
        Console.WriteLine($"1. Работники с зарплатой < сумма выработанной продукции: {rabotnikicnizkoizp}");

        var productionPoCategory = workers
            .GroupBy(w => w.ProductCategory)
            .Select(g => new
            {
                Category = g.Key,
                TotalQuantity = g.Sum(w => w.ProductCount),
                TotalValue = g.Sum(w => w.ProductionValue),
            });

        Console.WriteLine("2. Продукция по категориям");
        foreach (var category in productionPoCategory)
        {
            Console.WriteLine($"Категория {category.Category}: Количество = {category.TotalQuantity}, Значение = {category.TotalValue}");
        }

        decimal totalProductionValue = workers.Sum(w => w.ProductionValue);
        Console.WriteLine($"3. Общий суммарный объём произведённой продукции: {totalProductionValue}");

        int highIncomeWorkers = workers.Count(w => w.Salary > 0.5m * w.ProductionValue);
        Console.WriteLine($"4. Работники с зарплатой > 50%  от суммы производимого ими продукта: {highIncomeWorkers}");
    }
}
