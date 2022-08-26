// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int num = NumberFromUser ("Введите количество элементов массива: ","Ошибка ввода!");
double[] array = GetArray(num);
Console.WriteLine(String.Join(" ", array));
double differenceMaxMin = GetDifferenceMaxMin(array);
Console.WriteLine($"-> {differenceMaxMin}");

// возвращает количество элементов массива, либо сообщение об ошибке

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Возвращает массив из size элементов,

double[] GetArray(int size)
{
    double[] res = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = rand.NextDouble() * 100;
    }
    return res;
}

// Возвращает разницу между максимальным и минимальным элементом массива arr

double GetDifferenceMaxMin(double[] arr)
{
    double difference = 0;
    difference = array.Max() - array.Min();
    return difference;
}