namespace ConditionalsAndLoops.Task3_Sequence;

public class Task3Sequence
{
    //While выбран в задаче так как не указано количество итераций или нужное число.
    public void Run()
    {
        int number = 7;
        int startNumber = 5;

        while (true)
        {
            startNumber += number;
            Console.WriteLine(startNumber);
        }
    }
}