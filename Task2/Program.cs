/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int m = Input("Введите M ");
int n = Input("Введите N ");

void SumMtoN(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"{sum}");
        return;
    }
    sum = sum + (m++);
    SumMtoN(m, n, sum);
}
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} = ");
SumMtoN(m, n, 0);

int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}