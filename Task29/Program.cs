// Задача 29: Напишите программу, в которой пользователь задает длину массива, 
// элементы которого задаются в диапазоне [1,99] и выводит на экран .
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]


Console.WriteLine("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int length, int startPoint, int endPoint)
{
    int[] finalArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        finalArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return finalArray;
}

void PrintArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] currentArray = GetRandomArray(length, 1, 99);
PrintArray(currentArray);




