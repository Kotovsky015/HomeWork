namespace ConditionalsAndLoops.Task8_ProgramWithPassword;

public class Task8ProgramWithPassword
{
    public void Run()
    {
        const string Password = "123Test!";

        int maxAttempts = 3;

        string userInput;
        
        while (maxAttempts > 0)
        {
            maxAttempts--;

            Console.Write("Введите пароль:");
            userInput = Console.ReadLine();

            if (userInput == Password)
            {
                Console.WriteLine("Верный пароль");
            }
         
            Console.WriteLine($"Не верный пароль. Осталось попыток {maxAttempts}");
        }
    }
}