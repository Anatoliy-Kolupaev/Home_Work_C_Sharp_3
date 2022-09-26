
Console.Write("Введите любое число: ");
int user_number = int.Parse(Console.ReadLine());
for (int i = 1; i <= user_number ; i++)
{
    Console.Write(Math.Pow (i , 3)+" "); 
}
