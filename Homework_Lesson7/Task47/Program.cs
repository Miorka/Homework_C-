// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = InputNumber("Введите количество строк M =");
int n = InputNumber("Введите количество столбцов N =");
double[,] arr = new double[m,n];
Random rand = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = Convert.ToDouble(rand.Next(-100, 100)/10.0);
        System.Console.Write(arr[i,j] + " ");
    }
    System.Console.WriteLine();
}

int InputNumber(string text)
{
 Console.Write(text);
int number = Convert.ToInt32(Console.ReadLine());  
return number; 
}

