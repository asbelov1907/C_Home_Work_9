// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return Akkerman(n - 1, 1);
    else if (n > 0 && m > 0)
        return Akkerman(n - 1, Akkerman(n, m - 1));
    else return 0;
}

Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
    int result = Akkerman(n, m); 
    Console.WriteLine(result);
