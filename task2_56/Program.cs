// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 1, 2, 2, 1 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minRowSum = int.MaxValue;
        int minRow = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < cols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRow = i;
            }
        }

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");
    }
}
