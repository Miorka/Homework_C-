Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
do 
{
    if ((count % 2) == 0)
    {
        Console.Write($"{count} ");
        
    }
    count++;
}
while (count <= number);