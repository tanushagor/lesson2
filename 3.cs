using System;

public class Tasks
{
    public static void Main(string[] args)
    {
       int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int sum = int.MaxValue;
        int rowIndex = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int currentSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < sum)
            {
                sum = currentSum;
                rowIndex = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой элементов: {rowIndex}");
        Console.WriteLine("Матрица:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}