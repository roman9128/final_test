/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
int MakeSize()
{
    Console.Write("Введите натуральное число: ");
    string input = Console.ReadLine()!;
    while (true)
    {
        int size;
        if (int.TryParse(input, out size))
        {
            if (size > 0)
            {
                return size;
            }
            else
            {
                Console.WriteLine("Вы ввели число, которое не является натуральным. Попробуйте ещё раз: ");
                input = Console.ReadLine()!;
            }
        }
        else
        {
            Console.WriteLine("Вы ввели что-то, что не является натуральным числом. Попробуйте ещё раз. \nВведите натуральное число: ");
            input = Console.ReadLine()!;
        }
    }
}
void PutTo(string[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        array[i] = Console.ReadLine()!;
        i++;
    }
}
void Show(string[] array, int i = 0)
{
    if (i != array.Length)
    {
        Console.Write(array[i] + " ");
        Show(array, i + 1);
    }
}
Console.WriteLine("Вначале определим параметры массива");
string[] text = new string[MakeSize()];
PutTo(text);
Console.Clear();
Console.WriteLine("Вы ввели следующее:");
Show(text);