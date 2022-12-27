/* Задача 19.
Написать программу, которая на вход принимает пятизначное число и проверяет, является ли оно полидромом
14212 - нет
23432 - да
12821 - да
*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num01 = number / 10000 % 10;
int num02 = number / 1000 % 10;
int num04 = number / 10 % 10;
int num05 = number % 10;
//Console.WriteLine($"{num01}, {num02}, {num04}, {num05}");

string str = number.ToString();
int n = str.Length;

if (n == 5) 
{
    if (num01 ==  num05 & num02 == num04)
    {
        Console.WriteLine($"да, число {number} является полидромом");    
    }
    else
    {
        Console.WriteLine($"нет, число {number} не является полидромом");
    }
}
else
{
    Console.WriteLine($"введено не пятизначное число");
}