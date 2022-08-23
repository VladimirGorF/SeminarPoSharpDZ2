/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
 показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine ("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int x = a/10;
Console.WriteLine (x%10);
*/


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
void Third(int number)
{
    if (number < 100)
     Console.WriteLine ("Третьей цифры нет");
    else 
    {
        if (number >99 && number < 1000) Console.WriteLine (number%10);
        else 
        {
            int i = number;
            while (i > 99)
            {
                if(i < 1000) Console.WriteLine (i%10);
                i = i/10;
            } 
        }  
    }
}


Third(123456754);
Third(23);
Third(789);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
Console.WriteLine("HolidayCheck");
void Holiday(int number)
{
    if (number >5) Console.WriteLine($"{number} day - is a holiday");
    else Console.WriteLine($"{number} day - is Not a holiday");
}
Console.WriteLine("Please, input a number");
int number=Convert.ToInt32(Console.ReadLine());
Holiday(number);
Holiday(4);
Holiday(6);
Holiday(7);
*/