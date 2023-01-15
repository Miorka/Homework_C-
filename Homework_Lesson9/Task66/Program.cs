// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int N = InputNumber("Введите число N: = ");
int M = InputNumber("Введите число M: = ");

if (N > M)
{
    int D = N;
    N = M;
    M = D;
}
Console.WriteLine(Recursion(N - 1, M));

int Recursion(int i, int j)
{
    if (i == j)
    {
        return 0;
    }
    else
    {
        i++;
        int result = Recursion(i, j) + i;
        return result;
    }
}

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