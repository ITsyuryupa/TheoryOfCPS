using System.Numerics;

Console.WriteLine("Введите большое число");
BigInteger BigInt = BigInteger.Parse(Console.ReadLine());

Console.WriteLine("Введите число типа uint:");
uint Num = uint.Parse(Console.ReadLine());

Console.WriteLine(BigInt * Num);