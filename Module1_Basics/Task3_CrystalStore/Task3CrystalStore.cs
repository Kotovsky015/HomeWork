namespace ConsoleApp.Task3_CrystalStore;

public class Task3CrystalStore
{
    public void Run()
    {
        const int DiamondPrice = 10;

        int diamondsAvailable = 100;

        Console.WriteLine("Сколько у вас золота ?");

        int gold;

        gold = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Имеется {diamondsAvailable} кристаллов " +
                          $"\nЦена за один кристалл {DiamondPrice}." +
                          $"\nСколько кристаллов желаете приобрести ?");

        int diamondsToBuy;
        diamondsToBuy = Convert.ToInt32(Console.ReadLine());
        
        int total;
        gold -= diamondsToBuy * DiamondPrice;
        total = diamondsToBuy;

        Console.WriteLine($"Вы купили кристаллов {total}." + $"\nОстаток золота {gold}.");
    }
}