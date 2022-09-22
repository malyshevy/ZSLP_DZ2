//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num/100 == 0)
{
    Console.WriteLine($"Третьей цифры у числа {num} нет");
}
else
{
    int num2=num,
        num3=num2,
        num4=0;
    int i=1; 
    while (num3!=0)
    {
        num2=num3%10;
        num3=num3/10;
        num4=(num4*i)+num2;
        Console.WriteLine($"{num2} -- {num4}");
        i=10;
    }
    num2=(num4/100)%10;
    Console.WriteLine($"Третья цифра числа {num} -> {Math.Abs(num2)}");
}