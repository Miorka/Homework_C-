// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = InputNumber("Введите количество строк: = ");
int n = InputNumber("Введите количество столбцов: = ");
int[,] arr = new int[m,n];
Random rand = new Random();

RandonArr(arr);
PrintArr(arr);
double[] avg= new double[arr.GetLength(1)];
for (int i = 0; i < arr.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        result += arr[j, i];
    }
    avg[i] = Math.Round((result / arr.GetLength(0)), 1);
}
Console.WriteLine(string.Join("; ", avg));

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