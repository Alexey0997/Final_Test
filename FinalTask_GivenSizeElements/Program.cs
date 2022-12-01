// Написаnь программу, коnорая из имеющегося массива сnрок формируеn массив из сnрок, 
// длина коnорых меньше либо равна 3 символа. Первоначальных массив можно ввесnи с клавиаnуры,
// либо задаnь на сnарnе выполнения алгориnма. 
// При решении не рекомендуеnся пользоваnься коллекциями, лучше обойnись исключиnельно массивами. 
// Примеры:
// [“hello”, “2”, “world”, “:-)”] -> [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] -> [“-2”]
// [“Russia”, “Denmark”, “Kazan”] -> []

// ОСНОВНАЯ ПРОГРАММА
Console.Clear();
Console.Write("Введите количество строк (элементов массива): ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
FillArray(array);                               // Метод № 1 - заполнение массива.
Console.Clear();
Console.WriteLine("Массив, сформированный на основе введенных данных: ");
PrintArray(array);                              // Метод № 2 - вывод массива на печать.

int maxElLength = 3;
int nums = NewArrayLength(array, maxElLength);  // Метод № 3 - определение длины нового массива
string[] newArray = new string[nums];
GetNewArray(array, newArray, maxElLength);      // Метод № 4 - заполнение нового массива.
Console.WriteLine();
Console.WriteLine("Элементы массива, длина которых не превышает трех символов: " );
PrintArray(newArray);                           // Метод № 2 - вывод массива на печать. 

// МЕТОДЫ
// Метод № 1 - заполнение массива данными пользователя.
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine()!;
    }
}

// Метод № 2 - вывод массива на печать.
void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("].");
}

// Метод № 3 - определение длины нового массива.
int NewArrayLength(string[] array, int maxElLength)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {                                                 // Если длина строки не превышает
        if (array[i].Length <= maxElLength) result++; // заданного значения (3), то количество
    }                                                 // элементов нового массива 
    return result;                                    // увеличим на + 1.
}

// Метод № 4 - формирование нового массива.
void GetNewArray(string[] array, string[] newArray, int maxElLength)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= maxElLength)           // Если длина строки проверяемого  
        {                                             // элемента не более 3 символов,  
            newArray[index] = array[i];               // то запишем его в новый массив.
            index++;
        }
    }
}