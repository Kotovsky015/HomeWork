namespace ConditionalsAndLoops.Task2_ExitControll;

public class Task2ExitControll
{
    public void Run()
    {
        const string IsExit = "exit";

        while (true)
        {
            string inputText = Console.ReadLine();
            if (inputText == IsExit)
            {
                break;
            }
        }
    }
}