// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(" ", array));
int unevenPositionNumberSum = unevenPositionSum(array);
Console.WriteLine($"-> {unevenPositionNumberSum}");

// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Возвращает сумму элементов, стоящих на нечётных позициях в массиве arr

int unevenPositionSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sum = sum + arr[i];
    }
    return sum;
}