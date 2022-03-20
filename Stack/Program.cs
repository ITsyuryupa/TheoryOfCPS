// See https://aka.ms/new-console-template for more information
Stack<double> nums = new Stack<double>();
//Stack<double> nums = new Stack<double>(new double[] { 1,2,3,4,5});
Stack<double> numHelp = new Stack<double>();

Stack<string> str = new Stack<string>();
Stack<string> strHelp = new Stack<string>();

string input = "help";

Console.WriteLine("Выберете режим работы 0/1(double/string)");
int mood = 3;
while (mood != 0 && mood != 1)
{
    mood = int.Parse(Console.ReadLine());
    Console.WriteLine("Выберете режим работы 0/1(double/string)");
}
Console.Clear();

Console.WriteLine($"Далее ожидаются только команды (режим работы{mood})"); 

while (input != "\\")
{
    
    Reader(input, mood);
    input = Console.ReadLine();
}

bool CheckPrime(double num)
{
    if (num == 1) return false;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }

    return true;    
}
void revers(ref Stack<double> s)
{
    int length = 0;
    numHelp = new Stack<double>();
    length = s.Count;
    for (int i = 0; i < length; i++)
    {
        numHelp.Push(nums.Peek());
        s.Pop();
    }
    s = numHelp;
}

void reversStr(ref Stack<string> s)
{
    int length = 0;
    strHelp = new Stack<string>();
    length = s.Count;
    for (int i = 0; i < length; i++)
    {
        strHelp.Push(str.Peek());
        s.Pop();
    }
    s = strHelp;
}

void print<T>(Stack<T> s)
{
    foreach (var item in s)
    {
        Console.WriteLine(item);
    }
}

void Reader(string input, int mood)
{
    if (mood == 0)
    {
        int length = 0;
        int i = 0;
        switch (input)
        {
            case "help":
                Console.WriteLine(
                    "push - add elemet\n" +
                    "pop - delet peek\n" +
                    "count - show count element\n" +
                    "print\n" +
                    "clear - delet all element from stack\n" +
                    "popnint - delet non-int\n" +
                    "popn2 - delet odd\n" +
                    "popnp - delet non-prime\n" +
                    "revers - reverse stack\n" +
                    "printb - print bottom n element\n" +
                    "printpb - print peek and bottom\n"

                    );
                break;
            case "push"://add element
                Console.Write("< ");
                nums.Push(double.Parse(Console.ReadLine()));
                break;

            case "pop":
                if (nums.Count != 0) nums.Pop();
                break;

            case "count":
                Console.WriteLine(nums.Count());
                break;

            case "print":
                print(nums);
                break;

            case "clear":
                nums.Clear();
                break;

            case "popnint":// delet non-intenger
                numHelp = new Stack<double>();
                length = nums.Count;
                for (i = 0; i < length; i++)
                {
                    if (nums.Peek() % 1 == 0)
                    {
                        numHelp.Push(nums.Peek());
                    }
                    nums.Pop();
                }
                nums = numHelp;
                goto case "revers";

            case "popn2":
                numHelp = new Stack<double>();
                length = nums.Count;
                for (i = 0; i < length; i++)
                {
                    if (nums.Peek() % 2 == 0)
                    {
                        numHelp.Push(nums.Peek());
                    }
                    nums.Pop();
                }
                nums = numHelp;
                goto case "revers";

            case "popnp":
                numHelp = new Stack<double>();
                length = nums.Count;
                for (i = 0; i < length; i++)
                {
                    if (CheckPrime(nums.Peek()))
                    {
                        numHelp.Push(nums.Peek());
                    }
                    nums.Pop();
                }
                nums = numHelp;
                goto case "revers";

            case "revers":
                revers(ref nums);
                break;

            case "printb":// print last n element
                Console.Write("< ");
                int n = int.Parse(Console.ReadLine());
                length = nums.Count;

                i = 0;
                foreach (var item in nums)
                {
                    if (i >= length - n)
                    {
                        Console.WriteLine(item);
                    }
                    i++;
                }
                
                break;

            case "printpb":
                length = nums.Count;
                i = 0;
                foreach (var item in nums)
                {
                    if (i == length - 1 || i == 0)
                    {
                        Console.WriteLine(item);
                    }
                    i++;
                }

                break;

            default:
                Console.WriteLine("Неверная команда");
                break;
        }
    }

    if (mood == 1)
    {
        int length = 0;
        int i = 0;
        switch (input)
        {
            case "help":
                Console.WriteLine(
                    "push - add elemet\n" +
                    "pop - delet peek\n" +
                    "count - show count element\n" +
                    "print\n" +
                    "clear - delet all element from stack\n" +
                    "revers - reverse stack\n" +
                    "printb - print bottom n element\n" +
                    "printpb - print peek and bottom\n"

                    );
                break;
            case "push"://add element
                Console.Write("< ");
                str.Push(Console.ReadLine());
                break;

            case "pop":
                if (str.Count != 0) str.Pop();
                break;

            case "count":
                Console.WriteLine(str.Count());
                break;

            case "print":
                print(str);
                break;

            case "clear":
                str.Clear();
                break;

            case "revers":
                reversStr(ref str);
                break;

            case "printb":// print last n element
                Console.Write("< ");
                int n = int.Parse(Console.ReadLine());
                length = str.Count;

                i = 0;
                foreach (var item in str)
                {
                    if (i >= length - n)
                    {
                        Console.WriteLine(item);
                    }
                    i++;
                }

                break;

            case "printpb":
                length = str.Count;
                i = 0;
                foreach (var item in str)
                {
                    if (i == length - 1 || i == 0)
                    {
                        Console.WriteLine(item);
                    }
                    i++;
                }

                break;

            default:
                Console.WriteLine("Неверная команда");
                break;
        }
    }

}