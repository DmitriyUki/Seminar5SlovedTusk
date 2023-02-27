// Задача 33. Задайте массив. Напишите программу, 
//которая определеяет, присутствует ли данное число в массиве.
//3; массив [6, 7, 19, 345, 3]-> нет

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

// true - findNumber найден в array
//false - findNumber не найден в array
bool IsElementInArray(int[] array, int findNumber)
{

  bool result = false;
  for(int i = 0; i < array.Length; i++)
  {

    if(array[i] == findNumber) 
    {
      result = true;
      break;
    }
    //else писать сюда категорически нельзя, иначе будет перезапись

  }
  return result;

}


int length = ReadNumber("Введите длину массива: ");
int leftRange = ReadNumber("Введите левую границу вашего массива: ");
int rightRange = ReadNumber("Введите правую границу вашего массива: ");
int finding = ReadNumber("Задайте число которое необходимо найти в массиве: ");

int[] array = GetRandomArray(length, leftRange, rightRange);

Console.WriteLine($"[{string.Join(", ", array)}]");

bool res = IsElementInArray(array, finding);
Console.WriteLine(res);