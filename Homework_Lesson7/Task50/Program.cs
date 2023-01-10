// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = InputNumber("Введите индекс строки: = ");
int n = InputNumber("Введите индексстолбца: = ");
int[,] arr = new int[4,6];
Random rand = new Random();

RandonArr(arr);
PrintArr(arr);
Find(arr, m, n);

int InputNumber(string text)
{
 Console.Write(text);
int number = Convert.ToInt32(Console.ReadLine());  
return number; 
}

void RandonArr(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArr(int[,] array)
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

void Find(int[,] array, int m, int n)
{
    if (m < array.GetLength(0) && n < array.GetLength(1))
    {
        Console.WriteLine(array[m, n]);
    }
    else
    {
        Console.WriteLine("Такого элемента в данном массиве нет");
    }
}
