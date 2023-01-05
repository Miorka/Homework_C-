
int n = inputNumber();

int s = 0;
while(n!=0)
{
    s = s + n % 10;
    n = n / 10;
}
Console.WriteLine("Сумма чисел равна: {0}",s);

int inputNumber()
{
int number;
string text;

while (true)
{
Console.Write("Введите число: ");
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break;
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}