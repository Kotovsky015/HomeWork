using System.Globalization;

namespace Arrays.Task8_ShiftArrayElements;

public class Task8ShiftArrayElements
{
    public void Run()
    {
        int[] numbersArray =
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        string inputRepeatCount = Console.ReadLine();
        int count = Convert.ToInt32(inputRepeatCount);

        for (int i = 0; i < count; i++)
        {
            for (int j = 1; j < numbersArray.Length; j++)
            {
                int temp = numbersArray[j];
                numbersArray[j] = numbersArray[j - 1];
                numbersArray[j - 1] = temp;
            }
        }

        foreach (int number in numbersArray)
        {
            Console.Write($" {number}");
        }
    }
}