// ИТОГОВАЯ КОНТРОЛЬНАЯ РАБОТА ПО ВВОДНОМУ БЛОКУ
// Выполнила студент Дарья Хан
// Дата: 21/01/2024

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Для начала даем возможность пользователю определиться с длиной массива и 
// попросим его ввести целое положительное число от 1 до 10
// Чтобы не утяжелять программу не будем проверять на правильность вводимое число,
// предполагая, что пользователь не ошибается.

Console.WriteLine("Пожалуйста, введите число от 1 до 10 для определения длины массива:");
int myArrayLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введенное вами значения длины массива: {myArrayLength}");

// введем с консоли значения нашего массива

string[] InputStringArray(int arrayLength)
{
    string[] stringArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        Console.Write($"Строка {i + 1}: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

// выведем на печать созданный нами массив

void PrintStringArray(string[] array)
{
     Console.Write("Значения введенного массива:");
     Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Строка {i + 1}: ");
        Console.WriteLine (array[i]);
    }
}
// создаем метод для подсчтета длины каждой строки, каждое значение 
// вносим в массив

 int[] CalculateLengths(string[] stringArray)
 {
    int[] lengths = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            lengths[i] = stringArray[i].Length;
        }
        return lengths;
  }
// пишем метод для вывода на печать длину каждой строки массива

void PrintStringLength(int[] array)
{
     Console.Write("Ваши строки имеют следующее значение длины:");
     Console.WriteLine();
     
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Строка {i + 1}: ");
        Console.WriteLine (array[i]);
    }
}

