namespace Module4_Functions.Task3_KansasCityShuffle;

public class Task3KansasCityShuffle
{
    public void Run()
    {
        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ShuffleArray(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    void ShuffleArray(int[] array)
    {
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            int randomRange = rnd.Next(array.Length);
            int temp = array[i];
            array[i] = array[randomRange];
            array[randomRange] = temp;
        }
    }
}