// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadInteger(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int userNumber = ReadInteger("Введите число: ");

int GetDigitsInNumber(int a)
{
    int index = 0;
    while(a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int number, int count)
{
    int sum = 0;
    for(int i = 1; i <= count; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе{userNumber} составляет {sum}");
}

int result = GetDigitsInNumber(userNumber);
SumNumbers(userNumber, result);

