//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число ");

int myNum = int.Parse(Console.ReadLine());

if (myNum % 2 == 0)
{
    System.Console.WriteLine("Ваше число " + myNum + " чётное");
}
else
{
    System.Console.WriteLine("Ваше число " + myNum + " нечётное");
}
Console.ReadLine();