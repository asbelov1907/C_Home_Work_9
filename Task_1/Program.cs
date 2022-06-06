// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void SummNumber(int M, int N)
{
    int summ = 0;
    for (int i = M; i <= N; i++)
    {
        summ = summ + i;
        
    }
    Console.WriteLine("Сумма элементов в промежутке от M до N равна " + summ);
}

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
SummNumber(M,N);
