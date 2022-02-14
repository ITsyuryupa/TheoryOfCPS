// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

int Raising12Dumb(int x)
{
    return x * x * x * x * x * x * x * x * x * x * x * x;
}

int RaisingRec(int x, int degree)
{
    if (degree == 0)
    {
        return 1;
    }
    return x * RaisingRec(x, degree - 1);
}

int RaisingRecBit(int x, int degree)
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

Console.WriteLine("Введите X:");
int x = int.Parse(Console.ReadLine());


Stopwatch s = new Stopwatch();

double time1 = 0;
s.Start();
Console.WriteLine(Raising12Dumb(x));
s.Stop();
time1 = (double)s.ElapsedTicks;
Console.WriteLine($"Time = {s.ElapsedTicks}");
s.Reset();
Console.WriteLine();

double time2 = 0;
s.Start();
Console.WriteLine(RaisingRec(x, 12));
s.Stop();
time2 = (double)s.ElapsedTicks;
Console.WriteLine($"Time = {s.ElapsedTicks}");
s.Reset();
Console.WriteLine();

double time3 = 0;
s.Start();
Console.WriteLine(RaisingRec(x, 12));
s.Stop();
time3 = (double)s.ElapsedTicks;
Console.WriteLine($"Time = {s.ElapsedTicks}");
s.Reset();
Console.WriteLine();

Console.WriteLine($"3 способ быстрее 1 в { time1 / time3} раз");
Console.WriteLine($"3 способ быстрее 2 в { time2 / time3} раз");
Console.WriteLine($"2 способ быстрее 1 в { time1 / time2} раз");


