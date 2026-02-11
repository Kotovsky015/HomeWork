namespace Arrays.Task4_DynamicArray;

public class Task4DynamicArray
{
    public void Run()
    {
        const string SUM = "SUM";
        const string EXIT = "EXIT";

        int[] array = new int[0];
        bool isRunning = true;

        while (isRunning)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Текущие числа:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Выйти из приложения: EXIT");
            Console.WriteLine("Вывести сумму: SUM");
            Console.Write("Введите цифру:");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case SUM:
                    int sum = 0;
                    
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i];
                    }

                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"Сумма: {sum}");
                    break;

                case EXIT:
                    isRunning = false;
                    break;
                
                default:
                    Console.WriteLine("Такой команды нет.");
                    break;
            }

            int convertedInput = Convert.ToInt32(userInput);
            int[] tempArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = convertedInput;
            array = tempArray;
        }
    }
}