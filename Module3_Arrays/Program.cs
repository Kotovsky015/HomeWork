using Arrays.Task1;
using Arrays.Task3_LocalMaximum;
using Arrays.Task5_RepeatedSubarray;
using Arrays.Task6_SortNumbers;
using Arrays.Task7_Split;
using Arrays.Task8_ShiftArrayElements;
using Arrays.Task9_ParentheticalExpression;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 2 };
        int[] tempArray = new int[array.Length * 2];

        for (int i = 0; i < array.Length; i++)
        {
            tempArray[i] = array[i];
        }

        for (int i = 0; i < tempArray.Length; i++)
        {
            Console.Write(tempArray[i]);
        }
       
    }
}