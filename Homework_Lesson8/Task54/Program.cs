// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = InputNumber("Введите количество строк: = ");
int n = InputNumber("Введите количество столбцов: = ");
int[,] arr = new int[m, n];

FillArr(arr);
Print2DArr(arr);
Sort(arr);
Console.WriteLine();
Print2DArr(arr);

int InputNumber(string str)
{
int number;
string text;

while (true)
{
System.Console.Write(str);
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break;
}
System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}

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

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}