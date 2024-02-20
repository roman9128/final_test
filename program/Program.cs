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
            Console.Write("Это не подходит. \nПопробуйте ещё раз: ");
        }
    }
}
void PutTo(string[] array) // функция для заполнения массива строками с клавиатуры
{
    Console.WriteLine($"Теперь заполним массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку из {array.Length}: ");
        array[i] = Console.ReadLine()!;
    }
}
void Show(string[] array, int i = 0) // функция для вывода элементов массива с использованием рекурсии
{
    if (array.Length > 0)
    {
        if (i != array.Length)
        {
            Console.Write($"'{array[i]}' ");
            Show(array, i + 1);
        }
    }
    else
    {
        Console.Write("~отсутствуют~");
    }
}
string[] RemoveLongText(string[] arr) // функция для наполнения нового массива строками требуемой длины (3 и менее символов)
{
    string[] result = { };
    int i = 0;
    foreach (string e in arr)
    {
        if (e.Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1); // увеличиваю размер нового массива для подходящего элемента
            result[i] = e;
            i++;
        }
    }
    return result;
}
string[] usertext = new string[MakeSize()];
PutTo(usertext);
Console.Clear();
Console.WriteLine("Итак, Вы ввели следующее:");
Show(usertext);
Console.WriteLine();
string[] shorttext = RemoveLongText(usertext);
Console.WriteLine("Строки с длиной не больше трёх символов:");
Show(shorttext);