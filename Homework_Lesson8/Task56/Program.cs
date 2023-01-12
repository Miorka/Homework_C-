// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] arr = new int[4, 6];

FillArr(arr);
Print2DArr(arr);
StringMinSum(arr);


void FillArr(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void StringMinSum(int[,] array)
{
    int minString = 0;
    int minSumString = 0;
    int sumString = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minString += array[0, i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            sumString += array[i, j];
        }
        if (sumString < minString)
        {
            minString = sumString;
            minSumString = i;
        }
        sumString = 0;
    }
    Console.Write($"{minSumString + 1} строка");
}