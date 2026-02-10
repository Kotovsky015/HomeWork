namespace ConditionalsAndLoops.Task10_PowerOfTwo;

public class Task10PowerOfTwo
{
    public void Run()
    {
        const int MinNumber = 1;
        const int MaxNumber = 100;

        Random rnd = new Random();

        int randomNumberRange = rnd.Next(MinNumber, MaxNumber);

        int value = 1;
        int count = 0;

        for (;value <= randomNumberRange;)
        {
            value *= 2;
            count++;
        }

        Console.WriteLine($"Исходное число:{randomNumberRange}");
        Console.WriteLine($"Минимальная степень двойки:{count}");
        Console.WriteLine($"2 в степени:{value}");
    }
}