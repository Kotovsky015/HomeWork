using System.Globalization;

namespace Arrays.Task3_LocalMaximum;

public class Task3LocalMaximum
{
    public void Run()
    {
        int[] numbers =
        {
            12, 5, -3, 8, 0,
            17, 4, -9, 6, 11,
            2, 14, -1, 7, 10,
            9, -5, 13, 1, 16,
            18, -7, 15, 3, 19
        };
        int length = numbers.Length;

        if (numbers[0] > numbers[1])
        {
            Console.WriteLine(numbers[0]);
        }

        for (int i = 1; i < length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
            {
                Console.WriteLine(numbers[i]);
            }
        }

        if (numbers[length - 2] > numbers[length - 1])
        {
            Console.WriteLine(numbers[length - 2]);
        }
    }
}