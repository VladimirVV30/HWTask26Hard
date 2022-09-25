// Напишите программу, которая принимает на вход число (целое или вещественное) и выдаёт количество цифр в числе.
// 456 -> 3
// 0.78 -> 2
// 89.126 -> 5


int SumNums (double N)
{
    int i = 0;
    double x = N;

    while (x % 1 > 0)
    {
        x = x * 10;
    }

    while (x > 0)
    {
        x = Convert.ToInt32(x / 10);
        i++;
    }
    return i;
}
try
{
    System.Console.Write("Введите число ");
    double a = Convert.ToDouble (Console.ReadLine());
    System.Console.WriteLine("Число "+ a +" состоит из "+ SumNums(a) +" цифр");

}
catch
{
    System.Console.WriteLine("Необходимо ввести число цифрами!");
}
