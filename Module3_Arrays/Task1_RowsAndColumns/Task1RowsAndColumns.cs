namespace Arrays.Task1;

public class Task1RowsAndColumns
{
    public void Run()
    {
        int[,] matrix = new int[2, 3]
        {
            { 10, 20, 30 },
            { 40, 50, 60 }
        };

        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;

        int derivativeSum = 1;
        int sumOfSecondRow = 0;

        for (int i = 0; i < rows; i++)
        {
            derivativeSum *= matrix[i, 0];

            for (int j = 0; j < columns; j++)
            {
                if (i == 1)
                {
                    sumOfSecondRow += matrix[i, j];
                }
            }
        }

        Console.WriteLine(derivativeSum);
        Console.WriteLine(sumOfSecondRow);
    }
}