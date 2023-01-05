Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 & number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной день");
        }
    else
    {
        Console.WriteLine("Будний день");
        }
}
else
    {
        
         Console.WriteLine("Не верно задан номер дня недели");   
        
    }        
    

