// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int znach2 = Convert.ToInt32(Console.ReadLine());
int Length2 = znach2.ToString().Length;
if(Length2 >= 3)
{
    while (znach2 > 999)
    {
        znach2 = znach2 / 10;
    }
    int result = znach2 % 10;
    Console.WriteLine("Третье число - " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}