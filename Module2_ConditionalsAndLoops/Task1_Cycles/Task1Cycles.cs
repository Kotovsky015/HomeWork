namespace ConditionalsAndLoops.Task1_Cycles;

public class Task1Cycles
{
    public void Run()
    {
        string inputText = Console.ReadLine();

        int countRepeat = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < countRepeat; i++)
        {
            Console.Write(inputText);
        }
    }
}