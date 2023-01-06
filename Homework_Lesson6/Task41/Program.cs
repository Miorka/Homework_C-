Console.Write("Введите числа через символ ';'': ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(';'), int.Parse);
 
Console.WriteLine($"Кол-во элементов больше 0: {Count(arr)}");

int Count(int[] array)
{
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
return count;
}