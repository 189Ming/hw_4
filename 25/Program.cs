// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Initial(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Result(int digit1, int digit2)
{
    int result = 1;
    for (int i = 0; i < digit2; i++)
    {
        result *= digit1;
    }
    return result;
}

int digit1 = Initial("Введите основание: ");
int digit2 = Initial("Введите показатель: ");
Console.WriteLine($"Число {digit1} в степени {digit2} равно {Result(digit1, digit2)}");