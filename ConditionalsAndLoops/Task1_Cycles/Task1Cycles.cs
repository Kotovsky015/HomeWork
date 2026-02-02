namespace ConditionalsAndLoops.Task1_Cycles;

public class Task1Cycles
{
    public void Run()
    {
        string inputText;
        inputText = Console.ReadLine();

        int countRepeat = 0;
        countRepeat = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < countRepeat; i++)
        {
            Console.Write(inputText);
        }
    }
}