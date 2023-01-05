int A = InputNumber("Введите число A");
int B = InputNumber("Введите степень для числа A");
Console.WriteLine(Math.Pow(A, B));


int InputNumber(string text)
{
 Console.WriteLine(text);
int number = Convert.ToInt32(Console.ReadLine());  
return number; 
}


