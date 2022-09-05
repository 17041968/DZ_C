//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
int a = 1;
int b = 12;
int c = 31;
int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.WriteLine(max);
