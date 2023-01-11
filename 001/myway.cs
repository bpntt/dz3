Console.WriteLine("Введите координату X");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y");
double y = Convert.ToDouble(Console.ReadLine());
if (x == 0 || y == 0)
{
    Console.WriteLine("Недопустимые значения X,Y");
}
if (x  > 0 || y > 0 )
{
    Console.WriteLine("1/4");
    return;
}
if (x  > 0 || y < 0 )
{
    Console.WriteLine("4/4");
    return;
}
if (x < 0 || y < 0 )
{
    Console.WriteLine("3/4");
    return;
}
if (x < 0 || y > 0 )
{
    Console.WriteLine("2/4");
    return;
}