Console.Clear();
int MakeSize() // функция для определения размера изначального массива, в которую добавлена проверка вводимых данных; чтобы выйти из неё, нужно ввести натуральное число
{
    Console.Write("Вначале определим размер массива \nВведите натуральное число: ");
    while (true)
    {
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int size))
        {
            if (size > 0)
            {
                return size;
            }
            else
            {
                Console.Write("Хорошо, если в массиве будет хотя бы 1 элемент.\nПопробуйте ещё раз: ");
            }
        }
        else
        {
            Console.Write("Вы ввели что-то, что не является натуральным числом. \nПопробуйте ещё раз: ");
        }
    }
}
void PutTo(string[] array) // функция для заполнения массива строками с клавиатуры
{
    Console.Clear();
    Console.WriteLine($"Теперь заполним массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку из {array.Length}: ");
        array[i] = Console.ReadLine()!;
    }
}
void Show(string[] array, int i = 0) // функция для вывода элементов массива с использованием рекурсии
{
    if (i != array.Length)
    {
        Console.Write($"'{array[i]}' ");
        Show(array, i + 1);
    }
}
string[] RemoveLongText(string[] arr) // функция для наполнения нового массива строками требуемой длины (3 и менее)
{
    string[] result = new string[1];
    int i = 0;
    foreach (string e in arr)
    {
        if (e.Length <= 3)
        {
            result[i] = e;
            i++;
            Array.Resize(ref result, result.Length + 1); // увеличиваю размер нового массива для следующего подходящего элемента
        }
    }
    Array.Resize(ref result, result.Length - 1); // перед выходом из функции удаляю последний пустой элемент массива, созданный ранее, чтобы размер массива был равен числу элементов в нём
    return result;
}
string[] usertext = new string[MakeSize()];
PutTo(usertext);
Console.Clear();
Console.WriteLine("Итак, Вы ввели следующее:");
Show(usertext);
Console.WriteLine();
string[] result = RemoveLongText(usertext);
Console.WriteLine("Введённые Вами строки, длина которых не больше трёх:");
Show(result);