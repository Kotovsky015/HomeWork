namespace ConditionalsAndLoops.Task2_ExitControll;

public class Task2ExitControll
{
    public void Run()
    {
        string inputText;

        while (true)
        {
            inputText = Console.ReadLine();
            if (inputText == "exit")
            {
                break;
            }
        }
    }
}