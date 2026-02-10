namespace Arrays.Task5_RepeatedSubarray;

public class Task5RepeatedSubarray
{
    public void Run()
    {
        int[] numbersArray = new int[30]
        {
            5, 5,
            9, 9, 9,
            3,
            7, 7,
            2, 2, 2, 2,
            8,
            6, 6, 6,
            1,
            4, 4,
            10, 10, 10, 10, 10,
            3,
            90, 90, 90, 90, 90
        };

        int maxRepeatCount = 1;
        int maxRepeatNum = 0;
        int tempCount = 1;

        for (int i = 1; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] == numbersArray[i - 1])
            {
                tempCount++;
                if (tempCount > maxRepeatCount)
                {
                    maxRepeatCount = tempCount;
                    maxRepeatNum = numbersArray[i];
                }
            }
            else
            {
                tempCount = 1;
            }
        }

        Console.WriteLine($"Число {maxRepeatNum} повторяется {maxRepeatCount} раза подряд.");
    }
}