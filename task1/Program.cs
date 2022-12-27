// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите " + (i + 1) + "-й элемент маасива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}
int PositiveNumber(int[] array)
{
    int positiveCounter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) positiveCounter++;
    return positiveCounter;
}

Console.Write("Введите количество элементов массива: ");
int arraySize = int.Parse(Console.ReadLine());

int result = PositiveNumber(Array(arraySize));
Console.WriteLine($"В введенном массиве положительных чисел: {result}");
