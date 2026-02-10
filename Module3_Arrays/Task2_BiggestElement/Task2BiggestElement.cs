namespace Arrays.Task2_BiggestElement;

public class Task2BiggestElement
{
    public void Run()
    {
        int[,] originalMatrix = new int[10, 10]
        {
            { 5, 12, 7, 9, 3, 8, 6, 4, 10, 11 },
            { 14, 2, 8, 6, 1, 5, 9, 7, 3, 4 },
            { 6, 9, 4, 8, 12, 10, 5, 1, 7, 2 },
            { 3, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
            { 4, 7, 2, 6, 9, 5, 8, 10, 11, 12 },
            { 9, 8, 7, 6, 5, 4, 3, 2, 1, 14 },
            { 10, 11, 12, 13, 14, 6, 7, 8, 9, 5 },
            { 1, 3, 5, 7, 9, 11, 13, 20, 6, 2 },
            { 2, 4, 6, 8, 10, 12, 14, 5, 7, 9 },
            { 14, 6, 8, 10, 12, 7, 20, 3, 20, 11 }
        };

        int rows = originalMatrix.GetUpperBound(0) + 1;
        int columns = originalMatrix.Length / rows;
        int maxNumber = 0;

        //Вывести исходную матрица. Найти максимальное число.
        Console.WriteLine("Исходная матрица");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (originalMatrix[i, j] > maxNumber)
                {
                    maxNumber = originalMatrix[i, j];
                }

                Console.Write($"{originalMatrix[i, j]} ");
            }

            Console.WriteLine();
        }

        //Модифицировать матрицу "Найти наибольший элемент матрицы A(10,10) и записать "0" в те ячейки, где он находятся"
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (originalMatrix[i, j] == maxNumber)
                {
                    originalMatrix[i, j] = 0;
                }
            }
        }

        //Вывести модифицированную матрицу.
        Console.WriteLine();
        Console.WriteLine("Модифицированная матрица");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{originalMatrix[i, j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Наибольший элемент в матрице: {maxNumber}");
    }
}