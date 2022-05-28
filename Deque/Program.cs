using Deque;

Deque<string> usersDeck = new Deque<string>();
Console.WriteLine("\n Пробуем удалить конец из пустого массива \n");
usersDeck.RemoveFirst();
Console.WriteLine("\n Пробуем удалить начало из пустого массива \n");
usersDeck.RemoveLast();
Console.WriteLine("\n Добавление Катя в начало \n");
usersDeck.AddFirst("Катя");
foreach (string s in usersDeck)
    Console.WriteLine(s);
Console.WriteLine("\n Добавление Маша в конец \n");
usersDeck.AddLast("Маша");
foreach (string s in usersDeck)
    Console.WriteLine(s);
Console.WriteLine("\n Добавление Саша в конец \n");
usersDeck.AddLast("Саша");
foreach (string s in usersDeck)
    Console.WriteLine(s);
Console.WriteLine("\n Добавление Семён в начало \n");
usersDeck.AddFirst("Семён");

foreach (string s in usersDeck)
    Console.WriteLine(s);

usersDeck.RemoveFirst();

Console.WriteLine("\n Удален: первый элемент \n");
foreach (string s in usersDeck)
    Console.WriteLine(s);




usersDeck.RemoveLast();
Console.WriteLine("\n Удален: последний элемент \n");
foreach (string s in usersDeck)
    Console.WriteLine(s);

Console.WriteLine($"\n Кол-во элементво: {usersDeck.Count}\n");

Console.WriteLine($"\n Очистка Дека\n");
usersDeck.Clear();
Console.WriteLine($"\n Кол-во элементво: {usersDeck.Count}\n");
