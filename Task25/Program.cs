// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInteger(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInteger("Введите число А:");
int numberB = ReadInteger("Введите число B:");


void ToDegree(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"Число {numberA} в степени {numberB} равняется {result}");
}

ToDegree(numberA, numberB);