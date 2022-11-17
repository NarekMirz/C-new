//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите три числа ");

int number1,number2,number3;

number1 = int.Parse(Console.ReadLine());
number2 = int.Parse(Console.ReadLine());
number3 = int.Parse(Console.ReadLine());

int max = number1;

if(max > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
System.Console.WriteLine("Максимальное = " + max);