namespace Module4_Functions.Task1_ReadInt;

public class Task1ReadInt
{
    public void Run()
    {
        int number = ReadInt();
        Console.WriteLine($"Result: {number}");
    }

    int ReadInt()
    {
        bool isRun = true;
        int result = 0;

        while (isRun)
        {
            string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out int number))
            {
                Console.WriteLine("Input number is not a number.");
            }
            else
            {
                result = number;
                isRun = false;
            }
        }

        return result;
    }
}