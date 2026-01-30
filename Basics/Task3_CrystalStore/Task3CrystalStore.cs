namespace ConsoleApp.Task3_CrystalStore;

public class Task3CrystalStore
{
    public void Run()
    {
        int gold;
        int diamondsAvailable = 100;
        int diamondsToBuy;
        int total;

        const int DiamondPrice = 10;

        Console.WriteLine("Сколько у вас золота ?");
        gold = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Имеется {diamondsAvailable} кристаллов " +
                          $"\nЦена за один кристалл {DiamondPrice}." +
                          $"\nСколько кристаллов желаете приобрести ?");


        diamondsToBuy = Convert.ToInt32(Console.ReadLine());

        gold -= diamondsToBuy * DiamondPrice;
        total = diamondsToBuy;

        Console.WriteLine($"Вы купили кристаллов {total}." +
                          $"\nОстаток золота {gold}.");
    }
}