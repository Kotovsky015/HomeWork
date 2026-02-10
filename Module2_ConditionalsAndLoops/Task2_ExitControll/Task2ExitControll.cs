namespace ConditionalsAndLoops.Task2_ExitControll;

public class Task2ExitControll
{
    public void Run()
    {
        const string CurrentPassword = "exit";

        string userPassword = "";

        while (userPassword != CurrentPassword)
        {
            userPassword = Console.ReadLine();
        }
    }
}