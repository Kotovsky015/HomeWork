namespace ConditionalsAndLoops.Task4_SumOfNumbers;

public class Task4SumOfNumbers
{
    public void Run()
    {
        Random rnd = new Random();
        int numberRange = rnd.Next(1, 101);
        
        int sum = 0;

        for (int i = 1; i <= numberRange; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
}