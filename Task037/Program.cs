// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int [] FillArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int [] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int [] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {

        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}

int [] initialArray = FillArray(10, 0, 10);
System.Console.WriteLine(String.Join(" ", initialArray));

System.Console.WriteLine(String.Join(" ", ResultArray(initialArray)));

