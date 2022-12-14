/* Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

int[] FillArray(int size, int lower, int upper) //Функция заполнения массива случайными числами от lower до upper c указанием размера массива size
{
    Random rnd = new Random();
    List<int> list = new List<int>();
    for (int i = 1; i <= size; i++)
    {
        list.Add(rnd.Next(lower, upper + 1));
    }
    return list.ToArray();
}

int CountOfElements(int[] array) //Функция подсчёта количества чётных чисел в массиве
{
    int count = 0; // Переменная count для подсчёта количества чётных чисел в цикле созданного массива arr.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)  // проверяем числа на чётность(кратное 2, без остатка от деления)
        {
            count++;
        }
    }
    return count;
}


int[] arr = FillArray(10, 100, 999); //Заполняем массив функцией, в которой передаём параметры размера массива size = 30, начальное число массива 100, последнее 999
Console.WriteLine($"[{string.Join(", ", arr)}] -> {CountOfElements(arr)}");