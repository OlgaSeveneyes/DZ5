//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. 

Console.Clear();
int[] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(" ", array));
int countIvenNumber = IvenNumber(array);

Console.WriteLine($"Количество чётных чисел в массиве {countIvenNumber}");

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

// Возвращает количество чётных чисел в массиве arr

int IvenNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count ++;
    }
    return count;
}