namespace ConditionalsAndLoops.Task7_NameOutput;

public class Task7NameOutput
{
    public void Run()
    {
        string userInput;
        Console.Write("Введи ваше имя:");
        userInput = Console.ReadLine();

        char inputSymbol;
        Console.Write("Введите символ:");
        inputSymbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            if (i == 1)
            {
                Console.Write($"{inputSymbol}{userInput}{inputSymbol}");
            }
            else
            {
                for (int j = 0; j < userInput.Length + 2; j++)
                {
                    Console.Write(inputSymbol);
                }
            }

            Console.WriteLine();
        }
    }
}