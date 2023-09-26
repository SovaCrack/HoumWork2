// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа. 
Console.WriteLine("Введите трехзначное число: ");
int znach = Convert.ToInt32(Console.ReadLine());
int Length = znach.ToString().Length;
if(Length == 3)
{
    int result = (znach / 10) % 10;
    Console.WriteLine("Второе число - "  + result);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}