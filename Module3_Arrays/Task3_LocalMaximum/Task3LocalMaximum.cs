namespace Arrays.Task3_LocalMaximum;

public class Task3LocalMaximum
{
    public void Run()
    {
        int[] numbers =
        {
            5, 12, -3, 8, 0,
            17, 4, -9, 6, 11,
            2, 14, -1, 7, 10,
            9, -5, 13, 1, 16,
            18, -7, 15, 3, 19
        };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            else
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}