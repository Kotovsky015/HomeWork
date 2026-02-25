namespace Module5_Collections.Task3_DynamicArray;

public class Task3DynamicArray
{
    public void Run()
    {
        const string SUM_COMMAND = "SUM";
        const string EXIT_COMMAND = "EXIT";

        List<int> numberArray = new List<int>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Текущие числа:");

            foreach (var array in numberArray)
            {
                Console.Write($" {array}");
            }

            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"Выйти из приложения: {EXIT_COMMAND}");
            Console.WriteLine($"Вывести сумму: {SUM_COMMAND}");
            Console.Write("Введите цифру:");

            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int number))
            {
                numberArray.Add(int.Parse(userInput));
                continue;
            }

            switch (userInput)
            {
                case SUM_COMMAND:
                    ShowSum(numberArray);
                    break;

                case EXIT_COMMAND:
                    isRunning = false;
                    break;

                default:
                    ShowUnknownCommand();
                    break;
            }
        }
    }

    void ShowSum(List<int> numberArray)
    {
        int sum = 0;

        foreach (int number in numberArray)
        {
            sum += number;
        }

        Console.SetCursorPosition(0, 2);
        Console.WriteLine($"Сумма: {sum}");
    }

    void ShowUnknownCommand()
    {
        Console.WriteLine("Такой команды нет.");
        Console.ReadKey();
        Console.Clear();
    }
}