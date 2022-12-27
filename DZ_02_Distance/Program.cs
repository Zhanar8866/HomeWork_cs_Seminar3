/* Задача 21.
Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
A(3,6,8) B(2,1,-7) - 15.84
A(7,-5,0) B(1,-1,9) - 11.53
*/

Console.Write("Введите значение Ax, Ay, Az: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Bx, By, Bz: ");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(Ax-Bx,2) + Math.Pow(Ay-By,2) + Math.Pow(Az-Bz,2));
Console.WriteLine($"d={d:f2}"); //f2 - означает, что вывести 2 значения после запятой