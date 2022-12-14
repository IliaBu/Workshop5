/* Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

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

int DifferenceOfMaxMinElements(int[] array) //Функция подсчёта разницы между максимальными и минимальными элементами массива
{
    int max = array[0], min = array[0], difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        difference = max - min;
    }
    return difference;
}

int[] arr = FillArray(10, 1, 200); //Заполняем массив функцией, в которой передаём параметры размера массива, допустим, size = 10, начальное число массива 1, последнее 200
Console.WriteLine($"[{string.Join(", ", arr)}] -> {DifferenceOfMaxMinElements(arr)}"); //Выводим на экран