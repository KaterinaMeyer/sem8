// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

class Program
{
    static void Main()
    {
        int[,] matrix1 = new int[,]
        {
            { 2, 4 },
            { 3, 2 }
        };

        int[,] matrix2 = new int[,]
        {
            { 3, 4 },
            { 3, 3 }
        };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Невозможно умножить матрицы. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
            return;
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        Console.WriteLine("Результирующая матрица:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}