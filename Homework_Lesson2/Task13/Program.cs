Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
string num = Convert.ToString(number);

if (num.Length > 2)
{
 Console.WriteLine(num[2]);   
}
else
Console.WriteLine("Третьей цифры нет");
