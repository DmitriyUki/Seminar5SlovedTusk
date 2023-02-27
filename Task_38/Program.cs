// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}


int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}
(int, int) MaxAndMinElements(int[] array)
{
    int MaxElements = array[0]; 
    int MinElements = array[0]; 

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxElements) 
        {

            MaxElements = array[i];
            
        }

        else if (array[i] < MinElements)
        {

            MinElements = array[i];

        }
    }

    return (MaxElements, MinElements);
}

int length = ReadNumber("Введите длину массива: ");
int leftRange = ReadNumber("Введите левую границу вашего массива: ");
int rightRange = ReadNumber("Введите правую границу вашего массива: ");
int[] array = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");

(int MaxElements, int MinElements) = MaxAndMinElements(array);

//int difference = MaxElements - MinElements;

Console.WriteLine($"Разность максимального и минального элемента массива = {MaxElements - MinElements}");
