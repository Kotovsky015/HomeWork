namespace ConditionalsAndLoops.Task3_Sequence;

public class Task3Sequence
{
    public void Run()
    {
        int step = 7;
        int startNumber = 5;
        int maxNumber = 103;

        for (int sum = startNumber; sum <= maxNumber; sum+=step)
        {
            Console.WriteLine(sum);
        }
    }
}