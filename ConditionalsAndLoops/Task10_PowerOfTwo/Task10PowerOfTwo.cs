namespace ConditionalsAndLoops.Task10_PowerOfTwo;

public class Task10PowerOfTwo
{
    public void Run()
    {
        Random rnd = new Random();

        int RandomNumber = rnd.Next(1, 100);

        int value = 1;
        int count = 0;

        for (int i = 0; value <= RandomNumber; i++)
        {
            value *= 2;
            count++;
        }

        Console.WriteLine($"Исходное число:{RandomNumber}");
        Console.WriteLine($"Минимальная степень двойки:{count}");
        Console.WriteLine($"2 в степени:{value}");
    }
}