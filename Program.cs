void Zadacha19()
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    Console.Write("Введите пятизачное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (num > 9999 && num < 100000)
    {
        int result1 = num /10000;
        Console.WriteLine($"Первая цифра числа: {num} являетеся {result1}.");
        int result2 = num % 10;
        Console.WriteLine($"Пятая цифра числа: {num} являетеся {result2}.");
        
        if (result1 == result2)
        {
            Console.WriteLine();
            Console.WriteLine($"Первая цифра {result1} идентична пятой цифре {result2}, продолжаем проверку является ли число {num} палиндромом.");
            Console.WriteLine();
            result1 = num /1000 % 10;
            Console.WriteLine($"Вторая цифра числа: {num} являетеся {result1}.");
            result2 = num % 100 / 10;
            Console.WriteLine($"Четвертая цифра числа: {num} являетеся {result2}.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Первая цифра {result1} не идентична пятой цифре {result2}!");
            Console.WriteLine();
            Console.WriteLine($"Число {num}: не являтея палиндромом!");
        }
        if (result1 == result2)
        {
            Console.WriteLine();
            Console.WriteLine($"Вторая цифра {result1} идентична четвёртой цифре {result2}.");
            Console.WriteLine();
            int thd = num / 100 % 10;
            Console.WriteLine($"Так как число {num} явлется пятизначным, третья цифра {thd} является общей.");
            Console.WriteLine();
            Console.WriteLine($"Число {num}: являтея палиндромом!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Вторая цифра {result1} не идентична четвёртой цифре {result2}.");
            Console.WriteLine();
            Console.WriteLine($"Число {num}: не являтея палиндромом!");
        } 
    }
    else 
    {
        Console.WriteLine($"Введенное число {num} не является пятизначным, введите корректное число!");
    }
}

// Zadacha19();

void Zadacha21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    Console.WriteLine("Введите координаты первой точки в пространстве: A (xa, ya, za)");
    Console.Write("xa = ");
    int xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("ya = ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("za = ");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Заданы координаты первой точки: A = ({xa}, {ya}, {za})");
    Console.WriteLine();

    Console.WriteLine("Введите координаты второй точки в пространстве: B (xb, yb, zb)");
    Console.Write("xb = ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("yb = ");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.Write("zb = ");
    int zb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Заданы координаты второй точки в пространстве: B = ({xb}, {yb}, {zb})");
    Console.WriteLine();
    Console.WriteLine($"Вычисляем расстояние между двух точек в пространтсве по заданным координатам: A({xa}, {ya}, {za}); B({xb}, {yb}, {zb})");
    Console.WriteLine();

    double Distance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) // создал метод  на вычисления расстояния
    {
        int resultA = (arg1 - arg4) * (arg1 - arg4);
        int resultB = (arg2 - arg5) * (arg2 - arg5);
        int resultC = (arg3 - arg6) * (arg3 - arg6);
        double resultD = Math.Sqrt(resultA + resultB + resultC);
        double result = Math.Round(resultD, 2);

        Console.WriteLine($"Расстояние межде двух точек в пространстве: ('A' и 'В') по заданным координатам = {result}");
        return result;
    }
    Distance(xa, ya, za, xb, yb, zb);
}

// Zadacha21();

void Zadacha23()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.Write("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}:");
    Console.WriteLine();
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i} в степени 3 = ");
        int rezult = i * i * i;
        Console.WriteLine(rezult);
    }
}

// Zadacha23();


