// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.WriteLine("Введите трехзначное число.Выхода из программы команда Exit.");
//    while(true)
//    {
//        string input = Console.ReadLine();
//        if(!input.Equals("exit"))
//            Console.WriteLine("{0}->{1}",input, input[1]);
//        else
//            break;
//    }

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

// int ThirdDigit(int number)
//   {
//    int result = -1;
//    if (number >= 100)
//    {
//        while (number > 999)
//            {
//                number = number / 10;
//            }
//        result = number % 10;
//    }
//        return result; 
//    }
 
//Console.Write("Введите число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
 
//if (ThirdDigit(number1) == -1)
//Console.WriteLine("третьей цифры нет");
//else
//Console.WriteLine($"Третье число: {ThirdDigit(number1)}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string msg)
{

System.Console.WriteLine((msg));
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check(int number)
{
if (number >= 6 && number < 8) ss = "-> Да";
if (number >= 1 && number < 7) ss = "-> Нет";
return ss;
}
System.Console.WriteLine(check(number));
