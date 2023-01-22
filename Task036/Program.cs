// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
int sum = 0;

FillArray(numbers);
PrintArray(numbers);

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

Console.WriteLine($"Сумма элементов на нечётных индексах {sum}");

