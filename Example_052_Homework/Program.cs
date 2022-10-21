﻿//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



static int[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRansomValue);
        }
    }
    return randomArray;
}

static void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

static double[] GetAverageArray(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];

    for (int column = 0; column < averageArray.Length; column++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            averageArray[column] += array[row, column];
        }
        averageArray[column] = Math.Round(averageArray[column] / array.GetLength(0), 1);
    }
    return averageArray;
}


Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRansomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRansomValue);

Console.Clear();
PrintArray(array);

Console.WriteLine();

double[] average = GetAverageArray(array);
Console.WriteLine($"Average for every column is: {String.Join("; ", average)}");
