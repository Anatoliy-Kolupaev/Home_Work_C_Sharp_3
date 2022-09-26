
System.Console.WriteLine("Добрый день!");
int n=0;
int v=100;
while(n < v)
{
    Console.Write("Выберите задачу которую хотите проверить (задачи пронумерованы 1, 2, 3,):  ");
    int choice = int.Parse(Console.ReadLine());
    while (choice == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        Console.WriteLine();
        if (choice == 1) task1(); 
        if (choice == 1) task1();
        if (choice == 1) task1();
        break;
        
    }
    while(choice == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        Console.WriteLine();
        if (choice == 2) task2(); 
        if (choice == 2) task2(); 
        if (choice == 2) task2(); 
        break;
    }
    while(choice == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        Console.WriteLine();
        if (choice == 3) task3();
        if (choice == 3) task3();
        if (choice == 3) task3();
        break;  
    }
    n++;
}

    void task1()
    {
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
    }       
    
    void task2()
    {
        int x1 = Coordinate("x", "A");
        int y1 = Coordinate("y", "A");
        int z1 = Coordinate("z", "A");
        int x2 = Coordinate("x", "B");
        int y2 = Coordinate("y", "B");
        int z2 = Coordinate("z", "B");

        int Coordinate(string coorName, string pointName)
        {
            Console.Write($"Введите координату {coorName} точки {pointName}: ");
            return Convert.ToInt16(Console.ReadLine());
        }
        double Decision(double x1, double x2, 
                        double y1, double y2, 
                        double z1, double z2)
        {
            return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                            Math.Pow((y2-y1), 2) + 
                            Math.Pow((z2-z1), 2));
        }
        double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
        Console.WriteLine($"Длина отрезка  {segmentLength}");     
    }
    void task3()
    {
        Console.Write("Введите любое число: ");
        int user_number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= user_number ; i++)
        {
            Console.Write(Math.Pow (i , 3)+" ");
        }
        Console.WriteLine();
    }
