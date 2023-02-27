//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(99, 1000);
    }

    return array;
}

int numberEvenNumbers (int[] array)
{
   int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
        result += 1;
        }
    }
    return result;
}

int length = ReadNumber("Введите длину массива: ");

int[] array = GetRandomArray(length);

Console.WriteLine($"[{string.Join(", ", array)}]");

int EvenNumbers = numberEvenNumbers(array);
Console.WriteLine(EvenNumbers);