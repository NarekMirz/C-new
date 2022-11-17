//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите два числа");
int num1,num2;
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    System.Console.WriteLine("max = " + num1);
}
else
{
    System.Console.WriteLine("max = " + num2);
}
Console.ReadLine();