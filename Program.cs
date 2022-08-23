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


/*
"В институте биоинформатики по офису передвигается робот. Недавно студенты из группы 
программистов написали для него программу, по которой робот, когда заходит в комнату,
 считает количество программистов в ней и произносит его вслух: "n программистов".
Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
выводящее это число в консоль вместе с правильным образом изменённым словом "программист",
 для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
В комнате может быть очень много программистов. Проверьте, что ваша программа правильно 
обработает все случаи, как минимум до 1000 человек." */

void KindOfProgrammer(int n)
{
    if (n == 11) Console.WriteLine($"{n} програмистов");
    else if (n%100 == 11) Console.WriteLine($"{n} програмистов");

    else if (n == 12) Console.WriteLine($"{n} програмистов");
    else if (n == 13) Console.WriteLine($"{n} програмистов");
    else if (n == 14) Console.WriteLine($"{n} програмистов");

    else if (n%100 == 12) Console.WriteLine($"{n} програмистов");
    else if (n%100 == 13) Console.WriteLine($"{n} програмистов");
    else if (n%100 == 14) Console.WriteLine($"{n} програмистов");
    
    else if (n%10 == 1) Console.WriteLine($"{n} програмист");
    else if (n%10 == 2) Console.WriteLine($"{n} програмиста");
    else if (n%10 == 3) Console.WriteLine($"{n} програмиста");
    else if (n%10 == 4) Console.WriteLine($"{n} програмиста");
  
    else  Console.WriteLine($"{n} програмистов");
}
Console.WriteLine("Please, input a number");
int n = Convert.ToInt32(Console.ReadLine());

KindOfProgrammer(n);

KindOfProgrammer(1); 
KindOfProgrammer(11); 
KindOfProgrammer(111); 
KindOfProgrammer(2); 
KindOfProgrammer(12); 
KindOfProgrammer(22); 
KindOfProgrammer(122); 
KindOfProgrammer(16786); 
KindOfProgrammer(1143432211); 