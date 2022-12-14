/* Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

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

int SumOfElements(int[] array) //Функция подсчёта суммы элементов массива стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] arr1 = FillArray(10, 1, 200); //Заполняем массив функцией, в которой передаём параметры размера массива, допустим, size = 10, начальное число массива 1, последнее 200
int[] arr2 = FillArray(10, -100, 100); //Заполняем массив функцией, в которой передаём параметры размера массива, допустим, size = 10, начальное число массива -100, последнее 100
Console.WriteLine($"[{string.Join(", ", arr1)}] -> {SumOfElements(arr1)}"); //Выводим на экран с положительными числами, как в примере из задания
Console.WriteLine($"[{string.Join(", ", arr2)}] -> {SumOfElements(arr2)}"); //Выводим на экран с отрицательными числами, как в примере из задания