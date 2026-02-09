namespace ConditionalsAndLoops.Task8_ProgramWithPassword;

public class Task8ProgramWithPassword
{
    public void Run()
    {
        const string Password = "123Test!";

        int maxAttempts = 3;
        bool isCorrectPassword = true;
        string userInput;

        while (maxAttempts > 0 && isCorrectPassword == false)
        {
            maxAttempts--;

            Console.Write("Введите пароль:");
            userInput = Console.ReadLine();

            if (userInput == Password)
            {
                Console.WriteLine("Верный пароль");
                isCorrectPassword = true;
            }

            Console.WriteLine($"Не верный пароль. Осталось попыток {maxAttempts}");
        }
    }
}