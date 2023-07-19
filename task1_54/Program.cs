

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 10, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 415, 2, 4 }
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            // Сортировка элементов текущей строки по убыванию
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        // Обмен элементов местами
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        Console.WriteLine("Упорядоченный двумерный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
