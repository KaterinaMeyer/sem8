// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

class Program
{
    static void Main()
    {
        int n = 4; // размерность массива
        int[,] array = new int[n, n]; // создаем двумерный массив

        int value = 1; // начальное значение для заполнения
        int minRow = 0, maxRow = n - 1; // границы строк
        int minCol = 0, maxCol = n - 1; // границы столбцов

        while (value <= n * n)
        {
            // заполняем верхнюю строку слева направо
            for (int i = minCol; i <= maxCol; i++)
                array[minRow, i] = value++;

            // заполняем правый столбец сверху вниз
            for (int i = minRow + 1; i <= maxRow; i++)
                array[i, maxCol] = value++;

            // заполняем нижнюю строку справа налево
            for (int i = maxCol - 1; i >= minCol; i--)
                array[maxRow, i] = value++;

            // заполняем левый столбец снизу вверх
            for (int i = maxRow - 1; i > minRow; i--)
                array[i, minCol] = value++;

            // сдвигаем границы внутрь массива
            minRow++;
            minCol++;
            maxRow--;
            maxCol--;
        }

        // выводим массив на экран
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}