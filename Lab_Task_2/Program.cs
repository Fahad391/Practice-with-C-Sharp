using System;

namespace main;
class Program
{
    static void Main(string[] args)
    {
        PurchaseDate date1 = new PurchaseDate { Day = 12, Month = 4, Year = 2019 };
        PurchaseDate date2 = new PurchaseDate { Day = 15, Month = 6, Year = 2020 };
        PurchaseDate date3 = new PurchaseDate { Day = 20, Month = 9, Year = 2023 };
        PurchaseDate date4 = new PurchaseDate { Day = 12, Month = 12, Year = 2025 };

        Computer c = new Computer(1.8, 512, date1);
        Desktop d1 = new Desktop(3.0, 1024, date2, "Tower");
        Desktop d2 = new Desktop(2.0, 1024, date3, "Standard");
        Desktop d3 = new Desktop(3.8, 512, date1, "Mini");
        Desktop d4 = new Desktop(4.0, 5120, date4, "Standard");
        Desktop d5 = new Desktop(4.0, 5120, date4, "Tower");
        Laptop l1 = new Laptop(2.8, 512, date3, 80);
        Laptop l2 = new Laptop(1.9, 2048, date2, 65);
        Laptop l3 = new Laptop(2.6, 1024, date3, 40);
        Laptop l4 = new Laptop(3.9, 3072, date4, 95);

        c.Display();
        Console.WriteLine();
        d1.Display();
        Console.WriteLine();
        d2.Display();
        Console.WriteLine();
        d3.Display();
        Console.WriteLine();
        d4.Display();
        Console.WriteLine();
        l1.Display();
        Console.WriteLine();
        l2.Display();
        Console.WriteLine();
        l3.Display();
        Console.WriteLine();
        l4.Display();
        Console.WriteLine();
    }
}