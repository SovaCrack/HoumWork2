//Напишите программу, которая на вход принимает цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if(day >= 1 && day <= 7)
{
    if(day >= 6)
    {
        Console.WriteLine("Выходной!!!");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Введите нужный день между 1 и 7 днем недели");
}