namespace ConditionalsAndLoops.Task9_Multipes;

public class Task9Multiples
{
    public void Run()
    {
        Random rnd = new Random();

        const int MinNumber = 1;
        const int MaxNumber = 50;
        const int MinMultiples = 50;
        const int MaxMultiples = 150;
        
        int randomNumber = rnd.Next(MinNumber, MaxNumber);
        int result = 0;

        while (result <= MaxMultiples)
        {
            result += randomNumber;
            if (result >= MinMultiples && result <= MaxMultiples)
            {
                Console.WriteLine(result);
            }
        }
    }
}