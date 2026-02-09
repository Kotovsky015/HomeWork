namespace ConditionalsAndLoops.Task4_SumOfNumbers;

public class Task4SumOfNumbers
{
    public void Run()
    {
        const int MinNumber = 1;
        const int MaxNumber = 1;
        
        Random rnd = new Random();
        int randomNumberRange = rnd.Next(MinNumber, MaxNumber);
        
        int sum = 0;

        for (int i = 1; i <= randomNumberRange; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
    }
}