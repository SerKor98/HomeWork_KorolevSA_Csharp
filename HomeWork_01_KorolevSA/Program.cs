//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Введите число a: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = int.Parse(Console.ReadLine());

//if (a > b)
//{
//    Console.Write("max = ");
//    Console.WriteLine(a);
//}
//else
//{
    //Console.Write("max = ");
    //Console.WriteLine(b);
//}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.WriteLine("Введите число a: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число b: ");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите число c: ");
//int c = int.Parse(Console.ReadLine());

//int max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//Console.Write("->");
//Console.WriteLine(max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//Console.WriteLine("Введите число");
//int number = int.Parse(Console.ReadLine());
//if (number % 2 == 0)
//{
    //Console.WriteLine($"{number} -> да");  
//}
//else
//{
    //Console.WriteLine($"{number} -> нет");  
//};

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
for (int index = 2; index <= number; index = index + 2)
{
    {
        Console.Write($"{index} ");
    };
}
Console.WriteLine();