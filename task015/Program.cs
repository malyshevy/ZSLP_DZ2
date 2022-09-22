//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите порядковое число дня недели");
int num = int.Parse(Console.ReadLine());
while (num<1||num>7)
{
    Console.WriteLine("Введите порядковое число дня недели");
    num = int.Parse(Console.ReadLine());
}
if(num==6||num==7)
{
    Console.WriteLine($"{num} день является выходным");
}
else
{
    Console.WriteLine($"{num} день является рабочим");
}