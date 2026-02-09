namespace ConditionalsAndLoops.Task2_ExitControll;

public class Task2ExitControll
{
    public void Run()
    {
        const string IsExit = "exit";

        string inputText = "";

        while (inputText != IsExit)
        {
            inputText = Console.ReadLine();
        }
    }
}