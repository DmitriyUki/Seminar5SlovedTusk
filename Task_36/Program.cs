// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

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
        array[i] = Random.Shared.Next(1, 10);
    }

    return array;
}
int SumNotEvenElements(int[] array)
{
    int sumNotEven = 0; //сумма элеметов стоящих на нечетных позициях

    for (int i = 1; i < array.Length; i+=2)
    {
        
      sumNotEven = sumNotEven + array[i];
    
    }

    return sumNotEven;
}

int length = ReadNumber("Введите длину массива: ");

int[] array = GetRandomArray(length);

Console.WriteLine($"[{string.Join(", ", array)}]");

int SumNotEven = SumNotEvenElements(array);
Console.WriteLine(SumNotEven);