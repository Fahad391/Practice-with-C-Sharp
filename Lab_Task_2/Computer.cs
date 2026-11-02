using System;

public struct PurchaseDate
{
    public int Day;
    public int Month;
    public int Year;
}

public class Computer
{
    public double CpuClockSpeed;
    public int StorageSize;
    public PurchaseDate Date;

    public Computer(double CpuClockSpeed, int StorageSize, PurchaseDate Date) 
    {
        this.CpuClockSpeed = CpuClockSpeed;
        this.StorageSize = StorageSize;
        this.Date = Date;
    }

    public virtual void Display()
    {
        Console.WriteLine("About Computer");
        Console.WriteLine($"CPU Clock Speed: {CpuClockSpeed} GHz");
        Console.WriteLine($"Storage Size: {StorageSize} GB");
        Console.WriteLine($"Purchase Date: {Date.Day}-{Date.Month}-{Date.Year}");
    }
}

