// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// Console.WriteLine($"Укажите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Укажите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);




// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int MainAkermann(int m, int n)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else
//     {
//         if (m == 0)
//         {
//             return MainAkermann(m - 1, 1);
//         }
//         return MainAkermann(m - 1, MainAkermann(m, n - 1));
//     }
// }
// MainAkermann(4, 8);




// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {2, 34, 54, 32, 66, 54};
j = array.Length - 1;
void PrintRevertArray(int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j]);
        return;
    }
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[array.Length - 1 - i];
        numbers[array.Length - 1 - i] = temp;
    }
    Console.Write("Перевернутый массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}
PrintRevertArray();
// по последней задача не понял