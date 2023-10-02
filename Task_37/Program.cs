// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GenerateArray(int min, int max, int size)
{
    int[] arr = new int[size];
    var rnd = new Random();

    for(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void PrintArrayDouble(double[] arr)
{
    //Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //double nRound = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    //Console.WriteLine("]");
}


int[] ProductOfNumbers(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size = size + 1;
    int[] arrNew = new int[size];
     
    for (int i = 0; i < size; i++)
    {
        arrNew[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) arrNew[arrNew.Length - 1] = arr[arr.Length / 2];
    return arrNew;
}

int[] array = GenerateArray(1,9,5);
PrintArray(array);

int[] productOfNumbers = ProductOfNumbers(array);
PrintArray(productOfNumbers);


