public class Laptop : Computer
{
    public int BatteryPercentage;

    public Laptop(double cpuClockSpeed, int storageSize, PurchaseDate date, int batteryPercentage) : base(cpuClockSpeed, storageSize, date)
    {
        BatteryPercentage = batteryPercentage;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Battery Percentage: {BatteryPercentage}%");
        if (BatteryPercentage >= 70 && CpuClockSpeed > 2)
        {
            Console.WriteLine("Good laptop");
        }
        else
        {
            Console.WriteLine("Generic Laptop");
        }
    }
}