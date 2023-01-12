//Math.Pow(1,10) квадрат числа при условии что первое число это само число а втрое его степень 
//Math.Sqrt(16) квадратный корень значаения double
//Math.Round(d, 2) где первое перменая которую округляем второе до какого количества знаков окрюгляется 
Console.WriteLine("Ввведите координаты первой точки");
Console.WriteLine("X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите координаты первой точки");
Console.WriteLine("X");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y");
int y2 = Convert.ToInt32(Console.ReadLine());
//double answer = D (x1, x2, y1, y2);
//Double D (double ans)
//{
int a = x1 + x2;
int b = y1 + y2;
double c = Math.Pow(a, 2);
double d = Math.Pow(b, 2);
int e = a + b;
double r = Math.Sqrt(e);
double f = Math.Round (r, 2);
//return f;
//}
Console.WriteLine(f );

