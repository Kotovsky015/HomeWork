namespace Arrays.Task6_SortNumbers;

public class Task6SortNumbers
{
    public void Run()
    {
        int[] numbersArray =
        {
            12, 3, 19, 7, 1,
            16, 5, 14, 9, 2,
            18, 6, 11, 4, 20,
            8, 15, 10, 17, 13
        };

        for (int i = 0; i < numbersArray.Length; i++)
        {
            for (int j = i; j < numbersArray.Length; j++)
            {
                if (numbersArray[i] > numbersArray[j])
                {
                    int temp = numbersArray[i];
                    numbersArray[i] = numbersArray[j];
                    numbersArray[j] = temp;
                }
            }
        }
    }
}