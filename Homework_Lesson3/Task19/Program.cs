Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);
if (num.Length == 5)
{
    if (num[0] == num[4] & num[1] == num[3])
    {
        Console.WriteLine("Число является палиндромом");
        }
    else 
    {
        Console.WriteLine("Число является не палиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}