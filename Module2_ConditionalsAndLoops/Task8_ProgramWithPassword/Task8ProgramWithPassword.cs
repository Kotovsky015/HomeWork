namespace ConditionalsAndLoops.Task8_ProgramWithPassword;

public class Task8ProgramWithPassword
{
    public void Run()
    {
        const string Password = "123Test!";

        int maxAttempts = 3;
        bool isWork = true;

        string userInput;
        
        while (isWork)
        {
            maxAttempts--;

            Console.Write("Введите пароль:");
            userInput = Console.ReadLine();

            if (userInput == Password)
            {
                Console.WriteLine("Верный пароль");
                isWork = false;
            }
            else if (maxAttempts == 0)
            {
                isWork = false;
            }

            Console.WriteLine($"Не верный пароль. Осталось попыток {maxAttempts}");
        }
    }
}