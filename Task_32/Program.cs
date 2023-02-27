// Задача 32: Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int[] ReverseArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] *= -1 ;
  }
  
  return array; 
}

int length = ReadNumber("Введите длину массива: ");
int leftRange = ReadNumber("Введите левую границу вашего массива: ");
int rightRange = ReadNumber("Введите правую границу вашего массива: ");
int[] array = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"[{string.Join(", ", ReverseArray(array))}]");