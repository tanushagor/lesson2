using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        int[,] array = new int[,] 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        Console.Write("Введите позицию элемента в двумерном массиве через пробел (например, 0 1): ");
        string[] input = Console.ReadLine().Split(' ');
        
        int row = int.Parse(input[0]);
        int column = int.Parse(input[1]);
        
        int rowsCount = array.GetUpperBound(0) + 1;
        int columnsCount = array.GetUpperBound(1) + 1;
        
        if (row >= 0 && row < rowsCount && column >= 0 && column < columnsCount)
        {
            int element = array[row, column];
            Console.WriteLine("Значение элемента: " + element);
        }
        else
        {
            Console.WriteLine("Элемент с такой позицией не существует.");
        }
    }
}