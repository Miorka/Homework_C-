// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m1 = InputNumber("Введите количество строк первой матрицы: = ");
int n1 = InputNumber("Введите количество столбцов первой матрицы: = ");
int[,] arr1 = new int[m1, n1];
int m2 = InputNumber("Введите количество строк первой матрицы: = ");
int n2 = InputNumber("Введите количество столбцов первой матрицы: = ");
int[,] arr2 = new int[m2, n2];
int[,] arr3 = new int[m1, n2];

FillArr(arr1);
FillArr(arr2);
Console.WriteLine("Первый массив");
Print2DArr(arr1);
Console.WriteLine("Второй массив массив");
Print2DArr(arr2);
if (arr1.GetLength(0) == arr2.GetLength(1))
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            arr3[i, j] = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    Console.WriteLine("Произведение массивов");
    Print2DArr(arr3);
}
else
{
    Console.WriteLine(" Нельзя перемножить ");
}

Print2DArr(arr3);

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

