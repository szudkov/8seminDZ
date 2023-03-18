
int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");
int size = Numbers("Введите диапазон от 1 до ");

int[,] array = new int[m, n];
NewArray(array);
WriteArray(array);

Console.Write($"Новый массив : ");
Newline(array);
WriteArray(array);

void Newline(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int Numbers(string vvod)
{
  Console.WriteLine(vvod);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

void NewArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(size);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
