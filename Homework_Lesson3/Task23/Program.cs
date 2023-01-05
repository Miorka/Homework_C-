Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число\tКвадрат");
for(int i = 1; i <= n; i++)
{
    int a = i*i*i;
    Console.WriteLine("{0}\t{1}", i, a);
}
