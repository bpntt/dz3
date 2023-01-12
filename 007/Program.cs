Console.WriteLine("write Your number");
int a = Convert.ToInt32 (Console.ReadLine());
Faas(a);
void Faas(int b)
{
int index = 1;

    while (index < a)
    {
        Console.WriteLine($"{index} -> {index * index * index}");
        index++;
    }
    
}
