// See https://aka.ms/new-console-template for more information

string input = " ";

List<int> arr = new List<int>();

Console.WriteLine("Заполнение массива(если хотите закончить просто нажмите enter)");
while (true)
{
    Console.Write("Введите эелемент: ");
    input = Console.ReadLine();
    if (input == "")
    {
        break;
    }
    arr.Add(int.Parse(input));
}
Console.WriteLine();

Console.WriteLine("Введите N:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();


Console.WriteLine("Изначальный массив");
for (int i = 0; i < arr.Count; i++)
{
    
    Console.WriteLine($"{i}: {arr[i]}");
}
Console.WriteLine();

for (int i = 0; i < arr.Count; i++)
{
    if (arr[i] % n == 0)
    {
        arr.RemoveAt(i);
    }
}

Console.WriteLine("Конечный массив");
for (int i = 0; i < arr.Count; i++)
{
    
    Console.WriteLine($"{i}: {arr[i]}");
}