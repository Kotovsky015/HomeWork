namespace ConditionalsAndLoops.Task4_SumOfNumbers;

public class Task4SumOfNumbers
{
    public void Run()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }
    }
}