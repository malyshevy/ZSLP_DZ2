//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите 3х значное число");
int num = int.Parse(Console.ReadLine());
while ((-100<num && num<100)||num>999||num<-999)
{
    Console.WriteLine("Введите 3х значное число");
    num = int.Parse(Console.ReadLine());
}
Console.Write($"Вторая цифра числа {num} -> {Math.Abs((num/10)%10)}");
