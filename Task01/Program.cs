Console.Write("Введите пожалуйста пятизначное число: " );
int number = int.Parse(Console.ReadLine()); 
if (number < 0) number *=-1;
if (number > 9999 && number < 100000)
{
    int x = number % 100; // % - остаток от деления на 100
    int y = NumberOne (number, 2);
    if (x / 10 == y % 10 && x % 10 == y / 10)
    {
        System.Console.WriteLine( number + " Число является полиндром");
    }
    else System.Console.WriteLine(number + " Число не является полиндром");
} 
else Console.WriteLine("Вы ввели не правельное число! По пробуйте еще раз!");
int NumberOne(int num, int index) 
{
    while (num / Math.Pow(10, index) > 1)
    {
        num /= 10;
    }
    return num;
}