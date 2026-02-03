namespace ConditionalsAndLoops.Task9_Multipes;

public class Task9Multiples
{
    public void Run()
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 50);
        int result = 0;
        
        while (result <= 150)
        {
            result += number;
            if (result >= 50 && result <= 150)
            {
                Console.WriteLine(result);
            }
        }
    }
}