namespace ConditionalsAndLoops.Task2_ExitControll;

public class Task2ExitControll
{
    public void Run()
    {
        const string IsExit = "exit";
        bool isWork = true;

        while (isWork)
        {
            string inputText = Console.ReadLine();
            if (inputText == IsExit)
            {
                isWork = false;
                break;
            }
        }
    }
}