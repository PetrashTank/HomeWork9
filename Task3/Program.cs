/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int m = Input("Введите M ");
int n = Input("Введите N ");

if (n >= 4 || m >= 4) Console.Write($"число A({n},{m}) настолько велико, что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной");

else
{
    Console.WriteLine($"Функция Аккермана для чисел M({m},{n}) = {Akk(m, n)}");
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return Akk(m - 1, Akk(m, n - 1));
    }
}
int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
