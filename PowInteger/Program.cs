// See https://aka.ms/new-console-template for more information

double RaisingRecBit(double x, double degree)
{
    if (degree == 0)
    {
        return 1;
    }
    if (degree % 2 == 1)
    {
        return RaisingRecBit(x, degree - 1) * x;
    }
    else
    {
        return RaisingRecBit(x, degree / 2) * RaisingRecBit(x, degree / 2);
    }
}



string s = " ";
while (s != "1")
{
    Console.Write("x = ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("степень = ");
    double degree = double.Parse(Console.ReadLine());

    if (degree >= 0)
    {
        Console.WriteLine(RaisingRecBit(x, degree));
    }
    else
    {
        degree = degree * (-1);
        Console.WriteLine(1 / RaisingRecBit(x, degree));
    }

    Console.Write("для выхода введите 1");
    s = Console.ReadLine();
}


