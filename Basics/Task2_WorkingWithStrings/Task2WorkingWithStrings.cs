namespace ConsoleApp.Task2_WorkingWithStrings;

public class Task2WorkingWithStrings
{
    int age;
    string name;
    string zodiac;
    string work;

    public void Run()
    {
        Interview();
        ShowInfo();
    }

    private void Interview()
    {
        Console.WriteLine("Как вас зовут ?");
        name = Console.ReadLine();

        Console.WriteLine("Сколько вам лет ?");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Какой ваш знак зодиака ?");
        zodiac = Console.ReadLine();

        Console.WriteLine("Где вы работаете ?");
        work = Console.ReadLine();
    }

    private void ShowInfo()
    {
        Console.WriteLine($"Вас зовут {name}, вам {age}, вы {zodiac} и работаете на {work}.");
    }
}