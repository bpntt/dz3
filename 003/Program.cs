Console.WriteLine("Ввведите номер четверти");
int a = Convert.ToInt32(Console.ReadLine());
string Di = D (a);
Console.WriteLine($"{Di}");
string  D (int Z)
{
    if (a == 1) return "x > 0, y > 0";
    if (a == 2) return "x > 0, y < 0";
    if (a == 3) return "x < 0, y < 0";
    if (a == 4) return "x < 0, y > 0";
    return "not correct";
}
