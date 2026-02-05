namespace ConditionalsAndLoops.Task5_ConsoleMenu;

public class Task5ConsoleMenu
{
    public void Run()
    {
        const string CommandShowText = "1";
        const string CommandRandomNumber = "2";
        const string CommandClearConsole = "3";
        const string CommandExit = "4";

        Random rnd = new Random();
        bool isWork = true;

        while (isWork)
        {
            Console.WriteLine($"{CommandShowText} - показать текст");
            Console.WriteLine($"{CommandRandomNumber} - случайное число");
            Console.WriteLine($"{CommandClearConsole} - очистить консоль");
            Console.WriteLine($"{CommandExit} - выход");

           string userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandShowText:
                    Console.WriteLine("Введите текст");
                    userInput = Console.ReadLine();
                    Console.WriteLine($"Ваш текст:{userInput}");
                    break;
                case CommandRandomNumber:
                    int rndNumberRange = rnd.Next(1, 1001);
                    Console.WriteLine($"Случайное число:{rndNumberRange}");
                    break;
                case CommandClearConsole:
                    Console.Clear();
                    break;
                case CommandExit:
                    isWork = false;
                    break;
            }
        }
    }
}