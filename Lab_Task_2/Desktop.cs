public class Desktop : Computer
{
    public string CasingType;

    public Desktop(double cpuClockSpeed, int storageSize, PurchaseDate dateOfPurchase, string casingType) : base(cpuClockSpeed, storageSize, dateOfPurchase)
    {
        CasingType = casingType;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Casing Type: {CasingType}");
        if ((CasingType == "Standard" || CasingType == "Tower") && CpuClockSpeed > 2)
        {
            Console.WriteLine("Good Desktop");
        }
        else
        {
            Console.WriteLine("Generic Desktop");
        }
    }
}