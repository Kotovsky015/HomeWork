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

        int columnsNum = 0;
        int rowsNum = 1;
        int derivativeSum = 1;
        int sumSecondRow = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            derivativeSum *= matrix[i, columnsNum];

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == rowsNum)
                {
                    sumSecondRow += matrix[i, j];
                }
            }
        }

        Console.WriteLine(derivativeSum);
        Console.WriteLine(sumSecondRow);
    }
}