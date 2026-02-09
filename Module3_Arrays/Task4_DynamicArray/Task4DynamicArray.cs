namespace Arrays.Task4_DynamicArray;

public class Task4DynamicArray
{
    public void Run()
    {
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

            if (userInput == "SUM")
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                Console.SetCursorPosition(0, 2);
                Console.WriteLine($"Сумма: {sum}");
            }
            else if (userInput == "EXIT")
            {
                isRunning = false;
            }
            else
            {
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
}