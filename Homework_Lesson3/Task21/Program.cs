int[] point = new int[6];
Console.WriteLine("Введите x1");
point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у1");
point[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
point[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2");
point[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у2");
point[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
point[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Sqrt(Math.Pow(point[3] - point[0], 2) + Math.Pow(point[4] - point[1], 2) + Math.Pow(point[2] - point[5], 2)));