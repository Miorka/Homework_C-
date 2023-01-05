Console.WriteLine("Введите 3 числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int numberMax = numberA;

if (numberMax < numberB)
{
    numberMax = numberB;
}

if ( numberMax < numberC)
{
    numberMax = numberC;
}

Console.WriteLine(numberMax);
